Public Class RecipeForm
    Private sql As New SquekingDataContext
    Private recipeid As Integer
    Sub loaddata()
        Dim i As Integer = 1
        dgvHeader.Rows.Clear()
        For Each r In sql.RecipeHeaders
            dgvHeader.Rows.Add("show", i, r.RecipeId, r.Food.FoodName, r.Description, r.OutputUnitInPieces, r.CreatedDate, r.Employee.EmployeeName, r.Status)
            i += 1
        Next
        Dim j As Integer = 1
        dgvDetail.Rows.Clear()
        For Each s In sql.RecipeDetails
            Dim r As DataGridViewRow = New DataGridViewRow()
            dgvDetail.Rows.Add(j, s.RecipeId, s.RawMaterialId, s.RawMaterial.RawMaterialName, s.WeightInGram)
            dgvDetail.Rows(j - 1).Visible = False
            j += 1
        Next
        cbFoodName.DataSource = sql.Foods
        cbFoodName.DisplayMember = "FoodName"
        cbFoodName.ValueMember = "foodid"
        cbIdRawMaterial.DataSource = sql.RawMaterials
        cbIdRawMaterial.DisplayMember = "RawMaterialName"
        cbIdRawMaterial.ValueMember = "RawMaterialId"
    End Sub

    Private Sub RecipeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
    End Sub
End Class
