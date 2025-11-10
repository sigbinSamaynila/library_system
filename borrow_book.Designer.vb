<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class borrow_book
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BooksDataSet18 = New library_system.booksDataSet18()
        Me.Books1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Books1TableAdapter = New library_system.booksDataSet18TableAdapters.books1TableAdapter()
        Me.BookIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuthorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateAddedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksDataSet18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Books1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookIdDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.AuthorDataGridViewTextBoxColumn, Me.GenreDataGridViewTextBoxColumn, Me.DateAddedDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Books1BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(195, 77)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(664, 286)
        Me.DataGridView1.TabIndex = 0
        '
        'BooksDataSet18
        '
        Me.BooksDataSet18.DataSetName = "booksDataSet18"
        Me.BooksDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Books1BindingSource
        '
        Me.Books1BindingSource.DataMember = "books1"
        Me.Books1BindingSource.DataSource = Me.BooksDataSet18
        '
        'Books1TableAdapter
        '
        Me.Books1TableAdapter.ClearBeforeFill = True
        '
        'BookIdDataGridViewTextBoxColumn
        '
        Me.BookIdDataGridViewTextBoxColumn.DataPropertyName = "Book Id"
        Me.BookIdDataGridViewTextBoxColumn.HeaderText = "Book Id"
        Me.BookIdDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.BookIdDataGridViewTextBoxColumn.Name = "BookIdDataGridViewTextBoxColumn"
        Me.BookIdDataGridViewTextBoxColumn.ReadOnly = True
        Me.BookIdDataGridViewTextBoxColumn.Width = 150
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "Title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.TitleDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        Me.TitleDataGridViewTextBoxColumn.Width = 150
        '
        'AuthorDataGridViewTextBoxColumn
        '
        Me.AuthorDataGridViewTextBoxColumn.DataPropertyName = "Author"
        Me.AuthorDataGridViewTextBoxColumn.HeaderText = "Author"
        Me.AuthorDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.AuthorDataGridViewTextBoxColumn.Name = "AuthorDataGridViewTextBoxColumn"
        Me.AuthorDataGridViewTextBoxColumn.Width = 150
        '
        'GenreDataGridViewTextBoxColumn
        '
        Me.GenreDataGridViewTextBoxColumn.DataPropertyName = "Genre"
        Me.GenreDataGridViewTextBoxColumn.HeaderText = "Genre"
        Me.GenreDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.GenreDataGridViewTextBoxColumn.Name = "GenreDataGridViewTextBoxColumn"
        Me.GenreDataGridViewTextBoxColumn.Width = 150
        '
        'DateAddedDataGridViewTextBoxColumn
        '
        Me.DateAddedDataGridViewTextBoxColumn.DataPropertyName = "Date Added"
        Me.DateAddedDataGridViewTextBoxColumn.HeaderText = "Date Added"
        Me.DateAddedDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DateAddedDataGridViewTextBoxColumn.Name = "DateAddedDataGridViewTextBoxColumn"
        Me.DateAddedDataGridViewTextBoxColumn.Width = 150
        '
        'borrow_book
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1150, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "borrow_book"
        Me.Text = "borrow_book"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksDataSet18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Books1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BooksDataSet18 As booksDataSet18
    Friend WithEvents Books1BindingSource As BindingSource
    Friend WithEvents Books1TableAdapter As booksDataSet18TableAdapters.books1TableAdapter
    Friend WithEvents BookIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AuthorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateAddedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
