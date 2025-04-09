Public Class Kaset
    Dim sql As New Squek
    Private Sub loaddata()
        sql.execquery("select * from kaset")
        dgv1.DataSource = sql.dbdt
    End Sub
    Private Sub Kaset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
        lurukode()
        cbjenis.Items.Add("Pilih Dulu")
        cbjenis.Items.Add("Blu-Ray")
        cbjenis.Items.Add("CD")
        cbjenis.Items.Add("DVD")
        cbjenis.Items.Add("HD DVD")
        cbjenis.Text = "Pilih Dulu"
        cbfilter.Items.Add("Pilih Dulu")
        cbfilter.Items.Add("JudulKaset")
        cbfilter.Items.Add("Genre")
        cbfilter.Text = "Pilih Dulu"
    End Sub
    Private Sub lurukode()
        sql.execquery("select coalesce(max(KodeKaset),'0') as highest from kaset")
        Dim jumlah As String
        Dim num As Integer = 0
        For Each r As DataRow In sql.dbdt.Rows
            jumlah = r("highest")
            num = jumlah
        Next
        Dim item As Integer = num + 1
        txtkode.Text = item.ToString
    End Sub
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If txtjudul.Text = "" Or cbjenis.Text = "Pilih Dulu" Or txtgenre.Text = "" Or txtstok.Text = "0" Then
            MsgBox("Data ada yang belum diisi", vbCritical, "Peringatan")
        Else
            sql.addparam("@judul", txtjudul.Text)
            sql.addparam("@jenis", cbjenis.Text)
            sql.addparam("@genre", txtgenre.Text)
            sql.addparam("@stok", txtstok.Value)
            sql.execquery("insert into kaset(JudulKaset,Jenis,Genre,Stok) values(@judul,@jenis,@genre,@stok)")
            If sql.adakecuali(True) Then Exit Sub
            MsgBox("Data berhasil dimasukkan", vbOKOnly, "Selamat")
            txtjudul.Text = ""
            cbjenis.Text = "Pilih Dulu"
            txtgenre.Text = ""
            txtstok.Value = "0"
            loaddata()
        End If

    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        Dim i As Integer
        i = dgv1.CurrentRow.Index
        txtkode.Text = dgv1.Item(0, i).Value
        txtjudul.Text = dgv1.Item(1, i).Value
        cbjenis.Text = dgv1.Item(2, i).Value
        txtgenre.Text = dgv1.Item(3, i).Value
        txtstok.Value = dgv1.Item(4, i).Value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lurukode()
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If txtjudul.Text = "" Or cbjenis.Text = "Pilih Dulu" Or txtgenre.Text = "" Or txtstok.Text = "0" Then
            MsgBox("Data ada yang belum diisi", vbCritical, "Peringatan")
        Else
            sql.addparam("@kode", txtkode.Text)
            sql.addparam("@judul", txtjudul.Text)
            sql.addparam("@jenis", cbjenis.Text)
            sql.addparam("@genre", txtgenre.Text)
            sql.addparam("@stok", txtstok.Value)
            sql.execquery("update kaset set JudulKaset=@judul,Jenis=@jenis,Genre=@genre,Stok=@stok where KodeKaset=@kode")
            If sql.adakecuali(True) Then Exit Sub
            MsgBox("Data berhasil dirubah", vbOKOnly, "Selamat")
            txtjudul.Text = ""
            cbjenis.Text = "Pilih Dulu"
            txtgenre.Text = ""
            txtstok.Value = "0"
            loaddata()
            lurukode()
        End If

    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If MsgBox("Data yang diselek akan dihapus, apakah anda ingin menghapus data ini?", vbYesNo, "Menghapus Data") = MsgBoxResult.Yes Then
            sql.addparam("@kode", txtkode.Text)
            sql.execquery("delete kaset where KodeKaset=@kode")
            If sql.adakecuali(True) Then Exit Sub
            MsgBox("Data berhasil dihapus", vbOKOnly, "Selamat")
            txtjudul.Text = ""
            cbjenis.Text = "Pilih Dulu"
            txtgenre.Text = ""
            txtstok.Value = "0"
            loaddata()
            lurukode()
        Else

        End If
    End Sub
    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        Me.Close()
    End Sub
    Private Sub btnfilter_Click(sender As Object, e As EventArgs) Handles btnfilter.Click
        sql.addparam("@id", "%" & txtfilter.Text & "%")
        sql.execquery("select * from kaset where " & cbfilter.Text & " like @id order by " & cbfilter.Text & " asc")
        dgv1.DataSource = sql.dbdt
    End Sub
End Class