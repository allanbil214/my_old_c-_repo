<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class check_form
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
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbfemale = New System.Windows.Forms.RadioButton()
        Me.rbmale = New System.Windows.Forms.RadioButton()
        Me.txtnik = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtage = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtnumber = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.txtsearch = New System.Windows.Forms.Button()
        Me.txtbooking = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cleanroom = New System.Windows.Forms.Button()
        Me.addhks = New System.Windows.Forms.Button()
        Me.masemp = New System.Windows.Forms.Button()
        Me.masitem = New System.Windows.Forms.Button()
        Me.masterroom = New System.Windows.Forms.Button()
        Me.roomtype = New System.Windows.Forms.Button()
        Me.checout = New System.Windows.Forms.Button()
        Me.checin = New System.Windows.Forms.Button()
        Me.reserv = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.reqadd = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.btnsubmit)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.txtsearch)
        Me.Panel1.Controls.Add(Me.txtbooking)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(157, 81)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(739, 449)
        Me.Panel1.TabIndex = 60
        '
        'btnsubmit
        '
        Me.btnsubmit.BackColor = System.Drawing.Color.Transparent
        Me.btnsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsubmit.Location = New System.Drawing.Point(602, 313)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(88, 31)
        Me.btnsubmit.TabIndex = 64
        Me.btnsubmit.Text = "Check In"
        Me.btnsubmit.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbfemale)
        Me.GroupBox2.Controls.Add(Me.rbmale)
        Me.GroupBox2.Controls.Add(Me.txtnik)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtage)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtname)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtemail)
        Me.GroupBox2.Controls.Add(Me.txtnumber)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(377, 82)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(313, 225)
        Me.GroupBox2.TabIndex = 63
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Customer"
        '
        'rbfemale
        '
        Me.rbfemale.AutoSize = True
        Me.rbfemale.Location = New System.Drawing.Point(203, 105)
        Me.rbfemale.Name = "rbfemale"
        Me.rbfemale.Size = New System.Drawing.Size(59, 17)
        Me.rbfemale.TabIndex = 62
        Me.rbfemale.TabStop = True
        Me.rbfemale.Text = "Female"
        Me.rbfemale.UseVisualStyleBackColor = True
        '
        'rbmale
        '
        Me.rbmale.AutoSize = True
        Me.rbmale.Location = New System.Drawing.Point(116, 105)
        Me.rbmale.Name = "rbmale"
        Me.rbmale.Size = New System.Drawing.Size(48, 17)
        Me.rbmale.TabIndex = 61
        Me.rbmale.TabStop = True
        Me.rbmale.Text = "Male"
        Me.rbmale.UseVisualStyleBackColor = True
        '
        'txtnik
        '
        Me.txtnik.Location = New System.Drawing.Point(116, 156)
        Me.txtnik.Name = "txtnik"
        Me.txtnik.Size = New System.Drawing.Size(175, 20)
        Me.txtnik.TabIndex = 60
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(19, 156)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(25, 13)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "NIK"
        '
        'txtage
        '
        Me.txtage.Location = New System.Drawing.Point(116, 130)
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(175, 20)
        Me.txtage.TabIndex = 58
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Age"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(116, 52)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(175, 20)
        Me.txtname.TabIndex = 55
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Gender"
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(116, 78)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(175, 20)
        Me.txtemail.TabIndex = 53
        '
        'txtnumber
        '
        Me.txtnumber.Location = New System.Drawing.Point(116, 26)
        Me.txtnumber.Name = "txtnumber"
        Me.txtnumber.Size = New System.Drawing.Size(175, 20)
        Me.txtnumber.TabIndex = 52
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Email"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Phone Number"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgv1)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 225)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Room Details"
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToDeleteRows = False
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(18, 19)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.Size = New System.Drawing.Size(314, 190)
        Me.dgv1.TabIndex = 0
        '
        'txtsearch
        '
        Me.txtsearch.BackColor = System.Drawing.Color.Transparent
        Me.txtsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtsearch.Location = New System.Drawing.Point(386, 38)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(88, 31)
        Me.txtsearch.TabIndex = 61
        Me.txtsearch.Text = "Search"
        Me.txtsearch.UseVisualStyleBackColor = False
        '
        'txtbooking
        '
        Me.txtbooking.Location = New System.Drawing.Point(151, 44)
        Me.txtbooking.Name = "txtbooking"
        Me.txtbooking.Size = New System.Drawing.Size(207, 20)
        Me.txtbooking.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Booking Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Check In"
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
        Me.Button1.Location = New System.Drawing.Point(878, -2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 34)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
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
        'check_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumTurquoise
        Me.ClientSize = New System.Drawing.Size(908, 542)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cleanroom)
        Me.Controls.Add(Me.addhks)
        Me.Controls.Add(Me.masemp)
        Me.Controls.Add(Me.masitem)
        Me.Controls.Add(Me.masterroom)
        Me.Controls.Add(Me.roomtype)
        Me.Controls.Add(Me.checout)
        Me.Controls.Add(Me.checin)
        Me.Controls.Add(Me.reserv)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.reqadd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(865, 542)
        Me.Name = "check_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "check_form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents checin As Button
    Friend WithEvents reserv As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents reqadd As Button
    Friend WithEvents txtsearch As Button
    Friend WithEvents txtbooking As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtage As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtnumber As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents rbfemale As RadioButton
    Friend WithEvents rbmale As RadioButton
    Friend WithEvents txtnik As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnsubmit As Button
End Class
