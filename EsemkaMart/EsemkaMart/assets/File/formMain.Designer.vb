<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.namer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.posisi = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuLogin = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPass = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuMaster = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuMember = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPromo = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuProduct = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEmployee = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuTransaction = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuView = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.namer, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel3, Me.posisi, Me.ToolStripStatusLabel6})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 479)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(944, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(82, 17)
        Me.ToolStripStatusLabel1.Text = "Logged In As :"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(11, 17)
        Me.ToolStripStatusLabel2.Text = "["
        '
        'namer
        '
        Me.namer.Name = "namer"
        Me.namer.Size = New System.Drawing.Size(19, 17)
        Me.namer.Text = "...."
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(11, 17)
        Me.ToolStripStatusLabel4.Text = "]"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(11, 17)
        Me.ToolStripStatusLabel3.Text = "["
        '
        'posisi
        '
        Me.posisi.Name = "posisi"
        Me.posisi.Size = New System.Drawing.Size(19, 17)
        Me.posisi.Text = "...."
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(11, 17)
        Me.ToolStripStatusLabel6.Text = "]"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.menuMaster, Me.menuTransaction, Me.menuView})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(944, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuLogin, Me.menuLogout, Me.menuPass})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'menuLogin
        '
        Me.menuLogin.Name = "menuLogin"
        Me.menuLogin.Size = New System.Drawing.Size(168, 22)
        Me.menuLogin.Text = "&Login"
        '
        'menuLogout
        '
        Me.menuLogout.Enabled = False
        Me.menuLogout.Name = "menuLogout"
        Me.menuLogout.Size = New System.Drawing.Size(168, 22)
        Me.menuLogout.Text = "Log &Out"
        '
        'menuPass
        '
        Me.menuPass.Enabled = False
        Me.menuPass.Name = "menuPass"
        Me.menuPass.Size = New System.Drawing.Size(168, 22)
        Me.menuPass.Text = "Change Password"
        '
        'menuMaster
        '
        Me.menuMaster.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuMember, Me.menuPromo, Me.menuProduct, Me.menuEmployee})
        Me.menuMaster.Enabled = False
        Me.menuMaster.Name = "menuMaster"
        Me.menuMaster.Size = New System.Drawing.Size(55, 20)
        Me.menuMaster.Text = "&Master"
        '
        'menuMember
        '
        Me.menuMember.Name = "menuMember"
        Me.menuMember.Size = New System.Drawing.Size(126, 22)
        Me.menuMember.Text = "Mem&ber"
        '
        'menuPromo
        '
        Me.menuPromo.Name = "menuPromo"
        Me.menuPromo.Size = New System.Drawing.Size(126, 22)
        Me.menuPromo.Text = "&Promo"
        '
        'menuProduct
        '
        Me.menuProduct.Name = "menuProduct"
        Me.menuProduct.Size = New System.Drawing.Size(126, 22)
        Me.menuProduct.Text = "Pro&duct"
        '
        'menuEmployee
        '
        Me.menuEmployee.Name = "menuEmployee"
        Me.menuEmployee.Size = New System.Drawing.Size(126, 22)
        Me.menuEmployee.Text = "&Employee"
        '
        'menuTransaction
        '
        Me.menuTransaction.Enabled = False
        Me.menuTransaction.Name = "menuTransaction"
        Me.menuTransaction.Size = New System.Drawing.Size(80, 20)
        Me.menuTransaction.Text = "&Transaction"
        '
        'menuView
        '
        Me.menuView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransactionToolStripMenuItem1, Me.SummaryToolStripMenuItem})
        Me.menuView.Enabled = False
        Me.menuView.Name = "menuView"
        Me.menuView.Size = New System.Drawing.Size(44, 20)
        Me.menuView.Text = "View"
        '
        'TransactionToolStripMenuItem1
        '
        Me.TransactionToolStripMenuItem1.Name = "TransactionToolStripMenuItem1"
        Me.TransactionToolStripMenuItem1.Size = New System.Drawing.Size(135, 22)
        Me.TransactionToolStripMenuItem1.Text = "&Transaction"
        '
        'SummaryToolStripMenuItem
        '
        Me.SummaryToolStripMenuItem.Name = "SummaryToolStripMenuItem"
        Me.SummaryToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.SummaryToolStripMenuItem.Text = "&Summary"
        '
        'formMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 501)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "formMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents namer As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menuLogin As ToolStripMenuItem
    Friend WithEvents menuLogout As ToolStripMenuItem
    Friend WithEvents menuPass As ToolStripMenuItem
    Friend WithEvents menuMaster As ToolStripMenuItem
    Friend WithEvents menuMember As ToolStripMenuItem
    Friend WithEvents menuPromo As ToolStripMenuItem
    Friend WithEvents menuProduct As ToolStripMenuItem
    Friend WithEvents menuTransaction As ToolStripMenuItem
    Friend WithEvents menuView As ToolStripMenuItem
    Friend WithEvents TransactionToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SummaryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menuEmployee As ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents posisi As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As ToolStripStatusLabel
End Class
