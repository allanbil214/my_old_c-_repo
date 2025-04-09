Public Class TransactionForm
    Private sql As New SquekDataContext
    Private esttime As Integer
    Private custid As Integer
    Private estimated As DateTime
    Private empid As Integer = LoginForm.eid
    Private servid As Integer
    Private prepaidname As String
    Sub findcustomer()
        'Dim nganu1 = sql.Customers.Where(Function(x) x.PhoneNumber.ToString.Contains(txtPhone.Text))
        'Dim nganu2 = nganu1.FirstOrDefault(Function(x) x.PhoneNumber.ToString.Contains(txtPhone.Text))
        Dim nganu1 = sql.Customers.Where(Function(x) x.PhoneNumber = txtPhone.Text)
        Dim nganu2 = nganu1.FirstOrDefault(Function(x) x.PhoneNumber = txtPhone.Text)
        If IsNothing(nganu2) Then
            Return
        End If
        txtName.Text = nganu2.Name
        txtAddress.Text = nganu2.Address
        custid = nganu2.Id
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtPhone.TextChanged
        findcustomer()
    End Sub

    Private Sub AddCustomer_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AddCustomer.LinkClicked
        AddCustomerForm.ShowDialog()
    End Sub

    Private Sub TransactionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each r In sql.Services
            cbService.Items.Add(r.Name)
            cbService.Text = r.Name
        Next
    End Sub

    Private Sub cbService_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbService.SelectedIndexChanged
        Dim nganu1 = sql.Services.Where(Function(x) x.Name = cbService.Text)
        Dim nganu2 = nganu1.FirstOrDefault(Function(x) x.Name = cbService.Text)
        txtPrice.Text = nganu2.PriceUnit.ToString
        esttime = nganu2.EstimationDuration.ToString
        servid = nganu2.Id
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        datetimeticker.Text = "Current Time : " + Now
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If numTotal.Value <= 0 Then
            MsgBox("Invalid total unit")
        Else
            Dim row As DataGridViewRow = Nothing
            For Each item As DataGridViewRow In dgv1.Rows
                If item.Cells.Item("colService").Value = cbService.Text Then
                    row = item
                End If
            Next
            If Not IsNothing(row) Then
                Dim itung As Integer = row.Cells("colTotal").Value + numTotal.Value
                Dim itungest As Integer = row.Cells("colDuration").Value + esttime
                row.Cells.Item("colService").Value = cbService.Text
                row.Cells.Item("colPrepaid").Value = ""
                row.Cells.Item("colPriceUnit").Value = txtPrice.Text
                row.Cells.Item("colTotal").Value = itung
                row.Cells.Item("colSubtotal").Value = Val(itung * txtPrice.Text)
                row.Cells.Item("colDuration").Value = itungest
            Else
                Dim itung As String = Val(txtPrice.Text * numTotal.Value)
                If cekPrepaid.Checked = True Then
                    prepaidname = cbService.Text + " " + numTotal.Value.ToString
                    Dim newrow As String() = New String() {cbService.Text, prepaidname, txtPrice.Text, numTotal.Value, itung, "Delete", esttime}
                    dgv1.Rows.Add(newrow)
                Else
                    Dim newrow As String() = New String() {cbService.Text, "", txtPrice.Text, numTotal.Value, itung, "Delete", esttime}
                    dgv1.Rows.Add(newrow)
                End If
            End If
            Dim totalsubtotal As Integer
            Dim totalest As Integer
            For x As Integer = 0 To dgv1.RowCount - 1
                totalsubtotal += dgv1.Rows(x).Cells.Item("colsubtotal").Value
                totalest += Val(dgv1.Rows(x).Cells.Item("colDuration").Value)
            Next
            txtTotalPay.Text = "Rp." + totalsubtotal.ToString
            Dim hours As Integer = Val(totalest \ 60)
            Dim minutes As Integer = Val(totalest - (hours * 60))
            Dim timess As String = CType(hours, String) & ":" & CType(minutes, String) & ":" & "00"
            Dim converted = Convert.ToDateTime(timess)
            estimated = converted
            txtEst.Text = Mid(converted, 11).ToString
            numTotal.Value = 0
            cekPrepaid.Checked = False
        End If
    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellContentClick
        If e.ColumnIndex = 5 Then
            Dim row As DataGridViewRow = dgv1.SelectedRows(e.RowIndex)
            dgv1.Rows.Remove(row)
        End If
        If dgv1.RowCount <= 0 Then
            txtTotalPay.Text = "Rp.0"
            txtEst.Text = "00:00:00"
        End If
    End Sub
    Sub insertheader()
        Dim newheader As New HeaderDeposit
        newheader.IdCustomer = custid
        newheader.IdEmployee = empid
        newheader.TransactionDatetime = Today
        newheader.CompleteEstimationDatetime = estimated
        sql.HeaderDeposits.InsertOnSubmit(newheader)
        sql.SubmitChanges()
        insertdetail()
    End Sub

    Sub insertdetail()
        For x As Integer = 0 To dgv1.RowCount - 1
            Dim findidmax = sql.HeaderDeposits.Max(Function(l) l.Id)
            Dim newdetail As New DetailDeposit
            newdetail.IdDeposit = findidmax
            Dim nganu As String = dgv1.Rows(x).Cells.Item("colService").Value.ToString
            Dim findname = sql.Services.Where(Function(z) z.Name = nganu)
            Dim findname2 = findname.FirstOrDefault(Function(s) s.Name = nganu)
            newdetail.IdService = findname2.Id
            newdetail.PriceUnit = dgv1.Rows(x).Cells.Item("colPriceUnit").Value
            newdetail.TotalUnit = dgv1.Rows(x).Cells.Item("colTotal").Value
            sql.DetailDeposits.InsertOnSubmit(newdetail)
            sql.SubmitChanges()
        Next
        updatedetail()
    End Sub
    Sub insertprepaid()
        For x As Integer = 0 To dgv1.RowCount - 1
            Dim newprepaid As New PrepaidPackage
            newprepaid.IdCustomer = custid
            newprepaid.IdPackage = 1
            newprepaid.Price = 75000
        Next
        updatedetail()

    End Sub
    Sub updatedetail()
        For x As Integer = 0 To dgv1.RowCount - 1
            Dim newdetail As New DetailDeposit
            Dim maxidhead = sql.HeaderDeposits.Max(Function(a) a.Id)
            newdetail = sql.DetailDeposits.Where(Function(l) l.IdDeposit = maxidhead)
            If dgv1.Rows(x).Cells.Item(1).Value IsNot Nothing Then
                Dim maxid = sql.PrepaidPackages.Max(Function(z) z.Id)
                newdetail.IdPrepaidPackage = maxid.ToString
                sql.SubmitChanges()
            End If
        Next

        dgv1.Rows.Clear()
        txtAddress.Text = "[Address]"
        txtName.Text = "[Name]"
        txtPhone.Clear()
        numTotal.Value = 0
        MsgBox("Success")
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If dgv1.RowCount <= 0 Then
            MsgBox("Please add some data first")
        Else
            If txtPhone.Text = "" Or txtName.Text = "[Name]" Then
                MsgBox("Select customer first!")
            Else
                insertheader()
            End If
        End If
    End Sub

    Private Sub cekPrepaid_CheckedChanged(sender As Object, e As EventArgs) Handles cekPrepaid.CheckedChanged

    End Sub
End Class
