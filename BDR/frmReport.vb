
Public Class frmReport

    Private Sub frmReport_Unload(sender As Object, e As EventArgs) Handles MyBase.Closed
        frmMain.Show()
    End Sub

    Private Sub frmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'set up data sources, used depending on which report is being generated
        vwConditionEventTableAdapter.Connection.ConnectionString = My.Settings.BPESCnString
        vwConditionEventTableAdapter.Fill(BPESDataSet.vwEventsWithPhAndRec, gdStartTime, DateAdd(DateInterval.Second, 1, gdEndTime))
        UspBatchAnalogDataByGroupTableAdapter.Connection.ConnectionString = My.Settings.BPESCnString
        UspBatchAnalogDataByGroupTableAdapter.GetBatchAnalogData(BPESDataSet.uspBatchAnalogDataByGroup, frmMain.BatchID, frmMain.Period)
        UspBatchWithPhasesTableAdapter.Connection.ConnectionString = My.Settings.BPESCnString
        UspBatchWithPhasesTableAdapter.GetBatchWithPhases(BPESDataSet.uspBatchWithPhases, frmMain.BatchID)

        rvEvents.LocalReport.DataSources.Clear()
        'Alarm and Event report
        If glReportType = 1 Then
            rvEvents.LocalReport.ReportEmbeddedResource = "BDR.rptMain.rdlc"
            rvEvents.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsEvents", vwConditionEventBindingSource))
        Else    'Batch report
            rvEvents.LocalReport.ReportEmbeddedResource = "BDR.rptBatch.rdlc"
            rvEvents.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsBatchEvents", vwConditionEventBindingSource))
            rvEvents.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsBatchHeaderInfo", uspBatchWithPhasesBindingSource))
            'attach event so subreport can get datasource when it is generated
            AddHandler rvEvents.LocalReport.SubreportProcessing, AddressOf ProcessSR
        End If
        'pass in param used to format date fields
        rvEvents.LocalReport.SetParameters(New ReportParameter(name:="DateFormatShort", value:=GlobalVariables.TimeFormatShort))
        rvEvents.LocalReport.SetParameters(New ReportParameter(name:="DateFormatLong", value:=GlobalVariables.TimeFormatLong))

        rvEvents.LocalReport.Refresh()
        rvEvents.RefreshReport()
    End Sub

    Private Sub ProcessSR(ByVal sender As Object, ByVal e As Microsoft.Reporting.WinForms.SubreportProcessingEventArgs)

        e.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsBatchAnalogData", UspBAD_ByGroupTableAdapterBindingSource))

    End Sub

End Class