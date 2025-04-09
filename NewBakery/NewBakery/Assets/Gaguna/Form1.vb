Public Class Form1
    Dim sql As New SquekingDataContext
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Chart1.DataSource = sql.Employees
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class