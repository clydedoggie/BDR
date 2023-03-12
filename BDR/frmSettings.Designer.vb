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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.chkAutoRptOn = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAEReportPath = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBatchReportPath = New System.Windows.Forms.TextBox()
        Me.cmdUpdateAutoReport = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chk24Hr = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnUpdateOptions = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDatabase
        '
        Me.txtDatabase.Location = New System.Drawing.Point(71, 56)
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.Size = New System.Drawing.Size(331, 20)
        Me.txtDatabase.TabIndex = 0
        '
        'txtSqlServer
        '
        Me.txtSqlServer.Location = New System.Drawing.Point(71, 30)
        Me.txtSqlServer.Name = "txtSqlServer"
        Me.txtSqlServer.Size = New System.Drawing.Size(331, 20)
        Me.txtSqlServer.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Database"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Sql Server"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.btnUpdateCn)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtSqlServer)
        Me.Panel1.Controls.Add(Me.txtDatabase)
        Me.Panel1.Location = New System.Drawing.Point(7, 11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(479, 86)
        Me.Panel1.TabIndex = 5
        '
        'btnUpdateCn
        '
        Me.btnUpdateCn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateCn.Location = New System.Drawing.Point(410, 29)
        Me.btnUpdateCn.Name = "btnUpdateCn"
        Me.btnUpdateCn.Size = New System.Drawing.Size(67, 46)
        Me.btnUpdateCn.TabIndex = 5
        Me.btnUpdateCn.Text = "Update"
        Me.btnUpdateCn.UseVisualStyleBackColor = True
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(4, 332)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(42, 13)
        Me.lblVersion.TabIndex = 6
        Me.lblVersion.Text = "Version"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.chkAutoRptOn)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtAEReportPath)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtBatchReportPath)
        Me.Panel2.Controls.Add(Me.cmdUpdateAutoReport)
        Me.Panel2.Location = New System.Drawing.Point(7, 118)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(479, 86)
        Me.Panel2.TabIndex = 11
        '
        'chkAutoRptOn
        '
        Me.chkAutoRptOn.AutoSize = True
        Me.chkAutoRptOn.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.chkAutoRptOn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAutoRptOn.Location = New System.Drawing.Point(212, 5)
        Me.chkAutoRptOn.Name = "chkAutoRptOn"
        Me.chkAutoRptOn.Size = New System.Drawing.Size(64, 17)
        Me.chkAutoRptOn.TabIndex = 15
        Me.chkAutoRptOn.Text = "Enabled"
        Me.chkAutoRptOn.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "A && E Path"
        '
        'txtAEReportPath
        '
        Me.txtAEReportPath.Location = New System.Drawing.Point(71, 59)
        Me.txtAEReportPath.Name = "txtAEReportPath"
        Me.txtAEReportPath.Size = New System.Drawing.Size(331, 20)
        Me.txtAEReportPath.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Batch Path"
        '
        'txtBatchReportPath
        '
        Me.txtBatchReportPath.Location = New System.Drawing.Point(71, 33)
        Me.txtBatchReportPath.Name = "txtBatchReportPath"
        Me.txtBatchReportPath.Size = New System.Drawing.Size(331, 20)
        Me.txtBatchReportPath.TabIndex = 11
        '
        'cmdUpdateAutoReport
        '
        Me.cmdUpdateAutoReport.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdateAutoReport.Location = New System.Drawing.Point(410, 33)
        Me.cmdUpdateAutoReport.Name = "cmdUpdateAutoReport"
        Me.cmdUpdateAutoReport.Size = New System.Drawing.Size(67, 46)
        Me.cmdUpdateAutoReport.TabIndex = 5
        Me.cmdUpdateAutoReport.Text = "Update"
        Me.cmdUpdateAutoReport.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnUpdateOptions)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.chk24Hr)
        Me.Panel3.Location = New System.Drawing.Point(7, 225)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(479, 86)
        Me.Panel3.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Options"
        '
        'chk24Hr
        '
        Me.chk24Hr.AutoSize = True
        Me.chk24Hr.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk24Hr.Location = New System.Drawing.Point(71, 26)
        Me.chk24Hr.Name = "chk24Hr"
        Me.chk24Hr.Size = New System.Drawing.Size(136, 17)
        Me.chk24Hr.TabIndex = 13
        Me.chk24Hr.Text = "Use 24 Hr Date Format"
        Me.chk24Hr.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(203, 16)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Automatic  Report Generation"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 16)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Database"
        '
        'btnUpdateOptions
        '
        Me.btnUpdateOptions.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateOptions.Location = New System.Drawing.Point(410, 37)
        Me.btnUpdateOptions.Name = "btnUpdateOptions"
        Me.btnUpdateOptions.Size = New System.Drawing.Size(67, 46)
        Me.btnUpdateOptions.TabIndex = 15
        Me.btnUpdateOptions.Text = "Update"
        Me.btnUpdateOptions.UseVisualStyleBackColor = True
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 354)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmSettings"
        Me.Text = "SETTINGS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
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
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmdUpdateAutoReport As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents chkAutoRptOn As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAEReportPath As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBatchReportPath As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents chk24Hr As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnUpdateOptions As Button
End Class
