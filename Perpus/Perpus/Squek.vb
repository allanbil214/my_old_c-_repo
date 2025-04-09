Imports System.Data.SqlClient
Public Class squek
    Private dbcon As New SqlConnection("server=ALLAN/ALLANBIL;database=Perpus;Trusted_Connection=True")
    Public dbcmd As SqlCommand
    Public dbda As SqlDataAdapter
    Public dbdr As SqlDataReader
    Public dbdt As DataTable
    Public dbds As DataSet
    Public params As New List(Of SqlParameter)
    Public rc As Integer
    Public kecuali As String
    Public Sub New(dbconstring As String)
        dbcon = New SqlConnection(dbconstring)
    End Sub
    Public Function hasconnection() As Boolean
        Try
            dbcon.Close()
            dbcon.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function
    Public Function sequery(sql As String) As DataTable
        Dim dt As DataTable
        Try
            dbcon.Open()
            dbcmd.CommandText = sql
            Dim da As New SqlDataAdapter(dbcmd)
            dbda.Fill(dt)
        Catch ex As Exception
            MsgBox(ex.Message, "error")
        Finally
            dbcon.close
        End Try
        Return dt
    End Function
End Class