Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Public Class Validator

    ' Check if TextBox is empty
    Public Shared Function IsNotEmpty(txt As TextBox, fieldName As String) As Boolean
        If String.IsNullOrWhiteSpace(txt.Text) Then
            MessageBox.Show($"{fieldName} cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt.Focus()
            Return False
        End If
        Return True
    End Function

    ' Check if input is a valid number
    Public Shared Function IsDecimal(txt As TextBox, fieldName As String) As Boolean
        Dim val As Decimal
        If Not Decimal.TryParse(txt.Text, val) Then
            MessageBox.Show($"{fieldName} must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt.Focus()
            Return False
        End If
        Return True
    End Function

    ' Check if input is a valid integer
    Public Shared Function IsInteger(txt As TextBox, fieldName As String) As Boolean
        Dim val As Integer
        If Not Integer.TryParse(txt.Text, val) Then
            MessageBox.Show($"{fieldName} must be a valid integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt.Focus()
            Return False
        End If
        Return True
    End Function

    ' Validate Email format
    Public Shared Function IsValidEmail(txt As TextBox) As Boolean
        Dim pattern As String = "^[^@\s]+@[^@\s]+\.[^@\s]+$"
        If Not Regex.IsMatch(txt.Text, pattern) Then
            MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt.Focus()
            Return False
        End If
        Return True
    End Function

    ' Validate Phone number (digits only, length 10-15)
    Public Shared Function IsValidPhone(txt As TextBox) As Boolean
        Dim pattern As String = "^\d{10,15}$"
        If Not Regex.IsMatch(txt.Text, pattern) Then
            MessageBox.Show("Please enter a valid phone number (10-15 digits).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt.Focus()
            Return False
        End If
        Return True
    End Function

End Class