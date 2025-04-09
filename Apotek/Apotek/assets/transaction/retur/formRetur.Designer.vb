<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formRetur
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
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.numQty = New System.Windows.Forms.NumericUpDown()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDrug = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gbData = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpRetur = New System.Windows.Forms.DateTimePicker()
        Me.numReplace = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numQty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbData.SuspendLayout()
        CType(Me.numReplace, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToDeleteRows = False
        Me.dgv1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(350, 12)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv1.Size = New System.Drawing.Size(462, 417)
        Me.dgv1.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Replaced"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Qty"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(175, 327)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 26)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'numQty
        '
        Me.numQty.Location = New System.Drawing.Point(119, 45)
        Me.numQty.Name = "numQty"
        Me.numQty.Size = New System.Drawing.Size(207, 20)
        Me.numQty.TabIndex = 6
        Me.numQty.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(277, 17)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(49, 23)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "...."
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Drug Name"
        '
        'txtDrug
        '
        Me.txtDrug.Location = New System.Drawing.Point(119, 19)
        Me.txtDrug.Name = "txtDrug"
        Me.txtDrug.ReadOnly = True
        Me.txtDrug.Size = New System.Drawing.Size(152, 20)
        Me.txtDrug.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(94, 327)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 26)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'gbData
        '
        Me.gbData.Controls.Add(Me.Label4)
        Me.gbData.Controls.Add(Me.Label5)
        Me.gbData.Controls.Add(Me.dtpRetur)
        Me.gbData.Controls.Add(Me.numReplace)
        Me.gbData.Controls.Add(Me.Label3)
        Me.gbData.Controls.Add(Me.Label2)
        Me.gbData.Controls.Add(Me.numQty)
        Me.gbData.Controls.Add(Me.Button4)
        Me.gbData.Controls.Add(Me.Label1)
        Me.gbData.Controls.Add(Me.txtDrug)
        Me.gbData.Location = New System.Drawing.Point(12, 12)
        Me.gbData.Name = "gbData"
        Me.gbData.Size = New System.Drawing.Size(332, 290)
        Me.gbData.TabIndex = 27
        Me.gbData.TabStop = False
        Me.gbData.Text = "Master"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Retur Date"
        '
        'dtpRetur
        '
        Me.dtpRetur.Enabled = False
        Me.dtpRetur.Location = New System.Drawing.Point(119, 97)
        Me.dtpRetur.Name = "dtpRetur"
        Me.dtpRetur.Size = New System.Drawing.Size(207, 20)
        Me.dtpRetur.TabIndex = 17
        '
        'numReplace
        '
        Me.numReplace.Enabled = False
        Me.numReplace.Location = New System.Drawing.Point(119, 71)
        Me.numReplace.Name = "numReplace"
        Me.numReplace.Size = New System.Drawing.Size(207, 20)
        Me.numReplace.TabIndex = 14
        Me.numReplace.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Label4"
        '
        'formRetur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 441)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.gbData)
        Me.MinimumSize = New System.Drawing.Size(840, 480)
        Me.Name = "formRetur"
        Me.Text = "formRetur"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numQty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbData.ResumeLayout(False)
        Me.gbData.PerformLayout()
        CType(Me.numReplace, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents numQty As NumericUpDown
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDrug As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents gbData As GroupBox
    Friend WithEvents numReplace As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpRetur As DateTimePicker
    Friend WithEvents Label4 As Label
End Class
