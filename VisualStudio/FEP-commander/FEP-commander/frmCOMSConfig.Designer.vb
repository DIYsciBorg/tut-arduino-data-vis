<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCOMSConfig
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
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.btnFEP1INIT = New System.Windows.Forms.Button()
        Me.btnFEP2INIT = New System.Windows.Forms.Button()
        Me.btnScanFEP1 = New System.Windows.Forms.Button()
        Me.btnScanFEP2 = New System.Windows.Forms.Button()
        Me.cbPorts1 = New System.Windows.Forms.ComboBox()
        Me.cbPorts2 = New System.Windows.Forms.ComboBox()
        Me.rtbDebug1 = New System.Windows.Forms.RichTextBox()
        Me.rtbDebug2 = New System.Windows.Forms.RichTextBox()
        Me.btnScanPorts = New System.Windows.Forms.Button()
        Me.cbBaud1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(61, 79)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(55, 16)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "1 by 1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(410, 79)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(79, 16)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "2 at a time"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'btnFEP1INIT
        '
        Me.btnFEP1INIT.Location = New System.Drawing.Point(96, 180)
        Me.btnFEP1INIT.Name = "btnFEP1INIT"
        Me.btnFEP1INIT.Size = New System.Drawing.Size(75, 36)
        Me.btnFEP1INIT.TabIndex = 3
        Me.btnFEP1INIT.Text = "port 1 INIT"
        Me.btnFEP1INIT.UseVisualStyleBackColor = True
        '
        'btnFEP2INIT
        '
        Me.btnFEP2INIT.Location = New System.Drawing.Point(445, 180)
        Me.btnFEP2INIT.Name = "btnFEP2INIT"
        Me.btnFEP2INIT.Size = New System.Drawing.Size(75, 33)
        Me.btnFEP2INIT.TabIndex = 4
        Me.btnFEP2INIT.Text = "FEP 2 INIT"
        Me.btnFEP2INIT.UseVisualStyleBackColor = True
        '
        'btnScanFEP1
        '
        Me.btnScanFEP1.Location = New System.Drawing.Point(61, 240)
        Me.btnScanFEP1.Name = "btnScanFEP1"
        Me.btnScanFEP1.Size = New System.Drawing.Size(110, 36)
        Me.btnScanFEP1.TabIndex = 5
        Me.btnScanFEP1.Text = "Scan for FEP 1"
        Me.btnScanFEP1.UseVisualStyleBackColor = True
        '
        'btnScanFEP2
        '
        Me.btnScanFEP2.Location = New System.Drawing.Point(410, 240)
        Me.btnScanFEP2.Name = "btnScanFEP2"
        Me.btnScanFEP2.Size = New System.Drawing.Size(110, 36)
        Me.btnScanFEP2.TabIndex = 6
        Me.btnScanFEP2.Text = "Scan for FEP 2"
        Me.btnScanFEP2.UseVisualStyleBackColor = True
        '
        'cbPorts1
        '
        Me.cbPorts1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPorts1.FormattingEnabled = True
        Me.cbPorts1.Location = New System.Drawing.Point(61, 112)
        Me.cbPorts1.Name = "cbPorts1"
        Me.cbPorts1.Size = New System.Drawing.Size(121, 20)
        Me.cbPorts1.TabIndex = 7
        '
        'cbPorts2
        '
        Me.cbPorts2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPorts2.FormattingEnabled = True
        Me.cbPorts2.Location = New System.Drawing.Point(408, 112)
        Me.cbPorts2.Name = "cbPorts2"
        Me.cbPorts2.Size = New System.Drawing.Size(121, 20)
        Me.cbPorts2.TabIndex = 8
        '
        'rtbDebug1
        '
        Me.rtbDebug1.Location = New System.Drawing.Point(188, 116)
        Me.rtbDebug1.Name = "rtbDebug1"
        Me.rtbDebug1.Size = New System.Drawing.Size(186, 315)
        Me.rtbDebug1.TabIndex = 9
        Me.rtbDebug1.Text = ""
        '
        'rtbDebug2
        '
        Me.rtbDebug2.Location = New System.Drawing.Point(535, 112)
        Me.rtbDebug2.Name = "rtbDebug2"
        Me.rtbDebug2.Size = New System.Drawing.Size(186, 315)
        Me.rtbDebug2.TabIndex = 10
        Me.rtbDebug2.Text = ""
        '
        'btnScanPorts
        '
        Me.btnScanPorts.Location = New System.Drawing.Point(61, 12)
        Me.btnScanPorts.Name = "btnScanPorts"
        Me.btnScanPorts.Size = New System.Drawing.Size(116, 39)
        Me.btnScanPorts.TabIndex = 11
        Me.btnScanPorts.Text = "Scan Ports"
        Me.btnScanPorts.UseVisualStyleBackColor = True
        '
        'cbBaud1
        '
        Me.cbBaud1.FormattingEnabled = True
        Me.cbBaud1.Items.AddRange(New Object() {"9600", "115200"})
        Me.cbBaud1.Location = New System.Drawing.Point(61, 138)
        Me.cbBaud1.Name = "cbBaud1"
        Me.cbBaud1.Size = New System.Drawing.Size(121, 20)
        Me.cbBaud1.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(96, 423)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"9600", "115200"})
        Me.ComboBox1.Location = New System.Drawing.Point(410, 138)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 20)
        Me.ComboBox1.TabIndex = 14
        '
        'frmCOMSConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 472)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbBaud1)
        Me.Controls.Add(Me.btnScanPorts)
        Me.Controls.Add(Me.rtbDebug2)
        Me.Controls.Add(Me.rtbDebug1)
        Me.Controls.Add(Me.cbPorts2)
        Me.Controls.Add(Me.cbPorts1)
        Me.Controls.Add(Me.btnScanFEP2)
        Me.Controls.Add(Me.btnScanFEP1)
        Me.Controls.Add(Me.btnFEP2INIT)
        Me.Controls.Add(Me.btnFEP1INIT)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Name = "frmCOMSConfig"
        Me.Text = "COMS config"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents btnFEP1INIT As System.Windows.Forms.Button
    Friend WithEvents btnFEP2INIT As System.Windows.Forms.Button
    Friend WithEvents btnScanFEP1 As System.Windows.Forms.Button
    Friend WithEvents btnScanFEP2 As System.Windows.Forms.Button
    Friend WithEvents cbPorts1 As System.Windows.Forms.ComboBox
    Friend WithEvents cbPorts2 As System.Windows.Forms.ComboBox
    Friend WithEvents rtbDebug1 As System.Windows.Forms.RichTextBox
    Friend WithEvents rtbDebug2 As System.Windows.Forms.RichTextBox
    Friend WithEvents btnScanPorts As System.Windows.Forms.Button
    Friend WithEvents cbBaud1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
