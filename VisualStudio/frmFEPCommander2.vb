Imports System
Imports System.Threading
Imports System.IO.Ports
Imports System.ComponentModel




Public Class frmMain
    Dim ports1 As Array
    Dim ports2 As Array
    Delegate Sub SetTextCallback1(ByVal [text] As String)
    Delegate Sub SetTextCallback2(ByVal [text] As String)

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        scanPorts()
    End Sub

    Public Sub scanPorts()
        ports1 = IO.Ports.SerialPort.GetPortNames()
        cbPorts1.Items.Clear()
        cbPorts1.Items.AddRange(ports1)


        ports2 = IO.Ports.SerialPort.GetPortNames()
        cbPorts2.Items.Clear()
        cbPorts2.Items.AddRange(ports2)

        cbPorts1.SelectedIndex = 0
        cbBaud1.SelectedIndex = 0
        cbPorts2.SelectedIndex = 1
        cbBaud2.SelectedIndex = 0

    End Sub

    Public Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        ReceivedText1(SerialPort1.ReadExisting())
    End Sub

    Public Sub SerialPort2_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort2.DataReceived
        ReceivedText2(SerialPort2.ReadExisting())
    End Sub

    Public Sub ReceivedText1(ByVal [text] As String)
        If rtbDebug1.InvokeRequired Then
            Dim x As New SetTextCallback1(AddressOf ReceivedText1)
            rtbDebug1.Invoke(x, New Object() {(text)})
        Else
            rtbDebug1.Text &= [text]
        End If
    End Sub

    Public Sub ReceivedText2(ByVal [text] As String)
        If rtbDebug1.InvokeRequired Then
            Dim x As New SetTextCallback2(AddressOf ReceivedText2)
            rtbDebug1.Invoke(x, New Object() {(text)})
        Else
            rtbDebug1.Text &= [text]
        End If
    End Sub


    Private Sub cbPorts1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPorts1.SelectedIndexChanged

    End Sub

    Private Sub btnScanPorts_Click(sender As Object, e As EventArgs) Handles btnScanPorts.Click
        rtbDebug1.Text &= "Scanning Ports..." & vbCr
        scanPorts()
        cbPorts1.SelectedIndex = 0
        cbBaud1.SelectedIndex = 0
    End Sub

    Private Sub btnFEP1INIT_Click(sender As Object, e As EventArgs) Handles btnFEP1INIT.Click
        If SerialPort1.IsOpen = True Then
            SerialPort1.Close()
        End If
        SerialPort1.PortName = cbPorts1.Text
        SerialPort1.BaudRate = cbBaud1.Text
        SerialPort1.Open()
        rtbDebug1.Text &= "Initialized device 1 port" & vbCr
    End Sub

    Private Sub btnScanFEP1_Click(sender As Object, e As EventArgs) Handles btnScanFEP1.Click
        rtbDebug1.Text &= "calling FEP 1..." & vbCr
        SerialPort1.Write("@VER" & vbCr & vbLf)
    End Sub

    Private Sub btnFEP2INIT_Click(sender As Object, e As EventArgs) Handles btnFEP2INIT.Click
        If SerialPort2.IsOpen = True Then
            SerialPort2.Close()
        End If
        SerialPort2.PortName = cbPorts1.Text
        SerialPort2.BaudRate = cbBaud1.Text
        SerialPort2.Open()
        rtbDebug2.Text &= "Initialized device 2 port" & vbCr
    End Sub

    Private Sub btnScanFEP2_Click(sender As Object, e As EventArgs) Handles btnScanFEP2.Click
        rtbDebug2.Text &= "calling FEP 2..." & vbCr
        SerialPort2.Write("@VER" & vbCr & vbLf)
    End Sub
End Class
