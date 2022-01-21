Public Class Demo
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub
    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        If TextBoxPassword.Text = "1234" Then
            Dashboard.LabelType.Text = " TYPE : DEMO "
            TimerDemo.Enabled = True
            Dashboard.ButtonDemo.Text = "STOP DEMO"
            Dashboard.DemoStatus = True
            SendDataSerialPort("startdemo")

            Me.Close()
        Else
            MsgBox("Password Salah", MsgBoxStyle.Information)
        End If
    End Sub
    Dim Pos As Point
    Private Sub PanelTop_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelTop.MouseMove
        'Untuk memindahkan posisi Form 
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub
End Class