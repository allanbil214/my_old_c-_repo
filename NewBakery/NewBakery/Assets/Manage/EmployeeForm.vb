Public Class EmployeeForm
    Private sql As New SquekingDataContext
    Private squek As New Squek
    Private inorup As String = "no"
    Sub loaddata()
        dgv1.DataSource = sql.Employees.Where(Function(x) x.EmployeeName.ToString.Contains(searchBox.Text) _
                                              Or x.Email.ToString.Contains(searchBox.Text) _
                                              Or x.EmployeeAddress.ToString.Contains(searchBox.Text) _
                                              Or x.EmployeePhone.ToString.Contains(searchBox.Text))
        lblTotalData.Text = "Total Data : " + sql.Employees.Count.ToString
    End Sub
    Private Sub EmployeeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        loaddata()
    End Sub
    Sub cleaning()
        txtAddress.Clear()
        txtEmail.Clear()
        txtId.Clear()
        txtName.Clear()
        txtPass.Clear()
        txtPhone.Clear()
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
        txtAddress.Text = dgv1.Item(3, i).Value
        txtEmail.Text = dgv1.Item(6, i).Value
        txtId.Text = dgv1.Item(0, i).Value
        txtName.Text = dgv1.Item(1, i).Value
        txtPass.Text = dgv1.Item(2, i).Value
        txtPhone.Text = dgv1.Item(4, i).Value
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtAddress.Text = "" Then
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
        If txtAddress.Text = "" Then
            MsgBox("select data first!")
        Else
            If MsgBox("Delete?", vbYesNo) = vbYes Then
                Dim newEmployee As New Employee
                newEmployee = sql.Employees.Single(Function(x) x.EmployeeId = txtId.Text)
                newEmployee.Status = "D"
                sql.SubmitChanges()
            End If
        End If
    End Sub
    Sub insertdata()
        Dim newemployee As New Employee
        newemployee.EmployeeAddress = txtAddress.Text
        newemployee.Email = txtEmail.Text
        newemployee.EmployeeName = txtName.Text
        newemployee.Password = txtPass.Text
        newemployee.EmployeePhone = txtPhone.Text
        newemployee.Status = "A"
        sql.Employees.InsertOnSubmit(newemployee)
        sql.SubmitChanges()
    End Sub
    Sub updatedata()
        Dim newemployee As New Employee
        newemployee = sql.Employees.Single(Function(x) x.EmployeeId = txtId.Text)
        newemployee.EmployeeAddress = txtAddress.Text
        newemployee.Email = txtEmail.Text
        newemployee.EmployeeName = txtName.Text
        newemployee.Password = txtPass.Text
        newemployee.EmployeePhone = txtPhone.Text
        newemployee.Status = "A"
        sql.SubmitChanges()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtAddress.Text = "" Or txtEmail.Text = "" Or txtId.Text = "" Or txtName.Text = "" Or txtPass.Text = "" Or txtPhone.Text = "" Then
            MsgBox("Fill all the field first!")
        Else
            If squek.EmailFormat(txtEmail.Text) = False Then
                MsgBox("Invalid Email Format!")
            Else
                If squek.PhoneFormat(txtPhone.Text) = False Then
                    MsgBox("Invalid Phone Format!")
                Else
                    If inorup = "in" Then
                        insertdata()
                        cleaning()
                        loaddata()
                        deactiveCRUD()
                    ElseIf inorup = "up" Then
                        updatedata
                        cleaning()
                        loaddata()
                        deactiveCRUD()
                    End If
                End If
            End If
        End If
    End Sub
End Class
