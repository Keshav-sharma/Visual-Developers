Imports MySql.Data.MySqlClient

Public Class Form4
    Private Property READER As Object
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

        Dim cn As MySqlConnection = New MySqlConnection("Database=analysis;Data Source=localhost;User Id=root1;Password=root;")
        cn.Open()
        Dim sel As String = "select * from tata;"
        Dim c As MySqlCommand = New MySqlCommand(sel, cn)
        READER = c.ExecuteReader
        While READER.Read()

        End While

        cn.Close()
    End Sub
    End Sub
End Class