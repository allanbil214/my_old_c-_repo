Public Class pegawaiForm
    Private sql As New Squek
    Private inorup As String = ""
    Private id As Integer = 0
    Private isadmin As Integer = 0
    Private Sub loaddata()
        sql.execquery("select * from Pegawai")
        dgv1.DataSource = sql.dbdt
    End Sub
    Private Sub disableall()
        txtuser.Enabled = False
        txtpass.Enabled = False
        txtemail.Enabled = False
        txtnama.Enabled = False
        txtalamat.Enabled = False
        datelahir.Enabled = False
        cbadmin.Enabled = False
        cbsandi.Enabled = False
        btnBatal.Enabled = False
        btnSimpan.Enabled = False
        btnTambah.Enabled = True
        btnUpdate.Enabled = True
        btnHapus.Enabled = True
    End Sub
    Private Sub enableall()
        txtuser.Enabled = True
        txtpass.Enabled = True
        txtemail.Enabled = True
        txtnama.Enabled = True
        txtalamat.Enabled = True
        datelahir.Enabled = True
        cbadmin.Enabled = True
        cbsandi.Enabled = True
        btnBatal.Enabled = True
        btnSimpan.Enabled = True
        btnTambah.Enabled = False
        btnUpdate.Enabled = False
        btnHapus.Enabled = False
    End Sub
    Private Sub kosongan()
        txtuser.Text = ""
        txtpass.Text = ""
        txtemail.Text = ""
        txtnama.Text = ""
        txtalamat.Text = ""
        cbadmin.Checked = False
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
        sql.addparam("@user", txtuser.Text)
        sql.addparam("@pass", txtpass.Text)
        sql.addparam("@nama", txtnama.Text)
        sql.addparam("@email", txtemail.Text)
        sql.addparam("@alamat", txtalamat.Text)
        sql.addparam("@date", datelahir.Value)
        If cbadmin.Checked = True Then
            isadmin = 1
        Else
            isadmin = 0
        End If
        sql.addparam("@tingkat", isadmin)
        sql.execquery("insert into pegawai(Username,Password,Nama,Email,Alamat,TanggalLahir,Tingkat) values(@user,@pass,@nama,@email,@alamat,@date,@tingkat)")
        kosongan()
        MsgBox("Data Berhasil Ditambah", vbOKOnly, "Selamat")
    End Sub
    Private Sub updatedata()
        sql.addparam("@id", id)
        sql.addparam("@user", txtuser.Text)
        sql.addparam("@pass", txtpass.Text)
        sql.addparam("@nama", txtnama.Text)
        sql.addparam("@email", txtemail.Text)
        sql.addparam("@alamat", txtalamat.Text)
        sql.addparam("@date", datelahir.Value)
        If cbadmin.Checked = True Then
            isadmin = 1
        Else
            isadmin = 0
        End If
        sql.addparam("@tingkat", isadmin)
        sql.execquery("update pegawai set Username=@user,Password=@pass,Nama=@nama,Email=@email,Alamat=@alamat,TanggalLahir=@date,Tingkat=@tingkat where id=@id")
        kosongan()
        MsgBox("Data Berhasil Diupdate", vbOKOnly, "Selamat")
    End Sub
    Private Sub hapusdata()
        sql.addparam("@id", id)
        sql.execquery("delete pegawai where id=@id")
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtalamat.Text = "" Or txtemail.Text = "" Or txtnama.Text = "" Or txtpass.Text = "" Or txtuser.Text = "" Then
            MsgBox("Data masih kosong tolong diisi dahulu", vbCritical, "Error")
        Else
            If sql.emailformat(txtemail.Text) = False Then
                MsgBox("Tidak merupakan email", vbCritical, "Error")
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
        txtuser.Text = dgv1.Item(1, i).Value
        txtpass.Text = dgv1.Item(2, i).Value
        txtnama.Text = dgv1.Item(3, i).Value
        txtemail.Text = dgv1.Item(4, i).Value
        txtalamat.Text = dgv1.Item(5, i).Value
        datelahir.Value = dgv1.Item(6, i).Value
        isadmin = dgv1.Item(7, i).Value
        If isadmin = 1 Then
            cbadmin.Checked = True
        Else
            cbadmin.Checked = False
        End If
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
        sql.execquery("select * from pegawai where nama like @id")
        dgv1.DataSource = sql.dbdt
    End Sub

    Private Sub cbsandi_CheckedChanged(sender As Object, e As EventArgs) Handles cbsandi.CheckedChanged
        If cbsandi.Checked = True Then
            txtpass.UseSystemPasswordChar = False
        Else
            txtpass.UseSystemPasswordChar = True
        End If
    End Sub
End Class