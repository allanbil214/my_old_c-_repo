<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPurchase
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpNow = New System.Windows.Forms.DateTimePicker()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txtSup = New System.Windows.Forms.TextBox()
        Me.numQty = New System.Windows.Forms.NumericUpDown()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDrug = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.gbData.SuspendLayout()
        CType(Me.numQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbData
        '
        Me.gbData.Controls.Add(Me.Label8)
        Me.gbData.Controls.Add(Me.lblTotalCost)
        Me.gbData.Controls.Add(Me.Label6)
        Me.gbData.Controls.Add(Me.Label4)
        Me.gbData.Controls.Add(Me.Label3)
        Me.gbData.Controls.Add(Me.Label2)
        Me.gbData.Controls.Add(Me.dtpNow)
        Me.gbData.Controls.Add(Me.Button5)
        Me.gbData.Controls.Add(Me.txtSup)
        Me.gbData.Controls.Add(Me.numQty)
        Me.gbData.Controls.Add(Me.txtCost)
        Me.gbData.Controls.Add(Me.Button4)
        Me.gbData.Controls.Add(Me.Label1)
        Me.gbData.Controls.Add(Me.txtDrug)
        Me.gbData.Location = New System.Drawing.Point(12, 12)
        Me.gbData.Name = "gbData"
        Me.gbData.Size = New System.Drawing.Size(332, 290)
        Me.gbData.TabIndex = 22
        Me.gbData.TabStop = False
        Me.gbData.Text = "Master"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(-2, 273)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Total Cost : "
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Location = New System.Drawing.Point(64, 274)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(13, 13)
        Me.lblTotalCost.TabIndex = 17
        Me.lblTotalCost.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Purchase Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Supplier Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Qty"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Cost"
        '
        'dtpNow
        '
        Me.dtpNow.Enabled = False
        Me.dtpNow.Location = New System.Drawing.Point(119, 123)
        Me.dtpNow.Name = "dtpNow"
        Me.dtpNow.Size = New System.Drawing.Size(207, 20)
        Me.dtpNow.TabIndex = 11
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(277, 95)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(49, 23)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "...."
        Me.Button5.UseVisualStyleBackColor = True
        '
        'txtSup
        '
        Me.txtSup.Location = New System.Drawing.Point(119, 97)
        Me.txtSup.Name = "txtSup"
        Me.txtSup.ReadOnly = True
        Me.txtSup.Size = New System.Drawing.Size(152, 20)
        Me.txtSup.TabIndex = 7
        '
        'numQty
        '
        Me.numQty.Location = New System.Drawing.Point(119, 71)
        Me.numQty.Name = "numQty"
        Me.numQty.Size = New System.Drawing.Size(207, 20)
        Me.numQty.TabIndex = 6
        Me.numQty.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(119, 45)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.ReadOnly = True
        Me.txtCost.Size = New System.Drawing.Size(207, 20)
        Me.txtCost.TabIndex = 5
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
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(135, 359)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(77, 26)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "Submit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(175, 327)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 26)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(94, 327)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 26)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
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
        Me.dgv1.TabIndex = 23
        '
        'formPurchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 441)
        Me.Controls.Add(Me.gbData)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgv1)
        Me.MinimumSize = New System.Drawing.Size(840, 480)
        Me.Name = "formPurchase"
        Me.Text = "formPurchase"
        Me.gbData.ResumeLayout(False)
        Me.gbData.PerformLayout()
        CType(Me.numQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbData As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDrug As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents dtpNow As DateTimePicker
    Friend WithEvents Button5 As Button
    Friend WithEvents txtSup As TextBox
    Friend WithEvents numQty As NumericUpDown
    Friend WithEvents txtCost As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblTotalCost As Label
End Class
