Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Public Class MDIParent1
    Dim READER As MySqlDataReader
    Dim a As String
    Dim b As String
    Dim ca As String
    Dim d As String
    Dim ea As String


    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me



        ChildForm.Show()
    End Sub

    'Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripButton.Click
    '    Dim OpenFileDialog As New OpenFileDialog
    '    OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
    '    OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
    '    If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
    '        Dim FileName As String = OpenFileDialog.FileName
    '        ' TODO: Add code here to open the file.
    '    End If
    'End Sub

    'Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    Dim SaveFileDialog As New SaveFileDialog
    '    SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
    '    SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

    '    If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
    '        Dim FileName As String = SaveFileDialog.FileName
    '        ' TODO: Add code here to save the current contents of the form to a file.
    '    End If
    'End Sub


    'Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    Me.Close()
    'End Sub

    'Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    'End Sub

    'Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    'End Sub

    'Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    'End Sub

    'Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    'End Sub

    'Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    'End Sub

    'Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    Me.LayoutMdi(MdiLayout.Cascade)
    'End Sub

    'Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    Me.LayoutMdi(MdiLayout.TileVertical)
    'End Sub

    'Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    Me.LayoutMdi(MdiLayout.TileHorizontal)
    'End Sub

    'Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    Me.LayoutMdi(MdiLayout.ArrangeIcons)
    'End Sub

    'Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    ' Close all child forms of the parent.
    '    For Each ChildForm As Form In Me.MdiChildren
    '        ChildForm.Close()
    '    Next
    'End Sub


    Private Sub Form1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Form1ToolStripMenuItem.Click
        Form1.MdiParent = Me
        Form1.Show()
    End Sub

    Private Sub Form2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Form2ToolStripMenuItem.Click
        Form2.MdiParent = Me
        Form2.Show()
    End Sub


    Private Sub DailyReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DailyReportToolStripMenuItem.Click

    End Sub

    Private Sub FormToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FormToolStripMenuItem1.Click
        ' Form1.MdiParent = Me
        Form1.Show()
    End Sub

    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cn As MySqlConnection = New MySqlConnection("Database=analysis;Data Source=localhost;User Id=root1;Password=root;")
        cn.Open()
        Dim sel As String = "select * from meter"
        Dim c As MySqlCommand = New MySqlCommand(sel, cn)
        READER = c.ExecuteReader

        READER.Read()
        a = READER.Item("unitCode")
        TextBox1.Text = a
        b = READER.Item("location")
        TextBox2.Text = b
        ca = READER.Item("MeterNo")
        TextBox3.Text = ca
        d = READER.Item("Last")
        TextBox4.Text = d
        ea = READER.Item("FFL")
        TextBox5.Text = ea
        cn.Close()
    End Sub

End Class
