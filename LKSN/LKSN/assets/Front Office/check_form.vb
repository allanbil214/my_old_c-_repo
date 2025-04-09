Public Class check_form
    Public nameemp As String
    Public posemp As String
    Private sql As New Squek
    Private checkcount As Integer
    Private bookingcount As Integer
    Private gender As String
    Private realgender As String
    Private phonenumber As String
    Private namerer As String
    Private randomresult As String = ""
    Private roomid As String
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
        rbmale.Checked = True
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
        Form1.Show()
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

    Private Sub loaddata()
        sql.addparam("@id", txtbooking.Text)
        sql.execquery("select ReservationRoom.ReservationID, Room.RoomNumber, Room.RoomFloor, ReservationRoom.StartDateTime, 
                       ReservationRoom.DurationNights from ReservationRoom
                       inner join Room on room.ID = ReservationRoom.RoomID
					   inner join reservation on reservation.id = ReservationRoom.ReservationID
                       where CheckInDateTime is null and reservation.Code like @id")
        dgv1.DataSource = sql.dbdt
    End Sub
    Private Sub bookingcounting()
        sql.addparam("@id", txtbooking.Text)
        sql.execquery("select count(Code) as bookingcount from reservation where Code = @id")
        For Each r As DataRow In sql.dbdt.Rows
            bookingcount = r("bookingcount")
        Next
    End Sub
    Private Sub checkcounting()
        sql.execquery("select count(ReservationID) as checkcount from ReservationRoom where CheckInDateTime is null")
        For Each r As DataRow In sql.dbdt.Rows
            checkcount = r("checkcount")
        Next
    End Sub
    Private Sub txtsearch_Click(sender As Object, e As EventArgs) Handles txtsearch.Click
        bookingcounting()
        checkcounting()
        If bookingcount = 0 Then
            MsgBox("no booking id")
        Else
            If checkcount = 0 Then
                MsgBox("no pending room exist(s)")
            Else
                loaddata()
            End If
        End If
    End Sub
    Private Sub phonenumberer()
        sql.addparam("@number", txtnumber.Text)
        sql.execquery("select count(phonenumber) as phonecount from customer where phonenumber=@number")
        For Each r As DataRow In sql.dbdt.Rows
            phonenumber = r("phonecount")
        Next
    End Sub
    Private Sub findfromphone()
        sql.addparam("@id", txtnumber.Text)
        sql.execquery("select * from customer where phonenumber=@id")
        For Each r As DataRow In sql.dbdt.Rows
            txtname.Text = r("Name")
            txtnik.Text = r("NIK")
            txtemail.Text = r("Email")
            gender = r("gender")
            txtnumber.Text = r("phonenumber")
            txtage.Text = r("age")
        Next
    End Sub
    Private Sub findgender()
        If gender = "F" Then
            rbfemale.Checked = True
        Else
            rbmale.Checked = True
        End If
    End Sub
    Private Sub findexistingdata()
        sql.addparam("@id", txtname.Text)
        sql.execquery("select count(name) as counterer from customer where name=@id")
        For Each r As DataRow In sql.dbdt.Rows
            namerer = r("counterer")
        Next
    End Sub
    Private Sub insertdata()
        sql.addparam("@name", txtname.Text)
        sql.addparam("@nik", txtnik.Text)
        sql.addparam("@email", txtemail.Text)
        sql.addparam("@gender", realgender)
        sql.addparam("@number", txtnumber.Text)
        sql.addparam("@age", txtage.Text)
        sql.execquery("insert into customer (name,nik,email,gender,phonenumber,age) values (@name,@nik,@email,@gender,@number,@age)")
        If sql.hasexception(True) Then Exit Sub
        MsgBox("success inserting data")
    End Sub
    Private Sub updatedata()
        sql.addparam("@name", txtname.Text)
        sql.addparam("@nik", txtnik.Text)
        sql.addparam("@email", txtemail.Text)
        sql.addparam("@gender", realgender)
        sql.addparam("@number", txtnumber.Text)
        sql.addparam("@age", txtage.Text)
        sql.execquery("update customer set name=@name,nik=@nik,email=@email,gender=@gender,age=@age where phonenumber=@number")
        If sql.hasexception(True) Then Exit Sub
        MsgBox("success updating data")
    End Sub
    Private Sub randomizer()
        Dim random As New Random
        Dim allowChrs() As Char = "ABCDEFGHIJKLOMNOPQRSTUVWXYZ0123456789".ToCharArray()
        For i As Integer = 1 To 6
            randomresult += allowChrs(random.Next(0, allowChrs.Length))
        Next
    End Sub
    Private Sub txtnumber_TextChanged(sender As Object, e As EventArgs) Handles txtnumber.TextChanged
        phonenumberer()
        If phonenumber = 1 Then
            findfromphone()
            findgender()
        End If
    End Sub
    Private Sub rbmale_CheckedChanged(sender As Object, e As EventArgs) Handles rbmale.CheckedChanged
        realgender = "M"
    End Sub

    Private Sub rbfemale_CheckedChanged(sender As Object, e As EventArgs) Handles rbfemale.CheckedChanged
        realgender = "F"
    End Sub
    Private Sub updatecheckin()
        sql.addparam("@id", dgv1.Item(0, 0).Value)
        sql.addparam("@date", Date.Today)
        sql.execquery("update reservationroom set checkindatetime=@date where reservationid=@id")
        If sql.hasexception(True) Then Exit Sub
    End Sub
    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        findexistingdata()
        If txtbooking.Text = "" Then
            MsgBox("select booking/reservation first")
        Else
            If txtage.Text = "" Or txtemail.Text = "" Or txtname.Text = "" Or txtnik.Text = "" Or txtnumber.Text = "" Then
                MsgBox("fill all the field first")
            Else
                If sql.emailformat(txtemail.Text) = False Then
                    MsgBox("email wrong format")
                Else
                    If sql.phoneformat(txtnumber.Text) = True Then
                        If phonenumber = 0 Then
                            insertdata()
                            updatecheckin()
                            loaddata()
                        Else
                            updatedata()
                            updatecheckin()
                            loaddata()
                        End If
                    Else
                        MsgBox("not in phone number format")
                    End If
                End If
            End If
        End If

    End Sub

End Class