Public Class Form4
    Dim waktuMasukList As New List(Of Date)
    Dim waktuKeluarList As New List(Of Date)
    Dim timerRunning As Boolean = False

    Private Sub BERSIH_LAYAR()
        TextBox1.Text = ""
        LBLMulai.Text = ""
        LBLselesai.Text = ""
        LBLBiaya.Text = ""
        LAMA.Text = ""
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim waktuMasuk As Date = Now()
            LBLMulai.Text = waktuMasuk.ToString("dd-MM-yyyy HH:mm:ss")
            waktuMasukList.Add(waktuMasuk)
            waktuKeluarList.Add(Nothing)

            Dim row As String() = New String() {grd.Rows.Count + 1, TextBox1.Text, LBLMulai.Text, "", "0", ""}
            grd.Rows.Add(row)

            TextBox1.Clear()
            TextBox1.Focus()

            If Not timerRunning Then
                Timer1.Enabled = True
                timerRunning = True
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        LBLselesai.Text = Now().ToString("dd-MM-yyyy HH:mm:ss")

        If grd.CurrentRow IsNot Nothing AndAlso waktuKeluarList(grd.CurrentRow.Index) Is Nothing Then
            Dim waktuMasuk As Date = waktuMasukList(grd.CurrentRow.Index)
            Dim durasiDetik As Integer = DateDiff(DateInterval.Second, waktuMasuk, Now())
            Dim durasiJam As Integer = durasiDetik \ 3600
            Dim sisaDetik As Integer = durasiDetik Mod 3600
            Dim durasiMenit As Integer = sisaDetik \ 60
            LAMA.Text = $"{durasiJam:D2}:{durasiMenit:D2}:{sisaDetik Mod 60:D2}"
        End If


        For i As Integer = 0 To grd.Rows.Count - 1
            If waktuKeluarList(i) Is Nothing Then
                Dim waktuMasuk As Date = waktuMasukList(i)
                Dim durasiDetik As Integer = DateDiff(DateInterval.Second, waktuMasuk, Now())
                Dim durasiMenit As Integer = durasiDetik \ 60
                grd.Rows(i).Cells(3).Value = durasiMenit
            End If
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If grd.CurrentRow IsNot Nothing Then
            Dim selectedRowIndex As Integer = grd.CurrentRow.Index

            waktuKeluarList(selectedRowIndex) = Now()
            grd.Rows(selectedRowIndex).Cells(4).Value = Now().ToString("dd-MM-yyyy HH:mm:ss") ' Tampilkan waktu keluar

            Dim waktuMasuk As Date = waktuMasukList(selectedRowIndex)
            Dim durasiDetik As Integer = DateDiff(DateInterval.Second, waktuMasuk, waktuKeluarList(selectedRowIndex))
            Dim durasiJam As Integer = durasiDetik \ 3600
            Dim hasil As Integer

            If durasiJam = 0 Then
                hasil = 4000
            ElseIf durasiJam = 1 Then
                hasil = 4000
            ElseIf durasiJam <= 3 Then
                hasil = 4000 + ((durasiJam - 1) * 4000)
            Else
                hasil = 10000
            End If

            ' Mengupdate biaya di DataGridView
            grd.Rows(selectedRowIndex).Cells(5).Value = Format(hasil, "##0,00")
            LBLBiaya.Text = Format(hasil, "##0,00")

            ' Hentikan perhitungan lama parkir untuk baris yang dibayar
            waktuKeluarList(selectedRowIndex) = Now()

            ' Kosongkan label lama jika baris ini dibayar
            If grd.CurrentRow.Index = selectedRowIndex Then
                LAMA.Text = $"{durasiJam:D2}:{(durasiDetik \ 60) Mod 60:D2}:{durasiDetik Mod 60:D2}"
            End If

            ' Cek apakah semua baris sudah memiliki waktu keluar; jika ya, hentikan timer
            If Not waktuKeluarList.Contains(Nothing) Then
                Timer1.Enabled = False
                timerRunning = False
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End ' Menutup aplikasi
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BERSIH_LAYAR()
        Dim judul() As String = {"No", "Nomor Polisi", "Jam Masuk", "Lama (Menit)", "Jam Keluar", "Biaya"}
        Dim lebar() As Integer = {50, 90, 130, 75, 130, 75}

        ' Pastikan jumlah kolom sesuai dengan array
        grd.ColumnCount = judul.Length

        For i As Integer = 0 To judul.Length - 1
            grd.Columns(i).Name = judul(i)
            grd.Columns(i).Width = lebar(i)

            ' Jika kolom index > 1, atur alignment ke kanan
            If i > 1 Then
                grd.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                grd.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End If
        Next
    End Sub

    Private Sub grd_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd.CellContentClick
        ' Kosongkan jika tidak diperlukan
    End Sub

    Private Sub grd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd.Click
        ' Pastikan ada baris yang dipilih sebelum mengakses data
        If grd.CurrentRow IsNot Nothing Then
            TextBox1.Text = grd.Item(1, grd.CurrentRow.Index).Value.ToString()
            LBLMulai.Text = grd.Item(2, grd.CurrentRow.Index).Value.ToString()
            LBLselesai.Text = grd.Item(4, grd.CurrentRow.Index).Value.ToString()
            LBLBiaya.Text = grd.Item(5, grd.CurrentRow.Index).Value.ToString()
        End If
    End Sub
End Class