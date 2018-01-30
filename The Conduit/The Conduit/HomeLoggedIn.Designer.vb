<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomeLoggedIn
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.producetab = New MetroFramework.Controls.MetroTabPage()
        Me.DataGrid = New MetroFramework.Controls.MetroGrid()
        Me.searchtxt = New System.Windows.Forms.TextBox()
        Me.searchbtn = New MetroFramework.Controls.MetroButton()
        Me.middlementab = New MetroFramework.Controls.MetroTabPage()
        Me.searchtxtmiddle = New System.Windows.Forms.TextBox()
        Me.searchbtnmiddle = New MetroFramework.Controls.MetroButton()
        Me.MiddlemanGrid = New MetroFramework.Controls.MetroGrid()
        Me.companytab = New MetroFramework.Controls.MetroTabPage()
        Me.searchtxtcompany = New System.Windows.Forms.TextBox()
        Me.searchbtncompany = New MetroFramework.Controls.MetroButton()
        Me.companygrid = New MetroFramework.Controls.MetroGrid()
        Me.markets = New MetroFramework.Controls.MetroTabPage()
        Me.mktgrid = New MetroFramework.Controls.MetroGrid()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New MetroFramework.Controls.MetroButton()
        Me.sell = New MetroFramework.Controls.MetroButton()
        Me.user = New MetroFramework.Controls.MetroLabel()
        Me.logout = New MetroFramework.Controls.MetroButton()
        Me.check = New MetroFramework.Controls.MetroButton()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.username = New MetroFramework.Controls.MetroLabel()
        Me.TabControl1.SuspendLayout()
        Me.producetab.SuspendLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.middlementab.SuspendLayout()
        CType(Me.MiddlemanGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.companytab.SuspendLayout()
        CType(Me.companygrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.markets.SuspendLayout()
        CType(Me.mktgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.producetab)
        Me.TabControl1.Controls.Add(Me.middlementab)
        Me.TabControl1.Controls.Add(Me.companytab)
        Me.TabControl1.Controls.Add(Me.markets)
        Me.TabControl1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(7, 95)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(6, 8)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(994, 512)
        Me.TabControl1.TabIndex = 12
        Me.TabControl1.UseSelectable = True
        '
        'producetab
        '
        Me.producetab.Controls.Add(Me.DataGrid)
        Me.producetab.Controls.Add(Me.searchtxt)
        Me.producetab.Controls.Add(Me.searchbtn)
        Me.producetab.Enabled = True
        Me.producetab.HorizontalScrollbarBarColor = True
        Me.producetab.HorizontalScrollbarHighlightOnWheel = False
        Me.producetab.HorizontalScrollbarSize = 10
        Me.producetab.Location = New System.Drawing.Point(4, 38)
        Me.producetab.Name = "producetab"
        Me.producetab.Padding = New System.Windows.Forms.Padding(3)
        Me.producetab.Size = New System.Drawing.Size(986, 470)
        Me.producetab.TabIndex = 0
        Me.producetab.Text = "Produce Tab"
        Me.producetab.UseVisualStyleBackColor = True
        Me.producetab.VerticalScrollbarBarColor = True
        Me.producetab.VerticalScrollbarHighlightOnWheel = False
        Me.producetab.VerticalScrollbarSize = 10
        Me.producetab.Visible = True
        '
        'DataGrid
        '
        Me.DataGrid.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.DataGrid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        Me.DataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.DataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrid.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGrid.EnableHeadersVisualStyles = False
        Me.DataGrid.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.DataGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGrid.Location = New System.Drawing.Point(4, 43)
        Me.DataGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid.Size = New System.Drawing.Size(974, 434)
        Me.DataGrid.Style = MetroFramework.MetroColorStyle.Blue
        Me.DataGrid.TabIndex = 8
        Me.DataGrid.Theme = MetroFramework.MetroThemeStyle.Light
        Me.DataGrid.UseCustomBackColor = True
        Me.DataGrid.UseCustomForeColor = True
        '
        'searchtxt
        '
        Me.searchtxt.HideSelection = False
        Me.searchtxt.Location = New System.Drawing.Point(522, 4)
        Me.searchtxt.Margin = New System.Windows.Forms.Padding(4)
        Me.searchtxt.Name = "searchtxt"
        Me.searchtxt.Size = New System.Drawing.Size(281, 23)
        Me.searchtxt.TabIndex = 4
        '
        'searchbtn
        '
        Me.searchbtn.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchbtn.Location = New System.Drawing.Point(811, 4)
        Me.searchbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.searchbtn.Name = "searchbtn"
        Me.searchbtn.Size = New System.Drawing.Size(167, 28)
        Me.searchbtn.TabIndex = 5
        Me.searchbtn.Text = "Search"
        Me.searchbtn.UseSelectable = True
        Me.searchbtn.UseVisualStyleBackColor = True
        '
        'middlementab
        '
        Me.middlementab.Controls.Add(Me.searchtxtmiddle)
        Me.middlementab.Controls.Add(Me.searchbtnmiddle)
        Me.middlementab.Controls.Add(Me.MiddlemanGrid)
        Me.middlementab.Enabled = True
        Me.middlementab.HorizontalScrollbarBarColor = True
        Me.middlementab.HorizontalScrollbarHighlightOnWheel = False
        Me.middlementab.HorizontalScrollbarSize = 10
        Me.middlementab.Location = New System.Drawing.Point(4, 38)
        Me.middlementab.Name = "middlementab"
        Me.middlementab.Padding = New System.Windows.Forms.Padding(3)
        Me.middlementab.Size = New System.Drawing.Size(986, 470)
        Me.middlementab.TabIndex = 1
        Me.middlementab.Text = "Middlemen Tab"
        Me.middlementab.UseVisualStyleBackColor = True
        Me.middlementab.VerticalScrollbarBarColor = True
        Me.middlementab.VerticalScrollbarHighlightOnWheel = False
        Me.middlementab.VerticalScrollbarSize = 10
        Me.middlementab.Visible = False
        '
        'searchtxtmiddle
        '
        Me.searchtxtmiddle.HideSelection = False
        Me.searchtxtmiddle.Location = New System.Drawing.Point(269, 14)
        Me.searchtxtmiddle.Margin = New System.Windows.Forms.Padding(4)
        Me.searchtxtmiddle.Name = "searchtxtmiddle"
        Me.searchtxtmiddle.Size = New System.Drawing.Size(208, 23)
        Me.searchtxtmiddle.TabIndex = 11
        '
        'searchbtnmiddle
        '
        Me.searchbtnmiddle.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchbtnmiddle.Location = New System.Drawing.Point(485, 14)
        Me.searchbtnmiddle.Margin = New System.Windows.Forms.Padding(4)
        Me.searchbtnmiddle.Name = "searchbtnmiddle"
        Me.searchbtnmiddle.Size = New System.Drawing.Size(108, 28)
        Me.searchbtnmiddle.TabIndex = 12
        Me.searchbtnmiddle.Text = "Search"
        Me.searchbtnmiddle.UseSelectable = True
        Me.searchbtnmiddle.UseVisualStyleBackColor = True
        '
        'MiddlemanGrid
        '
        Me.MiddlemanGrid.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.MiddlemanGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.MiddlemanGrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MiddlemanGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MiddlemanGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MiddlemanGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MiddlemanGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.MiddlemanGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MiddlemanGrid.DefaultCellStyle = DataGridViewCellStyle7
        Me.MiddlemanGrid.EnableHeadersVisualStyles = False
        Me.MiddlemanGrid.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MiddlemanGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MiddlemanGrid.Location = New System.Drawing.Point(12, 54)
        Me.MiddlemanGrid.Name = "MiddlemanGrid"
        Me.MiddlemanGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MiddlemanGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.MiddlemanGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MiddlemanGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MiddlemanGrid.Size = New System.Drawing.Size(644, 432)
        Me.MiddlemanGrid.TabIndex = 10
        '
        'companytab
        '
        Me.companytab.Controls.Add(Me.searchtxtcompany)
        Me.companytab.Controls.Add(Me.searchbtncompany)
        Me.companytab.Controls.Add(Me.companygrid)
        Me.companytab.Enabled = True
        Me.companytab.HorizontalScrollbarBarColor = True
        Me.companytab.HorizontalScrollbarHighlightOnWheel = False
        Me.companytab.HorizontalScrollbarSize = 10
        Me.companytab.Location = New System.Drawing.Point(4, 38)
        Me.companytab.Name = "companytab"
        Me.companytab.Padding = New System.Windows.Forms.Padding(3)
        Me.companytab.Size = New System.Drawing.Size(986, 470)
        Me.companytab.TabIndex = 2
        Me.companytab.Text = "Companies/ Factories Tab"
        Me.companytab.UseVisualStyleBackColor = True
        Me.companytab.VerticalScrollbarBarColor = True
        Me.companytab.VerticalScrollbarHighlightOnWheel = False
        Me.companytab.VerticalScrollbarSize = 10
        Me.companytab.Visible = False
        '
        'searchtxtcompany
        '
        Me.searchtxtcompany.HideSelection = False
        Me.searchtxtcompany.Location = New System.Drawing.Point(310, 24)
        Me.searchtxtcompany.Margin = New System.Windows.Forms.Padding(4)
        Me.searchtxtcompany.Name = "searchtxtcompany"
        Me.searchtxtcompany.Size = New System.Drawing.Size(234, 23)
        Me.searchtxtcompany.TabIndex = 10
        '
        'searchbtncompany
        '
        Me.searchbtncompany.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchbtncompany.Location = New System.Drawing.Point(552, 20)
        Me.searchbtncompany.Margin = New System.Windows.Forms.Padding(4)
        Me.searchbtncompany.Name = "searchbtncompany"
        Me.searchbtncompany.Size = New System.Drawing.Size(115, 28)
        Me.searchbtncompany.TabIndex = 11
        Me.searchbtncompany.Text = "Search"
        Me.searchbtncompany.UseSelectable = True
        Me.searchbtncompany.UseVisualStyleBackColor = True
        '
        'companygrid
        '
        Me.companygrid.AllowUserToResizeRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        Me.companygrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.companygrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.companygrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.companygrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.companygrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.companygrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.companygrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.companygrid.DefaultCellStyle = DataGridViewCellStyle11
        Me.companygrid.EnableHeadersVisualStyles = False
        Me.companygrid.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.companygrid.GridColor = System.Drawing.Color.Silver
        Me.companygrid.Location = New System.Drawing.Point(3, 59)
        Me.companygrid.Name = "companygrid"
        Me.companygrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.companygrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.companygrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.companygrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.companygrid.Size = New System.Drawing.Size(720, 422)
        Me.companygrid.TabIndex = 9
        '
        'markets
        '
        Me.markets.Controls.Add(Me.mktgrid)
        Me.markets.Controls.Add(Me.TextBox1)
        Me.markets.Controls.Add(Me.Button1)
        Me.markets.Enabled = True
        Me.markets.HorizontalScrollbarBarColor = True
        Me.markets.HorizontalScrollbarHighlightOnWheel = False
        Me.markets.HorizontalScrollbarSize = 10
        Me.markets.Location = New System.Drawing.Point(4, 38)
        Me.markets.Name = "markets"
        Me.markets.Padding = New System.Windows.Forms.Padding(3)
        Me.markets.Size = New System.Drawing.Size(986, 470)
        Me.markets.TabIndex = 3
        Me.markets.Text = "Markets Tab"
        Me.markets.UseVisualStyleBackColor = True
        Me.markets.VerticalScrollbarBarColor = True
        Me.markets.VerticalScrollbarHighlightOnWheel = False
        Me.markets.VerticalScrollbarSize = 10
        Me.markets.Visible = False
        '
        'mktgrid
        '
        Me.mktgrid.AllowUserToResizeRows = False
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White
        Me.mktgrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.mktgrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mktgrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mktgrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.mktgrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mktgrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.mktgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.mktgrid.DefaultCellStyle = DataGridViewCellStyle15
        Me.mktgrid.EnableHeadersVisualStyles = False
        Me.mktgrid.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.mktgrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mktgrid.Location = New System.Drawing.Point(6, 54)
        Me.mktgrid.Name = "mktgrid"
        Me.mktgrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mktgrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.mktgrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.mktgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.mktgrid.Size = New System.Drawing.Size(541, 426)
        Me.mktgrid.TabIndex = 8
        '
        'TextBox1
        '
        Me.TextBox1.HideSelection = False
        Me.TextBox1.Location = New System.Drawing.Point(245, 21)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(211, 23)
        Me.TextBox1.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(464, 21)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 28)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Search"
        Me.Button1.UseSelectable = True
        Me.Button1.UseVisualStyleBackColor = True
        '
        'sell
        '
        Me.sell.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sell.Location = New System.Drawing.Point(741, 66)
        Me.sell.Margin = New System.Windows.Forms.Padding(4)
        Me.sell.Name = "sell"
        Me.sell.Size = New System.Drawing.Size(110, 28)
        Me.sell.TabIndex = 14
        Me.sell.Text = "SELL PRODUCE"
        Me.sell.UseSelectable = True
        Me.sell.UseVisualStyleBackColor = True
        '
        'user
        '
        Me.user.AutoSize = True
        Me.user.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user.Location = New System.Drawing.Point(89, 59)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(41, 19)
        Me.user.TabIndex = 17
        Me.user.Text = "Email"
        Me.user.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'logout
        '
        Me.logout.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logout.Location = New System.Drawing.Point(882, 47)
        Me.logout.Name = "logout"
        Me.logout.Size = New System.Drawing.Size(110, 28)
        Me.logout.TabIndex = 19
        Me.logout.Text = "LOGOUT"
        Me.logout.UseSelectable = True
        Me.logout.UseVisualStyleBackColor = True
        '
        'check
        '
        Me.check.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.check.Location = New System.Drawing.Point(619, 66)
        Me.check.Name = "check"
        Me.check.Size = New System.Drawing.Size(115, 28)
        Me.check.TabIndex = 20
        Me.check.Text = "CHECK STANCE"
        Me.check.UseSelectable = True
        Me.check.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 19)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Signed in as"
        '
        'username
        '
        Me.username.AutoSize = True
        Me.username.Location = New System.Drawing.Point(74, 56)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(0, 0)
        Me.username.TabIndex = 16
        '
        'HomeLoggedIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1015, 657)
        Me.Controls.Add(Me.check)
        Me.Controls.Add(Me.logout)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.user)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.sell)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.Name = "HomeLoggedIn"
        Me.Text = "The Conduit"
        Me.TabControl1.ResumeLayout(False)
        Me.producetab.ResumeLayout(False)
        Me.producetab.PerformLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.middlementab.ResumeLayout(False)
        Me.middlementab.PerformLayout()
        CType(Me.MiddlemanGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.companytab.ResumeLayout(False)
        Me.companytab.PerformLayout()
        CType(Me.companygrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.markets.ResumeLayout(False)
        Me.markets.PerformLayout()
        CType(Me.mktgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGrid As MetroFramework.Controls.MetroGrid
    Friend WithEvents searchtxt As TextBox
    Friend WithEvents searchtxtmiddle As TextBox
    Friend WithEvents MiddlemanGrid As MetroFramework.Controls.MetroGrid
    Friend WithEvents searchtxtcompany As TextBox
    Friend WithEvents companygrid As MetroFramework.Controls.MetroGrid
    Friend WithEvents mktgrid As MetroFramework.Controls.MetroGrid
    Friend WithEvents TextBox1 As TextBox
    Private WithEvents TabControl1 As MetroFramework.Controls.MetroTabControl
    Private WithEvents producetab As MetroFramework.Controls.MetroTabPage
    Private WithEvents searchbtn As MetroFramework.Controls.MetroButton
    Private WithEvents middlementab As MetroFramework.Controls.MetroTabPage
    Private WithEvents searchbtnmiddle As MetroFramework.Controls.MetroButton
    Private WithEvents companytab As MetroFramework.Controls.MetroTabPage
    Private WithEvents searchbtncompany As MetroFramework.Controls.MetroButton
    Private WithEvents markets As MetroFramework.Controls.MetroTabPage
    Private WithEvents Button1 As MetroFramework.Controls.MetroButton
    Private WithEvents sell As MetroFramework.Controls.MetroButton
    Private WithEvents logout As MetroFramework.Controls.MetroButton
    Private WithEvents check As MetroFramework.Controls.MetroButton
    Private WithEvents Label1 As MetroFramework.Controls.MetroLabel
    Private WithEvents username As MetroFramework.Controls.MetroLabel
    Public WithEvents user As MetroFramework.Controls.MetroLabel
End Class
