Module TimerWatch
    Public WithEvents TimerReceived As New System.Windows.Forms.Timer
    Public WithEvents TimerSend As New System.Windows.Forms.Timer
    Public WithEvents TimerReal As New System.Windows.Forms.Timer
    Sub SetTimer()
        'Timer Real Digunakan untuk jam dan tanggal
        TimerReal.Enabled = True
        TimerReal.Interval = 1
        'Timer Received di gunakan untuk menerima data
        TimerReceived.Interval = 35
        'Timer Send untuk sementara di gunakan untuk mengirim data start dan stop 
        TimerSend.Interval = 100
    End Sub
    Public Sub TimerReceived_Tick(sender As Object, e As System.EventArgs) Handles TimerReceived.Tick
        Dim HB As Double
        Dim ReceivedData As String = Dashboard.com1.ReadLine() '
        Dim testArray() As String = ReceivedData.Split(New String() {";"}, StringSplitOptions.None)
        For Each s As String In testArray
            HB = testArray(1)
            LineWaveSpo2(testArray(0))
            Dashboard.LabelWaveSpo2.Text = "Wave :" & testArray(0)
            Dashboard.LabelHB.Text = "HB : " & testArray(1)
            If HB = 0 Then
                TimerSend.Interval = 1
            Else
                TimerSend.Enabled = True
                TimerSend.Interval = 60 * 1000 / HB
            End If
        Next
    End Sub
    Public Sub TimerSend_Tick(sender As Object, e As System.EventArgs) Handles TimerSend.Tick
        Dashboard.com1.WriteLine("q") 'Mengirimkan katakter q ke alat
    End Sub

    Private Sub TimerReal_Tick(sender As Object, e As EventArgs) Handles TimerReal.Tick
        Dashboard.LabelDateDay.Text = Today
        Dashboard.LabelTime.Text = TimeOfDay
        LineWaveECG(50) 'Memanggil Fungsi LineWave pada Modul Wave
        'SPO2
        If TimerReceived.Enabled = False Then
            LineWaveSpo2(50)
        ElseIf TimerReceived.Enabled = True Then

        End If
    End Sub
End Module
