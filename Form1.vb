Imports System.Drawing.Imaging

Public Class Form1

    Private Sub btnCalculateTax_Click(sender As Object, e As EventArgs) Handles btnCalculateTax.Click
        Const RATE1 As Decimal = 0.1
        Const RATE2 As Decimal = 0.2
        Const RATE3 As Decimal = 0.3

        'declare variables
        Dim firstName As String
        Dim lastName As String
        Dim income As Single
        Dim sngtax As Single
        Dim tax As Single

        income = CSng(txtIncome.Text)

        If income >= 0 And income <= 10000 Then
            tax = income * RATE1
        ElseIf income >= 10001 And income <= 50000 Then
            tax = 10000 * RATE1 + (income - 10000) * RATE2
        ElseIf income >= 50001 Then
            tax = 10000 * RATE1 + (50000 - 10001) * RATE2 + (income - 50001) * RATE3
        End If

        'Get data from form
        sngtax = (10000 * RATE1) + ((50000 - 10001) * RATE2) + ((income - 50001) * RATE3)
        firstName = txtFirst.Text
        lastName = txtLast.Text
        lblName_Tax.Text = firstName + " " + lastName + " " + sngtax.ToString("C")

    End Sub

    Private Sub btnClearInput_Click(sender As Object, e As EventArgs) Handles btnClearInput.Click
        txtFirst.Text = ""
        txtLast.Text = ""
        txtIncome.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

End Class
