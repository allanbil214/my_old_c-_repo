Public Class RawMaterialForm
    Private linq As New LinQDataContext
    Private sql As New Squek
    Private inorup As String = "no"
    Private changesmade As Boolean = False
    Sub LoadData()
        dgv1.Rows.Clear()
        Dim i As Integer = 1
        For Each r In linq.RawMaterials
            dgv1.Rows.Add(i, r.RawMaterialId, r.RawMaterialName, r.Description, r.Status, r.Employee.EmployeeName)
            i += 1
        Next
        TotalDataLabel.Text = "Total Data : " + linq.RawMaterials.Count.ToString
    End Sub
    Sub Cleaning()
        NotEditionMode()
        txtId.Text = "New"
        txtName.Clear()
        txtDesc.Clear()
        dgv1.ClearSelection()
    End Sub
    Private Sub RawMaterialsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                                                                  Or x.Cells("colDesc").Value.ToString.Contains(SearchBox.Text))
        For Each r As DataGridViewRow In dgv1.Rows
            r.Visible = False
        Next
        For Each r As DataGridViewRow In result
            r.Visible = True
        Next
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtDesc.Text = "" Or txtId.Text = "" Or txtName.Text = "" Or txtId.Text = "" Then
            MsgBox("Fill the field first!")
        Else
            Dim newRawMaterials As New RawMaterial
            newRawMaterials.RawMaterialName = txtName.Text
            newRawMaterials.Description = txtDesc.Text
            newRawMaterials.EmployeeId = LoginForm.empid
            newRawMaterials.InputedDate = Today
            newRawMaterials.Status = "A"
            linq.RawMaterials.InsertOnSubmit(newRawMaterials)
            dgv1.Rows.Add(dgv1.RowCount + 1, "New", txtName.Text, txtDesc.Text, "A", LoginForm.empname)
            Cleaning()
            changesmade = True
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
                EditingMode()
            End If
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtDesc.Text = "" Or txtId.Text = "" Or txtName.Text = "" Then
            MsgBox("Fill the field first!")
        Else
            Dim newRawMaterials As New RawMaterial
            newRawMaterials = linq.RawMaterials.Where(Function(x) x.RawMaterialId = txtId.Text).FirstOrDefault
            newRawMaterials.Description = txtDesc.Text
            newRawMaterials.RawMaterialName = txtName.Text
            newRawMaterials.EmployeeId = LoginForm.empid
            newRawMaterials.InputedDate = Today
            newRawMaterials.Status = "A"
            Dim row As DataGridViewRow = dgv1.Rows.Cast(Of DataGridViewRow).FirstOrDefault(Function(x) x.Cells("colId").Value = txtId.Text)
            row.Cells("colName").Value = newRawMaterials.RawMaterialName
            row.Cells("colDesc").Value = newRawMaterials.Description
            row.Cells("colStatus").Value = newRawMaterials.Status
            row.Cells("colEmpName").Value = LoginForm.empname
            Cleaning()
            changesmade = True
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgv1.RowCount > 0 Then
            Dim r As DataGridViewRow = dgv1.CurrentRow
            If r.Cells("colId").Value.ToString <> "New" Then
                If MsgBox("Delete?", vbYesNo) = vbYes Then
                    Dim newRawMaterials As RawMaterial = linq.RawMaterials.Where(Function(x) x.RawMaterialId = Convert.ToInt32(r.Cells("colId").Value)).FirstOrDefault()
                    Dim row As DataGridViewRow = dgv1.Rows.Cast(Of DataGridViewRow)().FirstOrDefault(Function(x) x.Cells("colId").Value.ToString() = txtId.Text)
                    newRawMaterials.Status = "D"
                    Cleaning()
                    row.Cells("colStatus").Value = newRawMaterials.Status
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
