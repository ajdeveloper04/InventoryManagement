<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustEditForm
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
        Me.lbCustEdit = New Guna.UI.WinForms.GunaLabel()
        Me.btClear = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.btCancel = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.btUpdate = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.lbCustContact = New System.Windows.Forms.Label()
        Me.tbCustAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbCustAddress = New System.Windows.Forms.Label()
        Me.tbCustName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbCustName = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.tbCustContact = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbCustEdit)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(544, 65)
        Me.Panel1.TabIndex = 26
        '
        'lbCustEdit
        '
        Me.lbCustEdit.AutoSize = True
        Me.lbCustEdit.BackColor = System.Drawing.Color.Transparent
        Me.lbCustEdit.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCustEdit.ForeColor = System.Drawing.Color.White
        Me.lbCustEdit.Location = New System.Drawing.Point(206, 22)
        Me.lbCustEdit.Name = "lbCustEdit"
        Me.lbCustEdit.Size = New System.Drawing.Size(130, 25)
        Me.lbCustEdit.TabIndex = 1
        Me.lbCustEdit.Text = "Edit Customer"
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
        'lbCustContact
        '
        Me.lbCustContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCustContact.ForeColor = System.Drawing.Color.White
        Me.lbCustContact.Location = New System.Drawing.Point(36, 184)
        Me.lbCustContact.Name = "lbCustContact"
        Me.lbCustContact.Size = New System.Drawing.Size(125, 36)
        Me.lbCustContact.TabIndex = 33
        Me.lbCustContact.Text = "Contact No:"
        Me.lbCustContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbCustAddress
        '
        Me.tbCustAddress.BorderRadius = 15
        Me.tbCustAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbCustAddress.DefaultText = ""
        Me.tbCustAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbCustAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbCustAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbCustAddress.DisabledState.Parent = Me.tbCustAddress
        Me.tbCustAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbCustAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbCustAddress.FocusedState.Parent = Me.tbCustAddress
        Me.tbCustAddress.ForeColor = System.Drawing.Color.Black
        Me.tbCustAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbCustAddress.HoverState.Parent = Me.tbCustAddress
        Me.tbCustAddress.Location = New System.Drawing.Point(167, 142)
        Me.tbCustAddress.Name = "tbCustAddress"
        Me.tbCustAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbCustAddress.PlaceholderText = ""
        Me.tbCustAddress.SelectedText = ""
        Me.tbCustAddress.ShadowDecoration.Parent = Me.tbCustAddress
        Me.tbCustAddress.Size = New System.Drawing.Size(344, 36)
        Me.tbCustAddress.TabIndex = 29
        Me.tbCustAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbCustAddress
        '
        Me.lbCustAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCustAddress.ForeColor = System.Drawing.Color.White
        Me.lbCustAddress.Location = New System.Drawing.Point(36, 142)
        Me.lbCustAddress.Name = "lbCustAddress"
        Me.lbCustAddress.Size = New System.Drawing.Size(125, 36)
        Me.lbCustAddress.TabIndex = 32
        Me.lbCustAddress.Text = "Address:"
        Me.lbCustAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbCustName
        '
        Me.tbCustName.BorderRadius = 15
        Me.tbCustName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbCustName.DefaultText = ""
        Me.tbCustName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbCustName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbCustName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbCustName.DisabledState.Parent = Me.tbCustName
        Me.tbCustName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbCustName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbCustName.FocusedState.Parent = Me.tbCustName
        Me.tbCustName.ForeColor = System.Drawing.Color.Black
        Me.tbCustName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbCustName.HoverState.Parent = Me.tbCustName
        Me.tbCustName.Location = New System.Drawing.Point(167, 100)
        Me.tbCustName.Name = "tbCustName"
        Me.tbCustName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbCustName.PlaceholderText = ""
        Me.tbCustName.SelectedText = ""
        Me.tbCustName.ShadowDecoration.Parent = Me.tbCustName
        Me.tbCustName.Size = New System.Drawing.Size(344, 36)
        Me.tbCustName.TabIndex = 28
        Me.tbCustName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbCustName
        '
        Me.lbCustName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCustName.ForeColor = System.Drawing.Color.White
        Me.lbCustName.Location = New System.Drawing.Point(36, 100)
        Me.lbCustName.Name = "lbCustName"
        Me.lbCustName.Size = New System.Drawing.Size(140, 36)
        Me.lbCustName.TabIndex = 31
        Me.lbCustName.Text = "Customer Name:"
        Me.lbCustName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'tbCustContact
        '
        Me.tbCustContact.BorderRadius = 15
        Me.tbCustContact.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbCustContact.DefaultText = ""
        Me.tbCustContact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbCustContact.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbCustContact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbCustContact.DisabledState.Parent = Me.tbCustContact
        Me.tbCustContact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbCustContact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbCustContact.FocusedState.Parent = Me.tbCustContact
        Me.tbCustContact.ForeColor = System.Drawing.Color.Black
        Me.tbCustContact.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbCustContact.HoverState.Parent = Me.tbCustContact
        Me.tbCustContact.Location = New System.Drawing.Point(167, 184)
        Me.tbCustContact.Name = "tbCustContact"
        Me.tbCustContact.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbCustContact.PlaceholderText = ""
        Me.tbCustContact.SelectedText = ""
        Me.tbCustContact.ShadowDecoration.Parent = Me.tbCustContact
        Me.tbCustContact.Size = New System.Drawing.Size(344, 36)
        Me.tbCustContact.TabIndex = 41
        Me.tbCustContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CustEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(544, 394)
        Me.Controls.Add(Me.tbCustContact)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btClear)
        Me.Controls.Add(Me.btCancel)
        Me.Controls.Add(Me.btUpdate)
        Me.Controls.Add(Me.lbCustContact)
        Me.Controls.Add(Me.tbCustAddress)
        Me.Controls.Add(Me.lbCustAddress)
        Me.Controls.Add(Me.tbCustName)
        Me.Controls.Add(Me.lbCustName)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CustEditForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CustEditForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbCustEdit As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btClear As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents btCancel As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents btUpdate As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents lbCustContact As Label
    Friend WithEvents tbCustAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbCustAddress As Label
    Friend WithEvents tbCustName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbCustName As Label
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents tbCustContact As Guna.UI2.WinForms.Guna2TextBox
End Class
