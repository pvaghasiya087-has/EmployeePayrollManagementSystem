Public Class LoginForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If AuthService.Login(txtUsername.Text, txtPassword.Text) Then
            DashboardForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid Login")
        End If
    End Sub
End Class