<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransactionForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbCatergory = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox3 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.bt_Reset = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.lbTransacList = New System.Windows.Forms.Label()
        Me.bt_Find = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.tb_SearchBar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.btHome = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.bt_Clear = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.bt_Delete = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.bt_Edit = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.bt_Add = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.tbTransDate = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbTransactionDate = New System.Windows.Forms.Label()
        Me.tbTransID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbTransactID = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.db_Datagrid = New Guna.UI.WinForms.GunaDataGridView()
        Me.tbTransOrder = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbProdOrder = New System.Windows.Forms.Label()
        Me.tbTransCustomer = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbCustCategory = New System.Windows.Forms.Label()
        Me.tbTransQuantity = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbTransQuantity = New System.Windows.Forms.Label()
        Me.tbTransTotal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbTransTotal = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.db_Datagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbCatergory)
        Me.Panel1.Controls.Add(Me.Guna2ControlBox2)
        Me.Panel1.Controls.Add(Me.Guna2ControlBox3)
        Me.Panel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Panel1.Controls.Add(Me.GunaLabel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(931, 65)
        Me.Panel1.TabIndex = 63
        '
        'lbCatergory
        '
        Me.lbCatergory.AutoSize = True
        Me.lbCatergory.BackColor = System.Drawing.Color.Transparent
        Me.lbCatergory.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCatergory.ForeColor = System.Drawing.Color.White
        Me.lbCatergory.Location = New System.Drawing.Point(378, 39)
        Me.lbCatergory.Name = "lbCatergory"
        Me.lbCatergory.Size = New System.Drawing.Size(149, 21)
        Me.lbCatergory.TabIndex = 6
        Me.lbCatergory.Text = "Manage Transaction"
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox
        Me.Guna2ControlBox2.Enabled = False
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Guna2ControlBox2.HoverState.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(851, 12)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.ShadowDecoration.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(31, 22)
        Me.Guna2ControlBox2.TabIndex = 5
        '
        'Guna2ControlBox3
        '
        Me.Guna2ControlBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Guna2ControlBox3.HoverState.Parent = Me.Guna2ControlBox3
        Me.Guna2ControlBox3.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox3.Location = New System.Drawing.Point(814, 12)
        Me.Guna2ControlBox3.Name = "Guna2ControlBox3"
        Me.Guna2ControlBox3.ShadowDecoration.Parent = Me.Guna2ControlBox3
        Me.Guna2ControlBox3.Size = New System.Drawing.Size(31, 22)
        Me.Guna2ControlBox3.TabIndex = 4
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(888, 12)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(31, 22)
        Me.Guna2ControlBox1.TabIndex = 2
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.White
        Me.GunaLabel1.Location = New System.Drawing.Point(305, 12)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(271, 25)
        Me.GunaLabel1.TabIndex = 1
        Me.GunaLabel1.Text = "Inventory Management System"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.bt_Reset)
        Me.Panel3.Controls.Add(Me.lbTransacList)
        Me.Panel3.Controls.Add(Me.bt_Find)
        Me.Panel3.Controls.Add(Me.tb_SearchBar)
        Me.Panel3.Location = New System.Drawing.Point(0, 273)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(4)
        Me.Panel3.Size = New System.Drawing.Size(931, 44)
        Me.Panel3.TabIndex = 74
        '
        'bt_Reset
        '
        Me.bt_Reset.BorderRadius = 15
        Me.bt_Reset.CheckedState.Parent = Me.bt_Reset
        Me.bt_Reset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_Reset.CustomImages.Parent = Me.bt_Reset
        Me.bt_Reset.FillColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.bt_Reset.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.bt_Reset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bt_Reset.ForeColor = System.Drawing.Color.White
        Me.bt_Reset.HoverState.Parent = Me.bt_Reset
        Me.bt_Reset.Location = New System.Drawing.Point(849, 7)
        Me.bt_Reset.Name = "bt_Reset"
        Me.bt_Reset.ShadowDecoration.Parent = Me.bt_Reset
        Me.bt_Reset.Size = New System.Drawing.Size(70, 27)
        Me.bt_Reset.TabIndex = 21
        Me.bt_Reset.Text = "Reset"
        '
        'lbTransacList
        '
        Me.lbTransacList.BackColor = System.Drawing.Color.Transparent
        Me.lbTransacList.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbTransacList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTransacList.ForeColor = System.Drawing.Color.White
        Me.lbTransacList.Location = New System.Drawing.Point(4, 4)
        Me.lbTransacList.Name = "lbTransacList"
        Me.lbTransacList.Size = New System.Drawing.Size(156, 36)
        Me.lbTransacList.TabIndex = 20
        Me.lbTransacList.Text = "Transaction List"
        Me.lbTransacList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bt_Find
        '
        Me.bt_Find.BorderRadius = 13
        Me.bt_Find.CheckedState.Parent = Me.bt_Find
        Me.bt_Find.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_Find.CustomImages.Parent = Me.bt_Find
        Me.bt_Find.FillColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.bt_Find.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.bt_Find.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bt_Find.ForeColor = System.Drawing.Color.White
        Me.bt_Find.HoverState.Parent = Me.bt_Find
        Me.bt_Find.Location = New System.Drawing.Point(773, 7)
        Me.bt_Find.Name = "bt_Find"
        Me.bt_Find.ShadowDecoration.Parent = Me.bt_Find
        Me.bt_Find.Size = New System.Drawing.Size(70, 27)
        Me.bt_Find.TabIndex = 23
        Me.bt_Find.Text = "Find"
        '
        'tb_SearchBar
        '
        Me.tb_SearchBar.BorderRadius = 13
        Me.tb_SearchBar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_SearchBar.DefaultText = ""
        Me.tb_SearchBar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_SearchBar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_SearchBar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_SearchBar.DisabledState.Parent = Me.tb_SearchBar
        Me.tb_SearchBar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_SearchBar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_SearchBar.FocusedState.Parent = Me.tb_SearchBar
        Me.tb_SearchBar.ForeColor = System.Drawing.Color.Black
        Me.tb_SearchBar.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_SearchBar.HoverState.Parent = Me.tb_SearchBar
        Me.tb_SearchBar.Location = New System.Drawing.Point(500, 7)
        Me.tb_SearchBar.Name = "tb_SearchBar"
        Me.tb_SearchBar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_SearchBar.PlaceholderText = ""
        Me.tb_SearchBar.SelectedText = ""
        Me.tb_SearchBar.ShadowDecoration.Parent = Me.tb_SearchBar
        Me.tb_SearchBar.Size = New System.Drawing.Size(267, 27)
        Me.tb_SearchBar.TabIndex = 22
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 700)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(931, 29)
        Me.FlowLayoutPanel2.TabIndex = 64
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me
        '
        'btHome
        '
        Me.btHome.BorderRadius = 15
        Me.btHome.CheckedState.Parent = Me.btHome
        Me.btHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btHome.CustomImages.Parent = Me.btHome
        Me.btHome.FillColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btHome.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btHome.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btHome.ForeColor = System.Drawing.Color.White
        Me.btHome.HoverState.Parent = Me.btHome
        Me.btHome.Location = New System.Drawing.Point(797, 234)
        Me.btHome.Name = "btHome"
        Me.btHome.ShadowDecoration.Parent = Me.btHome
        Me.btHome.Size = New System.Drawing.Size(122, 31)
        Me.btHome.TabIndex = 75
        Me.btHome.Text = "Home"
        '
        'bt_Clear
        '
        Me.bt_Clear.BorderRadius = 15
        Me.bt_Clear.CheckedState.Parent = Me.bt_Clear
        Me.bt_Clear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_Clear.CustomImages.Parent = Me.bt_Clear
        Me.bt_Clear.FillColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.bt_Clear.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.bt_Clear.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bt_Clear.ForeColor = System.Drawing.Color.White
        Me.bt_Clear.HoverState.Parent = Me.bt_Clear
        Me.bt_Clear.Location = New System.Drawing.Point(797, 197)
        Me.bt_Clear.Name = "bt_Clear"
        Me.bt_Clear.ShadowDecoration.Parent = Me.bt_Clear
        Me.bt_Clear.Size = New System.Drawing.Size(122, 31)
        Me.bt_Clear.TabIndex = 72
        Me.bt_Clear.Text = "Clear"
        '
        'bt_Delete
        '
        Me.bt_Delete.BorderRadius = 15
        Me.bt_Delete.CheckedState.Parent = Me.bt_Delete
        Me.bt_Delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_Delete.CustomImages.Parent = Me.bt_Delete
        Me.bt_Delete.FillColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.bt_Delete.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.bt_Delete.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bt_Delete.ForeColor = System.Drawing.Color.White
        Me.bt_Delete.HoverState.Parent = Me.bt_Delete
        Me.bt_Delete.Location = New System.Drawing.Point(797, 160)
        Me.bt_Delete.Name = "bt_Delete"
        Me.bt_Delete.ShadowDecoration.Parent = Me.bt_Delete
        Me.bt_Delete.Size = New System.Drawing.Size(122, 31)
        Me.bt_Delete.TabIndex = 71
        Me.bt_Delete.Text = "Delete"
        '
        'bt_Edit
        '
        Me.bt_Edit.BorderRadius = 15
        Me.bt_Edit.CheckedState.Parent = Me.bt_Edit
        Me.bt_Edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_Edit.CustomImages.Parent = Me.bt_Edit
        Me.bt_Edit.FillColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.bt_Edit.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.bt_Edit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bt_Edit.ForeColor = System.Drawing.Color.White
        Me.bt_Edit.HoverState.Parent = Me.bt_Edit
        Me.bt_Edit.Location = New System.Drawing.Point(797, 123)
        Me.bt_Edit.Name = "bt_Edit"
        Me.bt_Edit.ShadowDecoration.Parent = Me.bt_Edit
        Me.bt_Edit.Size = New System.Drawing.Size(122, 31)
        Me.bt_Edit.TabIndex = 70
        Me.bt_Edit.Text = "Edit"
        '
        'bt_Add
        '
        Me.bt_Add.BorderRadius = 15
        Me.bt_Add.CheckedState.Parent = Me.bt_Add
        Me.bt_Add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_Add.CustomImages.Parent = Me.bt_Add
        Me.bt_Add.FillColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.bt_Add.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.bt_Add.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bt_Add.ForeColor = System.Drawing.Color.White
        Me.bt_Add.HoverState.Parent = Me.bt_Add
        Me.bt_Add.Location = New System.Drawing.Point(797, 86)
        Me.bt_Add.Name = "bt_Add"
        Me.bt_Add.ShadowDecoration.Parent = Me.bt_Add
        Me.bt_Add.Size = New System.Drawing.Size(122, 31)
        Me.bt_Add.TabIndex = 69
        Me.bt_Add.Text = "Add"
        '
        'tbTransDate
        '
        Me.tbTransDate.BorderRadius = 15
        Me.tbTransDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbTransDate.DefaultText = ""
        Me.tbTransDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbTransDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbTransDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbTransDate.DisabledState.Parent = Me.tbTransDate
        Me.tbTransDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbTransDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbTransDate.FocusedState.Parent = Me.tbTransDate
        Me.tbTransDate.ForeColor = System.Drawing.Color.Black
        Me.tbTransDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbTransDate.HoverState.Parent = Me.tbTransDate
        Me.tbTransDate.Location = New System.Drawing.Point(159, 128)
        Me.tbTransDate.Name = "tbTransDate"
        Me.tbTransDate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbTransDate.PlaceholderText = ""
        Me.tbTransDate.SelectedText = ""
        Me.tbTransDate.ShadowDecoration.Parent = Me.tbTransDate
        Me.tbTransDate.Size = New System.Drawing.Size(344, 36)
        Me.tbTransDate.TabIndex = 66
        Me.tbTransDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbTransactionDate
        '
        Me.lbTransactionDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTransactionDate.ForeColor = System.Drawing.Color.White
        Me.lbTransactionDate.Location = New System.Drawing.Point(23, 128)
        Me.lbTransactionDate.Name = "lbTransactionDate"
        Me.lbTransactionDate.Size = New System.Drawing.Size(148, 36)
        Me.lbTransactionDate.TabIndex = 68
        Me.lbTransactionDate.Text = "Transaction Date:"
        Me.lbTransactionDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbTransID
        '
        Me.tbTransID.BorderRadius = 15
        Me.tbTransID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbTransID.DefaultText = ""
        Me.tbTransID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbTransID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbTransID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbTransID.DisabledState.Parent = Me.tbTransID
        Me.tbTransID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbTransID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbTransID.FocusedState.Parent = Me.tbTransID
        Me.tbTransID.ForeColor = System.Drawing.Color.Black
        Me.tbTransID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbTransID.HoverState.Parent = Me.tbTransID
        Me.tbTransID.Location = New System.Drawing.Point(159, 86)
        Me.tbTransID.Name = "tbTransID"
        Me.tbTransID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbTransID.PlaceholderText = ""
        Me.tbTransID.SelectedText = ""
        Me.tbTransID.ShadowDecoration.Parent = Me.tbTransID
        Me.tbTransID.Size = New System.Drawing.Size(97, 36)
        Me.tbTransID.TabIndex = 65
        Me.tbTransID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbTransactID
        '
        Me.lbTransactID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTransactID.ForeColor = System.Drawing.Color.White
        Me.lbTransactID.Location = New System.Drawing.Point(23, 86)
        Me.lbTransactID.Name = "lbTransactID"
        Me.lbTransactID.Size = New System.Drawing.Size(125, 36)
        Me.lbTransactID.TabIndex = 67
        Me.lbTransactID.Text = "Transaction ID:"
        Me.lbTransactID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.db_Datagrid)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 317)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(931, 412)
        Me.Panel2.TabIndex = 73
        '
        'db_Datagrid
        '
        Me.db_Datagrid.AllowUserToAddRows = False
        Me.db_Datagrid.AllowUserToDeleteRows = False
        Me.db_Datagrid.AllowUserToResizeColumns = False
        Me.db_Datagrid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.db_Datagrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.db_Datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.db_Datagrid.BackgroundColor = System.Drawing.Color.White
        Me.db_Datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.db_Datagrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.db_Datagrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.db_Datagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.db_Datagrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.db_Datagrid.ColumnHeadersHeight = 40
        Me.db_Datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.db_Datagrid.DefaultCellStyle = DataGridViewCellStyle3
        Me.db_Datagrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.db_Datagrid.EnableHeadersVisualStyles = False
        Me.db_Datagrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.db_Datagrid.Location = New System.Drawing.Point(0, 0)
        Me.db_Datagrid.Name = "db_Datagrid"
        Me.db_Datagrid.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(175, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.db_Datagrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.db_Datagrid.RowHeadersVisible = False
        Me.db_Datagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.db_Datagrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.db_Datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.db_Datagrid.Size = New System.Drawing.Size(931, 412)
        Me.db_Datagrid.TabIndex = 2
        Me.db_Datagrid.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.db_Datagrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.db_Datagrid.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.db_Datagrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.db_Datagrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.db_Datagrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.db_Datagrid.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.db_Datagrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.db_Datagrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.db_Datagrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.db_Datagrid.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.db_Datagrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.db_Datagrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.db_Datagrid.ThemeStyle.HeaderStyle.Height = 40
        Me.db_Datagrid.ThemeStyle.ReadOnly = True
        Me.db_Datagrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.db_Datagrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.db_Datagrid.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.db_Datagrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.db_Datagrid.ThemeStyle.RowsStyle.Height = 22
        Me.db_Datagrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.db_Datagrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'tbTransOrder
        '
        Me.tbTransOrder.BorderRadius = 15
        Me.tbTransOrder.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbTransOrder.DefaultText = ""
        Me.tbTransOrder.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbTransOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbTransOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbTransOrder.DisabledState.Parent = Me.tbTransOrder
        Me.tbTransOrder.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbTransOrder.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbTransOrder.FocusedState.Parent = Me.tbTransOrder
        Me.tbTransOrder.ForeColor = System.Drawing.Color.Black
        Me.tbTransOrder.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbTransOrder.HoverState.Parent = Me.tbTransOrder
        Me.tbTransOrder.Location = New System.Drawing.Point(159, 171)
        Me.tbTransOrder.Name = "tbTransOrder"
        Me.tbTransOrder.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbTransOrder.PlaceholderText = ""
        Me.tbTransOrder.SelectedText = ""
        Me.tbTransOrder.ShadowDecoration.Parent = Me.tbTransOrder
        Me.tbTransOrder.Size = New System.Drawing.Size(344, 36)
        Me.tbTransOrder.TabIndex = 76
        Me.tbTransOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbProdOrder
        '
        Me.lbProdOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbProdOrder.ForeColor = System.Drawing.Color.White
        Me.lbProdOrder.Location = New System.Drawing.Point(23, 171)
        Me.lbProdOrder.Name = "lbProdOrder"
        Me.lbProdOrder.Size = New System.Drawing.Size(148, 36)
        Me.lbProdOrder.TabIndex = 77
        Me.lbProdOrder.Text = "Product Ordered:"
        Me.lbProdOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbTransCustomer
        '
        Me.tbTransCustomer.BorderRadius = 15
        Me.tbTransCustomer.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbTransCustomer.DefaultText = ""
        Me.tbTransCustomer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbTransCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbTransCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbTransCustomer.DisabledState.Parent = Me.tbTransCustomer
        Me.tbTransCustomer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbTransCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbTransCustomer.FocusedState.Parent = Me.tbTransCustomer
        Me.tbTransCustomer.ForeColor = System.Drawing.Color.Black
        Me.tbTransCustomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbTransCustomer.HoverState.Parent = Me.tbTransCustomer
        Me.tbTransCustomer.Location = New System.Drawing.Point(159, 215)
        Me.tbTransCustomer.Name = "tbTransCustomer"
        Me.tbTransCustomer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbTransCustomer.PlaceholderText = ""
        Me.tbTransCustomer.SelectedText = ""
        Me.tbTransCustomer.ShadowDecoration.Parent = Me.tbTransCustomer
        Me.tbTransCustomer.Size = New System.Drawing.Size(344, 36)
        Me.tbTransCustomer.TabIndex = 78
        Me.tbTransCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbCustCategory
        '
        Me.lbCustCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCustCategory.ForeColor = System.Drawing.Color.White
        Me.lbCustCategory.Location = New System.Drawing.Point(23, 215)
        Me.lbCustCategory.Name = "lbCustCategory"
        Me.lbCustCategory.Size = New System.Drawing.Size(148, 36)
        Me.lbCustCategory.TabIndex = 79
        Me.lbCustCategory.Text = "Customer:"
        Me.lbCustCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.tbTransQuantity.Location = New System.Drawing.Point(611, 86)
        Me.tbTransQuantity.Name = "tbTransQuantity"
        Me.tbTransQuantity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbTransQuantity.PlaceholderText = ""
        Me.tbTransQuantity.SelectedText = ""
        Me.tbTransQuantity.ShadowDecoration.Parent = Me.tbTransQuantity
        Me.tbTransQuantity.Size = New System.Drawing.Size(97, 36)
        Me.tbTransQuantity.TabIndex = 80
        Me.tbTransQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbTransQuantity
        '
        Me.lbTransQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTransQuantity.ForeColor = System.Drawing.Color.White
        Me.lbTransQuantity.Location = New System.Drawing.Point(533, 86)
        Me.lbTransQuantity.Name = "lbTransQuantity"
        Me.lbTransQuantity.Size = New System.Drawing.Size(125, 36)
        Me.lbTransQuantity.TabIndex = 81
        Me.lbTransQuantity.Text = "Quantity:"
        Me.lbTransQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbTransTotal
        '
        Me.tbTransTotal.BorderRadius = 15
        Me.tbTransTotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbTransTotal.DefaultText = ""
        Me.tbTransTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbTransTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbTransTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbTransTotal.DisabledState.Parent = Me.tbTransTotal
        Me.tbTransTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbTransTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbTransTotal.FocusedState.Parent = Me.tbTransTotal
        Me.tbTransTotal.ForeColor = System.Drawing.Color.Black
        Me.tbTransTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbTransTotal.HoverState.Parent = Me.tbTransTotal
        Me.tbTransTotal.Location = New System.Drawing.Point(611, 128)
        Me.tbTransTotal.Name = "tbTransTotal"
        Me.tbTransTotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbTransTotal.PlaceholderText = ""
        Me.tbTransTotal.SelectedText = ""
        Me.tbTransTotal.ShadowDecoration.Parent = Me.tbTransTotal
        Me.tbTransTotal.Size = New System.Drawing.Size(97, 36)
        Me.tbTransTotal.TabIndex = 82
        Me.tbTransTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbTransTotal
        '
        Me.lbTransTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTransTotal.ForeColor = System.Drawing.Color.White
        Me.lbTransTotal.Location = New System.Drawing.Point(533, 128)
        Me.lbTransTotal.Name = "lbTransTotal"
        Me.lbTransTotal.Size = New System.Drawing.Size(125, 36)
        Me.lbTransTotal.TabIndex = 83
        Me.lbTransTotal.Text = "Total:"
        Me.lbTransTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TransactionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(931, 729)
        Me.Controls.Add(Me.tbTransTotal)
        Me.Controls.Add(Me.lbTransTotal)
        Me.Controls.Add(Me.tbTransQuantity)
        Me.Controls.Add(Me.lbTransQuantity)
        Me.Controls.Add(Me.tbTransCustomer)
        Me.Controls.Add(Me.lbCustCategory)
        Me.Controls.Add(Me.tbTransOrder)
        Me.Controls.Add(Me.lbProdOrder)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.btHome)
        Me.Controls.Add(Me.bt_Clear)
        Me.Controls.Add(Me.bt_Delete)
        Me.Controls.Add(Me.bt_Edit)
        Me.Controls.Add(Me.bt_Add)
        Me.Controls.Add(Me.tbTransDate)
        Me.Controls.Add(Me.lbTransactionDate)
        Me.Controls.Add(Me.tbTransID)
        Me.Controls.Add(Me.lbTransactID)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TransactionForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TransactionForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.db_Datagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbCatergory As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents bt_Reset As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents lbTransacList As Label
    Friend WithEvents bt_Find As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents tb_SearchBar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents btHome As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents bt_Clear As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents bt_Delete As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents bt_Edit As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents bt_Add As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents tbTransDate As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbTransactionDate As Label
    Friend WithEvents tbTransID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbTransactID As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents db_Datagrid As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents tbTransOrder As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbProdOrder As Label
    Friend WithEvents tbTransCustomer As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbCustCategory As Label
    Friend WithEvents tbTransQuantity As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbTransQuantity As Label
    Friend WithEvents tbTransTotal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbTransTotal As Label
End Class
