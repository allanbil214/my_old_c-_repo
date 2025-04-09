Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class Squek
    Private dbcon As New SqlConnection("server=desktop-sky6942\ALLANBIL;database=Rental;trusted_connection=true")
    Public dbcmd As SqlCommand
    Public dbda As SqlDataAdapter
    Public dbdt As DataTable
    Public dbds As DataSet
    Public params As New List(Of SqlParameter)
    Public rc As Integer
    Public cecep As String
    Public Sub New()
    End Sub
    Public Sub New(dbconstring As String)
        dbcon = New SqlConnection(dbconstring)
    End Sub
    Public Function isconnect() As Boolean
        Try
            dbcon.Close()
            dbcon.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function
    Public Sub execquery(query As String)
        rc = 0
        cecep = ""
        Try
            dbcon.Open()
            dbcmd = New SqlCommand(query, dbcon)
            params.ForEach(Sub(p) dbcmd.Parameters.Add(p))
            params.Clear()
            dbdt = New DataTable
            dbda = New SqlDataAdapter(dbcmd)
            rc = dbda.Fill(dbdt)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If dbcon.State = ConnectionState.Open Then dbcon.Close()
        End Try
    End Sub
    Public Sub addparam(text As String, thing As Object)
        Dim newparam As New SqlParameter(text, thing)
        params.Add(newparam)
    End Sub
    Public Function isemailformat(text As String)
        If Regex.IsMatch(text, "[a-z,A-Z,0-9]+@[a-z,A-Z]+.com") Then Return True
        Return False
    End Function
End Class
