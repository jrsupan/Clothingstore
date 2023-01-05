Imports MySql.Data.MySqlClient
Public Class Form2
    Dim fr4 As New Form4
    Dim fr8 As New Form8
    Dim lgin As login
    Dim log As New List(Of login)
    Private Sub Btnexitsys_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnexitsys.Click
        Me.Close()
    End Sub
    Private Sub Btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnlogin.Click
        lgin = New login(TextBox1.Text, TextBox2.Text)
        lgin.array(log)
        Dim arr As Object
        For Each arr In log
            lgin.logins()
        Next
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox2.UseSystemPasswordChar = True
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        fr4.Show()
    End Sub

   
    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.Hide()
        fr8.show()
    End Sub
End Class