Imports MySql.Data.MySqlClient
Public Class connectionss
    Public con As New MySqlConnection
    Protected da As New MySqlDataAdapter
    Protected ds As New DataSet
    Protected cmd As New MySqlCommand
    Protected dr As MySqlDataReader
    Protected sql As String
    Protected dt As DataTable
    Protected trans As MySqlTransaction
    Protected connstr As String



    Public Sub opendb()
        connstr = "server='" & Form33.txtserver.Text & "';User Id=sgcsuser;database=sgcs;password=12345;"
        con.ConnectionString = connstr
        con.Open()
    End Sub

    Public Sub closedb()
        con.Close()
    End Sub
End Class
