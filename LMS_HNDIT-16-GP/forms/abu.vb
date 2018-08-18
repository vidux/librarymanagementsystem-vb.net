Public Class abu
    Private mousedownk As Boolean = False
    Private lastlocation As Point
    Private Sub abu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub abu_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        mousedownk = True
        lastlocation = e.Location
    End Sub

    Private Sub abu_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If mousedownk = True Then
            Me.Location = New Point((Me.Location.X - lastlocation.X) + e.X, (Me.Location.Y - lastlocation.Y) + e.Y)
            Me.Update()

        End If
    End Sub

    Private Sub abu_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        mousedownk = False
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Close()
    End Sub
End Class