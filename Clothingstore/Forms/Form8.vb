Imports System.IO.Ports
Public Class Form8
    Dim ardtvb As New arduinotovb
    Public crtcrd As New crtcard




    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Button3.Text = "Connect" Then
            SerialPort1.BaudRate = Val(ComboBox2.SelectedItem)
            SerialPort1.PortName = ComboBox1.SelectedItem
            Try
                ardtvb.serialopen(SerialPort1)
                Button3.Text = "Disconnect"
                Groupbox1.Enabled = False
                GroupBox2.Enabled = True

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            ardtvb.serialclose(SerialPort1)
            Groupbox1.Enabled = True
            Button3.Text = "Connect"
            GroupBox2.Enabled = False

        End If

        MessageBox.Show("Scan your rfid")

    End Sub

    Private Sub Form8_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        ardtvb.formload(ComboBox1, ComboBox2)
    End Sub

    Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        ardtvb.dataread(txtncard, SerialPort1)
        Dim res As String = Replace(txtncard.Text, Space(1), Space(0))
        Dim iid As Integer = Val("&H" & res)
        Dim cardid As Integer = Math.Abs(iid)
        txtncard.Text = cardid
    End Sub



   
    Private Sub btncrtcard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncrtcard.Click
        crtcrd.cardids = txtncard.Text
        crtcrd.descs = txtdesc.Text

        Try
            crtcrd.card_add()
        Catch ex As Exception
            MsgBox("error")
        End Try

        txtdesc.Text = ""
        txtncard.Text = ""

    End Sub

    Private Sub btndone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndone.Click
        Me.Hide()
        Form2.Show()
        ardtvb.serialclose(SerialPort1)
    End Sub
End Class