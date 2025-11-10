
Imports System.Data.SqlClient
Imports System.Data

Public Class edit

    Dim connection As New SqlConnection("Data Source=DESKTOP-9R7NK8N;Database= books ;Integrated Security=True")


    Private Sub LoadData(ByVal grid As DataGridView)
        Dim adapter As New SqlDataAdapter("SELECT * FROM edit", connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        grid.DataSource = table
    End Sub

    Private Sub edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BooksDataSet14.edit' table. You can move, or remove it, as needed.
        Me.EditTableAdapter.Fill(Me.BooksDataSet14.edit)

        Me.Final1TableAdapter.Fill(Me.BooksDataSet5.final1)
        Dim adp As New SqlDataAdapter("SELECT * FROM edit", connection)
        Dim table As New DataTable()
        adp.Fill(table)

    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

        Dim add As String = "INSERT INTO edit (Title, Author, Genre) VALUES (@Title, @Author, @Genre)"

        If title_txt.Text = "" AndAlso author_txt.Text = "" AndAlso genre_txt.Text = "" Then
            MessageBox.Show("Please fill all the fields")
            Exit Sub
        ElseIf title_txt.Text = "" Then
            MessageBox.Show("Enter a title")
            Exit Sub
        ElseIf author_txt.Text = "" Then
            MessageBox.Show("Enter an author")
            Exit Sub
        ElseIf genre_txt.Text = "" Then
            MessageBox.Show("Enter a genre")
            Exit Sub
        End If

        Try
            que(Add)
            MessageBox.Show("Book Added Successfully!")
            LoadData(DataGridView1)
        Catch ex As Exception
            MessageBox.Show("Something went wrong: " & ex.Message)
        End Try
    End Sub

    Public Sub que(ByVal query As String)

        Dim command As New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@Id", id_txt.Text)
        command.Parameters.AddWithValue("@Title", title_txt.Text)
        command.Parameters.AddWithValue("@Author", author_txt.Text)
        command.Parameters.AddWithValue("@Genre", genre_txt.Text)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        title_txt.Text = ("")
        author_txt.Text = ("")
        genre_txt.Text = ("")
        id_txt.Text = ("")
    End Sub

    Private Sub upd_txt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles upd_txt.Click
        Dim update As String = "UPDATE edit SET Title = @Title, Author = @Author, Genre = @Genre WHERE Id = @Id"

        que(update)
        MessageBox.Show("Book Updated")
        LoadData(DataGridView1)
    End Sub

    Private Sub dlt_txt_Click(sender As Object, e As EventArgs) Handles dlt_txt.Click
        Dim delete As String = "Delete from edit WHERE Id = @Id"
        que(delete)
        MessageBox.Show("Deleted")
        LoadData(DataGridView1)
    End Sub

    Private Sub find_txt_Click(sender As Object, e As EventArgs) Handles find_txt.Click
        Dim search As String = "SELECT * FROM edit WHERE Id = @Id OR Title = @Title"
        Dim command As New SqlCommand(search, connection)
        command.Parameters.AddWithValue("@Id", id_txt.Text)
        command.Parameters.AddWithValue("@Title", title_txt.Text)

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable
        adapter.Fill(table)
        DataGridView1.DataSource = table

        If table.Rows.Count > 0 Then
            id_txt.Text = table.Rows(0)("Id").ToString()
            title_txt.Text = table.Rows(0)("Title").ToString()
            author_txt.Text = table.Rows(0)("Author").ToString()
            genre_txt.Text = table.Rows(0)("Genre").ToString()
        ElseIf table.Rows.Count = 0 Then
            MessageBox.Show("Please enter the Id or Title of the book.")

        Else
            MessageBox.Show("Not Found")
        End If
        LoadData(DataGridView1)

    End Sub


End Class