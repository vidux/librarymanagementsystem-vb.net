Public Class issue

    Private Sub issue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDataDataSet.payments' table. You can move, or remove it, as needed.
        Me.PaymentsTableAdapter.Fill(Me.LibraryDataDataSet.payments)
        'TODO: This line of code loads data into the 'LibraryDataDataSet.Customer' table. You can move, or remove it, as needed.

        Try
            Me.CustomerTableAdapter.Fill(LibraryDataDataSet.Customer)
            ' Me.BooksTableAdapter.Fill(LibraryDataDataSet.Books)
            Me.IssueTableAdapter.Fill(LibraryDataDataSet.Issue)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

   

    
    

    

   
    Private Sub seachtext_TextChanged(sender As Object, e As EventArgs) Handles seachtext.TextChanged
        Try

            Me.BooksTableAdapter.seachByBookName(LibraryDataDataSet.Books, seachtext.Text.ToString & "%")

        Catch ex As Exception
            ' MsgBox("search error  ", MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub StatusTextBox_TextChanged(sender As Object, e As EventArgs) Handles StatusTextBox.TextChanged
        If StatusTextBox.Text = "Available" Then
            Me.StatusTextBox.ForeColor = Color.LightGreen

        ElseIf StatusTextBox.Text = "NotAvailable" Then
            Me.StatusTextBox.ForeColor = Color.Red

        End If

        


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
       
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If StatusTextBox.Text = "NotAvailable" Then
            MsgBox("sorry this book not available choose another", MsgBoxStyle.Information)
            Exit Sub
        End If

        Try

            IssueTableAdapter.Insert(IssueIDTextBox.Text, CIDComboBox.Text.ToString, BookIDComboBox.Text.ToString, IssueDateDateTimePicker.Value.ToString, DueDateDateTimePicker.Value.ToString)

            StatusTextBox.Text = "NotAvailable"

            IlogTableAdapter.Insert(CIDComboBox.Text.ToString, CNameTextBox.Text, BookIDComboBox.Text.ToString, BookNameTextBox.Text, IssueIDTextBox.Text, IssueDateDateTimePicker.Value.ToString, DueDateDateTimePicker.Value.ToString)
            Try
                Me.BooksBindingSource.EndEdit()
                Me.BooksTableAdapter.Update(Me.LibraryDataDataSet.Books)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            IssueTableAdapter.Fill(LibraryDataDataSet.Issue)

            ' Addrow("UPDATE Books SET Status='NotAvailable' WHERE (BookID = '" & BookIDComboBox.Text & "')")
            ' Me.BooksTableAdapter.Fill(LibraryDataDataSet.Books)




           






            MsgBox("successfuly issued!", MsgBoxStyle.Information)


        Catch kk As System.Data.OleDb.OleDbException
            MsgBox("issue id must be unique ", MsgBoxStyle.Information)


        Catch nb As Exception

            MsgBox(nb.Message, MsgBoxStyle.Information)

            ' MsgBox(" isssue id is null ", MsgBoxStyle.Information)

        End Try




    End Sub

    

    Private Sub IssueDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles IssueDataGridView.CellContentClick

    End Sub

    Private Sub IssueDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles IssueDataGridView.DataError

    End Sub




   
    Private Sub CIDComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CIDComboBox.SelectedIndexChanged
        Me.CustomerTableAdapter.Fill(LibraryDataDataSet.Customer)
    End Sub
End Class