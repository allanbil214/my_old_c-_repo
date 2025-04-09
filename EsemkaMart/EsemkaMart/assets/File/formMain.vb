Public Class formMain
    Public position As String
    Public title As String
    Public empid As Integer
    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuLogin.Click
        formLogin.ShowDialog()
    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles menuLogout.Click
        menuLogout.Enabled = False
        menuPass.Enabled = False
        menuTransaction.Enabled = False
        menuMaster.Enabled = False
        menuView.Enabled = False
        menuLogin.Enabled = True
        namer.Text = "..."
        posisi.Text = "..."
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
        End If
    End Sub

    Private Sub changepas_Click(sender As Object, e As EventArgs) Handles menuPass.Click
        formChangePass.ShowDialog()
    End Sub

    Private Sub MemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuMember.Click
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

    Private Sub PromoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuPromo.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            Promo.MdiParent = Me
            Promo.Show()
            Promo.WindowState = FormWindowState.Maximized
        Else
            Promo.MdiParent = Me
            Promo.Show()
            Promo.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub ProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuProduct.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            Product.MdiParent = Me
            Product.Show()
            Product.WindowState = FormWindowState.Maximized
        Else
            Product.MdiParent = Me
            Product.Show()
            Product.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub EmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuEmployee.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            Employee.MdiParent = Me
            Employee.Show()
            Employee.WindowState = FormWindowState.Maximized
        Else
            Employee.MdiParent = Me
            Employee.Show()
            Employee.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub transaction_Click(sender As Object, e As EventArgs) Handles menuTransaction.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            Transaction.MdiParent = Me
            Transaction.Show()
            Transaction.WindowState = FormWindowState.Maximized
        Else
            Transaction.MdiParent = Me
            Transaction.Show()
            Transaction.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub TransactionToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TransactionToolStripMenuItem1.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            VTransaction.MdiParent = Me
            VTransaction.Show()
            VTransaction.WindowState = FormWindowState.Maximized
        Else
            VTransaction.MdiParent = Me
            VTransaction.Show()
            VTransaction.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub SummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummaryToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            VSummary.MdiParent = Me
            VSummary.Show()
            VSummary.WindowState = FormWindowState.Maximized
        Else
            VSummary.MdiParent = Me
            VSummary.Show()
            VSummary.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        position = posisi.Text
    End Sub
End Class
