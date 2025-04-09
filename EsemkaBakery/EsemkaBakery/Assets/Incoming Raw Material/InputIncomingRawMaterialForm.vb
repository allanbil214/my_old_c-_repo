Public Class InputIncomingRawMaterialForm
    Private linq As New LinQDataContext
    Private sql As New Squek
    Private empid As Integer
    Private rawid As Integer
    Private latestid As Integer
    Sub loaddata()
        dgv1.Rows.Clear()
        Dim no As Integer = 1
        For Each r In linq.IncomingRawMaterialHeaders
            For Each s In linq.IncomingRawMaterialDetails
                dgv1.Rows.Add(no, r.IncomingRawMaterialId, r.IncomingDate, r.EmployeeId, r.Description, s.RawMaterialId, s.BestBeforeDate, s.WeightInGram)
                no += 1
            Next
        Next
    End Sub
    Sub Cleaning()
        txtWeight.Clear()
        txtDesc.Clear()
        dgv1.ClearSelection()
    End Sub
    Sub loadcbmaterial()
        sql.ExecQuery("select * from RawMaterial")
        For Each r As DataRow In sql.Dbdt.Rows
            cbMaterialName.Items.Add(r("RawMaterialName"))
        Next
    End Sub
    Sub loadcbemp()
        sql.ExecQuery("Select * from Employee")
        For Each r As DataRow In sql.Dbdt.Rows
            cbEmpName.Items.Add(r("EmployeeName"))
        Next
    End Sub
    Private Sub InputIncomingRawMaterialForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
        loadcbemp()
        loadcbmaterial()
    End Sub
    Sub findempid()
        sql.AddParam("@id", cbEmpName.Text)
        sql.ExecQuery("select * from employee where employeename=@id")
        For Each r As DataRow In sql.Dbdt.Rows
            empid = r("employeeid")
        Next
    End Sub
    Sub findrawid()
        sql.AddParam("@id", cbMaterialName.Text)
        sql.ExecQuery("select * from rawmaterial where rawmaterialname=@id")
        For Each r As DataRow In sql.Dbdt.Rows
            rawid = r("rawmaterialid")
        Next
    End Sub
    Sub insertheader()
        Dim newIncoming As New IncomingRawMaterialHeader
        newIncoming.IncomingDate = dateIncoming.Value.Date
        findempid()
        newIncoming.EmployeeId = empid
        newIncoming.Description = txtDesc.Text
        linq.IncomingRawMaterialHeaders.InsertOnSubmit(newIncoming)
    End Sub
    Sub insertdetail()
        Dim newincoming2 As New IncomingRawMaterialDetail
        findrawid()
        newincoming2.IncomingRawMaterialId = latestid
        newincoming2.RawMaterialId = rawid
        newincoming2.BestBeforeDate = dateBestBefore.Value.Date
        newincoming2.WeightInGram = txtWeight.Text
        linq.IncomingRawMaterialDetails.InsertOnSubmit(newincoming2)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtDesc.Text = "" Or cbEmpName.Text = "" Or cbMaterialName.Text = "" Or txtWeight.Text = "" Then
            MsgBox("Fill the field first!")
        Else
            insertheader()
            insertdetail()
            dgv1.Rows.Add(dgv1.RowCount + 1, "New", dateIncoming.Value.Date, empid, txtDesc.Text, rawid, dateBestBefore.Value.Date, txtWeight.Text)
            Cleaning()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        linq.SubmitChanges()
        Cleaning()
        loaddata()
    End Sub

End Class
