Public Class PackageForm
    Private sql As New SQuekDataContext
    Private inorup As String = "no"
    Private serviceid1 As Integer
    Private serviceid2 As Integer
    Sub loaddata()
        dgv1.DataSource = sql.Packages.Where(Function(x) x.IdService.ToString.Contains(SearchBox.Text) Or x.TotalUnit.ToString.Contains(SearchBox.Text) Or x.Price.ToString.Contains(SearchBox.Text))
    End Sub
    Sub loadcb()
        For Each r In sql.Services
            cbService.Items.Add(r.Name.ToString)
            cbService.Text = r.Name.ToString
        Next
    End Sub
    Private Sub packageForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
        loadcb()
        cleaning()
    End Sub
    Sub cleaning()
        numPrice.Value = 0
        numUnit.Value = 0
        txtId.Clear()
        dgv1.ClearSelection()
    End Sub
    Sub aktif()
        field1.Enabled = True
        btnUp.Enabled = False
        btnDown.Enabled = True
        dgv1.Enabled = False
    End Sub
    Sub noaktif()
        field1.Enabled = False
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
        If txtId.Text = "" Or numUnit.Value = 0 Or numPrice.Value = 0 Then
            MsgBox("Select any data first!")
        Else
            aktif()
            inorup = "up"
        End If
    End Sub
    Sub findnameservice()
        Dim services = sql.Services.Where(Function(x) x.Id = serviceid1)
        Dim services2 = services.FirstOrDefault(Function(x) x.Id = serviceid1)
        Dim getnameservice = services2.Name
        cbService.Text = getnameservice
    End Sub
    Sub findidservice()
        Dim services = sql.Services.Where(Function(x) x.Name = cbService.Text)
        Dim services2 = services.FirstOrDefault(Function(x) x.Name = cbService.Text)
        Dim getidservice = services2.Id
        serviceid2 = getidservice
    End Sub
    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        Dim i As Integer = dgv1.CurrentRow.Index
        txtId.Text = dgv1.Item(0, i).Value
        serviceid1 = dgv1.Item(1, i).Value
        numUnit.Value = dgv1.Item(2, i).Value
        numPrice.Value = dgv1.Item(3, i).Value
        findnameservice()
    End Sub

    Private Sub SearchBox_TextChanged(sender As Object, e As EventArgs) Handles SearchBox.TextChanged
        loaddata()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        cleaning()
        noaktif()
    End Sub
    Sub deletedata()
        Dim newpackage As New Package
        newpackage = sql.Packages.Single(Function(x) x.Id = txtId.Text)
        sql.Packages.DeleteOnSubmit(newpackage)
        sql.SubmitChanges()
        loaddata()
        cleaning()
        noaktif()
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtId.Text = "" Or txtId.Text = "New" Then
            MsgBox("Select any data first!")
        Else
            If MsgBox("Are you sure?", vbYesNo, vbCritical) = vbYes Then
                deletedata()
            End If
        End If
    End Sub
    Sub insertdata()
        Dim newpackage As New Package()
        newpackage.IdService = serviceid2
        newpackage.TotalUnit = numUnit.Value
        newpackage.Price = numPrice.Value
        sql.Packages.InsertOnSubmit(newpackage)
        sql.SubmitChanges()
        loaddata()
        cleaning()
        noaktif()
    End Sub

    Sub updatedata()
        Dim newpackage As New Package()
        newpackage = sql.Packages.Single(Function(x) x.Id = txtId.Text)
        newpackage.IdService = serviceid2
        newpackage.TotalUnit = numUnit.Value
        newpackage.Price = numPrice.Value
        sql.SubmitChanges()
        loaddata()
        cleaning()
        noaktif()
    End Sub

    Private Sub cbservice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbService.SelectedIndexChanged
        findidservice()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If numPrice.Value <= 0 Or numUnit.Value <= 0 Or cbService.Text = "" Then
            MsgBox("Fill blank field first!")
        Else
            If inorup = "in" Then
                insertdata()
            ElseIf inorup = "up" Then
                updatedata()
            End If
        End If
    End Sub
End Class
