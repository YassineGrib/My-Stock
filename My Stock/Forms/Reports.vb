Imports System.Data.SqlClient


Public Class Reports

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click
        Me.Close()

    End Sub

    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Get Categories N° from DB
        Try
            Dim SQLCMD As New SqlCommand($"select * from Categories_TBL", SQLCONN)
            Dim adapter As New SqlDataAdapter(SQLCMD)
            Dim table As New DataTable()
            adapter.Fill(table)
            Label1.Text = table.Rows.Count


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'Get Items N° from DB
        Try
            Dim SQLCMD As New SqlCommand($"select * from items_TBL", SQLCONN)
            Dim adapter As New SqlDataAdapter(SQLCMD)
            Dim table As New DataTable()
            adapter.Fill(table)
            Label2.Text = table.Rows.Count

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        'Get Users N° from DB
        Try
            Dim SQLCMD As New SqlCommand($"select * from User_TBL", SQLCONN)
            Dim adapter As New SqlDataAdapter(SQLCMD)
            Dim table As New DataTable()
            adapter.Fill(table)
            Label3.Text = table.Rows.Count

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try





    End Sub
End Class