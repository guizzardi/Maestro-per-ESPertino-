Public Class seriale

    Dim File = Application.StartupPath + "\maestro_seriale.ini"
    Dim Settaggi = "Settaggi"
    Dim PortaCOM = "USB"
    Dim PORTA As String = "COM1"

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If System.IO.File.Exists(File) Then
            PORTA = ReadIni(File, Settaggi, PortaCOM, "COM1")
        End If

        For Each sp As String In My.Computer.Ports.SerialPortNames
            ComboBox1.Items.Add(sp)
            If sp = PORTA Then
                ComboBox1.Text = PORTA
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        writeIni(File, Settaggi, PortaCOM, ComboBox1.Text)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class