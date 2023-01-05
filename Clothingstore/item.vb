Imports MySql.Data.MySqlClient
Public Class item

    Inherits connections

    Private itm_id As Integer
    Private itm_categ As String
    Private itm_desc As String
    Private itm_pr As Integer
    Private s_id As Integer
    Private itm_qty As Integer
    Public Property itm_qtys As Integer
        Get
            Return itm_qty
        End Get
        Set(ByVal value As Integer)
            itm_qty = value
        End Set
    End Property

    Public Property s_ids As Integer
        Get
            Return s_id
        End Get
        Set(ByVal value As Integer)
            s_id = value
        End Set
    End Property

    Public Property itm_ids As Integer
        Get
            Return itm_id
        End Get
        Set(ByVal value As Integer)
            itm_id = value
        End Set
    End Property

    Public Property itm_categs As String
        Get
            Return itm_categ
        End Get
        Set(ByVal value As String)
            itm_categ = value
        End Set
    End Property

    Public Property itm_descs As String
        Get
            Return itm_desc
        End Get
        Set(ByVal value As String)
            itm_desc = value
        End Set
    End Property

    Public Property itm_prs As Integer
        Get
            Return itm_pr
        End Get
        Set(ByVal value As Integer)
            itm_pr = value
        End Set
    End Property

    'Public Sub item_add()

    '    Try
    '        opendb()
    '        sql = "insert into item(i_name,i_desc,i_price) values (@iname,@idesc,@ipr)"

    '        cmd = New MySqlCommand(sql, con)
    '        cmd.Parameters.AddWithValue("@iname", itm_categ)
    '        cmd.Parameters.AddWithValue("@idesc", itm_desc)
    '        cmd.Parameters.AddWithValue("@ipr", itm_pr)
    '        cmd.CommandType = CommandType.Text

    '        cmd.ExecuteNonQuery()
    '    Catch ex As MySqlException
    '        Debug.WriteLine(ex.Message)
    '    Finally
    '        closedb()
    '        MsgBox("item created")
    '    End Try
    'End Sub

    'Public Sub item_delete()
    '    opendb()

    '    sql = "delete from item where i_id = @iid"

    '    cmd = New MySqlCommand(sql, con)
    '    cmd.Parameters.AddWithValue("@iid", itm_id)
    '    cmd.CommandType = CommandType.Text
    '    cmd.ExecuteNonQuery()

    '    closedb()
    '    MsgBox("item deleted")

    'End Sub

    Public Sub item_update()
        Try
            opendb()
            sql = "update item set i_name = @iname, i_desc = @idesc, i_price = @ipr, i_quantiy = @qty where i_id = @iid"


            cmd = New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@iname", itm_categ)
            cmd.Parameters.AddWithValue("@idesc", itm_desc)
            cmd.Parameters.AddWithValue("@ipr", itm_pr)
            cmd.Parameters.AddWithValue("@qty", itm_qty)
            cmd.Parameters.AddWithValue("@iid", itm_id)
            cmd.CommandType = CommandType.Text

            cmd.ExecuteNonQuery()
        Catch ex As MySqlException
            Debug.WriteLine(ex.Message)
        Finally
            closedb()
            MsgBox("item updated")
        End Try
    End Sub
    Public Sub ShowTable(ByVal dataGrid As DataGridView)
        If dataGrid.RowCount > 0 Then
            dataGrid.DataSource.clear()
        End If
        opendb()
        sql = "select * from item"
        da = New MySqlDataAdapter(sql, con)
        da.Fill(ds, "item")
        dataGrid.DataSource = ds
        dataGrid.DataMember = "item"
        da.Dispose()
        ds.Dispose()
        closedb()
    End Sub

End Class
