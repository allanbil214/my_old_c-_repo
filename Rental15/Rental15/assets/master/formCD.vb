Public Class formCD
    Private sql As New Squek
    Private cdid As Integer
    Private inorup As String = ""
    Sub loaddata()
        sql.addparam("@text", "%" & txtCari.Text & "%")
        sql.execquery("select * from cd where judul like @text")
        dgv1.DataSource = sql.dbdt
    End Sub
    Sub cleaning()
        txtJudul.Clear()
        cbTipe.Text = "Blu-Ray"
        numStok.Value = 1
        numHarga.Value = 1000
    End Sub
    Sub aktif()
        gbData.Enabled = True
        dgv1.Enabled = False
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = True
        Button5.Enabled = True
    End Sub
    Sub deaktif()
        gbData.Enabled = False
        dgv1.Enabled = True
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = False
        Button5.Enabled = False
    End Sub
    Private Sub formCD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
        cbTipe.Items.Add("Blu-Ray")
        cbTipe.Items.Add("DVD")
        cbTipe.Items.Add("CD")
        cbTipe.Text = "Blu-Ray"
        If dgv1.RowCount > 1 Then
            dgv1.Columns(0).Visible = False
        End If
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        loaddata()
    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        Dim i As Integer = dgv1.CurrentRow.Index
        cdid = dgv1.Item(0, i).Value
        txtJudul.Text = dgv1.Item(1, i).Value
        cbTipe.Text = dgv1.Item(2, i).Value
        numStok.Value = dgv1.Item(3, i).Value
        numHarga.Value = dgv1.Item(4, i).Value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        inorup = "insert"
        cleaning()
        aktif()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        inorup = "update"
        aktif()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txtJudul.Text = "" Then
            MsgBox("pilih dulu")
        Else
            If MsgBox("hapus?", vbYesNo) = vbYes Then
                sql.addparam("@id", cdid)
                sql.execquery("delete cd where id=@id")
                If sql.hascecep(True) Then Exit Sub
                MsgBox("terhapus")
                cleaning()
                deaktif()
                loaddata()
            End If
        End If
    End Sub
    Sub insertdata()
        sql.addparam("@id", cdid)
        sql.addparam("@judul", txtJudul.Text)
        sql.addparam("@tipe", cbTipe.Text)
        sql.addparam("@stok", numStok.Value)
        sql.addparam("@harga", numHarga.Value)
        sql.execquery("insert into cd(judul,tipe,stok,harga) values(@judul,@tipe,@stok,@harga) ")
        If sql.hascecep(True) Then Exit Sub
        MsgBox("sukses")
        cleaning()
        deaktif()
        loaddata()
    End Sub
    Sub updatedata()
        sql.addparam("@id", cdid)
        sql.addparam("@judul", txtJudul.Text)
        sql.addparam("@tipe", cbTipe.Text)
        sql.addparam("@stok", numStok.Value)
        sql.addparam("@harga", numHarga.Value)
        sql.execquery("update cd set judul=@judul,tipe=@tipe,stok=@stok,harga=@harga where id=@id ")
        If sql.hascecep(True) Then Exit Sub
        MsgBox("sukses")
        cleaning()
        deaktif()
        loaddata()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If inorup = "insert" Then
            If txtJudul.Text = "" Or numHarga.Value = 0 Or numStok.Value = 0 Then
                MsgBox("isi dulu")
            Else
                insertdata()
            End If
        ElseIf inorup = "update" Then
            If txtJudul.Text = "" Or numHarga.Value = 0 Or numStok.Value = 0 Then
                MsgBox("isi dulu")
            Else
                updatedata()
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cleaning()
        deaktif()
    End Sub
End Class