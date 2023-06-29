
Imports System.IO

Module mdlMain

    Public Sub StartupBDR(sStartupArgs As String, bFirstInstance As Boolean)

        Dim nWaitSec As Long = 0
        Dim bBatchReport As Boolean = True
        Dim sFolderToSaveTo As String = ""
        Dim sFileName As String = ""
        Dim dDateAndTime As DateTime = Now()
        ' Set time format to use in app
        If My.Settings.Use24Hr Then
            GlobalVariables.TimeFormatLong = "MM/dd/yy HH:mm:ss.f"
            GlobalVariables.TimeFormatShort = "MM/dd/yy HH:mm:ss"
        Else
            GlobalVariables.TimeFormatLong = "MM/dd/yy hh:mm:ss.f tt"
            GlobalVariables.TimeFormatShort = "MM/dd/yy hh:mm:ss tt"
        End If
        ' If Auto Report is enabled then check for startup argument. If found and >0 then generate last Batch report, save to pdf, and close.
        ' If found but =0 then generate Event and Alarm report for last day.
        ' If found it should be a numeric value that indicates delay to wait until generating report (for all data to be written to db).

        If My.Settings.AutoReportOn Then
            If Len(sStartupArgs) > 0 Then
                Dim sWaitSec As String = sStartupArgs
                'may or may not have '\' preceding number
                If Left(sWaitSec, 1) = "\" Then sWaitSec = Mid(sWaitSec, 2, 10)
                'if startup arg is number then wait
                If IsNumeric(sWaitSec) Then
                    nWaitSec = CLng(sWaitSec)
                Else
                    nWaitSec = 0
                End If
                'boolean indicating whether batch report (>0) or analog data report
                bBatchReport = (nWaitSec >= 0)
                frmMain.Visible = True
                'prohibit user from closing form if opened for auto batch report
                If nWaitSec > 0 Then
                    frmMain.btnExit.Enabled = False
                    ProgramPause(nWaitSec)
                End If
                If bBatchReport Then
                    frmMain.grdBatchSelection.Refresh()
                    frmMain.grdBatchSelection.Model.Selections.Clear()
                    frmMain.grdBatchSelection.Model.Selections.Add(Syncfusion.Windows.Forms.Grid.GridRangeInfo.Rows(1, 1))
                    frmMain.MoveGridToTextBoxes()
                    dDateAndTime = frmMain.txtStartTime.Value
                    sFileName = My.Settings.BatchReportPath & "\Batch Report " & Format(dDateAndTime, "dd-MMM-yy HH.mm.ss") & ".pdf"
                    frmMain.ShowBatchReport()
                Else
                    dDateAndTime = DateAdd(DateInterval.Day, -1, dDateAndTime)
                    sFileName = My.Settings.AEReportPath & "\Event and Alarm Report " & dDateAndTime.Month & "_" & dDateAndTime.Day & "_" & dDateAndTime.Year & ".pdf"
                    frmMain.txtStartTime.Value = dDateAndTime.Month & "/" & dDateAndTime.Day & "/" & dDateAndTime.Year & " 00:00:00"
                    frmMain.txtEndTime.Value = dDateAndTime.Month & "/" & dDateAndTime.Day & "/" & dDateAndTime.Year & " 23:59:59"
                    frmMain.CustomTimes()
                    frmMain.ShowEventReport()
                End If
                SaveReportToPDF(frmReport.rvEvents.LocalReport, sFileName)
                frmReport.Close()
                If bFirstInstance Then
                    ProgramPause(10)
                    End
                End If
            End If
        End If
    End Sub
    Public Sub ProgramPause(ByVal nSeconds As Integer)

        Dim dLoopUntil As Date = DateAdd(DateInterval.Second, nSeconds, Now())
        Do While Now() < dLoopUntil
            System.Threading.Thread.Sleep(100)
            Application.DoEvents()
        Loop
    End Sub

    Public Sub SaveReportToPDF(ByVal rpt As Microsoft.Reporting.WinForms.LocalReport, ByVal savePath As String)
        Dim Bytes() As Byte = rpt.Render("PDF", "", Nothing, Nothing, Nothing, Nothing, Nothing)

        Using Stream As New FileStream(savePath, FileMode.Create)
            Stream.Write(Bytes, 0, Bytes.Length)
        End Using
    End Sub


End Module
