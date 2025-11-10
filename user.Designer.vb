<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class user
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
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BooksDataSet6 = New library_system.booksDataSet6()
        Me.id_txt = New System.Windows.Forms.TextBox()
        Me.user_txt = New System.Windows.Forms.TextBox()
        Me.program_txt = New System.Windows.Forms.TextBox()
        Me.department_txt = New System.Windows.Forms.TextBox()
        Me.find_txt = New System.Windows.Forms.Button()
        Me.DirectorySearcher1 = New System.DirectoryServices.DirectorySearcher()
        Me.UserTableAdapter = New library_system.booksDataSet6TableAdapters.userTableAdapter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.dlt_btn = New System.Windows.Forms.Button()
        Me.BooksDataSet16 = New library_system.booksDataSet16()
        Me.UserlogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.User_logTableAdapter = New library_system.booksDataSet16TableAdapters.user_logTableAdapter()
        Me.BooksDataSet17 = New library_system.booksDataSet17()
        Me.UserlogBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.User_logTableAdapter1 = New library_system.booksDataSet17TableAdapters.user_logTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StudentidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksDataSet16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserlogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksDataSet17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserlogBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserBindingSource
        '
        Me.UserBindingSource.DataMember = "user"
        Me.UserBindingSource.DataSource = Me.BooksDataSet6
        '
        'BooksDataSet6
        '
        Me.BooksDataSet6.DataSetName = "booksDataSet6"
        Me.BooksDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'id_txt
        '
        Me.id_txt.Location = New System.Drawing.Point(12, 177)
        Me.id_txt.Name = "id_txt"
        Me.id_txt.Size = New System.Drawing.Size(100, 26)
        Me.id_txt.TabIndex = 1
        '
        'user_txt
        '
        Me.user_txt.Location = New System.Drawing.Point(12, 233)
        Me.user_txt.Name = "user_txt"
        Me.user_txt.Size = New System.Drawing.Size(100, 26)
        Me.user_txt.TabIndex = 2
        '
        'program_txt
        '
        Me.program_txt.Location = New System.Drawing.Point(12, 280)
        Me.program_txt.Name = "program_txt"
        Me.program_txt.Size = New System.Drawing.Size(100, 26)
        Me.program_txt.TabIndex = 3
        '
        'department_txt
        '
        Me.department_txt.Location = New System.Drawing.Point(12, 338)
        Me.department_txt.Name = "department_txt"
        Me.department_txt.Size = New System.Drawing.Size(100, 26)
        Me.department_txt.TabIndex = 4
        '
        'find_txt
        '
        Me.find_txt.Location = New System.Drawing.Point(12, 380)
        Me.find_txt.Name = "find_txt"
        Me.find_txt.Size = New System.Drawing.Size(100, 42)
        Me.find_txt.TabIndex = 5
        Me.find_txt.Text = "Find Account"
        Me.find_txt.UseVisualStyleBackColor = True
        '
        'DirectorySearcher1
        '
        Me.DirectorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'UserTableAdapter
        '
        Me.UserTableAdapter.ClearBeforeFill = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'dlt_btn
        '
        Me.dlt_btn.Location = New System.Drawing.Point(12, 428)
        Me.dlt_btn.Name = "dlt_btn"
        Me.dlt_btn.Size = New System.Drawing.Size(100, 42)
        Me.dlt_btn.TabIndex = 6
        Me.dlt_btn.Text = "Delete Account"
        Me.dlt_btn.UseVisualStyleBackColor = True
        '
        'BooksDataSet16
        '
        Me.BooksDataSet16.DataSetName = "booksDataSet16"
        Me.BooksDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserlogBindingSource
        '
        Me.UserlogBindingSource.DataMember = "user_log"
        Me.UserlogBindingSource.DataSource = Me.BooksDataSet16
        '
        'User_logTableAdapter
        '
        Me.User_logTableAdapter.ClearBeforeFill = True
        '
        'BooksDataSet17
        '
        Me.BooksDataSet17.DataSetName = "booksDataSet17"
        Me.BooksDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserlogBindingSource1
        '
        Me.UserlogBindingSource1.DataMember = "user_log"
        Me.UserlogBindingSource1.DataSource = Me.BooksDataSet17
        '
        'User_logTableAdapter1
        '
        Me.User_logTableAdapter1.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentidDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.UserlogBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(145, 177)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(513, 307)
        Me.DataGridView1.TabIndex = 7
        '
        'StudentidDataGridViewTextBoxColumn
        '
        Me.StudentidDataGridViewTextBoxColumn.DataPropertyName = "student_id"
        Me.StudentidDataGridViewTextBoxColumn.HeaderText = "student_id"
        Me.StudentidDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.StudentidDataGridViewTextBoxColumn.Name = "StudentidDataGridViewTextBoxColumn"
        Me.StudentidDataGridViewTextBoxColumn.Width = 150
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "username"
        Me.UsernameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.Width = 150
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "password"
        Me.PasswordDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        Me.PasswordDataGridViewTextBoxColumn.Width = 150
        '
        'user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1499, 663)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.dlt_btn)
        Me.Controls.Add(Me.find_txt)
        Me.Controls.Add(Me.department_txt)
        Me.Controls.Add(Me.program_txt)
        Me.Controls.Add(Me.user_txt)
        Me.Controls.Add(Me.id_txt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "user"
        Me.Text = "user"
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksDataSet16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserlogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksDataSet17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserlogBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents id_txt As TextBox
    Friend WithEvents user_txt As TextBox
    Friend WithEvents program_txt As TextBox
    Friend WithEvents department_txt As TextBox
    Friend WithEvents find_txt As Button
    Friend WithEvents DirectorySearcher1 As DirectoryServices.DirectorySearcher
    Friend WithEvents BooksDataSet6 As booksDataSet6
    Friend WithEvents UserBindingSource As BindingSource
    Friend WithEvents UserTableAdapter As booksDataSet6TableAdapters.userTableAdapter
    Friend WithEvents Timer1 As Timer
    Friend WithEvents dlt_btn As Button
    Friend WithEvents BooksDataSet16 As booksDataSet16
    Friend WithEvents UserlogBindingSource As BindingSource
    Friend WithEvents User_logTableAdapter As booksDataSet16TableAdapters.user_logTableAdapter
    Friend WithEvents BooksDataSet17 As booksDataSet17
    Friend WithEvents UserlogBindingSource1 As BindingSource
    Friend WithEvents User_logTableAdapter1 As booksDataSet17TableAdapters.user_logTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents StudentidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
