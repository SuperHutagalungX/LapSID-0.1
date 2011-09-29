Imports MySql.Data.MySqlClient
Module mysqlKonek
    Private Conn As MySqlConnection = Nothing
    Public Function Koneksi_mysql() As MySqlConnection
        Dim ConnString As String
        ConnString = ";server=localhost" & ";user=root" & ";password=admin" & ";database=lapsid"
        Try
            Conn = New MySqlConnection(ConnString)
            Conn.Open()
        Catch ex As MySqlException
            MessageBox.Show("Koneksi Erros: " + ex.Message)
        End Try
        Return Conn
    End Function
End Module

