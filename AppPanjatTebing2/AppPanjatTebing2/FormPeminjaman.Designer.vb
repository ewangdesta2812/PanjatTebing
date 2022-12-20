<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPeminjaman
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LBLNoPinjam = New System.Windows.Forms.Label()
        Me.LBLNama = New System.Windows.Forms.Label()
        Me.LBLAlamat = New System.Windows.Forms.Label()
        Me.LBLTelepon = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LBLTanggal = New System.Windows.Forms.Label()
        Me.LBLJam = New System.Windows.Forms.Label()
        Me.LBLPetugas = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LBLNamaAlat = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LBLTotal = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LBLTelahPinjam = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(51, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No Pinjam"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(51, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 35)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Kode Anggota"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(51, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 35)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nama"
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(51, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 35)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(51, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 35)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Telepon"
        '
        'LBLNoPinjam
        '
        Me.LBLNoPinjam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLNoPinjam.Location = New System.Drawing.Point(175, 25)
        Me.LBLNoPinjam.Name = "LBLNoPinjam"
        Me.LBLNoPinjam.Size = New System.Drawing.Size(118, 35)
        Me.LBLNoPinjam.TabIndex = 0
        Me.LBLNoPinjam.Text = "LBLNoPinjam"
        '
        'LBLNama
        '
        Me.LBLNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLNama.Location = New System.Drawing.Point(175, 95)
        Me.LBLNama.Name = "LBLNama"
        Me.LBLNama.Size = New System.Drawing.Size(474, 35)
        Me.LBLNama.TabIndex = 0
        Me.LBLNama.Text = "LBLNama"
        '
        'LBLAlamat
        '
        Me.LBLAlamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLAlamat.Location = New System.Drawing.Point(175, 130)
        Me.LBLAlamat.Name = "LBLAlamat"
        Me.LBLAlamat.Size = New System.Drawing.Size(474, 35)
        Me.LBLAlamat.TabIndex = 0
        Me.LBLAlamat.Text = "LBLAlamat"
        '
        'LBLTelepon
        '
        Me.LBLTelepon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLTelepon.Location = New System.Drawing.Point(175, 165)
        Me.LBLTelepon.Name = "LBLTelepon"
        Me.LBLTelepon.Size = New System.Drawing.Size(249, 35)
        Me.LBLTelepon.TabIndex = 0
        Me.LBLTelepon.Text = "LBLTelepon"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(175, 63)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Location = New System.Drawing.Point(664, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(118, 35)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Tanggal"
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Location = New System.Drawing.Point(664, 60)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(118, 35)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Jam"
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Location = New System.Drawing.Point(664, 95)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(118, 35)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Petugas"
        '
        'LBLTanggal
        '
        Me.LBLTanggal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLTanggal.Location = New System.Drawing.Point(788, 25)
        Me.LBLTanggal.Name = "LBLTanggal"
        Me.LBLTanggal.Size = New System.Drawing.Size(118, 35)
        Me.LBLTanggal.TabIndex = 0
        Me.LBLTanggal.Text = "LBLTanggal"
        '
        'LBLJam
        '
        Me.LBLJam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLJam.Location = New System.Drawing.Point(788, 63)
        Me.LBLJam.Name = "LBLJam"
        Me.LBLJam.Size = New System.Drawing.Size(118, 35)
        Me.LBLJam.TabIndex = 0
        Me.LBLJam.Text = "LBLJam"
        '
        'LBLPetugas
        '
        Me.LBLPetugas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLPetugas.Location = New System.Drawing.Point(788, 98)
        Me.LBLPetugas.Name = "LBLPetugas"
        Me.LBLPetugas.Size = New System.Drawing.Size(118, 35)
        Me.LBLPetugas.TabIndex = 0
        Me.LBLPetugas.Text = "LBLPetugas"
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(51, 217)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 35)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Kode Alat"
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Location = New System.Drawing.Point(380, 217)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 35)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Nama Alat"
        '
        'LBLNamaAlat
        '
        Me.LBLNamaAlat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLNamaAlat.Location = New System.Drawing.Point(504, 217)
        Me.LBLNamaAlat.Name = "LBLNamaAlat"
        Me.LBLNamaAlat.Size = New System.Drawing.Size(258, 35)
        Me.LBLNamaAlat.TabIndex = 0
        Me.LBLNamaAlat.Text = "LBLNamaAlat"
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Location = New System.Drawing.Point(768, 217)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 35)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Jumlah"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(175, 217)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(199, 22)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(834, 215)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(58, 22)
        Me.TextBox2.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(898, 217)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 35)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "INPUT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(56, 272)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(937, 229)
        Me.DataGridView1.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(690, 571)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 35)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "SIMPAN"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(797, 571)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(95, 35)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "BATAL"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(903, 571)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(95, 35)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "CLOSE"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Location = New System.Drawing.Point(788, 519)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 35)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Total"
        '
        'LBLTotal
        '
        Me.LBLTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLTotal.Location = New System.Drawing.Point(854, 519)
        Me.LBLTotal.Name = "LBLTotal"
        Me.LBLTotal.Size = New System.Drawing.Size(110, 35)
        Me.LBLTotal.TabIndex = 0
        Me.LBLTotal.Text = "LBLTotal"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(63, 620)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(929, 138)
        Me.DataGridView2.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Location = New System.Drawing.Point(63, 772)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 35)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Telah Pinjam"
        '
        'LBLTelahPinjam
        '
        Me.LBLTelahPinjam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLTelahPinjam.Location = New System.Drawing.Point(175, 772)
        Me.LBLTelahPinjam.Name = "LBLTelahPinjam"
        Me.LBLTelahPinjam.Size = New System.Drawing.Size(69, 35)
        Me.LBLTelahPinjam.TabIndex = 0
        '
        'FormPeminjaman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1033, 836)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.LBLNamaAlat)
        Me.Controls.Add(Me.LBLTotal)
        Me.Controls.Add(Me.LBLTelahPinjam)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LBLTelepon)
        Me.Controls.Add(Me.LBLAlamat)
        Me.Controls.Add(Me.LBLNama)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.LBLPetugas)
        Me.Controls.Add(Me.LBLJam)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.LBLTanggal)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LBLNoPinjam)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormPeminjaman"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Peminjaman Alat"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LBLNoPinjam As System.Windows.Forms.Label
    Friend WithEvents LBLNama As System.Windows.Forms.Label
    Friend WithEvents LBLAlamat As System.Windows.Forms.Label
    Friend WithEvents LBLTelepon As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents LBLTanggal As System.Windows.Forms.Label
    Friend WithEvents LBLJam As System.Windows.Forms.Label
    Friend WithEvents LBLPetugas As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LBLNamaAlat As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LBLTotal As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents LBLTelahPinjam As System.Windows.Forms.Label
End Class
