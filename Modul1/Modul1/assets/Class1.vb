Imports System.Data.SqlClient
Public Class Class1
    Public dbcon As New SqlConnection("server=ALLAN\ALLANBIL;database=esemka;Trusted_Connection=True")
    Public dbcmd As SqlCommand
    Public dbda As SqlDataAdapter
    Public dbdr As SqlDataReader
    Public dbds As DataSet
    Public dbdt As DataTable
    Public params As New List(Of SqlParameter)
    Public rc As Integer
    Public exce As String
End Class