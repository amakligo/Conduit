Imports System.Data.SqlClient

Public Class Home
    Private Toolbox As New Toolbox
    Private Sub signin_Click(sender As Object, e As EventArgs) Handles signin.Click
        My.Forms.Home.Hide()
        My.Forms.LOGIN.Show()

    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection = New SqlConnection("Data Source=localhost\SQLEXPRESS;Trusted_Connection=True")
        connection.Open()
        Dim command = New SqlCommand
        Dim co = New SqlCommand
        command = connection.CreateCommand()
        command.CommandText = "USE [Conduit_Database]
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Company')
BEGIN
CREATE TABLE [dbo].[Company](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Company Name] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[Office Phone] [varchar](50) NULL,
	[Office Phone(Optional)] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Produce Dealings] [varchar](50) NULL,
	[entryDate] [datetime] NULL,
 CONSTRAINT [PK_Comapny] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

INSERT INTO [dbo].[Company]
           ([Company Name]
           ,[Address]
           ,[Office Phone]
           ,[Office Phone(Optional)]
           ,[Email]
           ,[Password]
           ,[Produce Dealings]
           ,[entryDate])
     VALUES
           ('Centex Group','Adenta','0540000567','0540000567','centexg@gmail.com','centex','Pepper',GETDATE()),
		    ('Arken Group','Madina','0540200067','0540900557','arkhen@gmail.com','arken','Garden Egg',GETDATE()),
		    ('Padi Group','Jason','0540004067','0540900557','padi@gmail.com','padi','Cabbage',GETDATE()),
		    ('Selorm Group','Accra','0540670067','0549000557','selorm@gmail.com','selorm','Okro',GETDATE()),
		    ('Vincent Inc.','Hill view','0540000067','0540000557','arkhen@gmail.com','arken','Onion',GETDATE())
END
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Farmer' )
BEGIN
	CREATE TABLE [dbo].[Farmer](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[LastName] [varchar](50) NULL,
	[FirstName] [varchar](50) NULL,
	[Gender] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[Phone] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[entryDate] [datetime] NULL,
 CONSTRAINT [PK_Farmer] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
	
	INSERT INTO [dbo].[Farmer]
           ([LastName]
           ,[FirstName]
           ,[Gender]
           ,[Address]
           ,[Phone]
           ,[Email]
           ,[Password]
           ,[entryDate])
     VALUES
           ('Akligo','Alfred','Male','Adenta','0262104899','amakligo@gmail.com','amakligo',GETDATE()),
		   ('Amu','Shadrach Padi','Male','Kasoa','0572105091','spamu@gmail.com','spamu',GETDATE()),
		   ('Pappoe','Daniel','Male','Dansoman','0202189899','dpappoe@gmail.com','dpappoe',GETDATE()),
		   ('Damali','Russell','Male','West Legon','0242104809','rdamali@gmail.com','rdamali',GETDATE()),
		   ('Sentinel','Mawutor','Male','Abelemkpe','0209104899','smawutor@gmail.com','smawutor',GETDATE())
END

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Market' )
BEGIN
CREATE TABLE [dbo].[Market](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Market Name] [varchar](100) NOT NULL,
	[Location] [varchar](500) NOT NULL,
	[City/Town] [varchar](50) NOT NULL,
	[Region] [varchar](50) NOT NULL,
	[EntryDate] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Market] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


INSERT INTO [dbo].[Market]
           ([Market Name]
           ,[Location]
           ,[City/Town]
           ,[Region]
           ,[EntryDate])
     VALUES
           ('Agbogloshie','Kanda','Accra','Greater Accra Region',GETDATE()),
		    ('Night Market','Legon','Madina','Greater Accra Region',GETDATE()),
			 ('Asigame','OLA Junction','Ho','Volta Region',GETDATE()),
			  ('Bush Market','East Legon','Accra','Greater Accra',GETDATE()),
			   ('Mawuve Market','District Hospital','Akatsi','Volta Region',GETDATE())
END
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Middleman')
BEGIN
CREATE TABLE [dbo].[Middleman](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[LastName] [varchar](50) NULL,
	[FirstName] [varchar](50) NULL,
	[Gender] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[Phone] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Produce_Dealings] [varchar](50) NULL,
	[entryDate] [datetime] NULL,
 CONSTRAINT [PK_Middleman] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
	
	INSERT INTO [dbo].[Middleman]
           ([LastName]
           ,[FirstName]
           ,[Gender]
           ,[Address]
           ,[Phone]
           ,[Email]
           ,[Password]
           ,[Produce_Dealings]
           ,[entryDate])
     VALUES
            ('Akligo','Alfred','Male','Adenta','0262104899','amakligo@gmail.com','amakligo','Onion',GETDATE()),
		   ('Amu','Shadrach Padi','Male','Kasoa','0572105091','spamu@gmail.com','spamu','Ginger',GETDATE()),
		   ('Pappoe','Daniel','Male','Dansoman','0202189899','dpappoe@gmail.com','dpappoe','Tomatoes',GETDATE()),
		   ('Damali','Russell','Male','West Legon','0242104809','rdamali@gmail.com','rdamali','Garden Eggs',GETDATE()),
		   ('Sentinel','Mawutor','Male','Abelemkpe','0209104899','smawutor@gmail.com','smawutor','Pepper',GETDATE())
END
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Product')
BEGIN
CREATE TABLE [dbo].[Product](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Produce] [varchar](50) NOT NULL,
	[Location] [varchar](50) NULL,
	[Quantity] [varchar](50) NOT NULL,
	[Price] [varchar](50) NOT NULL,
	[Date_of_Harvest] [date] NOT NULL,
	[Phone] [varchar](50) NOT NULL,
	[Date_of_Entry] [date] NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

INSERT INTO [dbo].[Product]
           ([Produce]
           ,[Location]
           ,[Quantity]
           ,[Price]
           ,[Date_of_Harvest]
           ,[Phone]
           ,[Date_of_Entry])
     VALUES
           ('Tomatoes','Adenta','30 baskets','900',GETDATE(),'0262104899',GETDATE()),
		   ('Ginger','Kasoa','49 sacks','80',GETDATE(),'0572105091',GETDATE()),
		   ('Onion','Dasoman','15 crates','100',GETDATE(),'0202189899',GETDATE()),
		   ('Maize','Akatsi','88 sacks','700',GETDATE(),'0242104809',GETDATE()),
		   ('Cowpea','Ho','1090 barrels','1000',GETDATE(),'0209104899',GETDATE())
END"
        command.ExecuteNonQuery()

        Toolbox.FillDataGridView("select Produce,Location,Quantity,Price,Date_of_Harvest,Farmer.LastName,Farmer.FirstName,Farmer.Email,Farmer.Phone from Product,Farmer  Where Farmer.Phone=Product.Phone and Product.ID>0 ORDER BY Product.ID desc", "Product", DataGrid)
        Toolbox.FillDataGridView("select FirstName,LastName,Produce_Dealings,Phone,Email from Middleman Where ID>0 ORDER BY ID desc", "Middleman", MiddlemanGrid)
        Toolbox.FillDataGridView("select [Market Name],Location,[City/Town],Region,EntryDate from Market Where ID>0 ORDER BY ID desc", "Market", mktgrid)

        Toolbox.FillDataGridView("select [Company Name],[Produce Dealings],Address,[Office Phone],[Office Phone(Optional)],Email from Company Where ID>0 ORDER BY ID desc", "Company", companygrid)
    End Sub

    Private Sub sell_Click(sender As Object, e As EventArgs)
        My.Forms.Home.Hide()
        My.Forms.ProduceAd.Show()
    End Sub

    Private Sub register_Click(sender As Object, e As EventArgs) Handles register.Click
        My.Forms.Home.Hide()
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
        Toolbox.FillDataGridView("select FirstName,LastName,Produce_Dealings,Phone,Email from Middleman Where ID>0 ORDER BY ID desc", "Middleman", MiddlemanGrid)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles searchbtnmiddle.Click
        Toolbox.FillDataGridView("select FirstName,LastName,Produce_Dealings,Phone,Email from Middleman Where FirstName ='" + CStr(LTrim(searchtxtmiddle.Text)) + "'" + " or Gender ='" + CStr(LTrim(searchtxtmiddle.Text)) + "'" + " or LastName ='" + CStr(LTrim(searchtxtmiddle.Text)) + "'" + " or Phone ='" + CStr(LTrim(searchtxtmiddle.Text)) + "'" + " or Address ='" + CStr(LTrim(searchtxtmiddle.Text)) + "'" + " or Email ='" + CStr(LTrim(searchtxtmiddle.Text)) + "'" + "or Produce_Dealings='" + CStr(LTrim(searchtxtmiddle.Text)) + "'", "@search", MiddlemanGrid)
        If (searchtxtmiddle.Text = "") Then
            Toolbox.FillDataGridView("select FirstName,LastName,Produce_Dealings,Phone,Email from Middleman Where ID>0 ORDER BY ID desc", "Middleman", MiddlemanGrid)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles searchbtncompany.Click
        Toolbox.FillDataGridView("select [Company Name],[Produce Dealings],Address,[Office Phone],[Office Phone(Optional)],Email from Company Where [Company Name] ='" + CStr(LTrim(searchtxtcompany.Text)) + "'" + " or Address ='" + CStr(LTrim(searchtxtcompany.Text)) + "'" + " or [Office Phone] ='" + CStr(LTrim(searchtxtcompany.Text)) + "'" + " or [Office Phone(Optional)] ='" + CStr(LTrim(searchtxtcompany.Text)) + "'" + " or Email ='" + CStr(LTrim(searchtxtcompany.Text)) + "'" + "or [Produce Dealings]='" + CStr(LTrim(searchtxtcompany.Text)) + "'", "@search", companygrid)
        If (searchtxtmiddle.Text = "") Then
            Toolbox.FillDataGridView("select [Company Name],[Produce Dealings],Address,[Office Phone],[Office Phone(Optional)],Email from Company Where ID>0 ORDER BY ID desc", "Company", companygrid)
        End If
    End Sub

    Private Sub searchtxt_TextChanged(sender As Object, e As EventArgs) Handles searchtxt.TextChanged
        Toolbox.FillDataGridView("select Produce,Location,Quantity,Price,Date_of_Harvest,Farmer.LastName,Farmer.FirstName,Farmer.Email,Farmer.Phone from Product,Farmer  Where Farmer.Phone=Product.Phone and Product.ID>0 ORDER BY Product.ID desc", "Product", DataGrid)
    End Sub

    Private Sub searchtxtcompany_TextChanged(sender As Object, e As EventArgs) Handles searchtxtcompany.TextChanged
        Toolbox.FillDataGridView("select [Company Name],[Produce Dealings],Address,[Office Phone],[Office Phone(Optional)],Email from Company Where ID>0 ORDER BY ID desc", "Company", companygrid)
    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Toolbox.FillDataGridView("select [Market Name],Location,[City/Town],Region,EntryDate from Market Where ID>0 ORDER BY ID desc", "Market", mktgrid)
    End Sub
End Class