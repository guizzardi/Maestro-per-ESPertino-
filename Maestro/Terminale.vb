Imports System
Imports System.ComponentModel
Imports System.Threading
Imports System.IO.Ports

Public Class Terminale
    Dim receivedData As String = ""
    Delegate Sub SetTextCallback(ByVal [text] As String)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ModuloSeriale.SP.IsOpen Then
            ModuloSeriale.SP.Write(InviaTesto.Text.Trim())
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        receivedData = ReceiveSerialData()
        BoxRicezione.Text &= receivedData
    End Sub

    Function ReceiveSerialData() As String
        Dim Incoming As String
        Try
            Incoming = ModuloSeriale.SP.ReadExisting()
            If Incoming Is Nothing Then
                Return "nothing" & vbCrLf
            Else
                Return Incoming
            End If
        Catch ex As TimeoutException
            Return "Errore: timeout dalla porta seriale."
        End Try

    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        BoxRicezione.Text = ""
    End Sub
End Class