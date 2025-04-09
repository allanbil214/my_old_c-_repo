Public Class ChangePasswordForm
    Private sql As New SquekDataContext
    Private msg = ""
    Function validasi() As Boolean
        Dim result = False
        If UsernameTextBox.Text = "" Then
            msg = "Password lama diisi dulu"
        ElseIf PasswordTextBox.Text = "" Then
            msg = "Password Baru diisi dulu"
        Else
            Return True
        End If
        Return result
    End Function

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        Dim karyawan As Karyawan = sql.Karyawans.Where(Function(x) x.KaryawanId = (LoginForm.karyawanid)).FirstOrDefault
        If karyawan IsNot Nothing Then
            If UsernameTextBox.Text = karyawan.Password Then
                If MsgBox("Yakin?", vbYesNo) = vbYes Then
                    karyawan.Password = PasswordTextBox.Text
                    sql.SubmitChanges()
                    UsernameTextBox.Clear()
                    PasswordTextBox.Clear()
                    UsernameTextBox.Select()
                    MsgBox("Success")
                End If
            Else
                MsgBox("Password lama salah!", vbOKOnly, "Peringatan")
            End If
        End If
    End Sub
End Class
