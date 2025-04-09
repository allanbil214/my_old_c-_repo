Public Class EmployeeForm
    Private sql As New SQuekDataContext
    Private inorup As String = "no"
    Private jobid1 As Integer
    Private jobid2 As Integer
    Sub loaddata()
        dgv1.DataSource = sql.Employees.Where(Function(x) x.Name.ToString.Contains(SearchBox.Text) Or x.Email.ToString.Contains(SearchBox.Text) Or x.PhoneNumber.ToString.Contains(SearchBox.Text))
    End Sub
    Sub loadcb()
        For Each r In sql.Jobs
            cbJob.Items.Add(r.Name.ToString)
            cbJob.Text = r.Name.ToString
        Next
    End Sub
    Private Sub EmployeeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
        loadcb()
        cleaning()
    End Sub
    Sub cleaning()
        txtAddress.Clear()
        txtEmail.Clear()
        txtId.Clear()
        txtName.Clear()
        txtPass1.Clear()
        txtPass2.Clear()
        txtPhone.Clear()
        numSalary.Value = 0
        dateBirth.Value = Today
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
    Sub findnamejob()
        Dim jobs = sql.Jobs.Where(Function(x) x.Id = jobid1)
        Dim jobs2 = jobs.FirstOrDefault(Function(x) x.Id = jobid1)
        Dim getnamejob = jobs2.Name
        cbJob.Text = getnamejob
    End Sub
    Sub findidjob()
        Dim jobs = sql.Jobs.Where(Function(x) x.Name = cbJob.Text)
        Dim jobs2 = jobs.FirstOrDefault(Function(x) x.Name = cbJob.Text)
        Dim getidjob = jobs2.Id
        jobid2 = getidjob
    End Sub
    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        Dim i As Integer = dgv1.CurrentRow.Index
        txtId.Text = dgv1.Item(0, i).Value
        txtName.Text = dgv1.Item(2, i).Value
        txtEmail.Text = dgv1.Item(3, i).Value
        txtPhone.Text = dgv1.Item(5, i).Value
        txtAddress.Text = dgv1.Item(4, i).Value
        dateBirth.Value = dgv1.Item(6, i).Value
        jobid1 = dgv1.Item(7, i).Value
        findnamejob()
        numSalary.Value = Convert.ToInt32(dgv1.Item(8, i).Value)
        txtPass1.Text = dgv1.Item(1, i).Value
    End Sub

    Private Sub SearchBox_TextChanged(sender As Object, e As EventArgs) Handles SearchBox.TextChanged
        loaddata()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        cleaning()
        noaktif()
    End Sub
    Sub deletedata()
        Dim newemployee As New Employee
        newemployee = sql.Employees.Single(Function(x) x.Id = txtId.Text)
        sql.Employees.DeleteOnSubmit(newemployee)
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
                deletedata
            End If
        End If
    End Sub
    Sub insertdata()
        Dim newemployee As New Employee()
        newemployee.Address = txtAddress.Text
        newemployee.DateofBirth = dateBirth.Value
        newemployee.Email = txtEmail.Text
        newemployee.IdJob = jobid2
        newemployee.Name = txtName.Text
        newemployee.Password = txtPass1.Text
        newemployee.PhoneNumber = txtPhone.Text
        newemployee.Salary = numSalary.Value
        sql.Employees.InsertOnSubmit(newemployee)
        sql.SubmitChanges()
        loaddata()
        cleaning()
        noaktif()
    End Sub

    Sub updatedata()
        Dim newemployee As New Employee()
        newemployee = sql.Employees.Single(Function(x) x.Id = txtId.Text)
        newemployee.Address = txtAddress.Text
        newemployee.DateofBirth = dateBirth.Value
        newemployee.Email = txtEmail.Text
        newemployee.IdJob = jobid2
        newemployee.Name = txtName.Text
        newemployee.Password = txtPass1.Text
        newemployee.PhoneNumber = txtPhone.Text
        newemployee.Salary = numSalary.Value
        sql.SubmitChanges()
        loaddata()
        cleaning()
        noaktif()
    End Sub

    Private Sub cbJob_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbJob.SelectedIndexChanged
        findidjob()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtName.Text = "" Or txtPass1.Text = "" Or txtPass2.Text = "" Or txtPhone.Text = "" Or txtAddress.Text = "" Or txtEmail.Text = "" Or cbJob.Text = "" Or numSalary.Value <= 0 Then
            MsgBox("Fill blank field first!")
        Else
            If MainForm.isemailformat(txtEmail.Text) = False Then
                MsgBox("Invalid email format!")
            Else
                If MainForm.isphoneformat(txtPhone.Text) = False Then
                    MsgBox("Invalid phone number format!")
                Else
                    If txtPass1.Text <> txtPass2.Text Then
                        MsgBox("Invalid password, password must be same between the two fields")
                    Else
                        If inorup = "in" Then
                            insertdata()
                        ElseIf inorup = "up" Then
                            updatedata()
                        End If
                    End If
                End If
            End If
        End If
    End Sub
End Class
