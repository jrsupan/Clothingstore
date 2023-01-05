Imports MySql.Data.MySqlClient
Public Class loginss
    Inherits connectionss

    Public Sub logins(ByVal text1 As TextBox, ByVal text2 As TextBox)

        Try
            opendb()
            Dim sql As String
            sql = "SELECT * FROM employee WHERE e_user='" & text1.Text & "' and e_pass = '" & text2.Text & "'"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader

            Dim count As Integer
            count = 0
            While dr.Read
                count = count + 1
            End While

            If count = 1 Then
                MessageBox.Show("Login Successful!")
                Form22.Show()
                Form11.Hide()
            Else
                MessageBox.Show("Invalid Username or Password!")
            End If
            closedb()

        Catch ex As Exception
            MessageBox.Show("Check Database")

        End Try

        text1.Text = ""
        text2.Text = ""
    End Sub

End Class
