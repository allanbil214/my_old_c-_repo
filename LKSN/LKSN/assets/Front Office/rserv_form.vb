Public Class rserv_form
    Public nameemp As String
    Public posemp As String
    Private sql As New Squek
    Private databtnleft As Integer
    Private desc As String
    Private checkenin As Integer = 0 '
    Private iname As String
    Private iid As Integer
    Private iqty As Integer
    Private iprice As Integer
    Private itot As Integer
    Private asd As Integer = 0
    Dim btn As New DataGridViewButtonColumn
    Dim c As Integer = 0
    Private b As Integer = 0
    Dim rb As Integer = 0
    Dim ic As Integer = 0
    Private cusID As Integer
    Private empID As Integer
    Private randomtext As String
    Private rsvID As Integer
    Private rsvrID As Integer
    Private Sub loadroomtype()
        cbroomtype.Items.Clear()
        sql.execquery("select * from roomtype")
        For Each r As DataRow In sql.dbdt.Rows
            cbroomtype.Items.Add(r("Name"))
            cbroomtype.Text = cbroomtype.Items.Item(0).ToString
        Next
    End Sub
    Private Sub loaditem()
        cbitem.Items.Clear()
        sql.execquery("select * from item")
        For Each r As DataRow In sql.dbdt.Rows
            cbitem.Items.Add(r("Name"))
            cbitem.Text = cbitem.Items.Item(0).ToString
        Next
    End Sub
    Private Sub loaddgvroom1()
        dgvroom1.Rows.Clear()
        sql.addparam("@type", cbroomtype.Text)
        sql.addparam("@date", startdate.Value)
        sql.execquery("select room.id as 'room',room.RoomNumber as 'num',room.roomfloor as 'floor',roomtype.RoomPrice as 'price' from ReservationRoom 
                       inner join Room on ReservationRoom.roomID = room.ID
					   inner join RoomType on roomtype.id = room.RoomTypeID 
                       where RoomType.Name=@type and ReservationRoom.CheckOutDateTime<@date
					   group by room.id,room.roomnumber,room.roomfloor,roomtype.roomprice
					   order by room.id asc ")
        dgvroom1.ColumnCount = 5
        dgvroom1.Columns(0).Name = "id"
        dgvroom1.Columns(1).Name = "Room Number"
        dgvroom1.Columns(2).Name = "Room Floor"
        dgvroom1.Columns(3).Name = "Description"
        dgvroom1.Columns(4).Name = "roomprice"
        For Each r As DataRow In sql.dbdt.Rows
            Dim id As String = r("room")
            Dim num As String = r("num")
            Dim floor As String = r("floor")
            Dim price As String = r("price")
            sql.addparam("@id", id)
            sql.execquery("select description as 'desc' from room where id=@id")
            For Each ro As DataRow In sql.dbdt.Rows
                desc = ro("desc").ToString
            Next
            Dim row As String() = New String() {id, num, floor, desc, price}
            dgvroom1.Rows.Add(row)
        Next
        For Each row As DataGridViewRow In dgvroom1.Rows.Cast(Of DataGridViewRow)
            If Not row.IsNewRow AndAlso dgvroom2.Rows.Cast(Of DataGridViewRow).Any(Function(r) r.Cells(0).Value.Equals(row.Cells(0).Value)) Then
                dgvroom1.Rows.Remove(row)
            End If
        Next
    End Sub
    Private Sub loaddgv3()
        Dim chk As New DataGridViewCheckBoxColumn()
        dgvcustomer.Columns.Add(chk)
        chk.Name = "Choose"
        chk.HeaderText = "Choose"
        sql.addparam("@id", "%" & txtsearch.Text & "%")
        sql.execquery("select * from customer where name like @id")
        dgvcustomer.DataSource = sql.dbdt
    End Sub
    Private Sub deadall()
        reserv.Enabled = False
        checin.Enabled = False
        reqadd.Enabled = False
        checout.Enabled = False
        roomtype.Enabled = False
        masterroom.Enabled = False
        masitem.Enabled = False
        reserv.Visible = False
        checin.Visible = False
        reqadd.Visible = False
        checout.Visible = False
        roomtype.Visible = False
        masterroom.Visible = False
        masitem.Visible = False
        masemp.Enabled = False
        masemp.Visible = False
        cleanroom.Enabled = False
        cleanroom.Visible = False
        addhks.Enabled = False
        addhks.Visible = False
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posemp = Form1.posemp
        nameemp = Form1.nameemp
        Label2.Text = posemp
        loadroomtype()
        loaditem()
        loaddgv3()
        dgvroom1.Columns(0).Visible = False
        dgvroom1.Columns(4).Visible = False
        dgvcustomer.Columns(1).Visible = False
        '__________
        If posemp = "Admin" Then
            deadall()
            Label2.Text = posemp
            masemp.Enabled = True
            masemp.Visible = True
            masemp.Location = reserv.Location

        ElseIf posemp = "Front Office" Then
            deadall()
            Label2.Text = posemp
            reserv.Enabled = True
            checin.Enabled = True
            reqadd.Enabled = True
            checout.Enabled = True
            roomtype.Enabled = True
            masterroom.Enabled = True
            masitem.Enabled = True
            reserv.Visible = True
            checin.Visible = True
            reqadd.Visible = True
            checout.Visible = True
            roomtype.Visible = True
            masterroom.Visible = True
            masitem.Visible = True

        ElseIf posemp = "Housekeeper Supervisor" Then
            deadall()
            addhks.Enabled = True
            addhks.Visible = True
            addhks.Location = reserv.Location

        ElseIf posemp = "Housekeeper" Then
            deadall()
            cleanroom.Enabled = True
            cleanroom.Visible = True
            cleanroom.Location = reserv.Location

        End If
        '_______

        dgvitem.Columns.Add("item ID", "item ID")
        dgvitem.Columns.Add("Item name", "item name")
        dgvitem.Columns.Add("Qty", "Qty")
        dgvitem.Columns.Add("Price", "Price")
        dgvitem.Columns.Add("Total Price", "Total Price")

        dgvitem.Columns.Add(btn)
        btn.HeaderText = "Remove"
        btn.Text = "Remove"
        btn.Name = "btn"
    End Sub
    ' __________

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        LoginForm1.Close()
    End Sub

    Private Sub roomtype_Click(sender As Object, e As EventArgs) Handles roomtype.Click
        mrt_form.Show()
        Me.Hide()
    End Sub

    Private Sub reserv_Click(sender As Object, e As EventArgs) Handles reserv.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub checin_Click(sender As Object, e As EventArgs) Handles checin.Click
        check_form.Show()
        Me.Hide()
    End Sub

    Private Sub reqadd_Click(sender As Object, e As EventArgs) Handles reqadd.Click
        rai_form.Show()
        Me.Hide()
    End Sub

    Private Sub checout_Click(sender As Object, e As EventArgs) Handles checout.Click
        cheout_form.Show()
        Me.Hide()
    End Sub

    Private Sub masterroom_Click(sender As Object, e As EventArgs) Handles masterroom.Click
        mr_form.Show()
        Me.Hide()
    End Sub

    Private Sub masitem_Click(sender As Object, e As EventArgs) Handles masitem.Click
        mi_form.Show()
        Me.Hide()
    End Sub

    Private Sub masemp_Click(sender As Object, e As EventArgs) Handles masemp.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub addhks_Click(sender As Object, e As EventArgs) Handles addhks.Click
        addhouseschedule_form.Show()
        Me.Hide()
    End Sub

    Private Sub cleanroom_Click(sender As Object, e As EventArgs) Handles cleanroom.Click
        cleaing_form.Show()
        Me.Hide()
    End Sub
    '__________

    Private Sub cbroomtype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbroomtype.SelectedIndexChanged
        loaddgvroom1()
    End Sub

    Private Sub btnright_Click(sender As Object, e As EventArgs) Handles btnright.Click
        If dgvroom1.SelectedCells.Count > 0 Then
            If dgvroom2.RowCount > 0 Then
                For Each drr As DataGridViewRow In dgvroom1.SelectedRows
                    Dim row As DataGridViewRow = CType(drr.Clone(), DataGridViewRow)
                    For i As Int32 = 0 To drr.Cells.Count - 1
                        row.Cells(i).Value = drr.Cells(i).Value
                    Next
                    dgvroom2.Rows.Add(row)
                    Dim it As Integer
                    it = dgvroom1.CurrentRow.Index
                    databtnleft = dgvroom1.Item(0, it).Value
                    For Each r As DataGridViewRow In dgvroom1.SelectedRows
                        dgvroom1.Rows.Remove(r)
                    Next
                Next
            Else
                dgvroom2.Columns.Add("id", "ID")
                dgvroom2.Columns.Add("roomnumber", "Room Number")
                dgvroom2.Columns.Add("roomfloor", "Room Floor")
                dgvroom2.Columns.Add("description", "Description")
                dgvroom2.Columns.Add("roomprice", "Room Price")
                dgvroom2.Columns(0).Visible = False
                dgvroom2.Columns(4).Visible = False
                For Each drr As DataGridViewRow In dgvroom1.SelectedRows
                    Dim row As DataGridViewRow = CType(drr.Clone(), DataGridViewRow)
                    For i As Int32 = 0 To drr.Cells.Count - 1
                        row.Cells(i).Value = drr.Cells(i).Value
                    Next
                    dgvroom2.Rows.Add(row)
                    For Each r As DataGridViewRow In dgvroom1.SelectedRows
                        dgvroom1.Rows.Remove(r)
                    Next
                Next
            End If
        Else
            MsgBox("please select one of the row")
        End If
    End Sub

    Private Sub dgvroom1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvroom1.CellClick
        Dim i As Integer
        i = dgvroom1.CurrentRow.Index
        dgvroom1.Rows(i).Selected = True
    End Sub
    Private Sub btnleft_Click(sender As Object, e As EventArgs) Handles btnleft.Click
        If dgvroom2.RowCount > 0 Then
            For Each r As DataGridViewRow In dgvroom2.SelectedRows
                dgvroom2.Rows.Remove(r)
                loaddgvroom1()
            Next
        Else
            MsgBox("no data to be deleted")
        End If
    End Sub

    Private Sub dgvroom2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvroom2.CellClick
        Dim i As Integer
        i = dgvroom2.CurrentRow.Index
        dgvroom2.Rows(i).Selected = True
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        loaddgvroom1()
    End Sub

    Private Sub rbsearch_CheckedChanged(sender As Object, e As EventArgs) Handles rbsearch.CheckedChanged
        If rbsearch.Checked = True Then
            lblnem.Visible = False
            lblnum.Visible = False
            txtname.Visible = False
            txtnumber.Visible = False
            dgvcustomer.Visible = True
            lblsearch.Visible = True
            txtsearch.Visible = True
        Else
            lblnem.Visible = True
            lblnum.Visible = True
            txtname.Visible = True
            txtnumber.Visible = True
            dgvcustomer.Visible = False
            lblsearch.Visible = False
            txtsearch.Visible = False
        End If

    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        loaddgv3()
    End Sub

    Private Sub dgvcustomer_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcustomer.CellValueChanged
        If e.ColumnIndex = checkenin Then
            Dim isChecked As Boolean = CType(Me.dgvcustomer(e.ColumnIndex, e.RowIndex).Value, Boolean)
            If isChecked Then
                For Each row As DataGridViewRow In Me.dgvcustomer.Rows
                    row.Cells(e.ColumnIndex).Value = False
                Next
            End If
        Else
        End If
    End Sub
    Public Sub merge(ByVal row As Integer)
        Dim asa As Integer
        asa = row + 1
        If dgvitem.Item(0, row).Value = dgvitem.Item(0, asa).Value Then
            ' Sum up index
            dgvitem.Item(0, row).Value = dgvitem.Item(0, row).Value + dgvitem.Item(0, asa).Value
            ' Remove one row
            dgvitem.Rows.RemoveAt(asa)
            ' Message to warn there is a merge
        Else
        End If

        ' Same


        ' Merge

    End Sub
    Public Sub cariid()
        sql.addparam("ID", cbitem.Text)
        sql.execquery("select * from item where Name=@ID")
        For Each r As DataRow In sql.dbdt.Rows
            iid = r("Id")
            iprice = r("requestPrice")
        Next
    End Sub
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If numqty.Value = 0 Then
            MsgBox("item must be greater than 0")
        Else
            btn.UseColumnTextForButtonValue = True
            iname = cbitem.Text
            iqty = numqty.Value
            cariid()
            itot = iqty * iprice
            Dim id As Integer
            Dim name As String = cbitem.Text
            Dim qty As Integer = numqty.Value
            Dim price As Integer
            sql.addparam("@id", cbitem.Text)
            sql.execquery("select * from item where name=@id")
            For Each r As DataRow In sql.dbdt.Rows
                id = r("id")
                price = r("requestprice")
            Next
            Dim lol As String() = New String() {id, name, qty, price, itot}
            dgvitem.Rows.Add(lol)
            Dim bolDuplicateWasFound As Boolean = False
            If dgvitem.RowCount > 1 Then
                For x As Integer = 0 To dgvitem.Rows.Count - 1
                    For y As Integer = 0 To dgvitem.Rows.Count - 1
                        If y <> x AndAlso dgvitem.Rows(x).Cells(0).Value = dgvitem.Rows(y).Cells(0).Value Then
                            Dim removex As DataGridViewRow = dgvitem.Rows(x)
                            Dim removey As DataGridViewRow = dgvitem.Rows(y)
                            bolDuplicateWasFound = True
                            Dim newid As Integer = dgvitem.Rows(x).Cells(0).Value
                            Dim newname As String = dgvitem.Rows(x).Cells(1).Value
                            Dim newqty As Integer = Val(Convert.ToInt32(dgvitem.Rows(x).Cells(2).Value) + Convert.ToInt32(dgvitem.Rows(y).Cells(2).Value))
                            Dim newprice As Integer = dgvitem.Rows(x).Cells(3).Value
                            Dim newitot As Integer = newqty * newprice
                            Dim lol2 As String() = New String() {newid, newname, newqty, newprice, newitot}
                            dgvitem.Rows.Add(lol2)
                            dgvitem.Rows.Remove(removex)
                            dgvitem.Rows.Remove(removey)
                            Exit Sub
                        End If
                    Next
                Next
                If Not bolDuplicateWasFound Then

                End If
            End If
        End If
    End Sub

    Private Sub dgvitem_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvitem.CellContentClick
        If e.ColumnIndex = 5 Then
            Dim row As DataGridViewRow = dgvitem.SelectedRows(e.RowIndex)
            dgvitem.Rows.Remove(row)
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        hargaitem()
        hargakamar()
        Label12.Text = ic + rb
        insertreservation()
        reservationroominsert()
        insertrequestItem()
        MsgBox("Here Your Code " + randomtext)
    End Sub
    Public Sub cariRSVRID()
        sql.addparam("@RoomID", dgvroom2.Rows(0).Cells(1).Value)
        sql.addparam("@reservationID", rsvID)
        sql.execquery("select * from reservationroom where RoomID=@roomID and ReservationID=@reservationID")
        For Each r As DataRow In sql.dbdt.Rows
            rsvrID = r("ID")
        Next
    End Sub

    Public Sub insertrequestItem()
        cariRSVRID()
        If dgvitem.RowCount > 0 Then
            For x As Integer = 0 To dgvitem.Rows.Count - 1
                sql.addparam("@reservationRoomID", rsvrID)
                sql.addparam("@ItemID", dgvitem.Rows(x).Cells(0).Value)
                sql.addparam("@qty", dgvitem.Rows(x).Cells(2).Value)
                sql.addparam("@TotalPrice", dgvitem.Rows(x).Cells(4).Value)
                sql.execquery("insert into reservationrequestItem(ReservationRoomID,itemID,Qty,TotalPrice) values (ReservationRoomID,itemID,Qty,TotalPrice)")
            Next
        Else
        End If
    End Sub
    Public Sub hargaitem()
        If c = 0 Then
            If dgvitem.RowCount > 0 Then
                For x As Integer = 0 To dgvitem.Rows.Count - 1
                    Dim rhot As Integer = Val(Convert.ToInt32(dgvitem.Rows(x).Cells(4).Value)) '
                    Dim ac As Integer = ic
                    Dim m As String = rhot + ac
                    ic = m
                Next
                c = 1
            End If
        Else
            Label12.Text = "Rp.0"
            If dgvitem.RowCount > 0 Then
                For x As Integer = 0 To dgvitem.Rows.Count - 1
                    Dim rhot As Integer = Val(Convert.ToInt32(dgvitem.Rows(x).Cells(4).Value))
                    Dim ac As Integer = ic
                    Dim m As String = rhot + ac
                    ic = ic + m
                Next
            End If
        End If
    End Sub
    Public Sub hargakamar()
        If b = 0 Then
            If dgvroom2.RowCount > 0 Then
                For x As Integer = 0 To dgvroom2.Rows.Count - 1
                    Dim rhot As Integer = Val(Convert.ToInt32(dgvroom2.Rows(x).Cells(4).Value))
                    Dim ac As Integer = txtnight.Text * rhot
                    rb = rb + ac
                Next
            End If
            b = 1
        Else
            If dgvroom2.RowCount > 0 Then
                For x As Integer = 0 To dgvroom2.Rows.Count - 1
                    Dim rhot As Integer = Val(Convert.ToInt32(dgvroom2.Rows(x).Cells(4).Value))
                    Dim ac As Integer = txtnight.Text * rhot
                    rb = rb + ac
                Next
            End If
        End If
    End Sub
    Public Sub insertreservation()
        cariIDemp()
        If rbadd.Checked = True Then
            newcustomer()
            cariidcustomerbaru()
        End If
        Dim datetim As DateTime = DateTime.Now
        ngerandom()
        sql.addparam("@Datetime", datetim)
        sql.addparam("@EmployeeID", empID)
        sql.addparam("@customerID", cusID)
        sql.addparam("@kode", randomtext)
        sql.execquery("insert into reservation(DateTime,EmployeeID,customerID,code) values(@DateTime,@employeeID,@customerID,@kode) ")
        If sql.hasexception(True) Then Exit Sub
    End Sub
    Public Sub rsvIDfind()
        sql.execquery("select max(ID) as 'ID' from Reservation")
        For Each r As DataRow In sql.dbdt.Rows
            rsvID = r("ID")
        Next
    End Sub
    Public Sub reservationroominsert()
        rsvIDfind()
        If dgvroom2.RowCount > 0 Then
            For x As Integer = 0 To dgvroom2.Rows.Count - 1
                sql.addparam("@ReservationID", rsvID)
                sql.addparam("@RoomID", dgvroom2.Rows(x).Cells(1).Value)
                sql.addparam("@startdatetime", startdate.Value.Date)
                sql.addparam("@durationNight", txtnight.Text)
                sql.addparam("@roomprice", dgvroom2.Rows(x).Cells(4).Value)
                sql.execquery("insert into reservationRoom(ReservationID,RoomID,StartDateTime,DurationNight,RoomPrice) values(@ReservationID,@RoomID,@StartDateTime,@DurationNight,@RoomPrice)")
            Next
        Else
            MsgBox("please select room First")
        End If
    End Sub
    Private Sub ngerandom()
        Dim random As New Random
        Dim allowChrs() As Char = "ABCDEFGHIJKLOMNOPQRSTUVWXYZ0123456789".ToCharArray()
        For i As Integer = 1 To 6
            randomtext += allowChrs(random.Next(0, allowChrs.Length))
        Next
    End Sub
    Public Sub cariIDemp()
        sql.addparam("@name", nameemp)
        sql.execquery("select * from employee where Name=@Name")
        For Each r As DataRow In sql.dbdt.Rows
            empID = r("ID")
        Next
    End Sub
    Public Sub newcustomer()
        sql.addparam("@Number", txtnumber.Text)
        sql.addparam("@Name", txtname.Text)
        sql.execquery("insert into customer(Name,Phonenumber) values(@name,@Number) ")
        Label8.Text = "njirr"

    End Sub
    Public Sub cariidcustomerbaru()
        sql.addparam("@Number", txtnumber.Text)
        sql.addparam("@Name", txtname.Text)
        sql.execquery("select * from customer where Name=@Name and PhoneNumber=@Number")
        For Each r As DataRow In sql.dbdt.Rows
            cusID = r("ID")
        Next
    End Sub


    Private Sub dgvcustomer_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcustomer.CellContentClick
        cusID = dgvcustomer.Rows(e.RowIndex).Cells(1).Value
    End Sub
End Class
