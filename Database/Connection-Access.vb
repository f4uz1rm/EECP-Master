Imports System.Data.OleDb
Module Connection_Acces
    Public conn As OleDbConnection
    Public da As OleDbDataAdapter
    Public ds As DataSet
    Public cmd As OleDbCommand
    Public dr As OleDbDataReader
    Public syntak As String

    Public Sub Koneksi()
        'Koneksi pada database Access dengan format .mdb
        conn = New OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=patient.mdb")
        conn.Open()
    End Sub

End Module
