Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class Receipt
    Public rpt As New report

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        rpt.o_ids = TextBox1.Text
        Dim crys As New CrystalReceipt
        crys.SetDataSource(rpt.Report.tables("receipt"))
        CrystalReportViewer1.ReportSource = crys
        CrystalReportViewer1.Refresh()

    End Sub
End Class