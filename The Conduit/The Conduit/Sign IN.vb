Public Class register
    Private Toolbox As New Toolbox
    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles farmer.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        My.Forms.register.Hide()
        My.Forms.Home.Show()
    End Sub

    Private Sub farmerlastname_TextChanged(sender As Object, e As EventArgs) Handles farmerlastname.TextChanged

    End Sub

    Private Sub createfarmer_Click(sender As Object, e As EventArgs) Handles createfarmer.Click
        Toolbox.InsertFarmerData()
        Toolbox.FillDataGridView("select Produce,Location,Quantity,Price,Date_of_Harvest,Farmer.LastName,Farmer.FirstName,Farmer.Email,Farmer.Phone from Product,Farmer  Where Farmer.Phone=Product.Phone and Product.ID>0 ORDER BY Product.ID desc", "Product", Home.DataGrid)
        Toolbox.FillDataGridView("select FirstName,LastName,Produce_Dealings,Phone,Email from Middleman Where ID>0 ORDER BY ID desc", "Middleman", Home.MiddlemanGrid)
        Toolbox.FillDataGridView("select [Market Name],Location,[City/Town],Region,EntryDate from Market Where ID>0 ORDER BY ID desc", "Market", Home.mktgrid)

        Toolbox.FillDataGridView("select [Company Name],[Produce Dealings],Address,[Office Phone],[Office Phone(Optional)],Email from Company Where ID>0 ORDER BY ID desc", "Company", Home.companygrid)
    End Sub

    Private Sub middlemancreatebtn_Click(sender As Object, e As EventArgs) Handles middlemancreatebtn.Click
        Toolbox.InsertMiddlemanData()
        Toolbox.FillDataGridView("select Produce,Location,Quantity,Price,Date_of_Harvest,Farmer.LastName,Farmer.FirstName,Farmer.Email,Farmer.Phone from Product,Farmer  Where Farmer.Phone=Product.Phone and Product.ID>0 ORDER BY Product.ID desc", "Product", Home.DataGrid)
        Toolbox.FillDataGridView("select FirstName,LastName,Produce_Dealings,Phone,Email from Middleman Where ID>0 ORDER BY ID desc", "Middleman", Home.MiddlemanGrid)
        Toolbox.FillDataGridView("select [Market Name],Location,[City/Town],Region,EntryDate from Market Where ID>0 ORDER BY ID desc", "Market", Home.mktgrid)

        Toolbox.FillDataGridView("select [Company Name],[Produce Dealings],Address,[Office Phone],[Office Phone(Optional)],Email from Company Where ID>0 ORDER BY ID desc", "Company", Home.companygrid)
    End Sub

    Private Sub companycreatebtn_Click(sender As Object, e As EventArgs) Handles companycreatebtn.Click
        Toolbox.InsertCompanyData()

        Toolbox.FillDataGridView("select Produce,Location,Quantity,Price,Date_of_Harvest,Farmer.LastName,Farmer.FirstName,Farmer.Email,Farmer.Phone from Product,Farmer  Where Farmer.Phone=Product.Phone and Product.ID>0 ORDER BY Product.ID desc", "Product", Home.DataGrid)
        Toolbox.FillDataGridView("select FirstName,LastName,Produce_Dealings,Phone,Email from Middleman Where ID>0 ORDER BY ID desc", "Middleman", Home.MiddlemanGrid)
        Toolbox.FillDataGridView("select [Market Name],Location,[City/Town],Region,EntryDate from Market Where ID>0 ORDER BY ID desc", "Market", Home.mktgrid)

        Toolbox.FillDataGridView("select [Company Name],[Produce Dealings],Address,[Office Phone],[Office Phone(Optional)],Email from Company Where ID>0 ORDER BY ID desc", "Company", Home.companygrid)
    End Sub

    Private Sub register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub addmkt_Click(sender As Object, e As EventArgs) Handles addmkt.Click
        Toolbox.InsertMarketData()
        Toolbox.FillDataGridView("select [Market Name],Location,[City/Town],Region,EntryDate from Market Where ID>0 ORDER BY ID desc", "Market", Home.mktgrid)
        My.Forms.Home.Show()
        My.Forms.register.Hide()

    End Sub
End Class