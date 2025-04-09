Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class Class1
    Private dbcon As New SqlConnection("server=desktop-sky6942;database=newbakery;trusted_connection=true")
    Private dbcmd As SqlCommand
    Private dbda As SqlDataAdapter
    Private dbdt As DataTable
    Private dbds As DataSet
    Private params As New List(Of SqlParameter)
    Private rc As Integer
    Private cecep As String
    Public Sub New()
    End Sub
    Public Sub New(dbconstring As String)
        dbcon = New SqlConnection(dbconstring)
    End Sub
    Public Function hasconnect() As Boolean
        Try
            dbcon.Open()
            dbcon.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function
    Public Sub execquery(text As String)
        Try
            dbcon.Open()
            dbcmd = New SqlCommand(text, dbcon)
            params.ForEach(Sub(p) dbcmd.Parameters.Add(p))
            params.Clear()
            dbdt = New DataTable
            dbda = New SqlDataAdapter(dbcmd)
            rc = dbda.Fill(dbdt)
        Catch ex As Exception
            cecep = ex.Message
        Finally
            If dbcon.State = ConnectionState.Open Then dbcon.Close()
        End Try
    End Sub
    Public Sub addparam(text As String, thing As Object)
        Dim newparam As New SqlParameter(text, thing)
        params.Add(newparam)
    End Sub
    Public Function emailformat(text As String) As Boolean
        If Regex.IsMatch(text, "^[a-z,A-Z,0-9]+@[a-z,A-Z,0-9]+[.]+[a-z,A-Z]") Then
            Return True
        End If
        Return False
    End Function
    Public Function phoneformat(text As String) As Boolean
        If Regex.IsMatch(text, "^[0-9]") Then
            Return True
        End If
        Return False
    End Function
End Class