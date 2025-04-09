<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.reserv = New System.Windows.Forms.Button()
        Me.checin = New System.Windows.Forms.Button()
        Me.reqadd = New System.Windows.Forms.Button()
        Me.checout = New System.Windows.Forms.Button()
        Me.roomtype = New System.Windows.Forms.Button()
        Me.masterroom = New System.Windows.Forms.Button()
        Me.masitem = New System.Windows.Forms.Button()
        Me.masemp = New System.Windows.Forms.Button()
        Me.addhks = New System.Windows.Forms.Button()
        Me.cleanroom = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(835, -2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 34)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Grand Hotel"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "nganu"
        '
        'reserv
        '
        Me.reserv.BackColor = System.Drawing.Color.Transparent
        Me.reserv.Enabled = False
        Me.reserv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.reserv.Location = New System.Drawing.Point(15, 81)
        Me.reserv.Name = "reserv"
        Me.reserv.Size = New System.Drawing.Size(136, 41)
        Me.reserv.TabIndex = 9
        Me.reserv.Text = "Reservation"
        Me.reserv.UseVisualStyleBackColor = False
        Me.reserv.Visible = False
        '
        'checin
        '
        Me.checin.BackColor = System.Drawing.Color.Transparent
        Me.checin.Enabled = False
        Me.checin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checin.Location = New System.Drawing.Point(15, 128)
        Me.checin.Name = "checin"
        Me.checin.Size = New System.Drawing.Size(136, 41)
        Me.checin.TabIndex = 10
        Me.checin.Text = "Check In"
        Me.checin.UseVisualStyleBackColor = False
        Me.checin.Visible = False
        '
        'reqadd
        '
        Me.reqadd.BackColor = System.Drawing.Color.Transparent
        Me.reqadd.Enabled = False
        Me.reqadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.reqadd.Location = New System.Drawing.Point(15, 175)
        Me.reqadd.Name = "reqadd"
        Me.reqadd.Size = New System.Drawing.Size(136, 41)
        Me.reqadd.TabIndex = 11
        Me.reqadd.Text = "Request Additional Item(s)"
        Me.reqadd.UseVisualStyleBackColor = False
        Me.reqadd.Visible = False
        '
        'checout
        '
        Me.checout.BackColor = System.Drawing.Color.Transparent
        Me.checout.Enabled = False
        Me.checout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checout.Location = New System.Drawing.Point(15, 222)
        Me.checout.Name = "checout"
        Me.checout.Size = New System.Drawing.Size(136, 41)
        Me.checout.TabIndex = 12
        Me.checout.Text = "Check Out"
        Me.checout.UseVisualStyleBackColor = False
        Me.checout.Visible = False
        '
        'roomtype
        '
        Me.roomtype.BackColor = System.Drawing.Color.Transparent
        Me.roomtype.Enabled = False
        Me.roomtype.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.roomtype.Location = New System.Drawing.Point(15, 269)
        Me.roomtype.Name = "roomtype"
        Me.roomtype.Size = New System.Drawing.Size(136, 41)
        Me.roomtype.TabIndex = 13
        Me.roomtype.Text = "Master Room Type"
        Me.roomtype.UseVisualStyleBackColor = False
        Me.roomtype.Visible = False
        '
        'masterroom
        '
        Me.masterroom.BackColor = System.Drawing.Color.Transparent
        Me.masterroom.Enabled = False
        Me.masterroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.masterroom.Location = New System.Drawing.Point(15, 316)
        Me.masterroom.Name = "masterroom"
        Me.masterroom.Size = New System.Drawing.Size(136, 41)
        Me.masterroom.TabIndex = 14
        Me.masterroom.Text = "Master Room"
        Me.masterroom.UseVisualStyleBackColor = False
        Me.masterroom.Visible = False
        '
        'masitem
        '
        Me.masitem.BackColor = System.Drawing.Color.Transparent
        Me.masitem.Enabled = False
        Me.masitem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.masitem.Location = New System.Drawing.Point(15, 363)
        Me.masitem.Name = "masitem"
        Me.masitem.Size = New System.Drawing.Size(136, 41)
        Me.masitem.TabIndex = 15
        Me.masitem.Text = "Master Item"
        Me.masitem.UseVisualStyleBackColor = False
        Me.masitem.Visible = False
        '
        'masemp
        '
        Me.masemp.BackColor = System.Drawing.Color.Transparent
        Me.masemp.Enabled = False
        Me.masemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.masemp.Location = New System.Drawing.Point(15, 410)
        Me.masemp.Name = "masemp"
        Me.masemp.Size = New System.Drawing.Size(136, 41)
        Me.masemp.TabIndex = 16
        Me.masemp.Text = "Master Employee"
        Me.masemp.UseVisualStyleBackColor = False
        Me.masemp.Visible = False
        '
        'addhks
        '
        Me.addhks.BackColor = System.Drawing.Color.Transparent
        Me.addhks.Enabled = False
        Me.addhks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addhks.Location = New System.Drawing.Point(15, 457)
        Me.addhks.Name = "addhks"
        Me.addhks.Size = New System.Drawing.Size(136, 41)
        Me.addhks.TabIndex = 17
        Me.addhks.Text = "Add Housekeeping Schedule"
        Me.addhks.UseVisualStyleBackColor = False
        Me.addhks.Visible = False
        '
        'cleanroom
        '
        Me.cleanroom.BackColor = System.Drawing.Color.Transparent
        Me.cleanroom.Enabled = False
        Me.cleanroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cleanroom.Location = New System.Drawing.Point(15, 504)
        Me.cleanroom.Name = "cleanroom"
        Me.cleanroom.Size = New System.Drawing.Size(136, 41)
        Me.cleanroom.TabIndex = 18
        Me.cleanroom.Text = "Cleaning Room"
        Me.cleanroom.UseVisualStyleBackColor = False
        Me.cleanroom.Visible = False
        '
        'Form1
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
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(865, 542)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents reserv As Button
    Friend WithEvents checin As Button
    Friend WithEvents reqadd As Button
    Friend WithEvents checout As Button
    Friend WithEvents roomtype As Button
    Friend WithEvents masterroom As Button
    Friend WithEvents masitem As Button
    Friend WithEvents masemp As Button
    Friend WithEvents addhks As Button
    Friend WithEvents cleanroom As Button
End Class
