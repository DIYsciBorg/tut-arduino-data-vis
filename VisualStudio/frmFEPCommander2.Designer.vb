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
        Me.btnRead = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.rtbDebug1 = New System.Windows.Forms.RichTextBox()
        Me.cbBaud1 = New System.Windows.Forms.ComboBox()
        Me.cbPorts1 = New System.Windows.Forms.ComboBox()
        Me.btnScanFEP1 = New System.Windows.Forms.Button()
        Me.btnFEP1INIT = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.cbPorts2 = New System.Windows.Forms.ComboBox()
        Me.btnScanFEP2 = New System.Windows.Forms.Button()
        Me.btnFEP2INIT = New System.Windows.Forms.Button()
        Me.btnScanPorts = New System.Windows.Forms.Button()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.rtbDebug2 = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        '
        'SerialPort2
        '
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(619, 151)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(110, 45)
        Me.btnRead.TabIndex = 1
        Me.btnRead.Text = "READ devices"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(732, 60)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(114, 19)
        Me.TextBox1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(730, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Pair Name"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(1120, 167)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(56, 19)
        Me.TextBox2.TabIndex = 4
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(1199, 167)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(56, 19)
        Me.TextBox3.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1132, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 12)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Radio 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1211, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 12)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Radio 2"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(1163, 73)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton1.TabIndex = 8
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1075, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 12)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Heli"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1075, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 12)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Base"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(1241, 75)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton2.TabIndex = 11
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(1241, 104)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton3.TabIndex = 13
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(1163, 102)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton4.TabIndex = 12
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1069, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 12)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Base"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(1070, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 12)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Base"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(1199, 192)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(56, 19)
        Me.TextBox4.TabIndex = 16
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(1120, 192)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(56, 19)
        Me.TextBox5.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1070, 246)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 12)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Base"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(1199, 246)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(56, 19)
        Me.TextBox6.TabIndex = 22
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(1120, 246)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(56, 19)
        Me.TextBox7.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(1069, 221)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 12)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Base"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(1199, 221)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(56, 19)
        Me.TextBox8.TabIndex = 19
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(1120, 221)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(56, 19)
        Me.TextBox9.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(1069, 353)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 12)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Base"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(1198, 353)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(56, 19)
        Me.TextBox10.TabIndex = 34
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(1119, 353)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(56, 19)
        Me.TextBox11.TabIndex = 33
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(1068, 328)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 12)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Base"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(1198, 328)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(56, 19)
        Me.TextBox12.TabIndex = 31
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(1119, 328)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(56, 19)
        Me.TextBox13.TabIndex = 30
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(1069, 299)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 12)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Base"
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(1198, 299)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(56, 19)
        Me.TextBox14.TabIndex = 28
        '
        'TextBox15
        '
        Me.TextBox15.Location = New System.Drawing.Point(1119, 299)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(56, 19)
        Me.TextBox15.TabIndex = 27
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(1068, 274)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 12)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Base"
        '
        'TextBox16
        '
        Me.TextBox16.Location = New System.Drawing.Point(1198, 274)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(56, 19)
        Me.TextBox16.TabIndex = 25
        '
        'TextBox17
        '
        Me.TextBox17.Location = New System.Drawing.Point(1119, 274)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(56, 19)
        Me.TextBox17.TabIndex = 24
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(619, 218)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 44)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "Make NEW pair"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(619, 277)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(109, 44)
        Me.Button2.TabIndex = 37
        Me.Button2.Text = "Pair from HELI"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(619, 343)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(109, 44)
        Me.Button3.TabIndex = 38
        Me.Button3.Text = "Pair from BASE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(1068, 136)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 12)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "Antennas"
        '
        'rtbDebug1
        '
        Me.rtbDebug1.Location = New System.Drawing.Point(25, 144)
        Me.rtbDebug1.Name = "rtbDebug1"
        Me.rtbDebug1.Size = New System.Drawing.Size(191, 286)
        Me.rtbDebug1.TabIndex = 40
        Me.rtbDebug1.Text = ""
        '
        'cbBaud1
        '
        Me.cbBaud1.FormattingEnabled = True
        Me.cbBaud1.Items.AddRange(New Object() {"9600", "115200"})
        Me.cbBaud1.Location = New System.Drawing.Point(25, 61)
        Me.cbBaud1.Name = "cbBaud1"
        Me.cbBaud1.Size = New System.Drawing.Size(121, 20)
        Me.cbBaud1.TabIndex = 44
        '
        'cbPorts1
        '
        Me.cbPorts1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPorts1.FormattingEnabled = True
        Me.cbPorts1.Location = New System.Drawing.Point(25, 35)
        Me.cbPorts1.Name = "cbPorts1"
        Me.cbPorts1.Size = New System.Drawing.Size(121, 20)
        Me.cbPorts1.TabIndex = 43
        '
        'btnScanFEP1
        '
        Me.btnScanFEP1.Location = New System.Drawing.Point(106, 88)
        Me.btnScanFEP1.Name = "btnScanFEP1"
        Me.btnScanFEP1.Size = New System.Drawing.Size(110, 36)
        Me.btnScanFEP1.TabIndex = 42
        Me.btnScanFEP1.Text = "Scan for FEP 1"
        Me.btnScanFEP1.UseVisualStyleBackColor = True
        '
        'btnFEP1INIT
        '
        Me.btnFEP1INIT.Location = New System.Drawing.Point(25, 88)
        Me.btnFEP1INIT.Name = "btnFEP1INIT"
        Me.btnFEP1INIT.Size = New System.Drawing.Size(75, 36)
        Me.btnFEP1INIT.TabIndex = 41
        Me.btnFEP1INIT.Text = "port 1 INIT"
        Me.btnFEP1INIT.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"9600", "115200"})
        Me.ComboBox1.Location = New System.Drawing.Point(248, 61)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 20)
        Me.ComboBox1.TabIndex = 49
        '
        'cbPorts2
        '
        Me.cbPorts2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPorts2.FormattingEnabled = True
        Me.cbPorts2.Location = New System.Drawing.Point(246, 35)
        Me.cbPorts2.Name = "cbPorts2"
        Me.cbPorts2.Size = New System.Drawing.Size(121, 20)
        Me.cbPorts2.TabIndex = 48
        '
        'btnScanFEP2
        '
        Me.btnScanFEP2.Location = New System.Drawing.Point(329, 94)
        Me.btnScanFEP2.Name = "btnScanFEP2"
        Me.btnScanFEP2.Size = New System.Drawing.Size(110, 36)
        Me.btnScanFEP2.TabIndex = 47
        Me.btnScanFEP2.Text = "Scan for FEP 2"
        Me.btnScanFEP2.UseVisualStyleBackColor = True
        '
        'btnFEP2INIT
        '
        Me.btnFEP2INIT.Location = New System.Drawing.Point(248, 94)
        Me.btnFEP2INIT.Name = "btnFEP2INIT"
        Me.btnFEP2INIT.Size = New System.Drawing.Size(75, 33)
        Me.btnFEP2INIT.TabIndex = 46
        Me.btnFEP2INIT.Text = "FEP 2 INIT"
        Me.btnFEP2INIT.UseVisualStyleBackColor = True
        '
        'btnScanPorts
        '
        Me.btnScanPorts.Location = New System.Drawing.Point(158, 33)
        Me.btnScanPorts.Name = "btnScanPorts"
        Me.btnScanPorts.Size = New System.Drawing.Size(82, 39)
        Me.btnScanPorts.TabIndex = 50
        Me.btnScanPorts.Text = "Scan Ports"
        Me.btnScanPorts.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(244, 11)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(79, 16)
        Me.RadioButton5.TabIndex = 52
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "2 at a time"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(25, 12)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(55, 16)
        Me.RadioButton6.TabIndex = 51
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "1 by 1"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'rtbDebug2
        '
        Me.rtbDebug2.Location = New System.Drawing.Point(248, 144)
        Me.rtbDebug2.Name = "rtbDebug2"
        Me.rtbDebug2.Size = New System.Drawing.Size(191, 286)
        Me.rtbDebug2.TabIndex = 53
        Me.rtbDebug2.Text = ""
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1307, 550)
        Me.Controls.Add(Me.rtbDebug2)
        Me.Controls.Add(Me.RadioButton5)
        Me.Controls.Add(Me.RadioButton6)
        Me.Controls.Add(Me.btnScanPorts)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.cbPorts2)
        Me.Controls.Add(Me.btnScanFEP2)
        Me.Controls.Add(Me.btnFEP2INIT)
        Me.Controls.Add(Me.cbBaud1)
        Me.Controls.Add(Me.cbPorts1)
        Me.Controls.Add(Me.btnScanFEP1)
        Me.Controls.Add(Me.btnFEP1INIT)
        Me.Controls.Add(Me.rtbDebug1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.TextBox13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TextBox14)
        Me.Controls.Add(Me.TextBox15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TextBox16)
        Me.Controls.Add(Me.TextBox17)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnRead)
        Me.Name = "frmMain"
        Me.Text = "FEP Commander"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents SerialPort2 As System.IO.Ports.SerialPort
    Friend WithEvents btnRead As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents rtbDebug1 As System.Windows.Forms.RichTextBox
    Friend WithEvents cbBaud1 As System.Windows.Forms.ComboBox
    Friend WithEvents cbPorts1 As System.Windows.Forms.ComboBox
    Friend WithEvents btnScanFEP1 As System.Windows.Forms.Button
    Friend WithEvents btnFEP1INIT As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents cbPorts2 As System.Windows.Forms.ComboBox
    Friend WithEvents btnScanFEP2 As System.Windows.Forms.Button
    Friend WithEvents btnFEP2INIT As System.Windows.Forms.Button
    Friend WithEvents btnScanPorts As System.Windows.Forms.Button
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents rtbDebug2 As System.Windows.Forms.RichTextBox

End Class
