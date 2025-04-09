Public Class MemberForm
    Dim sql As New Squek
    Dim memberid As String
    Dim inorup As String
    Dim emailcount As String

    Public Sub loaddata()
        sql.execquery("select * from member where not memberid='M00000000'")
        dgv1.DataSource = sql.dbdt
        expdate.Value = Date.Today.AddMonths(1)
        nowdate.Value = Date.Today.AddMonths(1)
    End Sub
    Public Sub coalescemax()
        Dim year As Integer = Date.Today.Year
        Dim countmid As Integer
        Dim pluscount As Integer
        Dim stringmid As string
        sql.execquery("select coalesce(max(memberid),'00000000') as maxi from member")
        For Each r As DataRow In sql.dbdt.Rows
            memberid = r("maxi")
            countmid = Mid(memberid, 5)
            pluscount = 100000 + countmid + 1
            stringmid = "M" + year.ToString + Mid(pluscount, 3).ToString
            txtmemid.Text = stringmid.ToString
        Next
    End Sub
    Private Sub MemberForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
    End Sub
    Private Sub insertdata()
        sql.addparam("@memid", txtmemid.Text)
        sql.addparam("@name", txtname.Text)
        sql.addparam("@email", txtemail.Text)
        sql.addparam("@number", txtnum.Text)
        sql.addparam("@date", expdate.Value)
        sql.execquery("insert into member(memberid,name,email,handphone,expired) values (@memid,@name,@email,@number,@date)")
        If sql.hasexception(True) Then Exit Sub
        MsgBox("Success", vbOKOnly, "Success")
    End Sub
    Private Sub updatedata()
        sql.addparam("@memid", txtmemid.Text)
        sql.addparam("@name", txtname.Text)
        sql.addparam("@email", txtemail.Text)
        sql.addparam("@number", txtnum.Text)
        sql.addparam("@date", expdate.Value)
        sql.execquery("update member set name=@name,email=@email,handphone=@number,expired=@date where memberid=@memid ")
        If sql.hasexception(True) Then Exit Sub
        MsgBox("Success", vbOKOnly, "Success")
    End Sub
    Private Sub countemail()
        sql.addparam("@id", txtemail.Text)
        sql.execquery("select count(email) as emailcount from member where email=@id")
        For Each r As DataRow In sql.dbdt.Rows
            emailcount = r("emailcount")
        Next
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nowdate.Visible = False
        expdate.Visible = True
        Button1.Enabled = False
        txtmemid.Enabled = True
        txtname.Enabled = True
        txtemail.Enabled = True
        txtnum.Enabled = True
        Button3.Enabled = False
        Button2.Enabled = True
        Button4.Enabled = True
        expdate.Enabled = True
        coalescemax()
        inorup = "in"

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        nowdate.Visible = True
        expdate.Visible = False
        Button3.Enabled = False
        Button1.Enabled = False
        Button2.Enabled = True
        Button4.Enabled = True
        txtmemid.Enabled = True
        txtname.Enabled = True
        txtemail.Enabled = True
        txtnum.Enabled = True
        dgv1.Enabled = True
        inorup = "up"
        expdate.Enabled = True
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        countemail()
        If inorup = "in" Then
            If txtname.Text = "" Or txtnum.Text = "" Or txtemail.Text = "" Then
                MsgBox("Blank Data!", vbOKOnly, "Caution")
            ElseIf expdate.Value <= Date.Today Then
                MsgBox("Expired Date must greater than today!", vbOKOnly, "Caution")
            Else
                If IsNumeric(txtnum.Text) Then
                    If emailcount = "1" Then
                        MsgBox("Email already exist", vbOKOnly, "Caution")
                    ElseIf emailcount = "0" Then
                        If txtnum.TextLength < 10 Then
                            MsgBox("Incorrect Phone Number", vbOKOnly, "Caution")
                        Else
                            insertdata()
                        End If
                    End If
                Else
                    MsgBox("Call Number must in numeric!", vbOKOnly, "Caution")
                End If
            End If
        ElseIf inorup = "up" Then
            If txtname.Text = "" Or txtnum.Text = "" Or txtemail.Text = "" Then
                MsgBox("Blank Data!", vbOKOnly, "Caution")
            ElseIf expdate.Value <= Date.Today Then
                MsgBox("Expired Date must greater than today!", vbOKOnly, "Caution")
            Else
                If IsNumeric(txtnum.Text) Then
                    If txtnum.TextLength < 10 Then
                        MsgBox("Incorrect Phone Number", vbOKOnly, "Caution")
                    Else
                        updatedata()
                    End If
                Else
                    MsgBox("Call Number must in numeric!", vbOKOnly, "Caution")
                End If
            End If
        End If
        txtmemid.Text = ""
        txtname.Text = ""
        txtnum.Text = ""
        txtemail.Text = ""
        dgv1.Enabled = False
        expdate.Value = Date.Today.AddMonths(1)
        Button1.Enabled = True
        Button2.Enabled = False
        Button3.Enabled = True
        Button4.Enabled = False
        txtemail.Enabled = False
        txtname.Enabled = False
        txtnum.Enabled = False
        txtmemid.Enabled = False
        expdate.Enabled = False
        expdate.Visible = True
        nowdate.Visible = False
        loaddata()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txtmemid.Text = ""
        txtname.Text = ""
        txtnum.Text = ""
        txtemail.Text = ""
        dgv1.Enabled = False
        expdate.Value = Date.Today.AddMonths(1)
        Button1.Enabled = True
        Button2.Enabled = False
        Button3.Enabled = True
        Button4.Enabled = False
        txtemail.Enabled = False
        txtname.Enabled = False
        txtnum.Enabled = False
        txtmemid.Enabled = False
        expdate.Enabled = False
        expdate.Visible = True
        nowdate.Visible = False
    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        Dim i As Integer
        i = dgv1.CurrentRow.Index
        txtmemid.Text = dgv1.Item(0, i).Value
        txtname.Text = dgv1.Item(1, i).Value
        txtemail.Text = dgv1.Item(2, i).Value
        txtnum.Text = dgv1.Item(3, i).Value
        nowdate.Value = dgv1.Item(4, i).Value

    End Sub

    Private Sub expdate_ValueChanged(sender As Object, e As EventArgs) Handles expdate.ValueChanged
        If expdate.Value < Date.Now Then
            expdate.Value = expdate.Value.AddDays(1)
        End If
    End Sub
End Class