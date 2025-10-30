<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class edit
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
        Me.author_txt = New System.Windows.Forms.TextBox()
        Me.id_txt = New System.Windows.Forms.TextBox()
        Me.title_txt = New System.Windows.Forms.TextBox()
        Me.genre_txt = New System.Windows.Forms.TextBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.upd_txt = New System.Windows.Forms.Button()
        Me.dlt_txt = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.clear = New System.Windows.Forms.Button()
        Me.Table3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BooksDataSet1 = New library_system.booksDataSet1()
        Me.Table3TableAdapter = New library_system.booksDataSet1TableAdapters.table3TableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuthorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Final1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BooksDataSet5 = New library_system.booksDataSet5()
        Me.TestBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BooksDataSet2 = New library_system.booksDataSet2()
        Me.TestTableAdapter = New library_system.booksDataSet2TableAdapters.testTableAdapter()
        Me.find_txt = New System.Windows.Forms.Button()
        Me.Final1TableAdapter = New library_system.booksDataSet5TableAdapters.final1TableAdapter()
        CType(Me.Table3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Final1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'author_txt
        '
        Me.author_txt.Location = New System.Drawing.Point(88, 162)
        Me.author_txt.Name = "author_txt"
        Me.author_txt.Size = New System.Drawing.Size(100, 26)
        Me.author_txt.TabIndex = 1
        '
        'id_txt
        '
        Me.id_txt.Location = New System.Drawing.Point(88, 65)
        Me.id_txt.Name = "id_txt"
        Me.id_txt.Size = New System.Drawing.Size(100, 26)
        Me.id_txt.TabIndex = 2
        '
        'title_txt
        '
        Me.title_txt.Location = New System.Drawing.Point(88, 114)
        Me.title_txt.Name = "title_txt"
        Me.title_txt.Size = New System.Drawing.Size(100, 26)
        Me.title_txt.TabIndex = 4
        '
        'genre_txt
        '
        Me.genre_txt.Location = New System.Drawing.Point(88, 211)
        Me.genre_txt.Name = "genre_txt"
        Me.genre_txt.Size = New System.Drawing.Size(100, 26)
        Me.genre_txt.TabIndex = 5
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(49, 71)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(26, 20)
        Me.lbl1.TabIndex = 6
        Me.lbl1.Text = "ID"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(37, 117)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(38, 20)
        Me.lbl2.TabIndex = 7
        Me.lbl2.Text = "Title"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Location = New System.Drawing.Point(25, 168)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(57, 20)
        Me.lbl3.TabIndex = 8
        Me.lbl3.Text = "Author"
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.Location = New System.Drawing.Point(25, 214)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(54, 20)
        Me.lbl5.TabIndex = 9
        Me.lbl5.Text = "Genre"
        '
        'upd_txt
        '
        Me.upd_txt.Location = New System.Drawing.Point(101, 312)
        Me.upd_txt.Name = "upd_txt"
        Me.upd_txt.Size = New System.Drawing.Size(75, 31)
        Me.upd_txt.TabIndex = 12
        Me.upd_txt.Text = "Update"
        Me.upd_txt.UseVisualStyleBackColor = True
        '
        'dlt_txt
        '
        Me.dlt_txt.Location = New System.Drawing.Point(12, 312)
        Me.dlt_txt.Name = "dlt_txt"
        Me.dlt_txt.Size = New System.Drawing.Size(75, 31)
        Me.dlt_txt.TabIndex = 13
        Me.dlt_txt.Text = "Delete"
        Me.dlt_txt.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(101, 266)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(75, 31)
        Me.btn_add.TabIndex = 15
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'clear
        '
        Me.clear.Location = New System.Drawing.Point(53, 359)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(75, 31)
        Me.clear.TabIndex = 16
        Me.clear.Text = "Clear All"
        Me.clear.UseVisualStyleBackColor = True
        '
        'Table3BindingSource
        '
        Me.Table3BindingSource.DataMember = "table3"
        Me.Table3BindingSource.DataSource = Me.BooksDataSet1
        '
        'BooksDataSet1
        '
        Me.BooksDataSet1.DataSetName = "booksDataSet1"
        Me.BooksDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Table3TableAdapter
        '
        Me.Table3TableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.AuthorDataGridViewTextBoxColumn, Me.GenreDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Final1BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(247, 65)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(679, 345)
        Me.DataGridView1.TabIndex = 17
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
        'Final1BindingSource
        '
        Me.Final1BindingSource.DataMember = "final1"
        Me.Final1BindingSource.DataSource = Me.BooksDataSet5
        '
        'BooksDataSet5
        '
        Me.BooksDataSet5.DataSetName = "booksDataSet5"
        Me.BooksDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TestBindingSource
        '
        Me.TestBindingSource.DataMember = "test"
        Me.TestBindingSource.DataSource = Me.BooksDataSet2
        '
        'BooksDataSet2
        '
        Me.BooksDataSet2.DataSetName = "booksDataSet2"
        Me.BooksDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TestTableAdapter
        '
        Me.TestTableAdapter.ClearBeforeFill = True
        '
        'find_txt
        '
        Me.find_txt.Location = New System.Drawing.Point(12, 266)
        Me.find_txt.Name = "find_txt"
        Me.find_txt.Size = New System.Drawing.Size(75, 31)
        Me.find_txt.TabIndex = 18
        Me.find_txt.Text = "Search"
        Me.find_txt.UseVisualStyleBackColor = True
        '
        'Final1TableAdapter
        '
        Me.Final1TableAdapter.ClearBeforeFill = True
        '
        'edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(986, 470)
        Me.Controls.Add(Me.find_txt)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.dlt_txt)
        Me.Controls.Add(Me.upd_txt)
        Me.Controls.Add(Me.lbl5)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.genre_txt)
        Me.Controls.Add(Me.title_txt)
        Me.Controls.Add(Me.id_txt)
        Me.Controls.Add(Me.author_txt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "edit"
        Me.Text = "edit"
        CType(Me.Table3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Final1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BooksDataSet1 As booksDataSet1
    Friend WithEvents Table3BindingSource As BindingSource
    Friend WithEvents Table3TableAdapter As booksDataSet1TableAdapters.table3TableAdapter
    Friend WithEvents author_txt As TextBox
    Friend WithEvents id_txt As TextBox
    Friend WithEvents title_txt As TextBox
    Friend WithEvents genre_txt As TextBox
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents lbl5 As Label
    Friend WithEvents upd_txt As Button
    Friend WithEvents dlt_txt As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents clear As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BooksDataSet2 As booksDataSet2
    Friend WithEvents TestBindingSource As BindingSource
    Friend WithEvents TestTableAdapter As booksDataSet2TableAdapters.testTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AuthorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents find_txt As Button
    Friend WithEvents BooksDataSet5 As booksDataSet5
    Friend WithEvents Final1BindingSource As BindingSource
    Friend WithEvents Final1TableAdapter As booksDataSet5TableAdapters.final1TableAdapter
End Class
