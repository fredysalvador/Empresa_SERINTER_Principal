<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInventariado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInventariado))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.codp2 = New System.Windows.Forms.TextBox()
        Me.tnombre = New System.Windows.Forms.TextBox()
        Me.tobservaciones = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ccategoria = New System.Windows.Forms.ComboBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.dgvinventario = New System.Windows.Forms.DataGridView()
        Me.codp1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tproveedor = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cstock = New System.Windows.Forms.NumericUpDown()
        Me.tprecio = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ccampos = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tcriterio = New System.Windows.Forms.TextBox()
        Me.cubicacion = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.mensaje = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bformato = New System.Windows.Forms.Button()
        Me.biniciar = New System.Windows.Forms.Button()
        Me.pfototomar = New System.Windows.Forms.PictureBox()
        Me.bguardar2 = New System.Windows.Forms.Button()
        Me.pfoto2 = New System.Windows.Forms.PictureBox()
        Me.bguardar = New System.Windows.Forms.Button()
        Me.pfoto = New System.Windows.Forms.PictureBox()
        Me.blimpieza = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.bdatagrid = New System.Windows.Forms.Button()
        Me.breiniciar = New System.Windows.Forms.Button()
        Me.beliminar = New System.Windows.Forms.Button()
        Me.bagregar = New System.Windows.Forms.Button()
        Me.bregresar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvinventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cstock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pfototomar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pfoto2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pfoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nombre de Producto:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Codigo Producto:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Categoria:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 162)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Observaciones:"
        '
        'codp2
        '
        Me.codp2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.codp2.Location = New System.Drawing.Point(121, 28)
        Me.codp2.Name = "codp2"
        Me.codp2.Size = New System.Drawing.Size(225, 20)
        Me.codp2.TabIndex = 1
        '
        'tnombre
        '
        Me.tnombre.Location = New System.Drawing.Point(121, 54)
        Me.tnombre.Name = "tnombre"
        Me.tnombre.Size = New System.Drawing.Size(263, 20)
        Me.tnombre.TabIndex = 14
        '
        'tobservaciones
        '
        Me.tobservaciones.Location = New System.Drawing.Point(121, 159)
        Me.tobservaciones.Name = "tobservaciones"
        Me.tobservaciones.Size = New System.Drawing.Size(263, 20)
        Me.tobservaciones.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 136)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Proveedor:"
        '
        'ccategoria
        '
        Me.ccategoria.FormattingEnabled = True
        Me.ccategoria.Items.AddRange(New Object() {"MATERIAL DE CONSTRUCCIÓN", "HERRAMIENTA DE MANTENIMIENTO", "REPUESTOS", "OBJETO DE LIMPIEZA", "OBJETO DE OFICINA", "TUBERIA", "ELECTRICIDAD", "SEGURIDAD", "FONTANERIA", "LUBRICANTES", "COMBISTIBLE", "LLANTAS", "OTROS"})
        Me.ccategoria.Location = New System.Drawing.Point(121, 79)
        Me.ccategoria.Name = "ccategoria"
        Me.ccategoria.Size = New System.Drawing.Size(263, 21)
        Me.ccategoria.TabIndex = 26
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(176, 37)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(181, 24)
        Me.Label32.TabIndex = 332
        Me.Label32.Text = "Inventario General"
        '
        'dgvinventario
        '
        Me.dgvinventario.AllowUserToAddRows = False
        Me.dgvinventario.AllowUserToDeleteRows = False
        Me.dgvinventario.AllowUserToResizeColumns = False
        Me.dgvinventario.AllowUserToResizeRows = False
        Me.dgvinventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvinventario.Location = New System.Drawing.Point(436, 192)
        Me.dgvinventario.MultiSelect = False
        Me.dgvinventario.Name = "dgvinventario"
        Me.dgvinventario.ReadOnly = True
        Me.dgvinventario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvinventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvinventario.Size = New System.Drawing.Size(815, 472)
        Me.dgvinventario.TabIndex = 0
        '
        'codp1
        '
        Me.codp1.FormattingEnabled = True
        Me.codp1.Items.AddRange(New Object() {"A", "B", "C"})
        Me.codp1.Location = New System.Drawing.Point(352, 28)
        Me.codp1.Name = "codp1"
        Me.codp1.Size = New System.Drawing.Size(32, 21)
        Me.codp1.TabIndex = 339
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(264, 318)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 347
        Me.Label2.Text = "Guardar Imagen #1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(268, 526)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 350
        Me.Label4.Text = "Guardar Imagen #2"
        '
        'tproveedor
        '
        Me.tproveedor.FormattingEnabled = True
        Me.tproveedor.Location = New System.Drawing.Point(121, 132)
        Me.tproveedor.Name = "tproveedor"
        Me.tproveedor.Size = New System.Drawing.Size(263, 21)
        Me.tproveedor.TabIndex = 351
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 353
        Me.Label5.Text = "Stock:"
        '
        'cstock
        '
        Me.cstock.Location = New System.Drawing.Point(121, 211)
        Me.cstock.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.cstock.Name = "cstock"
        Me.cstock.Size = New System.Drawing.Size(89, 20)
        Me.cstock.TabIndex = 354
        '
        'tprecio
        '
        Me.tprecio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tprecio.Location = New System.Drawing.Point(121, 185)
        Me.tprecio.Name = "tprecio"
        Me.tprecio.Size = New System.Drawing.Size(89, 20)
        Me.tprecio.TabIndex = 362
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 361
        Me.Label6.Text = "Precio:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label10.Location = New System.Drawing.Point(899, 101)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 24)
        Me.Label10.TabIndex = 382
        Me.Label10.Text = "Limpiar"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(868, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(192, 24)
        Me.Label9.TabIndex = 380
        Me.Label9.Text = "Criterio de Busqueda:"
        '
        'ccampos
        '
        Me.ccampos.FormattingEnabled = True
        Me.ccampos.Items.AddRange(New Object() {"codigop", "prefijo", "nom_prod", "categoria", "ubicacion"})
        Me.ccampos.Location = New System.Drawing.Point(1066, 66)
        Me.ccampos.Name = "ccampos"
        Me.ccampos.Size = New System.Drawing.Size(174, 21)
        Me.ccampos.TabIndex = 379
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label12.Location = New System.Drawing.Point(985, 101)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 24)
        Me.Label12.TabIndex = 378
        Me.Label12.Text = "Buscar"
        '
        'tcriterio
        '
        Me.tcriterio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tcriterio.Location = New System.Drawing.Point(1085, 147)
        Me.tcriterio.Name = "tcriterio"
        Me.tcriterio.Size = New System.Drawing.Size(155, 20)
        Me.tcriterio.TabIndex = 376
        '
        'cubicacion
        '
        Me.cubicacion.FormattingEnabled = True
        Me.cubicacion.Location = New System.Drawing.Point(121, 105)
        Me.cubicacion.Name = "cubicacion"
        Me.cubicacion.Size = New System.Drawing.Size(263, 21)
        Me.cubicacion.TabIndex = 384
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(13, 109)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 13)
        Me.Label13.TabIndex = 383
        Me.Label13.Text = "Ubicación Fisica:"
        '
        'mensaje
        '
        Me.mensaje.AutoSize = True
        Me.mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mensaje.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.mensaje.Location = New System.Drawing.Point(7, 570)
        Me.mensaje.Name = "mensaje"
        Me.mensaje.Size = New System.Drawing.Size(75, 16)
        Me.mensaje.TabIndex = 385
        Me.mensaje.Text = "Mensajes"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cubicacion)
        Me.GroupBox1.Controls.Add(Me.mensaje)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.tprecio)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.bformato)
        Me.GroupBox1.Controls.Add(Me.biniciar)
        Me.GroupBox1.Controls.Add(Me.pfototomar)
        Me.GroupBox1.Controls.Add(Me.cstock)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tproveedor)
        Me.GroupBox1.Controls.Add(Me.bguardar2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.pfoto2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.bguardar)
        Me.GroupBox1.Controls.Add(Me.pfoto)
        Me.GroupBox1.Controls.Add(Me.codp1)
        Me.GroupBox1.Controls.Add(Me.ccategoria)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.tobservaciones)
        Me.GroupBox1.Controls.Add(Me.tnombre)
        Me.GroupBox1.Controls.Add(Me.codp2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(411, 597)
        Me.GroupBox1.TabIndex = 386
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Generales Inventario"
        '
        'bformato
        '
        Me.bformato.BackColor = System.Drawing.Color.White
        Me.bformato.BackgroundImage = CType(resources.GetObject("bformato.BackgroundImage"), System.Drawing.Image)
        Me.bformato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bformato.Location = New System.Drawing.Point(82, 483)
        Me.bformato.Name = "bformato"
        Me.bformato.Size = New System.Drawing.Size(67, 63)
        Me.bformato.TabIndex = 360
        Me.bformato.UseVisualStyleBackColor = False
        '
        'biniciar
        '
        Me.biniciar.BackColor = System.Drawing.Color.White
        Me.biniciar.BackgroundImage = CType(resources.GetObject("biniciar.BackgroundImage"), System.Drawing.Image)
        Me.biniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.biniciar.Location = New System.Drawing.Point(9, 483)
        Me.biniciar.Name = "biniciar"
        Me.biniciar.Size = New System.Drawing.Size(67, 63)
        Me.biniciar.TabIndex = 358
        Me.biniciar.UseVisualStyleBackColor = False
        '
        'pfototomar
        '
        Me.pfototomar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pfototomar.Location = New System.Drawing.Point(9, 269)
        Me.pfototomar.Name = "pfototomar"
        Me.pfototomar.Size = New System.Drawing.Size(192, 208)
        Me.pfototomar.TabIndex = 357
        Me.pfototomar.TabStop = False
        '
        'bguardar2
        '
        Me.bguardar2.BackColor = System.Drawing.Color.White
        Me.bguardar2.BackgroundImage = CType(resources.GetObject("bguardar2.BackgroundImage"), System.Drawing.Image)
        Me.bguardar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bguardar2.Location = New System.Drawing.Point(282, 542)
        Me.bguardar2.Name = "bguardar2"
        Me.bguardar2.Size = New System.Drawing.Size(56, 51)
        Me.bguardar2.TabIndex = 349
        Me.bguardar2.UseVisualStyleBackColor = False
        '
        'pfoto2
        '
        Me.pfoto2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pfoto2.Location = New System.Drawing.Point(245, 391)
        Me.pfoto2.Name = "pfoto2"
        Me.pfoto2.Size = New System.Drawing.Size(139, 128)
        Me.pfoto2.TabIndex = 348
        Me.pfoto2.TabStop = False
        '
        'bguardar
        '
        Me.bguardar.BackColor = System.Drawing.Color.White
        Me.bguardar.BackgroundImage = CType(resources.GetObject("bguardar.BackgroundImage"), System.Drawing.Image)
        Me.bguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bguardar.Location = New System.Drawing.Point(280, 334)
        Me.bguardar.Name = "bguardar"
        Me.bguardar.Size = New System.Drawing.Size(56, 51)
        Me.bguardar.TabIndex = 341
        Me.bguardar.UseVisualStyleBackColor = False
        '
        'pfoto
        '
        Me.pfoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pfoto.Location = New System.Drawing.Point(245, 184)
        Me.pfoto.Name = "pfoto"
        Me.pfoto.Size = New System.Drawing.Size(139, 128)
        Me.pfoto.TabIndex = 340
        Me.pfoto.TabStop = False
        '
        'blimpieza
        '
        Me.blimpieza.BackColor = System.Drawing.Color.White
        Me.blimpieza.BackgroundImage = CType(resources.GetObject("blimpieza.BackgroundImage"), System.Drawing.Image)
        Me.blimpieza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.blimpieza.Location = New System.Drawing.Point(903, 128)
        Me.blimpieza.Name = "blimpieza"
        Me.blimpieza.Size = New System.Drawing.Size(64, 56)
        Me.blimpieza.TabIndex = 381
        Me.blimpieza.UseVisualStyleBackColor = False
        '
        'btnbuscar
        '
        Me.btnbuscar.BackColor = System.Drawing.Color.White
        Me.btnbuscar.BackgroundImage = CType(resources.GetObject("btnbuscar.BackgroundImage"), System.Drawing.Image)
        Me.btnbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscar.Location = New System.Drawing.Point(989, 128)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(64, 56)
        Me.btnbuscar.TabIndex = 377
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'bdatagrid
        '
        Me.bdatagrid.BackgroundImage = CType(resources.GetObject("bdatagrid.BackgroundImage"), System.Drawing.Image)
        Me.bdatagrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bdatagrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bdatagrid.Location = New System.Drawing.Point(653, 121)
        Me.bdatagrid.Name = "bdatagrid"
        Me.bdatagrid.Size = New System.Drawing.Size(64, 63)
        Me.bdatagrid.TabIndex = 352
        Me.bdatagrid.UseVisualStyleBackColor = True
        '
        'breiniciar
        '
        Me.breiniciar.BackColor = System.Drawing.Color.White
        Me.breiniciar.BackgroundImage = CType(resources.GetObject("breiniciar.BackgroundImage"), System.Drawing.Image)
        Me.breiniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.breiniciar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.breiniciar.Location = New System.Drawing.Point(583, 121)
        Me.breiniciar.Name = "breiniciar"
        Me.breiniciar.Size = New System.Drawing.Size(64, 63)
        Me.breiniciar.TabIndex = 344
        Me.breiniciar.UseVisualStyleBackColor = False
        '
        'beliminar
        '
        Me.beliminar.BackgroundImage = CType(resources.GetObject("beliminar.BackgroundImage"), System.Drawing.Image)
        Me.beliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.beliminar.Enabled = False
        Me.beliminar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.beliminar.Location = New System.Drawing.Point(513, 121)
        Me.beliminar.Name = "beliminar"
        Me.beliminar.Size = New System.Drawing.Size(64, 63)
        Me.beliminar.TabIndex = 343
        Me.beliminar.UseVisualStyleBackColor = True
        '
        'bagregar
        '
        Me.bagregar.BackgroundImage = CType(resources.GetObject("bagregar.BackgroundImage"), System.Drawing.Image)
        Me.bagregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bagregar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bagregar.Location = New System.Drawing.Point(443, 121)
        Me.bagregar.Name = "bagregar"
        Me.bagregar.Size = New System.Drawing.Size(64, 63)
        Me.bagregar.TabIndex = 342
        Me.bagregar.UseVisualStyleBackColor = True
        '
        'bregresar
        '
        Me.bregresar.BackgroundImage = CType(resources.GetObject("bregresar.BackgroundImage"), System.Drawing.Image)
        Me.bregresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bregresar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bregresar.Location = New System.Drawing.Point(795, 121)
        Me.bregresar.Name = "bregresar"
        Me.bregresar.Size = New System.Drawing.Size(85, 63)
        Me.bregresar.TabIndex = 333
        Me.bregresar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(12, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(141, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 331
        Me.PictureBox1.TabStop = False
        '
        'FrmInventariado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1263, 678)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.blimpieza)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ccampos)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.tcriterio)
        Me.Controls.Add(Me.bdatagrid)
        Me.Controls.Add(Me.breiniciar)
        Me.Controls.Add(Me.beliminar)
        Me.Controls.Add(Me.bagregar)
        Me.Controls.Add(Me.dgvinventario)
        Me.Controls.Add(Me.bregresar)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmInventariado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvinventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cstock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pfototomar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pfoto2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pfoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents codp2 As System.Windows.Forms.TextBox
    Friend WithEvents tnombre As System.Windows.Forms.TextBox
    Friend WithEvents tobservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ccategoria As System.Windows.Forms.ComboBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents bregresar As System.Windows.Forms.Button
    Friend WithEvents dgvinventario As System.Windows.Forms.DataGridView
    Friend WithEvents codp1 As System.Windows.Forms.ComboBox
    Friend WithEvents pfoto As System.Windows.Forms.PictureBox
    Friend WithEvents bguardar As System.Windows.Forms.Button
    Friend WithEvents breiniciar As System.Windows.Forms.Button
    Friend WithEvents beliminar As System.Windows.Forms.Button
    Friend WithEvents bagregar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents bguardar2 As System.Windows.Forms.Button
    Friend WithEvents pfoto2 As System.Windows.Forms.PictureBox
    Friend WithEvents tproveedor As System.Windows.Forms.ComboBox
    Friend WithEvents bdatagrid As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cstock As System.Windows.Forms.NumericUpDown
    Friend WithEvents pfototomar As System.Windows.Forms.PictureBox
    Friend WithEvents biniciar As System.Windows.Forms.Button
    Friend WithEvents bformato As System.Windows.Forms.Button
    Friend WithEvents tprecio As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents blimpieza As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ccampos As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents tcriterio As System.Windows.Forms.TextBox
    Friend WithEvents cubicacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents mensaje As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
