Imports System.Data.Odbc
Public Class FormLogin
    Sub Terbuka()
        FormMenuUtama.LoginToolStripMenuItem.Visible = False
        FormMenuUtama.LogoutToolStripMenuItem.Visible = True
        FormMenuUtama.MasterToolStripMenuItem.Visible = True
        FormMenuUtama.TransaksiToolStripMenuItem.Visible = True
        FormMenuUtama.LaporanToolStripMenuItem.Visible = True
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Kode Petugas dan Password Tidak Boleh Kosong!!!")
        Else
            Call Koneksi()
            Cmd = New OdbcCommand("Select * From tbl_petugas where kodePetugas='" & TextBox1.Text & "' and pwdPetugas='" & TextBox2.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                Me.Close()
                Call Terbuka()
                FormMenuUtama.STLabel2.Text = Rd!kodePetugas
            Else
                MsgBox("Kode Petugas dan Password Salah!")
            End If
        End If
    End Sub

    Private Sub FormLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = "PTG001"
        TextBox2.Text = "ADMIN"
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox2.PasswordChar = ""
        Else
            TextBox2.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class