Public Class karyawancari
    Dim sql As New Squek
    Dim tulisan As String = ""
    Dim idk As String = ""
    Private Sub metudata()
        sql.PerintahQuery("select * from staff where not ID_Karyawan='2'")
        dgvM.DataSource = sql.STabel
    End Sub
    Private Sub MemberCari_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        metudata()
        cbFilterPinjam.Items.Add("Nama_Karyawan")
        cbFilterPinjam.Items.Add("Kode_Karyawan")
        cbFilterPinjam.Items.Add("Email")
        cbFilterPinjam.Text = "Nama_Karyawan"
    End Sub
    Private Sub dgvM_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvM.CellContentClick
        Dim i As Integer
        i = dgvM.CurrentRow.Index
        tulisan = dgvM.Item(2, i).Value
        idk = dgvM.Item(0, i).Value
        Form1.qNamaK.Text = tulisan
        Form1.idkaryawantext.Text = idk
        TextBox1.Text = tulisan
        Form1.luruhari()
        Form1.ngitungjumlah()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub cari()
        sql.PlusParam("@id", "%" & txtFilterPinjam.Text & "%")
        sql.PerintahQuery("select * from staff where " & cbFilterPinjam.Text & " like @id and not Nama_User='ADMIN' order by " & cbFilterPinjam.Text & " asc")
        dgvM.DataSource = sql.STabel
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        cari()
    End Sub
End Class