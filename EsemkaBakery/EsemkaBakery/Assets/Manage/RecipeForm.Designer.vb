<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class recipeForm
    Inherits EsemkaBakery.TemplateFOrm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnDeleteRaw = New System.Windows.Forms.Button()
        Me.btnEditRaw = New System.Windows.Forms.Button()
        Me.btnAddRaw = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TotalDataLabel = New System.Windows.Forms.Label()
        Me.SearchBox = New System.Windows.Forms.TextBox()
        Me.txtRawWeight = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbRawName = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtFoodId = New System.Windows.Forms.TextBox()
        Me.txtFoodUnit = New System.Windows.Forms.TextBox()
        Me.txtFoodDesc = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbFoodName = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnDeleteFood = New System.Windows.Forms.Button()
        Me.btnEditFood = New System.Windows.Forms.Button()
        Me.btnAddFood = New System.Windows.Forms.Button()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.colNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRecipeId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOutput = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.s = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRecipeIdRaw = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRawId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colWeight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.s, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(127, 32)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnDeleteRaw
        '
        Me.btnDeleteRaw.Location = New System.Drawing.Point(165, 3)
        Me.btnDeleteRaw.Name = "btnDeleteRaw"
        Me.btnDeleteRaw.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteRaw.TabIndex = 2
        Me.btnDeleteRaw.Text = "Delete"
        Me.btnDeleteRaw.UseVisualStyleBackColor = True
        '
        'btnEditRaw
        '
        Me.btnEditRaw.Location = New System.Drawing.Point(84, 3)
        Me.btnEditRaw.Name = "btnEditRaw"
        Me.btnEditRaw.Size = New System.Drawing.Size(75, 23)
        Me.btnEditRaw.TabIndex = 1
        Me.btnEditRaw.Text = "Edit"
        Me.btnEditRaw.UseVisualStyleBackColor = True
        '
        'btnAddRaw
        '
        Me.btnAddRaw.Location = New System.Drawing.Point(3, 3)
        Me.btnAddRaw.Name = "btnAddRaw"
        Me.btnAddRaw.Size = New System.Drawing.Size(75, 23)
        Me.btnAddRaw.TabIndex = 0
        Me.btnAddRaw.Text = "Add"
        Me.btnAddRaw.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnDeleteRaw)
        Me.Panel1.Controls.Add(Me.btnEditRaw)
        Me.Panel1.Controls.Add(Me.btnAddRaw)
        Me.Panel1.Location = New System.Drawing.Point(500, 343)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(243, 61)
        Me.Panel1.TabIndex = 33
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(46, 32)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Raw Material Name"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Weight In Gram"
        '
        'TotalDataLabel
        '
        Me.TotalDataLabel.AutoSize = True
        Me.TotalDataLabel.Location = New System.Drawing.Point(9, 429)
        Me.TotalDataLabel.Name = "TotalDataLabel"
        Me.TotalDataLabel.Size = New System.Drawing.Size(66, 13)
        Me.TotalDataLabel.TabIndex = 31
        Me.TotalDataLabel.Text = "Total Data : "
        '
        'SearchBox
        '
        Me.SearchBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchBox.Location = New System.Drawing.Point(79, 7)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(161, 20)
        Me.SearchBox.TabIndex = 25
        '
        'txtRawWeight
        '
        Me.txtRawWeight.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRawWeight.Location = New System.Drawing.Point(125, 33)
        Me.txtRawWeight.Name = "txtRawWeight"
        Me.txtRawWeight.Size = New System.Drawing.Size(218, 20)
        Me.txtRawWeight.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label1.Location = New System.Drawing.Point(14, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(365, 29)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Esemka Bakery : Recipe Form" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Search"
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRefresh.Location = New System.Drawing.Point(260, 6)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(64, 21)
        Me.btnRefresh.TabIndex = 2
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.54913!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.45087!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtRawWeight, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.cbRawName, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(448, 252)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(346, 89)
        Me.TableLayoutPanel2.TabIndex = 32
        '
        'cbRawName
        '
        Me.cbRawName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbRawName.FormattingEnabled = True
        Me.cbRawName.Location = New System.Drawing.Point(125, 4)
        Me.cbRawName.Name = "cbRawName"
        Me.cbRawName.Size = New System.Drawing.Size(218, 21)
        Me.cbRawName.TabIndex = 34
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.83041!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.65497!))
        Me.TableLayoutPanel1.Controls.Add(Me.SearchBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnRefresh, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(14, 50)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(342, 34)
        Me.TableLayoutPanel1.TabIndex = 29
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.54913!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.45087!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label9, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label10, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.txtFoodId, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txtFoodUnit, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.txtFoodDesc, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Label8, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Label7, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.cbFoodName, 1, 1)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(448, 90)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 4
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(346, 110)
        Me.TableLayoutPanel3.TabIndex = 35
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Food Id"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 34)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Food Name"
        '
        'txtFoodId
        '
        Me.txtFoodId.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFoodId.Location = New System.Drawing.Point(125, 3)
        Me.txtFoodId.Name = "txtFoodId"
        Me.txtFoodId.ReadOnly = True
        Me.txtFoodId.Size = New System.Drawing.Size(218, 20)
        Me.txtFoodId.TabIndex = 28
        '
        'txtFoodUnit
        '
        Me.txtFoodUnit.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFoodUnit.Location = New System.Drawing.Point(125, 57)
        Me.txtFoodUnit.Name = "txtFoodUnit"
        Me.txtFoodUnit.Size = New System.Drawing.Size(218, 20)
        Me.txtFoodUnit.TabIndex = 30
        '
        'txtFoodDesc
        '
        Me.txtFoodDesc.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFoodDesc.Location = New System.Drawing.Point(125, 85)
        Me.txtFoodDesc.Name = "txtFoodDesc"
        Me.txtFoodDesc.Size = New System.Drawing.Size(218, 20)
        Me.txtFoodDesc.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Description"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Output Unit (Piece)"
        '
        'cbFoodName
        '
        Me.cbFoodName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbFoodName.FormattingEnabled = True
        Me.cbFoodName.Location = New System.Drawing.Point(125, 30)
        Me.cbFoodName.Name = "cbFoodName"
        Me.cbFoodName.Size = New System.Drawing.Size(218, 21)
        Me.cbFoodName.TabIndex = 33
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnDeleteFood)
        Me.Panel2.Controls.Add(Me.btnEditFood)
        Me.Panel2.Controls.Add(Me.btnAddFood)
        Me.Panel2.Location = New System.Drawing.Point(497, 206)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(243, 32)
        Me.Panel2.TabIndex = 34
        '
        'btnDeleteFood
        '
        Me.btnDeleteFood.Location = New System.Drawing.Point(165, 3)
        Me.btnDeleteFood.Name = "btnDeleteFood"
        Me.btnDeleteFood.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteFood.TabIndex = 2
        Me.btnDeleteFood.Text = "Delete"
        Me.btnDeleteFood.UseVisualStyleBackColor = True
        '
        'btnEditFood
        '
        Me.btnEditFood.Location = New System.Drawing.Point(84, 3)
        Me.btnEditFood.Name = "btnEditFood"
        Me.btnEditFood.Size = New System.Drawing.Size(75, 23)
        Me.btnEditFood.TabIndex = 1
        Me.btnEditFood.Text = "Edit"
        Me.btnEditFood.UseVisualStyleBackColor = True
        '
        'btnAddFood
        '
        Me.btnAddFood.Location = New System.Drawing.Point(3, 3)
        Me.btnAddFood.Name = "btnAddFood"
        Me.btnAddFood.Size = New System.Drawing.Size(75, 23)
        Me.btnAddFood.TabIndex = 0
        Me.btnAddFood.Text = "Add"
        Me.btnAddFood.UseVisualStyleBackColor = True
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToDeleteRows = False
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNo, Me.colRecipeId, Me.colId, Me.colOutput, Me.colDesc, Me.colDate, Me.colStatus})
        Me.dgv1.Location = New System.Drawing.Point(12, 97)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv1.Size = New System.Drawing.Size(428, 149)
        Me.dgv1.TabIndex = 36
        '
        'colNo
        '
        Me.colNo.HeaderText = "No"
        Me.colNo.Name = "colNo"
        Me.colNo.ReadOnly = True
        '
        'colRecipeId
        '
        Me.colRecipeId.HeaderText = "Recipe Id"
        Me.colRecipeId.Name = "colRecipeId"
        Me.colRecipeId.ReadOnly = True
        '
        'colId
        '
        Me.colId.HeaderText = "Food Id"
        Me.colId.Name = "colId"
        Me.colId.ReadOnly = True
        '
        'colOutput
        '
        Me.colOutput.HeaderText = "Output Unit"
        Me.colOutput.Name = "colOutput"
        Me.colOutput.ReadOnly = True
        '
        'colDesc
        '
        Me.colDesc.HeaderText = "Description"
        Me.colDesc.Name = "colDesc"
        Me.colDesc.ReadOnly = True
        '
        'colDate
        '
        Me.colDate.HeaderText = "Created Date"
        Me.colDate.Name = "colDate"
        Me.colDate.ReadOnly = True
        '
        'colStatus
        '
        Me.colStatus.HeaderText = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.ReadOnly = True
        '
        's
        '
        Me.s.AllowUserToAddRows = False
        Me.s.AllowUserToDeleteRows = False
        Me.s.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.s.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.colRecipeIdRaw, Me.colRawId, Me.colWeight})
        Me.s.Location = New System.Drawing.Point(12, 252)
        Me.s.Name = "s"
        Me.s.ReadOnly = True
        Me.s.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.s.Size = New System.Drawing.Size(428, 152)
        Me.s.TabIndex = 37
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "No"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'colRecipeIdRaw
        '
        Me.colRecipeIdRaw.HeaderText = "Recipe Id"
        Me.colRecipeIdRaw.Name = "colRecipeIdRaw"
        Me.colRecipeIdRaw.ReadOnly = True
        '
        'colRawId
        '
        Me.colRawId.HeaderText = "Raw Material Id"
        Me.colRawId.Name = "colRawId"
        Me.colRawId.ReadOnly = True
        '
        'colWeight
        '
        Me.colWeight.HeaderText = "Weight"
        Me.colWeight.Name = "colWeight"
        Me.colWeight.ReadOnly = True
        '
        'recipeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(804, 451)
        Me.Controls.Add(Me.s)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TotalDataLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "recipeForm"
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.s, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnDeleteRaw As Button
    Friend WithEvents btnEditRaw As Button
    Friend WithEvents btnAddRaw As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSave As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TotalDataLabel As Label
    Friend WithEvents SearchBox As TextBox
    Friend WithEvents txtRawWeight As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtFoodId As TextBox
    Friend WithEvents txtFoodUnit As TextBox
    Friend WithEvents txtFoodDesc As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnDeleteFood As Button
    Friend WithEvents btnEditFood As Button
    Friend WithEvents btnAddFood As Button
    Friend WithEvents cbRawName As ComboBox
    Friend WithEvents cbFoodName As ComboBox
    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents s As DataGridView
    Friend WithEvents colNo As DataGridViewTextBoxColumn
    Friend WithEvents colRecipeId As DataGridViewTextBoxColumn
    Friend WithEvents colId As DataGridViewTextBoxColumn
    Friend WithEvents colOutput As DataGridViewTextBoxColumn
    Friend WithEvents colDesc As DataGridViewTextBoxColumn
    Friend WithEvents colDate As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents colRecipeIdRaw As DataGridViewTextBoxColumn
    Friend WithEvents colRawId As DataGridViewTextBoxColumn
    Friend WithEvents colWeight As DataGridViewTextBoxColumn
End Class
