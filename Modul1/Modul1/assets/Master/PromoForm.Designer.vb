<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PromoForm
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtprodid = New System.Windows.Forms.MaskedTextBox()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txttype = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.datestart = New System.Windows.Forms.DateTimePicker()
        Me.dateend = New System.Windows.Forms.DateTimePicker()
        Me.txtqty = New System.Windows.Forms.NumericUpDown()
        Me.txtreward = New System.Windows.Forms.NumericUpDown()
        Me.datenow = New System.Windows.Forms.DateTimePicker()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtqty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtreward, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(252, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(190, 29)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Manage Promo"
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button4.Enabled = False
        Me.Button4.Location = New System.Drawing.Point(479, 276)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 44
        Me.Button4.Text = "Cancel"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button3.Location = New System.Drawing.Point(479, 247)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 43
        Me.Button3.Text = "Update"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(479, 218)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 42
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button1.Location = New System.Drawing.Point(479, 189)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "Insert"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtname
        '
        Me.txtname.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtname.Enabled = False
        Me.txtname.Location = New System.Drawing.Point(237, 209)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(214, 20)
        Me.txtname.TabIndex = 37
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(159, 291)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Reward"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(159, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Promo Type"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(159, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Buy Qty"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(159, 212)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(159, 186)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Product ID"
        '
        'txtprodid
        '
        Me.txtprodid.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtprodid.Location = New System.Drawing.Point(237, 183)
        Me.txtprodid.Name = "txtprodid"
        Me.txtprodid.ReadOnly = True
        Me.txtprodid.Size = New System.Drawing.Size(181, 20)
        Me.txtprodid.TabIndex = 31
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToDeleteRows = False
        Me.dgv1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Enabled = False
        Me.dgv1.Location = New System.Drawing.Point(11, 46)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.Size = New System.Drawing.Size(688, 129)
        Me.dgv1.TabIndex = 30
        '
        'Button5
        '
        Me.Button5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button5.Enabled = False
        Me.Button5.Location = New System.Drawing.Point(424, 181)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(27, 23)
        Me.Button5.TabIndex = 46
        Me.Button5.Text = "..."
        Me.Button5.UseVisualStyleBackColor = True
        '
        'txttype
        '
        Me.txttype.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txttype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txttype.Enabled = False
        Me.txttype.FormattingEnabled = True
        Me.txttype.Location = New System.Drawing.Point(237, 261)
        Me.txttype.Name = "txttype"
        Me.txttype.Size = New System.Drawing.Size(214, 21)
        Me.txttype.TabIndex = 47
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(160, 343)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "End Date"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(159, 317)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Start Date"
        '
        'datestart
        '
        Me.datestart.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.datestart.Enabled = False
        Me.datestart.Location = New System.Drawing.Point(237, 314)
        Me.datestart.Name = "datestart"
        Me.datestart.Size = New System.Drawing.Size(214, 20)
        Me.datestart.TabIndex = 50
        '
        'dateend
        '
        Me.dateend.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.dateend.Enabled = False
        Me.dateend.Location = New System.Drawing.Point(237, 340)
        Me.dateend.Name = "dateend"
        Me.dateend.Size = New System.Drawing.Size(214, 20)
        Me.dateend.TabIndex = 51
        '
        'txtqty
        '
        Me.txtqty.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtqty.Enabled = False
        Me.txtqty.Location = New System.Drawing.Point(237, 235)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(214, 20)
        Me.txtqty.TabIndex = 52
        Me.txtqty.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtreward
        '
        Me.txtreward.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtreward.Enabled = False
        Me.txtreward.Location = New System.Drawing.Point(237, 288)
        Me.txtreward.Name = "txtreward"
        Me.txtreward.Size = New System.Drawing.Size(214, 20)
        Me.txtreward.TabIndex = 53
        '
        'datenow
        '
        Me.datenow.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.datenow.Enabled = False
        Me.datenow.Location = New System.Drawing.Point(237, 314)
        Me.datenow.Name = "datenow"
        Me.datenow.Size = New System.Drawing.Size(214, 20)
        Me.datenow.TabIndex = 54
        '
        'PromoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 382)
        Me.Controls.Add(Me.datenow)
        Me.Controls.Add(Me.txtreward)
        Me.Controls.Add(Me.txtqty)
        Me.Controls.Add(Me.dateend)
        Me.Controls.Add(Me.datestart)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txttype)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtprodid)
        Me.Controls.Add(Me.dgv1)
        Me.MinimumSize = New System.Drawing.Size(475, 382)
        Me.Name = "PromoForm"
        Me.Text = "PromoForm"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtqty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtreward, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtprodid As MaskedTextBox
    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents Button5 As Button
    Friend WithEvents txttype As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents datestart As DateTimePicker
    Friend WithEvents dateend As DateTimePicker
    Friend WithEvents txtqty As NumericUpDown
    Friend WithEvents txtreward As NumericUpDown
    Friend WithEvents datenow As DateTimePicker
End Class
