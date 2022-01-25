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
        TimerReceived.Interval = 1 ' Optimal 55ms | pada beberapa forum vb mereka mengatakan semakin kecil ms akan memberatkan CPU device yang di gunakan 
        'Timer Send untuk sementara di gunakan untuk mengirim data start dan stop 
        TimerSend.Interval = 100
        'Timer Revers untuk menghitung mundur pada button start
        TimerRevers.Interval = 1000 ' Untuk menit rubah menjadi 10000

        TimerDemo.Interval = 10 ' Timer Untuk Demo
    End Sub

    Sub TimerDemo_Tick(sender As Object, e As System.EventArgs) Handles TimerDemo.Tick
        Dim i, j As Integer
        Dim HB As Integer
        For i = 0 To 25 Step 1
            LineWaveSpo2(Rnd() * i) 'Random Number
        Next

        HB = 60
        If HB = 0 Then
            TimerSend.Interval = 1
        Else
            TimerSend.Enabled = True
            TimerSend.Interval = 60 * 1000 / HB
        End If

    End Sub
    Public Sub TimerReceived_Tick(sender As Object, e As System.EventArgs) Handles TimerReceived.Tick
        Dim HB As Double 'HB = HeartBeat
        Dashboard.Refresh()

        Dim ReceivedData As String = Dashboard.com1.ReadLine() 'Menerima data dari Serial Port ( Jika menggunakan .Readline = Otomatis Enter pada saat penerimaan data |
        'jika menggunakan .ReadExisting tidak akan otomatis membuat line baru 
        'Dashboard.com1.DiscardOutBuffer()
        Dim testArray() As String = ReceivedData.Split(New String() {";", "\r", "\n"}, StringSplitOptions.None) 'Split untuk memisahkan data 




        'Mengatasi Lag dengan melakukan refresh 
        'Dashboard.Refresh()
        'Untuk Menampilkan di Label
        'Dashboard.com1.DiscardInBuffer()

        Dashboard.com1.DiscardInBuffer()

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


        Select Case testArray(2)
            Case 0
                'LineWaveECG(1000)
            Case Else
                LineWaveECG(testArray(2))
                AddDataGridView(testArray(2))
        End Select

        'Line Preassure
        Select Case testArray(4)
            Case 0
                LineWavePressure(1000)
            Case Else
                LineWavePressure(testArray(4))
        End Select

        'Indikator SideBar and Led 
        Select Case testArray(4)
            Case 50
                Dashboard.Panel_I1.BackColor = ColorID
            Case 100
                Dashboard.Panel_I2.BackColor = ColorID
            Case 150
                Dashboard.Panel_I2.BackColor = ColorID
                Dashboard.Panel_I3.BackColor = ColorID
            Case Else
                DefaultID()
        End Select
    End Sub
    Sub AddDataGridView(valueData As String)
        If ViewDataGrid.DataGridView1.DataSource Is Nothing Then
            With ViewDataGrid.DataGridView1
                .Rows.Add(valueData)
            End With
        End If
    End Sub

    Public Sub TimerSend_Tick(sender As Object, e As System.EventArgs) Handles TimerSend.Tick
        SendDataSerialPort("q") ' katakter q = perintah untuk menyalakan lampu pada alat
    End Sub
    Private Sub TimerReal_Tick(sender As Object, e As EventArgs) Handles TimerReal.Tick
        Dashboard.LabelDateDay.Text = Today
        Dashboard.LabelTime.Text = TimeOfDay
        'SPO2
        If TimerReceived.Enabled = False Then
            LineWaveSpo2(500)
            LineWaveECG(500)
            LineWavePressure(500)
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
