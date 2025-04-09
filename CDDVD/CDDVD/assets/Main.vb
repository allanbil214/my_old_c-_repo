Imports System.IO
Imports System.Data.SqlClient
Public Class Form1
    Dim SQL As New Squek
    Public usermasuk As String
    Dim admin As Integer = 0
    Dim realadmin As Integer
    Dim admin2 As Integer = 0
    Dim editadmin As Integer = 0
    Dim totalpinjamm As Integer
    Private Sub Form1_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        Login.Close()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        metuadmin()
        cariadmin()
        loadinfo()
        loadcbkembali12()
        LoadComboTabK()
        loadcb()
        loadcbedit()
        loadcbM()
        loadcaricbm()
        loadcbkasetplus()
        loadpinjamdatafilter()
        loadtotalpinjam()
        'karyawanmetu()
        qTGLKembali.Value = DateTime.Now.AddDays(7)
        qTGLPinjam.Value = DateTime.Now
        lUserPlus.CharacterCasing = CharacterCasing.Upper
        mSandiPlus.CharacterCasing = CharacterCasing.Upper
        lUserEdit.CharacterCasing = CharacterCasing.Upper
        mSandiEdit.CharacterCasing = CharacterCasing.Upper
        Kembali.Show()
        Kembali.Hide()
        metucbkembali22()
    End Sub
    Private Sub loadcbkembali12()
        ComboBox2.Items.Add("No_Pinjam")
        ComboBox2.Items.Add("Judul_Kaset")
        ComboBox2.Items.Add("Nama_Member")
        ComboBox2.Items.Add("Nama_Karyawan")
        ComboBox2.Text = "No_Pinjam"
    End Sub
    Private Sub metuadmin()
        SQL.PlusParam("@nama", ToolStripStatusLabel1.Text)
        SQL.PerintahQuery("select isadmin from staff where Nama_User=@nama")
        For Each r As DataRow In SQL.STabel.Rows
            realadmin = r("isadmin")
        Next
    End Sub
    Public Sub cariadmin()
        If realadmin = "0" Then
            TambahK.Enabled = False
            EditK.Enabled = False
            HapusK.Enabled = False
            TabPage9.Enabled = False
            Stok2.Enabled = False
            qTGLKembali.Enabled = False
            TabPage12.Enabled = False
            qTGLKembali.Enabled = False
            PengaturanToolStripMenuItem.Enabled = False
        ElseIf realadmin = "1" Then
            TambahK.Enabled = True
            EditK.Enabled = True
            HapusK.Enabled = True
            TabPage9.Enabled = True
            Stok2.Enabled = True
            qTGLKembali.Enabled = True
            TabPage12.Enabled = True
            qTGLKembali.Enabled = True
            PengaturanToolStripMenuItem.Enabled = True
        End If
    End Sub
    Public Sub loadinfo()
        SQL.PerintahQuery("select * from identitas")
        For Each r As DataRow In SQL.STabel.Rows
            lblNama.Text = r("toko")
            lblKeps.Text = r("kepala")
            lblAlamat.Text = r("alamat")
            lblNoTelp.Text = r("nohp")
        Next
    End Sub
    Private Sub lurudataK()
        SQL.PerintahQuery("SELECT [Kode_Karyawan],[Nama_Karyawan],[Tempat_Lahir],[Tanggal_Lahir],[Nomor_KTP],[Alamat],[Jenis_Kelamin],[Golongan_Darah],[Agama],[Nomor_Ponsel],[Email],[Nama_User],[Kata_Sandi],[isadmin] FROM [CDDVD].[dbo].[staff] where not Kode_Karyawan='A00000'")
        If SQL.AdaKecuali(True) Then Exit Sub
        dgvK.DataSource = SQL.STabel
        ' For Each r As DataRow In SQL.STabel.Rows
        'TextBox1.Text = r("NIS")
        '  Next
    End Sub
    Private Sub loadcaricbm()
        cbFilterM.Items.Add("Nama_Member")
        cbFilterM.Items.Add("NIK")
        cbFilterM.Items.Add("Email")
        cbFilterM.Items.Add("Nomor_Ponsel")
        cbFilterM.Text = "Nama_Member"
    End Sub
    Private Sub MemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MemberToolStripMenuItem.Click
        MemberLaporan.ShowDialog()
    End Sub
    Private Sub cariK()
        SQL.PlusParam("@id", "%" & txtCariK.Text & "%")
        SQL.PerintahQuery("select [Kode_Karyawan],[Nama_Karyawan],[Tempat_Lahir],[Tanggal_Lahir],[Nomor_KTP],[Alamat],[Jenis_Kelamin],[Golongan_Darah],[Agama],[Nomor_Ponsel],[Email],[Nama_User],[Kata_Sandi],[isadmin] from staff " &
                          "where " & cbFilterK.Text & "like @id" &
                          "order by" & cbFilterK.Text & "asc;")
    End Sub
    Private Sub KaryawanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KaryawanToolStripMenuItem.Click
        KaryawanLaporan.ShowDialog()
    End Sub
    Private Sub LoadComboTabK()
        cbFilterK.Items.Add("Kode_Karyawan")
        cbFilterK.Items.Add("Nama_Karyawan")
        cbFilterK.Items.Add("Nomor_KTP")
        cbFilterK.Items.Add("Nomor_Ponsel")
        cbFilterK.Items.Add("Email")
        cbFilterK.Text = "Nama_Karyawan"
    End Sub
    Private Sub btn1_Click(sender As Object, e As EventArgs)
        cariK()
    End Sub 'rakanggo
    Private Sub dgvK_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvK.CellContentClick
        fetchingdataedit()
        metugambaredit()
        fetchingdatahapus()
        metugambarDel()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label8.Text = Format(Now, "dd/MM/yyyy")
        lblJam.Text = Format(Now, "HH:mm:ss")
    End Sub
    Private Sub cariM()
        SQL.PlusParam("@id", "%" & txtCariM.Text & "%")
        SQL.PerintahQuery("select * from member where " & cbFilterM.Text & " like @id order by " & cbFilterM.Text & " asc")
        dgvM.DataSource = SQL.STabel
    End Sub
    Private Sub btnCariM_Click(sender As Object, e As EventArgs) Handles btnCariM.Click
        cariM()
    End Sub
    'batas kode form /\
    Private Sub loadcb()
        gKelaminPlus.Items.Add("Laki-Laki")
        gKelaminPlus.Items.Add("Perempuan")
        hDarahPlus.Items.Add("A")
        hDarahPlus.Items.Add("B")
        hDarahPlus.Items.Add("O")
        hDarahPlus.Items.Add("AB")
        iAgamaPlus.Items.Add("Islam")
        iAgamaPlus.Items.Add("Kristen")
        iAgamaPlus.Items.Add("Hindu")
        iAgamaPlus.Items.Add("Katholic")
        iAgamaPlus.Items.Add("Buddha")
        iAgamaPlus.Items.Add("Khonghuchu")

    End Sub
    Private Sub btnloadK_Click(sender As Object, e As EventArgs) Handles btnloadK.Click
        lurudataK()
    End Sub
    Private Sub btnCariK_Click(sender As Object, e As EventArgs) Handles btnCariK.Click
        SQL.PlusParam("@klas", "%" & txtCariK.Text & "%")
        SQL.PerintahQuery("SELECT * " &
                   "FROM staff " &
                   "WHERE " & cbFilterK.Text & " LIKE @klas and not Nama_User='ADMIN' " &
                   "ORDER BY " & cbFilterK.Text & " ASC;")
        dgvK.DataSource = SQL.STabel
    End Sub
    Private Sub cbSandiPlus_CheckedChanged(sender As Object, e As EventArgs) Handles cbSandiPlus.CheckedChanged
        If cbSandiPlus.Checked = True Then
            mSandiPlus.UseSystemPasswordChar = False
        ElseIf cbSandiPlus.Checked = False Then
            mSandiPlus.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub btnBaru_Click(sender As Object, e As EventArgs) Handles btnBaru.Click
        Dim duwur As String
        Dim i As Integer
        SQL.PerintahQuery("select coalesce(max(Kode_Karyawan),'0000000') as highest from staff")
        For Each r As DataRow In SQL.STabel.Rows
            duwur = r("highest")
            i = Val(Mid(duwur, 6))
        Next
        Dim m As String = i + 1 + 100000
        aKodePlus.Text = "K" + Mid(m, 2).ToString
    End Sub
    Private Sub btnGambarPlus_Click(sender As Object, e As EventArgs) Handles btnGambarPlus.Click
        Dim fdlg As OpenFileDialog = New OpenFileDialog()
        fdlg.Title = "Pilih Foto"
        fdlg.InitialDirectory = "c:\"
        fdlg.Filter = "Picture Files(*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        fdlg.FilterIndex = 2
        fdlg.RestoreDirectory = True
        If fdlg.ShowDialog() = DialogResult.OK Then
            If File.Exists(fdlg.FileName) = False Then
                MessageBox.Show("Maaf, File yang anda pilih tidak ada.")
            Else
                FotoPlus.ImageLocation = fdlg.FileName
            End If
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            admin = 1
        ElseIf CheckBox1.Checked = False Then
            admin = 0
        End If
    End Sub
    Private Sub insertdata()
        SQL.PlusParam("@kode", aKodePlus.Text)
        SQL.PlusParam("@nama", bNamaPlus.Text)
        SQL.PlusParam("@tempat", cTempatPlus.Text)
        SQL.PlusParam("@date", dTanggalPlus.Text)
        SQL.PlusParam("@ktp", eKTPPlus.Text)
        SQL.PlusParam("@alamat", fAlamatPlus.Text)
        SQL.PlusParam("@kelamin", gKelaminPlus.Text)
        SQL.PlusParam("@darah", hDarahPlus.Text)
        SQL.PlusParam("@agama", iAgamaPlus.Text)
        SQL.PlusParam("@hape", jHPPlus.Text)
        SQL.PlusParam("@email", kEmailPlus.Text)
        SQL.PlusParam("@admin", admin)
        SQL.PlusParam("@user", lUserPlus.Text)
        SQL.PlusParam("@sandi", mSandiPlus.Text)
        SQL.PerintahQuery("insert into staff(isadmin,Kode_Karyawan,Nama_Karyawan,Tempat_Lahir,Tanggal_Lahir,Nomor_KTP,Alamat,Jenis_Kelamin,Golongan_Darah,Agama,Nomor_Ponsel,Email,Nama_User,Kata_Sandi)" &
                          "values(@admin,@kode,@nama,@tempat,@date,@ktp,@alamat,@kelamin,@darah,@agama,@hape,@email,@user,@sandi)")
        If SQL.AdaKecuali(True) Then Exit Sub
        MsgBox("Data telah ditambahkan", vbOKOnly, "Harap Perhatian")
        bNamaPlus.Text = ""
        cTempatPlus.Text = ""
        eKTPPlus.Text = ""
        fAlamatPlus.Text = ""
        gKelaminDel.Text = ""
        hDarahPlus.Text = ""
        iAgamaPlus.Text = ""
        jHPPlus.Text = ""
        kEmailPlus.Text = ""
        lUserPlus.Text = ""
        mSandiPlus.Text = ""
        CheckBox1.Checked = False
        InsertGambar()
    End Sub
    Private Sub InsertGambar()
        SQL.PerintahQuery("update staff set Foto= (select * from openrowset(bulk '" & FotoPlus.ImageLocation & "', single_blob) as x) where Kode_Karyawan='" & aKodePlus.Text & "'")
        If SQL.AdaKecuali(True) Then Exit Sub
        MsgBox("Gambar telah masuk", vbOKOnly, "Harap Perhatian")
        FotoEdit.Image = Nothing
        aKodePlus.Text = ""
    End Sub
    Private Sub btnSimpanPlus_Click(sender As Object, e As EventArgs) Handles btnSimpanPlus.Click
        If FotoPlus.ImageLocation = Nothing Or aKodePlus.Text = "" Or bNamaPlus.Text = "" Or cTempatPlus.Text = "" Or eKTPPlus.Text = "" Or fAlamatPlus.Text = "" Or gKelaminPlus.Text = "" Or hDarahPlus.Text = "" Or iAgamaPlus.Text = "" Or jHPPlus.Text = "" Or kEmailPlus.Text = "" Or lUserPlus.Text = "" Or mSandiPlus.Text = "" Then
            MsgBox("Data ada yang belum diisi")
        Else
            insertdata()
            lurudataK()
            FotoPlus.Image = Nothing
        End If
    End Sub
    'batas kode insert /\
    Private Sub fetchingdataedit()
        Dim i As Integer
        i = dgvK.CurrentRow.Index
        aKodeEdit.Text = dgvK.Item(0, i).Value
        bNamaEdit.Text = dgvK.Item(1, i).Value
        cTempatEdit.Text = dgvK.Item(2, i).Value
        dTanggalEdit.Value = dgvK.Item(3, i).Value
        eKTPEdit.Text = dgvK.Item(4, i).Value
        fAlamatEdit.Text = dgvK.Item(5, i).Value
        gKelaminEdit.Text = dgvK.Item(6, i).Value
        hDarahEdit.Text = dgvK.Item(7, i).Value
        iAgamaEdit.Text = dgvK.Item(8, i).Value
        jHPEdit.Text = dgvK.Item(9, i).Value
        kEmailEdit.Text = dgvK.Item(10, i).Value
        lUserEdit.Text = dgvK.Item(11, i).Value
        mSandiEdit.Text = dgvK.Item(12, i).Value
        editadmin = dgvK.Item(13, i).Value
        If editadmin = "0" Then
            CheckBox2.Checked = False
        ElseIf editadmin = "1" Then
            CheckBox2.Checked = True
        End If
    End Sub
    Private Sub metugambaredit()
        Dim constr As String = "Server=ALLAN\ALLANBIL;Database=CDDVD;Trusted_Connection = True"
        Using conn As SqlConnection = New SqlConnection(constr)
            Using cmd As SqlCommand = New SqlCommand("SELECT Foto FROM staff WHERE Kode_Karyawan = @Id", conn)
                cmd.Parameters.AddWithValue("@Id", aKodeEdit.Text)
                conn.Open()
                Dim bytes As Byte() = CType(cmd.ExecuteScalar(), Byte())
                conn.Close()
                FotoEdit.Image = Image.FromStream(New MemoryStream(bytes))
            End Using
        End Using
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnGambarEdit.Click
        Dim fdlg As OpenFileDialog = New OpenFileDialog()
        fdlg.Title = "Pilih Foto"
        fdlg.InitialDirectory = "C:\"
        fdlg.Filter = "Picture Files(*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        fdlg.FilterIndex = 2
        fdlg.RestoreDirectory = True
        If fdlg.ShowDialog() = DialogResult.OK Then
            If File.Exists(fdlg.FileName) = False Then
                MessageBox.Show("Maaf, File yang anda pilih tidak ada")
            Else
                FotoEdit.ImageLocation = fdlg.FileName
            End If
        End If
    End Sub
    Private Sub cbSandiEdit_CheckedChanged(sender As Object, e As EventArgs) Handles cbSandiEdit.CheckedChanged
        If cbSandiEdit.Checked = True Then
            mSandiEdit.UseSystemPasswordChar = False
        ElseIf cbSandiEdit.Checked = False Then
            mSandiEdit.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            admin2 = 1
        ElseIf CheckBox2.Checked = False Then
            admin2 = 0
        End If
    End Sub
    Private Sub editdata()
        SQL.PlusParam("@kode", aKodeEdit.Text)
        SQL.PlusParam("@nama", bNamaEdit.Text)
        SQL.PlusParam("@tempat", cTempatEdit.Text)
        SQL.PlusParam("@date", dTanggalEdit.Value)
        SQL.PlusParam("@ktp", eKTPEdit.Text)
        SQL.PlusParam("@alamat", fAlamatEdit.Text)
        SQL.PlusParam("@kelamin", gKelaminEdit.Text)
        SQL.PlusParam("@darah", hDarahEdit.Text)
        SQL.PlusParam("@agama", iAgamaEdit.Text)
        SQL.PlusParam("@hape", jHPEdit.Text)
        SQL.PlusParam("@email", kEmailEdit.Text)
        SQL.PlusParam("@user", lUserEdit.Text)
        SQL.PlusParam("@sandi", mSandiEdit.Text)
        SQL.PlusParam("@admin2", admin2)
        SQL.PerintahQuery("update staff " &
                          "set isadmin=@admin2,Nama_Karyawan=@nama,Tempat_Lahir=@tempat,Tanggal_Lahir=@date,Nomor_KTP=@ktp,Alamat=@alamat,Jenis_Kelamin=@kelamin,Golongan_Darah=@darah,Agama=@agama,Nomor_Ponsel=@hape,Email=@email,Nama_User=@user,Kata_Sandi=@sandi " &
                          "where Kode_Karyawan=@kode")
        If SQL.AdaKecuali(True) Then Exit Sub
        bNamaEdit.Text = ""
        cTempatEdit.Text = ""
        eKTPEdit.Text = ""
        fAlamatEdit.Text = ""
        gKelaminDel.Text = ""
        hDarahEdit.Text = ""
        iAgamaEdit.Text = ""
        jHPEdit.Text = ""
        kEmailEdit.Text = ""
        lUserEdit.Text = ""
        CheckBox2.Checked = False
        mSandiEdit.Text = ""
    End Sub
    Private Sub EditGambar()
        SQL.PerintahQuery("update staff set Foto= (select * from openrowset(bulk '" & FotoEdit.ImageLocation & "', single_blob) as x) where Kode_Karyawan='" & aKodeEdit.Text & "'")
        If SQL.AdaKecuali(True) Then Exit Sub
        MsgBox("Gambar telah masuk", vbOKOnly, "Harap Perhatian")
        FotoEdit.Image = Nothing
        aKodeEdit.Text = ""
    End Sub
    Private Sub loadcbedit()
        gKelaminEdit.Items.Add("Laki-Laki")
        gKelaminEdit.Items.Add("Perempuan")
        hDarahEdit.Items.Add("A")
        hDarahEdit.Items.Add("B")
        hDarahEdit.Items.Add("O")
        hDarahEdit.Items.Add("AB")
        iAgamaEdit.Items.Add("Islam")
        iAgamaEdit.Items.Add("Kristen")
        iAgamaEdit.Items.Add("Hindu")
        iAgamaEdit.Items.Add("Katholic")
        iAgamaEdit.Items.Add("Buddha")
        iAgamaEdit.Items.Add("Khonghuchu")
    End Sub
    Private Sub btnSimpanEdit_Click(sender As Object, e As EventArgs) Handles btnSimpanEdit.Click
        If aKodeEdit.Text = "" Or bNamaEdit.Text = "" Or cTempatEdit.Text = "" Or eKTPEdit.Text = "" Or fAlamatEdit.Text = "" Or gKelaminEdit.Text = "" Or hDarahEdit.Text = "" Or iAgamaEdit.Text = "" Or jHPEdit.Text = "" Or kEmailEdit.Text = "" Or lUserEdit.Text = "" Or mSandiEdit.Text = "" Then
            MsgBox("Data ada yang belum diisi")
        Else
            editdata()
            If FotoEdit.ImageLocation = Nothing Then
            Else
                EditGambar()
            End If
            lurudataK()
            MsgBox("Data sudah berhasil dirubah", vbOKOnly, "Selamat")
        End If
    End Sub
    'batas kode edit /\
    Private Sub cbSandiHapus_CheckedChanged(sender As Object, e As EventArgs) Handles cbSandiHapus.CheckedChanged
        If cbSandiHapus.Checked = True Then
            mSandiDel.UseSystemPasswordChar = False
        ElseIf cbSandiHapus.Checked = False Then
            mSandiDel.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub hapusdata()
        SQL.PlusParam("@kode", aKodeDell.Text)
        If MsgBox("Data yg diseleksi akan di hapus!! apakah anda ingin data ini dihapus? ", MsgBoxStyle.YesNo, "menghapus data?") = MsgBoxResult.Yes Then
            SQL.PerintahQuery("delete from staff where Kode_Karyawan='" & aKodeDell.Text & "'")
        End If
        If SQL.AdaKecuali(True) Then Exit Sub
        aKodeDell.Text = ""
        bNamaDel.Text = ""
        cTempatDel.Text = ""
        eKTPDel.Text = ""
        fAlamatDel.Text = ""
        gKelaminDel.Text = ""
        hDarahDel.Text = ""
        iAgamaDel.Text = ""
        jHPDel.Text = ""
        kEmailDel.Text = ""
        lUserDel.Text = ""
        mSandiDel.Text = ""
        FotoDelete.Image = Nothing
        'nganu
        aKodeEdit.Text = ""
        bNamaEdit.Text = ""
        cTempatEdit.Text = ""
        eKTPEdit.Text = ""
        fAlamatEdit.Text = ""
        gKelaminDel.Text = ""
        hDarahEdit.Text = ""
        iAgamaEdit.Text = ""
        jHPEdit.Text = ""
        kEmailEdit.Text = ""
        lUserEdit.Text = ""
        mSandiEdit.Text = ""
        FotoEdit.Image = Nothing
        MsgBox("Data sudah berhasil dihapus", vbOKOnly, "Selamat")
    End Sub
    Private Sub fetchingdatahapus()
        Dim i As Integer
        i = dgvK.CurrentRow.Index
        aKodeDell.Text = dgvK.Item(0, i).Value
        bNamaDel.Text = dgvK.Item(1, i).Value
        cTempatDel.Text = dgvK.Item(2, i).Value
        dTanggalDel.Value = dgvK.Item(3, i).Value
        eKTPDel.Text = dgvK.Item(4, i).Value
        fAlamatDel.Text = dgvK.Item(5, i).Value
        gKelaminDel.Text = dgvK.Item(6, i).Value
        hDarahDel.Text = dgvK.Item(7, i).Value
        iAgamaDel.Text = dgvK.Item(8, i).Value
        jHPDel.Text = dgvK.Item(9, i).Value
        kEmailDel.Text = dgvK.Item(10, i).Value
        lUserDel.Text = dgvK.Item(11, i).Value
        mSandiDel.Text = dgvK.Item(12, i).Value
    End Sub
    Private Sub metugambarDel()
        Dim constr As String = "Server=ALLAN\ALLANBIL;Database=CDDVD;Trusted_Connection = True"
        Using conn As SqlConnection = New SqlConnection(constr)
            Using cmd As SqlCommand = New SqlCommand("SELECT Foto FROM staff WHERE Kode_Karyawan = @Id", conn)
                cmd.Parameters.AddWithValue("@Id", aKodeDell.Text)
                conn.Open()
                Dim bytes As Byte() = CType(cmd.ExecuteScalar(), Byte())
                conn.Close()
                FotoDelete.Image = Image.FromStream(New MemoryStream(bytes))
            End Using
        End Using
    End Sub
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        hapusdata()
        lurudataK()

    End Sub
    'batas kode hapus /\
    Private Sub loadcbM()
        dKelaminDel.Items.Add("Laki-Laki")
        dKelaminDel.Items.Add("Perempuan")
        dKelaminPlus.Items.Add("Laki-Laki")
        dKelaminPlus.Items.Add("Perempuan")
        dKelaminEdit.Items.Add("Laki-Laki")
        dKelaminEdit.Items.Add("Perempuan")
        cbFilterDisk.Items.Add("Judul_Kaset")
        cbFilterDisk.Items.Add("Tahun_Rilis")
        cbFilterDisk.Text = "Judul_Kaset"
    End Sub
    Private Sub loaddatagridM()
        SQL.PerintahQuery("select * from member")
        dgvM.DataSource = SQL.STabel
    End Sub
    Private Sub insertdataM()
        SQL.PlusParam("@nama", aNamaPlus.Text)
        SQL.PlusParam("@nik", bNIKPlus.Text)
        SQL.PlusParam("@lahir", zTanggalPlus.Value)
        SQL.PlusParam("@alamat", cAlamatPlus.Text)
        SQL.PlusParam("@kelamin", dKelaminPlus.Text)
        SQL.PlusParam("@ponsel", ePonselPlus.Text)
        SQL.PlusParam("@email", fEmailPlus.Text)
        SQL.PerintahQuery("insert into member(Nama_Member,Tanggal_Lahir,NIK,Alamat,Jenis_Kelamin,Nomor_Ponsel,Email) " &
                          "values(@nama,@lahir,@nik,@alamat,@kelamin,@ponsel,@email) ")
        If SQL.AdaKecuali(True) Then Exit Sub
        '       aNamaPlus.Text = ""
        bNIKPlus.Text = ""
        cAlamatPlus.Text = ""
        dKelaminPlus.Text = ""
        ePonselPlus.Text = ""
        fEmailPlus.Text = ""
        insertgambarM()
    End Sub
    Private Sub insertgambarM()
        SQL.PerintahQuery("update member set Foto= (select * from openrowset(bulk '" & gFotoPlus.ImageLocation & "', single_blob) as x) where Nama_Member='" & aNamaPlus.Text & "'")
        If SQL.AdaKecuali(True) Then Exit Sub
        MsgBox("Gambar telah masuk", vbOKOnly, "Harap Perhatian")
        gFotoPlus.Image = Nothing
        aNamaPlus.Text = ""
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        loaddatagridM()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fdlg As OpenFileDialog = New OpenFileDialog()
        fdlg.Title = "Pilih Foto"
        fdlg.InitialDirectory = "c:\"
        fdlg.Filter = "Picture Files(*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        fdlg.FilterIndex = 2
        fdlg.RestoreDirectory = True
        If fdlg.ShowDialog() = DialogResult.OK Then
            If File.Exists(fdlg.FileName) = False Then
                MessageBox.Show("Maaf, File yang anda pilih tidak ada.")
            Else
                gFotoPlus.ImageLocation = fdlg.FileName
            End If
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If aNamaPlus.Text = "" Or bNIKPlus.Text = "" Or cAlamatPlus.Text = "" Or dKelaminPlus.Text = "" Or ePonselPlus.Text = "" Or fEmailPlus.Text = "" Or gFotoPlus.ImageLocation = Nothing Then
            MsgBox("Data ada yang belum ditentukan", vbCritical, "Peringatan")
        Else
            insertdataM()
        End If
        MsgBox("Data sudah berhasil dimasukan", vbOKOnly, "Selamat")
    End Sub
    'batas kode plus /\
    Private Sub dgvtoEditM()
        Dim i As Integer
        i = dgvM.CurrentRow.Index
        TextBox1.Text = dgvM.Item(0, i).Value
        aNamaEdit.Text = dgvM.Item(1, i).Value
        bNIKEdit.Text = dgvM.Item(3, i).Value
        cAlamatEdit.Text = dgvM.Item(4, i).Value
        dKelaminEdit.Text = dgvM.Item(5, i).Value
        ePonselEdit.Text = dgvM.Item(6, i).Value
        zTanggalEdit.Value = dgvM.Item(2, i).Value
        fEmailEdit.Text = dgvM.Item(7, i).Value
    End Sub
    Private Sub metugambareditM()
        Dim constr As String = "Server=ALLAN\ALLANBIL;Database=CDDVD;Trusted_Connection = True"
        Using conn As SqlConnection = New SqlConnection(constr)
            Using cmd As SqlCommand = New SqlCommand("SELECT Foto FROM member WHERE Nama_Member = @Id", conn)
                cmd.Parameters.AddWithValue("@Id", aNamaEdit.Text)
                conn.Open()
                Dim bytes As Byte() = CType(cmd.ExecuteScalar(), Byte())
                conn.Close()
                gFotoEdit.Image = Image.FromStream(New MemoryStream(bytes))
            End Using
        End Using
    End Sub
    Private Sub dgvM_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvM.CellContentClick
        dgvtoEditM()
        metugambareditM()
        metugambardelM()
        dgvtoDelM()
    End Sub
    Private Sub updatedataM()
        SQL.PlusParam("@id", TextBox1.Text)
        SQL.PlusParam("@nama", aNamaEdit.Text)
        SQL.PlusParam("@nik", bNIKEdit.Text)
        SQL.PlusParam("@lahir", zTanggalEdit.Value)
        SQL.PlusParam("@alamat", cAlamatEdit.Text)
        SQL.PlusParam("@kelamin", dKelaminEdit.Text)
        SQL.PlusParam("@ponsel", ePonselEdit.Text)
        SQL.PlusParam("@email", fEmailEdit.Text)
        SQL.PerintahQuery("update member " &
                          "set Nama_Member=@nama,NIK=@nik,Tanggal_Lahir=@lahir,Alamat=@alamat,Jenis_Kelamin=@kelamin,Nomor_Ponsel=@ponsel,Email=@email " &
                          "where ID_Member=@id")
        If SQL.AdaKecuali(True) Then Exit Sub

        aNamaEdit.Text = ""
        bNIKEdit.Text = ""
        cAlamatEdit.Text = ""
        dKelaminEdit.Text = ""
        ePonselEdit.Text = ""
        fEmailEdit.Text = ""
    End Sub
    Private Sub editgambar22()
        SQL.PerintahQuery("update member set Foto= (select * from openrowset(bulk '" & gFotoEdit.ImageLocation & "', single_blob) as x) where ID_Member='" & TextBox1.Text & "'")
        If SQL.AdaKecuali(True) Then Exit Sub
        MsgBox("Gambar telah masuk", vbOKOnly, "Harap Perhatian")
        gFotoEdit.Image = Nothing
        TextBox1.Text = ""
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If aNamaEdit.Text = "" Or bNIKEdit.Text = "" Or cAlamatEdit.Text = "" Or dKelaminEdit.Text = "" Or ePonselEdit.Text = "" Or fEmailEdit.Text = "" Then
            MsgBox("Data ada yang belum ditentukan", vbCritical, "Peringatan")
        Else
            updatedataM()
            editgambar22()

            If gFotoEdit.ImageLocation = Nothing Then
            Else
                editgambar22()
            End If
        End If
        loaddatagridM()
        MsgBox("Data berhasil dirubah", vbOKOnly, "Peringatan")
    End Sub
    'batas kode edit /\
    Private Sub dgvtoDelM()
        Dim i As Integer
        i = dgvM.CurrentRow.Index
        aNamaDel.Text = dgvM.Item(1, i).Value
        bNIKDel.Text = dgvM.Item(3, i).Value
        cAlamatDel.Text = dgvM.Item(4, i).Value
        dKelaminDel.Text = dgvM.Item(5, i).Value
        ePonselDel.Text = dgvM.Item(6, i).Value
        zTanggalDel.Value = dgvM.Item(2, i).Value
        fEmailDel.Text = dgvM.Item(7, i).Value
    End Sub
    Private Sub metugambardelM()
        Dim constr As String = "Server=ALLAN\ALLANBIL;Database=CDDVD;Trusted_Connection = True"
        Using conn As SqlConnection = New SqlConnection(constr)
            Using cmd As SqlCommand = New SqlCommand("SELECT Foto FROM member WHERE Nama_Member = @Id", conn)
                cmd.Parameters.AddWithValue("@Id", aNamaEdit.Text)
                conn.Open()
                Dim bytes As Byte() = CType(cmd.ExecuteScalar(), Byte())
                conn.Close()
                gFotoDel.Image = Image.FromStream(New MemoryStream(bytes))
            End Using
        End Using
    End Sub
    Private Sub deletedataM()
        SQL.PlusParam("@kode", aNamaDel.Text)
        If MsgBox("Data yg diseleksi akan di hapus!! apakah anda ingin data ini dihapus? ", MsgBoxStyle.YesNo, "menghapus data?") = MsgBoxResult.Yes Then
            SQL.PerintahQuery("delete from member where Nama_Member='" & aNamaDel.Text & "'")
        End If
        If SQL.AdaKecuali(True) Then Exit Sub
        TextBox1.Text = ""
        aNamaEdit.Text = ""
        bNIKEdit.Text = ""
        cAlamatEdit.Text = ""
        dKelaminEdit.Text = ""
        ePonselEdit.Text = ""
        fEmailEdit.Text = ""
        aNamaDel.Text = ""
        bNIKDel.Text = ""
        cAlamatDel.Text = ""
        dKelaminDel.Text = ""
        ePonselDel.Text = ""
        fEmailDel.Text = ""
        gFotoEdit.Image = Nothing
        gFotoDel.Image = Nothing
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        deletedataM()
        MsgBox("Data berhasil dihapus", vbOKOnly, "Selamat")
    End Sub
    'batas Member
    Private Sub loaddatakaset()
        SQL.PerintahQuery("select * from kaset")
        dgvDisk.DataSource = SQL.STabel
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        loaddatakaset()
    End Sub
    'batas Form
    Private Sub insertdatakaset()
        SQL.PlusParam("@nama", atxtJudulPlus.Text)
        SQL.PlusParam("@jenis", bCBJenisPlus.Text)
        SQL.PlusParam("@genre", ctxtGenreKasetPlus.Text)
        SQL.PlusParam("@rilis", dTXTTahunPlus.Text)
        SQL.PlusParam("@lisensor", eTXTLisensorPlus.Text)
        SQL.PlusParam("stok", STOKKK.Text)
        SQL.PerintahQuery("insert into kaset(Judul_Kaset,Jenis_Kaset,Genre_Kaset,Tahun_Rilis,Lisensor,Stok) values (@nama,@jenis,@genre,@rilis,@lisensor,@stok)")
        If SQL.AdaKecuali(True) Then Exit Sub
        bCBJenisPlus.Text = ""
        ctxtGenreKasetPlus.Text = ""
        dTXTTahunPlus.Text = ""
        eTXTLisensorPlus.Text = ""
        STOKKK.Text = ""
    End Sub
    Private Sub insertgambarkaset()
        SQL.PlusParam("@id", atxtJudulPlus.Text)
        SQL.PerintahQuery("update kaset Set Gambar= (Select * from openrowset(bulk '" & fGambarPlus.ImageLocation & "', single_blob) as x) where Judul_Kaset=@id")
        If SQL.AdaKecuali(True) Then Exit Sub
        MsgBox("Gambar masuk", vbOKOnly)
        fGambarPlus.Image = Nothing
        atxtJudulPlus.Text = ""
    End Sub
    Private Sub button11_click(sender As Object, e As EventArgs) Handles Button11.Click
        If atxtJudulPlus.Text = "" Or bCBJenisPlus.Text = "" Or ctxtGenreKasetPlus.Text = "" Or dTXTTahunPlus.Text = "" Or eTXTLisensorPlus.Text = "" Or fGambarPlus.ImageLocation = Nothing Then
            MsgBox("Maaf ada data yang belum dimasukkan", vbCritical, "Peringatan")
        Else
            insertdatakaset()
            insertgambarkaset()
            MsgBox("Data telah berhasil ditambahkan", vbOKOnly, "Selamat")
            loaddatakaset()
        End If
    End Sub
    Private Sub btnCariGambarPlus_Click(sender As Object, e As EventArgs) Handles btnCariGambarPlus.Click
        Dim fdlg As OpenFileDialog = New OpenFileDialog()
        fdlg.Title = "Pilih Foto"
        fdlg.InitialDirectory = "c:\"
        fdlg.Filter = "Picture Files(*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        fdlg.FilterIndex = 2
        fdlg.RestoreDirectory = True
        If fdlg.ShowDialog() = DialogResult.OK Then
            If File.Exists(fdlg.FileName) = False Then
                MessageBox.Show("Maaf, File yang anda pilih tidak ada.")
            Else
                fGambarPlus.ImageLocation = fdlg.FileName
            End If
        End If
    End Sub
    Private Sub loadcbkasetplus()
        bCBJenisPlus.Items.Add("CD")
        bCBJenisPlus.Items.Add("DVD")
        bCBJenisPlus.Items.Add("Blu-Ray")
        bCbJenisEdit.Items.Add("CD")
        bCbJenisEdit.Items.Add("DVD")
        bCbJenisEdit.Items.Add("Blu-Ray")
        cbJenisDel.Items.Add("CD")
        cbJenisDel.Items.Add("DVD")
        cbJenisDel.Items.Add("Blu-Ray")
    End Sub
    'batas kaset plus
    Private Sub dgvKasettoEdit()
        Dim i As Integer
        i = dgvDisk.CurrentRow.Index
        TextBox10.Text = dgvDisk.Item(0, i).Value
        aJudulEdit.Text = dgvDisk.Item(1, i).Value
        bCbJenisEdit.Text = dgvDisk.Item(2, i).Value
        cGenreEdit.Text = dgvDisk.Item(3, i).Value
        dTahunEdit.Text = dgvDisk.Item(4, i).Value
        eLisensorEdit.Text = dgvDisk.Item(5, i).Value
        Stok2.Text = dgvDisk.Item(6, i).Value
        metugambarkaset()
    End Sub
    Private Sub metugambarkaset()
        Dim constr As String = "Server=ALLAN\ALLANBIL;Database=CDDVD;Trusted_Connection = True"
        Using conn As SqlConnection = New SqlConnection(constr)
            Using cmd As SqlCommand = New SqlCommand("SELECT Gambar FROM kaset WHERE ID_Kaset = @Id", conn)
                cmd.Parameters.AddWithValue("@Id", TextBox10.Text)
                conn.Open()
                Dim bytes As Byte() = CType(cmd.ExecuteScalar(), Byte())
                conn.Close()
                fGambarEDit.Image = Image.FromStream(New MemoryStream(bytes))
            End Using
        End Using
    End Sub
    Private Sub dgvDisk_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDisk.CellContentClick
        dgvKasettoEdit()
        dgvkasettodel()
    End Sub
    Private Sub editdatakaset()
        SQL.PlusParam("@id", TextBox10.Text)
        SQL.PlusParam("@nama", aJudulEdit.Text)
        SQL.PlusParam("@jenis", bCbJenisEdit.Text)
        SQL.PlusParam("@genre", cGenreEdit.Text)
        SQL.PlusParam("@rilis", dTahunEdit.Text)
        SQL.PlusParam("@lisensor", eLisensorEdit.Text)
        SQL.PlusParam("@stok", Stok2.Text)
        SQL.PerintahQuery("update kaset set Judul_Kaset=@nama,Jenis_Kaset=@jenis,Genre_Kaset=@genre,Tahun_Rilis=@rilis,Lisensor=@lisensor,stok=@stok where ID_Kaset=@id ")
        If SQL.AdaKecuali(True) Then Exit Sub
        aJudulEdit.Text = ""
        bCbJenisEdit.Text = ""
        cGenreEdit.Text = ""
        dTahunEdit.Text = ""
        Stok2.Text = ""
        Stok3.Text = ""
        eLisensorEdit.Text = ""
        TextBox6.Text = ""
        aJudulDel.Text = ""
        cbJenisDel.Text = ""
        cGenreDel.Text = ""
        dTahunDel.Text = ""
        eLisensorDel.Text = ""
    End Sub
    Private Sub updategambarkaset()
        SQL.PlusParam("@id", TextBox10.Text)
        SQL.PerintahQuery("update kaset Set Gambar= (Select * from openrowset(bulk '" & fGambarEDit.ImageLocation & "', single_blob) as x) where ID_Kaset=@id")
        If SQL.AdaKecuali(True) Then Exit Sub
        MsgBox("Gambar masuk", vbOKOnly)
        TextBox10.Text = ""
        fGambarEDit.Image = Nothing
    End Sub
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If aJudulEdit.Text = "" Or bCbJenisEdit.Text = "" Or cGenreEdit.Text = "" Or dTahunEdit.Text = "" Or eLisensorEdit.Text = "" Then
            MsgBox("Maaf ada data yang belum dimasukkan", vbCritical, "Peringatan")
        Else
            editdatakaset()
            If fGambarEDit.ImageLocation = Nothing Then
            Else
                updategambarkaset()
            End If
            MsgBox("Data berhasil dimasukan", vbOKOnly, "Selamat")
        End If
        loaddatakaset()
        TextBox10.Text = ""
        fGambarEDit.Image = Nothing
    End Sub
    'batas kaset edit
    Private Sub deletedatakaset()
        SQL.PlusParam("@id", TextBox6.Text)
        If MsgBox("Data yg diseleksi akan di hapus!! apakah anda ingin data ini dihapus? ", MsgBoxStyle.YesNo, "menghapus data?") = MsgBoxResult.Yes Then
            SQL.PerintahQuery("delete from kaset where ID_Kaset='" & TextBox6.Text & "'")
        End If
        If SQL.AdaKecuali(True) Then Exit Sub
        TextBox10.Text = ""
        aJudulEdit.Text = ""
        bCbJenisEdit.Text = ""
        cGenreEdit.Text = ""
        dTahunEdit.Text = ""
        eLisensorEdit.Text = ""
        TextBox6.Text = ""
        aJudulDel.Text = ""
        cbJenisDel.Text = ""
        cGenreDel.Text = ""
        dTahunDel.Text = ""
        Stok3.Text = ""
        Stok2.Text = ""
        eLisensorDel.Text = ""
    End Sub
    Private Sub dgvkasettodel()
        Dim i As Integer
        i = dgvDisk.CurrentRow.Index
        TextBox6.Text = dgvDisk.Item(0, i).Value
        aJudulDel.Text = dgvDisk.Item(1, i).Value
        cbJenisDel.Text = dgvDisk.Item(2, i).Value
        cGenreDel.Text = dgvDisk.Item(3, i).Value
        dTahunDel.Text = dgvDisk.Item(4, i).Value
        eLisensorDel.Text = dgvDisk.Item(5, i).Value
        Stok3.Text = dgvDisk.Item(6, i).Value
        metugambarkasetdel()
    End Sub
    Private Sub metugambarkasetdel()
        Dim constr As String = "Server=ALLAN\ALLANBIL;Database=CDDVD;Trusted_Connection = True"
        Using conn As SqlConnection = New SqlConnection(constr)
            Using cmd As SqlCommand = New SqlCommand("SELECT Gambar FROM kaset WHERE ID_Kaset = @Id", conn)
                cmd.Parameters.AddWithValue("@Id", TextBox6.Text)
                conn.Open()
                Dim bytes As Byte() = CType(cmd.ExecuteScalar(), Byte())
                conn.Close()
                fGambarDel.Image = Image.FromStream(New MemoryStream(bytes))
            End Using
        End Using
    End Sub
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        deletedatakaset()
        loaddatakaset()
        fGambarDel.Image = Nothing
    End Sub
    Private Sub cariDisk()
        SQL.PlusParam("@id", "%" & txtFilterDisk.Text & "%")
        SQL.PerintahQuery("select * from kaset where " & cbFilterDisk.Text & " like @id order by " & cbFilterDisk.Text & " asc")
        dgvDisk.DataSource = SQL.STabel
    End Sub
    Private Sub btnCariDisk_Click(sender As Object, e As EventArgs) Handles btnCariDisk.Click
        cariDisk()
    End Sub
    'batas kaset
    Private Sub loadpinjamdata()
        SQL.PerintahQuery("Select * from pinjam")
        DataGridView1.DataSource = SQL.STabel
    End Sub
    Private Sub loadpinjamdatabtn(sender As Object, e As EventArgs) Handles Button14.Click
        loadpinjamdata()
    End Sub
    Private Sub loadpinjamdatafilter()
        cbFilterPinjam.Items.Add("No_Pinjam")
        cbFilterPinjam.Items.Add("Judul_Kaset")
        cbFilterPinjam.Items.Add("Nama_Member")
        cbFilterPinjam.Text = "Nama_Member"
    End Sub
    'batas dataform
    Private Sub qqBtnCari2_Click(sender As Object, e As EventArgs) Handles qqBtnCari2.Click
        MemberCari.Show()
    End Sub
    Private Sub qqBtnCari1_Click(sender As Object, e As EventArgs) Handles qqBtnCari1.Click
        StaffCari.Show()
    End Sub

    Private Sub idkaryawann()
        SQL.PerintahQuery("Select * from staff where Nama_Karyawan=" & qNamaK.Text & "")
        idkaryawantext.Text = ""
        For Each r As DataRow In SQL.STabel.Rows
            idkaryawantext.Text = (r("ID_Karyawan"))
        Next
    End Sub
    Private Sub qqBtnBaru_Click(sender As Object, e As EventArgs) Handles qqBtnBaru.Click
        Dim duwur As String
        Dim i As Integer
        SQL.PerintahQuery("Select coalesce(max(No_Pinjam),'0000000') as highest from pinjam")
        For Each r As DataRow In SQL.STabel.Rows
            duwur = r("highest")
            i = Val(Mid(duwur, 6))
        Next
        Dim m As String = i + 1 + 100000
        qNoPinjam.Text = "P" + Mid(m, 2).ToString
    End Sub
    Private Sub stonkmin()
        Dim stok As Integer
        If stoktext.Text <= 0 Then
            MsgBox("Bukunya sudah tidak ada", vbYesNo)
        Else
            stok = Val(stoktext.Text) - 1
            stoktext2.Text = stok
            SQL.PlusParam("@stonk", stoktext2.Text)
            SQL.PlusParam("@kode", qJudul.Text)
            SQL.PerintahQuery("Update kaset set Stok=@stonk where Judul_Kaset=@kode")
            insertdatapinjam()
        End If
    End Sub
    Private Sub insertdatapinjam()
        SQL.PlusParam("@nopinjam", qNoPinjam.Text)
        SQL.PlusParam("@total", totalpinjam.Text)
        SQL.PlusParam("@tglpinjam", qTGLPinjam.Value)
        SQL.PlusParam("@tglkembali", qTGLKembali.Value)
        SQL.PlusParam("@judul", qJudul.Text)
        SQL.PlusParam("@namam", qNamaM.Text)
        SQL.PlusParam("@id", TextBox2.Text)
        SQL.PlusParam("@idkaset", qIdKaset.Text)
        SQL.PlusParam("@namak", qNamaK.Text)
        SQL.PlusParam("@idnamak", idkaryawantext.Text)
        SQL.PerintahQuery("insert into pinjam(ID_Karyawan,ID_Kaset,ID_Member,No_Pinjam,Status,Tgl_Pinjam,Tgl_Kembali,Total_Pinjam,Judul_Kaset,Nama_Member,Nama_Karyawan) " &
                          "values(@idnamak,@idkaset,@id,@nopinjam,'Belum Dikembalikan',@tglpinjam,@tglkembali,@total,@judul,@namam,@namak) ")
        If SQL.AdaKecuali(True) Then Exit Sub
        qNoPinjam.Text = ""
        qJudul.Text = ""
        qNamaM.Text = ""
        qNamaK.Text = ""
        MsgBox("Berhasil menambahkan data", vbOKOnly, "selamat")
    End Sub
    Public Sub luruhari()
        SQL.PlusParam("@id", TextBox2.Text)
        SQL.PerintahQuery("select * from pinjam where ID_Member=@id")
        For Each r As DataRow In SQL.STabel.Rows
            hariini.Text = r("Tgl_Pinjam")
        Next
    End Sub
    Public Sub ngitungjumlah()
        SQL.PerintahQuery("select coalesce(max(Total_Pinjam),'0') as highest from pinjam where ID_Member=" & TextBox2.Text & "")
        Dim jumlah As String
        Dim num As Integer = 0
        For Each r As DataRow In SQL.STabel.Rows
            jumlah = r("highest")
            num = jumlah
        Next
        Dim item As Integer = num + 1
        totalpinjam.Text = item.ToString
    End Sub
    Private Sub qqBtnSimpan_Click(sender As Object, e As EventArgs) Handles qqBtnSimpan.Click
        maxtotal()
        loadpinjamdata()

    End Sub
    Private Sub qNamaM_TextChanged(sender As Object, e As EventArgs) Handles qNamaM.TextChanged
        nentuknohari()
        luruhari()
    End Sub
    Public Sub nentuknohari()
        Dim hariiiii As New DateTimePicker
        SQL.PerintahQuery("select coalesce(max(Tgl_Pinjam), '0') as date from pinjam where ID_Member=" & TextBox2.Text & "")
        For Each r As DataRow In SQL.STabel.Rows
            hariiiii.Value = r("date")
        Next
        If hariiiii.Value.Date = qTGLPinjam.Value.Date Then
            ngitungjumlah()
        Else
            totalpinjam.Text = "1"
        End If
    End Sub
    Private Sub loadtotalpinjam()
        SQL.PerintahQuery("select * from pengaturan")
        For Each r As DataRow In SQL.STabel.Rows
            totalpinjamm = r("total_pinjam")
        Next
    End Sub
    Public Sub maxtotal()
        If totalpinjam.Text > totalpinjamm Then
            MsgBox("Maaf sudah tidak bisa meminjam lagi", vbCritical, "Kasihan :(")
        Else
            stonkmin()
        End If
    End Sub
    'batas tambah
    Private Sub dgvtodeletpinjam()
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        qNoPinjamDe.Text = DataGridView1.Item(0, i).Value
        qTGLPinjamde.Value = DataGridView1.Item(2, i).Value
        qTGLKembalide.Value = DataGridView1.Item(3, i).Value
        qJudulde.Text = DataGridView1.Item(5, i).Value
        TextBox2de.Text = DataGridView1.Item(6, i).Value
        qNamaMde.Text = DataGridView1.Item(7, i).Value
        qNamaKde.Text = DataGridView1.Item(8, i).Value
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        dgvtodeletpinjam()
    End Sub
    Private Sub deletepinjam()
        SQL.PlusParam("@id", qNoPinjamDe.Text)
        If MsgBox("Data yg diseleksi akan di hapus!! apakah anda ingin data ini dihapus? ", MsgBoxStyle.YesNo, "menghapus data?") = MsgBoxResult.Yes Then
            SQL.PerintahQuery("delete from pinjam where No_Pinjam='" & qNoPinjamDe.Text & "'")
        End If
        If SQL.AdaKecuali(True) Then Exit Sub
        qNoPinjamDe.Text = ""
        qJudulde.Text = ""
        TextBox2de.Text = ""
        qNamaMde.Text = ""
        qNamaKde.Text = ""
    End Sub
    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        deletepinjam()
    End Sub
    'batas
    Private Sub kembaliload()
        SQL.PerintahQuery("select * from pinjam where not Status='Sudah Dikembalikan'")
        DataGridView2.DataSource = SQL.STabel
    End Sub
    Private Sub button20_click(sender As Object, e As EventArgs) Handles Button20.Click
        kembaliload()
    End Sub
    Private Sub dgv2tokembali()
        Dim i As Integer
        i = DataGridView2.CurrentRow.Index
        Kembali.nopinjam.Text = DataGridView2.Item(0, i).Value
        TextBox7.Text = DataGridView2.Item(0, i).Value
        Kembali.tglkembali.Text = DataGridView2.Item(3, i).Value
        Kembali.judulkaset.Text = DataGridView2.Item(6, i).Value
        Kembali.idmember.Text = DataGridView2.Item(7, i).Value
        Kembali.namamember.Text = DataGridView2.Item(8, i).Value
        Kembali.namakaryawan.Text = DataGridView2.Item(10, i).Value
        Kembali.idkaryawan.Text = DataGridView2.Item(9, i).Value
        Kembali.idkasettt.Text = DataGridView2.Item(5, i).Value
        Kembali.lurudenda()
    End Sub
    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        dgv2tokembali()
    End Sub
    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        If TextBox7.Text = "" Then
            MsgBox("Pilih datanya dulu", vbOKOnly, "Peringatan")
        Else
            Kembali.ShowDialog()
        End If
    End Sub
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        cariPinjam()
    End Sub
    Private Sub cariPinjam()
        SQL.PlusParam("@id", "%" & txtFilterPinjam.Text & "%")
        SQL.PerintahQuery("select * from pinjam where " & cbFilterPinjam.Text & " like @id order by " & cbFilterPinjam.Text & " asc")
        DataGridView1.DataSource = SQL.STabel
    End Sub
    Private Sub PengembalianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengembalianToolStripMenuItem.Click
        PengembalianLaporan.ShowDialog()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fdlg As OpenFileDialog = New OpenFileDialog()
        fdlg.Title = "Pilih Foto"
        fdlg.InitialDirectory = "c:\"
        fdlg.Filter = "Picture Files(*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        fdlg.FilterIndex = 2
        fdlg.RestoreDirectory = True
        If fdlg.ShowDialog() = DialogResult.OK Then
            If File.Exists(fdlg.FileName) = False Then
                MessageBox.Show("Maaf, File yang anda pilih tidak ada.")
            Else
                gFotoEdit.ImageLocation = fdlg.FileName
            End If
        End If
    End Sub
    'batas
    Private Sub loaddatakembali22()
        SQL.PerintahQuery("select * from kembali")
        DataGridView3.DataSource = SQL.STabel
    End Sub
    Private Sub lurudatakembali22()
        SQL.PlusParam("@id", "%" & TextBox8.Text & "%")
        SQL.PerintahQuery("select * from kembali where " & ComboBox1.Text & " like @id order by " & ComboBox1.Text & " asc")
        DataGridView3.DataSource = SQL.STabel
    End Sub
    Private Sub metucbkembali22()
        ComboBox1.Items.Add("Judul_Kaset")
        ComboBox1.Items.Add("ID_Member")
        ComboBox1.Items.Add("Nama_Member")
        ComboBox1.Items.Add("Nama_Karyawan")
        ComboBox1.Text = "ID_Member"
    End Sub
    Private Sub clickbutton7(sender As Object, e As EventArgs) Handles Button7.Click
        lurudatakembali22()
    End Sub
    Private Sub clickbutton4(sender As Object, e As EventArgs) Handles Button4.Click
        loaddatakembali22()
    End Sub
    Private Sub btnGambarEditDisk_Click(sender As Object, e As EventArgs) Handles btnGambarEditDisk.Click
        Dim fdlg As OpenFileDialog = New OpenFileDialog()
        fdlg.Title = "Pilih Foto"
        fdlg.InitialDirectory = "c:\"
        fdlg.Filter = "Picture Files(*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        fdlg.FilterIndex = 2
        fdlg.RestoreDirectory = True
        If fdlg.ShowDialog() = DialogResult.OK Then
            If File.Exists(fdlg.FileName) = False Then
                MessageBox.Show("Maaf, File yang anda pilih tidak ada.")
            Else
                fGambarEDit.ImageLocation = fdlg.FileName
            End If
        End If
    End Sub
    Private Sub PengaturanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengaturanToolStripMenuItem.Click
        Pengaturan.ShowDialog()
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        metuadmin()
        cariadmin()
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub LoginUserLainToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginUserLainToolStripMenuItem.Click
        Me.Hide()
        Login.Show()
    End Sub
    Private Sub qNamaK_SelectedIndexChanged(sender As Object, e As EventArgs)
        idkaryawann()
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        karyawancari.ShowDialog()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        SQL.PlusParam("@id", "%" & TextBox9.Text & "%")
        SQL.PerintahQuery("select * from pinjam where " & ComboBox2.Text & " like @id and not status='Sudah Dikembalikan' order by " & ComboBox2.Text & " asc")
        DataGridView2.DataSource = SQL.STabel
    End Sub
End Class