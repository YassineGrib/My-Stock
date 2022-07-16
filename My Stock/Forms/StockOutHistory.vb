Imports System.Data.SqlClient

Public Class StockOutHistory

    Private Sub StockOutHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Fill stock DataGridView from DB  
        Try
            Dim SQLCMD As New SqlCommand("Select bonID,itemID,Username,Type,Category,ItemName,Quantity,Recipient,note From Stockout ", SQLCONN)
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
End Class