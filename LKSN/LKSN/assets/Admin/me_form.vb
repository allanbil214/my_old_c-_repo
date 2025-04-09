Public Class me_form
    Public nameemp As String
    Public posemp As String
    Private sql As New Squek
    Private inorup As String
    Private realid As Integer
    Private passencrypt As String
    Private passdecrypt As String
    Private jobid As Integer
    Private jobidreverse As Integer
    Private usercount As Integer
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
        loadjob()
        posemp = Form1.posemp
        nameemp = Form1.nameemp
        Label10.Text = posemp
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
        addhouseschedule_form.Show()
        Me.Hide()
    End Sub

    Private Sub cleanroom_Click(sender As Object, e As EventArgs) Handles cleanroom.Click
        cleaing_form.Show()
        Me.Hide()
    End Sub
    Private Sub loaddata()
        sql.execquery("select * from 
                      Employee")
        dgv1.DataSource = sql.dbdt
    End Sub
    Private Sub cleaning()
        txtuser.Text = ""
        txtpass.Text = ""
        txtconfirm.Text = ""
        txtname.Text = ""
        txtemail.Text = ""
        txtaddress.Text = ""
    End Sub
    Private Sub backto()
        txtuser.Enabled = False
        txtpass.Enabled = False
        txtconfirm.Enabled = False
        txtname.Enabled = False
        txtemail.Enabled = False
        datebirth.Enabled = False
        cbjob.Enabled = False
        txtaddress.Enabled = False
        btnInsert.Enabled = True
        btnDelete.Enabled = True
        btnUpdate.Enabled = True
        btnSave.Enabled = False
        btnCancel.Enabled = False
    End Sub
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        cleaning()
        btnSave.Enabled = True
        btnCancel.Enabled = True
        btnInsert.Enabled = False
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
        txtuser.Enabled = True
        txtpass.Enabled = True
        txtconfirm.Enabled = True
        txtname.Enabled = True
        txtemail.Enabled = True
        datebirth.Enabled = True
        cbjob.Enabled = True
        txtaddress.Enabled = True
        inorup = "in"
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        btnSave.Enabled = True
        btnCancel.Enabled = True
        btnInsert.Enabled = False
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
        txtuser.Enabled = True
        txtpass.Enabled = True
        txtconfirm.Enabled = True
        txtname.Enabled = True
        txtemail.Enabled = True
        datebirth.Enabled = True
        cbjob.Enabled = True
        txtaddress.Enabled = True
        inorup = "up"
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        backto()
        cleaning()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtuser.Text = "" Or txtpass.Text = "" Or txtname.Text = "" Or txtemail.Text = "" Or txtconfirm.Text = "" Or txtaddress.Text = "" Then
            MsgBox("Select some data first!", vbOKOnly, "Caution")
        Else
            If MsgBox("Are you sure want to delete this?", vbYesNo, "Caution") = vbYes Then
                sql.addparam("@name", txtname.Text)
                sql.execquery("delete Employee where Name=@name")
                If sql.hasexception(True) Then Exit Sub
                MsgBox("Success")
                loaddata()
                cleaning()
                backto()
            End If
        End If
    End Sub
    Sub loadjob()
        sql.execquery("select * from job")
        For Each r As DataRow In sql.dbdt.Rows
            cbjob.Items.Add(r("name"))
        Next
    End Sub
    Sub findjobid()
        sql.addparam("@name", cbjob.Text)
        sql.execquery("select id from job where name=@name")
        For Each r As DataRow In sql.dbdt.Rows
            jobid = r("id")
        Next
    End Sub
    Private Sub encryptor()
        Dim wrapper As New Simple3Des(txtuser.Text)
        Dim cipherText As String = wrapper.EncryptData(txtpass.Text)
        passencrypt = cipherText
    End Sub
    Private Sub insertdata()
        encryptor()
        findjobid()
        sql.addparam("@id", realid)
        sql.addparam("@user", txtuser.Text)
        sql.addparam("@pass", passencrypt)
        sql.addparam("@name", txtname.Text)
        sql.addparam("@email", txtemail.Text)
        sql.addparam("@date", datebirth.Value)
        sql.addparam("@job", jobid)
        sql.addparam("@address", txtaddress.Text)
        sql.execquery("insert into employee(Username,Password,Name,Email,Address,DateOfBirth,JobID) values(@user,@pass,@name,@email,@address,@date,@job)")
        If sql.hasexception(True) Then Exit Sub
        MsgBox("Success")
        cleaning()
        backto()
    End Sub
    Private Sub updatedata()
        encryptor()
        findjobid()
        sql.addparam("@id", realid)
        sql.addparam("@user", txtuser.Text)
        sql.addparam("@pass", passencrypt)
        sql.addparam("@name", txtname.Text)
        sql.addparam("@email", txtemail.Text)
        sql.addparam("@date", datebirth.Value)
        sql.addparam("@job", jobid)
        sql.addparam("@address", txtaddress.Text)
        sql.execquery("update employee set username=@user,password=@pass,name=@name,email=@email,address=@address,dateofbirth=@date,jobid=@job where ID=@id")
        If sql.hasexception(True) Then Exit Sub
        MsgBox("Success")
        cleaning()
        backto()
    End Sub
    Sub usercountin()
        sql.addparam("@name", txtuser.Text)
        sql.execquery("select count(username) as usercount from employee where username=@name")
        For Each r As DataRow In sql.dbdt.Rows
            usercount = r("usercount")
        Next
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtuser.Text = "" Or txtpass.Text = "" Or txtname.Text = "" Or txtemail.Text = "" Or txtconfirm.Text = "" Or txtaddress.Text = "" Then
            MsgBox("fill the blank textbox first!", vbOKOnly, "Caution")
        Else
            If usercount = 1 Then
                MsgBox("username already exist")
            Else
                If sql.emailformat(txtemail.Text) = True Then
                    If txtuser.TextLength < 2 Then
                        MsgBox("username must greater than 2 letter")
                    Else
                        If txtpass.Text <> txtconfirm.Text Then
                            MsgBox("password different")
                        Else
                            If inorup = "in" Then
                                insertdata()
                            ElseIf inorup = "up" Then
                                updatedata()
                            End If
                        End If
                    End If
                Else
                    MsgBox("not an email")
                End If
            End If
        End If
        loaddata()
    End Sub

    Private Sub cbjob_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbjob.SelectedIndexChanged
        findjobid()
    End Sub
    Sub decryptor()
        Dim cipherText As String = passdecrypt
        Dim wrapper As New Simple3Des(txtuser.Text)
        Try
            Dim plainText As String = wrapper.DecryptData(cipherText)
            txtpass.Text = plainText
            txtconfirm.Text = plainText
        Catch ex As System.Security.Cryptography.CryptographicException
            MsgBox("The data could not be decrypted with the username.")
        End Try
    End Sub
    Sub findcbexact()
        sql.addparam("@id", jobidreverse)
        sql.execquery("select * from job where id=@id")
        For Each r As DataRow In sql.dbdt.Rows
            cbjob.Text = r("name")
        Next
    End Sub
    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        Dim i As Integer
        i = dgv1.CurrentRow.Index
        realid = dgv1.Item(0, i).Value
        txtuser.Text = dgv1.Item(1, i).Value
        passdecrypt = dgv1.Item(2, i).Value
        txtname.Text = dgv1.Item(3, i).Value
        txtemail.Text = dgv1.Item(4, i).Value
        txtaddress.Text = dgv1.Item(5, i).Value
        datebirth.Value = dgv1.Item(6, i).Value
        jobidreverse = dgv1.Item(7, i).Value
        findcbexact()
        decryptor()
    End Sub
End Class