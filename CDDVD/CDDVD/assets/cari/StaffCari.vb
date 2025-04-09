Public Class StaffCari
    Dim sql As New Squek
    Dim tulisan As String = ""
    Dim stok As Integer = 0
    Dim idkaset As Integer
    Private Sub metudata()
        sql.PerintahQuery("select * from kaset")
        dgvM.DataSource = sql.STabel
    End Sub
    Private Sub MemberCari_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        metudata()
        cbFilterPinjam.Items.Add("Judul_Kaset")
        cbFilterPinjam.Items.Add("Genre_Kaset")
        cbFilterPinjam.Items.Add("Lisensor")
        cbFilterPinjam.Text = "Judul_Kaset"
    End Sub
    Private Sub dgvM_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvM.CellContentClick
        Dim i As Integer
        i = dgvM.CurrentRow.Index
        idkaset = dgvM.Item(0, i).Value
        tulisan = dgvM.Item(1, i).Value
        stok = dgvM.Item(6, i).Value
        Form1.qJudul.Text = tulisan
        Form1.stoktext.Text = stok
        Form1.qIdKaset.Text = idkaset
        TextBox1.Text = tulisan
        TextBox2.Text = stok
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        sql.PlusParam("@id", "%" & txtFilterPinjam.Text & "%")
        sql.PerintahQuery("select * from kaset where " & cbFilterPinjam.Text & " like @id order by " & cbFilterPinjam.Text & " asc")
        dgvM.DataSource = sql.STabel
    End Sub
End Class