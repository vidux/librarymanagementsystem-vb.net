<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class issue
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
        Dim StatusLabel As System.Windows.Forms.Label
        Dim IssueIDLabel As System.Windows.Forms.Label
        Dim IssueDateLabel As System.Windows.Forms.Label
        Dim DueDateLabel As System.Windows.Forms.Label
        Dim BookIDLabel As System.Windows.Forms.Label
        Dim CIDLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BookIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PublisherDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuthorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PublishingYearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EditionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BooksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibraryDataDataSet = New LMS_HNDIT_16_GP.LibraryDataDataSet()
        Me.BooksTableAdapter = New LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.BooksTableAdapter()
        Me.seachtext = New System.Windows.Forms.TextBox()
        Me.TableAdapterManager = New LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.TableAdapterManager()
        Me.CustomerTableAdapter = New LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.CustomerTableAdapter()
        Me.IssueTableAdapter = New LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.IssueTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IssueBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BookNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AuthorTextBox = New System.Windows.Forms.TextBox()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.IssueDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CNameTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CIDComboBox = New System.Windows.Forms.ComboBox()
        Me.PaymentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookIDComboBox = New System.Windows.Forms.ComboBox()
        Me.DueDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.IssueDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.IssueIDTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.IlogTableAdapter = New LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.ilogTableAdapter()
        Me.PaymentsTableAdapter = New LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.paymentsTableAdapter()
        StatusLabel = New System.Windows.Forms.Label()
        IssueIDLabel = New System.Windows.Forms.Label()
        IssueDateLabel = New System.Windows.Forms.Label()
        DueDateLabel = New System.Windows.Forms.Label()
        BookIDLabel = New System.Windows.Forms.Label()
        CIDLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssueBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssueDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(620, 156)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(40, 13)
        StatusLabel.TabIndex = 7
        StatusLabel.Text = "Status:"
        '
        'IssueIDLabel
        '
        IssueIDLabel.AutoSize = True
        IssueIDLabel.Location = New System.Drawing.Point(40, 16)
        IssueIDLabel.Name = "IssueIDLabel"
        IssueIDLabel.Size = New System.Drawing.Size(48, 13)
        IssueIDLabel.TabIndex = 12
        IssueIDLabel.Text = "issue ID:"
        '
        'IssueDateLabel
        '
        IssueDateLabel.AutoSize = True
        IssueDateLabel.Location = New System.Drawing.Point(27, 112)
        IssueDateLabel.Name = "IssueDateLabel"
        IssueDateLabel.Size = New System.Drawing.Size(61, 13)
        IssueDateLabel.TabIndex = 13
        IssueDateLabel.Text = "Issue Date:"
        '
        'DueDateLabel
        '
        DueDateLabel.AutoSize = True
        DueDateLabel.Location = New System.Drawing.Point(32, 138)
        DueDateLabel.Name = "DueDateLabel"
        DueDateLabel.Size = New System.Drawing.Size(56, 13)
        DueDateLabel.TabIndex = 14
        DueDateLabel.Text = "Due Date:"
        '
        'BookIDLabel
        '
        BookIDLabel.AutoSize = True
        BookIDLabel.Location = New System.Drawing.Point(275, 20)
        BookIDLabel.Name = "BookIDLabel"
        BookIDLabel.Size = New System.Drawing.Size(49, 13)
        BookIDLabel.TabIndex = 15
        BookIDLabel.Text = "Book ID:"
        '
        'CIDLabel
        '
        CIDLabel.AutoSize = True
        CIDLabel.Location = New System.Drawing.Point(20, 54)
        CIDLabel.Name = "CIDLabel"
        CIDLabel.Size = New System.Drawing.Size(68, 13)
        CIDLabel.TabIndex = 16
        CIDLabel.Text = "Customer ID:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(239, 54)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(85, 13)
        Label4.TabIndex = 18
        Label4.Text = "Customer Name:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookIDDataGridViewTextBoxColumn, Me.GroupIDDataGridViewTextBoxColumn, Me.BookNameDataGridViewTextBoxColumn, Me.PublisherDataGridViewTextBoxColumn, Me.AuthorDataGridViewTextBoxColumn, Me.PublishingYearDataGridViewTextBoxColumn, Me.EditionDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BooksBindingSource
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(12, 57)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowRowErrors = False
        Me.DataGridView1.Size = New System.Drawing.Size(747, 78)
        Me.DataGridView1.TabIndex = 1
        '
        'BookIDDataGridViewTextBoxColumn
        '
        Me.BookIDDataGridViewTextBoxColumn.DataPropertyName = "BookID"
        Me.BookIDDataGridViewTextBoxColumn.HeaderText = "BookID"
        Me.BookIDDataGridViewTextBoxColumn.Name = "BookIDDataGridViewTextBoxColumn"
        Me.BookIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GroupIDDataGridViewTextBoxColumn
        '
        Me.GroupIDDataGridViewTextBoxColumn.DataPropertyName = "GroupID"
        Me.GroupIDDataGridViewTextBoxColumn.HeaderText = "GroupID"
        Me.GroupIDDataGridViewTextBoxColumn.Name = "GroupIDDataGridViewTextBoxColumn"
        Me.GroupIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BookNameDataGridViewTextBoxColumn
        '
        Me.BookNameDataGridViewTextBoxColumn.DataPropertyName = "BookName"
        Me.BookNameDataGridViewTextBoxColumn.HeaderText = "BookName"
        Me.BookNameDataGridViewTextBoxColumn.Name = "BookNameDataGridViewTextBoxColumn"
        Me.BookNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PublisherDataGridViewTextBoxColumn
        '
        Me.PublisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher"
        Me.PublisherDataGridViewTextBoxColumn.HeaderText = "Publisher"
        Me.PublisherDataGridViewTextBoxColumn.Name = "PublisherDataGridViewTextBoxColumn"
        Me.PublisherDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AuthorDataGridViewTextBoxColumn
        '
        Me.AuthorDataGridViewTextBoxColumn.DataPropertyName = "Author"
        Me.AuthorDataGridViewTextBoxColumn.HeaderText = "Author"
        Me.AuthorDataGridViewTextBoxColumn.Name = "AuthorDataGridViewTextBoxColumn"
        Me.AuthorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PublishingYearDataGridViewTextBoxColumn
        '
        Me.PublishingYearDataGridViewTextBoxColumn.DataPropertyName = "PublishingYear"
        Me.PublishingYearDataGridViewTextBoxColumn.HeaderText = "PublishingYear"
        Me.PublishingYearDataGridViewTextBoxColumn.Name = "PublishingYearDataGridViewTextBoxColumn"
        Me.PublishingYearDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EditionDataGridViewTextBoxColumn
        '
        Me.EditionDataGridViewTextBoxColumn.DataPropertyName = "Edition"
        Me.EditionDataGridViewTextBoxColumn.HeaderText = "Edition"
        Me.EditionDataGridViewTextBoxColumn.Name = "EditionDataGridViewTextBoxColumn"
        Me.EditionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BooksBindingSource
        '
        Me.BooksBindingSource.DataMember = "Books"
        Me.BooksBindingSource.DataSource = Me.LibraryDataDataSet
        '
        'LibraryDataDataSet
        '
        Me.LibraryDataDataSet.DataSetName = "LibraryDataDataSet"
        Me.LibraryDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BooksTableAdapter
        '
        Me.BooksTableAdapter.ClearBeforeFill = True
        '
        'seachtext
        '
        Me.seachtext.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.seachtext.ForeColor = System.Drawing.Color.Silver
        Me.seachtext.Location = New System.Drawing.Point(144, 30)
        Me.seachtext.Name = "seachtext"
        Me.seachtext.Size = New System.Drawing.Size(241, 20)
        Me.seachtext.TabIndex = 1
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
        Me.TableAdapterManager.loginsTableAdapter = Nothing
        Me.TableAdapterManager.notpaiedusersTableAdapter = Nothing
        Me.TableAdapterManager.paymentsTableAdapter = Nothing
        Me.TableAdapterManager.pictureTableAdapter = Nothing
        Me.TableAdapterManager.rlogTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'IssueTableAdapter
        '
        Me.IssueTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Search by book name:"
        '
        'IssueBindingSource
        '
        Me.IssueBindingSource.DataMember = "Issue"
        Me.IssueBindingSource.DataSource = Me.LibraryDataDataSet
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Selected Book:"
        '
        'BookNameTextBox
        '
        Me.BookNameTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BookNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "BookName", True))
        Me.BookNameTextBox.ForeColor = System.Drawing.Color.Silver
        Me.BookNameTextBox.Location = New System.Drawing.Point(144, 152)
        Me.BookNameTextBox.Name = "BookNameTextBox"
        Me.BookNameTextBox.ReadOnly = True
        Me.BookNameTextBox.Size = New System.Drawing.Size(206, 20)
        Me.BookNameTextBox.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(383, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "by:"
        '
        'AuthorTextBox
        '
        Me.AuthorTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AuthorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "Author", True))
        Me.AuthorTextBox.ForeColor = System.Drawing.Color.Silver
        Me.AuthorTextBox.Location = New System.Drawing.Point(410, 153)
        Me.AuthorTextBox.Name = "AuthorTextBox"
        Me.AuthorTextBox.ReadOnly = True
        Me.AuthorTextBox.Size = New System.Drawing.Size(183, 20)
        Me.AuthorTextBox.TabIndex = 7
        '
        'StatusTextBox
        '
        Me.StatusTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "Status", True))
        Me.StatusTextBox.ForeColor = System.Drawing.Color.Silver
        Me.StatusTextBox.Location = New System.Drawing.Point(666, 153)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.ReadOnly = True
        Me.StatusTextBox.Size = New System.Drawing.Size(124, 20)
        Me.StatusTextBox.TabIndex = 8
        '
        'IssueDataGridView
        '
        Me.IssueDataGridView.AllowUserToAddRows = False
        Me.IssueDataGridView.AllowUserToDeleteRows = False
        Me.IssueDataGridView.AutoGenerateColumns = False
        Me.IssueDataGridView.BackgroundColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IssueDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.IssueDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IssueDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.IssueDataGridView.DataSource = Me.IssueBindingSource
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.IssueDataGridView.DefaultCellStyle = DataGridViewCellStyle12
        Me.IssueDataGridView.EnableHeadersVisualStyles = False
        Me.IssueDataGridView.Location = New System.Drawing.Point(12, 254)
        Me.IssueDataGridView.MultiSelect = False
        Me.IssueDataGridView.Name = "IssueDataGridView"
        Me.IssueDataGridView.ReadOnly = True
        Me.IssueDataGridView.RowHeadersVisible = False
        Me.IssueDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.IssueDataGridView.Size = New System.Drawing.Size(373, 156)
        Me.IssueDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "issueID"
        Me.DataGridViewTextBoxColumn5.HeaderText = "issueID"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "BookID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "BookID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "IssueDate"
        Me.DataGridViewTextBoxColumn3.HeaderText = "IssueDate"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DueDate"
        Me.DataGridViewTextBoxColumn4.HeaderText = "DueDate"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Label4)
        Me.GroupBox1.Controls.Add(Me.CNameTextBox)
        Me.GroupBox1.Controls.Add(Me.CIDComboBox)
        Me.GroupBox1.Controls.Add(CIDLabel)
        Me.GroupBox1.Controls.Add(BookIDLabel)
        Me.GroupBox1.Controls.Add(Me.BookIDComboBox)
        Me.GroupBox1.Controls.Add(DueDateLabel)
        Me.GroupBox1.Controls.Add(Me.DueDateDateTimePicker)
        Me.GroupBox1.Controls.Add(IssueDateLabel)
        Me.GroupBox1.Controls.Add(Me.IssueDateDateTimePicker)
        Me.GroupBox1.Controls.Add(IssueIDLabel)
        Me.GroupBox1.Controls.Add(Me.IssueIDTextBox)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Location = New System.Drawing.Point(405, 282)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(485, 219)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter Details"
        '
        'CNameTextBox
        '
        Me.CNameTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "CName", True))
        Me.CNameTextBox.ForeColor = System.Drawing.Color.Silver
        Me.CNameTextBox.Location = New System.Drawing.Point(331, 51)
        Me.CNameTextBox.Name = "CNameTextBox"
        Me.CNameTextBox.ReadOnly = True
        Me.CNameTextBox.Size = New System.Drawing.Size(121, 20)
        Me.CNameTextBox.TabIndex = 17
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.LibraryDataDataSet
        '
        'CIDComboBox
        '
        Me.CIDComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CIDComboBox.DataSource = Me.PaymentsBindingSource
        Me.CIDComboBox.DisplayMember = "CID"
        Me.CIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CIDComboBox.ForeColor = System.Drawing.Color.Silver
        Me.CIDComboBox.FormattingEnabled = True
        Me.CIDComboBox.Location = New System.Drawing.Point(94, 51)
        Me.CIDComboBox.Name = "CIDComboBox"
        Me.CIDComboBox.Size = New System.Drawing.Size(121, 21)
        Me.CIDComboBox.TabIndex = 3
        '
        'PaymentsBindingSource
        '
        Me.PaymentsBindingSource.DataMember = "payments"
        Me.PaymentsBindingSource.DataSource = Me.LibraryDataDataSet
        '
        'BookIDComboBox
        '
        Me.BookIDComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BookIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IssueBindingSource, "BookID", True))
        Me.BookIDComboBox.DataSource = Me.BooksBindingSource
        Me.BookIDComboBox.DisplayMember = "BookID"
        Me.BookIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BookIDComboBox.ForeColor = System.Drawing.Color.Silver
        Me.BookIDComboBox.FormattingEnabled = True
        Me.BookIDComboBox.Location = New System.Drawing.Point(330, 17)
        Me.BookIDComboBox.Name = "BookIDComboBox"
        Me.BookIDComboBox.Size = New System.Drawing.Size(121, 21)
        Me.BookIDComboBox.TabIndex = 4
        '
        'DueDateDateTimePicker
        '
        Me.DueDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.IssueBindingSource, "DueDate", True))
        Me.DueDateDateTimePicker.Location = New System.Drawing.Point(94, 134)
        Me.DueDateDateTimePicker.Name = "DueDateDateTimePicker"
        Me.DueDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DueDateDateTimePicker.TabIndex = 6
        '
        'IssueDateDateTimePicker
        '
        Me.IssueDateDateTimePicker.CalendarForeColor = System.Drawing.Color.Silver
        Me.IssueDateDateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IssueDateDateTimePicker.CalendarTitleForeColor = System.Drawing.Color.Silver
        Me.IssueDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.IssueBindingSource, "IssueDate", True))
        Me.IssueDateDateTimePicker.Location = New System.Drawing.Point(94, 108)
        Me.IssueDateDateTimePicker.Name = "IssueDateDateTimePicker"
        Me.IssueDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.IssueDateDateTimePicker.TabIndex = 5
        '
        'IssueIDTextBox
        '
        Me.IssueIDTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IssueIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IssueBindingSource, "issueID", True))
        Me.IssueIDTextBox.ForeColor = System.Drawing.Color.Silver
        Me.IssueIDTextBox.Location = New System.Drawing.Point(94, 13)
        Me.IssueIDTextBox.Name = "IssueIDTextBox"
        Me.IssueIDTextBox.Size = New System.Drawing.Size(121, 20)
        Me.IssueIDTextBox.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(331, 166)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 33)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Issue this book"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'IlogTableAdapter
        '
        Me.IlogTableAdapter.ClearBeforeFill = True
        '
        'PaymentsTableAdapter
        '
        Me.PaymentsTableAdapter.ClearBeforeFill = True
        '
        'issue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(890, 502)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.IssueDataGridView)
        Me.Controls.Add(StatusLabel)
        Me.Controls.Add(Me.StatusTextBox)
        Me.Controls.Add(Me.AuthorTextBox)
        Me.Controls.Add(Me.BookNameTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.seachtext)
        Me.Controls.Add(Me.DataGridView1)
        Me.ForeColor = System.Drawing.Color.Silver
        Me.Name = "issue"
        Me.Text = "book issue"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssueBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssueDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents LibraryDataDataSet As LMS_HNDIT_16_GP.LibraryDataDataSet
    Friend WithEvents BooksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BooksTableAdapter As LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.BooksTableAdapter
    Friend WithEvents seachtext As System.Windows.Forms.TextBox
    Friend WithEvents TableAdapterManager As LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents IssueBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IssueTableAdapter As LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.IssueTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BookNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents AuthorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StatusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IssueDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerTableAdapter As LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents IssueIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DueDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents IssueDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents BookIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BookIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PublisherDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AuthorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PublishingYearDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EditionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IlogTableAdapter As LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.ilogTableAdapter
    Friend WithEvents CNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PaymentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PaymentsTableAdapter As LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.paymentsTableAdapter
End Class
