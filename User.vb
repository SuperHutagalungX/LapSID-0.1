Public Class User

    Private m_username As String
    Private m_password As String

    Public Property UserName() As String
        Get
            'Get : hanya ijinkan akses data
            Return m_username
        End Get
        Set(ByVal value As String)
            If value = "" Then
                Throw New Exception("Silahkan masukkan username")
            End If
            'Set : mengijinkan ubah data
            m_username = value
        End Set
    End Property

    Public Property Password() As String
        Get
            Return m_password
        End Get
        Set(ByVal value As String)
            If value = "" Then
                Throw New Exception("Silahkan masukkan password")
            End If
            m_password = value
        End Set
    End Property
End Class
