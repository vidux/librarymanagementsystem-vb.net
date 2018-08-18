<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class groups
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
        Dim GroupNameLabel As System.Windows.Forms.Label
        Dim GroupIDLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LibraryDataDataSet = New LMS_HNDIT_16_GP.LibraryDataDataSet()
        Me.GroupDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupDTableAdapter = New LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.GroupDTableAdapter()
        Me.TableAdapterManager = New LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.TableAdapterManager()
        Me.GroupDDataGridView = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupNameTextBox = New System.Windows.Forms.TextBox()
        Me.GroupIDTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        GroupNameLabel = New System.Windows.Forms.Label()
        GroupIDLabel = New System.Windows.Forms.Label()
        CType(Me.LibraryDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupDDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupNameLabel
        '
        GroupNameLabel.AutoSize = True
        GroupNameLabel.Location = New System.Drawing.Point(12, 59)
        GroupNameLabel.Name = "GroupNameLabel"
        GroupNameLabel.Size = New System.Drawing.Size(70, 13)
        GroupNameLabel.TabIndex = 8
        GroupNameLabel.Text = "Group Name:"
        '
        'GroupIDLabel
        '
        GroupIDLabel.AutoSize = True
        GroupIDLabel.Location = New System.Drawing.Point(28, 28)
        GroupIDLabel.Name = "GroupIDLabel"
        GroupIDLabel.Size = New System.Drawing.Size(53, 13)
        GroupIDLabel.TabIndex = 6
        GroupIDLabel.Text = "Group ID:"
        '
        'LibraryDataDataSet
        '
        Me.LibraryDataDataSet.DataSetName = "LibraryDataDataSet"
        Me.LibraryDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupDBindingSource
        '
        Me.GroupDBindingSource.DataMember = "GroupD"
        Me.GroupDBindingSource.DataSource = Me.LibraryDataDataSet
        '
        'GroupDTableAdapter
        '
        Me.GroupDTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BooksTableAdapter = Nothing
        Me.TableAdapterManager.CustomerTableAdapter = Nothing
        Me.TableAdapterManager.GroupDTableAdapter = Me.GroupDTableAdapter
        Me.TableAdapterManager.ilogTableAdapter = Nothing
        Me.TableAdapterManager.IssueTableAdapter = Nothing

        Me.TableAdapterManager.rlogTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GroupDDataGridView
        '
        Me.GroupDDataGridView.AllowUserToAddRows = False
        Me.GroupDDataGridView.AllowUserToDeleteRows = False
        Me.GroupDDataGridView.AutoGenerateColumns = False
        Me.GroupDDataGridView.BackgroundColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GroupDDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.GroupDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GroupDDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.GroupDDataGridView.DataSource = Me.GroupDBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GroupDDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.GroupDDataGridView.EnableHeadersVisualStyles = False
        Me.GroupDDataGridView.Location = New System.Drawing.Point(23, 12)
        Me.GroupDDataGridView.MultiSelect = False
        Me.GroupDDataGridView.Name = "GroupDDataGridView"
        Me.GroupDDataGridView.ReadOnly = True
        Me.GroupDDataGridView.RowHeadersVisible = False
        Me.GroupDDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GroupDDataGridView.Size = New System.Drawing.Size(307, 105)
        Me.GroupDDataGridView.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(GroupNameLabel)
        Me.GroupBox1.Controls.Add(Me.GroupNameTextBox)
        Me.GroupBox1.Controls.Add(GroupIDLabel)
        Me.GroupBox1.Controls.Add(Me.GroupIDTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 139)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(307, 100)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "enter details"
        '
        'GroupNameTextBox
        '
        Me.GroupNameTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GroupDBindingSource, "GroupName", True))
        Me.GroupNameTextBox.ForeColor = System.Drawing.Color.Silver
        Me.GroupNameTextBox.Location = New System.Drawing.Point(88, 56)
        Me.GroupNameTextBox.Name = "GroupNameTextBox"
        Me.GroupNameTextBox.Size = New System.Drawing.Size(207, 20)
        Me.GroupNameTextBox.TabIndex = 9
        '
        'GroupIDTextBox
        '
        Me.GroupIDTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GroupDBindingSource, "GroupID", True))
        Me.GroupIDTextBox.ForeColor = System.Drawing.Color.Silver
        Me.GroupIDTextBox.Location = New System.Drawing.Point(88, 25)
        Me.GroupIDTextBox.Name = "GroupIDTextBox"
        Me.GroupIDTextBox.Size = New System.Drawing.Size(207, 20)
        Me.GroupIDTextBox.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(175, 257)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Remove"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(94, 257)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 52)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Add New"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(175, 286)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "update"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "GroupID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "GroupID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "GroupName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "GroupName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'groups
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(342, 332)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupDDataGridView)
        Me.ForeColor = System.Drawing.Color.Silver
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "groups"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "groups"
        CType(Me.LibraryDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupDDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LibraryDataDataSet As LMS_HNDIT_16_GP.LibraryDataDataSet
    Friend WithEvents GroupDBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GroupDTableAdapter As LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.GroupDTableAdapter
    Friend WithEvents TableAdapterManager As LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GroupDDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
