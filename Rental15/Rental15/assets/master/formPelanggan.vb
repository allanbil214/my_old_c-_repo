Public Class formPelanggan
    Private sql As New Squek
    Private pelangganid As Integer
    Private inorup As String = ""
    Sub loaddata()
        sql.addparam("@text", "%" & txtCari.Text & "%")
        sql.execquery("select * from pelanggan where nama like @text")
        dgv1.DataSource = sql.dbdt
    End Sub
    Sub cleaning()
        txtAlamat.Clear()
        txtEmail.Clear()
        txtNama.Clear()
        txtNohp.Clear()
    End Sub
    Sub aktif()
        gbData.Enabled = True
        dgv1.Enabled = False
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = True
        Button5.Enabled = True
    End Sub
    Sub deaktif()
        gbData.Enabled = False
        dgv1.Enabled = True
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = False
        Button5.Enabled = False
    End Sub
    Private Sub formpelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
        cbJeniskelamin.Items.Add("Laki-Laki")
        cbJeniskelamin.Items.Add("Perempuan")
        cbJeniskelamin.Text = "Laki-Laki"
        If dgv1.RowCount > 1 Then
            dgv1.Columns(0).Visible = False
        End If
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        loaddata()
    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        Dim i As Integer = dgv1.CurrentRow.Index
        pelangganid = dgv1.Item(0, i).Value
        txtNama.Text = dgv1.Item(1, i).Value
        txtEmail.Text = dgv1.Item(2, i).Value
        txtNohp.Text = dgv1.Item(3, i).Value
        cbJeniskelamin.Text = dgv1.Item(4, i).Value
        txtAlamat.Text = dgv1.Item(5, i).Value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        inorup = "insert"
        cleaning()
        aktif()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        inorup = "update"
        aktif()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txtNama.Text = "" Then
            MsgBox("pilih dulu")
        Else
            If MsgBox("hapus?", vbYesNo) = vbYes Then
                sql.addparam("@id", pelangganid)
                sql.execquery("delete pelanggan where id=@id")
                If sql.hascecep(True) Then Exit Sub
                MsgBox("terhapus")
                cleaning()
                deaktif()
                loaddata()
            End If
        End If
    End Sub
    Sub insertdata()
        sql.addparam("@id", pelangganid)
        sql.addparam("@nama", txtNama.Text)
        sql.addparam("@email", txtEmail.Text)
        sql.addparam("@nohp", txtNohp.Text)
        sql.addparam("@jenis", cbJeniskelamin.Text)
        sql.addparam("@alamat", txtAlamat.Text)
        sql.execquery("insert into pelanggan(nama,email,nohp,jeniskelamin,alamat) values(@nama,@email,@nohp,@jenis,@alamat) ")
        If sql.hascecep(True) Then Exit Sub
        MsgBox("sukses")
        cleaning()
        deaktif()
        loaddata()
    End Sub
    Sub updatedata()
        sql.addparam("@id", pelangganid)
        sql.addparam("@nama", txtNama.Text)
        sql.addparam("@email", txtEmail.Text)
        sql.addparam("@nohp", txtNohp.Text)
        sql.addparam("@jenis", cbJeniskelamin.Text)
        sql.addparam("@alamat", txtAlamat.Text)
        sql.execquery("update pelanggan set nama=@nama,email=@email,nohp=@nohp,jeniskelamin=@jenis,alamat=@alamat where id=@id ")
        If sql.hascecep(True) Then Exit Sub
        MsgBox("sukses")
        cleaning()
        deaktif()
        loaddata()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If inorup = "insert" Then
            If txtNama.Text = "" Or txtEmail.Text = "" Or txtNohp.Text = "" Or txtAlamat.Text = "" Then
                MsgBox("isi dulu")
            Else
                If sql.isemailformat(txtEmail.Text) = False Then
                    MsgBox("email salah")
                Else
                    insertdata()
                End If
            End If
        ElseIf inorup = "update" Then
            If txtNama.Text = "" Or txtEmail.Text = "" Or txtNohp.Text = "" Or txtAlamat.Text = "" Then
                MsgBox("isi dulu")
            Else
                If sql.isemailformat(txtEmail.Text) = False Then
                    MsgBox("email salah")
                Else
                    updatedata()
                End If
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cleaning()
        deaktif()
    End Sub

    Private Sub txtNohp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNohp.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not Char.IsDigit(e.KeyChar)
        End If
    End Sub

End Class