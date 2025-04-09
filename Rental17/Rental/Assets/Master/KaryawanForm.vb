Public Class KaryawanForm
    Private sql As New SquekDataContext
    Private inorup As String
    Private msg = ""
    Sub loaddata()
        dgv1.Rows.Clear()
        Dim i As Integer = 1
        For Each r In sql.Karyawans
            dgv1.Rows.Add(i, r.KaryawanId, r.KaryawanNama, r.Alamat, r.NoHP, r.Username, r.Password, r.Status)
            i += 1
        Next
        Label1.Text = "Total Data : " + sql.Karyawans.Count.ToString
    End Sub
    Sub loadid()
        txtId.Text = "New"
    End Sub
    Private Sub KaryawanForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
        ComboBox1.Items.Add("Kasir")
        ComboBox1.Items.Add("Manajer")
        ComboBox1.Text = "Manajer"
    End Sub

    Private Sub searchBox_TextChanged(sender As Object, e As EventArgs) Handles searchBox.TextChanged
        Dim loaddata = dgv1.Rows.Cast(Of DataGridViewRow).Where(Function(x) x.Cells(2).Value.ToString.ToLower.Contains(searchBox.Text))
        For Each r As DataGridViewRow In dgv1.Rows
            r.Visible = False
        Next
        For Each r As DataGridViewRow In loaddata
            r.Visible = True
        Next
    End Sub

    Sub cleaning()
        txtAlamat.Clear()
        txtId.Clear()
        txtNama.Clear()
        txtNoHp.Clear()
        txtPassword.Clear()
        txtUser.Clear()
        dgv1.ClearSelection()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        inorup = "in"
        GroupBox1.Enabled = True
        ButtonAtas.Enabled = False
        ButtonBawah.Enabled = True
        dgv1.Enabled = False
        cleaning()
        loadid()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtNama.Text = "" Then
            MsgBox("Pilih data dulu")
        Else
            inorup = "up"
            GroupBox1.Enabled = True
            ButtonAtas.Enabled = False
            ButtonBawah.Enabled = True
            dgv1.Enabled = False
        End If
    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        Dim r As DataGridViewRow = dgv1.CurrentRow
        txtId.Text = r.Cells(1).Value.ToString
        txtNama.Text = r.Cells(2).Value.ToString
        txtAlamat.Text = r.Cells(3).Value.ToString
        txtNoHp.Text = r.Cells(4).Value.ToString
        txtUser.Text = r.Cells(5).Value.ToString
        txtPassword.Text = r.Cells(6).Value.ToString
        ComboBox1.Text = r.Cells(7).Value.ToString
    End Sub
    Sub backnormal()
        inorup = "no"
        GroupBox1.Enabled = False
        ButtonAtas.Enabled = True
        ButtonBawah.Enabled = False
        dgv1.Enabled = True
        cleaning()
    End Sub
    Sub deletedata()
        Dim karyawan As New Karyawan
        karyawan = sql.Karyawans.Single(Function(x) x.KaryawanId = txtId.Text)
        sql.Karyawans.DeleteOnSubmit(karyawan)
        sql.SubmitChanges()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txtNama.Text = "" Then
            MsgBox("Pilih data dulu")
        Else
            If MsgBox("Yakin?", vbYesNo) = vbYes Then
                deletedata()
                inorup = "no"
                GroupBox1.Enabled = False
                ButtonAtas.Enabled = True
                ButtonBawah.Enabled = False
                dgv1.Enabled = True
                cleaning()
                backnormal()
                loaddata()
            End If
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        backnormal()
    End Sub

    Sub insertdata()
        Dim karyawan As New Karyawan()
        karyawan.KaryawanNama = txtNama.Text
        karyawan.Alamat = txtAlamat.Text
        karyawan.NoHP = txtNoHp.Text
        karyawan.Username = txtUser.Text
        karyawan.Password = txtPassword.Text
        karyawan.Status = ComboBox1.Text
        sql.Karyawans.InsertOnSubmit(karyawan)
        sql.SubmitChanges()
        loaddata()
        backnormal()
    End Sub
    Sub updatedata()
        Dim karyawan As New Karyawan()
        karyawan = sql.Karyawans.Single(Function(x) x.KaryawanId = txtId.Text)
        karyawan.KaryawanNama = txtNama.Text
        karyawan.Alamat = txtAlamat.Text
        karyawan.NoHP = txtNoHp.Text
        karyawan.Username = txtUser.Text
        karyawan.Password = txtPassword.Text
        karyawan.Status = ComboBox1.Text
        sql.SubmitChanges()
        loaddata()
        backnormal()
    End Sub
    Function validasi()
        Dim result As Boolean = False
        If txtId.Text = "" Then
            msg = "Id kosong!"
        ElseIf txtNama.Text = "" Then
            msg = "Nama kosong!"
        ElseIf txtAlamat.Text = "" Then
            msg = "Alamat kosong!"
        ElseIf txtNoHp.Text = "" Then
            msg = "Nomor HP tidak boleh kosong!"
        ElseIf txtPassword.Text = "" Then
            msg = "Password tidak boleh kosong!"
        ElseIf txtUser.Text = "" Then
            msg = "Username tidak boleh kosong!"
        Else
            result = True
        End If
        Return result
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If validasi() Then
            If Not IsNumeric(txtNoHp.Text) Then
                MsgBox("No HP harus numeric")
            Else
                If inorup = "in" Then
                    insertdata()
                ElseIf inorup = "up" Then
                    updatedata()
                End If
            End If
        Else
                MsgBox(msg, vbCritical, "Error!")
        End If
    End Sub
End Class