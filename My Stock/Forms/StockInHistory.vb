Imports System.Data.SqlClient

Public Class StockInHistory


    Private mRow As Integer = 0
    Private newpage As Boolean = True
    Sub print()

        PrintPreviewDialog = New PrintPreviewDialog
        PrintDocument.DefaultPageSettings.PaperSize = New System.Drawing.Printing.PaperSize("PaperA4", 840, 1000)
        PrintPreviewDialog.Document = PrintDocument
        PrintDocument.DefaultPageSettings.Landscape = True
        PrintPreviewDialog.ShowDialog()
    End Sub

    Private Sub PrintDocument_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument.PrintPage
        Dim YAxis As Integer = 0
        Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
        fmt.LineAlignment = StringAlignment.Center
        fmt.Trimming = StringTrimming.EllipsisCharacter
        Dim y As Int32 = 100 'Dim y As Int32 = e.MarginBounds.Top
        Dim rc As Rectangle
        Dim x As Int32 = 50 ' Dim x As Int32
        Dim h As Int32 = 0
        Dim row As DataGridViewRow
        e.Graphics.DrawString("My Stock Application", New Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, New Point(310, YAxis + 15))
        e.Graphics.DrawString("Date Print: " & Date.Now.ToLongDateString, New Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, New Point(100, YAxis + 75))

        ' Print the header text for a new page
        ' Use a grey bg just like the control
        If newpage Then
            row = DataGridView.Rows(mRow)
            x = 50 'x = e.MarginBounds.Left
            For Each cell As DataGridViewCell In row.Cells
                ' since we are printing the control's view,
                ' skip invidible columns
                If cell.Visible Then
                    rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)

                    e.Graphics.FillRectangle(Brushes.LightGray, rc)
                    e.Graphics.DrawRectangle(Pens.Black, rc)

                    ' reused in the data pront - should be a function
                    Select Case DataGridView.Columns(cell.ColumnIndex).DefaultCellStyle.Alignment
                        Case DataGridViewContentAlignment.BottomRight,
                             DataGridViewContentAlignment.MiddleRight
                            fmt.Alignment = StringAlignment.Far
                            rc.Offset(-1, 0)
                        Case DataGridViewContentAlignment.BottomCenter,
                            DataGridViewContentAlignment.MiddleCenter
                            fmt.Alignment = StringAlignment.Center
                        Case Else
                            fmt.Alignment = StringAlignment.Near
                            rc.Offset(2, 0)
                    End Select
                    e.Graphics.DrawString(DataGridView.Columns(cell.ColumnIndex).HeaderText,
                                                DataGridView.Font, Brushes.Black, rc, fmt)
                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                End If
            Next
            y += h
        End If
        newpage = False
        ' Now print the data for each row
        Dim thisNDX As Int32
        For thisNDX = mRow To DataGridView.RowCount - 1
            ' No need to try to print the new row
            If DataGridView.Rows(thisNDX).IsNewRow Then Exit For
            row = DataGridView.Rows(thisNDX)
            x = 50 'x = e.MarginBounds.Left
            h = 0
            ' reset X for data
            x = 50 'e.MarginBounds.Left
            ' print the data
            For Each cell As DataGridViewCell In row.Cells
                If cell.Visible Then
                    rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)

                    e.Graphics.DrawRectangle(Pens.Black, rc)

                    Select Case DataGridView.Columns(cell.ColumnIndex).DefaultCellStyle.Alignment
                            Case DataGridViewContentAlignment.BottomRight,
                             DataGridViewContentAlignment.MiddleRight
                                fmt.Alignment = StringAlignment.Far
                                rc.Offset(-1, 0)
                            Case DataGridViewContentAlignment.BottomCenter,
                            DataGridViewContentAlignment.MiddleCenter
                                fmt.Alignment = StringAlignment.Center
                            Case Else
                                fmt.Alignment = StringAlignment.Near
                                rc.Offset(2, 0)
                        End Select

                        e.Graphics.DrawString(cell.FormattedValue.ToString(),
                    DataGridView.Font, Brushes.Black, rc, fmt)
                        x += rc.Width
                        h = Math.Max(h, rc.Height)
                    End If
            Next
            y += h
            ' Next row to print
            mRow = thisNDX + 1

            If y + h > e.MarginBounds.Bottom Then 'e.MarginBounds.Bottom
                e.HasMorePages = True
                '  mRow -= 1   \causes last row To rePrint On Next page
                newpage = True
                Return
            End If
        Next
    End Sub
    Private Sub PrintDocument_BeginPrint(sender As Object, e As Printing.PrintEventArgs) Handles PrintDocument.BeginPrint
        mRow = 0
        newpage = True
        PrintPreviewDialog.PrintPreviewControl.StartPage = 0
        PrintPreviewDialog.PrintPreviewControl.Zoom = 1.0
    End Sub

    Private Sub SubmitButton2_Click(sender As Object, e As EventArgs) Handles SubmitButton2.Click
        Call print()
    End Sub

    Private Sub StockInHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Fill stock DataGridView from DB  
        Try
            Dim SQLCMD As New SqlCommand("Select bonID,itemID,Type,Category,ItemName,Quantity FROM Stockin ", SQLCONN)
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