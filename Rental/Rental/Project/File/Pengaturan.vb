Public Class Pengaturan
    Dim id As Integer
    Dim sql As New Squek
    Private Sub loadsql()
        sql.execquery("select * from pengaturan")
        For Each r As DataRow In sql.dbdt.Rows
            NumericUpDown2.Text = r("Denda")
            NumericUpDown1.Text = r("TotalPinjam")
            id = r("id")
        Next
    End Sub
    Private Sub Pengaturan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadsql()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sql.addparam("@denda", NumericUpDown2.Text)
        sql.addparam("@total", NumericUpDown1.Text)
        sql.addparam("@id", id)
        sql.execquery("update pengaturan set Denda=@denda,TotalPinjam=@total where id=@id")
        If sql.adakecuali(True) Then Exit Sub
        MsgBox("Selamat data berhasil dirubah", vbOKOnly, "Selamat")
    End Sub
End Class