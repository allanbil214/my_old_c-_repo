Public Class formMember
    Private sql As New Squek
    Private inorup As String = ""
    Private mid As Integer = 0
    Sub loaddata()
        sql.addparam("@id", "%" & searchTXT.Text & "%")
        sql.execquery("select * from member where name like @id")
        dgv1.DataSource = sql.dbdt
    End Sub

    Private Sub formmember_Load(sender As Object, e As EventArgs) Handles Me.Load
        loaddata()
        cbGender.Items.Add("Male")
        cbGender.Items.Add("Female")
        cbGender.Text = "Male"
    End Sub

    Private Sub searchTXT_TextChanged(sender As Object, e As EventArgs) Handles searchTXT.TextChanged
        loaddata()
    End Sub

    Private Sub dgv1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellDoubleClick
        Dim i As Integer = dgv1.CurrentRow.Index
        mid = dgv1.Item(0, i).Value
        txtName.Text = dgv1.Item(1, i).Value
        txtEmail.Text = dgv1.Item(2, i).Value
        txtAddress.Text = dgv1.Item(3, i).Value
        cbGender.Text = dgv1.Item(4, i).Value
    End Sub
    Sub cleartext()
        txtName.Clear()
        txtEmail.Clear()
        txtAddress.Clear()
        mid = 0
    End Sub
    Sub enable1()
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = True
        Button5.Enabled = True
    End Sub
    Sub enable2()
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = False
        Button5.Enabled = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        inorup = "in"
        gbData.Enabled = True
        cleartext()
        dgv1.Enabled = False
        enable1()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtName.Text = "" Then
            MsgBox("Select data first!")
        Else
            inorup = "up"
            gbData.Enabled = True
            dgv1.Enabled = False
            enable1()
        End If
    End Sub
    Sub deletedata()
        sql.addparam("@id", mid)
        sql.execquery("delete member where id=@id")
        If sql.hascecep(True) Then
            Exit Sub
        Else
            MsgBox("Success")
            cleartext()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If mid = 0 Then
            MsgBox("Select any data first!")
        Else
            If MsgBox("Delete?", vbYesNo) = vbYes Then
                deletedata()
                loaddata()
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cleartext()
        enable2()
        dgv1.Enabled = True
        gbData.Enabled = False
    End Sub
    Sub insertdata()
        sql.addparam("@id", mid)
        sql.addparam("@name", txtName.Text)
        sql.addparam("@email", txtEmail.Text)
        sql.addparam("@address", txtAddress.Text)
        sql.addparam("@gender", cbGender.Text)
        sql.execquery("insert into member(name,email,address,gender) values(@name,@email,@address,@gender) ")
        If sql.hascecep(True) Then
            Exit Sub
        Else
            MsgBox("Success")
            enable2()
            cleartext()
            dgv1.Enabled = True
            gbData.Enabled = False
            loaddata()
        End If
    End Sub
    Sub updatedata()
        sql.addparam("@id", mid)
        sql.addparam("@name", txtName.Text)
        sql.addparam("@email", txtEmail.Text)
        sql.addparam("@address", txtAddress.Text)
        sql.addparam("@gender", cbGender.Text)
        sql.execquery("update member set name=@name,email=@email,address=@address,gender=@gender where id=@id ")
        If sql.hascecep(True) Then
            Exit Sub
        Else
            MsgBox("Success")
            enable2()
            cleartext()
            dgv1.Enabled = True
            gbData.Enabled = False
            loaddata()
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If inorup = "in" Then
            If txtName.Text = "" Or txtEmail.Text = "" Or txtAddress.Text = "" Then
                MsgBox("")
            Else
                If sql.emailformat(txtEmail.Text) = False Then
                    MsgBox("Invalid email format")
                Else
                    insertdata()
                End If
            End If
        ElseIf inorup = "up" Then
            If txtName.Text = "" Or txtEmail.Text = "" Or txtAddress.Text = "" Then
                MsgBox("")
            Else
                If sql.emailformat(txtEmail.Text) = False Then
                    MsgBox("Invalid email format")
                Else
                    updatedata()
                End If
            End If
        End If
    End Sub
End Class