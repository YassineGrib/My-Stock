
Imports System.Data.SqlClient

Module SQLModule

    Public SQLCONN As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database\MSDB.mdf;Integrated Security=True")

End Module
