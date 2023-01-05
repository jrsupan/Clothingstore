Imports MySql.Data.MySqlClient
Public Class createuser
    Inherits connections
    Private user As String
    Private password As String
    Public Sub New(ByVal user As String, ByVal password As String)
        Me.user = user
        Me.password = password
    End Sub

    Public Property users As String
        Get
            Return user
        End Get
        Set(ByVal value As String)
            user = value
        End Set
    End Property

    Public Property passwords As String
        Get
            Return password
        End Get
        Set(ByVal value As String)
            password = value
        End Set
    End Property
    Public Sub create(ByVal list As ArrayList)
        list.Add(New createuser(user, password))
    End Sub
    Public Sub user_add()

            Try
                opendb()
                sql = "insert into employee(e_user,e_pass) values (@user,@pass)"

                cmd = New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@user", user)
            cmd.Parameters.AddWithValue("@pass", password)
                cmd.CommandType = CommandType.Text

                cmd.ExecuteNonQuery()
            Catch ex As MySqlException
                Debug.WriteLine(ex.Message)
            Finally
                closedb()
                MsgBox("new user created")
        End Try
    End Sub
    
End Class
