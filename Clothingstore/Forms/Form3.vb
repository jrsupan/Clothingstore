Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class Form3
    Public rpt As New report
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        
        Dim crys As New Crystalexpenses2
        crys.SetDataSource(rpt.rexpenses1(DateTimePicker1.Text, DateTimePicker2.Text).tables("stock_records"))
        CrystalReportViewer1.ReportSource = crys
        CrystalReportViewer1.Refresh()

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy/MM/dd"
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "yyyy/MM/dd"
    End Sub
End Class