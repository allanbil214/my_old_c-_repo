Public Class PinjamForm
    Private sql As New SquekDataContext
    Private msg = ""
    Sub loaddata()
        dgv1.DataSource = sql.Pelanggans
    End Sub
    Private Sub TransaksiForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
    End Sub
End Class
