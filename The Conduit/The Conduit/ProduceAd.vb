Public Class ProduceAd
    Private Toolbox As New Toolbox
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Forms.ProduceAd.Hide()
        My.Forms.HomeLoggedIn.Show()
        Toolbox.FillDataGridView("select Produce,Location,Quantity,Price,Date_of_Harvest,Farmer.LastName,Farmer.FirstName,Farmer.Email,Farmer.Phone from Product,Farmer  Where Farmer.Phone=Product.Phone and Product.ID>0 ORDER BY Product.ID desc", "Product", HomeLoggedIn.DataGrid)
        Toolbox.FillDataGridView("select Produce,Location,Quantity,Price,Date_of_Harvest,Farmer.LastName,Farmer.FirstName,Farmer.Email,Farmer.Phone from Product,Farmer  Where Farmer.Phone=Product.Phone and Product.ID>0 ORDER BY Product.ID desc", "Product", Home.DataGrid)
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles phone.TextChanged

    End Sub

    Private Sub sellbtn_Click(sender As Object, e As EventArgs) Handles sellbtn.Click

        Toolbox.InsertData()
        If HomeLoggedIn.user.Text = "Email" Then
            My.Forms.Home.Show()
            My.Forms.ProduceAd.Hide()
        Else
            My.Forms.HomeLoggedIn.Show()
            My.Forms.ProduceAd.Hide()
        End If
        Toolbox.FillDataGridView("select Produce,Location,Quantity,Price,Date_of_Harvest,Farmer.LastName,Farmer.FirstName,Farmer.Email,Farmer.Phone from Product,Farmer  Where Farmer.Phone=Product.Phone and Product.ID>0 ORDER BY Product.ID desc", "Product", HomeLoggedIn.DataGrid)
        Toolbox.FillDataGridView("select Produce,Location,Quantity,Price,Date_of_Harvest,Farmer.LastName,Farmer.FirstName,Farmer.Email,Farmer.Phone from Product,Farmer  Where Farmer.Phone=Product.Phone and Product.ID>0 ORDER BY Product.ID desc", "Product", Home.DataGrid)


    End Sub


    Private Sub ProduceAd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class