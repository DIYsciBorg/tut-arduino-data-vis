<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.SerialPort2 = New System.IO.Ports.SerialPort(Me.components)
        Me.tbAddr = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbCounterpart = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbScramble1 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbChannel1 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbScramble2 = New System.Windows.Forms.TextBox()
        Me.rtbDebug1 = New System.Windows.Forms.RichTextBox()
        Me.cbBaudA = New System.Windows.Forms.ComboBox()
        Me.cbPortsA = New System.Windows.Forms.ComboBox()
        Me.btnScanFEP1 = New System.Windows.Forms.Button()
        Me.btnScanPorts = New System.Windows.Forms.Button()
        Me.tbASN = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnAWrite = New System.Windows.Forms.Button()
        Me.cbDiversity = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbRoaming = New System.Windows.Forms.ComboBox()
        Me.cbAddress = New System.Windows.Forms.ComboBox()
        Me.cbCounter = New System.Windows.Forms.ComboBox()
        Me.cbScramble1 = New System.Windows.Forms.ComboBox()
        Me.cbScramble2 = New System.Windows.Forms.ComboBox()
        Me.cbChannel1 = New System.Windows.Forms.ComboBox()
        Me.cbChannel2 = New System.Windows.Forms.ComboBox()
        Me.cbLPS = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbGroup = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbChannel2 = New System.Windows.Forms.TextBox()
        Me.cbTXMode = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbFreqGroup = New System.Windows.Forms.ComboBox()
        Me.cbChannel3 = New System.Windows.Forms.ComboBox()
        Me.cbRetrans = New System.Windows.Forms.ComboBox()
        Me.tbGroup = New System.Windows.Forms.TextBox()
        Me.tbFreqGroup = New System.Windows.Forms.TextBox()
        Me.tbChannel3 = New System.Windows.Forms.TextBox()
        Me.tbTXMode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbRetrans = New System.Windows.Forms.TextBox()
        Me.tbRoaming = New System.Windows.Forms.TextBox()
        Me.tbResponse = New System.Windows.Forms.TextBox()
        Me.cbResponse = New System.Windows.Forms.ComboBox()
        Me.cbRepeat2 = New System.Windows.Forms.ComboBox()
        Me.tbRepeat2 = New System.Windows.Forms.TextBox()
        Me.tbRepeat1 = New System.Windows.Forms.TextBox()
        Me.tbDITO = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbAddressCheck = New System.Windows.Forms.TextBox()
        Me.tbLPS = New System.Windows.Forms.TextBox()
        Me.tbTxDelim = New System.Windows.Forms.TextBox()
        Me.tbLPSU = New System.Windows.Forms.TextBox()
        Me.tbBand = New System.Windows.Forms.TextBox()
        Me.cbDITO = New System.Windows.Forms.ComboBox()
        Me.cbTxDelim = New System.Windows.Forms.ComboBox()
        Me.cbLPSU = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbAddressCheck = New System.Windows.Forms.ComboBox()
        Me.tbCrLf = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cbBand = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cbCrLf = New System.Windows.Forms.ComboBox()
        Me.cbLPSB = New System.Windows.Forms.ComboBox()
        Me.cbUART = New System.Windows.Forms.ComboBox()
        Me.cbBeacon = New System.Windows.Forms.ComboBox()
        Me.cbBuffer = New System.Windows.Forms.ComboBox()
        Me.cbCmdInt = New System.Windows.Forms.ComboBox()
        Me.cbRepeat1 = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tbLPSB = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tbUART = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.tbBeacon = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.tbBuffer = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.tbCmdInt = New System.Windows.Forms.TextBox()
        Me.tbReg14 = New System.Windows.Forms.TextBox()
        Me.cbReg14 = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.tbDiversity = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        '
        'tbAddr
        '
        Me.tbAddr.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAddr.Location = New System.Drawing.Point(361, 41)
        Me.tbAddr.Name = "tbAddr"
        Me.tbAddr.ReadOnly = True
        Me.tbAddr.Size = New System.Drawing.Size(36, 26)
        Me.tbAddr.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(306, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 12)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Address"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(288, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 12)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Counterpart"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbCounterpart
        '
        Me.tbCounterpart.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCounterpart.Location = New System.Drawing.Point(361, 105)
        Me.tbCounterpart.Name = "tbCounterpart"
        Me.tbCounterpart.ReadOnly = True
        Me.tbCounterpart.Size = New System.Drawing.Size(36, 26)
        Me.tbCounterpart.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(291, 176)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 12)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Scramble 1"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbScramble1
        '
        Me.tbScramble1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbScramble1.Location = New System.Drawing.Point(361, 169)
        Me.tbScramble1.Name = "tbScramble1"
        Me.tbScramble1.ReadOnly = True
        Me.tbScramble1.Size = New System.Drawing.Size(36, 26)
        Me.tbScramble1.TabIndex = 21
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(297, 276)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 12)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Channel 1"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbChannel1
        '
        Me.tbChannel1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbChannel1.Location = New System.Drawing.Point(361, 269)
        Me.tbChannel1.Name = "tbChannel1"
        Me.tbChannel1.ReadOnly = True
        Me.tbChannel1.Size = New System.Drawing.Size(36, 26)
        Me.tbChannel1.TabIndex = 27
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(291, 208)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 12)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Scramble 2"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbScramble2
        '
        Me.tbScramble2.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbScramble2.Location = New System.Drawing.Point(361, 199)
        Me.tbScramble2.Name = "tbScramble2"
        Me.tbScramble2.ReadOnly = True
        Me.tbScramble2.Size = New System.Drawing.Size(36, 26)
        Me.tbScramble2.TabIndex = 24
        '
        'rtbDebug1
        '
        Me.rtbDebug1.Location = New System.Drawing.Point(38, 174)
        Me.rtbDebug1.Name = "rtbDebug1"
        Me.rtbDebug1.Size = New System.Drawing.Size(191, 365)
        Me.rtbDebug1.TabIndex = 40
        Me.rtbDebug1.Text = ""
        '
        'cbBaudA
        '
        Me.cbBaudA.FormattingEnabled = True
        Me.cbBaudA.Items.AddRange(New Object() {"9600", "115200"})
        Me.cbBaudA.Location = New System.Drawing.Point(108, 61)
        Me.cbBaudA.Name = "cbBaudA"
        Me.cbBaudA.Size = New System.Drawing.Size(121, 20)
        Me.cbBaudA.TabIndex = 3
        '
        'cbPortsA
        '
        Me.cbPortsA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPortsA.FormattingEnabled = True
        Me.cbPortsA.Location = New System.Drawing.Point(108, 35)
        Me.cbPortsA.Name = "cbPortsA"
        Me.cbPortsA.Size = New System.Drawing.Size(121, 20)
        Me.cbPortsA.TabIndex = 2
        '
        'btnScanFEP1
        '
        Me.btnScanFEP1.Location = New System.Drawing.Point(119, 89)
        Me.btnScanFEP1.Name = "btnScanFEP1"
        Me.btnScanFEP1.Size = New System.Drawing.Size(110, 36)
        Me.btnScanFEP1.TabIndex = 4
        Me.btnScanFEP1.Text = "Scan for FEP 1"
        Me.btnScanFEP1.UseVisualStyleBackColor = True
        '
        'btnScanPorts
        '
        Me.btnScanPorts.Location = New System.Drawing.Point(12, 35)
        Me.btnScanPorts.Name = "btnScanPorts"
        Me.btnScanPorts.Size = New System.Drawing.Size(82, 39)
        Me.btnScanPorts.TabIndex = 1
        Me.btnScanPorts.Text = "Scan Ports"
        Me.btnScanPorts.UseVisualStyleBackColor = True
        '
        'tbASN
        '
        Me.tbASN.Location = New System.Drawing.Point(129, 140)
        Me.tbASN.Name = "tbASN"
        Me.tbASN.ReadOnly = True
        Me.tbASN.Size = New System.Drawing.Size(100, 19)
        Me.tbASN.TabIndex = 54
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(63, 143)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(51, 12)
        Me.Label15.TabIndex = 56
        Me.Label15.Text = "FEP S/N"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(562, 549)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(95, 28)
        Me.btnReset.TabIndex = 35
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnAWrite
        '
        Me.btnAWrite.Location = New System.Drawing.Point(434, 549)
        Me.btnAWrite.Name = "btnAWrite"
        Me.btnAWrite.Size = New System.Drawing.Size(102, 36)
        Me.btnAWrite.TabIndex = 34
        Me.btnAWrite.Text = "Write"
        Me.btnAWrite.UseVisualStyleBackColor = True
        '
        'cbDiversity
        '
        Me.cbDiversity.FormattingEnabled = True
        Me.cbDiversity.Items.AddRange(New Object() {"(unset)", "1 Antenna", "2 Antennas"})
        Me.cbDiversity.Location = New System.Drawing.Point(405, 372)
        Me.cbDiversity.Name = "cbDiversity"
        Me.cbDiversity.Size = New System.Drawing.Size(74, 20)
        Me.cbDiversity.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(302, 375)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 12)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "Diversity"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbRoaming
        '
        Me.cbRoaming.Enabled = False
        Me.cbRoaming.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRoaming.FormattingEnabled = True
        Me.cbRoaming.Items.AddRange(New Object() {"50"})
        Me.cbRoaming.Location = New System.Drawing.Point(403, 432)
        Me.cbRoaming.Name = "cbRoaming"
        Me.cbRoaming.Size = New System.Drawing.Size(42, 26)
        Me.cbRoaming.TabIndex = 17
        '
        'cbAddress
        '
        Me.cbAddress.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAddress.FormattingEnabled = True
        Me.cbAddress.Items.AddRange(New Object() {"00", "01", "02", "03", "03", "04", "05", "06", "07", "08", "09", "0A", "0B", "0C", "0D", "0E", "0F", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "1A", "1B", "1C", "1D", "1E", "1F", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "2A", "2B", "2C", "2D", "2E", "2F", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "3A", "3B", "3C", "3D", "3E", "3F", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "4A", "4B", "4C", "4D", "4E", "4F", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "5A", "5B", "5C", "5D", "5E", "5F", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "6A", "6B", "6C", "6D", "6E", "6F", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "7A", "7B", "7C", "7D", "7E", "7F", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "8A", "8B", "8C", "8D", "8E", "8F", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "9A", "9B", "9C", "9D", "9E", "9F", "A0", "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "AA", "AB", "AC", "AD", "AE", "AF", "B0", "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9", "BA", "BB", "BC", "BD", "BE", "BF", "C0", "C1", "C2", "C3", "C4", "C5", "C6", "C7", "C8", "C9", "CA", "CB", "CC", "CD", "CE", "CF", "D0", "D1", "D2", "D3", "D4", "D5", "D6", "D7", "D8", "D9", "DA", "DB", "DC", "DD", "DE", "DF", "E0", "E1", "E2", "E3", "E4", "E5", "E6", "E7", "E8", "E9", "EA", "EB", "EC", "ED", "EE", "EF"})
        Me.cbAddress.Location = New System.Drawing.Point(403, 41)
        Me.cbAddress.Name = "cbAddress"
        Me.cbAddress.Size = New System.Drawing.Size(42, 26)
        Me.cbAddress.TabIndex = 5
        '
        'cbCounter
        '
        Me.cbCounter.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCounter.FormattingEnabled = True
        Me.cbCounter.Items.AddRange(New Object() {"00", "01", "02", "03", "03", "04", "05", "06", "07", "08", "09", "0A", "0B", "0C", "0D", "0E", "0F", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "1A", "1B", "1C", "1D", "1E", "1F", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "2A", "2B", "2C", "2D", "2E", "2F", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "3A", "3B", "3C", "3D", "3E", "3F", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "4A", "4B", "4C", "4D", "4E", "4F", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "5A", "5B", "5C", "5D", "5E", "5F", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "6A", "6B", "6C", "6D", "6E", "6F", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "7A", "7B", "7C", "7D", "7E", "7F", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "8A", "8B", "8C", "8D", "8E", "8F", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "9A", "9B", "9C", "9D", "9E", "9F", "A0", "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "AA", "AB", "AC", "AD", "AE", "AF", "B0", "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9", "BA", "BB", "BC", "BD", "BE", "BF", "C0", "C1", "C2", "C3", "C4", "C5", "C6", "C7", "C8", "C9", "CA", "CB", "CC", "CD", "CE", "CF", "D0", "D1", "D2", "D3", "D4", "D5", "D6", "D7", "D8", "D9", "DA", "DB", "DC", "DD", "DE", "DF", "E0", "E1", "E2", "E3", "E4", "E5", "E6", "E7", "E8", "E9", "EA", "EB", "EC", "ED", "EE", "EF"})
        Me.cbCounter.Location = New System.Drawing.Point(403, 105)
        Me.cbCounter.Name = "cbCounter"
        Me.cbCounter.Size = New System.Drawing.Size(42, 26)
        Me.cbCounter.TabIndex = 7
        '
        'cbScramble1
        '
        Me.cbScramble1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbScramble1.FormattingEnabled = True
        Me.cbScramble1.Items.AddRange(New Object() {"00", "01", "02", "03", "03", "04", "05", "06", "07", "08", "09", "0A", "0B", "0C", "0D", "0E", "0F", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "1A", "1B", "1C", "1D", "1E", "1F", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "2A", "2B", "2C", "2D", "2E", "2F", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "3A", "3B", "3C", "3D", "3E", "3F", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "4A", "4B", "4C", "4D", "4E", "4F", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "5A", "5B", "5C", "5D", "5E", "5F", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "6A", "6B", "6C", "6D", "6E", "6F", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "7A", "7B", "7C", "7D", "7E", "7F", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "8A", "8B", "8C", "8D", "8E", "8F", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "9A", "9B", "9C", "9D", "9E", "9F", "A0", "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "AA", "AB", "AC", "AD", "AE", "AF", "B0", "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9", "BA", "BB", "BC", "BD", "BE", "BF", "C0", "C1", "C2", "C3", "C4", "C5", "C6", "C7", "C8", "C9", "CA", "CB", "CC", "CD", "CE", "CF", "D0", "D1", "D2", "D3", "D4", "D5", "D6", "D7", "D8", "D9", "DA", "DB", "DC", "DD", "DE", "DF", "E0", "E1", "E2", "E3", "E4", "E5", "E6", "E7", "E8", "E9", "EA", "EB", "EC", "ED", "EE", "EF", "F0", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "FA", "FB", "FC", "FD", "FE", "FF"})
        Me.cbScramble1.Location = New System.Drawing.Point(403, 169)
        Me.cbScramble1.Name = "cbScramble1"
        Me.cbScramble1.Size = New System.Drawing.Size(42, 26)
        Me.cbScramble1.TabIndex = 9
        '
        'cbScramble2
        '
        Me.cbScramble2.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbScramble2.FormattingEnabled = True
        Me.cbScramble2.Items.AddRange(New Object() {"00", "01", "02", "03", "03", "04", "05", "06", "07", "08", "09", "0A", "0B", "0C", "0D", "0E", "0F", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "1A", "1B", "1C", "1D", "1E", "1F", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "2A", "2B", "2C", "2D", "2E", "2F", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "3A", "3B", "3C", "3D", "3E", "3F", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "4A", "4B", "4C", "4D", "4E", "4F", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "5A", "5B", "5C", "5D", "5E", "5F", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "6A", "6B", "6C", "6D", "6E", "6F", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "7A", "7B", "7C", "7D", "7E", "7F", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "8A", "8B", "8C", "8D", "8E", "8F", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "9A", "9B", "9C", "9D", "9E", "9F", "A0", "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "AA", "AB", "AC", "AD", "AE", "AF", "B0", "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9", "BA", "BB", "BC", "BD", "BE", "BF", "C0", "C1", "C2", "C3", "C4", "C5", "C6", "C7", "C8", "C9", "CA", "CB", "CC", "CD", "CE", "CF", "D0", "D1", "D2", "D3", "D4", "D5", "D6", "D7", "D8", "D9", "DA", "DB", "DC", "DD", "DE", "DF", "E0", "E1", "E2", "E3", "E4", "E5", "E6", "E7", "E8", "E9", "EA", "EB", "EC", "ED", "EE", "EF", "F0", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "FA", "FB", "FC", "FD", "FE", "FF"})
        Me.cbScramble2.Location = New System.Drawing.Point(403, 201)
        Me.cbScramble2.Name = "cbScramble2"
        Me.cbScramble2.Size = New System.Drawing.Size(42, 26)
        Me.cbScramble2.TabIndex = 10
        '
        'cbChannel1
        '
        Me.cbChannel1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbChannel1.FormattingEnabled = True
        Me.cbChannel1.Items.AddRange(New Object() {"18", "19", "1A", "1B", "1C", "1D", "1E", "1F", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "2A", "2B", "2C", "2D", "2E", "2F", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "3A", "3B", "3C"})
        Me.cbChannel1.Location = New System.Drawing.Point(403, 269)
        Me.cbChannel1.Name = "cbChannel1"
        Me.cbChannel1.Size = New System.Drawing.Size(42, 26)
        Me.cbChannel1.TabIndex = 12
        '
        'cbChannel2
        '
        Me.cbChannel2.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbChannel2.FormattingEnabled = True
        Me.cbChannel2.Items.AddRange(New Object() {"18", "19", "1A", "1B", "1C", "1D", "1E", "1F", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "2A", "2B", "2C", "2D", "2E", "2F", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "3A", "3B", "3C"})
        Me.cbChannel2.Location = New System.Drawing.Point(403, 304)
        Me.cbChannel2.Name = "cbChannel2"
        Me.cbChannel2.Size = New System.Drawing.Size(42, 26)
        Me.cbChannel2.TabIndex = 13
        '
        'cbLPS
        '
        Me.cbLPS.Enabled = False
        Me.cbLPS.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLPS.FormattingEnabled = True
        Me.cbLPS.Items.AddRange(New Object() {"0F"})
        Me.cbLPS.Location = New System.Drawing.Point(646, 368)
        Me.cbLPS.Name = "cbLPS"
        Me.cbLPS.Size = New System.Drawing.Size(42, 26)
        Me.cbLPS.TabIndex = 30
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(297, 311)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 12)
        Me.Label9.TabIndex = 90
        Me.Label9.Text = "Channel 2"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbGroup
        '
        Me.cbGroup.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGroup.FormattingEnabled = True
        Me.cbGroup.Items.AddRange(New Object() {"F0", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "FA", "FB", "FC", "FD", "FE"})
        Me.cbGroup.Location = New System.Drawing.Point(403, 73)
        Me.cbGroup.Name = "cbGroup"
        Me.cbGroup.Size = New System.Drawing.Size(42, 26)
        Me.cbGroup.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(309, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 12)
        Me.Label1.TabIndex = 93
        Me.Label1.Text = "GROUP"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbChannel2
        '
        Me.tbChannel2.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbChannel2.Location = New System.Drawing.Point(361, 304)
        Me.tbChannel2.Name = "tbChannel2"
        Me.tbChannel2.ReadOnly = True
        Me.tbChannel2.Size = New System.Drawing.Size(36, 26)
        Me.tbChannel2.TabIndex = 94
        '
        'cbTXMode
        '
        Me.cbTXMode.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTXMode.FormattingEnabled = True
        Me.cbTXMode.Items.AddRange(New Object() {"F0", "FF"})
        Me.cbTXMode.Location = New System.Drawing.Point(403, 137)
        Me.cbTXMode.Name = "cbTXMode"
        Me.cbTXMode.Size = New System.Drawing.Size(42, 26)
        Me.cbTXMode.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(304, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 12)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "Tx Mode"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbFreqGroup
        '
        Me.cbFreqGroup.Enabled = False
        Me.cbFreqGroup.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFreqGroup.FormattingEnabled = True
        Me.cbFreqGroup.Items.AddRange(New Object() {"01"})
        Me.cbFreqGroup.Location = New System.Drawing.Point(403, 233)
        Me.cbFreqGroup.Name = "cbFreqGroup"
        Me.cbFreqGroup.Size = New System.Drawing.Size(42, 26)
        Me.cbFreqGroup.TabIndex = 11
        '
        'cbChannel3
        '
        Me.cbChannel3.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbChannel3.FormattingEnabled = True
        Me.cbChannel3.Items.AddRange(New Object() {"18", "19", "1A", "1B", "1C", "1D", "1E", "1F", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "2A", "2B", "2C", "2D", "2E", "2F", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "3A", "3B", "3C"})
        Me.cbChannel3.Location = New System.Drawing.Point(403, 336)
        Me.cbChannel3.Name = "cbChannel3"
        Me.cbChannel3.Size = New System.Drawing.Size(42, 26)
        Me.cbChannel3.TabIndex = 14
        '
        'cbRetrans
        '
        Me.cbRetrans.Enabled = False
        Me.cbRetrans.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRetrans.FormattingEnabled = True
        Me.cbRetrans.Items.AddRange(New Object() {"00"})
        Me.cbRetrans.Location = New System.Drawing.Point(403, 400)
        Me.cbRetrans.Name = "cbRetrans"
        Me.cbRetrans.Size = New System.Drawing.Size(42, 26)
        Me.cbRetrans.TabIndex = 16
        '
        'tbGroup
        '
        Me.tbGroup.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbGroup.Location = New System.Drawing.Point(361, 73)
        Me.tbGroup.Name = "tbGroup"
        Me.tbGroup.ReadOnly = True
        Me.tbGroup.Size = New System.Drawing.Size(36, 26)
        Me.tbGroup.TabIndex = 100
        '
        'tbFreqGroup
        '
        Me.tbFreqGroup.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFreqGroup.Location = New System.Drawing.Point(361, 233)
        Me.tbFreqGroup.Name = "tbFreqGroup"
        Me.tbFreqGroup.ReadOnly = True
        Me.tbFreqGroup.Size = New System.Drawing.Size(36, 26)
        Me.tbFreqGroup.TabIndex = 101
        '
        'tbChannel3
        '
        Me.tbChannel3.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbChannel3.Location = New System.Drawing.Point(361, 336)
        Me.tbChannel3.Name = "tbChannel3"
        Me.tbChannel3.ReadOnly = True
        Me.tbChannel3.Size = New System.Drawing.Size(36, 26)
        Me.tbChannel3.TabIndex = 102
        '
        'tbTXMode
        '
        Me.tbTXMode.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTXMode.Location = New System.Drawing.Point(361, 137)
        Me.tbTXMode.Name = "tbTXMode"
        Me.tbTXMode.ReadOnly = True
        Me.tbTXMode.Size = New System.Drawing.Size(36, 26)
        Me.tbTXMode.TabIndex = 104
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(261, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 12)
        Me.Label3.TabIndex = 105
        Me.Label3.Text = "Frequency Group"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(297, 343)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 12)
        Me.Label4.TabIndex = 106
        Me.Label4.Text = "Channel 3"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbRetrans
        '
        Me.tbRetrans.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRetrans.Location = New System.Drawing.Point(361, 400)
        Me.tbRetrans.Name = "tbRetrans"
        Me.tbRetrans.ReadOnly = True
        Me.tbRetrans.Size = New System.Drawing.Size(36, 26)
        Me.tbRetrans.TabIndex = 107
        '
        'tbRoaming
        '
        Me.tbRoaming.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRoaming.Location = New System.Drawing.Point(361, 432)
        Me.tbRoaming.Name = "tbRoaming"
        Me.tbRoaming.ReadOnly = True
        Me.tbRoaming.Size = New System.Drawing.Size(36, 26)
        Me.tbRoaming.TabIndex = 108
        '
        'tbResponse
        '
        Me.tbResponse.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbResponse.Location = New System.Drawing.Point(361, 466)
        Me.tbResponse.Name = "tbResponse"
        Me.tbResponse.ReadOnly = True
        Me.tbResponse.Size = New System.Drawing.Size(36, 26)
        Me.tbResponse.TabIndex = 109
        '
        'cbResponse
        '
        Me.cbResponse.Enabled = False
        Me.cbResponse.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbResponse.FormattingEnabled = True
        Me.cbResponse.Items.AddRange(New Object() {"81"})
        Me.cbResponse.Location = New System.Drawing.Point(403, 466)
        Me.cbResponse.Name = "cbResponse"
        Me.cbResponse.Size = New System.Drawing.Size(42, 26)
        Me.cbResponse.TabIndex = 18
        '
        'cbRepeat2
        '
        Me.cbRepeat2.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRepeat2.FormattingEnabled = True
        Me.cbRepeat2.Items.AddRange(New Object() {"FF"})
        Me.cbRepeat2.Location = New System.Drawing.Point(646, 466)
        Me.cbRepeat2.Name = "cbRepeat2"
        Me.cbRepeat2.Size = New System.Drawing.Size(42, 26)
        Me.cbRepeat2.TabIndex = 33
        '
        'tbRepeat2
        '
        Me.tbRepeat2.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRepeat2.Location = New System.Drawing.Point(604, 464)
        Me.tbRepeat2.Name = "tbRepeat2"
        Me.tbRepeat2.ReadOnly = True
        Me.tbRepeat2.Size = New System.Drawing.Size(36, 26)
        Me.tbRepeat2.TabIndex = 148
        '
        'tbRepeat1
        '
        Me.tbRepeat1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRepeat1.Location = New System.Drawing.Point(604, 432)
        Me.tbRepeat1.Name = "tbRepeat1"
        Me.tbRepeat1.ReadOnly = True
        Me.tbRepeat1.Size = New System.Drawing.Size(36, 26)
        Me.tbRepeat1.TabIndex = 147
        '
        'tbDITO
        '
        Me.tbDITO.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDITO.Location = New System.Drawing.Point(604, 400)
        Me.tbDITO.Name = "tbDITO"
        Me.tbDITO.ReadOnly = True
        Me.tbDITO.Size = New System.Drawing.Size(36, 26)
        Me.tbDITO.TabIndex = 146
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(530, 343)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 12)
        Me.Label10.TabIndex = 145
        Me.Label10.Text = "Tx Delimiter"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(517, 240)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 12)
        Me.Label11.TabIndex = 144
        Me.Label11.Text = "Low pwr setup"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbAddressCheck
        '
        Me.tbAddressCheck.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAddressCheck.Location = New System.Drawing.Point(604, 137)
        Me.tbAddressCheck.Name = "tbAddressCheck"
        Me.tbAddressCheck.ReadOnly = True
        Me.tbAddressCheck.Size = New System.Drawing.Size(36, 26)
        Me.tbAddressCheck.TabIndex = 143
        '
        'tbLPS
        '
        Me.tbLPS.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLPS.Location = New System.Drawing.Point(604, 368)
        Me.tbLPS.Name = "tbLPS"
        Me.tbLPS.ReadOnly = True
        Me.tbLPS.Size = New System.Drawing.Size(36, 26)
        Me.tbLPS.TabIndex = 142
        '
        'tbTxDelim
        '
        Me.tbTxDelim.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTxDelim.Location = New System.Drawing.Point(604, 336)
        Me.tbTxDelim.Name = "tbTxDelim"
        Me.tbTxDelim.ReadOnly = True
        Me.tbTxDelim.Size = New System.Drawing.Size(36, 26)
        Me.tbTxDelim.TabIndex = 141
        '
        'tbLPSU
        '
        Me.tbLPSU.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLPSU.Location = New System.Drawing.Point(604, 233)
        Me.tbLPSU.Name = "tbLPSU"
        Me.tbLPSU.ReadOnly = True
        Me.tbLPSU.Size = New System.Drawing.Size(36, 26)
        Me.tbLPSU.TabIndex = 140
        '
        'tbBand
        '
        Me.tbBand.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbBand.Location = New System.Drawing.Point(604, 73)
        Me.tbBand.Name = "tbBand"
        Me.tbBand.ReadOnly = True
        Me.tbBand.Size = New System.Drawing.Size(36, 26)
        Me.tbBand.TabIndex = 139
        '
        'cbDITO
        '
        Me.cbDITO.Enabled = False
        Me.cbDITO.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDITO.FormattingEnabled = True
        Me.cbDITO.Items.AddRange(New Object() {"01"})
        Me.cbDITO.Location = New System.Drawing.Point(646, 400)
        Me.cbDITO.Name = "cbDITO"
        Me.cbDITO.Size = New System.Drawing.Size(42, 26)
        Me.cbDITO.TabIndex = 31
        '
        'cbTxDelim
        '
        Me.cbTxDelim.Enabled = False
        Me.cbTxDelim.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTxDelim.FormattingEnabled = True
        Me.cbTxDelim.Items.AddRange(New Object() {"C1"})
        Me.cbTxDelim.Location = New System.Drawing.Point(646, 336)
        Me.cbTxDelim.Name = "cbTxDelim"
        Me.cbTxDelim.Size = New System.Drawing.Size(42, 26)
        Me.cbTxDelim.TabIndex = 29
        '
        'cbLPSU
        '
        Me.cbLPSU.Enabled = False
        Me.cbLPSU.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLPSU.FormattingEnabled = True
        Me.cbLPSU.Items.AddRange(New Object() {"09"})
        Me.cbLPSU.Location = New System.Drawing.Point(646, 233)
        Me.cbLPSU.Name = "cbLPSU"
        Me.cbLPSU.Size = New System.Drawing.Size(42, 26)
        Me.cbLPSU.TabIndex = 26
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(513, 142)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 12)
        Me.Label14.TabIndex = 135
        Me.Label14.Text = "Address Check"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbAddressCheck
        '
        Me.cbAddressCheck.Enabled = False
        Me.cbAddressCheck.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAddressCheck.FormattingEnabled = True
        Me.cbAddressCheck.Items.AddRange(New Object() {"8D"})
        Me.cbAddressCheck.Location = New System.Drawing.Point(646, 137)
        Me.cbAddressCheck.Name = "cbAddressCheck"
        Me.cbAddressCheck.Size = New System.Drawing.Size(42, 26)
        Me.cbAddressCheck.TabIndex = 23
        '
        'tbCrLf
        '
        Me.tbCrLf.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCrLf.Location = New System.Drawing.Point(604, 304)
        Me.tbCrLf.Name = "tbCrLf"
        Me.tbCrLf.ReadOnly = True
        Me.tbCrLf.Size = New System.Drawing.Size(36, 26)
        Me.tbCrLf.TabIndex = 133
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(527, 80)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 12)
        Me.Label16.TabIndex = 132
        Me.Label16.Text = "Band Switch"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbBand
        '
        Me.cbBand.Enabled = False
        Me.cbBand.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBand.FormattingEnabled = True
        Me.cbBand.Items.AddRange(New Object() {"00"})
        Me.cbBand.Location = New System.Drawing.Point(646, 73)
        Me.cbBand.Name = "cbBand"
        Me.cbBand.Size = New System.Drawing.Size(42, 26)
        Me.cbBand.TabIndex = 21
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(569, 311)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(27, 12)
        Me.Label17.TabIndex = 130
        Me.Label17.Text = "CrLf"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbCrLf
        '
        Me.cbCrLf.Enabled = False
        Me.cbCrLf.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCrLf.FormattingEnabled = True
        Me.cbCrLf.Items.AddRange(New Object() {"10"})
        Me.cbCrLf.Location = New System.Drawing.Point(646, 304)
        Me.cbCrLf.Name = "cbCrLf"
        Me.cbCrLf.Size = New System.Drawing.Size(42, 26)
        Me.cbCrLf.TabIndex = 28
        '
        'cbLPSB
        '
        Me.cbLPSB.Enabled = False
        Me.cbLPSB.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLPSB.FormattingEnabled = True
        Me.cbLPSB.Items.AddRange(New Object() {"0F"})
        Me.cbLPSB.Location = New System.Drawing.Point(646, 269)
        Me.cbLPSB.Name = "cbLPSB"
        Me.cbLPSB.Size = New System.Drawing.Size(42, 26)
        Me.cbLPSB.TabIndex = 27
        '
        'cbUART
        '
        Me.cbUART.Enabled = False
        Me.cbUART.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbUART.FormattingEnabled = True
        Me.cbUART.Items.AddRange(New Object() {"03"})
        Me.cbUART.Location = New System.Drawing.Point(646, 201)
        Me.cbUART.Name = "cbUART"
        Me.cbUART.Size = New System.Drawing.Size(42, 26)
        Me.cbUART.TabIndex = 25
        '
        'cbBeacon
        '
        Me.cbBeacon.Enabled = False
        Me.cbBeacon.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBeacon.FormattingEnabled = True
        Me.cbBeacon.Items.AddRange(New Object() {"00"})
        Me.cbBeacon.Location = New System.Drawing.Point(646, 169)
        Me.cbBeacon.Name = "cbBeacon"
        Me.cbBeacon.Size = New System.Drawing.Size(42, 26)
        Me.cbBeacon.TabIndex = 24
        '
        'cbBuffer
        '
        Me.cbBuffer.Enabled = False
        Me.cbBuffer.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBuffer.FormattingEnabled = True
        Me.cbBuffer.Items.AddRange(New Object() {"64"})
        Me.cbBuffer.Location = New System.Drawing.Point(646, 105)
        Me.cbBuffer.Name = "cbBuffer"
        Me.cbBuffer.Size = New System.Drawing.Size(42, 26)
        Me.cbBuffer.TabIndex = 22
        '
        'cbCmdInt
        '
        Me.cbCmdInt.Enabled = False
        Me.cbCmdInt.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCmdInt.FormattingEnabled = True
        Me.cbCmdInt.Items.AddRange(New Object() {"01"})
        Me.cbCmdInt.Location = New System.Drawing.Point(646, 41)
        Me.cbCmdInt.Name = "cbCmdInt"
        Me.cbCmdInt.Size = New System.Drawing.Size(42, 26)
        Me.cbCmdInt.TabIndex = 20
        '
        'cbRepeat1
        '
        Me.cbRepeat1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRepeat1.FormattingEnabled = True
        Me.cbRepeat1.Items.AddRange(New Object() {"FF"})
        Me.cbRepeat1.Location = New System.Drawing.Point(646, 432)
        Me.cbRepeat1.Name = "cbRepeat1"
        Me.cbRepeat1.Size = New System.Drawing.Size(42, 26)
        Me.cbRepeat1.TabIndex = 32
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(522, 375)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(76, 12)
        Me.Label18.TabIndex = 122
        Me.Label18.Text = "low pwr Sleep"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(504, 276)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(92, 12)
        Me.Label19.TabIndex = 120
        Me.Label19.Text = "Low pwr Standby"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbLPSB
        '
        Me.tbLPSB.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLPSB.Location = New System.Drawing.Point(604, 269)
        Me.tbLPSB.Name = "tbLPSB"
        Me.tbLPSB.ReadOnly = True
        Me.tbLPSB.Size = New System.Drawing.Size(36, 26)
        Me.tbLPSB.TabIndex = 119
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(560, 206)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(36, 12)
        Me.Label20.TabIndex = 118
        Me.Label20.Text = "UART"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbUART
        '
        Me.tbUART.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUART.Location = New System.Drawing.Point(604, 199)
        Me.tbUART.Name = "tbUART"
        Me.tbUART.ReadOnly = True
        Me.tbUART.Size = New System.Drawing.Size(36, 26)
        Me.tbUART.TabIndex = 117
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(553, 177)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(43, 12)
        Me.Label21.TabIndex = 116
        Me.Label21.Text = "Beacon"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbBeacon
        '
        Me.tbBeacon.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbBeacon.Location = New System.Drawing.Point(604, 169)
        Me.tbBeacon.Name = "tbBeacon"
        Me.tbBeacon.ReadOnly = True
        Me.tbBeacon.Size = New System.Drawing.Size(36, 26)
        Me.tbBeacon.TabIndex = 115
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(499, 113)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(97, 12)
        Me.Label22.TabIndex = 114
        Me.Label22.Text = "Buffer Clear Time"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbBuffer
        '
        Me.tbBuffer.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbBuffer.Location = New System.Drawing.Point(604, 105)
        Me.tbBuffer.Name = "tbBuffer"
        Me.tbBuffer.ReadOnly = True
        Me.tbBuffer.Size = New System.Drawing.Size(36, 26)
        Me.tbBuffer.TabIndex = 113
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(499, 48)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(97, 12)
        Me.Label23.TabIndex = 112
        Me.Label23.Text = "Command Interval"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbCmdInt
        '
        Me.tbCmdInt.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCmdInt.Location = New System.Drawing.Point(604, 41)
        Me.tbCmdInt.Name = "tbCmdInt"
        Me.tbCmdInt.ReadOnly = True
        Me.tbCmdInt.Size = New System.Drawing.Size(36, 26)
        Me.tbCmdInt.TabIndex = 111
        '
        'tbReg14
        '
        Me.tbReg14.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbReg14.Location = New System.Drawing.Point(361, 498)
        Me.tbReg14.Name = "tbReg14"
        Me.tbReg14.ReadOnly = True
        Me.tbReg14.Size = New System.Drawing.Size(36, 26)
        Me.tbReg14.TabIndex = 150
        '
        'cbReg14
        '
        Me.cbReg14.Enabled = False
        Me.cbReg14.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbReg14.FormattingEnabled = True
        Me.cbReg14.Items.AddRange(New Object() {"00"})
        Me.cbReg14.Location = New System.Drawing.Point(403, 498)
        Me.cbReg14.Name = "cbReg14"
        Me.cbReg14.Size = New System.Drawing.Size(42, 26)
        Me.cbReg14.TabIndex = 19
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(274, 405)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(79, 12)
        Me.Label24.TabIndex = 152
        Me.Label24.Text = "Retrans Count"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(265, 439)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(88, 12)
        Me.Label25.TabIndex = 153
        Me.Label25.Text = "Roaming Thresh"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(259, 473)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(94, 12)
        Me.Label26.TabIndex = 154
        Me.Label26.Text = "Packet Response"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(264, 505)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(89, 12)
        Me.Label27.TabIndex = 155
        Me.Label27.Text = "Reg 14 (unused)"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(537, 407)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(61, 12)
        Me.Label28.TabIndex = 156
        Me.Label28.Text = "Data in TO"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(535, 439)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(61, 12)
        Me.Label29.TabIndex = 157
        Me.Label29.Text = "Repeater 1"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(535, 471)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(61, 12)
        Me.Label30.TabIndex = 158
        Me.Label30.Text = "Repeater 2"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbDiversity
        '
        Me.tbDiversity.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDiversity.Location = New System.Drawing.Point(361, 368)
        Me.tbDiversity.Name = "tbDiversity"
        Me.tbDiversity.ReadOnly = True
        Me.tbDiversity.Size = New System.Drawing.Size(36, 26)
        Me.tbDiversity.TabIndex = 159
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"00", "01", "02", "03", "03", "04", "05", "06", "07", "08", "09", "0A", "0B", "0C", "0D", "0E", "0F", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "1A", "1B", "1C", "1D", "1E", "1F", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "2A", "2B", "2C", "2D", "2E", "2F", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "3A", "B3", "3C", "3D", "3E", "3F", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "4A", "4B", "4C", "4D", "4E", "4F", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "5A", "5B", "5C", "5D", "5E", "5F", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "6A", "6B", "6C", "6D", "6E", "6F", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "7A", "7B", "7C", "7D", "7E", "7F", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "8A", "8B", "8C", "8D", "8E", "8F", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "9A", "9B", "9C", "9D", "9E", "9F", "A0", "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "AA", "AB", "AC", "AD", "AE", "AF", "B0", "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9", "BA", "BB", "BC", "BD", "BE", "BF", "C0", "C1", "C2", "C3", "C4", "C5", "C6", "C7", "C8", "C9", "CA", "CB", "CC", "CD", "CE", "CF", "D0", "D1", "D2", "D3", "D4", "D5", "D6", "D7", "D8", "D9", "DA", "DB", "DC", "DD", "DE", "DF", "E0", "E1", "E2", "E3", "E4", "E5", "E6", "E7", "E8", "E9", "EA", "EB", "EC", "ED", "EE", "EF", "F0", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "FA", "FB", "FC", "FD", "FE", "FF"})
        Me.ComboBox1.Location = New System.Drawing.Point(261, 554)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(42, 26)
        Me.ComboBox1.TabIndex = 160
        Me.ComboBox1.Visible = False
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(692, 549)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 161
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 592)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.tbDiversity)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.cbReg14)
        Me.Controls.Add(Me.tbReg14)
        Me.Controls.Add(Me.cbRepeat2)
        Me.Controls.Add(Me.tbRepeat2)
        Me.Controls.Add(Me.tbRepeat1)
        Me.Controls.Add(Me.tbDITO)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tbAddressCheck)
        Me.Controls.Add(Me.tbLPS)
        Me.Controls.Add(Me.tbTxDelim)
        Me.Controls.Add(Me.tbLPSU)
        Me.Controls.Add(Me.tbBand)
        Me.Controls.Add(Me.cbDITO)
        Me.Controls.Add(Me.cbTxDelim)
        Me.Controls.Add(Me.cbLPSU)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cbAddressCheck)
        Me.Controls.Add(Me.tbCrLf)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.cbBand)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.cbCrLf)
        Me.Controls.Add(Me.cbLPSB)
        Me.Controls.Add(Me.cbUART)
        Me.Controls.Add(Me.cbBeacon)
        Me.Controls.Add(Me.cbBuffer)
        Me.Controls.Add(Me.cbCmdInt)
        Me.Controls.Add(Me.cbRepeat1)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.tbLPSB)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.tbUART)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.tbBeacon)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.tbBuffer)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.tbCmdInt)
        Me.Controls.Add(Me.cbResponse)
        Me.Controls.Add(Me.tbResponse)
        Me.Controls.Add(Me.tbRoaming)
        Me.Controls.Add(Me.tbRetrans)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbTXMode)
        Me.Controls.Add(Me.tbChannel3)
        Me.Controls.Add(Me.tbFreqGroup)
        Me.Controls.Add(Me.tbGroup)
        Me.Controls.Add(Me.cbRetrans)
        Me.Controls.Add(Me.cbChannel3)
        Me.Controls.Add(Me.cbFreqGroup)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbTXMode)
        Me.Controls.Add(Me.tbChannel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbGroup)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbLPS)
        Me.Controls.Add(Me.cbChannel2)
        Me.Controls.Add(Me.cbChannel1)
        Me.Controls.Add(Me.cbScramble2)
        Me.Controls.Add(Me.cbScramble1)
        Me.Controls.Add(Me.cbCounter)
        Me.Controls.Add(Me.cbAddress)
        Me.Controls.Add(Me.cbRoaming)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbDiversity)
        Me.Controls.Add(Me.btnAWrite)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.tbASN)
        Me.Controls.Add(Me.btnScanPorts)
        Me.Controls.Add(Me.cbBaudA)
        Me.Controls.Add(Me.cbPortsA)
        Me.Controls.Add(Me.btnScanFEP1)
        Me.Controls.Add(Me.rtbDebug1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.tbChannel1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.tbScramble2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbScramble1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbCounterpart)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbAddr)
        Me.Name = "frmMain"
        Me.Text = "FEP Presetter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents SerialPort2 As System.IO.Ports.SerialPort
    Friend WithEvents tbAddr As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbCounterpart As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbScramble1 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tbChannel1 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tbScramble2 As System.Windows.Forms.TextBox
    Friend WithEvents rtbDebug1 As System.Windows.Forms.RichTextBox
    Friend WithEvents cbBaudA As System.Windows.Forms.ComboBox
    Friend WithEvents cbPortsA As System.Windows.Forms.ComboBox
    Friend WithEvents btnScanFEP1 As System.Windows.Forms.Button
    Friend WithEvents btnScanPorts As System.Windows.Forms.Button
    Friend WithEvents tbASN As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnAWrite As System.Windows.Forms.Button
    Friend WithEvents cbDiversity As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbRoaming As System.Windows.Forms.ComboBox
    Friend WithEvents cbAddress As System.Windows.Forms.ComboBox
    Friend WithEvents cbCounter As System.Windows.Forms.ComboBox
    Friend WithEvents cbScramble1 As System.Windows.Forms.ComboBox
    Friend WithEvents cbScramble2 As System.Windows.Forms.ComboBox
    Friend WithEvents cbChannel1 As System.Windows.Forms.ComboBox
    Friend WithEvents cbChannel2 As System.Windows.Forms.ComboBox
    Friend WithEvents cbLPS As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbChannel2 As System.Windows.Forms.TextBox
    Friend WithEvents cbTXMode As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbFreqGroup As System.Windows.Forms.ComboBox
    Friend WithEvents cbChannel3 As System.Windows.Forms.ComboBox
    Friend WithEvents cbRetrans As System.Windows.Forms.ComboBox
    Friend WithEvents tbGroup As System.Windows.Forms.TextBox
    Friend WithEvents tbFreqGroup As System.Windows.Forms.TextBox
    Friend WithEvents tbChannel3 As System.Windows.Forms.TextBox
    Friend WithEvents tbTXMode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbRetrans As System.Windows.Forms.TextBox
    Friend WithEvents tbRoaming As System.Windows.Forms.TextBox
    Friend WithEvents tbResponse As System.Windows.Forms.TextBox
    Friend WithEvents cbResponse As System.Windows.Forms.ComboBox
    Friend WithEvents cbRepeat2 As System.Windows.Forms.ComboBox
    Friend WithEvents tbRepeat2 As System.Windows.Forms.TextBox
    Friend WithEvents tbRepeat1 As System.Windows.Forms.TextBox
    Friend WithEvents tbDITO As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tbAddressCheck As System.Windows.Forms.TextBox
    Friend WithEvents tbLPS As System.Windows.Forms.TextBox
    Friend WithEvents tbTxDelim As System.Windows.Forms.TextBox
    Friend WithEvents tbLPSU As System.Windows.Forms.TextBox
    Friend WithEvents tbBand As System.Windows.Forms.TextBox
    Friend WithEvents cbDITO As System.Windows.Forms.ComboBox
    Friend WithEvents cbTxDelim As System.Windows.Forms.ComboBox
    Friend WithEvents cbLPSU As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cbAddressCheck As System.Windows.Forms.ComboBox
    Friend WithEvents tbCrLf As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cbBand As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cbCrLf As System.Windows.Forms.ComboBox
    Friend WithEvents cbLPSB As System.Windows.Forms.ComboBox
    Friend WithEvents cbUART As System.Windows.Forms.ComboBox
    Friend WithEvents cbBeacon As System.Windows.Forms.ComboBox
    Friend WithEvents cbBuffer As System.Windows.Forms.ComboBox
    Friend WithEvents cbCmdInt As System.Windows.Forms.ComboBox
    Friend WithEvents cbRepeat1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents tbLPSB As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents tbUART As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents tbBeacon As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents tbBuffer As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents tbCmdInt As System.Windows.Forms.TextBox
    Friend WithEvents tbReg14 As System.Windows.Forms.TextBox
    Friend WithEvents cbReg14 As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents tbDiversity As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button

End Class
