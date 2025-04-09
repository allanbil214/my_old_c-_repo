Public Class PromoForm
    Dim sql As New Squek
    Dim inorup As String
    Dim promid As String
    Private Sub loaddata()
        sql.execquery("select * from promo")
        dgv1.DataSource = sql.dbdt
    End Sub
    Private Sub PromoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
        txttype.Items.Add("NOTH")
        txttype.Items.Add("DISC")
        txttype.Items.Add("FREE")
        txttype.Text = "NOTH"
        datestart.Value = Date.Now.AddDays(1)
        datenow.Value = Date.Now
        dateend.Value = Date.Now.AddMonths(1)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SearchForm.ShowDialog()
    End Sub

    Private Sub clearing()
        txtname.Text = ""
        txtqty.Value = 0
        txtreward.Value = 0
        txtprodid.Text = ""
        txttype.Text = "NOTH"
        datestart.Value = Date.Now.AddDays(1)
        dateend.Value = Date.Now.AddMonths(1)
        datenow.Value = Date.Now
        datestart.Visible = True
        datenow.Visible = False
        Button1.Enabled = True
        Button2.Enabled = False
        Button3.Enabled = True
        Button4.Enabled = False
        Button5.Enabled = False
        txtname.Enabled = False
        txtqty.Enabled = False
        txtreward.Enabled = False
        txttype.Enabled = False
        datestart.Enabled = False
        dateend.Enabled = False
        dgv1.Enabled = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtname.Enabled = True
        txtqty.Enabled = True
        txtreward.Enabled = True
        txttype.Enabled = True
        datestart.Enabled = True
        datestart.Visible = True
        datenow.Visible = False
        dateend.Enabled = True
        Button1.Enabled = False
        Button2.Enabled = True
        Button3.Enabled = False
        Button4.Enabled = True
        Button5.Enabled = True
        inorup = "in"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        clearing()
    End Sub
    Private Sub insertdata()
        sql.addparam("@prodid", txtprodid.Text)
        sql.addparam("@name", txtname.Text)
        sql.addparam("@qty", txtqty.Value)
        sql.addparam("@type", txttype.Text)
        sql.addparam("@reward", txtreward.Value)
        sql.addparam("@start", datestart.Value)
        sql.addparam("@end", dateend.Value)
        sql.execquery("insert into promo (ProductID,Name,BuyQty,Type,Reward,StartDate,EndDate) " &
                      "values(@prodid,@name,@qty,@type,@reward,@start,@end) ")
        If sql.hasexception(True) Then Exit Sub
        MsgBox("Success", vbOKOnly, "Success")
    End Sub
    Private Sub updatedata()
        sql.addparam("@id", promid)
        sql.addparam("@prodid", txtprodid.Text)
        sql.addparam("@name", txtname.Text)
        sql.addparam("@qty", txtqty.Value)
        sql.addparam("@type", txttype.Text)
        sql.addparam("@reward", txtreward.Value)
        sql.addparam("@start", datestart.Value)
        sql.addparam("@end", dateend.Value)
        sql.execquery("update promo set " &
                      "ProductID=@prodid,Name=@name,BuyQty=@qty,Type=@type,Reward=@reward,StartDate=@start,EndDate=@end " &
                      "where PromoID=@id")
        If sql.hasexception(True) Then Exit Sub
        MsgBox("Success", vbOKOnly, "Success")
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If inorup = "in" Then
            If txtprodid.Text = "" Or txtname.Text = "" Or txtqty.Value = 0 Or txtreward.Value = "" Then
                MsgBox("Blank Data, Please Fill", vbOKOnly, "Caution")
            Else
                insertdata()
            End If
        ElseIf inorup = "up" Then
            If txtprodid.Text = "" Or txtname.Text = "" Or txtqty.Value = 0 Or txtreward.Value = "" Then
                MsgBox("Blank Data, Please Fill", vbOKOnly, "Caution")
            Else
                updatedata()
            End If
        End If
        clearing()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        dgv1.Enabled = True
        txtname.Enabled = True
        txtqty.Enabled = True
        txtreward.Enabled = True
        txttype.Enabled = True
        datestart.Enabled = False
        datestart.Visible = False
        datenow.Visible = True
        dateend.Enabled = True
        Button1.Enabled = False
        Button2.Enabled = True
        Button3.Enabled = False
        Button4.Enabled = True
        Button5.Enabled = True
        inorup = "up"
    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        Dim i As Integer
        i = dgv1.CurrentRow.Index
        promid = dgv1.Item(0, i).Value
        txtprodid.Text = dgv1.Item(1, i).Value
        txtname.Text = dgv1.Item(2, i).Value
        txtqty.Value = dgv1.Item(3, i).Value
        txttype.Text = dgv1.Item(4, i).Value
        txtreward.Value = dgv1.Item(5, i).Value
        datenow.Value = dgv1.Item(6, i).Value
        dateend.Value = dgv1.Item(7, i).Value

    End Sub

    Private Sub dateend_ValueChanged(sender As Object, e As EventArgs) Handles dateend.ValueChanged
        If dateend.Value.Date <= datestart.Value.Date Then
            'MsgBox("Expired Date must be greater than start date!", vbOKOnly, "Caution")
            dateend.Value = datestart.Value.AddDays(1)
        End If
    End Sub

    Private Sub datestart_ValueChanged(sender As Object, e As EventArgs) Handles datestart.ValueChanged
        If datestart.Value.Date >= dateend.Value.Date Then
            'MsgBox("Start Date must be smaller than expired date!", vbOKOnly, "Caution")
            dateend.Value = datestart.Value.AddDays(1)
        ElseIf datestart.Value.Date < Date.Now Then
            datestart.Value = datestart.Value.AddDays(1)
        End If
    End Sub
End Class