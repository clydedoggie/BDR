
Imports System.IO
Imports Microsoft.Reporting.WinForms
Module mdlMain

    Public Sub StartupBDR(sStartupArgs As String, bFirstInstance As Boolean)

        Dim nWaitSec As Long = 0
        Dim bBatchReport As Boolean = True
        Dim sFolderToSaveTo As String = ""
        Dim sFileName As String = ""
        Dim dDateAndTime As DateTime = Now()

        If My.Settings.AutoReportOn Then
            '          If colStartupArgs.Count > 0 Then
            If Len(sStartupArgs) > 0 Then
                Dim sWaitSec As String = sStartupArgs
                If Left(sWaitSec, 1) = "\" Then sWaitSec = Mid(sWaitSec, 2, 10)
                If IsNumeric(sWaitSec) Then
                    nWaitSec = CLng(sWaitSec)
                Else
                    nWaitSec = 0
                End If
                bBatchReport = (nWaitSec >= 0)
                frmMain.Visible = True
                If nWaitSec > 0 Then ProgramPause(nWaitSec)
                If bBatchReport Then
                    frmMain.grdBatchSelection.Refresh()
                    frmMain.grdBatchSelection.Model.Selections.Clear()
                    frmMain.grdBatchSelection.Model.Selections.Add(Syncfusion.Windows.Forms.Grid.GridRangeInfo.Rows(1, 1))
                    frmMain.MoveGridToTextBoxes()
                    dDateAndTime = frmMain.txtBatchID.Text
                    sFileName = My.Settings.BatchReportPath & "\Batch Report " & dDateAndTime.Day & "_" & dDateAndTime.Month & "_" & dDateAndTime.Year _
                        & "_" & dDateAndTime.Hour & "_" & dDateAndTime.Minute & "_" & dDateAndTime.Second & ".pdf"
                    frmMain.ShowBatchReport()
                Else
                    dDateAndTime = DateAdd(DateInterval.Day, -1, dDateAndTime)
                    sFileName = My.Settings.AEReportPath & "\Event and Alarm Report " & dDateAndTime.Month & "_" & dDateAndTime.Day & "_" & dDateAndTime.Year & ".pdf"
                    frmMain.txtStartTime.Text = dDateAndTime.Month & "/" & dDateAndTime.Day & "/" & dDateAndTime.Year & " 00:00:00"
                    frmMain.txtEndTime.Text = dDateAndTime.Month & "/" & dDateAndTime.Day & "/" & dDateAndTime.Year & " 23:59:59"
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
