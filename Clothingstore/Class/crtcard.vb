Imports MySql.Data.MySqlClient
Public Class crtcard
    Inherits connections

    Private cardid As String
    Private desc As String

    Public Property cardids As String
        Get
            Return cardid
        End Get
        Set(ByVal value As String)
            cardid = value
        End Set
    End Property

    Public Property descs As String
        Get
            Return desc
        End Get
        Set(ByVal value As String)
            desc = value
        End Set
    End Property

    Public Sub card_add()

        Try
            opendb()
            sql = "insert into card(card_id,description) values (@cardid,@desc)"

            cmd = New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@cardid", cardid)
            cmd.Parameters.AddWithValue("@desc", descs)
            cmd.CommandType = CommandType.Text

            cmd.ExecuteNonQuery()
        Catch ex As MySqlException
            Debug.WriteLine(ex.Message)
        Finally
            closedb()
            MsgBox("card created")
        End Try
    End Sub
End Class
