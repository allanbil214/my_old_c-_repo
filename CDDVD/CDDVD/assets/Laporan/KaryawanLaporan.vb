Public Class KaryawanLaporan
    Private Sub Load_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Laporan As New KaryawanLaporanSap
        Me.CrystalReportViewer1.ReportSource = Laporan
        Me.Show()
    End Sub
End Class