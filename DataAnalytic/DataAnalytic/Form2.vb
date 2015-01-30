Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Public Class Form2
    Dim user As String
    Dim password As String
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim Passowrd As String
    Dim Passowrd2 As String
    Dim userName As String

    Private Property READER As Object
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        user = TextBox1.Text
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        password = TextBox2.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cn As MySqlConnection = New MySqlConnection("Database=analysis;Data Source=localhost;User Id=root1;Password=root;")
        cn.Open()
        Dim sel As String = "select * from logininfo where UserName = '" & user & "' and Pass = '" & password & "';"
        Dim c As MySqlCommand = New MySqlCommand(sel, cn)
        READER = c.ExecuteReader
        Dim count As Integer
        count = 0
        While READER.Read()
            count = count + 1
        End While

        If count = 1 Then
            'MsgBox("Login successful!!")

            Dim obj As New Form3
            obj.username = TextBox1.Text
            
            MDIParent1.Show()
            'Dim SAPI As Object
            'SAPI = CreateObject("sapi.spvoice")
            'SAPI.speak("Welcome " & TextBox1.Text)
            Me.Hide()
            TextBox1.Text = ""
            TextBox2.Text = ""
        ElseIf count > 1 Then
            MsgBox("Username and password are duplicate")
        Else
            MsgBox("Invalid credentials")
        End If
        con.Close()
        'If READER.IsDBNull(0) Then
        '    MsgBox("User Does not exist")
        'Else
        '    MsgBox("Login Successful!!")
        'End If

        'change the data source and initial catalog according to your sql server engine and data base
        'Try

        '    con.ConnectionString = "Server= localhost ;Database= product_details ;User Id= root;Password= root;"

        '    con.Open()

        '    cmd.Connection = con
        '    'change the data fields names and table according to your database
        '    cmd.CommandText = " SELECT  UserName, Pass FROM   logininfo WHERE UserName = '" & TextBox1.Text & "' AND Pass = '" & TextBox2.Text & "'"

        '    Dim lrd As SqlDataReader = cmd.ExecuteReader()
        '    If lrd.HasRows Then
        '        While lrd.Read()

        '            'Do something here
        '            Passowrd = lrd("Pass").ToString()
        '            userName = lrd("UserName").ToString()

        '            Passowrd2 = TextBox2.Text()

        '            If Passowrd = Passowrd2 And userName = TextBox1.Text Then

        '                MsgBox("Logged in successfully as " & userName & " ")


        '                'Clear all fields
        '                TextBox1.Text = ""
        '                TextBox2.Text = ""

        '            End If

        '        End While

        '    Else
        '        MsgBox("Username and Password do not match..")
        '        'Clear all fields
        '        TextBox1.Text = ""
        '        TextBox2.Text = ""
        '    End If


        'Catch ex As Exception
        '    MsgBox("Error while connecting to SQL Server." & ex.Message)

        'Finally
        '    con.Close() 'Whether there is error or not. Close the connection.

        'End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)


    End Sub
End Class