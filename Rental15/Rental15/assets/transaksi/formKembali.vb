Public Class formKembali
    Private sql As New Squek
    Private pinid As Integer
    Private denda As Integer
    Private cdid As Integer
    Private pcdid As Integer
    Sub loaddgv1()
        sql.execquery("select pinjam.id,karyawan.nama as 'Nama Karyawan',pelanggan.Nama as 'Nama Pelanggan',
tglpinjam as'Tanggal Pinjam',tglkembali as 'Tanggal Kembali',TotalHarga,Status
from pinjam
inner join karyawan on kid = karyawan.id
inner join pelanggan on pid = pelanggan.id
where status like '%belum dikembali%' ")
        dgv1.DataSource = sql.dbdt
    End Sub
    Sub loaddgv2()
        sql.addparam("@pinid", pinid)
        sql.execquery("select pinjamcd.ID,cd.Judul,cd.Harga,Qty,Status from PinjamCD
inner join cd on cd.id = cdid
where status like '%belum dikembali%'  and pinid = @pinid")
        dgv2.DataSource = sql.dbdt
        dgv2.Columns(0).Visible = False
        dgv2.Columns(1).Visible = False
    End Sub
    Sub loaddenda()
        sql.execquery("select denda from denda")
        For Each r As DataRow In sql.dbdt.Rows
            denda = r("denda")
        Next
    End Sub
    Private Sub formKembali_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddgv1()
        dgv1.Columns(0).Visible = False
        dtpDikembali.Value = DateTime.Now
    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        Dim i As Integer = dgv1.CurrentRow.Index
        pinid = dgv1.Item(0, i).Value
        txtNamak.Text = dgv1.Item(1, i).Value
        txtNamap.Text = dgv1.Item(2, i).Value
        dtpKembali.Value = dgv1.Item(4, i).Value
        loaddgv2()
    End Sub

    Private Sub dtpPinjam_ValueChanged(sender As Object, e As EventArgs) Handles dtpKembali.ValueChanged
        If dtpDikembali.Value.Date > dtpKembali.Value.Date Then
            Dim totalhari As Integer
            totalhari = DateDiff(DateInterval.Day, dtpKembali.Value.Date, dtpDikembali.Value.Date)
            txtDenda.Text = Val(denda * totalhari)
        End If
    End Sub

    Private Sub dtpDikembali_ValueChanged(sender As Object, e As EventArgs) Handles dtpDikembali.ValueChanged
        If dtpDikembali.Value.Date > dtpKembali.Value.Date Then
            Dim totalhari As Integer
            totalhari = DateDiff(DateInterval.Day, dtpKembali.Value.Date, dtpDikembali.Value.Date)
            txtDenda.Text = Val(denda * totalhari)
        End If
    End Sub

    Private Sub dgv2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv2.CellClick
        Dim i As Integer = dgv2.CurrentRow.Index
        pcdid = dgv2.Item(0, i).Value
        cdid = dgv2.Item(1, i).Value
        txtJudul.Text = dgv2.Item(2, i).Value
        txtTipe.Text = dgv2.Item(3, i).Value
        txtHarga.Text = dgv2.Item(4, i).Value
    End Sub
    Sub insertkembali()
        sql.addparam("@pinid", pinid)
        sql.addparam("@tglkembali", dtpKembali.Value)
        sql.addparam("@tgldikembali", dtpDikembali.Value)
        sql.addparam("@denda", txtDenda.Text)
        sql.execquery("insert into kembali(pinid,tglkembali,tgldikembali,denda) values(@pinid,@tglkembali,@tgldikembali,@denda) ")
        If sql.hascecep(True) Then Exit Sub
    End Sub

    Sub updatestatuspinjam()
        sql.addparam("@id", pinid)
        sql.addparam("@status", "Ada " + dgv2.RowCount.ToString + " jenis buku yang belum dikembalikan")
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class