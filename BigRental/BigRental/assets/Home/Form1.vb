Imports System.ComponentModel

Public Class Form1
    Private sql As New Squek
    Public idnamer As String
    Private tingkat As Integer
    Private Sub loaddata()
        namer.Text = LoginForm1.namer
        idnamer = LoginForm1.idnamer
        tingkat = LoginForm1.tingkat
        If tingkat = 0 Then
            DataPegawaiToolStripMenuItem.Enabled = False
            PengaturanToolStripMenuItem.Enabled = False
        Else
            DataPegawaiToolStripMenuItem.Enabled = True
            PengaturanToolStripMenuItem.Enabled = True
        End If
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            homeForm.MdiParent = Me
            homeForm.Show()
            homeForm.WindowState = FormWindowState.Maximized
        Else
            homeForm.MdiParent = Me
            homeForm.Show()
            homeForm.WindowState = FormWindowState.Maximized
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        LoginForm1.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Hide()
        LoginForm1.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Close()
        LoginForm1.Close()
    End Sub

    Private Sub DataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            itemForm.MdiParent = Me
            itemForm.Show()
            itemForm.WindowState = FormWindowState.Maximized
        Else
            itemForm.MdiParent = Me
            itemForm.Show()
            itemForm.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub DataPegawaiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPegawaiToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            pegawaiForm.MdiParent = Me
            pegawaiForm.Show()
            pegawaiForm.WindowState = FormWindowState.Maximized
        Else
            pegawaiForm.MdiParent = Me
            pegawaiForm.Show()
            pegawaiForm.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            homeForm.MdiParent = Me
            homeForm.Show()
            homeForm.WindowState = FormWindowState.Maximized
        Else
            homeForm.MdiParent = Me
            homeForm.Show()
            homeForm.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub DataPelangganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPelangganToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            pelangganForm.MdiParent = Me
            pelangganForm.Show()
            pelangganForm.WindowState = FormWindowState.Maximized
        Else
            pelangganForm.MdiParent = Me
            pelangganForm.Show()
            pelangganForm.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub PengembalianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengembalianToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            kembaliForm.MdiParent = Me
            kembaliForm.Show()
            kembaliForm.WindowState = FormWindowState.Maximized
        Else
            kembaliForm.MdiParent = Me
            kembaliForm.Show()
            kembaliForm.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub PeminjamanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PeminjamanToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            pinjamForm.MdiParent = Me
            pinjamForm.Show()
            pinjamForm.WindowState = FormWindowState.Maximized
        Else
            pinjamForm.MdiParent = Me
            pinjamForm.Show()
            pinjamForm.WindowState = FormWindowState.Maximized
        End If
    End Sub
End Class
