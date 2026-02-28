Imports System.Data.SqlClient

Public Class EmployeeForm


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click


        DBConnection.OpenConnection()

        Dim cmd As New SqlCommand("INSERT INTO Employees
        (Name, Gender, Department, BasicSalary, Email, Phone, JoinDate)
        VALUES (@Name,@Gender,@Department,@BasicSalary,@Email,@Phone,@JoinDate)",
        DBConnection.con)

        cmd.Parameters.AddWithValue("@Name", txtName.Text)
        cmd.Parameters.AddWithValue("@Gender", cmbGender.Text)
        cmd.Parameters.AddWithValue("@Department", txtDepartment.Text)
        cmd.Parameters.AddWithValue("@BasicSalary", txtBasicSalary.Text)
        cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
        cmd.Parameters.AddWithValue("@Phone", txtPhone.Text)
        cmd.Parameters.AddWithValue("@JoinDate", dtpJoinDate.Value)

        cmd.ExecuteNonQuery()
        DBConnection.CloseConnection()

        MessageBox.Show("Employee Added Successfully")
        LoadEmployees()
    End Sub
    Public Sub LoadEmployees()

        DBConnection.OpenConnection()

        Dim da As New SqlDataAdapter("SELECT * FROM Employees", DBConnection.con)
        Dim dt As New DataTable()
        da.Fill(dt)

        dgvEmployees.DataSource = dt

        DBConnection.CloseConnection()

    End Sub

    Private Sub EmployeeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmployees()

        cmbGender.Items.Add("Male")
        cmbGender.Items.Add("Female")
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        DBConnection.OpenConnection()

        Dim cmd As New SqlCommand("UPDATE Employees SET
        Name=@Name, Gender=@Gender, Department=@Department,
        BasicSalary=@BasicSalary, Email=@Email, Phone=@Phone,
        JoinDate=@JoinDate
        WHERE EmployeeID=@EmployeeID",
        DBConnection.con)

        cmd.Parameters.AddWithValue("@EmployeeID", dgvEmployees.CurrentRow.Cells("EmployeeID").Value)
        cmd.Parameters.AddWithValue("@Name", txtName.Text)
        cmd.Parameters.AddWithValue("@Gender", cmbGender.Text)
        cmd.Parameters.AddWithValue("@Department", txtDepartment.Text)
        cmd.Parameters.AddWithValue("@BasicSalary", txtBasicSalary.Text)
        cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
        cmd.Parameters.AddWithValue("@Phone", txtPhone.Text)
        cmd.Parameters.AddWithValue("@JoinDate", dtpJoinDate.Value)

        cmd.ExecuteNonQuery()
        DBConnection.CloseConnection()

        MessageBox.Show("Employee Updated Successfully")
        LoadEmployees()


    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        DBConnection.OpenConnection()

        Dim cmd As New SqlCommand("DELETE FROM Employees WHERE EmployeeID=@EmployeeID",
                              DBConnection.con)

        cmd.Parameters.AddWithValue("@EmployeeID",
                                dgvEmployees.CurrentRow.Cells("EmployeeID").Value)

        cmd.ExecuteNonQuery()
        DBConnection.CloseConnection()

        MessageBox.Show("Employee Deleted Successfully")
        LoadEmployees()
    End Sub
End Class
