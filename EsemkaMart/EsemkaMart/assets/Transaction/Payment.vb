Public Class Payment
    Dim sql As New Squek
    Dim id As Integer
    Dim dates As New DateTimePicker
    Dim expirationdate As New DateTimePicker
    Dim countsubtotal As Integer
    Dim checking As String
    Dim discounted As Integer
    Dim realdiscount As Integer
    Public trxid As String
    Public dater As String
    Public employeeid As Integer
    Dim numyousafe As Integer = 0
    Public yousafe As Integer = 0

    Private Sub nofilth()
        TextBox1.Text = ""
        TextBox1.ReadOnly = False
        Button1.Enabled = True
        subtotal.Text = "0"
        discount.Text = "0"
        realdiscount = "0"
        total.Text = "0"
        TextBox6.Text = ""
    End Sub
    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nofilth()
        subtotal.Text = Transaction.subtotal
        total.Text = Transaction.subtotal
        dates.Value = DateTime.Now
        trxid = Transaction.Label10.Text
        dater = Transaction.Label12.Text
        employeeid = formMain.empid
        yousafe = Transaction.yousafe
    End Sub
    Private Sub counting()
        discounted = Val((realdiscount / 100) * subtotal.Text)
        total.Text = Val(subtotal.Text - discounted)
        numyousafe = Val(yousafe + subtotal.Text * realdiscount / 100)
        yousafe = numyousafe
    End Sub
    Private Sub expiration()
        sql.addparam("@id", TextBox1.Text)
        sql.execquery("select * from member where memberid=@id")
        For Each r As DataRow In sql.dbdt.Rows
            expirationdate.Value = r("expired")
            checking = r("Name")
        Next
        If dates.Value.Date > expirationdate.Value.Date Then
            MsgBox("Your member card is expired", vbOKOnly, "Sad :(")
        Else
            MsgBox("Member identified as " + checking, vbOKOnly, "Congrats")
            realdiscount = Val(realdiscount + 1)
            discount.Text = realdiscount.ToString + "%"
            TextBox1.ReadOnly = True
            Button1.Enabled = False
            counting()
        End If
    End Sub
    Private Sub cekmember()
        sql.addparam("@id", TextBox1.Text)
        sql.execquery("select count(MemberID) as idcount from Member where MemberID=@id")
        For Each r As DataRow In sql.dbdt.Rows
            id = r("idcount")
        Next
        If id = 1 Then
            expiration()
        ElseIf id = 0 Then
            MsgBox("MemberID is incorrect please retype again", vbOKOnly, "Warning")
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cekmember()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TextBox6.ReadOnly = False
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TextBox6.ReadOnly = True
    End Sub
    Private Sub inserheadertrx()
        If TextBox1.Text = "" Then
            sql.addparam("@id", trxid)
            sql.addparam("@date", dater)
            sql.addparam("@empid", employeeid)
            sql.execquery("Update headertrx set TrxID=@id,Date=@date,EmployeeID=@empid,MemberID='M00000000'")
            If sql.hascecep(True) Then Exit Sub
            MsgBox("HeaderTrx Successful added", vbOKOnly, "Success")
        Else
            sql.addparam("@id", trxid)
            sql.addparam("@date", dater)
            sql.addparam("@empid", employeeid)
            sql.addparam("@memid", TextBox1.Text)
            sql.execquery("Update headertrx set TrxID=@id,Date=@date,EmployeeID=@empid,MemberID=@memid")
            If sql.hascecep(True) Then Exit Sub
            MsgBox("HeaderTrx Successful added", vbOKOnly, "Success")
            updatesellprice()
        End If
    End Sub
    Private Sub updateheadermemb()
        If TextBox1.Text = "" Then
        Else
            sql.addparam("@id", trxid)
            sql.addparam("@memid", TextBox1.Text)
            sql.execquery("update headertrx set MemberID=@memid where TrxID=@id")
            If sql.hascecep(True) Then Exit Sub
            MsgBox("HeaderTrx Successful added", vbOKOnly, "Success")
            updatesellprice()
        End If
    End Sub
    Private Sub updatesellprice()
        sql.addparam("@id", trxid)
        sql.execquery("update DetailTrx set sellprice=(SellPrice - (SellPrice * 1 / 100)) where TrxID=@id")
        If sql.hascecep(True) Then Exit Sub
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Receipt.ShowDialog()
        updateheadermemb()
        Me.Close()

    End Sub
End Class