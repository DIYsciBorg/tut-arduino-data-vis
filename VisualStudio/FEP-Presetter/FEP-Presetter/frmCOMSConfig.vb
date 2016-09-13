Public Class frmCOMSConfig

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub frmCOMSConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnScanPorts_Click(sender As Object, e As EventArgs) Handles btnScanPorts.Click
        frmMain.scanPorts()
    End Sub

    Private Sub btnScanFEP1_Click(sender As Object, e As EventArgs) Handles btnScanFEP1.Click
       
        frmMain.SerialPort1.Write("@VER" & vbCr & vbLf)

    End Sub

    Private Sub btnFEP1INIT_Click(sender As Object, e As EventArgs) Handles btnFEP1INIT.Click
        If frmMain.SerialPort1.IsOpen = True Then
            frmMain.SerialPort1.Close()
        End If
        frmMain.SerialPort1.PortName = cbPorts1.Text
        frmMain.SerialPort1.BaudRate = cbBaud1.Text
        frmMain.SerialPort1.Open()
    End Sub
End Class