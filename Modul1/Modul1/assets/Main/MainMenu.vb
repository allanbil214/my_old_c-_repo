Public Class MainMenu
    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem1.Click
        LoginForm1.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

    End Sub

    Private Sub LogoutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem1.Click
        MasterToolStripMenuItem.Enabled = False
        TransactionToolStripMenuItem.Enabled = False
        ViewToolStripMenuItem.Enabled = False
        LoginToolStripMenuItem1.Enabled = True
        LogoutToolStripMenuItem1.Enabled = False
        ActiveMdiChild.Close()
        namestrip.Text = ""
        posstrip.Text = ""
    End Sub

    Private Sub EmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MemberToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            MemberForm.MdiParent = Me
            MemberForm.Show()
            MemberForm.WindowState = FormWindowState.Maximized

        Else
            MemberForm.MdiParent = Me
            MemberForm.Show()
            MemberForm.WindowState = FormWindowState.Maximized
        End If


    End Sub

    Private Sub PromoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PromoToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            PromoForm.MdiParent = Me
            PromoForm.Show()
            PromoForm.WindowState = FormWindowState.Maximized

        Else
            PromoForm.MdiParent = Me
            PromoForm.Show()
            PromoForm.WindowState = FormWindowState.Maximized
        End If
    End Sub
End Class