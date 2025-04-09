Public Class recipeForm
    Private linq As New LinQDataContext
    Private sql As New Squek
    Private inorup As String = "no"
    Private changesmade As Boolean = False
    Private recipeid As Integer
    Private rawmaterialid As Integer
    Sub LoadData()
        dgv1.Rows.Clear()
        Dim i As Integer = 1
        For Each r In linq.RecipeHeaders
            dgv1.Rows.Add(i, r.RecipeId, r.FoodId, r.OutputUnitInPieces, r.Description, r.CreatedDate, r.Status)
            i += 1
        Next
        TotalDataLabel.Text = "Total Data : " + linq.RecipeHeaders.Count.ToString
    End Sub
    Sub LoadData2()
        s.Rows.Clear()
        Dim i As Integer = 1
        For Each r In linq.RecipeDetails
            s.Rows.Add(i, r.RecipeId, r.RawMaterialId, r.WeightInGram)
            i += 1
        Next
    End Sub
    Sub loadcbFood()
        sql.ExecQuery("select * from food where not Status='D'")
        For Each r As DataRow In sql.Dbdt.Rows
            cbFoodName.Items.Add(r("FoodName"))
        Next
    End Sub
    Sub loadcbRaw()
        sql.ExecQuery("select * from RawMaterial where not Status='D'")
        For Each r As DataRow In sql.Dbdt.Rows
            cbRawName.Items.Add(r("RawMaterialName"))
        Next
    End Sub
    Sub Cleaning()
        NotEditionMode()
        txtFoodId.Clear()
        txtFoodUnit.Clear()
        txtFoodDesc.Clear()
        dgv1.ClearSelection()
    End Sub
    Private Sub FoodForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        LoadData2()
        Cleaning()
        loadcbFood()
        loadcbRaw()
    End Sub
    Sub EditingMode()
        btnEditFood.Enabled = True
        btnDeleteFood.Enabled = True
        btnEditRaw.Enabled = True
        btnDeleteRaw.Enabled = True
    End Sub
    Sub NotEditionMode()
        btnEditFood.Enabled = False
        btnDeleteFood.Enabled = False
        btnEditRaw.Enabled = False
        btnDeleteRaw.Enabled = False
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

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAddFood.Click
        If txtFoodDesc.Text = "" Or txtFoodUnit.Text = "" Then
            MsgBox("Fill the field first!")
        Else
            If sql.PhoneFormat(txtFoodUnit.Text) = False Then
                MsgBox("Invalid Unit Format")
            Else
                Dim newfoodforrecipeheader As New RecipeHeader
                newfoodforrecipeheader.FoodId = txtFoodId.Text
                newfoodforrecipeheader.Description = "Production Of " + cbFoodName.Text
                newfoodforrecipeheader.OutputUnitInPieces = txtFoodUnit.Text
                newfoodforrecipeheader.EmployeeId = LoginForm.empid
                newfoodforrecipeheader.CreatedDate = Today
                newfoodforrecipeheader.Status = "A"
                linq.RecipeHeaders.InsertOnSubmit(newfoodforrecipeheader)
                dgv1.Rows.Add(dgv1.RowCount + 1, "New", txtFoodId.Text, txtFoodUnit.Text, txtFoodDesc.Text, LoginForm.empid, Today, "A")
                Cleaning()
                changesmade = True
            End If
        End If
    End Sub
    Sub findnamefood()
        sql.AddParam("@id", txtFoodId.Text)
        sql.ExecQuery("select * from food where FoodId=@id")
        For Each r As DataRow In sql.Dbdt.Rows
            cbFoodName.Text = r("FoodName")
        Next
    End Sub
    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        If e.RowIndex >= 0 Then
            Dim r As DataGridViewRow = dgv1.CurrentRow
            If r.Cells(1).Value.ToString() <> "New" Then
                Dim i As Integer = dgv1.CurrentRow.Index
                recipeid = dgv1.Item("colrecipeid", i).Value
                txtFoodId.Text = dgv1.Item("colId", i).Value
                findnamefood()
                txtFoodDesc.Text = dgv1.Item("colDesc", i).Value
                txtFoodUnit.Text = dgv1.Item("colOutput", i).Value
                EditingMode()
            End If
        End If
    End Sub

    Private Sub btnEditFood_Click(sender As Object, e As EventArgs) Handles btnEditFood.Click
        If txtFoodDesc.Text = "" Or txtFoodUnit.Text = "" Then
            MsgBox("Fill the field first!")
        Else
            If sql.PhoneFormat(txtFoodUnit.Text) = False Then
                MsgBox("Invalid Price Format")
            Else
                Dim newfoodforrecipeheader As New RecipeHeader
                newfoodforrecipeheader = linq.RecipeHeaders.Where(Function(x) x.RecipeId = recipeid).FirstOrDefault
                newfoodforrecipeheader.FoodId = txtFoodId.Text
                newfoodforrecipeheader.Description = txtFoodDesc.Text
                newfoodforrecipeheader.OutputUnitInPieces = txtFoodUnit.Text
                newfoodforrecipeheader.EmployeeId = LoginForm.empid
                newfoodforrecipeheader.CreatedDate = Today
                newfoodforrecipeheader.Status = "A"
                Dim row As DataGridViewRow = dgv1.Rows.Cast(Of DataGridViewRow).FirstOrDefault(Function(x) x.Cells("colRecipeId").Value = recipeid)
                row.Cells("colid").Value = newfoodforrecipeheader.FoodId
                row.Cells("colDesc").Value = newfoodforrecipeheader.Description
                row.Cells("colOutput").Value = newfoodforrecipeheader.OutputUnitInPieces
                row.Cells("colStatus").Value = newfoodforrecipeheader.Status
                Cleaning()
                changesmade = True
            End If
        End If
    End Sub

    Private Sub btnDeleteFood_Click(sender As Object, e As EventArgs) Handles btnDeleteFood.Click
        If dgv1.RowCount > 0 Then
            Dim r As DataGridViewRow = dgv1.CurrentRow
            If r.Cells("colId").Value.ToString <> "New" Then
                If MsgBox("Delete?", vbYesNo) = vbYes Then
                    Dim newfoodforrecipeheader As RecipeHeader = linq.RecipeHeaders.Where(Function(x) x.FoodId = Convert.ToInt32(r.Cells("colRecipeId").Value)).FirstOrDefault()
                    Dim row As DataGridViewRow = dgv1.Rows.Cast(Of DataGridViewRow)().FirstOrDefault(Function(x) x.Cells("colRecipeId").Value.ToString() = recipeid)
                    newfoodforrecipeheader.Status = "D"
                    Cleaning()
                    row.Cells("colStatus").Value = newfoodforrecipeheader.Status
                    changesmade = True
                End If
            Else
                dgv1.Rows.Remove(r)
                Cleaning()
            End If
        End If
    End Sub


    Private Sub btnAddRaw_Click(sender As Object, e As EventArgs) Handles btnAddRaw.Click
        If txtRawWeight.Text = "" Or cbRawName.Text = "" Then
            MsgBox("Fill the field first!")
        Else
            If sql.PhoneFormat(txtRawWeight.Text) = False Then
                MsgBox("Invalid Weight Format")
            Else
                Dim newfoodforrecipeheader As New RecipeDetail
                newfoodforrecipeheader.RawMaterialId = rawmaterialid
                newfoodforrecipeheader.WeightInGram = txtRawWeight.Text
                linq.RecipeDetails.InsertOnSubmit(newfoodforrecipeheader)
                s.Rows.Add(s.RowCount + 1, "New", rawmaterialid, txtRawWeight.Text)
                Cleaning()
                changesmade = True
            End If
        End If
    End Sub
    Sub findnameraw()
        sql.AddParam("@id", rawmaterialid)
        sql.ExecQuery("select * from RawMaterial where RawMaterialId=@id")
        For Each r As DataRow In sql.Dbdt.Rows
            cbRawName.Text = r("RawMaterialName")
        Next
    End Sub
    Private Sub dgv2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles s.CellClick
        If e.RowIndex >= 0 Then
            Dim r As DataGridViewRow = s.CurrentRow
            If r.Cells(1).Value.ToString() <> "New" Then
                Dim i As Integer = s.CurrentRow.Index
                recipeid = s.Item("colrecipeidraw", i).Value
                findnameraw()
                rawmaterialid = s.Item("colRawId", i).Value
                txtRawWeight.Text = s.Item("colWeight", i).Value
                EditingMode()
            End If
        End If
    End Sub
    Sub findrawid()
        sql.AddParam("@id", cbRawName.Text)
        sql.ExecQuery("select * from rawmaterial where rawmaterialname=@id")
        For Each r As DataRow In sql.Dbdt.Rows
            rawmaterialid = r("rawmaterialid")
        Next
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEditRaw.Click
        If txtRawWeight.Text = "" Or cbRawName.Text = "" Then
            MsgBox("Fill the field first!")
        Else
            If sql.PhoneFormat(txtRawWeight.Text) = False Then
                MsgBox("Invalid Price Format")
            Else
                Dim newfoodforrecipeheader As New RecipeDetail
                newfoodforrecipeheader = linq.RecipeDetails.Where(Function(x) x.RecipeId = recipeid).FirstOrDefault
                findrawid
                newfoodforrecipeheader.RawMaterialId = rawmaterialid
                newfoodforrecipeheader.WeightInGram = txtRawWeight.Text
                Dim row As DataGridViewRow = s.Rows.Cast(Of DataGridViewRow).FirstOrDefault(Function(x) x.Cells("colRecipeIdraw").Value = recipeid)
                row.Cells("colrecipeidraw").Value = newfoodforrecipeheader.RecipeId
                row.Cells("colrawid").Value = newfoodforrecipeheader.RawMaterialId
                row.Cells("colweight").Value = newfoodforrecipeheader.WeightInGram
                Cleaning()
                changesmade = True
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDeleteFood.Click
        If s.RowCount > 0 Then
            Dim r As DataGridViewRow = s.CurrentRow
            If r.Cells("colId").Value.ToString <> "New" Then
                If MsgBox("Delete?", vbYesNo) = vbYes Then
                    Dim newfoodforrecipeheader As RecipeHeader = linq.RecipeHeaders.Where(Function(x) x.FoodId = Convert.ToInt32(r.Cells("colRecipeIdraw").Value)).FirstOrDefault()
                    Dim row As DataGridViewRow = s.Rows.Cast(Of DataGridViewRow)().FirstOrDefault(Function(x) x.Cells("colRecipeIdraw").Value.ToString() = recipeid)
                    newfoodforrecipeheader.Status = "D"
                    Cleaning()
                    row.Cells("colStatus").Value = newfoodforrecipeheader.Status
                    changesmade = True
                End If
            Else
                s.Rows.Remove(r)
                Cleaning()
            End If
        End If
    End Sub



    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        linq.SubmitChanges()
        Cleaning()
        LoadData()
        LoadData2()
        changesmade = False
    End Sub
    Private Sub cancelall()
        linq = New LinQDataContext()
        Cleaning()
        LoadData()
        LoadData2()
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

    Private Sub cbFoodName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFoodName.SelectedIndexChanged
        sql.AddParam("@food", cbFoodName.Text)
        sql.ExecQuery("select * from food where FoodName=@food")
        For Each r As DataRow In sql.Dbdt.Rows
            txtFoodId.Text = r("FoodId")
        Next
    End Sub

    Private Sub cbRawName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRawName.SelectedIndexChanged
        sql.AddParam("@food", cbRawName.Text)
        sql.ExecQuery("select * from RawMaterial where RawMaterialName=@food")
        For Each r As DataRow In sql.Dbdt.Rows
            rawmaterialid = r("RawMaterialId")
        Next
    End Sub

    Private Sub s_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles s.CellContentClick

    End Sub
End Class
