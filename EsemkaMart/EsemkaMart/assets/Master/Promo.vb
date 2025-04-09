Public Class Promo
    Dim sql As New Squek
    Dim numberer As Integer
    Dim idprom As Integer
    Private issame As Integer
    Dim namer As String
    Private Sub coalescemax()

    End Sub
    Private Sub loaddata()
        sql.execquery("select * from Promo")
        dgv1.DataSource = sql.dbdt
        coalescemax()
    End Sub

    Private Sub Promo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
        ComboBox1.Items.Add("FREE")
        ComboBox1.Items.Add("DISC")
        ComboBox1.Items.Add("NOTH")
        ComboBox1.Text = "NOTH"
        formMain.title = "promo"
    End Sub

    Private Sub txtfilter_TextChanged(sender As Object, e As EventArgs) Handles txtfilter.TextChanged
        sql.addparam("@txt", txtfilter.Text)
        sql.execquery("select * from promo where " & cbfilter.Text & " like @txt")
        dgv1.DataSource = sql.dbdt
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Search.ShowDialog()
        formMain.title = "promo"
    End Sub
    Private Sub cleaner()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox1.Text = "Discount"
    End Sub
    Private Sub disabler()
        GroupBox1.Enabled = False
    End Sub
    Private Sub insertdata()

        sql.addparam("@id", TextBox1.Text)
        sql.addparam("@name", TextBox2.Text)
        sql.addparam("@buy", TextBox3.Text)
        sql.addparam("@type", ComboBox1.Text)
        sql.addparam("@reward", TextBox4.Text)
        sql.addparam("@start", DateTimePicker1.Value)
        sql.addparam("@end", DateTimePicker2.Value)
        sql.execquery("insert into promo(ProductID,Name,BuyQty,Type,Reward,StartDate,EndDate) values(@id,@name,@buy,@type,@reward,@start,@end)")
        If sql.hascecep(True) Then
            Exit Sub
        Else
            MsgBox("Data successfully added", vbOKOnly, "Succeded")
            cleaner()
            disabler()
            btn1.Enabled = True
            btn3.Enabled = True
            btn2.Enabled = False
            btn4.Enabled = False
            loaddata()
        End If
    End Sub

    Private Sub updatedata()

        sql.addparam("@idprom", idprom)
        sql.addparam("@id", TextBox1.Text)
        sql.addparam("@name", TextBox2.Text)
        sql.addparam("@buy", TextBox3.Text)
        sql.addparam("@type", ComboBox1.Text)
        sql.addparam("@reward", TextBox4.Text)
        sql.addparam("@start", DateTimePicker1.Value)
        sql.addparam("@end", DateTimePicker2.Value)
        sql.execquery("update promo set ProductID=@id,Name=@name,BuyQty=@buy,Type=@type,Reward=@reward,StartDate=@start,EndDate=@end where PromoID=@idprom")
        If sql.hascecep(True) Then
            Exit Sub
        Else
            MsgBox("Data successfully updated", vbOKOnly, "Succeded")
            cleaner()
            disabler()
            btn1.Enabled = True
            btn3.Enabled = True
            btn2.Enabled = False
            btn4.Enabled = False
            loaddata()
        End If
    End Sub
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        cleaner()
        GroupBox1.Enabled = True
        btn1.Enabled = False
        btn3.Enabled = False
        btn2.Enabled = True
        btn4.Enabled = True
        dgv1.Enabled = False
        namer = "Insert"
    End Sub
    Sub checksama()
        sql.addparam("@name", TextBox2.Text)
        sql.execquery("select count(name) as issame from promo where name=@name")
        For Each r As DataRow In sql.dbdt.Rows
            issame = r("issame")
        Next
    End Sub
    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If TextBox2.Text = "" Then
            MsgBox("Select first!")
        Else
            GroupBox1.Enabled = True
            btn1.Enabled = False
            btn3.Enabled = False
            btn2.Enabled = True
            btn4.Enabled = True
            namer = "Update"
            dgv1.Enabled = False
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If namer = "Update" Then
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
                MsgBox("Fill the data first!", vbOKOnly, "Caution")
            Else
                updatedata()
            End If
        ElseIf namer = "Insert" Then
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
                MsgBox("Fill the data first!", vbOKOnly, "Caution")
            Else
                'checksama()
                'If issame = 1 Then
                'MsgBox("There are same product")
                ' Else
                insertdata()

                ' End If
            End If

        End If
        dgv1.Enabled = True
        loaddata()
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        cleaner()
        disabler()
        loaddata()
        btn1.Enabled = True
        btn3.Enabled = True
        btn2.Enabled = False
        btn4.Enabled = False
        dgv1.Enabled = True
    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        Dim i As Integer
        i = dgv1.CurrentRow.Index
        idprom = dgv1.Item(0, i).Value
        TextBox1.Text = dgv1.Item(1, i).Value
        TextBox2.Text = dgv1.Item(2, i).Value
        TextBox3.Text = dgv1.Item(3, i).Value
        ComboBox1.Text = dgv1.Item(4, i).Value
        TextBox4.Text = dgv1.Item(5, i).Value
        DateTimePicker1.Value = dgv1.Item(6, i).Value
        DateTimePicker2.Value = dgv1.Item(7, i).Value
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = ("NOTH") Then
            TextBox3.Text = "0"
            TextBox3.ReadOnly = True
            TextBox4.Text = "0"
            TextBox4.ReadOnly = True
        Else
            TextBox3.ReadOnly = False
            TextBox4.ReadOnly = False
        End If
    End Sub


    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not Char.IsDigit(e.KeyChar)
        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not Char.IsDigit(e.KeyChar)
        End If
    End Sub
End Class