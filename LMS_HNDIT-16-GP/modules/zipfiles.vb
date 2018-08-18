Imports System.IO
Imports System.IO.Compression
Module zipfiles


    '-----------------------------------------------------------------------
    'this module created by HNDIT/2016 using thirdparty code elements that 
    'gethered from internet 
    'sources: 'http://www.mkasoft.com/how-to/39-how-to-compress-file
    '-----------------------------------------------------------------------














    Public Sub ZipAFile(fname As String, extpath As String)
        'fname - file name that going to archive
        'extpath is the zip file path eg: c:\abc.zip


        'Dim fname As String = "C:\tmp\k.exe"
        ' Dim extpath As String = "C:\tmp\backup.zip"

        Dim z As System.IO.Packaging.ZipPackage


        z = System.IO.Packaging.Package.Open(extpath, FileMode.Create)
        Dim b() As Byte = System.IO.File.ReadAllBytes(fname)

        Dim puid As Uri = System.IO.Packaging.PackUriHelper.CreatePartUri(New Uri(System.IO.Path.GetFileName(fname), UriKind.Relative))
        Dim p = z.CreatePart(puid, System.Net.Mime.MediaTypeNames.Application.Zip, Packaging.CompressionOption.Normal)

        p.GetStream.Write(b, 0, b.Length)
        z.Close()


    End Sub

    Public Sub ZipExtractAFile(zipname As String, extpath As String)
        'zipname - zip file name
        'extpath should like "C:\tmp\"
        Dim filename = zipname


        Dim Z As System.IO.Packaging.ZipPackage

        Z = System.IO.Packaging.Package.Open(filename, IO.FileMode.Open)

        ' loop on every part/file

        For Each P As System.IO.Packaging.PackagePart In Z.GetParts

            ' get the file name

            Dim FN As String = extpath '& P.Uri.OriginalString

            ' open the steams

            Dim S = P.GetStream(System.IO.FileMode.Open)

            Dim S2 As New System.IO.FileStream(FN, IO.FileMode.Create)

            ' use buffer of 1KB , you could use more

            Dim Buffer(0 To 1023) As Byte

            Do

                ' read from the stream

                Dim R = S.Read(Buffer, 0, Buffer.Length)

                ' if a byte or more was read, then write it, else stop the loop

                If R <> 0 Then

                    S2.Write(Buffer, 0, R)

                Else

                    Exit Do

                End If

            Loop

            ' close both files

            S.Close()

            S2.Close()

        Next

        ' close the zip file

        Z.Close()


    End Sub



End Module
