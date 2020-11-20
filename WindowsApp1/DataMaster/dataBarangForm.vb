Imports MySql.Data.MySqlClient

Public Class dataBarangForm

    'Dim Tg As Integer = 0

    Private Sub dataBarangForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampil()
        Call aturdgvbarang()
        'Tg = 0
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
        'Tg = 0
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

    Sub muatBarang()
        With dgvBarang
            txtKdBarang.Text = .Item(0, .CurrentRow.Index).Value
            txtNamaBarang.Text = .Item(1, .CurrentRow.Index).Value
            txtHargaBarang.Text = .Item(2, .CurrentRow.Index).Value
            txtStokBarang.Text = .Item(3, .CurrentRow.Index).Value
        End With
        'Tg = 1
    End Sub

    Sub cari()
        Using objcommand = New MySqlCommand("SELECT * from tabelbarang WHERE namabarang LIKE 
                                            '%" & tstbCari.Text & "%'", objkoneksi)
            'tstbCari.Text = Nama Textbox yg digunakan
            Using objdataRd As MySqlDataReader = objcommand.ExecuteReader
                Using Tabel As New DataTable

                    Tabel.Load(objdataRd)
                    If Tabel.Rows.Count = 0 Then
                        dgvBarang.DataSource = Nothing
                    Else
                        dgvBarang.DataSource = Tabel
                        Call aturdgvbarang()
                    End If

                End Using
            End Using
        End Using
    End Sub

    Sub updateBarang()
        Try
            If txtKdBarang.Text = "" Or txtNamaBarang.Text = "" Or txtHargaBarang.Text = "" Or
                txtStokBarang.Text = "" Then
                MsgBox("Data belum lengkap!", MsgBoxStyle.Exclamation)
            Else
                Dim Query As String = "UPDATE tabelbarang SET namabarang = '" & txtNamaBarang.Text & "', harga = '" & txtHargaBarang.Text & "', stock = '" & txtStokBarang.Text & "' WHERE kodebarang = '" & txtKdBarang.Text & "'"
                objcommand = New MySqlCommand(Query, objkoneksi)
                objcommand.ExecuteNonQuery()
                Call tampil()
                Call bersihtextbox()
                MsgBox("Data berhasil di update")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        'Button simpan
        Call insertBarang()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        'Call deleteDataBarang()
        Dim result As DialogResult = MessageBox.Show("Apakah anda yakin ?", "Informasi",
                                                     MessageBoxButtons.YesNo)
        If (result = DialogResult.Yes) Then
            Call deleteDataBarang()
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        'Button muat
        Call muatBarang()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        'Button batal
        Call bersihtextbox()
    End Sub

    Private Sub tstbCari_KeyUp(sender As Object, e As KeyEventArgs) Handles tstbCari.KeyUp
        Call cari()
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs)
        Call updateBarang()
    End Sub

    Private Sub ToolStripButton5_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        Call updateBarang()
    End Sub
End Class