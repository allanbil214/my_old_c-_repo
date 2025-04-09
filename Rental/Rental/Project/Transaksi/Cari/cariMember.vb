Public Class cariMember
    Dim sql As New Squek
    Private Sub loaddata()
        sql.execquery("select * from member")
        dgv1.DataSource = sql.dbdt
    End Sub
    Private Sub CariKaset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
        cbfilter.Items.Add("Pilih Dulu")
        cbfilter.Items.Add("NamaMember")
        cbfilter.Items.Add("NoTelp")
        cbfilter.Text = "Pilih Dulu"
    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        Dim i As Integer
        i = dgv1.CurrentRow.Index
        TextBox1.Text = dgv1.Item(0, i).Value
        TextBox2.Text = dgv1.Item(1, i).Value
        Peminjam.txtkode.Text = dgv1.Item(0, i).Value
        Peminjam.txtmember.Text = dgv1.Item(1, i).Value
        Peminjam.totalquery = dgv1.Item(4, i).Value
    End Sub
    Private Sub btnfilter_Click(sender As Object, e As EventArgs) Handles btnfilter.Click
        sql.addparam("@id", "%" & txtfilter.Text & "%")
        sql.execquery("select * from member where " & cbfilter.Text & " like @id order by " & cbfilter.Text & " asc")
        dgv1.DataSource = sql.dbdt
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class