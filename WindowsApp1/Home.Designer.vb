<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btCustomers = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btProducts = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btCategories = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btTransactions = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.btLogout = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GunaLabel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(528, 65)
        Me.Panel1.TabIndex = 2
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.White
        Me.GunaLabel1.Location = New System.Drawing.Point(229, 20)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(62, 25)
        Me.GunaLabel1.TabIndex = 1
        Me.GunaLabel1.Text = "Home"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btCustomers)
        Me.Panel2.Location = New System.Drawing.Point(303, 91)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(127, 86)
        Me.Panel2.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customers"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btCustomers
        '
        Me.btCustomers.BackgroundImage = Global.InventoryManagement.My.Resources.Resources.icons8_crowd_96
        Me.btCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btCustomers.BorderRadius = 15
        Me.btCustomers.CheckedState.Parent = Me.btCustomers
        Me.btCustomers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btCustomers.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btCustomers.CustomImages.Parent = Me.btCustomers
        Me.btCustomers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btCustomers.FillColor = System.Drawing.Color.Transparent
        Me.btCustomers.FillColor2 = System.Drawing.Color.Transparent
        Me.btCustomers.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btCustomers.ForeColor = System.Drawing.Color.White
        Me.btCustomers.HoverState.Parent = Me.btCustomers
        Me.btCustomers.Location = New System.Drawing.Point(0, 0)
        Me.btCustomers.Name = "btCustomers"
        Me.btCustomers.ShadowDecoration.Parent = Me.btCustomers
        Me.btCustomers.Size = New System.Drawing.Size(127, 86)
        Me.btCustomers.TabIndex = 26
        Me.btCustomers.TextOffset = New System.Drawing.Point(0, 45)
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.btProducts)
        Me.Panel3.Location = New System.Drawing.Point(124, 91)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(97, 86)
        Me.Panel3.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Products"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btProducts
        '
        Me.btProducts.BackgroundImage = Global.InventoryManagement.My.Resources.Resources.icons8_add_shopping_cart_48
        Me.btProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btProducts.BorderRadius = 15
        Me.btProducts.CheckedState.Parent = Me.btProducts
        Me.btProducts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btProducts.CustomImages.Parent = Me.btProducts
        Me.btProducts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btProducts.FillColor = System.Drawing.Color.Transparent
        Me.btProducts.FillColor2 = System.Drawing.Color.Transparent
        Me.btProducts.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btProducts.ForeColor = System.Drawing.Color.White
        Me.btProducts.HoverState.Parent = Me.btProducts
        Me.btProducts.Location = New System.Drawing.Point(0, 0)
        Me.btProducts.Name = "btProducts"
        Me.btProducts.ShadowDecoration.Parent = Me.btProducts
        Me.btProducts.Size = New System.Drawing.Size(97, 86)
        Me.btProducts.TabIndex = 25
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.btCategories)
        Me.Panel4.Location = New System.Drawing.Point(113, 205)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(127, 86)
        Me.Panel4.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Categories"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btCategories
        '
        Me.btCategories.BackgroundImage = Global.InventoryManagement.My.Resources.Resources.icons8_categorize_96
        Me.btCategories.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btCategories.BorderRadius = 15
        Me.btCategories.CheckedState.Parent = Me.btCategories
        Me.btCategories.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btCategories.CustomImages.Parent = Me.btCategories
        Me.btCategories.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btCategories.FillColor = System.Drawing.Color.Transparent
        Me.btCategories.FillColor2 = System.Drawing.Color.Transparent
        Me.btCategories.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btCategories.ForeColor = System.Drawing.Color.White
        Me.btCategories.HoverState.Parent = Me.btCategories
        Me.btCategories.Location = New System.Drawing.Point(0, 0)
        Me.btCategories.Name = "btCategories"
        Me.btCategories.ShadowDecoration.Parent = Me.btCategories
        Me.btCategories.Size = New System.Drawing.Size(127, 86)
        Me.btCategories.TabIndex = 30
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.btTransactions)
        Me.Panel5.Location = New System.Drawing.Point(303, 205)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(127, 86)
        Me.Panel5.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Transactions"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btTransactions
        '
        Me.btTransactions.BackgroundImage = Global.InventoryManagement.My.Resources.Resources.icons8_billing_machine_96
        Me.btTransactions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btTransactions.BorderRadius = 15
        Me.btTransactions.CheckedState.Parent = Me.btTransactions
        Me.btTransactions.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btTransactions.CustomImages.Parent = Me.btTransactions
        Me.btTransactions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btTransactions.FillColor = System.Drawing.Color.Transparent
        Me.btTransactions.FillColor2 = System.Drawing.Color.Transparent
        Me.btTransactions.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btTransactions.ForeColor = System.Drawing.Color.White
        Me.btTransactions.HoverState.Parent = Me.btTransactions
        Me.btTransactions.Location = New System.Drawing.Point(0, 0)
        Me.btTransactions.Name = "btTransactions"
        Me.btTransactions.ShadowDecoration.Parent = Me.btTransactions
        Me.btTransactions.Size = New System.Drawing.Size(127, 86)
        Me.btTransactions.TabIndex = 31
        '
        'btLogout
        '
        Me.btLogout.BorderRadius = 15
        Me.btLogout.CheckedState.Parent = Me.btLogout
        Me.btLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btLogout.CustomImages.Parent = Me.btLogout
        Me.btLogout.FillColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btLogout.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btLogout.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btLogout.ForeColor = System.Drawing.Color.White
        Me.btLogout.HoverState.Parent = Me.btLogout
        Me.btLogout.Location = New System.Drawing.Point(203, 7)
        Me.btLogout.Name = "btLogout"
        Me.btLogout.ShadowDecoration.Parent = Me.btLogout
        Me.btLogout.Size = New System.Drawing.Size(122, 26)
        Me.btLogout.TabIndex = 45
        Me.btLogout.Text = "Logout"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Panel6.Controls.Add(Me.btLogout)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 315)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(528, 40)
        Me.Panel6.TabIndex = 46
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(528, 355)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btCustomers As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents btProducts As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents btTransactions As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents btCategories As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btLogout As Guna.UI2.WinForms.Guna2GradientTileButton
End Class
