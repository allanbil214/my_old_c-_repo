Public Class formPinjam
    Private sql As New Squek
    Public cdid As Integer
    Public stokasli As Integer
    Public pid As Integer
    Public kid As Integer
    Private pinid As Integer

    Private Sub btnCari1_Click(sender As Object, e As EventArgs) Handles btnCari1.Click
        formCari1.ShowDialog()
    End Sub

    Private Sub btnCari2_Click(sender As Object, e As EventArgs) Handles btnCari2.Click
        formCari2.ShowDialog()
    End Sub

    Sub loaddata()
        dgv1.Columns.Add("colcdid", "CDID")
        dgv1.Columns.Add("coljudul", "Judul")
        dgv1.Columns.Add("coltipe", "Tipe")
        dgv1.Columns.Add("colqty", "Qty")
        dgv1.Columns.Add("colharga", "Harga")
        dgv1.Columns.Add("colsubharga", "Sub Harga")
        dgv1.Columns.Add("colpinjam", "Tanggal Peminjaman")
        dgv1.Columns.Add("colkembali", "Tanggal Pengembalian")
        dgv1.Columns.Add("colpid", "PID")
        dgv1.Columns.Add("colnamap", "Nama Pelanggan")
        dgv1.Columns.Add("colkid", "KID")
        dgv1.Columns.Add("colnamak", "Nama Karyawan")
        dgv1.Columns.Add("colstok", "Stok")
    End Sub

    Private Sub formPinjam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
        txtNamak.Text = formMain.txtNama.Text
        kid = formMain.userid
        dgv1.Columns("colcdid").Visible = False
        dgv1.Columns("colstok").Visible = False
        dgv1.Columns("colpid").Visible = False
        dgv1.Columns("colkid").Visible = False
        dtpPinjam.Value = DateTime.Now
        dtpKembali.Value = DateTime.Now.AddDays(7)
    End Sub

    Sub tambahdgv1()
        Dim row As DataGridViewRow = Nothing
        For Each item As DataGridViewRow In dgv1.Rows
            If item.Cells.Item("coljudul").Value = txtJudul.Text Then
                row = item
            End If
        Next
        If Not IsNothing(row) Then
            Dim totalqty As Integer = row.Cells("colqty").Value + numQty.Value
            row.Cells.Item("colcdid").Value = cdid
            row.Cells.Item("coljudul").Value = txtJudul.Text
            row.Cells.Item("coltipe").Value = txtTipe.Text
            row.Cells.Item("colqty").Value = totalqty
            row.Cells.Item("colharga").Value = txtHarga.Text
            row.Cells.Item("colsubharga").Value = Val(totalqty * txtHarga.Text)
            row.Cells.Item("colpinjam").Value = dtpPinjam.Value.Date
            row.Cells.Item("colkembali").Value = dtpKembali.Value.Date
            row.Cells.Item("colpid").Value = pid
            row.Cells.Item("colnamap").Value = txtNamap.Text
            row.Cells.Item("colkid").Value = kid
            row.Cells.Item("colnamak").Value = txtNamak.Text
            row.Cells.Item("colstok").Value = stokasli
        Else
            Dim newindex = dgv1.Rows.Add()
            row = dgv1.Rows.Item(newindex)
            row.Cells.Item("colcdid").Value = cdid
            row.Cells.Item("coljudul").Value = txtJudul.Text
            row.Cells.Item("coltipe").Value = txtTipe.Text
            row.Cells.Item("colqty").Value = numQty.Value
            row.Cells.Item("colharga").Value = txtHarga.Text
            row.Cells.Item("colsubharga").Value = Val(numQty.Value * txtHarga.Text)
            row.Cells.Item("colpinjam").Value = dtpPinjam.Value.Date
            row.Cells.Item("colkembali").Value = dtpKembali.Value.Date
            row.Cells.Item("colpid").Value = pid
            row.Cells.Item("colnamap").Value = txtNamap.Text
            row.Cells.Item("colkid").Value = kid
            row.Cells.Item("colnamak").Value = txtNamak.Text
            row.Cells.Item("colstok").Value = stokasli
        End If
    End Sub
    Sub totalingharga()
        Dim totalharga As Decimal
        For x As Integer = 0 To dgv1.RowCount - 1
            totalharga += dgv1.Rows(x).Cells.Item("colsubharga").Value
        Next
        txtTotal.Text = totalharga
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtJudul.Text = "" Or txtNamap.Text = "" Or txtNamak.Text = "" Then
            MsgBox("isi dulu")
        Else
            tambahdgv1()
            totalingharga()
            txtHarga.Clear()
            txtJudul.Clear()
            txtTipe.Clear()
            numQty.Value = 1
            dtpPinjam.Enabled = False
            dtpKembali.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each x As DataGridViewRow In dgv1.SelectedRows
            dgv1.Rows.Remove(x)
        Next
        If dgv1.RowCount = 0 Then
            dtpPinjam.Enabled = True
            dtpKembali.Enabled = True
        End If
    End Sub

    Sub insertpinjam()
        sql.addparam("@kid", kid)
        sql.addparam("@pid", pid)
        sql.addparam("@tglpinjam", dtpPinjam.Value)
        sql.addparam("@tglkembali", dtpKembali.Value)
        sql.addparam("@totalharga", txtTotal.Text)
        sql.addparam("@status", "Ada " + dgv1.RowCount.ToString + " jenis buku yang belum dikembalikan")
        sql.execquery("insert into pinjam(KID,PID,TglPinjam,TglKembali,TotalHarga,Status) values(@kid,@pid,@tglpinjam,@tglkembali,@totalharga,@status)  ")
        If sql.hascecep(True) Then Exit Sub
        lurupinjamid()
    End Sub
    Sub lurupinjamid()
        sql.execquery("select max(id) as maxid from pinjam")
        For Each r As DataRow In sql.dbdt.Rows
            pinid = r("maxid")
        Next
        insertpinjamcd
    End Sub
    Sub insertpinjamcd()
        For row As Integer = 0 To dgv1.RowCount - 1
            sql.addparam("@pinid", pinid)
            sql.addparam("@cdid", dgv1.Rows(row).Cells.Item("colcdid").Value)
            sql.addparam("@harga", dgv1.Rows(row).Cells.Item("colharga").Value)
            sql.addparam("@qty", dgv1.Rows(row).Cells.Item("colqty").Value)
            sql.addparam("@status", "Ada " + dgv1.Rows(row).Cells.Item("colqty").Value.ToString + " yang masih belum dikembalikan")
            sql.execquery("insert into pinjamcd(pinid,cdid,harga,qty,status) values(@pinid,@cdid,@harga,@qty,@status)  ")
            If sql.hascecep(True) Then Exit Sub
        Next
        Updatestokcd
    End Sub
    Sub updatestokcd()
        For row As Integer = 0 To dgv1.RowCount - 1
            sql.addparam("@cdid", dgv1.Rows(row).Cells.Item("colcdid").Value)
            sql.addparam("@stok", dgv1.Rows(row).Cells.Item("colstok").Value)
            sql.execquery("update cd set stok=@stok where id=@cdid")
        Next
        If sql.hascecep(True) Then
            Exit Sub
        Else
            MsgBox("sukses")
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If dgv1.RowCount < 1 Then
            MsgBox("isi dulu datanya")
        Else
            insertpinjam()
            btnCari2.Enabled = True
            txtHarga.Clear()
            txtJudul.Clear()
            txtNamak.Clear()
            txtNamap.Clear()
            txtTipe.Clear()
            numQty.Value = 1
            txtTotal.Text = "0"
            dtpKembali.Enabled = False
            dtpPinjam.Enabled = False
        End If
    End Sub
End Class