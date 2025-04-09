Public Class RawMaterialForm
    Private sql As New SquekingDataContext
    Private squek As New Squek
    Private inorup As String = "no"
    Sub loaddata()
        dgv1.DataSource = sql.RawMaterials.Where(Function(x) x.RawMaterialName.ToString.Contains(SearchBox.Text) _
                                              Or x.Description.ToString.Contains(SearchBox.Text) _
                                              Or x.InputedDate.ToString.Contains(SearchBox.Text))
        lblTotalData.Text = "Total Data : " + sql.RawMaterials.Count.ToString
    End Sub
    Private Sub rawmaterialForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        loaddata()
    End Sub
    Sub cleaning()
        txtId.Clear()
        txtName.Clear()
        txtDesc.Clear()
        txtName.Select()
    End Sub
    Sub activateCRUD()
        dgv1.Enabled = False
        TableButtonDown.Enabled = True
        TableButtonUp.Enabled = False
        TableData.Enabled = True
    End Sub
    Sub deactiveCRUD()
        dgv1.Enabled = True
        TableButtonDown.Enabled = False
        TableButtonUp.Enabled = True
        TableData.Enabled = False
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        activateCRUD()
        cleaning()
        txtId.Text = "New"
        inorup = "in"
    End Sub

    Private Sub dgv1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        Dim i As Integer = dgv1.CurrentRow.Index
        txtId.Text = dgv1.Item(0, i).Value
        txtName.Text = dgv1.Item(1, i).Value
        txtDesc.Text = dgv1.Item(2, i).Value
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtName.Text = "" Then
            MsgBox("Select data first!")
        Else
            activateCRUD()
            inorup = "up"
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        deactiveCRUD()
        cleaning()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtName.Text = "" Then
            MsgBox("select data first!")
        Else
            If MsgBox("Delete?", vbYesNo) = vbYes Then
                Dim newrawmaterial As New RawMaterial
                newrawmaterial = sql.RawMaterials.Single(Function(x) x.RawMaterialId = txtId.Text)
                newrawmaterial.Status = "D"
                sql.SubmitChanges()
            End If
        End If
    End Sub
    Sub insertdata()
        Dim newrawmaterial As New RawMaterial
        newrawmaterial.Description = txtDesc.Text
        newrawmaterial.EmployeeId = LoginForm.eid
        newrawmaterial.InputedDate = Today
        newrawmaterial.RawMaterialName = txtName.Text
        newrawmaterial.Status = "A"
        sql.RawMaterials.InsertOnSubmit(newrawmaterial)
        sql.SubmitChanges()
    End Sub
    Sub updatedata()
        Dim newrawmaterial As New RawMaterial
        newrawmaterial = sql.RawMaterials.Single(Function(x) x.RawMaterialId = txtId.Text)
        newrawmaterial.Description = txtDesc.Text
        newrawmaterial.EmployeeId = LoginForm.eid
        newrawmaterial.InputedDate = Today
        newrawmaterial.RawMaterialName = txtName.Text
        newrawmaterial.Status = "A"
        sql.SubmitChanges()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtDesc.Text = "" Or txtId.Text = "" Or txtName.Text = "" Then
            MsgBox("Fill all the field first!")
        Else
            If inorup = "in" Then
                insertdata()
                cleaning()
                loaddata()
                deactiveCRUD()
            ElseIf inorup = "up" Then
                updatedata()
                cleaning()
                loaddata()
                deactiveCRUD()
            End If
        End If
    End Sub
End Class
