Imports System.IO
Imports System.IO.Ports

Public Module ModuloSeriale

    Dim File = Application.StartupPath + "\maestro_seriale.ini"
    Dim Settaggi = "Settaggi"
    Dim PortaCOM = "USB"
    Dim PORTA As String = "COM1"

    Public Function LetturaPorta()
        If System.IO.File.Exists(File) Then
            PORTA = ReadIni(File, Settaggi, PortaCOM, "COM1")
        End If
        Return PORTA
    End Function

    Friend SP = New System.IO.Ports.SerialPort(LetturaPorta(), 9600, IO.Ports.Parity.None, 8, IO.Ports.StopBits.One)

End Module
