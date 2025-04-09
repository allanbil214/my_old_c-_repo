<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffCari
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.dgvM = New System.Windows.Forms.DataGridView()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.cbFilterPinjam = New System.Windows.Forms.ComboBox()
        Me.txtFilterPinjam = New System.Windows.Forms.TextBox()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel3.Controls.Add(Me.Button17)
        Me.Panel3.Controls.Add(Me.cbFilterPinjam)
        Me.Panel3.Controls.Add(Me.TextBox2)
        Me.Panel3.Controls.Add(Me.txtFilterPinjam)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Controls.Add(Me.Label63)
        Me.Panel3.Controls.Add(Me.Label43)
        Me.Panel3.Location = New System.Drawing.Point(4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(757, 35)
        Me.Panel3.TabIndex = 28
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(612, 8)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(56, 20)
        Me.TextBox2.TabIndex = 29
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(674, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(506, 8)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 27
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Location = New System.Drawing.Point(345, 11)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(155, 13)
        Me.Label63.TabIndex = 26
        Me.Label63.Text = "Klik dua kali untuk memilih data"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(329, -5)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(23, 37)
        Me.Label43.TabIndex = 21
        Me.Label43.Text = "|"
        '
        'dgvM
        '
        Me.dgvM.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvM.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgvM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvM.Location = New System.Drawing.Point(4, 43)
        Me.dgvM.Name = "dgvM"
        Me.dgvM.ReadOnly = True
        Me.dgvM.Size = New System.Drawing.Size(757, 301)
        Me.dgvM.TabIndex = 27
        '
        'Button17
        '
        Me.Button17.Location = New System.Drawing.Point(248, 6)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(75, 23)
        Me.Button17.TabIndex = 34
        Me.Button17.Text = "Cari"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'cbFilterPinjam
        '
        Me.cbFilterPinjam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFilterPinjam.FormattingEnabled = True
        Me.cbFilterPinjam.Location = New System.Drawing.Point(15, 7)
        Me.cbFilterPinjam.Name = "cbFilterPinjam"
        Me.cbFilterPinjam.Size = New System.Drawing.Size(121, 21)
        Me.cbFilterPinjam.TabIndex = 33
        '
        'txtFilterPinjam
        '
        Me.txtFilterPinjam.Location = New System.Drawing.Point(142, 8)
        Me.txtFilterPinjam.Name = "txtFilterPinjam"
        Me.txtFilterPinjam.Size = New System.Drawing.Size(100, 20)
        Me.txtFilterPinjam.TabIndex = 32
        '
        'StaffCari
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 348)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.dgvM)
        Me.Name = "StaffCari"
        Me.Text = "StaffCari"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgvM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label63 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents dgvM As DataGridView
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button17 As Button
    Friend WithEvents cbFilterPinjam As ComboBox
    Friend WithEvents txtFilterPinjam As TextBox
End Class
