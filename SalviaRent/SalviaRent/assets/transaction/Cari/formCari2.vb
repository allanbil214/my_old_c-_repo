Public Class formCari2
    Private sql As New Squek
    Private Sub loaddata()
        sql.addparam("@id", "%" & txtCari.Text & "%")
        sql.execquery("select * from pelanggan where nama like @id ")
        dgv1.DataSource = sql.dbdt
    End Sub
    Private Sub formCari_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
        dgv1.Columns(0).Visible = False
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        loaddata()
    End Sub
    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        Dim i As Integer
        i = dgv1.CurrentRow.Index
        formPeminjaman.txtpelanggan.Text = dgv1.Item(1, i).Value
        formPeminjaman.pelangganid = dgv1.Item(0, i).Value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If formPeminjaman.txtpelanggan.Text = "" Then
            MsgBox("Pilih dulu datanya", vbOKOnly, "Peringatan")
        Else
            formPeminjaman.Button2.Enabled = False
            Me.Close()
        End If
    End Sub

End Class