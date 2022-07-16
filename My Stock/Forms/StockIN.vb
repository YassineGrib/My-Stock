Imports System.Data.SqlClient

Public Class StockIN

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub DataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView.CellContentClick

    End Sub

    Private Sub StockIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'get BONID 
        Try
            Dim selectSQLCMD As New SqlCommand("SELECT MAX(BonId) as lastID FROM StockIn", SQLCONN)
            Dim adapter As New SqlDataAdapter(selectSQLCMD)
            Dim table As New DataTable()
            adapter.Fill(table)
            If table.Rows(0)("LastID").ToString = Nothing Then
                BonIDTextBox.Text = 1
            Else
                BonIDTextBox.Text = table.Rows(0)("LastID") + 1
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try


        'Today date in DateTimerPicker
        DateTimePicker.Value = DateTime.Now


        'Fill textBox From DataBase // guna bug 
        'Try
        '    Dim selectSQLCMD As New SqlCommand("SELECT item FROM items_tbl", SQLCONN)
        '    Dim ds As New DataSet
        '    Dim adapter As New SqlDataAdapter(selectSQLCMD)
        '    adapter.Fill(ds, "list")
        '    Dim col As New AutoCompleteStringCollection
        '    Dim i As Integer
        '    For i = 0 To ds.Tables(0).Rows.Count - 1
        '        col.Add(ds.Tables(0).Rows(i)("item").ToString())
        '    Next
        '    ItemtextBox.AutoCompleteSource = AutoCompleteSource.CustomSource
        '    ItemtextBox.AutoCompleteCustomSource = col
        '    ItemtextBox.AutoCompleteMode = AutoCompleteMode.Suggest
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical)
        'End Try




    End Sub

    Private Sub ADDButton_Click(sender As Object, e As EventArgs) Handles ADDButton.Click

        If TypeComboBox.Text = String.Empty Then
            MsgBox("Type Cant be null !", MsgBoxStyle.Exclamation)
        ElseIf CategoryComboBox.Text = String.Empty Then
            MsgBox("Category Cant be null !", MsgBoxStyle.Exclamation)
        ElseIf ItemComboBox.Text = String.Empty Then
            MsgBox("Item Cant be null !", MsgBoxStyle.Exclamation)
        Else
            DataGridView.Rows.Add(BonIDTextBox.Text, ItemIDTextBox.Text, DateTimePicker.Value, TypeComboBox.Text, CategoryComboBox.Text, ItemComboBox.Text, UnityComboBox.Text, QtyNumericUpDown.Value)
            ItemIDTextBox.Text = ItemIDTextBox.Text + 1
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles SubmitButton2.Click

        If DataGridView.Rows.Count <= 0 Then
            MsgBox("Table Is vide !", MsgBoxStyle.Exclamation)
        Else
            SQLCONN.Open()
            For row As Integer = 0 To DataGridView.Rows.Count - 1
                Dim InsertSQLCMD As New SqlCommand($"insert Into StockIn (bonID,ItemID,UserName,Date,Category,Type,ItemName,Unity,Quantity)
                                        VALUES (@bonID,@ItemID,@UserName,@Date,@Category,@Type,@ItemName,@Unity,@Quantity)", SQLCONN)
                With InsertSQLCMD
                    .Parameters.AddWithValue("@bonID", DataGridView.Rows(row).Cells(0).Value)
                    .Parameters.AddWithValue("@ItemID", DataGridView.Rows(row).Cells(1).Value)
                    .Parameters.AddWithValue("@Date", DataGridView.Rows(row).Cells(2).Value)
                    .Parameters.AddWithValue("@Type", DataGridView.Rows(row).Cells(3).Value.ToString)
                    .Parameters.AddWithValue("@Category", DataGridView.Rows(row).Cells(4).Value.ToString)
                    .Parameters.AddWithValue("@ItemName", DataGridView.Rows(row).Cells(5).Value.ToString)
                    .Parameters.AddWithValue("@Unity", DataGridView.Rows(row).Cells(6).Value.ToString)
                    .Parameters.AddWithValue("@Quantity", DataGridView.Rows(row).Cells(7).Value)
                    .Parameters.AddWithValue("@UserName", MyStock.UsernameLabel.Text)
                End With

                InsertSQLCMD.ExecuteNonQuery()
            Next
            SQLCONN.Close()

            DataGridView.Rows.Clear()

            'get BONID 
            Try
                Dim selectSQLCMD As New SqlCommand("SELECT MAX(BonId) as lastID FROM StockIn", SQLCONN)
                Dim adapter As New SqlDataAdapter(selectSQLCMD)
                Dim table As New DataTable()
                adapter.Fill(table)
                If table.Rows(0)("LastID").ToString = Nothing Then
                    BonIDTextBox.Text = 1
                Else
                    BonIDTextBox.Text = table.Rows(0)("LastID") + 1
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If

        ItemIDTextBox.Text = 1

    End Sub

    Private Sub DELButton_Click(sender As Object, e As EventArgs) Handles DELButton.Click

        For Each DataGridViewRow In DataGridView.SelectedRows
            DataGridView.Rows.Remove(DataGridViewRow)
        Next

        For i As Integer = 0 To DataGridView.Rows.Count - 1
            DataGridView.Rows(i).Cells(1).Value = i + 1
            ItemIDTextBox.Text = i + 2
        Next


    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        StockInHistory.Show()
    End Sub

    Private Sub DateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker.ValueChanged

        If DateTimePicker.Value > DateTime.Now Then
            MsgBox("You can't select this date !", MsgBoxStyle.Exclamation)
            DateTimePicker.Value = DateTime.Now
        End If

    End Sub

    Private Sub ItemComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CategoryComboBox.SelectedIndexChanged
        'get itemsComboBox 
        Try
            Dim selectSQLCMD As New SqlCommand($"SELECT DISTINCT item FROM items_tbl WHERE category='{CategoryComboBox.Text}'", SQLCONN)
            Dim adapter As New SqlDataAdapter(selectSQLCMD)
            Dim table As New DataTable()
            adapter.Fill(table)
            ItemComboBox.DataSource = table
            ItemComboBox.DisplayMember = "item"
            ItemComboBox.ValueMember = "item"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub TypeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TypeComboBox.SelectedIndexChanged

        'get CategoryComboBox 
        Try
            Dim selectSQLCMD As New SqlCommand($"SELECT DISTINCT Category FROM items_tbl WHERE type='{TypeComboBox.Text}'", SQLCONN)
            Dim adapter As New SqlDataAdapter(selectSQLCMD)
            Dim table As New DataTable()
            adapter.Fill(table)
            CategoryComboBox.DataSource = table
            CategoryComboBox.DisplayMember = "Category"
            CategoryComboBox.ValueMember = "Category"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try


    End Sub


End Class