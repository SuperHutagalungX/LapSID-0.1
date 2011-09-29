Imports System.Data.SqlClient

Module Koneksi_Access
    Friend SharedxGlobalConn As String = "Server = localhost ;Database = lapSID;UID=sa; pwd=admin123;Trusted_Connection=yes;"
    Public Propertyh as i l () As String
    Get
        ReturnxGlobalC onn
    End Get
    Set(ByValvalue As String)
        xGlobalConn = value
    End Set
    End Property 

End Module
