Public Class Form3

    Private Sub BERSIHLAYAR()
        TextBox1.Text = "" : TextBox3.Text = "" : TextBox4.Text = "" : TextBox5.Text = ""
        TextBox6.Text = "" : LBLBiaya.Text = "" : cmb.Text = ""
    End Sub
    Private Sub HITUNG_CICILAN()
        Dim Jumlah As Long, Bunga As Double
        Dim CiciPokok As Double, CiciBunga As Double

        Bunga = CDbl(TextBox5.Text) / 12
        Jumlah = (Val(TextBox3.Text) - Val(TextBox4.Text))
        CiciPokok = Jumlah / Val(TextBox6.Text)
        CiciBunga = Jumlah * Bunga / 100
        LBLBiaya.Text = Format(CiciPokok + CiciBunga, "##0.00")

    End Sub
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim judul() As String = {"Nopol", "Jenis", "Harga", "DP", "Bunga", "lama", "Jumlah"}
        Dim lebar() As String = {90, 130, 75, 75, 40, 40, 75}
        grd.ColumnCount = 7
        For i As Integer = 0 To 6
            grd.Columns(i).Name = judul(i)
            grd.Columns(i).Width = lebar(i)
            If i > 1 Then
                grd.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                grd.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End If
        Next

        cmb.Items.Add("Honda")
        cmb.Items.Add("Suzuki")
        cmb.Items.Add("Yamaha")
        cmb.Items.Add("Kawasaki")
        cmb.Items.Add("Ducati")

        BERSIHLAYAR()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub grd_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd.CellContentClick

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then cmb.Focus()
    End Sub
    Private Sub cmb_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb.KeyPress
        If e.KeyChar = Chr(13) Then TextBox3.Focus()
    End Sub
    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If e.KeyChar = Chr(13) Then TextBox4.Focus()
    End Sub
    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If e.KeyChar = Chr(13) Then TextBox5.Focus()
    End Sub

    Private Sub TextBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        If e.KeyChar = Chr(13) Then TextBox5.Focus()
    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If e.KeyChar = Chr(13) Then Button1.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        HITUNG_CICILAN()
        Dim tanya As Object
        tanya = MsgBox("Apakah Data Sudah Benar ?", MsgBoxStyle.YesNo, "Simpan Data")
        If tanya = MsgBoxResult.Yes Then
            grd.Rows.Add(TextBox1.Text, cmb.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, LBLBiaya.Text)

            BERSIHLAYAR()
            TextBox1.Focus()
        End If
    End Sub

    Private Sub grd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd.Click
        TextBox1.Text = grd.Item(0, grd.CurrentRow.Index).Value
        cmb.Text = grd.Item(1, grd.CurrentRow.Index).Value
        TextBox3.Text = grd.Item(2, grd.CurrentRow.Index).Value
        TextBox4.Text = grd.Item(3, grd.CurrentRow.Index).Value
        TextBox5.Text = grd.Item(4, grd.CurrentRow.Index).Value
        TextBox6.Text = grd.Item(5, grd.CurrentRow.Index).Value
        LBLBiaya.Text = grd.Item(6, grd.CurrentRow.Index).Value
    End Sub

    
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        HITUNG_CICILAN()
        Dim tanya As Object
        tanya = MsgBox("Apakah Data Sudah Benar ?", MsgBoxStyle.YesNo, "Update Data")
        If tanya = MsgBoxResult.Yes Then

            For i As Integer = 0 To grd.Rows.Count - 1
                If Trim(grd.Item(0, i).Value) = Trim(TextBox1.Text) Then
                    grd.Item(1, i).Value = cmb.Text
                    grd.Item(2, i).Value = TextBox3.Text
                    grd.Item(3, i).Value = TextBox4.Text
                    grd.Item(4, i).Value = TextBox5.Text
                    grd.Item(5, i).Value = TextBox6.Text
                    grd.Item(6, i).Value = LBLBiaya.Text
                End If
            Next


            BERSIHLAYAR()
            TextBox1.Focus()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        HITUNG_CICILAN()
        Dim tanya As Object
        tanya = MsgBox("Apakah Data Yakin Akan di Hapus ?", MsgBoxStyle.YesNo, "Update Data")
        If tanya = MsgBoxResult.Yes Then

            For i As Integer = 0 To grd.Rows.Count - 1
                If Trim(grd.Item(0, i).Value) = Trim(TextBox1.Text) Then
                    grd.Rows.RemoveAt(i)
                    
                End If
            Next


            BERSIHLAYAR()
            TextBox1.Focus()
        End If
    End Sub
End Class