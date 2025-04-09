<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCD
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
        Me.gbData = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.numHarga = New System.Windows.Forms.NumericUpDown()
        Me.numStok = New System.Windows.Forms.NumericUpDown()
        Me.cbTipe = New System.Windows.Forms.ComboBox()
        Me.txtJudul = New System.Windows.Forms.TextBox()
        Me.gbCari = New System.Windows.Forms.GroupBox()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.gbData.SuspendLayout()
        CType(Me.numHarga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numStok, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCari.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbData
        '
        Me.gbData.Controls.Add(Me.Label4)
        Me.gbData.Controls.Add(Me.Label3)
        Me.gbData.Controls.Add(Me.Label2)
        Me.gbData.Controls.Add(Me.Label1)
        Me.gbData.Controls.Add(Me.numHarga)
        Me.gbData.Controls.Add(Me.numStok)
        Me.gbData.Controls.Add(Me.cbTipe)
        Me.gbData.Controls.Add(Me.txtJudul)
        Me.gbData.Enabled = False
        Me.gbData.Location = New System.Drawing.Point(12, 12)
        Me.gbData.Name = "gbData"
        Me.gbData.Size = New System.Drawing.Size(272, 304)
        Me.gbData.TabIndex = 0
        Me.gbData.TabStop = False
        Me.gbData.Text = "Master Data"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Harga"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Stok"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tipe"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Judul"
        '
        'numHarga
        '
        Me.numHarga.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numHarga.Location = New System.Drawing.Point(118, 98)
        Me.numHarga.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.numHarga.Name = "numHarga"
        Me.numHarga.Size = New System.Drawing.Size(147, 20)
        Me.numHarga.TabIndex = 3
        Me.numHarga.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'numStok
        '
        Me.numStok.Location = New System.Drawing.Point(118, 72)
        Me.numStok.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numStok.Name = "numStok"
        Me.numStok.Size = New System.Drawing.Size(147, 20)
        Me.numStok.TabIndex = 2
        Me.numStok.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cbTipe
        '
        Me.cbTipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipe.FormattingEnabled = True
        Me.cbTipe.Location = New System.Drawing.Point(118, 45)
        Me.cbTipe.Name = "cbTipe"
        Me.cbTipe.Size = New System.Drawing.Size(148, 21)
        Me.cbTipe.TabIndex = 1
        '
        'txtJudul
        '
        Me.txtJudul.Location = New System.Drawing.Point(118, 19)
        Me.txtJudul.Name = "txtJudul"
        Me.txtJudul.Size = New System.Drawing.Size(148, 20)
        Me.txtJudul.TabIndex = 0
        '
        'gbCari
        '
        Me.gbCari.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbCari.Controls.Add(Me.txtCari)
        Me.gbCari.Location = New System.Drawing.Point(290, 12)
        Me.gbCari.Name = "gbCari"
        Me.gbCari.Size = New System.Drawing.Size(422, 50)
        Me.gbCari.TabIndex = 1
        Me.gbCari.TabStop = False
        Me.gbCari.Text = "Pencarian"
        '
        'txtCari
        '
        Me.txtCari.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCari.Location = New System.Drawing.Point(6, 19)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(410, 20)
        Me.txtCari.TabIndex = 0
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToDeleteRows = False
        Me.dgv1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(290, 68)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv1.Size = New System.Drawing.Size(422, 331)
        Me.dgv1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(25, 322)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Tambah"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(106, 322)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Ubah"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(187, 322)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Hapus"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(68, 351)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Simpan"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(149, 351)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Batal"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'formCD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 411)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.gbCari)
        Me.Controls.Add(Me.gbData)
        Me.MinimumSize = New System.Drawing.Size(740, 450)
        Me.Name = "formCD"
        Me.Text = "formCD"
        Me.gbData.ResumeLayout(False)
        Me.gbData.PerformLayout()
        CType(Me.numHarga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numStok, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCari.ResumeLayout(False)
        Me.gbCari.PerformLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbData As GroupBox
    Friend WithEvents gbCari As GroupBox
    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents txtCari As TextBox
    Friend WithEvents numHarga As NumericUpDown
    Friend WithEvents numStok As NumericUpDown
    Friend WithEvents cbTipe As ComboBox
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
