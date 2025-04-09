Public Class formAturDenda
    Private sql As New Squek
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sql.addparam("@id", TextBox1.Text)
        sql.execquery("update denda set denda=@id")
        If sql.hasexception(True) Then Exit Sub
        MsgBox("Denda berhasil dirubah")
    End Sub

    Private Sub formAturDenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql.execquery("select denda from denda")
        For Each r As DataRow In sql.dbdt.Rows
            TextBox1.Text = r("denda")
        Next
    End Sub
End Class