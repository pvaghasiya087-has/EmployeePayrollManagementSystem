<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PayrollForm
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
        Me.cmbEmployee = New System.Windows.Forms.ComboBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.dgvPayroll = New System.Windows.Forms.DataGridView()
        Me.cmbMonth = New System.Windows.Forms.ComboBox()
        Me.txtAllowance = New System.Windows.Forms.TextBox()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnExportExcel = New System.Windows.Forms.Button()
        Me.btnPrintPayslip = New System.Windows.Forms.Button()
        CType(Me.dgvPayroll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbEmployee
        '
        Me.cmbEmployee.FormattingEnabled = True
        Me.cmbEmployee.Location = New System.Drawing.Point(87, 12)
        Me.cmbEmployee.Name = "cmbEmployee"
        Me.cmbEmployee.Size = New System.Drawing.Size(121, 21)
        Me.cmbEmployee.TabIndex = 0
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(87, 88)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(100, 20)
        Me.txtYear.TabIndex = 1
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(101, 246)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerate.TabIndex = 2
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'dgvPayroll
        '
        Me.dgvPayroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPayroll.Location = New System.Drawing.Point(419, 22)
        Me.dgvPayroll.Name = "dgvPayroll"
        Me.dgvPayroll.Size = New System.Drawing.Size(349, 197)
        Me.dgvPayroll.TabIndex = 3
        '
        'cmbMonth
        '
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.Location = New System.Drawing.Point(87, 50)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(121, 21)
        Me.cmbMonth.TabIndex = 4
        '
        'txtAllowance
        '
        Me.txtAllowance.Location = New System.Drawing.Point(87, 125)
        Me.txtAllowance.Name = "txtAllowance"
        Me.txtAllowance.Size = New System.Drawing.Size(100, 20)
        Me.txtAllowance.TabIndex = 5
        '
        'txtTax
        '
        Me.txtTax.Location = New System.Drawing.Point(87, 161)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(100, 20)
        Me.txtTax.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Employee"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Month"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Year"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Allowance"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(54, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Tax"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Employee"
        '
        'btnExportExcel
        '
        Me.btnExportExcel.Location = New System.Drawing.Point(419, 246)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(75, 23)
        Me.btnExportExcel.TabIndex = 12
        Me.btnExportExcel.Text = "Export Excel"
        Me.btnExportExcel.UseVisualStyleBackColor = True
        '
        'btnPrintPayslip
        '
        Me.btnPrintPayslip.Location = New System.Drawing.Point(515, 246)
        Me.btnPrintPayslip.Name = "btnPrintPayslip"
        Me.btnPrintPayslip.Size = New System.Drawing.Size(72, 23)
        Me.btnPrintPayslip.TabIndex = 13
        Me.btnPrintPayslip.Text = "PaySlip Pdf"
        Me.btnPrintPayslip.UseVisualStyleBackColor = True
        '
        'PayrollForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnPrintPayslip)
        Me.Controls.Add(Me.btnExportExcel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTax)
        Me.Controls.Add(Me.txtAllowance)
        Me.Controls.Add(Me.cmbMonth)
        Me.Controls.Add(Me.dgvPayroll)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.cmbEmployee)
        Me.Name = "PayrollForm"
        Me.Text = "PayrollForm"
        CType(Me.dgvPayroll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbEmployee As ComboBox
    Friend WithEvents txtYear As TextBox
    Friend WithEvents btnGenerate As Button
    Friend WithEvents dgvPayroll As DataGridView
    Friend WithEvents cmbMonth As ComboBox
    Friend WithEvents txtAllowance As TextBox
    Friend WithEvents txtTax As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnExportExcel As Button
    Friend WithEvents btnPrintPayslip As Button
End Class
