Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class strecords
    Public rpt As New report
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim crys As New Crystalexpenses1
        crys.SetDataSource(rpt.rexpenses.tables("stock_records"))
        CrystalReportViewer1.ReportSource = crys
        CrystalReportViewer1.Refresh()
    End Sub

End Class