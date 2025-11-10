Imports System.Data.SqlClient
Imports System.Data

Public Class borrow_book

    Dim connection As New SqlConnection("Data Source=DESKTOP-9R7NK8N;Database= books ;Integrated Security=True")
    Private Sub LoadData(ByVal grid As DataGridView)
        Dim adapter As New SqlDataAdapter("SELECT [Book Id], Title, Author, Genre, [Date Added] FROM books1", connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        grid.DataSource = table


    End Sub

End Class