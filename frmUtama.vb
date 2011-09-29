Public Class frmUtama

    Private Sub PathDBaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PathDBaseToolStripMenuItem.Click
        frmPathDBase.MdiParent = Me
        frmPathDBase.Text = "Konfigurasi Database"
        frmPathDBase.Show()
    End Sub

    Private Sub BakiDebetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BakiDebetToolStripMenuItem.Click
        frmBakiDebet.MdiParent = Me
        frmBakiDebet.Text = "Cek BAKI DEBET"
        frmBakiDebet.Show()
    End Sub

    Private Sub CekSaldoKreditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CekSaldoKreditToolStripMenuItem.Click
        frmCekLunas.MdiParent = Me
        frmCekLunas.Text = "Cek SALDO KREDIT"
        frmCekLunas.Show()
    End Sub

    Private Sub NasabahToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NasabahToolStripMenuItem.Click
        frmTransNasabah.MdiParent = Me
        frmTransNasabah.Text = "Cek Data Nasabah berdasarkan No. Rekening"
        frmTransNasabah.Show()
    End Sub

    Private Sub DINToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DINToolStripMenuItem.Click
        frmTransDIN.MdiParent = Me
        frmTransDIN.Text = "Lihat Data SID"
        frmTransDIN.Show()
    End Sub

    Private Sub PenjaminToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PenjaminToolStripMenuItem.Click
        frmPenjamin.MdiParent = Me
        frmPenjamin.Text = "Cek Data Penjamin"
        frmPenjamin.Show()
    End Sub

    Private Sub CekKodePosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CekKodePosToolStripMenuItem.Click

    End Sub

    Private Sub InputReferensiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputReferensiToolStripMenuItem.Click

    End Sub

    Private Sub ViewSAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewSAToolStripMenuItem.Click

    End Sub

    Private Sub LihatNeracaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LihatNeracaToolStripMenuItem.Click
        frmLihatNeraca.MdiParent = Me
        frmLihatNeraca.Text = "LIHAT NERACA SA"
        frmLihatNeraca.Show()
    End Sub

    Private Sub ValidasiDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValidasiDataToolStripMenuItem.Click
        frmKirimSID.MdiParent = Me
        frmKirimSID.Text = "CEK VALIDASI DATA SA"
        frmKirimSID.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim dlgResult As DialogResult = MsgBox("Tahan Boss. Yakin mo keluar?", MsgBoxStyle.YesNo)
        If dlgResult = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub TentangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TentangToolStripMenuItem.Click
        frmAbout.MdiParent = Me
        frmAbout.Text = "Tentang Aplikasi"
        frmAbout.Show()
    End Sub

    Private Sub OperatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OperatorToolStripMenuItem.Click

    End Sub

    Private Sub frmUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class