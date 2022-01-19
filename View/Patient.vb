Public Class Patient
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        SendDataSerialPort("w")
        SendDataSerialPort("start")
        TimerRevers.Enabled = True
        Seconds = TextBoxTime.Text
        Me.Close()
    End Sub
    Dim Pos As Point
    Private Sub PanelTop_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelTop.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub

    Private Sub ButtonPlus_Click(sender As Object, e As EventArgs) Handles ButtonPlus.Click
        Seconds = Seconds + 1
        TextBoxTime.Text = Seconds
    End Sub

    Private Sub ButtonMin_Click(sender As Object, e As EventArgs) Handles ButtonMin.Click
        Seconds = Seconds - 1
        TextBoxTime.Text = Seconds
    End Sub
End Class