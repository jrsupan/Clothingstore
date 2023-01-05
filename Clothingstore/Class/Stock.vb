Imports MySql.Data.MySqlClient
Public Class stock
    Inherits connections
    Private st_id As Integer
    Private i_id As Integer
    Private st_pr As Integer
    Private sp_id As Double
    Private st_date As Date
    Private price As Double
    Private st_qty As Integer
    Private st_name As String
    Private ct_desc As String
    Public Property st_prs As Integer
        Get
            Return st_pr
        End Get
        Set(ByVal value As Integer)
            st_pr = value
        End Set
    End Property
    Public Property i_ids As Integer
        Get
            Return i_id
        End Get
        Set(ByVal value As Integer)
            i_id = value
        End Set
    End Property
    Public Property sp_ids As Integer
        Get
            Return sp_id
        End Get
        Set(ByVal value As Integer)
            sp_id = value
        End Set
    End Property

    Public Property st_ids As Integer
        Get
            Return st_id
        End Get
        Set(ByVal value As Integer)
            st_id = value
        End Set
    End Property

    Public Property st_dates As Date
        Get
            Return st_date
        End Get
        Set(ByVal value As Date)
            st_date = value
        End Set
    End Property

    Public Property prices As Double
        Get
            Return price
        End Get
        Set(ByVal value As Double)
            price = value
        End Set
    End Property

    Public Property st_qtys As Integer
        Get
            Return st_qty
        End Get
        Set(ByVal value As Integer)
            st_qty = value
        End Set
    End Property
    Public Property st_names As String
        Get
            Return st_name
        End Get
        Set(ByVal value As String)
            st_name = value
        End Set
    End Property

    Public Property ct_descs As String
        Get
            Return ct_desc
        End Get
        Set(ByVal value As String)
            ct_desc = value
        End Set
    End Property

    Public Sub stock_add()

        Try
            opendb()
            trans = con.BeginTransaction

            sql = "insert into item(i_name,i_desc,i_price,i_quantiy)values(@iname,@idesc,@stpr,@qty)"
            cmd = New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@iname", st_name)
            cmd.Parameters.AddWithValue("@idesc", ct_desc)
            cmd.Parameters.AddWithValue("@stpr", st_pr)
            cmd.Parameters.AddWithValue("@qty", st_qty)
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()


            sql = "insert into stocks(supp_id,i_id,stocks_datestock,cost_price,stocks_quantity) values (@sid,(select max(i_id) from item),@sdate,@cpr,@qty)"

            cmd = New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@sid", sp_id)
            cmd.Parameters.AddWithValue("@sdate", st_date)
            cmd.Parameters.AddWithValue("@cpr", price)
            cmd.Parameters.AddWithValue("@qty", st_qty)
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()

            trans.Commit()
        Catch ex As MySqlException
            Debug.WriteLine(ex.Message)
            trans.Rollback()
        Finally
            closedb()
            MsgBox("stock created")
        End Try
    End Sub

    Public Sub stock_delete()
        Try
            opendb()
            trans = con.BeginTransaction
            'sql = "delete from item where i_id =  @stid"
            'cmd = New MySqlCommand(sql, con)
            'cmd.Parameters.AddWithValue("@stid", st_id)
            'cmd.CommandType = CommandType.Text
            'cmd.ExecuteNonQuery()

            sql = "update item set i_quantiy = i_quantiy - @qty where i_id = @stid"
            cmd = New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@qty", st_qty)
            cmd.Parameters.AddWithValue("@stid", i_id)
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()

            sql = "delete from stocks where s_id = @stid"
            cmd = New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@stid", st_id)
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()


            trans.Commit()
        Catch ex As Exception
            trans.Rollback()
        End Try
        closedb()
        MsgBox("item deleted")
    End Sub

    Public Sub ShowTable(ByVal dataGrid As DataGridView)
        If dataGrid.RowCount > 0 Then
            dataGrid.DataSource.clear()
        End If
        opendb()
        sql = "SELECT distinct * from stocks"
        da = New MySqlDataAdapter(sql, con)
        da.Fill(ds, "stocks")
        dataGrid.DataSource = ds
        dataGrid.DataMember = "stocks"
        da.Dispose()
        ds.Dispose()
        closedb()
    End Sub
    Public Sub combo(ByVal combox As ComboBox)
        opendb()
        sql = "SELECT supp_id from supplier"
        cmd = New MySqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While (dr.Read)
            combox.Items.Add(dr.Item(0))
        End While
        dr.Close()
        closedb()
    End Sub
    Public Sub show(ByVal text1 As TextBox, ByVal text2 As TextBox, ByVal combo As ComboBox)
        opendb()
        sql = "select supp_iname,supp_desc from supplier where supp_id = '" & combo.Text & "'"
        cmd = New MySqlCommand(sql, con)
        cmd.CommandType = CommandType.Text

        dr = cmd.ExecuteReader
        dr.Read()
        text1.Text = dr.Item(0)
        text2.Text = dr.Item(1)
        dr.Close()
        closedb()
    End Sub

    Public Sub stockr(ByVal dtg As DataGridView)
        opendb()
        sql = "select * from stock_records"
        da = New MySqlDataAdapter(sql, con)
        da.Fill(ds, "stock_records")
        dtg.DataSource = ds
        dtg.DataMember = "stock_records"
        da.Dispose()
        ds.Dispose()
        closedb()

    End Sub
    Public Sub restock()
        Try
            opendb()
            trans = con.BeginTransaction
            sql = "insert into stocks(supp_id,i_id,stocks_datestock,cost_price,stocks_quantity) values(@sid,@iid,@sdate,@cpr,@qty)"
            cmd = New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@sid", sp_id)
            cmd.Parameters.AddWithValue("@iid", i_id)
            cmd.Parameters.AddWithValue("@sdate", st_date)
            cmd.Parameters.AddWithValue("@cpr", st_pr)
            cmd.Parameters.AddWithValue("@qty", st_qty)
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()


            sql = "update item set i_quantiy = i_quantiy + @qty where i_id = @iid"
            cmd = New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@qty", st_qty)
            cmd.Parameters.AddWithValue("@iid", i_id)
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()

            trans.Commit()
        Catch ex As Exception
            trans.Rollback()
        End Try
        closedb()
        MsgBox("restock has been updated")
    End Sub
    Public Sub item(ByVal combox As ComboBox)
        opendb()
        sql = "select i_id from item"
        cmd = New MySqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While (dr.Read)
            combox.Items.Add(dr.Item(0))
        End While
        dr.Close()
        closedb()
    End Sub
    Public Sub items(ByVal text1 As TextBox, ByVal text2 As TextBox, ByVal combo As ComboBox)
        opendb()
        sql = "select i_name,i_desc from item where i_id = '" & combo.Text & "'"
        cmd = New MySqlCommand(sql, con)
        cmd.CommandType = CommandType.Text

        dr = cmd.ExecuteReader
        dr.Read()
        text1.Text = dr.Item(0)
        text2.Text = dr.Item(1)
        dr.Close()
        closedb()
    End Sub
End Class
