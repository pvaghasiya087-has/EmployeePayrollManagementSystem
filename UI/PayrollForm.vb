Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Data.SqlClient


Public Class PayrollForm
    Private Sub PayrollForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadEmployees()

        cmbMonth.Items.AddRange(
        {"January", "February", "March", "April", "May", "June",
         "July", "August", "September", "October", "November", "December"})

    End Sub
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        DBConnection.OpenConnection()

        ' Get Basic Salary
        Dim cmdGet As New SqlCommand(
            "SELECT BasicSalary FROM Employees WHERE EmployeeID=@EmployeeID",
            DBConnection.con)

        cmdGet.Parameters.AddWithValue("@EmployeeID", cmbEmployee.SelectedValue)

        Dim basic As Decimal = Convert.ToDecimal(cmdGet.ExecuteScalar())

        Dim allowance As Decimal = Convert.ToDecimal(txtAllowance.Text)
        Dim tax As Decimal = Convert.ToDecimal(txtTax.Text)

        Dim netSalary As Decimal = (basic + allowance) - tax

        ' Insert Payroll
        Dim cmdInsert As New SqlCommand(
            "INSERT INTO Payroll
        (EmployeeID, Month, Year, BasicSalary, Allowance, Tax, NetSalary)
        VALUES (@EmployeeID,@Month,@Year,@Basic,@Allowance,@Tax,@NetSalary)",
            DBConnection.con)

        cmdInsert.Parameters.AddWithValue("@EmployeeID", cmbEmployee.SelectedValue)
        cmdInsert.Parameters.AddWithValue("@Month", cmbMonth.Text)
        cmdInsert.Parameters.AddWithValue("@Year", txtYear.Text)
        cmdInsert.Parameters.AddWithValue("@Basic", basic)
        cmdInsert.Parameters.AddWithValue("@Allowance", allowance)
        cmdInsert.Parameters.AddWithValue("@Tax", tax)
        cmdInsert.Parameters.AddWithValue("@NetSalary", netSalary)

        cmdInsert.ExecuteNonQuery()

        DBConnection.CloseConnection()

        MessageBox.Show("Payroll Generated Successfully")

    End Sub
    Public Sub LoadEmployees()

        DBConnection.OpenConnection()

        Dim cmd As New SqlCommand("SELECT EmployeeID, Name FROM Employees",
                                  DBConnection.con)

        Dim dt As New DataTable()
        dt.Load(cmd.ExecuteReader())

        cmbEmployee.DataSource = dt
        cmbEmployee.DisplayMember = "Name"
        cmbEmployee.ValueMember = "EmployeeID"

        DBConnection.CloseConnection()

    End Sub

    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        Try
            If dgvPayroll.Rows.Count = 0 Then
                MessageBox.Show("No payroll data to export.")
                Exit Sub
            End If

            Dim xlApp As Excel.Application = New Excel.Application
            Dim xlWorkBook As Excel.Workbook = xlApp.Workbooks.Add
            Dim xlWorkSheet As Excel.Worksheet = CType(xlWorkBook.Sheets(1), Excel.Worksheet)

            ' Export DataGridView headers
            For i As Integer = 0 To dgvPayroll.Columns.Count - 1
                xlWorkSheet.Cells(1, i + 1) = dgvPayroll.Columns(i).HeaderText
            Next

            ' Export DataGridView rows
            ' Skip the new row placeholder
            For i As Integer = 0 To dgvPayroll.Rows.Count - 2
                For j As Integer = 0 To dgvPayroll.Columns.Count - 1
                    xlWorkSheet.Cells(i + 2, j + 1) = dgvPayroll.Rows(i).Cells(j).Value
                Next
            Next

            xlApp.Visible = True

        Catch ex As Exception
            MessageBox.Show("Error exporting to Excel: " & ex.Message)
        End Try
    End Sub

    Private Sub btnPrintPayslip_Click(sender As Object, e As EventArgs) Handles btnPrintPayslip.Click
        If dgvPayroll.CurrentRow Is Nothing Then Exit Sub

        Dim payrollID = dgvPayroll.CurrentRow.Cells("PayrollID").Value
        DBConnection.OpenConnection()
        Dim cmd As New SqlCommand("SELECT e.Name, e.Department, p.Month, p.Year, p.BasicSalary, p.Allowance, p.Tax, p.NetSalary
                               FROM Payroll p
                               INNER JOIN Employees e ON p.EmployeeID = e.EmployeeID
                               WHERE p.PayrollID=@PayrollID", DBConnection.con)
        cmd.Parameters.AddWithValue("@PayrollID", payrollID)
        Dim reader = cmd.ExecuteReader()
        If reader.Read() Then
            Dim payslip As String = $"Payslip for {reader("Name")}" & vbCrLf &
                                    $"Department: {reader("Department")}" & vbCrLf &
                                    $"Month/Year: {reader("Month")}/{reader("Year")}" & vbCrLf &
                                    $"Basic Salary: {Convert.ToDecimal(reader("BasicSalary")).ToString("F2")}" & vbCrLf &
                                    $"Allowance: {Convert.ToDecimal(reader("Allowance")).ToString("F2")}" & vbCrLf &
                                    $"Tax: {Convert.ToDecimal(reader("Tax")).ToString("F2")}" & vbCrLf &
                                    $"Net Salary: {Convert.ToDecimal(reader("NetSalary")).ToString("F2")}"
            MessageBox.Show(payslip, "Payslip Preview")
        End If
        reader.Close()
        DBConnection.CloseConnection()
    End Sub
End Class