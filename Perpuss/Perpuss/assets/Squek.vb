Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class Squek
    Private dbcon As New SqlConnection("server=ALLAN\ALLANBIL;database=Perpuss;Trusted_Connection=True")
    Public dbcmd As SqlCommand
    Public dbda As SqlDataAdapter
    Public dbdt As DataTable
    Public dbds As DataSet
    Public params As New List(Of SqlParameter)
    Public rc As Integer
    Public Sub New()
    End Sub
    Public Sub New(dbconstring As String)
        dbcon = New SqlConnection(dbconstring)
    End Sub
    Public Function hasconnection()
        Try
            dbcon.Close()
            dbcon.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function
    Private Sub execquery(query As String)
        rc = 0
        Try
            dbcon.Open()
            dbcmd = New SqlCommand(query, dbcon)
            params.ForEach(Sub(p) dbcmd.Parameters.Add(p))
            params.Clear()

        Catch ex As Exception

        End Try
    End Sub
End Class
