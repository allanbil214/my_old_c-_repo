Public Class Kembali
    Dim sql As New Squek
    Dim stonk As Integer
    Dim stonk2 As Integer
    Dim dendaaa As Integer
    Dim realadmin As Integer

    Private Sub Kembali_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tgldikembali.Value = DateTime.Now
        loaddenda()
    End Sub
    Private Sub loaddenda()
        sql.PerintahQuery("select * from pengaturan")
        For Each r As DataRow In sql.STabel.Rows
            dendaaa = r("Denda")
        Next
    End Sub
    Public Sub lurudenda()
        Dim selisih As Integer
        selisih = DateDiff("d", tgldikembali.Value, tglkembali.Value)
        If selisih < 0 Then
            selisih = selisih * (-Val(dendaaa))
            denda.Text = selisih
        Else
            denda.Text = "0"
        End If
    End Sub
    Private Sub kembali()
        sql.PlusParam("@kembali", tglkembali.Value)
        sql.PlusParam("@dikembali", tgldikembali.Value)
        sql.PlusParam("@denda", denda.Text)
        sql.PlusParam("@judul", judulkaset.Text)
        sql.PlusParam("@idmember", idmember.Text)
        sql.PlusParam("@namamember", namamember.Text)
        sql.PlusParam("@namakaryawan", namakaryawan.Text)
        sql.PlusParam("@idkaset", idkasettt.Text)
        sql.PlusParam("@idkaryaw", idkaryawan.Text)
        sql.PerintahQuery("insert into kembali(ID_Karyawan,ID_Kaset,Tgl_Kembali,Tgl_Dikembali,Judul_Kaset,Denda,ID_Member,Nama_Member,Nama_Karyawan) " &
                          "values(@idkaryaw,@idkaset,@kembali,@dikembali,@judul,@denda,@idmember,@namamember,@namakaryawan)")
        If sql.AdaKecuali(True) Then Exit Sub
    End Sub
    Public Sub updatestatus()
        sql.PlusParam("@id", nopinjam.Text)
        sql.PerintahQuery("Update pinjam set Status='Sudah Dikembalikan' where No_Pinjam=@id")
        nopinjam.Text = ""
        denda.Text = ""
        judulkaset.Text = ""
        idmember.Text = ""
        namamember.Text = ""
        namakaryawan.Text = ""
        MsgBox("Data sudah berhasil dimasukkan", vbOKOnly, "Selamat")
    End Sub
    Public Sub lurustonk()
        sql.PlusParam("@kode", judulkaset.Text)
        sql.PerintahQuery("Select * from kaset where Judul_Kaset=@kode")
        For Each r As DataRow In sql.STabel.Rows
            stoktext.Text = r("Stok")
        Next
    End Sub
    Private Sub stonkplus()
        lurustonk()
        Dim stok As Integer
        stok = Val(stoktext.Text) + 1
        stoktext2.Text = stok
        sql.PlusParam("@stonk", stoktext2.Text)
        sql.PlusParam("@kode", judulkaset.Text)
        sql.PerintahQuery("Update kaset set Stok=@stonk where Judul_Kaset=@kode")
        kembali()
        updatestatus()
    End Sub
    Private Sub qqBtnSimpan_Click(sender As Object, e As EventArgs) Handles qqBtnSimpan.Click
        stonkplus()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lurudenda()
    End Sub
    Private Sub tgldikembali_ValueChanged(sender As Object, e As EventArgs) Handles tgldikembali.ValueChanged
        lurudenda()
    End Sub
    Private Sub tickingadmin()
        sql.PlusParam("@nama", Form1.ToolStripStatusLabel1.Text)
        sql.PerintahQuery("select isadmin from staff where Nama_User=@nama")
        For Each r As DataRow In sql.STabel.Rows
            realadmin = r("isadmin")
        Next
        If realadmin = 0 Then
            tgldikembali.Enabled = False
        ElseIf realadmin = 1 Then
            tgldikembali.Enabled = True
        End If
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        tickingadmin()
    End Sub
End Class