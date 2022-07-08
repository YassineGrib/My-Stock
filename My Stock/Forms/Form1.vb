Imports System.Data.SqlClient

Public Class Login
    ReadOnly SQLCONN As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\MVS\My Stock\My Stock\Database\MSDB.mdf;Integrated Security=True")
    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click
        'the exit Button
        End
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Make Password crypted 
        PasswordTextBox.UseSystemPasswordChar = True

    End Sub
    Private Sub UsernameComboBox_GotFocus(sender As Object, e As EventArgs) Handles UsernameComboBox.GotFocus
        'fill Username ComboBox from DB  
        Dim SQLCMD As New SqlCommand($"select Username from User_TBL", SQLCONN)
        Dim adapter As New SqlDataAdapter(SQLCMD)
        Dim table As New DataTable()
        adapter.Fill(table)
        UsernameComboBox.DataSource = table
        UsernameComboBox.DisplayMember = "Username"
        UsernameComboBox.ValueMember = "Username"
    End Sub



    Private Sub PasswordTextBox_IconRightClick(sender As Object, e As EventArgs) Handles PasswordTextBox.IconRightClick
        'Textbox password right icon (Show/hide Password)
        If PasswordTextBox.UseSystemPasswordChar = True Then
            PasswordTextBox.UseSystemPasswordChar = False
        Else
            PasswordTextBox.UseSystemPasswordChar = True
        End If

    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        'Chack for Password of username Selected 

        If PasswordTextBox.Text = String.Empty Then
            MsgBox("Please entry the password!", MsgBoxStyle.Exclamation)

        ElseIf UsernameComboBox.Text = String.Empty Then
            MsgBox("Please select the User!", MsgBoxStyle.Exclamation)
        Else
            Dim SQLCMD As New SqlCommand($"select Username,Password from User_TBL where username='{UsernameComboBox.Text}' and Password='{PasswordTextBox.Text}'", SQLCONN)
            Dim adapter As New SqlDataAdapter(SQLCMD)
            Dim table As New DataTable()
            adapter.Fill(table)
            If table.Rows.Count = 0 Then
                MsgBox("Wrong Password!", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Password Correct", MsgBoxStyle.Information)

            End If
        End If

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        MsgBox("Ohh we sorry for that! Please contact your IT ADMIN", MsgBoxStyle.Information)

    End Sub
End Class
