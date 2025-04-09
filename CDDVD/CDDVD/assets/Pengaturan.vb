Public Class Pengaturan
    Dim sql As New Squek
    Dim id As Integer = 1

    Private Sub insertdata()
        sql.PlusParam("@toko", TextBox1.Text)
        sql.PlusParam("@id", id)
        sql.PlusParam("@pemilik", TextBox2.Text)
        sql.PlusParam("@telepon", TextBox3.Text)
        sql.PlusParam("@alamat", TextBox4.Text)
        sql.PerintahQuery("update identitas set toko=@toko,kepala=@pemilik,nohp=@telepon,alamat=@alamat where id=@id")
        If sql.AdaKecuali(True) Then Exit Sub
        MsgBox("Data sudah berhasil dirubah", vbOKOnly, "Selamat")
        loadpengaturan()

    End Sub
    Private Sub qqBtnSimpan_Click(sender As Object, e As EventArgs) Handles qqBtnSimpan.Click
        insertdata()
        denda()
        Form1.loadinfo()
    End Sub
    Private Sub denda()
        sql.PlusParam("@id", id)
        sql.PlusParam("@denda", TextBox5.Text)
        sql.PlusParam("@totalpinjam", TextBox6.Text)
        sql.PerintahQuery("update pengaturan set Denda=@denda,Total_Pinjam=@totalpinjam")
        If sql.AdaKecuali(True) Then Exit Sub
        loaddenda()
    End Sub
    Private Sub loadpengaturan()
        sql.PerintahQuery("select * from identitas")
        For Each r As DataRow In sql.STabel.Rows
            TextBox1.Text = (r("toko"))
            TextBox2.Text = (r("kepala"))
            TextBox3.Text = (r("nohp"))
            TextBox4.Text = (r("alamat"))
        Next
    End Sub
    Private Sub loaddenda()
        sql.PerintahQuery("select * from pengaturan")
        For Each r As DataRow In sql.STabel.Rows
            TextBox5.Text = (r("denda"))
            TextBox6.Text = (r("total_pinjam"))
        Next
    End Sub
    Private Sub Pengaturan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadpengaturan()
        loaddenda()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        loadpengaturan()
        loaddenda()
    End Sub
End Class