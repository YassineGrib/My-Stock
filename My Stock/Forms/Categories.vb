Imports System.Data.SqlClient
Public Class Categories
    ReadOnly SQLCONN As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\MVS\My Stock\My Stock\Database\MSDB.mdf;Integrated Security=True")

    Private Sub Categories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'fill Username DataGridView from DB  
        Try
            Dim SQLCMD As New SqlCommand($"select * from Categories_tbl", SQLCONN)
            Dim adapter As New SqlDataAdapter(SQLCMD)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView.DataSource = table
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub ADDButton_Click(sender As Object, e As EventArgs) Handles ADDButton.Click
        If categoryTextBox.Text = String.Empty Then
            MsgBox("Please entry the category!", MsgBoxStyle.Exclamation)
        ElseIf TypeComboBox.Text = String.Empty Then
            MsgBox("Please entry the Type!", MsgBoxStyle.Exclamation)
        Else
            Dim SQLCMD As New SqlCommand($"select category from Categories_tbl where category='{CategoryTextBox.Text}' ", SQLCONN)
            Dim adapter As New SqlDataAdapter(SQLCMD)
            Dim table As New DataTable()
            adapter.Fill(table)
            If table.Rows.Count = 0 Then
                Dim SQLCMDADD As New SqlCommand($"INSERT INTO Categories_tbl ([category],[Type] ) 
                                                VALUES ('{CategoryTextBox.Text}','{TypeComboBox.Text}') ", SQLCONN)
                SQLCONN.Open()
                SQLCMDADD.ExecuteNonQuery()
                SQLCONN.Close()
                MsgBox($"category {CategoryTextBox.Text} Has ben add successfully!", MsgBoxStyle.Information)
            Else
                MsgBox($"category {CategoryTextBox.Text} already exists!", MsgBoxStyle.Exclamation)
            End If
        End If

        'fill Username DataGridView from DB  
        Try
            Dim SQLCMD As New SqlCommand($"select * from Categories_tbl", SQLCONN)
            Dim adapter As New SqlDataAdapter(SQLCMD)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView.DataSource = table
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView.CellClick
        CategoryTextBox.Text = DataGridView.SelectedRows(0).Cells(1).Value.ToString
    End Sub

    Private Sub DELButton_Click(sender As Object, e As EventArgs) Handles DELButton.Click
        If CategoryTextBox.Text = "" Then
            MsgBox("Please select a category First!", MsgBoxStyle.Information)
        Else
            MsgBox($"Are you sure to delete  {CategoryTextBox.Text} category  !", MsgBoxStyle.YesNo)
            If MsgBoxResult.Yes Then
                Try
                    Dim SQLCMDDEL As New SqlCommand($"Delete FROM Categories_tbl WHERE category ='{CategoryTextBox.Text}' ", SQLCONN)
                    SQLCONN.Open()
                    SQLCMDDEL.ExecuteNonQuery()
                    SQLCONN.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If

        'fill Username DataGridView from DB  
        Try
            Dim SQLCMD As New SqlCommand($"select * from Categories_tbl", SQLCONN)
            Dim adapter As New SqlDataAdapter(SQLCMD)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView.DataSource = table
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class