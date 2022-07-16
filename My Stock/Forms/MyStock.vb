Imports System.Data.SqlClient
Public Class MyStock

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs)

        Users.Show()




    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)
        Users.Show()
    End Sub

    Private Sub Guna2PictureBox1_MouseHover(sender As Object, e As EventArgs)
        Guna2VSeparator1.Visible = True
    End Sub

    Private Sub Guna2PictureBox3_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox3.Click
        Categories.Show()
        'Chack for Privilege of username Selected 
        Dim SQLCMD As New SqlCommand($"select * from User_tbl where Username = '{UsernameLabel.Text}' and Privilege = 'ADMIN' ", SQLCONN)
        Dim adapter As New SqlDataAdapter(SQLCMD)
        Dim table As New DataTable()
        adapter.Fill(table)

        If table.Rows.Count = 0 Then



            Categories.DELButton.Enabled = False


        Else

        End If


    End Sub

    Private Sub Guna2PictureBox3_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox3.MouseHover
        Guna2VSeparator2.Visible = True
    End Sub

    Private Sub Guna2PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox3.MouseLeave
        Guna2VSeparator2.Visible = False

    End Sub

    Private Sub Guna2PictureBox1_MouseLeave(sender As Object, e As EventArgs)
        Guna2VSeparator1.Visible = False
    End Sub

    Private Sub Guna2PictureBox5_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox5.Click

        'Chack for Privilege of username Selected 
        Dim SQLCMD As New SqlCommand($"select * from User_tbl where Username = '{UsernameLabel.Text}' and Privilege = 'ADMIN' ", SQLCONN)
        Dim adapter As New SqlDataAdapter(SQLCMD)
        Dim table As New DataTable()
        adapter.Fill(table)

        If table.Rows.Count = 0 Then
            Items.DELButton.Enabled = False
        Else
        End If
        Items.Show()
    End Sub

    Private Sub Guna2PictureBox5_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox5.MouseHover
        Guna2VSeparator3.Visible = True
    End Sub

    Private Sub Guna2PictureBox5_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox5.MouseLeave
        Guna2VSeparator3.Visible = False


    End Sub

    Private Sub Guna2PictureBox8_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox8.Click
        Stockout.Show()
    End Sub

    Private Sub Guna2PictureBox8_MouseWheel(sender As Object, e As MouseEventArgs) Handles Guna2PictureBox8.MouseWheel

    End Sub

    Private Sub Guna2PictureBox8_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox8.MouseHover
        Guna2VSeparator4.Visible = True
    End Sub

    Private Sub Guna2PictureBox8_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox8.MouseLeave
        Guna2VSeparator4.Visible = False

    End Sub

    Private Sub Guna2PictureBox7_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox7.Click
        Stock.Show()

    End Sub

    Private Sub Guna2PictureBox7_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox7.MouseHover
        Guna2VSeparator5.Visible = True

    End Sub

    Private Sub Guna2PictureBox7_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox7.MouseLeave
        Guna2VSeparator5.Visible = False
    End Sub

    Private Sub Guna2VSeparator6_Click(sender As Object, e As EventArgs) Handles Guna2VSeparator6.Click

    End Sub

    Private Sub Guna2PictureBox6_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox6.Click
        StockIN.Show()


    End Sub

    Private Sub Guna2PictureBox6_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox6.MouseHover
        Guna2VSeparator6.Visible = True

    End Sub

    Private Sub Guna2PictureBox6_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox6.MouseLeave
        Guna2VSeparator6.Visible = False

    End Sub

    Private Sub Guna2PictureBox10_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox10.Click
        Reports.show()


    End Sub

    Private Sub Guna2PictureBox10_MouseMove(sender As Object, e As MouseEventArgs) Handles Guna2PictureBox10.MouseMove

    End Sub

    Private Sub Guna2PictureBox10_MouseUp(sender As Object, e As MouseEventArgs) Handles Guna2PictureBox10.MouseUp

    End Sub

    Private Sub Guna2PictureBox10_MouseHover(sender As Object, e As EventArgs) Handles Guna2PictureBox10.MouseHover
        Guna2VSeparator9.Visible = True
    End Sub

    Private Sub Guna2PictureBox10_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox10.MouseLeave
        Guna2VSeparator9.Visible = False
    End Sub

    Private Sub Guna2PictureBox9_Click(sender As Object, e As EventArgs) Handles SettingPictureBox.Click
        Settings.Show()
    End Sub

    Private Sub Guna2PictureBox9_MouseHover(sender As Object, e As EventArgs) Handles SettingPictureBox.MouseHover
        Guna2VSeparator8.Visible = True
    End Sub

    Private Sub Guna2PictureBox9_MouseLeave(sender As Object, e As EventArgs) Handles SettingPictureBox.MouseLeave
        Guna2VSeparator8.Visible = False
    End Sub

    Private Sub Guna2VSeparator1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Categories.Show()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Items.Show()
    End Sub

    Private Sub MyStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UsernameLabel.Text = Login.UsernameComboBox.Text
        'Chack for Privilege of username Selected 
        Dim SQLCMD As New SqlCommand($"select * from User_tbl where Username = '{UsernameLabel.Text}' and Privilege = 'ADMIN' ", SQLCONN)
        Dim adapter As New SqlDataAdapter(SQLCMD)
        Dim table As New DataTable()
        adapter.Fill(table)

        If table.Rows.Count = 0 Then

            UsersPictureBox.Visible = False
            Label4.Visible = False


            SettingPictureBox.Visible = False
            Label10.Visible = False

            Categories.DELButton.Enabled = False
            Items.DELButton.Enabled = False

        Else

        End If



    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        StockIN.Show()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Stockout.Show()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Stock.Show()
    End Sub

    Private Sub UsersPictureBox_Click(sender As Object, e As EventArgs) Handles UsersPictureBox.Click
        Users.Show()

    End Sub
End Class