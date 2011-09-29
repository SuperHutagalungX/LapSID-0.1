Public Class frmPathDBase
    Public Sub ComboBox1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.Click

    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim dlgResult As DialogResult = MsgBox("Tahan Boss. Yakin mo keluar? Pastikan konfigurasi telah tersimpan untuk menghindari terjadinya error/gagal konksi.", MsgBoxStyle.YesNo)
        If dlgResult = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class