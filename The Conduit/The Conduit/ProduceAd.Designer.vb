<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProduceAd
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.producename = New System.Windows.Forms.TextBox()
        Me.location = New System.Windows.Forms.TextBox()
        Me.qty = New System.Windows.Forms.TextBox()
        Me.price = New System.Windows.Forms.TextBox()
        Me.Produce = New MetroFramework.Controls.MetroLabel()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.Label5 = New MetroFramework.Controls.MetroLabel()
        Me.sellbtn = New MetroFramework.Controls.MetroButton()
        Me.Button2 = New MetroFramework.Controls.MetroButton()
        Me.phone = New System.Windows.Forms.TextBox()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.photo = New System.Windows.Forms.PictureBox()
        Me.picker = New MetroFramework.Controls.MetroDateTime()
        CType(Me.photo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'producename
        '
        Me.producename.Location = New System.Drawing.Point(375, 119)
        Me.producename.Name = "producename"
        Me.producename.Size = New System.Drawing.Size(288, 20)
        Me.producename.TabIndex = 0
        '
        'location
        '
        Me.location.Location = New System.Drawing.Point(375, 175)
        Me.location.Name = "location"
        Me.location.Size = New System.Drawing.Size(291, 20)
        Me.location.TabIndex = 1
        '
        'qty
        '
        Me.qty.Location = New System.Drawing.Point(375, 231)
        Me.qty.Name = "qty"
        Me.qty.Size = New System.Drawing.Size(291, 20)
        Me.qty.TabIndex = 2
        '
        'price
        '
        Me.price.Location = New System.Drawing.Point(375, 292)
        Me.price.Name = "price"
        Me.price.Size = New System.Drawing.Size(291, 20)
        Me.price.TabIndex = 3
        '
        'Produce
        '
        Me.Produce.AutoSize = True
        Me.Produce.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Produce.Location = New System.Drawing.Point(375, 92)
        Me.Produce.Name = "Produce"
        Me.Produce.Size = New System.Drawing.Size(70, 19)
        Me.Produce.TabIndex = 5
        Me.Produce.Text = "PRODUCE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(375, 154)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(233, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "LOCATION ( Include Region,Town/City)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(375, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "QUANTITY"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(375, 270)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "PRICE (GHC)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(375, 323)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "DATE OF HARVEST"
        '
        'sellbtn
        '
        Me.sellbtn.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sellbtn.Location = New System.Drawing.Point(434, 491)
        Me.sellbtn.Name = "sellbtn"
        Me.sellbtn.Size = New System.Drawing.Size(232, 40)
        Me.sellbtn.TabIndex = 12
        Me.sellbtn.Text = "SELL PRODUCE"
        Me.sellbtn.UseSelectable = True
        Me.sellbtn.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(23, 63)
        Me.Button2.Name = "Button2"
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "BACK"
        Me.Button2.UseSelectable = True
        Me.Button2.UseVisualStyleBackColor = True
        '
        'phone
        '
        Me.phone.Location = New System.Drawing.Point(375, 397)
        Me.phone.Name = "phone"
        Me.phone.Size = New System.Drawing.Size(291, 20)
        Me.phone.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(372, 376)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 19)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "PHONE(Enter same phone as registration)"
        '
        'photo
        '
        Me.photo.Location = New System.Drawing.Point(23, 110)
        Me.photo.Name = "photo"
        Me.photo.Size = New System.Drawing.Size(307, 273)
        Me.photo.TabIndex = 17
        Me.photo.TabStop = False
        '
        'picker
        '
        Me.picker.Location = New System.Drawing.Point(375, 341)
        Me.picker.MinimumSize = New System.Drawing.Size(0, 29)
        Me.picker.Name = "picker"
        Me.picker.Size = New System.Drawing.Size(291, 29)
        Me.picker.TabIndex = 18
        '
        'ProduceAd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1015, 657)
        Me.Controls.Add(Me.picker)
        Me.Controls.Add(Me.photo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.phone)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.sellbtn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Produce)
        Me.Controls.Add(Me.price)
        Me.Controls.Add(Me.qty)
        Me.Controls.Add(Me.location)
        Me.Controls.Add(Me.producename)
        Me.MinimizeBox = False
        Me.Name = "ProduceAd"
        Me.Text = "Advertise Produce"
        CType(Me.photo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents producename As TextBox
    Friend WithEvents location As TextBox
    Friend WithEvents qty As TextBox
    Friend WithEvents price As TextBox
    Friend WithEvents phone As TextBox
    Friend WithEvents photo As PictureBox
    Friend WithEvents picker As MetroFramework.Controls.MetroDateTime
    Private WithEvents Produce As MetroFramework.Controls.MetroLabel
    Private WithEvents Label2 As MetroFramework.Controls.MetroLabel
    Private WithEvents Label3 As MetroFramework.Controls.MetroLabel
    Private WithEvents Label4 As MetroFramework.Controls.MetroLabel
    Private WithEvents Label5 As MetroFramework.Controls.MetroLabel
    Private WithEvents sellbtn As MetroFramework.Controls.MetroButton
    Private WithEvents Button2 As MetroFramework.Controls.MetroButton
    Private WithEvents Label1 As MetroFramework.Controls.MetroLabel
End Class
