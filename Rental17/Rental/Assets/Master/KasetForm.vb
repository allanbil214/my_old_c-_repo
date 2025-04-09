Public Class KasetForm
    Private sql As New SquekDataContext
    Private inorup As String = "no"
    Private msg = ""

    Sub loaddata()
        dgv1.Rows.Clear()
        Dim i As Integer = 1
        For Each r In sql.Kasets
            dgv1.Rows.Add(i, r.KasetId, r.KasetNama, r.Jenis, r.Harga, r.Stok)
            i += 1
        Next
        Label1.Text = "Total Data : " + sql.Kasets.Count.ToString
    End Sub
    Sub loadid()
        txtId.Text = "New"
    End Sub
    Sub loadcb()
        If cbJenis.Items IsNot Nothing Then cbJenis.Items.Clear()
        cbJenis.Items.Add("BluRay")
        cbJenis.Items.Add("CD")
        cbJenis.Items.Add("DVD")
        cbJenis.Text = "BluRay"
    End Sub
    Private Sub textCari_TextChanged(sender As Object, e As EventArgs) Handles searchBox.TextChanged
        Dim hasil = dgv1.Rows.Cast(Of DataGridViewRow).Where(Function(x) x.Cells(2).Value.ToString.ToLower.Contains(searchBox.Text))
        For Each item As DataGridViewRow In dgv1.Rows
            item.Visible = False
        Next
        For Each newitem As DataGridViewRow In hasil
            newitem.Visible = True
        Next
    End Sub
    Sub cleaning()
        txtId.Clear()
        txtNama.Clear()
        numHarga.Value = 1000
        numStok.Value = 1
        dgv1.ClearSelection()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        inorup = "in"
        GroupBox1.Enabled = True
        ButtonAtas.Enabled = False
        ButtonBawah.Enabled = True
        dgv1.Enabled = False
        cleaning()
        loadcb()
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
            loadcb()
        End If
    End Sub
    Sub deletedata()
        Dim kaset As New Kaset
        kaset = sql.Kasets.Single(Function(x) x.KasetId = txtId.Text)
        sql.Kasets.DeleteOnSubmit(kaset)
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

    Private Sub KasetForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
        loadcb()
    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        Dim r As DataGridViewRow = dgv1.CurrentRow
        txtId.Text = r.Cells(1).Value.ToString
        txtNama.Text = r.Cells(2).Value.ToString
        cbJenis.Text = r.Cells(3).Value.ToString
        numHarga.Value = r.Cells(4).Value.ToString
        numStok.Value = r.Cells(5).Value.ToString
    End Sub
    Sub backnormal()
        inorup = "no"
        GroupBox1.Enabled = False
        ButtonAtas.Enabled = True
        ButtonBawah.Enabled = False
        dgv1.Enabled = True
        cleaning()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        backnormal()
    End Sub

    Sub insertdata()
        Dim kaset As New Kaset()
        kaset.KasetNama = txtNama.Text
        kaset.Jenis = cbJenis.Text
        kaset.Harga = numHarga.Value
        kaset.Stok = numStok.Value
        sql.Kasets.InsertOnSubmit(kaset)
        sql.SubmitChanges()
        loaddata()
        backnormal()
    End Sub
    Sub updatedata()
        Dim kaset As New Kaset()
        kaset = sql.Kasets.Single(Function(x) x.KasetId = txtId.Text)
        kaset.KasetNama = txtNama.Text
        kaset.Jenis = cbJenis.Text
        kaset.Harga = numHarga.Value
        kaset.Stok = numStok.Value
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
        ElseIf numHarga.Value <= 0 Then
            msg = "Harga tidak valid"
        ElseIf numStok.Value <= 0 Then
            msg = "Stok tidak valid"
        Else
            result = True
        End If
        Return result
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If validasi() Then
            If numHarga.Value > 0 Or numStok.Value > 0 Then
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
