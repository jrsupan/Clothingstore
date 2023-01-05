Imports System.IO.Ports
Public Class Form4
    Dim fr5 As New Form5
    Dim ardtvb As New arduinotovb
    Dim conn As connections






    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If Button1.Text = "connect" Then
            SerialPort1.BaudRate = Val(ComboBox2.SelectedItem)
            SerialPort1.PortName = ComboBox1.SelectedItem
            Try
                ardtvb.serialopen(SerialPort1)
                Button1.Text = "Disconnect"
                Groupbox1.Enabled = False

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            ardtvb.serialclose(SerialPort1)
            Groupbox1.Enabled = True
            Button1.Text = "connect"
        End If

        MessageBox.Show("Scan your rfid")





    End Sub

    Private Sub Form4_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        ardtvb.formload(ComboBox1, ComboBox2)
    End Sub

    Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        ardtvb.dataread(TextBox1, SerialPort1)
        Dim res As String = Replace(TextBox1.Text, Space(1), Space(0))
        Dim iid As Integer = Val("&H" & res)
        Dim cardid As Integer = Math.Abs(iid)
        TextBox1.Text = cardid


        ardtvb.admincard(TextBox1, SerialPort1, Me, fr5)


    End Sub
End Class