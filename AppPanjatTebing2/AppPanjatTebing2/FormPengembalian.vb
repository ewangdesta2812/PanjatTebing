Imports System.Data.Odbc
Public Class FormPengembalian
    Sub KondisiAwal()
        txtKodeMember.Text = ""
        LBLNamaMember.Text = ""
        txtJumlah.Text = ""
        txtBayar.Text = ""
        txtKodeAlat.Text = ""
        LBLNamaAlat.Text = ""
        txtJumlah.Text = ""
        LBLTanggalPinjam.Text = ""
        LBL_Denda.Text = ""
        LBLLamaPinjam.Text = ""
        LBLNoPinjam.Text = ""
        LBLTelahPinjam.Text = ""
        LBLDenda.Text = ""
        LBLKembalian.Text = ""
        LBLTotal.Text = ""
    End Sub

    Sub KondisiAwal2()
        txtJumlah.Text = ""
        txtBayar.Text = ""
        LBLNamaAlat.Text = ""
        txtJumlah.Text = ""
        LBLTanggalPinjam.Text = ""
        LBL_Denda.Text = ""
        LBLLamaPinjam.Text = ""
        LBLNoPinjam.Text = ""
    End Sub

    Sub TampilGrid()
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("Kode", "Kode Alat")
        DataGridView1.Columns.Add("Nomor", "No Pinjam")
        DataGridView1.Columns.Add("Nama", "Nama Alat")
        DataGridView1.Columns.Add("Jumlah", "Jumlah Pinjam")
        DataGridView1.Columns.Add("Tanggal", "Tanggal Pinjam")
        DataGridView1.Columns.Add("Lama", "Lama Pinjam")
        DataGridView1.Columns.Add("Denda", "Denda")
    End Sub

    Sub TampilGrid2()
        DataGridView2.Columns.Add("Kode", "Kode")
        DataGridView2.Columns.Add("Nama", "Nama Alat")
        DataGridView2.Columns.Add("Jumlah", "Jumlah")
        DataGridView2.ReadOnly = True
    End Sub

    Sub NoKembali()
        Call Koneksi()
        Cmd = New OdbcCommand("Select * From tbl_pengembalian where noKembali in (select max(noKembali) From tbl_pengembalian)", Conn)
        Dim UrutanKode As String
        Dim Hitung As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            UrutanKode = "KBL" + Format(Now, "yyMMdd") + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 9) + 1
            UrutanKode = "KBL" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        LBLNoKembali.Text = UrutanKode
    End Sub

    Sub CekPinjaman()
        Call Koneksi()
        Da = New OdbcDataAdapter("SELECT tbl_alat.kodeAlat, tbl_alat.namaAlat, tbl_detailpeminjaman.jumlahAlat FROM tbl_detailpeminjaman INNER JOIN tbl_alat ON tbl_detailpeminjaman.kodeAlat = tbl_alat.kodeAlat INNER JOIN tbl_peminjaman ON tbl_detailpeminjaman.noPinjam = tbl_peminjaman.noPinjam INNER JOIN tbl_member ON tbl_peminjaman.kodeMember = tbl_member.kodeMember INNER JOIN tbl_petugas ON tbl_peminjaman.kodePetugas = tbl_petugas.kodePetugas where tbl_member.kodeMember= '" & txtKodeMember.Text & "' and tbl_detailpeminjaman.jumlahAlat>0", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "Detail")
        DataGridView2.DataSource = Ds.Tables("Detail")
        LBLTelahPinjam.Text = DataGridView2.Rows.Count - 1
        DataGridView2.ReadOnly = True
    End Sub

    Private Sub FormPengembalian_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call Koneksi()
        LBLTanggal.Text = Today
    End Sub

    Private Sub FormPengembalian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        Call Koneksi()
        Call TampilGrid()
        'Call HapusMaster()
        Call NoKembali()
    End Sub
End Class