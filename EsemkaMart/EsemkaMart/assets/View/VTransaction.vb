Public Class VTransaction
    Dim sql As New Squek
    Dim filter As String = "M00000000"
    Dim trxid As String

    Private Sub loaddata2()
        sql.addparam("@id", trxid)
        sql.execquery(" select Name,Spec as 'Specification',DetailTrx.Qty,product.BuyPrice,product.SellPrice,DetailTrx.SellPrice - (Product.SellPrice * DetailTrx.Qty) as Discount,detailtrx.Profit " &
                      " from Product inner join detailtrx on product.productid = detailtrx.productid where DetailTrx.TrxID=@id ")
        dgv2.DataSource = sql.dbdt
    End Sub
    Private Sub totaltrx()
        sql.execquery("select sum(sellprice) as total from detailtrx")
        For Each r As DataRow In sql.dbdt.Rows
            Label5.Text = r("total")
        Next
    End Sub
    Private Sub totalprofit()
        sql.execquery("select sum(profit) as total from detailtrx")
        For Each r As DataRow In sql.dbdt.Rows
            Label8.Text = r("total")
        Next
    End Sub
    Private Sub loaddata1()
        ComboBox1.Items.Add("All")
        ComboBox1.Items.Add("Member")
        ComboBox1.Items.Add("Non-Member")
        ComboBox1.Text = "All"
        sql.addparam("@start", DateTimePicker1.Value.Date)
        sql.addparam("@end", DateTimePicker2.Value.Date)
        sql.execquery(" select DetailTrx.TrxID,HeaderTrx.Date,sum(BuyPrice) as 'Buy Price',sum(SellPrice) as 'Sell Price' ,sum(Profit) as 'Profit',MemberID from DetailTrx  " &
                      " Inner Join HeaderTrx on DetailTrx.TrxID = HeaderTrx.TrxID " &
                      " where HeaderTrx.Date between @start and @end " &
                      " Group by DetailTrx.TrxID,HeaderTrx.Date,HeaderTrx.MemberID")
        dgv1.DataSource = sql.dbdt
        dgv1.Columns(5).Visible = False
    End Sub
    Private Sub lurudatanonmember()
        sql.addparam("@start", DateTimePicker1.Value.Date)
        sql.addparam("@end", DateTimePicker2.Value.Date)
        sql.addparam("@filter", filter)
        sql.execquery(" select DetailTrx.TrxID,HeaderTrx.Date,sum(BuyPrice) as 'Buy Price',sum(SellPrice) as 'Sell Price' ,sum(Profit) as 'Profit',MemberID from DetailTrx " &
                      " Inner Join HeaderTrx on DetailTrx.TrxID = HeaderTrx.TrxID " &
                      " where MemberID=@filter and HeaderTrx.Date between @start and @end " &
                      " Group by DetailTrx.TrxID,HeaderTrx.Date,HeaderTrx.MemberID")
        dgv1.DataSource = sql.dbdt
        dgv1.Columns(5).Visible = False
    End Sub
    Private Sub lurudatamember()
        sql.addparam("@start", DateTimePicker1.Value.Date)
        sql.addparam("@end", DateTimePicker2.Value.Date)
        sql.addparam("@filter", filter)
        sql.execquery(" select DetailTrx.TrxID,HeaderTrx.Date,sum(BuyPrice) as 'Buy Price',sum(SellPrice) as 'Sell Price' ,sum(Profit) as 'Profit',MemberID from DetailTrx " &
                      " Inner Join HeaderTrx on DetailTrx.TrxID = HeaderTrx.TrxID " &
                      " where HeaderTrx.Date between @start and @end and not MemberID=@filter " &
                      " Group by DetailTrx.TrxID,HeaderTrx.Date,HeaderTrx.MemberID")
        dgv1.DataSource = sql.dbdt
        dgv1.Columns(5).Visible = False
    End Sub
    Private Sub VTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata1()
        totaltrx()
        totalprofit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedItem = "Non-Member" Then
            lurudatanonmember()
        ElseIf ComboBox1.SelectedItem = "Member" Then
            lurudatamember()
        ElseIf ComboBox1.SelectedItem = "All" Then
            loaddata1()
        End If
    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        Dim i As Integer
        i = dgv1.CurrentRow.Index
        trxid = dgv1.Item(0, i).Value
        loaddata2()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        loaddata1()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        loaddata1()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        loaddata1()
        totaltrx()
        totalprofit()
    End Sub
End Class