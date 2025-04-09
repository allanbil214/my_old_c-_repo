Public Class LoginForm1
    Private sql As New Squek
    Private usercount As Integer
    Private passcount As Integer
    Private Sub usercounting()
        sql.addparam("@user", UsernameTextBox.Text)
        sql.execquery("select count(username) as usercount from karyawan where username=@user")
        For Each r As DataRow In sql.dbdt.Rows
            usercount = r("usercount")
        Next
    End Sub
    Private Sub passcounting()
        sql.addparam("@user", UsernameTextBox.Text)
        sql.addparam("@pass", PasswordTextBox.Text)
        sql.execquery("select count(password) as passcount from karyawan where username=@user and password=@pass")
        For Each r As DataRow In sql.dbdt.Rows
            passcount = r("passcount")
        Next
    End Sub
    Private Sub finduserdata()
        sql.addparam("@user", UsernameTextBox.Text)
        sql.execquery("select * from karyawan where username=@user")
        For Each r As DataRow In sql.dbdt.Rows
            formUtama.id = r("id")
            formUtama.nameuser = r("Nama")
            formUtama.posisi = r("Posisi")
        Next
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            PasswordTextBox.UseSystemPasswordChar = False
        Else
            PasswordTextBox.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        If UsernameTextBox.Text = "" And PasswordTextBox.Text = "" Then
            MsgBox("Isi dulu username dan passwordnya", vbCritical, "Peringatan")
        Else
            usercounting()
            If usercount = 1 Then
                passcounting()
                If passcount = 1 Then
                    finduserdata()
                    If formUtama.posisi = "Kasir" Then
                        formUtama.CDMenu.Enabled = False
                        formUtama.KaryawanMenu.Enabled = False
                        formUtama.MasterMenu.Enabled = True
                        formUtama.TransMenu.Enabled = True
                        formUtama.LoginMenu.Enabled = False
                        formUtama.LogoutMenu.Enabled = True
                        formUtama.AturDendaMenu.Enabled = False
                        formUtama.RiwayatToolStripMenuItem.Enabled = True
                        formUtama.namastatus.Text = formUtama.nameuser
                        UsernameTextBox.Text = ""
                        PasswordTextBox.Text = ""
                        UsernameTextBox.Select()
                        Me.Close()
                    Else
                        formUtama.CDMenu.Enabled = True
                        formUtama.KaryawanMenu.Enabled = True
                        formUtama.MasterMenu.Enabled = True
                        formUtama.TransMenu.Enabled = True
                        formUtama.LoginMenu.Enabled = False
                        formUtama.LogoutMenu.Enabled = True
                        formUtama.AturDendaMenu.Enabled = True
                        formUtama.RiwayatToolStripMenuItem.Enabled = True
                        formUtama.namastatus.Text = formUtama.nameuser
                        UsernameTextBox.Text = ""
                        PasswordTextBox.Text = ""
                        UsernameTextBox.Select()
                        Me.Close()
                    End If
                Else
                        MsgBox("Password anda salah", vbCritical, "Peringatan")
                End If
            Else
                MsgBox("Username anda salah, coba periksa lagi", vbCritical, "Peringatan")
            End If
        End If
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        UsernameTextBox.Text = ""
        PasswordTextBox.Text = ""
        Me.Close()
    End Sub

    Private Sub LogoPictureBox_Click(sender As Object, e As EventArgs) Handles LogoPictureBox.Click
        UsernameTextBox.Text = "salvia"
        PasswordTextBox.Text = "salvia"
    End Sub

End Class
