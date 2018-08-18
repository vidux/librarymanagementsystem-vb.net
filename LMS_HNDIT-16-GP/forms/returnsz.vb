Public Class returnsz

   

    Private Sub returnsz_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Try
            Me.CustomerTableAdapter.Fill(LibraryDataDataSet.Customer)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            Me.GroupDTableAdapter.Fill(LibraryDataDataSet.GroupD)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            Me.BooksTableAdapter.Fill(Me.LibraryDataDataSet.Books)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            Me.IssueTableAdapter.searchre(LibraryDataDataSet.Issue)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try












    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If IssueDataGridView.RowCount = 0 Then MsgBox("lis is empty", MsgBoxStyle.Information) : Exit Sub

            Dim cc As String = rtext.Text
            Dim rowval As String = IssueDataGridView.Item(0, IssueDataGridView.CurrentRow.Index).Value

            Addrow("UPDATE Books SET Status='Available' WHERE (BookID = '" & rtext.Text & "')")
            Me.BooksTableAdapter.Fill(LibraryDataDataSet.Books)

            writelog(rowval)

            IssueBindingSource.RemoveCurrent()

            Me.IssueBindingSource.EndEdit()
            Me.IssueTableAdapter.Update(Me.LibraryDataDataSet.Issue)
            MsgBox("book id: " & cc & " is returened")



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

    End Sub
    Private Sub writelog(rowval As String)

        Try
            Me.SetReturnsTableAdapter.Fill(Me.LibraryDataDataSet.setReturns, rowval)
            RlogTableAdapter.Insert(CIDTextBox.Text, CNameTextBox.Text, BookIDTextBox.Text, BookNameTextBox.Text, DateTimePicker1.Value.ToString)
        Catch ex As System.Exception
            SetReturnsBindingSource.Clear()
        End Try
    End Sub

   
    
End Class