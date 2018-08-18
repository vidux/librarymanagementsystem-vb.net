<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class allbooks
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
        Dim PriceLabel As System.Windows.Forms.Label
        Dim EditionLabel As System.Windows.Forms.Label
        Dim PublishingYearLabel As System.Windows.Forms.Label
        Dim AuthorLabel As System.Windows.Forms.Label
        Dim PublisherLabel As System.Windows.Forms.Label
        Dim BookNameLabel As System.Windows.Forms.Label
        Dim BookIDLabel As System.Windows.Forms.Label
        Dim GroupIDLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(allbooks))
        Me.LibraryDataDataSet = New LMS_HNDIT_16_GP.LibraryDataDataSet()
        Me.BooksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BooksTableAdapter = New LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.BooksTableAdapter()
        Me.TableAdapterManager = New LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.TableAdapterManager()
        Me.BooksDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ptcover = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.stu = New System.Windows.Forms.ComboBox()
        Me.grpid = New System.Windows.Forms.ComboBox()
        Me.GroupDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.EditionTextBox = New System.Windows.Forms.TextBox()
        Me.PublishingYearTextBox = New System.Windows.Forms.TextBox()
        Me.AuthorTextBox = New System.Windows.Forms.TextBox()
        Me.PublisherTextBox = New System.Windows.Forms.TextBox()
        Me.booknm = New System.Windows.Forms.TextBox()
        Me.BookIDTextBox = New System.Windows.Forms.TextBox()
        Me.GroupDTableAdapter = New LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.GroupDTableAdapter()
        Me.OFDpicture = New System.Windows.Forms.OpenFileDialog()
        Me.PictureTableAdapter1 = New LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.pictureTableAdapter()
        StatusLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        EditionLabel = New System.Windows.Forms.Label()
        PublishingYearLabel = New System.Windows.Forms.Label()
        AuthorLabel = New System.Windows.Forms.Label()
        PublisherLabel = New System.Windows.Forms.Label()
        BookNameLabel = New System.Windows.Forms.Label()
        BookIDLabel = New System.Windows.Forms.Label()
        GroupIDLabel = New System.Windows.Forms.Label()
        CType(Me.LibraryDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ptcover, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(266, 116)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(40, 13)
        StatusLabel.TabIndex = 36
        StatusLabel.Text = "Status:"
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Location = New System.Drawing.Point(439, 116)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(34, 13)
        PriceLabel.TabIndex = 34
        PriceLabel.Text = "Price:"
        '
        'EditionLabel
        '
        EditionLabel.AutoSize = True
        EditionLabel.Location = New System.Drawing.Point(431, 80)
        EditionLabel.Name = "EditionLabel"
        EditionLabel.Size = New System.Drawing.Size(42, 13)
        EditionLabel.TabIndex = 32
        EditionLabel.Text = "Edition:"
        '
        'PublishingYearLabel
        '
        PublishingYearLabel.AutoSize = True
        PublishingYearLabel.Location = New System.Drawing.Point(28, 116)
        PublishingYearLabel.Name = "PublishingYearLabel"
        PublishingYearLabel.Size = New System.Drawing.Size(83, 13)
        PublishingYearLabel.TabIndex = 30
        PublishingYearLabel.Text = "Publishing Year:"
        '
        'AuthorLabel
        '
        AuthorLabel.AutoSize = True
        AuthorLabel.Location = New System.Drawing.Point(265, 80)
        AuthorLabel.Name = "AuthorLabel"
        AuthorLabel.Size = New System.Drawing.Size(41, 13)
        AuthorLabel.TabIndex = 28
        AuthorLabel.Text = "Author:"
        '
        'PublisherLabel
        '
        PublisherLabel.AutoSize = True
        PublisherLabel.Location = New System.Drawing.Point(431, 44)
        PublisherLabel.Name = "PublisherLabel"
        PublisherLabel.Size = New System.Drawing.Size(53, 13)
        PublisherLabel.TabIndex = 26
        PublisherLabel.Text = "Publisher:"
        '
        'BookNameLabel
        '
        BookNameLabel.AutoSize = True
        BookNameLabel.Location = New System.Drawing.Point(45, 80)
        BookNameLabel.Name = "BookNameLabel"
        BookNameLabel.Size = New System.Drawing.Size(66, 13)
        BookNameLabel.TabIndex = 24
        BookNameLabel.Text = "Book Name:"
        '
        'BookIDLabel
        '
        BookIDLabel.AutoSize = True
        BookIDLabel.Location = New System.Drawing.Point(62, 44)
        BookIDLabel.Name = "BookIDLabel"
        BookIDLabel.Size = New System.Drawing.Size(49, 13)
        BookIDLabel.TabIndex = 20
        BookIDLabel.Text = "Book ID:"
        '
        'GroupIDLabel
        '
        GroupIDLabel.AutoSize = True
        GroupIDLabel.Location = New System.Drawing.Point(253, 44)
        GroupIDLabel.Name = "GroupIDLabel"
        GroupIDLabel.Size = New System.Drawing.Size(53, 13)
        GroupIDLabel.TabIndex = 22
        GroupIDLabel.Text = "Group ID:"
        '
        'LibraryDataDataSet
        '
        Me.LibraryDataDataSet.DataSetName = "LibraryDataDataSet"
        Me.LibraryDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BooksBindingSource
        '
        Me.BooksBindingSource.DataMember = "Books"
        Me.BooksBindingSource.DataSource = Me.LibraryDataDataSet
        '
        'BooksTableAdapter
        '
        Me.BooksTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BooksTableAdapter = Me.BooksTableAdapter
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
        'BooksDataGridView
        '
        Me.BooksDataGridView.AllowUserToAddRows = False
        Me.BooksDataGridView.AllowUserToDeleteRows = False
        Me.BooksDataGridView.AutoGenerateColumns = False
        Me.BooksDataGridView.BackgroundColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BooksDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.BooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BooksDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.BooksDataGridView.DataSource = Me.BooksBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BooksDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.BooksDataGridView.EnableHeadersVisualStyles = False
        Me.BooksDataGridView.Location = New System.Drawing.Point(29, 41)
        Me.BooksDataGridView.MultiSelect = False
        Me.BooksDataGridView.Name = "BooksDataGridView"
        Me.BooksDataGridView.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BooksDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.BooksDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray
        Me.BooksDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.BooksDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BooksDataGridView.Size = New System.Drawing.Size(809, 155)
        Me.BooksDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "BookID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "BookID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "GroupID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "GroupID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "BookName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "BookName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Publisher"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Publisher"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Author"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Author"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "PublishingYear"
        Me.DataGridViewTextBoxColumn6.HeaderText = "PublishingYear"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Edition"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Edition"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Price"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ptcover)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.stu)
        Me.GroupBox1.Controls.Add(Me.grpid)
        Me.GroupBox1.Controls.Add(StatusLabel)
        Me.GroupBox1.Controls.Add(PriceLabel)
        Me.GroupBox1.Controls.Add(Me.PriceTextBox)
        Me.GroupBox1.Controls.Add(EditionLabel)
        Me.GroupBox1.Controls.Add(Me.EditionTextBox)
        Me.GroupBox1.Controls.Add(PublishingYearLabel)
        Me.GroupBox1.Controls.Add(Me.PublishingYearTextBox)
        Me.GroupBox1.Controls.Add(AuthorLabel)
        Me.GroupBox1.Controls.Add(Me.AuthorTextBox)
        Me.GroupBox1.Controls.Add(PublisherLabel)
        Me.GroupBox1.Controls.Add(Me.PublisherTextBox)
        Me.GroupBox1.Controls.Add(BookNameLabel)
        Me.GroupBox1.Controls.Add(Me.booknm)
        Me.GroupBox1.Controls.Add(GroupIDLabel)
        Me.GroupBox1.Controls.Add(BookIDLabel)
        Me.GroupBox1.Controls.Add(Me.BookIDTextBox)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Silver
        Me.GroupBox1.Location = New System.Drawing.Point(104, 202)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(734, 260)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "enter details"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(406, 238)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "this cover image shoud lower than 100 kb"
        '
        'ptcover
        '
        Me.ptcover.ErrorImage = CType(resources.GetObject("ptcover.ErrorImage"), System.Drawing.Image)
        Me.ptcover.Location = New System.Drawing.Point(616, 125)
        Me.ptcover.Name = "ptcover"
        Me.ptcover.Size = New System.Drawing.Size(112, 126)
        Me.ptcover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptcover.TabIndex = 42
        Me.ptcover.TabStop = False
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(490, 212)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(109, 23)
        Me.Button2.TabIndex = 41
        Me.Button2.Text = "browse cover.."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(268, 178)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 30)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(353, 178)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(82, 30)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(187, 178)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 30)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Add New"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'stu
        '
        Me.stu.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.stu.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "Status", True))
        Me.stu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.stu.ForeColor = System.Drawing.Color.Silver
        Me.stu.FormattingEnabled = True
        Me.stu.Items.AddRange(New Object() {"Available", "NotAvailable"})
        Me.stu.Location = New System.Drawing.Point(312, 115)
        Me.stu.Name = "stu"
        Me.stu.Size = New System.Drawing.Size(100, 21)
        Me.stu.TabIndex = 8
        '
        'grpid
        '
        Me.grpid.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.grpid.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "GroupID", True))
        Me.grpid.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BooksBindingSource, "GroupID", True))
        Me.grpid.DataSource = Me.GroupDBindingSource
        Me.grpid.DisplayMember = "GroupName"
        Me.grpid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.grpid.ForeColor = System.Drawing.Color.Silver
        Me.grpid.FormattingEnabled = True
        Me.grpid.Location = New System.Drawing.Point(312, 40)
        Me.grpid.Name = "grpid"
        Me.grpid.Size = New System.Drawing.Size(101, 21)
        Me.grpid.TabIndex = 2
        Me.grpid.ValueMember = "GroupID"
        '
        'GroupDBindingSource
        '
        Me.GroupDBindingSource.DataMember = "GroupD"
        Me.GroupDBindingSource.DataSource = Me.LibraryDataDataSet
        '
        'PriceTextBox
        '
        Me.PriceTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "Price", True))
        Me.PriceTextBox.ForeColor = System.Drawing.Color.Silver
        Me.PriceTextBox.Location = New System.Drawing.Point(479, 113)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PriceTextBox.TabIndex = 9
        '
        'EditionTextBox
        '
        Me.EditionTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EditionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "Edition", True))
        Me.EditionTextBox.ForeColor = System.Drawing.Color.Silver
        Me.EditionTextBox.Location = New System.Drawing.Point(479, 77)
        Me.EditionTextBox.Name = "EditionTextBox"
        Me.EditionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EditionTextBox.TabIndex = 6
        '
        'PublishingYearTextBox
        '
        Me.PublishingYearTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PublishingYearTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "PublishingYear", True))
        Me.PublishingYearTextBox.ForeColor = System.Drawing.Color.Silver
        Me.PublishingYearTextBox.Location = New System.Drawing.Point(117, 113)
        Me.PublishingYearTextBox.Name = "PublishingYearTextBox"
        Me.PublishingYearTextBox.Size = New System.Drawing.Size(142, 20)
        Me.PublishingYearTextBox.TabIndex = 7
        '
        'AuthorTextBox
        '
        Me.AuthorTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AuthorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "Author", True))
        Me.AuthorTextBox.ForeColor = System.Drawing.Color.Silver
        Me.AuthorTextBox.Location = New System.Drawing.Point(312, 77)
        Me.AuthorTextBox.Name = "AuthorTextBox"
        Me.AuthorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AuthorTextBox.TabIndex = 5
        '
        'PublisherTextBox
        '
        Me.PublisherTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PublisherTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "Publisher", True))
        Me.PublisherTextBox.ForeColor = System.Drawing.Color.Silver
        Me.PublisherTextBox.Location = New System.Drawing.Point(490, 41)
        Me.PublisherTextBox.Name = "PublisherTextBox"
        Me.PublisherTextBox.Size = New System.Drawing.Size(216, 20)
        Me.PublisherTextBox.TabIndex = 3
        '
        'booknm
        '
        Me.booknm.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.booknm.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "BookName", True))
        Me.booknm.ForeColor = System.Drawing.Color.Silver
        Me.booknm.Location = New System.Drawing.Point(117, 77)
        Me.booknm.Name = "booknm"
        Me.booknm.Size = New System.Drawing.Size(142, 20)
        Me.booknm.TabIndex = 4
        '
        'BookIDTextBox
        '
        Me.BookIDTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BookIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "BookID", True))
        Me.BookIDTextBox.ForeColor = System.Drawing.Color.Silver
        Me.BookIDTextBox.Location = New System.Drawing.Point(117, 41)
        Me.BookIDTextBox.Name = "BookIDTextBox"
        Me.BookIDTextBox.Size = New System.Drawing.Size(130, 20)
        Me.BookIDTextBox.TabIndex = 1
        '
        'GroupDTableAdapter
        '
        Me.GroupDTableAdapter.ClearBeforeFill = True
        '
        'OFDpicture
        '
        Me.OFDpicture.Filter = "JPEG Files|*.jpg"
        '
        'PictureTableAdapter1
        '
        Me.PictureTableAdapter1.ClearBeforeFill = True
        '
        'allbooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(871, 465)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BooksDataGridView)
        Me.ForeColor = System.Drawing.Color.Silver
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "allbooks"
        Me.Text = "allbooks"
        CType(Me.LibraryDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ptcover, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LibraryDataDataSet As LMS_HNDIT_16_GP.LibraryDataDataSet
    Friend WithEvents BooksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BooksTableAdapter As LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.BooksTableAdapter
    Friend WithEvents TableAdapterManager As LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BooksDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EditionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PublishingYearTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AuthorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents booknm As System.Windows.Forms.TextBox
    Friend WithEvents BookIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupDBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GroupDTableAdapter As LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.GroupDTableAdapter
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents stu As System.Windows.Forms.ComboBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PublisherTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ptcover As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents OFDpicture As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PictureTableAdapter1 As LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.pictureTableAdapter
    Friend WithEvents grpid As System.Windows.Forms.ComboBox
End Class
