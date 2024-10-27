<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LBLselesai = New System.Windows.Forms.Label()
        Me.LBLMulai = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LAMA = New System.Windows.Forms.Label()
        Me.LBLBiaya = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.grd = New System.Windows.Forms.DataGridView()
        CType(Me.grd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBLselesai
        '
        Me.LBLselesai.BackColor = System.Drawing.Color.White
        Me.LBLselesai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLselesai.Location = New System.Drawing.Point(234, 130)
        Me.LBLselesai.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLselesai.Name = "LBLselesai"
        Me.LBLselesai.Size = New System.Drawing.Size(194, 23)
        Me.LBLselesai.TabIndex = 13
        '
        'LBLMulai
        '
        Me.LBLMulai.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LBLMulai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLMulai.Location = New System.Drawing.Point(234, 100)
        Me.LBLMulai.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLMulai.Name = "LBLMulai"
        Me.LBLMulai.Size = New System.Drawing.Size(194, 23)
        Me.LBLMulai.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 130)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 23)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Jam Keluar"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 100)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 23)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Jam Masuk"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(234, 52)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(193, 22)
        Me.TextBox1.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 51)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(216, 23)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nomor Kendaraan"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Location = New System.Drawing.Point(544, 51)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(150, 23)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Lama Parkir"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LAMA
        '
        Me.LAMA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LAMA.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAMA.Location = New System.Drawing.Point(544, 75)
        Me.LAMA.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LAMA.Name = "LAMA"
        Me.LAMA.Size = New System.Drawing.Size(150, 107)
        Me.LAMA.TabIndex = 22
        Me.LAMA.Text = "0"
        Me.LAMA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBLBiaya
        '
        Me.LBLBiaya.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLBiaya.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLBiaya.Location = New System.Drawing.Point(459, 200)
        Me.LBLBiaya.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLBiaya.Name = "LBLBiaya"
        Me.LBLBiaya.Size = New System.Drawing.Size(329, 61)
        Me.LBLBiaya.TabIndex = 21
        Me.LBLBiaya.Text = "1,000,000"
        Me.LBLBiaya.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(234, 200)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(178, 47)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Tutup"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(38, 200)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(178, 47)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Bayar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'grd
        '
        Me.grd.AllowUserToAddRows = False
        Me.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd.Location = New System.Drawing.Point(23, 265)
        Me.grd.Margin = New System.Windows.Forms.Padding(4)
        Me.grd.Name = "grd"
        Me.grd.RowHeadersVisible = False
        Me.grd.Size = New System.Drawing.Size(756, 257)
        Me.grd.TabIndex = 26
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(801, 535)
        Me.Controls.Add(Me.grd)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LAMA)
        Me.Controls.Add(Me.LBLBiaya)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LBLselesai)
        Me.Controls.Add(Me.LBLMulai)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.grd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBLselesai As System.Windows.Forms.Label
    Friend WithEvents LBLMulai As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LAMA As System.Windows.Forms.Label
    Friend WithEvents LBLBiaya As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents grd As System.Windows.Forms.DataGridView
End Class
