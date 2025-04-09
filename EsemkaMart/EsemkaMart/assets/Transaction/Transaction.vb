Public Class Transaction
    Private sql As New Squek
    Public buy As Integer
    Public tipe As String
    Public reward As Integer
    Public promoid As Integer
    Public priceafter As Integer
    Public freexprice As Integer
    Public pricexqty As Integer
    Public buyprice As Integer
    Public sellprice As Integer
    Private divided As Integer
    Private countmin As Integer
    Private thelatter As Integer
    Private qtyxharga As Integer
    Public datenow As New DateTimePicker
    Public datebegin As New DateTimePicker
    Public dateexpire As New DateTimePicker
    Public subtotal As Integer
    Public numyousafe As Integer = 0
    Public yousafe As Integer = 0
    Public dgvhid As New DataGridView
    Private profit As Integer
    Private prodic As String
    Private emploid As Integer
    Private buylater As Integer
    Private newprice As Integer
    Private comboboxbuypromo As ComboBox
    Private comboboxrewardpromo As ComboBox
    Private Sub countingrewards()
        If tipe = "NOTH" Then
            priceafter = Val(TextBox3.Text * NumericUpDown1.Value)
        ElseIf tipe = "FREE" Then
            'divided = Int(NumericUpDown1.Value / buy)
            'countmin = Val(NumericUpDown1.Value - (buy * divided))
            'thelatter = Val(divided * (buy - reward) + countmin)
            'priceafter = Val(thelatter * TextBox3.Text)
            'numyousafe = Val(yousafe + (TextBox3.Text * NumericUpDown1.Value - priceafter))
            'yousafe = numyousafe
            If NumericUpDown1.Value > 2 Then
                thelatter = Val(TextBox3.Text * NumericUpDown1.Value)
                priceafter = Val(thelatter - TextBox3.Text)
                numyousafe = Val(yousafe + (TextBox3.Text * NumericUpDown1.Value - priceafter))
                yousafe = numyousafe
            Else
                priceafter = Val(TextBox3.Text * NumericUpDown1.Value)
                yousafe = yousafe
            End If
        ElseIf tipe = "DISC" Then
            If NumericUpDown1.Value >= buy Then
                priceafter = Val(reward * NumericUpDown1.Value)
                numyousafe = Val(yousafe + (TextBox3.Text * NumericUpDown1.Value - priceafter))
                yousafe = numyousafe
            Else
                priceafter = Val(TextBox3.Text * NumericUpDown1.Value)
                numyousafe = Val(yousafe + (TextBox3.Text * NumericUpDown1.Value - priceafter))
                yousafe = numyousafe
            End If
        End If
    End Sub
    Public Sub coalescemax()
        Dim dtp1 As New DateTimePicker
        dtp1.Value = DateTime.Now
        Label12.Text = Date.Now.ToString("yyyy-MM-dd")
        Dim year As Integer = dtp1.Value.Year
        Dim years As String = year
        Dim luru As String
        Dim i As Integer = 0
        sql.execquery("select coalesce(max(trxid),'0000000000') as maxi from headertrx")
        For Each r As DataRow In sql.dbdt.Rows
            luru = r("maxi")
            i = Mid(luru, 5)
        Next
        Dim m As String = i + 1 + 1000000
        Dim text As String
        text = years + Mid(m, 2).ToString
        Label10.Text = text
    End Sub

    Private Sub Transaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
        cbfilter.Items.Add("ProductID")
        cbfilter.Items.Add("Name")
        cbfilter.Text = "Name"
        formMain.title = "trx"
        emploid = formMain.empid
        coalescemax()
        datenow.Value = DateTime.Now
        sql.addparam("@id", Label10.Text)
        sql.addparam("@date", Label12.Text)
        sql.addparam("@empid", emploid)
        sql.execquery("insert into headertrx(TrxID,Date,EmployeeID,MemberID) values(@id,@date,@empid,'M00000000')")
        If sql.hascecep(True) Then Exit Sub
    End Sub

    Private Sub txtfilter_TextChanged(sender As Object, e As EventArgs) Handles txtfilter.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Search.ShowDialog()
    End Sub
    Private Sub nofilth()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        NumericUpDown1.Value = 1
        longlabel.Text = "[NOTHING]"
    End Sub
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Empty!")
        Else
            If datenow.Value.Date > dateexpire.Value.Date Then
                buylater = Val(buyprice * NumericUpDown1.Value)
                priceafter = Val(TextBox3.Text * NumericUpDown1.Value)
            ElseIf datenow.Value.Date < datebegin.Value.Date Then
                priceafter = Val(TextBox3.Text * NumericUpDown1.Value)
                buylater = Val(buyprice * NumericUpDown1.Value)
            Else
                countingrewards()
                buylater = Val(buyprice * NumericUpDown1.Value)
            End If
            Dim row As DataGridViewRow = Nothing
            For Each item As DataGridViewRow In dgv1.Rows
                If item.Cells.Item("colname").Value = TextBox2.Text Then
                    row = item
                End If
            Next
            If Not IsNothing(row) Then
                Dim totalqty As Integer = row.Cells("colqty").Value + NumericUpDown1.Value
                Dim totalpriceafter As Integer
                If tipe = "NOTH" Then
                    totalpriceafter = row.Cells("coltotal").Value + priceafter
                    row.Cells.Item("colpid").Value = TextBox1.Text
                    row.Cells.Item("colname").Value = TextBox2.Text
                    row.Cells.Item("colqty").Value = totalqty
                    row.Cells.Item("colprice").Value = TextBox3.Text
                    row.Cells.Item("coltotal").Value = totalpriceafter
                ElseIf tipe = "FREE" Then
                    If totalqty > 2 Then
                        thelatter = Val(TextBox3.Text * totalqty)
                        totalpriceafter = Val(thelatter - TextBox3.Text)
                        numyousafe = Val(yousafe + (TextBox3.Text * totalqty - totalpriceafter))
                        yousafe = numyousafe
                    Else
                        totalpriceafter = Val(TextBox3.Text * totalqty)
                        yousafe = 0
                    End If
                    row.Cells.Item("colpid").Value = TextBox1.Text
                    row.Cells.Item("colname").Value = TextBox2.Text
                    row.Cells.Item("colqty").Value = totalqty
                    row.Cells.Item("colprice").Value = TextBox3.Text
                    row.Cells.Item("coltotal").Value = totalpriceafter
                ElseIf tipe = "DISC" Then
                    sql.addparam("@name", TextBox2.Text)
                    sql.addparam("@startdate", datebegin.Value.Date)
                    sql.addparam("@enddate", dateexpire.Value.Date)
                    sql.addparam("@buyqty", totalqty)
                    sql.execquery("select MAX(buyqty) as buymax from promo 
                       where name=@name and StartDate>=@startdate and EndDate<=@enddate and BuyQty <=@buyqty")
                    For Each r As DataRow In sql.dbdt.Rows
                        buy = r("buymax")
                    Next
                    sql.addparam("@buy", buy)
                    sql.execquery("select reward from promo where buyqty=@buy")
                    For Each r As DataRow In sql.dbdt.Rows
                        reward = r("reward")
                    Next
                    If NumericUpDown1.Value >= buy Then
                        totalpriceafter = Val(reward * totalqty)
                    Else
                        totalpriceafter = Val(reward * totalqty)
                        reward = reward
                    End If
                    row.Cells.Item("colpid").Value = TextBox1.Text
                    row.Cells.Item("colname").Value = TextBox2.Text
                    row.Cells.Item("colqty").Value = totalqty
                    row.Cells.Item("colprice").Value = reward
                    row.Cells.Item("coltotal").Value = totalpriceafter
                End If

            Else 'batas
                Dim newindex = dgv1.Rows.Add()
                row = dgv1.Rows.Item(newindex)
                row.Cells.Item("colpid").Value = TextBox1.Text
                row.Cells.Item("colname").Value = TextBox2.Text
                row.Cells.Item("colqty").Value = NumericUpDown1.Value
                If NumericUpDown1.Value < buy Then
                    row.Cells.Item("colprice").Value = TextBox3.Text
                ElseIf tipe = "NOTH" Then
                    row.Cells.Item("colprice").Value = TextBox3.Text
                Else
                    row.Cells.Item("colprice").Value = reward
                End If
                row.Cells.Item("coltotal").Value = priceafter
            End If
            Dim rowhid As String() = New String() {TextBox2.Text, NumericUpDown1.Value, TextBox3.Text, priceafter}
            dgvhid.Rows.Add(rowhid)
            insertdata()
            nofilth()
        End If
    End Sub
    Private Sub loaddata()
        dgv1.Columns.Add("colpid", "ProductID")
        dgv1.Columns.Add("colname", "Name")
        dgv1.Columns.Add("colqty", "Qty")
        dgv1.Columns.Add("colprice", "Price")
        dgv1.Columns.Add("coltotal", "SubTotal")
        dgvhid.ColumnCount = 4
    End Sub
    Private Sub findprofit()
        profit = Val(priceafter - buylater)
    End Sub
    Private Sub insertdata()
        findprofit()
        sql.addparam("@id", Label10.Text)
        sql.addparam("@prodid", TextBox1.Text)
        sql.addparam("@qty", NumericUpDown1.Text)
        sql.addparam("@buyp", buylater)
        sql.addparam("@sellp", priceafter)
        sql.addparam("@promoid", promoid)
        sql.addparam("@profit", profit)
        sql.execquery("insert into DetailTrx (TrxID,ProductID,Qty,BuyPrice,SellPrice,PromoID,Profit) " &
                      " values (@id,@prodid,@qty,@buyp,@sellp,@promoid,@profit)")
        If sql.hascecep(True) Then Exit Sub

    End Sub
    Private Sub removeitem()
        sql.addparam("@id", prodic)
        sql.execquery("delete detailtrx where ProductID=@id")
        If sql.hascecep(True) Then Exit Sub
    End Sub
    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If IsNothing(prodic) Then
            MsgBox("Select first!")
        Else
            For Each row As DataGridViewRow In dgv1.SelectedRows
                dgv1.Rows.Remove(row)
            Next
            removeitem()
            nofilth()
        End If
    End Sub
    Private Sub ngitungdgv()
        subtotal = 0
        For index As Integer = 0 To dgv1.RowCount - 1
            subtotal += Convert.ToInt32(dgv1.Rows(index).Cells(4).Value)
        Next
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If dgv1.Rows.Count > 0 Then
            ngitungdgv()
            Payment.ShowDialog()
        ElseIf dgv1.Rows.Count <= 0 Then
            MsgBox("Add a product first!", vbOKOnly, "Caution")
        End If
    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        Dim i As Integer
        i = dgv1.CurrentRow.Index
        prodic = dgv1.Item(0, i).Value
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        sql.addparam("@name", TextBox2.Text)
        sql.addparam("@startdate", datebegin.Value.Date)
        sql.addparam("@enddate", dateexpire.Value.Date)
        sql.addparam("@buyqty", NumericUpDown1.Value)
        sql.execquery("select * from promo where name=@name and StartDate>=@startdate and EndDate<=@enddate and buyqty<=@buyqty")
        For Each r As DataRow In sql.dbdt.Rows
            buy = r("buyqty")
            reward = r("reward")
            If tipe = "NOTH" Then
                longlabel.Text = "No Promo Available"
            ElseIf tipe = "DISC" Then
                longlabel.Text = "BUY " + buy.ToString + " DISC " + reward.ToString
            ElseIf tipe = "FREE" Then
                longlabel.Text = "BUY " + buy.ToString + " FREE " + reward.ToString
            End If
        Next
    End Sub

End Class