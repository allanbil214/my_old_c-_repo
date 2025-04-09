Public Class formPurchase
    Private sql As New Squek
    Public drugid As Integer = 0
    Public drugbasestock As Integer = 0
    Public empid As Integer = 0
    Public supid As Integer = 0
    Private phid As Integer = 0

    Sub loaddgv()
        dgv1.Columns.Add("coldid", "did")
        dgv1.Columns.Add("coldname", "Drug Name")
        dgv1.Columns.Add("colcost", "Cost")
        dgv1.Columns.Add("colqty", "Qty")
        dgv1.Columns.Add("colsubcost", "Sub Cost")
        dgv1.Columns.Add("coleid", "eid")
        dgv1.Columns.Add("colempname", "Employee Name")
        dgv1.Columns.Add("colsid", "sid")
        dgv1.Columns.Add("colsupname", "Supplier Name")
        dgv1.Columns.Add("colpurdate", "Purchase Date")
        dgv1.Columns.Add("colbasestock", "Base Stock")
        dgv1.Columns("coldid").Visible = False
        dgv1.Columns("coleid").Visible = False
        dgv1.Columns("colsid").Visible = False
        dgv1.Columns("colbasestock").Visible = False
    End Sub

    Private Sub formPurchase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        empid = formMain.empid
        dtpNow.Value = DateTime.Now
        loaddgv()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        formSearch.whatform = "purchase"
        formSearch.whatisit = "drug"
        formSearch.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        formSearch.whatisit = "sup"
        formSearch.ShowDialog()
    End Sub
    Sub counttotal()
        Dim totalcost As Integer = 0
        For index As Integer = 0 To dgv1.RowCount - 1
            totalcost += Convert.ToInt32(dgv1.Rows(index).Cells("colsubcost").Value)
        Next
        lblTotalCost.Text = totalcost
    End Sub
    Sub cleaning()
        drugid = 0
        drugbasestock = 0
        supid = 0
        txtSup.Clear()
        txtCost.Clear()
        txtDrug.Clear()
        numQty.Value = 1
    End Sub
    Sub adddata()
        Dim row As DataGridViewRow = Nothing
        For Each item As DataGridViewRow In dgv1.Rows
            If item.Cells.Item("coldname").Value = txtDrug.Text Then
                row = item
            End If
        Next
        If Not IsNothing(row) Then
            Dim totalQty As Integer = row.Cells.Item("colqty").Value + numQty.Value
            row.Cells.Item("coldid").Value = drugid
            row.Cells.Item("coldname").Value = txtDrug.Text
            row.Cells.Item("colcost").Value = txtCost.Text
            row.Cells.Item("colqty").Value = totalQty
            row.Cells.Item("colsubcost").Value = totalQty * txtCost.Text
            row.Cells.Item("coleid").Value = empid
            row.Cells.Item("colempname").Value = formMain.empname
            row.Cells.Item("colsid").Value = supid
            row.Cells.Item("colsupname").Value = txtSup.Text
            row.Cells.Item("colpurdate").Value = dtpNow.Value.Date
            row.Cells.Item("colbasestock").Value = drugbasestock
        Else
            Dim newIndex = dgv1.Rows.Add()
            row = dgv1.Rows.Item(newIndex)
            row.Cells.Item("coldid").Value = drugid
            row.Cells.Item("coldname").Value = txtDrug.Text
            row.Cells.Item("colcost").Value = txtCost.Text
            row.Cells.Item("colqty").Value = numQty.Value
            row.Cells.Item("colsubcost").Value = numQty.Value * txtCost.Text
            row.Cells.Item("coleid").Value = empid
            row.Cells.Item("colempname").Value = formMain.empname
            row.Cells.Item("colsid").Value = supid
            row.Cells.Item("colsupname").Value = txtSup.Text
            row.Cells.Item("colpurdate").Value = dtpNow.Value.Date
            row.Cells.Item("colbasestock").Value = drugbasestock
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If drugid = 0 Or txtDrug.Text = "" Or txtSup.Text = "" Or numQty.Value <= 0 Then
            MsgBox("Something is wrong, i can feel it!")
        Else
            adddata()
            counttotal()
            cleaning()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("Delete?", vbYesNo, "Caution") = vbYes Then
            For Each row As DataGridViewRow In dgv1.SelectedRows
                dgv1.Rows.Remove(row)
            Next
            counttotal()
        End If
    End Sub
    Sub insertpurheader()
        sql.addparam("@date", dtpNow.Value.Date)
        sql.addparam("@eid", empid)
        sql.addparam("@totalcost", lblTotalCost.Text)
        sql.execquery("insert into purchaseheader(purchasedate,eid,totalcost) values(@date,@eid,@totalcost) ")
        If sql.hascecep(True) Then
            Exit Sub
        Else
            findpurhid()
        End If
    End Sub
    Sub findpurhid()
        sql.execquery("select coalesce(max(id),'0') as maxid from purchaseheader")
        For Each r As DataRow In sql.dbdt.Rows
            phid = r("maxid")
        Next
        insertpurdetail()
    End Sub
    Sub insertpurdetail()
        For x As Integer = 0 To dgv1.RowCount - 1
            sql.addparam("@phid", phid)
            sql.addparam("@did", dgv1.Rows(x).Cells("coldid").Value)
            sql.addparam("@sid", dgv1.Rows(x).Cells("colsid").Value)
            sql.addparam("@name", dgv1.Rows(x).Cells("coldname").Value)
            sql.addparam("@qty", dgv1.Rows(x).Cells("colqty").Value)
            sql.addparam("@cost", dgv1.Rows(x).Cells("colcost").Value)
            sql.execquery("insert into purchasedetail(phid,did,sid,DrugName,Qty,Cost) values(@phid,@did,@sid,@name,@qty,@cost) ")
            If sql.hascecep(True) Then
                Exit Sub
            Else
                plusstock()
            End If
        Next
    End Sub
    Sub plusstock()
        For x As Integer = 0 To dgv1.RowCount - 1
            sql.addparam("@id", dgv1.Rows(x).Cells("coldid").Value)
            sql.addparam("@qty", Val(dgv1.Rows(x).Cells("colbasestock").Value + dgv1.Rows(x).Cells("colqty").Value))
            sql.execquery("update drugs set stock=@qty where id=@id")
            If sql.hascecep(True) Then Exit Sub
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If dgv1.RowCount = 0 Then
            MsgBox("Tambah dulu bukunya")
        Else
            insertpurheader()
            MsgBox("Success")
            lblTotalCost.Text = "0"
            dgv1.Rows.Clear()
            cleaning()
        End If
    End Sub
End Class