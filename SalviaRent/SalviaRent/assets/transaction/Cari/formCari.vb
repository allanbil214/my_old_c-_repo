Public Class formCari
    Private sql As New Squek
    Private Sub loaddata()
        sql.addparam("@id", "%" & txtCari.Text & "%")
        sql.execquery("select * from cd where judul like @id ")
        dgv1.DataSource = sql.dbdt
    End Sub
    Private Sub formCari_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
        dgv1.Columns(0).Visible = False
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        loaddata()
    End Sub
    Private Sub tipeidkenama()
        sql.addparam("@id", formPeminjaman.tipeid)
        sql.execquery("select * from tipecd where id=@id")
        For Each r As DataRow In sql.dbdt.Rows
            formPeminjaman.txtTipe.Text = r("Nama")
        Next
    End Sub
    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        Dim i As Integer
        i = dgv1.CurrentRow.Index
        formPeminjaman.cdid = dgv1.Item(0, i).Value
        formPeminjaman.txtJudul.Text = dgv1.Item(1, i).Value
        formPeminjaman.tipeid = dgv1.Item(2, i).Value
        formPeminjaman.qtycd = dgv1.Item(3, i).Value
        tipeidkenama()
        formPeminjaman.txtHarga.Text = dgv1.Item(4, i).Value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If formPeminjaman.txtJudul.Text = "" Then
            MsgBox("Pilih dulu datanya", vbOKOnly, "Peringatan")
        Else
            Me.Close()
        End If
    End Sub
End Class