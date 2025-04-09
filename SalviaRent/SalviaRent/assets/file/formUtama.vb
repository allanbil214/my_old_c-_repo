Public Class formUtama
    Public nameuser As String
    Public id As Integer
    Public posisi As String

    Private Sub LoginMenu_Click(sender As Object, e As EventArgs) Handles LoginMenu.Click
        LoginForm1.ShowDialog()
    End Sub

    Private Sub LogoutMenu_Click(sender As Object, e As EventArgs) Handles LogoutMenu.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            MasterMenu.Enabled = False
            TransMenu.Enabled = False
            LoginMenu.Enabled = True
            LogoutMenu.Enabled = False
            AturDendaMenu.Enabled = False
            RiwayatToolStripMenuItem.Enabled = False
            namastatus.Text = ""
        Else
            MasterMenu.Enabled = False
            TransMenu.Enabled = False
            LoginMenu.Enabled = True
            LogoutMenu.Enabled = False
            AturDendaMenu.Enabled = False
            namastatus.Text = ""
            RiwayatToolStripMenuItem.Enabled = False
        End If

    End Sub

    Private Sub CDMenu_Click(sender As Object, e As EventArgs) Handles CDMenu.Click
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

    Private Sub PelangganMenu_Click(sender As Object, e As EventArgs) Handles PelangganMenu.Click
        If ActiveMdiChild() IsNot Nothing Then
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

    Private Sub KaryawanMenu_Click(sender As Object, e As EventArgs) Handles KaryawanMenu.Click
        If ActiveMdiChild() IsNot Nothing Then
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

    Private Sub PinjamMenu_Click(sender As Object, e As EventArgs) Handles PinjamMenu.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            formPeminjaman.MdiParent = Me
            formPeminjaman.Show()
            formPeminjaman.WindowState = FormWindowState.Maximized
        Else
            formPeminjaman.MdiParent = Me
            formPeminjaman.Show()
            formPeminjaman.WindowState = FormWindowState.Maximized
        End If
    End Sub


    Private Sub KembaliMenu_Click(sender As Object, e As EventArgs) Handles KembaliMenu.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            formPengembalian.MdiParent = Me
            formPengembalian.Show()
            formPengembalian.WindowState = FormWindowState.Maximized
        Else
            formPengembalian.MdiParent = Me
            formPengembalian.Show()
            formPengembalian.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub PeminjamanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PeminjamanToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            formRiwayatPin.MdiParent = Me
            formRiwayatPin.Show()
            formRiwayatPin.WindowState = FormWindowState.Maximized
        Else
            formRiwayatPin.MdiParent = Me
            formRiwayatPin.Show()
            formRiwayatPin.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub PengembalianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengembalianToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            formRiwayatKem.MdiParent = Me
            formRiwayatKem.Show()
            formRiwayatKem.WindowState = FormWindowState.Maximized
        Else
            formRiwayatKem.MdiParent = Me
            formRiwayatKem.Show()
            formRiwayatKem.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub AturDendaMenu_Click(sender As Object, e As EventArgs) Handles AturDendaMenu.Click
        formAturDenda.ShowDialog()
    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click
        test.Show()
    End Sub
End Class
