Public Class Form1
    Dim sql As New Squek
    Dim username As String
    Dim password As String
    Dim namauser As String
    Dim namaasli As String
    Public adminkah As Integer
    Private Function otentikasi()
        sql.runquery("select count(Username) as usercount from Pegawai where Username='" & TextBox1.Text & "' and Passwords='" & TextBox2.Text & "' ")
        If sql.dbds.Tables(0).Rows(0).Item("usercount") = 1 Then
            Return True
        End If
        MsgBox("Username/Password yang anda masukkan tidak cocok", vbCritical, "Peringatan")
        Return False
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub lurunamauser()
        sql.addparam("@nama", TextBox1.Text)
        sql.execquery("select * from pegawai where Username=@nama")

    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub lurunama()
        sql.addparam("@user", username)
        sql.execquery("select * from pegawai where Username=@user")
        For Each r As DataRow In sql.dbdt.Rows
            namaasli = r("NamaPegawai")
            adminkah = r("Tipe")
        Next
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If otentikasi() = True Then
            MsgBox("Login berhasil, Selamat Datang", vbOKOnly, "Welcome")
            username = TextBox1.Text
            lurunama()
            MDIParent1.adminkah = adminkah
            MDIParent1.namauser.Text = namaasli
            MDIParent1.Show()
            TextBox1.Text = ""
            TextBox2.Text = ""
            Me.Hide()
        End If
    End Sub
End Class
