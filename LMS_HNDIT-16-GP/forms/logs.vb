Public Class logs

    Private Sub IlogBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.IlogBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LibraryDataDataSet)

    End Sub

    Private Sub logs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'LibraryDataDataSet.rlog' table. You can move, or remove it, as needed.
            Me.RlogTableAdapter.Fill(Me.LibraryDataDataSet.rlog)
            'TODO: This line of code loads data into the 'LibraryDataDataSet.ilog' table. You can move, or remove it, as needed.
            Me.IlogTableAdapter.Fill(Me.LibraryDataDataSet.ilog)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try


    End Sub
End Class