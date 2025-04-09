Imports System.Text.RegularExpressions
Public Class testing
    Sub TestEncoding()
        Dim wrapper As New Simple3Des(TextBox1.Text)
        Dim cipherText As String = wrapper.EncryptData(TextBox2.Text)

        MsgBox("The cipher text is: " & cipherText)
        TextBox5.Text = cipherText
    End Sub
    Sub TestDecoding()
        Dim cipherText As String = TextBox3.Text
        Dim wrapper As New Simple3Des(TextBox4.Text)

        Try
            Dim plainText As String = wrapper.DecryptData(cipherText)
            MsgBox("The plain text is: " & plainText)
            TextBox6.Text = plainText
        Catch ex As System.Security.Cryptography.CryptographicException
            MsgBox("The data could not be decrypted with the username.")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TestEncoding()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TestDecoding()
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim random As New Random
        Dim allowChrs() As Char = "ABCDEFGHIJKLOMNOPQRSTUVWXYZ0123456789".ToCharArray()
        For i As Integer = 1 To 6
            TextBox7.Text += allowChrs(random.Next(0, allowChrs.Length))
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub TextBox8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox8.KeyPress

    End Sub

    Private Sub testing_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class