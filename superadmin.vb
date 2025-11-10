Imports System.Data.SqlClient
Imports System.Data
Imports System.Drawing.Text

Public Class superadmin

    Private Sub superadmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        Timer1.Interval = 5000
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LoadData()
    End Sub

    Private Sub LoadData()
        Dim connectionString As String = "Data Source=DESKTOP-9R7NK8N;Initial Catalog=books;Integrated Security=True;"
        Dim connection As New SqlConnection(connectionString)

        Try
            connection.Open()

            ' Get user count
            Dim usersque As String = "SELECT COUNT(*) FROM [user_log]"
            Dim usersCommand As New SqlCommand(usersque, connection)
            Dim userCount As Integer = Convert.ToInt32(usersCommand.ExecuteScalar())

            ' Get book count
            Dim booksque As String = "SELECT COUNT(*) FROM books1"
            Dim booksCommand As New SqlCommand(booksque, connection)
            Dim bookCount As Integer = Convert.ToInt32(booksCommand.ExecuteScalar())

            ' Update UI controls (make sure these labels exist on your form)
            If total_books IsNot Nothing Then
                total_books.Text = "Total Books: " & bookCount.ToString()
            End If

            If total_students IsNot Nothing Then
                total_students.Text = "Total Students: " & userCount.ToString()
            End If

        Catch ex As Exception

        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub





End Class