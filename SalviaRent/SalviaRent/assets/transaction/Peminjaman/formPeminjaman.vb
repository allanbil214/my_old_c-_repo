Public Class formPeminjaman
    Public cdid As Integer
    Public tipeid As Integer
    Public umuresrb As Integer
    Private subharga As Integer
    Private sql As New Squek
    Private karyawanid As Integer
    Public pelangganid As Integer
    Private realkode As String
    Private statuscount As Integer
    Private pinjamid As Integer
    Private iddelete As Integer
    Public qtycd As Integer
    Public batas As Integer
    Private Sub formPeminjaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv1.Columns.Add("cdid", "CDID") '0
        dgv1.Columns.Add("judul", "Judul") '1
        dgv1.Columns.Add("tipeid", "Tipe ID") '2
        dgv1.Columns.Add("tipe", "Tipe") '3
        dgv1.Columns.Add("qty", "Qty") '4
        dgv1.Columns.Add("harga", "Harga") '5
        dgv1.Columns.Add("sub", "SubHarga") '6
        dgv1.Columns.Add("tglpinjam", "Tanggal Pinjam") '7
        dgv1.Columns.Add("tglkembali", "Tanggal Kembali") '8
        dgv1.Columns.Add("pelangganid", "Pelanggan ID") '9
        dgv1.Columns.Add("namapelanggan", "Nama Pelanggan") '10
        dgv1.Columns.Add("karyawanid", "Karyawan ID") '11
        dgv1.Columns.Add("namakaryawan", "Nama Karyawan") '12
        dgv1.Columns.Add("qtycdasli", "qtycdasli") '13
        dgv1.Columns(0).Visible = False
        dgv1.Columns(2).Visible = False
        dgv1.Columns(9).Visible = False
        dgv1.Columns(11).Visible = False
        dgv1.Columns(13).Visible = False
        dtpPinjam.Value = DateTime.Now
        dtpKembali.Value = DateTime.Now.AddDays(7)
        txtkaryawan.Text = formUtama.nameuser
        karyawanid = formUtama.id
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        formCari.Show()
    End Sub
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        formCari.Show()
    End Sub
    Private Sub totalhargaea()
        Dim totalharga As Integer = 0
        For index As Integer = 0 To dgv1.RowCount - 1
            totalharga += Convert.ToInt32(dgv1.Rows(index).Cells(6).Value)
        Next
        totalprice.Text = totalharga
    End Sub
    Private Sub tambahdatadgv()
        Dim row As DataGridViewRow = Nothing
        For Each item As DataGridViewRow In dgv1.Rows
            If item.Cells.Item("judul").Value = txtJudul.Text Then
                row = item
            End If
        Next
        If Not IsNothing(row) Then
            Dim totalQty As Integer = row.Cells.Item("qty").Value + numqty.Value
            row.Cells.Item("cdid").Value = cdid
            row.Cells.Item("judul").Value = txtJudul.Text
            row.Cells.Item("tipeid").Value = tipeid
            row.Cells.Item("tipe").Value = txtTipe.Text
            row.Cells.Item("qty").Value = totalQty
            row.Cells.Item("harga").Value = txtHarga.Text
            row.Cells.Item("sub").Value = totalQty * txtHarga.Text
            row.Cells.Item("tglpinjam").Value = dtpPinjam.Value
            row.Cells.Item("tglkembali").Value = dtpKembali.Value
            row.Cells.Item("pelangganid").Value = pelangganid
            row.Cells.Item("namapelanggan").Value = txtpelanggan.Text
            row.Cells.Item("karyawanid").Value = txtkaryawan.Text
            row.Cells.Item("namakaryawan").Value = txtkaryawan.Text
            row.Cells.Item("qtycdasli").Value = qtycd
        Else
            Dim newIndex = dgv1.Rows.Add()
            row = dgv1.Rows.Item(newIndex)
            row.Cells.Item("cdid").Value = cdid
            row.Cells.Item("judul").Value = txtJudul.Text
            row.Cells.Item("tipeid").Value = tipeid
            row.Cells.Item("tipe").Value = txtTipe.Text
            row.Cells.Item("qty").Value = numqty.Value
            row.Cells.Item("harga").Value = txtHarga.Text
            row.Cells.Item("sub").Value = numqty.Value * txtHarga.Text
            row.Cells.Item("tglpinjam").Value = dtpPinjam.Value
            row.Cells.Item("tglkembali").Value = dtpKembali.Value
            row.Cells.Item("pelangganid").Value = pelangganid
            row.Cells.Item("namapelanggan").Value = txtpelanggan.Text
            row.Cells.Item("karyawanid").Value = txtkaryawan.Text
            row.Cells.Item("namakaryawan").Value = txtkaryawan.Text
            row.Cells.Item("qtycdasli").Value = qtycd
        End If
    End Sub
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If txtkaryawan.Text = "" Or txtpelanggan.Text = "" Or txtJudul.Text = "" Or txtHarga.Text = "" Or txtTipe.Text = "" Or numqty.Value = 0 Then
            MsgBox("Data belum dimasukkan", vbOKOnly, "Peringatan")
        Else
            If qtycd <= 0 Then
                MsgBox("Tidak ada Stok CD yang tersisa", vbOKOnly, "Peringatan")
            Else
                tambahdatadgv()
                totalhargaea()
                cleaning()
            End If
        End If
    End Sub
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If MsgBox("Apakah anda yakin akan mengapus data tersebut?", vbYesNo, "Peringatan") = vbYes Then
            For Each row As DataGridViewRow In dgv1.SelectedRows
                dgv1.Rows.Remove(row)
            Next
            totalhargaea()
        End If
    End Sub
    Private Sub dtpPinjam_ValueChanged(sender As Object, e As EventArgs) Handles dtpPinjam.ValueChanged
        If dtpPinjam.Value.Date >= dtpKembali.Value.Date Then
            dtpKembali.Value = dtpKembali.Value.AddDays(1)
        End If
    End Sub
    Private Sub dtpKembali_ValueChanged(sender As Object, e As EventArgs) Handles dtpKembali.ValueChanged
        If dtpKembali.Value.Date <= dtpPinjam.Value.Date Then
            dtpKembali.Value = dtpKembali.Value.AddDays(1)
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        formCari2.Show()
    End Sub
    Private Sub findkode()
        Dim kode As String
        Dim kode2 As Integer
        sql.execquery("select coalesce(max(kode),'10') as kode2 from pinjam")
        For Each r As DataRow In sql.dbdt.Rows
            kode = r("kode2")
            kode2 = Val(Mid(kode, 2))
        Next
        Dim m As String = kode2 + 1 + 10
        realkode = "P" + Mid(m, 2).ToString
    End Sub
    Private Sub insertpinjam()
        findkode()
        sql.addparam("@karyawan", karyawanid)
        sql.addparam("@pelanggan", pelangganid)
        sql.addparam("@tglpinjam", dtpPinjam.Value)
        sql.addparam("@tglkembali", dtpKembali.Value)
        sql.addparam("@total", totalprice.Text)
        sql.addparam("@kode", realkode)
        sql.execquery("insert into pinjam (KaryawanID,PelangganID,TglPinjam,TglKembali,HargaTotal,Kode) 
                       values (@karyawan,@pelanggan,@tglpinjam,@tglkembali,@total,@kode) ")
        If sql.hasexception(True) Then Exit Sub
        lurupinjamid()
        insertpinjamcd()
    End Sub
    Private Sub lurupinjamid()
        sql.execquery("select max(id) as id from pinjam")
        For Each r As DataRow In sql.dbdt.Rows
            pinjamid = r("id")
        Next
    End Sub
    Private Sub insertpinjamcd()
        For x As Integer = 0 To dgv1.RowCount - 1
            sql.addparam("@pinjamid", pinjamid)
            sql.addparam("@cdid", dgv1.Rows(x).Cells(0).Value)
            sql.addparam("@qty", dgv1.Rows(x).Cells(4).Value)
            sql.addparam("@harga", dgv1.Rows(x).Cells(5).Value)
            sql.addparam("@status", dgv1.Rows(x).Cells(4).Value.ToString + " CD Belum Dikembalikan".ToString)
            sql.execquery("insert into pinjamcd (PinjamID,CDID,Qty,Harga,Status) values (@pinjamid,@cdid,@qty,@harga,@status)")
            If sql.hasexception(True) Then Exit Sub
        Next
        lurustatus()
    End Sub
    Private Sub lurustatus()
        sql.addparam("@id", pinjamid)
        sql.addparam("@status", "%" & "Belum Dikembalikan" & "%")
        sql.execquery("select count(status) as statuscount from pinjamcd where status like @status and pinjamid=@id")
        For Each r As DataRow In sql.dbdt.Rows
            statuscount = r("statuscount")
        Next
        updatestatus()
    End Sub
    Private Sub updatestatus()
        sql.addparam("@id", pinjamid)
        Dim i As String = "Ada " + statuscount.ToString + " jenis CD yang belum dikembalikan"
        sql.addparam("@status", i)
        sql.execquery("update pinjam set Status=@status where id=@id")
        If sql.hasexception(True) Then Exit Sub
        updateqtycd()
    End Sub
    Private Sub updateqtycd()
        For x As Integer = 0 To dgv1.RowCount - 1
            sql.addparam("@id", dgv1.Rows(x).Cells(0).Value)
            sql.addparam("@qty", Val(dgv1.Rows(x).Cells(13).Value - dgv1.Rows(x).Cells(4).Value))
            sql.execquery("update cd set stok=@qty where id=@id")
            If sql.hasexception(True) Then Exit Sub
        Next
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If dgv1.RowCount = 0 Then
            MsgBox("Tambah dulu bukunya")
        Else
            insertpinjam()
            MsgBox("Data berhasil ditambahkan", vbOKOnly, "Selamat")
            cleaning()
            dgv1.Rows.Clear()
            Button2.Enabled = True
        End If
    End Sub
    Private Sub cleaning()
        txtJudul.Clear()
        txtHarga.Clear()
        txtTipe.Clear()
        numqty.Value = 0
    End Sub
End Class