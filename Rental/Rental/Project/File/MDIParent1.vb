Imports System.Windows.Forms

Public Class MDIParent1
    Public adminkah As Integer
    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub MDIParent1_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        Form1.Close()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Hide()
        ActiveMdiChild.Close()
        Form1.Show()
    End Sub

    Private Sub PegawaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PegawaToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            Pegawai.MdiParent = Me
            Pegawai.Show()
            Pegawai.WindowState = FormWindowState.Maximized
        Else
            Pegawai.MdiParent = Me
            Pegawai.Show()
            Pegawai.WindowState = FormWindowState.Maximized
        End If
    End Sub
    Private Sub MemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MemberToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            Member.MdiParent = Me
            Member.Show()
            Member.WindowState = FormWindowState.Maximized
        Else
            Member.MdiParent = Me
            Member.Show()
            Member.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub KasetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KasetToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            Kaset.MdiParent = Me
            Kaset.Show()
            Kaset.WindowState = FormWindowState.Maximized
        Else
            Kaset.MdiParent = Me
            Kaset.Show()
            Kaset.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub PeminjamanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PeminjamanToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            Peminjam.MdiParent = Me
            Peminjam.Show()
            Peminjam.WindowState = FormWindowState.Maximized
        Else
            Peminjam.MdiParent = Me
            Peminjam.Show()
            Peminjam.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub PengembalianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengembalianToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            Kembali.MdiParent = Me
            Kembali.Show()
            Kembali.WindowState = FormWindowState.Maximized
        Else
            Kembali.MdiParent = Me
            Kembali.Show()
            Kembali.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If adminkah = 0 Then
            PegawaToolStripMenuItem.Enabled = False
            MemberToolStripMenuItem.Enabled = False
            Peminjam.tglkembali.Enabled = False
            Kembali.tgldikembali.Enabled = False
        Else
            PegawaToolStripMenuItem.Enabled = True
            MemberToolStripMenuItem.Enabled = True
            Peminjam.tglkembali.Enabled = True
            Kembali.tgldikembali.Enabled = True
        End If
    End Sub

    Private Sub PengaturanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengaturanToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            Pengaturan.MdiParent = Me
            Pengaturan.Show()
            'Pengaturan.WindowState = FormWindowState.Maximized
        Else
            Pengaturan.MdiParent = Me
            Pengaturan.Show()
            'Pengaturan.WindowState = FormWindowState.Maximized
        End If
    End Sub
End Class
