Imports System.Data.SqlClient
Public Class Squek
    Private dbcon As New SqlConnection("SERVER=ALLAN\ALLANBIL;Database=Rental;Trusted_Connection=True")
    Public dbcmd As SqlCommand
    Public dbda As SqlDataAdapter
    Public dbdt As DataTable
    Public dbds As DataSet
    Public dbdr As SqlDataReader
    Public params As New List(Of SqlParameter)
    Public rekorcount As Integer
    Public kecualii As String
    Public Sub New()
    End Sub
    Public Sub New(dbconstring As String)
        dbcon = New SqlConnection(dbconstring)
    End Sub
    Public Function hasconnection() As Boolean
        Try
            dbcon.Open()
            dbcon.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function
    Public Function seQuery(sql As String) As DataTable
        Dim dt As New DataTable
        Try
            dbcon.Open()
            dbcmd.CommandText = sql
            Dim datadap As New SqlDataAdapter(dbcmd)
            dbda.Fill(dt)
        Catch ex As Exception
            MsgBox(ex.Message, "Error")
        Finally
            dbcon.Close()
        End Try
        Return dt
    End Function
    Public Sub execquery(query As String, Optional ridentiti As Boolean = False)
        rekorcount = 0
        kecualii = ""
        Try
            dbcon.Open()
            dbcmd = New SqlCommand(query, dbcon)
            params.ForEach(Sub(p) dbcmd.Parameters.Add(p))
            params.Clear()
            dbdt = New DataTable
            dbda = New SqlDataAdapter(dbcmd)
            rekorcount = dbda.Fill(dbdt)
            If ridentiti = True Then
                Dim QueryBack As String = "SELECT @Identity as lastid;"
                dbcmd = New SqlCommand(QueryBack, dbcon)
                dbdt = New DataTable
                dbda = New SqlDataAdapter(dbcmd)
                rekorcount = dbda.Fill(dbdt)
            End If
        Catch ex As Exception
            kecualii = "PerintahQuery:" & vbNewLine & ex.Message
        Finally
            If dbcon.State = ConnectionState.Open Then dbcon.Close()
        End Try
    End Sub
    Public Sub addparam(Nama As String, Harga As Object)
        Dim ParamAnyar As New SqlParameter(Nama, Harga)
        params.Add(ParamAnyar)
    End Sub
    Public Function adakecuali(Optional Lapor As Boolean = False) As Boolean
        If String.IsNullOrEmpty(kecualii) Then Return False
        If Lapor = True Then MsgBox(kecualii, MsgBoxStyle.Critical, "eRrOr!")
        Return True
    End Function
    Public Sub addpicparam(Nama As String, Harga As Object)
        Dim ParamAnyar As New SqlParameter(Nama, Harga)
        params.Add(ParamAnyar)
    End Sub
    Public Sub runquery(Query As String)
        Try
            dbcon.Open()
            dbcmd = New SqlCommand(Query, dbcon)
            dbda = New SqlDataAdapter(dbcmd)
            dbds = New DataSet
            dbda.Fill(dbds)
            dbcon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            If dbcon.State = ConnectionState.Open Then
                dbcon.Close()
            End If
        End Try
    End Sub
End Class

