Public Class ViewRawMaterialStockForm
    Private sql As New Squek
    Private linq As New LinQDataContext
    Sub loaddata()
        DataGridView1.Rows.Clear()
        Dim i As Integer = 1
        For Each r In linq.RawMaterialIntakes
            For Each s In linq.IncomingRawMaterialDetails
                DataGridView1.Rows.Add(i, r.RawMaterial.RawMaterialName, r.IncomingRawMaterialHeader.IncomingDate, s.BestBeforeDate, r.WeightInGram)
                i += 1
            Next
        Next
    End Sub
    Private Sub ViewFoodStockForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("A")
        ComboBox1.Items.Add("D")
        ComboBox1.Text = "A"
        loaddata()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result = DataGridView1.Rows.Cast(Of DataGridViewRow).Where(Function(x) x.Cells("colStatus").Value.ToString.Contains(ComboBox1.Text))
        For Each r As DataGridViewRow In DataGridView1.Rows
            r.Visible = False
        Next
        For Each r As DataGridViewRow In result
            r.Visible = True
        Next
    End Sub
End Class
