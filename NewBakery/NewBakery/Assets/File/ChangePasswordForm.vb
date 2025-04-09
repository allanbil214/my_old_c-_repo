Imports System.ComponentModel

Public Class ChangePasswordForm
    Private sql As New SquekingDataContext
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtOld.Text = "" Or txtConfirm.Text = "" Or txtNew.Text = "" Then
            MsgBox("Fill the field first!")
        Else
            Dim oldpass = sql.Employees.Where(Function(x) x.Password = txtOld.Text)
            If oldpass.Count <= 0 Then
                MsgBox("Invalid Password")
                Return
            End If
            Dim findid = sql.Employees.FirstOrDefault(Function(x) x.Password = txtOld.Text)
            Dim getid = findid.EmployeeId
            If txtNew.Text <> txtConfirm.Text Then
                MsgBox("Password is isnot the same!")
                Return
            End If
            Dim newemployee As Employee
            newemployee = sql.Employees.Single(Function(x) x.EmployeeId = getid)
            newemployee.Password = txtNew.Text
            sql.SubmitChanges()
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