Imports System
Imports System.Security.Cryptography
Imports System.Text
Public Class frmLoginSID
    Private Sub frmLoginSID_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Try
            Dim AccessUser As New AccessUser
            Dim User As New User

            User.UserName = txtUser.Text.Trim
            User.UserName = txtPass.Text.Trim

            Dim list As List(Of User) = AccessUser.FindByUsername(txtUser.Text.Trim)

            If list.First.Password <> txtPass.Text.Trim Then
                MsgBox("Password salah")
                Exit Sub
            Else
                Me.Hide()
                Me.ShowInTaskbar = False
                Me.Close()
                Me.Dispose()
                Dim frmUtama As New frmUtama
                frmUtama.Show()
                txtUser.Clear()
                txtPass.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class