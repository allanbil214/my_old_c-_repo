Public Class formLogin
    Private sql As New Squek
    Private usercount As Integer
    Private passcount As Integer
    Private userid As Integer
    Private usernama As String
    Private userposisi As String
    Sub cleaning()
        txtUser.Clear()
        txtPass.Clear()
        txtUser.Select()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        cleaning()
        Me.Close()
    End Sub
    Sub usercounting()
        sql.addparam("@user", txtUser.Text)
        sql.execquery("select count(username) as usercount from karyawan where username=@user")
        For Each r As DataRow In sql.dbdt.Rows
            usercount = r("usercount")
        Next
    End Sub

    Sub passcounting()
        sql.addparam("@user", txtUser.Text)
        sql.addparam("@pass", txtPass.Text)
        sql.execquery("select count(password) as passcount from karyawan where username=@user and password=@pass")
        For Each r As DataRow In sql.dbdt.Rows
            passcount = r("passcount")
        Next
    End Sub

    Sub finddata()
        sql.addparam("@user", txtUser.Text)
        sql.addparam("@pass", txtPass.Text)
        sql.execquery("select * from karyawan where username=@user")
        For Each r As DataRow In sql.dbdt.Rows
            userid = r("id")
            usernama = r("nama")
            userposisi = r("posisi")
        Next
    End Sub
    Sub posisikasir()
        formMain.menuLogin.Enabled = False
        formMain.menuLogout.Enabled = True
        formMain.menuMaster.Enabled = True
        formMain.menuTransaksi.Enabled = True
        formMain.menuKaryawan.Enabled = False
        formMain.txtNama.Text = usernama
        formMain.usernama = usernama
        formMain.userid = userid
        formMain.userposisi = userposisi
        cleaning()
    End Sub
    Sub posisimanajer()
        formMain.menuLogin.Enabled = False
        formMain.menuLogout.Enabled = True
        formMain.menuMaster.Enabled = True
        formMain.menuTransaksi.Enabled = True
        formMain.menuKaryawan.Enabled = True
        formMain.txtNama.Text = usernama
        formMain.usernama = usernama
        formMain.userid = userid
        formMain.userposisi = userposisi
        cleaning()
    End Sub
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If txtUser.Text = "" Or txtPass.Text = "" Then
            MsgBox("isi dulu")
        Else
            usercounting()
            If usercount = 0 Then
                MsgBox("user salah")
            Else
                passcounting()
                If passcount = 0 Then
                    MsgBox("sandi salah")
                Else
                    finddata()
                    If userposisi = "Manajer" Then
                        posisimanajer()
                        Me.Close()
                    ElseIf userposisi = "Kasir" Then
                        posisikasir()
                        Me.Close()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub LogoPictureBox_Click(sender As Object, e As EventArgs) Handles LogoPictureBox.Click
        txtUser.Text = "salvia"
        txtPass.Text = "salvia"
    End Sub

    Private Sub cbSandi_CheckedChanged(sender As Object, e As EventArgs) Handles cbSandi.CheckedChanged
        If cbSandi.Checked = True Then
            txtPass.UseSystemPasswordChar = False
        Else
            txtPass.UseSystemPasswordChar = True
        End If
    End Sub
End Class
