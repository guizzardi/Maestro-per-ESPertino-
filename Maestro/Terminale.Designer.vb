<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Terminale
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.InviaTesto = New System.Windows.Forms.TextBox()
        Me.BoxRicezione = New System.Windows.Forms.RichTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(385, 68)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 33)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Invia"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'InviaTesto
        '
        Me.InviaTesto.Location = New System.Drawing.Point(12, 40)
        Me.InviaTesto.Name = "InviaTesto"
        Me.InviaTesto.Size = New System.Drawing.Size(448, 22)
        Me.InviaTesto.TabIndex = 1
        '
        'BoxRicezione
        '
        Me.BoxRicezione.Location = New System.Drawing.Point(12, 124)
        Me.BoxRicezione.Name = "BoxRicezione"
        Me.BoxRicezione.Size = New System.Drawing.Size(448, 198)
        Me.BoxRicezione.TabIndex = 2
        Me.BoxRicezione.Text = ""
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(385, 328)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 41)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Esci"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 328)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 41)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Pulisci"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Terminale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 381)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BoxRicezione)
        Me.Controls.Add(Me.InviaTesto)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Terminale"
        Me.Text = "Terminale"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents InviaTesto As TextBox
    Friend WithEvents BoxRicezione As RichTextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button3 As Button
End Class
