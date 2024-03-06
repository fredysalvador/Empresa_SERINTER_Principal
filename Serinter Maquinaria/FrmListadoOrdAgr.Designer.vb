<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListadoOrdAgr
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListadoOrdAgr))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tcriterio = New System.Windows.Forms.TextBox()
        Me.dgvinventario = New System.Windows.Forms.DataGridView()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.mensaje = New System.Windows.Forms.Label()
        Me.dgvreg = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.articulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Can_aprob = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bdatagrid = New System.Windows.Forms.Button()
        Me.bregresar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tnumsolici = New System.Windows.Forms.TextBox()
        Me.taprobad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.fechasolc = New System.Windows.Forms.DateTimePicker()
        Me.fechareq = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.bagregar = New System.Windows.Forms.Button()
        Me.beliminar = New System.Windows.Forms.Button()
        Me.tdepartament = New System.Windows.Forms.ComboBox()
        Me.bborrar = New System.Windows.Forms.Button()
        Me.btadelante = New System.Windows.Forms.Button()
        Me.btatras = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tproyectos = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tprioridad = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tobservacion = New System.Windows.Forms.TextBox()
        Me.dgvreg2 = New System.Windows.Forms.DataGridView()
        Me.id2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.articulo2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unidad2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.can_aprob2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tnombre = New System.Windows.Forms.TextBox()
        Me.tmaquinaria = New System.Windows.Forms.TextBox()
        Me.blimpiar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblestado = New System.Windows.Forms.Label()
        Me.chknvregistro = New System.Windows.Forms.CheckBox()
        Me.chkbxaceptartodo = New System.Windows.Forms.CheckBox()
        CType(Me.dgvinventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvreg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvreg2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(909, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(192, 24)
        Me.Label9.TabIndex = 399
        Me.Label9.Text = "Criterio de Busqueda:"
        '
        'tcriterio
        '
        Me.tcriterio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tcriterio.Location = New System.Drawing.Point(929, 101)
        Me.tcriterio.Name = "tcriterio"
        Me.tcriterio.Size = New System.Drawing.Size(155, 20)
        Me.tcriterio.TabIndex = 395
        '
        'dgvinventario
        '
        Me.dgvinventario.AllowUserToAddRows = False
        Me.dgvinventario.AllowUserToDeleteRows = False
        Me.dgvinventario.AllowUserToResizeColumns = False
        Me.dgvinventario.AllowUserToResizeRows = False
        Me.dgvinventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvinventario.Location = New System.Drawing.Point(87, 128)
        Me.dgvinventario.MultiSelect = False
        Me.dgvinventario.Name = "dgvinventario"
        Me.dgvinventario.ReadOnly = True
        Me.dgvinventario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvinventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvinventario.Size = New System.Drawing.Size(1019, 209)
        Me.dgvinventario.TabIndex = 387
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(202, 25)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(199, 24)
        Me.Label32.TabIndex = 389
        Me.Label32.Text = "Solicitud de Compra"
        '
        'mensaje
        '
        Me.mensaje.AutoSize = True
        Me.mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mensaje.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.mensaje.Location = New System.Drawing.Point(11, 612)
        Me.mensaje.Name = "mensaje"
        Me.mensaje.Size = New System.Drawing.Size(75, 16)
        Me.mensaje.TabIndex = 402
        Me.mensaje.Text = "Mensajes"
        '
        'dgvreg
        '
        Me.dgvreg.AllowUserToAddRows = False
        Me.dgvreg.AllowUserToDeleteRows = False
        Me.dgvreg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvreg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.item, Me.articulo, Me.descripcion, Me.unidad, Me.cantidad, Me.Can_aprob})
        Me.dgvreg.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvreg.Location = New System.Drawing.Point(378, 341)
        Me.dgvreg.Name = "dgvreg"
        Me.dgvreg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvreg.Size = New System.Drawing.Size(788, 129)
        Me.dgvreg.TabIndex = 490
        '
        'id
        '
        Me.id.HeaderText = "Id"
        Me.id.Name = "id"
        Me.id.Visible = False
        '
        'item
        '
        Me.item.HeaderText = "Item"
        Me.item.Name = "item"
        Me.item.Width = 40
        '
        'articulo
        '
        Me.articulo.HeaderText = "Articulo"
        Me.articulo.Name = "articulo"
        Me.articulo.ReadOnly = True
        Me.articulo.Width = 105
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "Descripcion del Producto"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Width = 380
        '
        'unidad
        '
        Me.unidad.HeaderText = "Unidad"
        Me.unidad.Name = "unidad"
        Me.unidad.Width = 74
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cantidad Solicitud"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.Width = 73
        '
        'Can_aprob
        '
        Me.Can_aprob.HeaderText = "Cantidad Aprobada"
        Me.Can_aprob.Name = "Can_aprob"
        Me.Can_aprob.ReadOnly = True
        Me.Can_aprob.Width = 73
        '
        'bdatagrid
        '
        Me.bdatagrid.BackgroundImage = CType(resources.GetObject("bdatagrid.BackgroundImage"), System.Drawing.Image)
        Me.bdatagrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bdatagrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bdatagrid.Location = New System.Drawing.Point(87, 63)
        Me.bdatagrid.Name = "bdatagrid"
        Me.bdatagrid.Size = New System.Drawing.Size(64, 63)
        Me.bdatagrid.TabIndex = 394
        Me.bdatagrid.UseVisualStyleBackColor = True
        '
        'bregresar
        '
        Me.bregresar.BackgroundImage = CType(resources.GetObject("bregresar.BackgroundImage"), System.Drawing.Image)
        Me.bregresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bregresar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bregresar.Location = New System.Drawing.Point(157, 63)
        Me.bregresar.Name = "bregresar"
        Me.bregresar.Size = New System.Drawing.Size(85, 63)
        Me.bregresar.TabIndex = 390
        Me.bregresar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(39, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(141, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 388
        Me.PictureBox1.TabStop = False
        '
        'tnumsolici
        '
        Me.tnumsolici.Enabled = False
        Me.tnumsolici.Location = New System.Drawing.Point(101, 392)
        Me.tnumsolici.Name = "tnumsolici"
        Me.tnumsolici.Size = New System.Drawing.Size(210, 20)
        Me.tnumsolici.TabIndex = 491
        '
        'taprobad
        '
        Me.taprobad.Location = New System.Drawing.Point(1035, 33)
        Me.taprobad.Name = "taprobad"
        Me.taprobad.Size = New System.Drawing.Size(210, 20)
        Me.taprobad.TabIndex = 493
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 395)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 495
        Me.Label1.Text = "Num. Solicitud:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 498)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 496
        Me.Label2.Text = "Departamento:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(953, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 497
        Me.Label3.Text = "Aprobada por:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(94, 347)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 498
        Me.Label4.Text = "Fecha de Solicitud:"
        '
        'fechasolc
        '
        Me.fechasolc.Enabled = False
        Me.fechasolc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechasolc.Location = New System.Drawing.Point(98, 363)
        Me.fechasolc.Name = "fechasolc"
        Me.fechasolc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fechasolc.Size = New System.Drawing.Size(101, 20)
        Me.fechasolc.TabIndex = 499
        '
        'fechareq
        '
        Me.fechareq.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechareq.Location = New System.Drawing.Point(215, 363)
        Me.fechareq.Name = "fechareq"
        Me.fechareq.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fechareq.Size = New System.Drawing.Size(101, 20)
        Me.fechareq.TabIndex = 501
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(198, 347)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 13)
        Me.Label5.TabIndex = 500
        Me.Label5.Text = "Fecha Requerida Mínima:"
        '
        'bagregar
        '
        Me.bagregar.BackgroundImage = CType(resources.GetObject("bagregar.BackgroundImage"), System.Drawing.Image)
        Me.bagregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bagregar.Location = New System.Drawing.Point(1172, 336)
        Me.bagregar.Name = "bagregar"
        Me.bagregar.Size = New System.Drawing.Size(75, 67)
        Me.bagregar.TabIndex = 504
        Me.bagregar.UseVisualStyleBackColor = True
        '
        'beliminar
        '
        Me.beliminar.BackColor = System.Drawing.Color.White
        Me.beliminar.BackgroundImage = CType(resources.GetObject("beliminar.BackgroundImage"), System.Drawing.Image)
        Me.beliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.beliminar.Location = New System.Drawing.Point(1172, 404)
        Me.beliminar.Name = "beliminar"
        Me.beliminar.Size = New System.Drawing.Size(75, 67)
        Me.beliminar.TabIndex = 505
        Me.beliminar.UseVisualStyleBackColor = False
        '
        'tdepartament
        '
        Me.tdepartament.FormattingEnabled = True
        Me.tdepartament.Items.AddRange(New Object() {"Mantenimiento", "Bodega"})
        Me.tdepartament.Location = New System.Drawing.Point(101, 495)
        Me.tdepartament.Name = "tdepartament"
        Me.tdepartament.Size = New System.Drawing.Size(210, 21)
        Me.tdepartament.TabIndex = 506
        '
        'bborrar
        '
        Me.bborrar.BackColor = System.Drawing.Color.White
        Me.bborrar.BackgroundImage = CType(resources.GetObject("bborrar.BackgroundImage"), System.Drawing.Image)
        Me.bborrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bborrar.Location = New System.Drawing.Point(1172, 472)
        Me.bborrar.Name = "bborrar"
        Me.bborrar.Size = New System.Drawing.Size(75, 67)
        Me.bborrar.TabIndex = 507
        Me.bborrar.UseVisualStyleBackColor = False
        '
        'btadelante
        '
        Me.btadelante.BackColor = System.Drawing.Color.White
        Me.btadelante.BackgroundImage = CType(resources.GetObject("btadelante.BackgroundImage"), System.Drawing.Image)
        Me.btadelante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btadelante.Location = New System.Drawing.Point(346, 390)
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
        Me.btatras.Location = New System.Drawing.Point(317, 390)
        Me.btatras.Name = "btatras"
        Me.btatras.Size = New System.Drawing.Size(28, 23)
        Me.btatras.TabIndex = 566
        Me.btatras.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 418)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 571
        Me.Label7.Text = "Equipo:"
        '
        'tproyectos
        '
        Me.tproyectos.FormattingEnabled = True
        Me.tproyectos.Location = New System.Drawing.Point(101, 441)
        Me.tproyectos.Name = "tproyectos"
        Me.tproyectos.Size = New System.Drawing.Size(210, 21)
        Me.tproyectos.TabIndex = 576
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(30, 444)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 575
        Me.Label10.Text = "Proyecto:"
        '
        'tprioridad
        '
        Me.tprioridad.FormattingEnabled = True
        Me.tprioridad.Items.AddRange(New Object() {"Baja", "Media", "Alta"})
        Me.tprioridad.Location = New System.Drawing.Point(101, 468)
        Me.tprioridad.Name = "tprioridad"
        Me.tprioridad.Size = New System.Drawing.Size(210, 21)
        Me.tprioridad.TabIndex = 578
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 470)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 13)
        Me.Label11.TabIndex = 577
        Me.Label11.Tag = ""
        Me.Label11.Text = "Tipo de Prioridad:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 526)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 580
        Me.Label8.Text = "Observaciones:"
        '
        'tobservacion
        '
        Me.tobservacion.Location = New System.Drawing.Point(15, 542)
        Me.tobservacion.Multiline = True
        Me.tobservacion.Name = "tobservacion"
        Me.tobservacion.Size = New System.Drawing.Size(323, 42)
        Me.tobservacion.TabIndex = 579
        '
        'dgvreg2
        '
        Me.dgvreg2.AllowUserToAddRows = False
        Me.dgvreg2.AllowUserToDeleteRows = False
        Me.dgvreg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvreg2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id2, Me.item2, Me.articulo2, Me.descripcion2, Me.unidad2, Me.cantidad2, Me.can_aprob2})
        Me.dgvreg2.Location = New System.Drawing.Point(378, 475)
        Me.dgvreg2.Name = "dgvreg2"
        Me.dgvreg2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvreg2.Size = New System.Drawing.Size(788, 130)
        Me.dgvreg2.TabIndex = 581
        '
        'id2
        '
        Me.id2.HeaderText = "Id"
        Me.id2.Name = "id2"
        Me.id2.Visible = False
        '
        'item2
        '
        Me.item2.HeaderText = "Item"
        Me.item2.Name = "item2"
        Me.item2.Width = 40
        '
        'articulo2
        '
        Me.articulo2.HeaderText = "Articulo"
        Me.articulo2.Name = "articulo2"
        Me.articulo2.ReadOnly = True
        Me.articulo2.Width = 105
        '
        'descripcion2
        '
        Me.descripcion2.HeaderText = "Descripcion del Producto"
        Me.descripcion2.Name = "descripcion2"
        Me.descripcion2.Width = 380
        '
        'unidad2
        '
        Me.unidad2.HeaderText = "Unidad"
        Me.unidad2.Name = "unidad2"
        Me.unidad2.Width = 74
        '
        'cantidad2
        '
        Me.cantidad2.HeaderText = "Cantidad Solicitud"
        Me.cantidad2.Name = "cantidad2"
        Me.cantidad2.Width = 73
        '
        'can_aprob2
        '
        Me.can_aprob2.HeaderText = "Cantidad Aprobada"
        Me.can_aprob2.Name = "can_aprob2"
        Me.can_aprob2.ReadOnly = True
        Me.can_aprob2.Width = 73
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(678, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 582
        Me.Label12.Text = "Label12"
        '
        'tnombre
        '
        Me.tnombre.Location = New System.Drawing.Point(776, 10)
        Me.tnombre.Name = "tnombre"
        Me.tnombre.Size = New System.Drawing.Size(100, 20)
        Me.tnombre.TabIndex = 583
        Me.tnombre.Text = "Fredy Salvador"
        '
        'tmaquinaria
        '
        Me.tmaquinaria.Location = New System.Drawing.Point(101, 416)
        Me.tmaquinaria.Name = "tmaquinaria"
        Me.tmaquinaria.Size = New System.Drawing.Size(210, 20)
        Me.tmaquinaria.TabIndex = 584
        '
        'blimpiar
        '
        Me.blimpiar.BackColor = System.Drawing.Color.White
        Me.blimpiar.BackgroundImage = CType(resources.GetObject("blimpiar.BackgroundImage"), System.Drawing.Image)
        Me.blimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.blimpiar.Location = New System.Drawing.Point(1172, 541)
        Me.blimpiar.Name = "blimpiar"
        Me.blimpiar.Size = New System.Drawing.Size(75, 67)
        Me.blimpiar.TabIndex = 585
        Me.blimpiar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1128, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 587
        Me.Label6.Text = "Estado:"
        '
        'lblestado
        '
        Me.lblestado.AutoSize = True
        Me.lblestado.Location = New System.Drawing.Point(1170, 134)
        Me.lblestado.Name = "lblestado"
        Me.lblestado.Size = New System.Drawing.Size(10, 13)
        Me.lblestado.TabIndex = 588
        Me.lblestado.Text = "."
        '
        'chknvregistro
        '
        Me.chknvregistro.AutoSize = True
        Me.chknvregistro.Location = New System.Drawing.Point(1131, 158)
        Me.chknvregistro.Name = "chknvregistro"
        Me.chknvregistro.Size = New System.Drawing.Size(100, 17)
        Me.chknvregistro.TabIndex = 589
        Me.chknvregistro.Text = "Nuevo Registro"
        Me.chknvregistro.UseVisualStyleBackColor = True
        '
        'chkbxaceptartodo
        '
        Me.chkbxaceptartodo.AutoSize = True
        Me.chkbxaceptartodo.Location = New System.Drawing.Point(1131, 313)
        Me.chkbxaceptartodo.Name = "chkbxaceptartodo"
        Me.chkbxaceptartodo.Size = New System.Drawing.Size(91, 17)
        Me.chkbxaceptartodo.TabIndex = 590
        Me.chkbxaceptartodo.Text = "Aprobar Todo"
        Me.chkbxaceptartodo.UseVisualStyleBackColor = True
        Me.chkbxaceptartodo.Visible = False
        '
        'FrmListadoOrdAgr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1259, 633)
        Me.Controls.Add(Me.chkbxaceptartodo)
        Me.Controls.Add(Me.chknvregistro)
        Me.Controls.Add(Me.lblestado)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.blimpiar)
        Me.Controls.Add(Me.tmaquinaria)
        Me.Controls.Add(Me.tnombre)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.dgvreg2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tobservacion)
        Me.Controls.Add(Me.tprioridad)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tproyectos)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btadelante)
        Me.Controls.Add(Me.btatras)
        Me.Controls.Add(Me.bborrar)
        Me.Controls.Add(Me.tdepartament)
        Me.Controls.Add(Me.beliminar)
        Me.Controls.Add(Me.bagregar)
        Me.Controls.Add(Me.fechareq)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.fechasolc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.taprobad)
        Me.Controls.Add(Me.tnumsolici)
        Me.Controls.Add(Me.dgvreg)
        Me.Controls.Add(Me.mensaje)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tcriterio)
        Me.Controls.Add(Me.bdatagrid)
        Me.Controls.Add(Me.dgvinventario)
        Me.Controls.Add(Me.bregresar)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmListadoOrdAgr"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmListadoOrdAgr"
        CType(Me.dgvinventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvreg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvreg2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tcriterio As System.Windows.Forms.TextBox
    Friend WithEvents bdatagrid As System.Windows.Forms.Button
    Friend WithEvents dgvinventario As System.Windows.Forms.DataGridView
    Friend WithEvents bregresar As System.Windows.Forms.Button
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents mensaje As System.Windows.Forms.Label
    Friend WithEvents dgvreg As System.Windows.Forms.DataGridView
    Friend WithEvents tnumsolici As System.Windows.Forms.TextBox
    Friend WithEvents taprobad As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents fechasolc As System.Windows.Forms.DateTimePicker
    Friend WithEvents fechareq As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents bagregar As System.Windows.Forms.Button
    Friend WithEvents beliminar As System.Windows.Forms.Button
    Friend WithEvents tdepartament As System.Windows.Forms.ComboBox
    Friend WithEvents bborrar As System.Windows.Forms.Button
    Friend WithEvents btadelante As System.Windows.Forms.Button
    Friend WithEvents btatras As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tproyectos As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tprioridad As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tobservacion As System.Windows.Forms.TextBox
    Friend WithEvents dgvreg2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tnombre As System.Windows.Forms.TextBox
    Friend WithEvents tmaquinaria As System.Windows.Forms.TextBox
    Friend WithEvents blimpiar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblestado As System.Windows.Forms.Label
    Friend WithEvents chknvregistro As System.Windows.Forms.CheckBox
    Friend WithEvents chkbxaceptartodo As System.Windows.Forms.CheckBox
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents articulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Can_aprob As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents articulo2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unidad2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents can_aprob2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
