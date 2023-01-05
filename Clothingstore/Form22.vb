Public Class Form22
    Public its As New itemshow



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
        Form11.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        its.ShowTable(itemshowdatagrid)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Text = Date.Now.ToString("MM-dd-yyyy  hh:mm:ss")
    End Sub

    Private Sub Form22_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        its.cmbshow(cmbdesc)
        Timer1.Enabled = True
    End Sub
End Class