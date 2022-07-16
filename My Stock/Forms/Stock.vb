
Imports System.Data.SqlClient

Public Class Stock
    ReadOnly SQLCONN As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\MVS\My Stock\My Stock\Database\MSDB.mdf;Integrated Security=True")

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim SQLCMD As New SqlCommand($"select type,Category,itemname,sum(Quantity) Quantity from (select type,Category, itemname, - Quantity Quantity, 0 used from stockout  union all select type,Category, itemname, Quantity, 1 used from stockin ) t group by type,Category, itemname having sum(used) >0;", SQLCONN)
            Dim adapter As New SqlDataAdapter(SQLCMD)
            Dim table As New DataTable()
            adapter.Fill(table)
            SQLCONN.Open()
            SQLCMD.ExecuteNonQuery()
            SQLCONN.Close()
            DataGridView.DataSource = table
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
End Class