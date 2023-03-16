Public Class Form1
    ' Program Name: Building Plans Conversion Application
    ' Author: ArRionne Hickson
    ' Date: 15 March 2023
    ' Purpose: Convert measurements from inches to meters, from meters to inches
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim decValue As Decimal

        If IsNumeric(txtInput.Text) Then
            decValue = Convert.ToDecimal(txtInput.Text)
            If (txtInput.Text) > 0 Then
                If radInchesto.Checked Then
                    ' Conversions, 1m = 39.3701in
                    decValue /= 39.3701
                Else
                    decValue *= 39.3701
                End If
                lblConvert.Text = $"{txtInput.Text} {(If(radInchesto.Checked, "Inches", "Meters"))} is {decValue:F2} {(If(radInchesto.Checked, "Meters", "Inches"))}"
            Else
                ' message boxes
                MsgBox("You entered " & decValue.ToString() & ". Enter a positive number.", , "Input Error")
            End If
        Else
            MsgBox("Please enter a valid number. ", , "Non-Numeric Error")

        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtInput.Clear()
        lblConvert.Text = "Enter value in text box to convert."
        radInchesto.Checked = True
        txtInput.Focus()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtInput.Focus()
        lblConvert.Text = ""
    End Sub
End Class
