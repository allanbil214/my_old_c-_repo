Public Class formCari1
    Private sql As New Squek
    Public cdid As Integer
    Public cdjudul As String
    Public cdtipe As String
    Public stokasli As Integer
    Public harga As Integer
    Sub loaddata()
        sql.addparam("@text", "%" & txtCari.Text & "%")
        sql.execquery("select * from cd where judul like @text")
        dgv1.DataSource = sql.dbdt
    End Sub
    Private Sub formCari1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        loaddata()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cdjudul = "" Then
            MsgBox("pilih dulu")
        Else
            formPinjam.cdid = cdid
            formPinjam.txtTipe.Text = cdtipe
            formPinjam.txtJudul.Text = cdjudul
            formPinjam.stokasli = stokasli
            formPinjam.txtHarga.Text = harga
            Me.Close()
        End If
    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        Dim i As Integer = dgv1.CurrentRow.Index
        cdid = dgv1.Item(0, i).Value
        cdjudul = dgv1.Item(1, i).Value
        cdtipe = dgv1.Item(2, i).Value
        stokasli = dgv1.Item(3, i).Value
        harga = dgv1.Item(4, i).Value
    End Sub
End Class