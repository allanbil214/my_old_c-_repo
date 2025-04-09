Public Class test
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DataGridView1.RowCount > 0 Then
            For x As Integer = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Rows(x).Cells(0).Value = TextBox1.Text Then
                    DataGridView1.Rows(x).Cells(3).Value = Val(Convert.ToInt32(DataGridView1.Rows(x).Cells(3).Value) + TextBox4.Text)
                Else
                    Dim row As String() = New String() {TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text}
                    DataGridView1.Rows.Add(row)
                End If
            Next
        Else
            Dim row As String() = New String() {TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text}
            DataGridView1.Rows.Add(row)
        End If
    End Sub

    Private Sub test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Columns.Add("kolom1", "Kolom 1")
        DataGridView1.Columns.Add("kolom2", "Kolom 2")
        DataGridView1.Columns.Add("kolom3", "Kolom 3")
        DataGridView1.Columns.Add("kolom4", "Kolom 4")

    End Sub
End Class