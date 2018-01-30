<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOGIN
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
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.Button1 = New MetroFramework.Controls.MetroButton()
        Me.emaillogin = New System.Windows.Forms.TextBox()
        Me.passwordlogin = New System.Windows.Forms.TextBox()
        Me.farmerradio = New MetroFramework.Controls.MetroRadioButton()
        Me.middlemanradio = New MetroFramework.Controls.MetroRadioButton()
        Me.companyradio = New MetroFramework.Controls.MetroRadioButton()
        Me.back = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(272, 280)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EMAIL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(272, 336)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PASSWORD"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(408, 419)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "LOG IN"
        Me.Button1.UseSelectable = True
        Me.Button1.UseVisualStyleBackColor = True
        '
        'emaillogin
        '
        Me.emaillogin.Location = New System.Drawing.Point(370, 280)
        Me.emaillogin.Name = "emaillogin"
        Me.emaillogin.Size = New System.Drawing.Size(215, 20)
        Me.emaillogin.TabIndex = 3
        '
        'passwordlogin
        '
        Me.passwordlogin.Location = New System.Drawing.Point(370, 336)
        Me.passwordlogin.Name = "passwordlogin"
        Me.passwordlogin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordlogin.Size = New System.Drawing.Size(215, 20)
        Me.passwordlogin.TabIndex = 4
        '
        'farmerradio
        '
        Me.farmerradio.AutoSize = True
        Me.farmerradio.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.farmerradio.Location = New System.Drawing.Point(364, 224)
        Me.farmerradio.Name = "farmerradio"
        Me.farmerradio.Size = New System.Drawing.Size(60, 15)
        Me.farmerradio.TabIndex = 5
        Me.farmerradio.TabStop = True
        Me.farmerradio.Text = "Farmer"
        Me.farmerradio.UseSelectable = True
        Me.farmerradio.UseVisualStyleBackColor = True
        '
        'middlemanradio
        '
        Me.middlemanradio.AutoSize = True
        Me.middlemanradio.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.middlemanradio.Location = New System.Drawing.Point(435, 224)
        Me.middlemanradio.Name = "middlemanradio"
        Me.middlemanradio.Size = New System.Drawing.Size(84, 15)
        Me.middlemanradio.TabIndex = 6
        Me.middlemanradio.TabStop = True
        Me.middlemanradio.Text = "Middleman"
        Me.middlemanradio.UseSelectable = True
        Me.middlemanradio.UseVisualStyleBackColor = True
        '
        'companyradio
        '
        Me.companyradio.AutoSize = True
        Me.companyradio.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.companyradio.Location = New System.Drawing.Point(529, 224)
        Me.companyradio.Name = "companyradio"
        Me.companyradio.Size = New System.Drawing.Size(75, 15)
        Me.companyradio.TabIndex = 7
        Me.companyradio.TabStop = True
        Me.companyradio.Text = "Company"
        Me.companyradio.UseSelectable = True
        Me.companyradio.UseVisualStyleBackColor = True
        '
        'back
        '
        Me.back.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back.Location = New System.Drawing.Point(11, 63)
        Me.back.Name = "back"
        Me.back.TabIndex = 8
        Me.back.Text = "BACK"
        Me.back.UseSelectable = True
        Me.back.UseVisualStyleBackColor = True
        '
        'LOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1015, 657)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.companyradio)
        Me.Controls.Add(Me.middlemanradio)
        Me.Controls.Add(Me.farmerradio)
        Me.Controls.Add(Me.passwordlogin)
        Me.Controls.Add(Me.emaillogin)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "LOGIN"
        Me.Resizable = False
        Me.Text = "LOGIN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents emaillogin As TextBox
    Friend WithEvents passwordlogin As TextBox
    Private WithEvents Label1 As MetroFramework.Controls.MetroLabel
    Private WithEvents Label2 As MetroFramework.Controls.MetroLabel
    Private WithEvents Button1 As MetroFramework.Controls.MetroButton
    Private WithEvents farmerradio As MetroFramework.Controls.MetroRadioButton
    Private WithEvents middlemanradio As MetroFramework.Controls.MetroRadioButton
    Private WithEvents companyradio As MetroFramework.Controls.MetroRadioButton
    Private WithEvents back As MetroFramework.Controls.MetroButton
End Class
