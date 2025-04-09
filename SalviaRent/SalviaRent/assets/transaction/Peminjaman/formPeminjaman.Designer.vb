<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formPeminjaman
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
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.grupText = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtkaryawan = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtpelanggan = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpKembali = New System.Windows.Forms.DateTimePicker()
        Me.dtpPinjam = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTipe = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.numqty = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtJudul = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.totalprice = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupText.SuspendLayout()
        CType(Me.numqty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(160, 372)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(61, 28)
        Me.btnHapus.TabIndex = 28
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(94, 372)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(60, 28)
        Me.btnTambah.TabIndex = 21
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToDeleteRows = False
        Me.dgv1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv1.Location = New System.Drawing.Point(319, 18)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        Me.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv1.Size = New System.Drawing.Size(437, 384)
        Me.dgv1.TabIndex = 22
        '
        'grupText
        '
        Me.grupText.Controls.Add(Me.Label10)
        Me.grupText.Controls.Add(Me.txtkaryawan)
        Me.grupText.Controls.Add(Me.Label9)
        Me.grupText.Controls.Add(Me.Button2)
        Me.grupText.Controls.Add(Me.txtpelanggan)
        Me.grupText.Controls.Add(Me.Label8)
        Me.grupText.Controls.Add(Me.Label7)
        Me.grupText.Controls.Add(Me.dtpKembali)
        Me.grupText.Controls.Add(Me.dtpPinjam)
        Me.grupText.Controls.Add(Me.Label4)
        Me.grupText.Controls.Add(Me.txtTipe)
        Me.grupText.Controls.Add(Me.Label3)
        Me.grupText.Controls.Add(Me.numqty)
        Me.grupText.Controls.Add(Me.Label2)
        Me.grupText.Controls.Add(Me.txtHarga)
        Me.grupText.Controls.Add(Me.Button1)
        Me.grupText.Controls.Add(Me.Label1)
        Me.grupText.Controls.Add(Me.txtJudul)
        Me.grupText.Location = New System.Drawing.Point(12, 12)
        Me.grupText.Name = "grupText"
        Me.grupText.Size = New System.Drawing.Size(301, 338)
        Me.grupText.TabIndex = 26
        Me.grupText.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 152)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 13)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Nama Karyawan"
        '
        'txtkaryawan
        '
        Me.txtkaryawan.Location = New System.Drawing.Point(98, 149)
        Me.txtkaryawan.Name = "txtkaryawan"
        Me.txtkaryawan.ReadOnly = True
        Me.txtkaryawan.Size = New System.Drawing.Size(197, 20)
        Me.txtkaryawan.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 126)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Nama Pelanggan"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(250, 121)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(45, 23)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtpelanggan
        '
        Me.txtpelanggan.Location = New System.Drawing.Point(98, 123)
        Me.txtpelanggan.Name = "txtpelanggan"
        Me.txtpelanggan.ReadOnly = True
        Me.txtpelanggan.Size = New System.Drawing.Size(147, 20)
        Me.txtpelanggan.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 205)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Tanggal Kembali"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 179)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Tanggal Pinjam"
        '
        'dtpKembali
        '
        Me.dtpKembali.Location = New System.Drawing.Point(98, 201)
        Me.dtpKembali.Name = "dtpKembali"
        Me.dtpKembali.Size = New System.Drawing.Size(198, 20)
        Me.dtpKembali.TabIndex = 22
        '
        'dtpPinjam
        '
        Me.dtpPinjam.Location = New System.Drawing.Point(98, 175)
        Me.dtpPinjam.Name = "dtpPinjam"
        Me.dtpPinjam.Size = New System.Drawing.Size(198, 20)
        Me.dtpPinjam.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Tipe"
        '
        'txtTipe
        '
        Me.txtTipe.Location = New System.Drawing.Point(98, 45)
        Me.txtTipe.Name = "txtTipe"
        Me.txtTipe.ReadOnly = True
        Me.txtTipe.Size = New System.Drawing.Size(198, 20)
        Me.txtTipe.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Qty"
        '
        'numqty
        '
        Me.numqty.Location = New System.Drawing.Point(98, 71)
        Me.numqty.Name = "numqty"
        Me.numqty.Size = New System.Drawing.Size(198, 20)
        Me.numqty.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Harga"
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(98, 97)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.ReadOnly = True
        Me.txtHarga.Size = New System.Drawing.Size(198, 20)
        Me.txtHarga.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(251, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(45, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Judul"
        '
        'txtJudul
        '
        Me.txtJudul.Location = New System.Drawing.Point(98, 19)
        Me.txtJudul.Name = "txtJudul"
        Me.txtJudul.ReadOnly = True
        Me.txtJudul.Size = New System.Drawing.Size(147, 20)
        Me.txtJudul.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(316, 405)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Total"
        '
        'totalprice
        '
        Me.totalprice.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.totalprice.AutoSize = True
        Me.totalprice.Location = New System.Drawing.Point(362, 405)
        Me.totalprice.Name = "totalprice"
        Me.totalprice.Size = New System.Drawing.Size(13, 13)
        Me.totalprice.TabIndex = 30
        Me.totalprice.Text = "0"
        '
        'btnSubmit
        '
        Me.btnSubmit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSubmit.Location = New System.Drawing.Point(681, 408)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 24)
        Me.btnSubmit.TabIndex = 31
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'formPeminjaman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 441)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.totalprice)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.grupText)
        Me.MinimumSize = New System.Drawing.Size(784, 480)
        Me.Name = "formPeminjaman"
        Me.Text = "Transaksi Peminjaman"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupText.ResumeLayout(False)
        Me.grupText.PerformLayout()
        CType(Me.numqty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents grupText As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents numqty As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents totalprice As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTipe As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpKembali As DateTimePicker
    Friend WithEvents dtpPinjam As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents txtpelanggan As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtkaryawan As TextBox
    Friend WithEvents btnSubmit As Button
End Class
