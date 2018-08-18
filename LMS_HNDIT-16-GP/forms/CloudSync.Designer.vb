<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CloudSync
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnStartDownload = New System.Windows.Forms.Button()
        Me.pw = New System.Windows.Forms.TextBox()
        Me.un = New System.Windows.Forms.TextBox()
        Me.chekzip = New System.Windows.Forms.CheckBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ftppath = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TT = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.zipfilek = New System.ComponentModel.BackgroundWorker()
        Me.uplod = New System.ComponentModel.BackgroundWorker()
        Me.stat = New System.Windows.Forms.Label()
        Me.downl = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(281, 233)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Upload"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnStartDownload
        '
        Me.btnStartDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStartDownload.Location = New System.Drawing.Point(281, 308)
        Me.btnStartDownload.Name = "btnStartDownload"
        Me.btnStartDownload.Size = New System.Drawing.Size(75, 23)
        Me.btnStartDownload.TabIndex = 0
        Me.btnStartDownload.Text = "Download"
        Me.TT.SetToolTip(Me.btnStartDownload, "download data base file from server")
        Me.btnStartDownload.UseVisualStyleBackColor = True
        '
        'pw
        '
        Me.pw.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pw.ForeColor = System.Drawing.Color.Silver
        Me.pw.Location = New System.Drawing.Point(121, 55)
        Me.pw.Name = "pw"
        Me.pw.Size = New System.Drawing.Size(235, 20)
        Me.pw.TabIndex = 2
        Me.TT.SetToolTip(Me.pw, "enter password of cloud/ftp account")
        Me.pw.UseSystemPasswordChar = True
        '
        'un
        '
        Me.un.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.un.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.un.ForeColor = System.Drawing.Color.Silver
        Me.un.Location = New System.Drawing.Point(121, 29)
        Me.un.Name = "un"
        Me.un.Size = New System.Drawing.Size(235, 20)
        Me.un.TabIndex = 1
        Me.TT.SetToolTip(Me.un, "Enter your cloud/ftp user name here")
        '
        'chekzip
        '
        Me.chekzip.AutoSize = True
        Me.chekzip.BackColor = System.Drawing.Color.Transparent
        Me.chekzip.Checked = True
        Me.chekzip.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chekzip.Location = New System.Drawing.Point(23, 190)
        Me.chekzip.Name = "chekzip"
        Me.chekzip.Size = New System.Drawing.Size(303, 17)
        Me.chekzip.TabIndex = 2
        Me.chekzip.Text = "compress Database before upload(this save time and data)"
        Me.chekzip.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 379)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(361, 18)
        Me.ProgressBar1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ftp username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ftp password"
        '
        'ftppath
        '
        Me.ftppath.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ftppath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ftppath.ForeColor = System.Drawing.Color.Silver
        Me.ftppath.Location = New System.Drawing.Point(121, 81)
        Me.ftppath.Name = "ftppath"
        Me.ftppath.Size = New System.Drawing.Size(235, 20)
        Me.ftppath.TabIndex = 3
        Me.TT.SetToolTip(Me.ftppath, "drive path ")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ftp drive path"
        '
        'TT
        '
        Me.TT.AutomaticDelay = 0
        Me.TT.AutoPopDelay = 10000
        Me.TT.BackColor = System.Drawing.Color.Black
        Me.TT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TT.InitialDelay = 1
        Me.TT.OwnerDraw = True
        Me.TT.ReshowDelay = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.OliveDrab
        Me.Label4.Location = New System.Drawing.Point(42, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(271, 39)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "drive path must be assign corectly" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "eg: ftpcloud.com/ or ftpcloud.com/foldername" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "folders must per created , else connection not complete "
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(250, 107)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(106, 25)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "save login data"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'zipfilek
        '
        '
        'uplod
        '
        Me.uplod.WorkerReportsProgress = True
        '
        'stat
        '
        Me.stat.AutoSize = True
        Me.stat.Location = New System.Drawing.Point(12, 359)
        Me.stat.Name = "stat"
        Me.stat.Size = New System.Drawing.Size(0, 13)
        Me.stat.TabIndex = 5
        '
        'downl
        '
        Me.downl.WorkerReportsProgress = True
        '
        'CloudSync
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(385, 401)
        Me.Controls.Add(Me.stat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.chekzip)
        Me.Controls.Add(Me.un)
        Me.Controls.Add(Me.ftppath)
        Me.Controls.Add(Me.pw)
        Me.Controls.Add(Me.btnStartDownload)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.ForeColor = System.Drawing.Color.Silver
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "CloudSync"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CloudSync"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnStartDownload As System.Windows.Forms.Button
    Friend WithEvents pw As System.Windows.Forms.TextBox
    Friend WithEvents un As System.Windows.Forms.TextBox
    Friend WithEvents chekzip As System.Windows.Forms.CheckBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ftppath As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents TT As System.Windows.Forms.ToolTip
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents zipfilek As System.ComponentModel.BackgroundWorker
    Friend WithEvents uplod As System.ComponentModel.BackgroundWorker
    Friend WithEvents stat As System.Windows.Forms.Label
    Friend WithEvents downl As System.ComponentModel.BackgroundWorker
End Class
