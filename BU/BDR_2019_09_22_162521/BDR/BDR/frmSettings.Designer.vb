<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtDatabase = New System.Windows.Forms.TextBox()
        Me.txtSqlServer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnUpdateCn = New System.Windows.Forms.Button()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBatchReportPath = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAEReportPath = New System.Windows.Forms.TextBox()
        Me.chkAutoRptOn = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmdUpdateAutoReport = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDatabase
        '
        Me.txtDatabase.Location = New System.Drawing.Point(71, 40)
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.Size = New System.Drawing.Size(331, 20)
        Me.txtDatabase.TabIndex = 0
        '
        'txtSqlServer
        '
        Me.txtSqlServer.Location = New System.Drawing.Point(71, 14)
        Me.txtSqlServer.Name = "txtSqlServer"
        Me.txtSqlServer.Size = New System.Drawing.Size(331, 20)
        Me.txtSqlServer.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Database"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Sql Server"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnUpdateCn)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtSqlServer)
        Me.Panel1.Controls.Add(Me.txtDatabase)
        Me.Panel1.Location = New System.Drawing.Point(7, 11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(479, 71)
        Me.Panel1.TabIndex = 5
        '
        'btnUpdateCn
        '
        Me.btnUpdateCn.Location = New System.Drawing.Point(410, 13)
        Me.btnUpdateCn.Name = "btnUpdateCn"
        Me.btnUpdateCn.Size = New System.Drawing.Size(67, 46)
        Me.btnUpdateCn.TabIndex = 5
        Me.btnUpdateCn.Text = "Update"
        Me.btnUpdateCn.UseVisualStyleBackColor = True
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Location = New System.Drawing.Point(4, 255)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(42, 13)
        Me.lblVersion.TabIndex = 6
        Me.lblVersion.Text = "Version"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Location = New System.Drawing.Point(16, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Batch Path"
        Me.Label4.Visible = False
        '
        'txtBatchReportPath
        '
        Me.txtBatchReportPath.Location = New System.Drawing.Point(78, 122)
        Me.txtBatchReportPath.Name = "txtBatchReportPath"
        Me.txtBatchReportPath.Size = New System.Drawing.Size(331, 20)
        Me.txtBatchReportPath.TabIndex = 6
        Me.txtBatchReportPath.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.Location = New System.Drawing.Point(16, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "A && E Path"
        Me.Label5.Visible = False
        '
        'txtAEReportPath
        '
        Me.txtAEReportPath.Location = New System.Drawing.Point(78, 148)
        Me.txtAEReportPath.Name = "txtAEReportPath"
        Me.txtAEReportPath.Size = New System.Drawing.Size(331, 20)
        Me.txtAEReportPath.TabIndex = 8
        Me.txtAEReportPath.Visible = False
        '
        'chkAutoRptOn
        '
        Me.chkAutoRptOn.AutoSize = True
        Me.chkAutoRptOn.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.chkAutoRptOn.Location = New System.Drawing.Point(78, 99)
        Me.chkAutoRptOn.Name = "chkAutoRptOn"
        Me.chkAutoRptOn.Size = New System.Drawing.Size(100, 17)
        Me.chkAutoRptOn.TabIndex = 10
        Me.chkAutoRptOn.Text = "Auto Report On"
        Me.chkAutoRptOn.UseVisualStyleBackColor = False
        Me.chkAutoRptOn.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.cmdUpdateAutoReport)
        Me.Panel2.Location = New System.Drawing.Point(7, 93)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(479, 86)
        Me.Panel2.TabIndex = 11
        Me.Panel2.Visible = False
        '
        'cmdUpdateAutoReport
        '
        Me.cmdUpdateAutoReport.Location = New System.Drawing.Point(410, 19)
        Me.cmdUpdateAutoReport.Name = "cmdUpdateAutoReport"
        Me.cmdUpdateAutoReport.Size = New System.Drawing.Size(67, 46)
        Me.cmdUpdateAutoReport.TabIndex = 5
        Me.cmdUpdateAutoReport.Text = "Update"
        Me.cmdUpdateAutoReport.UseVisualStyleBackColor = True
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 277)
        Me.Controls.Add(Me.chkAutoRptOn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAEReportPath)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.txtBatchReportPath)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmSettings"
        Me.Text = "SETTINGS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDatabase As TextBox
    Friend WithEvents txtSqlServer As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnUpdateCn As Button
    Friend WithEvents lblVersion As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBatchReportPath As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAEReportPath As TextBox
    Friend WithEvents chkAutoRptOn As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmdUpdateAutoReport As Button
End Class
