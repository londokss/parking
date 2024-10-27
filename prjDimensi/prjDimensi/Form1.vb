Public Class Form1
    Dim HASIL As Double


    Private Sub BERSIHIN_LAYAR()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""

        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False
        RadioButton6.Checked = False

    End Sub

    Private Sub HITUNG_LUAS()
        HASIL = Val(TextBox1.Text) * Val(TextBox2.Text)
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar() = Chr(13) Then
            TextBox2.Focus()
        End If
    End Sub


    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        HITUNG_LUAS()
        TextBox3.Text = HASIL

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        BERSIHIN_LAYAR()
        TextBox1.Focus()


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End

    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        If Val(TextBox1.Text) = Val(TextBox2.Text) Then
            HITUNG_LUAS()
            TextBox3.Text = HASIL
        Else
            MsgBox("NILAI 1 DAN NILAI 2 HARUS HARUS MEMILIKI NILAI YANG SAMA")
        End If


    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        If Val(TextBox1.Text) = Val(TextBox2.Text) Then
            HITUNG_LUAS()
            TextBox3.Text = Format(22 / 7 * HASIL, "##0.00")
        Else
            MsgBox("NILAI 1 DAN NILAI 2 HARUS HARUS MEMILIKI NILAI YANG SAMA")
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged

        HITUNG_LUAS()
        TextBox3.Text = Format(1 / 2 * HASIL, "##0.00")


    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        HITUNG_LUAS()
        TextBox3.Text = Format(1 / 2 * HASIL, "##0.00")
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        HITUNG_LUAS()
        TextBox3.Text = HASIL
    End Sub
End Class
