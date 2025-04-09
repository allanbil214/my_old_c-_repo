<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formDrugs
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
        Me.Button4 = New System.Windows.Forms.Button()
        Me.gbData = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUsage = New System.Windows.Forms.TextBox()
        Me.numStock = New System.Windows.Forms.NumericUpDown()
        Me.numPrice = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.gbSearch = New System.Windows.Forms.GroupBox()
        Me.searchTXT = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.dtpExpire = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbData.SuspendLayout()
        CType(Me.numStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSearch.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Location = New System.Drawing.Point(88, 357)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(77, 26)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "Save"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'gbData
        '
        Me.gbData.Controls.Add(Me.Label2)
        Me.gbData.Controls.Add(Me.dtpExpire)
        Me.gbData.Controls.Add(Me.Label5)
        Me.gbData.Controls.Add(Me.Label4)
        Me.gbData.Controls.Add(Me.Label3)
        Me.gbData.Controls.Add(Me.txtUsage)
        Me.gbData.Controls.Add(Me.numStock)
        Me.gbData.Controls.Add(Me.numPrice)
        Me.gbData.Controls.Add(Me.Label1)
        Me.gbData.Controls.Add(Me.txtName)
        Me.gbData.Enabled = False
        Me.gbData.Location = New System.Drawing.Point(12, 12)
        Me.gbData.Name = "gbData"
        Me.gbData.Size = New System.Drawing.Size(332, 290)
        Me.gbData.TabIndex = 16
        Me.gbData.TabStop = False
        Me.gbData.Text = "Master"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Usage"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Stock"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Price"
        '
        'txtUsage
        '
        Me.txtUsage.Location = New System.Drawing.Point(119, 97)
        Me.txtUsage.Multiline = True
        Me.txtUsage.Name = "txtUsage"
        Me.txtUsage.Size = New System.Drawing.Size(207, 71)
        Me.txtUsage.TabIndex = 5
        '
        'numStock
        '
        Me.numStock.Location = New System.Drawing.Point(119, 71)
        Me.numStock.Name = "numStock"
        Me.numStock.Size = New System.Drawing.Size(207, 20)
        Me.numStock.TabIndex = 4
        Me.numStock.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'numPrice
        '
        Me.numPrice.Increment = New Decimal(New Integer() {500, 0, 0, 0})
        Me.numPrice.Location = New System.Drawing.Point(119, 45)
        Me.numPrice.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.numPrice.Name = "numPrice"
        Me.numPrice.Size = New System.Drawing.Size(207, 20)
        Me.numPrice.TabIndex = 3
        Me.numPrice.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(119, 19)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(207, 20)
        Me.txtName.TabIndex = 0
        '
        'gbSearch
        '
        Me.gbSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbSearch.Controls.Add(Me.searchTXT)
        Me.gbSearch.Location = New System.Drawing.Point(350, 12)
        Me.gbSearch.Name = "gbSearch"
        Me.gbSearch.Size = New System.Drawing.Size(462, 52)
        Me.gbSearch.TabIndex = 17
        Me.gbSearch.TabStop = False
        Me.gbSearch.Text = "Search"
        '
        'searchTXT
        '
        Me.searchTXT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.searchTXT.Location = New System.Drawing.Point(6, 19)
        Me.searchTXT.Name = "searchTXT"
        Me.searchTXT.Size = New System.Drawing.Size(450, 20)
        Me.searchTXT.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(212, 328)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(77, 26)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(131, 328)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 26)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(50, 328)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 26)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Insert"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Enabled = False
        Me.Button5.Location = New System.Drawing.Point(169, 357)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(77, 26)
        Me.Button5.TabIndex = 23
        Me.Button5.Text = "Cancel"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToDeleteRows = False
        Me.dgv1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(350, 70)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv1.Size = New System.Drawing.Size(462, 359)
        Me.dgv1.TabIndex = 18
        '
        'dtpExpire
        '
        Me.dtpExpire.Location = New System.Drawing.Point(119, 174)
        Me.dtpExpire.Name = "dtpExpire"
        Me.dtpExpire.Size = New System.Drawing.Size(207, 20)
        Me.dtpExpire.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Expire Date"
        '
        'formDrugs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 441)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.gbData)
        Me.Controls.Add(Me.gbSearch)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.dgv1)
        Me.MinimumSize = New System.Drawing.Size(840, 480)
        Me.Name = "formDrugs"
        Me.Text = "formDrugs"
        Me.gbData.ResumeLayout(False)
        Me.gbData.PerformLayout()
        CType(Me.numStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSearch.ResumeLayout(False)
        Me.gbSearch.PerformLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button4 As Button
    Friend WithEvents gbData As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents gbSearch As GroupBox
    Friend WithEvents searchTXT As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUsage As TextBox
    Friend WithEvents numStock As NumericUpDown
    Friend WithEvents numPrice As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpExpire As DateTimePicker
End Class
