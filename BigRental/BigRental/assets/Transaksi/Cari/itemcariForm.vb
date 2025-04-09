Public Class itemcariForm
    Private sql As New Squek

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        Dim i As Integer
        i = dgv1.CurrentRow.Index
        pinjamForm.idkaset = dgv1.Item(0, i).Value
        pinjamForm.txtjudul.Text = dgv1.Item(1, i).Value
    End Sub
    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        sql.addparam("@id", "%" & txtCari.Text & "%")
        sql.execquery("select * from item where judul like @id")
        dgv1.DataSource = sql.dbdt
    End Sub
    Private Sub pelanggancariForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql.execquery("select * from item")
        dgv1.DataSource = sql.dbdt
        dgv1.Columns(0).Visible = False
    End Sub

    Private Sub btnpilih_Click(sender As Object, e As EventArgs) Handles btnpilih.Click
        Me.Close()
    End Sub
End Class