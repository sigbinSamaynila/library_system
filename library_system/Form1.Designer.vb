<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.button_history = New System.Windows.Forms.Button()
        Me.button_edit = New System.Windows.Forms.Button()
        Me.button_users = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.books = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'button_history
        '
        Me.button_history.Location = New System.Drawing.Point(0, 426)
        Me.button_history.Name = "button_history"
        Me.button_history.Size = New System.Drawing.Size(200, 66)
        Me.button_history.TabIndex = 5
        Me.button_history.Text = "History"
        Me.button_history.UseVisualStyleBackColor = True
        '
        'button_edit
        '
        Me.button_edit.Location = New System.Drawing.Point(0, 282)
        Me.button_edit.Name = "button_edit"
        Me.button_edit.Size = New System.Drawing.Size(200, 66)
        Me.button_edit.TabIndex = 6
        Me.button_edit.Text = "Edit Book"
        Me.button_edit.UseVisualStyleBackColor = True
        '
        'button_users
        '
        Me.button_users.Location = New System.Drawing.Point(0, 354)
        Me.button_users.Name = "button_users"
        Me.button_users.Size = New System.Drawing.Size(200, 66)
        Me.button_users.TabIndex = 7
        Me.button_users.Text = "Users"
        Me.button_users.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.books)
        Me.Panel1.Controls.Add(Me.button_edit)
        Me.Panel1.Controls.Add(Me.button_history)
        Me.Panel1.Controls.Add(Me.button_users)
        Me.Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 667)
        Me.Panel1.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(199, 116)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(991, 468)
        Me.Panel2.TabIndex = 12
        '
        'books
        '
        Me.books.Location = New System.Drawing.Point(0, 210)
        Me.books.Name = "books"
        Me.books.Size = New System.Drawing.Size(200, 66)
        Me.books.TabIndex = 8
        Me.books.Text = "Books"
        Me.books.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1185, 670)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents button_history As Button
    Friend WithEvents button_edit As Button
    Friend WithEvents button_users As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents books As Button
End Class
