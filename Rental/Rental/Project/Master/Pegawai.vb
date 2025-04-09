Public Class Pegawai
    Dim sql As New Squek
    Dim isadmin As Integer = 0
    Dim editadmin As Integer = 0
    Private Sub loaddata()
        sql.execquery("select * from Pegawai where not username='ADMIN'")
        dgv1.DataSource = sql.dbdt
    End Sub
    Private Sub lurukode()
        sql.execquery("select coalesce(max(KodePegawai),'0') as highest from Pegawai")
        Dim jumlah As String
        Dim num As Integer = 0
        For Each r As DataRow In sql.dbdt.Rows
            jumlah = r("highest")
            num = jumlah
        Next
        Dim item As Integer = num + 1
        txtkode.Text = item.ToString
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        lurukode()
    End Sub

    Private Sub Pegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
        lurukode()
        cbfilter.Items.Add("Pilih Dulu")
        cbfilter.Items.Add("NamaPegawai")
        cbfilter.Items.Add("NoTelp")
        cbfilter.Items.Add("KodePegawai")
        cbfilter.Text = "NamaPegawai"
    End Sub
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If txtnama.Text = "" Or txttelp.Text = "" Or txtalamat.Text = "" Or txtuser.Text = "" Or txtpass.Text = "" Then
            MsgBox("Data ada yang belum diisi", vbCritical, "Peringatan")
        Else
            sql.addparam("@kode", txtkode.Text)
            sql.addparam("@nama", txtnama.Text)
            sql.addparam("@notelp", txttelp.Text)
            sql.addparam("@isadmin", isadmin)
            sql.addparam("@alamat", txtalamat.Text)
            sql.addparam("@user", txtuser.Text)
            sql.addparam("@pass", txtpass.Text)
            sql.execquery("insert into pegawai(TotalPinjam,NamaPegawai,NoTelp,Alamat,Tipe,Username,Passwords) values('0',@nama,@notelp,@alamat,@isadmin,@user,@pass)")
            If sql.adakecuali(True) Then Exit Sub
            MsgBox("Data berhasil dimasukkan", vbOKOnly, "Selamat")
            lurukode()
            txtnama.Text = ""
            txttelp.Text = ""
            cbadmin.Checked = False
            txtalamat.Text = ""
            txtuser.Text = ""
            txtpass.Text = ""
            loaddata()
        End If
    End Sub

    Private Sub cbadmin_CheckedChanged(sender As Object, e As EventArgs) Handles cbadmin.CheckedChanged
        If cbadmin.Checked = True Then
            isadmin = 1
        Else
            isadmin = 0
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtpass.UseSystemPasswordChar = False
        Else
            txtpass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        Dim i As Integer
        i = dgv1.CurrentRow.Index
        txtkode.Text = dgv1.Item(0, i).Value
        txtnama.Text = dgv1.Item(1, i).Value
        txtalamat.Text = dgv1.Item(2, i).Value
        txttelp.Text = dgv1.Item(3, i).Value
        editadmin = dgv1.Item(4, i).Value
        txtuser.Text = dgv1.Item(5, i).Value
        txtpass.Text = dgv1.Item(6, i).Value
        If editadmin = 1 Then
            cbadmin.Checked = True
        Else
            cbadmin.Checked = False
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If txtnama.Text = "" Or txttelp.Text = "" Or txtalamat.Text = "" Or txtuser.Text = "" Or txtpass.Text = "" Then
            MsgBox("Data ada yang belum diisi", vbCritical, "Peringatan")
        Else
            sql.addparam("@kode", txtkode.Text)
            sql.addparam("@nama", txtnama.Text)
            sql.addparam("@notelp", txttelp.Text)
            sql.addparam("@isadmin", isadmin)
            sql.addparam("@alamat", txtalamat.Text)
            sql.addparam("@user", txtuser.Text)
            sql.addparam("@pass", txtpass.Text)
            sql.execquery("update pegawai set NamaPegawai=@nama,Alamat=@alamat,NoTelp=@notelp,Tipe=@isadmin,Username=@user,Passwords=@pass where KodePegawai=@kode")
            If sql.adakecuali(True) Then Exit Sub
            MsgBox("Data berhasil dimasukkan", vbOKOnly, "Selamat")
            lurukode()
            txtnama.Text = ""
            txttelp.Text = ""
            cbadmin.Checked = False
            txtalamat.Text = ""
            txtuser.Text = ""
            txtpass.Text = ""
            loaddata()
        End If
    End Sub
    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        Me.Close()
    End Sub
    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If MsgBox("Data yang diselek akan dihapus, apakah anda ingin menghapus data ini?", vbYesNo, "Menghapus Data") = MsgBoxResult.Yes Then
            sql.addparam("@kode", txtkode.Text)
            sql.execquery("delete pegawai where kodepegawai=@kode")
            If sql.adakecuali(True) Then Exit Sub
            MsgBox("Data berhasil dihapus", vbOKOnly, "Selamat")
            lurukode()
            txtnama.Text = ""
            txttelp.Text = ""
            cbadmin.Checked = False
            txtalamat.Text = ""
            txtuser.Text = ""
            txtpass.Text = ""
            loaddata()
        Else

        End If
    End Sub

    Private Sub btnfilter_Click(sender As Object, e As EventArgs) Handles btnfilter.Click
        sql.addparam("@id", "%" & txtfilter.Text & "%")
        sql.execquery("select * from pegawai where " & cbfilter.Text & " like @id order by " & cbfilter.Text & " asc")
        dgv1.DataSource = sql.dbdt
    End Sub

    Private Sub txttelp_TextChanged(sender As Object, e As EventArgs) Handles txttelp.TextChanged

    End Sub

    Private Sub txttelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttelp.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
             AndAlso (Not Char.IsDigit(e.KeyChar) _
             AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub
End Class