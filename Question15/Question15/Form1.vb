Public Class Form1


    Private Sub btnAnswer_Click(sender As Object, e As EventArgs) Handles btnAnswer.Click
        Dim strMonth As String = Me.txtMonth.Text
        Dim intYear As Integer = Me.txtYear.Text

        Dim strAnswer1 As String = "JANUARY"
        Dim strAnswer2 As String = "FEBRUARY"
        Dim strAnswer3 As String = "MARCH"
        Dim strAnswer4 As String = "APRIL"
        Dim strAnswer5 As String = "MAY"
        Dim strAnswer6 As String = "JUNE"
        Dim strAnswer7 As String = "JULY"
        Dim strAnswer8 As String = "AUGUST"
        Dim strAnswer9 As String = "SEPTEMBER"
        Dim strAnswer10 As String = "OCTOBER"
        Dim strAnswer11 As String = "NOVEMBER"
        Dim strAnswer12 As String = "DECEMBER"

        Select Case Me.txtMonth.Text
            Case strAnswer1, strAnswer3, strAnswer5, strAnswer7, strAnswer8, strAnswer10, strAnswer12
                Me.lblAnswer.Text = "There are 31 days in this month."
            Case strAnswer4, strAnswer6, strAnswer9, strAnswer11
                Me.lblAnswer.Text = "There are 30 days in this month."
            Case strAnswer2
                If intYear Mod 4 <> 0 Then
                    Me.lblAnswer.Text = "There are 28 days in this month."
                ElseIf intYear Mod 400 = 0 Then
                    Me.lblAnswer.Text = "There are 29 days in this month."
                ElseIf intYear Mod 100 = 0 Then
                    Me.lblAnswer.Text = "There are 28 days in this month."
                Else
                    lblAnswer.Text = "There are 29 days in this month."
                End If
            Case Else
        End Select

    End Sub

End Class

