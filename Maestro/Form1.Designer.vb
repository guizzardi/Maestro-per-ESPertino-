<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EsciToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StrumentiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GraficoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LEDRGBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettaggiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PortaUSBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AiutoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoSulProgrammaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button05 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.StrumentiToolStripMenuItem, Me.SettaggiToolStripMenuItem, Me.AiutoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(855, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EsciToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'EsciToolStripMenuItem
        '
        Me.EsciToolStripMenuItem.Name = "EsciToolStripMenuItem"
        Me.EsciToolStripMenuItem.Size = New System.Drawing.Size(109, 26)
        Me.EsciToolStripMenuItem.Text = "Esci"
        '
        'StrumentiToolStripMenuItem
        '
        Me.StrumentiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LEDRGBToolStripMenuItem, Me.ToolStripSeparator1, Me.GraficoToolStripMenuItem})
        Me.StrumentiToolStripMenuItem.Name = "StrumentiToolStripMenuItem"
        Me.StrumentiToolStripMenuItem.Size = New System.Drawing.Size(85, 24)
        Me.StrumentiToolStripMenuItem.Text = "Strumenti"
        '
        'GraficoToolStripMenuItem
        '
        Me.GraficoToolStripMenuItem.Name = "GraficoToolStripMenuItem"
        Me.GraficoToolStripMenuItem.Size = New System.Drawing.Size(182, 26)
        Me.GraficoToolStripMenuItem.Text = "Grafico DHT11"
        '
        'LEDRGBToolStripMenuItem
        '
        Me.LEDRGBToolStripMenuItem.Name = "LEDRGBToolStripMenuItem"
        Me.LEDRGBToolStripMenuItem.Size = New System.Drawing.Size(182, 26)
        Me.LEDRGBToolStripMenuItem.Text = "Terminale"
        '
        'SettaggiToolStripMenuItem
        '
        Me.SettaggiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PortaUSBToolStripMenuItem})
        Me.SettaggiToolStripMenuItem.Name = "SettaggiToolStripMenuItem"
        Me.SettaggiToolStripMenuItem.Size = New System.Drawing.Size(77, 24)
        Me.SettaggiToolStripMenuItem.Text = "Settaggi"
        '
        'PortaUSBToolStripMenuItem
        '
        Me.PortaUSBToolStripMenuItem.Name = "PortaUSBToolStripMenuItem"
        Me.PortaUSBToolStripMenuItem.Size = New System.Drawing.Size(149, 26)
        Me.PortaUSBToolStripMenuItem.Text = "Porta USB"
        '
        'AiutoToolStripMenuItem
        '
        Me.AiutoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InfoSulProgrammaToolStripMenuItem})
        Me.AiutoToolStripMenuItem.Name = "AiutoToolStripMenuItem"
        Me.AiutoToolStripMenuItem.Size = New System.Drawing.Size(57, 24)
        Me.AiutoToolStripMenuItem.Text = "Aiuto"
        '
        'InfoSulProgrammaToolStripMenuItem
        '
        Me.InfoSulProgrammaToolStripMenuItem.Name = "InfoSulProgrammaToolStripMenuItem"
        Me.InfoSulProgrammaToolStripMenuItem.Size = New System.Drawing.Size(215, 26)
        Me.InfoSulProgrammaToolStripMenuItem.Text = "Info sul programma"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(99, 89)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(496, 376)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Button05
        '
        Me.Button05.Location = New System.Drawing.Point(440, 68)
        Me.Button05.Name = "Button05"
        Me.Button05.Size = New System.Drawing.Size(22, 23)
        Me.Button05.TabIndex = 3
        Me.Button05.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(521, 68)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(22, 23)
        Me.Button13.TabIndex = 4
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(575, 68)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(20, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(549, 68)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(20, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(179, 6)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(855, 703)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button05)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maestro - Espertino Controller - Scritto da Brain & Bytes - Ver. 1.0.0"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EsciToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettaggiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PortaUSBToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AiutoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InfoSulProgrammaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents StrumentiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GraficoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button05 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents LEDRGBToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
End Class
