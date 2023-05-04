<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProdEditForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.cb_Category = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lb_Category = New System.Windows.Forms.Label()
        Me.tb_Description = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lb_Description = New System.Windows.Forms.Label()
        Me.tb_ProdName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lb_ProdName = New System.Windows.Forms.Label()
        Me.tb_Price = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lb_Price = New System.Windows.Forms.Label()
        Me.tb_Quantity = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lb_Quantity = New System.Windows.Forms.Label()
        Me.btUpdate = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.btCancel = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.btClear = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GunaLabel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(544, 65)
        Me.Panel1.TabIndex = 1
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.White
        Me.GunaLabel1.Location = New System.Drawing.Point(206, 22)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(115, 25)
        Me.GunaLabel1.TabIndex = 1
        Me.GunaLabel1.Text = "Edit Product"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 365)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(544, 29)
        Me.FlowLayoutPanel2.TabIndex = 2
        '
        'cb_Category
        '
        Me.cb_Category.BackColor = System.Drawing.Color.Transparent
        Me.cb_Category.BorderRadius = 15
        Me.cb_Category.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cb_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Category.FocusedColor = System.Drawing.Color.Empty
        Me.cb_Category.FocusedState.Parent = Me.cb_Category
        Me.cb_Category.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cb_Category.ForeColor = System.Drawing.Color.Black
        Me.cb_Category.FormattingEnabled = True
        Me.cb_Category.HoverState.Parent = Me.cb_Category
        Me.cb_Category.ItemHeight = 30
        Me.cb_Category.Items.AddRange(New Object() {"Perfume", "Soaps", "Beauty Products"})
        Me.cb_Category.ItemsAppearance.Parent = Me.cb_Category
        Me.cb_Category.Location = New System.Drawing.Point(167, 177)
        Me.cb_Category.Name = "cb_Category"
        Me.cb_Category.ShadowDecoration.Parent = Me.cb_Category
        Me.cb_Category.Size = New System.Drawing.Size(344, 36)
        Me.cb_Category.TabIndex = 15
        Me.cb_Category.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lb_Category
        '
        Me.lb_Category.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Category.ForeColor = System.Drawing.Color.White
        Me.lb_Category.Location = New System.Drawing.Point(36, 177)
        Me.lb_Category.Name = "lb_Category"
        Me.lb_Category.Size = New System.Drawing.Size(125, 36)
        Me.lb_Category.TabIndex = 18
        Me.lb_Category.Text = "Category:"
        Me.lb_Category.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tb_Description
        '
        Me.tb_Description.BorderRadius = 15
        Me.tb_Description.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_Description.DefaultText = ""
        Me.tb_Description.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_Description.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_Description.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_Description.DisabledState.Parent = Me.tb_Description
        Me.tb_Description.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_Description.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_Description.FocusedState.Parent = Me.tb_Description
        Me.tb_Description.ForeColor = System.Drawing.Color.Black
        Me.tb_Description.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_Description.HoverState.Parent = Me.tb_Description
        Me.tb_Description.Location = New System.Drawing.Point(167, 135)
        Me.tb_Description.Name = "tb_Description"
        Me.tb_Description.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_Description.PlaceholderText = ""
        Me.tb_Description.SelectedText = ""
        Me.tb_Description.ShadowDecoration.Parent = Me.tb_Description
        Me.tb_Description.Size = New System.Drawing.Size(344, 36)
        Me.tb_Description.TabIndex = 14
        Me.tb_Description.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lb_Description
        '
        Me.lb_Description.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Description.ForeColor = System.Drawing.Color.White
        Me.lb_Description.Location = New System.Drawing.Point(36, 135)
        Me.lb_Description.Name = "lb_Description"
        Me.lb_Description.Size = New System.Drawing.Size(125, 36)
        Me.lb_Description.TabIndex = 17
        Me.lb_Description.Text = "Description:"
        Me.lb_Description.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tb_ProdName
        '
        Me.tb_ProdName.BorderRadius = 15
        Me.tb_ProdName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_ProdName.DefaultText = ""
        Me.tb_ProdName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_ProdName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_ProdName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_ProdName.DisabledState.Parent = Me.tb_ProdName
        Me.tb_ProdName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_ProdName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_ProdName.FocusedState.Parent = Me.tb_ProdName
        Me.tb_ProdName.ForeColor = System.Drawing.Color.Black
        Me.tb_ProdName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_ProdName.HoverState.Parent = Me.tb_ProdName
        Me.tb_ProdName.Location = New System.Drawing.Point(167, 93)
        Me.tb_ProdName.Name = "tb_ProdName"
        Me.tb_ProdName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_ProdName.PlaceholderText = ""
        Me.tb_ProdName.SelectedText = ""
        Me.tb_ProdName.ShadowDecoration.Parent = Me.tb_ProdName
        Me.tb_ProdName.Size = New System.Drawing.Size(344, 36)
        Me.tb_ProdName.TabIndex = 13
        Me.tb_ProdName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lb_ProdName
        '
        Me.lb_ProdName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_ProdName.ForeColor = System.Drawing.Color.White
        Me.lb_ProdName.Location = New System.Drawing.Point(36, 93)
        Me.lb_ProdName.Name = "lb_ProdName"
        Me.lb_ProdName.Size = New System.Drawing.Size(125, 36)
        Me.lb_ProdName.TabIndex = 16
        Me.lb_ProdName.Text = "Product Name:"
        Me.lb_ProdName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tb_Price
        '
        Me.tb_Price.BorderRadius = 15
        Me.tb_Price.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_Price.DefaultText = ""
        Me.tb_Price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_Price.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_Price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_Price.DisabledState.Parent = Me.tb_Price
        Me.tb_Price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_Price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_Price.FocusedState.Parent = Me.tb_Price
        Me.tb_Price.ForeColor = System.Drawing.Color.Black
        Me.tb_Price.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_Price.HoverState.Parent = Me.tb_Price
        Me.tb_Price.Location = New System.Drawing.Point(167, 264)
        Me.tb_Price.Name = "tb_Price"
        Me.tb_Price.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_Price.PlaceholderText = ""
        Me.tb_Price.SelectedText = ""
        Me.tb_Price.ShadowDecoration.Parent = Me.tb_Price
        Me.tb_Price.Size = New System.Drawing.Size(97, 36)
        Me.tb_Price.TabIndex = 20
        Me.tb_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lb_Price
        '
        Me.lb_Price.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Price.ForeColor = System.Drawing.Color.White
        Me.lb_Price.Location = New System.Drawing.Point(36, 264)
        Me.lb_Price.Name = "lb_Price"
        Me.lb_Price.Size = New System.Drawing.Size(125, 36)
        Me.lb_Price.TabIndex = 22
        Me.lb_Price.Text = "Price:"
        Me.lb_Price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tb_Quantity
        '
        Me.tb_Quantity.BorderRadius = 15
        Me.tb_Quantity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_Quantity.DefaultText = ""
        Me.tb_Quantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_Quantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_Quantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_Quantity.DisabledState.Parent = Me.tb_Quantity
        Me.tb_Quantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_Quantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_Quantity.FocusedState.Parent = Me.tb_Quantity
        Me.tb_Quantity.ForeColor = System.Drawing.Color.Black
        Me.tb_Quantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_Quantity.HoverState.Parent = Me.tb_Quantity
        Me.tb_Quantity.Location = New System.Drawing.Point(167, 222)
        Me.tb_Quantity.Name = "tb_Quantity"
        Me.tb_Quantity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_Quantity.PlaceholderText = ""
        Me.tb_Quantity.SelectedText = ""
        Me.tb_Quantity.ShadowDecoration.Parent = Me.tb_Quantity
        Me.tb_Quantity.Size = New System.Drawing.Size(97, 36)
        Me.tb_Quantity.TabIndex = 19
        Me.tb_Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lb_Quantity
        '
        Me.lb_Quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Quantity.ForeColor = System.Drawing.Color.White
        Me.lb_Quantity.Location = New System.Drawing.Point(36, 222)
        Me.lb_Quantity.Name = "lb_Quantity"
        Me.lb_Quantity.Size = New System.Drawing.Size(125, 36)
        Me.lb_Quantity.TabIndex = 21
        Me.lb_Quantity.Text = "Quantity:"
        Me.lb_Quantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btUpdate
        '
        Me.btUpdate.BorderRadius = 15
        Me.btUpdate.CheckedState.Parent = Me.btUpdate
        Me.btUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btUpdate.CustomImages.Parent = Me.btUpdate
        Me.btUpdate.FillColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btUpdate.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btUpdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btUpdate.ForeColor = System.Drawing.Color.White
        Me.btUpdate.HoverState.Parent = Me.btUpdate
        Me.btUpdate.Location = New System.Drawing.Point(244, 323)
        Me.btUpdate.Name = "btUpdate"
        Me.btUpdate.ShadowDecoration.Parent = Me.btUpdate
        Me.btUpdate.Size = New System.Drawing.Size(94, 36)
        Me.btUpdate.TabIndex = 23
        Me.btUpdate.Text = "Update"
        '
        'btCancel
        '
        Me.btCancel.BorderRadius = 15
        Me.btCancel.CheckedState.Parent = Me.btCancel
        Me.btCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btCancel.CustomImages.Parent = Me.btCancel
        Me.btCancel.FillColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btCancel.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btCancel.ForeColor = System.Drawing.Color.White
        Me.btCancel.HoverState.Parent = Me.btCancel
        Me.btCancel.Location = New System.Drawing.Point(438, 323)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.ShadowDecoration.Parent = Me.btCancel
        Me.btCancel.Size = New System.Drawing.Size(94, 36)
        Me.btCancel.TabIndex = 24
        Me.btCancel.Text = "Cancel"
        '
        'btClear
        '
        Me.btClear.BorderRadius = 15
        Me.btClear.CheckedState.Parent = Me.btClear
        Me.btClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btClear.CustomImages.Parent = Me.btClear
        Me.btClear.FillColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btClear.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btClear.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btClear.ForeColor = System.Drawing.Color.White
        Me.btClear.HoverState.Parent = Me.btClear
        Me.btClear.Location = New System.Drawing.Point(342, 323)
        Me.btClear.Name = "btClear"
        Me.btClear.ShadowDecoration.Parent = Me.btClear
        Me.btClear.Size = New System.Drawing.Size(94, 36)
        Me.btClear.TabIndex = 25
        Me.btClear.Text = "Clear"
        '
        'ProdEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(544, 394)
        Me.Controls.Add(Me.btClear)
        Me.Controls.Add(Me.btCancel)
        Me.Controls.Add(Me.btUpdate)
        Me.Controls.Add(Me.tb_Price)
        Me.Controls.Add(Me.lb_Price)
        Me.Controls.Add(Me.tb_Quantity)
        Me.Controls.Add(Me.lb_Quantity)
        Me.Controls.Add(Me.cb_Category)
        Me.Controls.Add(Me.lb_Category)
        Me.Controls.Add(Me.tb_Description)
        Me.Controls.Add(Me.lb_Description)
        Me.Controls.Add(Me.tb_ProdName)
        Me.Controls.Add(Me.lb_ProdName)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ProdEditForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents cb_Category As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lb_Category As Label
    Friend WithEvents tb_Description As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lb_Description As Label
    Friend WithEvents tb_ProdName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lb_ProdName As Label
    Friend WithEvents tb_Price As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lb_Price As Label
    Friend WithEvents tb_Quantity As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lb_Quantity As Label
    Friend WithEvents btUpdate As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents btCancel As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents btClear As Guna.UI2.WinForms.Guna2GradientTileButton
End Class
