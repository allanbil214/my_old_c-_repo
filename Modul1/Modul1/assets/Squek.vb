Imports System.Data.SqlClient
Public Class Squek
    Private dbcon As New SqlConnection("server=ALLAN\ALLANBIL;database=esemka;Trusted_Connection=True")
    Public dbcmd As SqlCommand
    Public dbda As SqlDataAdapter
    Public dbdr As SqlDataReader
    Public dbdt As DataTable
    Public dbds As DataSet
    Public params As New List(Of SqlParameter)
    Public rc As Integer
    Public exce As String
    Public Sub New()
    End Sub
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
    Public Sub execquery(query As String, Optional ridentity As Boolean = False)
        rc = 0
        exce = ""
        Try
            dbcon.Open()
            dbcmd = New SqlCommand(query, dbcon)
            params.ForEach(Sub(p) dbcmd.Parameters.Add(p))
            params.Clear()
            dbdt = New DataTable
            dbda = New SqlDataAdapter(dbcmd)
            rc = dbda.Fill(dbdt)
            If ridentity = True Then
                Dim queryback As String = "select @identity as lastid"
                dbcmd = New SqlCommand(queryback, dbcon)
                dbdt = New DataTable
                dbda = New SqlDataAdapter(dbcmd)
                rc = dbda.Fill(dbdt)
            End If
        Catch ex As Exception
            exce = "execquery error:" & vbNewLine & ex.Message
        Finally
            If dbcon.State = ConnectionState.Open Then dbcon.Close()
        End Try
    End Sub
    Public Sub addparam(name As String, thing As Object)
        Dim newparam As New SqlParameter(name, thing)
        params.Add(newparam)
    End Sub
    Public Function hasexception(Optional report As Boolean = False) As Boolean
        If String.IsNullOrEmpty(exce) Then Return False
        If report = True Then MsgBox(exce, MsgBoxStyle.Critical, "error")
        Return True
    End Function
End Class