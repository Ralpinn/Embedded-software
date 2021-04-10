<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ControlLed
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlLed))
        Me.BtnOn = New System.Windows.Forms.Button()
        Me.BtnOff = New System.Windows.Forms.Button()
        Me.PortBox = New System.Windows.Forms.ComboBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Ledon = New System.Windows.Forms.PictureBox()
        Me.Led = New System.Windows.Forms.PictureBox()
        CType(Me.Ledon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Led, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnOn
        '
        Me.BtnOn.Location = New System.Drawing.Point(13, 286)
        Me.BtnOn.Name = "BtnOn"
        Me.BtnOn.Size = New System.Drawing.Size(96, 48)
        Me.BtnOn.TabIndex = 0
        Me.BtnOn.Text = "ON"
        Me.BtnOn.UseVisualStyleBackColor = True
        '
        'BtnOff
        '
        Me.BtnOff.Location = New System.Drawing.Point(329, 290)
        Me.BtnOff.Name = "BtnOff"
        Me.BtnOff.Size = New System.Drawing.Size(96, 44)
        Me.BtnOff.TabIndex = 1
        Me.BtnOff.Text = "OFF"
        Me.BtnOff.UseVisualStyleBackColor = True
        '
        'PortBox
        '
        Me.PortBox.FormattingEnabled = True
        Me.PortBox.Location = New System.Drawing.Point(13, 23)
        Me.PortBox.Name = "PortBox"
        Me.PortBox.Size = New System.Drawing.Size(412, 21)
        Me.PortBox.TabIndex = 2
        '
        'Ledon
        '
        Me.Ledon.Image = CType(resources.GetObject("Ledon.Image"), System.Drawing.Image)
        Me.Ledon.Location = New System.Drawing.Point(136, 50)
        Me.Ledon.Name = "Ledon"
        Me.Ledon.Size = New System.Drawing.Size(167, 284)
        Me.Ledon.TabIndex = 3
        Me.Ledon.TabStop = False
        '
        'Led
        '
        Me.Led.Image = CType(resources.GetObject("Led.Image"), System.Drawing.Image)
        Me.Led.Location = New System.Drawing.Point(136, 50)
        Me.Led.Name = "Led"
        Me.Led.Size = New System.Drawing.Size(167, 284)
        Me.Led.TabIndex = 4
        Me.Led.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 346)
        Me.Controls.Add(Me.Led)
        Me.Controls.Add(Me.Ledon)
        Me.Controls.Add(Me.PortBox)
        Me.Controls.Add(Me.BtnOff)
        Me.Controls.Add(Me.BtnOn)
        Me.Name = "Form1"
        Me.Text = "ControlLed"
        CType(Me.Ledon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Led, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnOn As Button
    Friend WithEvents BtnOff As Button
    Friend WithEvents PortBox As ComboBox
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Ledon As PictureBox
    Friend WithEvents Led As PictureBox
End Class
