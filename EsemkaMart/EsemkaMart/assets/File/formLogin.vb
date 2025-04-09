Public Class formLogin
    Private sql As New Squek
    Private emailcount As Integer = 0
    Private passcount As Integer = 0
    Private realname As String
    Private position As String
    Private empid As Integer = 0

    Sub emailcounting()
        sql.execquery("select count(email) as emailcount from employee")
        For Each r As DataRow In sql.dbdt.Rows
            emailcount = r("emailcount")
        Next
    End Sub
    Sub passcounting()
        sql.execquery("select count(passwords) as passcount from employee")
        For Each r As DataRow In sql.dbdt.Rows
            passcount = r("passcount")
        Next
    End Sub
    Sub finddata()
        sql.addparam("@email", txtEmail.Text)
        sql.execquery("select * from employee where email=@email")
        For Each r As DataRow In sql.dbdt.Rows
            realname = r("name")
            position = r("position")
            empid = r("EmployeeID")
        Next
    End Sub
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtPass.UseSystemPasswordChar = False
        Else
            txtPass.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        txtEmail.Text = "steven@esemka.com"
        txtPass.Text = "admin"
    End Sub
    Sub succeslog()
        finddata()
        If position = "Manager" Then
            formMain.menuTransaction.Enabled = True
            formMain.menuMaster.Enabled = True
            formMain.menuView.Enabled = True
            formMain.menuLogin.Enabled = False
            formMain.menuLogout.Enabled = True
            formMain.menuPass.Enabled = True
            formMain.namer.Text = realname
            formMain.posisi.Text = position
            formMain.empid = empid
            Me.Close()
        ElseIf position = "Cashier" Then
            formMain.menuTransaction.Enabled = True
            formMain.menuMaster.Enabled = False
            formMain.menuView.Enabled = True
            formMain.menuLogin.Enabled = False
            formMain.menuLogout.Enabled = True
            formMain.menuPass.Enabled = True
            formMain.namer.Text = realname
            formMain.posisi.Text = position
            formMain.empid = empid
            Me.Close()
        End If
        MsgBox("Welcome " + realname)
    End Sub
    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        If txtEmail.Text = "" Or txtPass.Text = "" Then
            MsgBox("Empty!")
        Else
            emailcounting()
            If emailcount = 0 Then
                MsgBox("Wrong Email!")
            Else
                passcounting()
                If passcount = 0 Then
                    MsgBox("Wrong Pass!")
                Else
                    succeslog()
                End If
            End If
        End If
    End Sub

    Private Sub formLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
