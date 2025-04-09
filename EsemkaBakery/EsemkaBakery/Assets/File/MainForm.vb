Imports System.ComponentModel

Public Class MainForm

    Private Sub MainForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        LoginForm.Close()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Hide()
        LoginForm.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        ChangePasswordForm.ShowDialog()
    End Sub

    Private Sub InputSellngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputSellngToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            InputSellingForm.MdiParent = Me
            InputSellingForm.Show()
            InputSellingForm.WindowState = FormWindowState.Maximized
        Else
            InputSellingForm.MdiParent = Me
            InputSellingForm.Show()
            InputSellingForm.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub ViewSellingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewSellingToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            ViewSellingForm.MdiParent = Me
            ViewSellingForm.Show()
            ViewSellingForm.WindowState = FormWindowState.Maximized
        Else
            ViewSellingForm.MdiParent = Me
            ViewSellingForm.Show()
            ViewSellingForm.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub AddProductionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddProductionToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            AddProductionForm.MdiParent = Me
            AddProductionForm.Show()
            AddProductionForm.WindowState = FormWindowState.Maximized
        Else
            AddProductionForm.MdiParent = Me
            AddProductionForm.Show()
            AddProductionForm.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub InputProductionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewProductionToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            ViewProductionForm.MdiParent = Me
            ViewProductionForm.Show()
            ViewProductionForm.WindowState = FormWindowState.Maximized
        Else
            ViewProductionForm.MdiParent = Me
            ViewProductionForm.Show()
            ViewProductionForm.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub AddIncomingRawMaterialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddIncomingRawMaterialToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            InputIncomingRawMaterialForm.MdiParent = Me
            InputIncomingRawMaterialForm.Show()
            InputIncomingRawMaterialForm.WindowState = FormWindowState.Maximized
        Else
            InputIncomingRawMaterialForm.MdiParent = Me
            InputIncomingRawMaterialForm.Show()
            InputIncomingRawMaterialForm.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub ViewIncomingRawMaterialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewIncomingRawMaterialToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            ViewIncomingRawMaterialFrom.MdiParent = Me
            ViewIncomingRawMaterialFrom.Show()
            ViewIncomingRawMaterialFrom.WindowState = FormWindowState.Maximized
        Else
            ViewIncomingRawMaterialFrom.MdiParent = Me
            ViewIncomingRawMaterialFrom.Show()
            ViewIncomingRawMaterialFrom.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub ViewFoodStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewFoodStockToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            ViewFoodStockForm.MdiParent = Me
            ViewFoodStockForm.Show()
            ViewFoodStockForm.WindowState = FormWindowState.Maximized
        Else
            ViewFoodStockForm.MdiParent = Me
            ViewFoodStockForm.Show()
            ViewFoodStockForm.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub ViewRawMaterialStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewRawMaterialStockToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            ViewRawMaterialStockForm.MdiParent = Me
            ViewRawMaterialStockForm.Show()
            ViewRawMaterialStockForm.WindowState = FormWindowState.Maximized
        Else
            ViewRawMaterialStockForm.MdiParent = Me
            ViewRawMaterialStockForm.Show()
            ViewRawMaterialStockForm.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub RawMaterialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RawMaterialToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            RawMaterialForm.MdiParent = Me
            RawMaterialForm.Show()
            RawMaterialForm.WindowState = FormWindowState.Maximized
        Else
            RawMaterialForm.MdiParent = Me
            RawMaterialForm.Show()
            RawMaterialForm.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub FoodToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FoodToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            FoodForm.MdiParent = Me
            FoodForm.Show()
            FoodForm.WindowState = FormWindowState.Maximized
        Else
            FoodForm.MdiParent = Me
            FoodForm.Show()
            FoodForm.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub RecipeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecipeToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
            RecipeForm.MdiParent = Me
            RecipeForm.Show()
            RecipeForm.WindowState = FormWindowState.Maximized
        Else
            RecipeForm.MdiParent = Me
            RecipeForm.Show()
            RecipeForm.WindowState = FormWindowState.Maximized
        End If
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
End Class