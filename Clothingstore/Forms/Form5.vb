Imports System.IO.Ports
Public Class Form5
    Dim crtusr As createuser
    Dim crt As New ArrayList
    Dim ar As New arduinotovb
    Dim fr4 As Form4

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        crtusr = New createuser(UTextBox1.Text, UTextBox2.Text)
        crtusr.create(crt)
        Dim cr As Object
        For Each cr In crt
            crtusr.user_add()
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Me.Hide()
        Form2.Show()
    End Sub
End Class