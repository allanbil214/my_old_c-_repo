Public Class formCari2
    Private sql As New Squek
    Public pid As Integer
    Public namap As String
    Sub loaddata()
        sql.addparam("@text", "%" & txtCari.Text & "%")
        sql.execquery("select * from pelanggan where nama like @text")
        dgv1.DataSource = sql.dbdt
    End Sub
    Private Sub formCari1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        loaddata()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If namap = "" Then
            MsgBox("pilih dulu")
        Else
            formPinjam.pid = pid
            formPinjam.txtNamap.Text = namap
            formPinjam.btnCari2.Enabled = False
            Me.Close()
        End If
    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        Dim i As Integer = dgv1.CurrentRow.Index
        pid = dgv1.Item(0, i).Value
        namap = dgv1.Item(1, i).Value
    End Sub
End Class