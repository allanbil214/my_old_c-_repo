Imports System.Windows.Forms

Public Class MDIParent1
    Dim SQL As New Squek
    Public usermasuk As String
    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me
        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber
        ChildForm.Show()
    End Sub
    Private Sub mdiform_close(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Closing
        Login.Close()
    End Sub
    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub
    Private m_ChildFormNumber As Integer
    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rumah As New Home
        rumah.Owner = Me
        rumah.MdiParent = Me
        rumah.Show()
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Dim rumah As New Home
        rumah.Owner = Me
        rumah.MdiParent = Me
        rumah.Show()
    End Sub
End Class
