Imports System.Reflection

Public Class frmSettings
    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim sCnString() As String = Split(My.Settings.BPESCnString, ";")

        txtDatabase.Text = Mid(sCnString(1), 17)
        txtSqlServer.Text = Mid(sCnString(0), 13)
        txtAEReportPath.Text = My.Settings.AEReportPath
        txtBatchReportPath.Text = My.Settings.BatchReportPath
        chkAutoRptOn.Checked = My.Settings.AutoReportOn
        Me.lblVersion.Text = "CPS Basic Data Reporting v" & Assembly.GetExecutingAssembly().GetName().Version.Major & "." & Assembly.GetExecutingAssembly().GetName().Version.Minor
    End Sub

    Private Sub btnUpdateCn_Click(sender As Object, e As EventArgs) Handles btnUpdateCn.Click

        Dim sCnString As String = "Data Source=SQL SERVER;Initial Catalog=DATABASE;Integrated Security=True;Connect Timeout=120"
        'Dim sCnString As String = "Data Source=SQL SERVER;Initial Catalog=DATABASE;Integrated Security=False;User ID=sa;Password=adminbpes;Connect Timeout=60"

        sCnString = Replace(Replace(sCnString, "SQL SERVER", txtSqlServer.Text), "DATABASE", txtDatabase.Text)
        My.Settings.BPESCnString = sCnString
        My.Settings.Save()

    End Sub

    Private Sub btnUpdateAutoReport_Click(sender As Object, e As EventArgs) Handles cmdUpdateAutoReport.Click

        Dim bEnabled As Boolean = Me.chkAutoRptOn.Checked
        Dim bValidPaths As Boolean = False

        If bEnabled Then
            bValidPaths = (Len(txtAEReportPath.Text) > 0 And Len(txtBatchReportPath.Text) > 0)
            If bValidPaths Then
                bValidPaths = bValidPaths And FileIO.FileSystem.GetDirectoryInfo(txtAEReportPath.Text).Exists _
                And FileIO.FileSystem.GetDirectoryInfo(txtBatchReportPath.Text).Exists
            End If
            If Not bValidPaths Then
                MsgBox("Invalid path to store Auto reports")
                Exit Sub
            End If
        End If
        My.Settings.AutoReportOn = bEnabled
        My.Settings.AEReportPath = txtAEReportPath.Text
        My.Settings.BatchReportPath = txtBatchReportPath.Text
        My.Settings.Save()

    End Sub

    Private Sub txtBatchReportPath_Clicked(sender As Object, e As EventArgs) Handles txtBatchReportPath.Click

        Dim oGetFldrPath As New FolderBrowserDialog()

        oGetFldrPath.SelectedPath = txtBatchReportPath.Text
        If DialogResult.OK = oGetFldrPath.ShowDialog() Then
            txtBatchReportPath.Text = oGetFldrPath.SelectedPath
        End If

    End Sub
    Private Sub txtAEReportPath_Clicked(sender As Object, e As EventArgs) Handles txtAEReportPath.Click

        Dim oGetFldrPath As New FolderBrowserDialog()

        oGetFldrPath.SelectedPath = txtAEReportPath.Text
        If DialogResult.OK = oGetFldrPath.ShowDialog() Then
            txtAEReportPath.Text = oGetFldrPath.SelectedPath
        End If

    End Sub

End Class