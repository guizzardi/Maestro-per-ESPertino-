'=====================================================
' MAESTRO - ESPERTINO Interfaccia, ver. 1.0.0
' ----------------------------------------------------
' Scritto da Gabriele Guizzardi, Brain & Bytes
' Copyright 2017 Elettrnonica Open Source
'=====================================================

Imports System.IO
Imports System.IO.Ports
Imports System.Threading

Public Class Form1

    ' onboard LEDs
    Dim b13 As Boolean = False
    Dim b5 As Boolean = False
    ' onboard Relays
    Dim bk1 As Boolean = False
    Dim bk2 As Boolean = False

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If ModuloSeriale.SP.IsOpen = True Then
            ModuloSeriale.SP.Close()
        End If

        Try
            ModuloSeriale.SP.Open()
        Catch ex As Exception
            MsgBox("Errore nell'utilizzo della USB." + vbNewLine + "ESPertino non è collegato oppure è in uso la porta sbagliata." + vbNewLine + "Cliccate su Settaggi e cambiate la USB.")
        End Try

    End Sub

    Private Sub PortaUSBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PortaUSBToolStripMenuItem.Click
        seriale.Show()
    End Sub

    Private Sub GraficoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GraficoToolStripMenuItem.Click
        Grafico.Show()
    End Sub

    Private Sub InfoSulProgrammaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfoSulProgrammaToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub EsciToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EsciToolStripMenuItem.Click
        End
    End Sub

    Private Sub Button05_Click(sender As Object, e As EventArgs) Handles Button05.Click

        If ModuloSeriale.SP.IsOpen Then
            If b5 Then
                ModuloSeriale.SP.Write("L05")
                b5 = False
                Button05.BackColor = Color.Black
            Else
                ModuloSeriale.SP.Write("H05")
                b5 = True
                Button05.BackColor = Color.Red
            End If
        End If

    End Sub

    Private Sub Button13_Click_1(sender As Object, e As EventArgs) Handles Button13.Click

        If ModuloSeriale.SP.IsOpen Then
            If b13 Then
                ModuloSeriale.SP.Write("L13")
                b13 = False
                Button13.BackColor = Color.Black
            Else
                ModuloSeriale.SP.Write("H13")
                b13 = True
                Button13.BackColor = Color.Red
            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If ModuloSeriale.SP.IsOpen Then
            If bk1 Then
                ModuloSeriale.SP.Write("HK1")
                bk1 = False
                Button1.BackColor = Color.Black
            Else
                ModuloSeriale.SP.Write("LK1")
                bk1 = True
                Button1.BackColor = Color.Red
            End If
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If ModuloSeriale.SP.IsOpen Then
            If bk2 Then
                ModuloSeriale.SP.Write("HK2")
                bk2 = False
                Button2.BackColor = Color.Black
            Else
                ModuloSeriale.SP.Write("LK2")
                bk2 = True
                Button2.BackColor = Color.Red
            End If
        End If

    End Sub

    Private Sub LEDRGBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LEDRGBToolStripMenuItem.Click
        Terminale.Show()
    End Sub
End Class
