<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CatEditForm
    Inherits System.Windows.Forms.Form

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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbCatEdit = New Guna.UI.WinForms.GunaLabel()
        Me.btClear = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.btCancel = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.btUpdate = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.tbCatName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbCategoryName = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbCatEdit)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(544, 65)
        Me.Panel1.TabIndex = 42
        '
        'lbCatEdit
        '
        Me.lbCatEdit.AutoSize = True
        Me.lbCatEdit.BackColor = System.Drawing.Color.Transparent
        Me.lbCatEdit.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCatEdit.ForeColor = System.Drawing.Color.White
        Me.lbCatEdit.Location = New System.Drawing.Point(206, 22)
        Me.lbCatEdit.Name = "lbCatEdit"
        Me.lbCatEdit.Size = New System.Drawing.Size(125, 25)
        Me.lbCatEdit.TabIndex = 1
        Me.lbCatEdit.Text = "Edit Category"
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
        Me.btClear.TabIndex = 55
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
        Me.btCancel.TabIndex = 54
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
        Me.btUpdate.TabIndex = 53
        Me.btUpdate.Text = "Update"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 365)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(544, 29)
        Me.FlowLayoutPanel2.TabIndex = 43
        '
        'tbCatName
        '
        Me.tbCatName.BorderRadius = 15
        Me.tbCatName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbCatName.DefaultText = ""
        Me.tbCatName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbCatName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbCatName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbCatName.DisabledState.Parent = Me.tbCatName
        Me.tbCatName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbCatName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbCatName.FocusedState.Parent = Me.tbCatName
        Me.tbCatName.ForeColor = System.Drawing.Color.Black
        Me.tbCatName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbCatName.HoverState.Parent = Me.tbCatName
        Me.tbCatName.Location = New System.Drawing.Point(163, 180)
        Me.tbCatName.Name = "tbCatName"
        Me.tbCatName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbCatName.PlaceholderText = ""
        Me.tbCatName.SelectedText = ""
        Me.tbCatName.ShadowDecoration.Parent = Me.tbCatName
        Me.tbCatName.Size = New System.Drawing.Size(344, 36)
        Me.tbCatName.TabIndex = 57
        Me.tbCatName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbCategoryName
        '
        Me.lbCategoryName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCategoryName.ForeColor = System.Drawing.Color.White
        Me.lbCategoryName.Location = New System.Drawing.Point(32, 180)
        Me.lbCategoryName.Name = "lbCategoryName"
        Me.lbCategoryName.Size = New System.Drawing.Size(148, 36)
        Me.lbCategoryName.TabIndex = 59
        Me.lbCategoryName.Text = "Category Name:"
        Me.lbCategoryName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CatEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(544, 394)
        Me.Controls.Add(Me.tbCatName)
        Me.Controls.Add(Me.lbCategoryName)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btClear)
        Me.Controls.Add(Me.btCancel)
        Me.Controls.Add(Me.btUpdate)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CatEditForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CatEditForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbCatEdit As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btClear As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents btCancel As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents btUpdate As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents tbCatName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbCategoryName As Label
End Class
