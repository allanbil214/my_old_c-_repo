Public Class formDrugs
    Private sql As New Squek
    Private inorup As String = ""
    Private did As Integer = 0
    Sub loaddata()
        sql.addparam("@id", "%" & searchTXT.Text & "%")
        sql.execquery("select * from drugs where name like @id")
        dgv1.DataSource = sql.dbdt
        dtpExpire.MinDate = Today.AddDays(100)
    End Sub

    Private Sub formdrugs_Load(sender As Object, e As EventArgs) Handles Me.Load
        loaddata()
        dtpExpire.Value = DateTime.Now.AddDays(30)
    End Sub

    Private Sub searchTXT_TextChanged(sender As Object, e As EventArgs) Handles searchTXT.TextChanged
        loaddata()
    End Sub

    Private Sub dgv1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellDoubleClick
        Dim i As Integer = dgv1.CurrentRow.Index
        did = dgv1.Item(0, i).Value
        txtName.Text = dgv1.Item(1, i).Value
        numPrice.Value = dgv1.Item(2, i).Value
        numStock.Value = dgv1.Item(3, i).Value
        txtUsage.Text = dgv1.Item(4, i).Value
        dtpExpire.Value = dgv1.Item(5, i).Value
        If dtpExpire.Value < dtpExpire.MinDate Then MsgBox("Obat hampir kadaluarsa", vbCritical, "Caution")
        dtpExpire.MinDate = dgv1.Item(5, i).Value
    End Sub
    Sub cleartext()
        txtName.Clear()
        numPrice.Value = 1000
        numStock.Value = 1
        txtUsage.Clear()
        did = 0
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
        sql.addparam("@id", did)
        sql.execquery("delete drugs where id=@id")
        If sql.hascecep(True) Then
            Exit Sub
        Else
            MsgBox("Success")
            cleartext()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If did = 0 Then
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
        sql.addparam("@id", did)
        sql.addparam("@name", txtName.Text)
        sql.addparam("@cost", numPrice.Value)
        sql.addparam("@stock", numStock.Value)
        sql.addparam("@usage", txtUsage.Text)
        sql.addparam("@expire", dtpExpire.Value.Date)
        sql.execquery("insert into drugs(name,cost,stock,usage,ExpireDate) values(@name,@cost,@stock,@usage,@expire) ")
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
        sql.addparam("@id", did)
        sql.addparam("@name", txtName.Text)
        sql.addparam("@cost", numPrice.Value)
        sql.addparam("@stock", numStock.Value)
        sql.addparam("@usage", txtUsage.Text)
        sql.execquery("update drugs set name=@name,cost=@cost,stock=@stock,usage=@usage,ExpireDate=@expire where id=@id ")
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
            If txtName.Text = "" Or txtUsage.Text = "" Then
                MsgBox("No null allowed")
            Else
                insertdata()
                End If
        ElseIf inorup = "up" Then
            If txtName.Text = "" Or txtUsage.Text = "" Then
                MsgBox("No null allowed")
            Else
                updatedata()
            End If
        End If
    End Sub
End Class