Public Class Form1

    

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim intTest1 As Integer = Me.txtTest1.Text
        Dim intTest2 As Integer = Me.txtTest2.Text
        Dim intTest3 As Integer = Me.txtTest3.Text
        Dim intAverage As Integer = (intTest1 + intTest2 + intTest3) / 3

        If (intTest1 Or intTest2 Or intTest3) > 100 Then
            Me.lblAnswer.Text = "Guess numbers lower than 100!"
        ElseIf (intTest1 Or intTest2 Or intTest3) < 1 Then
            Me.lblAnswer.Text = "Guess numbers higher than 0!"
        Else
            Me.lblAnswer.Text = "The average is " & intAverage
        End If
    End Sub

End Class
