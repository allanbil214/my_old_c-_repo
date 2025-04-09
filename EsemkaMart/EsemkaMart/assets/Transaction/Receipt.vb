Imports System.ComponentModel

Public Class Receipt
    Dim nulltext As String = ""
    Dim nulltext2 As String = ""
    Dim diskontext As String = "Diskon"
    Public yousafe As String = Payment.yousafe
    Private Sub nganu()
        dgv1.ColumnCount = 3
        For Each Col As DataGridViewColumn In Transaction.dgvhid.Columns
            dgv1.Columns.Add(DirectCast(Col.Clone, DataGridViewColumn))
        Next
        For rowIndex As Integer = 0 To (Transaction.dgvhid.Rows.Count - 1)
            dgv1.Rows.Add(Transaction.dgvhid.Rows(rowIndex).Cells.Cast(Of DataGridViewCell).Select(Function(c) c.Value).ToArray)
        Next
        Dim rowhid As String() = New String() {nulltext, nulltext2, diskontext, -yousafe}
        dgv1.Rows.Add(rowhid)
    End Sub
    Private Sub Receipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv1.Columns.Clear()
        Label7.Text = Payment.trxid
        Label6.Text = Payment.dater
        Label11.Text = Payment.discount.Text
        Label12.Text = Payment.total.Text
        Label13.Text = -Payment.yousafe
        nganu()
    End Sub

    Private Sub Receipt_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Payment.Close()
        Transaction.dgv1.Columns.Clear()
        Transaction.coalescemax()
    End Sub
End Class