Public Class LoginForm
    Public sql As New SquekingDataContext
    Public eid As Integer
    Public ename As String

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtEmail.Text = "" Or txtPass.Text = "" Then
            MsgBox("Fill the empty field first!")
        Else
            Dim emailcheck = sql.Employees.Where(Function(x) x.Email = txtEmail.Text)
            If emailcheck.Count <= 0 Then
                MsgBox("Invalid Email")
                Return
            End If
            Dim passcheck = emailcheck.FirstOrDefault(Function(x) x.Password = txtPass.Text)
            If IsNothing(passcheck) Then
                MsgBox("Invalid Password")
                Return
            End If
            Dim statuscheck = passcheck.Status
            If statuscheck = "D" Then
                MsgBox("Account already deleted!")
                Return
            End If
            eid = passcheck.EmployeeId
            ename = passcheck.EmployeeName
            MainForm.Show()
            txtEmail.Clear()
            txtPass.Clear()
            txtEmail.Select()
            MsgBox("Success")
            Me.Hide()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        txtEmail.Text = "salvia@bigmoney.com"
        txtPass.Text = "salvia"
    End Sub
End Class