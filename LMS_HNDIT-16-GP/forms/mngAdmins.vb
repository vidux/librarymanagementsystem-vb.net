Public Class mngAdmins

  

    Private Sub mngAdmins_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDataDataSet.logins' table. You can move, or remove it, as needed.
        Try
            Me.LoginsTableAdapter.Fill(Me.LibraryDataDataSet.logins)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            Me.Validate()
            Me.LoginsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.LibraryDataDataSet)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            LoginsBindingSource.RemoveCurrent()
            Button8.PerformClick()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            LoginsTableAdapter.Insert(UnameTextBox.Text, PasswordTextBox.Text)
            Me.LoginsTableAdapter.Fill(LibraryDataDataSet.logins)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class