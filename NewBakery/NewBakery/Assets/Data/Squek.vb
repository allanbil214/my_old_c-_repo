Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class Squek
    Private DBCon As New SqlConnection("server=desktop-sky6942\allanbil;database=newbakery;trusted_connection=true")
    Private DBCmd As SqlCommand
    Private DBDA As SqlDataAdapter
    Private DBDT As DataTable
    Private DBDS As DataSet
    Private Params As New List(Of SqlParameter)
    Private RC As Integer
    Private Cecep As String
    Public Sub New()
    End Sub
    Public Sub New(DBConString As String)
        DBCon = New SqlConnection(DBConString)
    End Sub
    Public Function HasConnect() As Boolean
        Try
            DBCon.Close()
            DBCon.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function
    Public Sub ExecQuery(Query As String)
        Try
            DBCon.Open()
            DBCmd = New SqlCommand(Query, DBCon)
            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))
            Params.Clear()
            DBDT = New DataTable
            DBDA = New SqlDataAdapter(DBCmd)
            RC = DBDA.Fill(DBDT)
        Catch ex As Exception
            Cecep = (ex.Message)
        Finally
            If DBCon.State = ConnectionState.Open Then DBCon.Close()
        End Try
    End Sub
    Public Sub AddParam(Text As String, Thing As Object)
        Dim NewParam As New SqlParameter(Text, Thing)
        Params.Add(NewParam)
    End Sub
    Public Function EmailFormat(Text As String)
        If Regex.IsMatch(Text, "^[a-z,A-Z,0-9]+@[a-z,A-Z,0-9]+[.]+[a-z,A-Z]") Then
            Return True
        End If
        Return False
    End Function
    Public Function PhoneFormat(Text As String)
        If Regex.IsMatch(Text, "^[0-9]") Then
            Return True
        End If
        Return False
    End Function
End Class
