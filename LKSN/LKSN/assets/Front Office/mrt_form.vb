Public Class mrt_form
    Public nameemp As String
    Public posemp As String
    Private sql As New Squek
    Private inorup As String
    Private id As String
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
        Form1.Show()
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
        addhouseschedule_form.Show()
        Me.Hide()
    End Sub

    Private Sub cleanroom_Click(sender As Object, e As EventArgs) Handles cleanroom.Click
        cleaing_form.Show()
        Me.Hide()
    End Sub
    Private Sub loaddata()
        sql.execquery("select * from roomtype")
        dgv1.DataSource = sql.dbdt
    End Sub
    Private Sub reload()
        btnsave.Enabled = False
        btncanc.Enabled = False
        btninsert.Enabled = True
        btndel.Enabled = True
        btnupdate.Enabled = True
        txtname.Enabled = False
        txtprice.Enabled = False
        numcap.Enabled = False
        loaddata()
        inorup = ""
        txtprice.Text = ""
        txtname.Text = ""
        numcap.Value = 0
    End Sub
    Private Sub btninsert_Click(sender As Object, e As EventArgs) Handles btninsert.Click
        inorup = ""
        txtprice.Text = ""
        txtname.Text = ""
        numcap.Value = 0
        btnsave.Enabled = True
        btncanc.Enabled = True
        inorup = "in"
        btninsert.Enabled = False
        btnupdate.Enabled = False
        btndel.Enabled = False
        txtname.Enabled = True
        txtprice.Enabled = True
        numcap.Enabled = True
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        btnsave.Enabled = True
        btncanc.Enabled = True
        inorup = "up"
        btninsert.Enabled = False
        btnupdate.Enabled = False
        btndel.Enabled = False
        txtname.Enabled = True
        txtprice.Enabled = True
        numcap.Enabled = True
    End Sub

    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
        If txtname.Text = "" Or numcap.Value = 0 Or txtprice.Text = "" Then
            MsgBox("Select some data first!", vbOKOnly, "Caution")
        Else
            If MsgBox("Are you sure want to delete this?", vbYesNo, "Caution") = vbYes Then
                sql.addparam("@name", txtname.Text)
                sql.execquery("delete roomtype where Name=@name")
                If sql.hasexception(True) Then Exit Sub
                MsgBox("Success")
                loaddata()
                reload()
            End If
        End If
    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        Dim i As Integer
        i = dgv1.CurrentRow.Index
        id = dgv1.Item(0, i).Value
        txtname.Text = dgv1.Item(1, i).Value
        numcap.Value = dgv1.Item(2, i).Value
        txtprice.Text = dgv1.Item(3, i).Value

    End Sub
    Private Sub insertdata()
        sql.addparam("@name", txtname.Text)
        sql.addparam("@num", numcap.Value)
        sql.addparam("@price", txtprice.Text)
        sql.execquery("insert into roomtype(Name,Capacity,RoomPrice) values (@name,@num,@price)")
        If sql.hasexception(True) Then Exit Sub
        MsgBox("Success")
        loaddata()
        reload()
    End Sub
    Private Sub updatedata()
        sql.addparam("@id", id)
        sql.addparam("@name", txtname.Text)
        sql.addparam("@num", numcap.Value)
        sql.addparam("@price", txtprice.Text)
        sql.execquery("update roomtype set Name=@name,Capacity=@num,RoomPrice=@price where ID=@id")
        If sql.hasexception(True) Then Exit Sub
        MsgBox("Success")
        loaddata()
        reload()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txtname.Text = "" Or numcap.Value = 0 Or txtprice.Text = "" Then
            MsgBox("fill the blank textbox first!", vbOKOnly, "Ca")
        Else
            If IsNumeric(txtprice.Text) = False Then
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

    Private Sub btncanc_Click(sender As Object, e As EventArgs) Handles btncanc.Click
        loaddata()
        reload()
    End Sub
End Class