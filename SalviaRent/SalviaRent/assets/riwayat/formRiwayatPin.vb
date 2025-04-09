Public Class formRiwayatPin
    Private sql As New Squek
    Private wherecari As String = "Judul"
    Private Sub loaddata()
        sql.addparam("@awal", DateTimePicker1.Value.Date)
        sql.addparam("@akhir", DateTimePicker2.Value.Date)
        sql.addparam("@item", "%" & txtCari.Text & "%")
        sql.execquery("select Karyawan.Nama as 'Nama Karyawan',Pelanggan.Nama as 'Nama Pelanggan', 
pinjam.TglPinjam as 'Tanggal Pinjam', pinjam.TglKembali as 'Tanggal Kembali', 
cd.Judul,pinjamcd.Qty,pinjamcd.Harga,pinjamcd.Status 
from pinjamcd 
inner join pinjam on pinjam.id = pinjamcd.pinjamid 
inner join cd on cd.id = pinjamcd.CDID 
inner join karyawan on karyawan.id = pinjam.KaryawanID 
inner join pelanggan on pelanggan.id = pinjam.pelangganid 
where pinjam.TglPinjam >= @awal and pinjam.TglPinjam <= @akhir and " & wherecari & " like @item")
        If sql.hasexception(True) Then Exit Sub
        dgv1.DataSource = sql.dbdt
    End Sub
    Private Sub formRiwayatPin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = DateTime.Now
        DateTimePicker2.Value = DateTime.Now.AddDays(7)
        ComboBox1.Items.Add("Judul")
        ComboBox1.Items.Add("Nama Pelanggan")
        ComboBox1.Items.Add("Nama Karyawan")
        ComboBox1.Text = "Judul"
        loaddata()
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        loaddata()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Nama Pelanggan" Then
            wherecari = "Pelanggan.Nama"
        ElseIf ComboBox1.Text = "Nama Karyawan" Then
            wherecari = "Karyawan.Nama"
        ElseIf ComboBox1.Text = "Judul" Then
            wherecari = "CD.Judul"
        End If
        txtCari.Clear()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        loaddata()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        loaddata()
    End Sub
End Class