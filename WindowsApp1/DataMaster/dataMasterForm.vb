Public Class dataMasterForm
    Private Sub dataMasterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KoneksiDatabase.koneksi()
    End Sub

    Private Sub BarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangToolStripMenuItem.Click
        dataBarangForm.Show()
    End Sub
End Class