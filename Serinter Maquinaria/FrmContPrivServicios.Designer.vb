<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmContPrivServicios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmContPrivServicios))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tnombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tidentidad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tnumcorrelativo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nsalario = New System.Windows.Forms.NumericUpDown()
        Me.btadelante = New System.Windows.Forms.Button()
        Me.btatras = New System.Windows.Forms.Button()
        Me.bagregar = New System.Windows.Forms.Button()
        Me.beliminar = New System.Windows.Forms.Button()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpfechaemision = New System.Windows.Forms.DateTimePicker()
        Me.dtpfechafinalizacion = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.mensaje = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tconsultor = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nsalario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 363)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre Completo del Contratante:"
        '
        'tnombre
        '
        Me.tnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tnombre.Location = New System.Drawing.Point(43, 381)
        Me.tnombre.Name = "tnombre"
        Me.tnombre.Size = New System.Drawing.Size(255, 20)
        Me.tnombre.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 418)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Salario a Asignar"
        '
        'tidentidad
        '
        Me.tidentidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tidentidad.Location = New System.Drawing.Point(43, 326)
        Me.tidentidad.Name = "tidentidad"
        Me.tidentidad.Size = New System.Drawing.Size(255, 20)
        Me.tidentidad.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 308)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Identidad del Contratante:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(200, 37)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(426, 24)
        Me.Label32.TabIndex = 560
        Me.Label32.Text = "Contrato Privado por Prestación de Servicios"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(45, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(141, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 559
        Me.PictureBox1.TabStop = False
        '
        'tnumcorrelativo
        '
        Me.tnumcorrelativo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tnumcorrelativo.Location = New System.Drawing.Point(43, 108)
        Me.tnumcorrelativo.Name = "tnumcorrelativo"
        Me.tnumcorrelativo.Size = New System.Drawing.Size(255, 20)
        Me.tnumcorrelativo.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 561
        Me.Label4.Text = "Num Correlativo:"
        '
        'nsalario
        '
        Me.nsalario.Location = New System.Drawing.Point(43, 439)
        Me.nsalario.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.nsalario.Name = "nsalario"
        Me.nsalario.Size = New System.Drawing.Size(120, 20)
        Me.nsalario.TabIndex = 563
        '
        'btadelante
        '
        Me.btadelante.BackColor = System.Drawing.Color.White
        Me.btadelante.BackgroundImage = CType(resources.GetObject("btadelante.BackgroundImage"), System.Drawing.Image)
        Me.btadelante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btadelante.Location = New System.Drawing.Point(342, 105)
        Me.btadelante.Name = "btadelante"
        Me.btadelante.Size = New System.Drawing.Size(28, 23)
        Me.btadelante.TabIndex = 567
        Me.btadelante.UseVisualStyleBackColor = False
        '
        'btatras
        '
        Me.btatras.BackColor = System.Drawing.Color.White
        Me.btatras.BackgroundImage = CType(resources.GetObject("btatras.BackgroundImage"), System.Drawing.Image)
        Me.btatras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btatras.Location = New System.Drawing.Point(313, 105)
        Me.btatras.Name = "btatras"
        Me.btatras.Size = New System.Drawing.Size(28, 23)
        Me.btatras.TabIndex = 566
        Me.btatras.UseVisualStyleBackColor = False
        '
        'bagregar
        '
        Me.bagregar.BackColor = System.Drawing.Color.Transparent
        Me.bagregar.BackgroundImage = CType(resources.GetObject("bagregar.BackgroundImage"), System.Drawing.Image)
        Me.bagregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bagregar.Location = New System.Drawing.Point(541, 90)
        Me.bagregar.Name = "bagregar"
        Me.bagregar.Size = New System.Drawing.Size(85, 76)
        Me.bagregar.TabIndex = 568
        Me.bagregar.UseVisualStyleBackColor = False
        '
        'beliminar
        '
        Me.beliminar.BackColor = System.Drawing.Color.Transparent
        Me.beliminar.BackgroundImage = CType(resources.GetObject("beliminar.BackgroundImage"), System.Drawing.Image)
        Me.beliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.beliminar.Location = New System.Drawing.Point(541, 169)
        Me.beliminar.Name = "beliminar"
        Me.beliminar.Size = New System.Drawing.Size(85, 76)
        Me.beliminar.TabIndex = 569
        Me.beliminar.UseVisualStyleBackColor = False
        '
        'btnlimpiar
        '
        Me.btnlimpiar.BackColor = System.Drawing.Color.White
        Me.btnlimpiar.BackgroundImage = CType(resources.GetObject("btnlimpiar.BackgroundImage"), System.Drawing.Image)
        Me.btnlimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnlimpiar.Location = New System.Drawing.Point(541, 249)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(85, 76)
        Me.btnlimpiar.TabIndex = 570
        Me.btnlimpiar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 571
        Me.Label5.Text = "Fecha Emisión:"
        '
        'dtpfechaemision
        '
        Me.dtpfechaemision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaemision.Location = New System.Drawing.Point(43, 157)
        Me.dtpfechaemision.Name = "dtpfechaemision"
        Me.dtpfechaemision.Size = New System.Drawing.Size(255, 20)
        Me.dtpfechaemision.TabIndex = 572
        '
        'dtpfechafinalizacion
        '
        Me.dtpfechafinalizacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechafinalizacion.Location = New System.Drawing.Point(45, 213)
        Me.dtpfechafinalizacion.Name = "dtpfechafinalizacion"
        Me.dtpfechafinalizacion.Size = New System.Drawing.Size(255, 20)
        Me.dtpfechafinalizacion.TabIndex = 574
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(43, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 13)
        Me.Label6.TabIndex = 573
        Me.Label6.Text = "Fecha Finalización:"
        '
        'mensaje
        '
        Me.mensaje.AutoSize = True
        Me.mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mensaje.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.mensaje.Location = New System.Drawing.Point(45, 471)
        Me.mensaje.Name = "mensaje"
        Me.mensaje.Size = New System.Drawing.Size(75, 16)
        Me.mensaje.TabIndex = 575
        Me.mensaje.Text = "Mensajes"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(38, 250)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 13)
        Me.Label7.TabIndex = 576
        Me.Label7.Text = "Tipo de Consultor:"
        '
        'tconsultor
        '
        Me.tconsultor.FormattingEnabled = True
        Me.tconsultor.Items.AddRange(New Object() {"OPERADORES DE EQUIPO"})
        Me.tconsultor.Location = New System.Drawing.Point(43, 267)
        Me.tconsultor.Name = "tconsultor"
        Me.tconsultor.Size = New System.Drawing.Size(254, 21)
        Me.tconsultor.TabIndex = 577
        '
        'FrmContPrivServicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(707, 517)
        Me.Controls.Add(Me.tconsultor)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.mensaje)
        Me.Controls.Add(Me.dtpfechafinalizacion)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtpfechaemision)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.beliminar)
        Me.Controls.Add(Me.bagregar)
        Me.Controls.Add(Me.btadelante)
        Me.Controls.Add(Me.btatras)
        Me.Controls.Add(Me.nsalario)
        Me.Controls.Add(Me.tnumcorrelativo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.tidentidad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tnombre)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmContPrivServicios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmContPrivServicios"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nsalario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tidentidad As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents tnumcorrelativo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents nsalario As System.Windows.Forms.NumericUpDown
    Friend WithEvents btadelante As System.Windows.Forms.Button
    Friend WithEvents btatras As System.Windows.Forms.Button
    Friend WithEvents bagregar As System.Windows.Forms.Button
    Friend WithEvents beliminar As System.Windows.Forms.Button
    Friend WithEvents btnlimpiar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaemision As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfechafinalizacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents mensaje As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tconsultor As System.Windows.Forms.ComboBox
End Class
