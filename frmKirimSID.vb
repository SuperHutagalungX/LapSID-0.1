Public Class frmKirimSID
    Private Sub frmKirimSID_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'frmTransferKredit.MdiParent = Me
        frmTransferKredit.Text = "TRANSFER KREDIT KE SIDBPR v6"
        frmTransferKredit.Show()
        Me.Close()
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

    End Sub
End Class