<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TRANSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BakiDebetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CekSaldoKreditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NasabahToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjaminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CekKodePosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputReferensiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewSAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LihatNeracaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ValidasiDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PathDBaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TentangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.PathDBaseToolStripMenuItem, Me.OperatorToolStripMenuItem, Me.TentangToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(872, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TRANSToolStripMenuItem, Me.InputReferensiToolStripMenuItem, Me.ViewSAToolStripMenuItem, Me.LihatNeracaToolStripMenuItem, Me.ValidasiDataToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'TRANSToolStripMenuItem
        '
        Me.TRANSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BakiDebetToolStripMenuItem, Me.CekSaldoKreditToolStripMenuItem, Me.NasabahToolStripMenuItem, Me.DINToolStripMenuItem, Me.PenjaminToolStripMenuItem, Me.CekKodePosToolStripMenuItem})
        Me.TRANSToolStripMenuItem.Name = "TRANSToolStripMenuItem"
        Me.TRANSToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.TRANSToolStripMenuItem.Text = "TRANS"
        '
        'BakiDebetToolStripMenuItem
        '
        Me.BakiDebetToolStripMenuItem.Name = "BakiDebetToolStripMenuItem"
        Me.BakiDebetToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.BakiDebetToolStripMenuItem.Text = "Baki Debet"
        '
        'CekSaldoKreditToolStripMenuItem
        '
        Me.CekSaldoKreditToolStripMenuItem.Name = "CekSaldoKreditToolStripMenuItem"
        Me.CekSaldoKreditToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.CekSaldoKreditToolStripMenuItem.Text = "Cek Saldo Kredit"
        '
        'NasabahToolStripMenuItem
        '
        Me.NasabahToolStripMenuItem.Name = "NasabahToolStripMenuItem"
        Me.NasabahToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.NasabahToolStripMenuItem.Text = "Nasabah"
        '
        'DINToolStripMenuItem
        '
        Me.DINToolStripMenuItem.Name = "DINToolStripMenuItem"
        Me.DINToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.DINToolStripMenuItem.Text = "DIN"
        '
        'PenjaminToolStripMenuItem
        '
        Me.PenjaminToolStripMenuItem.Name = "PenjaminToolStripMenuItem"
        Me.PenjaminToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.PenjaminToolStripMenuItem.Text = "Penjamin"
        '
        'CekKodePosToolStripMenuItem
        '
        Me.CekKodePosToolStripMenuItem.Name = "CekKodePosToolStripMenuItem"
        Me.CekKodePosToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.CekKodePosToolStripMenuItem.Text = "Cek Kode Pos"
        '
        'InputReferensiToolStripMenuItem
        '
        Me.InputReferensiToolStripMenuItem.Name = "InputReferensiToolStripMenuItem"
        Me.InputReferensiToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.InputReferensiToolStripMenuItem.Text = "Input Referensi"
        '
        'ViewSAToolStripMenuItem
        '
        Me.ViewSAToolStripMenuItem.Name = "ViewSAToolStripMenuItem"
        Me.ViewSAToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ViewSAToolStripMenuItem.Text = "Lihat SA"
        '
        'LihatNeracaToolStripMenuItem
        '
        Me.LihatNeracaToolStripMenuItem.Name = "LihatNeracaToolStripMenuItem"
        Me.LihatNeracaToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.LihatNeracaToolStripMenuItem.Text = "Lihat Neraca"
        '
        'ValidasiDataToolStripMenuItem
        '
        Me.ValidasiDataToolStripMenuItem.Name = "ValidasiDataToolStripMenuItem"
        Me.ValidasiDataToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ValidasiDataToolStripMenuItem.Text = "Validasi Data"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'PathDBaseToolStripMenuItem
        '
        Me.PathDBaseToolStripMenuItem.Name = "PathDBaseToolStripMenuItem"
        Me.PathDBaseToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.PathDBaseToolStripMenuItem.Text = "Path DBase"
        '
        'OperatorToolStripMenuItem
        '
        Me.OperatorToolStripMenuItem.Name = "OperatorToolStripMenuItem"
        Me.OperatorToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.OperatorToolStripMenuItem.Text = "Operator :"
        '
        'TentangToolStripMenuItem
        '
        Me.TentangToolStripMenuItem.Name = "TentangToolStripMenuItem"
        Me.TentangToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.TentangToolStripMenuItem.Text = "Tentang"
        '
        'frmUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 462)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmUtama"
        Me.Text = "Menu LapSID"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TRANSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BakiDebetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CekSaldoKreditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NasabahToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DINToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenjaminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CekKodePosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InputReferensiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewSAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LihatNeracaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ValidasiDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PathDBaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OperatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TentangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
