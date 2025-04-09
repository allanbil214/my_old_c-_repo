Public Class kembaliForm
    Private sql As New Squek
    Private inorup As String = ""
    Private id As Integer = 0
    Public idkaset As Integer
    Public idpelanggan As Integer
    Public idpegawai As Integer
    Private denda As Integer = 500
    Private Sub loaddata()
        sql.execquery("select * from Pinjam")
        dgv1.DataSource = sql.dbdt
    End Sub
    Private Sub kosongan()
        datekembali.Value = Date.Now
        txtDenda.Text = ""
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

        kosongan()
        txtpegawai.Text = Form1.namer.Text
        idpegawai = Form1.idnamer
    End Sub



    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click

        kosongan()
        inorup = ""
    End Sub
    Private Sub insertdata()
        sql.addparam("@id", txtID.Text)
        sql.addparam("@pinjam", datepinjam.Value)
        sql.addparam("@kembali", datekembali.Value)
        sql.addparam("@qyt", txtDenda.Text)
        sql.addparam("@itemid", idkaset)
        sql.addparam("@pelangganid", idpelanggan)
        sql.addparam("@pegawaiid", idpegawai)
        sql.execquery("insert into Kembali(IDPinjam,TanggalPinjam,TanggalKembali,Denda,ItemID,PelangganID,PegawaiID) values(@id, @pinjam,@kembali,@qyt,@itemid,@pelangganid,@pegawaiid)")
        kosongan()
        MsgBox("Data Berhasil Ditambah", vbOKOnly, "Selamat")
    End Sub
    Private Sub updatedatas()
        sql.addparam("@id", txtID.Text)
        sql.execquery("update pinjam set Status = 'Sudah Dikembalikan' where id=@id")
    End Sub
    Private Sub hapusdata()
        sql.addparam("@id", id)
        sql.execquery("delete Pinjam where id=@id")
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
        txtID.Text = dgv1.Item(0, i).Value
        datepinjam.Value = dgv1.Item(2, i).Value
        datekembali.Value = dgv1.Item(3, i).Value
        idkaset = dgv1.Item(5, i).Value
        loadkaset()
        idpelanggan = dgv1.Item(6, i).Value
        loadpelanggan()
        idpegawai = Form1.idnamer
        txtpegawai.Text = Form1.namer.Text
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        sql.addparam("@id", "%" & txtCari.Text & "%")
        sql.execquery("select * from pinjam where nama like @id")
        dgv1.DataSource = sql.dbdt
    End Sub

    Private Sub datepinjam_ValueChanged(sender As Object, e As EventArgs) Handles datepinjam.ValueChanged
        lurudenda()
    End Sub

    Private Sub lurudenda()
        Dim perbandingan As Integer
        perbandingan = DateDiff("d", datepinjam.Value, datekembali.Value)
        If perbandingan < 0 Then
            perbandingan = perbandingan * (-Val(denda))
            txtDenda.Text = perbandingan
        Else
            txtDenda.Text = "0"
        End If
    End Sub
End Class