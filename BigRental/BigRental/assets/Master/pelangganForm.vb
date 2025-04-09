Public Class pelangganForm
    Private sql As New Squek
    Private inorup As String = ""
    Private id As Integer = 0
    Private Sub loaddata()
        sql.execquery("select * from pelanggan")
        dgv1.DataSource = sql.dbdt
    End Sub
    Private Sub disableall()
        txtNama.Enabled = False
        txtNIK.Enabled = False
        txtEmail.Enabled = False
        txtHP.Enabled = False
        numUmur.Enabled = False
        cbKelamin.Enabled = False
        btnBatal.Enabled = False
        btnSimpan.Enabled = False
        btnTambah.Enabled = True
        btnUpdate.Enabled = True
        btnHapus.Enabled = True
    End Sub
    Private Sub enableall()
        txtNama.Enabled = True
        txtNIK.Enabled = True
        txtEmail.Enabled = True
        txtHP.Enabled = True
        numUmur.Enabled = True
        cbKelamin.Enabled = True
        btnBatal.Enabled = True
        btnSimpan.Enabled = True
        btnTambah.Enabled = False
        btnUpdate.Enabled = False
        btnHapus.Enabled = False
    End Sub
    Private Sub kosongan()
        txtNIK.Text = ""
        txtHP.Text = ""
        txtEmail.Text = ""
        txtNama.Text = ""
        numUmur.Value = 0
    End Sub
    Private Sub pelangganForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
        cbKelamin.Items.Add("Laki-Laki")
        cbKelamin.Items.Add("Perempuan")
        cbKelamin.Text = "Laki-Laki"
        dgv1.Columns(0).Visible = False
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        inorup = "in"
        enableall()
        kosongan()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        inorup = "up"
        enableall()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        disableall()
        kosongan()
        inorup = ""
    End Sub
    Private Sub insertdata()
        sql.addparam("@id", id)
        sql.addparam("@nama", txtNama.Text)
        sql.addparam("@nik", txtNIK.Text)
        sql.addparam("@email", txtEmail.Text)
        sql.addparam("@jenis", cbKelamin.Text)
        sql.addparam("@hp", txtHP.Text)
        sql.addparam("@umur", numUmur.Value)
        sql.execquery("insert into pelanggan(Nama,NIK,Email,JenisKelamin,NomorTelepon,Umur) values(@nama,@nik,@email,@jenis,@hp,@umur)")
        kosongan()
        MsgBox("Data Berhasil Ditambah", vbOKOnly, "Selamat")
    End Sub
    Private Sub updatedata()
        sql.addparam("@id", id)
        sql.addparam("@nama", txtNama.Text)
        sql.addparam("@nik", txtNIK.Text)
        sql.addparam("@email", txtEmail.Text)
        sql.addparam("@jenis", cbKelamin.Text)
        sql.addparam("@hp", txtHP.Text)
        sql.addparam("@umur", numUmur.Value)
        sql.execquery("update pelanggan set Nama=@nama,NIK=@nik,Email=@email,JenisKelamin=@jenis,NomorTelepon=@hp,Umur=@umur where id=@id")
        kosongan()
        MsgBox("Data Berhasil Diupdate", vbOKOnly, "Selamat")
    End Sub
    Private Sub hapusdata()
        sql.addparam("@id", id)
        sql.execquery("delete pelanggan where id=@id")
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtHP.Text = "" Or txtEmail.Text = "" Or txtNama.Text = "" Or txtNIK.Text = "" Or numUmur.Value = 0 Then
            MsgBox("Data masih kosong tolong diisi dahulu", vbCritical, "Error")
        Else
            If numUmur.Text < 11 Then
                MsgBox("maaf umur anda kurang cukup untuk meminjam", vbCritical, "Error")
            Else
                If sql.emailformat(txtEmail.Text) = False Then
                    MsgBox("Tidak merupakan email", vbCritical, "Error")
                Else
                    If sql.phoneformat(txtHP.Text) = False Then
                        MsgBox("Harus Numeric", vbCritical, "Error")
                    Else
                        If sql.phoneformat(txtNIK.Text) = False Then
                            MsgBox("Harus Numeric", vbCritical, "Error")
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
        txtNama.Text = dgv1.Item(1, i).Value
        txtNIK.Text = dgv1.Item(2, i).Value
        txtEmail.Text = dgv1.Item(3, i).Value
        cbKelamin.Text = dgv1.Item(4, i).Value
        txtHP.Text = dgv1.Item(5, i).Value
        numUmur.Value = dgv1.Item(6, i).Value
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
        sql.execquery("select * from pelanggan where nama like @id")
        dgv1.DataSource = sql.dbdt
    End Sub

End Class