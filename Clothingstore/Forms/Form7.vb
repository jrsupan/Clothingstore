Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class Form7
    Public rpt As New report
    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy/MM/dd"
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "yyyy/MM/dd"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim crys As New Crystalsale2
        crys.SetDataSource(rpt.sales2(DateTimePicker1.Text, DateTimePicker2.Text).tables("order_records"))
        CrystalReportViewer1.ReportSource = crys
        CrystalReportViewer1.Refresh()
    End Sub
End Class