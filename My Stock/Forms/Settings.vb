Imports System.Data.SqlClient
Public Class Settings
    ReadOnly SQLCONN As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\MVS\My Stock\My Stock\Database\MSDB.mdf;Integrated Security=True")

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles BackUpButton.Click

        Dim SDF As New SaveFileDialog() With {
            .Filter = "BackUp Database | *.Bak",
            .FileName = "backUp" + Today.Year.ToString
        }

        If SDF.ShowDialog = DialogResult.OK Then
            Dim SQLCMD As New SqlCommand($"backup database MSDB To disk= '{SDF.FileName}' ", SQLCONN)
            SQLCONN.Open()
            SQLCMD.ExecuteNonQuery()
            SQLCONN.Close()
            MsgBox("backup Complete", MsgBoxStyle.Information)
        End If


    End Sub
End Class