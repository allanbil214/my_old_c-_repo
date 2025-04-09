Public Class Form1
    Private Sub userLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnuserLogin.Click
        If txtUsername.Text.ToUpper <> "SHALINI" Then
            MessageBox.Show(" showing Error: Username doesn't exists.")
            Exit Sub
        End If
        If txtvalidpassword.Text <> "JUNEJA" Then
            MessageBox.Show("Error: Password doesn't match.")
            Exit Sub
        Else
            MessageBox.Show("Welcome users you are now logged in to the data page.Now you can see all information about data!")
        End If
    End Sub
End Class
