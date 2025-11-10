Imports System.Data.SqlClient
Imports System.Data

Public Class edit_book

    Dim connection As New SqlConnection("Data Source=DESKTOP-9R7NK8N;Database= books ;Integrated Security=True")
    Private Sub LoadData(ByVal grid As DataGridView)
        Dim adapter As New SqlDataAdapter("SELECT [Book Id], Title, Author, Genre, [Date Added] FROM books1", connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        grid.DataSource = table
    End Sub

    Private Sub edit_book_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adp As New SqlDataAdapter("SELECT [Book Id], Title, Author, Genre, [Date Added] FROM books1", connection)
        Dim table As New DataTable()
        adp.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

        Dim add As String = "INSERT INTO books1 (Title, Author, Genre, [Date Added]) VALUES (@Title, @Author, @Genre, @DateAdded)"
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
            que(add)
            MessageBox.Show("Book Added Successfully!")
            LoadData(DataGridView1)
        Catch ex As Exception
            MessageBox.Show("Something went wrong: " & ex.Message)
        End Try
    End Sub

    Public Sub que(ByVal query As String)

        Dim command As New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@BookId", id_txt.Text)
        command.Parameters.AddWithValue("@Title", title_txt.Text)
        command.Parameters.AddWithValue("@Author", author_txt.Text)
        command.Parameters.AddWithValue("@Genre", genre_txt.Text)
        command.Parameters.AddWithValue("@DateAdded", DateTime.Now)
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
        Dim update As String = "UPDATE books1 SET Title = @Title, Author = @Author, Genre = @Genre WHERE [Book Id] = @BookId"

        que(update)
        MessageBox.Show("Book Updated")
        LoadData(DataGridView1)
    End Sub

    Private Sub dlt_txt_Click(sender As Object, e As EventArgs) Handles dlt_txt.Click
        Dim delete As String = "Delete from books1 WHERE [Book Id] = @BookId"
        que(delete)
        MessageBox.Show("Deleted")
        LoadData(DataGridView1)
    End Sub

    Private Sub find_txt_Click(sender As Object, e As EventArgs) Handles find_txt.Click
        Dim search As String = "SELECT * FROM books1 WHERE [Book Id] = @BookId OR Title = @Title"
        Dim command As New SqlCommand(search, connection)
        command.Parameters.AddWithValue("@BookId", id_txt.Text)
        command.Parameters.AddWithValue("@Title", title_txt.Text)


        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable
        adapter.Fill(table)
        DataGridView1.DataSource = table

        If table.Rows.Count > 0 Then
            id_txt.Text = table.Rows(0)("Book Id").ToString()
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

    Private Sub gn_id_Click(sender As Object, e As EventArgs) Handles gn_id.Click
        id_increment()
    End Sub
    Private Sub id_increment()
        Dim connection As New SqlConnection
        Dim command As New SqlCommand

        Dim Num As Integer
        connection.ConnectionString = "Data Source=DESKTOP-9R7NK8N;Database= books ;Integrated Security=True"
        connection.Open()
        command = New SqlCommand("select max([Book Id]) from books1", connection)
        command.ExecuteNonQuery()
        If IsDBNull(command.ExecuteScalar) Then
            Num = 1
            id_txt.Text = Num
        Else
            Num = command.ExecuteScalar + 1
            id_txt.Text = Num
        End If
        connection.Close()
    End Sub


End Class