Public Class frmFactorial



    Private Sub btnButton_Click(sender As Object, e As EventArgs) Handles btnButton.Click
        Dim intFact As Integer = 1
        Dim intNum As Integer = InputBox("Enter your number", "Factorial")
        For intNum = intNum To 1 Step -1
            intFact = intNum * intFact
        Next
        lblLabel.Text = intFact

    End Sub
End Class
