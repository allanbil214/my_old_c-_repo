Imports System.ComponentModel

Public Class ChangePasswordForm
    Private linq As New LinQDataContext
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtOld.Text = "" Or txtNew.Text = "" Or txtConfirm.Text = "" Then
            MsgBox("Please fill the field first!")
        Else
            Dim checkpass = linq.Employees.Where(Function(x) x.Password = txtOld.Text)
            If checkpass.Count = 0 Then
                MsgBox("Invalid password!")
                Return
            End If
            Dim findid = checkpass.FirstOrDefault(Function(x) x.Password = txtOld.Text)
            Dim getid = findid.EmployeeId
            If txtNew.Text <> txtConfirm.Text Then
                MsgBox("Password is isnot the same!")
                Return
            End If
            Dim newemployee As Employee
            newemployee = linq.Employees.Single(Function(x) x.EmployeeId = getid)
            newemployee.Password = txtNew.Text
            linq.SubmitChanges()
            txtNew.Clear()
            txtConfirm.Clear()
            txtOld.Clear()
            txtOld.Select()
            MsgBox("Success")
        End If
    End Sub
    Private Sub ChangePasswordForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        txtNew.Clear()
        txtConfirm.Clear()
        txtOld.Clear()
        txtOld.Select()
    End Sub
End Class