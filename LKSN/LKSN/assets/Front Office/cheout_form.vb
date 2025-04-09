Public Class cheout_form
    Public nameemp As String
    Public posemp As String
    Private sql As New Squek
    Private price As Integer
    Private total As Integer
    Private itemcount As Integer
    Private newtotal As Integer
    Private newnumqty As Integer
    Private idroom As Integer
    Private idreservroom As Integer
    Private iditem As Integer
    Private idstatusitem As Integer
    Private durnight As Integer
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
        loadcbitem()
        loadcbitemstatus()
        loadcbroomnum()
        dgv1.ColumnCount = 5
        dgv1.Columns(0).Name = "Item"
        dgv1.Columns(1).Name = "Qty"
        dgv1.Columns(2).Name = "Total Price"
        dgv1.Columns(3).Name = "Status"
        dgv1.Columns(4).Name = "ID"
        dgv1.Columns(3).Visible = False
        dgv1.Columns(4).Visible = False
        Dim btn As New DataGridViewButtonColumn()
        dgv1.Columns.Add(btn)
        btn.HeaderText = "Remove"
        btn.Text = "Remove"
        btn.Name = "btn"
        btn.UseColumnTextForButtonValue = True
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

    End Sub


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
        rserv_form.Show()
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
        Form1.Show()
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

    Private Sub loadcbroomnum()
        sql.execquery("select room.RoomNumber as num from Room
                       inner join ReservationRoom on reservationroom.roomid = room.id
                       where reservationroom.CheckOutDateTime is null and ReservationRoom.CheckInDateTime is not null	")
        For Each r As DataRow In sql.dbdt.Rows
            cbroomnum.Items.Add(r("num"))
            cbroomnum.Text = r("num")
        Next
    End Sub
    Private Sub loadcbitem()
        sql.execquery("select * from item")
        For Each r As DataRow In sql.dbdt.Rows
            cbitem.Items.Add(r("name"))
            cbitem.Text = (r("name"))
        Next
    End Sub
    Private Sub loadcbitemstatus()
        sql.execquery("select * from itemstatus")
        For Each r As DataRow In sql.dbdt.Rows
            cbitemstatus.Items.Add(r("name"))
            cbitemstatus.Text = r("name")
        Next
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If numqty.Value = 0 Then
            MsgBox("atleast item is more than 0")
        Else
            total = Val(price * numqty.Value)
            Dim row As String() = New String() {cbitem.Text, numqty.Value, total, cbitemstatus.Text, iditem}
            dgv1.Rows.Add(row)
            Dim bolDuplicateWasFound As Boolean = False
            If dgv1.RowCount > 1 Then
                For x As Integer = 0 To dgv1.Rows.Count - 1
                    For y As Integer = 0 To dgv1.Rows.Count - 1
                        If y <> x AndAlso dgv1.Rows(x).Cells(0).Value = dgv1.Rows(y).Cells(0).Value Then
                            Dim removex As DataGridViewRow = dgv1.Rows(x)
                            Dim removey As DataGridViewRow = dgv1.Rows(y)
                            bolDuplicateWasFound = True
                            Dim newname As String = dgv1.Rows(x).Cells(0).Value
                            Dim newqty As Integer = Val(Convert.ToInt32(dgv1.Rows(x).Cells(1).Value) + Convert.ToInt32(dgv1.Rows(y).Cells(1).Value))
                            Dim newprice As Integer = Val(Convert.ToInt32(dgv1.Rows(x).Cells(2).Value) + Convert.ToInt32(dgv1.Rows(y).Cells(2).Value))
                            Dim newitot As String = dgv1.Rows(x).Cells(3).Value
                            Dim newiditem As Integer = dgv1.Rows(x).Cells(4).Value
                            Dim lol2 As String() = New String() {newname, newqty, newprice, newitot, newiditem}
                            dgv1.Rows.Add(lol2)
                            dgv1.Rows.Remove(removex)
                            dgv1.Rows.Remove(removey)
                            Exit Sub
                        End If
                    Next
                Next
                If Not bolDuplicateWasFound Then
                End If
            End If
            If dgv1.RowCount > 0 And dgv1.RowCount < 2 Then
                Dim tot As Integer
                Try
                    For x = 0 To dgv1.Columns.Count - 2
                        tot += dgv1.Rows(x).Cells(2).Value
                        lblchange.Text = tot
                    Next
                Catch ex As Exception
                    'MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub cbitem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbitem.SelectedIndexChanged
        sql.addparam("@id", cbitem.Text)
        sql.execquery("select * from item where name=@id")
        For Each r As DataRow In sql.dbdt.Rows
            price = r("requestprice")
            iditem = r("id")
        Next
    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellContentClick
        If e.ColumnIndex = 5 Then
            Dim removex As DataGridViewRow = dgv1.Rows(e.RowIndex)
            dgv1.Rows.Remove(removex)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If dgv1.RowCount > 0 Then
            Dim tot As Integer
            Try
                For x = 0 To dgv1.Columns.Count - 2
                    tot += dgv1.Rows(x).Cells(2).Value
                    lblchange.Text = tot
                Next
            Catch ex As Exception
            End Try
        ElseIf dgv1.RowCount = 0 Then
            lblchange.Text = "0"
        End If
    End Sub
    Private Sub loaddatareservroomid()
        sql.addparam("@id", idroom)
        sql.execquery("select * from reservationroom 
                       where CheckOutDateTime is null and RoomID=@id and CheckInDateTime is not null")
        For Each r As DataRow In sql.dbdt.Rows
            idreservroom = r("id")
        Next
    End Sub
    Private Sub updatereservroom()
        sql.addparam("@id", idroom)
        sql.addparam("@outdate", DateTime.Now)
        sql.execquery("update reservationroom set CheckOutDateTime=@outdate 
                       where roomid=@id and CheckInDateTime is not null and CheckOutDateTime is null")
    End Sub
    Private Sub submitting()
        sql.addparam("@idreserv", idreservroom)
        sql.addparam("@iditem", iditem)
        sql.addparam("@idstatus", idstatusitem)
        Dim tot As Integer
        Try
            For x = 0 To dgv1.Columns.Count - 2
                tot += dgv1.Rows(x).Cells(1).Value
            Next
        Catch ex As Exception
        End Try
        sql.addparam("@qty", tot)
        sql.addparam("@total", lblchange.Text)
        sql.execquery("insert into reservationcheckout(ReservationRoomID,ItemID,ItemStatusID,Qty,TotalCharge) 
                       values (@idreserv,@iditem,@idstatus,@qty,@total)")
        MsgBox("Berhasil")
    End Sub

    Private Sub cbroomnum_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbroomnum.SelectedIndexChanged
        sql.addparam("@id", cbroomnum.Text)
        sql.execquery("select * from room where roomnumber=@id")
        For Each r As DataRow In sql.dbdt.Rows
            idroom = r("id")
        Next
    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        loaddatareservroomid()
        updatereservroom()
        submitting()
    End Sub

    Private Sub cbitemstatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbitemstatus.SelectedIndexChanged
        sql.addparam("@id", cbitemstatus.Text)
        sql.execquery("select * from itemstatus where name=@id")
        For Each r As DataRow In sql.dbdt.Rows
            idstatusitem = r("id")
        Next
    End Sub
End Class