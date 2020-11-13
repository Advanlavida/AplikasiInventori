<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dataMasterForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dataMasterForm))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsbLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbDataMaster = New System.Windows.Forms.ToolStripDropDownButton()
        Me.BarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PegawaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbDataTransaksi = New System.Windows.Forms.ToolStripDropDownButton()
        Me.PenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbLaporan = New System.Windows.Forms.ToolStripDropDownButton()
        Me.LaporanPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.tsbDataMaster, Me.tsbDataTransaksi, Me.tsbLaporan})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        Me.ToolStrip1.UseWaitCursor = True
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbLogout, Me.tsbExit})
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(38, 22)
        Me.ToolStripButton1.Text = "File"
        '
        'tsbLogout
        '
        Me.tsbLogout.Name = "tsbLogout"
        Me.tsbLogout.Size = New System.Drawing.Size(112, 22)
        Me.tsbLogout.Text = "Logout"
        '
        'tsbExit
        '
        Me.tsbExit.Name = "tsbExit"
        Me.tsbExit.Size = New System.Drawing.Size(112, 22)
        Me.tsbExit.Text = "Exit"
        '
        'tsbDataMaster
        '
        Me.tsbDataMaster.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbDataMaster.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BarangToolStripMenuItem, Me.SupplierToolStripMenuItem, Me.PegawaiToolStripMenuItem})
        Me.tsbDataMaster.Image = CType(resources.GetObject("tsbDataMaster.Image"), System.Drawing.Image)
        Me.tsbDataMaster.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbDataMaster.Name = "tsbDataMaster"
        Me.tsbDataMaster.Size = New System.Drawing.Size(83, 22)
        Me.tsbDataMaster.Text = "Data Master"
        '
        'BarangToolStripMenuItem
        '
        Me.BarangToolStripMenuItem.Image = CType(resources.GetObject("BarangToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BarangToolStripMenuItem.Name = "BarangToolStripMenuItem"
        Me.BarangToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.BarangToolStripMenuItem.Text = "Barang"
        '
        'SupplierToolStripMenuItem
        '
        Me.SupplierToolStripMenuItem.Image = CType(resources.GetObject("SupplierToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SupplierToolStripMenuItem.Name = "SupplierToolStripMenuItem"
        Me.SupplierToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.SupplierToolStripMenuItem.Text = "Supplier"
        '
        'PegawaiToolStripMenuItem
        '
        Me.PegawaiToolStripMenuItem.Image = CType(resources.GetObject("PegawaiToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PegawaiToolStripMenuItem.Name = "PegawaiToolStripMenuItem"
        Me.PegawaiToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.PegawaiToolStripMenuItem.Text = "Pegawai"
        '
        'tsbDataTransaksi
        '
        Me.tsbDataTransaksi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbDataTransaksi.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenjualanToolStripMenuItem, Me.PembelianToolStripMenuItem})
        Me.tsbDataTransaksi.Image = CType(resources.GetObject("tsbDataTransaksi.Image"), System.Drawing.Image)
        Me.tsbDataTransaksi.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbDataTransaksi.Name = "tsbDataTransaksi"
        Me.tsbDataTransaksi.Size = New System.Drawing.Size(94, 22)
        Me.tsbDataTransaksi.Text = "Data Transaksi"
        '
        'PenjualanToolStripMenuItem
        '
        Me.PenjualanToolStripMenuItem.Name = "PenjualanToolStripMenuItem"
        Me.PenjualanToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.PenjualanToolStripMenuItem.Text = "Penjualan"
        '
        'PembelianToolStripMenuItem
        '
        Me.PembelianToolStripMenuItem.Name = "PembelianToolStripMenuItem"
        Me.PembelianToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.PembelianToolStripMenuItem.Text = "Pembelian"
        '
        'tsbLaporan
        '
        Me.tsbLaporan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbLaporan.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanPenjualanToolStripMenuItem, Me.LaporanPembelianToolStripMenuItem})
        Me.tsbLaporan.Image = CType(resources.GetObject("tsbLaporan.Image"), System.Drawing.Image)
        Me.tsbLaporan.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbLaporan.Name = "tsbLaporan"
        Me.tsbLaporan.Size = New System.Drawing.Size(63, 22)
        Me.tsbLaporan.Text = "Laporan"
        '
        'LaporanPenjualanToolStripMenuItem
        '
        Me.LaporanPenjualanToolStripMenuItem.Name = "LaporanPenjualanToolStripMenuItem"
        Me.LaporanPenjualanToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.LaporanPenjualanToolStripMenuItem.Text = "Laporan Penjualan"
        '
        'LaporanPembelianToolStripMenuItem
        '
        Me.LaporanPembelianToolStripMenuItem.Name = "LaporanPembelianToolStripMenuItem"
        Me.LaporanPembelianToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.LaporanPembelianToolStripMenuItem.Text = "Laporan Pembelian"
        '
        'dataMasterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "dataMasterForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Master"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripDropDownButton
    Friend WithEvents tsbLogout As ToolStripMenuItem
    Friend WithEvents tsbExit As ToolStripMenuItem
    Friend WithEvents tsbDataMaster As ToolStripDropDownButton
    Friend WithEvents BarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SupplierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PegawaiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsbDataTransaksi As ToolStripDropDownButton
    Friend WithEvents PenjualanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PembelianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsbLaporan As ToolStripDropDownButton
    Friend WithEvents LaporanPenjualanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanPembelianToolStripMenuItem As ToolStripMenuItem
End Class
