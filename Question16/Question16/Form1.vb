Public Class Form1
    Dim intMessage As Integer
    Private Sub btnMessage_Click(sender As Object, e As EventArgs) Handles btnMessage.Click
        Randomize()
        intMessage = Int((100 - 1 + 1) * Rnd() + 1)

        Select Case intMessage
            Case 1, 2
                Me.lblAnswer.Text = "You win $100"
            Case 40 To 50
                Me.lblAnswer.Text = "You win $10"
            Case 50 To 100
                Me.lblAnswer.Text = "You win $1"
            Case Else
                Me.lblAnswer.Text = "Thanks for trying"
        End Select

    End Sub
End Class
