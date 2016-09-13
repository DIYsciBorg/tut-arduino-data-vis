Imports System
Imports System.Threading
Imports System.IO.Ports
Imports System.ComponentModel


Public Class frmMain
    Dim ports As Array
    Delegate Sub SetTextCallback1(ByVal [text] As String)
    Delegate Sub SetTextCallback2(ByVal [text] As String)

    Dim ClassA As New clsFEP()

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        scanPorts()

        ' Pre-set all the registers we have selected fixed values for
        'cbTXMode.SelectedIndex = 0
        cbFreqGroup.SelectedIndex = 0
        cbRetrans.SelectedIndex = 0
        cbRoaming.SelectedIndex = 0
        cbResponse.SelectedIndex = 0
        cbReg14.SelectedIndex = 0
        cbCmdInt.SelectedIndex = 0
        cbBand.SelectedIndex = 0
        cbBuffer.SelectedIndex = 0
        cbAddressCheck.SelectedIndex = 0
        cbBeacon.SelectedIndex = 0
        cbUART.SelectedIndex = 0
        cbLPSU.SelectedIndex = 0
        cbLPSB.SelectedIndex = 0
        cbCrLf.SelectedIndex = 0
        cbTxDelim.SelectedIndex = 0
        cbLPS.SelectedIndex = 0
        cbDITO.SelectedIndex = 0
        cbRepeat1.SelectedIndex = 0
        cbRepeat2.SelectedIndex = 0

    End Sub

    Public Sub scanPorts()
        If SerialPort1.IsOpen = True Then
            SerialPort1.Close()
        End If

        ports = IO.Ports.SerialPort.GetPortNames()
        If ports.Length.Equals(0) Then
            cbPortsA.Text = ""
            cbBaudA.Text = ""
           
            MessageBox.Show("You have no serial ports!")
            Exit Sub
        End If
        cbPortsA.Items.Clear()
        cbPortsA.Items.AddRange(ports)
        
        cbPortsA.SelectedIndex = 0
        cbBaudA.SelectedIndex = 0


    End Sub

    Public Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        ReceivedText1(SerialPort1.ReadExisting())
    End Sub

 

    Public Sub ReceivedText1(ByVal [text] As String)
        If rtbDebug1.InvokeRequired Then
            Dim x As New SetTextCallback1(AddressOf ReceivedText1)
            rtbDebug1.Invoke(x, New Object() {(text)})
        Else
            rtbDebug1.Text &= [text]
        End If
    End Sub

   


    Private Sub btnScanPorts_Click(sender As Object, e As EventArgs) Handles btnScanPorts.Click
        rtbDebug1.Text &= "Scanning Ports..." & vbCr
        scanPorts()

    End Sub

    Public Sub scanClassA()
        If ClassA.isOpen = True Then
            ClassA.Close()
        End If
        If cbPortsA.Text = "" Then
            MsgBox("No A port selected")
            Return
        End If
        If cbBaudA.Text = "" Then
            MsgBox("No A baud rate selected")
            Return
        End If

        ClassA.portName = cbPortsA.Text
        ClassA.baudRate = cbBaudA.Text
        ClassA.Open(cbPortsA.Text, cbBaudA.Text)
        If ClassA.isOpen = True Then
            rtbDebug1.Text &= "Initialized device" & vbCr
        Else
            rtbDebug1.Text &= "Can't initialize port" & vbCr
            ClassA.Close()
            Return
        End If

        rtbDebug1.Text &= "calling FEP..." & vbCr
        Dim rsp As String
        rsp = ClassA.Ver
        rtbDebug1.Text &= "I received: " & rsp & vbCr
        If rsp = "1.001" Then
            rtbDebug1.Text &= "passed the test!" & vbCr
            ' Get Serial number
            rsp = ClassA.TID
            rtbDebug1.Text &= "I received: " & rsp & vbCr
            tbASN.Text = rsp
        Else
            rtbDebug1.Text &= "sorry something is wrong" & vbCr
            ClassA.Close()
            Return
        End If
        AreadParameters()

    End Sub

    Private Sub btnScanFEP1_Click(sender As Object, e As EventArgs) Handles btnScanFEP1.Click
        scanClassA()
        ' preset the write values of critical registers with read in settings
        cbAddress.Text = ClassA.address
        cbGroup.Text = ClassA.group
        cbCounter.Text = ClassA.counterpart
        cbScramble1.Text = ClassA.scramble1
        cbScramble2.Text = ClassA.scramble2
        cbChannel1.Text = ClassA.channel1
        cbChannel2.Text = ClassA.channel2
        cbChannel3.Text = ClassA.channel3


    End Sub

  
    Private Sub AreadParameters()
        ClassA.readAll()
        ' Debug printing
        rtbDebug1.Text &= "Address = " & ClassA.address & vbCr
        rtbDebug1.Text &= "group = " & ClassA.group & vbCr
        rtbDebug1.Text &= "counterpart = " & ClassA.counterpart & vbCr
        rtbDebug1.Text &= "transmit mode = " & ClassA.txmode & vbCr
        rtbDebug1.Text &= "scramble 1 = " & ClassA.scramble1 & vbCr
        rtbDebug1.Text &= "scramble 2 = " & ClassA.scramble2 & vbCr
        rtbDebug1.Text &= "channel mode = " & ClassA.channelmode & vbCr
        rtbDebug1.Text &= "channel 1 = " & ClassA.channel1 & vbCr
        rtbDebug1.Text &= "channel 2 = " & ClassA.channel2 & vbCr
        rtbDebug1.Text &= "channel 3 = " & ClassA.channel3 & vbCr
        rtbDebug1.Text &= "diversity = " & ClassA.diversity & vbCr
        rtbDebug1.Text &= "retransmit count = " & ClassA.retransmit & vbCr
        rtbDebug1.Text &= "roaming thresh = " & ClassA.roamingthresh & vbCr
        rtbDebug1.Text &= "packet response = " & ClassA.packetresponse & vbCr
        rtbDebug1.Text &= "unused = " & ClassA.unused & vbCr
        rtbDebug1.Text &= "cmd interval = " & ClassA.cmdinterval & vbCr
        rtbDebug1.Text &= "band switching = " & ClassA.bandswitching & vbCr
        rtbDebug1.Text &= "bufferClrTime = " & ClassA.buffertime & vbCr
        rtbDebug1.Text &= "address check = " & ClassA.addresscheck & vbCr
        rtbDebug1.Text &= "beacon proc = " & ClassA.beaconmode & vbCr
        rtbDebug1.Text &= "uart = " & ClassA.uart & vbCr
        rtbDebug1.Text &= "powerMode = " & ClassA.powermode & vbCr
        rtbDebug1.Text &= "standby = " & ClassA.standby & vbCr
        rtbDebug1.Text &= "CrLf = " & ClassA.crlf & vbCr
        rtbDebug1.Text &= "txModeDelimiter = " & ClassA.txmodedelimiter & vbCr
        rtbDebug1.Text &= "sleepTime = " & ClassA.sleeptime & vbCr
        rtbDebug1.Text &= "dataTimeout = " & ClassA.datatimeout & vbCr
        rtbDebug1.Text &= "repeaterAddr1 = " & ClassA.repeateraddr1 & vbCr
        rtbDebug1.Text &= "repeaterAddr2 = " & ClassA.repeateraddr2 & vbCr

        'Set text boxes
        tbAddr.Text = ClassA.address
        tbGroup.Text = ClassA.group
        tbCounterpart.Text = ClassA.counterpart
        tbTXMode.Text = ClassA.txmode
        tbScramble1.Text = ClassA.scramble1
        tbScramble2.Text = ClassA.scramble2
        tbFreqGroup.Text = ClassA.channelmode
        tbChannel1.Text = ClassA.channel1
        tbChannel2.Text = ClassA.channel2
        tbChannel3.Text = ClassA.channel3
        tbDiversity.Text = ClassA.diversity
        ' set diversity combo box
        If ClassA.diversity = "00" Then
            cbDiversity.SelectedIndex = 2
        ElseIf ClassA.diversity = "01" Then
            cbDiversity.SelectedIndex = 1
        End If
        tbRetrans.Text = ClassA.retransmit
        tbRoaming.Text = ClassA.roamingthresh
        tbResponse.Text = ClassA.packetresponse
        tbReg14.Text = ClassA.unused
        tbCmdInt.Text = ClassA.cmdinterval
        tbBand.Text = ClassA.bandswitching
        tbBuffer.Text = ClassA.buffertime
        tbAddressCheck.Text = ClassA.addresscheck
        tbBeacon.Text = ClassA.beaconmode
        tbUART.Text = ClassA.uart
        tbLPSU.Text = ClassA.powermode
        tbLPSB.Text = ClassA.standby
        tbCrLf.Text = ClassA.crlf
        tbTxDelim.Text = ClassA.txmodedelimiter
        tbLPS.Text = ClassA.sleeptime
        tbDITO.Text = ClassA.datatimeout
        tbRepeat1.Text = ClassA.repeateraddr1
        tbRepeat2.Text = ClassA.repeateraddr2

    End Sub


    Private Sub btnAWrite_Click(sender As Object, e As EventArgs) Handles btnAWrite.Click
        ' assign the entry fields to the class variables
        ClassA.address = cbAddress.Text
        ClassA.group = cbGroup.Text
        ClassA.counterpart = cbCounter.Text
        ClassA.txmode = cbTXMode.Text
        ClassA.scramble1 = cbScramble1.Text
        ClassA.scramble2 = cbScramble2.Text
        ClassA.channelmode = cbFreqGroup.Text
        ClassA.channel1 = cbChannel1.Text
        ClassA.channel2 = cbChannel2.Text
        ClassA.channel3 = cbChannel3.Text

        If cbDiversity.SelectedIndex = 0 Then
            MsgBox("No diversity mode selected")
            Return
        ElseIf cbDiversity.SelectedIndex = 1 Then
            ClassA.diversity = "01"
        ElseIf cbDiversity.SelectedIndex = 2 Then
            ClassA.diversity = "00"
        End If

        ClassA.retransmit = cbRetrans.Text
        ClassA.roamingthresh = cbRoaming.Text
        ClassA.packetresponse = cbResponse.Text
        ClassA.unused = cbReg14.Text
        ClassA.cmdinterval = cbCmdInt.Text
        ClassA.bandswitching = cbBand.Text
        ClassA.buffertime = cbBuffer.Text
        ClassA.addresscheck = cbAddressCheck.Text
        ClassA.beaconmode = cbBeacon.Text
        ClassA.uart = cbUART.Text
        ClassA.powermode = cbLPSU.Text
        ClassA.standby = cbLPSB.Text
        ClassA.crlf = cbCrLf.Text
        ClassA.txmodedelimiter = cbTxDelim.Text
        ClassA.sleeptime = cbLPS.Text
        ClassA.datatimeout = cbDITO.Text
        ClassA.repeateraddr1 = cbRepeat1.Text
        ClassA.repeateraddr2 = cbRepeat2.Text



        ' issue write all command
        If ClassA.isOpen = False Then
            ClassA.Open(cbPortsA.Text, cbBaudA.Text)

        End If
        ClassA.writeAll()
        MsgBox("Write opperations on A complete")

    End Sub

    

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim tempPort As Integer
        Dim result As Integer
        If ClassA.isOpen = True Then
            tempPort = cbPortsA.SelectedIndex
            result = ClassA.reset()
            If result = 1 Then
                cbPortsA.SelectedIndex = tempPort
                cbBaudA.SelectedIndex = 1

                scanClassA()
            Else
                MsgBox("Something failed on A")
            End If
        Else
            MsgBox("Module A is not connected?")
        End If
    End Sub


    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        MsgBox("Output can be found in the report window.")

        rtbDebug1.Text &= vbCr
        rtbDebug1.Text &= "Copy this output" & vbCr
        rtbDebug1.Text &= "directly to the sheet" & vbCr
        rtbDebug1.Text &= vbCr
        rtbDebug1.Text &= ClassA.TID & vbCr
        rtbDebug1.Text &= vbCr
        rtbDebug1.Text &= ClassA.address & "H" & vbCr
        rtbDebug1.Text &= ClassA.group & "H" & vbCr
        rtbDebug1.Text &= ClassA.counterpart & "H" & vbCr
        rtbDebug1.Text &= ClassA.txmode & "H" & vbCr
        rtbDebug1.Text &= ClassA.scramble1 & "H" & vbCr
        rtbDebug1.Text &= ClassA.scramble2 & "H" & vbCr
        rtbDebug1.Text &= ClassA.channelmode & "H" & vbCr
        rtbDebug1.Text &= ClassA.channel1 & "H" & vbCr
        rtbDebug1.Text &= ClassA.channel2 & "H" & vbCr
        rtbDebug1.Text &= ClassA.channel3 & "H" & vbCr
        rtbDebug1.Text &= ClassA.diversity & "H" & vbCr
        rtbDebug1.Text &= ClassA.retransmit & "H" & vbCr
        rtbDebug1.Text &= ClassA.roamingthresh & "H" & vbCr
        rtbDebug1.Text &= ClassA.packetresponse & "H" & vbCr
        rtbDebug1.Text &= ClassA.unused & "H" & vbCr
        rtbDebug1.Text &= ClassA.cmdinterval & "H" & vbCr
        rtbDebug1.Text &= ClassA.bandswitching & "H" & vbCr
        rtbDebug1.Text &= ClassA.buffertime & "H" & vbCr
        rtbDebug1.Text &= ClassA.addresscheck & "H" & vbCr
        rtbDebug1.Text &= ClassA.beaconmode & "H" & vbCr
        rtbDebug1.Text &= ClassA.uart & "H" & vbCr
        rtbDebug1.Text &= ClassA.powermode & "H" & vbCr
        rtbDebug1.Text &= ClassA.standby & "H" & vbCr
        rtbDebug1.Text &= ClassA.crlf & "H" & vbCr
        rtbDebug1.Text &= ClassA.txmodedelimiter & "H" & vbCr
        rtbDebug1.Text &= ClassA.sleeptime & "H" & vbCr
        rtbDebug1.Text &= ClassA.datatimeout & "H" & vbCr
        rtbDebug1.Text &= ClassA.repeateraddr1 & "H" & vbCr
        rtbDebug1.Text &= ClassA.repeateraddr2 & "H" & vbCr
        rtbDebug1.Text &= vbCr

    End Sub
End Class