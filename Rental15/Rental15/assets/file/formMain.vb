Public Class formMain
    Public userposisi As String
    Public userid As Integer
    Public usernama As String
    Private Sub menuLogin_Click(sender As Object, e As EventArgs) Handles menuLogin.Click
        formLogin.ShowDialog()
    End Sub

    Private Sub menuLogout_Click(sender As Object, e As EventArgs) Handles menuLogout.Click
        menuLogin.Enabled = True
        menuLogout.Enabled = False
        menuMaster.Enabled = False
        menuTransaksi.Enabled = False
        menuKaryawan.Enabled = False
        txtNama.Text = ""
        usernama = ""
        userid = 0
        userposisi = ""
    End Sub

    Private Sub CDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CDToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            formCD.MdiParent = Me
            formCD.Show()
            formCD.WindowState = FormWindowState.Maximized
        Else
            formCD.MdiParent = Me
            formCD.Show()
            formCD.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub menuKaryawan_Click(sender As Object, e As EventArgs) Handles menuKaryawan.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            formKaryawan.MdiParent = Me
            formKaryawan.Show()
            formKaryawan.WindowState = FormWindowState.Maximized
        Else
            formKaryawan.MdiParent = Me
            formKaryawan.Show()
            formKaryawan.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub PelangganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PelangganToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            formPelanggan.MdiParent = Me
            formPelanggan.Show()
            formPelanggan.WindowState = FormWindowState.Maximized
        Else
            formPelanggan.MdiParent = Me
            formPelanggan.Show()
            formPelanggan.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub DednaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DednaToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            formDenda.MdiParent = Me
            formDenda.Show()
        Else
            formDenda.MdiParent = Me
            formDenda.Show()
        End If
    End Sub

    Private Sub PeminjamanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PeminjamanToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            formPinjam.MdiParent = Me
            formPinjam.Show()
            formPinjam.WindowState = FormWindowState.Maximized
        Else
            formPinjam.MdiParent = Me
            formPinjam.Show()
            formPinjam.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub PengembalianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengembalianToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            formKembali.MdiParent = Me
            formKembali.Show()
            formKembali.WindowState = FormWindowState.Maximized
        Else
            formKembali.MdiParent = Me
            formKembali.Show()
            formKembali.WindowState = FormWindowState.Maximized
        End If
    End Sub
End Class
