<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrrrs
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
        Dim CIDLabel As System.Windows.Forms.Label
        Dim CNameLabel As System.Windows.Forms.Label
        Dim CAddressLabel As System.Windows.Forms.Label
        Dim CContactLabel As System.Windows.Forms.Label
        Dim CSecurityLabel As System.Windows.Forms.Label
        Dim CActiveDateLabel As System.Windows.Forms.Label
        Dim CValidLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LibraryDataDataSet = New LMS_HNDIT_16_GP.LibraryDataDataSet()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter = New LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.CustomerTableAdapter()
        Me.TableAdapterManager = New LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.TableAdapterManager()
        Me.CustomerDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CValidDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CActiveDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CSecurityTextBox = New System.Windows.Forms.TextBox()
        Me.CContactTextBox = New System.Windows.Forms.TextBox()
        Me.CAddressTextBox = New System.Windows.Forms.TextBox()
        Me.CNameTextBox = New System.Windows.Forms.TextBox()
        Me.CIDTextBox = New System.Windows.Forms.TextBox()
        CIDLabel = New System.Windows.Forms.Label()
        CNameLabel = New System.Windows.Forms.Label()
        CAddressLabel = New System.Windows.Forms.Label()
        CContactLabel = New System.Windows.Forms.Label()
        CSecurityLabel = New System.Windows.Forms.Label()
        CActiveDateLabel = New System.Windows.Forms.Label()
        CValidLabel = New System.Windows.Forms.Label()
        CType(Me.LibraryDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CIDLabel
        '
        CIDLabel.AutoSize = True
        CIDLabel.Location = New System.Drawing.Point(31, 31)
        CIDLabel.Name = "CIDLabel"
        CIDLabel.Size = New System.Drawing.Size(44, 13)
        CIDLabel.TabIndex = 0
        CIDLabel.Text = "user ID:"
        '
        'CNameLabel
        '
        CNameLabel.AutoSize = True
        CNameLabel.Location = New System.Drawing.Point(12, 70)
        CNameLabel.Name = "CNameLabel"
        CNameLabel.Size = New System.Drawing.Size(63, 13)
        CNameLabel.TabIndex = 2
        CNameLabel.Text = "User Name:"
        '
        'CAddressLabel
        '
        CAddressLabel.AutoSize = True
        CAddressLabel.Location = New System.Drawing.Point(366, 31)
        CAddressLabel.Name = "CAddressLabel"
        CAddressLabel.Size = New System.Drawing.Size(73, 13)
        CAddressLabel.TabIndex = 4
        CAddressLabel.Text = "User Address:"
        '
        'CContactLabel
        '
        CContactLabel.AutoSize = True
        CContactLabel.Location = New System.Drawing.Point(186, 31)
        CContactLabel.Name = "CContactLabel"
        CContactLabel.Size = New System.Drawing.Size(72, 13)
        CContactLabel.TabIndex = 6
        CContactLabel.Text = "User Contact:"
        '
        'CSecurityLabel
        '
        CSecurityLabel.AutoSize = True
        CSecurityLabel.Location = New System.Drawing.Point(316, 70)
        CSecurityLabel.Name = "CSecurityLabel"
        CSecurityLabel.Size = New System.Drawing.Size(123, 13)
        CSecurityLabel.TabIndex = 8
        CSecurityLabel.Text = "borow Security payment:"
        '
        'CActiveDateLabel
        '
        CActiveDateLabel.AutoSize = True
        CActiveDateLabel.Location = New System.Drawing.Point(30, 101)
        CActiveDateLabel.Name = "CActiveDateLabel"
        CActiveDateLabel.Size = New System.Drawing.Size(66, 13)
        CActiveDateLabel.TabIndex = 10
        CActiveDateLabel.Text = "Active Date:"
        '
        'CValidLabel
        '
        CValidLabel.AutoSize = True
        CValidLabel.Location = New System.Drawing.Point(51, 141)
        CValidLabel.Name = "CValidLabel"
        CValidLabel.Size = New System.Drawing.Size(45, 13)
        CValidLabel.TabIndex = 12
        CValidLabel.Text = "Valid till:"
        '
        'LibraryDataDataSet
        '
        Me.LibraryDataDataSet.DataSetName = "LibraryDataDataSet"
        Me.LibraryDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.LibraryDataDataSet
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BooksTableAdapter = Nothing
        Me.TableAdapterManager.CustomerTableAdapter = Me.CustomerTableAdapter
        Me.TableAdapterManager.GroupDTableAdapter = Nothing
        Me.TableAdapterManager.ilogTableAdapter = Nothing
        Me.TableAdapterManager.IssueTableAdapter = Nothing
        Me.TableAdapterManager.loginsTableAdapter = Nothing

        Me.TableAdapterManager.rlogTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CustomerDataGridView
        '
        Me.CustomerDataGridView.AllowUserToAddRows = False
        Me.CustomerDataGridView.AllowUserToDeleteRows = False
        Me.CustomerDataGridView.AutoGenerateColumns = False
        Me.CustomerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CustomerDataGridView.BackgroundColor = System.Drawing.Color.DimGray
        Me.CustomerDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CustomerDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.CustomerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.CustomerDataGridView.DataSource = Me.CustomerBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CustomerDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.CustomerDataGridView.EnableHeadersVisualStyles = False
        Me.CustomerDataGridView.Location = New System.Drawing.Point(12, 24)
        Me.CustomerDataGridView.Name = "CustomerDataGridView"
        Me.CustomerDataGridView.ReadOnly = True
        Me.CustomerDataGridView.RowHeadersVisible = False
        Me.CustomerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CustomerDataGridView.Size = New System.Drawing.Size(834, 197)
        Me.CustomerDataGridView.TabIndex = 1
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
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "CName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CAddress"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CAddress"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CContact"
        Me.DataGridViewTextBoxColumn4.HeaderText = "CContact"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CSecurity"
        Me.DataGridViewTextBoxColumn5.HeaderText = "CSecurity"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CActiveDate"
        Me.DataGridViewTextBoxColumn6.HeaderText = "CActiveDate"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "CValid"
        Me.DataGridViewTextBoxColumn7.HeaderText = "CValid"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(450, 141)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 32)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Update"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(369, 141)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 32)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Add New"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(531, 141)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 32)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Remove"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(CValidLabel)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.CValidDateTimePicker)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(CActiveDateLabel)
        Me.GroupBox1.Controls.Add(Me.CActiveDateDateTimePicker)
        Me.GroupBox1.Controls.Add(CSecurityLabel)
        Me.GroupBox1.Controls.Add(Me.CSecurityTextBox)
        Me.GroupBox1.Controls.Add(CContactLabel)
        Me.GroupBox1.Controls.Add(Me.CContactTextBox)
        Me.GroupBox1.Controls.Add(CAddressLabel)
        Me.GroupBox1.Controls.Add(Me.CAddressTextBox)
        Me.GroupBox1.Controls.Add(CNameLabel)
        Me.GroupBox1.Controls.Add(Me.CNameTextBox)
        Me.GroupBox1.Controls.Add(CIDLabel)
        Me.GroupBox1.Controls.Add(Me.CIDTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(228, 227)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(618, 202)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "enter details"
        '
        'CValidDateTimePicker
        '
        Me.CValidDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerBindingSource, "CValid", True))
        Me.CValidDateTimePicker.Location = New System.Drawing.Point(109, 135)
        Me.CValidDateTimePicker.Name = "CValidDateTimePicker"
        Me.CValidDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.CValidDateTimePicker.TabIndex = 13
        '
        'CActiveDateDateTimePicker
        '
        Me.CActiveDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerBindingSource, "CActiveDate", True))
        Me.CActiveDateDateTimePicker.Location = New System.Drawing.Point(109, 97)
        Me.CActiveDateDateTimePicker.Name = "CActiveDateDateTimePicker"
        Me.CActiveDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.CActiveDateDateTimePicker.TabIndex = 11
        '
        'CSecurityTextBox
        '
        Me.CSecurityTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CSecurityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "CSecurity", True))
        Me.CSecurityTextBox.ForeColor = System.Drawing.Color.Silver
        Me.CSecurityTextBox.Location = New System.Drawing.Point(445, 67)
        Me.CSecurityTextBox.Name = "CSecurityTextBox"
        Me.CSecurityTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CSecurityTextBox.TabIndex = 9
        '
        'CContactTextBox
        '
        Me.CContactTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CContactTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "CContact", True))
        Me.CContactTextBox.ForeColor = System.Drawing.Color.Silver
        Me.CContactTextBox.Location = New System.Drawing.Point(259, 28)
        Me.CContactTextBox.Name = "CContactTextBox"
        Me.CContactTextBox.Size = New System.Drawing.Size(101, 20)
        Me.CContactTextBox.TabIndex = 7
        '
        'CAddressTextBox
        '
        Me.CAddressTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "CAddress", True))
        Me.CAddressTextBox.ForeColor = System.Drawing.Color.Silver
        Me.CAddressTextBox.Location = New System.Drawing.Point(445, 28)
        Me.CAddressTextBox.Name = "CAddressTextBox"
        Me.CAddressTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CAddressTextBox.TabIndex = 5
        '
        'CNameTextBox
        '
        Me.CNameTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "CName", True))
        Me.CNameTextBox.ForeColor = System.Drawing.Color.Silver
        Me.CNameTextBox.Location = New System.Drawing.Point(75, 67)
        Me.CNameTextBox.Name = "CNameTextBox"
        Me.CNameTextBox.Size = New System.Drawing.Size(205, 20)
        Me.CNameTextBox.TabIndex = 3
        '
        'CIDTextBox
        '
        Me.CIDTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "CID", True))
        Me.CIDTextBox.ForeColor = System.Drawing.Color.Silver
        Me.CIDTextBox.Location = New System.Drawing.Point(80, 28)
        Me.CIDTextBox.Name = "CIDTextBox"
        Me.CIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CIDTextBox.TabIndex = 1
        '
        'usrrrs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(875, 441)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CustomerDataGridView)
        Me.ForeColor = System.Drawing.Color.Silver
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "usrrrs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "users"
        CType(Me.LibraryDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LibraryDataDataSet As LMS_HNDIT_16_GP.LibraryDataDataSet
    Friend WithEvents CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerTableAdapter As LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents TableAdapterManager As LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomerDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CContactTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CValidDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents CActiveDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents CSecurityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
