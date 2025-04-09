Public Class ViewSellingForm
    Private linq As New LinQDataContext
    Private sql As New Squek
    Private getid As Integer
    Sub loaddata()
        DataGridView1.Rows.Clear()
        For Each r In linq.SellingHeaders
            DataGridView1.Rows.Add(r.SellingId, r.SellingId, r.Discount, r.EmployeeId)
        Next
    End Sub
    Sub loaddata2()
        sql.AddParam("@id", getid)
        sql.ExecQuery("select  * from sellingdetail where sellingid=@id")
        DataGridView2.DataSource = sql.Dbdt
    End Sub
    Private Sub ViewIncomingRawMaterialFrom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 4 Then
            Dim i As Integer = DataGridView1.CurrentRow.Index
            getid = DataGridView1.Item(0, i).Value
            loaddata2()
        End If
    End Sub
End Class