Public Class MemberCari
    Dim sql As New Squek
    Dim tulisan As String = ""
    Dim idmember As String = ""
    Private Sub metudata()
        sql.PerintahQuery("select * from member")
        dgvM.DataSource = sql.STabel
    End Sub
    Private Sub MemberCari_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        metudata()
        cbFilterPinjam.Items.Add("Nama_Member")
        cbFilterPinjam.Items.Add("ID_Member")
        cbFilterPinjam.Items.Add("Email")
        cbFilterPinjam.Text = "Nama_Member"
    End Sub
    Private Sub dgvM_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvM.CellContentClick
        Dim i As Integer
        i = dgvM.CurrentRow.Index
        tulisan = dgvM.Item(1, i).Value
        idmember = dgvM.Item(0, i).Value
        Form1.qNamaM.Text = tulisan
        Form1.TextBox2.Text = idmember
        TextBox1.Text = tulisan
        Form1.luruhari()
        Form1.ngitungjumlah()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub cari()
        sql.PlusParam("@id", "%" & txtFilterPinjam.Text & "%")
        sql.PerintahQuery("select * from member where " & cbFilterPinjam.Text & " like @id order by " & cbFilterPinjam.Text & " asc")
        dgvM.DataSource = sql.STabel
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        cari()
    End Sub
End Class