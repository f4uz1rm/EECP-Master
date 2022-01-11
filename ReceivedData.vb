Public Class ReceivedData
    Dim com1 As IO.Ports.SerialPort = Nothing
    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click
        Try
            com1 = My.Computer.Ports.OpenSerialPort("COM3")
            com1.BaudRate = 9600
            MsgBox("Connect")
            Timer1.Enabled = True
        Catch ex As TimeoutException
            MsgBox("Error: Serial Port read timed out.")
        End Try
    End Sub

    Private Sub ButtonDisconnect_Click(sender As Object, e As EventArgs) Handles ButtonDisconnect.Click
        com1.Close()
        Timer1.Enabled = False

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim ReceivedData As String = com1.ReadLine()
        LabelReveived.Text = ReceivedData

    End Sub
End Class