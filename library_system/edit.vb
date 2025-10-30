
Imports System.Data.SqlClient
Imports System.Data

Public Class edit

    Dim connection As New SqlConnection("Data Source=DESKTOP-9R7NK8N;Database= books ;Integrated Security=True")

    Private Sub edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BooksDataSet5.final1' table. You can move, or remove it, as needed.
        Me.Final1TableAdapter.Fill(Me.BooksDataSet5.final1)
        Dim adp As New SqlDataAdapter("SELECT * FROM final1", connection)
        Dim table As New DataTable()
        adp.Fill(table)

        DataGridView1.DataSource = table



    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim add As String = "INSERT INTO final1 (Title, Author, Genre) VALUES (@Title, @Author, @Genre)"
        que(add)


        If (title_txt.Text.Length = 0 AndAlso author_txt.Text.Length = 0 AndAlso genre_txt.Text.Length = 0) Then
            MessageBox.Show("Please fill all the fields")
        ElseIf (title_txt.Text.Length = 0) Then
            MessageBox.Show("Enter a title")
        ElseIf (author_txt.Text.Length = 0) Then
            MessageBox.Show("Enter an author")
        ElseIf (genre_txt.Text.Length = 0) Then
            MessageBox.Show("Enter a genre")
        ElseIf (title_txt.TextLength < 50 AndAlso author_txt.TextLength < 50 AndAlso genre_txt.TextLength < 50) Then
            MessageBox.Show("Book Added")
        Else
            MessageBox.Show("Try Again")
        End If



    End Sub

    Public Sub que(ByVal que As String)
        Dim command As New SqlCommand(que, connection)
        command.Parameters.AddWithValue("Id", id_txt.Text)
        command.Parameters.AddWithValue("title", title_txt.Text)
        command.Parameters.AddWithValue("author", author_txt.Text)
        command.Parameters.AddWithValue("genre", genre_txt.Text)
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
        Dim update As String = "UPDATE final1 SET Title = @Title, Author = @Author, Genre = @Genre, WHERE Id = @Id"
        que(update)
        MessageBox.Show("Book Updated")

    End Sub

    Private Sub dlt_txt_Click(sender As Object, e As EventArgs) Handles dlt_txt.Click
        Dim delete As String = "Delete from final1 WHERE Id = @Id"
        que(delete)
        MessageBox.Show("Deleted")
    End Sub

    Private Sub find_txt_Click(sender As Object, e As EventArgs) Handles find_txt.Click
        Dim search As String = "SELECT * FROM final1 WHERE Id = @Id"
        Dim command As New SqlCommand(search, connection)
        command.Parameters.AddWithValue("Id", id_txt.Text)

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable
        adapter.Fill(table)
        DataGridView1.DataSource = table

        If table.Rows.Count() > 0 Then

            title_txt.Text = table.Rows(0)(1).ToString()
            author_txt.Text = table.Rows(0)(2).ToString()
            genre_txt.Text = table.Rows(0)(3).ToString()


        Else
            MessageBox.Show("Not Found")
        End If



    End Sub


End Class