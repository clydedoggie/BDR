<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReportConfig
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridColumnDescriptor1 As Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor = New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor()
        Dim GridColumnDescriptor2 As Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor = New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor()
        Me.TblReportTagGroupsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboTags = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
        Me.BPESDataSet = New BDR.BPESDataSet()
        Me.cboGroups = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
        Me.grdRC = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl()
        Me.BPESDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblReportTagGroupsTableAdapter = New BDR.BPESDataSetTableAdapters.tblReportTagGroupsTableAdapter()
        Me.BatchReportConfigTagsTableAdapter = New BDR.BPESDataSetTableAdapters.BatchReportConfigTagsTableAdapter()
        Me.BatchReportConfigGroupsTableAdapter = New BDR.BPESDataSetTableAdapters.BatchReportConfigGroupsTableAdapter()
        Me.TagTableTableAdapter = New BDR.BPESDataSetTableAdapters.TagTableTableAdapter()
        Me.cmdAddTagToGroup = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.txtNewGrp = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.cmdAddNewGroup = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.cmdRemoveTag = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.txtSelectedGrp = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdDeleteGroup = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.ComboBoxAdv1 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdClose = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.cboSelectConfig = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
        Me.TextBoxExt1 = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.taBatchReportConfigTableAdapter = New BDR.BPESDataSetTableAdapters.BatchReportConfigTableAdapter()
        Me.cmdAddConfig = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.cmdDeleteConfig = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.cmdActive = New Syncfusion.Windows.Forms.ButtonAdv()
        CType(Me.TblReportTagGroupsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTags, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BPESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGroups, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdRC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BPESDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNewGrp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSelectedGrp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ComboBoxAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.cboSelectConfig, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBoxExt1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboTags
        '
        Me.cboTags.BeforeTouchSize = New System.Drawing.Size(129, 21)
        Me.cboTags.DataSource = Me.BPESDataSet
        Me.cboTags.DisplayMember = "TagTable.TagName"
        Me.cboTags.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTags.Location = New System.Drawing.Point(167, 29)
        Me.cboTags.Name = "cboTags"
        Me.cboTags.Size = New System.Drawing.Size(129, 21)
        Me.cboTags.TabIndex = 6
        Me.cboTags.ValueMember = "TagTable.TagIndex"
        '
        'BPESDataSet
        '
        Me.BPESDataSet.DataSetName = "BPESDataSet"
        Me.BPESDataSet.EnforceConstraints = False
        Me.BPESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cboGroups
        '
        Me.cboGroups.BeforeTouchSize = New System.Drawing.Size(191, 21)
        Me.cboGroups.DataSource = Me.BPESDataSet
        Me.cboGroups.DisplayMember = "BatchReportConfigGroups.BRCGroupName"
        Me.cboGroups.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGroups.Location = New System.Drawing.Point(10, 78)
        Me.cboGroups.Name = "cboGroups"
        Me.cboGroups.Size = New System.Drawing.Size(191, 21)
        Me.cboGroups.TabIndex = 5
        Me.cboGroups.ValueMember = "BatchReportConfigGroups.BRCGroupID"
        '
        'grdRC
        '
        Me.grdRC.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grdRC.BackColor = System.Drawing.SystemColors.Window
        Me.grdRC.DataMember = "tblReportTagGroups"
        Me.grdRC.DataSource = Me.BPESDataSet
        Me.grdRC.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdRC.Location = New System.Drawing.Point(21, 75)
        Me.grdRC.MarkRowHeader = True
        Me.grdRC.Name = "grdRC"
        Me.grdRC.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus
        Me.grdRC.Size = New System.Drawing.Size(239, 501)
        Me.grdRC.TabIndex = 2
        Me.grdRC.TableDescriptor.AllowEdit = False
        Me.grdRC.TableDescriptor.AllowNew = False
        Me.grdRC.TableDescriptor.AllowRemove = False
        GridColumnDescriptor1.GroupByAppearance.ColumnHeaderCell.Enabled = False
        GridColumnDescriptor1.GroupByAppearance.ColumnHeaderCell.Interior = New Syncfusion.Drawing.BrushInfo()
        GridColumnDescriptor1.GroupByAppearance.ColumnHeaderCell.ReadOnly = True
        GridColumnDescriptor1.GroupByOptions.CaptionText = " {Category} "
        GridColumnDescriptor1.GroupByOptions.IsExpandedInitialValue = True
        GridColumnDescriptor1.GroupByOptions.ShowSummaries = False
        GridColumnDescriptor1.HeaderText = "Group"
        GridColumnDescriptor1.MappingName = "BRCGroupName"
        GridColumnDescriptor1.ReadOnly = True
        GridColumnDescriptor2.AllowGroupByColumn = False
        GridColumnDescriptor2.HeaderText = "Tags"
        GridColumnDescriptor2.MappingName = "TagName"
        GridColumnDescriptor2.ReadOnly = True
        GridColumnDescriptor2.Width = 150
        Me.grdRC.TableDescriptor.Columns.AddRange(New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor() {GridColumnDescriptor1, GridColumnDescriptor2})
        Me.grdRC.TableDescriptor.GroupedColumns.AddRange(New Syncfusion.Grouping.SortColumnDescriptor() {New Syncfusion.Grouping.SortColumnDescriptor("BRCGroupName", System.ComponentModel.ListSortDirection.Ascending)})
        Me.grdRC.TableDescriptor.Name = "tblReportTagGroupsDescriptor"
        Me.grdRC.TableDescriptor.PrimaryKeyColumns.AddRange(New Syncfusion.Grouping.SortColumnDescriptor() {New Syncfusion.Grouping.SortColumnDescriptor("BRCGroupID", System.ComponentModel.ListSortDirection.Ascending), New Syncfusion.Grouping.SortColumnDescriptor("TagIndex", System.ComponentModel.ListSortDirection.Ascending)})
        Me.grdRC.TableDescriptor.SortedColumns.AddRange(New Syncfusion.Grouping.SortColumnDescriptor() {New Syncfusion.Grouping.SortColumnDescriptor("BRCGroupName", System.ComponentModel.ListSortDirection.Ascending)})
        Me.grdRC.TableDescriptor.TableOptions.AllowDragColumns = False
        Me.grdRC.TableDescriptor.TableOptions.AllowMultiColumnSort = False
        Me.grdRC.TableDescriptor.TableOptions.AllowSelection = Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Row
        Me.grdRC.TableDescriptor.TableOptions.ShowRowHeader = True
        Me.grdRC.TableDescriptor.TopLevelGroupOptions.ShowCaption = False
        Me.grdRC.TableDescriptor.VisibleColumns.AddRange(New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor() {New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("TagName")})
        Me.grdRC.Text = "GridGroupingControl2"
        Me.grdRC.UseRightToLeftCompatibleTextBox = True
        Me.grdRC.VersionInfo = "15.3460.0.33"
        '
        'BPESDataSetBindingSource
        '
        Me.BPESDataSetBindingSource.DataMember = "BatchReportConfigTags"
        Me.BPESDataSetBindingSource.DataSource = Me.BPESDataSet
        '
        'TblReportTagGroupsTableAdapter
        '
        Me.TblReportTagGroupsTableAdapter.ClearBeforeFill = True
        '
        'BatchReportConfigTagsTableAdapter
        '
        Me.BatchReportConfigTagsTableAdapter.ClearBeforeFill = True
        '
        'BatchReportConfigGroupsTableAdapter
        '
        Me.BatchReportConfigGroupsTableAdapter.ClearBeforeFill = True
        '
        'TagTableTableAdapter
        '
        Me.TagTableTableAdapter.ClearBeforeFill = True
        '
        'cmdAddTagToGroup
        '
        Me.cmdAddTagToGroup.BeforeTouchSize = New System.Drawing.Size(94, 47)
        Me.cmdAddTagToGroup.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddTagToGroup.IsBackStageButton = False
        Me.cmdAddTagToGroup.Location = New System.Drawing.Point(178, 78)
        Me.cmdAddTagToGroup.Name = "cmdAddTagToGroup"
        Me.cmdAddTagToGroup.Size = New System.Drawing.Size(94, 47)
        Me.cmdAddTagToGroup.TabIndex = 9
        Me.cmdAddTagToGroup.Text = "Add New Tag"
        '
        'txtNewGrp
        '
        Me.txtNewGrp.BeforeTouchSize = New System.Drawing.Size(239, 20)
        Me.txtNewGrp.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewGrp.Location = New System.Drawing.Point(10, 24)
        Me.txtNewGrp.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtNewGrp.Name = "txtNewGrp"
        Me.txtNewGrp.Size = New System.Drawing.Size(191, 27)
        Me.txtNewGrp.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtNewGrp.TabIndex = 11
        Me.txtNewGrp.Text = "Enter New Group Name"
        '
        'cmdAddNewGroup
        '
        Me.cmdAddNewGroup.BeforeTouchSize = New System.Drawing.Size(94, 47)
        Me.cmdAddNewGroup.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddNewGroup.IsBackStageButton = False
        Me.cmdAddNewGroup.Location = New System.Drawing.Point(207, 13)
        Me.cmdAddNewGroup.Name = "cmdAddNewGroup"
        Me.cmdAddNewGroup.Size = New System.Drawing.Size(94, 47)
        Me.cmdAddNewGroup.TabIndex = 13
        Me.cmdAddNewGroup.Text = "Add New Group"
        '
        'cmdRemoveTag
        '
        Me.cmdRemoveTag.BeforeTouchSize = New System.Drawing.Size(94, 47)
        Me.cmdRemoveTag.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRemoveTag.IsBackStageButton = False
        Me.cmdRemoveTag.Location = New System.Drawing.Point(65, 78)
        Me.cmdRemoveTag.Name = "cmdRemoveTag"
        Me.cmdRemoveTag.Size = New System.Drawing.Size(94, 47)
        Me.cmdRemoveTag.TabIndex = 15
        Me.cmdRemoveTag.Text = "Remove Tag"
        '
        'txtSelectedGrp
        '
        Me.txtSelectedGrp.BackColor = System.Drawing.SystemColors.Control
        Me.txtSelectedGrp.BeforeTouchSize = New System.Drawing.Size(239, 20)
        Me.txtSelectedGrp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSelectedGrp.Enabled = False
        Me.txtSelectedGrp.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSelectedGrp.Location = New System.Drawing.Point(9, 29)
        Me.txtSelectedGrp.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtSelectedGrp.Name = "txtSelectedGrp"
        Me.txtSelectedGrp.Size = New System.Drawing.Size(149, 20)
        Me.txtSelectedGrp.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtSelectedGrp.TabIndex = 16
        Me.txtSelectedGrp.Text = "selected group"
        Me.txtSelectedGrp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdDeleteGroup)
        Me.GroupBox1.Controls.Add(Me.cmdAddNewGroup)
        Me.GroupBox1.Controls.Add(Me.txtNewGrp)
        Me.GroupBox1.Controls.Add(Me.cboGroups)
        Me.GroupBox1.Location = New System.Drawing.Point(274, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(315, 122)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'cmdDeleteGroup
        '
        Me.cmdDeleteGroup.BeforeTouchSize = New System.Drawing.Size(94, 47)
        Me.cmdDeleteGroup.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDeleteGroup.IsBackStageButton = False
        Me.cmdDeleteGroup.Location = New System.Drawing.Point(207, 66)
        Me.cmdDeleteGroup.Name = "cmdDeleteGroup"
        Me.cmdDeleteGroup.Size = New System.Drawing.Size(94, 47)
        Me.cmdDeleteGroup.TabIndex = 15
        Me.cmdDeleteGroup.Text = "Delete Group"
        '
        'ComboBoxAdv1
        '
        Me.ComboBoxAdv1.BeforeTouchSize = New System.Drawing.Size(218, 21)
        Me.ComboBoxAdv1.DisplayMember = "BatchReportConfigGroups.BRCGroupName"
        Me.ComboBoxAdv1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxAdv1.Location = New System.Drawing.Point(12, 71)
        Me.ComboBoxAdv1.Name = "ComboBoxAdv1"
        Me.ComboBoxAdv1.Size = New System.Drawing.Size(218, 21)
        Me.ComboBoxAdv1.TabIndex = 5
        Me.ComboBoxAdv1.ValueMember = "BatchReportConfigGroups.BRCGroupID"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtSelectedGrp)
        Me.GroupBox2.Controls.Add(Me.cmdRemoveTag)
        Me.GroupBox2.Controls.Add(Me.cmdAddTagToGroup)
        Me.GroupBox2.Controls.Add(Me.cboTags)
        Me.GroupBox2.Location = New System.Drawing.Point(274, 211)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(315, 140)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        '
        'cmdClose
        '
        Me.cmdClose.BeforeTouchSize = New System.Drawing.Size(315, 47)
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.IsBackStageButton = False
        Me.cmdClose.Location = New System.Drawing.Point(274, 529)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(315, 47)
        Me.cmdClose.TabIndex = 19
        Me.cmdClose.Text = "Exit Configuration"
        '
        'cboSelectConfig
        '
        Me.cboSelectConfig.BeforeTouchSize = New System.Drawing.Size(252, 21)
        Me.cboSelectConfig.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSelectConfig.Location = New System.Drawing.Point(254, 12)
        Me.cboSelectConfig.Name = "cboSelectConfig"
        Me.cboSelectConfig.Size = New System.Drawing.Size(252, 21)
        Me.cboSelectConfig.TabIndex = 20
        '
        'TextBoxExt1
        '
        Me.TextBoxExt1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxExt1.BeforeTouchSize = New System.Drawing.Size(239, 20)
        Me.TextBoxExt1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxExt1.Enabled = False
        Me.TextBoxExt1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxExt1.Location = New System.Drawing.Point(4, 13)
        Me.TextBoxExt1.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.TextBoxExt1.Name = "TextBoxExt1"
        Me.TextBoxExt1.Size = New System.Drawing.Size(239, 20)
        Me.TextBoxExt1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.TextBoxExt1.TabIndex = 21
        Me.TextBoxExt1.Text = "Select Report Configuration"
        Me.TextBoxExt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'taBatchReportConfigTableAdapter
        '
        Me.taBatchReportConfigTableAdapter.ClearBeforeFill = True
        '
        'cmdAddConfig
        '
        Me.cmdAddConfig.BeforeTouchSize = New System.Drawing.Size(29, 29)
        Me.cmdAddConfig.Image = Global.BDR.My.Resources.Resources.AddRecord16x16
        Me.cmdAddConfig.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdAddConfig.IsBackStageButton = False
        Me.cmdAddConfig.Location = New System.Drawing.Point(512, 7)
        Me.cmdAddConfig.Name = "cmdAddConfig"
        Me.cmdAddConfig.Size = New System.Drawing.Size(29, 29)
        Me.cmdAddConfig.TabIndex = 23
        '
        'cmdDeleteConfig
        '
        Me.cmdDeleteConfig.BeforeTouchSize = New System.Drawing.Size(26, 29)
        Me.cmdDeleteConfig.Image = Global.BDR.My.Resources.Resources.DeleteRecord16x16
        Me.cmdDeleteConfig.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdDeleteConfig.IsBackStageButton = False
        Me.cmdDeleteConfig.Location = New System.Drawing.Point(547, 7)
        Me.cmdDeleteConfig.Name = "cmdDeleteConfig"
        Me.cmdDeleteConfig.Size = New System.Drawing.Size(26, 29)
        Me.cmdDeleteConfig.TabIndex = 24
        '
        'cmdActive
        '
        Me.cmdActive.BeforeTouchSize = New System.Drawing.Size(191, 29)
        Me.cmdActive.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdActive.ForeColor = System.Drawing.Color.DarkGreen
        Me.cmdActive.IsBackStageButton = False
        Me.cmdActive.Location = New System.Drawing.Point(206, 40)
        Me.cmdActive.Name = "cmdActive"
        Me.cmdActive.Size = New System.Drawing.Size(191, 29)
        Me.cmdActive.TabIndex = 25
        Me.cmdActive.Text = "Active"
        '
        'frmReportConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 588)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdActive)
        Me.Controls.Add(Me.cmdDeleteConfig)
        Me.Controls.Add(Me.cmdAddConfig)
        Me.Controls.Add(Me.TextBoxExt1)
        Me.Controls.Add(Me.cboSelectConfig)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grdRC)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReportConfig"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "REPORT CONFIGURATION"
        Me.TopMost = True
        CType(Me.TblReportTagGroupsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTags, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BPESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGroups, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdRC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BPESDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNewGrp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSelectedGrp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ComboBoxAdv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.cboSelectConfig, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBoxExt1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BPESDataSet As BPESDataSet
    Friend WithEvents TblReportTagGroupsTableAdapter As BPESDataSetTableAdapters.tblReportTagGroupsTableAdapter
    Friend WithEvents BatchReportConfigTagsTableAdapter As BPESDataSetTableAdapters.BatchReportConfigTagsTableAdapter
    Friend WithEvents BatchReportConfigGroupsTableAdapter As BPESDataSetTableAdapters.BatchReportConfigGroupsTableAdapter
    Friend WithEvents TagTableTableAdapter As BPESDataSetTableAdapters.TagTableTableAdapter
    Friend WithEvents BPESDataSetBindingSource As BindingSource
    Friend WithEvents TblReportTagGroupsBindingSource As BindingSource
    Friend WithEvents grdRC As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
    Friend WithEvents cboGroups As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
    Friend WithEvents cboTags As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
    Friend WithEvents cmdAddTagToGroup As Syncfusion.Windows.Forms.ButtonAdv
    Friend WithEvents txtNewGrp As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents cmdAddNewGroup As Syncfusion.Windows.Forms.ButtonAdv
    Friend WithEvents cmdRemoveTag As Syncfusion.Windows.Forms.ButtonAdv
    Friend WithEvents txtSelectedGrp As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBoxAdv1 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
    Friend WithEvents cmdDeleteGroup As Syncfusion.Windows.Forms.ButtonAdv
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmdClose As Syncfusion.Windows.Forms.ButtonAdv
    Friend WithEvents cboSelectConfig As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
    Friend WithEvents TextBoxExt1 As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents taBatchReportConfigTableAdapter As BPESDataSetTableAdapters.BatchReportConfigTableAdapter
    Friend WithEvents cmdAddConfig As Syncfusion.Windows.Forms.ButtonAdv
    Friend WithEvents cmdDeleteConfig As Syncfusion.Windows.Forms.ButtonAdv
    Friend WithEvents cmdActive As Syncfusion.Windows.Forms.ButtonAdv
End Class
