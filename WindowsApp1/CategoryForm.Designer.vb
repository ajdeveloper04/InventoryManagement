<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CategoryForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btHome = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.bt_Clear = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.bt_Delete = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.bt_Edit = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.bt_Add = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.tbCatName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbCategoryName = New System.Windows.Forms.Label()
        Me.tbCategoryID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbCategoryID = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.db_Datagrid = New Guna.UI.WinForms.GunaDataGridView()
        Me.bt_Reset = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.lbCatList = New System.Windows.Forms.Label()
        Me.bt_Find = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.tb_SearchBar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.lbCatergory = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox3 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Panel2.SuspendLayout()
        CType(Me.db_Datagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.btHome.TabIndex = 62
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
        Me.bt_Clear.TabIndex = 59
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
        Me.bt_Delete.TabIndex = 58
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
        Me.bt_Edit.TabIndex = 57
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
        Me.bt_Add.TabIndex = 56
        Me.bt_Add.Text = "Add"
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
        Me.tbCatName.Location = New System.Drawing.Point(154, 128)
        Me.tbCatName.Name = "tbCatName"
        Me.tbCatName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbCatName.PlaceholderText = ""
        Me.tbCatName.SelectedText = ""
        Me.tbCatName.ShadowDecoration.Parent = Me.tbCatName
        Me.tbCatName.Size = New System.Drawing.Size(344, 36)
        Me.tbCatName.TabIndex = 47
        Me.tbCatName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbCategoryName
        '
        Me.lbCategoryName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCategoryName.ForeColor = System.Drawing.Color.White
        Me.lbCategoryName.Location = New System.Drawing.Point(23, 128)
        Me.lbCategoryName.Name = "lbCategoryName"
        Me.lbCategoryName.Size = New System.Drawing.Size(148, 36)
        Me.lbCategoryName.TabIndex = 50
        Me.lbCategoryName.Text = "Category Name:"
        Me.lbCategoryName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbCategoryID
        '
        Me.tbCategoryID.BorderRadius = 15
        Me.tbCategoryID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbCategoryID.DefaultText = ""
        Me.tbCategoryID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbCategoryID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbCategoryID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbCategoryID.DisabledState.Parent = Me.tbCategoryID
        Me.tbCategoryID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbCategoryID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbCategoryID.FocusedState.Parent = Me.tbCategoryID
        Me.tbCategoryID.ForeColor = System.Drawing.Color.Black
        Me.tbCategoryID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbCategoryID.HoverState.Parent = Me.tbCategoryID
        Me.tbCategoryID.Location = New System.Drawing.Point(154, 86)
        Me.tbCategoryID.Name = "tbCategoryID"
        Me.tbCategoryID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbCategoryID.PlaceholderText = ""
        Me.tbCategoryID.SelectedText = ""
        Me.tbCategoryID.ShadowDecoration.Parent = Me.tbCategoryID
        Me.tbCategoryID.Size = New System.Drawing.Size(97, 36)
        Me.tbCategoryID.TabIndex = 46
        Me.tbCategoryID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbCategoryID
        '
        Me.lbCategoryID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCategoryID.ForeColor = System.Drawing.Color.White
        Me.lbCategoryID.Location = New System.Drawing.Point(23, 86)
        Me.lbCategoryID.Name = "lbCategoryID"
        Me.lbCategoryID.Size = New System.Drawing.Size(125, 36)
        Me.lbCategoryID.TabIndex = 48
        Me.lbCategoryID.Text = "CatID:"
        Me.lbCategoryID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.db_Datagrid)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 317)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(931, 383)
        Me.Panel2.TabIndex = 60
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
        Me.db_Datagrid.Size = New System.Drawing.Size(931, 383)
        Me.db_Datagrid.TabIndex = 1
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
        'lbCatList
        '
        Me.lbCatList.BackColor = System.Drawing.Color.Transparent
        Me.lbCatList.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbCatList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCatList.ForeColor = System.Drawing.Color.White
        Me.lbCatList.Location = New System.Drawing.Point(4, 4)
        Me.lbCatList.Name = "lbCatList"
        Me.lbCatList.Size = New System.Drawing.Size(156, 36)
        Me.lbCatList.TabIndex = 20
        Me.lbCatList.Text = "Category List"
        Me.lbCatList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.bt_Reset)
        Me.Panel3.Controls.Add(Me.lbCatList)
        Me.Panel3.Controls.Add(Me.bt_Find)
        Me.Panel3.Controls.Add(Me.tb_SearchBar)
        Me.Panel3.Location = New System.Drawing.Point(0, 273)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(4)
        Me.Panel3.Size = New System.Drawing.Size(931, 44)
        Me.Panel3.TabIndex = 61
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 700)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(931, 29)
        Me.FlowLayoutPanel2.TabIndex = 45
        '
        'lbCatergory
        '
        Me.lbCatergory.AutoSize = True
        Me.lbCatergory.BackColor = System.Drawing.Color.Transparent
        Me.lbCatergory.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCatergory.ForeColor = System.Drawing.Color.White
        Me.lbCatergory.Location = New System.Drawing.Point(378, 39)
        Me.lbCatergory.Name = "lbCatergory"
        Me.lbCatergory.Size = New System.Drawing.Size(133, 21)
        Me.lbCatergory.TabIndex = 6
        Me.lbCatergory.Text = "Manage Category"
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
        Me.Panel1.TabIndex = 44
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Nothing
        '
        'CategoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(931, 729)
        Me.Controls.Add(Me.btHome)
        Me.Controls.Add(Me.bt_Clear)
        Me.Controls.Add(Me.bt_Delete)
        Me.Controls.Add(Me.bt_Edit)
        Me.Controls.Add(Me.bt_Add)
        Me.Controls.Add(Me.tbCatName)
        Me.Controls.Add(Me.lbCategoryName)
        Me.Controls.Add(Me.tbCategoryID)
        Me.Controls.Add(Me.lbCategoryID)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CategoryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CategoryForm"
        Me.Panel2.ResumeLayout(False)
        CType(Me.db_Datagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btHome As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents bt_Clear As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents bt_Delete As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents bt_Edit As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents bt_Add As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents tbCatName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbCategoryName As Label
    Friend WithEvents tbCategoryID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbCategoryID As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents bt_Reset As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents lbCatList As Label
    Friend WithEvents bt_Find As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents tb_SearchBar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents lbCatergory As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents db_Datagrid As Guna.UI.WinForms.GunaDataGridView
End Class
