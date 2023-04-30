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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.vwConditionEventBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BPESDataSet = New BDR.BPESDataSet()
        Me.rvEvents = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.vwConditionEventTableAdapter = New BDR.BPESDataSetTableAdapters.vwEventsWithPhAndRecTableAdapter()
        Me.UspBatchAnalogDataByGroupTableAdapter = New BDR.BPESDataSetTableAdapters.uspBatchAnalogDataByGroupTableAdapter()
        Me.UspBAD_ByGroupTableAdapterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UspBatchWithPhasesTableAdapter = New BDR.BPESDataSetTableAdapters.uspBatchWithPhasesTableAdapter()
        Me.uspBatchWithPhasesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.vwConditionEventBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BPESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UspBAD_ByGroupTableAdapterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uspBatchWithPhasesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'rvEvents
        '
        ReportDataSource1.Name = "dsEvents"
        ReportDataSource1.Value = Me.vwConditionEventBindingSource
        Me.rvEvents.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rvEvents.LocalReport.ReportEmbeddedResource = "BDR.rptMain.rdlc"
        Me.rvEvents.Location = New System.Drawing.Point(47, 52)
        Me.rvEvents.Name = "rvEvents"
        Me.rvEvents.ServerReport.BearerToken = Nothing
        Me.rvEvents.Size = New System.Drawing.Size(941, 536)
        Me.rvEvents.TabIndex = 0
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
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1049, 600)
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rvEvents As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents vwConditionEventBindingSource As BindingSource
    Friend WithEvents BPESDataSet As BPESDataSet
    Friend WithEvents vwConditionEventTableAdapter As BPESDataSetTableAdapters.vwEventsWithPhAndRecTableAdapter
    Friend WithEvents UspBatchAnalogDataByGroupTableAdapter As BPESDataSetTableAdapters.uspBatchAnalogDataByGroupTableAdapter
    Friend WithEvents UspBAD_ByGroupTableAdapterBindingSource As BindingSource
    Friend WithEvents UspBatchWithPhasesTableAdapter As BPESDataSetTableAdapters.uspBatchWithPhasesTableAdapter
    Friend WithEvents uspBatchWithPhasesBindingSource As BindingSource
End Class
