Imports System.Data.SqlClient
Imports Excel = Microsoft.Office.Interop.Excel

Public Class ReportsForm

    Private Sub ReportsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmployees()
        cmbReportMonth.Items.AddRange({"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
    End Sub

    Private Sub LoadEmployees()
        DBConnection.OpenConnection()
        Dim cmd As New SqlCommand("SELECT EmployeeID, Name FROM Employees", DBConnection.con)
        Dim dt As New DataTable()
        dt.Load(cmd.ExecuteReader())
        cmbReportEmployee.DataSource = dt
        cmbReportEmployee.DisplayMember = "Name"
        cmbReportEmployee.ValueMember = "EmployeeID"
        DBConnection.CloseConnection()
    End Sub

    Private Sub btnGenerateReport_Click(sender As Object, e As EventArgs) Handles btnGenerateReport.Click
        DBConnection.OpenConnection()
        Dim cmd As New SqlCommand("SELECT p.PayrollID, e.Name, p.Month, p.Year, p.BasicSalary, p.Allowance, p.Tax, p.NetSalary
                                   FROM Payroll p
                                   INNER JOIN Employees e ON p.EmployeeID=e.EmployeeID
                                   WHERE (@EmpID=0 OR p.EmployeeID=@EmpID) 
                                   AND (@Month='' OR p.Month=@Month) 
                                   AND (@Year=0 OR p.Year=@Year)
                                   ORDER BY p.PayrollID DESC", DBConnection.con)
        cmd.Parameters.AddWithValue("@EmpID", If(cmbReportEmployee.SelectedIndex = -1, 0, cmbReportEmployee.SelectedValue))
        cmd.Parameters.AddWithValue("@Month", If(cmbReportMonth.SelectedIndex = -1, "", cmbReportMonth.Text))
        cmd.Parameters.AddWithValue("@Year", If(String.IsNullOrEmpty(txtReportYear.Text), 0, Convert.ToInt32(txtReportYear.Text)))

        Dim dt As New DataTable()
        dt.Load(cmd.ExecuteReader())
        dgvReport.DataSource = dt
        DBConnection.CloseConnection()
    End Sub

    Private Sub btnExportReport_Click(sender As Object, e As EventArgs) Handles btnExportReport.Click
        Try
            If dgvReport.Rows.Count = 0 Then
                MessageBox.Show("No report data to export.")
                Exit Sub
            End If

            Dim xlApp As Excel.Application = New Excel.Application
            Dim xlWorkBook As Excel.Workbook = xlApp.Workbooks.Add
            Dim xlWorkSheet As Excel.Worksheet = CType(xlWorkBook.Sheets(1), Excel.Worksheet)

            ' Headers
            For i As Integer = 0 To dgvReport.Columns.Count - 1
                xlWorkSheet.Cells(1, i + 1) = dgvReport.Columns(i).HeaderText
            Next

            ' Rows
            For i As Integer = 0 To dgvReport.Rows.Count - 2
                For j As Integer = 0 To dgvReport.Columns.Count - 1
                    xlWorkSheet.Cells(i + 2, j + 1) = dgvReport.Rows(i).Cells(j).Value
                Next
            Next

            xlApp.Visible = True
        Catch ex As Exception
            MessageBox.Show("Error exporting report: " & ex.Message)
        End Try
    End Sub
End Class