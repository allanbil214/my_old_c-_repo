<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formKaryawan
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
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.gbCari = New System.Windows.Forms.GroupBox()
        Me.gbData = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.cbPosisi = New System.Windows.Forms.ComboBox()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.cbJeniskelamin = New System.Windows.Forms.ComboBox()
        Me.txtNohp = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.cbSandi = New System.Windows.Forms.CheckBox()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCari.SuspendLayout()
        Me.gbData.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(149, 351)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "Batal"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(187, 322)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Hapus"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(106, 322)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Ubah"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(25, 322)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Tambah"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtCari
        '
        Me.txtCari.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCari.Location = New System.Drawing.Point(6, 19)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(410, 20)
        Me.txtCari.TabIndex = 0
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(68, 351)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "Simpan"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToDeleteRows = False
        Me.dgv1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(290, 68)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv1.Size = New System.Drawing.Size(422, 331)
        Me.dgv1.TabIndex = 10
        '
        'gbCari
        '
        Me.gbCari.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbCari.Controls.Add(Me.txtCari)
        Me.gbCari.Location = New System.Drawing.Point(290, 12)
        Me.gbCari.Name = "gbCari"
        Me.gbCari.Size = New System.Drawing.Size(422, 50)
        Me.gbCari.TabIndex = 9
        Me.gbCari.TabStop = False
        Me.gbCari.Text = "Pencarian"
        '
        'gbData
        '
        Me.gbData.Controls.Add(Me.cbSandi)
        Me.gbData.Controls.Add(Me.Label8)
        Me.gbData.Controls.Add(Me.Label7)
        Me.gbData.Controls.Add(Me.Label6)
        Me.gbData.Controls.Add(Me.Label5)
        Me.gbData.Controls.Add(Me.Label4)
        Me.gbData.Controls.Add(Me.Label3)
        Me.gbData.Controls.Add(Me.Label2)
        Me.gbData.Controls.Add(Me.Label1)
        Me.gbData.Controls.Add(Me.txtPass)
        Me.gbData.Controls.Add(Me.txtUser)
        Me.gbData.Controls.Add(Me.cbPosisi)
        Me.gbData.Controls.Add(Me.txtAlamat)
        Me.gbData.Controls.Add(Me.cbJeniskelamin)
        Me.gbData.Controls.Add(Me.txtNohp)
        Me.gbData.Controls.Add(Me.txtEmail)
        Me.gbData.Controls.Add(Me.txtNama)
        Me.gbData.Enabled = False
        Me.gbData.Location = New System.Drawing.Point(12, 12)
        Me.gbData.Name = "gbData"
        Me.gbData.Size = New System.Drawing.Size(272, 304)
        Me.gbData.TabIndex = 8
        Me.gbData.TabStop = False
        Me.gbData.Text = "Master Data"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 241)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Password"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Username"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Posisi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Jenis Kelamin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Alamat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "NoHP"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nama"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(119, 238)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(147, 20)
        Me.txtPass.TabIndex = 7
        Me.txtPass.UseSystemPasswordChar = True
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(119, 212)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(147, 20)
        Me.txtUser.TabIndex = 6
        '
        'cbPosisi
        '
        Me.cbPosisi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPosisi.FormattingEnabled = True
        Me.cbPosisi.Location = New System.Drawing.Point(119, 185)
        Me.cbPosisi.Name = "cbPosisi"
        Me.cbPosisi.Size = New System.Drawing.Size(147, 21)
        Me.cbPosisi.TabIndex = 5
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(119, 124)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(147, 55)
        Me.txtAlamat.TabIndex = 4
        '
        'cbJeniskelamin
        '
        Me.cbJeniskelamin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbJeniskelamin.FormattingEnabled = True
        Me.cbJeniskelamin.Location = New System.Drawing.Point(119, 97)
        Me.cbJeniskelamin.Name = "cbJeniskelamin"
        Me.cbJeniskelamin.Size = New System.Drawing.Size(147, 21)
        Me.cbJeniskelamin.TabIndex = 3
        '
        'txtNohp
        '
        Me.txtNohp.Location = New System.Drawing.Point(119, 71)
        Me.txtNohp.Name = "txtNohp"
        Me.txtNohp.Size = New System.Drawing.Size(147, 20)
        Me.txtNohp.TabIndex = 2
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(119, 45)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(147, 20)
        Me.txtEmail.TabIndex = 1
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(119, 19)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(147, 20)
        Me.txtNama.TabIndex = 0
        '
        'cbSandi
        '
        Me.cbSandi.AutoSize = True
        Me.cbSandi.Location = New System.Drawing.Point(119, 264)
        Me.cbSandi.Name = "cbSandi"
        Me.cbSandi.Size = New System.Drawing.Size(109, 17)
        Me.cbSandi.TabIndex = 16
        Me.cbSandi.Text = "Perlihatkan Sandi"
        Me.cbSandi.UseVisualStyleBackColor = True
        '
        'formKaryawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 411)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.gbCari)
        Me.Controls.Add(Me.gbData)
        Me.MinimumSize = New System.Drawing.Size(740, 450)
        Me.Name = "formKaryawan"
        Me.Text = "formKaryawan"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCari.ResumeLayout(False)
        Me.gbCari.PerformLayout()
        Me.gbData.ResumeLayout(False)
        Me.gbData.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button5 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtCari As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents gbCari As GroupBox
    Friend WithEvents gbData As GroupBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents cbPosisi As ComboBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents cbJeniskelamin As ComboBox
    Friend WithEvents txtNohp As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbSandi As CheckBox
End Class
