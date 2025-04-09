Public Class LoginForm
    Private sql As New SQuekDataContext
    Public eid As Integer
    Public ename As String
    Public jobid As Integer
    Sub login()
        Dim email = sql.Employees.Where(Function(x) x.Email = txtEmail.Text)
        If email.Count <= 0 Then
            MsgBox("Please Try Again, Your Email is not Valid!")
            Return
        End If
        Dim password = email.FirstOrDefault(Function(x) x.Password = txtPass.Text)
        If IsNothing(password) Then
            MsgBox("Please Try Again, Your Password is not Valid!")
            Return
        End If
        eid = password.Id
        ename = password.Name
        jobid = password.IdJob
        MsgBox("Welcome " + ename)
        MainForm.Show()
        Me.Hide()
        txtEmail.Clear()
        txtPass.Clear()
        txtEmail.Select()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtEmail.Text = "" Then
            MsgBox("Email must be filled first!")
        ElseIf txtPass.Text = "" Then
            MsgBox("Password must be filled first!")
        Else
            login()
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        txtEmail.Text = "salvia@gmail.com"
        txtPass.Text = "salvia"
        btnLogin.PerformClick()
    End Sub
End Class