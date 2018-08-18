Public Class usrrrs

    Private Sub CustomerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CustomerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LibraryDataDataSet)

    End Sub

    Private Sub usrrrs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.CustomerTableAdapter.Fill(Me.LibraryDataDataSet.Customer)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try


            CustomerTableAdapter.Insert(CIDTextBox.Text, CNameTextBox.Text, CAddressTextBox.Text, CContactTextBox.Text, CSecurityTextBox.Text, CActiveDateDateTimePicker.Value, CValidDateTimePicker.Value)


            Me.CustomerTableAdapter.Fill(Me.LibraryDataDataSet.Customer)




        

        Catch n As Exception

            MsgBox(n.Message, MsgBoxStyle.Information)

            'MsgBox("cannot add new one. book id is null or empty fill all fields and try agian :(")

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            CustomerBindingSource.RemoveCurrent()
            Button3.PerformClick()

        Catch n As Exception
            '  MsgBox(n)
            MsgBox(n.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            CustomerBindingSource.EndEdit()
            CustomerTableAdapter.Update(LibraryDataDataSet.Customer)


           


        Catch n As Exception

            ' MsgBox(n.ToString)

            MsgBox(n.Message, MsgBoxStyle.Information)

        End Try
    End Sub

    Private Sub CustomerDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CustomerDataGridView.CellContentClick

    End Sub

    Private Sub CustomerDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles CustomerDataGridView.DataError

    End Sub
End Class