Public Class Peminjam
    Dim sql As New Squek
    Dim status As String = "Belum Dikembalikan"
    Public stokquery As Integer
    Dim stoktext As Integer
    Dim totalpinjamquery As Integer
    Dim totalpinjamsettingan As Integer
    Dim ngitungtotal As Integer
    Public totalquery As Integer

    Private Sub loaddata()
        sql.execquery("select * from pinjam")
        dgv1.DataSource = sql.dbdt
    End Sub
    Private Sub lurukode()
        sql.execquery("select coalesce(max(NoPinjam),'0') as highest from Pinjam")
        Dim jumlah As String
        Dim num As Integer = 0
        For Each r As DataRow In sql.dbdt.Rows
            jumlah = r("highest")
            num = jumlah
        Next
        Dim item As Integer = num + 1
        txtpinjam.Text = item.ToString

    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        lurukode()
    End Sub
    Private Sub Peminjam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lurukode()
        loadpegawai()
        loaddata()
        tglpinjam.Value = DateTime.Now
        tglkembali.Value = DateTime.Now.AddDays(7)
        tglawal.Value = DateTime.Now
        tglakhir.Value = DateTime.Now.AddDays(7)
        cbfilter.Items.Add("Pilih Dulu")
        cbfilter.Items.Add("NamaPegawai")
        cbfilter.Items.Add("NamaMember")
        cbfilter.Items.Add("JudulKaset")
        cbfilter.Text = "Pilih Dulu"
        loaddata2()
        loadpinjamsettingan()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CariKaset.ShowDialog()
    End Sub
    Private Sub loadpegawai()
        txtnama.Text = MDIParent1.namauser.Text
        sql.addparam("@nama", txtnama.Text)
        sql.execquery("select kodepegawai from pegawai where namapegawai=@nama")
        For Each r As DataRow In sql.dbdt.Rows
            txtpegawai.Text = r("KodePegawai")
        Next
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        loadpegawai()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cariMember.Show()
    End Sub
    Private Sub insertdatapinjam()
        If txtnama.Text = "" Or txtkode.Text = "" Or txtkaset.Text = "" Then
            MsgBox("Data ada yang belum diisi", vbCritical, "Peringatan")
        Else
            sql.addparam("@pinjam", txtpinjam.Text)
            sql.addparam("@tglpinjam", tglpinjam.Value)
            sql.addparam("@tglkembali", tglkembali.Value)
            sql.addparam("@kaset", txtkaset.Text)
            sql.addparam("@judul", txtjudul.Text)
            sql.addparam("@kodem", txtkode.Text)
            sql.addparam("@member", txtmember.Text)
            sql.addparam("@pegawai", txtpegawai.Text)
            sql.addparam("@nama", txtnama.Text)
            sql.addparam("@status", status)
            sql.execquery("insert into pinjam (Status,TglPinjam,TglKembali,KodeKaset,JudulKaset,KodeMember,NamaMember,KodePegawai,NamaPegawai)" &
                          " values(@status,@tglpinjam,@tglkembali,@kaset,@judul,@kodem,@member,@pegawai,@nama)")
            If sql.adakecuali(True) Then Exit Sub
            MsgBox("Data berhasil dimasukkan", vbOKOnly, "Selamat")
            lurukode()
            tglpinjam.Value = DateTime.Now
            tglkembali.Value = DateTime.Now.AddDays(7)
            txtkaset.Text = ""
            txtjudul.Text = ""
            txtkode.Text = ""
            txtmember.Text = ""
            txtpegawai.Text = ""
            txtnama.Text = ""
            loaddata()
        End If
    End Sub
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        ngitungtotalpinjam()
    End Sub
    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        Dim i As Integer
        i = dgv1.CurrentRow.Index
        txtpinjam.Text = dgv1.Item(0, i).Value
        tglpinjam.Value = dgv1.Item(2, i).Value
        tglkembali.Value = dgv1.Item(3, i).Value
        txtkaset.Text = dgv1.Item(4, i).Value
        txtjudul.Text = dgv1.Item(5, i).Value
        txtkode.Text = dgv1.Item(6, i).Value
        txtmember.Text = dgv1.Item(7, i).Value
        txtpegawai.Text = dgv1.Item(8, i).Value
        txtnama.Text = dgv1.Item(9, i).Value
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs)
        If txtnama.Text = "" Or txtkode.Text = "" Or txtkaset.Text = "" Then
            MsgBox("Data ada yang belum diisi", vbCritical, "Peringatan")
        Else
            sql.addparam("@pinjam", txtpinjam.Text)
            sql.addparam("@tglpinjam", tglpinjam.Value)
            sql.addparam("@tglkembali", tglkembali.Value)
            sql.addparam("@kaset", txtkaset.Text)
            sql.addparam("@judul", txtjudul.Text)
            sql.addparam("@kodem", txtkode.Text)
            sql.addparam("@member", txtmember.Text)
            sql.addparam("@pegawai", txtpegawai.Text)
            sql.addparam("@nama", txtnama.Text)
            sql.addparam("@status", status)
            sql.execquery("update pinjam set Status=@status,TglPinjam=@tglpinjam,TglKembali=@tglkembali,KodeKaset=@kaset,JudulKaset=@judul,KodeMember=@kodem,NamaMember=@member,KodePegawai=@pegawai,NamaPegawai=@nama where NoPinjam=@pinjam")
            If sql.adakecuali(True) Then Exit Sub
            MsgBox("Data berhasil dimasukkan", vbOKOnly, "Selamat")
            lurukode()
            tglpinjam.Value = DateTime.Now
            tglkembali.Value = DateTime.Now.AddDays(7)
            txtkaset.Text = ""
            txtjudul.Text = ""
            txtkode.Text = ""
            txtmember.Text = ""
            txtpegawai.Text = ""
            txtnama.Text = ""
            loaddata()
        End If
    End Sub
    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If MsgBox("Data yang diselek akan dihapus, apakah anda ingin menghapus data ini?", vbYesNo, "Menghapus Data") = MsgBoxResult.Yes Then
            sql.addparam("@kode", txtpinjam.Text)
            sql.execquery("delete pinjam where NoPinjam=@kode")
            If sql.adakecuali(True) Then Exit Sub
            MsgBox("Data berhasil dihapus", vbOKOnly, "Selamat")
            lurukode()
            tglpinjam.Value = DateTime.Now
            tglkembali.Value = DateTime.Now.AddDays(7)
            txtkaset.Text = ""
            txtjudul.Text = ""
            txtkode.Text = ""
            txtmember.Text = ""
            txtpegawai.Text = ""
            txtnama.Text = ""
            loaddata()
        Else

        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        Me.Close()
    End Sub

    Private Sub btnfilter_Click(sender As Object, e As EventArgs) Handles btnfilter.Click
        sql.addparam("@id", "%" & txtfilter.Text & "%")
        sql.execquery("select * from pinjam where " & cbfilter.Text & " like @id order by " & cbfilter.Text & " asc")
        dgv1.DataSource = sql.dbdt
    End Sub

    Private Sub txtlap_Click(sender As Object, e As EventArgs) Handles txtlap.Click
        LaporanPinjam.ShowDialog()
    End Sub
    Private Sub loaddata2()
        sql.addparam("@awal", tglawal.Value.Date)
        sql.addparam("@akhir", tglakhir.Value.Date)
        sql.execquery("select * from pinjam where TglPinjam>=@awal and TglPinjam<=@akhir")
        dgv2.DataSource = sql.dbdt
    End Sub

    Private Sub btntampil_Click(sender As Object, e As EventArgs) Handles btntampil.Click
        loaddata2()
    End Sub
    Private Sub ngitungtotalpinjam()
        Dim totalpinjamm As Integer
        If totalquery >= totalpinjamsettingan Then
            MsgBox("Sudah melewati batas peminjaman", vbCritical, "Kasihan :(")
        Else
            totalpinjamm = Val(totalquery) + 1
            sql.addparam("@stonk", totalpinjamm)
            sql.addparam("@kode", txtkode.Text)
            sql.execquery("Update Member set TotalPinjam=@stonk where KodeMember=@kode")
            stonkmin()
        End If
    End Sub

    Private Sub loadpinjamsettingan()
        sql.execquery("select * from pengaturan")
        For Each r As DataRow In sql.dbdt.Rows
            totalpinjamsettingan = r("TotalPinjam")
        Next
    End Sub
    Private Sub stonkmin()
        Dim stok As Integer
        If stokquery <= 0 Then
            MsgBox("Bukunya sudah tidak ada", vbCritical, "Kasihan :(")
        Else
            stok = Val(stokquery) - 1
            sql.addparam("@stonk", stok)
            sql.addparam("@kode", txtjudul.Text)
            sql.execquery("Update kaset set Stok=@stonk where JudulKaset=@kode")
            insertdatapinjam()
        End If
    End Sub
End Class