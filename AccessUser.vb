Imports MySql.Data.MySqlClient
Public Class AccessUser
    Private myconnection As New DataBaseConnection

    Public Function FindByUsername(ByVal Username As String) As List(Of User)
        Dim User As New List(Of User)()
        Try
            'String SQL untuk mencari username dari table users
            Dim StrSQL As String = "SELECT * FROM users WHERE username=@username"
            Dim myCommand As New MySqlCommand(StrSQL, myconnection.open)
            myCommand.Parameters.Add("@username", MySqlDbType.VarChar).Value = Username
            Dim rdr As MySqlDataReader = myCommand.ExecuteReader()
            If rdr.Read = False Then 'jika user yang dicari tidak ada
                Throw New Exception("Username salah atau tidak ditemukan")
            Else
                Dim Users As New User()
                Users.UserName = rdr("Username").ToString()
                Users.Password = rdr("Password").ToString()
                'Users.Add(Users)
            End If
        Catch sqlex As MySqlException
            Throw New Exception(sqlex.Message.ToString())
        End Try
        Return User
    End Function
End Class
