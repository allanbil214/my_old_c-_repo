<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rai_form
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cleanroom = New System.Windows.Forms.Button()
        Me.addhks = New System.Windows.Forms.Button()
        Me.masemp = New System.Windows.Forms.Button()
        Me.masitem = New System.Windows.Forms.Button()
        Me.masterroom = New System.Windows.Forms.Button()
        Me.roomtype = New System.Windows.Forms.Button()
        Me.checout = New System.Windows.Forms.Button()
        Me.reqadd = New System.Windows.Forms.Button()
        Me.checin = New System.Windows.Forms.Button()
        Me.reserv = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(157, 81)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(696, 449)
        Me.Panel1.TabIndex = 60
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(327, 285)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(85, 34)
        Me.Button3.TabIndex = 63
        Me.Button3.Text = "Submit"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(98, 296)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Label8"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 296)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Total Charge :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(417, 194)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 76)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(405, 112)
        Me.DataGridView1.TabIndex = 62
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(306, 36)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 34)
        Me.Button2.TabIndex = 61
        Me.Button2.Text = "Add"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(106, 50)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(165, 20)
        Me.NumericUpDown1.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 13)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Qty"
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(106, 23)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(165, 21)
        Me.ComboBox2.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Item"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(127, 44)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(165, 21)
        Me.ComboBox1.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Room Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(198, 20)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Request Additional Item(s)"
        '
        'cleanroom
        '
        Me.cleanroom.BackColor = System.Drawing.Color.Transparent
        Me.cleanroom.Enabled = False
        Me.cleanroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cleanroom.Location = New System.Drawing.Point(15, 504)
        Me.cleanroom.Name = "cleanroom"
        Me.cleanroom.Size = New System.Drawing.Size(136, 41)
        Me.cleanroom.TabIndex = 59
        Me.cleanroom.Text = "Cleaning Room"
        Me.cleanroom.UseVisualStyleBackColor = False
        Me.cleanroom.Visible = False
        '
        'addhks
        '
        Me.addhks.BackColor = System.Drawing.Color.Transparent
        Me.addhks.Enabled = False
        Me.addhks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addhks.Location = New System.Drawing.Point(15, 457)
        Me.addhks.Name = "addhks"
        Me.addhks.Size = New System.Drawing.Size(136, 41)
        Me.addhks.TabIndex = 58
        Me.addhks.Text = "Add Housekeeping Schedule"
        Me.addhks.UseVisualStyleBackColor = False
        Me.addhks.Visible = False
        '
        'masemp
        '
        Me.masemp.BackColor = System.Drawing.Color.Transparent
        Me.masemp.Enabled = False
        Me.masemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.masemp.Location = New System.Drawing.Point(15, 410)
        Me.masemp.Name = "masemp"
        Me.masemp.Size = New System.Drawing.Size(136, 41)
        Me.masemp.TabIndex = 57
        Me.masemp.Text = "Master Employee"
        Me.masemp.UseVisualStyleBackColor = False
        Me.masemp.Visible = False
        '
        'masitem
        '
        Me.masitem.BackColor = System.Drawing.Color.Transparent
        Me.masitem.Enabled = False
        Me.masitem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.masitem.Location = New System.Drawing.Point(15, 363)
        Me.masitem.Name = "masitem"
        Me.masitem.Size = New System.Drawing.Size(136, 41)
        Me.masitem.TabIndex = 56
        Me.masitem.Text = "Master Item"
        Me.masitem.UseVisualStyleBackColor = False
        Me.masitem.Visible = False
        '
        'masterroom
        '
        Me.masterroom.BackColor = System.Drawing.Color.Transparent
        Me.masterroom.Enabled = False
        Me.masterroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.masterroom.Location = New System.Drawing.Point(15, 316)
        Me.masterroom.Name = "masterroom"
        Me.masterroom.Size = New System.Drawing.Size(136, 41)
        Me.masterroom.TabIndex = 55
        Me.masterroom.Text = "Master Room"
        Me.masterroom.UseVisualStyleBackColor = False
        Me.masterroom.Visible = False
        '
        'roomtype
        '
        Me.roomtype.BackColor = System.Drawing.Color.Transparent
        Me.roomtype.Enabled = False
        Me.roomtype.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.roomtype.Location = New System.Drawing.Point(15, 269)
        Me.roomtype.Name = "roomtype"
        Me.roomtype.Size = New System.Drawing.Size(136, 41)
        Me.roomtype.TabIndex = 54
        Me.roomtype.Text = "Master Room Type"
        Me.roomtype.UseVisualStyleBackColor = False
        Me.roomtype.Visible = False
        '
        'checout
        '
        Me.checout.BackColor = System.Drawing.Color.Transparent
        Me.checout.Enabled = False
        Me.checout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checout.Location = New System.Drawing.Point(15, 222)
        Me.checout.Name = "checout"
        Me.checout.Size = New System.Drawing.Size(136, 41)
        Me.checout.TabIndex = 53
        Me.checout.Text = "Check Out"
        Me.checout.UseVisualStyleBackColor = False
        Me.checout.Visible = False
        '
        'reqadd
        '
        Me.reqadd.BackColor = System.Drawing.Color.Transparent
        Me.reqadd.Enabled = False
        Me.reqadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.reqadd.Location = New System.Drawing.Point(15, 175)
        Me.reqadd.Name = "reqadd"
        Me.reqadd.Size = New System.Drawing.Size(136, 41)
        Me.reqadd.TabIndex = 52
        Me.reqadd.Text = "Request Additional Item(s)"
        Me.reqadd.UseVisualStyleBackColor = False
        Me.reqadd.Visible = False
        '
        'checin
        '
        Me.checin.BackColor = System.Drawing.Color.Transparent
        Me.checin.Enabled = False
        Me.checin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checin.Location = New System.Drawing.Point(15, 128)
        Me.checin.Name = "checin"
        Me.checin.Size = New System.Drawing.Size(136, 41)
        Me.checin.TabIndex = 51
        Me.checin.Text = "Check In"
        Me.checin.UseVisualStyleBackColor = False
        Me.checin.Visible = False
        '
        'reserv
        '
        Me.reserv.BackColor = System.Drawing.Color.Transparent
        Me.reserv.Enabled = False
        Me.reserv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.reserv.Location = New System.Drawing.Point(15, 81)
        Me.reserv.Name = "reserv"
        Me.reserv.Size = New System.Drawing.Size(136, 41)
        Me.reserv.TabIndex = 50
        Me.reserv.Text = "Reservation"
        Me.reserv.UseVisualStyleBackColor = False
        Me.reserv.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 20)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "nganu"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Grand Hotel"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(835, -2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 34)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'rai_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumTurquoise
        Me.ClientSize = New System.Drawing.Size(865, 542)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cleanroom)
        Me.Controls.Add(Me.addhks)
        Me.Controls.Add(Me.masemp)
        Me.Controls.Add(Me.masitem)
        Me.Controls.Add(Me.masterroom)
        Me.Controls.Add(Me.roomtype)
        Me.Controls.Add(Me.checout)
        Me.Controls.Add(Me.reqadd)
        Me.Controls.Add(Me.checin)
        Me.Controls.Add(Me.reserv)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "rai_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "rai_form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents cleanroom As Button
    Friend WithEvents addhks As Button
    Friend WithEvents masemp As Button
    Friend WithEvents masitem As Button
    Friend WithEvents masterroom As Button
    Friend WithEvents roomtype As Button
    Friend WithEvents checout As Button
    Friend WithEvents reqadd As Button
    Friend WithEvents checin As Button
    Friend WithEvents reserv As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
End Class
