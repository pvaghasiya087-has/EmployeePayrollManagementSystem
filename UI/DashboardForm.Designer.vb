<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardForm
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.lblTotalEmployees = New System.Windows.Forms.Label()
        Me.dgvRecentPayroll = New System.Windows.Forms.DataGridView()
        Me.chartSalary = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblTotalPayroll = New System.Windows.Forms.Label()
        Me.lblHighestPaid = New System.Windows.Forms.Label()
        CType(Me.dgvRecentPayroll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chartSalary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTotalEmployees
        '
        Me.lblTotalEmployees.AutoSize = True
        Me.lblTotalEmployees.Location = New System.Drawing.Point(220, 228)
        Me.lblTotalEmployees.Name = "lblTotalEmployees"
        Me.lblTotalEmployees.Size = New System.Drawing.Size(85, 13)
        Me.lblTotalEmployees.TabIndex = 0
        Me.lblTotalEmployees.Text = "Total Employees"
        '
        'dgvRecentPayroll
        '
        Me.dgvRecentPayroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecentPayroll.Location = New System.Drawing.Point(62, 12)
        Me.dgvRecentPayroll.Name = "dgvRecentPayroll"
        Me.dgvRecentPayroll.Size = New System.Drawing.Size(334, 185)
        Me.dgvRecentPayroll.TabIndex = 1
        '
        'chartSalary
        '
        ChartArea2.Name = "ChartArea1"
        Me.chartSalary.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.chartSalary.Legends.Add(Legend2)
        Me.chartSalary.Location = New System.Drawing.Point(442, 12)
        Me.chartSalary.Name = "chartSalary"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.chartSalary.Series.Add(Series2)
        Me.chartSalary.Size = New System.Drawing.Size(322, 185)
        Me.chartSalary.TabIndex = 2
        Me.chartSalary.Text = "Chart1"
        '
        'lblTotalPayroll
        '
        Me.lblTotalPayroll.AutoSize = True
        Me.lblTotalPayroll.Location = New System.Drawing.Point(220, 259)
        Me.lblTotalPayroll.Name = "lblTotalPayroll"
        Me.lblTotalPayroll.Size = New System.Drawing.Size(38, 13)
        Me.lblTotalPayroll.TabIndex = 3
        Me.lblTotalPayroll.Text = "Payroll"
        '
        'lblHighestPaid
        '
        Me.lblHighestPaid.AutoSize = True
        Me.lblHighestPaid.Location = New System.Drawing.Point(220, 297)
        Me.lblHighestPaid.Name = "lblHighestPaid"
        Me.lblHighestPaid.Size = New System.Drawing.Size(67, 13)
        Me.lblHighestPaid.TabIndex = 4
        Me.lblHighestPaid.Text = "Highest Paid"
        '
        'DashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblHighestPaid)
        Me.Controls.Add(Me.lblTotalPayroll)
        Me.Controls.Add(Me.chartSalary)
        Me.Controls.Add(Me.dgvRecentPayroll)
        Me.Controls.Add(Me.lblTotalEmployees)
        Me.Name = "DashboardForm"
        Me.Text = "DashboardForm"
        CType(Me.dgvRecentPayroll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chartSalary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTotalEmployees As Label
    Friend WithEvents dgvRecentPayroll As DataGridView
    Friend WithEvents chartSalary As DataVisualization.Charting.Chart
    Friend WithEvents lblTotalPayroll As Label
    Friend WithEvents lblHighestPaid As Label
End Class
