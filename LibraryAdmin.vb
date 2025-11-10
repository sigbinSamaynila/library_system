Imports System.Data
Imports System.Data.SqlClient

Public Class LibraryAdmin


    Dim connection As New SqlClient.SqlConnection()

    Sub switchPanel(ByVal panel As Form)
        Panel2.Controls.Clear()
        panel.TopLevel = False
        Panel2.Controls.Add(panel)
        panel.Show()
    End Sub
    Private Sub button_edit_Click(sender As Object, e As EventArgs) Handles button_edit.Click
        switchPanel(edit_book)
    End Sub

    Private Sub button_users_Click(sender As Object, e As EventArgs) Handles button_users.Click
        switchPanel(user)
    End Sub

    Private Sub inventory_btn_Click(sender As Object, e As EventArgs) Handles inventory_btn.Click
        switchPanel(inventory)
    End Sub

    Private Sub board_btn_Click(sender As Object, e As EventArgs) Handles board_btn.Click
        switchPanel(superadmin)
    End Sub

    Private Sub borrow_btn_Click(sender As Object, e As EventArgs)
        Dim borrow As New borrow_book()
        borrow.Show()
        Me.Hide()
    End Sub

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


            Dim usersque As String = "SELECT COUNT(*) FROM [user_log]"
            Dim usersCommand As New SqlCommand(usersque, connection)
            Dim userCount As Integer = Convert.ToInt32(usersCommand.ExecuteScalar())


            Dim booksque As String = "SELECT COUNT(*) FROM books1"
            Dim booksCommand As New SqlCommand(booksque, connection)
            Dim bookCount As Integer = Convert.ToInt32(booksCommand.ExecuteScalar())


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

