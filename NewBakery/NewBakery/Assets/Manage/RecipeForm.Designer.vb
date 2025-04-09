<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecipeForm
    Inherits NewBakery.TemplateForm

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
        Me.TableDataRecipe = New System.Windows.Forms.TableLayoutPanel()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtIdRecipe = New System.Windows.Forms.TextBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.cbFoodName = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SearchBox = New System.Windows.Forms.TextBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.dgvHeader = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableButtonUpRecipe = New System.Windows.Forms.TableLayoutPanel()
        Me.btnDeleteRecipe = New System.Windows.Forms.Button()
        Me.btnEditRecipe = New System.Windows.Forms.Button()
        Me.btnAddRecipe = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.TableButtonDown = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.labelTotalData = New System.Windows.Forms.Label()
        Me.dgvDetail = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TableDataRawMaterial = New System.Windows.Forms.TableLayoutPanel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.cbIdRawMaterial = New System.Windows.Forms.ComboBox()
        Me.TableButtonUpRawMaterial = New System.Windows.Forms.TableLayoutPanel()
        Me.btnDeleteRawMaterial = New System.Windows.Forms.Button()
        Me.btnEditRawMaterial = New System.Windows.Forms.Button()
        Me.btnAddRawMaterial = New System.Windows.Forms.Button()
        Me.colShowDetail = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colNo = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colRecipeId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOutput = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCreatedDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInputedDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNoDetail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRecipeIdDetail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRawMaterialId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRawMaterialName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableDataRecipe.SuspendLayout()
        CType(Me.dgvHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableButtonUpRecipe.SuspendLayout()
        Me.TableButtonDown.SuspendLayout()
        CType(Me.dgvDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableDataRawMaterial.SuspendLayout()
        Me.TableButtonUpRawMaterial.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableDataRecipe
        '
        Me.TableDataRecipe.ColumnCount = 2
        Me.TableDataRecipe.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.25243!))
        Me.TableDataRecipe.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.74757!))
        Me.TableDataRecipe.Controls.Add(Me.txtOutput, 1, 2)
        Me.TableDataRecipe.Controls.Add(Me.Label6, 0, 1)
        Me.TableDataRecipe.Controls.Add(Me.Label4, 0, 0)
        Me.TableDataRecipe.Controls.Add(Me.txtIdRecipe, 1, 0)
        Me.TableDataRecipe.Controls.Add(Me.txtDesc, 1, 3)
        Me.TableDataRecipe.Controls.Add(Me.cbFoodName, 1, 1)
        Me.TableDataRecipe.Controls.Add(Me.Label5, 0, 2)
        Me.TableDataRecipe.Controls.Add(Me.Label8, 0, 3)
        Me.TableDataRecipe.Location = New System.Drawing.Point(468, 78)
        Me.TableDataRecipe.Name = "TableDataRecipe"
        Me.TableDataRecipe.RowCount = 4
        Me.TableDataRecipe.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableDataRecipe.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableDataRecipe.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableDataRecipe.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableDataRecipe.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableDataRecipe.Size = New System.Drawing.Size(334, 115)
        Me.TableDataRecipe.TabIndex = 24
        '
        'txtOutput
        '
        Me.txtOutput.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOutput.Location = New System.Drawing.Point(114, 60)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(217, 20)
        Me.txtOutput.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Food Name"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Recipe Id"
        '
        'txtIdRecipe
        '
        Me.txtIdRecipe.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIdRecipe.Location = New System.Drawing.Point(114, 4)
        Me.txtIdRecipe.Name = "txtIdRecipe"
        Me.txtIdRecipe.ReadOnly = True
        Me.txtIdRecipe.Size = New System.Drawing.Size(217, 20)
        Me.txtIdRecipe.TabIndex = 5
        '
        'txtDesc
        '
        Me.txtDesc.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDesc.Location = New System.Drawing.Point(114, 89)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(217, 20)
        Me.txtDesc.TabIndex = 9
        '
        'cbFoodName
        '
        Me.cbFoodName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbFoodName.FormattingEnabled = True
        Me.cbFoodName.Location = New System.Drawing.Point(114, 31)
        Me.cbFoodName.Name = "cbFoodName"
        Me.cbFoodName.Size = New System.Drawing.Size(217, 21)
        Me.cbFoodName.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Output (Unit Price)"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Description"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(315, 26)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Esemka Bakery : Food Form"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Search"
        '
        'SearchBox
        '
        Me.SearchBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchBox.Location = New System.Drawing.Point(70, 7)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(203, 20)
        Me.SearchBox.TabIndex = 1
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRefresh.Location = New System.Drawing.Point(286, 5)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 2
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'dgvHeader
        '
        Me.dgvHeader.AllowUserToAddRows = False
        Me.dgvHeader.AllowUserToDeleteRows = False
        Me.dgvHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHeader.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colShowDetail, Me.colNo, Me.colRecipeId, Me.colName, Me.colDesc, Me.colOutput, Me.colCreatedDate, Me.colInputedDate, Me.colStatus})
        Me.dgvHeader.Location = New System.Drawing.Point(12, 91)
        Me.dgvHeader.Name = "dgvHeader"
        Me.dgvHeader.ReadOnly = True
        Me.dgvHeader.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvHeader.Size = New System.Drawing.Size(440, 139)
        Me.dgvHeader.TabIndex = 22
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.11765!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.45161!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.53763!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.SearchBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnRefresh, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 38)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(372, 34)
        Me.TableLayoutPanel1.TabIndex = 21
        '
        'TableButtonUpRecipe
        '
        Me.TableButtonUpRecipe.ColumnCount = 3
        Me.TableButtonUpRecipe.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableButtonUpRecipe.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableButtonUpRecipe.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableButtonUpRecipe.Controls.Add(Me.btnDeleteRecipe, 2, 0)
        Me.TableButtonUpRecipe.Controls.Add(Me.btnEditRecipe, 1, 0)
        Me.TableButtonUpRecipe.Controls.Add(Me.btnAddRecipe, 0, 0)
        Me.TableButtonUpRecipe.Location = New System.Drawing.Point(468, 199)
        Me.TableButtonUpRecipe.Name = "TableButtonUpRecipe"
        Me.TableButtonUpRecipe.RowCount = 1
        Me.TableButtonUpRecipe.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableButtonUpRecipe.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableButtonUpRecipe.Size = New System.Drawing.Size(334, 31)
        Me.TableButtonUpRecipe.TabIndex = 25
        '
        'btnDeleteRecipe
        '
        Me.btnDeleteRecipe.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDeleteRecipe.Location = New System.Drawing.Point(240, 4)
        Me.btnDeleteRecipe.Name = "btnDeleteRecipe"
        Me.btnDeleteRecipe.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteRecipe.TabIndex = 2
        Me.btnDeleteRecipe.Text = "Delete"
        Me.btnDeleteRecipe.UseVisualStyleBackColor = True
        '
        'btnEditRecipe
        '
        Me.btnEditRecipe.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEditRecipe.Location = New System.Drawing.Point(129, 4)
        Me.btnEditRecipe.Name = "btnEditRecipe"
        Me.btnEditRecipe.Size = New System.Drawing.Size(75, 23)
        Me.btnEditRecipe.TabIndex = 1
        Me.btnEditRecipe.Text = "Edit"
        Me.btnEditRecipe.UseVisualStyleBackColor = True
        '
        'btnAddRecipe
        '
        Me.btnAddRecipe.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddRecipe.Location = New System.Drawing.Point(18, 4)
        Me.btnAddRecipe.Name = "btnAddRecipe"
        Me.btnAddRecipe.Size = New System.Drawing.Size(75, 23)
        Me.btnAddRecipe.TabIndex = 0
        Me.btnAddRecipe.Text = "Add"
        Me.btnAddRecipe.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancel.Location = New System.Drawing.Point(197, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'TableButtonDown
        '
        Me.TableButtonDown.ColumnCount = 2
        Me.TableButtonDown.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableButtonDown.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableButtonDown.Controls.Add(Me.btnCancel, 1, 0)
        Me.TableButtonDown.Controls.Add(Me.btnSave, 0, 0)
        Me.TableButtonDown.Enabled = False
        Me.TableButtonDown.Location = New System.Drawing.Point(480, 381)
        Me.TableButtonDown.Name = "TableButtonDown"
        Me.TableButtonDown.RowCount = 1
        Me.TableButtonDown.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableButtonDown.Size = New System.Drawing.Size(313, 31)
        Me.TableButtonDown.TabIndex = 26
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSave.Location = New System.Drawing.Point(40, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'labelTotalData
        '
        Me.labelTotalData.AutoSize = True
        Me.labelTotalData.Location = New System.Drawing.Point(12, 399)
        Me.labelTotalData.Name = "labelTotalData"
        Me.labelTotalData.Size = New System.Drawing.Size(72, 13)
        Me.labelTotalData.TabIndex = 23
        Me.labelTotalData.Text = "Total Data : 0"
        '
        'dgvDetail
        '
        Me.dgvDetail.AllowUserToAddRows = False
        Me.dgvDetail.AllowUserToDeleteRows = False
        Me.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNoDetail, Me.colRecipeIdDetail, Me.colRawMaterialId, Me.colRawMaterialName})
        Me.dgvDetail.Enabled = False
        Me.dgvDetail.Location = New System.Drawing.Point(12, 249)
        Me.dgvDetail.Name = "dgvDetail"
        Me.dgvDetail.ReadOnly = True
        Me.dgvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetail.Size = New System.Drawing.Size(440, 139)
        Me.dgvDetail.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Recipe Header"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 233)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Recipe Detail"
        '
        'TableDataRawMaterial
        '
        Me.TableDataRawMaterial.ColumnCount = 2
        Me.TableDataRawMaterial.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.25243!))
        Me.TableDataRawMaterial.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.74757!))
        Me.TableDataRawMaterial.Controls.Add(Me.Label10, 0, 1)
        Me.TableDataRawMaterial.Controls.Add(Me.Label11, 0, 0)
        Me.TableDataRawMaterial.Controls.Add(Me.txtWeight, 1, 1)
        Me.TableDataRawMaterial.Controls.Add(Me.cbIdRawMaterial, 1, 0)
        Me.TableDataRawMaterial.Location = New System.Drawing.Point(468, 249)
        Me.TableDataRawMaterial.Name = "TableDataRawMaterial"
        Me.TableDataRawMaterial.RowCount = 2
        Me.TableDataRawMaterial.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableDataRawMaterial.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableDataRawMaterial.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableDataRawMaterial.Size = New System.Drawing.Size(334, 62)
        Me.TableDataRawMaterial.TabIndex = 30
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Weight in Grams"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Raw Material Id"
        '
        'txtWeight
        '
        Me.txtWeight.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtWeight.Location = New System.Drawing.Point(114, 36)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(217, 20)
        Me.txtWeight.TabIndex = 5
        '
        'cbIdRawMaterial
        '
        Me.cbIdRawMaterial.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbIdRawMaterial.FormattingEnabled = True
        Me.cbIdRawMaterial.Location = New System.Drawing.Point(114, 5)
        Me.cbIdRawMaterial.Name = "cbIdRawMaterial"
        Me.cbIdRawMaterial.Size = New System.Drawing.Size(217, 21)
        Me.cbIdRawMaterial.TabIndex = 10
        '
        'TableButtonUpRawMaterial
        '
        Me.TableButtonUpRawMaterial.ColumnCount = 3
        Me.TableButtonUpRawMaterial.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableButtonUpRawMaterial.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableButtonUpRawMaterial.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableButtonUpRawMaterial.Controls.Add(Me.btnDeleteRawMaterial, 2, 0)
        Me.TableButtonUpRawMaterial.Controls.Add(Me.btnEditRawMaterial, 1, 0)
        Me.TableButtonUpRawMaterial.Controls.Add(Me.btnAddRawMaterial, 0, 0)
        Me.TableButtonUpRawMaterial.Location = New System.Drawing.Point(468, 317)
        Me.TableButtonUpRawMaterial.Name = "TableButtonUpRawMaterial"
        Me.TableButtonUpRawMaterial.RowCount = 1
        Me.TableButtonUpRawMaterial.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableButtonUpRawMaterial.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableButtonUpRawMaterial.Size = New System.Drawing.Size(334, 31)
        Me.TableButtonUpRawMaterial.TabIndex = 31
        '
        'btnDeleteRawMaterial
        '
        Me.btnDeleteRawMaterial.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDeleteRawMaterial.Location = New System.Drawing.Point(240, 4)
        Me.btnDeleteRawMaterial.Name = "btnDeleteRawMaterial"
        Me.btnDeleteRawMaterial.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteRawMaterial.TabIndex = 2
        Me.btnDeleteRawMaterial.Text = "Delete"
        Me.btnDeleteRawMaterial.UseVisualStyleBackColor = True
        '
        'btnEditRawMaterial
        '
        Me.btnEditRawMaterial.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEditRawMaterial.Location = New System.Drawing.Point(129, 4)
        Me.btnEditRawMaterial.Name = "btnEditRawMaterial"
        Me.btnEditRawMaterial.Size = New System.Drawing.Size(75, 23)
        Me.btnEditRawMaterial.TabIndex = 1
        Me.btnEditRawMaterial.Text = "Edit"
        Me.btnEditRawMaterial.UseVisualStyleBackColor = True
        '
        'btnAddRawMaterial
        '
        Me.btnAddRawMaterial.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddRawMaterial.Location = New System.Drawing.Point(18, 4)
        Me.btnAddRawMaterial.Name = "btnAddRawMaterial"
        Me.btnAddRawMaterial.Size = New System.Drawing.Size(75, 23)
        Me.btnAddRawMaterial.TabIndex = 0
        Me.btnAddRawMaterial.Text = "Add"
        Me.btnAddRawMaterial.UseVisualStyleBackColor = True
        '
        'colShowDetail
        '
        Me.colShowDetail.HeaderText = "Show Detail"
        Me.colShowDetail.Name = "colShowDetail"
        Me.colShowDetail.ReadOnly = True
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
        'colName
        '
        Me.colName.HeaderText = "Food Name"
        Me.colName.Name = "colName"
        Me.colName.ReadOnly = True
        '
        'colDesc
        '
        Me.colDesc.HeaderText = "Description"
        Me.colDesc.Name = "colDesc"
        Me.colDesc.ReadOnly = True
        '
        'colOutput
        '
        Me.colOutput.HeaderText = "Output Unit (Piece)"
        Me.colOutput.Name = "colOutput"
        Me.colOutput.ReadOnly = True
        '
        'colCreatedDate
        '
        Me.colCreatedDate.HeaderText = "Created Date"
        Me.colCreatedDate.Name = "colCreatedDate"
        Me.colCreatedDate.ReadOnly = True
        '
        'colInputedDate
        '
        Me.colInputedDate.HeaderText = "Inputed Date"
        Me.colInputedDate.Name = "colInputedDate"
        Me.colInputedDate.ReadOnly = True
        '
        'colStatus
        '
        Me.colStatus.HeaderText = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.ReadOnly = True
        '
        'colNoDetail
        '
        Me.colNoDetail.HeaderText = "No"
        Me.colNoDetail.Name = "colNoDetail"
        Me.colNoDetail.ReadOnly = True
        '
        'colRecipeIdDetail
        '
        Me.colRecipeIdDetail.HeaderText = "Recipe Id"
        Me.colRecipeIdDetail.Name = "colRecipeIdDetail"
        Me.colRecipeIdDetail.ReadOnly = True
        '
        'colRawMaterialId
        '
        Me.colRawMaterialId.HeaderText = "Raw Material Id"
        Me.colRawMaterialId.Name = "colRawMaterialId"
        Me.colRawMaterialId.ReadOnly = True
        '
        'colRawMaterialName
        '
        Me.colRawMaterialName.HeaderText = "Raw Material Name"
        Me.colRawMaterialName.Name = "colRawMaterialName"
        Me.colRawMaterialName.ReadOnly = True
        '
        'RecipeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(814, 421)
        Me.Controls.Add(Me.TableButtonUpRawMaterial)
        Me.Controls.Add(Me.TableDataRawMaterial)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgvDetail)
        Me.Controls.Add(Me.TableDataRecipe)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvHeader)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.TableButtonUpRecipe)
        Me.Controls.Add(Me.TableButtonDown)
        Me.Controls.Add(Me.labelTotalData)
        Me.Name = "RecipeForm"
        Me.TableDataRecipe.ResumeLayout(False)
        Me.TableDataRecipe.PerformLayout()
        CType(Me.dgvHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableButtonUpRecipe.ResumeLayout(False)
        Me.TableButtonDown.ResumeLayout(False)
        CType(Me.dgvDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableDataRawMaterial.ResumeLayout(False)
        Me.TableDataRawMaterial.PerformLayout()
        Me.TableButtonUpRawMaterial.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableDataRecipe As TableLayoutPanel
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtIdRecipe As TextBox
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SearchBox As TextBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents dgvHeader As DataGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableButtonUpRecipe As TableLayoutPanel
    Friend WithEvents btnDeleteRecipe As Button
    Friend WithEvents btnEditRecipe As Button
    Friend WithEvents btnAddRecipe As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents TableButtonDown As TableLayoutPanel
    Friend WithEvents btnSave As Button
    Friend WithEvents labelTotalData As Label
    Friend WithEvents cbFoodName As ComboBox
    Friend WithEvents dgvDetail As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TableDataRawMaterial As TableLayoutPanel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents cbIdRawMaterial As ComboBox
    Friend WithEvents TableButtonUpRawMaterial As TableLayoutPanel
    Friend WithEvents btnDeleteRawMaterial As Button
    Friend WithEvents btnEditRawMaterial As Button
    Friend WithEvents btnAddRawMaterial As Button
    Friend WithEvents colShowDetail As DataGridViewButtonColumn
    Friend WithEvents colNo As DataGridViewButtonColumn
    Friend WithEvents colRecipeId As DataGridViewTextBoxColumn
    Friend WithEvents colName As DataGridViewTextBoxColumn
    Friend WithEvents colDesc As DataGridViewTextBoxColumn
    Friend WithEvents colOutput As DataGridViewTextBoxColumn
    Friend WithEvents colCreatedDate As DataGridViewTextBoxColumn
    Friend WithEvents colInputedDate As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents colNoDetail As DataGridViewTextBoxColumn
    Friend WithEvents colRecipeIdDetail As DataGridViewTextBoxColumn
    Friend WithEvents colRawMaterialId As DataGridViewTextBoxColumn
    Friend WithEvents colRawMaterialName As DataGridViewTextBoxColumn
End Class
