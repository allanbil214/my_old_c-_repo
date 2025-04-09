Public Class MainForm

    Public Sub aktifmanajer()
        MasterToolStripMenuItem.Enabled = True
        TransactionToolStripMenuItem.Enabled = True
        ViewToolStripMenuItem.Enabled = True
        CDDVDToolStripMenuItem.Enabled = True
        MemberToolStripMenuItem.Enabled = True
        EmployeeToolStripMenuItem.Enabled = True
        PeminjamanToolStripMenuItem.Enabled = True
        PengembalianToolStripMenuItem.Enabled = True
        ViewPinjamDataToolStripMenuItem.Enabled = True
        ViewKembaliDataToolStripMenuItem.Enabled = True
    End Sub
    Public Sub aktifkasir()
        MasterToolStripMenuItem.Enabled = True
        TransactionToolStripMenuItem.Enabled = True
        ViewToolStripMenuItem.Enabled = False
        CDDVDToolStripMenuItem.Enabled = True
        MemberToolStripMenuItem.Enabled = True
        EmployeeToolStripMenuItem.Enabled = False
        PeminjamanToolStripMenuItem.Enabled = True
        PengembalianToolStripMenuItem.Enabled = True
        ViewPinjamDataToolStripMenuItem.Enabled = False
        ViewKembaliDataToolStripMenuItem.Enabled = False
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        Me.Hide()
        LoginForm.Show()
    End Sub

    Private Sub MainForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        LoginForm.Close()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        ChangePasswordForm.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub


    Private Sub CDDVDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CDDVDToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            KasetForm.MdiParent = Me
            KasetForm.Show()
            KasetForm.WindowState = FormWindowState.Maximized
        Else
            KasetForm.MdiParent = Me
            KasetForm.Show()
            KasetForm.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub EmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            KaryawanForm.MdiParent = Me
            KaryawanForm.Show()
            KaryawanForm.WindowState = FormWindowState.Maximized
        Else
            KaryawanForm.MdiParent = Me
            KaryawanForm.Show()
            KaryawanForm.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub MemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MemberToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            PelangganForm.MdiParent = Me
            PelangganForm.Show()
            PelangganForm.WindowState = FormWindowState.Maximized
        Else
            PelangganForm.MdiParent = Me
            PelangganForm.Show()
            PelangganForm.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub PeminjamanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PeminjamanToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            PinjamForm.MdiParent = Me
            PinjamForm.Show()
            PinjamForm.WindowState = FormWindowState.Maximized
        Else
            PinjamForm.MdiParent = Me
            PinjamForm.Show()
            PinjamForm.WindowState = FormWindowState.Maximized
        End If
    End Sub
End Class