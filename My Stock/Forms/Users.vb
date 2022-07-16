Imports System.Data.SqlClient
Public Class Users

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'fill Username DataGridView from DB  
        Try
            Dim SQLCMD As New SqlCommand($"select ID,Username,Privilege from User_tbl", SQLCONN)
            Dim adapter As New SqlDataAdapter(SQLCMD)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView.DataSource = table
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub UsernameComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PrivilegeComboBox.SelectedIndexChanged

    End Sub

    Private Sub ADDButton_Click(sender As Object, e As EventArgs) Handles ADDButton.Click

        If UsernameTextBox.Text = String.Empty Then
            MsgBox("Please entry the Username!", MsgBoxStyle.Exclamation)
        ElseIf PasswordTextBox.Text = String.Empty Then
            MsgBox("Please entry the Password!", MsgBoxStyle.Exclamation)
        ElseIf PrivilegeComboBox.Text = String.Empty Then
            MsgBox("Please select the privilege!", MsgBoxStyle.Exclamation)

        Else
            Dim SQLCMD As New SqlCommand($"select Username from User_TBL where username='{UsernameTextBox.Text}' ", SQLCONN)
            Dim adapter As New SqlDataAdapter(SQLCMD)
            Dim table As New DataTable()
            adapter.Fill(table)

            If table.Rows.Count = 0 Then


                Dim SQLCMDADD As New SqlCommand($"INSERT INTO User_tbl ([Username],[Password],[Privilege] ) 
                                                VALUES ('{UsernameTextBox.Text}','{PasswordTextBox.Text}','{PrivilegeComboBox.Text}') ", SQLCONN)
                SQLCONN.Open()
                SQLCMDADD.ExecuteNonQuery()
                SQLCONN.Close()



                MsgBox($"User {UsernameTextBox.Text} Has ben add successfully!", MsgBoxStyle.Information)
            Else
                MsgBox($"Username {UsernameTextBox.Text} already exists!", MsgBoxStyle.Exclamation)
            End If
        End If

        'fill Username DataGridView from DB  
        Try
            Dim SQLCMD As New SqlCommand($"Select ID,Username,Privilege from User_TBL", SQLCONN)
            Dim adapter As New SqlDataAdapter(SQLCMD)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView.DataSource = table
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub DELButton_Click(sender As Object, e As EventArgs) Handles DELButton.Click
        If UsernameTextBox.Text = String.Empty Then

            MsgBox("Please select a User First!", MsgBoxStyle.Information)

        Else
            MsgBox($"Are you sure to delete  {UsernameTextBox.Text} User name !", MsgBoxStyle.YesNo)
            If MsgBoxResult.Yes Then


                Try
                    Dim SQLCMDDEL As New SqlCommand($"Delete FROM User_tbl WHERE username ='{UsernameTextBox.Text}' ", SQLCONN)
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
            Dim SQLCMD As New SqlCommand($"select ID,Username,Privilege from User_TBL", SQLCONN)
            Dim adapter As New SqlDataAdapter(SQLCMD)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView.DataSource = table
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub DataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView.CellClick
        UsernameTextBox.Text = DataGridView.SelectedRows(0).Cells(1).Value.ToString
    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click

    End Sub
End Class