Public Class Form2
    Dim oLAMA As Integer
    Private Sub BERSIH_LAYAR()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        LBLMulai.Text = ""
        LBLselesai.Text = ""
        LBLBiaya.Text = ""
        CheckBox1.Checked = False
        CheckBox2.Checked = False

    End Sub


    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BERSIH_LAYAR()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            LBLMulai.Text = Now() 'Format(Now(), "dd--MMM-yyyy HH:mm:ss")'
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LBLselesai.Text = Now() 'Format(Now(), "dd--MMM-yyyy HH:mm:ss")'
        oLAMA = DateDiff(DateInterval.Second, CDate(LBLMulai.Text),
                               CDate(LBLselesai.Text))
        If oLAMA Mod 10 = 0 Then LAMA.Text = oLAMA



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Enabled = False
        Dim uangAwal As Integer = 3000
        Dim uangTambah As Integer = 2000
        Dim uangWarna As Integer = 1000
        Dim uangHitam As Integer = 500


        Dim jamAwal As Integer = 0
        Dim jamTambah As Integer = 0
        Dim hasil As Integer = 0

        oLAMA = Val(LAMA.Text)
        jamAwal = oLAMA \ 60
        jamTambah = oLAMA Mod 60

        If jamAwal = 0 Then

            If jamTambah > 0 Then
                hasil = 1 * uangAwal
            ElseIf jamTambah = 0 Then
                hasil = 0 * uangAwal
            End If

        ElseIf jamAwal > 0 Then

            If jamTambah > 0 Then
                jamAwal = jamAwal + 1
                hasil = 1 * 3000
                hasil = hasil + ((jamAwal - 1) * 2000)
            Else
                hasil = 1 * 3000
                hasil = hasil + ((jamAwal - 1) * 2000)
            End If

        End If
        If CheckBox1.Checked = True And Val(TextBox2.Text) > 0 Then
            hasil = hasil + (Val(TextBox2.Text) * uangWarna)
        End If
        If CheckBox1.Checked = True And Val(TextBox3.Text) > 0 Then
            hasil = hasil + (Val(TextBox3.Text) * uangWarna)
        End If
        LBLBiaya.Text = Format(hasil, "##0,00")

    End Sub

    
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub LAMA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LAMA.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub LBLBiaya_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBLBiaya.Click

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub LBLselesai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBLselesai.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub LBLMulai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBLMulai.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class