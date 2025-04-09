Public Class formCD
    Private sql As New Squek
    Private inorup As Integer '1 = in ; 2 = up
    Private tipeid As Integer
    Private id As Integer

    Private Sub formCD_Load(sender As Object, e As EventArgs) Handles Me.Load
        loaddata()
        loadcbtipe()
        dgv1.Columns(0).Visible = False
    End Sub
    Private Sub loadcbtipe()
        cbTipe.Items.Clear()
        sql.execquery("select * from tipecd")
        For Each r As DataRow In sql.dbdt.Rows
            cbTipe.Items.Add(r("Nama"))
            cbTipe.SelectedIndex = 0
        Next
    End Sub
    Private Sub loaddata()
        sql.addparam("@id", "%" & txtCari.Text & "%")
        sql.execquery("select CD.ID,Judul,Tipecd.nama as 'Tipe',Stok,Harga from cd
                       inner join tipecd on tipecd.id = TipeID
                       where judul like @id
					   group by cd.id,cd.judul,tipecd.nama,cd.stok,cd.Harga ")
        dgv1.DataSource = sql.dbdt
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        loaddata()
    End Sub
    Private Sub cleaning()
        txtHarga.Text = ""
        txtJudul.Text = ""
        numStok.Value = 0
    End Sub
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        GroupBox2.Enabled = True
        inorup = 1
        btnSimpan.Enabled = True
        dgv1.Enabled = False
        btnBatal.Enabled = True
        btnTambah.Enabled = False
        btnHapus.Enabled = False
        btnUpdate.Enabled = False
        cleaning()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtHarga.Text = "" Or txtJudul.Text = "" Or numStok.Value = 0 Then
            MsgBox("Pilih salah satu data dulu!", vbCritical, "Peringatan")
        Else
            GroupBox2.Enabled = True
            inorup = 2
            btnSimpan.Enabled = True
            btnBatal.Enabled = True
            btnTambah.Enabled = False
            btnHapus.Enabled = False
            btnUpdate.Enabled = False
            dgv1.Enabled = False
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        GroupBox2.Enabled = False
        inorup = 0
        btnSimpan.Enabled = False
        btnBatal.Enabled = False
        btnHapus.Enabled = True
        btnTambah.Enabled = True
        btnUpdate.Enabled = True
        dgv1.Enabled = True
        cleaning()
    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        Dim i As Integer
        i = dgv1.CurrentRow.Index
        id = dgv1.Item(0, i).Value
        txtJudul.Text = dgv1.Item(1, i).Value
        cbTipe.Text = dgv1.Item(2, i).Value
        numStok.Value = dgv1.Item(3, i).Value
        txtHarga.Text = dgv1.Item(4, i).Value
    End Sub
    Private Sub findtipeid()
        sql.addparam("@id", cbTipe.Text)
        sql.execquery("select id from tipecd where nama=@id")
        For Each r As DataRow In sql.dbdt.Rows
            tipeid = r("id")
        Next
    End Sub
    Private Sub insertdata()
        findtipeid()
        sql.addparam("@judul", txtJudul.Text)
        sql.addparam("@tipe", tipeid)
        sql.addparam("@stok", numStok.Value)
        sql.addparam("@harga", txtHarga.Text)
        sql.execquery("insert into CD(Judul,TipeID,Stok,Harga) values(@judul,@tipe,@stok,@harga)")
        MsgBox("Success")
    End Sub
    Private Sub updatedata()
        findtipeid()
        sql.addparam("@id", id)
        sql.addparam("@judul", txtJudul.Text)
        sql.addparam("@tipe", tipeid)
        sql.addparam("@stok", numStok.Value)
        sql.addparam("@harga", txtHarga.Text)
        sql.execquery("update CD set Judul=@judul,TipeID=@tipe,Stok=@stok,Harga=@harga where id=@id")
        MsgBox("Success")
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If inorup = 1 Then
            If txtHarga.Text = "" Or txtJudul.Text = "" Or numStok.Value = 0 Then
                MsgBox("Data Kosong!", vbCritical, "Peringatan")
            Else
                If IsNumeric(txtHarga.Text) = True Then
                    insertdata()
                    cleaning()
                    loaddata()
                Else
                    MsgBox("Harga harus dalam numeric", vbOKOnly, "Peringatan")
                End If
            End If
        ElseIf inorup = 2 Then
            If IsNumeric(txtHarga.Text) = True Then
                updatedata()
                cleaning()
                loaddata()
                dgv1.Enabled = True
            Else
                MsgBox("Harga harus dalam numeric", vbOKOnly, "Peringatan")
            End If
        End If
        GroupBox2.Enabled = False
        inorup = 0
        btnSimpan.Enabled = False
        btnBatal.Enabled = False
        btnTambah.Enabled = True
        btnHapus.Enabled = True
        btnUpdate.Enabled = True
        dgv1.Enabled = True
        cleaning()
    End Sub
    Private Sub deletedata()
        sql.addparam("@id", id)
        sql.execquery("delete cd where id=@id")
        MsgBox("success")
    End Sub
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtJudul.Text = "" Then
            MsgBox("Pilih dulu datanya!", vbOKOnly, "Peringatan")
        Else
            If MsgBox("Apakah anda yakin untuk menghapus data ini?", vbYesNo, "Peringatan") = vbYes Then
                deletedata()
                cleaning()
                loaddata()
            End If
        End If
    End Sub

    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not Char.IsDigit(e.KeyChar)
        End If
    End Sub

    Private Sub formCD_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        dgv1.Columns(0).Visible = True
    End Sub
End Class