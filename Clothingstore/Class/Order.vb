Imports MySql.Data.MySqlClient
Public Class Order
    Inherits connections
    Private order_id As Integer
    Private itemid As Integer
    Private itemname As String
    Private custid As Integer
    Private custname As String
    Private quantity As Integer
    Private odate As Date
    Private ocost As Integer
    Private oamount As Integer
    Private ochange As Integer

    Public Property order_ids As Integer
        Get
            Return order_id
        End Get
        Set(ByVal value As Integer)
            order_id = value
        End Set
    End Property

    Public Property itemids As Integer
        Get
            Return itemid
        End Get
        Set(ByVal value As Integer)
            itemid = value
        End Set
    End Property

    Public Property itemnames As String
        Get
            Return itemname
        End Get
        Set(ByVal value As String)
            itemname = value
        End Set
    End Property

    Public Property custids As Integer
        Get
            Return custid
        End Get
        Set(ByVal value As Integer)
            custid = value
        End Set
    End Property
    Public Property custnames As String
        Get
            Return custname
        End Get
        Set(ByVal value As String)
            custname = value
        End Set
    End Property

    Public Property quantitys As Integer
        Get
            Return quantity
        End Get
        Set(ByVal value As Integer)
            quantity = value
        End Set
    End Property

    Public Property odates As Date
        Get
            Return odate
        End Get
        Set(ByVal value As Date)
            odate = value
        End Set
    End Property
    Public Property ocosts As Integer
        Get
            Return ocost
        End Get
        Set(ByVal value As Integer)
            ocost = value
        End Set
    End Property
    Public Property oamounts As Integer
        Get
            Return oamount
        End Get
        Set(ByVal value As Integer)
            oamount = value
        End Set
    End Property
    Public Property ochanges As Integer
        Get
            Return ochange
        End Get
        Set(ByVal value As Integer)
            ochange = value
        End Set
    End Property
    Public Sub ordercustomer(ByVal dtg As DataGridView)

        Try
            opendb()
            trans = con.BeginTransaction()

            sql = "INSERT INTO orderinfo(c_id,o_dateorder,o_cost,o_amount,o_change) VALUES(@c_id,@o_dateorder,@o_cst,@o_amnt,@o_chng)"
            cmd = New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@c_id", custid)
            cmd.Parameters.AddWithValue("@o_dateorder", odate)
            cmd.Parameters.AddWithValue("@o_cst", ocost)
            cmd.Parameters.AddWithValue("@o_amnt", oamount)
            cmd.Parameters.AddWithValue("@o_chng", ochange)
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()

            For i = 0 To dtg.RowCount - 2

                sql = "INSERT INTO orderitem(i_id,o_id,o_quantity) VALUES(" & CInt(dtg(0, i).Value) & ",(SELECT MAX(o_id) FROM orderinfo)," & CInt(dtg(4, i).Value) & ")"
                cmd = New MySqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@i_id", itemid)
                cmd.Parameters.AddWithValue("@o_quantity", quantity)
                cmd.CommandType = CommandType.Text
                cmd.ExecuteNonQuery()

                sql = "update item set i_quantiy = i_quantiy - '" & CInt(dtg(4, i).Value) & "' where i_id = '" & CInt(dtg(0, i).Value) & "' "
                cmd = New MySqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@i_id", itemid)
                cmd.Parameters.AddWithValue("@o_quantity", quantity)
                cmd.CommandType = CommandType.Text
                cmd.ExecuteNonQuery()

            Next
            trans.Commit()
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        Finally
            closedb()
            MsgBox("Successful!")
        End Try
    End Sub
    Public Sub cancel(ByVal dtg As DataGridView)
        Try
            opendb()

            For i = 0 To dtg.RowCount - 2

                sql = "update item set i_quantiy = i_quantiy + '" & CInt(dtg(4, i).Value) & "' where i_id = '" & CInt(dtg(0, i).Value) & "' "
                cmd = New MySqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@i_id", itemid)
                cmd.Parameters.AddWithValue("@o_quantity", quantity)
                cmd.CommandType = CommandType.Text
                cmd.ExecuteNonQuery()

            Next
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        Finally
            closedb()
            MsgBox("Successful!")
        End Try
    End Sub

    Public Sub GetItemnames(ByVal textdesc As TextBox, ByVal textprice As TextBox, ByVal cinameBox As ComboBox, ByVal ciname As Label)
        opendb()
        sql = "SELECT i_id,i_desc,i_price FROM item WHERE i_name = '" & CStr(cinameBox.Text) & "'"
        cmd = New MySqlCommand(sql, con)
        cmd.CommandType = CommandType.Text
        dr = cmd.ExecuteReader

        dr.Read()
        ciname.Text = dr.Item(0)
        textdesc.Text = dr.Item(1)
        textprice.Text = dr.Item(2)
        dr.Close()
        closedb()
    End Sub

    Public Sub GetItemnamesz(ByVal cinamebox As ComboBox)
        opendb()
        sql = "SELECT i_name FROM item"
        cmd = New MySqlCommand(sql, con)
        dr = cmd.ExecuteReader()

        While (dr.Read)
            cinamebox.Items.Add(dr.Item(0))
        End While
        dr.Close()
        closedb()
    End Sub


    Public Sub getcustnames(ByVal cnameBox As ComboBox, ByVal cname As Label)
        opendb()
        sql = "SELECT c_id FROM customer WHERE c_name = '" & CStr(cnameBox.Text) & "'  "
        cmd = New MySqlCommand(sql, con)
        cmd.CommandType = CommandType.Text
        dr = cmd.ExecuteReader

        dr.Read()
        cname.Text = dr.Item(0)

        dr.Close()
        closedb()

    End Sub

    Public Sub getcustnamesz(ByVal cnameBox As ComboBox)
        opendb()
        sql = "SELECT c_name FROM customer"
        cmd = New MySqlCommand(sql, con)
        dr = cmd.ExecuteReader()

        While (dr.Read)
            cnameBox.Items.Add(dr.Item(0))
        End While

        dr.Close()
        closedb()

    End Sub

    Public Sub dtgrid(ByVal text1 As Label, ByVal itemn As ComboBox, ByVal text3 As TextBox, ByVal text4 As TextBox, ByVal text5 As NumericUpDown, ByVal textt As TextBox, ByVal dtg As DataGridView)
        textt.Text = CStr(0)

        dtg.ColumnCount = 5
        dtg.Columns(0).Name = "i_id"
        dtg.Columns(1).Name = "i_name"
        dtg.Columns(2).Name = "i_desc"
        dtg.Columns(3).Name = "i_price"
        dtg.Columns(4).Name = "i_quantiy"

        dtg.Rows.Add(CInt(text1.Text), CStr(itemn.Text), CStr(text3.Text), CInt(text4.Text), CInt(text5.Text))
        For i = 0 To dtg.RowCount - 2
            textt.Text = CStr(CInt(textt.Text) + (CInt(dtg(4, i).Value) * CInt(dtg(3, i).Value)))
        Next

    End Sub

    Public Sub records(ByVal dtg As DataGridView)
        opendb()
        sql = "select * from order_records"
        da = New MySqlDataAdapter(sql, con)
        da.Fill(ds, "order_records")
        dtg.DataSource = ds
        dtg.DataMember = "order_records"
        da.Dispose()
        ds.Dispose()
        closedb()

    End Sub
End Class
