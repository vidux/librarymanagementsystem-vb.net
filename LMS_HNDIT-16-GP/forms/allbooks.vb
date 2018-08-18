Imports System.Data.OleDb

Public Class allbooks



    

    Private Sub allbooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Try
            Me.GroupDTableAdapter.Fill(Me.LibraryDataDataSet.GroupD)


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        Try
            Me.BooksTableAdapter.Fill(Me.LibraryDataDataSet.Books)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub BooksBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles BooksBindingSource.CurrentChanged, stu.Click

    End Sub

   

  

   

   

   

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim d = MsgBox("are you sure to delete this book?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "delete book")
        If d = vbNo Then
            Exit Sub
        End If
        Try
            BooksBindingSource.RemoveCurrent()
            Button1.PerformClick()
        Catch n As Exception

            MsgBox(n.Message, MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub BooksDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles BooksDataGridView.SelectionChanged
        loadIMGtoCover()
    End Sub
    

    Private Sub BooksDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles BooksDataGridView.DataError
        
    End Sub

    Private Sub BooksDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BooksDataGridView.CellContentClick

    End Sub

    Private Sub stu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles stu.SelectedIndexChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Try

            'BooksTableAdapter.Insert(BookIDTextBox.Text, grpid.Text, booknm.Text, PublisherTextBox.Text, AuthorTextBox.Text, PublishingYearTextBox.Text, EditionTextBox.Text, PriceTextBox.Text, stu.Text)
            BooksTableAdapter.Insert(BookIDTextBox.Text, grpid.SelectedValue.ToString, booknm.Text, PublisherTextBox.Text, AuthorTextBox.Text, PublishingYearTextBox.Text, EditionTextBox.Text, PriceTextBox.Text, stu.Text)

            Me.BooksTableAdapter.Fill(Me.LibraryDataDataSet.Books)
            

        Catch ex1 As OleDbException
            MsgBox(ex1.Message, MsgBoxStyle.Information)
            ' MsgBox("bookID cannot duplicate", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)


        End Try



    End Sub

    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.BooksBindingSource.EndEdit()
            Me.BooksTableAdapter.Update(Me.LibraryDataDataSet.Books)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try


    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            OFDpicture.FileName = ""

            OFDpicture.ShowDialog()
            If OFDpicture.FileName = "" Then Exit Sub

            Dim myFile As New System.IO.FileInfo(OFDpicture.FileName)
            If myFile.Length > 100000 Then
                MsgBox("file size larger than 100 kb")
                Exit Sub

            End If


            Dim tmp() As Byte = My.Computer.FileSystem.ReadAllBytes(OFDpicture.FileName)
            PictureTableAdapter1.Insert(BookIDTextBox.Text, tmp)
            loadIMGtoCover()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub loadIMGtoCover()
        Try
            If PictureTableAdapter1.getBytes(BookIDTextBox.Text) Is Nothing Then
                ptcover.Image = ptcover.ErrorImage
                Exit Sub
            End If

            Dim imageByteArray() As Byte = PictureTableAdapter1.getBytes(BookIDTextBox.Text)
            Dim pictureBytes As New System.IO.MemoryStream(imageByteArray)


            ptcover.Image = Image.FromStream(pictureBytes)
        Catch ex As Exception
            ptcover.Image = ptcover.ErrorImage
        End Try

    End Sub

    Private Sub grpid_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupIDLabel_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub grpid_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles grpid.SelectedIndexChanged

    End Sub
End Class