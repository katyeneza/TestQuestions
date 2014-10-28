
Public Class Form1
    Dim intCostumerNum As Integer = 0

    Private Sub btnPurchase_Click(sender As Object, e As EventArgs) Handles btnPurchase.Click
        Dim intTicketNum As Integer = txtNumberTickets.Text
        Select Case intCostumerNum
            Case Is <> 9
                MsgBox("The cost of the tickets is $" & intTicketNum * 8)
                intCostumerNum += 1
            Case Is = 9
                MsgBox("Congratulations, your tickets are free!")
                intCostumerNum = 0
            Case Else

        End Select

    End Sub


End Class