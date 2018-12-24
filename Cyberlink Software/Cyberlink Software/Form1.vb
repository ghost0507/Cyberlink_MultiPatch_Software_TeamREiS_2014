Public Class REiS
    Dim Point As New System.Drawing.Point()
    Dim X, Y As Integer

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If e.Button = MouseButtons.Left Then
            Point = Control.MousePosition
            Point.X = Point.X - (X)
            Point.Y = Point.Y - (Y)
            Me.Location = Point
        End If
    End Sub
    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub
    Private Sub btnPatch_MouseDown(sender As Object, e As MouseEventArgs) Handles btnPatch.MouseDown
        btnPatch.BackgroundImage = My.Resources.patch_down
    End Sub

    Private Sub btnPatch_MouseEnter(sender As Object, e As EventArgs) Handles btnPatch.MouseEnter
        btnPatch.BackgroundImage = My.Resources.patch_enter
    End Sub

    Private Sub btnPatch_MouseLeave(sender As Object, e As EventArgs) Handles btnPatch.MouseLeave
        btnPatch.BackgroundImage = My.Resources.patch_button
    End Sub

    Private Sub btnAbout_MouseDown(sender As Object, e As MouseEventArgs) Handles btnAbout.MouseDown
        btnAbout.BackgroundImage = My.Resources.about_down
    End Sub

    Private Sub btnAbout_MouseEnter(sender As Object, e As EventArgs) Handles btnAbout.MouseEnter
        btnAbout.BackgroundImage = My.Resources.about_enter
    End Sub

    Private Sub btnAbout_MouseLeave(sender As Object, e As EventArgs) Handles btnAbout.MouseLeave
        btnAbout.BackgroundImage = My.Resources.about_button
    End Sub

    Private Sub btnKill_MouseDown(sender As Object, e As MouseEventArgs) Handles btnKill.MouseDown
        btnKill.BackgroundImage = My.Resources.killer_down
    End Sub

    Private Sub btnKill_MouseEnter(sender As Object, e As EventArgs) Handles btnKill.MouseEnter
        btnKill.BackgroundImage = My.Resources.killer_enter
    End Sub

    Private Sub btnKill_MouseLeave(sender As Object, e As EventArgs) Handles btnKill.MouseLeave
        btnKill.BackgroundImage = My.Resources.killer_button
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        AboutREiS.ShowDialog()
    End Sub
End Class
