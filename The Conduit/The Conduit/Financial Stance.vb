Public Class ServerDetails
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Cost As Integer
        Dim Revenue As Integer
        Cost = CDec(My.Forms.ServerDetails.cost.Text)
        Revenue = CDec(My.Forms.ServerDetails.revenue.Text)

        If (Revenue - Cost) < 0 Then
            Status.Text = "Your Financial Stance is a Loss."
            details.Text = "You have obtained a loss of GHC " + CStr(LTrim(Revenue - Cost)) + "."
        ElseIf (Revenue - Cost) > 0 Then
            Status.Text = "Your Financial Stance is a Profit."
            details.Text = "You have obtained a profit of GHC " + CStr(LTrim(Revenue - Cost)) + "."
        ElseIf (Revenue - Cost) = 0 Then
            Status.Text = "Your Financial Stance is a  Zero-Profit."
            details.Text = "You have obtained a profit of GHC " + CStr(LTrim(Revenue - Cost)) + "."

        End If


    End Sub

    Private Sub ServerDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub done_Click(sender As Object, e As EventArgs) Handles done.Click
        My.Forms.ServerDetails.Hide()
        My.Forms.HomeLoggedIn.Show()
        Status.Text = "Check your financial Stance below"
        details.Text = ""
        cost.Text = ""
        revenue.Text = ""
    End Sub
End Class