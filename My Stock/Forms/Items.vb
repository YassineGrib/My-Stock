Imports System.Data.SqlClient
Public Class Items
    ReadOnly SQLCONN As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\MVS\My Stock\My Stock\Database\MSDB.mdf;Integrated Security=True")

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click
        Me.Close()
    End Sub
    Private Sub DataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView.CellClick
        CategoryComboBox.Text = DataGridView.SelectedRows(0).Cells(1).Value.ToString
        itemTextBox.Text = DataGridView.SelectedRows(0).Cells(2).Value.ToString
    End Sub

    Private Sub Items_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'fill Category Datagridview from DB  
        Try
            Dim SQLCMD As New SqlCommand($"select * from items_tbl", SQLCONN)
            Dim adapter As New SqlDataAdapter(SQLCMD)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView.DataSource = table
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ADDButton_Click(sender As Object, e As EventArgs) Handles ADDButton.Click
        If itemTextBox.Text = String.Empty Then
            MsgBox("Please entry the item Name!", MsgBoxStyle.Exclamation)
        ElseIf CategoryComboBox.Text = String.Empty Then
            MsgBox("Please entry the Category Name !", MsgBoxStyle.Exclamation)

        Else
            Dim SQLCMD As New SqlCommand($"select item from items_TBL where item='{itemTextBox.Text}' ", SQLCONN)
            Dim adapter As New SqlDataAdapter(SQLCMD)
            Dim table As New DataTable()
            adapter.Fill(table)
            If table.Rows.Count = 0 Then
                Dim SQLCMDADD As New SqlCommand($"INSERT INTO items_tbl ([item],[Category] ,[Type]) 
                                                VALUES ('{itemTextBox.Text}','{CategoryComboBox.Text}','{TypeComboBox.Text}') ", SQLCONN)
                SQLCONN.Open()
                SQLCMDADD.ExecuteNonQuery()
                SQLCONN.Close()
                MsgBox($"item {itemTextBox.Text} Has ben add successfully!", MsgBoxStyle.Information)
            Else
                MsgBox($"item {itemTextBox.Text} already exists!", MsgBoxStyle.Exclamation)
            End If
        End If

        'fill Category Datagridview from DB  
        Try
            Dim SQLCMD As New SqlCommand($"select * from items_tbl", SQLCONN)
            Dim adapter As New SqlDataAdapter(SQLCMD)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView.DataSource = table
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub DELButton_Click(sender As Object, e As EventArgs) Handles DELButton.Click
        If itemTextBox.Text = String.Empty Then
            MsgBox("Please select a item First!", MsgBoxStyle.Information)
        Else
            MsgBox($"Are you sure to delete {itemTextBox.Text} !", MsgBoxStyle.YesNo)
            If MsgBoxResult.Yes Then

                Try
                    Dim SQLCMDDEL As New SqlCommand($"Delete FROM items_tbl WHERE item ='{itemTextBox.Text}' ", SQLCONN)
                    SQLCONN.Open()
                    SQLCMDDEL.ExecuteNonQuery()
                    SQLCONN.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If

        'fill Category Datagridview from DB  
        Try
            Dim SQLCMD As New SqlCommand($"select * from items_tbl", SQLCONN)
            Dim adapter As New SqlDataAdapter(SQLCMD)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView.DataSource = table
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub TypeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TypeComboBox.SelectedIndexChanged





        If TypeComboBox.Text = "Consommable" Then
            'fill Category comboBox from DB  
            Try
                Dim SQLCMD As New SqlCommand($"select Category from Categories_tbl where type= 'consommable'  ", SQLCONN)
                Dim adapter As New SqlDataAdapter(SQLCMD)
                Dim table As New DataTable()
                adapter.Fill(table)
                CategoryComboBox.DataSource = table
                CategoryComboBox.ValueMember = "Category"
                CategoryComboBox.DisplayMember = "Category"
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        ElseIf TypeComboBox.Text = "Non-Consommable" Then

            'fill Category comboBox from DB  
            Try
                Dim SQLCMD As New SqlCommand($"select Category from Categories_tbl where type= 'non-consommable'  ", SQLCONN)
                Dim adapter As New SqlDataAdapter(SQLCMD)
                Dim table As New DataTable()
                adapter.Fill(table)
                CategoryComboBox.DataSource = table
                CategoryComboBox.ValueMember = "Category"
                CategoryComboBox.DisplayMember = "Category"
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If



    End Sub
End Class