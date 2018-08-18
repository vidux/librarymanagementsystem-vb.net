Public Class libfees

 

    Private Sub libfees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.NotpaiedusersTableAdapter.Fill(Me.LibraryDataDataSet.notpaiedusers)
            Me.PaymentsTableAdapter.Fill(LibraryDataDataSet.payments)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)

        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            If NotpaiedusersDataGridView.RowCount = 0 Then MsgBox("no users to add", vbInformation) : Exit Sub
            PaymentsTableAdapter.Insert(CIDTextBox.Text, payment.Text, True)
            Me.PaymentsTableAdapter.Fill(LibraryDataDataSet.payments)
            Me.NotpaiedusersTableAdapter.Fill(Me.LibraryDataDataSet.notpaiedusers)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

    End Sub

    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If PaymentsDataGridView.RowCount = 0 Then MsgBox("no users to remove", vbInformation) : Exit Sub
            PaymentsBindingSource.RemoveCurrent()
            PaymentsBindingSource.EndEdit()
            PaymentsTableAdapter.Update(Me.LibraryDataDataSet.payments)
            Me.NotpaiedusersTableAdapter.Fill(Me.LibraryDataDataSet.notpaiedusers)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("are you sure to clear the full list?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            Try
                Addrow("DELETE FROM  payments")

                Me.NotpaiedusersTableAdapter.Fill(Me.LibraryDataDataSet.notpaiedusers)
                Me.PaymentsTableAdapter.Fill(Me.LibraryDataDataSet.payments)


            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try
        End If



    End Sub
End Class