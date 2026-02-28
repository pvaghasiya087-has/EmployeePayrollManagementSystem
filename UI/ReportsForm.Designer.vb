<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportsForm
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
        Me.cmbReportEmployee = New System.Windows.Forms.ComboBox()
        Me.btnGenerateReport = New System.Windows.Forms.Button()
        Me.dgvReport = New System.Windows.Forms.DataGridView()
        Me.txtReportYear = New System.Windows.Forms.TextBox()
        Me.cmbReportMonth = New System.Windows.Forms.ComboBox()
        Me.btnExportReport = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbReportEmployee
        '
        Me.cmbReportEmployee.FormattingEnabled = True
        Me.cmbReportEmployee.Location = New System.Drawing.Point(81, 27)
        Me.cmbReportEmployee.Name = "cmbReportEmployee"
        Me.cmbReportEmployee.Size = New System.Drawing.Size(121, 21)
        Me.cmbReportEmployee.TabIndex = 0
        '
        'btnGenerateReport
        '
        Me.btnGenerateReport.Location = New System.Drawing.Point(81, 151)
        Me.btnGenerateReport.Name = "btnGenerateReport"
        Me.btnGenerateReport.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerateReport.TabIndex = 1
        Me.btnGenerateReport.Text = "Generate Report "
        Me.btnGenerateReport.UseVisualStyleBackColor = True
        '
        'dgvReport
        '
        Me.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReport.Location = New System.Drawing.Point(373, 27)
        Me.dgvReport.Name = "dgvReport"
        Me.dgvReport.Size = New System.Drawing.Size(415, 229)
        Me.dgvReport.TabIndex = 2
        '
        'txtReportYear
        '
        Me.txtReportYear.Location = New System.Drawing.Point(81, 106)
        Me.txtReportYear.Name = "txtReportYear"
        Me.txtReportYear.Size = New System.Drawing.Size(100, 20)
        Me.txtReportYear.TabIndex = 3
        '
        'cmbReportMonth
        '
        Me.cmbReportMonth.FormattingEnabled = True
        Me.cmbReportMonth.Location = New System.Drawing.Point(81, 70)
        Me.cmbReportMonth.Name = "cmbReportMonth"
        Me.cmbReportMonth.Size = New System.Drawing.Size(121, 21)
        Me.cmbReportMonth.TabIndex = 4
        '
        'btnExportReport
        '
        Me.btnExportReport.Location = New System.Drawing.Point(81, 191)
        Me.btnExportReport.Name = "btnExportReport"
        Me.btnExportReport.Size = New System.Drawing.Size(75, 23)
        Me.btnExportReport.TabIndex = 5
        Me.btnExportReport.Text = "Export"
        Me.btnExportReport.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Employee"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Month"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Year"
        '
        'ReportsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExportReport)
        Me.Controls.Add(Me.cmbReportMonth)
        Me.Controls.Add(Me.txtReportYear)
        Me.Controls.Add(Me.dgvReport)
        Me.Controls.Add(Me.btnGenerateReport)
        Me.Controls.Add(Me.cmbReportEmployee)
        Me.Name = "ReportsForm"
        Me.Text = "ReportsForm"
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbReportEmployee As ComboBox
    Friend WithEvents btnGenerateReport As Button
    Friend WithEvents dgvReport As DataGridView
    Friend WithEvents txtReportYear As TextBox
    Friend WithEvents cmbReportMonth As ComboBox
    Friend WithEvents btnExportReport As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
