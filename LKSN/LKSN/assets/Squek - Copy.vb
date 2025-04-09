Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class Squek
    Private dbcon As New SqlConnection("server=ALLAN\ALLANBIL;database=PC_NGANU;Trusted_Connection=True")
    Public dbcmd As SqlCommand
    Public dbda As SqlDataAdapter
    Public dbdt As DataTable
    Public dbds As DataSet
    Public params As New List(Of SqlParameter)
    Public rc As Integer
    Public except As String
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
        except = ""
        Try
            dbcon.Open()
            dbcmd = New SqlCommand(query, dbcon)
            params.ForEach(Sub(p) dbcmd.Parameters.Add(p))
            params.Clear()
            dbdt = New DataTable
            dbda = New SqlDataAdapter(dbcmd)
            rc = dbda.Fill(dbdt)
        Catch ex As Exception
            except = "query error:" & ex.Message & vbNewLine
        Finally
            If dbcon.State = ConnectionState.Open Then dbcon.Close()
        End Try
    End Sub
    Public Sub addparam(name As String, thing As Object)
        Dim newparam As New SqlParameter(name, thing)
        params.Add(newparam)
    End Sub
    Public Function hasexception(Optional report As Boolean = False) As Boolean
        If String.IsNullOrEmpty(except) Then Return False
        If report = True Then MsgBox(except, MsgBoxStyle.Critical, "error")
        Return True
    End Function
    Function emailformat(email As String) As Boolean
        If Regex.IsMatch(email, "^[a-z,A-Z,0-9]+@[a-z,A-Z,0-9]+") Then
            Return True
        End If
        Return False
    End Function
    Function phoneformat(phone As String) As Boolean
        If Regex.IsMatch(phone, "^[0-9]+-[0-9]+-[0-9]") Then
            Return True
        End If
        Return False
    End Function
End Class