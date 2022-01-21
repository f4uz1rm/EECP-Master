Module Default_Set
    Public ColorID As Color = Color.Lime
    Public Sub DefaultID()
        Dashboard.Panel_I1.BackColor = System.Drawing.Color.FromArgb(30, 38, 52)
        Dashboard.Panel_I2.BackColor = System.Drawing.Color.FromArgb(30, 38, 52)
        Dashboard.Panel_I3.BackColor = System.Drawing.Color.FromArgb(30, 38, 52)
    End Sub
    Public Sub StepSet(value() As String)
        If value(4) = 50 Then
            Dashboard.Panel_I1.BackColor = ColorID
        ElseIf value(4) = 100 Then
            Dashboard.Panel_I2.BackColor = ColorID
        ElseIf value(4) = 150 Then
            Dashboard.Panel_I2.BackColor = ColorID
            Dashboard.Panel_I3.BackColor = ColorID
        ElseIf value(4) = 0 Then
            DefaultID()
        End If
    End Sub
End Module
