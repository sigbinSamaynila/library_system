<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class inventory
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuthorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorrowedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReturnOnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BooksDataSet8 = New library_system.booksDataSet8()
        Me.InventoryTableAdapter = New library_system.booksDataSet8TableAdapters.inventoryTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksDataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TitleDataGridViewTextBoxColumn, Me.AuthorDataGridViewTextBoxColumn, Me.GenreDataGridViewTextBoxColumn, Me.BorrowedDataGridViewTextBoxColumn, Me.ReturnOnDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.InventoryBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 80)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1212, 470)
        Me.DataGridView1.TabIndex = 0
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
        'BorrowedDataGridViewTextBoxColumn
        '
        Me.BorrowedDataGridViewTextBoxColumn.DataPropertyName = "Borrowed"
        Me.BorrowedDataGridViewTextBoxColumn.HeaderText = "Borrowed"
        Me.BorrowedDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.BorrowedDataGridViewTextBoxColumn.Name = "BorrowedDataGridViewTextBoxColumn"
        Me.BorrowedDataGridViewTextBoxColumn.Width = 150
        '
        'ReturnOnDataGridViewTextBoxColumn
        '
        Me.ReturnOnDataGridViewTextBoxColumn.DataPropertyName = "Return On"
        Me.ReturnOnDataGridViewTextBoxColumn.HeaderText = "Return On"
        Me.ReturnOnDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ReturnOnDataGridViewTextBoxColumn.Name = "ReturnOnDataGridViewTextBoxColumn"
        Me.ReturnOnDataGridViewTextBoxColumn.Width = 150
        '
        'InventoryBindingSource
        '
        Me.InventoryBindingSource.DataMember = "inventory"
        Me.InventoryBindingSource.DataSource = Me.BooksDataSet8
        '
        'BooksDataSet8
        '
        Me.BooksDataSet8.DataSetName = "booksDataSet8"
        Me.BooksDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InventoryTableAdapter
        '
        Me.InventoryTableAdapter.ClearBeforeFill = True
        '
        'inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1224, 599)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "inventory"
        Me.Text = "inventory"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksDataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BooksDataSet8 As booksDataSet8
    Friend WithEvents InventoryBindingSource As BindingSource
    Friend WithEvents InventoryTableAdapter As booksDataSet8TableAdapters.inventoryTableAdapter
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AuthorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BorrowedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReturnOnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
