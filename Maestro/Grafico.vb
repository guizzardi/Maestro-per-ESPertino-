Imports System
Imports System.IO.Ports
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Grafico

    Dim s As New Series
    Dim stopclick As Boolean = False
    Dim comPORT As String
    Dim receivedData As String = ""

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            'Change to a line graph.
            s.ChartType = SeriesChartType.Line

            If ModuloSeriale.SP.IsOpen = True Then
                ModuloSeriale.SP.Close()
            End If

            ModuloSeriale.SP.Open()

            Chart1.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Line
            Chart1.ChartAreas(0).AxisX.Maximum = 100
            Chart1.ChartAreas(0).AxisY.Maximum = 100
            Chart1.ChartAreas(0).AxisX.ScrollBar.Size = 10
            Chart1.ChartAreas(0).AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll
            Chart1.ChartAreas(0).AxisX.ScrollBar.IsPositionedInside = True
            Chart1.ChartAreas(0).AxisX.ScrollBar.Enabled = True

        Catch ex As Exception
            MsgBox("Errore nell'utilizzo della USB." + vbNewLine + "ESPertino non è collegato oppure è in uso la porta sbagliata." + vbNewLine + "Cliccate su Settaggi e cambiate la USB.")
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        stopclick = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If ModuloSeriale.SP.IsOpen Then
            ModuloSeriale.SP.Write("DHT") ' comando lettore DHT11
            receivedData = ReceiveSerialData()

            Dim dati As String() = receivedData.Split(New Char() {";"c})

            Try
                If dati(0).Length > 0 Then
                    Me.Chart1.Series("Umidità").Points.AddXY(Format(Now, "hh:mm:ss"), dati(0))
                End If
            Catch ex As Exception
            End Try

            Try
                If dati(1).Length > 0 Then
                    Me.Chart1.Series("Temperatura").Points.AddXY(Format(Now, "hh:mm:ss"), dati(1))
                End If
            Catch ex As Exception
            End Try

            If Me.Chart1.Series(0).Points.Count > 100 Then
                Chart1.ChartAreas(0).AxisX.Maximum = Chart1.ChartAreas(0).AxisX.Maximum + 100
            End If

        End If

    End Sub

    Function ReceiveSerialData() As String
        Dim Incoming As String
        Try
            If ModuloSeriale.SP.IsOpen Then
                Incoming = ModuloSeriale.SP.ReadExisting()
                If Incoming Is Nothing Then
                    Return 0
                Else
                    Return Incoming
                End If
            End If

        Catch ex As TimeoutException
            Return "Errore: time out dalla porta seriale."
        End Try
        Return 0
    End Function

End Class