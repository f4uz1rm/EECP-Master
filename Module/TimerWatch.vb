Imports System.Threading
Imports System.Timers
Imports System.ComponentModel
Module TimerWatch
    Public WithEvents TimerReceived As New System.Windows.Forms.Timer
    Public WithEvents TimerSend As New System.Windows.Forms.Timer
    Public WithEvents TimerReal As New System.Windows.Forms.Timer
    Public WithEvents TimerRevers As New System.Windows.Forms.Timer
    Public WithEvents TimerDemo As New System.Windows.Forms.Timer
    'Percobaan
    Public TimerDouble As System.Timers.Timer

    'OPSI CADANGAN bisa menggunakan Timer seperti ini * hanya saja berbeda fungsi seperti di atas
    Public Seconds As Integer = 60 ' Sebagai Timer untuk berapa menit melakukan treatment 

    Private WithEvents Bgw As New ComponentModel.BackgroundWorker
    Private WithEvents St As New Diagnostics.Stopwatch

    Private Event Tick(Ms As Integer)
    Private CancelBgw As Boolean = False

    'Sebagai variable penampung data 
    Public mmHgValue As String
    Private Sub TimerHandler(ByVal timerID As Object)
        MsgBox("Timer Elapsed!!!!")
    End Sub
    Public Sub TimerDouble_Elapsed(sender As Object, e As System.Timers.ElapsedEventArgs)
        Console.WriteLine("Timer 3 Hit...")
    End Sub

    Sub FormLoad()
        With Bgw
            .WorkerSupportsCancellation = True
            If Not .IsBusy Then
                CancelBgw = False
                .RunWorkerAsync()
            End If
        End With
    End Sub
    Private Sub Bgw_DoWork(sender As Object, e As DoWorkEventArgs) Handles Bgw.DoWork
        St.Start()
        While Not CancelBgw
            If St.ElapsedMilliseconds >= 50 Then
                RaiseEvent Tick(St.ElapsedMilliseconds)
                St.Reset()
                St.Start()
            End If
        End While
    End Sub
    Sub SetTimer()
        'Timer Real Digunakan untuk jam dan tanggal
        TimerReal.Enabled = True
        TimerReal.Interval = 50
        'Timer Received di gunakan untuk menerima data
        TimerReceived.Interval = 50 ' Optimal 55ms | pada beberapa forum vb mereka mengatakan semakin kecil ms akan memberatkan CPU device yang di gunakan 
        'Timer Send untuk sementara di gunakan untuk mengirim data start dan stop 
        TimerSend.Interval = 100
        'Timer Revers untuk menghitung mundur pada button start
        TimerRevers.Interval = 1000 ' Untuk menit rubah menjadi 10000

        TimerDemo.Interval = 50 ' Timer Untuk Demo
    End Sub

    Sub TimerDemo_Tick(sender As Object, e As System.EventArgs) Handles TimerDemo.Tick
        Dim i, j As Integer
        For i = 0 To 25 Step 1
            LineWaveSpo2(Rnd() * i)
        Next
    End Sub
    Public Sub TimerWaktu_Tick(sender As Object, e As System.EventArgs)
        Debug.WriteLine("Test")
    End Sub

    Public Sub TimerReceived_Tick(sender As Object, e As System.EventArgs) Handles TimerReceived.Tick
        Dim HB As Double 'HB = HeartBeat
        Dim ColorID As Color = Color.Lime
        Dim ReceivedData As String = Dashboard.com1.ReadLine() 'Menerima data dari Serial Port ( Jika menggunakan .Readline = Otomatis Enter pada saat penerimaan data
        Dashboard.com1.DiscardInBuffer()
        Dim testArray() As String = ReceivedData.Split(New String() {";"}, StringSplitOptions.None) 'Split untuk memisahkan data 

        For Each s As String In testArray
            'Mengatasi Lag 
            Dashboard.Refresh()
            'Untuk Menampilkan di Label
            Dashboard.LabelWaveSpo2.Text = "Spo Wave : " & vbCrLf & testArray(0)
            Dashboard.LabelHB.Text = "HB : " & vbCrLf & testArray(1)
            Dashboard.LabelECG.Text = "ECG Wave " & vbCrLf & testArray(2)
            Dashboard.LabelMmhg.Text = testArray(3)
            Dashboard.LabelPreassure.Text = "Preassure : " & vbCrLf & testArray(4)
            'HB
            HB = testArray(1)
            If HB = 0 Then
                TimerSend.Interval = 1
            Else
                TimerSend.Enabled = True
                TimerSend.Interval = 60 * 1000 / HB
            End If

            'Line Wave Spo2
            LineWaveSpo2(testArray(0))

            'Line Wave ECG
            If testArray(2) = 0 Then
                LineWaveECG(1000)
            Else
                LineWaveECG(testArray(2))
            End If

            'Line STEP WAVE
            LineWavePressure(testArray(4))

            'STEP
            If testArray(4) = 50 Then
                Dashboard.Panel_I1.BackColor = ColorID
            ElseIf testArray(4) = 100 Then
                Dashboard.Panel_I2.BackColor = ColorID
            ElseIf testArray(4) = 150 Then
                Dashboard.Panel_I2.BackColor = ColorID
                Dashboard.Panel_I3.BackColor = ColorID
            ElseIf testArray(4) = 0 Then
                DefaultID()
            End If
        Next
    End Sub
    Sub DefaultID()
        Dashboard.Panel_I1.BackColor = System.Drawing.Color.FromArgb(30, 38, 52)
        Dashboard.Panel_I2.BackColor = System.Drawing.Color.FromArgb(30, 38, 52)
        Dashboard.Panel_I3.BackColor = System.Drawing.Color.FromArgb(30, 38, 52)
    End Sub
    Public Sub TimerSend_Tick(sender As Object, e As System.EventArgs) Handles TimerSend.Tick
        SendDataSerialPort("-") ' katakter q = perintah untuk menyalakan lampu pada alat
    End Sub
    Private Sub TimerReal_Tick(sender As Object, e As EventArgs) Handles TimerReal.Tick
        Dashboard.LabelDateDay.Text = Today
        Dashboard.LabelTime.Text = TimeOfDay
        'SPO2
        If TimerReceived.Enabled = False Then
            LineWaveSpo2(500)
            LineWaveECG(500)
            LineWavePressure(500) ' Memanggil Fungsi LineWace pada Modul Wave

            'Memanggil Fungsi LineWave pada Modul Wave
            'LineWavePressure(50) ' Memanggil Fungsi LineWace pada Modul Wave
        ElseIf TimerReceived.Enabled = True Then

        End If
    End Sub

    Public Sub TimerRevers_Tick(sender As Object, e As System.EventArgs) Handles TimerRevers.Tick
        If Seconds = 0 Then
            Dashboard.ButtonStart.Text = "START"
            TimerRevers.Enabled = False
            Seconds = 60
            SendDataSerialPort("e")
            Dashboard.ButtonStop.PerformClick()
        Else
            Seconds = Seconds - 1
            Dashboard.ButtonStart.Text = Seconds
        End If
    End Sub


End Module
