Imports Syncfusion.WinForms.Input.Events

Public Class frmMain

    Public BatchID As Long
    Public Period As Long

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            UspBatchListTableAdapter.Connection.ConnectionString = My.Settings.BPESCnString
            UspBatchListTableAdapter.Fill(BPESDataSet.uspBatchList)
            qryTagTableTableAdapter.Connection.ConnectionString = My.Settings.BPESCnString
            qryTagTableTableAdapter.Fill(BPESDataSet.qryTagTable)
        Catch ex As Exception
            MsgBox("Could not connect to Data - Check Connection", vbCritical, "ERROR GETTING BATCH INFORMATION")
            grdBatchSelection.AllowResizeToFit = False
        End Try
        'grid sizing doesn't seem to take properties as configured at design time, so manually set them when form opens
        grdBatchSelection.Model.ColWidths(1) = 150
        grdBatchSelection.Model.ColWidths(2) = 300
        grdBatchSelection.Model.ColWidths(3) = 139
        grdBatchSelection.Model.ColWidths(4) = 139
        grdBatchSelection.Model.ColWidths(5) = 100
        grdBatchSelection.Top = 145
        grdBatchSelection.Left = 52
        grdBatchSelection.Width = 878
        grdBatchSelection.Height = 420
        'set time format to 24 hr or AM/PM, formats set in Startup event
        grdBatchSelection.GridBoundColumns("StartTime").StyleInfo.Format = GlobalVariables.TimeFormatShort
        grdBatchSelection.GridBoundColumns("EndTime").StyleInfo.Format = GlobalVariables.TimeFormatShort
        grdBatchSelection.GridBoundColumns("PLCBatchID").StyleInfo.Format = GlobalVariables.TimeFormatShort
        txtStartTime.Format = GlobalVariables.TimeFormatShort
        txtEndTime.Format = GlobalVariables.TimeFormatShort

        ShowActiveConfig()
    End Sub


    Private Sub ShowActiveConfig()
        Dim dt As BPESDataSetTableAdapters.BatchReportConfigTableAdapter = New BPESDataSetTableAdapters.BatchReportConfigTableAdapter
        dt.Connection.ConnectionString = My.Settings.BPESCnString
        Dim dr() As DataRow = dt.GetReportConfig().Select("ActiveConfig = 1")
        If dr.Count > 0 Then txtActiveConfig.Text = dr(0)("BRCDescription")
    End Sub

    Private Function GetTagIndex(sTag As String) As Long
        Dim nIndex As Long = 0
        Dim nCounter As Long = 0
        Dim dt As DataTable = qryTagTableTableAdapter.GetData()

        For nCounter = 0 To dt.Rows.Count - 1
            If dt.Rows(nCounter)("TagName").ToString() = sTag Then nIndex = nCounter
        Next nCounter
        GetTagIndex = nIndex
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub grdBatchSelection_CellClick(sender As Object, e As Syncfusion.Windows.Forms.Grid.GridCellClickEventArgs) Handles grdBatchSelection.CellClick
        MoveGridToTextBoxes()
    End Sub

    Public Sub MoveGridToTextBoxes()
        If grdBatchSelection.Model.SelectedRanges.Count > 0 Then
            ' txtStartTime.Text = Format(grdBatchSelection(grdBatchSelection.Model.SelectedRanges(0).Top, 3).CellValue, "M/dd/yy HH:mm:ss")
            'txtEndTime.Text = Format(grdBatchSelection(grdBatchSelection.Model.SelectedRanges(0).Top, 4).CellValue, "M/dd/yy HH:mm:ss")
            txtStartTime.Value = grdBatchSelection(grdBatchSelection.Model.SelectedRanges(0).Top, 3).CellValue
            txtEndTime.Value = grdBatchSelection(grdBatchSelection.Model.SelectedRanges(0).Top, 4).CellValue
            txtBatchID.Text = grdBatchSelection(grdBatchSelection.Model.SelectedRanges(0).Top, 1).Text
            btnBatchRpt.Enabled = True
        Else
            MsgBox("No Batch Selected", vbCritical)
        End If
    End Sub

    Public Sub CustomTimes()
        txtBatchID.Text = "Custom Dates"
        btnBatchRpt.Enabled = False
    End Sub

    Private Sub btnEventReport_Click(sender As Object, e As EventArgs) Handles btnEventReport.Click
        ShowEventReport()
    End Sub

    Public Sub ShowEventReport()
        Dim params(4) As Microsoft.Reporting.WinForms.ReportParameter
        If Not (IsDate(txtStartTime.Value) And IsDate(txtEndTime.Value)) Then
            MsgBox("Invalid Dates")
            Exit Sub
        End If
        glReportType = 1
        gdStartTime = Date.Parse(txtStartTime.Value)
        gdEndTime = Date.Parse(txtEndTime.Value)

        Cursor = Cursors.WaitCursor
        Try
            params(0) = New Microsoft.Reporting.WinForms.ReportParameter("StartTime", txtStartTime.Value)
            params(1) = New Microsoft.Reporting.WinForms.ReportParameter("EndTime", txtEndTime.Value)
            params(2) = New Microsoft.Reporting.WinForms.ReportParameter("BatchID", txtBatchID.Text)
            params(3) = New Microsoft.Reporting.WinForms.ReportParameter("ShowEvents", chkEvents.Checked)
            params(4) = New Microsoft.Reporting.WinForms.ReportParameter("ShowAlarms", chkAlarms.Checked)
            frmReport.Show()
            frmReport.TopMost = True
            frmReport.rvEvents.LocalReport.SetParameters(params)
            frmReport.rvEvents.RefreshReport()
        Catch
            Cursor = Cursors.Default
            MsgBox("Cannot process that timespan, try increasing period or decreasing time span")
        End Try
        Cursor = Cursors.Default
        Me.Visible = False
    End Sub

    Private Sub btnData_Click(sender As Object, e As EventArgs) Handles btnData.Click
        Dim dtStart As Date
        Dim dtEnd As Date
        Dim pth As String = My.Computer.FileSystem.SpecialDirectories.Temp
        Dim sFilename As String
        Dim nCounter As Integer
        Dim sLine As String = ""
        Dim dc As DataColumn
        Dim sSPName As String = ""

        If optInterpolated.Checked Then
            sSPName = "BDR.uspInterpolatedAnalogData"
        Else
            sSPName = "BDR.uspAnalogData"
        End If
        sFilename = Replace(Replace(Replace(txtBatchID.Text, " ", ""), "/", ""), ":", "") & ".txt"
        If Not (IsDate(txtStartTime.Value) And IsDate(txtEndTime.Value)) Then
            MsgBox("Invalid Dates")
            Exit Sub
        End If
        dtStart = Date.Parse(txtStartTime.Value)
        dtEnd = Date.Parse(txtEndTime.Value)
        Cursor = Cursors.WaitCursor
        Try
            Using cn = GetConnection()
                Dim cmd As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand(sSPName, cn) With {
                    .CommandType = CommandType.StoredProcedure,
                    .CommandTimeout = 120
                }
                cmd.Parameters.AddWithValue("@Start", dtStart)
                cmd.Parameters.AddWithValue("@End", dtEnd)
                If optInterpolated.Checked Then cmd.Parameters.AddWithValue("@Period", txtPeriod.Text)
                Using r = cmd.ExecuteReader()
                    If r.HasRows Then
                        Using outputFile As New System.IO.StreamWriter(pth & "\" & sFilename)
                            Dim dt As New DataTable
                            dt.Load(r)
                            For nCounter = 0 To dt.Columns.Count - 1
                                sLine = sLine & "#" & (dt.Columns(nCounter).ColumnName)
                            Next nCounter
                            outputFile.WriteLine(Replace(Mid(sLine, 2), "#", vbTab))
                            For Each dtr In dt.Rows
                                sLine = ""
                                For Each dc In dt.Columns
                                    sLine = sLine & "#" & (dtr(dc))
                                Next
                                outputFile.WriteLine(Replace(Mid(sLine, 2), "#", vbTab))
                            Next
                            outputFile.Close()
                        End Using
                        If System.IO.File.Exists(pth & "\" & sFilename) = True Then
                            Process.Start(pth & "\" & sFilename)
                        Else
                            Cursor = Cursors.Default
                            MsgBox("File Does Not Exist")
                        End If
                    Else
                        Cursor = Cursors.Default
                        MsgBox("No data returned for those parameters", MsgBoxStyle.Critical, "OPERATION FAILED")
                        Exit Sub
                    End If
                End Using
            End Using
        Catch
            Cursor = Cursors.Default
            MsgBox(Err.Description())
            MsgBox("Cannot process that timespan, try increasing period or decreasing time span")
        End Try
        Cursor = Cursors.Default
    End Sub

    Private Sub btnTools_Click(sender As Object, e As EventArgs) Handles btnTools.Click
        frmSettings.ShowDialog()
    End Sub

    Private Sub btnBatchRpt_Click(sender As Object, e As EventArgs) Handles btnBatchRpt.Click
        ShowBatchReport()
    End Sub

    Public Sub ShowBatchReport(Optional bRemote As Boolean = False)

        Dim params(3) As Microsoft.Reporting.WinForms.ReportParameter

        If Not bRemote Then
            If Not (IsDate(txtStartTime.Value) And IsDate(txtEndTime.Value)) Then
                MsgBox("Invalid Dates")
                Exit Sub
            End If
        End If
        glReportType = 2
        gdStartTime = Date.Parse(txtStartTime.Value)
        gdEndTime = Date.Parse(txtEndTime.Value)

        Cursor = Cursors.WaitCursor
        Try
            Period = txtPeriod.Text
            BatchID = grdBatchSelection(grdBatchSelection.Model.SelectedRanges(0).Top, 6).Text
            params(0) = New Microsoft.Reporting.WinForms.ReportParameter("StartTime", txtStartTime.Value)
            params(1) = New Microsoft.Reporting.WinForms.ReportParameter("EndTime", txtEndTime.Value)
            params(2) = New Microsoft.Reporting.WinForms.ReportParameter("BatchID", txtBatchID.Text)
            params(3) = New Microsoft.Reporting.WinForms.ReportParameter("BatchDesc", grdBatchSelection(grdBatchSelection.Model.SelectedRanges(0).Top, 2).Text)
            frmReport.Show()
            frmReport.TopMost = True
            frmReport.rvEvents.LocalReport.SetParameters(params)
            frmReport.rvEvents.RefreshReport()
        Catch
            Cursor = Cursors.Default
            MsgBox("Unknown error generating report", vbCritical, "RESTART BDR AND TRY AGAIN")
            Exit Sub
        End Try
        Cursor = Cursors.Default
        Me.Visible = False
    End Sub

    Private Sub cmdReportConfig_Click(sender As Object, e As EventArgs) Handles cmdReportConfig.Click
        Me.TopMost = False
        frmReportConfig.ShowDialog(Me)
        Me.TopMost = True
        ShowActiveConfig()
    End Sub

    Private Sub optInterpolated_CheckedChanged(sender As Object, e As EventArgs) Handles optInterpolated.CheckedChanged
        lblPeriod.Enabled = optInterpolated.Checked
        txtPeriod.Enabled = optInterpolated.Checked
    End Sub

    Private Sub txtStartTime_ValueChanged(sender As Object, e As DateTimeValueChangedEventArgs) Handles txtStartTime.ValueChanged
        CustomTimes()
    End Sub

    Private Sub txtEndTime_ValueChanged(sender As Object, e As DateTimeValueChangedEventArgs) Handles txtEndTime.ValueChanged
        CustomTimes()
    End Sub
End Class