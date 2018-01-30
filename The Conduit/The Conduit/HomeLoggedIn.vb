Public Class HomeLoggedIn
    Private Toolbox As New Toolbox
    Private Sub HomeLoggedIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Toolbox.FillDataGridView("select Produce,Location,Quantity,Price,Date_of_Harvest,Farmer.LastName,Farmer.FirstName,Farmer.Email,Farmer.Phone from Product,Farmer  Where Farmer.Phone=Product.Phone and Product.ID>0 ORDER BY Product.ID desc", "Product", DataGrid)
        Toolbox.FillDataGridView("select FirstName,LastName,Produce_Dealings,Phone,Email from Middleman Where ID>0 ORDER BY ID desc", "Middleman", MiddlemanGrid)
        Toolbox.FillDataGridView("select [Market Name],Location,[City/Town],Region,EntryDate from Market Where ID>0 ORDER BY ID desc", "Market", mktgrid)
        Toolbox.FillDataGridView("select [Company Name],[Produce Dealings],Address,[Office Phone],[Office Phone(Optional)],Email from Company Where ID>0 ORDER BY ID desc", "Company", companygrid)
    End Sub

    Private Sub sell_Click(sender As Object, e As EventArgs) Handles sell.Click
        My.Forms.HomeLoggedIn.Hide()
        My.Forms.ProduceAd.Show()
    End Sub

    Private Sub register_Click(sender As Object, e As EventArgs)
        My.Forms.HomeLoggedIn.Hide()
        My.Forms.register.Show()

    End Sub

    Private Sub searchbtn_Click(sender As Object, e As EventArgs) Handles searchbtn.Click
        Toolbox.FillDataGridView("select Produce,Location,Quantity,Price,Date_of_Harvest,Farmer.LastName,Farmer.FirstName,Farmer.Email,Farmer.Phone from Product,Farmer  Where Farmer.Phone=Product.Phone and Product.ID>0 ORDER BY Product.ID desc", "Product", DataGrid)
        Toolbox.FillDataGridView("Select Produce,Location,Quantity,Price,Date_of_Harvest,Farmer.LastName,Farmer.FirstName,Farmer.Email,Farmer.Phone from Product,Farmer Where Farmer.Phone=Product.Phone and Product.ID>0 and Produce = '" + CStr(LTrim(searchtxt.Text)) + "'" + " or Location ='" + CStr(LTrim(searchtxt.Text)) + "'" + " or Price ='" + CStr(LTrim(searchtxt.Text)) + "'" + " or Farmer.Lastname ='" + CStr(LTrim(searchtxt.Text)) + "'" + " or Farmer.FirstName ='" + CStr(LTrim(searchtxt.Text)) + "'" + " or Farmer.Email ='" + CStr(LTrim(searchtxt.Text)) + "'" + " or Farmer.Phone ='" + CStr(LTrim(searchtxt.Text)) + "'", "@search", DataGrid)
        If (searchtxt.Text = "") Then
            Toolbox.FillDataGridView("select Produce,Location,Quantity,Price,Date_of_Harvest,Farmer.LastName,Farmer.FirstName,Farmer.Email,Farmer.Phone from Product,Farmer  Where Farmer.Phone=Product.Phone and Product.ID>0 ORDER BY Product.ID desc", "Product", DataGrid)


        End If
    End Sub

    Private Sub listview_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles searchtxtmiddle.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles searchbtnmiddle.Click
        Toolbox.FillDataGridView("select FirstName,LastName,Produce_Dealings,Phone,Email from Middleman Where FirstName ='" + CStr(LTrim(searchtxtmiddle.Text)) + "'" + " or Gender ='" + CStr(LTrim(searchtxtmiddle.Text)) + "'" + " or LastName ='" + CStr(LTrim(searchtxtmiddle.Text)) + "'" + " or Phone ='" + CStr(LTrim(searchtxtmiddle.Text)) + "'" + " or Address ='" + CStr(LTrim(searchtxtmiddle.Text)) + "'" + " or Email ='" + CStr(LTrim(searchtxtmiddle.Text)) + "'" + "or Produce_Dealings='" + CStr(LTrim(searchtxtmiddle.Text)) + "'", "@search", MiddlemanGrid)
        If (searchtxtmiddle.Text = "") Then
            Toolbox.FillDataGridView("select FirstName,LastName,Produce_Dealings,Phone,Email from Middleman Where ID>0 ORDER BY ID desc", "Middleman", MiddlemanGrid)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles searchbtncompany.Click
        Toolbox.FillDataGridView("select [Company Name],[Produce Dealings],Address,[Office Phone],[Office Phone(Optional)],Email from Company Where [Company Name] ='" + CStr(LTrim(searchtxtcompany.Text)) + "'" + " or Address ='" + CStr(LTrim(searchtxtcompany.Text)) + "'" + " or [Office Phone] ='" + CStr(LTrim(searchtxtcompany.Text)) + "'" + " or [Office Phone(Optional)] ='" + CStr(LTrim(searchtxtcompany.Text)) + "'" + " or Email ='" + CStr(LTrim(searchtxtcompany.Text)) + "'" + " or [Produce Dealings] ='" + CStr(LTrim(searchtxtcompany.Text)) + "'", "@search", companygrid)
        If (searchtxtmiddle.Text = "") Then
            Toolbox.FillDataGridView("select [Company Name],[Produce Dealings],Address,[Office Phone],[Office Phone(Optional)],Email from Company Where ID>0 ORDER BY ID desc", "Company", companygrid)
        End If
    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        My.Forms.Home.Show()
        My.Forms.HomeLoggedIn.Hide()
    End Sub

    Private Sub check_Click(sender As Object, e As EventArgs) Handles check.Click
        My.Forms.ServerDetails.Show()
        My.Forms.HomeLoggedIn.Hide()

    End Sub
End Class