Public Class InputSellingForm
    Private linq As New LinQDataContext
    Private sql As New Squek
    Private empid As Integer
    Private rawid As Integer
    Private latestid As Integer
    Sub loaddata()
        dgv1.Rows.Clear()
        Dim no As Integer = 1
        For Each r In linq.SellingHeaders
            For Each s In linq.SellingDetails
                dgv1.Rows.Add(no, s.Food.FoodName, s.Price, s.Qty, Val(s.Price * s.Qty))
                no += 1
            Next
        Next
    End Sub
    Sub Cleaning()
        txtQty.Clear()
        dateSelling.Value = Today
        dgv1.ClearSelection()
    End Sub
    Sub loadcbemp()
        sql.ExecQuery("Select * from Food")
        For Each r As DataRow In sql.Dbdt.Rows
            cbFoodName.Items.Add(r("FoodName"))
        Next
    End Sub
    Private Sub InputIncomingRawMaterialForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
        loadcbemp()
    End Sub
    Sub findrawid()
        sql.AddParam("@id", cbFoodName.Text)
        sql.ExecQuery("select * from Food where FoodName=@id")
        For Each r As DataRow In sql.Dbdt.Rows
            empid = r("FoodId")
        Next
    End Sub

    Sub insertheader()
        Dim newIncoming As New SellingHeader
        newIncoming.SellingDate = dateSelling.Value.Date
        newIncoming.Discount = txtDiscount.Text
        newIncoming.EmployeeId = LoginForm.empid
        linq.SellingHeaders.InsertOnSubmit(newIncoming)
    End Sub
    Sub insertdetail()
        Dim newincoming2 As New SellingDetail
        findrawid()
        newincoming2.FoodId = empid
        Dim nganu2 = linq.SellingDetails.Max(Function(x) x.BatchNumber).ToString
        newincoming2.BatchNumber = nganu2
        newincoming2.Qty = txtQty.Text
        newincoming2.Price = txtPrice.Text
        linq.SellingDetails.InsertOnSubmit(newincoming2)
    End Sub
    Sub itung()
        For r As Integer = 0 To dgv1.RowCount - 1
            txtPrice.Text = dgv1.Item(4, r).Value
        Next
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtQty.Text = "" Then
            MsgBox("Fill the field first!")
        Else
            insertheader()
            insertdetail()
            dgv1.Rows.Add(dgv1.RowCount + 1, cbFoodName.Text, txtPrice.Text, txtQty.Text, Val(txtPrice.Text * txtQty.Text))
            Cleaning()
            itung()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        linq.SubmitChanges()
        Cleaning()
        loaddata()
    End Sub
End Class