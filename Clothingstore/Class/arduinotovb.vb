Imports System.IO.Ports
Imports MySql.Data.MySqlClient
Public Class arduinotovb
    Inherits connections


    Public Sub formload(ByVal combo1 As ComboBox, ByVal combo2 As ComboBox)
        Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        Try
            For Each port As String In SerialPort.GetPortNames()
                combo1.Items.Add(port)
            Next
            combo1.SelectedItem = 0
            combo2.SelectedItem = "96"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub serialopen(ByVal serial As SerialPort)
        serial.Open()
    End Sub
    Public Sub serialclose(ByVal serial As SerialPort)
        serial.Close()
    End Sub


    Public Sub dataread(ByVal txtboxx As TextBox, ByVal serial As SerialPort)
        txtboxx.Text = serial.ReadExisting()
    End Sub

    Public Sub admincard(ByVal txtcard As TextBox, ByVal serial As SerialPort, ByVal f4 As Form, ByVal f5 As Form)
        opendb()
        sql = "SELECT * FROM card WHERE card_id = '" & txtcard.Text & "'"
        cmd = New MySqlCommand(sql, con)
        dr = cmd.ExecuteReader

        Dim count As Integer
        count = 0
        While dr.Read
            count = count + 1
        End While
        If count = 1 Then
            MessageBox.Show("admin card")
            f4.Hide()
            f5.Show()
            txtcard.Text = ""
            serialclose(serial)
        Else
            MessageBox.Show("invalid card")
            txtcard.Text = ""
        End If
        closedb()

    End Sub


End Class
