Imports System.Data.SqlClient
Imports System

Public Class user
    Dim connection As New SqlConnection("Data Source=DESKTOP-9R7NK8N;Database= books ;Integrated Security=True")

    Private Sub LoadData(ByVal grid As DataGridView)
        Dim adapter As New SqlDataAdapter("SELECT * FROM [user]", connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        grid.DataSource = table
    End Sub
    Public Sub que(ByVal que As String)
        Dim command As New SqlCommand(que, connection)
        command.Parameters.AddWithValue("id", id_txt.Text)
        command.Parameters.AddWithValue("username", user_txt.Text)
        command.Parameters.AddWithValue("department", department_txt.Text)
        command.Parameters.AddWithValue("program", program_txt.Text)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()

    End Sub


    Private Sub find_txt_Click(sender As Object, e As EventArgs) Handles find_txt.Click
        Dim find As String = "SELECT * FROM [user_log] WHERE id = @id"
        Dim command As New SqlCommand(find, connection)
        command.Parameters.AddWithValue("id", id_txt.Text)

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable
        adapter.Fill(table)
        DataGridView1.DataSource = table

        If table.Rows.Count() > 0 Then


            user_txt.Text = table.Rows(0)(1).ToString()
            program_txt.Text = table.Rows(0)(2).ToString()
            department_txt.Text = table.Rows(0)(3).ToString()


        Else
            MessageBox.Show("Not Found")
        End If

        LoadData(DataGridView1)
    End Sub



    Private Sub dlt_btn_Click(sender As Object, e As EventArgs) Handles dlt_btn.Click
        Dim delete As String = "Delete from [user] WHERE Id = @Id"
        que(delete)
        MessageBox.Show("Deleted")
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class