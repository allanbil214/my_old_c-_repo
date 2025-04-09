Public Class LoginForm
    Private sql As New SquekDataContext
    Private msg = ""
    Public karyawanid As Integer
    Function validasi() As Boolean
        Dim result = False
        If UsernameTextBox.Text = "" Then
            msg = "Username harus diisi"
        ElseIf PasswordTextBox.Text = "" Then
            msg = "Password harus diisi"
        Else
            Return True
        End If
        Return result
    End Function
    Sub login()
        If validasi() Then
            Dim username = sql.Karyawans.Where(Function(x) x.Username = UsernameTextBox.Text)
            If username.Count <= 0 Then
                MsgBox("Username tidak ditemukan", vbOKOnly)
                Return
            End If
            Dim password = username.FirstOrDefault(Function(x) x.Password = PasswordTextBox.Text)
            If IsNothing(password) Then
                MsgBox("Password salah", vbOKOnly)
                Return
            End If
            Dim getid = password.KaryawanId
            Dim getname = password.KaryawanNama
            Dim getstatus = password.Status
            karyawanid = getid
            MsgBox("Logged in sebagai " + getname)
            UsernameTextBox.Clear()
            PasswordTextBox.Clear()
            UsernameTextBox.Select()
            MainForm.Show()
            If getstatus = "Manajer" Then
                MainForm.aktifmanajer()
            ElseIf getstatus = "Kasir" Then
                MainForm.aktifkasir()
            End If
            Me.Hide()
        Else
            MsgBox(msg, vbOKOnly, "Peringatan")
        End If
    End Sub

    Private Sub LogoPictureBox_Click(sender As Object, e As EventArgs) Handles LogoPictureBox.Click
        UsernameTextBox.Text = "salvia"
        PasswordTextBox.Text = "salvia"
        OK.PerformClick()
    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        login()
    End Sub

End Class
