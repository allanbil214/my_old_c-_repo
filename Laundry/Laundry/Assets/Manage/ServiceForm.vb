Public Class ServiceForm
    Private sql As New SQuekDataContext
    Private inorup As String = "no"
    Private catid1 As Integer
    Private catid2 As Integer
    Private unitid1 As Integer
    Private unitid2 As Integer
    Sub loaddata()
        dgv1.DataSource = sql.Services.Where(Function(x) x.Name.ToString.Contains(SearchBox.Text) Or x.IdCategory.ToString.Contains(SearchBox.Text) Or x.IdUnit.ToString.Contains(SearchBox.Text) Or x.PriceUnit.ToString.Contains(SearchBox.Text))
    End Sub
    Sub loadcbcategory()
        For Each r In sql.Categories
            cbCategory.Items.Add(r.Name.ToString)
            cbCategory.Text = r.Name.ToString
        Next
    End Sub
    Sub loadcbunit()
        For Each r In sql.Units
            cbUnit.Items.Add(r.Name.ToString)
            cbUnit.Text = r.Name.ToString
        Next
    End Sub
    Private Sub serviceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
        loadcbunit()
        loadcbcategory()
        cleaning()
    End Sub
    Sub cleaning()
        numDuration.Value = 0
        numPrice.Value = 0
        txtId.Clear()
        txtName.Clear()
        dgv1.ClearSelection()
    End Sub
    Sub aktif()
        field1.Enabled = True
        field2.Enabled = True
        btnUp.Enabled = False
        btnDown.Enabled = True
        dgv1.Enabled = False
    End Sub
    Sub noaktif()
        field1.Enabled = False
        field2.Enabled = False
        btnUp.Enabled = True
        btnDown.Enabled = False
        dgv1.Enabled = True
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        aktif()
        cleaning()
        inorup = "in"
        txtId.Text = "New"
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtName.Text = "" Then
            MsgBox("Select any data first!")
        Else
            aktif()
            inorup = "up"
        End If
    End Sub
    Sub findnamecategory()
        Dim cat = sql.Categories.Where(Function(x) x.Id = catid1)
        Dim cat2 = cat.FirstOrDefault(Function(x) x.Id = catid1)
        Dim getnamecat = cat2.Name
        cbCategory.Text = getnamecat
    End Sub
    Sub findnameunit()
        Dim unit = sql.Units.Where(Function(x) x.Id = unitid1)
        Dim unit2 = unit.FirstOrDefault(Function(x) x.Id = unitid1)
        Dim getnameunit = unit2.Name
        cbUnit.Text = getnameunit
    End Sub
    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        Dim i As Integer = dgv1.CurrentRow.Index
        txtId.Text = dgv1.Item(0, i).Value
        txtName.Text = dgv1.Item(1, i).Value
        catid1 = dgv1.Item(2, i).Value
        unitid1 = dgv1.Item(3, i).Value
        numPrice.Value = dgv1.Item(4, i).Value
        numDuration.Value = dgv1.Item(5, i).Value
        findnamecategory()
        findnameunit()
    End Sub

    Private Sub SearchBox_TextChanged(sender As Object, e As EventArgs) Handles SearchBox.TextChanged
        loaddata()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        cleaning()
        noaktif()
    End Sub
    Sub deletedata()
        Dim newservice As New Service
        newservice = sql.Services.Single(Function(x) x.Id = txtId.Text)
        sql.Services.DeleteOnSubmit(newservice)
        sql.SubmitChanges()
        loaddata()
        cleaning()
        noaktif()
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtName.Text = "" Then
            MsgBox("Select any data first!")
        Else
            If MsgBox("Are you sure?", vbYesNo, vbCritical) = vbYes Then
                deletedata()
            End If
        End If
    End Sub
    Sub insertdata()
        Dim newservice As New Service()
        newservice.Name = txtName.Text
        newservice.IdCategory = catid2
        newservice.IdUnit = unitid2
        newservice.PriceUnit = numPrice.Value
        newservice.EstimationDuration = numDuration.Value
        sql.Services.InsertOnSubmit(newservice)
        sql.SubmitChanges()
        loaddata()
        cleaning()
        noaktif()
    End Sub

    Sub updatedata()
        Dim newservice As New Service()
        newservice = sql.Services.Single(Function(x) x.Id = txtId.Text)
        newservice.Name = txtName.Text
        newservice.IdCategory = catid2
        newservice.IdUnit = unitid2
        newservice.PriceUnit = numPrice.Value
        newservice.EstimationDuration = numDuration.Value
        sql.SubmitChanges()
        loaddata()
        cleaning()
        noaktif()
    End Sub
    Sub findcatid()
        Dim cat = sql.Categories.Where(Function(x) x.Name = cbCategory.Text)
        Dim cat2 = cat.FirstOrDefault(Function(x) x.Name = cbCategory.Text)
        Dim getidcat = cat2.Id
        catid2 = getidcat
    End Sub
    Sub findunitid()
        Dim unit = sql.Units.Where(Function(x) x.Name = cbUnit.Text)
        Dim unit2 = unit.FirstOrDefault(Function(x) x.Name = cbUnit.Text)
        Dim getunitid = unit2.Id
        unitid2 = getunitid
    End Sub
    Private Sub cbJob_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCategory.SelectedIndexChanged
        findcatid()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtName.Text = "" Or cbCategory.Text = "" Or cbUnit.Text = "" Or numDuration.Value <= 0 Or numPrice.Value <= 0 Then
            MsgBox("Fill blank field first!")
        Else
            If inorup = "in" Then
                insertdata()
            ElseIf inorup = "up" Then
                updatedata()
            End If
        End If
    End Sub

    Private Sub cbUnit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbUnit.SelectedIndexChanged
        findunitid()
    End Sub
End Class
