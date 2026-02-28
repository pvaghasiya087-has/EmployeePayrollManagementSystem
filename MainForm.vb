Imports System.Windows.Forms

Public Class MainForm

    ' Form Load
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load Dashboard by default
        LoadFormIntoPanel(New DashboardForm())
        For Each ctrl As Control In pnlNav.Controls
            If TypeOf ctrl Is Button Then
                AddHandler ctrl.MouseEnter, AddressOf btn_MouseEnter
                AddHandler ctrl.MouseLeave, AddressOf btn_MouseLeave
            End If
        Next
    End Sub

    ' ======================
    ' Dynamic Form Loader
    ' ======================
    Private Sub LoadFormIntoPanel(frm As Form)
        pnlMain.Controls.Clear()
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        pnlMain.Controls.Add(frm)
        frm.Show()
    End Sub

    ' ======================
    ' Navigation Buttons
    ' ======================
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        LoadFormIntoPanel(New DashboardForm())
    End Sub

    Private Sub btnEmployees_Click(sender As Object, e As EventArgs)
        LoadFormIntoPanel(New EmployeeForm())
    End Sub

    Private Sub btnPayroll_Click(sender As Object, e As EventArgs)
        LoadFormIntoPanel(New PayrollForm())
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs)
        LoadFormIntoPanel(New ReportsForm())
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs)
        ' Optional: Show login form after logout
        Me.Close()
        LoginForm.Show()
    End Sub
    Private Sub btn_MouseEnter(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        btn.BackColor = Color.DarkGray
    End Sub

    Private Sub btn_MouseLeave(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        btn.BackColor = Color.LightGray
    End Sub

    Private Sub btnPayroll_Click_1(sender As Object, e As EventArgs) Handles btnPayroll.Click

    End Sub
End Class