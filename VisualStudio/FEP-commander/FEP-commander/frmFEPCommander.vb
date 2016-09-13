Imports System
Imports System.Threading
Imports System.IO.Ports
Imports System.ComponentModel


Public Class frmMain
    Dim ports As Array
    Delegate Sub SetTextCallback1(ByVal [text] As String)
    Delegate Sub SetTextCallback2(ByVal [text] As String)

    Dim ClassA As New clsFEP()
    Dim ClassB As New clsFEP()

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        scanPorts()

    End Sub

    Public Sub scanPorts()
        If SerialPort1.IsOpen = True Then
            SerialPort1.Close()
        End If
        If SerialPort2.IsOpen = True Then
            SerialPort2.Close()
        End If

        ports = IO.Ports.SerialPort.GetPortNames()
        If ports.Length.Equals(0) Then
            cbPortsA.Text = ""
            cbBaudA.Text = ""
            cbPortsB.Text = ""
            cbBaudB.Text = ""
            MessageBox.Show("You have no serial ports!")
            Exit Sub
        End If
        cbPortsA.Items.Clear()
        cbPortsA.Items.AddRange(ports)
        cbPortsB.Items.Clear()
        cbPortsB.Items.AddRange(ports)

        cbPortsA.SelectedIndex = 0
        cbBaudA.SelectedIndex = 0

        If ports.Length.Equals(1) Then
            cbPortsB.Text = ""
            cbBaudB.Text = ""
            ' need to disable B side here!
            Exit Sub
        End If
        cbPortsB.SelectedIndex = 1
        cbBaudB.SelectedIndex = 0

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
            rtbDebug2.Invoke(x, New Object() {(text)})
        Else
            rtbDebug2.Text &= [text]
        End If
    End Sub


    Private Sub btnScanPorts_Click(sender As Object, e As EventArgs) Handles btnScanPorts.Click
        rtbDebug1.Text &= "Scanning Ports..." & vbCr
        rtbDebug2.Text &= "Scanning Ports..." & vbCr
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
            rtbDebug1.Text &= "Initialized device on port A" & vbCr
        Else
            rtbDebug1.Text &= "Can't initialize port" & vbCr
            ClassA.Close()
            Return
        End If

        rtbDebug1.Text &= "calling FEP on A..." & vbCr
        ' get version number
        ClassA.serialWrite("@VER")
        Dim rsp As String
        rsp = ClassA.serialRead()
        rtbDebug1.Text &= "I received: " & rsp & vbCr
        If rsp = "1.001" Then
            rtbDebug1.Text &= "passed the test!" & vbCr
            ' Get Serial number
            ClassA.serialWrite("@TID")
            rsp = ClassA.serialRead()
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

    End Sub

    Public Sub scanClassB()
        If ClassB.isOpen = True Then
            ClassB.Close()
        End If
        If cbPortsB.Text = "" Then
            MsgBox("No B port selected")
            Return
        End If
        If cbBaudB.Text = "" Then
            MsgBox("No B baud rate selected")
            Return
        End If

        ClassB.portName = cbPortsB.Text
        ClassB.baudRate = cbBaudB.Text
        ClassB.Open(cbPortsB.Text, cbBaudB.Text)
        If ClassB.isOpen = True Then
            rtbDebug2.Text &= "Initialized device on port B" & vbCr
        Else
            rtbDebug2.Text &= "Can't initialize port" & vbCr
            ClassB.Close()
            Return
        End If

        rtbDebug2.Text &= "calling FEP on B..." & vbCr
        ' get version number
        ClassB.serialWrite("@VER")
        Dim rsp As String
        rsp = ClassB.serialRead()
        rtbDebug2.Text &= "I received: " & rsp & vbCr
        If rsp = "1.001" Then
            rtbDebug2.Text &= "passed the test!" & vbCr
            ' Get Serial number
            ClassB.serialWrite("@TID")
            rsp = ClassB.serialRead()
            rtbDebug2.Text &= "I received: " & rsp & vbCr
            tbBSN.Text = rsp
        Else
            rtbDebug2.Text &= "sorry something is wrong" & vbCr
            ClassB.Close()
            Return
        End If
        BreadParameters()

    End Sub

    Private Sub btnScanFEP2_Click(sender As Object, e As EventArgs) Handles btnScanFEP2.Click
        scanClassB()

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
        tbAAddr.Text = ClassA.address
        tbACounterAddr.Text = ClassA.counterpart
        tbAScramble1.Text = ClassA.scramble1
        tbAScramble2.Text = ClassA.scramble2
        tbAChannel1.Text = ClassA.channel1
        ' set diversity combo box
        If ClassA.diversity = "00" Then
            cbADiversity.SelectedIndex = 2
        ElseIf ClassA.diversity = "01" Then
            cbADiversity.SelectedIndex = 1
        End If
        ' other stuff?
    End Sub

    Private Sub BreadParameters()      ' gotta tweak all these for the B set!!!!!!
        ClassB.readAll()
        ' Debug printing
        rtbDebug2.Text &= "Address = " & ClassB.address & vbCr
        rtbDebug2.Text &= "group = " & ClassB.group & vbCr
        rtbDebug2.Text &= "counterpart = " & ClassB.counterpart & vbCr
        rtbDebug2.Text &= "transmit mode = " & ClassB.txmode & vbCr
        rtbDebug2.Text &= "scramble 1 = " & ClassB.scramble1 & vbCr
        rtbDebug2.Text &= "scramble 2 = " & ClassB.scramble2 & vbCr
        rtbDebug2.Text &= "channel mode = " & ClassB.channelmode & vbCr
        rtbDebug2.Text &= "channel 1 = " & ClassB.channel1 & vbCr
        rtbDebug2.Text &= "channel 2 = " & ClassB.channel2 & vbCr
        rtbDebug2.Text &= "channel 3 = " & ClassB.channel3 & vbCr
        rtbDebug2.Text &= "diversity = " & ClassB.diversity & vbCr
        rtbDebug2.Text &= "retransmit count = " & ClassB.retransmit & vbCr
        rtbDebug2.Text &= "roaming thresh = " & ClassB.roamingthresh & vbCr
        rtbDebug2.Text &= "packet response = " & ClassB.packetresponse & vbCr
        rtbDebug2.Text &= "unused = " & ClassB.unused & vbCr
        rtbDebug2.Text &= "cmd interval = " & ClassB.cmdinterval & vbCr
        rtbDebug2.Text &= "band switching = " & ClassB.bandswitching & vbCr
        rtbDebug2.Text &= "bufferClrTime = " & ClassB.buffertime & vbCr
        rtbDebug2.Text &= "address check = " & ClassB.addresscheck & vbCr
        rtbDebug2.Text &= "beacon proc = " & ClassB.beaconmode & vbCr
        rtbDebug2.Text &= "uart = " & ClassB.uart & vbCr
        rtbDebug2.Text &= "powerMode = " & ClassB.powermode & vbCr
        rtbDebug2.Text &= "standby = " & ClassB.standby & vbCr
        rtbDebug2.Text &= "CrLf = " & ClassB.crlf & vbCr
        rtbDebug2.Text &= "txModeDelimiter = " & ClassB.txmodedelimiter & vbCr
        rtbDebug2.Text &= "sleepTime = " & ClassB.sleeptime & vbCr
        rtbDebug2.Text &= "dataTimeout = " & ClassB.datatimeout & vbCr
        rtbDebug2.Text &= "repeaterAddr1 = " & ClassB.repeateraddr1 & vbCr
        rtbDebug2.Text &= "repeaterAddr2 = " & ClassB.repeateraddr2 & vbCr

        'Set text boxes
        tbBAddr.Text = ClassB.address
        tbBCounterAddr.Text = ClassB.counterpart
        tbBScramble1.Text = ClassB.scramble1
        tbBScramble2.Text = ClassB.scramble2
        tbBChannel1.Text = ClassB.channel1
        ' set diversity combo box
        If ClassB.diversity = "00" Then
            cbBDiversity.SelectedIndex = 2
        ElseIf ClassB.diversity = "01" Then
            cbBDiversity.SelectedIndex = 1
        End If
        ' other stuff?
    End Sub

    Private Sub btnAtoB_Click(sender As Object, e As EventArgs) Handles btnAtoB.Click
        ' do a write check to handle unwritten edits to the source module first!!

        'copy variables from source module
        ClassB.address = ClassA.counterpart
        ClassB.group = ClassA.group
        ClassB.counterpart = ClassA.address
        ClassB.txmode = ClassA.txmode
        ClassB.scramble1 = ClassA.scramble1
        ClassB.scramble2 = ClassA.scramble2
        ClassB.channelmode = ClassA.channelmode
        ClassB.channel1 = ClassA.channel1
        ClassB.channel2 = ClassA.channel2
        ClassB.channel3 = ClassA.channel3
        ClassB.diversity = ClassA.diversity
        ClassB.retransmit = ClassA.retransmit
        ClassB.roamingthresh = ClassA.roamingthresh
        ClassB.packetresponse = ClassA.packetresponse
        ClassB.unused = ClassA.unused
        ClassB.cmdinterval = ClassA.cmdinterval
        ClassB.bandswitching = ClassA.bandswitching
        ClassB.buffertime = ClassA.buffertime
        ClassB.addresscheck = ClassA.addresscheck
        ClassB.beaconmode = ClassA.beaconmode
        ClassB.uart = ClassA.uart
        ClassB.powermode = ClassA.powermode
        ClassB.standby = ClassA.standby
        ClassB.crlf = ClassA.crlf
        ClassB.txmodedelimiter = ClassA.txmodedelimiter
        ClassB.sleeptime = ClassA.sleeptime
        ClassB.datatimeout = ClassA.datatimeout
        ClassB.repeateraddr1 = ClassA.repeateraddr1
        ClassB.repeateraddr2 = ClassA.repeateraddr2

        'Set text boxes
        tbBAddr.Text = ClassB.address
        tbBCounterAddr.Text = ClassB.counterpart
        tbBScramble1.Text = ClassB.scramble1
        tbBScramble2.Text = ClassB.scramble2
        tbBChannel1.Text = ClassB.channel1
        ' set diversity combo box
        If ClassB.diversity = "00" Then
            cbBDiversity.SelectedIndex = 2
        ElseIf ClassB.diversity = "01" Then
            cbBDiversity.SelectedIndex = 1
        End If
        ' other stuff?
    End Sub

    Private Sub btnBtoA_Click(sender As Object, e As EventArgs) Handles btnBtoA.Click
        ' do a write check to handle unwritten edits to the source module first!!

        'copy variables from source module
        ClassA.address = ClassB.counterpart
        ClassA.group = ClassB.group
        ClassA.counterpart = ClassB.address
        ClassA.txmode = ClassB.txmode
        ClassA.scramble1 = ClassB.scramble1
        ClassA.scramble2 = ClassB.scramble2
        ClassA.channelmode = ClassB.channelmode
        ClassA.channel1 = ClassB.channel1
        ClassA.channel2 = ClassB.channel2
        ClassA.channel3 = ClassB.channel3
        ClassA.diversity = ClassB.diversity
        ClassA.retransmit = ClassB.retransmit
        ClassA.roamingthresh = ClassB.roamingthresh
        ClassA.packetresponse = ClassB.packetresponse
        ClassA.unused = ClassB.unused
        ClassA.cmdinterval = ClassB.cmdinterval
        ClassA.bandswitching = ClassB.bandswitching
        ClassA.buffertime = ClassB.buffertime
        ClassA.addresscheck = ClassB.addresscheck
        ClassA.beaconmode = ClassB.beaconmode
        ClassA.uart = ClassB.uart
        ClassA.powermode = ClassB.powermode
        ClassA.standby = ClassB.standby
        ClassA.crlf = ClassB.crlf
        ClassA.txmodedelimiter = ClassB.txmodedelimiter
        ClassA.sleeptime = ClassA.sleeptime
        ClassA.datatimeout = ClassB.datatimeout
        ClassA.repeateraddr1 = ClassB.repeateraddr1
        ClassA.repeateraddr2 = ClassB.repeateraddr2

        'Set text boxes
        tbAAddr.Text = ClassA.address
        tbACounterAddr.Text = ClassA.counterpart
        tbAScramble1.Text = ClassA.scramble1
        tbAScramble2.Text = ClassA.scramble2
        tbAChannel1.Text = ClassA.channel1
        ' set diversity combo box
        If ClassA.diversity = "00" Then
            cbADiversity.SelectedIndex = 2
        ElseIf ClassA.diversity = "01" Then
            cbADiversity.SelectedIndex = 1
        End If
        ' other stuff?
    End Sub

    Private Sub btnAWrite_Click(sender As Object, e As EventArgs) Handles btnAWrite.Click
        ' assign the entry fields to the class variables
        ClassA.address = tbAAddr.Text
        ClassA.counterpart = tbACounterAddr.Text
        ClassA.scramble1 = tbAScramble1.Text
        ClassA.scramble2 = tbAScramble2.Text
        ClassA.channel1 = tbAChannel1.Text
        If cbADiversity.SelectedIndex = 0 Then
            MsgBox("No diversity mode selected on A")
            Return
        ElseIf cbADiversity.SelectedIndex = 1 Then
            ClassA.diversity = "01"
        ElseIf cbADiversity.SelectedIndex = 2 Then
            ClassA.diversity = "00"
        End If
        ' assign other defaults to class variables

        ' issue write all command
        If ClassA.isOpen = False Then
            ClassA.Open(cbPortsA.Text, cbBaudA.Text)

        End If
        ClassA.writeAll()
        MsgBox("Write opperations on A complete")

    End Sub

    Private Sub btnBWrite_Click(sender As Object, e As EventArgs) Handles btnBWrite.Click
        ' assign the entry fields to the class variables
        ClassB.address = tbBAddr.Text
        ClassB.counterpart = tbBCounterAddr.Text
        ClassB.scramble1 = tbBScramble1.Text
        ClassB.scramble2 = tbBScramble2.Text
        ClassB.channel1 = tbBChannel1.Text
        If cbBDiversity.SelectedIndex = 0 Then
            MsgBox("No diversity mode selected on B")
            Return
        ElseIf cbBDiversity.SelectedIndex = 1 Then
            ClassB.diversity = "01"
        ElseIf cbBDiversity.SelectedIndex = 2 Then
            ClassB.diversity = "00"
        End If
        ' assign other defaults to class variables

        ' issue write all command
        If ClassB.isOpen = False Then
            ClassB.Open(cbPortsB.Text, cbBaudB.Text)

        End If
        ClassB.writeAll()
        MsgBox("Write opperations on B complete")
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

        If ClassB.isOpen = True Then
            tempPort = cbPortsB.SelectedIndex
            result = ClassB.reset()
            If result = 1 Then
                cbPortsB.SelectedIndex = tempPort
                cbBaudB.SelectedIndex = 1
                scanClassB()
            Else
                MsgBox("Something failed on B")
            End If
        Else
            MsgBox("Module B is not connected?")
        End If
    End Sub

End Class
