Public Class formLogin
    Private sql As New Squek
    Private usercounted As Integer = 0
    Private passcounted As Integer = 0
    Private empid As Integer = 0
    Private empname As String = ""
    Private emppos As String = ""
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
    Sub usercounting()
        sql.addparam("@user", txtUser.Text)
        sql.execquery("select count(username) as usercount from employee where username=@user")
        For Each r As DataRow In sql.dbdt.Rows
            usercounted = r("usercount")
        Next
    End Sub
    Sub passcounting()
        sql.addparam("@user", txtUser.Text)
        sql.addparam("@pass", txtPass.Text)
        sql.execquery("select count(password) as passcount from employee where username=@user and password=@pass")
        For Each r As DataRow In sql.dbdt.Rows
            passcounted = r("passcount")
        Next
    End Sub
    Sub finddata()
        sql.addparam("@user", txtUser.Text)
        sql.execquery("select * from employee where username=@user")
        For Each r As DataRow In sql.dbdt.Rows
            empid = r("id")
            empname = r("name")
            emppos = r("position")
        Next
    End Sub
    Sub success()
        formMain.empid = empid
        formMain.empname = empname
        formMain.emppos = emppos
        If emppos = "Manager" Then
            formMain.toolLogin.Enabled = False
            formMain.toolLogout.Enabled = True
            formMain.toolMaster.Enabled = True
            formMain.toolTrans.Enabled = True
            formMain.toolHistory.Enabled = True
            formMain.returtool.Enabled = True
            formMain.toolStatus.Text = empname + " (" + emppos + ")"
        ElseIf emppos = "Cashier" Then
            formMain.toolLogin.Enabled = False
            formMain.toolLogout.Enabled = True
            formMain.toolMaster.Enabled = False
            formMain.toolTrans.Enabled = True
            formMain.toolHistory.Enabled = False
            formMain.returtool.Enabled = True
            formMain.toolStatus.Text = empname + " (" + emppos + ")"
        End If
        txtUser.Select()
        txtUser.Clear()
        txtPass.Clear()
        cbPass.Checked = False
        Me.Close()
    End Sub
    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        If txtUser.Text = "" Or txtPass.Text = "" Then
            MsgBox("Username and Password need to be filled first!")
        Else
            usercounting()
            If usercounted = 0 Then
                MsgBox("Username not found")
            Else
                passcounting()
                If passcounted = 0 Then
                    MsgBox("Wrong password")
                Else
                    finddata()
                    success()
                End If
            End If
        End If
    End Sub

    Private Sub cbPass_CheckedChanged(sender As Object, e As EventArgs) Handles cbPass.CheckedChanged
        If cbPass.Checked = True Then
            txtPass.UseSystemPasswordChar = False
        Else
            txtPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub LogoPictureBox_Click(sender As Object, e As EventArgs) Handles LogoPictureBox.Click
        txtUser.Text = "salvia"
        txtPass.Text = "salvia"
    End Sub
End Class
