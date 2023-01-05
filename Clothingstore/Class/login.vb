Imports MySql.Data.MySqlClient
Public Class login
    Inherits connections
    Private user As String
    Private pass As String
    Public Sub New(ByVal user As String, ByVal pass As String)
        Me.user = user
        Me.pass = pass

    End Sub
    Public Property users As String
        Get
            Return user
        End Get
        Set(ByVal value As String)
            user = value
        End Set
    End Property
    Public Property passs As String
        Get
            Return pass
        End Get
        Set(ByVal value As String)
            pass = value
        End Set
    End Property
    Public Sub logins()
            opendb()
            sql = "SELECT * FROM employee WHERE e_user='" & user & "' and e_pass = '" & pass & "'"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader

            Dim count As Integer
            count = 0
            While dr.Read
                count = count + 1
            End While
            If count = 1 Then
                MessageBox.Show("Login Successful!")
                Form1.Show()
                Form2.Hide()
            Else
                MessageBox.Show("invalid username or password!")
            End If
            closedb()
    End Sub
    Public Sub array(ByVal list As List(Of login))
        list.Add(Me)
    End Sub
End Class
