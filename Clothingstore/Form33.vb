
Imports MySql.Data.MySqlClient
Public Class Form33

    Public conns As New connectionss


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If conns.con.State = ConnectionState.Closed Then
            conns.opendb()
            Form11.Label3.Text = "CONNECTED"
            Form11.Label3.ForeColor = Color.Green
            MessageBox.Show("DONE")
            Me.Hide()
            Form11.Show()
        End If
    End Sub
End Class