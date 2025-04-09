<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CDMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.KaryawanMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.PelangganMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AturDendaMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.PinjamMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.KembaliMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.RiwayatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PeminjamanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengembalianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.namastatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.MasterMenu, Me.TransMenu, Me.RiwayatToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(864, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginMenu, Me.LogoutMenu, Me.ExitMenu})
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(37, 20)
        Me.FileMenu.Text = "File"
        '
        'LoginMenu
        '
        Me.LoginMenu.Name = "LoginMenu"
        Me.LoginMenu.Size = New System.Drawing.Size(112, 22)
        Me.LoginMenu.Text = "Login"
        '
        'LogoutMenu
        '
        Me.LogoutMenu.Enabled = False
        Me.LogoutMenu.Name = "LogoutMenu"
        Me.LogoutMenu.Size = New System.Drawing.Size(112, 22)
        Me.LogoutMenu.Text = "Logout"
        '
        'ExitMenu
        '
        Me.ExitMenu.Name = "ExitMenu"
        Me.ExitMenu.Size = New System.Drawing.Size(112, 22)
        Me.ExitMenu.Text = "Exit"
        '
        'MasterMenu
        '
        Me.MasterMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CDMenu, Me.KaryawanMenu, Me.PelangganMenu, Me.AturDendaMenu})
        Me.MasterMenu.Enabled = False
        Me.MasterMenu.Name = "MasterMenu"
        Me.MasterMenu.Size = New System.Drawing.Size(55, 20)
        Me.MasterMenu.Text = "Master"
        '
        'CDMenu
        '
        Me.CDMenu.Name = "CDMenu"
        Me.CDMenu.Size = New System.Drawing.Size(134, 22)
        Me.CDMenu.Text = "CD"
        '
        'KaryawanMenu
        '
        Me.KaryawanMenu.Name = "KaryawanMenu"
        Me.KaryawanMenu.Size = New System.Drawing.Size(134, 22)
        Me.KaryawanMenu.Text = "Karyawan"
        '
        'PelangganMenu
        '
        Me.PelangganMenu.Name = "PelangganMenu"
        Me.PelangganMenu.Size = New System.Drawing.Size(134, 22)
        Me.PelangganMenu.Text = "Pelanggan"
        '
        'AturDendaMenu
        '
        Me.AturDendaMenu.Name = "AturDendaMenu"
        Me.AturDendaMenu.Size = New System.Drawing.Size(134, 22)
        Me.AturDendaMenu.Text = "Atur Denda"
        '
        'TransMenu
        '
        Me.TransMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PinjamMenu, Me.KembaliMenu})
        Me.TransMenu.Enabled = False
        Me.TransMenu.Name = "TransMenu"
        Me.TransMenu.Size = New System.Drawing.Size(80, 20)
        Me.TransMenu.Text = "Transaction"
        '
        'PinjamMenu
        '
        Me.PinjamMenu.Name = "PinjamMenu"
        Me.PinjamMenu.Size = New System.Drawing.Size(150, 22)
        Me.PinjamMenu.Text = "Peminjaman"
        '
        'KembaliMenu
        '
        Me.KembaliMenu.Name = "KembaliMenu"
        Me.KembaliMenu.Size = New System.Drawing.Size(150, 22)
        Me.KembaliMenu.Text = "Pengembalian"
        '
        'RiwayatToolStripMenuItem
        '
        Me.RiwayatToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PeminjamanToolStripMenuItem, Me.PengembalianToolStripMenuItem})
        Me.RiwayatToolStripMenuItem.Enabled = False
        Me.RiwayatToolStripMenuItem.Name = "RiwayatToolStripMenuItem"
        Me.RiwayatToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.RiwayatToolStripMenuItem.Text = "Riwayat"
        '
        'PeminjamanToolStripMenuItem
        '
        Me.PeminjamanToolStripMenuItem.Name = "PeminjamanToolStripMenuItem"
        Me.PeminjamanToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.PeminjamanToolStripMenuItem.Text = "Peminjaman"
        '
        'PengembalianToolStripMenuItem
        '
        Me.PengembalianToolStripMenuItem.Name = "PengembalianToolStripMenuItem"
        Me.PengembalianToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.PengembalianToolStripMenuItem.Text = "Pengembalian"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.namastatus, Me.ToolStripStatusLabel4})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 469)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(864, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(45, 17)
        Me.ToolStripStatusLabel1.Text = "Status :"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(11, 17)
        Me.ToolStripStatusLabel2.Text = "["
        '
        'namastatus
        '
        Me.namastatus.Name = "namastatus"
        Me.namastatus.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(11, 17)
        Me.ToolStripStatusLabel4.Text = "]"
        '
        'formUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 491)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(880, 530)
        Me.Name = "formUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileMenu As ToolStripMenuItem
    Friend WithEvents LoginMenu As ToolStripMenuItem
    Friend WithEvents LogoutMenu As ToolStripMenuItem
    Friend WithEvents ExitMenu As ToolStripMenuItem
    Friend WithEvents MasterMenu As ToolStripMenuItem
    Friend WithEvents CDMenu As ToolStripMenuItem
    Friend WithEvents KaryawanMenu As ToolStripMenuItem
    Friend WithEvents PelangganMenu As ToolStripMenuItem
    Friend WithEvents TransMenu As ToolStripMenuItem
    Friend WithEvents PinjamMenu As ToolStripMenuItem
    Friend WithEvents KembaliMenu As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents namastatus As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents RiwayatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PeminjamanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PengembalianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AturDendaMenu As ToolStripMenuItem
End Class
