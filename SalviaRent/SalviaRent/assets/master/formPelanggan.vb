Public Class formPelanggan
    Private sql As New Squek
    Private gender As String = "Laki-Laki"
    Private inorup As Integer = "1"
    Private id As Integer = 0
    Private Sub loaddata()
        sql.addparam("@id", "%" & txtCari.Text & "%")
        sql.execquery("select * from pelanggan where nama like @id")
        dgv1.DataSource = sql.dbdt
    End Sub
    Private Sub formPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
        dgv1.Columns(0).Visible = False
    End Sub

    Private Sub rbMale_CheckedChanged(sender As Object, e As EventArgs) Handles rbMale.CheckedChanged
        If rbMale.Checked = True Then
            gender = "Laki-Laki"
        Else
            gender = "Perempuan"
        End If
    End Sub
    Private Sub cleaning()
        txtAlamat.Text = ""
        txtEmail.Text = ""
        txtHP.Text = ""
        txtNama.Text = ""
        txtNIK.Text = ""
        numUmur.Value = 1
        rbMale.Checked = True
    End Sub
    Private Sub aktif()
        grupText.Enabled = True
        btnTambah.Enabled = False
        btnUpdate.Enabled = False
        btnHapus.Enabled = False
        btnSimpan.Enabled = True
        btnBatal.Enabled = True
        dgv1.Enabled = False
    End Sub
    Private Sub deaktif()
        grupText.Enabled = False
        btnTambah.Enabled = True
        btnUpdate.Enabled = True
        btnHapus.Enabled = True
        btnSimpan.Enabled = False
        btnBatal.Enabled = False
        dgv1.Enabled = True
    End Sub
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        inorup = 1
        cleaning()
        aktif()
        dgv1.Enabled = False
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtAlamat.Text = "" Then
            MsgBox("Silahkan pilih data dahulu!", vbCritical, "Peringatan")
        Else
            inorup = 2
            aktif()
            dgv1.Enabled = False
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If id = 0 Then
            MsgBox("Silahkan pilih data yang ingin dihapus dulu!", vbCritical, "Peringatan")
        Else
            If MsgBox("Data akan terhapus apakah anda yakin untuk menghapusnya?", vbYesNo, "Peringatan") = vbYes Then
                sql.addparam("@id", id)
                sql.execquery("delete pelanggan where id=@id")
                MsgBox("Data berhasil dihapus", vbOKOnly, "Sukses")
                cleaning()
            End If
        End If
        loaddata()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        cleaning()
        deaktif()
    End Sub
    Private Sub insertdata()
        sql.addparam("@nama", txtNama.Text)
        sql.addparam("@nik", txtNIK.Text)
        sql.addparam("@nohp", txtHP.Text)
        sql.addparam("@email", txtEmail.Text)
        sql.addparam("@alamat", txtAlamat.Text)
        sql.addparam("@gender", gender)
        sql.addparam("@umur", numUmur.Value)
        sql.execquery("insert into pelanggan(Nama,Email,Nik,NoHP,Alamat,JenisKelamin,Umur) values (@nama,@email,@nik,@nohp,@alamat,@gender,@umur)")
        If sql.hasexception(True) Then Exit Sub
        MsgBox("Data berhasil dimasukkan!", vbOKOnly, "Sukses")
    End Sub
    Private Sub updatedata()
        sql.addparam("@id", id)
        sql.addparam("@nama", txtNama.Text)
        sql.addparam("@nik", txtNIK.Text)
        sql.addparam("@email", txtEmail.Text)
        sql.addparam("@nohp", txtHP.Text)
        sql.addparam("@alamat", txtAlamat.Text)
        sql.addparam("@gender", gender)
        sql.addparam("@umur", numUmur.Value)
        sql.execquery("update pelanggan set email=@email,nama=@nama,nik=@nik,nohp=@nohp,alamat=@alamat,JenisKelamin=@gender,Umur=@umur where id=@id")
        If sql.hasexception(True) Then Exit Sub
        MsgBox("Data berhasil diperbarui!", vbOKOnly, "Sukses")
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If inorup = 1 Then
            If txtAlamat.Text = "" Or txtEmail.Text = "" Or txtHP.Text = "" Or txtNama.Text = "" Or txtNIK.Text = "" Or numUmur.Value = 0 Then
                MsgBox("Ada data yang belum diisi!", vbCritical, "Peringatan")
            Else
                If numUmur.Value < 17 Then
                    MsgBox("Belum cukup umur", vbCritical, "Peringatan")
                Else
                    If sql.emailformat(txtEmail.Text) = False Then
                        MsgBox("Format email salah", vbCritical, "Peringatan")
                    Else
                        insertdata()
                        deaktif()
                        cleaning()
                        grupText.Enabled = False
                        dgv1.Enabled = True
                    End If
                End If
            End If
        ElseIf inorup = 2 Then
            If sql.emailformat(txtEmail.Text) = False Then
                MsgBox("Format email salah", vbCritical, "Peringatan")
            Else
                updatedata()
                deaktif()
                cleaning()
                grupText.Enabled = False
                dgv1.Enabled = True
            End If
        End If
        loaddata()
    End Sub

    Private Sub txtHP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHP.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar)
        End If
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        loaddata()
    End Sub

    Private Sub txtNIK_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNIK.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not Char.IsDigit(e.KeyChar)
        End If
    End Sub
    Private Sub changegender()
        If gender = "Laki-Laki" Then
            rbMale.Checked = True
        Else
            rbFemale.Checked = True
        End If
    End Sub
    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        Dim i As Integer
        i = dgv1.CurrentRow.Index
        id = dgv1.Item(0, i).Value
        txtNama.Text = dgv1.Item(1, i).Value
        txtNIK.Text = dgv1.Item(2, i).Value
        txtEmail.Text = dgv1.Item(3, i).Value
        txtHP.Text = dgv1.Item(4, i).Value
        txtAlamat.Text = dgv1.Item(5, i).Value
        gender = dgv1.Item(6, i).Value
        changegender()
        numUmur.Value = dgv1.Item(7, i).Value
    End Sub

    Private Sub formPelanggan_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        dgv1.Columns(0).Visible = True
    End Sub
End Class