<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Items
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Items))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DELButton = New Guna.UI2.WinForms.Guna2Button()
        Me.DataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.itemTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CategoryComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.ADDButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2VSeparator1 = New Guna.UI2.WinForms.Guna2VSeparator()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TypeComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label5.Location = New System.Drawing.Point(133, 32)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(457, 81)
        Me.Label5.TabIndex = 91
        Me.Label5.Text = "Items Manager"
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
        Me.DELButton.Location = New System.Drawing.Point(836, 316)
        Me.DELButton.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.DELButton.Name = "DELButton"
        Me.DELButton.Size = New System.Drawing.Size(567, 58)
        Me.DELButton.TabIndex = 90
        Me.DELButton.Text = "Delete"
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
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Type, Me.Category, Me.Item})
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
        Me.DataGridView.Location = New System.Drawing.Point(38, 482)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.ReadOnly = True
        Me.DataGridView.RowHeadersVisible = False
        Me.DataGridView.RowHeadersWidth = 51
        Me.DataGridView.RowTemplate.Height = 24
        Me.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView.Size = New System.Drawing.Size(1365, 249)
        Me.DataGridView.TabIndex = 89
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(34, 291)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 23)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "Category"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 376)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 23)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "Item name"
        '
        'itemTextBox
        '
        Me.itemTextBox.Animated = True
        Me.itemTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.itemTextBox.DefaultText = ""
        Me.itemTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.itemTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.itemTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.itemTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.itemTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.itemTextBox.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.itemTextBox.ForeColor = System.Drawing.Color.Black
        Me.itemTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.itemTextBox.IconLeftSize = New System.Drawing.Size(32, 32)
        Me.itemTextBox.IconRight = CType(resources.GetObject("itemTextBox.IconRight"), System.Drawing.Image)
        Me.itemTextBox.IconRightOffset = New System.Drawing.Point(3, 0)
        Me.itemTextBox.IconRightSize = New System.Drawing.Size(25, 25)
        Me.itemTextBox.Location = New System.Drawing.Point(38, 401)
        Me.itemTextBox.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.itemTextBox.Name = "itemTextBox"
        Me.itemTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.itemTextBox.PlaceholderText = ""
        Me.itemTextBox.SelectedText = ""
        Me.itemTextBox.Size = New System.Drawing.Size(775, 58)
        Me.itemTextBox.TabIndex = 84
        Me.itemTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CategoryComboBox
        '
        Me.CategoryComboBox.BackColor = System.Drawing.Color.Transparent
        Me.CategoryComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoryComboBox.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CategoryComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CategoryComboBox.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.CategoryComboBox.ForeColor = System.Drawing.Color.Black
        Me.CategoryComboBox.ItemHeight = 40
        Me.CategoryComboBox.Location = New System.Drawing.Point(38, 316)
        Me.CategoryComboBox.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.CategoryComboBox.Name = "CategoryComboBox"
        Me.CategoryComboBox.Size = New System.Drawing.Size(775, 46)
        Me.CategoryComboBox.TabIndex = 83
        Me.CategoryComboBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.ADDButton.Location = New System.Drawing.Point(836, 401)
        Me.ADDButton.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.ADDButton.Name = "ADDButton"
        Me.ADDButton.Size = New System.Drawing.Size(567, 58)
        Me.ADDButton.TabIndex = 82
        Me.ADDButton.Text = "Add"
        '
        'Guna2VSeparator1
        '
        Me.Guna2VSeparator1.AccessibleName = "S1"
        Me.Guna2VSeparator1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Guna2VSeparator1.FillColor = System.Drawing.Color.RoyalBlue
        Me.Guna2VSeparator1.Location = New System.Drawing.Point(121, 13)
        Me.Guna2VSeparator1.Name = "Guna2VSeparator1"
        Me.Guna2VSeparator1.Size = New System.Drawing.Size(5, 124)
        Me.Guna2VSeparator1.TabIndex = 81
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 80
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(1375, 13)
        Me.Guna2PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(52, 52)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox2.TabIndex = 79
        Me.Guna2PictureBox2.TabStop = False
        Me.Guna2PictureBox2.UseTransparentBackground = True
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Enabled = False
        Me.Guna2Separator1.Location = New System.Drawing.Point(249, 756)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(1212, 10)
        Me.Guna2Separator1.TabIndex = 78
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Enabled = False
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DimGray
        Me.Label11.Location = New System.Drawing.Point(9, 746)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(233, 23)
        Me.Label11.TabIndex = 77
        Me.Label11.Text = "My Stock - Your data by click "
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
        Me.TypeComboBox.Location = New System.Drawing.Point(38, 231)
        Me.TypeComboBox.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TypeComboBox.Name = "TypeComboBox"
        Me.TypeComboBox.Size = New System.Drawing.Size(775, 46)
        Me.TypeComboBox.TabIndex = 97
        Me.TypeComboBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 206)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 23)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "Category Type"
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.MinimumWidth = 6
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'Type
        '
        Me.Type.DataPropertyName = "Type"
        Me.Type.HeaderText = "Type"
        Me.Type.MinimumWidth = 6
        Me.Type.Name = "Type"
        Me.Type.ReadOnly = True
        '
        'Category
        '
        Me.Category.DataPropertyName = "Category"
        Me.Category.HeaderText = "Category"
        Me.Category.MinimumWidth = 6
        Me.Category.Name = "Category"
        Me.Category.ReadOnly = True
        '
        'Item
        '
        Me.Item.DataPropertyName = "Item"
        Me.Item.HeaderText = "Item"
        Me.Item.MinimumWidth = 6
        Me.Item.Name = "Item"
        Me.Item.ReadOnly = True
        '
        'Items
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1444, 778)
        Me.Controls.Add(Me.TypeComboBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DELButton)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.itemTextBox)
        Me.Controls.Add(Me.CategoryComboBox)
        Me.Controls.Add(Me.ADDButton)
        Me.Controls.Add(Me.Guna2VSeparator1)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.Guna2PictureBox2)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Controls.Add(Me.Label11)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Items"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Items"
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents DELButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents itemTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CategoryComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents ADDButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2VSeparator1 As Guna.UI2.WinForms.Guna2VSeparator
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Label11 As Label
    Friend WithEvents TypeComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Type As DataGridViewTextBoxColumn
    Friend WithEvents Category As DataGridViewTextBoxColumn
    Friend WithEvents Item As DataGridViewTextBoxColumn
End Class
