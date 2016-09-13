' how to do this is here:  https://msdn.microsoft.com/en-us/library/xtka85tz.aspx

Imports System
Imports System.IO.Ports
Imports System.Threading

Public Class clsFEP
    Shared _continue As Boolean
    Shared _serialPort As SerialPort

    ' Serial port settings
    Private state As Boolean
    Private port As String
    Private baud As String
    'serial port chat
    Public message As String

    ' FEP module registers
    Public group As String
    Public txmode As String
    Public channelmode As String
    Public channel2 As String
    Public channel3 As String
    Public retransmit As String
    Public roamingthresh As String
    Public packetresponse As String
    Public unused As String
    Public cmdinterval As String
    Public bandswitching As String
    Public buffertime As String
    Public addresscheck As String
    Public beaconmode As String
    Public uart As String
    Public powermode As String
    Public standby As String
    Public crlf As String
    Public txmodedelimiter As String
    Public sleeptime As String
    Public datatimeout As String
    Public repeateraddr1 As String
    Public repeateraddr2 As String

    Public moduleSN As String
    Public ourSN As String
    Public diversity As String
    Public name As String
    Public role As String
    Public address As String
    Public counterpart As String
    Public scramble1 As String
    Public scramble2 As String
    Public channel1 As String



    ' Every class needs a "new" where we define how to create it's objects
    Public Sub New()

        _serialPort = New SerialPort()
        ' Allow the user to set the appropriate properties.
        _serialPort.PortName = SetPortName(_serialPort.PortName)
        _serialPort.BaudRate = SetPortBaudRate(_serialPort.BaudRate)
        _serialPort.Parity = SetPortParity(_serialPort.Parity)
        _serialPort.DataBits = SetPortDataBits(_serialPort.DataBits)
        _serialPort.StopBits = SetPortStopBits(_serialPort.StopBits)
        _serialPort.Handshake = SetPortHandshake(_serialPort.Handshake)

        ' Set the read/write timeouts
        _serialPort.ReadTimeout = 500
        _serialPort.WriteTimeout = 500

    End Sub

    ' Properties allow external code to read, write and perform operators on our fields efficiently
    Public Property ACSLnumber() As String
        Get
            ' Gets the property value. 
            Return ourSN
        End Get
        Set(ByVal Value As String)
            ' Sets the property value.
            ourSN = Value
        End Set
    End Property

    Public Property portName() As String
        Get
            ' Gets the property value.
            ' Return port
            Return _serialPort.PortName
        End Get

        Set(ByVal Value As String)
            ' Sets the property value.
            'port = Value
            If Value = "" Then
                MsgBox("No port to set!!")
                Return
            End If
            _serialPort.PortName = Value
        End Set
    End Property

    Public Property baudRate() As String
        Get
            Return _serialPort.BaudRate
        End Get

        Set(ByVal Value As String)
            If Value = "" Then
                MsgBox("No baud rate to set!!")
                Return
            End If
            _serialPort.BaudRate = Value
        End Set
    End Property

    Public Property isOpen()
        Get
            Return _serialPort.IsOpen
        End Get
        Set(value)

        End Set
    End Property


    Public Sub Open(ByVal port As String, ByVal baud As String)
        If _serialPort.IsOpen = True Then
            _serialPort.Close()
        End If
        If port = "" Then
            MsgBox("No port selected!!")
            Return
        End If
        If baud = "" Then
            MsgBox("No baud rate selected!!")
            Return
        End If
        _serialPort.PortName = port
        _serialPort.BaudRate = baud
        _serialPort.Open()
        state = True
    End Sub

    Public Sub Close()
        _serialPort.Close()
        state = False
    End Sub


    Public Property serialRead()

        Get
            Try
                message = _serialPort.ReadTo(vbCrLf)
            Catch ex As TimeoutException
                MsgBox("I got no response")
            End Try
            Return message
        End Get
        Set(value)
        End Set
    End Property
    

    Public Sub serialWrite(ByVal msg As String)
        If msg = "" Then
            MsgBox("You sent nothing!")
            Return
        End If
        _serialPort.Write(msg & vbCr & vbLf)
    End Sub

    Public Property Ver()
        Get
            If state = True Then
                _serialPort.Write("@VER" & vbCr & vbLf)
                Try
                    message = _serialPort.ReadTo(vbCrLf)
                Catch ex As TimeoutException
                    MsgBox("No response!")
                    Return 0
                End Try
                If message = "NO" Then
                    MsgBox("FEP got mad!")
                    Return 0
                End If
                Return message
            End If
            Return 0
        End Get
        Set(value)
        End Set
    End Property

    Public Property TID()
        Get
            If state = True Then
                _serialPort.Write("@TID" & vbCr & vbLf)
                Try
                    message = _serialPort.ReadTo(vbCrLf)
                Catch ex As TimeoutException
                    MsgBox("No response!")
                    Return 0
                End Try
                If message = "NO" Then
                    MsgBox("FEP got mad!")
                    Return 0
                End If
                Return message
            End If
            Return 0
        End Get
        Set(value)
        End Set
    End Property


    Public Sub readAll()
        ' Send the @ARG command, parse line by line
        _serialPort.Write("@ARG" & vbCr & vbLf)
        For regiCount As Integer = 0 To 28
            Try
                message = _serialPort.ReadTo(vbCrLf)
            Catch ex As TimeoutException
                MsgBox("No response!")
                Return
            End Try
            If message = "NO" Then
                MsgBox("FEP got mad!")
                Return
            End If
            Select Case regiCount
                Case 0
                    address = Mid(message, 7, 2)
                Case 1
                    group = Mid(message, 7, 2)
                Case 2
                    counterpart = Mid(message, 7, 2)
                Case 3
                    txmode = Mid(message, 7, 2)
                Case 4
                    scramble1 = Mid(message, 7, 2)
                Case 5
                    scramble2 = Mid(message, 7, 2)
                Case 6
                    channelmode = Mid(message, 7, 2)
                Case 7
                    channel1 = Mid(message, 7, 2)
                Case 8
                    channel2 = Mid(message, 7, 2)
                Case 9
                    channel3 = Mid(message, 7, 2)
                Case 10
                    diversity = Mid(message, 7, 2)
                Case 11
                    retransmit = Mid(message, 7, 2)
                Case 12
                    roamingthresh = Mid(message, 7, 2)
                Case 13
                    packetresponse = Mid(message, 7, 2)
                Case 14
                    unused = Mid(message, 7, 2)
                Case 15
                    cmdinterval = Mid(message, 7, 2)
                Case 16
                    bandswitching = Mid(message, 7, 2)
                Case 17
                    buffertime = Mid(message, 7, 2)
                Case 18
                    addresscheck = Mid(message, 7, 2)
                Case 19
                    beaconmode = Mid(message, 7, 2)
                Case 20
                    uart = Mid(message, 7, 2)
                Case 21
                    powermode = Mid(message, 7, 2)
                Case 22
                    standby = Mid(message, 7, 2)
                Case 23
                    crlf = Mid(message, 7, 2)
                Case 24
                    txmodedelimiter = Mid(message, 7, 2)
                Case 25
                    sleeptime = Mid(message, 7, 2)
                Case 26
                    datatimeout = Mid(message, 7, 2)
                Case 27
                    repeateraddr1 = Mid(message, 7, 2)
                Case 28
                    repeateraddr2 = Mid(message, 7, 2)
            End Select
        Next

    End Sub



    Public Sub writeAll()

        regWrite("00", address)
        regWrite("01", group)
        regWrite("02", counterpart)
        regWrite("03", txmode)
        regWrite("04", scramble1)
        regWrite("05", scramble2)
        regWrite("06", channelmode)
        regWrite("07", channel1)
        regWrite("08", channel2)
        regWrite("09", channel3)
        regWrite("10", diversity)
        regWrite("11", retransmit)
        regWrite("12", roamingthresh)
        regWrite("13", packetresponse)
        regWrite("14", unused)
        regWrite("15", cmdinterval)
        regWrite("16", bandswitching)
        regWrite("17", buffertime)
        regWrite("18", addresscheck)
        regWrite("19", beaconmode)
        regWrite("20", uart)
        regWrite("21", powermode)
        regWrite("22", standby)
        regWrite("23", crlf)
        regWrite("24", txmodedelimiter)
        regWrite("25", sleeptime)
        regWrite("26", datatimeout)
        regWrite("27", repeateraddr1)
        regWrite("28", repeateraddr2)
    End Sub

    Public Property reset()
        Get
            Try
                _serialPort.Write("@RST" & vbCr & vbLf)
            Catch ex As TimeoutException
                Return 0
            End Try
            Return 1
        End Get
        Set(value)
        End Set
    End Property


    Public Sub regWrite(ByVal reg As String, ByVal val As String)
        'Write out the register
        Try
            _serialPort.Write("@REG" & reg & ":" & val & "H" & vbCr & vbLf)
        Catch ex As TimeoutException
            MsgBox("Could not write to module. WTF?!?")
        End Try

        ' read back response
        Try
            message = _serialPort.ReadTo(vbCrLf)
        Catch ex As TimeoutException
            MsgBox("No response!")
            Return
        End Try
        If message = "N0" Then
            MsgBox("Write FAIL: " & "@REG" & reg & ":" & val & "H")
            Return
        ElseIf message = "P0" Then
            Return
        End If
    End Sub


    '****************************************************************************************
    ' These functions are the example code from the MSN reference library
    ' I am not using any of these functions, but there exist here for completeness and reference
    '****************************************************************************************

    Public Shared Function SetPortName(ByVal defaultPortName As String) As String
        Dim newPortName As String
        newPortName = defaultPortName

        If newPortName = "" Then
            '    newPortName = defaultPortName
            ' Complain
        End If
        Return newPortName
    End Function

    Public Shared Function SetPortBaudRate(ByVal defaultPortBaudRate As Integer) As Integer
        Dim newBaudRate As String

        Console.Write("Baud Rate({0}): ", defaultPortBaudRate)
        newBaudRate = Console.ReadLine()

        If newBaudRate = "" Then
            newBaudRate = defaultPortBaudRate.ToString()
        End If

        Return Integer.Parse(newBaudRate)
    End Function

    Public Shared Function SetPortParity(ByVal defaultPortParity As Parity) As Parity
        Dim newParity As String

        Console.WriteLine("Available Parity options:")
        Dim s As String
        For Each s In [Enum].GetNames(GetType(Parity))
            Console.WriteLine("   {0}", s)
        Next s

        Console.Write("Parity({0}):", defaultPortParity.ToString())
        newParity = Console.ReadLine()

        If newParity = "" Then
            newParity = defaultPortParity.ToString()
        End If

        Return CType([Enum].Parse(GetType(Parity), newParity), Parity)
    End Function

    Public Shared Function SetPortDataBits(ByVal defaultPortDataBits As Integer) As Integer
        Dim newDataBits As String

        Console.Write("Data Bits({0}): ", defaultPortDataBits)
        newDataBits = Console.ReadLine()

        If newDataBits = "" Then
            newDataBits = defaultPortDataBits.ToString()
        End If

        Return Integer.Parse(newDataBits)
    End Function

    Public Shared Function SetPortStopBits(ByVal defaultPortStopBits As StopBits) As StopBits
        Dim newStopBits As String

        Console.WriteLine("Available Stop Bits options:")
        Dim s As String
        For Each s In [Enum].GetNames(GetType(StopBits))
            Console.WriteLine("   {0}", s)
        Next s

        Console.Write("Stop Bits({0}):", defaultPortStopBits.ToString())
        newStopBits = Console.ReadLine()

        If newStopBits = "" Then
            newStopBits = defaultPortStopBits.ToString()
        End If

        Return CType([Enum].Parse(GetType(StopBits), newStopBits), StopBits)
    End Function

    Public Shared Function SetPortHandshake(ByVal defaultPortHandshake As Handshake) As Handshake
        Dim newHandshake As String

        Console.WriteLine("Available Handshake options:")
        Dim s As String
        For Each s In [Enum].GetNames(GetType(Handshake))
            Console.WriteLine("   {0}", s)
        Next s

        Console.Write("Handshake({0}):", defaultPortHandshake.ToString())
        newHandshake = Console.ReadLine()

        If newHandshake = "" Then
            newHandshake = defaultPortHandshake.ToString()
        End If

        Return CType([Enum].Parse(GetType(Handshake), newHandshake), Handshake)
    End Function
    ' End of serial port functions!


End Class
