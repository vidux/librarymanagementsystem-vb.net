

Partial Public Class LibraryDataDataSet
    Partial Class IssueDataTable

        Private Sub IssueDataTable_IssueRowChanging(sender As Object, e As IssueRowChangeEvent) Handles Me.IssueRowChanging

        End Sub

        Private Sub IssueDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.IssueDateColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class

Namespace LibraryDataDataSetTableAdapters
    
    Partial Class paymentsTableAdapter

    End Class

    Partial Public Class IssueTableAdapter
    End Class
End Namespace
