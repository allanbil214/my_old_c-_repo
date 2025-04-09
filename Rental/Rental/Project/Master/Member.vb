Public Class Member
    Dim sql As New Squek
    Private Sub loaddata()
        sql.execquery("select * from member")
        dgv1.DataSource = sql.dbdt
    End Sub
    Private Sub lurukode()
        sql.execquery("select coalesce(max(KodeMember),'0') as highest from member")
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

    Private Sub Member_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lurukode()
        loaddata()
        cbfilter.Items.Add("Pilih Dulu")
        cbfilter.Items.Add("NamaMember")
        cbfilter.Items.Add("NoTelp")
        cbfilter.Text = "Pilih Dulu"
    End Sub
    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        Me.Close()
    End Sub
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If txtnama.Text = "" Or txttelp.Text = "" Or txtalamat.Text = "" Then
            MsgBox("Data ada yang belum diisi", vbCritical, "Peringatan")
        Else
            sql.addparam("@kode", txtkode.Text)
            sql.addparam("@nama", txtnama.Text)
            sql.addparam("@notelp", txttelp.Text)
            sql.addparam("@alamat", txtalamat.Text)
            sql.execquery("insert into member (NamaMember,NoTelp,Alamat) values(@nama,@notelp,@alamat)")
            If sql.adakecuali(True) Then Exit Sub
            MsgBox("Data berhasil dimasukkan", vbOKOnly, "Selamat")
            lurukode()
            txtnama.Text = ""
            txttelp.Text = ""
            txtalamat.Text = ""
            loaddata()
        End If
    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        Dim i As Integer
        i = dgv1.CurrentRow.Index
        txtkode.Text = dgv1.Item(0, i).Value
        txtnama.Text = dgv1.Item(1, i).Value
        txttelp.Text = dgv1.Item(2, i).Value
        txtalamat.Text = dgv1.Item(3, i).Value
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If txtnama.Text = "" Or txttelp.Text = "" Or txtalamat.Text = "" Then
            MsgBox("Data ada yang belum diisi", vbCritical, "Peringatan")
        Else
            sql.addparam("@kode", txtkode.Text)
            sql.addparam("@nama", txtnama.Text)
            sql.addparam("@notelp", txttelp.Text)
            sql.addparam("@alamat", txtalamat.Text)
            sql.execquery("update member set NamaMember=@nama,NoTelp=@notelp,Alamat=@alamat where KodeMember=@kode")
            If sql.adakecuali(True) Then Exit Sub
            MsgBox("Data berhasil diganti", vbOKOnly, "Selamat")
            lurukode()
            txtnama.Text = ""
            txttelp.Text = ""
            txtalamat.Text = ""
            loaddata()
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If MsgBox("Data yang diselek akan dihapus, apakah anda ingin menghapus data ini?", vbYesNo, "Menghapus Data") = MsgBoxResult.Yes Then
            sql.addparam("@kode", txtkode.Text)
            sql.execquery("delete member where KodeMember=@kode")
            If sql.adakecuali(True) Then Exit Sub
            MsgBox("Data berhasil dihapus", vbOKOnly, "Selamat")
            txtnama.Text = ""
            txtalamat.Text = ""
            txttelp.Text = ""
            loaddata()
            lurukode()
        Else

        End If
    End Sub
    Private Sub btnfilter_Click(sender As Object, e As EventArgs) Handles btnfilter.Click
        sql.addparam("@id", "%" & txtfilter.Text & "%")
        sql.execquery("select * from member where " & cbfilter.Text & " like @id order by " & cbfilter.Text & " asc")
        dgv1.DataSource = sql.dbdt
    End Sub
    Private Sub txttelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttelp.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
                     AndAlso (Not Char.IsDigit(e.KeyChar) _
                     AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub
End Class