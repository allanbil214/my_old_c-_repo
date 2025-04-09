Public Class Employee
    Dim sql As New Squek
    Dim inorup As String
    Dim idd As Integer
    Private Sub loaddata()
        sql.addparam("@txt", "%" & txtfilter.Text & "%")
        sql.execquery("select * from employee where name like @txt")
        dgv1.DataSource = sql.dbdt
    End Sub
    Private Sub autoid()
        sql.execquery("select coalesce(max(EmployeeID),0) as id from employee")
        For Each r As DataRow In sql.dbdt.Rows
            idd = r("id")
        Next
        txtid.Text = idd + 1
    End Sub
    Private Sub insertdata()
        sql.addparam("@id", txtid.Text)
        sql.addparam("@name", txtname.Text)
        sql.addparam("@hp", txthp.Text)
        sql.addparam("@cb", cbposition.Text)
        sql.addparam("@date", datebirth.Value)
        sql.addparam("@email", txtemail.Text)
        sql.addparam("@pass", txtpass.Text)
        sql.execquery("insert into employee(Name,Handphone,Position,BirthDate,Email,Passwords) values(@name,@hp,@cb,@date,@email,@pass) ")
        If sql.hascecep(True) Then Exit Sub
        MsgBox("Data inserted Successfully", vbOKOnly, "Congratulation")
    End Sub
    Private Sub updatedata()
        sql.addparam("@id", txtid.Text)
        sql.addparam("@name", txtname.Text)
        sql.addparam("@hp", txthp.Text)
        sql.addparam("@cb", cbposition.Text)
        sql.addparam("@date", datebirth.Value)
        sql.addparam("@email", txtemail.Text)
        sql.addparam("@pass", txtpass.Text)
        sql.execquery("update employee set Name=@name,Handphone=@hp,Position=@cb,BirthDate=@date,Email=@email,Passwords=@pass where EmployeeID=@id")
        If sql.hascecep(True) Then Exit Sub
        MsgBox("Data updated Successfully", vbOKOnly, "Congratulation")
    End Sub
    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
        cbposition.Items.Add("Select")
        cbposition.Items.Add("Manager")
        cbposition.Items.Add("Kasir")
        cbposition.Text = "Select"
    End Sub


    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        Dim i As Integer
        i = dgv1.CurrentRow.Index
        txtid.Text = dgv1.Item(0, i).Value
        txtname.Text = dgv1.Item(1, i).Value
        txthp.Text = dgv1.Item(2, i).Value
        cbposition.Text = dgv1.Item(3, i).Value
        datebirth.Value = dgv1.Item(4, i).Value
        txtemail.Text = dgv1.Item(5, i).Value
        txtpass.Text = dgv1.Item(6, i).Value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNEw.Click
        autoid()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtpass.UseSystemPasswordChar = False
        Else
            txtpass.UseSystemPasswordChar = True
        End If
    End Sub
    Sub cleaning()
        txtid.Text = ""
        txtname.Text = ""
        txthp.Text = ""
        cbposition.Text = "Select"
        txtemail.Text = ""
        txtpass.Text = ""
        CheckBox1.Checked = False
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        inorup = "in"
        gbData.Enabled = True
        dgv1.Enabled = False
        cleaning()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtname.Text = "" Then
            MsgBox("Select data first!")
        Else
            inorup = "up"
            gbData.Enabled = True
            dgv1.Enabled = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txtname.Text = "" Then
            MsgBox("Select data first!")
        Else
            If MsgBox("Delete?", vbYesNo) = vbYes Then
                sql.addparam("@id", txtid.Text)
                sql.execquery("delete employee where id=@id")
                If sql.hascecep(True) Then
                    Exit Sub
                Else
                    MsgBox("Success")
                End If
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cleaning()
        gbData.Enabled = False
        dgv1.Enabled = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If txtemail.Text = "" Or txthp.Text = "" Or txtid.Text = "" Or txtname.Text = "" Or txtpass.Text = "" Or cbposition.Text = "Select" Then
            MsgBox("Empty data!")
        Else
            If sql.isemailformat(txtemail.Text) = False Then
                MsgBox("Not email format")
            Else
                If inorup = "in" Then
                    insertdata()
                    cleaning()
                    gbData.Enabled = False
                    dgv1.Enabled = True
                ElseIf inorup = "up" Then
                    updatedata()
                    cleaning()
                    gbData.Enabled = False
                    dgv1.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Sub txthp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txthp.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not Char.IsDigit(e.KeyChar)
        End If
    End Sub
End Class