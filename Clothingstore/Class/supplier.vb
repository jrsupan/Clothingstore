Imports MySql.Data.MySqlClient

Public Class Supplier
    Inherits connections

    Private s_id As Integer
    Private s_name As String
    Private s_phone As Integer
    Private s_iname As String
    Private s_desc As String


    Public Property s_ids As Integer
        Get
            Return s_id
        End Get
        Set(ByVal value As Integer)
            s_id = value
        End Set
    End Property

    Public Property s_names As String
        Get
            Return s_name
        End Get
        Set(ByVal value As String)
            s_name = value
        End Set
    End Property

    Public Property s_phones As Integer
        Get
            Return s_phone
        End Get
        Set(ByVal value As Integer)
            s_phone = value
        End Set
    End Property
    Public Property s_inames As String
        Get
            Return s_iname
        End Get
        Set(ByVal value As String)
            s_iname = value
        End Set
    End Property
    Public Property s_descs As String
        Get
            Return s_desc
        End Get
        Set(ByVal value As String)
            s_desc = value
        End Set
    End Property
    Public Sub supplier_add()
        Dim list As New ArrayList
        list.Add(s_name)
        list.Add(s_phone)
        list.Add(s_iname)
        list.Add(s_desc)
        For Each num In list
            Try
                opendb()
                sql = "insert into supplier(supp_name,supp_contact,supp_iname,supp_desc) values (@sname,@scontact,@iname,@desc)"

                cmd = New MySqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@sname", num.s_name)
                cmd.Parameters.AddWithValue("@scontact", num.s_phone)
                cmd.Parameters.AddWithValue("@iname", num.s_iname)
                cmd.Parameters.AddWithValue("@desc", num.s_desc)
                cmd.CommandType = CommandType.Text

                cmd.ExecuteNonQuery()
            Catch ex As MySqlException
                Debug.WriteLine(ex.Message)
            Finally
                closedb()
                MsgBox("supplier created")
            End Try
        Next
    End Sub

    Public Sub supplier_delete()
        opendb()
        sql = "delete from supplier where supp_id = @sid"

        cmd = New MySqlCommand(sql, con)
        cmd.Parameters.AddWithValue("@sid", s_id)
        cmd.CommandType = CommandType.Text

        cmd.ExecuteNonQuery()
        closedb()
        MsgBox("supplier deleted")
    End Sub

    Public Sub supplier_update()
        Dim list As New ArrayList
        list.Add(s_name)
        list.Add(s_phone)
        list.Add(s_id)
        list.Add(s_iname)
        list.Add(s_desc)
        For Each num In list
            Try
                opendb()
                sql = "update supplier set supp_name = @sname, supp_contact = @scontact, supp_iname = @iname, supp_desc = @desc where supp_id = @sid"


                cmd = New MySqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@sname", num.s_name)
                cmd.Parameters.AddWithValue("@scontact", num.s_phone)
                cmd.Parameters.AddWithValue("@sid", num.s_id)
                cmd.Parameters.AddWithValue("@iname", num.s_iname)
                cmd.Parameters.AddWithValue("@desc", num.s_desc)
                cmd.CommandType = CommandType.Text

                cmd.ExecuteNonQuery()
            Catch ex As MySqlException
                Debug.WriteLine(ex.Message)
            Finally
                closedb()
                MsgBox("supplier updated")
            End Try
        Next
    End Sub
    Public Sub ShowTable(ByVal dataGrid As DataGridView)
        If dataGrid.RowCount > 0 Then
            dataGrid.DataSource.clear()
        End If
        opendb()
        sql = "Allsupplier"
        da = New MySqlDataAdapter(sql, con)
        da.Fill(ds, "supplier")
        dataGrid.DataSource = ds
        dataGrid.DataMember = "supplier"
        da.Dispose()
        ds.Dispose()
        closedb()
    End Sub
End Class
