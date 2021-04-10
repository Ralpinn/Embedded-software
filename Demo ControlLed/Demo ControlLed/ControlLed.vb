Public Class ControlLed

    Dim MyPorts As Array

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MyPorts = IO.Ports.SerialPort.GetPortNames
            PortBox.Items.AddRange(MyPorts)
            PortBox.SelectedItem = PortBox.Items(0)

            SerialPort1.BaudRate = (9600)
            SerialPort1.ReadTimeout = (2000)
            SerialPort1.WriteTimeout = (2000)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnOn_Click(sender As Object, e As EventArgs) Handles BtnOn.Click
        Try
            Led.Visible = False
            Ledon.Visible = True
            SerialPort1.Open()
            SerialPort1.WriteLine("on")
            SerialPort1.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnOff_Click(sender As Object, e As EventArgs) Handles BtnOff.Click
        Led.Visible = True
        Ledon.Visible = False
        SerialPort1.Open()
        SerialPort1.WriteLine("off")
        SerialPort1.Close()
    End Sub

    Private Sub PortBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PortBox.SelectedIndexChanged
        Try
            SerialPort1.PortName = PortBox.Text
        Catch ex As Exception

        End Try
    End Sub


End Class
