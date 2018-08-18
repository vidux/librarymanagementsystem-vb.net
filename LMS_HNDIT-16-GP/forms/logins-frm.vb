
Public Class logins_frm

    Private mousedownk As Boolean = False
    Private lastlocation As Point



    Private Sub aluth_da_paranada()
        Dim rowsc As String = Getsqlvalue("SELECT Count(uname) FROM logins")

        If rowsc = 0 Then
            Label3.Visible = True
            pw2.Visible = True
            Button2.Visible = True
            Button1.Visible = False
        End If


    End Sub


    Private Function texterrcheck() As Boolean
        If pw2.Visible = True Then
            If un.Text = "" Or pw1.Text = "" Or pw2.Text = "" Then MsgBox("fill the empty fields", MsgBoxStyle.Information, "login") : Return False
            If pw1.Text.Equals(pw2.Text) = False Then MsgBox("passwords didn't match", MsgBoxStyle.Information, "login") : Return False

        Else
            If un.Text = "" Or pw1.Text = "" Then MsgBox("fill the empty fields", MsgBoxStyle.Information, "login") : Return False
        End If
        If InStr(un.Text, " ") > 0 Then MsgBox("username cannot contains spaces", MsgBoxStyle.Information, "login") : Return False
        If InStr(pw1.Text, " ") > 0 Then MsgBox("password cannot contains spaces", MsgBoxStyle.Information, "login") : Return False
        If InStr(pw2.Text, " ") > 0 Then MsgBox("password cannot contains spaces", MsgBoxStyle.Information, "login") : Return False



        Return True
    End Function
    Private Sub logins_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        aluth_da_paranada()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If texterrcheck() = False Then Exit Sub
        Try
            LoginsTableAdapter.Insert(un.Text, pw1.Text)
            Form1.Visible = True
            Me.Hide()
        Catch ex As DuplicateNameException
            MsgBox("username already exits. please try new one", MsgBoxStyle.Information, "login")

        Catch ekn As Exception
            MsgBox(ekn.Message)
        End Try




    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If texterrcheck() = False Then Exit Sub









        Try
            Dim Suname As String = Getsqlvalue("SELECT COUNT(*) AS Expr1 FROM  logins GROUP BY [password], uname  HAVING   ([password] = '" & pw1.Text & "') AND (uname = '" & un.Text & "')")

            If Suname = 1 Then

                If fromMainPanel = True Then

                    mngAdmins.Visible = True
                    fromMainPanel = False

                Else

                    Form1.Visible = True

                End If


                Me.Close()
            Else
                MsgBox("username & password didn't match", MsgBoxStyle.Information, "login")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        mousedownk = True
        lastlocation = e.Location

    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If mousedownk = True Then
            Me.Location = New Point((Me.Location.X - lastlocation.X) + e.X, (Me.Location.Y - lastlocation.Y) + e.Y)
            Me.Update()

        End If
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        mousedownk = False
    End Sub
End Class