Public Class AddCustomerForm
    Private sql As New SquekDataContext
    Sub insertdata()
        Dim newcustomer As New Customer()
        newcustomer.Name = txtName.Text
        newcustomer.PhoneNumber = txtHP.Text
        newcustomer.Address = txtAddress.Text
        sql.Customers.InsertOnSubmit(newcustomer)
        sql.SubmitChanges()
        MsgBox("Success")
        txtAddress.Clear()
        txtHP.Clear()
        txtName.Clear()
        txtName.Select()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtName.Text = "" Or txtHP.Text = "" Or txtAddress.Text = "" Then
            MsgBox("Fill the data first!")
        Else
            If MainForm.isphoneformat(txtHP.Text) = False Then
                MsgBox("Invalid phone number format")
            Else
                insertdata()
            End If
        End If
    End Sub
End Class