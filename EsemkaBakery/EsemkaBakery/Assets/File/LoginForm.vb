Public Class LoginForm
    Private linq As New LinQDataContext
    Public empname As String
    Public empid As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtEmail.Text = "" Or txtPass.Text = "" Then
            MsgBox("Fill all field first!")
        Else
            Dim checkemail = linq.Employees.Where(Function(x) x.Email = txtEmail.Text)
            If checkemail.Count = 0 Then
                MsgBox("Invalid Email")
                Return
            End If
            Dim checkpass = checkemail.FirstOrDefault(Function(x) x.Password = txtPass.Text)
            If IsNothing(checkpass) = True Then
                MsgBox("Invalid Password")
                Return
            End If
            empid = checkpass.EmployeeId
            empname = checkpass.EmployeeName
            txtPass.Clear()
            txtEmail.Clear()
            txtEmail.Select()
            MainForm.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        txtEmail.Text = "joko@gmail.com"
        txtPass.Text = "joko"
        Button1.PerformClick()
    End Sub
End Class