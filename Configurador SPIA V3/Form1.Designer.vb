<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.puertos = New System.Windows.Forms.ComboBox()
        Me.bufferout = New System.Windows.Forms.TextBox()
        Me.sppuertos = New System.IO.Ports.SerialPort(Me.components)
        Me.bufferin = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtpin = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtlinea = New System.Windows.Forms.TextBox()
        Me.txtclave = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtapnmanual = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbdistancia = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbtiempo = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txttramarecibida = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.btnlimpiarlog = New System.Windows.Forms.Button()
        Me.btnoffled = New System.Windows.Forms.Button()
        Me.btnonled = New System.Windows.Forms.Button()
        Me.btnencender = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnfinalizarpanico = New System.Windows.Forms.Button()
        Me.btnapagado = New System.Windows.Forms.Button()
        Me.btnapnmanual = New System.Windows.Forms.Button()
        Me.btntigo = New System.Windows.Forms.Button()
        Me.btnmovistar = New System.Windows.Forms.Button()
        Me.btnclaro = New System.Windows.Forms.Button()
        Me.enviardato = New System.Windows.Forms.Button()
        Me.conectar = New System.Windows.Forms.Button()
        Me.determinarconecxion = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'puertos
        '
        Me.puertos.FormattingEnabled = True
        Me.puertos.Location = New System.Drawing.Point(1089, 62)
        Me.puertos.Name = "puertos"
        Me.puertos.Size = New System.Drawing.Size(87, 21)
        Me.puertos.TabIndex = 3
        '
        'bufferout
        '
        Me.bufferout.Location = New System.Drawing.Point(454, 381)
        Me.bufferout.Multiline = True
        Me.bufferout.Name = "bufferout"
        Me.bufferout.Size = New System.Drawing.Size(232, 20)
        Me.bufferout.TabIndex = 4
        '
        'sppuertos
        '
        Me.sppuertos.BaudRate = 115200
        Me.sppuertos.ReadBufferSize = 8000
        Me.sppuertos.WriteBufferSize = 4000
        '
        'bufferin
        '
        Me.bufferin.AllowDrop = True
        Me.bufferin.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.bufferin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bufferin.Font = New System.Drawing.Font("Segoe Print", 10.87!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bufferin.Location = New System.Drawing.Point(487, 405)
        Me.bufferin.Margin = New System.Windows.Forms.Padding(3, 1, 3, 3)
        Me.bufferin.Multiline = True
        Me.bufferin.Name = "bufferin"
        Me.bufferin.Size = New System.Drawing.Size(232, 247)
        Me.bufferin.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(42, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 26)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "PIN"
        '
        'txtpin
        '
        Me.txtpin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpin.Location = New System.Drawing.Point(86, 124)
        Me.txtpin.MaxLength = 6
        Me.txtpin.Name = "txtpin"
        Me.txtpin.Size = New System.Drawing.Size(104, 23)
        Me.txtpin.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe Print", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label4.Location = New System.Drawing.Point(39, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 24)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "OPERADOR"
        '
        'txtlinea
        '
        Me.txtlinea.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlinea.Location = New System.Drawing.Point(197, 259)
        Me.txtlinea.MaxLength = 10
        Me.txtlinea.Name = "txtlinea"
        Me.txtlinea.Size = New System.Drawing.Size(77, 23)
        Me.txtlinea.TabIndex = 14
        '
        'txtclave
        '
        Me.txtclave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtclave.Location = New System.Drawing.Point(197, 286)
        Me.txtclave.MaxLength = 4
        Me.txtclave.Name = "txtclave"
        Me.txtclave.Size = New System.Drawing.Size(53, 23)
        Me.txtclave.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label5.Location = New System.Drawing.Point(148, 257)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 23)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Linea"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label6.Location = New System.Drawing.Point(147, 282)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 23)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Clave"
        '
        'txtapnmanual
        '
        Me.txtapnmanual.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtapnmanual.Location = New System.Drawing.Point(72, 383)
        Me.txtapnmanual.MaxLength = 100
        Me.txtapnmanual.Name = "txtapnmanual"
        Me.txtapnmanual.Size = New System.Drawing.Size(271, 23)
        Me.txtapnmanual.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe Script", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label7.Location = New System.Drawing.Point(38, 441)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(156, 22)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "DISTANCIA (metros)"
        '
        'cmbdistancia
        '
        Me.cmbdistancia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbdistancia.FormattingEnabled = True
        Me.cmbdistancia.Items.AddRange(New Object() {"500", "1000", "1500", "2000"})
        Me.cmbdistancia.Location = New System.Drawing.Point(138, 470)
        Me.cmbdistancia.Name = "cmbdistancia"
        Me.cmbdistancia.Size = New System.Drawing.Size(112, 24)
        Me.cmbdistancia.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe Print", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label8.Location = New System.Drawing.Point(38, 514)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(147, 24)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "TIEMPO  (minutos)"
        '
        'cmbtiempo
        '
        Me.cmbtiempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtiempo.FormattingEnabled = True
        Me.cmbtiempo.Items.AddRange(New Object() {"30", "60", "120"})
        Me.cmbtiempo.Location = New System.Drawing.Point(138, 541)
        Me.cmbtiempo.Name = "cmbtiempo"
        Me.cmbtiempo.Size = New System.Drawing.Size(112, 24)
        Me.cmbtiempo.TabIndex = 27
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe Print", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label9.Location = New System.Drawing.Point(41, 575)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 26)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "KIT APAGADO"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe Print", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label10.Location = New System.Drawing.Point(409, 141)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 24)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "PANICO"
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Print", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label2.Location = New System.Drawing.Point(393, 408)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 240)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "PIN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "OPERADOR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DISTANCIA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TIEMPO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PANICO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "LINEA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CLAVE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "LED" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "VERSION" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SATELITES"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Print", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label3.Location = New System.Drawing.Point(404, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(419, 47)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "CONFIGURADOR SPIA V 3.5"
        '
        'txttramarecibida
        '
        Me.txttramarecibida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttramarecibida.Location = New System.Drawing.Point(746, 167)
        Me.txttramarecibida.Multiline = True
        Me.txttramarecibida.Name = "txttramarecibida"
        Me.txttramarecibida.ReadOnly = True
        Me.txttramarecibida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txttramarecibida.Size = New System.Drawing.Size(430, 484)
        Me.txttramarecibida.TabIndex = 37
        Me.txttramarecibida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label11.Location = New System.Drawing.Point(752, 134)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 28)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "LOG"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label12.Location = New System.Drawing.Point(408, 224)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(140, 26)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "LED INDICADOR"
        '
        'Timer2
        '
        Me.Timer2.Interval = 13000
        '
        'btnlimpiarlog
        '
        Me.btnlimpiarlog.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnlimpiarlog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnlimpiarlog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnlimpiarlog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlimpiarlog.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlimpiarlog.Image = CType(resources.GetObject("btnlimpiarlog.Image"), System.Drawing.Image)
        Me.btnlimpiarlog.Location = New System.Drawing.Point(1089, 657)
        Me.btnlimpiarlog.Name = "btnlimpiarlog"
        Me.btnlimpiarlog.Size = New System.Drawing.Size(111, 46)
        Me.btnlimpiarlog.TabIndex = 44
        Me.btnlimpiarlog.Text = "Limpiar"
        Me.btnlimpiarlog.UseVisualStyleBackColor = True
        '
        'btnoffled
        '
        Me.btnoffled.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnoffled.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnoffled.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnoffled.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnoffled.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnoffled.Image = CType(resources.GetObject("btnoffled.Image"), System.Drawing.Image)
        Me.btnoffled.Location = New System.Drawing.Point(597, 255)
        Me.btnoffled.Name = "btnoffled"
        Me.btnoffled.Size = New System.Drawing.Size(104, 50)
        Me.btnoffled.TabIndex = 43
        Me.btnoffled.Text = "Inhabilitar"
        Me.btnoffled.UseVisualStyleBackColor = True
        '
        'btnonled
        '
        Me.btnonled.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnonled.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnonled.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnonled.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnonled.Font = New System.Drawing.Font("Segoe Print", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnonled.Image = CType(resources.GetObject("btnonled.Image"), System.Drawing.Image)
        Me.btnonled.Location = New System.Drawing.Point(482, 256)
        Me.btnonled.Name = "btnonled"
        Me.btnonled.Size = New System.Drawing.Size(109, 47)
        Me.btnonled.TabIndex = 42
        Me.btnonled.Text = "Habilitar"
        Me.btnonled.UseVisualStyleBackColor = True
        '
        'btnencender
        '
        Me.btnencender.BackColor = System.Drawing.Color.Transparent
        Me.btnencender.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnencender.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnencender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnencender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnencender.Font = New System.Drawing.Font("Segoe Print", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnencender.Image = CType(resources.GetObject("btnencender.Image"), System.Drawing.Image)
        Me.btnencender.Location = New System.Drawing.Point(197, 605)
        Me.btnencender.Name = "btnencender"
        Me.btnencender.Size = New System.Drawing.Size(89, 46)
        Me.btnencender.TabIndex = 38
        Me.btnencender.Text = "Encender"
        Me.btnencender.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(247, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(113, 86)
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'btnfinalizarpanico
        '
        Me.btnfinalizarpanico.BackColor = System.Drawing.Color.Transparent
        Me.btnfinalizarpanico.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnfinalizarpanico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnfinalizarpanico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnfinalizarpanico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnfinalizarpanico.Font = New System.Drawing.Font("Segoe Print", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfinalizarpanico.Image = CType(resources.GetObject("btnfinalizarpanico.Image"), System.Drawing.Image)
        Me.btnfinalizarpanico.Location = New System.Drawing.Point(541, 169)
        Me.btnfinalizarpanico.Name = "btnfinalizarpanico"
        Me.btnfinalizarpanico.Size = New System.Drawing.Size(96, 49)
        Me.btnfinalizarpanico.TabIndex = 32
        Me.btnfinalizarpanico.Text = "Finalizar "
        Me.btnfinalizarpanico.UseVisualStyleBackColor = False
        '
        'btnapagado
        '
        Me.btnapagado.BackColor = System.Drawing.Color.Transparent
        Me.btnapagado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnapagado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnapagado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnapagado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnapagado.Font = New System.Drawing.Font("Segoe Print", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnapagado.Image = CType(resources.GetObject("btnapagado.Image"), System.Drawing.Image)
        Me.btnapagado.Location = New System.Drawing.Point(87, 605)
        Me.btnapagado.Name = "btnapagado"
        Me.btnapagado.Size = New System.Drawing.Size(88, 46)
        Me.btnapagado.TabIndex = 30
        Me.btnapagado.Text = "Apagar"
        Me.btnapagado.UseVisualStyleBackColor = False
        '
        'btnapnmanual
        '
        Me.btnapnmanual.BackColor = System.Drawing.Color.Transparent
        Me.btnapnmanual.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnapnmanual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnapnmanual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnapnmanual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnapnmanual.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnapnmanual.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnapnmanual.Image = CType(resources.GetObject("btnapnmanual.Image"), System.Drawing.Image)
        Me.btnapnmanual.Location = New System.Drawing.Point(50, 329)
        Me.btnapnmanual.Name = "btnapnmanual"
        Me.btnapnmanual.Size = New System.Drawing.Size(310, 45)
        Me.btnapnmanual.TabIndex = 23
        Me.btnapnmanual.Text = "Ingreso manual de APN (opcional)"
        Me.btnapnmanual.UseVisualStyleBackColor = False
        '
        'btntigo
        '
        Me.btntigo.BackColor = System.Drawing.Color.Transparent
        Me.btntigo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btntigo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btntigo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btntigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntigo.Font = New System.Drawing.Font("Segoe Print", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntigo.Image = CType(resources.GetObject("btntigo.Image"), System.Drawing.Image)
        Me.btntigo.Location = New System.Drawing.Point(218, 196)
        Me.btntigo.Name = "btntigo"
        Me.btntigo.Size = New System.Drawing.Size(95, 45)
        Me.btntigo.TabIndex = 13
        Me.btntigo.Text = "Tigo"
        Me.btntigo.UseVisualStyleBackColor = False
        '
        'btnmovistar
        '
        Me.btnmovistar.BackColor = System.Drawing.Color.Transparent
        Me.btnmovistar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnmovistar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnmovistar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnmovistar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmovistar.Font = New System.Drawing.Font("Segoe Print", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmovistar.Image = CType(resources.GetObject("btnmovistar.Image"), System.Drawing.Image)
        Me.btnmovistar.Location = New System.Drawing.Point(49, 258)
        Me.btnmovistar.Name = "btnmovistar"
        Me.btnmovistar.Size = New System.Drawing.Size(99, 43)
        Me.btnmovistar.TabIndex = 12
        Me.btnmovistar.Text = "Movistar"
        Me.btnmovistar.UseVisualStyleBackColor = False
        '
        'btnclaro
        '
        Me.btnclaro.BackColor = System.Drawing.Color.Transparent
        Me.btnclaro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnclaro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnclaro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnclaro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclaro.Font = New System.Drawing.Font("Segoe Print", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclaro.Image = CType(resources.GetObject("btnclaro.Image"), System.Drawing.Image)
        Me.btnclaro.Location = New System.Drawing.Point(53, 196)
        Me.btnclaro.Name = "btnclaro"
        Me.btnclaro.Size = New System.Drawing.Size(93, 45)
        Me.btnclaro.TabIndex = 11
        Me.btnclaro.Text = "Claro"
        Me.btnclaro.UseVisualStyleBackColor = False
        '
        'enviardato
        '
        Me.enviardato.BackColor = System.Drawing.Color.Transparent
        Me.enviardato.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.enviardato.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.enviardato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.enviardato.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.enviardato.Font = New System.Drawing.Font("Segoe Print", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enviardato.ForeColor = System.Drawing.SystemColors.Highlight
        Me.enviardato.Image = CType(resources.GetObject("enviardato.Image"), System.Drawing.Image)
        Me.enviardato.Location = New System.Drawing.Point(524, 311)
        Me.enviardato.Name = "enviardato"
        Me.enviardato.Size = New System.Drawing.Size(144, 76)
        Me.enviardato.TabIndex = 2
        Me.enviardato.Text = "Enviar"
        Me.enviardato.UseVisualStyleBackColor = False
        '
        'conectar
        '
        Me.conectar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.conectar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.conectar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.conectar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.conectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.conectar.Font = New System.Drawing.Font("Segoe Print", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.conectar.ForeColor = System.Drawing.SystemColors.Highlight
        Me.conectar.Image = CType(resources.GetObject("conectar.Image"), System.Drawing.Image)
        Me.conectar.Location = New System.Drawing.Point(1064, 89)
        Me.conectar.Name = "conectar"
        Me.conectar.Size = New System.Drawing.Size(143, 52)
        Me.conectar.TabIndex = 1
        Me.conectar.Text = "Conectar"
        Me.conectar.UseVisualStyleBackColor = False
        '
        'determinarconecxion
        '
        Me.determinarconecxion.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.determinarconecxion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.determinarconecxion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.determinarconecxion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.determinarconecxion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.determinarconecxion.Font = New System.Drawing.Font("Segoe Print", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.determinarconecxion.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.determinarconecxion.Image = CType(resources.GetObject("determinarconecxion.Image"), System.Drawing.Image)
        Me.determinarconecxion.Location = New System.Drawing.Point(1065, 9)
        Me.determinarconecxion.Name = "determinarconecxion"
        Me.determinarconecxion.Size = New System.Drawing.Size(140, 52)
        Me.determinarconecxion.TabIndex = 0
        Me.determinarconecxion.Text = "Check puerto"
        Me.determinarconecxion.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1219, 724)
        Me.Controls.Add(Me.btnlimpiarlog)
        Me.Controls.Add(Me.btnoffled)
        Me.Controls.Add(Me.btnonled)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnencender)
        Me.Controls.Add(Me.txttramarecibida)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnfinalizarpanico)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnapagado)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmbtiempo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbdistancia)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnapnmanual)
        Me.Controls.Add(Me.txtapnmanual)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtclave)
        Me.Controls.Add(Me.txtlinea)
        Me.Controls.Add(Me.btntigo)
        Me.Controls.Add(Me.btnmovistar)
        Me.Controls.Add(Me.btnclaro)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtpin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bufferin)
        Me.Controls.Add(Me.puertos)
        Me.Controls.Add(Me.enviardato)
        Me.Controls.Add(Me.conectar)
        Me.Controls.Add(Me.determinarconecxion)
        Me.Controls.Add(Me.bufferout)
        Me.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Configurador SPIA V3"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents determinarconecxion As Button
    Friend WithEvents conectar As Button
    Friend WithEvents enviardato As Button
    Friend WithEvents puertos As ComboBox
    Friend WithEvents bufferout As TextBox
    Friend WithEvents sppuertos As IO.Ports.SerialPort
    Friend WithEvents bufferin As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtpin As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnclaro As Button
    Friend WithEvents btnmovistar As Button
    Friend WithEvents btntigo As Button
    Friend WithEvents txtlinea As TextBox
    Friend WithEvents txtclave As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtapnmanual As TextBox
    Friend WithEvents btnapnmanual As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbdistancia As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbtiempo As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnapagado As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents btnfinalizarpanico As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txttramarecibida As TextBox
    Friend WithEvents btnencender As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btnonled As Button
    Friend WithEvents btnoffled As Button
    Friend WithEvents Timer2 As Timer
    Friend WithEvents btnlimpiarlog As Button
End Class
