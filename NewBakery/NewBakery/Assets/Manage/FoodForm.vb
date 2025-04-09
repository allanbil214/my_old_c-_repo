Public Class FoodForm
    Private sql As New SquekingDataContext
    Private squek As New Squek
    Private inorup As String = "no"
    Sub loaddata()
        dgv1.DataSource = sql.Foods.Where(Function(x) x.FoodName.ToString.Contains(searchBox.Text) _
                                              Or x.Description.ToString.Contains(searchBox.Text) _
                                              Or x.Price.ToString.Contains(searchBox.Text))
        lblTotalData.Text = "Total Data : " + sql.Foods.Count.ToString
    End Sub
    Private Sub FoodForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        loaddata()
    End Sub
    Sub cleaning()
        txtId.Clear()
        txtName.Clear()
        txtDesc.Clear()
        txtPrice.Clear()
        txtName.Select()
    End Sub
    Sub activateCRUD()
        dgv1.Enabled = False
        TableButtonDown.Enabled = True
        TableButtonUp.Enabled = False
        TableData.Enabled = True
    End Sub
    Sub deactiveCRUD()
        dgv1.Enabled = True
        TableButtonDown.Enabled = False
        TableButtonUp.Enabled = True
        TableData.Enabled = False
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        activateCRUD()
        cleaning()
        txtId.Text = "New"
        inorup = "in"
    End Sub

    Private Sub dgv1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        Dim i As Integer = dgv1.CurrentRow.Index
        txtPrice.Text = dgv1.Item(3, i).Value
        txtId.Text = dgv1.Item(0, i).Value
        txtName.Text = dgv1.Item(1, i).Value
        txtDesc.Text = dgv1.Item(2, i).Value
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtName.Text = "" Then
            MsgBox("Select data first!")
        Else
            activateCRUD()
            inorup = "up"
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        deactiveCRUD()
        cleaning()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtName.Text = "" Then
            MsgBox("select data first!")
        Else
            If MsgBox("Delete?", vbYesNo) = vbYes Then
                Dim newFood As New Food
                newFood = sql.Foods.Single(Function(x) x.FoodId = txtId.Text)
                newFood.Status = "D"
                sql.SubmitChanges()
            End If
        End If
    End Sub
    Sub insertdata()
        Dim newFood As New Food
        newFood.Description = txtDesc.Text
        newFood.Price = txtPrice.Text
        newFood.FoodName = txtName.Text
        newFood.Status = "A"
        sql.Foods.InsertOnSubmit(newFood)
        sql.SubmitChanges()
    End Sub
    Sub updatedata()
        Dim newFood As New Food
        newFood = sql.Foods.Single(Function(x) x.FoodId = txtId.Text)
        newFood.Description = txtDesc.Text
        newFood.Price = txtPrice.Text
        newFood.FoodName = txtName.Text
        newFood.Status = "A"
        sql.SubmitChanges()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtDesc.Text = "" Or txtPrice.Text = "" Or txtId.Text = "" Or txtName.Text = "" Then
            MsgBox("Fill all the field first!")
        Else
            If squek.PhoneFormat(txtPrice.Text) = False Then
                MsgBox("Invalid format!")
            Else
                If inorup = "in" Then
                    insertdata()
                    cleaning()
                    loaddata()
                    deactiveCRUD()
                ElseIf inorup = "up" Then
                    updatedata()
                    cleaning()
                    loaddata()
                    deactiveCRUD()
                End If
            End If
        End If
    End Sub
End Class
