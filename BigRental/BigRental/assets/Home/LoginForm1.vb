Public Class LoginForm1
    Private sql As New Squek
    Private usercount As Integer
    Private passcount As Integer
    Public namer As String
    Public idnamer As Integer
    Public tingkat As Integer
    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub usercounting()
        sql.addparam("@user", UsernameTextBox.Text)
        sql.execquery("select count(Username) as usercount from Pegawai where Username=@user")
        For Each r As DataRow In sql.dbdt.Rows
            usercount = r("usercount")
        Next
    End Sub
    Private Sub passcounting()
        sql.addparam("@pass", PasswordTextBox.Text)
        sql.execquery("Select count(Password) as passcount from Pegawai where Password=@pass")
        For Each r As DataRow In sql.dbdt.Rows
            passcount = r("passcount")
        Next
    End Sub
    Private Sub findwho()
        sql.addparam("@user", UsernameTextBox.Text)
        sql.execquery("select * from pegawai where username=@user")
        For Each r As DataRow In sql.dbdt.Rows
            namer = r("nama")
            idnamer = r("ID")
            tingkat = r("Tingkat")
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
        If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
            MsgBox("Username/Password kosong, tolong diisi dahulu", vbCritical, "Error")
        Else
            usercounting()
            If usercount = 0 Then
                MsgBox("Username salah, tolong dicek kembali", vbCritical, "Error")
            Else
                passcounting()
                If passcount = 0 Then
                    MsgBox("Password salah, tolong dicek kembali", vbCritical, "Error")
                Else
                    findwho()
                    Me.Hide()
                    Form1.Show()
                    UsernameTextBox.Text = ""
                    PasswordTextBox.Text = ""
                    CheckBox1.Checked = False
                    UsernameTextBox.Select()
                End If
            End If
        End If
    End Sub
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
