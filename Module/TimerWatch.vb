Imports System.Threading
Module TimerWatch
    Public WithEvents TimerReceived As New System.Windows.Forms.Timer
    Public WithEvents TimerSend As New System.Windows.Forms.Timer
    Public WithEvents TimerReal As New System.Windows.Forms.Timer
    Public WithEvents TimerRevers As New System.Windows.Forms.Timer

    'OPSI CADANGAN bisa menggunakan Timer seperti ini * hanya saja berbeda fungsi seperti di atas
    Public TimerWaktu As New System.Timers.Timer

    Public Seconds As Integer = 60 ' Sebagai Timer untuk berapa menit melakukan treatment 
    Sub SetTimer()
        'Timer Real Digunakan untuk jam dan tanggal
        TimerReal.Enabled = True
        TimerReal.Interval = 1
        'Timer Received di gunakan untuk menerima data
        TimerReceived.Interval = 32 ' 32 Optimal 
        'Timer Send untuk sementara di gunakan untuk mengirim data start dan stop 
        TimerSend.Interval = 100
        'Timer Revers untuk menghitung mundur pada button start
        TimerRevers.Interval = 1000 ' Untuk menit rubah menjadi 10000
    End Sub
    Public Sub TimerReceived_Tick(sender As Object, e As System.EventArgs) Handles TimerReceived.Tick
        Dim HB As Double 'HB = HeartBeat
        Dim ReceivedData As String = Dashboard.com1.ReadLine() 'Menerima Data dari Serial Port
        Dashboard.com1.DiscardInBuffer()
        Dim testArray() As String = ReceivedData.Split(New String() {";"}, StringSplitOptions.None) 'Split untuk memisahkan data 
        For Each s As String In testArray
            HB = testArray(1)
            LineWaveSpo2(testArray(0))
            'Dashboard.Chart3.SuspendLayout()
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
        SendDataSerialPort("q") ' katakter q = perintah untuk menyalakan lampu pada alat
    End Sub

    Private Sub TimerReal_Tick(sender As Object, e As EventArgs) Handles TimerReal.Tick
        Dashboard.LabelDateDay.Text = Today
        Dashboard.LabelTime.Text = TimeOfDay


        LineWaveECG(50) 'Memanggil Fungsi LineWave pada Modul Wave
        LineWavePressure(50) ' Memanggil Fungsi LineWace pada Modul Wave
        'SPO2
        If TimerReceived.Enabled = False Then
            LineWaveSpo2(50)
        ElseIf TimerReceived.Enabled = True Then

        End If
    End Sub

    Public Sub TimerRevers_Tick(sender As Object, e As System.EventArgs) Handles TimerRevers.Tick
        If Seconds = 0 Then
            Dashboard.ButtonStart.Text = "START"
            TimerRevers.Enabled = False
            Seconds = 60
            SendDataSerialPort("e")
        Else
            Seconds = Seconds - 1
            Dashboard.ButtonStart.Text = Seconds
        End If
    End Sub


End Module
