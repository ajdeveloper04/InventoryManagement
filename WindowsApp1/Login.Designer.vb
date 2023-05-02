<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.components = New System.ComponentModel.Container()
        Dim GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tb_Username = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tb_Password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.bt_Login = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.cb_Showpass = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.bt_Cancel = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaDragControl1
        '
        GunaDragControl1.TargetControl = Me
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 298)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(280, 29)
        Me.FlowLayoutPanel2.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(107, 71)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 66)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'tb_Username
        '
        Me.tb_Username.BorderRadius = 15
        Me.tb_Username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_Username.DefaultText = ""
        Me.tb_Username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_Username.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_Username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_Username.DisabledState.Parent = Me.tb_Username
        Me.tb_Username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_Username.FocusedState.Parent = Me.tb_Username
        Me.tb_Username.ForeColor = System.Drawing.Color.Black
        Me.tb_Username.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_Username.HoverState.Parent = Me.tb_Username
        Me.tb_Username.Location = New System.Drawing.Point(36, 160)
        Me.tb_Username.Name = "tb_Username"
        Me.tb_Username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_Username.PlaceholderText = "Username"
        Me.tb_Username.SelectedText = ""
        Me.tb_Username.ShadowDecoration.Parent = Me.tb_Username
        Me.tb_Username.Size = New System.Drawing.Size(205, 31)
        Me.tb_Username.TabIndex = 1
        '
        'tb_Password
        '
        Me.tb_Password.BorderRadius = 15
        Me.tb_Password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_Password.DefaultText = ""
        Me.tb_Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_Password.DisabledState.Parent = Me.tb_Password
        Me.tb_Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_Password.FocusedState.Parent = Me.tb_Password
        Me.tb_Password.ForeColor = System.Drawing.Color.Black
        Me.tb_Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_Password.HoverState.Parent = Me.tb_Password
        Me.tb_Password.Location = New System.Drawing.Point(36, 206)
        Me.tb_Password.Name = "tb_Password"
        Me.tb_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_Password.PlaceholderText = "Password"
        Me.tb_Password.SelectedText = ""
        Me.tb_Password.ShadowDecoration.Parent = Me.tb_Password
        Me.tb_Password.Size = New System.Drawing.Size(205, 31)
        Me.tb_Password.TabIndex = 2
        Me.tb_Password.UseSystemPasswordChar = True
        '
        'bt_Login
        '
        Me.bt_Login.BorderRadius = 15
        Me.bt_Login.CheckedState.Parent = Me.bt_Login
        Me.bt_Login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_Login.CustomImages.Parent = Me.bt_Login
        Me.bt_Login.FillColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.bt_Login.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.bt_Login.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bt_Login.ForeColor = System.Drawing.Color.White
        Me.bt_Login.HoverState.Parent = Me.bt_Login
        Me.bt_Login.Location = New System.Drawing.Point(36, 247)
        Me.bt_Login.Name = "bt_Login"
        Me.bt_Login.ShadowDecoration.Parent = Me.bt_Login
        Me.bt_Login.Size = New System.Drawing.Size(97, 31)
        Me.bt_Login.TabIndex = 3
        Me.bt_Login.Text = "Login"
        '
        'cb_Showpass
        '
        Me.cb_Showpass.BackColor = System.Drawing.Color.Transparent
        Me.cb_Showpass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_Showpass.CheckedState.BorderRadius = 2
        Me.cb_Showpass.CheckedState.BorderThickness = 0
        Me.cb_Showpass.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_Showpass.CheckedState.Parent = Me.cb_Showpass
        Me.cb_Showpass.Location = New System.Drawing.Point(215, 214)
        Me.cb_Showpass.Name = "cb_Showpass"
        Me.cb_Showpass.ShadowDecoration.Parent = Me.cb_Showpass
        Me.cb_Showpass.Size = New System.Drawing.Size(15, 15)
        Me.cb_Showpass.TabIndex = 5
        Me.cb_Showpass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.cb_Showpass.UncheckedState.BorderRadius = 2
        Me.cb_Showpass.UncheckedState.BorderThickness = 0
        Me.cb_Showpass.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.cb_Showpass.UncheckedState.Parent = Me.cb_Showpass
        '
        'bt_Cancel
        '
        Me.bt_Cancel.BorderRadius = 15
        Me.bt_Cancel.CheckedState.Parent = Me.bt_Cancel
        Me.bt_Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_Cancel.CustomImages.Parent = Me.bt_Cancel
        Me.bt_Cancel.FillColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.bt_Cancel.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.bt_Cancel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bt_Cancel.ForeColor = System.Drawing.Color.White
        Me.bt_Cancel.HoverState.Parent = Me.bt_Cancel
        Me.bt_Cancel.Location = New System.Drawing.Point(144, 247)
        Me.bt_Cancel.Name = "bt_Cancel"
        Me.bt_Cancel.ShadowDecoration.Parent = Me.bt_Cancel
        Me.bt_Cancel.Size = New System.Drawing.Size(97, 31)
        Me.bt_Cancel.TabIndex = 4
        Me.bt_Cancel.Text = "Cancel"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GunaLabel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(280, 65)
        Me.Panel1.TabIndex = 6
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.White
        Me.GunaLabel1.Location = New System.Drawing.Point(37, 24)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(208, 25)
        Me.GunaLabel1.TabIndex = 1
        Me.GunaLabel1.Text = "Inventory Management"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(280, 327)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.bt_Cancel)
        Me.Controls.Add(Me.cb_Showpass)
        Me.Controls.Add(Me.bt_Login)
        Me.Controls.Add(Me.tb_Password)
        Me.Controls.Add(Me.tb_Username)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tb_Username As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tb_Password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents bt_Login As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents cb_Showpass As Guna.UI2.WinForms.Guna2CustomCheckBox
    Friend WithEvents bt_Cancel As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
End Class
