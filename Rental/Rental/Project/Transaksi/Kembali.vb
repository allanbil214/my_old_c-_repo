Public Class Kembali
    Dim sql As New Squek
    Dim dendanya As New Integer
    Dim status As String
    Dim nopinjam As Integer
    Dim stonk As Integer
    Dim totalquery As Integer
    Private Sub loaddenda()
        sql.execquery("select * from pengaturan")
        For Each r As DataRow In sql.dbdt.Rows
            dendanya = r("Denda")
        Next
    End Sub
    Private Sub loaddata()
        sql.execquery("select * from pinjam where Status='Belum Dikembalikan'")
        dgv1.DataSource = sql.dbdt
    End Sub
    Private Sub lurukode()
        sql.execquery("select coalesce(max(NoKembali),'0') as highest from kembali")
        Dim jumlah As String
        Dim num As Integer = 0
        For Each r As DataRow In sql.dbdt.Rows
            jumlah = r("highest")
            num = jumlah
        Next
        Dim item As Integer = num + 1
        txtnokembali.Text = item.ToString

    End Sub
    Private Sub Kembali_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbfilter.Items.Add("Pilih Dulu")
        cbfilter.Items.Add("NamaPegawai")
        cbfilter.Items.Add("NamaMember")
        cbfilter.Items.Add("JudulKaset")
        cbfilter.Text = "Pilih Dulu"
        status = "Sudah Dikembalikan"
        tgldikembali.Value = DateTime.Now
        loaddata()
        loaddata2()
        loaddenda()
        lurukode()
    End Sub

    Private Sub btnfilter_Click(sender As Object, e As EventArgs) Handles btnfilter.Click
        sql.addparam("@id", "%" & txtfilter.Text & "%")
        sql.execquery("select * from pinjam where " & cbfilter.Text & " like @id and status='Belum Dikembalikan' order by " & cbfilter.Text & " asc")
        dgv1.DataSource = sql.dbdt
    End Sub

    Private Sub btnfilter_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnfilter.KeyPress
        sql.addparam("@id", "%" & txtfilter.Text & "%")
        sql.execquery("select * from pinjam where " & cbfilter.Text & " like @id and status='Belum Dikembalikan' order by " & cbfilter.Text & " asc")
        dgv1.DataSource = sql.dbdt
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        Me.Close()
    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        Dim i As Integer
        i = dgv1.CurrentRow.Index
        nopinjam = dgv1.Item(0, i).Value
        tglkembali.Value = dgv1.Item(3, i).Value
        txtkaset.Text = dgv1.Item(4, i).Value
        txtjudul.Text = dgv1.Item(5, i).Value
        txtkode.Text = dgv1.Item(6, i).Value
        txtmember.Text = dgv1.Item(7, i).Value
        txtpegawai.Text = dgv1.Item(8, i).Value
        txtnama.Text = dgv1.Item(9, i).Value
    End Sub
    Private Sub lurudenda()
        Dim selisih As Integer
        selisih = DateDiff("d", tgldikembali.Value, tglkembali.Value)
        If selisih < 0 Then
            selisih = selisih * (-Val(dendanya))
            txtdenda.Text = selisih
        Else
            txtdenda.Text = "0"
        End If
    End Sub

    Private Sub tgldikembali_ValueChanged(sender As Object, e As EventArgs) Handles tgldikembali.ValueChanged
        lurudenda()
    End Sub
    Private Sub insertdatakembali()
        If txtnama.Text = "" Or txtkode.Text = "" Or txtkaset.Text = "" Then
            MsgBox("Data ada yang belum diisi", vbCritical, "Peringatan")
        Else
            sql.addparam("@pinjam", txtnokembali.Text)
            sql.addparam("@tglkembali", tglkembali.Value)
            sql.addparam("@tgldikembali", tgldikembali.Value)
            sql.addparam("@kaset", txtkaset.Text)
            sql.addparam("@judul", txtjudul.Text)
            sql.addparam("@kodem", txtkode.Text)
            sql.addparam("@member", txtmember.Text)
            sql.addparam("@pegawai", txtpegawai.Text)
            sql.addparam("@nama", txtnama.Text)
            sql.addparam("@denda", txtdenda.Text)
            sql.execquery("insert into kembali (Denda,TglKembali,TglDiKembali,KodeKaset,JudulKaset,KodeMember,NamaMember,KodePegawai,NamaPegawai)" &
                          " values(@denda,@tglkembali,@tgldikembali,@kaset,@judul,@kodem,@member,@pegawai,@nama)")
            If sql.adakecuali(True) Then Exit Sub
        End If
    End Sub
    Private Sub updatestatus()
        sql.addparam("@status", status)
        sql.addparam("@id", nopinjam)
        sql.execquery("Update pinjam set Status='Sudah Dikembalikan' where NoPinjam=@id")
        If sql.adakecuali(True) Then Exit Sub
        insertdatakembali()
        MsgBox("Data berhasil dimasukkan", vbOKOnly, "Selamat")
        lurukode()
        tglkembali.Value = DateTime.Now
        tgldikembali.Value = DateTime.Now
        txtkaset.Text = ""
        txtjudul.Text = ""
        txtkode.Text = ""
        txtmember.Text = ""
        txtpegawai.Text = ""
        txtnama.Text = ""
        txtdenda.Text = ""
        loaddata()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        lurukode()
    End Sub
    Public Sub lurustonk()
        sql.addparam("@kode", txtkaset.Text)
        sql.execquery("Select * from kaset where KodeKaset=@kode")
        For Each r As DataRow In sql.dbdt.Rows
            stonk = r("Stok")
        Next
    End Sub
    Private Sub stonkplus()
        lurustonk()
        Dim stok As Integer
        stok = Val(stonk) + 1
        stonk = stok
        sql.addparam("@stonk", stonk)
        sql.addparam("@kode", txtkaset.Text)
        sql.execquery("Update kaset set Stok=@stonk where KodeKaset=@kode")
        ngitungtotalpinjam()
    End Sub

    Private Sub txtkaset_TextChanged(sender As Object, e As EventArgs) Handles txtkaset.TextChanged
        lurustonk()
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        stonkplus()
    End Sub
    Private Sub loadtotal()
        sql.addparam("@kode", txtkode.Text)
        sql.execquery("Select * from Member where KodeMember=@kode")
        For Each r As DataRow In sql.dbdt.Rows
            totalquery = r("TotalPinjam")
        Next
    End Sub
    Private Sub ngitungtotalpinjam()
        loadtotal()
        Dim total As Integer
        total = Val(totalquery) - 1
        totalquery = total
        sql.addparam("@stonk", totalquery)
        sql.addparam("@kode", txtkode.Text)
        sql.execquery("Update Member set TotalPinjam=@stonk where KodeMember=@kode")
        updatestatus()
    End Sub

    Private Sub txtkode_TextChanged(sender As Object, e As EventArgs) Handles txtkode.TextChanged
        loadtotal()
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
End Class
