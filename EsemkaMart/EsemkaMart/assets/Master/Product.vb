Public Class Product
    Dim sql As New Squek
    Dim namequery As String
    Private Sub loaddata()
        sql.execquery("select * from product")
        dgv1.DataSource = sql.dbdt
        cbfilter.Items.Clear()
        cbfilter.Items.Add("Name")
        cbfilter.Items.Add("Spec")
        cbfilter.Items.Add("ProductID")
        cbfilter.Text = "Name"
    End Sub
    Private Sub Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
    End Sub

    Private Sub txtfilter_TextChanged(sender As Object, e As EventArgs) Handles txtfilter.TextChanged
        sql.addparam("@txt", "%" & txtfilter.Text & "%")
        sql.execquery("select * from product where " & cbfilter.Text & " like @txt")
        dgv1.DataSource = sql.dbdt
    End Sub
    Private Sub maxcoalesce()
        Dim luru As String
        Dim i As Integer
        sql.execquery("select coalesce(max(ProductID),'000000') as maxi from Product")
        For Each r As DataRow In sql.dbdt.Rows
            luru = r("maxi")
            i = Val(Mid(luru, 3))
        Next
        Dim m As Integer = i + 1 + 10000
        TextBox1.Text = "PR" + Mid(m, 2).ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        maxcoalesce()
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox5.Enabled = True
        Button1.Enabled = True
        maxcoalesce()
        btn1.Enabled = False
        btn3.Enabled = False
        btn2.Enabled = True
        btn4.Enabled = True
        namequery = "insert"
        dgv1.Enabled = False
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If TextBox2.Text = "" Then
            MsgBox("Select first!")
        Else
            TextBox1.Enabled = True
            TextBox2.Enabled = True
            TextBox3.Enabled = True
            TextBox4.Enabled = True
            TextBox5.Enabled = True
            btn1.Enabled = False
            btn3.Enabled = False
            btn2.Enabled = True
            btn4.Enabled = True
            namequery = "update"
            dgv1.Enabled = False
        End If
    End Sub
    Private Sub clearr()
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        btn1.Enabled = True
        btn3.Enabled = True
        btn2.Enabled = False
        btn4.Enabled = False
        namequery = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub
    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        clearr()
        dgv1.Enabled = True
    End Sub
    Private Sub insertdata()
        sql.addparam("@id", TextBox1.Text)
        sql.addparam("@name", TextBox2.Text)
        sql.addparam("@spec", TextBox3.Text)
        sql.addparam("@buy", TextBox4.Text)
        sql.addparam("@sell", TextBox5.Text)
        sql.execquery("insert into product(ProductID,Name,Spec,BuyPrice,SellPrice) values(@id,@name,@spec,@buy,@sell)")
        If sql.hascecep(True) Then
            Exit Sub
        Else
            clearr()
            MsgBox("Data are successfully added", vbOKOnly, "Congratulation")
        End If
    End Sub
    Private Sub updatedata()
        sql.addparam("@id", TextBox1.Text)
        sql.addparam("@name", TextBox2.Text)
        sql.addparam("@spec", TextBox3.Text)
        sql.addparam("@buy", TextBox4.Text)
        sql.addparam("@sell", TextBox5.Text)
        sql.execquery("update product set Name=@name,Spec=@spec,BuyPrice=@buy,SellPrice=@sell where ProductID=@id")
        If sql.hascecep(True) Then
            Exit Sub
        Else
            clearr()
            MsgBox("Data are successfully updated", vbOKOnly, "Congratulation")
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If namequery = "insert" Then
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
                MsgBox("Fill the textboxs first!", vbOKOnly, "Congratulation")
            Else
                insertdata()
            End If
        ElseIf namequery = "update" Then
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
                MsgBox("Fill the textboxs first!", vbOKOnly, "Congratulation")
            Else
                updatedata()
            End If
        End If
        clearr()
        dgv1.Enabled = True
        loaddata()
    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        Dim i As Integer
        i = dgv1.CurrentRow.Index
        TextBox1.Text = dgv1.Item(0, i).Value
        TextBox2.Text = dgv1.Item(1, i).Value
        TextBox3.Text = dgv1.Item(2, i).Value
        TextBox4.Text = dgv1.Item(3, i).Value
        TextBox5.Text = dgv1.Item(4, i).Value
    End Sub
End Class