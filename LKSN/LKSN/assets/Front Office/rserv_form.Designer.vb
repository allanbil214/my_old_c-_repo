<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class rserv_form
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvitem = New System.Windows.Forms.DataGridView()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.numqty = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbitem = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.lblnem = New System.Windows.Forms.Label()
        Me.txtnumber = New System.Windows.Forms.TextBox()
        Me.lblnum = New System.Windows.Forms.Label()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.lblsearch = New System.Windows.Forms.Label()
        Me.rbsearch = New System.Windows.Forms.RadioButton()
        Me.rbadd = New System.Windows.Forms.RadioButton()
        Me.dgvcustomer = New System.Windows.Forms.DataGridView()
        Me.dgvroom2 = New System.Windows.Forms.DataGridView()
        Me.btnleft = New System.Windows.Forms.Button()
        Me.btnright = New System.Windows.Forms.Button()
        Me.dgvroom1 = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.txtnight = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbroomtype = New System.Windows.Forms.ComboBox()
        Me.startdate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvitem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numqty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvcustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvroom2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvroom1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cleanroom
        '
        Me.cleanroom.BackColor = System.Drawing.Color.Transparent
        Me.cleanroom.Enabled = False
        Me.cleanroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cleanroom.Location = New System.Drawing.Point(15, 504)
        Me.cleanroom.Name = "cleanroom"
        Me.cleanroom.Size = New System.Drawing.Size(136, 41)
        Me.cleanroom.TabIndex = 58
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
        Me.addhks.TabIndex = 57
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
        Me.masemp.TabIndex = 56
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
        Me.masitem.TabIndex = 55
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
        Me.masterroom.TabIndex = 54
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
        Me.roomtype.TabIndex = 53
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
        Me.checout.TabIndex = 52
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
        Me.reqadd.TabIndex = 51
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
        Me.checin.TabIndex = 50
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
        Me.reserv.TabIndex = 49
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
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "nganu"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Grand Hotel"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(901, -2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 34)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 20)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Reservation"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.dgvroom2)
        Me.Panel1.Controls.Add(Me.btnleft)
        Me.Panel1.Controls.Add(Me.btnright)
        Me.Panel1.Controls.Add(Me.dgvroom1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.btnsearch)
        Me.Panel1.Controls.Add(Me.txtnight)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.cbroomtype)
        Me.Panel1.Controls.Add(Me.startdate)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(157, 81)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(762, 531)
        Me.Panel1.TabIndex = 59
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(373, 122)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 13)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "List selected rooms :"
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(634, 505)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 50
        Me.Button6.Text = "Submit"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(651, 480)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 13)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "rp.0000"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(577, 480)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 13)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Total Price"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvitem)
        Me.GroupBox2.Controls.Add(Me.btnadd)
        Me.GroupBox2.Controls.Add(Me.numqty)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.cbitem)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(342, 282)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(367, 195)
        Me.GroupBox2.TabIndex = 47
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Request Additional Items"
        '
        'dgvitem
        '
        Me.dgvitem.AllowUserToAddRows = False
        Me.dgvitem.AllowUserToDeleteRows = False
        Me.dgvitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvitem.Location = New System.Drawing.Point(6, 71)
        Me.dgvitem.Name = "dgvitem"
        Me.dgvitem.ReadOnly = True
        Me.dgvitem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvitem.Size = New System.Drawing.Size(348, 111)
        Me.dgvitem.TabIndex = 48
        '
        'btnadd
        '
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadd.Location = New System.Drawing.Point(279, 42)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 23)
        Me.btnadd.TabIndex = 48
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'numqty
        '
        Me.numqty.Location = New System.Drawing.Point(82, 45)
        Me.numqty.Name = "numqty"
        Me.numqty.Size = New System.Drawing.Size(186, 20)
        Me.numqty.TabIndex = 49
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(19, 47)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(23, 13)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "Qty"
        '
        'cbitem
        '
        Me.cbitem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbitem.FormattingEnabled = True
        Me.cbitem.Location = New System.Drawing.Point(82, 18)
        Me.cbitem.Name = "cbitem"
        Me.cbitem.Size = New System.Drawing.Size(186, 21)
        Me.cbitem.TabIndex = 47
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 13)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Item"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.lblnem)
        Me.GroupBox1.Controls.Add(Me.txtnumber)
        Me.GroupBox1.Controls.Add(Me.lblnum)
        Me.GroupBox1.Controls.Add(Me.txtsearch)
        Me.GroupBox1.Controls.Add(Me.lblsearch)
        Me.GroupBox1.Controls.Add(Me.rbsearch)
        Me.GroupBox1.Controls.Add(Me.rbadd)
        Me.GroupBox1.Controls.Add(Me.dgvcustomer)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 282)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(315, 195)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Data"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(126, 97)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(166, 20)
        Me.txtname.TabIndex = 51
        Me.txtname.Visible = False
        '
        'lblnem
        '
        Me.lblnem.AutoSize = True
        Me.lblnem.Location = New System.Drawing.Point(14, 100)
        Me.lblnem.Name = "lblnem"
        Me.lblnem.Size = New System.Drawing.Size(35, 13)
        Me.lblnem.TabIndex = 50
        Me.lblnem.Text = "Name"
        Me.lblnem.Visible = False
        '
        'txtnumber
        '
        Me.txtnumber.Location = New System.Drawing.Point(126, 71)
        Me.txtnumber.Name = "txtnumber"
        Me.txtnumber.Size = New System.Drawing.Size(166, 20)
        Me.txtnumber.TabIndex = 49
        Me.txtnumber.Visible = False
        '
        'lblnum
        '
        Me.lblnum.AutoSize = True
        Me.lblnum.Location = New System.Drawing.Point(14, 74)
        Me.lblnum.Name = "lblnum"
        Me.lblnum.Size = New System.Drawing.Size(78, 13)
        Me.lblnum.TabIndex = 48
        Me.lblnum.Text = "Phone Number"
        Me.lblnum.Visible = False
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(203, 18)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(100, 20)
        Me.txtsearch.TabIndex = 47
        '
        'lblsearch
        '
        Me.lblsearch.AutoSize = True
        Me.lblsearch.Location = New System.Drawing.Point(156, 21)
        Me.lblsearch.Name = "lblsearch"
        Me.lblsearch.Size = New System.Drawing.Size(41, 13)
        Me.lblsearch.TabIndex = 46
        Me.lblsearch.Text = "Search"
        '
        'rbsearch
        '
        Me.rbsearch.AutoSize = True
        Me.rbsearch.Checked = True
        Me.rbsearch.Location = New System.Drawing.Point(83, 19)
        Me.rbsearch.Name = "rbsearch"
        Me.rbsearch.Size = New System.Drawing.Size(59, 17)
        Me.rbsearch.TabIndex = 45
        Me.rbsearch.TabStop = True
        Me.rbsearch.Text = "Search"
        Me.rbsearch.UseVisualStyleBackColor = True
        '
        'rbadd
        '
        Me.rbadd.AutoSize = True
        Me.rbadd.Location = New System.Drawing.Point(12, 19)
        Me.rbadd.Name = "rbadd"
        Me.rbadd.Size = New System.Drawing.Size(67, 17)
        Me.rbadd.TabIndex = 44
        Me.rbadd.Text = "Add new"
        Me.rbadd.UseVisualStyleBackColor = True
        '
        'dgvcustomer
        '
        Me.dgvcustomer.AllowUserToAddRows = False
        Me.dgvcustomer.AllowUserToDeleteRows = False
        Me.dgvcustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcustomer.Location = New System.Drawing.Point(12, 47)
        Me.dgvcustomer.Name = "dgvcustomer"
        Me.dgvcustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvcustomer.Size = New System.Drawing.Size(291, 135)
        Me.dgvcustomer.TabIndex = 43
        '
        'dgvroom2
        '
        Me.dgvroom2.AllowUserToAddRows = False
        Me.dgvroom2.AllowUserToDeleteRows = False
        Me.dgvroom2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvroom2.Location = New System.Drawing.Point(376, 141)
        Me.dgvroom2.Name = "dgvroom2"
        Me.dgvroom2.ReadOnly = True
        Me.dgvroom2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvroom2.Size = New System.Drawing.Size(303, 135)
        Me.dgvroom2.TabIndex = 45
        '
        'btnleft
        '
        Me.btnleft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnleft.Location = New System.Drawing.Point(330, 207)
        Me.btnleft.Name = "btnleft"
        Me.btnleft.Size = New System.Drawing.Size(40, 38)
        Me.btnleft.TabIndex = 44
        Me.btnleft.Text = "<<"
        Me.btnleft.UseVisualStyleBackColor = True
        '
        'btnright
        '
        Me.btnright.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnright.Location = New System.Drawing.Point(330, 163)
        Me.btnright.Name = "btnright"
        Me.btnright.Size = New System.Drawing.Size(40, 38)
        Me.btnright.TabIndex = 43
        Me.btnright.Text = ">>"
        Me.btnright.UseVisualStyleBackColor = True
        '
        'dgvroom1
        '
        Me.dgvroom1.AllowUserToAddRows = False
        Me.dgvroom1.AllowUserToDeleteRows = False
        Me.dgvroom1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvroom1.Location = New System.Drawing.Point(21, 141)
        Me.dgvroom1.Name = "dgvroom1"
        Me.dgvroom1.ReadOnly = True
        Me.dgvroom1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvroom1.Size = New System.Drawing.Size(303, 135)
        Me.dgvroom1.TabIndex = 42
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 13)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "List available rooms :"
        '
        'btnsearch
        '
        Me.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsearch.Location = New System.Drawing.Point(313, 65)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(75, 23)
        Me.btnsearch.TabIndex = 40
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'txtnight
        '
        Me.txtnight.Location = New System.Drawing.Point(411, 41)
        Me.txtnight.Name = "txtnight"
        Me.txtnight.Size = New System.Drawing.Size(100, 20)
        Me.txtnight.TabIndex = 39
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(310, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Number of nights"
        '
        'cbroomtype
        '
        Me.cbroomtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbroomtype.FormattingEnabled = True
        Me.cbroomtype.Location = New System.Drawing.Point(104, 67)
        Me.cbroomtype.Name = "cbroomtype"
        Me.cbroomtype.Size = New System.Drawing.Size(200, 21)
        Me.cbroomtype.TabIndex = 37
        '
        'startdate
        '
        Me.startdate.Location = New System.Drawing.Point(104, 41)
        Me.startdate.Name = "startdate"
        Me.startdate.Size = New System.Drawing.Size(200, 20)
        Me.startdate.TabIndex = 36
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Room Type"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Start Date"
        '
        'rserv_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumTurquoise
        Me.ClientSize = New System.Drawing.Size(931, 624)
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
        Me.MinimumSize = New System.Drawing.Size(865, 542)
        Me.Name = "rserv_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "rserv_form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvitem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numqty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvcustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvroom2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvroom1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

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
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnleft As Button
    Friend WithEvents btnright As Button
    Friend WithEvents dgvroom1 As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents btnsearch As Button
    Friend WithEvents txtnight As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbroomtype As ComboBox
    Friend WithEvents startdate As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvroom2 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents lblsearch As Label
    Friend WithEvents rbsearch As RadioButton
    Friend WithEvents rbadd As RadioButton
    Friend WithEvents dgvcustomer As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents numqty As NumericUpDown
    Friend WithEvents Label10 As Label
    Friend WithEvents cbitem As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents dgvitem As DataGridView
    Friend WithEvents btnadd As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents lblnem As Label
    Friend WithEvents txtnumber As TextBox
    Friend WithEvents lblnum As Label
    Friend WithEvents Label8 As Label
End Class
