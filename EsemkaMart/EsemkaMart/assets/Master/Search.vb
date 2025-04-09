Public Class Search
    Dim sql As New Squek
    Dim i As Integer
    Private Sub loaddata()
        If formMain.title = "promo" Then
            sql.execquery("select * from product")
            dgv1.DataSource = sql.dbdt
            cbfilter.Items.Add("ProductID")
            cbfilter.Items.Add("Name")
            cbfilter.Text = "Name"
        ElseIf formMain.title = "trx" Then
            sql.execquery("select * from promo")
            dgv1.DataSource = sql.dbdt
            cbfilter.Items.Add("ProductID")
            cbfilter.Items.Add("Name")
            cbfilter.Text = "Name"
        End If
    End Sub
    Private Sub Search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
    End Sub
    Private Sub lurusellprice()
        sql.addparam("@id", Transaction.TextBox1.Text)
        sql.execquery("select sellprice,buyprice from product where productid=@id")
        For Each r As DataRow In sql.dbdt.Rows
            Transaction.TextBox3.Text = r("sellprice")
            Transaction.buyprice = r("buyprice")
            Transaction.sellprice = r("sellprice")
        Next
    End Sub
    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        If formMain.title = "promo" Then
            i = dgv1.CurrentRow.Index
            Promo.TextBox1.Text = dgv1.Item(0, i).Value
            Promo.TextBox2.Text = dgv1.Item(1, i).Value
        ElseIf formMain.title = "trx" Then
            i = dgv1.CurrentRow.Index
            Transaction.promoid = dgv1.Item(0, i).Value
            Transaction.TextBox1.Text = dgv1.Item(1, i).Value
            Transaction.TextBox2.Text = dgv1.Item(2, i).Value
            Transaction.buy = dgv1.Item(3, i).Value
            Transaction.tipe = dgv1.Item(4, i).Value
            Transaction.reward = dgv1.Item(5, i).Value
            Transaction.datebegin.Value = dgv1.Item(6, i).Value
            Transaction.dateexpire.Value = dgv1.Item(7, i).Value
            lurusellprice()
            If Transaction.datenow.Value.Date > Transaction.dateexpire.Value.Date Then
                Transaction.longlabel.Text = "Promo is already expired"
            ElseIf Transaction.datenow.Value.Date < Transaction.datebegin.Value.Date Then
                Transaction.longlabel.Text = "No Promo yet"
            Else
                If Transaction.tipe = "NOTH" Then
                    Transaction.longlabel.Text = "No Promo Available"
                ElseIf Transaction.tipe = "DISC" Then
                    Transaction.longlabel.Text = "BUY " + Transaction.buy.ToString + " DISC " + Transaction.reward.ToString
                ElseIf Transaction.tipe = "FREE" Then
                    Transaction.longlabel.Text = "BUY " + Transaction.buy.ToString + " FREE " + Transaction.reward.ToString
                End If
            End If
        End If
    End Sub
    Private Sub txtfilter_TextChanged(sender As Object, e As EventArgs) Handles txtfilter.TextChanged
        sql.addparam("@txt", txtfilter.Text)
        sql.execquery("select * from product where " & cbfilter.Text & " like @txt")
        dgv1.DataSource = sql.dbdt
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class