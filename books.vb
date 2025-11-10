Public Class books
    Private Sub books_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BooksDataSet7.final1' table. You can move, or remove it, as needed.
        Me.Final1TableAdapter.Fill(Me.BooksDataSet7.final1)

    End Sub
End Class