Public Class LoginForm1
    Dim sql As New Squek
    Dim emailcount As Integer
    Dim passcount As Integer
    Dim nameemp As String
    Dim pos As String
    Private Sub emailing()
        sql.addparam("@email", UsernameTextBox.Text)
        sql.execquery("select count(email) as emailcount from employee where email=@email")
        For Each r As DataRow In sql.dbdt.Rows
            emailcount = r("emailcount")
        Next
    End Sub
    Private Sub passing()
        sql.addparam("@pass", PasswordTextBox.Text)
        sql.execquery("select count(passwords) as passcount from employee where passwords=@pass")
        For Each r As DataRow In sql.dbdt.Rows
            passcount = r("passcount")
        Next
    End Sub
    Private Sub naming()
        sql.addparam("@email", UsernameTextBox.Text)
        sql.addparam("@pass", PasswordTextBox.Text)
        sql.execquery("select * from employee where email=@email and passwords=@pass")
        For Each r As DataRow In sql.dbdt.Rows
            nameemp = r("Name")
            pos = r("position")
        Next
    End Sub
    Private Sub loadlevel()
        If pos = "Manager" Then
            MainMenu.MasterToolStripMenuItem.Enabled = True
            MainMenu.TransactionToolStripMenuItem.Enabled = True
            MainMenu.ViewToolStripMenuItem.Enabled = True
        ElseIf pos = "Cashier" Then
            MainMenu.MasterToolStripMenuItem.Enabled = False
            MainMenu.TransactionToolStripMenuItem.Enabled = True
            MainMenu.ViewToolStripMenuItem.Enabled = False
        End If
    End Sub
    Private Sub loggin()
        emailing()
        passing()
        If emailcount = "1" And passcount = "1" Then
            naming()
            MsgBox("Logged in as " + nameemp, vbOKOnly, "Congrats")
            MainMenu.posstrip.Text = pos
            MainMenu.namestrip.Text = nameemp
            MainMenu.LogoutToolStripMenuItem1.Enabled = True
            MainMenu.LoginToolStripMenuItem1.Enabled = False
            loadlevel()
            UsernameTextBox.Text = ""
            PasswordTextBox.Text = ""
            Me.Close()
        ElseIf emailcount = "0" And passcount = "1" Then
            MsgBox("Wrong email, please check your email again", vbCritical, "Caution")
        ElseIf emailcount = "1" And passcount = "0" Then
            MsgBox("Wrong password, please check your password again", vbCritical, "Caution")
        ElseIf UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
            MsgBox("Email and password not yet filled, please fill it first!", vbCritical, "Caution")
        ElseIf emailcount = "0" And passcount = "0" Then
            MsgBox("Both email and password is wrong", vbCritical, "Caution")
        End If
    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        loggin()
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm1_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        UsernameTextBox.Text = ""
        PasswordTextBox.Text = ""
    End Sub

    Private Sub LogoPictureBox_Click(sender As Object, e As EventArgs) Handles LogoPictureBox.Click
        UsernameTextBox.Text = "steven@esemka.com"
        PasswordTextBox.Text = "admin"
    End Sub
End Class
