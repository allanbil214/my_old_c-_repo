Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class Squek
    Private dbcon As New SqlConnection("server=DESKTOP-SKY6942\ALLANBIL;database=SkyRent;Trusted_Connection=True")
    Public dbcmd As SqlCommand
    Public dbda As SqlDataAdapter
    Public dbdt As DataTable
    Public dbds As DataSet
    Public params As New List(Of SqlParameter)
    Public rc As Integer
    Public excep As String
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
        Try
            dbcon.Open()
            dbcmd = New SqlCommand(query, dbcon)
            params.ForEach(Sub(p) dbcmd.Parameters.Add(p))
            params.Clear()
            dbdt = New DataTable
            dbda = New SqlDataAdapter(dbcmd)
            rc = dbda.Fill(dbdt)
        Catch ex As Exception
            excep = ex.Message
        Finally
            If dbcon.State = ConnectionState.Open Then dbcon.Close()
        End Try
    End Sub
    Public Function hasexception(Optional thing As Boolean = False) As Boolean
        If String.IsNullOrEmpty(excep) Then Return False
        If thing = True Then MsgBox("Query Error : " + excep, vbCritical, "Error")
        Return True
    End Function
    Public Sub addparam(text As String, thing As Object)
        Dim newparam As New SqlParameter(text, thing)
        params.Add(newparam)
    End Sub
    Public Function emailformat(text As String) As Boolean
        If Regex.IsMatch(text, "[a-z,A-Z,0-9]+@[a-z,A-Z]+.[a-z,A-Z]") Then
            Return True
        End If
        Return False
    End Function
End Class