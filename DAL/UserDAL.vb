Imports System.Data.SqlClient

Public Class UserDAL

    ' Get user by username
    Public Shared Function GetUserByUsername(username As String) As User
        DBConnection.OpenConnection()
        Dim cmd As New SqlCommand("SELECT * FROM Users WHERE Username=@Username", DBConnection.con)
        cmd.Parameters.AddWithValue("@Username", username)

        Dim reader = cmd.ExecuteReader()
        Dim user As User = Nothing
        If reader.Read() Then
            user = New User() With {
                .UserID = Convert.ToInt32(reader("UserID")),
                .Username = reader("Username").ToString(),
                .PasswordHash = reader("PasswordHash").ToString(),
                .Role = reader("Role").ToString()
            }
        End If
        reader.Close()
        DBConnection.CloseConnection()
        Return user
    End Function

    ' Add new user
    Public Shared Sub AddUser(user As User)
        DBConnection.OpenConnection()
        Dim cmd As New SqlCommand("INSERT INTO Users (Username, PasswordHash, Role) VALUES (@Username,@PasswordHash,@Role)", DBConnection.con)
        cmd.Parameters.AddWithValue("@Username", user.Username)
        cmd.Parameters.AddWithValue("@PasswordHash", user.PasswordHash)
        cmd.Parameters.AddWithValue("@Role", user.Role)
        cmd.ExecuteNonQuery()
        DBConnection.CloseConnection()
    End Sub

    ' Optional: Delete or Update users can be added similarly
End Class