Imports MySql.Data.MySqlClient
Public Class Form11
    Dim lin As New loginss
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form33.Show()
        Me.Hide()
    End Sub

    Private Sub Btnexitsys_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnexitsys.Click
        Me.Close()
    End Sub

    Private Sub Form11_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TextBox2.UseSystemPasswordChar = True
        Label3.Text = "NOT CONNECTED!"
        Label3.ForeColor = Color.Red
    End Sub

    Private Sub Btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnlogin.Click
        lin.logins(TextBox1, TextBox2)
    End Sub
End Class