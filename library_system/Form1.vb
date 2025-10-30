Imports System.Data
Imports System.Data.SqlClient

Public Class Form1


    Dim connection As New SqlClient.SqlConnection()

    Sub switchPanel(ByVal panel As Form)
        Panel2.Controls.Clear()
        panel.TopLevel = False
        Panel2.Controls.Add(panel)
        panel.Show()
    End Sub
    Private Sub button_edit_Click(sender As Object, e As EventArgs) Handles button_edit.Click
        switchPanel(edit)
    End Sub


End Class

