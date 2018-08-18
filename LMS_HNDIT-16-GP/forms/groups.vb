Public Class groups

   

    Private Sub groups_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDataDataSet.GroupD' table. You can move, or remove it, as needed.
        Try
            Me.GroupDTableAdapter.Fill(Me.LibraryDataDataSet.GroupD)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If GroupIDTextBox.Text = "" Or GroupNameTextBox.Text = "" Then
            MsgBox("Group id or group name fields are empty. fill them and try again", MsgBoxStyle.Information)
            Exit Sub
        End If
        Try


            GroupDTableAdapter.Insert(GroupIDTextBox.Text, GroupNameTextBox.Text)
            GroupDTableAdapter.Fill(Me.LibraryDataDataSet.GroupD)


        Catch n As Exception
            MsgBox(n.Message, MsgBoxStyle.Information)
        
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            GroupDBindingSource.EndEdit()
            GroupDTableAdapter.Update(LibraryDataDataSet.GroupD)


           


        Catch n As Exception



            MsgBox(n.Message, MsgBoxStyle.Information)

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            GroupDBindingSource.RemoveCurrent()
            Button3.PerformClick()

        Catch n As Exception

            MsgBox(n.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    

    Private Sub GroupDDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles GroupDDataGridView.DataError
        '  Call Button1.PerformClick()
    End Sub

    
    Private Sub GroupDDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GroupDDataGridView.CellContentClick

    End Sub
End Class