Imports MySql.Data.MySqlClient
Public Class DataBaseConnection
    Dim conn As New MySqlConnection("server=localhost; user id=root; user password=admin; database=lapsid; pooling=false; Connection Timeout=5")

    Public Function open() As MySqlConnection

        If conn.State <> ConnectionState.Open Then
            conn.Open()
        End If
        Return conn
    End Function

    Public Function close() As MySqlConnection
        conn.Close()
        Return conn
    End Function
End Class
