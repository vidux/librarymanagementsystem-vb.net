<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class returnsz
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LibraryDataDataSet = New LMS_HNDIT_16_GP.LibraryDataDataSet()
        Me.TableAdapterManager = New LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.TableAdapterManager()
        Me.IssueTableAdapter = New LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.IssueTableAdapter()
        Me.BooksTableAdapter = New LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.BooksTableAdapter()
        Me.CustomerTableAdapter = New LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.CustomerTableAdapter()
        Me.IssueBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IssueDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupDTableAdapter = New LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.GroupDTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.rtext = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BooksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SetReturnsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SetReturnsTableAdapter = New LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.setReturnsTableAdapter()
        Me.SetReturnsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CIDTextBox = New System.Windows.Forms.TextBox()
        Me.BookIDTextBox = New System.Windows.Forms.TextBox()
        Me.BookNameTextBox = New System.Windows.Forms.TextBox()
        Me.CNameTextBox = New System.Windows.Forms.TextBox()
        Me.RlogTableAdapter = New LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.rlogTableAdapter()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        CType(Me.LibraryDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssueBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssueDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SetReturnsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SetReturnsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LibraryDataDataSet
        '
        Me.LibraryDataDataSet.DataSetName = "LibraryDataDataSet"
        Me.LibraryDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BooksTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.CustomerTableAdapter = Nothing
        Me.TableAdapterManager.GroupDTableAdapter = Nothing
        Me.TableAdapterManager.ilogTableAdapter = Nothing
        Me.TableAdapterManager.IssueTableAdapter = Nothing

        Me.TableAdapterManager.rlogTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IssueTableAdapter
        '
        Me.IssueTableAdapter.ClearBeforeFill = True
        '
        'BooksTableAdapter
        '
        Me.BooksTableAdapter.ClearBeforeFill = True
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'IssueBindingSource
        '
        Me.IssueBindingSource.DataMember = "Issue"
        Me.IssueBindingSource.DataSource = Me.LibraryDataDataSet
        '
        'IssueDataGridView
        '
        Me.IssueDataGridView.AllowUserToAddRows = False
        Me.IssueDataGridView.AllowUserToDeleteRows = False
        Me.IssueDataGridView.AutoGenerateColumns = False
        Me.IssueDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.IssueDataGridView.BackgroundColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IssueDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.IssueDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IssueDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.IssueDataGridView.DataSource = Me.IssueBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.IssueDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.IssueDataGridView.EnableHeadersVisualStyles = False
        Me.IssueDataGridView.Location = New System.Drawing.Point(12, 5)
        Me.IssueDataGridView.MultiSelect = False
        Me.IssueDataGridView.Name = "IssueDataGridView"
        Me.IssueDataGridView.ReadOnly = True
        Me.IssueDataGridView.RowHeadersVisible = False
        Me.IssueDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.IssueDataGridView.Size = New System.Drawing.Size(665, 244)
        Me.IssueDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "issueID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "issueID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "BookID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "BookID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "IssueDate"
        Me.DataGridViewTextBoxColumn4.HeaderText = "IssueDate"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DueDate"
        Me.DataGridViewTextBoxColumn5.HeaderText = "DueDate"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'GroupDTableAdapter
        '
        Me.GroupDTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(242, 330)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Return this book"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'rtext
        '
        Me.rtext.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rtext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtext.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IssueBindingSource, "BookID", True))
        Me.rtext.ForeColor = System.Drawing.Color.Silver
        Me.rtext.Location = New System.Drawing.Point(106, 332)
        Me.rtext.Name = "rtext"
        Me.rtext.ReadOnly = True
        Me.rtext.Size = New System.Drawing.Size(127, 20)
        Me.rtext.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 335)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Book ID:"
        '
        'BooksBindingSource
        '
        Me.BooksBindingSource.DataMember = "Books"
        Me.BooksBindingSource.DataSource = Me.LibraryDataDataSet
        '
        'SetReturnsBindingSource
        '
        Me.SetReturnsBindingSource.DataMember = "setReturns"
        Me.SetReturnsBindingSource.DataSource = Me.LibraryDataDataSet
        '
        'SetReturnsTableAdapter
        '
        Me.SetReturnsTableAdapter.ClearBeforeFill = True
        '
        'SetReturnsDataGridView
        '
        Me.SetReturnsDataGridView.AllowUserToAddRows = False
        Me.SetReturnsDataGridView.AllowUserToDeleteRows = False
        Me.SetReturnsDataGridView.AutoGenerateColumns = False
        Me.SetReturnsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SetReturnsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.SetReturnsDataGridView.DataSource = Me.SetReturnsBindingSource
        Me.SetReturnsDataGridView.Location = New System.Drawing.Point(705, 23)
        Me.SetReturnsDataGridView.Name = "SetReturnsDataGridView"
        Me.SetReturnsDataGridView.ReadOnly = True
        Me.SetReturnsDataGridView.Size = New System.Drawing.Size(315, 74)
        Me.SetReturnsDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "issueID"
        Me.DataGridViewTextBoxColumn6.HeaderText = "issueID"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "CID"
        Me.DataGridViewTextBoxColumn7.HeaderText = "CID"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "BookID"
        Me.DataGridViewTextBoxColumn8.HeaderText = "BookID"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "IssueDate"
        Me.DataGridViewTextBoxColumn9.HeaderText = "IssueDate"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "DueDate"
        Me.DataGridViewTextBoxColumn10.HeaderText = "DueDate"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "BookName"
        Me.DataGridViewTextBoxColumn11.HeaderText = "BookName"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "CName"
        Me.DataGridViewTextBoxColumn12.HeaderText = "CName"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'CIDTextBox
        '
        Me.CIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SetReturnsBindingSource, "CID", True))
        Me.CIDTextBox.Location = New System.Drawing.Point(895, 125)
        Me.CIDTextBox.Name = "CIDTextBox"
        Me.CIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CIDTextBox.TabIndex = 9
        '
        'BookIDTextBox
        '
        Me.BookIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SetReturnsBindingSource, "BookID", True))
        Me.BookIDTextBox.Location = New System.Drawing.Point(895, 151)
        Me.BookIDTextBox.Name = "BookIDTextBox"
        Me.BookIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BookIDTextBox.TabIndex = 11
        '
        'BookNameTextBox
        '
        Me.BookNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SetReturnsBindingSource, "BookName", True))
        Me.BookNameTextBox.Location = New System.Drawing.Point(895, 177)
        Me.BookNameTextBox.Name = "BookNameTextBox"
        Me.BookNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BookNameTextBox.TabIndex = 17
        '
        'CNameTextBox
        '
        Me.CNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SetReturnsBindingSource, "CName", True))
        Me.CNameTextBox.Location = New System.Drawing.Point(895, 203)
        Me.CNameTextBox.Name = "CNameTextBox"
        Me.CNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CNameTextBox.TabIndex = 19
        '
        'RlogTableAdapter
        '
        Me.RlogTableAdapter.ClearBeforeFill = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(820, 238)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 20
        '
        'returnsz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(689, 394)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.CIDTextBox)
        Me.Controls.Add(Me.BookIDTextBox)
        Me.Controls.Add(Me.BookNameTextBox)
        Me.Controls.Add(Me.CNameTextBox)
        Me.Controls.Add(Me.SetReturnsDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rtext)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.IssueDataGridView)
        Me.ForeColor = System.Drawing.Color.Silver
        Me.MinimizeBox = False
        Me.Name = "returnsz"
        Me.Text = "returns"
        CType(Me.LibraryDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssueBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssueDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SetReturnsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SetReturnsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LibraryDataDataSet As LMS_HNDIT_16_GP.LibraryDataDataSet
    Friend WithEvents TableAdapterManager As LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IssueTableAdapter As LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.IssueTableAdapter
    Friend WithEvents BooksTableAdapter As LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.BooksTableAdapter
    Friend WithEvents CustomerTableAdapter As LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents IssueBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IssueDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupDTableAdapter As LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.GroupDTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents rtext As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BooksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SetReturnsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SetReturnsTableAdapter As LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.setReturnsTableAdapter
    Friend WithEvents SetReturnsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BookIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BookNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RlogTableAdapter As LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.rlogTableAdapter
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
End Class
