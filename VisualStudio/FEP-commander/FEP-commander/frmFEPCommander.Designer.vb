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
        Me.tbAName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbAAddr = New System.Windows.Forms.TextBox()
        Me.tbBAddr = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbBCounterAddr = New System.Windows.Forms.TextBox()
        Me.tbACounterAddr = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbBScramble1 = New System.Windows.Forms.TextBox()
        Me.tbAScramble1 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbBChannel1 = New System.Windows.Forms.TextBox()
        Me.tbAChannel1 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbBScramble2 = New System.Windows.Forms.TextBox()
        Me.tbAScramble2 = New System.Windows.Forms.TextBox()
        Me.btnAtoB = New System.Windows.Forms.Button()
        Me.btnBtoA = New System.Windows.Forms.Button()
        Me.rtbDebug1 = New System.Windows.Forms.RichTextBox()
        Me.cbBaudA = New System.Windows.Forms.ComboBox()
        Me.cbPortsA = New System.Windows.Forms.ComboBox()
        Me.btnScanFEP1 = New System.Windows.Forms.Button()
        Me.cbBaudB = New System.Windows.Forms.ComboBox()
        Me.cbPortsB = New System.Windows.Forms.ComboBox()
        Me.btnScanFEP2 = New System.Windows.Forms.Button()
        Me.btnScanPorts = New System.Windows.Forms.Button()
        Me.rtbDebug2 = New System.Windows.Forms.RichTextBox()
        Me.tbASN = New System.Windows.Forms.TextBox()
        Me.tbBSN = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tbBName = New System.Windows.Forms.TextBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tbBourSN = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.tbAourSN = New System.Windows.Forms.TextBox()
        Me.btnAWrite = New System.Windows.Forms.Button()
        Me.cbARole = New System.Windows.Forms.ComboBox()
        Me.cbADiversity = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbBRole = New System.Windows.Forms.ComboBox()
        Me.cbBDiversity = New System.Windows.Forms.ComboBox()
        Me.btnBWrite = New System.Windows.Forms.Button()
        Me.cbHexClone = New System.Windows.Forms.ComboBox()
        Me.cbAAddress = New System.Windows.Forms.ComboBox()
        Me.cbACounterpart = New System.Windows.Forms.ComboBox()
        Me.cbAScramble1 = New System.Windows.Forms.ComboBox()
        Me.cbAScramble2 = New System.Windows.Forms.ComboBox()
        Me.cbAChannel1 = New System.Windows.Forms.ComboBox()
        Me.cbAChannel2 = New System.Windows.Forms.ComboBox()
        Me.cbAChannel3 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbAGroup = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        '
        'SerialPort2
        '
        '
        'tbAName
        '
        Me.tbAName.Location = New System.Drawing.Point(995, 480)
        Me.tbAName.Name = "tbAName"
        Me.tbAName.Size = New System.Drawing.Size(114, 19)
        Me.tbAName.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1127, 480)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Pair Name"
        '
        'tbAAddr
        '
        Me.tbAAddr.Location = New System.Drawing.Point(581, 147)
        Me.tbAAddr.Name = "tbAAddr"
        Me.tbAAddr.Size = New System.Drawing.Size(56, 19)
        Me.tbAAddr.TabIndex = 4
        '
        'tbBAddr
        '
        Me.tbBAddr.Location = New System.Drawing.Point(659, 146)
        Me.tbBAddr.Name = "tbBAddr"
        Me.tbBAddr.Size = New System.Drawing.Size(56, 19)
        Me.tbBAddr.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(207, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Radio A"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(1007, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Radio B"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(449, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 12)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Address"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(440, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 12)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Counterpart"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbBCounterAddr
        '
        Me.tbBCounterAddr.Location = New System.Drawing.Point(659, 171)
        Me.tbBCounterAddr.Name = "tbBCounterAddr"
        Me.tbBCounterAddr.Size = New System.Drawing.Size(56, 19)
        Me.tbBCounterAddr.TabIndex = 16
        '
        'tbACounterAddr
        '
        Me.tbACounterAddr.Location = New System.Drawing.Point(581, 172)
        Me.tbACounterAddr.Name = "tbACounterAddr"
        Me.tbACounterAddr.Size = New System.Drawing.Size(56, 19)
        Me.tbACounterAddr.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(440, 249)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 12)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Scramble 1"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbBScramble1
        '
        Me.tbBScramble1.Location = New System.Drawing.Point(659, 234)
        Me.tbBScramble1.Name = "tbBScramble1"
        Me.tbBScramble1.Size = New System.Drawing.Size(56, 19)
        Me.tbBScramble1.TabIndex = 22
        '
        'tbAScramble1
        '
        Me.tbAScramble1.Location = New System.Drawing.Point(597, 234)
        Me.tbAScramble1.Name = "tbAScramble1"
        Me.tbAScramble1.Size = New System.Drawing.Size(56, 19)
        Me.tbAScramble1.TabIndex = 21
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(449, 320)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 12)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Channel 1"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbBChannel1
        '
        Me.tbBChannel1.Location = New System.Drawing.Point(659, 284)
        Me.tbBChannel1.Name = "tbBChannel1"
        Me.tbBChannel1.Size = New System.Drawing.Size(56, 19)
        Me.tbBChannel1.TabIndex = 28
        '
        'tbAChannel1
        '
        Me.tbAChannel1.Location = New System.Drawing.Point(597, 284)
        Me.tbAChannel1.Name = "tbAChannel1"
        Me.tbAChannel1.Size = New System.Drawing.Size(56, 19)
        Me.tbAChannel1.TabIndex = 27
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(443, 284)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 12)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Scramble 2"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbBScramble2
        '
        Me.tbBScramble2.Location = New System.Drawing.Point(659, 259)
        Me.tbBScramble2.Name = "tbBScramble2"
        Me.tbBScramble2.Size = New System.Drawing.Size(56, 19)
        Me.tbBScramble2.TabIndex = 25
        '
        'tbAScramble2
        '
        Me.tbAScramble2.Location = New System.Drawing.Point(597, 259)
        Me.tbAScramble2.Name = "tbAScramble2"
        Me.tbAScramble2.Size = New System.Drawing.Size(56, 19)
        Me.tbAScramble2.TabIndex = 24
        '
        'btnAtoB
        '
        Me.btnAtoB.Location = New System.Drawing.Point(354, 468)
        Me.btnAtoB.Name = "btnAtoB"
        Me.btnAtoB.Size = New System.Drawing.Size(109, 24)
        Me.btnAtoB.TabIndex = 37
        Me.btnAtoB.Text = "A --> B"
        Me.btnAtoB.UseVisualStyleBackColor = True
        '
        'btnBtoA
        '
        Me.btnBtoA.Location = New System.Drawing.Point(528, 468)
        Me.btnBtoA.Name = "btnBtoA"
        Me.btnBtoA.Size = New System.Drawing.Size(109, 23)
        Me.btnBtoA.TabIndex = 38
        Me.btnBtoA.Text = "A <-- B"
        Me.btnBtoA.UseVisualStyleBackColor = True
        '
        'rtbDebug1
        '
        Me.rtbDebug1.Location = New System.Drawing.Point(108, 131)
        Me.rtbDebug1.Name = "rtbDebug1"
        Me.rtbDebug1.Size = New System.Drawing.Size(191, 408)
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
        Me.cbBaudA.TabIndex = 44
        '
        'cbPortsA
        '
        Me.cbPortsA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPortsA.FormattingEnabled = True
        Me.cbPortsA.Location = New System.Drawing.Point(108, 35)
        Me.cbPortsA.Name = "cbPortsA"
        Me.cbPortsA.Size = New System.Drawing.Size(121, 20)
        Me.cbPortsA.TabIndex = 43
        '
        'btnScanFEP1
        '
        Me.btnScanFEP1.Location = New System.Drawing.Point(108, 89)
        Me.btnScanFEP1.Name = "btnScanFEP1"
        Me.btnScanFEP1.Size = New System.Drawing.Size(110, 36)
        Me.btnScanFEP1.TabIndex = 42
        Me.btnScanFEP1.Text = "Scan for FEP 1"
        Me.btnScanFEP1.UseVisualStyleBackColor = True
        '
        'cbBaudB
        '
        Me.cbBaudB.FormattingEnabled = True
        Me.cbBaudB.Items.AddRange(New Object() {"9600", "115200"})
        Me.cbBaudB.Location = New System.Drawing.Point(1110, 89)
        Me.cbBaudB.Name = "cbBaudB"
        Me.cbBaudB.Size = New System.Drawing.Size(121, 20)
        Me.cbBaudB.TabIndex = 49
        '
        'cbPortsB
        '
        Me.cbPortsB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPortsB.FormattingEnabled = True
        Me.cbPortsB.Location = New System.Drawing.Point(1110, 63)
        Me.cbPortsB.Name = "cbPortsB"
        Me.cbPortsB.Size = New System.Drawing.Size(121, 20)
        Me.cbPortsB.TabIndex = 48
        '
        'btnScanFEP2
        '
        Me.btnScanFEP2.Location = New System.Drawing.Point(1110, 117)
        Me.btnScanFEP2.Name = "btnScanFEP2"
        Me.btnScanFEP2.Size = New System.Drawing.Size(110, 36)
        Me.btnScanFEP2.TabIndex = 47
        Me.btnScanFEP2.Text = "Scan for FEP 2"
        Me.btnScanFEP2.UseVisualStyleBackColor = True
        '
        'btnScanPorts
        '
        Me.btnScanPorts.Location = New System.Drawing.Point(12, 35)
        Me.btnScanPorts.Name = "btnScanPorts"
        Me.btnScanPorts.Size = New System.Drawing.Size(82, 39)
        Me.btnScanPorts.TabIndex = 50
        Me.btnScanPorts.Text = "Scan Ports"
        Me.btnScanPorts.UseVisualStyleBackColor = True
        '
        'rtbDebug2
        '
        Me.rtbDebug2.Location = New System.Drawing.Point(1110, 159)
        Me.rtbDebug2.Name = "rtbDebug2"
        Me.rtbDebug2.Size = New System.Drawing.Size(191, 247)
        Me.rtbDebug2.TabIndex = 53
        Me.rtbDebug2.Text = ""
        '
        'tbASN
        '
        Me.tbASN.Enabled = False
        Me.tbASN.Location = New System.Drawing.Point(318, 115)
        Me.tbASN.Name = "tbASN"
        Me.tbASN.Size = New System.Drawing.Size(100, 19)
        Me.tbASN.TabIndex = 54
        '
        'tbBSN
        '
        Me.tbBSN.Enabled = False
        Me.tbBSN.Location = New System.Drawing.Point(656, 114)
        Me.tbBSN.Name = "tbBSN"
        Me.tbBSN.Size = New System.Drawing.Size(100, 19)
        Me.tbBSN.TabIndex = 55
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(443, 121)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(51, 12)
        Me.Label15.TabIndex = 56
        Me.Label15.Text = "FEP S/N"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbBName
        '
        Me.tbBName.Location = New System.Drawing.Point(1201, 478)
        Me.tbBName.Name = "tbBName"
        Me.tbBName.Size = New System.Drawing.Size(114, 19)
        Me.tbBName.TabIndex = 58
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(442, 519)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(109, 43)
        Me.btnReset.TabIndex = 62
        Me.btnReset.Text = "Reset Modules"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label19.Location = New System.Drawing.Point(1265, 71)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(36, 33)
        Me.Label19.TabIndex = 68
        Me.Label19.Text = "B"
        '
        'tbBourSN
        '
        Me.tbBourSN.Location = New System.Drawing.Point(1201, 504)
        Me.tbBourSN.Name = "tbBourSN"
        Me.tbBourSN.ReadOnly = True
        Me.tbBourSN.Size = New System.Drawing.Size(114, 19)
        Me.tbBourSN.TabIndex = 71
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(1115, 505)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(59, 12)
        Me.Label21.TabIndex = 70
        Me.Label21.Text = "ACSL S/N"
        '
        'tbAourSN
        '
        Me.tbAourSN.Location = New System.Drawing.Point(995, 501)
        Me.tbAourSN.Name = "tbAourSN"
        Me.tbAourSN.ReadOnly = True
        Me.tbAourSN.Size = New System.Drawing.Size(114, 19)
        Me.tbAourSN.TabIndex = 69
        '
        'btnAWrite
        '
        Me.btnAWrite.Location = New System.Drawing.Point(354, 422)
        Me.btnAWrite.Name = "btnAWrite"
        Me.btnAWrite.Size = New System.Drawing.Size(88, 29)
        Me.btnAWrite.TabIndex = 74
        Me.btnAWrite.Text = "Write A"
        Me.btnAWrite.UseVisualStyleBackColor = True
        '
        'cbARole
        '
        Me.cbARole.FormattingEnabled = True
        Me.cbARole.Items.AddRange(New Object() {"(unset)", "Heli", "Base"})
        Me.cbARole.Location = New System.Drawing.Point(1035, 536)
        Me.cbARole.Name = "cbARole"
        Me.cbARole.Size = New System.Drawing.Size(89, 20)
        Me.cbARole.TabIndex = 75
        '
        'cbADiversity
        '
        Me.cbADiversity.FormattingEnabled = True
        Me.cbADiversity.Items.AddRange(New Object() {"(unset)", "1 Antenna", "2 Antennas"})
        Me.cbADiversity.Location = New System.Drawing.Point(332, 216)
        Me.cbADiversity.Name = "cbADiversity"
        Me.cbADiversity.Size = New System.Drawing.Size(86, 20)
        Me.cbADiversity.TabIndex = 76
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1146, 539)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 12)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "Role"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(446, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 12)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "Diversity"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbBRole
        '
        Me.cbBRole.FormattingEnabled = True
        Me.cbBRole.Items.AddRange(New Object() {"(unset)", "Heli", "Base"})
        Me.cbBRole.Location = New System.Drawing.Point(1201, 531)
        Me.cbBRole.Name = "cbBRole"
        Me.cbBRole.Size = New System.Drawing.Size(89, 20)
        Me.cbBRole.TabIndex = 79
        '
        'cbBDiversity
        '
        Me.cbBDiversity.FormattingEnabled = True
        Me.cbBDiversity.Items.AddRange(New Object() {"(unset)", "1 Antenna", "2 Antennas"})
        Me.cbBDiversity.Location = New System.Drawing.Point(662, 207)
        Me.cbBDiversity.Name = "cbBDiversity"
        Me.cbBDiversity.Size = New System.Drawing.Size(86, 20)
        Me.cbBDiversity.TabIndex = 80
        '
        'btnBWrite
        '
        Me.btnBWrite.Location = New System.Drawing.Point(549, 421)
        Me.btnBWrite.Name = "btnBWrite"
        Me.btnBWrite.Size = New System.Drawing.Size(88, 29)
        Me.btnBWrite.TabIndex = 81
        Me.btnBWrite.Text = "Write B"
        Me.btnBWrite.UseVisualStyleBackColor = True
        '
        'cbHexClone
        '
        Me.cbHexClone.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbHexClone.FormattingEnabled = True
        Me.cbHexClone.Items.AddRange(New Object() {"00", "01", "02", "03", "03", "04", "05", "06", "07", "08", "09", "0A", "0B", "0C", "0D", "0E", "0F", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "1A", "1B", "1C", "1D", "1E", "1F", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "2A", "2B", "2C", "2D", "2E", "2F", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "3A", "B3", "3C", "3D", "3E", "3F", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "4A", "4B", "4C", "4D", "4E", "4F", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "5A", "5B", "5C", "5D", "5E", "5F", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "6A", "6B", "6C", "6D", "6E", "6F", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "7A", "7B", "7C", "7D", "7E", "7F", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "8A", "8B", "8C", "8D", "8E", "8F", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "9A", "9B", "9C", "9D", "9E", "9F", "A0", "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "AA", "AB", "AC", "AD", "AE", "AF", "B0", "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9", "BA", "BB", "BC", "BD", "BE", "BF", "C0", "C1", "C2", "C3", "C4", "C5", "C6", "C7", "C8", "C9", "CA", "CB", "CC", "CD", "CE", "CF", "D0", "D1", "D2", "D3", "D4", "D5", "D6", "D7", "D8", "D9", "DA", "DB", "DC", "DD", "DE", "DF", "E0", "E1", "E2", "E3", "E4", "E5", "E6", "E7", "E8", "E9", "EA", "EB", "EC", "ED", "EE", "EF", "F0", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "FA", "FB", "FC", "FD", "FE", "FF"})
        Me.cbHexClone.Location = New System.Drawing.Point(819, 530)
        Me.cbHexClone.Name = "cbHexClone"
        Me.cbHexClone.Size = New System.Drawing.Size(42, 26)
        Me.cbHexClone.TabIndex = 82
        '
        'cbAAddress
        '
        Me.cbAAddress.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAAddress.FormattingEnabled = True
        Me.cbAAddress.Items.AddRange(New Object() {"00", "01", "02", "03", "03", "04", "05", "06", "07", "08", "09", "0A", "0B", "0C", "0D", "0E", "0F", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "1A", "1B", "1C", "1D", "1E", "1F", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "2A", "2B", "2C", "2D", "2E", "2F", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "3A", "B3", "3C", "3D", "3E", "3F", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "4A", "4B", "4C", "4D", "4E", "4F", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "5A", "5B", "5C", "5D", "5E", "5F", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "6A", "6B", "6C", "6D", "6E", "6F", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "7A", "7B", "7C", "7D", "7E", "7F", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "8A", "8B", "8C", "8D", "8E", "8F", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "9A", "9B", "9C", "9D", "9E", "9F", "A0", "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "AA", "AB", "AC", "AD", "AE", "AF", "B0", "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9", "BA", "BB", "BC", "BD", "BE", "BF", "C0", "C1", "C2", "C3", "C4", "C5", "C6", "C7", "C8", "C9", "CA", "CB", "CC", "CD", "CE", "CF", "D0", "D1", "D2", "D3", "D4", "D5", "D6", "D7", "D8", "D9", "DA", "DB", "DC", "DD", "DE", "DF", "E0", "E1", "E2", "E3", "E4", "E5", "E6", "E7", "E8", "E9", "EA", "EB", "EC", "ED", "EE", "EF"})
        Me.cbAAddress.Location = New System.Drawing.Point(376, 143)
        Me.cbAAddress.Name = "cbAAddress"
        Me.cbAAddress.Size = New System.Drawing.Size(42, 26)
        Me.cbAAddress.TabIndex = 83
        '
        'cbACounterpart
        '
        Me.cbACounterpart.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbACounterpart.FormattingEnabled = True
        Me.cbACounterpart.Items.AddRange(New Object() {"00", "01", "02", "03", "03", "04", "05", "06", "07", "08", "09", "0A", "0B", "0C", "0D", "0E", "0F", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "1A", "1B", "1C", "1D", "1E", "1F", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "2A", "2B", "2C", "2D", "2E", "2F", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "3A", "B3", "3C", "3D", "3E", "3F", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "4A", "4B", "4C", "4D", "4E", "4F", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "5A", "5B", "5C", "5D", "5E", "5F", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "6A", "6B", "6C", "6D", "6E", "6F", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "7A", "7B", "7C", "7D", "7E", "7F", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "8A", "8B", "8C", "8D", "8E", "8F", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "9A", "9B", "9C", "9D", "9E", "9F", "A0", "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "AA", "AB", "AC", "AD", "AE", "AF", "B0", "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9", "BA", "BB", "BC", "BD", "BE", "BF", "C0", "C1", "C2", "C3", "C4", "C5", "C6", "C7", "C8", "C9", "CA", "CB", "CC", "CD", "CE", "CF", "D0", "D1", "D2", "D3", "D4", "D5", "D6", "D7", "D8", "D9", "DA", "DB", "DC", "DD", "DE", "DF", "E0", "E1", "E2", "E3", "E4", "E5", "E6", "E7", "E8", "E9", "EA", "EB", "EC", "ED", "EE", "EF"})
        Me.cbACounterpart.Location = New System.Drawing.Point(376, 175)
        Me.cbACounterpart.Name = "cbACounterpart"
        Me.cbACounterpart.Size = New System.Drawing.Size(42, 26)
        Me.cbACounterpart.TabIndex = 84
        '
        'cbAScramble1
        '
        Me.cbAScramble1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAScramble1.FormattingEnabled = True
        Me.cbAScramble1.Items.AddRange(New Object() {"00", "01", "02", "03", "03", "04", "05", "06", "07", "08", "09", "0A", "0B", "0C", "0D", "0E", "0F", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "1A", "1B", "1C", "1D", "1E", "1F", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "2A", "2B", "2C", "2D", "2E", "2F", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "3A", "B3", "3C", "3D", "3E", "3F", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "4A", "4B", "4C", "4D", "4E", "4F", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "5A", "5B", "5C", "5D", "5E", "5F", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "6A", "6B", "6C", "6D", "6E", "6F", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "7A", "7B", "7C", "7D", "7E", "7F", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "8A", "8B", "8C", "8D", "8E", "8F", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "9A", "9B", "9C", "9D", "9E", "9F", "A0", "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "AA", "AB", "AC", "AD", "AE", "AF", "B0", "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9", "BA", "BB", "BC", "BD", "BE", "BF", "C0", "C1", "C2", "C3", "C4", "C5", "C6", "C7", "C8", "C9", "CA", "CB", "CC", "CD", "CE", "CF", "D0", "D1", "D2", "D3", "D4", "D5", "D6", "D7", "D8", "D9", "DA", "DB", "DC", "DD", "DE", "DF", "E0", "E1", "E2", "E3", "E4", "E5", "E6", "E7", "E8", "E9", "EA", "EB", "EC", "ED", "EE", "EF", "F0", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "FA", "FB", "FC", "FD", "FE", "FF"})
        Me.cbAScramble1.Location = New System.Drawing.Point(376, 242)
        Me.cbAScramble1.Name = "cbAScramble1"
        Me.cbAScramble1.Size = New System.Drawing.Size(42, 26)
        Me.cbAScramble1.TabIndex = 85
        '
        'cbAScramble2
        '
        Me.cbAScramble2.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAScramble2.FormattingEnabled = True
        Me.cbAScramble2.Items.AddRange(New Object() {"00", "01", "02", "03", "03", "04", "05", "06", "07", "08", "09", "0A", "0B", "0C", "0D", "0E", "0F", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "1A", "1B", "1C", "1D", "1E", "1F", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "2A", "2B", "2C", "2D", "2E", "2F", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "3A", "B3", "3C", "3D", "3E", "3F", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "4A", "4B", "4C", "4D", "4E", "4F", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "5A", "5B", "5C", "5D", "5E", "5F", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "6A", "6B", "6C", "6D", "6E", "6F", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "7A", "7B", "7C", "7D", "7E", "7F", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "8A", "8B", "8C", "8D", "8E", "8F", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "9A", "9B", "9C", "9D", "9E", "9F", "A0", "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "AA", "AB", "AC", "AD", "AE", "AF", "B0", "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9", "BA", "BB", "BC", "BD", "BE", "BF", "C0", "C1", "C2", "C3", "C4", "C5", "C6", "C7", "C8", "C9", "CA", "CB", "CC", "CD", "CE", "CF", "D0", "D1", "D2", "D3", "D4", "D5", "D6", "D7", "D8", "D9", "DA", "DB", "DC", "DD", "DE", "DF", "E0", "E1", "E2", "E3", "E4", "E5", "E6", "E7", "E8", "E9", "EA", "EB", "EC", "ED", "EE", "EF", "F0", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "FA", "FB", "FC", "FD", "FE", "FF"})
        Me.cbAScramble2.Location = New System.Drawing.Point(376, 277)
        Me.cbAScramble2.Name = "cbAScramble2"
        Me.cbAScramble2.Size = New System.Drawing.Size(42, 26)
        Me.cbAScramble2.TabIndex = 86
        '
        'cbAChannel1
        '
        Me.cbAChannel1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAChannel1.FormattingEnabled = True
        Me.cbAChannel1.Items.AddRange(New Object() {"18", "19", "1A", "1B", "1C", "1D", "1E", "1F", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "2A", "2B", "2C", "2D", "2E", "2F", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "3A", "B3", "3C"})
        Me.cbAChannel1.Location = New System.Drawing.Point(376, 313)
        Me.cbAChannel1.Name = "cbAChannel1"
        Me.cbAChannel1.Size = New System.Drawing.Size(42, 26)
        Me.cbAChannel1.TabIndex = 87
        '
        'cbAChannel2
        '
        Me.cbAChannel2.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAChannel2.FormattingEnabled = True
        Me.cbAChannel2.Items.AddRange(New Object() {"18", "19", "1A", "1B", "1C", "1D", "1E", "1F", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "2A", "2B", "2C", "2D", "2E", "2F", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "3A", "B3", "3C"})
        Me.cbAChannel2.Location = New System.Drawing.Point(376, 345)
        Me.cbAChannel2.Name = "cbAChannel2"
        Me.cbAChannel2.Size = New System.Drawing.Size(42, 26)
        Me.cbAChannel2.TabIndex = 88
        '
        'cbAChannel3
        '
        Me.cbAChannel3.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAChannel3.FormattingEnabled = True
        Me.cbAChannel3.Items.AddRange(New Object() {"18", "19", "1A", "1B", "1C", "1D", "1E", "1F", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "2A", "2B", "2C", "2D", "2E", "2F", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "3A", "B3", "3C"})
        Me.cbAChannel3.Location = New System.Drawing.Point(376, 377)
        Me.cbAChannel3.Name = "cbAChannel3"
        Me.cbAChannel3.Size = New System.Drawing.Size(42, 26)
        Me.cbAChannel3.TabIndex = 89
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(449, 352)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 12)
        Me.Label9.TabIndex = 90
        Me.Label9.Text = "Channel 1"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(449, 384)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 12)
        Me.Label10.TabIndex = 91
        Me.Label10.Text = "Channel 1"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbAGroup
        '
        Me.cbAGroup.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAGroup.FormattingEnabled = True
        Me.cbAGroup.Items.AddRange(New Object() {"F0", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "FA", "FB", "FC", "FD", "FE"})
        Me.cbAGroup.Location = New System.Drawing.Point(318, 159)
        Me.cbAGroup.Name = "cbAGroup"
        Me.cbAGroup.Size = New System.Drawing.Size(42, 26)
        Me.cbAGroup.TabIndex = 92
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1342, 592)
        Me.Controls.Add(Me.cbAGroup)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbAChannel3)
        Me.Controls.Add(Me.cbAChannel2)
        Me.Controls.Add(Me.cbAChannel1)
        Me.Controls.Add(Me.cbAScramble2)
        Me.Controls.Add(Me.cbAScramble1)
        Me.Controls.Add(Me.cbACounterpart)
        Me.Controls.Add(Me.cbAAddress)
        Me.Controls.Add(Me.cbHexClone)
        Me.Controls.Add(Me.btnBWrite)
        Me.Controls.Add(Me.cbBDiversity)
        Me.Controls.Add(Me.cbBRole)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbADiversity)
        Me.Controls.Add(Me.cbARole)
        Me.Controls.Add(Me.btnAWrite)
        Me.Controls.Add(Me.tbBourSN)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.tbAourSN)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.tbBName)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.tbBSN)
        Me.Controls.Add(Me.tbASN)
        Me.Controls.Add(Me.rtbDebug2)
        Me.Controls.Add(Me.btnScanPorts)
        Me.Controls.Add(Me.cbBaudB)
        Me.Controls.Add(Me.cbPortsB)
        Me.Controls.Add(Me.btnScanFEP2)
        Me.Controls.Add(Me.cbBaudA)
        Me.Controls.Add(Me.cbPortsA)
        Me.Controls.Add(Me.btnScanFEP1)
        Me.Controls.Add(Me.rtbDebug1)
        Me.Controls.Add(Me.btnBtoA)
        Me.Controls.Add(Me.btnAtoB)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.tbBChannel1)
        Me.Controls.Add(Me.tbAChannel1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.tbBScramble2)
        Me.Controls.Add(Me.tbAScramble2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbBScramble1)
        Me.Controls.Add(Me.tbAScramble1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbBCounterAddr)
        Me.Controls.Add(Me.tbACounterAddr)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbBAddr)
        Me.Controls.Add(Me.tbAAddr)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbAName)
        Me.Name = "frmMain"
        Me.Text = "FEP Commander"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents SerialPort2 As System.IO.Ports.SerialPort
    Friend WithEvents tbAName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbAAddr As System.Windows.Forms.TextBox
    Friend WithEvents tbBAddr As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbBCounterAddr As System.Windows.Forms.TextBox
    Friend WithEvents tbACounterAddr As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbBScramble1 As System.Windows.Forms.TextBox
    Friend WithEvents tbAScramble1 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tbBChannel1 As System.Windows.Forms.TextBox
    Friend WithEvents tbAChannel1 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tbBScramble2 As System.Windows.Forms.TextBox
    Friend WithEvents tbAScramble2 As System.Windows.Forms.TextBox
    Friend WithEvents btnAtoB As System.Windows.Forms.Button
    Friend WithEvents btnBtoA As System.Windows.Forms.Button
    Friend WithEvents rtbDebug1 As System.Windows.Forms.RichTextBox
    Friend WithEvents cbBaudA As System.Windows.Forms.ComboBox
    Friend WithEvents cbPortsA As System.Windows.Forms.ComboBox
    Friend WithEvents btnScanFEP1 As System.Windows.Forms.Button
    Friend WithEvents cbBaudB As System.Windows.Forms.ComboBox
    Friend WithEvents cbPortsB As System.Windows.Forms.ComboBox
    Friend WithEvents btnScanFEP2 As System.Windows.Forms.Button
    Friend WithEvents btnScanPorts As System.Windows.Forms.Button
    Friend WithEvents rtbDebug2 As System.Windows.Forms.RichTextBox
    Friend WithEvents tbASN As System.Windows.Forms.TextBox
    Friend WithEvents tbBSN As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents tbBName As System.Windows.Forms.TextBox
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents tbBourSN As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents tbAourSN As System.Windows.Forms.TextBox
    Friend WithEvents btnAWrite As System.Windows.Forms.Button
    Friend WithEvents cbARole As System.Windows.Forms.ComboBox
    Friend WithEvents cbADiversity As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbBRole As System.Windows.Forms.ComboBox
    Friend WithEvents cbBDiversity As System.Windows.Forms.ComboBox
    Friend WithEvents btnBWrite As System.Windows.Forms.Button
    Friend WithEvents cbHexClone As System.Windows.Forms.ComboBox
    Friend WithEvents cbAAddress As System.Windows.Forms.ComboBox
    Friend WithEvents cbACounterpart As System.Windows.Forms.ComboBox
    Friend WithEvents cbAScramble1 As System.Windows.Forms.ComboBox
    Friend WithEvents cbAScramble2 As System.Windows.Forms.ComboBox
    Friend WithEvents cbAChannel1 As System.Windows.Forms.ComboBox
    Friend WithEvents cbAChannel2 As System.Windows.Forms.ComboBox
    Friend WithEvents cbAChannel3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbAGroup As System.Windows.Forms.ComboBox

End Class
