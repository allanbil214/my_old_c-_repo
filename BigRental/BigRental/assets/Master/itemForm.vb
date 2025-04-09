Public Class itemForm
    Private sql As New Squek
    Private inorup As String = ""
    Private id As Integer = 0
    Private btncell As DataGridViewButtonColumn
    Private Sub loadcb()
        cbEsrb.Items.Add("eC 'Kanak-Kanak'")
        cbEsrb.Items.Add("E 'Semua Orang'")
        cbEsrb.Items.Add("T 'Remaja'")
        cbEsrb.Items.Add("M 'Remaja Dewasa'")
        cbEsrb.Items.Add("Ao 'Dewasa'")
        cbEsrb.Text = "E 'Semua Orang'"
        cbTipe.Items.Add("Blu-Ray")
        cbTipe.Items.Add("CD")
        cbTipe.Items.Add("DVD")
        cbTipe.Text = "Blu-Ray"
    End Sub
    Private Sub loaddata()
        sql.execquery("select * from Item")
        dgv1.DataSource = sql.dbdt
    End Sub
    Private Sub disableall()
        txtHarga.Enabled = False
        txtJudul.Enabled = False
        btnBatal.Enabled = False
        btnSimpan.Enabled = False
        cbEsrb.Enabled = False
        cbTipe.Enabled = False
        numStok.Enabled = False
        btnTambah.Enabled = True
        btnUpdate.Enabled = True
        btnHapus.Enabled = True
    End Sub
    Private Sub enableall()
        txtHarga.Enabled = True
        txtJudul.Enabled = True
        btnBatal.Enabled = True
        btnSimpan.Enabled = True
        cbEsrb.Enabled = True
        cbTipe.Enabled = True
        numStok.Enabled = True
        btnTambah.Enabled = False
        btnUpdate.Enabled = False
        btnHapus.Enabled = False
    End Sub
    Private Sub itemForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadcb()
        loaddata()
        dgv1.Columns(0).Visible = False
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        inorup = "in"
        enableall()
        txtHarga.Text = ""
        txtJudul.Text = ""
        numStok.Value = 0
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        inorup = "up"
        enableall()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        disableall()
        txtJudul.Text = ""
        txtHarga.Text = ""
        numStok.Value = 0
        inorup = ""
    End Sub
    Private Sub insertdata()
        sql.addparam("@judul", txtJudul.Text)
        sql.addparam("@tipe", cbTipe.Text)
        sql.addparam("@stok", numStok.Value)
        sql.addparam("@harga", txtHarga.Text)
        sql.addparam("@esrb", cbEsrb.Text)
        sql.execquery("insert into item(Judul,Tipe,Stok,Harga,ESRB) values(@judul,@tipe,@stok,@harga,@esrb)")
        txtJudul.Text = ""
        txtHarga.Text = ""
        numStok.Value = 0
        MsgBox("Data Berhasil Ditambah", vbOKOnly, "Selamat")
    End Sub
    Private Sub updatedata()
        sql.addparam("@id", id)
        sql.addparam("@judul", txtJudul.Text)
        sql.addparam("@tipe", cbTipe.Text)
        sql.addparam("@stok", numStok.Value)
        sql.addparam("@harga", txtHarga.Text)
        sql.addparam("@esrb", cbEsrb.Text)
        sql.execquery("update item set Judul=@judul,Tipe=@tipe,Stok=@stok,Harga=@harga,ESRB=@esrb where id=@id")
        txtJudul.Text = ""
        txtHarga.Text = ""
        numStok.Value = 0
        MsgBox("Data Berhasil Diupdate", vbOKOnly, "Selamat")
    End Sub
    Private Sub hapusdata()
        sql.addparam("@id", id)
        sql.execquery("delete item where id=@id")
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtHarga.Text = "" Or txtJudul.Text = "" Or numStok.Value = 0 Then
            MsgBox("Data masih kosong tolong diisi dahulu", vbCritical, "Error")
        Else
            If sql.phoneformat(txtHarga.Text) = False Then
                MsgBox("Harus numeric!", vbCritical, "Error")
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
        End If
        loaddata()
        id = 0
    End Sub

    Private Sub dgv1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        Dim i As Integer
        i = dgv1.CurrentRow.Index
        id = dgv1.Item(0, i).Value
        txtJudul.Text = dgv1.Item(1, i).Value
        cbTipe.Text = dgv1.Item(2, i).Value
        numStok.Value = dgv1.Item(3, i).Value
        txtHarga.Text = dgv1.Item(4, i).Value
        cbEsrb.Text = dgv1.Item(5, i).Value
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
        sql.execquery("select * from item where judul like @id")
        dgv1.DataSource = sql.dbdt
    End Sub
End Class