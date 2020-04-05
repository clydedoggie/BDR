<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim GridBaseStyle1 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
        Dim GridBaseStyle2 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
        Dim GridBaseStyle3 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
        Dim GridBaseStyle4 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
        Dim GridStyleInfo1 As Syncfusion.Windows.Forms.Grid.GridStyleInfo = New Syncfusion.Windows.Forms.Grid.GridStyleInfo()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.grdBatchSelection = New Syncfusion.Windows.Forms.Grid.GridDataBoundGrid()
        Me.BPESDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BPESDataSet = New BDR.BPESDataSet()
        Me.colPLCBatchID = New Syncfusion.Windows.Forms.Grid.GridBoundColumn()
        Me.colPLCBatchDescription = New Syncfusion.Windows.Forms.Grid.GridBoundColumn()
        Me.colStartTime = New Syncfusion.Windows.Forms.Grid.GridBoundColumn()
        Me.colEndTime = New Syncfusion.Windows.Forms.Grid.GridBoundColumn()
        Me.colEndState = New Syncfusion.Windows.Forms.Grid.GridBoundColumn()
        Me.colBatchID = New Syncfusion.Windows.Forms.Grid.GridBoundColumn()
        Me.txtBatchID = New System.Windows.Forms.TextBox()
        Me.txtStartTime = New System.Windows.Forms.TextBox()
        Me.txtEndTime = New System.Windows.Forms.TextBox()
        Me.lblBatchID = New System.Windows.Forms.Label()
        Me.lblStartTime = New System.Windows.Forms.Label()
        Me.lblEndTime = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnData = New System.Windows.Forms.Button()
        Me.btnEventReport = New System.Windows.Forms.Button()
        Me.chkEvents = New System.Windows.Forms.CheckBox()
        Me.chkAlarms = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optgrpDataMode = New System.Windows.Forms.Panel()
        Me.optInterpolated = New System.Windows.Forms.RadioButton()
        Me.optActual = New System.Windows.Forms.RadioButton()
        Me.lblPeriod = New System.Windows.Forms.Label()
        Me.txtPeriod = New System.Windows.Forms.TextBox()
        Me.btnTools = New System.Windows.Forms.Button()
        Me.btnBatchRpt = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtActiveConfig = New System.Windows.Forms.TextBox()
        Me.lblReportConfig = New System.Windows.Forms.Label()
        Me.cmdReportConfig = New System.Windows.Forms.Button()
        Me.QryTagTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UspBatchListTableAdapter = New BDR.BPESDataSetTableAdapters.uspBatchListTableAdapter()
        Me.qryTagTableTableAdapter = New BDR.BPESDataSetTableAdapters.qryTagTableTableAdapter()
        CType(Me.grdBatchSelection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BPESDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BPESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.optgrpDataMode.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.QryTagTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdBatchSelection
        '
        Me.grdBatchSelection.AllowDragSelectedCols = True
        Me.grdBatchSelection.AllowResizeToFit = False
        Me.grdBatchSelection.AllowSelection = Syncfusion.Windows.Forms.Grid.GridSelectionFlags.None
        Me.grdBatchSelection.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grdBatchSelection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        GridBaseStyle1.Name = "Column Header"
        GridBaseStyle1.StyleInfo.BaseStyle = "Header"
        GridBaseStyle1.StyleInfo.CellType = "ColumnHeaderCell"
        GridBaseStyle1.StyleInfo.Enabled = False
        GridBaseStyle1.StyleInfo.Font.Bold = True
        GridBaseStyle1.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
        GridBaseStyle2.Name = "Header"
        GridBaseStyle2.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
        GridBaseStyle2.StyleInfo.Borders.Left = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
        GridBaseStyle2.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
        GridBaseStyle2.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
        GridBaseStyle2.StyleInfo.CellType = "Header"
        GridBaseStyle2.StyleInfo.Font.Bold = True
        GridBaseStyle2.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Control)
        GridBaseStyle2.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle
        GridBaseStyle3.Name = "Standard"
        GridBaseStyle3.StyleInfo.CheckBoxOptions.CheckedValue = "True"
        GridBaseStyle3.StyleInfo.CheckBoxOptions.UncheckedValue = "False"
        GridBaseStyle3.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window)
        GridBaseStyle4.Name = "Row Header"
        GridBaseStyle4.StyleInfo.BaseStyle = "Header"
        GridBaseStyle4.StyleInfo.CellType = "RowHeaderCell"
        GridBaseStyle4.StyleInfo.Enabled = True
        GridBaseStyle4.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left
        Me.grdBatchSelection.BaseStylesMap.AddRange(New Syncfusion.Windows.Forms.Grid.GridBaseStyle() {GridBaseStyle1, GridBaseStyle2, GridBaseStyle3, GridBaseStyle4})
        Me.grdBatchSelection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.grdBatchSelection.DataMember = ""
        Me.grdBatchSelection.DataSource = Me.BPESDataSetBindingSource
        Me.grdBatchSelection.EnableAddNew = False
        Me.grdBatchSelection.EnableEdit = False
        Me.grdBatchSelection.EnableRemove = False
        Me.grdBatchSelection.GridBoundColumns.AddRange(New Syncfusion.Windows.Forms.Grid.GridBoundColumn() {Me.colPLCBatchID, Me.colPLCBatchDescription, Me.colStartTime, Me.colEndTime, Me.colEndState, Me.colBatchID})
        Me.grdBatchSelection.ListBoxSelectionMode = System.Windows.Forms.SelectionMode.One
        Me.grdBatchSelection.Location = New System.Drawing.Point(474, 10)
        Me.grdBatchSelection.Margin = New System.Windows.Forms.Padding(0)
        Me.grdBatchSelection.Name = "grdBatchSelection"
        Me.grdBatchSelection.OptimizeInsertRemoveCells = True
        Me.grdBatchSelection.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus
        Me.grdBatchSelection.Size = New System.Drawing.Size(780, 232)
        Me.grdBatchSelection.SmartSizeBox = False
        Me.grdBatchSelection.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick
        Me.grdBatchSelection.TabIndex = 0
        GridStyleInfo1.AutoCompleteInEditMode = Syncfusion.Windows.Forms.Grid.GridComboSelectionOptions.None
        GridStyleInfo1.AutoSize = False
        GridStyleInfo1.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Top
        Me.grdBatchSelection.TableStyle = GridStyleInfo1
        Me.grdBatchSelection.Text = "GridDataBoundGrid1"
        Me.grdBatchSelection.UseListChangedEvent = True
        Me.grdBatchSelection.UseRightToLeftCompatibleTextBox = True
        '
        'BPESDataSetBindingSource
        '
        Me.BPESDataSetBindingSource.DataMember = "uspBatchList"
        Me.BPESDataSetBindingSource.DataSource = Me.BPESDataSet
        '
        'BPESDataSet
        '
        Me.BPESDataSet.DataSetName = "BPESDataSet"
        Me.BPESDataSet.EnforceConstraints = False
        Me.BPESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'colPLCBatchID
        '
        Me.colPLCBatchID.HeaderText = "Batch ID"
        Me.colPLCBatchID.Hidden = False
        Me.colPLCBatchID.MappingName = "PLCBatchID"
        Me.colPLCBatchID.Position = 1
        Me.colPLCBatchID.ReadOnly = True
        Me.colPLCBatchID.StyleInfo.AutoCompleteInEditMode = Syncfusion.Windows.Forms.Grid.GridComboSelectionOptions.None
        Me.colPLCBatchID.StyleInfo.AutoSize = False
        Me.colPLCBatchID.StyleInfo.CellValueType = GetType(Date)
        Me.colPLCBatchID.Width = -1
        '
        'colPLCBatchDescription
        '
        Me.colPLCBatchDescription.HeaderText = "Batch Description"
        Me.colPLCBatchDescription.Hidden = False
        Me.colPLCBatchDescription.MappingName = "PLCBatchDescription"
        Me.colPLCBatchDescription.Position = 2
        Me.colPLCBatchDescription.ReadOnly = True
        Me.colPLCBatchDescription.StyleInfo.CellValueType = GetType(String)
        Me.colPLCBatchDescription.Width = -1
        '
        'colStartTime
        '
        Me.colStartTime.HeaderText = "Batch Start"
        Me.colStartTime.Hidden = False
        Me.colStartTime.MappingName = "StartTime"
        Me.colStartTime.Position = 3
        Me.colStartTime.ReadOnly = True
        Me.colStartTime.StyleInfo.AutoCompleteInEditMode = Syncfusion.Windows.Forms.Grid.GridComboSelectionOptions.None
        Me.colStartTime.StyleInfo.AutoSize = False
        Me.colStartTime.StyleInfo.CellAppearance = Syncfusion.Windows.Forms.Grid.GridCellAppearance.Flat
        Me.colStartTime.StyleInfo.CellValueType = GetType(Date)
        Me.colStartTime.StyleInfo.Format = ""
        Me.colStartTime.Width = -1
        '
        'colEndTime
        '
        Me.colEndTime.HeaderText = "Batch End"
        Me.colEndTime.Hidden = False
        Me.colEndTime.MappingName = "EndTime"
        Me.colEndTime.Position = 4
        Me.colEndTime.ReadOnly = True
        Me.colEndTime.StyleInfo.AutoCompleteInEditMode = Syncfusion.Windows.Forms.Grid.GridComboSelectionOptions.None
        Me.colEndTime.StyleInfo.AutoSize = False
        Me.colEndTime.StyleInfo.CellValueType = GetType(Date)
        Me.colEndTime.StyleInfo.Format = ""
        Me.colEndTime.Width = -1
        '
        'colEndState
        '
        Me.colEndState.HeaderText = "Batch State"
        Me.colEndState.Hidden = False
        Me.colEndState.MappingName = "EndState"
        Me.colEndState.Position = 5
        Me.colEndState.ReadOnly = True
        Me.colEndState.StyleInfo.CellValueType = GetType(String)
        Me.colEndState.Width = -1
        '
        'colBatchID
        '
        Me.colBatchID.Hidden = True
        Me.colBatchID.MappingName = "BatchID"
        Me.colBatchID.Position = 6
        Me.colBatchID.StyleInfo.CellValueType = GetType(Integer)
        Me.colBatchID.StyleInfo.Format = "G"
        Me.colBatchID.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Right
        Me.colBatchID.StyleInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.colBatchID.Width = -1
        '
        'txtBatchID
        '
        Me.txtBatchID.Enabled = False
        Me.txtBatchID.Location = New System.Drawing.Point(117, 8)
        Me.txtBatchID.Name = "txtBatchID"
        Me.txtBatchID.Size = New System.Drawing.Size(328, 24)
        Me.txtBatchID.TabIndex = 1
        '
        'txtStartTime
        '
        Me.txtStartTime.Location = New System.Drawing.Point(117, 35)
        Me.txtStartTime.Name = "txtStartTime"
        Me.txtStartTime.Size = New System.Drawing.Size(134, 24)
        Me.txtStartTime.TabIndex = 2
        Me.txtStartTime.WordWrap = False
        '
        'txtEndTime
        '
        Me.txtEndTime.Location = New System.Drawing.Point(300, 38)
        Me.txtEndTime.Name = "txtEndTime"
        Me.txtEndTime.Size = New System.Drawing.Size(134, 24)
        Me.txtEndTime.TabIndex = 3
        Me.txtEndTime.WordWrap = False
        '
        'lblBatchID
        '
        Me.lblBatchID.AutoSize = True
        Me.lblBatchID.Location = New System.Drawing.Point(50, 12)
        Me.lblBatchID.Name = "lblBatchID"
        Me.lblBatchID.Size = New System.Drawing.Size(61, 17)
        Me.lblBatchID.TabIndex = 4
        Me.lblBatchID.Text = "Batch ID"
        '
        'lblStartTime
        '
        Me.lblStartTime.AutoSize = True
        Me.lblStartTime.Location = New System.Drawing.Point(75, 43)
        Me.lblStartTime.Name = "lblStartTime"
        Me.lblStartTime.Size = New System.Drawing.Size(38, 17)
        Me.lblStartTime.TabIndex = 5
        Me.lblStartTime.Text = "Start"
        '
        'lblEndTime
        '
        Me.lblEndTime.AutoSize = True
        Me.lblEndTime.Location = New System.Drawing.Point(265, 43)
        Me.lblEndTime.Name = "lblEndTime"
        Me.lblEndTime.Size = New System.Drawing.Size(32, 17)
        Me.lblEndTime.TabIndex = 6
        Me.lblEndTime.Text = "End"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(1255, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(24, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "X"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnData
        '
        Me.btnData.Location = New System.Drawing.Point(212, 17)
        Me.btnData.Name = "btnData"
        Me.btnData.Size = New System.Drawing.Size(108, 38)
        Me.btnData.TabIndex = 11
        Me.btnData.Text = "Analog Data"
        Me.btnData.UseVisualStyleBackColor = True
        '
        'btnEventReport
        '
        Me.btnEventReport.Location = New System.Drawing.Point(212, 16)
        Me.btnEventReport.Name = "btnEventReport"
        Me.btnEventReport.Size = New System.Drawing.Size(108, 38)
        Me.btnEventReport.TabIndex = 8
        Me.btnEventReport.Text = "Event Report"
        Me.btnEventReport.UseVisualStyleBackColor = True
        '
        'chkEvents
        '
        Me.chkEvents.AutoSize = True
        Me.chkEvents.Checked = True
        Me.chkEvents.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEvents.Location = New System.Drawing.Point(6, 26)
        Me.chkEvents.Name = "chkEvents"
        Me.chkEvents.Size = New System.Drawing.Size(69, 21)
        Me.chkEvents.TabIndex = 9
        Me.chkEvents.Text = "Events"
        Me.chkEvents.UseVisualStyleBackColor = True
        '
        'chkAlarms
        '
        Me.chkAlarms.AutoSize = True
        Me.chkAlarms.Checked = True
        Me.chkAlarms.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAlarms.Location = New System.Drawing.Point(94, 26)
        Me.chkAlarms.Name = "chkAlarms"
        Me.chkAlarms.Size = New System.Drawing.Size(67, 21)
        Me.chkAlarms.TabIndex = 10
        Me.chkAlarms.Text = "Alarms"
        Me.chkAlarms.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkAlarms)
        Me.GroupBox1.Controls.Add(Me.chkEvents)
        Me.GroupBox1.Controls.Add(Me.btnEventReport)
        Me.GroupBox1.Location = New System.Drawing.Point(117, 117)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(328, 62)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optgrpDataMode)
        Me.GroupBox2.Controls.Add(Me.lblPeriod)
        Me.GroupBox2.Controls.Add(Me.txtPeriod)
        Me.GroupBox2.Controls.Add(Me.btnData)
        Me.GroupBox2.Location = New System.Drawing.Point(117, 177)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(328, 62)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        '
        'optgrpDataMode
        '
        Me.optgrpDataMode.Controls.Add(Me.optInterpolated)
        Me.optgrpDataMode.Controls.Add(Me.optActual)
        Me.optgrpDataMode.Location = New System.Drawing.Point(6, 11)
        Me.optgrpDataMode.Name = "optgrpDataMode"
        Me.optgrpDataMode.Size = New System.Drawing.Size(109, 45)
        Me.optgrpDataMode.TabIndex = 12
        '
        'optInterpolated
        '
        Me.optInterpolated.AutoSize = True
        Me.optInterpolated.Checked = True
        Me.optInterpolated.Location = New System.Drawing.Point(7, 22)
        Me.optInterpolated.Name = "optInterpolated"
        Me.optInterpolated.Size = New System.Drawing.Size(100, 21)
        Me.optInterpolated.TabIndex = 1
        Me.optInterpolated.TabStop = True
        Me.optInterpolated.Text = "Interpolated"
        Me.optInterpolated.UseVisualStyleBackColor = True
        '
        'optActual
        '
        Me.optActual.AutoSize = True
        Me.optActual.Location = New System.Drawing.Point(7, 4)
        Me.optActual.Name = "optActual"
        Me.optActual.Size = New System.Drawing.Size(63, 21)
        Me.optActual.TabIndex = 0
        Me.optActual.Text = "Actual"
        Me.optActual.UseVisualStyleBackColor = True
        '
        'lblPeriod
        '
        Me.lblPeriod.AutoSize = True
        Me.lblPeriod.Location = New System.Drawing.Point(121, 11)
        Me.lblPeriod.Name = "lblPeriod"
        Me.lblPeriod.Size = New System.Drawing.Size(80, 17)
        Me.lblPeriod.TabIndex = 1
        Me.lblPeriod.Text = "Period (sec)"
        '
        'txtPeriod
        '
        Me.txtPeriod.Location = New System.Drawing.Point(137, 31)
        Me.txtPeriod.Name = "txtPeriod"
        Me.txtPeriod.Size = New System.Drawing.Size(47, 24)
        Me.txtPeriod.TabIndex = 0
        Me.txtPeriod.Text = "60"
        Me.txtPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnTools
        '
        Me.btnTools.Image = CType(resources.GetObject("btnTools.Image"), System.Drawing.Image)
        Me.btnTools.Location = New System.Drawing.Point(9, 2)
        Me.btnTools.Name = "btnTools"
        Me.btnTools.Size = New System.Drawing.Size(33, 34)
        Me.btnTools.TabIndex = 14
        Me.btnTools.UseVisualStyleBackColor = True
        '
        'btnBatchRpt
        '
        Me.btnBatchRpt.Location = New System.Drawing.Point(212, 13)
        Me.btnBatchRpt.Name = "btnBatchRpt"
        Me.btnBatchRpt.Size = New System.Drawing.Size(108, 38)
        Me.btnBatchRpt.TabIndex = 15
        Me.btnBatchRpt.Text = "Batch Report"
        Me.btnBatchRpt.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtActiveConfig)
        Me.GroupBox3.Controls.Add(Me.lblReportConfig)
        Me.GroupBox3.Controls.Add(Me.btnBatchRpt)
        Me.GroupBox3.Controls.Add(Me.cmdReportConfig)
        Me.GroupBox3.Location = New System.Drawing.Point(117, 62)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(328, 58)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        '
        'txtActiveConfig
        '
        Me.txtActiveConfig.BackColor = System.Drawing.SystemColors.Control
        Me.txtActiveConfig.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtActiveConfig.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtActiveConfig.ForeColor = System.Drawing.Color.Blue
        Me.txtActiveConfig.Location = New System.Drawing.Point(9, 35)
        Me.txtActiveConfig.Name = "txtActiveConfig"
        Me.txtActiveConfig.Size = New System.Drawing.Size(152, 16)
        Me.txtActiveConfig.TabIndex = 19
        Me.txtActiveConfig.TabStop = False
        Me.txtActiveConfig.Text = "Active Config"
        Me.txtActiveConfig.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtActiveConfig.WordWrap = False
        '
        'lblReportConfig
        '
        Me.lblReportConfig.AutoSize = True
        Me.lblReportConfig.Location = New System.Drawing.Point(14, 14)
        Me.lblReportConfig.Name = "lblReportConfig"
        Me.lblReportConfig.Size = New System.Drawing.Size(136, 17)
        Me.lblReportConfig.TabIndex = 18
        Me.lblReportConfig.Text = "Report Configuration"
        '
        'cmdReportConfig
        '
        Me.cmdReportConfig.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReportConfig.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdReportConfig.Location = New System.Drawing.Point(167, 14)
        Me.cmdReportConfig.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.cmdReportConfig.Name = "cmdReportConfig"
        Me.cmdReportConfig.Size = New System.Drawing.Size(40, 37)
        Me.cmdReportConfig.TabIndex = 17
        Me.cmdReportConfig.Text = "..."
        Me.cmdReportConfig.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdReportConfig.UseVisualStyleBackColor = True
        '
        'QryTagTableBindingSource
        '
        Me.QryTagTableBindingSource.DataMember = "qryTagTable"
        Me.QryTagTableBindingSource.DataSource = Me.BPESDataSet
        '
        'UspBatchListTableAdapter
        '
        Me.UspBatchListTableAdapter.ClearBeforeFill = True
        '
        'qryTagTableTableAdapter
        '
        Me.qryTagTableTableAdapter.ClearBeforeFill = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1280, 250)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnTools)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblEndTime)
        Me.Controls.Add(Me.lblStartTime)
        Me.Controls.Add(Me.lblBatchID)
        Me.Controls.Add(Me.txtEndTime)
        Me.Controls.Add(Me.txtStartTime)
        Me.Controls.Add(Me.txtBatchID)
        Me.Controls.Add(Me.grdBatchSelection)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(0, 640)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "BATCH SELECTOR"
        Me.TopMost = True
        CType(Me.grdBatchSelection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BPESDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BPESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.optgrpDataMode.ResumeLayout(False)
        Me.optgrpDataMode.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.QryTagTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdBatchSelection As Syncfusion.Windows.Forms.Grid.GridDataBoundGrid
    Friend WithEvents BPESDataSet As BPESDataSet
    Friend WithEvents BPESDataSetBindingSource As BindingSource
    Friend WithEvents UspBatchListTableAdapter As BPESDataSetTableAdapters.uspBatchListTableAdapter
    Friend WithEvents colPLCBatchID As Syncfusion.Windows.Forms.Grid.GridBoundColumn
    Friend WithEvents colPLCBatchDescription As Syncfusion.Windows.Forms.Grid.GridBoundColumn
    Friend WithEvents colStartTime As Syncfusion.Windows.Forms.Grid.GridBoundColumn
    Friend WithEvents colEndTime As Syncfusion.Windows.Forms.Grid.GridBoundColumn
    Friend WithEvents colEndState As Syncfusion.Windows.Forms.Grid.GridBoundColumn
    Friend WithEvents txtBatchID As TextBox
    Friend WithEvents txtStartTime As TextBox
    Friend WithEvents txtEndTime As TextBox
    Friend WithEvents lblBatchID As Label
    Friend WithEvents lblStartTime As Label
    Friend WithEvents lblEndTime As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnData As Button
    Friend WithEvents btnEventReport As Button
    Friend WithEvents chkEvents As CheckBox
    Friend WithEvents chkAlarms As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblPeriod As Label
    Friend WithEvents txtPeriod As TextBox
    Friend WithEvents btnTools As Button
    Friend WithEvents btnBatchRpt As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents QryTagTableBindingSource As BindingSource
    Friend WithEvents qryTagTableTableAdapter As BPESDataSetTableAdapters.qryTagTableTableAdapter
    Friend WithEvents colBatchID As Syncfusion.Windows.Forms.Grid.GridBoundColumn
    Friend WithEvents cmdReportConfig As Button
    Friend WithEvents optgrpDataMode As Panel
    Friend WithEvents optActual As RadioButton
    Friend WithEvents optInterpolated As RadioButton
    Friend WithEvents txtActiveConfig As TextBox
    Friend WithEvents lblReportConfig As Label
End Class
