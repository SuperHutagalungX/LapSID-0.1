Imports System.Data.SqlClient
Module Koneksi_SQLServer
    Private Conn As SqlConnection = Nothing
    Public Function Koneksi() As SqlConnection
        Dim Conn As New SqlConnection
        Try
            Conn = New SqlConnection("server=IT-PC\SQLEXPRESS; database=sidbpr; user=sa;password=admin123;")
            Conn.Open()
        Catch ex As SqlException
            MessageBox.Show("Koneksi Erros: " + ex.Message)
        End Try
        Return Conn
    End Function
End Module
