<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class libfees
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
        Dim MonthPaymentLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LibraryDataDataSet = New LMS_HNDIT_16_GP.LibraryDataDataSet()
        Me.PaymentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PaymentsTableAdapter = New LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.paymentsTableAdapter()
        Me.TableAdapterManager = New LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.TableAdapterManager()
        Me.PaymentsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.NotpaiedusersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NotpaiedusersTableAdapter = New LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.notpaiedusersTableAdapter()
        Me.NotpaiedusersDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CIDTextBox = New System.Windows.Forms.TextBox()
        Me.payment = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        MonthPaymentLabel = New System.Windows.Forms.Label()
        CType(Me.LibraryDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotpaiedusersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotpaiedusersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MonthPaymentLabel
        '
        MonthPaymentLabel.AutoSize = True
        MonthPaymentLabel.Location = New System.Drawing.Point(46, 237)
        MonthPaymentLabel.Name = "MonthPaymentLabel"
        MonthPaymentLabel.Size = New System.Drawing.Size(84, 13)
        MonthPaymentLabel.TabIndex = 5
        MonthPaymentLabel.Text = "Month Payment:"
        '
        'LibraryDataDataSet
        '
        Me.LibraryDataDataSet.DataSetName = "LibraryDataDataSet"
        Me.LibraryDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PaymentsBindingSource
        '
        Me.PaymentsBindingSource.DataMember = "payments"
        Me.PaymentsBindingSource.DataSource = Me.LibraryDataDataSet
        '
        'PaymentsTableAdapter
        '
        Me.PaymentsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BooksTableAdapter = Nothing
        Me.TableAdapterManager.CustomerTableAdapter = Nothing
        Me.TableAdapterManager.GroupDTableAdapter = Nothing
        Me.TableAdapterManager.ilogTableAdapter = Nothing
        Me.TableAdapterManager.IssueTableAdapter = Nothing
        Me.TableAdapterManager.loginsTableAdapter = Nothing
        Me.TableAdapterManager.notpaiedusersTableAdapter = Nothing
        Me.TableAdapterManager.paymentsTableAdapter = Me.PaymentsTableAdapter

        Me.TableAdapterManager.rlogTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PaymentsDataGridView
        '
        Me.PaymentsDataGridView.AllowUserToAddRows = False
        Me.PaymentsDataGridView.AllowUserToDeleteRows = False
        Me.PaymentsDataGridView.AutoGenerateColumns = False
        Me.PaymentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.PaymentsDataGridView.BackgroundColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PaymentsDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.PaymentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PaymentsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewCheckBoxColumn1})
        Me.PaymentsDataGridView.DataSource = Me.PaymentsBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PaymentsDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.PaymentsDataGridView.EnableHeadersVisualStyles = False
        Me.PaymentsDataGridView.Location = New System.Drawing.Point(427, 12)
        Me.PaymentsDataGridView.Name = "PaymentsDataGridView"
        Me.PaymentsDataGridView.ReadOnly = True
        Me.PaymentsDataGridView.RowHeadersVisible = False
        Me.PaymentsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PaymentsDataGridView.Size = New System.Drawing.Size(459, 210)
        Me.PaymentsDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PAYID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "PAYID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "User ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "MonthPayment"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Monthly Payment"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Paid"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Paid"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(376, 227)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 30)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Paid>>"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'NotpaiedusersBindingSource
        '
        Me.NotpaiedusersBindingSource.DataMember = "notpaiedusers"
        Me.NotpaiedusersBindingSource.DataSource = Me.LibraryDataDataSet
        '
        'NotpaiedusersTableAdapter
        '
        Me.NotpaiedusersTableAdapter.ClearBeforeFill = True
        '
        'NotpaiedusersDataGridView
        '
        Me.NotpaiedusersDataGridView.AllowUserToAddRows = False
        Me.NotpaiedusersDataGridView.AllowUserToDeleteRows = False
        Me.NotpaiedusersDataGridView.AutoGenerateColumns = False
        Me.NotpaiedusersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.NotpaiedusersDataGridView.BackgroundColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.NotpaiedusersDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.NotpaiedusersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.NotpaiedusersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.NotpaiedusersDataGridView.DataSource = Me.NotpaiedusersBindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.NotpaiedusersDataGridView.DefaultCellStyle = DataGridViewCellStyle4
        Me.NotpaiedusersDataGridView.EnableHeadersVisualStyles = False
        Me.NotpaiedusersDataGridView.Location = New System.Drawing.Point(3, 12)
        Me.NotpaiedusersDataGridView.Name = "NotpaiedusersDataGridView"
        Me.NotpaiedusersDataGridView.ReadOnly = True
        Me.NotpaiedusersDataGridView.RowHeadersVisible = False
        Me.NotpaiedusersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.NotpaiedusersDataGridView.Size = New System.Drawing.Size(401, 210)
        Me.NotpaiedusersDataGridView.TabIndex = 11
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "user ID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CName"
        Me.DataGridViewTextBoxColumn5.HeaderText = "User Name"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CAddress"
        Me.DataGridViewTextBoxColumn6.HeaderText = "User Address"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "CContact"
        Me.DataGridViewTextBoxColumn7.HeaderText = "User Contact"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'CIDTextBox
        '
        Me.CIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NotpaiedusersBindingSource, "CID", True))
        Me.CIDTextBox.Location = New System.Drawing.Point(12, 389)
        Me.CIDTextBox.Name = "CIDTextBox"
        Me.CIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CIDTextBox.TabIndex = 12
        Me.CIDTextBox.TabStop = False
        '
        'payment
        '
        Me.payment.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.payment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.payment.ForeColor = System.Drawing.Color.Silver
        Me.payment.Location = New System.Drawing.Point(134, 234)
        Me.payment.Name = "payment"
        Me.payment.Size = New System.Drawing.Size(75, 20)
        Me.payment.TabIndex = 13
        Me.payment.Text = "500"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(682, 228)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(187, 30)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "remove from paid list"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(682, 264)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(187, 30)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "reset paid list"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'libfees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(888, 381)
        Me.Controls.Add(Me.payment)
        Me.Controls.Add(Me.CIDTextBox)
        Me.Controls.Add(Me.NotpaiedusersDataGridView)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(MonthPaymentLabel)
        Me.Controls.Add(Me.PaymentsDataGridView)
        Me.ForeColor = System.Drawing.Color.Silver
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "libfees"
        Me.ShowIcon = False
        Me.Text = "libfees"
        CType(Me.LibraryDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotpaiedusersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotpaiedusersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LibraryDataDataSet As LMS_HNDIT_16_GP.LibraryDataDataSet
    Friend WithEvents PaymentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PaymentsTableAdapter As LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.paymentsTableAdapter
    Friend WithEvents TableAdapterManager As LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PaymentsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents NotpaiedusersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NotpaiedusersTableAdapter As LMS_HNDIT_16_GP.LibraryDataDataSetTableAdapters.notpaiedusersTableAdapter
    Friend WithEvents NotpaiedusersDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents payment As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
