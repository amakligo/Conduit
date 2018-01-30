<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServerDetails
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
        Me.cost = New System.Windows.Forms.TextBox()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.revenue = New System.Windows.Forms.TextBox()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.Button1 = New MetroFramework.Controls.MetroButton()
        Me.Status = New MetroFramework.Controls.MetroLabel()
        Me.details = New MetroFramework.Controls.MetroLabel()
        Me.done = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'cost
        '
        Me.cost.Location = New System.Drawing.Point(5, 149)
        Me.cost.Name = "cost"
        Me.cost.Size = New System.Drawing.Size(151, 20)
        Me.cost.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total Cost(GHC)"
        '
        'revenue
        '
        Me.revenue.Location = New System.Drawing.Point(180, 149)
        Me.revenue.Name = "revenue"
        Me.revenue.Size = New System.Drawing.Size(167, 20)
        Me.revenue.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(177, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Total Revenue (GHC)"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(104, 185)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Check"
        Me.Button1.UseSelectable = True
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Status
        '
        Me.Status.AutoSize = True
        Me.Status.Font = New System.Drawing.Font("Cambria", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status.Location = New System.Drawing.Point(2, 60)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(214, 19)
        Me.Status.TabIndex = 5
        Me.Status.Text = "Check your financial Stance below  "
        '
        'details
        '
        Me.details.AutoSize = True
        Me.details.Location = New System.Drawing.Point(5, 78)
        Me.details.Name = "details"
        Me.details.Size = New System.Drawing.Size(0, 0)
        Me.details.TabIndex = 6
        '
        'done
        '
        Me.done.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.done.Location = New System.Drawing.Point(8, 254)
        Me.done.Name = "done"
        Me.done.Size = New System.Drawing.Size(101, 23)
        Me.done.TabIndex = 7
        Me.done.Text = "DONE"
        Me.done.UseSelectable = True
        Me.done.UseVisualStyleBackColor = True
        '
        'ServerDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 300)
        Me.Controls.Add(Me.done)
        Me.Controls.Add(Me.details)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.revenue)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cost)
        Me.MaximizeBox = False
        Me.Name = "ServerDetails"
        Me.Text = "FINANCIAL STANCE"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.TransparencyKey = System.Drawing.SystemColors.ControlLight
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cost As TextBox
    Friend WithEvents revenue As TextBox
    Private WithEvents Label1 As MetroFramework.Controls.MetroLabel
    Private WithEvents Label2 As MetroFramework.Controls.MetroLabel
    Private WithEvents Button1 As MetroFramework.Controls.MetroButton
    Private WithEvents Status As MetroFramework.Controls.MetroLabel
    Private WithEvents details As MetroFramework.Controls.MetroLabel
    Private WithEvents done As MetroFramework.Controls.MetroButton
End Class
