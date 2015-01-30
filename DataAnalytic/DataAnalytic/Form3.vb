Imports MySql.Data.MySqlClient

Public Class Form3
    Public Property username As String
    Private Property READER As Object
    Public Property datef31 As String
    Public Property datef32 As String
    Dim d1 As DateTime
    Dim d2 As DateTime
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Public Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        d1 = Convert.ToDateTime(datef31)
        d2 = Convert.ToDateTime(datef32)
        Dim cn As MySqlConnection = New MySqlConnection("Database=analysis;Data Source=localhost;User Id=root1;Password=root;")
        cn.Open()
        Dim sel As String = "select * from tata where DATE(timestamp1) between '" & d1.ToString("yyyy/MM/dd") & "' and '" & d2.ToString("yyyy/MM/dd") & "';"
        Dim c As MySqlCommand = New MySqlCommand(sel, cn)
        READER = c.ExecuteReader
        While READER.Read()

            Chart1.Series("Date vs active power").Points.AddXY(READER.Item("timestamp1"), READER.Item("power"))
        End While

        cn.Close()
    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

        
    End Sub
End Class