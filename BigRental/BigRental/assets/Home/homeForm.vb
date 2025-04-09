Public Class homeForm
    Private sql As New Squek
    Private Sub homeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql.execquery("select * from pengaturan")
        For Each r As DataRow In sql.dbdt.Rows
            Label1.Text = r("NamaToko")
            Label2.Text = r("Alamat")
            Label3.Text = r("Pemilik")
            Label4.Text = r("NomorTelepon")
        Next
    End Sub
End Class