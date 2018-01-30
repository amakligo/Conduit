Public Class LOGIN
    Public radiof As Integer
    Public radiom As Integer
    Public radioc As Integer
    Private Toolbox As New Toolbox
    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        My.Forms.LOGIN.Hide()
        My.Forms.Home.Show()
    End Sub

    Public Sub farmerradio_CheckedChanged(sender As Object, e As EventArgs) Handles farmerradio.CheckedChanged

        radiof = 1
        radiom = 0
        radioc = 0
    End Sub

    Public Sub middlemanradio_CheckedChanged(sender As Object, e As EventArgs) Handles middlemanradio.CheckedChanged
        radiof = 0
        radiom = 1
        radioc = 0
    End Sub

    Public Sub companyradio_CheckedChanged(sender As Object, e As EventArgs) Handles companyradio.CheckedChanged

        radiof = 0
        radiom = 0
        radioc = 1
    End Sub

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        If radiof = 1 Then
            Toolbox.LogUserIn("Select Email,Password,Phone from Farmer where Email=@email and Password=@password ")

        ElseIf radiom = 1 Then
            Toolbox.LogUserIn("Select Email,Password from Middleman where Email=@email and Password=@password ")
            radiom = 0
        ElseIf radioc = 1 Then
            Toolbox.LogUserIn("Select Email,Password from Company where Email=@email and Password=@password ")
            radioc = 0
        Else
            MessageBox.Show("Please Check your appopriate radio button")
        End If
        My.Forms.LOGIN.passwordlogin.Text = ""

    End Sub

    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class