Public Class formDenda
    Private sql As New Squek
    Private id As Integer
    Sub loaddata()
        sql.execquery("select * from denda")
        For Each r As DataRow In sql.dbdt.Rows
            id = r("id")
            TextBox1.Text = r("denda")
        Next
    End Sub
    Private Sub formDenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("isi dulu")
        Else
            sql.addparam("@id", id)
            sql.addparam("@text", TextBox1.Text)
            sql.execquery("update denda set denda=@text where id=@id")
            If sql.hascecep(True) Then Exit Sub
            MsgBox("terubah")
        End If
    End Sub
End Class