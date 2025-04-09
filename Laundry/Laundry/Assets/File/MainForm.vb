Imports System.ComponentModel
Imports System.Text.RegularExpressions

Public Class MainForm
    Public Function isemailformat(text As String) As Boolean
        If Regex.IsMatch(text, "^[a-z,A-Z,0-9]+@[a-z,A-Z]+[.]+[a-z,A-Z]") Then
            Return True
        End If
        Return False
    End Function
    Public Function isphoneformat(text As String) As Boolean
        If Regex.IsMatch(text, "^[+]+[0-9]") Then
            Return True
        End If
        Return False
    End Function
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Hide()
        LoginForm.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        LoginForm.Close()
    End Sub

    Private Sub MainForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        LoginForm.Close()
    End Sub

    Private Sub EmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            EmployeeForm.MdiParent = Me
            EmployeeForm.Show()
            EmployeeForm.WindowState = FormWindowState.Maximized
        Else
            EmployeeForm.MdiParent = Me
            EmployeeForm.Show()
            EmployeeForm.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub ServiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServiceToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            ServiceForm.MdiParent = Me
            ServiceForm.Show()
            ServiceForm.WindowState = FormWindowState.Maximized
        Else
            ServiceForm.MdiParent = Me
            ServiceForm.Show()
            ServiceForm.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub PackageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PackageToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            PackageForm.MdiParent = Me
            PackageForm.Show()
            PackageForm.WindowState = FormWindowState.Maximized
        Else
            PackageForm.MdiParent = Me
            PackageForm.Show()
            PackageForm.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub TransactionDepositToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransactionDepositToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            TransactionForm.MdiParent = Me
            TransactionForm.Show()
            TransactionForm.WindowState = FormWindowState.Maximized
        Else
            TransactionForm.MdiParent = Me
            TransactionForm.Show()
            TransactionForm.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub PrepaidPackageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrepaidPackageToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            PrepaidForm.MdiParent = Me
            PrepaidForm.Show()
            PrepaidForm.WindowState = FormWindowState.Maximized
        Else
            PrepaidForm.MdiParent = Me
            PrepaidForm.Show()
            PrepaidForm.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub ViewTransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewTransactionToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            ViewTransactionForm.MdiParent = Me
            ViewTransactionForm.Show()
            ViewTransactionForm.WindowState = FormWindowState.Maximized
        Else
            ViewTransactionForm.MdiParent = Me
            ViewTransactionForm.Show()
            ViewTransactionForm.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class