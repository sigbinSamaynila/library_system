Imports System.Data.SqlClient
Imports System.Data
Public Class Add
    Dim connection As New SqlClient.SqlConnection("Data Source=DESKTOP-9R7NK8N;Initial Catalog= books ;Integrated Security=True")

    Private Sub add_button_Click(sender As Object, e As EventArgs) Handles add_button.Click
        Dim command As New SqlCommand("INSERT INTO table3 (Title, Author, Published, Genre) VALUES (@Title, @Author, @Published, @Genre)", connection)
        connection.Open()

        If (title.Text.Length = 0 AndAlso author.Text.Length = 0 AndAlso genres.Text.Length = 0) Then
            MessageBox.Show("Please fill all the fields")
        ElseIf (title.Text.Length = 0) Then
            MessageBox.Show("Enter a title")
        ElseIf (author.Text.Length = 0) Then
            MessageBox.Show("Enter an author")
        ElseIf (genres.Text.Length = 0) Then
            MessageBox.Show("Enter a genre")
        ElseIf (title.TextLength < 50 AndAlso author.TextLength < 50 AndAlso genres.TextLength < 50) Then
            command.ExecuteNonQuery()
            MessageBox.Show("Book Added")
        Else
            MessageBox.Show("Try Again")
        End If
        connection.Close()
    End Sub

    Public Sub que(ByVal que As String)
        Dim command As New SqlCommand(que, connection)
        command.Parameters.AddWithValue("title", title.Text)
        command.Parameters.AddWithValue("author", author.Text)
        command.Parameters.AddWithValue("published", Date.Now)
        command.Parameters.AddWithValue("genre", genres.Text)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()

    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear_button.Click
        title.Text = ("")
        author.Text = ("")
        genres.Text = ("")
    End Sub
End Class