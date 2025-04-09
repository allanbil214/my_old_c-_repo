<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formKembali
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNamak = New System.Windows.Forms.TextBox()
        Me.txtNamap = New System.Windows.Forms.TextBox()
        Me.dtpDikembali = New System.Windows.Forms.DateTimePicker()
        Me.dtpKembali = New System.Windows.Forms.DateTimePicker()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.txtJudul = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.gbData = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDenda = New System.Windows.Forms.TextBox()
        Me.dgv2 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTipe = New System.Windows.Forms.TextBox()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbData.SuspendLayout()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 126)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Tanggal Dikembali"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Tanggal Kembali"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Nama Pelanggan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Harga"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 204)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Nama Karyawan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Judul"
        '
        'txtNamak
        '
        Me.txtNamak.Location = New System.Drawing.Point(101, 201)
        Me.txtNamak.Name = "txtNamak"
        Me.txtNamak.ReadOnly = True
        Me.txtNamak.Size = New System.Drawing.Size(165, 20)
        Me.txtNamak.TabIndex = 8
        '
        'txtNamap
        '
        Me.txtNamap.Location = New System.Drawing.Point(101, 175)
        Me.txtNamap.Name = "txtNamap"
        Me.txtNamap.ReadOnly = True
        Me.txtNamap.Size = New System.Drawing.Size(165, 20)
        Me.txtNamap.TabIndex = 7
        '
        'dtpDikembali
        '
        Me.dtpDikembali.Location = New System.Drawing.Point(101, 123)
        Me.dtpDikembali.Name = "dtpDikembali"
        Me.dtpDikembali.Size = New System.Drawing.Size(165, 20)
        Me.dtpDikembali.TabIndex = 6
        '
        'dtpKembali
        '
        Me.dtpKembali.Location = New System.Drawing.Point(101, 97)
        Me.dtpKembali.Name = "dtpKembali"
        Me.dtpKembali.Size = New System.Drawing.Size(165, 20)
        Me.dtpKembali.TabIndex = 5
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(101, 71)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.ReadOnly = True
        Me.txtHarga.Size = New System.Drawing.Size(165, 20)
        Me.txtHarga.TabIndex = 3
        '
        'txtJudul
        '
        Me.txtJudul.Location = New System.Drawing.Point(101, 19)
        Me.txtJudul.Name = "txtJudul"
        Me.txtJudul.ReadOnly = True
        Me.txtJudul.Size = New System.Drawing.Size(165, 20)
        Me.txtJudul.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(101, 357)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 32
        Me.Button3.Text = "Submit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToDeleteRows = False
        Me.dgv1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(290, 18)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv1.Size = New System.Drawing.Size(422, 221)
        Me.dgv1.TabIndex = 31
        '
        'gbData
        '
        Me.gbData.Controls.Add(Me.Label4)
        Me.gbData.Controls.Add(Me.txtDenda)
        Me.gbData.Controls.Add(Me.Label9)
        Me.gbData.Controls.Add(Me.Label8)
        Me.gbData.Controls.Add(Me.Label6)
        Me.gbData.Controls.Add(Me.Label5)
        Me.gbData.Controls.Add(Me.Label3)
        Me.gbData.Controls.Add(Me.Label2)
        Me.gbData.Controls.Add(Me.Label1)
        Me.gbData.Controls.Add(Me.txtNamak)
        Me.gbData.Controls.Add(Me.txtNamap)
        Me.gbData.Controls.Add(Me.dtpDikembali)
        Me.gbData.Controls.Add(Me.dtpKembali)
        Me.gbData.Controls.Add(Me.txtHarga)
        Me.gbData.Controls.Add(Me.txtTipe)
        Me.gbData.Controls.Add(Me.txtJudul)
        Me.gbData.Location = New System.Drawing.Point(12, 18)
        Me.gbData.Name = "gbData"
        Me.gbData.Size = New System.Drawing.Size(272, 304)
        Me.gbData.TabIndex = 30
        Me.gbData.TabStop = False
        Me.gbData.Text = "Master Data"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Denda"
        '
        'txtDenda
        '
        Me.txtDenda.Location = New System.Drawing.Point(101, 149)
        Me.txtDenda.Name = "txtDenda"
        Me.txtDenda.ReadOnly = True
        Me.txtDenda.Size = New System.Drawing.Size(165, 20)
        Me.txtDenda.TabIndex = 18
        Me.txtDenda.Text = "0"
        '
        'dgv2
        '
        Me.dgv2.AllowUserToAddRows = False
        Me.dgv2.AllowUserToDeleteRows = False
        Me.dgv2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv2.Location = New System.Drawing.Point(290, 245)
        Me.dgv2.Name = "dgv2"
        Me.dgv2.ReadOnly = True
        Me.dgv2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv2.Size = New System.Drawing.Size(422, 154)
        Me.dgv2.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Tipe"
        '
        'txtTipe
        '
        Me.txtTipe.Location = New System.Drawing.Point(101, 45)
        Me.txtTipe.Name = "txtTipe"
        Me.txtTipe.ReadOnly = True
        Me.txtTipe.Size = New System.Drawing.Size(165, 20)
        Me.txtTipe.TabIndex = 1
        '
        'formKembali
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 411)
        Me.Controls.Add(Me.dgv2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.gbData)
        Me.MinimumSize = New System.Drawing.Size(740, 450)
        Me.Name = "formKembali"
        Me.Text = "formKembali"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbData.ResumeLayout(False)
        Me.gbData.PerformLayout()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNamak As TextBox
    Friend WithEvents txtNamap As TextBox
    Friend WithEvents dtpDikembali As DateTimePicker
    Friend WithEvents dtpKembali As DateTimePicker
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents gbData As GroupBox
    Friend WithEvents dgv2 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDenda As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTipe As TextBox
End Class
