Public Class mi_form
    Public nameemp As String
    Private sql As New Squek
    Private inorup As String
    Public posemp As String
    Private realid As Integer
    Private namecount As Integer
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
        loaddata()
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
        Form1.Show()
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
        sql.execquery("select * from Item")
        dgv1.DataSource = sql.dbdt
    End Sub
    Private Sub backto()
        txtcomp.Enabled = False
        txtname.Enabled = False
        txtreq.Enabled = False
        btnsave.Enabled = False
        btncancel.Enabled = False
        btninsert.Enabled = True
        btnupdate.Enabled = True
        btndelete.Enabled = True
    End Sub
    Private Sub cleaning()
        txtcomp.Text = ""
        txtname.Text = ""
        txtreq.Text = ""
    End Sub
    Private Sub btninsert_Click(sender As Object, e As EventArgs) Handles btninsert.Click
        btnsave.Enabled = True
        btncancel.Enabled = True
        btninsert.Enabled = False
        btnupdate.Enabled = False
        btndelete.Enabled = False
        txtcomp.Enabled = True
        txtname.Enabled = True
        txtreq.Enabled = True
        txtcomp.Text = ""
        txtname.Text = ""
        txtreq.Text = ""
        inorup = "in"
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        btnsave.Enabled = True
        btncancel.Enabled = True
        btninsert.Enabled = False
        btnupdate.Enabled = False
        btndelete.Enabled = False
        txtcomp.Enabled = True
        txtname.Enabled = True
        txtreq.Enabled = True
        inorup = "up"
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        cleaning()
        backto()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If txtcomp.Text = "" Or txtname.Text = "" Or txtreq.Text = "" Then
            MsgBox("Select some data first!", vbOKOnly, "Caution")
        Else
            If MsgBox("Are you sure want to delete this?", vbYesNo, "Caution") = vbYes Then
                sql.addparam("@name", txtname.Text)
                sql.execquery("delete item where Name=@name")
                If sql.hasexception(True) Then Exit Sub
                MsgBox("Success")
                loaddata()
                cleaning()
                backto()
            End If
        End If
    End Sub
    Private Sub insertdata()
        sql.addparam("@req", txtreq.Text)
        sql.addparam("@comp", txtcomp.Text)
        sql.addparam("@name", txtname.Text)
        sql.execquery("insert into item (Name,RequestPrice,CompensationFee) values (@name,@req,@comp)")
        If sql.hasexception(True) Then Exit Sub
        MsgBox("Success")
        cleaning()
        backto()
    End Sub
    Sub namecounting()
        sql.addparam("@name", txtname.Text)
        sql.execquery("select count(name) as namecount from Item where name=@name")
        For Each r As DataRow In sql.dbdt.Rows
            namecount = r("namecount")
        Next
    End Sub
    Private Sub updatedata()
        sql.addparam("@id", realid)
        sql.addparam("@req", txtreq.Text)
        sql.addparam("@comp", txtcomp.Text)
        sql.addparam("@name", txtname.Text)
        sql.execquery("update item set Name=@name,RequestPrice=@req,CompensationFee=@comp where ID=@id ")
        If sql.hasexception(True) Then Exit Sub
        MsgBox("Success")
        cleaning()
        backto()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        namecounting()
        If txtname.Text = "" Or txtreq.Text = "" Then
            MsgBox("fill the blank textbox first!", vbOKOnly, "Caution")
        Else

            If IsNumeric(txtreq.Text) = False Or IsNumeric(txtcomp.Text) = False Then
                MsgBox("price must be in numeric")
            Else
                If inorup = "in" Then
                    If namecount = 1 Then
                        insertdata()
                    Else
                        MsgBox("Already exist")
                    End If
                ElseIf inorup = "up" Then
                        updatedata()
                    End If
                End If

            End If
        loaddata()
    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        Dim i As Integer
        i = dgv1.CurrentRow.Index
        realid = dgv1.Item(0, i).Value
        txtname.Text = dgv1.Item(1, i).Value.ToString
        txtcomp.Text = dgv1.Item(3, i).Value.ToString
        txtreq.Text = dgv1.Item(2, i).Value.ToString
    End Sub
End Class