Public Class formChangePass
    Dim sql As New Squek
    Private Sub updatepass()
        sql.addparam("@old", TextBox1.Text)
        sql.addparam("@new", TextBox2.Text)
        sql.addparam("@confirm", TextBox3.Text)
        sql.execquery("update employee set Passwords=@new where Passwords=@old")
        If sql.hascecep(True) Then Exit Sub
        MsgBox("Password successfully updated", vbOKOnly, "Congratulation")
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox1.UseSystemPasswordChar = False
        Else
            TextBox1.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            TextBox3.UseSystemPasswordChar = False
        Else
            TextBox3.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Please insert the data first!", vbOKOnly, "Caution")
        ElseIf TextBox2.Text = TextBox3.Text Then
            updatepass()
        ElseIf TextBox2.Text <> TextBox3.Text Then
            MsgBox("Password is incorrect", vbOKOnly, "Caution")
        End If
    End Sub
End Class