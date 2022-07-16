<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StockInHistory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StockInHistory))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.SubmitButton2 = New Guna.UI2.WinForms.Guna2Button()
        Me.BonIDTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2VSeparator1 = New Guna.UI2.WinForms.Guna2VSeparator()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.DataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.PrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(1379, 13)
        Me.Guna2PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(52, 52)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox2.TabIndex = 98
        Me.Guna2PictureBox2.TabStop = False
        Me.Guna2PictureBox2.UseTransparentBackground = True
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
        Me.SubmitButton2.Location = New System.Drawing.Point(1088, 188)
        Me.SubmitButton2.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.SubmitButton2.Name = "SubmitButton2"
        Me.SubmitButton2.Size = New System.Drawing.Size(329, 58)
        Me.SubmitButton2.TabIndex = 107
        Me.SubmitButton2.Text = "Print"
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
        Me.BonIDTextBox.Location = New System.Drawing.Point(37, 188)
        Me.BonIDTextBox.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BonIDTextBox.Name = "BonIDTextBox"
        Me.BonIDTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BonIDTextBox.PlaceholderText = ""
        Me.BonIDTextBox.ReadOnly = True
        Me.BonIDTextBox.SelectedText = ""
        Me.BonIDTextBox.Size = New System.Drawing.Size(1043, 58)
        Me.BonIDTextBox.TabIndex = 106
        Me.BonIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 163)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 23)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "BonID "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(124, 30)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(583, 81)
        Me.Label4.TabIndex = 110
        Me.Label4.Text = "Stock Input History"
        '
        'Guna2VSeparator1
        '
        Me.Guna2VSeparator1.AccessibleName = "S1"
        Me.Guna2VSeparator1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Guna2VSeparator1.FillColor = System.Drawing.Color.RoyalBlue
        Me.Guna2VSeparator1.Location = New System.Drawing.Point(112, 10)
        Me.Guna2VSeparator1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2VSeparator1.Name = "Guna2VSeparator1"
        Me.Guna2VSeparator1.Size = New System.Drawing.Size(5, 124)
        Me.Guna2VSeparator1.TabIndex = 109
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(4, 10)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 108
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
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
        Me.DataGridView.Location = New System.Drawing.Point(32, 265)
        Me.DataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.ReadOnly = True
        Me.DataGridView.RowHeadersVisible = False
        Me.DataGridView.RowHeadersWidth = 51
        Me.DataGridView.RowTemplate.Height = 24
        Me.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView.Size = New System.Drawing.Size(1380, 292)
        Me.DataGridView.TabIndex = 111
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
        'PrintDocument
        '
        '
        'PrintPreviewDialog
        '
        Me.PrintPreviewDialog.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog.Enabled = True
        Me.PrintPreviewDialog.Icon = CType(resources.GetObject("PrintPreviewDialog.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog.Name = "PrintPreviewDialog"
        Me.PrintPreviewDialog.Visible = False
        '
        'StockInHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1444, 778)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Guna2VSeparator1)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.SubmitButton2)
        Me.Controls.Add(Me.BonIDTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StockInHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StockInHistory"
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents SubmitButton2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BonIDTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2VSeparator1 As Guna.UI2.WinForms.Guna2VSeparator
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents DataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents PrintDocument As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog As PrintPreviewDialog
End Class
