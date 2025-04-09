<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPengembalian
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
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtkaryawan = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtpelanggan = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpDikembali = New System.Windows.Forms.DateTimePicker()
        Me.dtpKembali = New System.Windows.Forms.DateTimePicker()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.numqty = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDenda = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtJudul = New System.Windows.Forms.TextBox()
        Me.grupText = New System.Windows.Forms.GroupBox()
        Me.dgv2 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numqty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupText.SuspendLayout()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(84, 354)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 24)
        Me.btnSubmit.TabIndex = 38
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 126)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 13)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Nama Karyawan"
        '
        'txtkaryawan
        '
        Me.txtkaryawan.Location = New System.Drawing.Point(107, 123)
        Me.txtkaryawan.Name = "txtkaryawan"
        Me.txtkaryawan.ReadOnly = True
        Me.txtkaryawan.Size = New System.Drawing.Size(188, 20)
        Me.txtkaryawan.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 100)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Nama Pelanggan"
        '
        'txtpelanggan
        '
        Me.txtpelanggan.Location = New System.Drawing.Point(107, 97)
        Me.txtpelanggan.Name = "txtpelanggan"
        Me.txtpelanggan.ReadOnly = True
        Me.txtpelanggan.Size = New System.Drawing.Size(188, 20)
        Me.txtpelanggan.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 153)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Tanggal Dikembali"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 179)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Tanggal Kembali"
        '
        'dtpDikembali
        '
        Me.dtpDikembali.Location = New System.Drawing.Point(107, 149)
        Me.dtpDikembali.Name = "dtpDikembali"
        Me.dtpDikembali.Size = New System.Drawing.Size(189, 20)
        Me.dtpDikembali.TabIndex = 22
        '
        'dtpKembali
        '
        Me.dtpKembali.Location = New System.Drawing.Point(107, 175)
        Me.dtpKembali.Name = "dtpKembali"
        Me.dtpKembali.Size = New System.Drawing.Size(189, 20)
        Me.dtpKembali.TabIndex = 21
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToDeleteRows = False
        Me.dgv1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv1.Location = New System.Drawing.Point(319, 16)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        Me.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv1.Size = New System.Drawing.Size(437, 218)
        Me.dgv1.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Qty"
        '
        'numqty
        '
        Me.numqty.Location = New System.Drawing.Point(107, 45)
        Me.numqty.Name = "numqty"
        Me.numqty.Size = New System.Drawing.Size(189, 20)
        Me.numqty.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Denda"
        '
        'txtDenda
        '
        Me.txtDenda.Location = New System.Drawing.Point(107, 71)
        Me.txtDenda.Name = "txtDenda"
        Me.txtDenda.ReadOnly = True
        Me.txtDenda.Size = New System.Drawing.Size(189, 20)
        Me.txtDenda.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Judul"
        '
        'txtJudul
        '
        Me.txtJudul.Location = New System.Drawing.Point(107, 19)
        Me.txtJudul.Name = "txtJudul"
        Me.txtJudul.ReadOnly = True
        Me.txtJudul.Size = New System.Drawing.Size(188, 20)
        Me.txtJudul.TabIndex = 0
        '
        'grupText
        '
        Me.grupText.Controls.Add(Me.Label10)
        Me.grupText.Controls.Add(Me.txtkaryawan)
        Me.grupText.Controls.Add(Me.Label9)
        Me.grupText.Controls.Add(Me.txtpelanggan)
        Me.grupText.Controls.Add(Me.Label8)
        Me.grupText.Controls.Add(Me.Label7)
        Me.grupText.Controls.Add(Me.dtpDikembali)
        Me.grupText.Controls.Add(Me.dtpKembali)
        Me.grupText.Controls.Add(Me.Label3)
        Me.grupText.Controls.Add(Me.numqty)
        Me.grupText.Controls.Add(Me.Label2)
        Me.grupText.Controls.Add(Me.txtDenda)
        Me.grupText.Controls.Add(Me.Label1)
        Me.grupText.Controls.Add(Me.txtJudul)
        Me.grupText.Location = New System.Drawing.Point(12, 10)
        Me.grupText.Name = "grupText"
        Me.grupText.Size = New System.Drawing.Size(301, 338)
        Me.grupText.TabIndex = 35
        Me.grupText.TabStop = False
        '
        'dgv2
        '
        Me.dgv2.AllowUserToAddRows = False
        Me.dgv2.AllowUserToDeleteRows = False
        Me.dgv2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv2.Location = New System.Drawing.Point(319, 240)
        Me.dgv2.Name = "dgv2"
        Me.dgv2.ReadOnly = True
        Me.dgv2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        Me.dgv2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv2.Size = New System.Drawing.Size(437, 189)
        Me.dgv2.TabIndex = 39
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(165, 354)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 24)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "Batal"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'formPengembalian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 441)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgv2)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.grupText)
        Me.MinimumSize = New System.Drawing.Size(784, 480)
        Me.Name = "formPengembalian"
        Me.Text = "formPengembalian"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numqty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupText.ResumeLayout(False)
        Me.grupText.PerformLayout()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents txtkaryawan As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtpelanggan As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpDikembali As DateTimePicker
    Friend WithEvents dtpKembali As DateTimePicker
    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents numqty As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDenda As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents grupText As GroupBox
    Friend WithEvents dgv2 As DataGridView
    Friend WithEvents Button1 As Button
End Class
