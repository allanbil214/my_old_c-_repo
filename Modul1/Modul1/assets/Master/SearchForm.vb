Public Class SearchForm
    Dim sql As New Squek
    Private Sub loaddata()
        sql.execquery("select * from product")
        dgv1.DataSource = sql.dbdt
    End Sub
    Private Sub SearchForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
    End Sub
    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        Dim i As Integer
        i = dgv1.CurrentRow.Index
        PromoForm.txtprodid.Text = dgv1.Item(0, i).Value
        PromoForm.txtname.Text = dgv1.Item(1, i).Value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        sql.addparam("@id", "%" & TextBox1.Text & "%")
        sql.execquery("select * from product where Name like @id or productid like @id")
        dgv1.DataSource = sql.dbdt
    End Sub
End Class