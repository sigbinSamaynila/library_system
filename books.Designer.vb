<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class books
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
        Me.BooksDataSet7 = New library_system.booksDataSet7()
        Me.Final1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Final1TableAdapter = New library_system.booksDataSet7TableAdapters.final1TableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuthorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksDataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Final1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.AuthorDataGridViewTextBoxColumn, Me.GenreDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Final1BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(-3, 1)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(996, 446)
        Me.DataGridView1.TabIndex = 0
        '
        'BooksDataSet7
        '
        Me.BooksDataSet7.DataSetName = "booksDataSet7"
        Me.BooksDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Final1BindingSource
        '
        Me.Final1BindingSource.DataMember = "final1"
        Me.Final1BindingSource.DataSource = Me.BooksDataSet7
        '
        'Final1TableAdapter
        '
        Me.Final1TableAdapter.ClearBeforeFill = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Width = 150
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "title"
        Me.TitleDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        Me.TitleDataGridViewTextBoxColumn.Width = 150
        '
        'AuthorDataGridViewTextBoxColumn
        '
        Me.AuthorDataGridViewTextBoxColumn.DataPropertyName = "author"
        Me.AuthorDataGridViewTextBoxColumn.HeaderText = "author"
        Me.AuthorDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.AuthorDataGridViewTextBoxColumn.Name = "AuthorDataGridViewTextBoxColumn"
        Me.AuthorDataGridViewTextBoxColumn.Width = 150
        '
        'GenreDataGridViewTextBoxColumn
        '
        Me.GenreDataGridViewTextBoxColumn.DataPropertyName = "genre"
        Me.GenreDataGridViewTextBoxColumn.HeaderText = "genre"
        Me.GenreDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.GenreDataGridViewTextBoxColumn.Name = "GenreDataGridViewTextBoxColumn"
        Me.GenreDataGridViewTextBoxColumn.Width = 150
        '
        'books
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "books"
        Me.Text = "books"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksDataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Final1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BooksDataSet7 As booksDataSet7
    Friend WithEvents Final1BindingSource As BindingSource
    Friend WithEvents Final1TableAdapter As booksDataSet7TableAdapters.final1TableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AuthorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
