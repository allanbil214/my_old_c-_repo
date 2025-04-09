Public Class formSearch
    Private sql As New Squek
    Public whatisit As String = ""
    Public whatform As String = ""
    '------- \/ --------
    Private drugid As Integer = 0
    Private drugname As String = ""
    Private drugcost As Integer = 0
    Private drugbasestock As Integer = 0
    '------- \/ --------
    Private memid As Integer = 0
    Private memname As String = ""
    '------- \/ --------
    Private supid As Integer = 0
    Private supname As String = ""
    Sub loadsup()
        sql.addparam("@text", "%" & txtSearch.Text & "%")
        sql.execquery("select * from supplier where name like @text")
        dgv1.DataSource = sql.dbdt
    End Sub

    Sub loadmem()
        sql.addparam("@text", "%" & txtSearch.Text & "%")
        sql.execquery("select * from member where name like @text")
        dgv1.DataSource = sql.dbdt
    End Sub
    Sub loaddrug()
        sql.addparam("@text", "%" & txtSearch.Text & "%")
        sql.execquery("select * from drugs where name like @text")
        dgv1.DataSource = sql.dbdt
    End Sub
    Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As DataGridViewCellFormattingEventArgs) Handles dgv1.CellFormatting
        For i As Integer = 0 To dgv1.Rows.Count - 1
            If dgv1.Rows(i).Cells("ExpireDate").Value <= DateTime.Now Then
                dgv1.Rows(i).Cells("ExpireDate").Style.ForeColor = Color.Red
            End If
        Next
    End Sub
    Private Sub formSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If whatisit = "mem" Then
            loadmem()
        ElseIf whatisit = "sup" Then
            loadsup
        ElseIf whatisit = "drug" Then
            loaddrug()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If whatisit = "mem" Then
            loadmem()
        ElseIf whatisit = "sup" Then
            loadsup()
        ElseIf whatisit = "drug" Then
            loaddrug()
        End If
    End Sub

    Private Sub dgv1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellDoubleClick
        Dim i As Integer = dgv1.CurrentRow.Index
        If whatisit = "drug" Then
            drugid = dgv1.Item(0, i).Value
            drugname = dgv1.Item(1, i).Value
            drugcost = dgv1.Item(2, i).Value
            drugbasestock = dgv1.Item(3, i).Value
        ElseIf whatisit = "sup" Then
            supid = dgv1.Item(0, i).Value
            supname = dgv1.Item(1, i).Value
        ElseIf whatisit = "mem" Then
            memid = dgv1.Item(0, i).Value
            memname = dgv1.Item(1, i).Value
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If whatisit = "mem" Then
            If memid = 0 Or memname = "" Then
                MsgBox("Select data first!")
            Else
                formSale.memid = memid
                formSale.txtMem.Text = memname
                formSale.Button5.Enabled = False
                Me.Close()
            End If
        ElseIf whatisit = "sup" Then
            If supid = 0 Or supname = "" Then
                MsgBox("Select data first!")
            Else
                formPurchase.supid = supid
                formPurchase.txtSup.Text = supname
                Me.Close()
            End If
        ElseIf whatisit = "drug" Then
            If whatform = "sale" Then
                If drugid = 0 Or drugname = "" Then
                    MsgBox("Select data first!")
                Else
                    formSale.drugid = drugid
                    formSale.txtDrug.Text = drugname
                    formSale.txtCost.Text = drugcost
                    formSale.drugbasestock = drugbasestock
                    Me.Close()
                End If
            ElseIf whatform = "purchase" Then
                If drugid = 0 Or drugname = "" Then
                    MsgBox("Select data first!")
                Else
                    formPurchase.drugid = drugid
                    formPurchase.txtDrug.Text = drugname
                    formPurchase.txtCost.Text = drugcost
                    formPurchase.drugbasestock = drugbasestock
                    Me.Close()
                End If
            ElseIf whatform = "retur" Then
                If drugid = 0 Or drugname = "" Then
                    MsgBox("Select data first!")
                Else
                    formRetur.drugid = drugid
                    formRetur.txtDrug.Text = drugname
                    formRetur.drugbasestock = drugbasestock
                    Me.Close()
                End If
            End If
        End If
    End Sub
End Class