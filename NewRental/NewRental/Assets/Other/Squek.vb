Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class Squek
    Private Dbcon As New SqlConnection("server=desktop-sky6942\allanbil;database=newrental;trusted_connection=true")
    Private Dbcmd As SqlCommand
    Private Dbda As SqlDataAdapter
    Private Dbdt As DataTable
    Private Dbds As DataSet
    Private Params As New List(Of SqlParameter)
    Private Rc As Integer
    Private Cecep As String
    Private Sub New()
    End Sub
    Private Sub New(dbconstring As String)
        Dbcon = New SqlConnection(dbconstring)
    End Sub
    Public Function Hasconnect() As Boolean
        Try
            Dbcon.Close()
            Dbcon.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function
    Public Sub Execquery(Query As String)
        Try
            Dbcon.Open()
            Dbcmd = New SqlCommand(Query, Dbcon)
            Params.ForEach(Sub(s) Dbcmd.Parameters.Add(s))
            Params.Clear()
            Dbdt = New DataTable
            Dbda = New SqlDataAdapter(Dbcmd)
            Rc = Dbda.Fill(Dbdt)
        Catch ex As Exception
            Cecep = (ex.Message)
        Finally
            If Dbcon.State = ConnectionState.Open Then Dbcon.Close()
        End Try
    End Sub
    Public Function Emailformat(Text As String) As Boolean
        If Regex.IsMatch(Text, "^[a-z,A-Z,0-9]+@[a-z,A-Z]+[.]+[a-z,A-Z]") Then
            Return True
        End If
        Return False
    End Function
    Public Function phoneformat(Text As String) As Boolean
        If Regex.IsMatch(Text, "^[0-9]") Then
            Return True
        End If
        Return False
    End Function
End Class
