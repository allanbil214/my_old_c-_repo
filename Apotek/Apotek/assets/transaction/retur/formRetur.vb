Public Class formRetur
    Private sql As New Squek
    Public drugid As Integer = 0
    Public drugbasestock As Integer = 0
    Private returid As Integer = 0
    Sub loaddata()
        sql.execquery("select * from retur")
        dgv1.DataSource = sql.dbdt
    End Sub
    Sub findlastid()
        sql.execquery("select max(id) as maxid from retur ")
        Dim null As String
        For Each r As DataRow In sql.dbdt.Rows
            null = r("maxid").ToString
            If null <> "" Then
                returid = null
                Label4.Text = returid
            End If
        Next
    End Sub
    Private Sub formRetur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
        findlastid()
        dtpRetur.Value = DateTime.Now
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        formSearch.whatform = "retur"
        formSearch.whatisit = "drug"
        formSearch.ShowDialog()
    End Sub
    Dim x As Integer

    Sub dgv1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv1.CellMouseClick
        If e.RowIndex >= 0 Then x = e.RowIndex
    End Sub
    Sub findname()
        sql.addparam("@id", drugid)
        sql.execquery("select * from drugs where id=@id")
        For Each r As DataRow In sql.dbdt.Rows
            txtDrug.Text = r("Name")
            numQty.Value = 1
            numQty.Maximum = r("stock")
        Next
    End Sub
    Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellDoubleClick
        With dgv1.Rows(x)
            If .Cells("Replaced").Value < .Cells("Qty").Value Then
                returid = .Cells("id").Value
                drugid = .Cells("did").Value
                findname()
                numQty.Enabled = False
                numReplace.Enabled = True
                numQty.Value = .Cells("qty").Value
                numReplace.Maximum = .Cells("qty").Value - .Cells("replaced").Value
            Else
                MsgBox("Drugs all already changed")
            End If
        End With
    End Sub

    Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sql.addparam("@id", returid)
        sql.execquery("select * from retur where id=@id")
        If txtDrug.Text = "" Or numQty.Value = 1 Then
            MsgBox("please fill all the blank")
        Else
            If MsgBox("Really?", vbYesNo) = vbYes Then
                If dgv1.RowCount > 1 Then
                    sql.addparam("@replace", numReplace.Value)
                    sql.addparam("@id", returid)
                    sql.execquery("update retur set replaced+=@replace where id=@id")
                    sql.addparam("@stock", numReplace.Value)
                    sql.addparam("@did", drugid)
                    sql.execquery("update drugs set stock+=@stock where id=@id")
                    numQty.Enabled = True
                    numReplace.Enabled = False
                    cleandata()
                Else
                    sql.addparam("@id", returid)
                    sql.addparam("@did", drugid)
                    sql.addparam("@date", dtpRetur.Value.Date)
                    sql.addparam("@qty", numQty.Value)
                    sql.execquery("insert into retur(did,qty,replaced,returdate) values(@did,@qty,0,@date) ")
                    sql.addparam("@qty", numQty.Value)
                    sql.addparam("@did", drugid)
                    sql.execquery("update drugs set stock-=@qty where id=@did")
                    cleandata()
                End If
            End If
        End If
    End Sub
    Sub cleandata()
        loaddata()
        txtDrug.Clear()
        numQty.Value = 1
        numReplace.Value = 1
        drugid = 0
        returid = 0
        dtpRetur.Value = DateTime.Now
        findlastid()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cleandata()
    End Sub
End Class