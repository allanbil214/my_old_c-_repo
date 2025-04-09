Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Squek
    Private Dbcon As New SqlConnection("Server=Desktop-Sky6942\ALLANBIL;Database=Esemkabakery;Trusted_Connection=True")
    Public Dbcmd As SqlCommand
    Public Dbda As SqlDataAdapter
    Public Dbdt As DataTable
    Public Dbds As DataSet
    Public Params As New List(Of SqlParameter)
    Public Rc As Integer
    Public Cecep As String
    Public Sub New()
    End Sub
    Public Sub New(Dbconstring As String)
        Dbcon = New SqlConnection(Dbconstring)
    End Sub

    Public Function HasConnect() As Boolean
        Try
            Dbcon.Open()
            Dbcon.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function
    Public Sub ExecQuery(Query As String)
        Try
            Dbcon.Open()
            Dbcmd = New SqlCommand(Query, Dbcon)
            Params.ForEach(Sub(p) Dbcmd.Parameters.Add(p))
            Params.Clear()
            Dbdt = New DataTable
            Dbda = New SqlDataAdapter(Dbcmd)
            Rc = Dbda.Fill(Dbdt)
        Catch ex As Exception
            Cecep = ex.Message
        Finally
            If Dbcon.State = ConnectionState.Open Then Dbcon.Close()
        End Try
    End Sub
    Public Sub AddParam(text As String, thing As Object)
        Dim NewParam As New SqlParameter(text, thing)
        Params.Add(NewParam)
    End Sub
    Public Function EmailFormat(text As String) As Boolean
        If Regex.IsMatch(text, "^[a-z,A-Z,0-9]+@[a-z,A-Z,0-9]+[.]+[a-z,A-Z]") Then
            Return True
        End If
        Return False
    End Function
    Public Function PhoneFormat(text As String) As Boolean
        If Regex.IsMatch(text, "^[0-9]") Then Return True
        Return False
    End Function
End Class



