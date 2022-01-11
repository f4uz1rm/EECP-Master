Public Class Dashboard
    Dim com1 As IO.Ports.SerialPort = Nothing
    Private Sub Button_Exit_Click(sender As Object, e As EventArgs) Handles Button_Exit.Click
        Me.Close()
    End Sub
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetMaxChart()
        ViewPort()
    End Sub
    Dim Pos As Point
    Private Sub PanelTop_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelTop.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub

    Private Sub TimerWatch_Tick(sender As Object, e As EventArgs) Handles TimerWatch.Tick
        LabelDateDay.Text = Today
        LabelTime.Text = TimeOfDay
        'LineWaveECG(50 * Rnd(2))
        'SPO2
        If TimerReceived.Enabled = False Then
            LineWaveSpo2(50)
        ElseIf TimerReceived.Enabled = True Then

        End If
    End Sub
    Private Sub ButtonDemo_Click(sender As Object, e As EventArgs) Handles ButtonDemo.Click
        Demo.Show()
    End Sub

    Public MinuteValue As Integer = 60
    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click

    End Sub

    Private Sub ButtonPatient_Click(sender As Object, e As EventArgs) Handles ButtonPatient.Click
        Patient_Information.Show()
    End Sub
    'AMP ECG
    Dim AmpEcg As Integer = 1
    Private Sub ButtonPlusEcg_Click(sender As Object, e As EventArgs) Handles ButtonPlusEcg.Click
        If AmpEcg >= 32 Then
            AmpEcg = 32
        Else
            AmpEcg = AmpEcg + 1
        End If
        LabelAmpEcg.Text = "AMP X" & AmpEcg
    End Sub

    Private Sub ButtonMinEcg_Click(sender As Object, e As EventArgs) Handles ButtonMinEcg.Click
        If AmpEcg <= 1 Then
            AmpEcg = 1
        Else
            AmpEcg = AmpEcg - 1
        End If
        LabelAmpEcg.Text = "AMP X" & AmpEcg

    End Sub
    Dim AmpSpo2 As Integer = 1
    Private Sub ButtonPlus_Click(sender As Object, e As EventArgs) Handles ButtonPlus.Click
        If AmpSpo2 >= 32 Then
            AmpSpo2 = 32
        Else
            AmpSpo2 = AmpSpo2 + 1
        End If
        LabelAmpSpo.Text = "AMP X" & AmpSpo2
    End Sub

    Private Sub ButtonMin_Click(sender As Object, e As EventArgs) Handles ButtonMin.Click
        If AmpSpo2 <= 1 Then
            AmpSpo2 = 1
        Else
            AmpSpo2 = AmpSpo2 - 1
        End If
        LabelAmpSpo.Text = "AMP X" & AmpSpo2
    End Sub
    Dim IDControl1 As Integer = 184
    Private Sub ButtonIDPlus1_Click(sender As Object, e As EventArgs) Handles ButtonIDPlus1.Click
        If IDControl1 >= 100000 Then
            IDControl1 = 100000
        Else
            IDControl1 = IDControl1 + 8
        End If
        LabelIDControl1.Text = "R - I " & IDControl1
    End Sub

    Private Sub ButtonIDMin1_Click(sender As Object, e As EventArgs) Handles ButtonIDMin1.Click
        If IDControl1 <= 8 Then
            IDControl1 = 8
        Else
            IDControl1 = IDControl1 - 8
        End If
        LabelIDControl1.Text = "R - I " & IDControl1
    End Sub

    Dim IDControl2 As Integer = 536
    Private Sub ButtonIDPlus2_Click(sender As Object, e As EventArgs) Handles ButtonIDPlus2.Click
        If IDControl2 >= 100000 Then
            IDControl2 = 100000
        Else
            IDControl2 = IDControl2 + 8
        End If
        LabelIDControl2.Text = "R - D " & IDControl2
    End Sub

    Private Sub ButtonIDMin2_Click(sender As Object, e As EventArgs) Handles ButtonIDMin2.Click
        If IDControl2 <= 8 Then
            IDControl2 = 8
        Else
            IDControl2 = IDControl2 - 8
        End If
        LabelIDControl2.Text = "R - D " & IDControl2
    End Sub

    Dim Pressure As Integer = 80
    Private Sub ButtonPlusPressure_Click(sender As Object, e As EventArgs) Handles ButtonPlusPressure.Click
        If Pressure >= 100000 Then
            Pressure = 100000
        Else
            Pressure = Pressure + 1
        End If
        LabelPressure.Text = Pressure
    End Sub
    Private Sub ButtonMinPressure_Click(sender As Object, e As EventArgs) Handles ButtonMinPressure.Click
        If Pressure <= 1 Then
            Pressure = 1
        Else
            Pressure = Pressure - 1
        End If
        LabelPressure.Text = Pressure
    End Sub
    Dim btnStep As Boolean = False
    Private Sub ButtonStep_Click(sender As Object, e As EventArgs) Handles ButtonStep.Click
        Select Case btnStep
            Case False
                ButtonStep.Text = " 2 STEP "
                btnStep = True

            Case True
                ButtonStep.Text = " 3 STEP "
                btnStep = False

        End Select

    End Sub
    Dim btnMm As Boolean = False
    Private Sub ButtonMm_Click(sender As Object, e As EventArgs) Handles ButtonMm.Click
        Select Case btnMm
            Case False
                ButtonMm.Text = " 50 mm/s "
                btnMm = True

            Case True
                ButtonMm.Text = " 25 mm/s "
                btnMm = False

        End Select
    End Sub

    Dim btnStndby As Boolean = False
    Private Sub ButtonStandby_Click(sender As Object, e As EventArgs) Handles ButtonStandby.Click
        Select Case btnStndby
            Case False
                ButtonStandby.Text = " COME BACK "
                btnStndby = True

            Case True
                ButtonStandby.Text = " PAUSE "
                btnStndby = False

        End Select
    End Sub

    Private Sub ButtonStop_Click(sender As Object, e As EventArgs) Handles ButtonStop.Click
        LabelType.Text = " TYPE : ADULT "
    End Sub
    Dim BtnFreeze As Boolean = False
    Private Sub ButtonFreeze_Click(sender As Object, e As EventArgs) Handles ButtonFreeze.Click
        Select Case BtnFreeze
            Case False
                ButtonFreeze.Text = " CONTINUE "
                BtnFreeze = True
                TimerWatch.Enabled = False

            Case True
                ButtonFreeze.Text = " FREEZE "
                BtnFreeze = False
                TimerWatch.Enabled = True
        End Select
    End Sub
    Sub ViewPort()
        ' Declare Ports 
        Dim Ports As String() = IO.Ports.SerialPort.GetPortNames()
        ' Add port name Into a comboBox control 
        For Each Port In Ports
            ComboBoxPort.Items.Add(Port)
        Next Port
        ' Select an item in the combobox
        ComboBoxPort.SelectedIndex = 0
    End Sub
    Sub COM5Connecting()
        Try
            com1 = My.Computer.Ports.OpenSerialPort(ComboBoxPort.SelectedItem)
            com1.BaudRate = 115200
            com1.ReadTimeout = 20000
            TimerReceived.Enabled = True
            LabelPort.Text = "CONNECT"
            LabelPort.ForeColor = Color.Lime
        Catch ex As TimeoutException
            MsgBox("Error: Serial Port read timed out.")
        End Try

    End Sub

    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click
        COM5Connecting()
    End Sub

    Private Sub ButtonDisconnect_Click(sender As Object, e As EventArgs) Handles ButtonDisconnect.Click
        com1.Close()
        TimerReceived.Enabled = False
        LabelPort.Text = "DISCONNECT"
        LabelPort.ForeColor = Color.Red

    End Sub
    Dim RCData As String
    Dim Bprm As Double
    Private Sub TimerReceived_Tick(sender As Object, e As EventArgs) Handles TimerReceived.Tick

        Dim ReceivedData As String = com1.ReadLine()
        Dim testArray() As String = ReceivedData.Split(New String() {";"}, StringSplitOptions.None)
        For Each s As String In testArray
            LineWaveSpo2(testArray(0))
            LabelWaveSpo2.Text = "Wave :" & testArray(0)
            LabelHB.Text = "HB : " & testArray(1)
        Next

    End Sub
End Class