Imports System.Data.SqlClient
Public Class DBConnection
    Public Shared con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\VB_NETPROJECT\Employee Payroll Management System\PayrollDB.mdf;Integrated Security=True")
    Public Shared Sub OpenConnection()
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
        Catch ex As Exception
            MessageBox.Show("DataBase Connecion Failed:" & ex.Message)
        End Try
    End Sub
    Public Shared Sub CloseConnection()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
    End Sub

End Class
