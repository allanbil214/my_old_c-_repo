Public Class mr_form
    Public nameemp As String
    Public posemp As String
    Private sql As New Squek
    Private roomname As String
    Private roomid As Integer
    Private inorup As String
    Private roomtyid As Integer
    Private realid As Integer
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
        loaddata()
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
        Form1.Show()
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
        sql.execquery("select * from room")
        dgv1.DataSource = sql.dbdt
        loadcb()
    End Sub
    Private Sub loadcb()
        cbtype.Items.Clear()
        sql.execquery("select * from roomtype")
        For Each r As DataRow In sql.dbdt.Rows
            cbtype.Items.Add(r("Name"))
        Next
    End Sub
    Private Sub findnameroom()
        sql.addparam("@id", roomid)
        sql.execquery("select * from roomtype where ID=@id")
        For Each r As DataRow In sql.dbdt.Rows
            cbtype.Text = r("Name")
        Next
    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        Dim i As Integer
        i = dgv1.CurrentRow.Index
        txtnumber.Text = dgv1.Item(2, i).Value
        roomid = dgv1.Item(1, i).Value
        findnameroom()
        txtfloor.Text = dgv1.Item(3, i).Value
        txtdesc.Text = dgv1.Item(4, i).Value.ToString
        realid = dgv1.Item(0, i).Value

    End Sub

    Private Sub btninsert_Click(sender As Object, e As EventArgs) Handles btninsert.Click
        txtnumber.Text = ""
        txtfloor.Text = ""
        txtdesc.Text = ""
        btninsert.Enabled = False
        btnupdate.Enabled = False
        btndel.Enabled = False
        btnsave.Enabled = True
        btncancel.Enabled = True
        inorup = "in"
        txtdesc.Enabled = True
        txtfloor.Enabled = True
        txtnumber.Enabled = True
        cbtype.Enabled = True
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        btninsert.Enabled = False
        btnupdate.Enabled = False
        btndel.Enabled = False
        btnsave.Enabled = True
        btncancel.Enabled = True
        inorup = "up"
        txtdesc.Enabled = True
        txtfloor.Enabled = True
        txtnumber.Enabled = True
        cbtype.Enabled = True
    End Sub
    Private Sub reload()
        btnsave.Enabled = False
        btncancel.Enabled = False
        btninsert.Enabled = True
        btndel.Enabled = True
        btnupdate.Enabled = True
        txtdesc.Enabled = False
        txtfloor.Enabled = False
        txtnumber.Enabled = False
        cbtype.Enabled = False
        loaddata()
        inorup = ""
        txtnumber.Text = ""
        txtfloor.Text = ""
        txtdesc.Text = ""
    End Sub
    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
        If txtnumber.Text = "" Or txtfloor.Text = "" Then
            MsgBox("Select some data first!", vbOKOnly, "Caution")
        Else
            If MsgBox("Are you sure want to delete this?", vbYesNo, "Caution") = vbYes Then
                sql.addparam("@name", txtnumber.Text)
                sql.execquery("delete room where RoomNumber=@name")
                If sql.hasexception(True) Then Exit Sub
                    MsgBox("Success")
                    loaddata()
                    reload()
                End If
            End If
    End Sub
    Private Sub insertdata()
        sql.addparam("@id", roomtyid)
        sql.addparam("@num", txtnumber.Text)
        sql.addparam("@floor", txtnumber.Text)
        sql.addparam("@desc", txtdesc.Text)
        sql.execquery("insert into room(RoomTypeID,RoomNumber,RoomFloor,Description) values (@id,@num,@floor,@desc)")
        If sql.hasexception(True) Then Exit Sub
        MsgBox("Success")
        loaddata()
        reload()
    End Sub
    Private Sub updatedata()
        sql.addparam("@realid", realid)
        sql.addparam("@id", roomtyid)
        sql.addparam("@num", txtnumber.Text)
        sql.addparam("@floor", txtnumber.Text)
        sql.addparam("@desc", txtdesc.Text)
        sql.execquery("update room set RoomTypeID=@id,RoomNumber=@num,RoomFloor=@floor,Description=@desc where ID=@realid")
        If sql.hasexception(True) Then Exit Sub
        MsgBox("Success")
        loaddata()
        reload()
    End Sub
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txtnumber.Text = "" Or txtfloor.Text = "" Then
            MsgBox("fill the blank textbox first!", vbOKOnly, "Caution")
        Else
            If IsNumeric(txtfloor.Text) = False Or IsNumeric(txtnumber.Text) = False Then
                MsgBox("the price textbox must in numeric", vbOKOnly, "Caution")
            Else
                If inorup = "in" Then
                    insertdata()
                ElseIf inorup = "up" Then
                    updatedata()
                End If
            End If
        End If
        loaddata()
        reload()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        loaddata()
        reload()
    End Sub

    Private Sub cbtype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbtype.SelectedIndexChanged
        sql.addparam("@name", cbtype.Text)
        sql.execquery("select * from roomtype where Name=@name")
        For Each r As DataRow In sql.dbdt.Rows
            roomtyid = r("ID")
        Next
    End Sub
End Class