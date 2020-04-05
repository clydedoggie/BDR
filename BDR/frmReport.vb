
Public Class frmReport

    Private Sub frmReport_Unload(sender As Object, e As EventArgs) Handles MyBase.Closed
        frmMain.Show()
    End Sub

    Private Sub frmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        vwConditionEventTableAdapter.Connection.ConnectionString = My.Settings.BPESCnString
        vwConditionEventTableAdapter.Fill(BPESDataSet.vwEventsWithPhAndRec, gdStartTime, gdEndTime)
        UspBatchAnalogDataByGroupTableAdapter.Connection.ConnectionString = My.Settings.BPESCnString
        UspBatchAnalogDataByGroupTableAdapter.GetBatchAnalogData(BPESDataSet.uspBatchAnalogDataByGroup, frmMain.BatchID, frmMain.Period)
        UspBatchWithPhasesTableAdapter.Connection.ConnectionString = My.Settings.BPESCnString
        UspBatchWithPhasesTableAdapter.GetBatchWithPhases(BPESDataSet.uspBatchWithPhases, frmMain.BatchID)

        rvEvents.LocalReport.DataSources.Clear()
        If glReportType = 1 Then
            rvEvents.LocalReport.ReportEmbeddedResource = "BDR.rptMain.rdlc"
            rvEvents.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsEvents", vwConditionEventBindingSource))
        Else
            rvEvents.LocalReport.ReportEmbeddedResource = "BDR.rptBatch.rdlc"
            rvEvents.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsBatchEvents", vwConditionEventBindingSource))
            rvEvents.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsBatchHeaderInfo", uspBatchWithPhasesBindingSource))

            AddHandler rvEvents.LocalReport.SubreportProcessing, AddressOf ProcessSR

        End If
        rvEvents.LocalReport.Refresh()
        rvEvents.RefreshReport()
    End Sub

    Private Sub ProcessSR(ByVal sender As Object, ByVal e As Microsoft.Reporting.WinForms.SubreportProcessingEventArgs)

        e.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsBatchAnalogData", UspBAD_ByGroupTableAdapterBindingSource))

    End Sub

End Class