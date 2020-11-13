Imports MySql.Data.MySqlClient

Public Class dataBarangForm
    Private Sub dataBarangForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampil()
        Call aturdgvbarang()
    End Sub

    Sub tampil()
        Try
            objdataAdo = New MySqlDataAdapter("SELECT * from tabelbarang", objkoneksi)
            objDataSet = New DataSet
            objdataAdo.Fill(objDataSet, "barang")
            dgvBarang.DataSource = (objDataSet.Tables("barang"))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub aturdgvbarang()
        Try
            dgvBarang.Columns(0).HeaderText = "KODE BARANG"
            dgvBarang.Columns(0).Width = 100

            dgvBarang.Columns(1).HeaderText = "NAMA BARANG"
            dgvBarang.Columns(1).Width = 300

            dgvBarang.Columns(2).HeaderText = "HARGA"
            dgvBarang.Columns(2).Width = 100

            dgvBarang.Columns(3).HeaderText = "STOK"
            dgvBarang.Columns(3).Width = 100
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub bersihtextbox()
        txtKdBarang.Text = ""
        txtNamaBarang.Text = ""
        txtHargaBarang.Text = ""
        txtStokBarang.Text = ""
    End Sub

    Sub insertBarang()
        Try
            If txtKdBarang.Text = "" Or txtNamaBarang.Text = "" Or txtHargaBarang.Text = "" Or
                txtStokBarang.Text = "" Then
                MsgBox("Data belum lengkap!", MsgBoxStyle.Exclamation)
            Else
                Dim Query As String = "INSERT into tabelbarang values (
                             '" & txtKdBarang.Text & "', 
                             '" & txtNamaBarang.Text & "', 
                             '" & txtHargaBarang.Text & "', 
                             '" & txtStokBarang.Text & "');"
                objcommand = New MySqlCommand(Query, objkoneksi)
                objcommand.ExecuteNonQuery()
                Call tampil()
                MsgBox("Data berhasil disimpan")
                Call bersihtextbox()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub deleteDataBarang()
        Dim id As String
        id = dgvBarang.Item(0, dgvBarang.CurrentRow.Index).Value
        Dim Query As String = "DELETE from tabelbarang where kodebarang = '" & id & "'"
        objcommand = New MySqlCommand(Query, objkoneksi)
        objcommand.ExecuteNonQuery()
        MsgBox("Data berhasil dihapus")
        Call tampil()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Call insertBarang()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        'Call deleteDataBarang()
        Dim result As DialogResult = MessageBox.Show("Apakah anda yakin ?", "Informasi", MessageBoxButtons.YesNo)
        If (result = DialogResult.Yes) Then
            Call deleteDataBarang()
        End If
    End Sub
End Class