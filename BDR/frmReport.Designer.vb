<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReport
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.rvEvents = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.vwConditionEventBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BPESDataSet = New BDR.BPESDataSet()
        Me.vwConditionEventTableAdapter = New BDR.BPESDataSetTableAdapters.vwEventsWithPhAndRecTableAdapter()
        Me.UspBatchAnalogDataByGroupTableAdapter = New BDR.BPESDataSetTableAdapters.uspBatchAnalogDataByGroupTableAdapter()
        Me.UspBAD_ByGroupTableAdapterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UspBatchWithPhasesTableAdapter = New BDR.BPESDataSetTableAdapters.uspBatchWithPhasesTableAdapter()
        Me.uspBatchWithPhasesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.StartTimeToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.StartTimeToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.EndTimeToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.EndTimeToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        CType(Me.vwConditionEventBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BPESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UspBAD_ByGroupTableAdapterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uspBatchWithPhasesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'rvEvents
        '
        ReportDataSource2.Name = "dsEvents"
        ReportDataSource2.Value = Me.vwConditionEventBindingSource
        Me.rvEvents.LocalReport.DataSources.Add(ReportDataSource2)
        Me.rvEvents.LocalReport.ReportEmbeddedResource = "BDR.rptMain.rdlc"
        Me.rvEvents.Location = New System.Drawing.Point(47, 52)
        Me.rvEvents.Name = "rvEvents"
        Me.rvEvents.ServerReport.BearerToken = Nothing
        Me.rvEvents.Size = New System.Drawing.Size(826, 707)
        Me.rvEvents.TabIndex = 0
        '
        'vwConditionEventBindingSource
        '
        Me.vwConditionEventBindingSource.DataMember = "vwEventsWithPhAndRec"
        Me.vwConditionEventBindingSource.DataSource = Me.BPESDataSet
        '
        'BPESDataSet
        '
        Me.BPESDataSet.DataSetName = "BPESDataSet"
        Me.BPESDataSet.EnforceConstraints = False
        Me.BPESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'vwConditionEventTableAdapter
        '
        Me.vwConditionEventTableAdapter.ClearBeforeFill = True
        '
        'UspBatchAnalogDataByGroupTableAdapter
        '
        Me.UspBatchAnalogDataByGroupTableAdapter.ClearBeforeFill = True
        '
        'UspBAD_ByGroupTableAdapterBindingSource
        '
        Me.UspBAD_ByGroupTableAdapterBindingSource.DataMember = "uspBatchAnalogDataByGroup"
        Me.UspBAD_ByGroupTableAdapterBindingSource.DataSource = Me.BPESDataSet
        '
        'UspBatchWithPhasesTableAdapter
        '
        Me.UspBatchWithPhasesTableAdapter.ClearBeforeFill = True
        '
        'uspBatchWithPhasesBindingSource
        '
        Me.uspBatchWithPhasesBindingSource.DataMember = "uspBatchWithPhases"
        Me.uspBatchWithPhasesBindingSource.DataSource = Me.BPESDataSet
        Me.uspBatchWithPhasesBindingSource.Sort = "PhaseStart"
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartTimeToolStripLabel, Me.StartTimeToolStripTextBox, Me.EndTimeToolStripLabel, Me.EndTimeToolStripTextBox, Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(918, 25)
        Me.FillByToolStrip.TabIndex = 1
        Me.FillByToolStrip.Text = "FillByToolStrip"
        '
        'StartTimeToolStripLabel
        '
        Me.StartTimeToolStripLabel.Name = "StartTimeToolStripLabel"
        Me.StartTimeToolStripLabel.Size = New System.Drawing.Size(60, 22)
        Me.StartTimeToolStripLabel.Text = "StartTime:"
        '
        'StartTimeToolStripTextBox
        '
        Me.StartTimeToolStripTextBox.Name = "StartTimeToolStripTextBox"
        Me.StartTimeToolStripTextBox.Size = New System.Drawing.Size(100, 23)
        '
        'EndTimeToolStripLabel
        '
        Me.EndTimeToolStripLabel.Name = "EndTimeToolStripLabel"
        Me.EndTimeToolStripLabel.Size = New System.Drawing.Size(56, 15)
        Me.EndTimeToolStripLabel.Text = "EndTime:"
        '
        'EndTimeToolStripTextBox
        '
        Me.EndTimeToolStripTextBox.Name = "EndTimeToolStripTextBox"
        Me.EndTimeToolStripTextBox.Size = New System.Drawing.Size(100, 23)
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(39, 19)
        Me.FillByToolStripButton.Text = "FillBy"
        '
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 779)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.rvEvents)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReport"
        Me.Text = "REPORT"
        CType(Me.vwConditionEventBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BPESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UspBAD_ByGroupTableAdapterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uspBatchWithPhasesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rvEvents As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents vwConditionEventBindingSource As BindingSource
    Friend WithEvents BPESDataSet As BPESDataSet
    Friend WithEvents vwConditionEventTableAdapter As BPESDataSetTableAdapters.vwEventsWithPhAndRecTableAdapter
    Friend WithEvents UspBatchAnalogDataByGroupTableAdapter As BPESDataSetTableAdapters.uspBatchAnalogDataByGroupTableAdapter
    Friend WithEvents UspBAD_ByGroupTableAdapterBindingSource As BindingSource
    Friend WithEvents UspBatchWithPhasesTableAdapter As BPESDataSetTableAdapters.uspBatchWithPhasesTableAdapter
    Friend WithEvents uspBatchWithPhasesBindingSource As BindingSource
    Friend WithEvents FillByToolStrip As ToolStrip
    Friend WithEvents StartTimeToolStripLabel As ToolStripLabel
    Friend WithEvents StartTimeToolStripTextBox As ToolStripTextBox
    Friend WithEvents EndTimeToolStripLabel As ToolStripLabel
    Friend WithEvents EndTimeToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillByToolStripButton As ToolStripButton
End Class
