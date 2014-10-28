Public Class Form1
   
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim intGuess1 As Integer = Me.txtNum1.Text
        Dim intGuess2 As Integer = Me.txtNum2.Text

        If intGuess1 > intGuess2 Then
            Me.lblAnswer.Text = "First number is larger"
        ElseIf intGuess1 < intGuess2 Then
            Me.lblAnswer.Text = "Second number is larger"
        ElseIf intGuess1 = intGuess2 Then
            Me.lblAnswer.Text = "The numbers are equal"
        Else
        End If

    End Sub

End Class
