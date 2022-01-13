Module SendData
    Sub SendDataSerialPort(aksi As String)
        'Mengirimkan data berbentuk baris melalui serial port 
        Dashboard.com1.WriteLine("*" & aksi & ";" & Dashboard.IDControl1 & ";" & Dashboard.IDControl2 & "#")
    End Sub

End Module
