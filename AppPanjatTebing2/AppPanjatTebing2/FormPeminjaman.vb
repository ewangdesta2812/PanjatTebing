Imports System.Data.Odbc
Public Class FormPeminjaman
    Sub KondisiAwal()
        Call NoPinjam()
        Call KodeMember()
        Call BukaKolom()
        LBLPetugas.Text = FormMenuUtama.STLabel2.Text
        LBLNama.Text = ""
        LBLAlamat.Text = ""
        LBLTelepon.Text = ""
        LBLNamaAlat.Text = ""
        LBLTotal.Text = "0"
        ComboBox1.Text = ""
    End Sub

    Sub NoPinjam()
        Call Koneksi()
        Cmd = New OdbcCommand("Select * From tbl_peminjaman where noPinjam in (select max(noPinjam) From tbl_peminjaman)", Conn)
        Dim UrutanKode As String
        Dim Hitung As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            UrutanKode = "PJM" + Format(Now, "yyMMdd") + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 9) + 1
            UrutanKode = "PJM" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        LBLNoPinjam.Text = UrutanKode
    End Sub

    Sub KodeMember()
        Call Koneksi()
        ComboBox1.Items.Clear()
        Cmd = New OdbcCommand("Select * From tbl_member", Conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            ComboBox1.Items.Add(Rd.Item(0))
        Loop
    End Sub

    Sub BukaKolom()
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("Kode", "Kode Alat")
        DataGridView1.Columns.Add("Nama", "Nama Alat")
        DataGridView1.Columns.Add("Jumlah", "Jumlah Alat")
    End Sub

    Sub RumusTotalAlat()
        Dim HitungItem As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            HitungItem = HitungItem + DataGridView1.Rows(i).Cells(2).Value
            LBLTotal.Text = HitungItem
        Next
    End Sub

    Sub CekPinjaman()
        Call Koneksi()
        Da = New OdbcDataAdapter("SELECT tbl_alat.kodeAlat, tbl_alat.namaAlat, tbl_detailpeminjaman.jumlahAlat FROM tbl_detailpeminjaman INNER JOIN tbl_alat ON tbl_detailpeminjaman.kodeAlat = tbl_alat.kodeAlat INNER JOIN tbl_peminjaman ON tbl_detailpeminjaman.noPinjam = tbl_peminjaman.noPinjam INNER JOIN tbl_member ON tbl_peminjaman.kodeMember = tbl_member.kodeMember INNER JOIN tbl_petugas ON tbl_peminjaman.kodePetugas = tbl_petugas.kodePetugas where tbl_member.kodeMember= '" & ComboBox1.Text & "' and tbl_detailpeminjaman.jumlahAlat>0", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "Detail")
        DataGridView2.DataSource = Ds.Tables("Detail")
        LBLTelahPinjam.Text = DataGridView2.Rows.Count - 1
        DataGridView2.ReadOnly = True
    End Sub

    Private Sub FormPeminjaman_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        LBLTanggal.Text = Today
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LBLJam.Text = TimeOfDay
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call Koneksi()
        Cmd = New OdbcCommand("Select * From tbl_member where kodeMember = '" & ComboBox1.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            LBLNama.Text = Rd!namaMember
            LBLAlamat.Text = Rd!alamatMember
            LBLTelepon.Text = Rd!telpMember
            Call CekPinjaman()
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            Cmd = New OdbcCommand("Select * From tbl_alat where kodeAlat= '" & TextBox1.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("Alat Tidak Ada !")
            Else
                TextBox1.Text = Rd.Item("kodeAlat")
                LBLNamaAlat.Text = Rd.Item("namaAlat")
                TextBox2.Enabled = True
                TextBox2.Text = "1"
            End If
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Val(LBLTelahPinjam.Text) + Val(LBLTotal.Text) >= 5 Or Val(LBLTotal.Text) + Val(TextBox2.Text) > 5 Then
            MsgBox("Alat yang di pinjam melebihi batas maksimum")
        Else
            If LBLNamaAlat.Text = "" Or TextBox2.Text = "" Then
                MsgBox("Silahkan Masukan Kode Alat dan Tekan ENTER!!!")
            Else
                DataGridView1.Rows.Add(New String() {TextBox1.Text, LBLNamaAlat.Text, TextBox2.Text})
                TextBox1.Text = ""
                TextBox2.Text = ""
                LBLNamaAlat.Text = ""
                Call RumusTotalAlat()
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If LBLNama.Text = "" Or Label9.Text = "" Then
            MsgBox("Transaksi tidak ada, silahkan melakukan transaksi")
        Else
            Call Koneksi()
            Dim tglsql As String
            tglsql = Format(Today, "yyyy-MM-dd")
            Dim PinjamAlat As String = "Insert into tbl_peminjaman values('" & LBLNoPinjam.Text & "','" & tglsql & "','" & LBLJam.Text & "','" & ComboBox1.Text & "','" & LBLTotal.Text & "','" & LBLTotal.Text & "','" & FormMenuUtama.STLabel2.Text & "') "
            Cmd = New OdbcCommand(PinjamAlat, Conn)
            Cmd.ExecuteNonQuery()

            For Baris As Integer = 0 To DataGridView1.Rows.Count - 2
                Call Koneksi()
                Dim SimpanDetail As String = "Insert into tbl_detailpeminjaman values ('" & LBLNoPinjam.Text & "','" & DataGridView1.Rows(Baris).Cells(0).Value & "','" & DataGridView1.Rows(Baris).Cells(2).Value & "')"
                Cmd = New OdbcCommand(SimpanDetail, Conn)
                Cmd.ExecuteNonQuery()
                Call Koneksi()
                Cmd = New OdbcCommand("Select * From tbl_alat where kodeAlat='" & DataGridView1.Rows(Baris).Cells(0).Value & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                Call Koneksi()
                Dim KurangiJumlah As String = "Update tbl_alat set stokAlat = '" & Rd.Item("stokAlat") - DataGridView1.Rows(Baris).Cells(2).Value & "' where kodeAlat = '" & DataGridView1.Rows(Baris).Cells(0).Value & "'"
                Cmd = New OdbcCommand(KurangiJumlah, Conn)
                Cmd.ExecuteNonQuery()
            Next
            Call KondisiAwal()
            MsgBox("Transaksi Telah Berhasil Di Simpan")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call KondisiAwal()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class