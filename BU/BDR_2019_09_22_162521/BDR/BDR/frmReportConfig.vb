

Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Grouping
Imports Syncfusion.Windows.Forms.Grid

Public Class frmReportConfig
    Private mbStillLoading As Boolean = False

    Private Sub frmReportConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetConfigLIst()
        ResetForm()
    End Sub

    Private Sub SetConfigLIst()
        Dim dt As BPESDataSetTableAdapters.BatchReportConfigTableAdapter = New BPESDataSetTableAdapters.BatchReportConfigTableAdapter
        Try
            mbStillLoading = True
            dt.Connection.ConnectionString = My.Settings.BPESCnString
            Dim dv As DataView = New DataView(dt.GetReportConfig())
            Me.cboSelectConfig.DataSource = dv
            Me.cboSelectConfig.DisplayMember = "BRCDescription"
            Me.cboSelectConfig.ValueMember = "BatchReportConfigID"
            Dim dr() As DataRow = dt.GetReportConfig().Select("ActiveConfig = 1")
            mbStillLoading = False
            Me.cboSelectConfig.SelectedValue = dr(0)("BatchReportConfigID")
        Catch ex As Exception
            MsgBox("Form Load: Could not connect to Data - Check Connection" & Err.Description, vbCritical, "ERROR GETTING REPORT CONFIGURATION INFORMATION")
        End Try
    End Sub

    Private Sub RefillDatasets()
        If Not mbStillLoading Then
            Try
                BatchReportConfigTagsTableAdapter.Connection.ConnectionString = My.Settings.BPESCnString
                BatchReportConfigTagsTableAdapter.Fill(BPESDataSet.BatchReportConfigTags)
                TblReportTagGroupsTableAdapter.Connection.ConnectionString = My.Settings.BPESCnString
                TblReportTagGroupsTableAdapter.Fill(BPESDataSet.tblReportTagGroups, Me.cboSelectConfig.SelectedValue)
                BatchReportConfigGroupsTableAdapter.Connection.ConnectionString = My.Settings.BPESCnString
                BatchReportConfigGroupsTableAdapter.Fill(Me.BPESDataSet.BatchReportConfigGroups, Me.cboSelectConfig.SelectedValue)
                TagTableTableAdapter.Connection.ConnectionString = My.Settings.BPESCnString
                TagTableTableAdapter.Fill(Me.BPESDataSet.TagTable)
                taBatchReportConfigTableAdapter.Connection.ConnectionString = My.Settings.BPESCnString
                Me.grdRC.Refresh()
            Catch ex As Exception
                MsgBox("RefillDatasets: Could not connect to Data - Check Connection", vbCritical, "ERROR REPORT CONFIGURATION INFORMATION")
            End Try
        End If
    End Sub

    Private Sub grdRC_Click(ByVal sender As Object, ByVal e As EventArgs) Handles grdRC.TableControlCellClick
        Dim r As Record = grdRC.Table.DisplayElements(grdRC.TableControl.CurrentCell.RowIndex).ParentRecord
        'MsgBox("Group index:" & r.PrimaryKeys(0).ToString & " Tag index:" & r.PrimaryKeys(1).ToString)
        txtSelectedGrp.Text = r.GetData("BRCGroupName")
        cboTags.SelectedValue = r.PrimaryKeys(1)
    End Sub

    Private Sub cmdAddNewGroup_Click(sender As Object, e As EventArgs) Handles cmdAddNewGroup.Click
        Dim sNewGroupDesc As String = txtNewGrp.Text
        Dim r As Record
        For Each r In grdRC.Table.Records
            If UCase(r.GetData("BRCGroupName")) = UCase(sNewGroupDesc) Then
                MsgBox("Group Name already exists, Group must be unique", vbCritical, "INVALID OPERATION")
                Exit Sub
            End If
        Next
        If Len(sNewGroupDesc) = 0 Then
            MsgBox("You must have at least 3 char in Group Name", vbCritical, "INVALID OPERATION")
            Exit Sub
        End If
        If Len(sNewGroupDesc) > 50 Then
            MsgBox("You are limited to 50 char for the description", MsgBoxStyle.Critical, "INVALID OPERATION")
            Exit Sub
        End If
        BatchReportConfigGroupsTableAdapter.Insert(Me.cboSelectConfig.SelectedValue, sNewGroupDesc)
        Dim dr As DataRow() = BatchReportConfigGroupsTableAdapter.GetData(Me.cboSelectConfig.SelectedValue).Select("BRCGroupName = '" & sNewGroupDesc & "'")
        Dim lGroupID As Long = dr(0).Item("BRCGroupID")
        BatchReportConfigTagsTableAdapter.Insert(lGroupID, 0)
        RefillDatasets()
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdDeleteGroup_Click(sender As Object, e As EventArgs) Handles cmdDeleteGroup.Click
        BatchReportConfigGroupsTableAdapter.Delete(Me.cboGroups.SelectedValue)
        RefillDatasets()
    End Sub

    Private Sub cmdRemoveTag_Click(sender As Object, e As EventArgs) Handles cmdRemoveTag.Click
        Dim r As Record = grdRC.Table.DisplayElements(grdRC.TableControl.CurrentCell.RowIndex).ParentRecord
        BatchReportConfigTagsTableAdapter.Delete(r.PrimaryKeys(0), r.PrimaryKeys(1))
        RefillDatasets()
    End Sub

    Private Sub cmdAddTagToGroup_Click(sender As Object, e As EventArgs) Handles cmdAddTagToGroup.Click
        If grdRC.TableControl.CurrentCell.RowIndex = -1 Then
            MsgBox("You need to have a group selected to add tag")
            Exit Sub
        End If

        Dim rg As Record
        For Each rg In grdRC.Table.Records
            If rg.GetData("BRCGroupName") = Me.txtSelectedGrp.Text Then
                If rg.GetData("TagName") = Me.cboTags.Text Then
                    MsgBox("Selected Tag already in Group, only one instace of a tag allowed", vbCritical, "INVALID OPERATION")
                    Exit Sub
                End If
            End If
        Next

        Dim r As Record = grdRC.Table.DisplayElements(grdRC.TableControl.CurrentCell.RowIndex).ParentRecord
        BatchReportConfigTagsTableAdapter.Insert(r.PrimaryKeys(0), cboTags.SelectedValue)
        RefillDatasets()
    End Sub

    Private Sub SelectConfig(sender As Object, e As EventArgs) Handles cboSelectConfig.SelectedValueChanged
        ResetForm()
    End Sub

    Private Sub ResetForm()
        RefillDatasets()
        grdRC.TableOptions.ListBoxSelectionMode = SelectionMode.One

        If Not mbStillLoading Then
            Dim dt As BPESDataSetTableAdapters.BatchReportConfigTableAdapter = New BPESDataSetTableAdapters.BatchReportConfigTableAdapter
            dt.Connection.ConnectionString = My.Settings.BPESCnString
            Dim dv As DataView = New DataView(dt.GetReportConfig())
            dv.Sort = "BatchReportConfigID"
            Dim rowid As Integer = dv.Find(Me.cboSelectConfig.SelectedValue)
            If dv(rowid)("ActiveConfig") Then
                Me.cmdActive.Text = "Active"
                Me.cmdActive.ForeColor = Color.DarkGreen
                Me.cmdActive.Font = New Font(Me.cmdActive.Font, FontStyle.Bold)
            Else
                Me.cmdActive.Text = "Make Active"
                Me.cmdActive.ForeColor = Color.DarkRed
                Me.cmdActive.Font = New Font(Me.cmdActive.Font, FontStyle.Regular)
            End If
        End If
    End Sub

    Private Sub cmdDeleteConfig_Click(sender As Object, e As EventArgs) Handles cmdDeleteConfig.Click
        If Me.cboSelectConfig.Items.Count > 1 Then
            taBatchReportConfigTableAdapter.Delete(Me.cboSelectConfig.SelectedValue)
            SetConfigLIst()
            Me.cboSelectConfig.SelectedIndex = 0
        Else
            MsgBox("You cannot delete the last configuration!", vbCritical, "INVALID OPERATION")
        End If
    End Sub

    Private Sub cmdActive_Click(sender As Object, e As EventArgs) Handles cmdActive.Click
        Dim bUpdateID As Integer = Me.cboSelectConfig.SelectedValue
        taBatchReportConfigTableAdapter.Update(Me.cboSelectConfig.SelectedValue)
        ResetForm()
        SetConfigLIst()
    End Sub

    Private Sub cmdAddConfig_Click(sender As Object, e As EventArgs) Handles cmdAddConfig.Click
        Dim sDescription As String = InputBox("Enter Description for this configuration", "DESCRIPTION REQUIRED")

        If Len(sDescription) = 0 Then Exit Sub
        If Len(sDescription) > 50 Then
            MsgBox("You are limited to 50 char for the description", MsgBoxStyle.Critical, "INVALID OPERATION")
            Exit Sub
        End If
        taBatchReportConfigTableAdapter.Insert(sDescription)
        SetConfigLIst()
        ResetForm()
    End Sub
End Class