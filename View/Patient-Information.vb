Public Class Patient_Information
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Me.Close()
    End Sub

    Private Sub PanelTop_Paint(sender As Object, e As PaintEventArgs) Handles PanelTop.Paint

    End Sub
    Dim Pos As Point
    Private Sub PanelTop_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTop.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub
End Class