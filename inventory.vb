Public Class inventory
    Private Sub inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BooksDataSet8.inventory' table. You can move, or remove it, as needed.
        Me.InventoryTableAdapter.Fill(Me.BooksDataSet8.inventory)

    End Sub
End Class