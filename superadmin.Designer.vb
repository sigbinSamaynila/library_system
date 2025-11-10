<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class superadmin
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.total_students = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.total_books = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BooksDataSet9 = New library_system.booksDataSet9()
        Me.Final1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Final1TableAdapter = New library_system.booksDataSet9TableAdapters.final1TableAdapter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.BooksDataSet9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Final1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.total_students)
        Me.Panel1.Location = New System.Drawing.Point(72, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(388, 118)
        Me.Panel1.TabIndex = 0
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.total_books)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(475, 35)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(388, 118)
        Me.Panel2.TabIndex = 1
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
        Me.Panel3.Location = New System.Drawing.Point(72, 172)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(388, 288)
        Me.Panel3.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel4.Location = New System.Drawing.Point(475, 172)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(388, 288)
        Me.Panel4.TabIndex = 1
        '
        'BooksDataSet9
        '
        Me.BooksDataSet9.DataSetName = "booksDataSet9"
        Me.BooksDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Final1BindingSource
        '
        Me.Final1BindingSource.DataMember = "final1"
        Me.Final1BindingSource.DataSource = Me.BooksDataSet9
        '
        'Final1TableAdapter
        '
        Me.Final1TableAdapter.ClearBeforeFill = True
        '
        'superadmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1380, 586)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "superadmin"
        Me.Text = "superadmin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BooksDataSet9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Final1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents total_students As Label
    Friend WithEvents total_books As Label
    Friend WithEvents BooksDataSet9 As booksDataSet9
    Friend WithEvents Final1BindingSource As BindingSource
    Friend WithEvents Final1TableAdapter As booksDataSet9TableAdapters.final1TableAdapter
    Friend WithEvents Timer1 As Timer
End Class
