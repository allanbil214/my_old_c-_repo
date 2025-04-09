Public Class formHistPur
    Private sql As New Squek
    Private phid As Integer = 0
    Sub loaddgv1()
        sql.addparam("@start", DateTimePicker1.Value.Date)
        sql.addparam("@end", DateTimePicker2.Value.Date)
        sql.execquery("select * from PurchaseHeader where PurchaseDate between @start and @end")
        dgv1.DataSource = sql.dbdt
    End Sub
    Sub loaddgv2()
        sql.addparam("@phid", phid)
        sql.execquery("select * from purchasedetail where phid=@phid")
        dgv2.DataSource = sql.dbdt
    End Sub
    Private Sub formHistPur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddgv1()
    End Sub

    Private Sub dgv1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellDoubleClick
        Dim i As Integer = dgv1.CurrentRow.Index
        phid = dgv1.Item(0, i).Value
        loaddgv2()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        loaddgv1()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        loaddgv1()
    End Sub
End Class