Public Class LoginForm1
    Dim sql As New Squek
    Dim usercount As String
    Dim passcount As String
    Dim nameemp As String
    Dim pos As Integer
    Dim jobname As String
    Dim hashed As String
    Dim password As String
    Private Sub metuhash()
        sql.addparam("@user", UsernameTextBox.Text)
        sql.execquery("select * from employee where username=@user")
        For Each r As DataRow In sql.dbdt.Rows
            hashed = r("Password")
        Next
    End Sub
    Private Sub emailing()
        sql.addparam("@email", UsernameTextBox.Text)
        sql.execquery("select count(Username) as usercount from Employee where username=@email")
        For Each r As DataRow In sql.dbdt.Rows
            usercount = r("usercount")
        Next
    End Sub
    Sub TestDecoding()
        metuhash()
        Dim cipherText As String = hashed
        Dim wrapper As New Simple3Des(UsernameTextBox.Text)
        Try
            Dim plainText As String = wrapper.DecryptData(cipherText)
            password = plainText
        Catch ex As System.Security.Cryptography.CryptographicException
            MsgBox("The data could not be decrypted with the username.")
        End Try
    End Sub
    Private Sub passing()
        TestDecoding()

    End Sub
    Private Sub naming()
        sql.addparam("@email", UsernameTextBox.Text)
        sql.execquery("select * from employee where username=@email")
        For Each r As DataRow In sql.dbdt.Rows
            nameemp = r("Name")
            pos = r("JobID")
        Next
        jobidconverter()
    End Sub
    Private Sub jobidconverter()
        sql.addparam("@jobid", pos)
        sql.execquery("Select Name from Job where id=@jobid")
        For Each r As DataRow In sql.dbdt.Rows
            jobname = r("Name")
        Next
    End Sub

    Private Sub loggin()
        emailing()
        passing()

    End Sub


    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm1_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        UsernameTextBox.Text = ""
        PasswordTextBox.Text = ""
    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
            MsgBox("Fill The Textbox First")
        Else
            loggin()
            If PasswordTextBox.Text = password Then
                naming()
                MsgBox("Logged in as " + nameemp, vbOKOnly, "Congrats")
                Form1.posemp = jobname
                Form1.nameemp = nameemp
                Form1.Label2.Text = jobname
                Form1.Show()
                UsernameTextBox.Text = ""
                PasswordTextBox.Text = ""
                Me.Hide()
            ElseIf usercount = "0" And passcount = password Then
                MsgBox("Wrong username, please check your username again", vbCritical, "Caution")
            ElseIf usercount = "1" And passcount <> password Then
                MsgBox("Wrong password, please check your password again", vbCritical, "Caution")
            ElseIf UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
                MsgBox("username and password not yet filled, please fill it first!", vbCritical, "Caution")
            End If
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        testing.Show()
    End Sub
End Class
