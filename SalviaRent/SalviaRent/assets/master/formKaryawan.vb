Public Class formKaryawan
    Private sql As New Squek
    Private id As Integer = 0
    Private isorup As Integer = 0
    Private gender As String = "Laki-Laki"
    Private posisi As String = "Kasir"
    Private Sub loaddata()
        sql.addparam("@id", "%" & txtCari.Text & "%")
        sql.execquery("select * from karyawan where nama like @id")
        dgv1.DataSource = sql.dbdt
    End Sub
    Private Sub formKaryawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
        dgv1.Columns(0).Visible = False
    End Sub
    Private Sub cleaning()
        txtAlamat.Text = ""
        txtEmail.Text = ""
        txtHP.Text = ""
        txtNama.Text = ""
        txtNIK.Text = ""
        txtPassword.Text = ""
        txtUsername.Text = ""
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
    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        loaddata()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        isorup = 1
        cleaning()
        aktif()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtEmail.Text = "" Then
            MsgBox("Silahkan pilih data dahulu!", vbCritical, "Peringatan")
        Else
            isorup = 2
            aktif()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtEmail.Text = "" Then
            MsgBox("Silahkan pilih data yang ingin dihapus", vbCritical, "Peringatan")
        Else
            If MsgBox("Apakah anda yakin ingin menghapus data ini?", vbYesNo, "Peringatan") = vbYes Then
                sql.addparam("@id", id)
                sql.execquery("delete karyawan where id=@id")
                If sql.hasexception(True) Then Exit Sub
                MsgBox("Berhasil menghapus data", vbOKOnly, "Selamat")
                loaddata()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        cleaning()
        deaktif()
        loaddata()
    End Sub
    Private Sub insertdata()
        sql.addparam("@nama", txtNama.Text)
        sql.addparam("@nik", txtNIK.Text)
        sql.addparam("@lahir", dateLahir.Value)
        sql.addparam("@alamat", txtAlamat.Text)
        sql.addparam("@email", txtEmail.Text)
        sql.addparam("@nohp", txtHP.Text)
        sql.addparam("@gender", gender)
        sql.addparam("@posisi", posisi)
        sql.addparam("@username", txtUsername.Text)
        sql.addparam("@pass", txtPassword.Text)
        sql.execquery("insert into karyawan(Nama,NIK,TglLahir,Alamat,Email,NoHP,JenisKelamin,Posisi,Username,Password) 
                       values(@nama,@nik,@lahir,@alamat,@email,@nohp,@gender,@posisi,@username,@pass)")
        If sql.hasexception(True) Then Exit Sub
        MsgBox("Data berhasil dimasukkan", vbOKOnly, "Selamat")
    End Sub
    Private Sub updatedata()
        sql.addparam("@id", id)
        sql.addparam("@nama", txtNama.Text)
        sql.addparam("@nik", txtNIK.Text)
        sql.addparam("@lahir", dateLahir.Value)
        sql.addparam("@alamat", txtAlamat.Text)
        sql.addparam("@email", txtEmail.Text)
        sql.addparam("@nohp", txtHP.Text)
        sql.addparam("@gender", gender)
        sql.addparam("@posisi", posisi)
        sql.addparam("@username", txtUsername.Text)
        sql.addparam("@pass", txtPassword.Text)
        sql.execquery("update karyawan set nama=@nama,nik=@nik,tgllahir=@lahir,alamat=@alamat,email=@email,NoHP=@nohp,JenisKelamin=@gender,
                       Posisi=@posisi,username=@username,password=@pass where id=@id")
        If sql.hasexception(True) Then Exit Sub
        MsgBox("Data berhasil diperbarui", vbOKOnly, "Selamat")
    End Sub
    Private Sub rbM_CheckedChanged(sender As Object, e As EventArgs) Handles rbM.CheckedChanged
        If rbM.Checked = True Then
            gender = "Laki-Laki"
        ElseIf rbF.Checked = True Then
            gender = "Perempuan"
        End If
    End Sub

    Private Sub cbposisi_CheckedChanged(sender As Object, e As EventArgs) Handles cbposisi.CheckedChanged
        If cbposisi.Checked = True Then
            posisi = "Manajer"
        End If
    End Sub
    Private Sub gendering()
        If gender = "Laki-Laki" Then
            rbM.Checked = True
            rbF.Checked = False
        Else
            rbM.Checked = False
            rbF.Checked = True
        End If
    End Sub
    Private Sub posising()
        If posisi = "Manajer" Then
            cbposisi.Checked = True
        Else
            cbposisi.Checked = False
        End If
    End Sub
    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        Dim i As Integer
        i = dgv1.CurrentRow.Index
        id = dgv1.Item(0, i).Value
        txtNama.Text = dgv1.Item(1, i).Value
        txtNIK.Text = dgv1.Item(2, i).Value
        dateLahir.Value = dgv1.Item(3, i).Value
        txtAlamat.Text = dgv1.Item(4, i).Value
        txtEmail.Text = dgv1.Item(5, i).Value
        txtHP.Text = dgv1.Item(6, i).Value
        gender = dgv1.Item(7, i).Value
        gendering()
        posisi = dgv1.Item(8, i).Value
        posising()
        txtUsername.Text = dgv1.Item(9, i).Value
        txtPassword.Text = dgv1.Item(10, i).Value
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If isorup = 1 Then
            If txtAlamat.Text = "" Or txtEmail.Text = "" Or txtHP.Text = "" Or txtNama.Text = "" Or txtNIK.Text = "" Or txtPassword.Text = "" Or txtUsername.Text = "" Then
                MsgBox("Ada data yang belum diisi", vbCritical, "Peringatan")
            Else
                If sql.emailformat(txtEmail.Text) = False Then
                    MsgBox("Format email anda salah!", vbCritical, "Peringatan")
                Else
                    insertdata()
                    deaktif()
                    cleaning()
                End If
            End If
        ElseIf isorup = 2 Then
            If sql.emailformat(txtEmail.Text) = False Then
                MsgBox("Format email anda salah!", vbCritical, "Peringatan")
            Else
                updatedata()
                deaktif()
                cleaning()
            End If
        End If
        loaddata()
    End Sub

    Private Sub txtNIK_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNIK.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not Char.IsNumber(e.KeyChar)
        End If
    End Sub
    Private Sub txtHP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHP.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not Char.IsNumber(e.KeyChar)
        End If
    End Sub

    Private Sub formKaryawan_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        dgv1.Columns(0).Visible = True
    End Sub
End Class