Public Class ViewTransactionForm
    Private sql As New SquekDataContext
    Private headerid As Integer
    Sub loadheader()
        dgvHeader.DataSource = sql.HeaderDeposits.Where(Function(x) x.IdCustomer.ToString.Contains(TextBox1.Text) Or x.Id.ToString.Contains(TextBox1.Text) Or x.IdEmployee.ToString.Contains(TextBox1.Text))
    End Sub
    Private Sub ViewTransactionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadheader()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        loadheader()
    End Sub
    Sub loaddetail()
        dgvDetail.DataSource = sql.DetailDeposits.Where(Function(x) x.IdDeposit = headerid)
    End Sub
    Private Sub dgvHeader_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHeader.CellClick
        Dim i As Integer = dgvHeader.CurrentRow.Index
        headerid = dgvHeader.Item(0, i).Value
        loaddetail()
    End Sub
End Class
