Imports MySql.Data.MySqlClient
Public Class report
    Inherits connections
    Private o_id As Integer

    Public Property o_ids As Integer
        Get
            Return o_id
        End Get
        Set(ByVal value As Integer)
            o_id = value
        End Set
    End Property

    Public Overloads Function Report()
        Dim dt As New DataSet1
        Dim Sql As String = "select o.o_dateorder,o.o_cost,o.o_amount,o.o_change,o.o_id,c.c_name,i.i_desc,i.i_name,i.i_price,oi.o_quantity from customer as c,orderitem as oi,item as i,orderinfo as o where c.c_id = o.c_id and o.o_id = oi.o_id and oi.i_id = i.i_id and o.o_id =" & o_id
        Return GetReport(dt, Sql, "receipt")
    End Function
    Public Overloads Function rexpenses()
        Dim dt As New DataSet1
        Dim Sql As String = "select s_id,supp_id,supp_name,stocks_datestock,cost_price from stock_records"
        Return GetReport(dt, Sql, "stock_records")
    End Function
    Public Overloads Function rexpenses1(ByVal text1 As String, ByVal text2 As String)
        Dim dt As New DataSet1
        Dim Sql As String = "select s_id,supp_id,supp_name,stocks_datestock,cost_price from stock_records where stocks_datestock between '" & text1 & "' and '" & text2 & "'"
        Return GetReport(dt, Sql, "stock_records")
    End Function
    Public Overloads Function sales1()
        Dim dt As New DataSet1
        Dim Sql As String = "select o_id,c_id,c_name,o_dateorder,o_cost from order_records"
        Return GetReport(dt, Sql, "order_records")
    End Function
    Public Overloads Function sales2(ByVal text1 As String, ByVal text2 As String)
        Dim dt As New DataSet1
        Dim Sql As String = "select o_id,c_id,c_name,o_dateorder,o_cost from order_records where o_dateorder between '" & text1 & "'and'" & text2 & "'"
        Return GetReport(dt, Sql, "order_records")
    End Function
    Public Overloads Function Reports()
        Dim dt As New DataSet1
        Dim Sql As String = "select SUM(o.o_cost) As Cost, SUM(st.cost_price) As Amount, o.o_dateorder as Datedelivered, (SUM(o.o_cost) - SUM(st.cost_price)) As Total from stocks as st,item as i,orderitem as oi,orderinfo as o where st.i_id = i.i_id and i.i_id = oi.i_id and oi.o_id = o.o_id"
        Return GetReport(dt, Sql, "reports")
    End Function
End Class
