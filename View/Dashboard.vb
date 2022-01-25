Imports System.ComponentModel

Public Class Dashboard
    Public com1 As IO.Ports.SerialPort = Nothing
    Private Sub Button_Exit_Click(sender As Object, e As EventArgs) Handles Button_Exit.Click
        Me.Close()
    End Sub
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormLoad()
        SetMaxChart()
        ViewPort()
        SetTimer()
    End Sub
    Dim Pos As Point
    Private Sub PanelTop_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelTop.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub
    Public DemoStatus As Boolean = False
    Private Sub ButtonDemo_Click(sender As Object, e As EventArgs) Handles ButtonDemo.Click
        If DemoStatus = True Then
            DemoStatus = False
            TimerDemo.Enabled = False
            ButtonDemo.Text = "DEMO"
            SendDataSerialPort("stopdemo")
        Else
            Demo.Show()
        End If
    End Sub

    Public MinuteValue As Integer = 60
    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        Patient.Show()
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
    Public IDControl1 As Integer = 184
    Private Sub ButtonIDPlus1_Click(sender As Object, e As EventArgs) Handles ButtonIDPlus1.Click
        If IDControl1 >= 100000 Then
            IDControl1 = 100000
        Else
            IDControl1 = IDControl1 + 8
        End If
        LabelIDControl1.Text = "R - I " & IDControl1
        com1.Write(IDControl1)
    End Sub

    Private Sub ButtonIDMin1_Click(sender As Object, e As EventArgs) Handles ButtonIDMin1.Click
        If IDControl1 <= 8 Then
            IDControl1 = 8
        Else
            IDControl1 = IDControl1 - 8
        End If
        LabelIDControl1.Text = "R - I " & IDControl1
        com1.Write(IDControl1)

    End Sub
    Public IDControl2 As Integer = 536
    Private Sub ButtonIDPlus2_Click(sender As Object, e As EventArgs) Handles ButtonIDPlus2.Click
        If IDControl2 >= 100000 Then
            IDControl2 = 100000
        Else
            IDControl2 = IDControl2 + 8
        End If
        LabelIDControl2.Text = "R - D " & IDControl2
        com1.Write(IDControl2)
    End Sub
    Private Sub ButtonIDMin2_Click(sender As Object, e As EventArgs) Handles ButtonIDMin2.Click
        If IDControl2 <= 8 Then
            IDControl2 = 8
        Else
            IDControl2 = IDControl2 - 8
        End If
        LabelIDControl2.Text = "R - D " & IDControl2
        com1.Write(IDControl2)
    End Sub
    Public Pressure As Integer = 80
    Private Sub ButtonPlusPressure_Click(sender As Object, e As EventArgs) Handles ButtonPlusPressure.Click
        If Pressure >= 100000 Then
            Pressure = 100000
        Else
            Pressure = Pressure + 1
            SendDataSerialPort("-")
        End If
        LabelPressure.Text = Pressure
    End Sub
    Private Sub ButtonMinPressure_Click(sender As Object, e As EventArgs) Handles ButtonMinPressure.Click
        If Pressure <= 1 Then
            Pressure = 1
        Else
            Pressure = Pressure - 1
            SendDataSerialPort("-")
        End If
        LabelPressure.Text = Pressure
    End Sub
    Dim btnStep As Boolean = False
    Private Sub ButtonStep_Click(sender As Object, e As EventArgs) Handles ButtonStep.Click
        Select Case btnStep
            Case False
                ButtonStep.Text = " 2 STEP "
                btnStep = True
                SendDataSerialPort("2step")

            Case True
                ButtonStep.Text = " 3 STEP "
                btnStep = False
                SendDataSerialPort("3step")

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
    Private Sub ButtonStandby_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        ButtonStop.PerformClick()
        Me.Close()
    End Sub
    Private Sub ButtonStop_Click(sender As Object, e As EventArgs) Handles ButtonStop.Click
        SendDataSerialPort("e")
        SendDataSerialPort("stop")
        LabelType.Text = " TYPE : ADULT "
        TimerRevers.Enabled = False

    End Sub
    Dim BtnFreeze As Boolean = False
    Private Sub ButtonFreeze_Click(sender As Object, e As EventArgs) Handles ButtonFreeze.Click
        Select Case BtnFreeze
            Case False
                ButtonFreeze.Text = " CONTINUE "
                BtnFreeze = True
                TimerReal.Enabled = False
                TimerReceived.Enabled = False

            Case True
                ButtonFreeze.Text = " FREEZE "
                BtnFreeze = False
                TimerReal.Enabled = True
                TimerReceived.Enabled = True

        End Select
    End Sub
    Sub ViewPort()
        ' Mendeklarasikan Port
        Dim Ports As String() = IO.Ports.SerialPort.GetPortNames()
        ' Menambah item port pada Combo box
        For Each Port In Ports
            ComboBoxPort.Items.Add(Port)
        Next Port
        ' Memilih item pada Combo box
        ComboBoxPort.SelectedIndex = 0
    End Sub
    Sub COM5Connecting()
        'Ini untuk koneksi dari VB ke Alat menggunakan Serial Port
        Try
            com1 = My.Computer.Ports.OpenSerialPort(ComboBoxPort.SelectedItem)
            com1.BaudRate = 115200
            TimerReceived.Enabled = True
            LabelPort.Text = "CONNECT"
            LabelPort.ForeColor = Color.Lime
        Catch ex As TimeoutException
            MsgBox("Error: Serial Port read timed out.")
        End Try

    End Sub

    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click
        COM5Connecting()
        ButtonConnect.Enabled = False
        ButtonActive()
    End Sub

    Private Sub ButtonDisconnect_Click(sender As Object, e As EventArgs) Handles ButtonDisconnect.Click
        com1.Close()
        TimerReceived.Enabled = False
        TimerSend.Enabled = False
        LabelPort.Text = "DISCONNECT"
        LabelPort.ForeColor = Color.Red
        ButtonConnect.Enabled = True
        ButtonDisable()
    End Sub
    Dim RCData As String
    Dim Bprm As Double
    Sub ButtonActive()
        ButtonDisconnect.Enabled = True
        ButtonStart.Enabled = True
        ButtonStop.Enabled = True
        ButtonExit.Enabled = False
        ButtonPembanding.Enabled = True
        ButtonMm.Enabled = True
        ButtonFreeze.Enabled = True
        ButtonStep.Enabled = True
        ButtonSave.Enabled = True
        ButtonPatient.Enabled = True
        ButtonDemo.Enabled = True

    End Sub
    Sub ButtonDisable()
        ButtonDisconnect.Enabled = False
        ButtonStart.Enabled = False
        ButtonStop.Enabled = False
        ButtonExit.Enabled = True
        ButtonPembanding.Enabled = False
        ButtonMm.Enabled = False
        ButtonFreeze.Enabled = False
        ButtonStep.Enabled = False
        ButtonSave.Enabled = False
        ButtonPatient.Enabled = False
        ButtonDemo.Enabled = False
    End Sub
    Dim WindowsState As Boolean = True
    Private Sub PanelTop_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles PanelTop.MouseDoubleClick
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub PanelID_Click(sender As Object, e As EventArgs) Handles PanelID.Click
        PanelSideVisible()
        PanelIDControl.Visible = True
    End Sub

    Private Sub PanelECG_Click(sender As Object, e As EventArgs) Handles PanelECG.Click
        PanelSideVisible()
        PanelECGControl.Visible = True
    End Sub

    Private Sub PanelSPO_Click(sender As Object, e As EventArgs) Handles PanelSPO.Click
        PanelSideVisible()
        PanelSPO2Control.Visible = True
    End Sub

    Private Sub PanelPressure_Click(sender As Object, e As EventArgs) Handles PanelPressure.Click
        PanelSideVisible()
        PanelPreassureControl.Visible = True
    End Sub

    Private Sub PanelTime_Click(sender As Object, e As EventArgs) Handles PanelTime.Click
        PanelSideVisible()
        PanelTimeControl.Visible = True
    End Sub
    Sub PanelSideVisible()
        PanelIDControl.Visible = False
        PanelECGControl.Visible = False
        PanelSPO2Control.Visible = False
        PanelPreassureControl.Visible = False
        PanelTimeControl.Visible = False
    End Sub

    Private Sub ButtonToMobile_Click(sender As Object, e As EventArgs) Handles ButtonToMobile.Click
        QrCode.Show()
    End Sub


    Private Sub LabelWaveSpo2_Click(sender As Object, e As EventArgs) Handles LabelWaveSpo2.Click

    End Sub

    Private Sub LabelECG_Click(sender As Object, e As EventArgs) Handles LabelECG.Click
        ViewDataGrid.Show()
    End Sub
End Class
'Untuk yang melanjutkan EECP, Semangat yaa aplikasi sedikit lagi beres