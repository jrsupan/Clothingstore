Imports MySql.Data.MySqlClient
Public MustInherit Class connections
    Protected con As New MySqlConnection
    Protected da As New MySqlDataAdapter
    Protected ds As New DataSet
    Protected cmd As New MySqlCommand
    Protected dr As MySqlDataReader
    Protected sql As String
    Protected dt As DataTable
    Protected trans As MySqlTransaction


    Public Sub opendb()
        con.ConnectionString = "server=localhost;User Id=root;database=sgcs;"
        con.Open()
    End Sub
    Public Sub closedb()
        con.Close()
    End Sub
    Protected Function GetReport(ByVal a As DataSet, ByVal sql As String, ByVal name As String) As DataSet
        opendb()
        Dim ds As New MySqlDataAdapter(sql, con)
        ds.Fill(a, name)
        closedb()
        Return a
    End Function
End Class
