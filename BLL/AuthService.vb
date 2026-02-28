Imports System.Data.SqlClient

Public Class AuthService

    Public Shared Function Login(username As String, password As String) As Boolean

        DBConnection.OpenConnection()

        Dim cmd As New SqlCommand("SELECT PasswordHash FROM Users WHERE Username=@Username",
                                  DBConnection.con)

        cmd.Parameters.AddWithValue("@Username", username)

        Dim result = cmd.ExecuteScalar()

        DBConnection.CloseConnection()

        If result IsNot Nothing Then
            Dim storedHash As String = result.ToString()
            Dim enteredHash As String = PasswordHelper.HashPassword(password)
            Return storedHash = enteredHash
        End If

        Return False
    End Function

End Class