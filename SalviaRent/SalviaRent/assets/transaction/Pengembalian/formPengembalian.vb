Public Class formPengembalian
    Private sql As New Squek
    Private pinjamid As Integer
    Private basedenda As Integer
    Private baseqty As Integer
    Private stokcd As Integer
    Private statusqty As Integer
    Private statuspinjamcd As String
    Private statuspinjam As String
    Private cdid As Integer
    Private pinjamcdid As Integer
    Private karyawanid As Integer
    Private Sub loaddenda()
        sql.execquery("select denda from denda")
        For Each r As DataRow In sql.dbdt.Rows
            basedenda = r("Denda")
        Next
    End Sub
    Private Sub loaddgv1()
        sql.execquery("select pinjam.id as 'ID', pinjam.karyawanid,karyawan.Nama,pinjam.pelangganid,pelanggan.Nama,pinjam.tglpinjam as 'Tanggal Pinjam', pinjam.tglkembali as 'Tanggal Kembali', pinjam.Hargatotal as 'Harga Total', pinjam.Kode, Pinjam.Status
                    from Pinjam
                    inner join karyawan on Karyawan.id = pinjam.KaryawanID
                    inner join pelanggan on pelanggan.id = pinjam.pelangganid
                    where not status like '%Sudah Dikembalikan%'")
        dgv1.DataSource = sql.dbdt
        dgv1.Columns(0).Visible = False
        dgv1.Columns(1).Visible = False
        dgv1.Columns(3).Visible = False
    End Sub
    Private Sub loaddgv2()
        sql.addparam("@id", pinjamid)
        sql.addparam("@status", "%" & "Sudah Dikembalikan" & "%")
        sql.execquery("select pinjamcd.id, pinjamcd.pinjamid,pinjamcd.cdid,cd.Judul,pinjamcd.Qty,pinjamcd.Harga,pinjamcd.Status,cd.stok,pinjamcd.qty as 'baseqty'
from pinjamcd
inner join pinjam on pinjam.id = pinjamcd.pinjamid
inner join cd on cd.id = pinjamcd.CDID
where not pinjamcd.status like @status and pinjamcd.pinjamid=@id")
        dgv2.DataSource = sql.dbdt
        dgv2.Columns(0).Visible = False
        dgv2.Columns(1).Visible = False
        dgv2.Columns(2).Visible = False
        dgv2.Columns(7).Visible = False
        dgv2.Columns(8).Visible = False
    End Sub
    Private Sub formPengembalian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddenda()
        loaddgv1()
        dtpDikembali.Value = DateTime.Now
    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        Dim i As Integer
        i = dgv1.CurrentRow.Index
        pinjamid = dgv1.Item(0, i).Value
        karyawanid = dgv1.Item(1, i).Value
        txtpelanggan.Text = dgv1.Item(4, i).Value
        txtkaryawan.Text = dgv1.Item(2, i).Value
        dtpKembali.Value = dgv1.Item(6, i).Value
        loaddgv2()
    End Sub

    Private Sub dgv2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv2.CellClick
        Dim i As Integer
        i = dgv2.CurrentRow.Index
        pinjamcdid = dgv2.Item(0, i).Value
        cdid = dgv2.Item(2, i).Value
        txtJudul.Text = dgv2.Item(3, i).Value
        numqty.Value = dgv2.Item(4, i).Value
        stokcd = dgv2.Item(7, i).Value
        baseqty = dgv2.Item(8, i).Value
    End Sub

    Private Sub dtpDikembali_ValueChanged(sender As Object, e As EventArgs) Handles dtpDikembali.ValueChanged
        If dtpDikembali.Value > dtpKembali.Value Then
            Dim hari As Integer
            hari = DateDiff(DateInterval.Day, dtpDikembali.Value, dtpKembali.Value)
            txtDenda.Text = Val(basedenda * hari)
            txtDenda.Text = txtDenda.Text.Replace("-", "")
        ElseIf dtpDikembali.Value <= dtpKembali.Value Then
            txtDenda.Text = "0"
        End If
    End Sub

    Private Sub dtpKembali_ValueChanged(sender As Object, e As EventArgs) Handles dtpKembali.ValueChanged
        If dtpDikembali.Value > dtpKembali.Value Then
            Dim hari As Integer
            hari = DateDiff(DateInterval.Day, dtpDikembali.Value, dtpKembali.Value)
            txtDenda.Text = Val(basedenda * hari)
            txtDenda.Text = txtDenda.Text.Replace("-", "")
        ElseIf dtpDikembali.Value <= dtpKembali.Value Then
            txtDenda.Text = "0"
        End If
    End Sub
    Private Sub itungpinjamcd()
        Dim hasilqty As Integer = Val(baseqty - numqty.Value)
        If hasilqty < 0 Then
            MsgBox("Error : Qty melebihi qty cd yang ada!", vbCritical, "Peringatan")
        ElseIf hasilqty = 0 Then
            statusqty = 0
            statuspinjamcd = "Sudah Dikembalikan"
            updatepinjamcd()
        ElseIf hasilqty > 0 Then
            statusqty = hasilqty
            statuspinjamcd = statusqty.ToString + " CD belum dikembalikan"
            updatepinjamcd()
        End If
    End Sub
    Private Sub updatepinjamcd()
        sql.addparam("@id", pinjamcdid)
        sql.addparam("@qty", statusqty)
        sql.addparam("@status", statuspinjamcd)
        sql.execquery("update pinjamcd set qty=@qty,status=@status where id=@id")
        If sql.hasexception(True) Then Exit Sub
        updatecdstok()
    End Sub
    Private Sub updatecdstok()
        Dim tambahstok As Integer = Val(stokcd + numqty.Value)
        sql.addparam("@stok", tambahstok)
        sql.addparam("@id", cdid)
        sql.execquery("update cd set stok=@stok where id=@id")
        If sql.hasexception(True) Then Exit Sub
        countpinjamcd()
    End Sub
    Private Sub countpinjamcd()
        sql.addparam("@id", pinjamid)
        sql.execquery("select count(id) as countid from pinjamcd where status like '%belum dikembalikan%' and pinjamid=@id")
        Dim countid As Integer
        For Each r As DataRow In sql.dbdt.Rows
            countid = r("countid")
        Next
        If countid = 0 Then
            statuspinjam = "CD sudah dikembalikan"
        Else
            statuspinjam = "Ada " + countid.ToString + " jenis CD yang belum dikembalikan"
        End If
        updatepinjam()
    End Sub
    Private Sub updatepinjam()
        sql.addparam("@id", pinjamid)
        sql.addparam("@status", statuspinjam)
        sql.execquery("update pinjam set status=@status where id=@id")
        If sql.hasexception(True) Then Exit Sub
        insertkembali()
    End Sub
    Private Sub insertkembali()
        sql.addparam("@id", pinjamid)
        sql.addparam("@karyawanid", karyawanid)
        sql.addparam("@tglkembali", dtpKembali.Value)
        sql.addparam("@tgldikembali", dtpDikembali.Value)
        sql.addparam("@denda", txtDenda.Text)
        sql.execquery("insert into kembali(PinjamID,KaryawanID,TglKembali,TglDikembali,Denda) values(@id,@karyawanid,@tglkembali,@tgldikembali,@denda)")
        If sql.hasexception(True) Then Exit Sub
        MsgBox("Data sudah berhasil dirubah", vbOKOnly, "Selamat")
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtDenda.Text = "" Or txtJudul.Text = "" Or txtkaryawan.Text = "" Or txtpelanggan.Text = "" Then
            MsgBox("Pilih datanya dulu", vbOKOnly, "Peringatan")
        Else
            itungpinjamcd()
            loaddgv1()
            dgv2.DataSource = Nothing
            cleaning()
        End If
    End Sub
    Private Sub cleaning()
        txtDenda.Text = ""
        txtJudul.Text = ""
        txtkaryawan.Text = ""
        txtpelanggan.Text = ""
        numqty.Value = 0
        dtpDikembali.Value = DateTime.Now
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cleaning()
        dgv2.DataSource = Nothing
    End Sub
End Class