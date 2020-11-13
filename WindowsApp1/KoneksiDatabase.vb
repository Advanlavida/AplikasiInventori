Imports MySql.Data.MySqlClient

Module KoneksiDatabase
    Public objkoneksi As MySqlConnection
    Public objdataAdo As MySqlDataAdapter
    Public objdataRd As MySqlDataReader
    Public objcommand As MySqlCommand
    Public objDataSet As DataSet

    Sub koneksi()
        Try
            Dim AlamatDatabase As String = "Server=localhost;userid=root;password=;
                                            database=dbinventoriv2"
            objkoneksi = New MySqlConnection(AlamatDatabase)
            If objkoneksi.State = ConnectionState.Closed Then
                objkoneksi.Open()
                'MsgBox("Koneksi berhasil!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Module
