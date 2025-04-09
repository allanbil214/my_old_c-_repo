Public Class VSummary
    Dim sql As New Squek
    Private Sub loaddata1()
        sql.execquery("select top(3) detailtrx.TrxID,HeaderTrx.MemberID ,Member.Name,sum(DetailTrx.sellprice) as 'Transaction' from DetailTrx " &
                      "inner Join HeaderTrx on DetailTrx.TrxID = HeaderTrx.TrxID " &
                      "inner Join member on HeaderTrx.MemberID = member.MemberID " &
                      "group by HeaderTrx.MemberID, DetailTrx.TrxID, Member.Name, DetailTrx.SellPrice " &
                      "order by sellprice desc")
        dgv1.DataSource = sql.dbdt
    End Sub
    Private Sub loaddata2()
        sql.execquery("select top(5) Product.ProductID, Product.Name, sum(DetailTrx.Qty) as 'Quantities' from DetailTrx  " &
                      "inner Join Product on Detailtrx.ProductID = Product.ProductID  " &
                      "group by Product.productid, product.Name, DetailTrx.Qty " &
                      "order by qty desc ")
        dgv2.DataSource = sql.dbdt
    End Sub
    Private Sub VSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata1()
        loaddata2()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        loaddata1()
        loaddata2()
    End Sub
End Class