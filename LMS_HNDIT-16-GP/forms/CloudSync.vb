

Public Class CloudSync

    Private Sub TT_Draw(sender As Object, e As DrawToolTipEventArgs) Handles TT.Draw
        e.DrawBackground()
        e.DrawBorder()
        e.DrawText()
    End Sub

    Private Sub TT_Popup(sender As Object, e As PopupEventArgs) Handles TT.Popup

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If texterrcheck() = False Then Exit Sub

        Dim textline As String = un.Text & " " & pw.Text & " " & ftppath.Text


        InIWriteValue("ftpdata", "2", encriptedText(encriptedText(textline)), IniPath)


    End Sub

    Private Sub CloudSync_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        On Error Resume Next
        Me.Dispose()
        GC.Collect()
    End Sub

    Private Sub CloudSync_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim textline As String = InIReadValue("ftpdata", "2", IniPath)

            textline = decriptedText(decriptedText(textline))


            Dim ss() = textline.Split(" ")
            un.Text = ss(0)
            pw.Text = ss(1)
            ftppath.Text = ss(2)
        Catch ex As Exception

        End Try

    End Sub

    Private Function texterrcheck() As Boolean

        If un.Text = "" Or pw.Text = "" Or ftppath.Text = "" Then MsgBox("fill the empty fields", MsgBoxStyle.Information, "login") : Return False

        If InStr(un.Text, " ") > 0 Then MsgBox("username cannot contains spaces", MsgBoxStyle.Information, "login") : Return False
        If InStr(pw.Text, " ") > 0 Then MsgBox("password cannot contains spaces", MsgBoxStyle.Information, "login") : Return False



        Return True
    End Function



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If zipfilek.IsBusy = True Or uplod.IsBusy = True Then MsgBox("task is running!") : Exit Sub

        Try
            If IO.Directory.Exists(Application.StartupPath & "\syncData") = False Then
                MkDir(Application.StartupPath & "\syncData")
            End If



            If IO.File.Exists(Application.StartupPath & "\LibraryData.mdb") = False Then MsgBox("LibraryData.mdb file not found", MsgBoxStyle.Information) : Exit Sub
            IO.File.Copy(Application.StartupPath & "\LibraryData.mdb", Application.StartupPath & "\syncData\db.tmp", True)

            If chekzip.CheckState = CheckState.Checked Then
                stat.Text = "compressing[zip] data base file..."
                zipfilek.RunWorkerAsync()
            Else
                uplod.RunWorkerAsync()
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            zipfilek.Dispose()

        End Try



    End Sub


    Private Sub zipfilek_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles zipfilek.DoWork
        Try

            ZipAFile(Application.StartupPath & "\syncData\db.tmp", Application.StartupPath & "\syncData\db.tmp.zip")

        Catch ex As Exception
            stat.Text = "compression failed"
            zipfilek.Dispose()
            Exit Sub

        End Try



    End Sub

    Private Sub zipfilek_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles zipfilek.RunWorkerCompleted
        stat.Text = "compress complete!"
        uplod.RunWorkerAsync()
    End Sub

    Private Sub uplod_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles uplod.DoWork
        Try
            Dim request As System.Net.FtpWebRequest = DirectCast(System.Net.WebRequest.Create(ftppath.Text & "/upload.bak"), System.Net.FtpWebRequest)
            request.Credentials = New System.Net.NetworkCredential(un.Text, pw.Text)
            request.Method = System.Net.WebRequestMethods.Ftp.UploadFile

            Dim UploadfileName As String = Application.StartupPath & "\syncData\db.tmp"

            If chekzip.CheckState = CheckState.Checked Then
                UploadfileName = Application.StartupPath & "\syncData\db.tmp.zip"
            End If

            Dim sr As New IO.FileStream(UploadfileName, IO.FileMode.Open)




            Dim strz As System.IO.Stream = request.GetRequestStream()

            Dim buffer(1024) As Byte
            Dim len As Long = sr.Length - 1
            Dim bytesread As Integer





            While sr.Position < len
                bytesread = (sr.Read(buffer, 0, 1024))
                strz.Write(buffer, 0, bytesread)

                uplod.ReportProgress(CInt(sr.Position / len * 100))
                Application.DoEvents()
            End While
            sr.Close()

            strz.Close()
            strz.Dispose()


        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Information)
            uplod.Dispose()
        End Try


    End Sub

    Private Sub uplod_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles uplod.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub uplod_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles uplod.RunWorkerCompleted
        stat.Text = "upload complete!"
    End Sub

   

    Private Function isthiszip(filename As String) As Boolean


        Dim kk As New IO.FileStream(filename, IO.FileMode.Open)
        Dim k(1) As Byte

        kk.Read(k, 0, 2)
        Dim pkg As String = System.Text.Encoding.ASCII.GetString(k)
        kk.Close()
        kk.Dispose()


        If pkg = "PK" Then
            Return True
        End If
        Return False

    End Function

    Private Sub btnStartDownload_Click(sender As Object, e As EventArgs) Handles btnStartDownload.Click
        'this code get from a tutorial:1:http://www.dreamincode.net/forums/topic/185093-download-file-asynchronously-with-progressbar/
        stat.Text = "Downloading"
        Try
            Dim client As System.Net.WebClient = New System.Net.WebClient
            client.Credentials = New System.Net.NetworkCredential(un.Text, pw.Text)

            AddHandler client.DownloadProgressChanged, AddressOf client_ProgressChanged

            AddHandler client.DownloadFileCompleted, AddressOf client_DownloadCompleted


            client.DownloadFileAsync(New Uri(ftppath.Text & "/upload.bak"), Application.StartupPath & "\syncData\downraw.tmp")




            btnStartDownload.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
            btnStartDownload.Enabled = True

        End Try



    End Sub
    Private Sub client_ProgressChanged(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs)
        'this code get from a tutorial:1:
        Try
            ProgressBar1.Value = e.ProgressPercentage
        Catch ex As Exception
            MsgBox(ex.ToString)
            btnStartDownload.Enabled = True
        End Try


    End Sub

    Private Sub client_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)

        stat.Text = "Download Complete"
        btnStartDownload.Enabled = True
        finishfile()
    End Sub

    
    Private Sub finishfile()
        Try
            If IO.File.Exists(Application.StartupPath & "\syncData\downraw.tmp") = True Then
                If isthiszip(Application.StartupPath & "\syncData\downraw.tmp") = True Then
                    ZipExtractAFile(Application.StartupPath & "\syncData\downraw.tmp", Application.StartupPath & "\downloaded-LibraryData.mdb")

                Else
                    IO.File.Copy(Application.StartupPath & "\syncData\downraw.tmp", Application.StartupPath & "\downloaded-LibraryData.mdb")
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try


    End Sub
End Class