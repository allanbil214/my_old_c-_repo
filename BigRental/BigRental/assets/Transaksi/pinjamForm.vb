Public Class pinjamForm
    Private sql As New Squek
    Private inorup As String = ""
    Private id As Integer = 0
    Public idkaset As Integer
    Public idpelanggan As Integer
    Public idpegawai As Integer
    Private Sub loaddata()
        sql.execquery("select * from Pinjam")
        dgv1.DataSource = sql.dbdt
    End Sub
    Private Sub disableall()
        Panel2.Enabled = False
        btnBatal.Enabled = False
        btnSimpan.Enabled = False
        btnTambah.Enabled = True
        btnUpdate.Enabled = True
        btnHapus.Enabled = True
    End Sub
    Private Sub enableall()
        Panel2.Enabled = True
        btnBatal.Enabled = True
        btnSimpan.Enabled = True
        btnTambah.Enabled = False
        btnUpdate.Enabled = False
        btnHapus.Enabled = False
    End Sub
    Private Sub kosongan()
        datepinjam.Value = Date.Now
        datekembali.Value = Date.Now.AddDays(7)
        numqty.Value = 0
        txtjudul.Text = ""
        txtpegawai.Text = ""
        txtpelanggan.Text = ""
        idkaset = 0
        idpegawai = 0
        idpelanggan = 0
    End Sub
    Private Sub pegawaiForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
        dgv1.Columns(0).Visible = False
        dgv1.Columns(2).Visible = False
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        inorup = "in"
        enableall()
        kosongan()
        txtpegawai.Text = Form1.namer.Text
        idpegawai = Form1.idnamer
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        inorup = "up"
        enableall()
        kosongan()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        disableall()
        kosongan()
        inorup = ""
    End Sub
    Private Sub insertdata()
        sql.addparam("@id", id)
        sql.addparam("@pinjam", datepinjam.Value)
        sql.addparam("@kembali", datekembali.Value)
        sql.addparam("@qyt", numqty.Value)
        sql.addparam("@itemid", idkaset)
        sql.addparam("@pelangganid", idpelanggan)
        sql.addparam("@pegawaiid", idpegawai)
        sql.execquery("insert into Pinjam(Status,TanggalPinjam,TanggalKembali,Qty,ItemID,PelangganID,PegawaiID) values('Belum Dikembalikan', @pinjam,@kembali,@qyt,@itemid,@pelangganid,@pegawaiid)")
        kosongan()
        MsgBox("Data Berhasil Ditambah", vbOKOnly, "Selamat")
    End Sub
    Private Sub updatedata()
        sql.addparam("@id", id)
        sql.addparam("@pinjam", datepinjam.Value)
        sql.addparam("@kembali", datekembali.Value)
        sql.addparam("@qyt", numqty.Value)
        sql.addparam("@itemid", idkaset)
        sql.addparam("@pelangganid", idpelanggan)
        sql.addparam("@pegawaiid", idpegawai)
        sql.execquery("update Pinjam set TanggalPinjam=@pinjam,TanggalKembali=@kembali,Qty=@qyt,ItemID=@itemid,PelangganID=@pelangganid,PegawaiID=@pegawaiid where id=@id")
        kosongan()
        MsgBox("Data Berhasil Diupdate", vbOKOnly, "Selamat")
    End Sub
    Private Sub hapusdata()
        sql.addparam("@id", id)
        sql.execquery("delete Pinjam where id=@id")
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtjudul.Text = "" Or txtpegawai.Text = "" Or txtpelanggan.Text = "" Or numqty.Value = 0 Then
            MsgBox("Data masih kosong tolong diisi dahulu", vbCritical, "Error")
        Else
            If inorup = "in" Then
                If MsgBox("Apakah anda yakin untuk menambahkan data ini?", vbYesNo, "Peringatan") = MsgBoxResult.Yes Then
                    insertdata()
                    disableall()
                Else
                End If
            ElseIf inorup = "up" Then
                If MsgBox("Apakah anda yakin untuk mengupdate data ini?", vbYesNo, "Peringatan") = MsgBoxResult.Yes Then
                    updatedata()
                    disableall()
                Else
                End If
            End If
        End If
        loaddata()
        id = 0
    End Sub
    Private Sub loadkaset()
        sql.addparam("@id", idkaset)
        sql.execquery("select judul from item where id=@id")
        For Each r As DataRow In sql.dbdt.Rows
            txtjudul.Text = r("judul")
        Next
    End Sub
    Private Sub loadpelanggan()
        sql.addparam("@id", idpelanggan)
        sql.execquery("select nama from pelanggan where id=@id")
        For Each r As DataRow In sql.dbdt.Rows
            txtpelanggan.Text = r("Nama")
        Next
    End Sub
    Private Sub dgv1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        Dim i As Integer
        i = dgv1.CurrentRow.Index
        id = dgv1.Item(0, i).Value
        datepinjam.Value = dgv1.Item(2, i).Value
        datekembali.Value = dgv1.Item(3, i).Value
        numqty.Value = dgv1.Item(4, i).Value
        idkaset = dgv1.Item(5, i).Value
        loadkaset()
        idpelanggan = dgv1.Item(6, i).Value
        loadpelanggan()
        idpegawai = Form1.idnamer
        txtpegawai.Text = Form1.namer.Text
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If id = 0 Then
            MsgBox("Pilih salah satu item yang ingin dihapus", vbCritical, "Error")
        Else
            If MsgBox("Apakah anda ingin menghapus data tersebut?", vbYesNo, "Peringatan") = MsgBoxResult.Yes Then
                hapusdata()
                disableall()
            End If
        End If
        id = 0
        loaddata()
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        sql.addparam("@id", "%" & txtCari.Text & "%")
        sql.execquery("select * from pinjam where nama like @id")
        dgv1.DataSource = sql.dbdt
    End Sub

    Private Sub datepinjam_ValueChanged(sender As Object, e As EventArgs) Handles datepinjam.ValueChanged
        If datepinjam.Value.Date >= datekembali.Value.Date Then
            datekembali.Value = DateTime.Now.AddDays(1)
        End If
    End Sub

    Private Sub datekembali_ValueChanged(sender As Object, e As EventArgs) Handles datekembali.ValueChanged
        If datepinjam.Value.Date >= datekembali.Value.Date Then
            datekembali.Value = DateTime.Now.AddDays(1)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        pelanggancariForm.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        itemcariForm.ShowDialog()
    End Sub
End Class