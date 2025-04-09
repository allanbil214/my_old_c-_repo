Public Class formMain
    Public empid As Integer = 0
    Public empname As String = ""
    Public emppos As String = ""

    Private Sub toolLogout_Click(sender As Object, e As EventArgs) Handles toolLogout.Click
        toolStatus.Text = "..."
        toolLogin.Enabled = True
        toolLogout.Enabled = False
        toolMaster.Enabled = False
        toolTrans.Enabled = False
        toolHistory.Enabled = False
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
        End If
    End Sub

    Private Sub toolLogin_Click(sender As Object, e As EventArgs) Handles toolLogin.Click
        formLogin.ShowDialog()
    End Sub

    Private Sub EmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            formEmployee.MdiParent = Me
            formEmployee.Show()
            formEmployee.WindowState = FormWindowState.Maximized
        Else
            formEmployee.MdiParent = Me
            formEmployee.Show()
            formEmployee.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub MemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MemberToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            formMember.MdiParent = Me
            formMember.Show()
            formMember.WindowState = FormWindowState.Maximized
        Else
            formMember.MdiParent = Me
            formMember.Show()
            formMember.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub ObatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ObatToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            formDrugs.MdiParent = Me
            formDrugs.Show()
            formDrugs.WindowState = FormWindowState.Maximized
        Else
            formDrugs.MdiParent = Me
            formDrugs.Show()
            formDrugs.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub SupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            formSupplier.MdiParent = Me
            formSupplier.Show()
            formSupplier.WindowState = FormWindowState.Maximized
        Else
            formSupplier.MdiParent = Me
            formSupplier.Show()
            formSupplier.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub PurchaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchaseToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            formPurchase.MdiParent = Me
            formPurchase.Show()
            formPurchase.WindowState = FormWindowState.Maximized
        Else
            formPurchase.MdiParent = Me
            formPurchase.Show()
            formPurchase.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub SaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaleToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            formSale.MdiParent = Me
            formSale.Show()
            formSale.WindowState = FormWindowState.Maximized
        Else
            formSale.MdiParent = Me
            formSale.Show()
            formSale.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub PurchasesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchasesToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            formHistPur.MdiParent = Me
            formHistPur.Show()
            formHistPur.WindowState = FormWindowState.Maximized
        Else
            formHistPur.MdiParent = Me
            formHistPur.Show()
            formHistPur.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub SalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            formHistSale.MdiParent = Me
            formHistSale.Show()
            formHistSale.WindowState = FormWindowState.Maximized
        Else
            formHistSale.MdiParent = Me
            formHistSale.Show()
            formHistSale.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub ReturToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles returtool.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            formRetur.MdiParent = Me
            formRetur.Show()
            formRetur.WindowState = FormWindowState.Maximized
        Else
            formRetur.MdiParent = Me
            formRetur.Show()
            formRetur.WindowState = FormWindowState.Maximized
        End If
    End Sub
End Class
