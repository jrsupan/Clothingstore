Imports MySql.Data.MySqlClient
Public Class itemshow
    Inherits connectionss

    Public Sub cmbshow(ByVal combox As ComboBox)
        opendb()
        sql = "SELECT i_desc from item"
        cmd = New MySqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While (dr.Read)
            combox.Items.Add(dr.Item(0))
        End While
        dr.Close()
        closedb()
    End Sub

    Public Sub ShowTable(ByVal dataGrid As DataGridView)
        If dataGrid.RowCount > 0 Then
            dataGrid.DataSource.clear()
        End If
        opendb()
        sql = "select * from item where i_desc = '" & Form22.cmbdesc.SelectedItem & "'"
        da = New MySqlDataAdapter(sql, con)
        da.Fill(ds, "item")
        dataGrid.DataSource = ds
        dataGrid.DataMember = "item"
        da.Dispose()
        ds.Dispose()
        closedb()
    End Sub

End Class
