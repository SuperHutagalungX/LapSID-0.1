Public Class frmLihatNeraca

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim dlgResult As DialogResult = MsgBox("Tahan Boss. Yakin mo keluar?", MsgBoxStyle.YesNo)
        If dlgResult = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class