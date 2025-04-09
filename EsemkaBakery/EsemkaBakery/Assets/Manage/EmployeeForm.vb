Public Class EmployeeForm
    Private linq As New LinQDataContext
    Private sql As New Squek
    Private inorup As String = "no"
    Private changesmade As Boolean = False
    Sub LoadData()
        dgv1.Rows.Clear()
        Dim i As Integer = 1
        For Each r In linq.Employees
            dgv1.Rows.Add(i, r.EmployeeId, r.EmployeeName, r.Password, r.EmployeeAddress, r.EmployeePhone, r.Status, r.Email)
            i += 1
        Next
        TotalDataLabel.Text = "Total Data : " + linq.Employees.Count.ToString
    End Sub
    Sub Cleaning()
        NotEditionMode()
        txtAddress.Clear()
        txtEmail.Clear()
        txtId.Text = "New"
        txtName.Clear()
        txtPassword.Clear()
        txtPhone.Clear()
        dgv1.ClearSelection()
    End Sub
    Private Sub EmployeeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        Dim result = dgv1.Rows.Cast(Of DataGridViewRow).Where(Function(x) x.Cells("colName").Value.ToString.Contains(SearchBox.Text) _
                                                                  Or x.Cells("colEmail").Value.ToString.Contains(SearchBox.Text) _
                                                                  Or x.Cells("colAddress").Value.ToString.Contains(SearchBox.Text) _
                                                                  Or x.Cells("colPhone").Value.ToString.Contains(SearchBox.Text))
        For Each r As DataGridViewRow In dgv1.Rows
            r.Visible = False
        Next
        For Each r As DataGridViewRow In result
            r.Visible = True
        Next
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtAddress.Text = "" Or txtEmail.Text = "" Or txtId.Text = "" Or txtName.Text = "" Or txtPassword.Text = "" Or txtPhone.Text = "" Then
            MsgBox("Fill the field first!")
        Else
            If sql.EmailFormat(txtEmail.Text) = False Then
                MsgBox("Invalid Email Format")
            Else
                If sql.PhoneFormat(txtPhone.Text) = False Then
                    MsgBox("Invalid Phone Format")
                Else
                    Dim newEmp As New Employee
                    newEmp.EmployeeAddress = txtAddress.Text
                    newEmp.Email = txtEmail.Text
                    newEmp.EmployeeName = txtName.Text
                    newEmp.Password = txtPassword.Text
                    newEmp.EmployeePhone = txtPhone.Text
                    newEmp.Status = "A"
                    linq.Employees.InsertOnSubmit(newEmp)
                    dgv1.Rows.Add(dgv1.RowCount + 1, "New", txtName.Text, txtPassword.Text, txtAddress.Text, txtPhone.Text, "A", txtEmail.Text)
                    Cleaning()
                    changesmade = True
                End If
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
                txtPassword.Text = dgv1.Item("colPass", i).Value
                txtAddress.Text = dgv1.Item("colAddress", i).Value
                txtPhone.Text = dgv1.Item("colPhone", i).Value
                txtEmail.Text = dgv1.Item("colEmail", i).Value
                EditingMode()
            End If
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtAddress.Text = "" Or txtEmail.Text = "" Or txtId.Text = "" Or txtName.Text = "" Or txtPassword.Text = "" Or txtPhone.Text = "" Then
            MsgBox("Fill the field first!")
        Else
            If sql.EmailFormat(txtEmail.Text) = False Then
                MsgBox("Invalid Email Format")
            Else
                If sql.PhoneFormat(txtPhone.Text) = False Then
                    MsgBox("Invalid Phone Format")
                Else
                    Dim newEmp As New Employee
                    newEmp = linq.Employees.Where(Function(x) x.EmployeeId = txtId.Text).FirstOrDefault
                    newEmp.EmployeeAddress = txtAddress.Text
                    newEmp.Email = txtEmail.Text
                    newEmp.EmployeeName = txtName.Text
                    newEmp.Password = txtPassword.Text
                    newEmp.EmployeePhone = txtPhone.Text
                    newEmp.Status = "A"
                    Dim row As DataGridViewRow = dgv1.Rows.Cast(Of DataGridViewRow).FirstOrDefault(Function(x) x.Cells("colId").Value = txtId.Text)
                    row.Cells(2).Value = newEmp.EmployeeName
                    row.Cells(3).Value = newEmp.Password
                    row.Cells(4).Value = newEmp.EmployeeAddress
                    row.Cells(5).Value = newEmp.EmployeePhone
                    row.Cells(6).Value = newEmp.Status
                    row.Cells(7).Value = newEmp.Email
                    Cleaning()
                    changesmade = True
                End If
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgv1.RowCount > 0 Then
            Dim r As DataGridViewRow = dgv1.CurrentRow
            If r.Cells("colId").Value.ToString <> "New" Then
                If MsgBox("Delete?", vbYesNo) = vbYes Then
                    Dim newemp As Employee = linq.Employees.Where(Function(x) x.EmployeeId = Convert.ToInt32(r.Cells("colId").Value)).FirstOrDefault()
                    Dim row As DataGridViewRow = dgv1.Rows.Cast(Of DataGridViewRow)().FirstOrDefault(Function(x) x.Cells("colId").Value.ToString() = txtId.Text)
                    newemp.Status = "D"
                    Cleaning()
                    row.Cells("colStatus").Value = newemp.Status
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
