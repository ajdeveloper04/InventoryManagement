<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransEditForm
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
        Me.cbTransCustomer = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbTransEdit = New Guna.UI.WinForms.GunaLabel()
        Me.btClear = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.btCancel = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.btUpdate = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.tbTransPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lb_Price = New System.Windows.Forms.Label()
        Me.tbTransQuantity = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lb_Quantity = New System.Windows.Forms.Label()
        Me.lbEdit = New System.Windows.Forms.Label()
        Me.lbTrans = New System.Windows.Forms.Label()
        Me.tbTransName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbTransDate = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.cbTransOrder = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbTransCustomer
        '
        Me.cbTransCustomer.BackColor = System.Drawing.Color.Transparent
        Me.cbTransCustomer.BorderRadius = 15
        Me.cbTransCustomer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbTransCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTransCustomer.FocusedColor = System.Drawing.Color.Empty
        Me.cbTransCustomer.FocusedState.Parent = Me.cbTransCustomer
        Me.cbTransCustomer.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbTransCustomer.ForeColor = System.Drawing.Color.Black
        Me.cbTransCustomer.FormattingEnabled = True
        Me.cbTransCustomer.HoverState.Parent = Me.cbTransCustomer
        Me.cbTransCustomer.ItemHeight = 30
        Me.cbTransCustomer.Items.AddRange(New Object() {"Perfume", "Soaps", "Beauty Products"})
        Me.cbTransCustomer.ItemsAppearance.Parent = Me.cbTransCustomer
        Me.cbTransCustomer.Location = New System.Drawing.Point(167, 177)
        Me.cbTransCustomer.Name = "cbTransCustomer"
        Me.cbTransCustomer.ShadowDecoration.Parent = Me.cbTransCustomer
        Me.cbTransCustomer.Size = New System.Drawing.Size(344, 36)
        Me.cbTransCustomer.TabIndex = 30
        Me.cbTransCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbTransEdit)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(544, 65)
        Me.Panel1.TabIndex = 26
        '
        'lbTransEdit
        '
        Me.lbTransEdit.AutoSize = True
        Me.lbTransEdit.BackColor = System.Drawing.Color.Transparent
        Me.lbTransEdit.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTransEdit.ForeColor = System.Drawing.Color.White
        Me.lbTransEdit.Location = New System.Drawing.Point(206, 22)
        Me.lbTransEdit.Name = "lbTransEdit"
        Me.lbTransEdit.Size = New System.Drawing.Size(153, 25)
        Me.lbTransEdit.TabIndex = 1
        Me.lbTransEdit.Text = "Edit Transactions"
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
        Me.btClear.TabIndex = 40
        Me.btClear.Text = "Clear"
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
        Me.btCancel.TabIndex = 39
        Me.btCancel.Text = "Cancel"
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
        Me.btUpdate.TabIndex = 38
        Me.btUpdate.Text = "Update"
        '
        'tbTransPrice
        '
        Me.tbTransPrice.BorderRadius = 15
        Me.tbTransPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbTransPrice.DefaultText = ""
        Me.tbTransPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbTransPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbTransPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbTransPrice.DisabledState.Parent = Me.tbTransPrice
        Me.tbTransPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbTransPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbTransPrice.FocusedState.Parent = Me.tbTransPrice
        Me.tbTransPrice.ForeColor = System.Drawing.Color.Black
        Me.tbTransPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbTransPrice.HoverState.Parent = Me.tbTransPrice
        Me.tbTransPrice.Location = New System.Drawing.Point(167, 264)
        Me.tbTransPrice.Name = "tbTransPrice"
        Me.tbTransPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbTransPrice.PlaceholderText = ""
        Me.tbTransPrice.SelectedText = ""
        Me.tbTransPrice.ShadowDecoration.Parent = Me.tbTransPrice
        Me.tbTransPrice.Size = New System.Drawing.Size(97, 36)
        Me.tbTransPrice.TabIndex = 35
        Me.tbTransPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lb_Price
        '
        Me.lb_Price.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Price.ForeColor = System.Drawing.Color.White
        Me.lb_Price.Location = New System.Drawing.Point(36, 264)
        Me.lb_Price.Name = "lb_Price"
        Me.lb_Price.Size = New System.Drawing.Size(125, 36)
        Me.lb_Price.TabIndex = 37
        Me.lb_Price.Text = "Total:"
        Me.lb_Price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbTransQuantity
        '
        Me.tbTransQuantity.BorderRadius = 15
        Me.tbTransQuantity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbTransQuantity.DefaultText = ""
        Me.tbTransQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbTransQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbTransQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbTransQuantity.DisabledState.Parent = Me.tbTransQuantity
        Me.tbTransQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbTransQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbTransQuantity.FocusedState.Parent = Me.tbTransQuantity
        Me.tbTransQuantity.ForeColor = System.Drawing.Color.Black
        Me.tbTransQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbTransQuantity.HoverState.Parent = Me.tbTransQuantity
        Me.tbTransQuantity.Location = New System.Drawing.Point(167, 222)
        Me.tbTransQuantity.Name = "tbTransQuantity"
        Me.tbTransQuantity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbTransQuantity.PlaceholderText = ""
        Me.tbTransQuantity.SelectedText = ""
        Me.tbTransQuantity.ShadowDecoration.Parent = Me.tbTransQuantity
        Me.tbTransQuantity.Size = New System.Drawing.Size(97, 36)
        Me.tbTransQuantity.TabIndex = 34
        Me.tbTransQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lb_Quantity
        '
        Me.lb_Quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Quantity.ForeColor = System.Drawing.Color.White
        Me.lb_Quantity.Location = New System.Drawing.Point(36, 222)
        Me.lb_Quantity.Name = "lb_Quantity"
        Me.lb_Quantity.Size = New System.Drawing.Size(125, 36)
        Me.lb_Quantity.TabIndex = 36
        Me.lb_Quantity.Text = "Quantity:"
        Me.lb_Quantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbEdit
        '
        Me.lbEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEdit.ForeColor = System.Drawing.Color.White
        Me.lbEdit.Location = New System.Drawing.Point(36, 177)
        Me.lbEdit.Name = "lbEdit"
        Me.lbEdit.Size = New System.Drawing.Size(125, 36)
        Me.lbEdit.TabIndex = 33
        Me.lbEdit.Text = "Customer:"
        Me.lbEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbTrans
        '
        Me.lbTrans.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTrans.ForeColor = System.Drawing.Color.White
        Me.lbTrans.Location = New System.Drawing.Point(29, 132)
        Me.lbTrans.Name = "lbTrans"
        Me.lbTrans.Size = New System.Drawing.Size(143, 36)
        Me.lbTrans.TabIndex = 32
        Me.lbTrans.Text = "Product Ordered:"
        Me.lbTrans.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbTransName
        '
        Me.tbTransName.BorderRadius = 15
        Me.tbTransName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbTransName.DefaultText = ""
        Me.tbTransName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbTransName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbTransName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbTransName.DisabledState.Parent = Me.tbTransName
        Me.tbTransName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbTransName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbTransName.FocusedState.Parent = Me.tbTransName
        Me.tbTransName.ForeColor = System.Drawing.Color.Black
        Me.tbTransName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbTransName.HoverState.Parent = Me.tbTransName
        Me.tbTransName.Location = New System.Drawing.Point(167, 93)
        Me.tbTransName.Name = "tbTransName"
        Me.tbTransName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbTransName.PlaceholderText = ""
        Me.tbTransName.SelectedText = ""
        Me.tbTransName.ShadowDecoration.Parent = Me.tbTransName
        Me.tbTransName.Size = New System.Drawing.Size(344, 36)
        Me.tbTransName.TabIndex = 28
        Me.tbTransName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbTransDate
        '
        Me.lbTransDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTransDate.ForeColor = System.Drawing.Color.White
        Me.lbTransDate.Location = New System.Drawing.Point(29, 93)
        Me.lbTransDate.Name = "lbTransDate"
        Me.lbTransDate.Size = New System.Drawing.Size(150, 36)
        Me.lbTransDate.TabIndex = 31
        Me.lbTransDate.Text = "Transaction Date:"
        Me.lbTransDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 365)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(544, 29)
        Me.FlowLayoutPanel2.TabIndex = 27
        '
        'cbTransOrder
        '
        Me.cbTransOrder.BackColor = System.Drawing.Color.Transparent
        Me.cbTransOrder.BorderRadius = 15
        Me.cbTransOrder.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbTransOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTransOrder.FocusedColor = System.Drawing.Color.Empty
        Me.cbTransOrder.FocusedState.Parent = Me.cbTransOrder
        Me.cbTransOrder.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbTransOrder.ForeColor = System.Drawing.Color.Black
        Me.cbTransOrder.FormattingEnabled = True
        Me.cbTransOrder.HoverState.Parent = Me.cbTransOrder
        Me.cbTransOrder.ItemHeight = 30
        Me.cbTransOrder.Items.AddRange(New Object() {"Perfume", "Soaps", "Beauty Products"})
        Me.cbTransOrder.ItemsAppearance.Parent = Me.cbTransOrder
        Me.cbTransOrder.Location = New System.Drawing.Point(167, 135)
        Me.cbTransOrder.Name = "cbTransOrder"
        Me.cbTransOrder.ShadowDecoration.Parent = Me.cbTransOrder
        Me.cbTransOrder.Size = New System.Drawing.Size(344, 36)
        Me.cbTransOrder.TabIndex = 41
        Me.cbTransOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TransEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(544, 394)
        Me.Controls.Add(Me.cbTransOrder)
        Me.Controls.Add(Me.cbTransCustomer)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btClear)
        Me.Controls.Add(Me.btCancel)
        Me.Controls.Add(Me.btUpdate)
        Me.Controls.Add(Me.tbTransPrice)
        Me.Controls.Add(Me.lb_Price)
        Me.Controls.Add(Me.tbTransQuantity)
        Me.Controls.Add(Me.lb_Quantity)
        Me.Controls.Add(Me.lbEdit)
        Me.Controls.Add(Me.lbTrans)
        Me.Controls.Add(Me.tbTransName)
        Me.Controls.Add(Me.lbTransDate)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TransEditForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TransEditForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbTransCustomer As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbTransEdit As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btClear As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents btCancel As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents btUpdate As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents tbTransPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lb_Price As Label
    Friend WithEvents tbTransQuantity As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lb_Quantity As Label
    Friend WithEvents lbEdit As Label
    Friend WithEvents lbTrans As Label
    Friend WithEvents tbTransName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbTransDate As Label
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents cbTransOrder As Guna.UI2.WinForms.Guna2ComboBox
End Class
