Public Class Chart
    Private sql As New Squeking
    Sub loaddata()
        sql.execquery("select top 5 JudulKaset,Stok from Kaset")
        'Chart1.DataSource = sql.dbdt
        For Each r As DataRow In sql.dbdt.Rows
            Chart1.Series("Stok").Points.AddXY(r("JudulKaset"), r("Stok"))
        Next
    End Sub
    Private Sub Chart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
    End Sub
End Class