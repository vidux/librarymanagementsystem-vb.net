Public Class Form1
    Private mousedownk As Boolean = False
    Private lastlocation As Point
   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        allbooks.Visible = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        groups.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        usrrrs.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        issue.Visible = True
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        e.Cancel = True

        Me.Hide()
        noticon.ShowBalloonTip(8000, "LMS Software", "this program minimized to system tray" & vbNewLine & " you can close this at any time from here :)", ToolTipIcon.Info)

    End Sub
    Private Sub updateStus()
        st.Text = ""
        st2.Text = ""
        st3.Text = ""
        Dim isu As String = 0, isu2 As String = 0
        Try
            st.Text = Getsqlvalue("SELECT Count(BookID) FROM books")
            st2.Text = Getsqlvalue("SELECT Count(CID) FROM Customer")
            isu = Getsqlvalue("SELECT Count(LogID) FROM ilog")
            isu2 = Getsqlvalue("SELECT Count(LogID) FROM rlog")
            st3.Text = isu & "( " & isu2 & " returns)"
        Catch fl As System.Data.OleDb.OleDbException
            MsgBox("oops you have flooded the sql connection. in your sql server connection protection was activated(i think) " & vbNewLine & "but don't panic. wait 2 miniutes. and do your works as usual", vbInformation)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateStus()



    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        returnsz.Visible = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        logs.Visible = True
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click

        Application.ExitThread()
    End Sub

    Private Sub noticon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles noticon.MouseDoubleClick
        Me.Visible = True
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Me.Visible = True
    End Sub

    Private Sub ViewLogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewLogToolStripMenuItem.Click
        logs.Visible = True
    End Sub

    Private Sub ManageGroupsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageGroupsToolStripMenuItem.Click
        groups.Visible = True
    End Sub

    Private Sub ManageUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageUsersToolStripMenuItem.Click
        usrrrs.Visible = True
    End Sub

    Private Sub ManageBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageBooksToolStripMenuItem.Click
        allbooks.Visible = True
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        abu.Visible = True
    End Sub

    Private Sub TT_Draw(sender As Object, e As DrawToolTipEventArgs) Handles TT.Draw
        e.DrawBackground()
        e.DrawBorder()
        e.DrawText()

    End Sub

    Private Sub TT_Popup(sender As Object, e As PopupEventArgs) Handles TT.Popup

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        updateStus()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If MsgBox("this will close program and not minimize to system tray" & vbNewLine & "do you want to continue?", MsgBoxStyle.YesNo + vbInformation) = MsgBoxResult.Yes Then
            Application.ExitThread()
        End If

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        fromMainPanel = True
        logins_frm.Visible = True

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        CloudSync.Visible = True
    End Sub

    Private Sub pic_Click(sender As Object, e As EventArgs) Handles pic.Click

    End Sub

    Private Sub pic_MouseDown(sender As Object, e As MouseEventArgs) Handles pic.MouseDown
        mousedownk = True
        lastlocation = e.Location
    End Sub

    Private Sub pic_MouseMove(sender As Object, e As MouseEventArgs) Handles pic.MouseMove
        If mousedownk = True Then
            Me.Location = New Point((Me.Location.X - lastlocation.X) + e.X, (Me.Location.Y - lastlocation.Y) + e.Y)
            Me.Update()

        End If
    End Sub


    Private Sub pic_MouseUp(sender As Object, e As MouseEventArgs) Handles pic.MouseUp
        mousedownk = False
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Close()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        libfees.Visible = True

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        abu.ShowDialog()

    End Sub
End Class
