Public Class PayrollService

    Public Shared Function CalculateTax(basic As Decimal) As Decimal

        If basic < 30000 Then
            Return basic * 0.05D ' 05% tax
        ElseIf basic < 60000 Then
            Return basic * 0.1D  ' 10% tax
        Else
            Return basic * 0.15D ' 15% tax
        End If

    End Function

    Public Shared Function CalculateNetSalary(basic As Decimal, allowance As Decimal) As Decimal
        Dim tax = CalculateTax(basic)
        Return (basic + allowance) - tax
    End Function

End Class