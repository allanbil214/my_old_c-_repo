Public Class Member
    Dim sql As New Squek
    Dim namequery As String
    Private Sub loaddata()
        sql.execquery("select * from member where not memberid='M00000000'")
        dgv1.DataSource = sql.dbdt
        cbfilter.Items.Clear()
        cbfilter.Items.Add("Name")
        cbfilter.Items.Add("Email")
        cbfilter.Items.Add("Handphone")
        cbfilter.Text = "Name"
    End Sub
    Private Sub Member_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
    End Sub

    Private Sub txtfilter_TextChanged(sender As Object, e As EventArgs) Handles txtfilter.TextChanged
        sql.addparam("@txt", "%" & txtfilter.Text & "%")
        sql.execquery("select * from member " & cbfilter.Text & "=@txt where not memberid='M00000000'")
        dgv1.DataSource = sql.dbdt
    End Sub

    Private Sub insertdata()
        sql.addparam("@id", TextBox1.Text)
        sql.addparam("@name", TextBox2.Text)
        sql.addparam("@email", TextBox3.Text)
        sql.addparam("@hp", TextBox4.Text)
        sql.addparam("@date", dtp1.Value)
        sql.execquery("insert into member(MemberID,Name,Email,Handphone,Expired) values(@id,@name,@email,@hp,@date)")
        If sql.hascecep(True) Then
            Exit Sub
        Else
            disable()
            MsgBox("Data are successfully added", vbOKOnly, "Congratulation")
        End If

    End Sub
    Private Sub updatedata()
        sql.addparam("@id", TextBox1.Text)
        sql.addparam("@name", TextBox2.Text)
        sql.addparam("@email", TextBox3.Text)
        sql.addparam("@hp", TextBox4.Text)
        sql.addparam("@date", dtp1.Value)
        sql.execquery("update member set Name=@name,Email=@email,Handphone=@hp,Expired=@date where MemberID=@id")
        If sql.hascecep(True) Then
            Exit Sub
        Else
            disable()
            MsgBox("Data are successfully updated", vbOKOnly, "Congratulation")
        End If

    End Sub
    Private Sub coalescemax()
        Dim year As Integer = dtp1.Value.Year
        Dim years As String = year
        Dim luru As String
        Dim i As Integer = 0
        sql.execquery("select coalesce(max(memberid),'000000000') as maxi from member")
        For Each r As DataRow In sql.dbdt.Rows
            luru = r("maxi")
            i = Mid(luru, 5)
        Next
        Dim m As String = i + 1 + 10000
        Dim text As String
        text = "M" + years + Mid(m, 2).ToString
        TextBox1.Text = text
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        coalescemax()
    End Sub
    Private Sub urepno()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        dtp1.Enabled = True
    End Sub
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        namequery = "Insert"
        urepno()
        Button1.Enabled = True
        btn2.Enabled = True
        btn4.Enabled = True
        btn1.Enabled = False
        btn3.Enabled = False
        coalescemax()
        dgv1.Enabled = False
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If TextBox2.Text = "" Then
            MsgBox("Select first!")
        Else
            namequery = "Update"
            TextBox1.Enabled = True
            TextBox2.Enabled = True
            TextBox3.Enabled = True
            TextBox4.Enabled = True
            dtp1.Enabled = True
            Button1.Enabled = False
            btn2.Enabled = True
            btn4.Enabled = True
            btn1.Enabled = False
            btn3.Enabled = False
            dgv1.Enabled = False
        End If
    End Sub
    Private Sub disable()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        dtp1.Enabled = False
        coalescemax()
        namequery = ""
        btn2.Enabled = False
        btn4.Enabled = False

    End Sub
    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        dgv1.Enabled = True
        disable()
        btn1.Enabled = True
        btn3.Enabled = True
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If namequery = "Insert" Then
            If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
                MsgBox("Fill the data first!", vbOKOnly, "Caution")
            Else
                insertdata()
                disable()
                dgv1.Enabled = True
            End If
        ElseIf namequery = "Update" Then
            If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
                MsgBox("Fill the data first!", vbOKOnly, "Caution")
            Else
                updatedata()
                disable()
                dgv1.Enabled = True
            End If
        End If
        loaddata()
        btn1.Enabled = True
        btn3.Enabled = True
    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        Dim i As Integer
        i = dgv1.CurrentRow.Index
        TextBox1.Text = dgv1.Item(0, i).Value
        TextBox2.Text = dgv1.Item(1, i).Value
        TextBox3.Text = dgv1.Item(2, i).Value
        TextBox4.Text = dgv1.Item(3, i).Value
        dtp1.Value = dgv1.Item(4, i).Value
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub
End Class