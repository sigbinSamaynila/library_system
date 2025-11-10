<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LibraryAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LibraryAdmin))
        Me.button_edit = New System.Windows.Forms.Button()
        Me.button_users = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.board_btn = New System.Windows.Forms.Button()
        Me.inventory_btn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.total_books = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.total_students = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.return_btn = New System.Windows.Forms.Button()
        Me.borrow_btn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'button_edit
        '
        Me.button_edit.Location = New System.Drawing.Point(0, 221)
        Me.button_edit.Name = "button_edit"
        Me.button_edit.Size = New System.Drawing.Size(200, 66)
        Me.button_edit.TabIndex = 6
        Me.button_edit.Text = "Edit Book"
        Me.button_edit.UseVisualStyleBackColor = True
        '
        'button_users
        '
        Me.button_users.Location = New System.Drawing.Point(0, 280)
        Me.button_users.Name = "button_users"
        Me.button_users.Size = New System.Drawing.Size(200, 66)
        Me.button_users.TabIndex = 7
        Me.button_users.Text = "Users"
        Me.button_users.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.borrow_btn)
        Me.Panel1.Controls.Add(Me.return_btn)
        Me.Panel1.Controls.Add(Me.inventory_btn)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.board_btn)
        Me.Panel1.Controls.Add(Me.button_edit)
        Me.Panel1.Controls.Add(Me.button_users)
        Me.Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 667)
        Me.Panel1.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(0, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 67)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Assistant Librarian"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(202, 108)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'board_btn
        '
        Me.board_btn.Location = New System.Drawing.Point(0, 160)
        Me.board_btn.Name = "board_btn"
        Me.board_btn.Size = New System.Drawing.Size(200, 66)
        Me.board_btn.TabIndex = 10
        Me.board_btn.Text = "Dashboard"
        Me.board_btn.UseVisualStyleBackColor = True
        '
        'inventory_btn
        '
        Me.inventory_btn.Location = New System.Drawing.Point(2, 473)
        Me.inventory_btn.Name = "inventory_btn"
        Me.inventory_btn.Size = New System.Drawing.Size(200, 66)
        Me.inventory_btn.TabIndex = 9
        Me.inventory_btn.Text = "Inventory"
        Me.inventory_btn.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(208, 29)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1309, 468)
        Me.Panel2.TabIndex = 12
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel4.Controls.Add(Me.total_books)
        Me.Panel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(475, 35)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(388, 118)
        Me.Panel4.TabIndex = 3
        '
        'total_books
        '
        Me.total_books.AutoSize = True
        Me.total_books.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_books.Location = New System.Drawing.Point(28, 38)
        Me.total_books.Name = "total_books"
        Me.total_books.Size = New System.Drawing.Size(198, 37)
        Me.total_books.TabIndex = 3
        Me.total_books.Text = "Total Books"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel3.Controls.Add(Me.total_students)
        Me.Panel3.Location = New System.Drawing.Point(72, 35)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(388, 118)
        Me.Panel3.TabIndex = 13
        '
        'total_students
        '
        Me.total_students.AutoSize = True
        Me.total_students.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_students.Location = New System.Drawing.Point(28, 38)
        Me.total_students.Name = "total_students"
        Me.total_students.Size = New System.Drawing.Size(238, 37)
        Me.total_students.TabIndex = 2
        Me.total_students.Text = "Total Students"
        '
        'Timer1
        '
        '
        'return_btn
        '
        Me.return_btn.Location = New System.Drawing.Point(0, 342)
        Me.return_btn.Name = "return_btn"
        Me.return_btn.Size = New System.Drawing.Size(200, 67)
        Me.return_btn.TabIndex = 14
        Me.return_btn.Text = "Return"
        Me.return_btn.UseVisualStyleBackColor = True
        '
        'borrow_btn
        '
        Me.borrow_btn.Location = New System.Drawing.Point(0, 406)
        Me.borrow_btn.Name = "borrow_btn"
        Me.borrow_btn.Size = New System.Drawing.Size(200, 71)
        Me.borrow_btn.TabIndex = 14
        Me.borrow_btn.Text = "Borrow"
        Me.borrow_btn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1678, 668)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents button_edit As Button
    Friend WithEvents button_users As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents board_btn As Button
    Friend WithEvents inventory_btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents total_students As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents total_books As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents borrow_btn As Button
    Friend WithEvents return_btn As Button
End Class
