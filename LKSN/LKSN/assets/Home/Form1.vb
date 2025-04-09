Public Class Form1
    Public nameemp As String
    Public posemp As String
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
        me_form.Show()
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
End Class
