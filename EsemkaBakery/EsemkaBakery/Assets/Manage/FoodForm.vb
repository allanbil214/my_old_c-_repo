Public Class FoodForm
    Private linq As New LinQDataContext
    Private sql As New Squek
    Private inorup As String = "no"
    Private changesmade As Boolean = False
    Sub LoadData()
        dgv1.Rows.Clear()
        Dim i As Integer = 1
        For Each r In linq.Foods
            dgv1.Rows.Add(i, r.FoodId, r.FoodName, r.Description, r.Price, r.Status)
            i += 1
        Next
        TotalDataLabel.Text = "Total Data : " + linq.Foods.Count.ToString
    End Sub
    Sub Cleaning()
        NotEditionMode()
        txtId.Text = "New"
        txtName.Clear()
        txtPrice.Clear()
        txtDesc.Clear()
        dgv1.ClearSelection()
    End Sub
    Private Sub FoodForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        Cleaning()
    End Sub
    Sub EditingMode()
        btnEdit.Enabled = True
        btnDelete.Enabled = True
    End Sub
    Sub NotEditionMode()
        btnEdit.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Dim result = dgv1.Rows.Cast(Of DataGridViewRow).Where(Function(x) x.Cells("colName").Value.ToString.Contains(SearchBox.Text) _
                                                                  Or x.Cells("colDesc").Value.ToString.Contains(SearchBox.Text) _
                                                                  Or x.Cells("colPrice").Value.ToString.Contains(SearchBox.Text))
        For Each r As DataGridViewRow In dgv1.Rows
            r.Visible = False
        Next
        For Each r As DataGridViewRow In result
            r.Visible = True
        Next
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtDesc.Text = "" Or txtPrice.Text = "" Or txtId.Text = "" Or txtName.Text = "" Or txtId.Text = "" Then
            MsgBox("Fill the field first!")
        Else
            If sql.PhoneFormat(txtPrice.Text) = False Then
                MsgBox("Invalid Price Format")
            Else
                Dim newfood As New Food
                newfood.FoodName = txtName.Text
                newfood.Description = txtDesc.Text
                newfood.Price = txtPrice.Text
                newfood.Status = "A"
                linq.Foods.InsertOnSubmit(newfood)
                dgv1.Rows.Add(dgv1.RowCount + 1, "New", txtName.Text, txtDesc.Text, txtPrice.Text, "A")
                Cleaning()
                changesmade = True
            End If
        End If
    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        If e.RowIndex >= 0 Then
            Dim r As DataGridViewRow = dgv1.CurrentRow
            If r.Cells(1).Value.ToString() <> "New" Then
                Dim i As Integer = dgv1.CurrentRow.Index
                txtId.Text = dgv1.Item("colId", i).Value
                txtName.Text = dgv1.Item("colName", i).Value
                txtDesc.Text = dgv1.Item("colDesc", i).Value
                txtPrice.Text = dgv1.Item("colPrice", i).Value
                EditingMode()
            End If
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtDesc.Text = "" Or txtPrice.Text = "" Or txtId.Text = "" Or txtName.Text = "" Then
            MsgBox("Fill the field first!")
        Else
            If sql.PhoneFormat(txtPrice.Text) = False Then
                MsgBox("Invalid Price Format")
            Else
                Dim newfood As New Food
                    newfood = linq.Foods.Where(Function(x) x.FoodId = txtId.Text).FirstOrDefault
                    newfood.Description = txtDesc.Text
                    newfood.Price = txtPrice.Text
                    newfood.FoodName = txtName.Text
                    newfood.Status = "A"
                    Dim row As DataGridViewRow = dgv1.Rows.Cast(Of DataGridViewRow).FirstOrDefault(Function(x) x.Cells("colId").Value = txtId.Text)
                    row.Cells("colName").Value = newfood.FoodName
                    row.Cells("colDesc").Value = newfood.Description
                    row.Cells("colPrice").Value = newfood.Price
                    row.Cells("colStatus").Value = newfood.Status
                    Cleaning()
                changesmade = True
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgv1.RowCount > 0 Then
            Dim r As DataGridViewRow = dgv1.CurrentRow
            If r.Cells("colId").Value.ToString <> "New" Then
                If MsgBox("Delete?", vbYesNo) = vbYes Then
                    Dim newfood As Food = linq.Foods.Where(Function(x) x.FoodId = Convert.ToInt32(r.Cells("colId").Value)).FirstOrDefault()
                    Dim row As DataGridViewRow = dgv1.Rows.Cast(Of DataGridViewRow)().FirstOrDefault(Function(x) x.Cells("colId").Value.ToString() = txtId.Text)
                    newfood.Status = "D"
                    Cleaning()
                    row.Cells("colStatus").Value = newfood.Status
                    changesmade = True
                End If
            Else
                dgv1.Rows.Remove(r)
                Cleaning()
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        linq.SubmitChanges()
        Cleaning()
        LoadData()
        changesmade = False
    End Sub
    Private Sub cancelall()
        linq = New LinQDataContext()
        Cleaning()
        LoadData()
        changesmade = False
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If changesmade Then
            If MsgBox("Cancel?", vbYesNo) = vbYes Then
                cancelall()
            End If
        Else
            cancelall()
        End If
    End Sub
End Class
