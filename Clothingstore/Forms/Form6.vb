Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class Form6
    Public rpt As New report
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim crys As New Crystalsale1
        crys.SetDataSource(rpt.sales1.tables("order_records"))
        CrystalReportViewer1.ReportSource = crys
        CrystalReportViewer1.Refresh()
    End Sub
End Class