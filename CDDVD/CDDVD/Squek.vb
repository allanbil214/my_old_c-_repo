Imports System.Data.SqlClient
Public Class Squek
    Private Konek As New SqlConnection("SERVER=ALLAN\ALLANBIL;Database=CDDVD;Trusted_Connection=True")
    Public SPerintah As SqlCommand
    Public SAdapter As SqlDataAdapter
    Public STabel As DataTable
    Public SSet As DataSet
    Public SReader As SqlDataReader
    Public SParam As New List(Of SqlParameter)
    Public ItungRekor As Integer
    Public Kecualii As String
    Public Sub New()
    End Sub
    Public Sub New(StringKoneksi As String)
        Konek = New SqlConnection(StringKoneksi)
    End Sub
    Public Function PunyaKoneksi() As Boolean
        Try
            Konek.Open()
            Konek.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function
    Public Function seQuery(sql As String) As DataTable
        Dim dt As New DataTable
        Try
            Konek.Open()
            SPerintah.CommandText = sql
            Dim datadap As New SqlDataAdapter(SPerintah)
            SAdapter.Fill(dt)
        Catch ex As Exception
            MsgBox(ex.Message, "Error")
        Finally
            Konek.Close()
        End Try
        Return dt
    End Function
    Public Sub PerintahQuery(Query As String, Optional RIdentiti As Boolean = False)
        ItungRekor = 0
        Kecualii = ""
        Try
            Konek.Open()
            SPerintah = New SqlCommand(Query, Konek)
            SParam.ForEach(Sub(p) SPerintah.Parameters.Add(p))
            SParam.Clear()
            STabel = New DataTable
            SAdapter = New SqlDataAdapter(SPerintah)
            ItungRekor = SAdapter.Fill(STabel)
            If RIdentiti = True Then
                Dim QueryBack As String = "SELECT @Identity as lastid;"
                SPerintah = New SqlCommand(QueryBack, Konek)
                STabel = New DataTable
                SAdapter = New SqlDataAdapter(SPerintah)
                ItungRekor = SAdapter.Fill(STabel)
            End If
        Catch ex As Exception
            Kecualii = "PerintahQuery:" & vbNewLine & ex.Message
        Finally
            If Konek.State = ConnectionState.Open Then Konek.Close()
        End Try
    End Sub
    Public Sub PlusParam(Nama As String, Harga As Object)
        Dim ParamAnyar As New SqlParameter(Nama, Harga)
        SParam.Add(ParamAnyar)
    End Sub
    Public Function AdaKecuali(Optional Lapor As Boolean = False) As Boolean
        If String.IsNullOrEmpty(Kecualii) Then Return False
        If Lapor = True Then MsgBox(Kecualii, MsgBoxStyle.Critical, "eRrOr!")
        Return True
    End Function
    Public Sub GambarPlus(Nama As String, Harga As Object)
        Dim ParamAnyar As New SqlParameter(Nama, Harga)
        SParam.Add(ParamAnyar)
    End Sub
    Public Sub JalanQuery(Query As String)
        Try
            Konek.Open()
            SPerintah = New SqlCommand(Query, Konek)
            SAdapter = New SqlDataAdapter(SPerintah)
            SSet = New DataSet
            SAdapter.Fill(SSet)
            Konek.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            If Konek.State = ConnectionState.Open Then
                Konek.Close()
            End If
        End Try
    End Sub
End Class
