<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class me_form
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.cbjob = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.datebirth = New System.Windows.Forms.DateTimePicker()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtconfirm = New System.Windows.Forms.TextBox()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtaddress)
        Me.Panel1.Controls.Add(Me.cbjob)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.datebirth)
        Me.Panel1.Controls.Add(Me.txtemail)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtname)
        Me.Panel1.Controls.Add(Me.txtpass)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtconfirm)
        Me.Panel1.Controls.Add(Me.txtuser)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.dgv1)
        Me.Panel1.Location = New System.Drawing.Point(157, 81)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(696, 544)
        Me.Panel1.TabIndex = 47
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Controls.Add(Me.btnDelete)
        Me.Panel2.Controls.Add(Me.btnUpdate)
        Me.Panel2.Controls.Add(Me.btnInsert)
        Me.Panel2.Location = New System.Drawing.Point(407, 272)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(219, 116)
        Me.Panel2.TabIndex = 62
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.Enabled = False
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(112, 42)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(99, 30)
        Me.btnCancel.TabIndex = 48
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.Enabled = False
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(112, 6)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(99, 30)
        Me.btnSave.TabIndex = 47
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Location = New System.Drawing.Point(7, 78)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(99, 30)
        Me.btnDelete.TabIndex = 46
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Location = New System.Drawing.Point(7, 42)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(99, 30)
        Me.btnUpdate.TabIndex = 45
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnInsert
        '
        Me.btnInsert.BackColor = System.Drawing.Color.Transparent
        Me.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsert.Location = New System.Drawing.Point(7, 6)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(99, 30)
        Me.btnInsert.TabIndex = 44
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 432)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Address"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 405)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 13)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Job"
        '
        'txtaddress
        '
        Me.txtaddress.Enabled = False
        Me.txtaddress.Location = New System.Drawing.Point(119, 429)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(239, 76)
        Me.txtaddress.TabIndex = 52
        '
        'cbjob
        '
        Me.cbjob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbjob.Enabled = False
        Me.cbjob.FormattingEnabled = True
        Me.cbjob.Location = New System.Drawing.Point(119, 402)
        Me.cbjob.Name = "cbjob"
        Me.cbjob.Size = New System.Drawing.Size(239, 21)
        Me.cbjob.TabIndex = 51
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 380)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Date Of Birth"
        '
        'datebirth
        '
        Me.datebirth.Enabled = False
        Me.datebirth.Location = New System.Drawing.Point(119, 376)
        Me.datebirth.Name = "datebirth"
        Me.datebirth.Size = New System.Drawing.Size(239, 20)
        Me.datebirth.TabIndex = 49
        Me.datebirth.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'txtemail
        '
        Me.txtemail.Enabled = False
        Me.txtemail.Location = New System.Drawing.Point(119, 350)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(239, 20)
        Me.txtemail.TabIndex = 48
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 353)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Email"
        '
        'txtname
        '
        Me.txtname.Enabled = False
        Me.txtname.Location = New System.Drawing.Point(119, 324)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(239, 20)
        Me.txtname.TabIndex = 46
        '
        'txtpass
        '
        Me.txtpass.Enabled = False
        Me.txtpass.Location = New System.Drawing.Point(119, 272)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(239, 20)
        Me.txtpass.TabIndex = 45
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 327)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Name"
        '
        'txtconfirm
        '
        Me.txtconfirm.Enabled = False
        Me.txtconfirm.Location = New System.Drawing.Point(119, 298)
        Me.txtconfirm.Name = "txtconfirm"
        Me.txtconfirm.Size = New System.Drawing.Size(239, 20)
        Me.txtconfirm.TabIndex = 39
        '
        'txtuser
        '
        Me.txtuser.Enabled = False
        Me.txtuser.Location = New System.Drawing.Point(119, 246)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(239, 20)
        Me.txtuser.TabIndex = 38
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 301)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Confirm Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 275)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 20)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Master Employee"
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToDeleteRows = False
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(21, 47)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.Size = New System.Drawing.Size(655, 179)
        Me.dgv1.TabIndex = 0
        '
        'cleanroom
        '
        Me.cleanroom.BackColor = System.Drawing.Color.Transparent
        Me.cleanroom.Enabled = False
        Me.cleanroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cleanroom.Location = New System.Drawing.Point(15, 504)
        Me.cleanroom.Name = "cleanroom"
        Me.cleanroom.Size = New System.Drawing.Size(136, 41)
        Me.cleanroom.TabIndex = 60
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
        Me.addhks.TabIndex = 59
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
        Me.masemp.TabIndex = 58
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
        Me.masitem.TabIndex = 57
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
        Me.masterroom.TabIndex = 56
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
        Me.roomtype.TabIndex = 55
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
        Me.checout.TabIndex = 54
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
        Me.reqadd.TabIndex = 53
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
        Me.checin.TabIndex = 52
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
        Me.reserv.TabIndex = 51
        Me.reserv.Text = "Reservation"
        Me.reserv.UseVisualStyleBackColor = False
        Me.reserv.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(11, 43)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 20)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "nganu"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 13)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Grand Hotel"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(835, -2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 34)
        Me.Button1.TabIndex = 48
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'me_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumTurquoise
        Me.ClientSize = New System.Drawing.Size(865, 542)
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
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(865, 542)
        Me.Name = "me_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ma_form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtconfirm As TextBox
    Friend WithEvents txtuser As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents datebirth As DateTimePicker
    Friend WithEvents txtemail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents cbjob As ComboBox
    Friend WithEvents Label9 As Label
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
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnInsert As Button
End Class
