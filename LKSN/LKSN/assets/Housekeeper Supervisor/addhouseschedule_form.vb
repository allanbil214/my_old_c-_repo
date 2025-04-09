Public Class addhouseschedule_form
    Public nameemp As String
    Public posemp As String
    Private sql As New Squek
    Private empid As Integer
    Private roomid As Integer
    Private crid As Integer
    Dim btn As New DataGridViewButtonColumn
    Private id As Integer
    Private auto As Integer = 0
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
        Label1.Text = auto
        posemp = Form1.posemp
        nameemp = Form1.nameemp
        Label2.Text = posemp
        loadkeeper()
        loadroomnum()
        filtering()
        dgv1.Columns(0).Visible = False
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
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub cleanroom_Click(sender As Object, e As EventArgs) Handles cleanroom.Click
        cleaing_form.Show()
        Me.Hide()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
    Private Sub findempid()
        sql.addparam("@name", cbkeeper.Text)
        sql.execquery("select * from employee where jobid='4' and name=@name")
        For Each r As DataRow In sql.dbdt.Rows
            empid = r("ID")
        Next
    End Sub
    Private Sub findroomid()
        sql.addparam("@name", cbroomnum.Text)
        sql.execquery("select * from room where RoomNumber=@name")
        For Each r As DataRow In sql.dbdt.Rows
            roomid = r("ID")
        Next
    End Sub
    Private Sub findcrid()
        sql.addparam("@date", dtpdate.Value)
        sql.execquery("select coalesce(max(ID),'0') as highest from CleaningRoom")
        For Each r As DataRow In sql.dbdt.Rows
            crid = r("highest")
        Next
    End Sub
    Private Sub loadkeeper()
        cbkeeper.Items.Clear()
        sql.execquery("select * from employee where jobid='4'")
        For Each r As DataRow In sql.dbdt.Rows
            cbkeeper.Items.Add(r("Name"))
        Next
        If cbkeeper.Items.Count > 0 Then
            cbkeeper.SelectedIndex = 0
        End If
    End Sub
    Private Sub loadroomnum()
        cbroomnum.Items.Clear()
        sql.execquery("select * from room")
        For Each r As DataRow In sql.dbdt.Rows
            cbroomnum.Items.Add(r("RoomNumber"))
        Next
        If cbroomnum.Items.Count > 0 Then
            cbroomnum.SelectedIndex = 0
        End If
    End Sub
    Private Sub filtering()
        sql.addparam("@id", dtpdate.Value.Date)
        sql.addparam("@name", cbkeeper.Text)
        sql.execquery("select CleaningRoom.ID,CleaningRoom.Date,Employee.Name as 'Housekeeper Name',room.RoomNumber as 'Room Number' from CleaningRoom " &
               "inner join CleaningRoomDetail On CleaningRoom.id = CleaningRoomDetail.CleaningRoomID " &
               "inner join Employee on Employee.ID = CleaningRoom.EmployeeID " &
               "inner Join Room on Room.ID = CleaningRoomDetail.RoomID " &
               "where CleaningRoom.date=@id and Employee.Name=@name " &
               "group by CleaningRoom.ID,CleaningRoom.Date,Employee.Name,room.Roomnumber ")
        dgv1.DataSource = sql.dbdt


    End Sub
    Private Sub dtpdate_ValueChanged(sender As Object, e As EventArgs) Handles dtpdate.ValueChanged
        filtering()
    End Sub

    Private Sub cbkeeper_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbkeeper.SelectedIndexChanged
        filtering()
    End Sub
    Private Sub insertdata1()
        findempid()
        sql.addparam("@date", dtpdate.Value)
        sql.addparam("@empid", empid)
        sql.execquery("insert into CleaningRoom (Date,EmployeeID) values(@date,@empid)")
        If sql.hasexception(True) Then Exit Sub
    End Sub
    Private Sub insertdata2()
        findroomid()
        findcrid()
        sql.addparam("@date", dtpdate.Value)
        sql.addparam("@roomid", roomid)
        sql.addparam("@crid", crid)
        sql.execquery("insert into CleaningRoomDetail (CleaningRoomID,RoomID,StartDateTime) values (@crid,@roomid,@date)")
        If sql.hasexception(True) Then Exit Sub
    End Sub
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        insertdata1()
        insertdata2()
        filtering()
        MsgBox("Success")
    End Sub
    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        If auto = 0 Then
            If e.ColumnIndex = 4 Then
                auto = auto + 1
                sql.addparam("@delete", dgv1.Item(0, e.RowIndex).Value)
                sql.execquery("delete CleaningRoomDetail Where CleaningRoomID=@delete")
                If sql.hasexception(True) Then Exit Sub
                sql.addparam("@delete", dgv1.Item(0, e.RowIndex).Value)
                sql.execquery("delete CleaningRoom where ID=@delete")
                If sql.hasexception(True) Then Exit Sub
                filtering()
            End If
        Else
            If e.ColumnIndex = 0 Then
                auto = 1
                sql.addparam("@delete", dgv1.Item(1, e.RowIndex).Value)
                sql.execquery("delete CleaningRoomDetail Where CleaningRoomID=@delete")
                If sql.hasexception(True) Then Exit Sub
                sql.addparam("@delete", dgv1.Item(1, e.RowIndex).Value)
                sql.execquery("delete CleaningRoom where ID=@delete")
                If sql.hasexception(True) Then Exit Sub
                filtering()
            End If
        End If

    End Sub
End Class