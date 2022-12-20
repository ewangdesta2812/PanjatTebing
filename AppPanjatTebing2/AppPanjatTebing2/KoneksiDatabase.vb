Imports System.Data.Odbc
Module KoneksiDatabase
    Public Conn As OdbcConnection
    Public Cmd As OdbcCommand
    Public Da As OdbcDataAdapter
    Public Ds As DataSet
    Public Rd As OdbcDataReader

    Public MyDB As String
    Public Sub Koneksi()
        MyDB = "Driver={MySQL ODBC 8.0 ANSI DRIVER};database=db_panjattebing1;server=localhost;uid=root"
        Conn = New OdbcConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub
End Module
