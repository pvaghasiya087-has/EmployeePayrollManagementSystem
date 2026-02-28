Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class DashboardForm

    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStatistics()
        LoadRecentPayroll()
        LoadSalaryChart()
    End Sub

    ' Total employees
    Private Sub LoadStatistics()
        DBConnection.OpenConnection()

        ' Total Employees
        Dim cmdEmp As New SqlCommand("SELECT COUNT(*) FROM Employees", DBConnection.con)
        lblTotalEmployees.Text = cmdEmp.ExecuteScalar().ToString()

        ' Total Payroll Expense
        Dim cmdTotalPayroll As New SqlCommand("SELECT ISNULL(SUM(NetSalary),0) FROM Payroll", DBConnection.con)
        lblTotalPayroll.Text = Convert.ToDecimal(cmdTotalPayroll.ExecuteScalar()).ToString("F2")

        ' Highest Paid Employee
        Dim cmdHigh As New SqlCommand("SELECT TOP 1 e.Name, p.NetSalary 
                                       FROM Payroll p 
                                       INNER JOIN Employees e ON p.EmployeeID=e.EmployeeID
                                       ORDER BY p.NetSalary DESC", DBConnection.con)
        Dim reader = cmdHigh.ExecuteReader()
        If reader.Read() Then
            lblHighestPaid.Text = $"{reader("Name")} ({Convert.ToDecimal(reader("NetSalary")).ToString("F2")})"
        End If
        reader.Close()

        DBConnection.CloseConnection()
    End Sub

    ' Load recent payroll in DataGridView
    Private Sub LoadRecentPayroll()
        DBConnection.OpenConnection()
        Dim da As New SqlDataAdapter("SELECT TOP 10 p.PayrollID, e.Name, p.Month, p.Year, p.NetSalary 
                                      FROM Payroll p
                                      INNER JOIN Employees e ON p.EmployeeID=e.EmployeeID
                                      ORDER BY p.PayrollID DESC", DBConnection.con)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvRecentPayroll.DataSource = dt
        DBConnection.CloseConnection()
    End Sub

    ' Optional: Load salary chart
    Private Sub LoadSalaryChart()
        DBConnection.OpenConnection()
        Dim cmd As New SqlCommand("SELECT TOP 5 e.Name, MAX(p.NetSalary) as MaxSalary 
                                   FROM Payroll p
                                   INNER JOIN Employees e ON p.EmployeeID=e.EmployeeID
                                   GROUP BY e.Name
                                   ORDER BY MaxSalary DESC", DBConnection.con)
        Dim reader = cmd.ExecuteReader()
        chartSalary.Series.Clear()
        Dim series As New Series("Salary")
        series.ChartType = SeriesChartType.Column
        While reader.Read()
            series.Points.AddXY(reader("Name").ToString(), reader("MaxSalary"))
        End While
        chartSalary.Series.Add(series)
        reader.Close()
        DBConnection.CloseConnection()
    End Sub

End Class