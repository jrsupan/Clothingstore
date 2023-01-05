Imports MySql.Data.MySqlClient
Public Class customer
    Inherits connections

    Private cus_id As Integer
    Private cus_age As Integer
    Private cus_name As String
    Private cus_add As String
    Private cus_pho As Integer

    Public Property cus_ids As Integer
        Get
            Return cus_id
        End Get
        Set(ByVal value As Integer)
            cus_id = value
        End Set
    End Property

    Public Property cus_names As String
        Get
            Return cus_name
        End Get
        Set(ByVal value As String)
            cus_name = value
        End Set
    End Property

    Public Property cus_adds As String
        Get
            Return cus_add
        End Get
        Set(ByVal value As String)
            cus_add = value
        End Set
    End Property

    Public Property cus_phos As Integer
        Get
            Return cus_pho
        End Get
        Set(ByVal value As Integer)
            cus_pho = value
        End Set
    End Property
    Public Property cus_ages As Integer
        Get
            Return cus_age
        End Get
        Set(ByVal value As Integer)
            cus_age = value
        End Set
    End Property

    Public Sub customer_add()
        Dim list As New Hashtable
        list.Add("@cage", cus_age)
        list.Add("@cname", cus_name)
        list.Add("@cadd", cus_add)
        list.Add("@cphone", cus_pho)

        Try
            opendb()
            sql = "insert into customer(c_age,c_name,c_add,c_phone) values (@cage,@cname,@cadd,@cphone)"

            cmd = New MySqlCommand(sql, con)
            For Each num As DictionaryEntry In list
                cmd.Parameters.AddWithValue(num.Key, num.Value)
            Next

            cmd.CommandType = CommandType.Text

            cmd.ExecuteNonQuery()
        Catch ex As MySqlException
            Debug.WriteLine(ex.Message)
        Finally
            closedb()
            MsgBox("customer created")
        End Try

    End Sub

    Public Sub customer_delete()
        opendb()
        sql = "delete from customer where c_id = @cid"

        cmd = New MySqlCommand(sql, con)
        cmd.Parameters.AddWithValue("@cid", cus_id)
        cmd.CommandType = CommandType.Text

        cmd.ExecuteNonQuery()
        closedb()
        MsgBox("customer deleted")
    End Sub

    Public Sub customer_update()
        Try
            opendb()
            sql = "update customer set c_age = @cage,c_name = @cname, c_add = @cadd, c_phone = @cphone where c_id = @cid"

            cmd = New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@cname", cus_name)
            cmd.Parameters.AddWithValue("@cadd", cus_add)
            cmd.Parameters.AddWithValue("@cage", cus_age)
            cmd.Parameters.AddWithValue("@cphone", cus_pho)
            cmd.Parameters.AddWithValue("@cid", cus_id)
            cmd.CommandType = CommandType.Text

            cmd.ExecuteNonQuery()
        Catch ex As MySqlException
            Debug.WriteLine(ex.Message)
        Finally
            closedb()
            MsgBox("customer updated")
        End Try
    End Sub
    Public Sub ShowTable(ByVal dataGrid As DataGridView)
        If dataGrid.RowCount > 0 Then
            dataGrid.DataSource.clear()
        End If
        opendb()
        sql = "Allcustomer"
        da = New MySqlDataAdapter(sql, con)
        da.Fill(ds, "customer")
        dataGrid.DataSource = ds
        dataGrid.DataMember = "customer"
        da.Dispose()
        ds.Dispose()
        closedb()
    End Sub
End Class
