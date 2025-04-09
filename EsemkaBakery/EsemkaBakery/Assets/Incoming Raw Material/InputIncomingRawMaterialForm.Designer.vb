<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputIncomingRawMaterialForm
    Inherits EsemkaBakery.TemplateFOrm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.cbMaterialName = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dateBestBefore = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dateIncoming = New System.Windows.Forms.DateTimePicker()
        Me.cbEmpName = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.colNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIncomingId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIncomingDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmpId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRawId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBestBefore = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colWeight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.58209!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.41791!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtWeight, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cbMaterialName, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.dateBestBefore, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(17, 42)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(359, 125)
        Me.TableLayoutPanel1.TabIndex = 7
        '
        'txtWeight
        '
        Me.txtWeight.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtWeight.Location = New System.Drawing.Point(246, 67)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(110, 20)
        Me.txtWeight.TabIndex = 0
        '
        'cbMaterialName
        '
        Me.cbMaterialName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbMaterialName.FormattingEnabled = True
        Me.cbMaterialName.Location = New System.Drawing.Point(159, 3)
        Me.cbMaterialName.Name = "cbMaterialName"
        Me.cbMaterialName.Size = New System.Drawing.Size(197, 21)
        Me.cbMaterialName.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button1.Location = New System.Drawing.Point(281, 97)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Raw Material Name"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Best Before"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Raw Material Weight (grams)"
        '
        'dateBestBefore
        '
        Me.dateBestBefore.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dateBestBefore.Location = New System.Drawing.Point(159, 37)
        Me.dateBestBefore.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.dateBestBefore.Name = "dateBestBefore"
        Me.dateBestBefore.Size = New System.Drawing.Size(197, 20)
        Me.dateBestBefore.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label1.Location = New System.Drawing.Point(12, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(611, 29)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Esemka Bakery : Input Incoming Raw Material Form" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.2434!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.7566!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.dateIncoming, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.cbEmpName, 1, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(451, 42)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(341, 65)
        Me.TableLayoutPanel2.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Incoming Date"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Employee Name"
        '
        'dateIncoming
        '
        Me.dateIncoming.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dateIncoming.Location = New System.Drawing.Point(129, 6)
        Me.dateIncoming.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.dateIncoming.Name = "dateIncoming"
        Me.dateIncoming.Size = New System.Drawing.Size(209, 20)
        Me.dateIncoming.TabIndex = 2
        '
        'cbEmpName
        '
        Me.cbEmpName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbEmpName.FormattingEnabled = True
        Me.cbEmpName.Location = New System.Drawing.Point(129, 35)
        Me.cbEmpName.Name = "cbEmpName"
        Me.cbEmpName.Size = New System.Drawing.Size(209, 21)
        Me.cbEmpName.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(717, 417)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Submit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToDeleteRows = False
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNo, Me.colIncomingId, Me.colIncomingDate, Me.colEmpId, Me.colDescription, Me.colRawId, Me.colBestBefore, Me.colWeight})
        Me.dgv1.Location = New System.Drawing.Point(12, 173)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv1.Size = New System.Drawing.Size(780, 238)
        Me.dgv1.TabIndex = 9
        '
        'colNo
        '
        Me.colNo.HeaderText = "No"
        Me.colNo.Name = "colNo"
        Me.colNo.ReadOnly = True
        '
        'colIncomingId
        '
        Me.colIncomingId.HeaderText = "Incoming Raw Material Id"
        Me.colIncomingId.Name = "colIncomingId"
        Me.colIncomingId.ReadOnly = True
        '
        'colIncomingDate
        '
        Me.colIncomingDate.HeaderText = "Incoming Date"
        Me.colIncomingDate.Name = "colIncomingDate"
        Me.colIncomingDate.ReadOnly = True
        '
        'colEmpId
        '
        Me.colEmpId.HeaderText = "Employee Id"
        Me.colEmpId.Name = "colEmpId"
        Me.colEmpId.ReadOnly = True
        '
        'colDescription
        '
        Me.colDescription.HeaderText = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.ReadOnly = True
        '
        'colRawId
        '
        Me.colRawId.HeaderText = "Raw Material Id"
        Me.colRawId.Name = "colRawId"
        Me.colRawId.ReadOnly = True
        '
        'colBestBefore
        '
        Me.colBestBefore.HeaderText = "Best Before Date"
        Me.colBestBefore.Name = "colBestBefore"
        Me.colBestBefore.ReadOnly = True
        '
        'colWeight
        '
        Me.colWeight.HeaderText = "Weight In Gram"
        Me.colWeight.Name = "colWeight"
        Me.colWeight.ReadOnly = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(454, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Description"
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(580, 110)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(209, 52)
        Me.txtDesc.TabIndex = 8
        '
        'InputIncomingRawMaterialForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(804, 451)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.dgv1)
        Me.Name = "InputIncomingRawMaterialForm"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents cbMaterialName As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dateIncoming As DateTimePicker
    Friend WithEvents Button2 As Button
    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents dateBestBefore As DateTimePicker
    Friend WithEvents cbEmpName As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents colNo As DataGridViewTextBoxColumn
    Friend WithEvents colIncomingId As DataGridViewTextBoxColumn
    Friend WithEvents colIncomingDate As DataGridViewTextBoxColumn
    Friend WithEvents colEmpId As DataGridViewTextBoxColumn
    Friend WithEvents colDescription As DataGridViewTextBoxColumn
    Friend WithEvents colRawId As DataGridViewTextBoxColumn
    Friend WithEvents colBestBefore As DataGridViewTextBoxColumn
    Friend WithEvents colWeight As DataGridViewTextBoxColumn
End Class
