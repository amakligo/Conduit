Imports System.Data
Imports System.Data.SqlClient
Public Class Toolbox
    ''Creating class level variabless
    Public qsCompanionQueryString As String
    Public qsCompanionSqlString As SqlConnection
    Public qsCompanionSqlCommand As SqlCommandBuilder
    Public qsCompanionSqlAdapter As SqlDataAdapter
    Public qsCompanionSqlReader As SqlDataReader
    Public qsCompanionDataSet As DataSet
    'This function contains the database connection string
    Public Function DatabaseConnectionString() As SqlConnection
        Try
            'Appending database connection string to the variable declared
            qsCompanionSqlString = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=Conduit_Database;Trusted_Connection=True")

        Catch Ex As SqlException
            MessageBox.Show("Opps! Could not establish database connection",
                            "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch Ex As Exception
            MessageBox.Show("Remote Server Connection Error", Ex.Message.ToUpper)
        End Try

        Return (qsCompanionSqlString)

    End Function

    Public Sub InsertData()
        Try
            'Opening the database connection
            If (DatabaseConnectionString.State = ConnectionState.Closed) Then
                qsCompanionSqlString.Open()
            End If
            'Declaring sqlCommand instance & updating the content of the cell
            Dim qsCompanionSqlCommand = New SqlCommand()
            qsCompanionSqlCommand.Parameters.AddWithValue("@userName", CStr(LTrim(Home.searchtxt.Text)))
            qsCompanionSqlCommand.Parameters.AddWithValue("@produce", CStr(LTrim(ProduceAd.producename.Text)))
            qsCompanionSqlCommand.Parameters.AddWithValue("@location", CStr(LTrim(ProduceAd.location.Text)))
            qsCompanionSqlCommand.Parameters.AddWithValue("@qty", CStr(LTrim(ProduceAd.qty.Text)))
            qsCompanionSqlCommand.Parameters.AddWithValue("@price", CStr(LTrim(ProduceAd.price.Text)))
            qsCompanionSqlCommand.Parameters.AddWithValue("@picker", ProduceAd.picker.Value)
            qsCompanionSqlCommand.Parameters.AddWithValue("@phone", CStr(LTrim(ProduceAd.phone.Text)))
            qsCompanionSqlCommand.CommandText = ("INSERT INTO dbo.Product(Produce,Location,Quantity,Price,Date_of_Harvest,Phone,
        Date_of_Entry) VALUES(@produce,@location,@qty,@price,@picker,@phone,GETDATE())")
            'Assigning the connection string to Sql Command connection function
            qsCompanionSqlCommand.Connection = qsCompanionSqlString
            'Checks to see if fields are not empty
            If (String.IsNullOrWhiteSpace(ProduceAd.producename.Text) = False And String.IsNullOrWhiteSpace(ProduceAd.location.Text) =
                False And String.IsNullOrWhiteSpace(ProduceAd.qty.Text) = False And String.IsNullOrWhiteSpace(ProduceAd.price.Text) =
                False And String.IsNullOrWhiteSpace(ProduceAd.picker.Text) = False And String.IsNullOrWhiteSpace(ProduceAd.phone.Text) = False) Then
                'Checking to see if the data insertion was successful
                If (qsCompanionSqlCommand.ExecuteNonQuery = 1) Then
                    MessageBox.Show("Your Ad will be live in moments.Thank You.")
                    ProduceAd.producename.Text = ""
                    ProduceAd.location.Text = ""
                    ProduceAd.qty.Text = ""
                    ProduceAd.price.Text = ""
                    ProduceAd.phone.Text = ""
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
        End Try
    End Sub
    '**********************************************
    'Subroutine fills in data into the datagridview
    Public Sub FillDataGridView(ByVal myDatabaseQuery As String, ByVal myDatabaseTable As String, ByVal gridViewToFill As DataGridView)
        Try
            Dim qsCompanionQueryString As String
            'Creating a query string
            qsCompanionQueryString = (myDatabaseQuery)

            Dim qsCompanionSqlAdapter As SqlDataAdapter
            'Setting up the SqlCommand,SqlAdapter & SqlDataSet
            qsCompanionSqlAdapter = New SqlDataAdapter(qsCompanionQueryString, DatabaseConnectionString())
            qsCompanionDataSet = New DataSet()
            qsCompanionSqlCommand = New SqlCommandBuilder(qsCompanionSqlAdapter)

            'Filling up the datagrid view
            qsCompanionSqlAdapter.Fill(qsCompanionDataSet, CStr(LTrim(myDatabaseTable)))
            gridViewToFill.DataSource = qsCompanionDataSet.Tables(CStr(LTrim(myDatabaseTable)))





            'Grabbing the number of database records
            Dim countDatabaseRecords As Integer
            countDatabaseRecords = (gridViewToFill.Rows.Count)
        Catch Ex As Exception
            MessageBox.Show("Oops!!! Unable to reach Server. Try again later.", Ex.Message.ToUpper)
        Finally
            'Closes the datbase connection after use
            If (DatabaseConnectionString.State = ConnectionState.Open) Then
                DatabaseConnectionString.Close()
            End If
        End Try

    End Sub
    'Updates data into the Farmer table in the database 
    Public Sub InsertFarmerData()
        Try
            'Opening the database connection
            If (DatabaseConnectionString.State = ConnectionState.Closed) Then
                qsCompanionSqlString.Open()
            End If
            'Declaring sqlCommand instance & updating the content of the cell
            Dim qsCompanionSqlCommand = New SqlCommand()
            qsCompanionSqlCommand.Parameters.AddWithValue("@lastname", CStr(LTrim(register.farmerlastname.Text)))
            qsCompanionSqlCommand.Parameters.AddWithValue("@firstname", CStr(LTrim(register.farmerfirstname.Text)))
            qsCompanionSqlCommand.Parameters.AddWithValue("@gender", CStr(LTrim(register.farmergender.Text)))
            qsCompanionSqlCommand.Parameters.AddWithValue("@address", CStr(LTrim(register.farmeraddress.Text)))
            qsCompanionSqlCommand.Parameters.AddWithValue("@phone", CStr(LTrim(register.farmerphone.Text)))
            qsCompanionSqlCommand.Parameters.AddWithValue("@email", CStr(LTrim(register.farmeremail.Text)))
            If CStr(LTrim(register.farmerpassword.Text)) = CStr(LTrim(register.farmerpasswordverify.Text)) Then
                qsCompanionSqlCommand.Parameters.AddWithValue("@password", CStr(LTrim(register.farmerpassword.Text)))
                qsCompanionSqlCommand.CommandText = ("INSERT INTO dbo.Farmer(LastName,FirstName,Gender,Address,Phone,Email,Password,entryDate) 
                VALUES(@lastname,@firstname,@gender,@address,@phone,@email,@password,GETDATE())")
                'Assigning the connection string to Sql Command connection function
                qsCompanionSqlCommand.Connection = qsCompanionSqlString
                'Checks to see if fields are not empty
                If (String.IsNullOrWhiteSpace(register.farmerlastname.Text) = False And String.IsNullOrWhiteSpace(register.farmerfirstname.Text) =
                    False And String.IsNullOrWhiteSpace(register.farmergender.Text) = False And String.IsNullOrWhiteSpace(register.farmeraddress.Text) =
                    False And String.IsNullOrWhiteSpace(register.label.Text) = False And String.IsNullOrWhiteSpace(register.label45.Text) =
                    False And String.IsNullOrWhiteSpace(register.farmerpassword.Text) = False) Then
                    'Checking to see if the data insertion was successful
                    If (qsCompanionSqlCommand.ExecuteNonQuery = 1) Then
                        MessageBox.Show("Account was successfully created. Proceed to advertise your produce.Thank You.")
                        register.farmerlastname.Text = ""
                        register.farmerfirstname.Text = ""
                        register.farmergender.Text = ""
                        register.farmeraddress.Text = ""
                        register.farmerphone.Text = ""
                        register.farmeremail.Text = ""
                        register.farmerpassword.Text = ""
                        register.farmerpasswordverify.Text = ""
                        My.Forms.ProduceAd.Show()
                        My.Forms.register.Hide()
                    End If
                End If
            Else
                MessageBox.Show("Passwords do not match.")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
        End Try
    End Sub
    '**********************************************
    'Inserts data into the Middleman table in the database
    Public Sub InsertMiddlemanData()
        Try
            'Opening the database connection
            If (DatabaseConnectionString.State = ConnectionState.Closed) Then
                qsCompanionSqlString.Open()
            End If

            'Declaring sqlCommand instance & updating the content of the cell
            Dim qsCompanionSqlCommand = New SqlCommand()
            qsCompanionSqlCommand.Parameters.AddWithValue("@lastname", CStr(LTrim(register.middlemanlname.Text)))
            qsCompanionSqlCommand.Parameters.AddWithValue("@firstname", CStr(LTrim(register.middlemanfname.Text)))
            qsCompanionSqlCommand.Parameters.AddWithValue("@gender", CStr(LTrim(register.middlemangender.Text)))
            qsCompanionSqlCommand.Parameters.AddWithValue("@address", CStr(LTrim(register.middlemanaddress.Text)))
            qsCompanionSqlCommand.Parameters.AddWithValue("@phone", CStr(LTrim(register.middlemanphone.Text)))
            qsCompanionSqlCommand.Parameters.AddWithValue("@email", CStr(LTrim(register.middlemanemail.Text)))
            qsCompanionSqlCommand.Parameters.AddWithValue("@product", CStr(LTrim(register.produce.Text)))
            If CStr(LTrim(register.middlemanpassword.Text)) = CStr(LTrim(register.middlemanpasswordverify.Text)) Then
                qsCompanionSqlCommand.Parameters.AddWithValue("@password", CStr(LTrim(register.middlemanpassword.Text)))
                qsCompanionSqlCommand.CommandText = ("INSERT INTO dbo.Middleman(LastName,FirstName,Gender,Address,Phone,Email,Password,Produce_Dealings,
                entryDate) VALUES(@lastname,@firstname,@gender,@address,@phone,@email,@password,@product,GETDATE())")
                'Assigning the connection string to Sql Command connection function
                qsCompanionSqlCommand.Connection = qsCompanionSqlString
                'Checks to see if fields are not empty
                If (String.IsNullOrWhiteSpace(register.middlemanlname.Text) = False And String.IsNullOrWhiteSpace(register.middlemanfname.Text) =
                    False And String.IsNullOrWhiteSpace(register.middlemangender.Text) = False And String.IsNullOrWhiteSpace(register.middlemanaddress.Text) =
                    False And String.IsNullOrWhiteSpace(register.middlemanphone.Text) = False And String.IsNullOrWhiteSpace(register.middlemanemail.Text) =
                    False And String.IsNullOrWhiteSpace(register.middlemanpassword.Text) = False) Then
                    'Checking to see if the data insertion was successful
                    If (qsCompanionSqlCommand.ExecuteNonQuery = 1) Then
                        MessageBox.Show("Account was created successfully. Thank you.")
                        register.middlemanlname.Text = ""
                        register.middlemanfname.Text = ""
                        register.middlemangender.Text = ""
                        register.middlemanaddress.Text = ""
                        register.middlemanphone.Text = ""
                        register.middlemanemail.Text = ""
                        register.middlemanpassword.Text = ""
                        register.middlemanpasswordverify.Text = ""
                        register.produce.Text = ""
                        My.Forms.Home.Show()
                        My.Forms.register.Hide()

                    End If
                End If
            Else
                MessageBox.Show("Passwords do not match.")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

        End Try

    End Sub
    '**********************************************
    'Inserts data into the company table in the database
    Public Sub InsertCompanyData()
        Try
            'Opening the database connection
            If (DatabaseConnectionString.State = ConnectionState.Closed) Then
                qsCompanionSqlString.Open()
            End If

            'Declaring sqlCommand instance & updating the content of the cell
            Dim qsCompanionSqlCommand = New SqlCommand()
            qsCompanionSqlCommand.Parameters.AddWithValue("@cname", CStr(LTrim(register.companyname.Text)))
            qsCompanionSqlCommand.Parameters.AddWithValue("@caddress", CStr(LTrim(register.companyaddress.Text)))
            qsCompanionSqlCommand.Parameters.AddWithValue("@cphone1", CStr(LTrim(register.cphone1.Text)))
            qsCompanionSqlCommand.Parameters.AddWithValue("@cphone2", CStr(LTrim(register.cphone2.Text)))
            qsCompanionSqlCommand.Parameters.AddWithValue("@cemail", CStr(LTrim(register.cemail.Text)))
            qsCompanionSqlCommand.Parameters.AddWithValue("@cproduce", CStr(LTrim(register.product.Text)))
            If CStr(LTrim(register.cpassword.Text)) = CStr(LTrim(register.cpasswordverify.Text)) Then
                qsCompanionSqlCommand.Parameters.AddWithValue("@cpassword", CStr(LTrim(register.cpassword.Text)))
                qsCompanionSqlCommand.CommandText = ("INSERT INTO dbo.Company([Company Name],Address,[Office Phone],
        [Office Phone(Optional)],Email,Password,[Produce Dealings],entryDate) VALUES(@cname,@caddress,@cphone1,@cphone2,@cemail,@cpassword
        ,@cproduce,GETDATE())")
                'Assigning the connection string to Sql Command connection function
                qsCompanionSqlCommand.Connection = qsCompanionSqlString
                'Checks to see if fields are not empty
                If (String.IsNullOrWhiteSpace(register.companyname.Text) = False And String.IsNullOrWhiteSpace(register.companyaddress.Text) =
                    False And String.IsNullOrWhiteSpace(register.cphone1.Text) = False And String.IsNullOrWhiteSpace(register.cphone2.Text) =
                    False And String.IsNullOrWhiteSpace(register.cemail.Text) = False And String.IsNullOrWhiteSpace(register.cpassword.Text) = False) Then
                    'Checking to see if the data insertion was successful
                    If (qsCompanionSqlCommand.ExecuteNonQuery = 1) Then
                        MessageBox.Show("Account was created successfully. Thank You.")
                        register.companyname.Text = ""
                        register.companyaddress.Text = ""
                        register.cphone1.Text = ""
                        register.cphone2.Text = ""
                        register.cemail.Text = ""
                        register.cpassword.Text = ""
                        register.cpasswordverify.Text = ""
                        register.product.Text = ""

                        My.Forms.Home.Show()
                        My.Forms.register.Hide()

                    End If
                End If
            Else
                MessageBox.Show("Passwords do not match.")

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

        End Try

    End Sub
    '***********************Login Form Actions***********************
    'This subroutine checks the login credentials provided by the user 
    'and logs them in if the parameters are correct
    Public Sub LogUserIn(ByVal command As String)

        Try
            'Opening the database connection
            If (DatabaseConnectionString.State = ConnectionState.Closed) Then
                qsCompanionSqlString.Open()
            End If
            'Comparing credentials entered by the user and the one in the database
            Dim qsCompanionSqlCommand = New SqlCommand(command, DatabaseConnectionString)
            qsCompanionSqlCommand.Parameters.Add("@email", SqlDbType.VarChar).Value = CStr(LTrim(LOGIN.emaillogin.Text))
            qsCompanionSqlCommand.Parameters.Add("@password", SqlDbType.VarChar).Value = CStr(LTrim(LOGIN.passwordlogin.Text))
            Dim table As New DataTable()
            Dim adapter As New SqlDataAdapter(qsCompanionSqlCommand)
            adapter.Fill(table)

            If table.Rows.Count() <= 0 Then
                MessageBox.Show("Check the appopriate radio button and Try Again. ")
            Else
                My.Forms.LOGIN.Hide()
                My.Forms.HomeLoggedIn.Show()
                HomeLoggedIn.user.Text = CStr(LTrim(LOGIN.emaillogin.Text))
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

        End Try


    End Sub
    '**********************************************
    'Inserts data into the market table in the database
    Public Sub InsertMarketData()
        Try
            'Opening the database connection
            If (DatabaseConnectionString.State = ConnectionState.Closed) Then
                qsCompanionSqlString.Open()
            End If
            'Declaring sqlCommand instance & updating the content of the cell
            Dim qsCompanionSqlCommand = New SqlCommand()
            qsCompanionSqlCommand.Parameters.AddWithValue("@mname", CStr(LTrim(register.mname.Text)))
            qsCompanionSqlCommand.Parameters.AddWithValue("@mlocation", CStr(LTrim(register.mlocation.Text)))
            qsCompanionSqlCommand.Parameters.AddWithValue("@mcity", CStr(LTrim(register.city.Text)))
            qsCompanionSqlCommand.Parameters.AddWithValue("@mregion", CStr(LTrim(register.region.Text)))
            qsCompanionSqlCommand.CommandText = ("INSERT INTO dbo.Market([Market Name],Location,
`             [City/Town],Region,EntryDate) VALUES(@mname,@mlocation,@mcity,@mregion,GETDATE())")
            'Assigning the connection string to Sql Command connection function
            qsCompanionSqlCommand.Connection = qsCompanionSqlString
            'Checks to see if fields are not empty
            If (String.IsNullOrWhiteSpace(register.mname.Text) = False And String.IsNullOrWhiteSpace(register.mlocation.Text) =
                False And String.IsNullOrWhiteSpace(register.city.Text) = False And String.IsNullOrWhiteSpace(register.region.Text) = False) Then
                'Checking to see if the data insertion was successful
                If (qsCompanionSqlCommand.ExecuteNonQuery = 1) Then
                    MessageBox.Show("Market Added Successfully. Thank You.")
                    register.mname.Text = ""
                    register.mlocation.Text = ""
                    register.city.Text = ""
                    register.region.Text = ""
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            'Closes the datbase connection after use
            If (DatabaseConnectionString.State = ConnectionState.Open) Then
                DatabaseConnectionString.Close()
            End If
        End Try
    End Sub
End Class
