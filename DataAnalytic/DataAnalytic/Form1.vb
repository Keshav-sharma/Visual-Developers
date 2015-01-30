Imports MySql.Data.MySqlClient

Public Class Form1

    Private Property READER As Object
    Dim date1 As DateTime
    Dim date2 As DateTime
    Dim a As String
    Dim b As String
    Dim ca As String
    Dim d As String

    'Dim count As Integer = 0


    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click
       
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'count += 1
        'If count <= 1 Then

        'End If

        date1 = Convert.ToDateTime(DateTimePicker1.Text)
        date2 = Convert.ToDateTime(DateTimePicker2.Text)

        Dim obj As New Form3
        a = Convert.ToString(date1)
        b = a.Substring(0, 9)
        obj.datef31 = b
        ca = Convert.ToString(date2)
        d = ca.Substring(0, 9)
        obj.datef32 = d
        obj.Show()
        'obj.datef32 = date2.ToString()

        'Dim cn As MySqlConnection = New MySqlConnection("Database=analysis;Data Source=localhost;User Id=root1;Password=root;")
        'cn.Open()
        'Dim sel As String = "select * from consumption where DATE(timestamp1) between '" & date1.ToString("yyyy/MM/dd") & "' and '" & date2.ToString("yyyy/MM/dd") & "';"
        'Dim c As MySqlCommand = New MySqlCommand(sel, cn)
        'READER = c.ExecuteReader
        'While READER.Read()

        '    Chart1.Series("Date vs active power").Points.AddXY(READER.Item("timestamp1"), READER.Item("active_power"))
        'End While

        'cn.Close()


    End Sub

    
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cn As MySqlConnection = New MySqlConnection("Database=analysis;Data Source=localhost;User Id=root1;Password=root;")
        cn.Open()
        Dim sel As String = "select * from tata"
        Dim c As MySqlCommand = New MySqlCommand(sel, cn)
        READER = c.ExecuteReader
        While READER.Read()
            Dim sDate1 = READER.Item("timestamp1")
            ComboBox1.Items.Add(sDate1)

            Dim sDate2 = READER.Item("timestamp1")
            ComboBox2.Items.Add(sDate2)
        End While

        cn.Close()
        Dim con As MySqlConnection = New MySqlConnection("Database=analysis;Data Source=localhost;User Id=root1;Password=root;")
        con.Open()
        Dim sela As String = "select * from tata"
        Dim ca As MySqlCommand = New MySqlCommand(sela, con)
        READER = ca.ExecuteReader
        While READER.Read()
            Chart1.Series("Date vs active power").Points.AddXY(READER.Item("timestamp1"), READER.Item("power"))
        End While
       
        con.Close()
    End Sub

    
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub
End Class
