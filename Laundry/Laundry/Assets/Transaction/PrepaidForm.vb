Public Class PrepaidForm
    Private sql As New SquekDataContext
    Private custid As Integer
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

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        AddCustomerForm.ShowDialog()
    End Sub
    Sub loaddata()
        dgv1.Rows.Clear()
        For Each r In sql.DetailDeposits.Where(Function(x) x.IdPrepaidPackage.ToString.Contains(TextBox1.Text) And x.IdPrepaidPackage IsNot Nothing)
            For Each l In sql.HeaderDeposits
                dgv1.Rows.Add(r.IdPrepaidPackage, l.Customer.Name, r.PrepaidPackage.Package.Service.Name, r.PriceUnit)
            Next
        Next
    End Sub
    Private Sub PrepaidForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
    End Sub
    Sub pencarian()
        Dim loaddata = dgv1.Rows.Cast(Of DataGridViewRow).Where(Function(x) x.Cells(2).Value.ToString.ToLower.Contains(TextBox1.Text))
        For Each r As DataGridViewRow In dgv1.Rows
            r.Visible = False
        Next
        For Each r As DataGridViewRow In loaddata
            r.Visible = True
        Next
    End Sub
    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        pencarian()
    End Sub
End Class
