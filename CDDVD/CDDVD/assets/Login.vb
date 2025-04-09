Public Class Login
    Dim SQL As New Squek
    Dim PerikUser As String
    Public realnama As String
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.CharacterCasing = CharacterCasing.Upper
        TextBox2.CharacterCasing = CharacterCasing.Upper

    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.UseSystemPasswordChar = False
        ElseIf CheckBox1.Checked = False Then
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Function otentikasi() As Boolean
        If SQL.SSet IsNot Nothing Then
            SQL.SSet.Clear()
        End If
        SQL.JalanQuery("Select count(Nama_User) as usercount " &
                       "from staff " &
                       "WHERE Nama_User='" & TextBox1.Text & "' " &
                       "AND Kata_Sandi='" & TextBox2.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS ")
        If SQL.SSet.Tables(0).Rows(0).Item("usercount") = 1 Then
            Return True
        End If
        MsgBox("Kata sandi/user anda salah.", MsgBoxStyle.Critical, "Login Failed")
        Return False
    End Function
    Private Sub namakaryawan()
        SQL.JalanQuery("select * from staff where Nama_User ='" & PerikUser & "'")
        For Each r As DataRow In SQL.STabel.Rows
            realnama = r("Nama_Karyawan")
        Next
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If SQL.PunyaKoneksi = True Then
            If otentikasi() = True Then
                PerikUser = TextBox1.Text
                MsgBox("Login Berhasil, Selamat Datang", vbOKOnly, "Welcome")
                TextBox1.Text = ""
                TextBox2.Text = ""
                Me.Hide()
                ' namakaryawan()
                Form1.Show()
                Form1.ToolStripStatusLabel1.Text = PerikUser
                Form1.usermasuk = PerikUser
            End If
        End If
    End Sub
End Class