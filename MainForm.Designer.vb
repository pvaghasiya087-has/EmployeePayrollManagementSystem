<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlNav = New System.Windows.Forms.Panel()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.btnEmployees = New System.Windows.Forms.Button()
        Me.btnPayroll = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.pnlNav.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.MaximumSize = New System.Drawing.Size(0, 60)
        Me.Panel1.MinimumSize = New System.Drawing.Size(0, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 60)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(371, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee Payroll Management System"
        '
        'pnlNav
        '
        Me.pnlNav.BackColor = System.Drawing.Color.LightGray
        Me.pnlNav.Controls.Add(Me.btnLogout)
        Me.pnlNav.Controls.Add(Me.btnPayroll)
        Me.pnlNav.Controls.Add(Me.btnEmployees)
        Me.pnlNav.Controls.Add(Me.btnDashboard)
        Me.pnlNav.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlNav.Location = New System.Drawing.Point(0, 60)
        Me.pnlNav.MaximumSize = New System.Drawing.Size(200, 0)
        Me.pnlNav.MinimumSize = New System.Drawing.Size(200, 0)
        Me.pnlNav.Name = "pnlNav"
        Me.pnlNav.Size = New System.Drawing.Size(200, 390)
        Me.pnlNav.TabIndex = 1
        '
        'btnDashboard
        '
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(16, 0)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnDashboard.Size = New System.Drawing.Size(145, 40)
        Me.btnDashboard.TabIndex = 0
        Me.btnDashboard.Text = "DashBoard"
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'pnlMain
        '
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(200, 60)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(600, 390)
        Me.pnlMain.TabIndex = 2
        '
        'btnEmployees
        '
        Me.btnEmployees.FlatAppearance.BorderSize = 0
        Me.btnEmployees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmployees.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmployees.Location = New System.Drawing.Point(16, 36)
        Me.btnEmployees.Name = "btnEmployees"
        Me.btnEmployees.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnEmployees.Size = New System.Drawing.Size(145, 40)
        Me.btnEmployees.TabIndex = 5
        Me.btnEmployees.Text = "Employees"
        Me.btnEmployees.UseVisualStyleBackColor = True
        '
        'btnPayroll
        '
        Me.btnPayroll.FlatAppearance.BorderSize = 0
        Me.btnPayroll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnPayroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPayroll.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayroll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPayroll.Location = New System.Drawing.Point(16, 76)
        Me.btnPayroll.Name = "btnPayroll"
        Me.btnPayroll.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnPayroll.Size = New System.Drawing.Size(145, 40)
        Me.btnPayroll.TabIndex = 6
        Me.btnPayroll.Text = "PayRoll"
        Me.btnPayroll.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(16, 122)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnLogout.Size = New System.Drawing.Size(145, 40)
        Me.btnLogout.TabIndex = 7
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlNav)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlNav.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlNav As Panel
    Friend WithEvents btnDashboard As Button
    Friend WithEvents pnlMain As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnPayroll As Button
    Friend WithEvents btnEmployees As Button
End Class
