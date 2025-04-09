Imports System.Data.SqlClient
Public Class Class2
    Private dbcon As New SqlConnection("server=ALLAN\ALLANBIL;database=esemka;Trusted_Connection=True")
    Public dbcmd As SqlCommand
    Public dbda As SqlDataAdapter
    Public dbdr As SqlDataReader
    Public dbds As DataSet
    Public dbdt As DataTable
    Public params As New List(Of SqlParameter)
    Public rc As Integer
    Public exce As String

    Public Sub New()

    End Sub
    Public Sub New(dbconstring As String)
        dbcon = New Sqlconnection(dbconstring)
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
        Dim dt As New DataTable
        Try
            dbcon.Open()
            dbcmd.CommandText = sql
            Dim da As New SqlDataAdapter(dbcmd)
            dbda.Fill(dt)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbcon.close
        End Try
        Return dt
    End Function
    Public Sub execquery(query As String, Optional ridentity As Boolean = False)

    End Sub
End Class