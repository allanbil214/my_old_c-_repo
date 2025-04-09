Public Class Form1
    Private sql As New Squek
    Private kategoriid As Integer
    Private inorup As String = "no"
    Sub loaddata()
        DataGridView1.Rows.Clear()
        sql.execquery("select * from Kategori")
        DataGridView1.Rows.Add("ADD", "0")
        For Each r As DataRow In sql.dbdt.Rows
            DataGridView1.Rows.Add(r("Nama").ToString + " " + r("Id").ToString, r("Id"))
        Next
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer = DataGridView1.CurrentRow.Index
        kategoriid = DataGridView1.Item(1, i).Value
        TextBox1.Text = DataGridView1.Item(0, i).Value
        If TextBox1.Text = "ADD" Or TextBox1.Text = "" Then
            inorup = "in"
            TextBox1.Clear()
        Else
            inorup = "up"
        End If
        Panel2.Enabled = True
    End Sub

    Sub insertdata()
        sql.addparam("@id", kategoriid)
        sql.addparam("@nama", TextBox1.Text)
        sql.execquery("insert into kategori(nama) values(@nama)")
        loaddata()
        MsgBox("Success")
        TextBox1.Clear()
    End Sub
    Sub updatedata()
        sql.addparam("@id", kategoriid)
        sql.addparam("@nama", TextBox1.Text)
        sql.execquery("update kategori set nama=@nama where id=@id")
        loaddata()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text = "" Then
            MsgBox("Fill all the field first!")
        Else
            MsgBox(inorup)
            If inorup = "in" Then
                insertdata()
            ElseIf inorup = "up" Then
                updatedata()
            End If
            Panel2.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button1.BackColor = Color.GhostWhite
        Button2.BackColor = Color.DarkCyan
        Button3.BackColor = Color.GhostWhite
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.BackColor = Color.DarkCyan
        Button2.BackColor = Color.GhostWhite
        Button3.BackColor = Color.GhostWhite
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button1.BackColor = Color.GhostWhite
        Button2.BackColor = Color.GhostWhite
        Button3.BackColor = Color.DarkCyan
    End Sub
End Class
