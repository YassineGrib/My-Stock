<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StockIN
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StockIN))
        Me.DateTimePicker = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.QtyNumericUpDown = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DELButton = New Guna.UI2.WinForms.Guna2Button()
        Me.ADDButton = New Guna.UI2.WinForms.Guna2Button()
        Me.DataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.BonID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InputDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemIDTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BonIDTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2VSeparator1 = New Guna.UI2.WinForms.Guna2VSeparator()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.UnityComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.SubmitButton2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.TypeComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CategoryComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.ItemComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        CType(Me.QtyNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker
        '
        Me.DateTimePicker.Checked = True
        Me.DateTimePicker.FillColor = System.Drawing.Color.White
        Me.DateTimePicker.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DateTimePicker.Location = New System.Drawing.Point(35, 262)
        Me.DateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(670, 56)
        Me.DateTimePicker.TabIndex = 0
        Me.DateTimePicker.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DateTimePicker.Value = New Date(2022, 7, 13, 21, 9, 42, 905)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 152)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 23)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "BonID "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 238)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 23)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(374, 152)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 23)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Item ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(35, 406)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 23)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Item Name"
        '
        'QtyNumericUpDown
        '
        Me.QtyNumericUpDown.BackColor = System.Drawing.Color.Transparent
        Me.QtyNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.QtyNumericUpDown.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.QtyNumericUpDown.ForeColor = System.Drawing.Color.Black
        Me.QtyNumericUpDown.Location = New System.Drawing.Point(1074, 179)
        Me.QtyNumericUpDown.Margin = New System.Windows.Forms.Padding(4)
        Me.QtyNumericUpDown.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.QtyNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.QtyNumericUpDown.Name = "QtyNumericUpDown"
        Me.QtyNumericUpDown.Size = New System.Drawing.Size(332, 58)
        Me.QtyNumericUpDown.TabIndex = 24
        Me.QtyNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1070, 152)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 23)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Quantity"
        '
        'DELButton
        '
        Me.DELButton.Animated = True
        Me.DELButton.BackColor = System.Drawing.Color.RoyalBlue
        Me.DELButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.DELButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.DELButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.DELButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.DELButton.FillColor = System.Drawing.Color.Crimson
        Me.DELButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DELButton.ForeColor = System.Drawing.Color.White
        Me.DELButton.Location = New System.Drawing.Point(1083, 346)
        Me.DELButton.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.DELButton.Name = "DELButton"
        Me.DELButton.Size = New System.Drawing.Size(329, 58)
        Me.DELButton.TabIndex = 77
        Me.DELButton.Text = "Delete"
        '
        'ADDButton
        '
        Me.ADDButton.Animated = True
        Me.ADDButton.BackColor = System.Drawing.Color.RoyalBlue
        Me.ADDButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ADDButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ADDButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ADDButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ADDButton.FillColor = System.Drawing.Color.ForestGreen
        Me.ADDButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.ADDButton.ForeColor = System.Drawing.Color.White
        Me.ADDButton.Location = New System.Drawing.Point(734, 346)
        Me.ADDButton.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.ADDButton.Name = "ADDButton"
        Me.ADDButton.Size = New System.Drawing.Size(329, 58)
        Me.ADDButton.TabIndex = 76
        Me.ADDButton.Text = "Add"
        '
        'DataGridView
        '
        Me.DataGridView.AllowUserToAddRows = False
        Me.DataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView.ColumnHeadersHeight = 58
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BonID, Me.ItemID, Me.InputDate, Me.Type, Me.Category, Me.ItemName, Me.Unity, Me.Quantity})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView.EnableHeadersVisualStyles = False
        Me.DataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView.Location = New System.Drawing.Point(32, 515)
        Me.DataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.ReadOnly = True
        Me.DataGridView.RowHeadersVisible = False
        Me.DataGridView.RowHeadersWidth = 51
        Me.DataGridView.RowTemplate.Height = 24
        Me.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView.Size = New System.Drawing.Size(1380, 249)
        Me.DataGridView.TabIndex = 78
        Me.DataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DataGridView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DataGridView.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridView.ThemeStyle.HeaderStyle.Height = 58
        Me.DataGridView.ThemeStyle.ReadOnly = True
        Me.DataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DataGridView.ThemeStyle.RowsStyle.Height = 24
        Me.DataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'BonID
        '
        Me.BonID.HeaderText = "Bon ID"
        Me.BonID.MinimumWidth = 6
        Me.BonID.Name = "BonID"
        Me.BonID.ReadOnly = True
        '
        'ItemID
        '
        Me.ItemID.HeaderText = "Item ID"
        Me.ItemID.MinimumWidth = 6
        Me.ItemID.Name = "ItemID"
        Me.ItemID.ReadOnly = True
        '
        'InputDate
        '
        Me.InputDate.HeaderText = "Input Date"
        Me.InputDate.MinimumWidth = 6
        Me.InputDate.Name = "InputDate"
        Me.InputDate.ReadOnly = True
        '
        'Type
        '
        Me.Type.HeaderText = "Type"
        Me.Type.MinimumWidth = 6
        Me.Type.Name = "Type"
        Me.Type.ReadOnly = True
        '
        'Category
        '
        Me.Category.HeaderText = "Category"
        Me.Category.MinimumWidth = 6
        Me.Category.Name = "Category"
        Me.Category.ReadOnly = True
        '
        'ItemName
        '
        Me.ItemName.HeaderText = "Item Name"
        Me.ItemName.MinimumWidth = 6
        Me.ItemName.Name = "ItemName"
        Me.ItemName.ReadOnly = True
        '
        'Unity
        '
        Me.Unity.HeaderText = "Unity"
        Me.Unity.MinimumWidth = 6
        Me.Unity.Name = "Unity"
        Me.Unity.ReadOnly = True
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.MinimumWidth = 6
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        '
        'ItemIDTextBox
        '
        Me.ItemIDTextBox.Animated = True
        Me.ItemIDTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ItemIDTextBox.DefaultText = "1"
        Me.ItemIDTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ItemIDTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ItemIDTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ItemIDTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ItemIDTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ItemIDTextBox.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.ItemIDTextBox.ForeColor = System.Drawing.Color.Black
        Me.ItemIDTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ItemIDTextBox.IconLeftSize = New System.Drawing.Size(32, 32)
        Me.ItemIDTextBox.IconRight = CType(resources.GetObject("ItemIDTextBox.IconRight"), System.Drawing.Image)
        Me.ItemIDTextBox.IconRightOffset = New System.Drawing.Point(3, 0)
        Me.ItemIDTextBox.IconRightSize = New System.Drawing.Size(25, 25)
        Me.ItemIDTextBox.Location = New System.Drawing.Point(374, 176)
        Me.ItemIDTextBox.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.ItemIDTextBox.Name = "ItemIDTextBox"
        Me.ItemIDTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ItemIDTextBox.PlaceholderText = ""
        Me.ItemIDTextBox.ReadOnly = True
        Me.ItemIDTextBox.SelectedText = ""
        Me.ItemIDTextBox.Size = New System.Drawing.Size(331, 58)
        Me.ItemIDTextBox.TabIndex = 87
        Me.ItemIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BonIDTextBox
        '
        Me.BonIDTextBox.Animated = True
        Me.BonIDTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BonIDTextBox.DefaultText = ""
        Me.BonIDTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.BonIDTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BonIDTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.BonIDTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.BonIDTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BonIDTextBox.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.BonIDTextBox.ForeColor = System.Drawing.Color.Black
        Me.BonIDTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BonIDTextBox.IconLeftSize = New System.Drawing.Size(32, 32)
        Me.BonIDTextBox.IconRight = CType(resources.GetObject("BonIDTextBox.IconRight"), System.Drawing.Image)
        Me.BonIDTextBox.IconRightOffset = New System.Drawing.Point(3, 0)
        Me.BonIDTextBox.IconRightSize = New System.Drawing.Size(25, 25)
        Me.BonIDTextBox.Location = New System.Drawing.Point(35, 176)
        Me.BonIDTextBox.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BonIDTextBox.Name = "BonIDTextBox"
        Me.BonIDTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BonIDTextBox.PlaceholderText = ""
        Me.BonIDTextBox.ReadOnly = True
        Me.BonIDTextBox.SelectedText = ""
        Me.BonIDTextBox.Size = New System.Drawing.Size(331, 58)
        Me.BonIDTextBox.TabIndex = 88
        Me.BonIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(378, 322)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 23)
        Me.Label10.TabIndex = 90
        Me.Label10.Text = "Category"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(35, 322)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 23)
        Me.Label11.TabIndex = 89
        Me.Label11.Text = "Type"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(730, 154)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 23)
        Me.Label6.TabIndex = 93
        Me.Label6.Text = "Unity"
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(1378, 15)
        Me.Guna2PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(52, 52)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox2.TabIndex = 97
        Me.Guna2PictureBox2.TabStop = False
        Me.Guna2PictureBox2.UseTransparentBackground = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(132, 29)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(359, 81)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "Stock Input"
        '
        'Guna2VSeparator1
        '
        Me.Guna2VSeparator1.AccessibleName = "S1"
        Me.Guna2VSeparator1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Guna2VSeparator1.FillColor = System.Drawing.Color.RoyalBlue
        Me.Guna2VSeparator1.Location = New System.Drawing.Point(120, 9)
        Me.Guna2VSeparator1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2VSeparator1.Name = "Guna2VSeparator1"
        Me.Guna2VSeparator1.Size = New System.Drawing.Size(5, 124)
        Me.Guna2VSeparator1.TabIndex = 99
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(12, 9)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 98
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'UnityComboBox
        '
        Me.UnityComboBox.BackColor = System.Drawing.Color.Transparent
        Me.UnityComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.UnityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UnityComboBox.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UnityComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UnityComboBox.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.UnityComboBox.ForeColor = System.Drawing.Color.Black
        Me.UnityComboBox.ItemHeight = 40
        Me.UnityComboBox.Items.AddRange(New Object() {"U", "M", "G", "L"})
        Me.UnityComboBox.Location = New System.Drawing.Point(734, 179)
        Me.UnityComboBox.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.UnityComboBox.Name = "UnityComboBox"
        Me.UnityComboBox.Size = New System.Drawing.Size(328, 46)
        Me.UnityComboBox.TabIndex = 103
        Me.UnityComboBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SubmitButton2
        '
        Me.SubmitButton2.Animated = True
        Me.SubmitButton2.BackColor = System.Drawing.Color.RoyalBlue
        Me.SubmitButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.SubmitButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.SubmitButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.SubmitButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.SubmitButton2.FillColor = System.Drawing.Color.RoyalBlue
        Me.SubmitButton2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.SubmitButton2.ForeColor = System.Drawing.Color.White
        Me.SubmitButton2.Location = New System.Drawing.Point(734, 430)
        Me.SubmitButton2.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.SubmitButton2.Name = "SubmitButton2"
        Me.SubmitButton2.Size = New System.Drawing.Size(329, 58)
        Me.SubmitButton2.TabIndex = 104
        Me.SubmitButton2.Text = "Submit"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.SlateGray
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(1083, 430)
        Me.Guna2Button1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(329, 58)
        Me.Guna2Button1.TabIndex = 105
        Me.Guna2Button1.Text = "History"
        '
        'TypeComboBox
        '
        Me.TypeComboBox.BackColor = System.Drawing.Color.Transparent
        Me.TypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TypeComboBox.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TypeComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TypeComboBox.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.TypeComboBox.ForeColor = System.Drawing.Color.Black
        Me.TypeComboBox.ItemHeight = 40
        Me.TypeComboBox.Items.AddRange(New Object() {"Consommable", "Non-Consommable"})
        Me.TypeComboBox.Location = New System.Drawing.Point(39, 347)
        Me.TypeComboBox.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TypeComboBox.Name = "TypeComboBox"
        Me.TypeComboBox.Size = New System.Drawing.Size(327, 46)
        Me.TypeComboBox.TabIndex = 106
        Me.TypeComboBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CategoryComboBox
        '
        Me.CategoryComboBox.BackColor = System.Drawing.Color.White
        Me.CategoryComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoryComboBox.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CategoryComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CategoryComboBox.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.CategoryComboBox.ForeColor = System.Drawing.Color.Black
        Me.CategoryComboBox.ItemHeight = 40
        Me.CategoryComboBox.Location = New System.Drawing.Point(382, 346)
        Me.CategoryComboBox.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.CategoryComboBox.Name = "CategoryComboBox"
        Me.CategoryComboBox.Size = New System.Drawing.Size(327, 46)
        Me.CategoryComboBox.TabIndex = 107
        Me.CategoryComboBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ItemComboBox
        '
        Me.ItemComboBox.BackColor = System.Drawing.Color.Transparent
        Me.ItemComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ItemComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ItemComboBox.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ItemComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ItemComboBox.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.ItemComboBox.ForeColor = System.Drawing.Color.Black
        Me.ItemComboBox.ItemHeight = 40
        Me.ItemComboBox.Location = New System.Drawing.Point(39, 431)
        Me.ItemComboBox.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.ItemComboBox.Name = "ItemComboBox"
        Me.ItemComboBox.Size = New System.Drawing.Size(666, 46)
        Me.ItemComboBox.TabIndex = 108
        Me.ItemComboBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'StockIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1444, 778)
        Me.Controls.Add(Me.ItemComboBox)
        Me.Controls.Add(Me.CategoryComboBox)
        Me.Controls.Add(Me.TypeComboBox)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.SubmitButton2)
        Me.Controls.Add(Me.UnityComboBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Guna2VSeparator1)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.Guna2PictureBox2)
        Me.Controls.Add(Me.DELButton)
        Me.Controls.Add(Me.ADDButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.BonIDTextBox)
        Me.Controls.Add(Me.ItemIDTextBox)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.QtyNumericUpDown)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "StockIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StockIN"
        CType(Me.QtyNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePicker As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents QtyNumericUpDown As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents DELButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ADDButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents ItemIDTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BonIDTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2VSeparator1 As Guna.UI2.WinForms.Guna2VSeparator
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents UnityComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents SubmitButton2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BonID As DataGridViewTextBoxColumn
    Friend WithEvents ItemID As DataGridViewTextBoxColumn
    Friend WithEvents InputDate As DataGridViewTextBoxColumn
    Friend WithEvents Type As DataGridViewTextBoxColumn
    Friend WithEvents Category As DataGridViewTextBoxColumn
    Friend WithEvents ItemName As DataGridViewTextBoxColumn
    Friend WithEvents Unity As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TypeComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CategoryComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents ItemComboBox As Guna.UI2.WinForms.Guna2ComboBox
End Class
