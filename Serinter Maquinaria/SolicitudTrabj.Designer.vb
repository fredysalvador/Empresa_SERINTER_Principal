<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SolicitudTrabj
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SolicitudTrabj))
        Me.chknvregistro = New System.Windows.Forms.CheckBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.descp1env = New System.Windows.Forms.TextBox()
        Me.mensaje = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cestadpase = New System.Windows.Forms.ComboBox()
        Me.tvacio = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.dgvreg = New System.Windows.Forms.DataGridView()
        Me.id1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cant1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.npart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodSert = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.categoria = New System.Windows.Forms.ComboBox()
        Me.nosolicitud = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tproyecto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.codigovh = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvvehiculos = New System.Windows.Forms.DataGridView()
        Me.tcriterio2 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ccampos2 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvreg2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bagregadogeneral = New System.Windows.Forms.Button()
        Me.bimprimir = New System.Windows.Forms.Button()
        Me.bregresar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pfoto4 = New System.Windows.Forms.PictureBox()
        Me.pfoto3 = New System.Windows.Forms.PictureBox()
        Me.breiniciar = New System.Windows.Forms.Button()
        Me.beliminar = New System.Windows.Forms.Button()
        Me.bagregar = New System.Windows.Forms.Button()
        Me.blimpieza2 = New System.Windows.Forms.Button()
        Me.btnbuscar2 = New System.Windows.Forms.Button()
        Me.bdatagridveh = New System.Windows.Forms.Button()
        Me.bagrlista2 = New System.Windows.Forms.Button()
        Me.beliminarreg = New System.Windows.Forms.Button()
        Me.tsolicitante = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tnompart = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tunt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tcodsert = New System.Windows.Forms.TextBox()
        Me.num1un = New System.Windows.Forms.NumericUpDown()
        Me.fechaSolc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dgvreg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvvehiculos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvreg2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pfoto4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pfoto3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num1un, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chknvregistro
        '
        Me.chknvregistro.AutoSize = True
        Me.chknvregistro.Location = New System.Drawing.Point(339, 74)
        Me.chknvregistro.Name = "chknvregistro"
        Me.chknvregistro.Size = New System.Drawing.Size(100, 17)
        Me.chknvregistro.TabIndex = 577
        Me.chknvregistro.Text = "Nuevo Registro"
        Me.chknvregistro.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(522, 88)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(66, 13)
        Me.Label27.TabIndex = 576
        Me.Label27.Text = "Descripcion:"
        '
        'descp1env
        '
        Me.descp1env.Location = New System.Drawing.Point(604, 84)
        Me.descp1env.Name = "descp1env"
        Me.descp1env.Size = New System.Drawing.Size(150, 20)
        Me.descp1env.TabIndex = 573
        '
        'mensaje
        '
        Me.mensaje.AutoSize = True
        Me.mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mensaje.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.mensaje.Location = New System.Drawing.Point(364, 647)
        Me.mensaje.Name = "mensaje"
        Me.mensaje.Size = New System.Drawing.Size(75, 16)
        Me.mensaje.TabIndex = 571
        Me.mensaje.Text = "Mensajes"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(343, 118)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(88, 13)
        Me.Label25.TabIndex = 570
        Me.Label25.Text = "Estado de salida:"
        '
        'cestadpase
        '
        Me.cestadpase.Enabled = False
        Me.cestadpase.FormattingEnabled = True
        Me.cestadpase.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.cestadpase.Location = New System.Drawing.Point(346, 142)
        Me.cestadpase.Name = "cestadpase"
        Me.cestadpase.Size = New System.Drawing.Size(79, 21)
        Me.cestadpase.TabIndex = 569
        '
        'tvacio
        '
        Me.tvacio.Location = New System.Drawing.Point(798, 7)
        Me.tvacio.Name = "tvacio"
        Me.tvacio.Size = New System.Drawing.Size(100, 20)
        Me.tvacio.TabIndex = 494
        Me.tvacio.Visible = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(176, 27)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(197, 24)
        Me.Label32.TabIndex = 560
        Me.Label32.Text = "Solicitud de Trabajo"
        '
        'dgvreg
        '
        Me.dgvreg.AllowUserToAddRows = False
        Me.dgvreg.AllowUserToDeleteRows = False
        Me.dgvreg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvreg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id1, Me.item, Me.cant1, Me.unidad, Me.npart, Me.CodSert, Me.descripcion})
        Me.dgvreg.Location = New System.Drawing.Point(18, 237)
        Me.dgvreg.MultiSelect = False
        Me.dgvreg.Name = "dgvreg"
        Me.dgvreg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvreg.Size = New System.Drawing.Size(855, 153)
        Me.dgvreg.TabIndex = 493
        '
        'id1
        '
        Me.id1.HeaderText = "id"
        Me.id1.Name = "id1"
        Me.id1.Visible = False
        '
        'item
        '
        Me.item.HeaderText = "item"
        Me.item.Name = "item"
        Me.item.ReadOnly = True
        Me.item.Width = 60
        '
        'cant1
        '
        Me.cant1.HeaderText = "cantidad"
        Me.cant1.Name = "cant1"
        '
        'unidad
        '
        Me.unidad.HeaderText = "unidad"
        Me.unidad.Name = "unidad"
        Me.unidad.ReadOnly = True
        '
        'npart
        '
        Me.npart.HeaderText = "numero de parte"
        Me.npart.Name = "npart"
        Me.npart.Width = 160
        '
        'CodSert
        '
        Me.CodSert.HeaderText = "codigo serinter"
        Me.CodSert.Name = "CodSert"
        Me.CodSert.Width = 115
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "descripcion"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Width = 280
        '
        'categoria
        '
        Me.categoria.FormattingEnabled = True
        Me.categoria.Items.AddRange(New Object() {"Salida Inventario", "Salida Personal", "Salida Maquinaria", "Salida Tecnica", "Salida Renta", "Salida Compras", "Salida Acarreo"})
        Me.categoria.Location = New System.Drawing.Point(130, 151)
        Me.categoria.Name = "categoria"
        Me.categoria.Size = New System.Drawing.Size(192, 21)
        Me.categoria.TabIndex = 533
        '
        'nosolicitud
        '
        Me.nosolicitud.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.nosolicitud.Location = New System.Drawing.Point(130, 99)
        Me.nosolicitud.Name = "nosolicitud"
        Me.nosolicitud.Size = New System.Drawing.Size(192, 20)
        Me.nosolicitud.TabIndex = 497
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(18, 104)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(105, 13)
        Me.Label14.TabIndex = 530
        Me.Label14.Text = "Numero de Solicitud:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(68, 158)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 13)
        Me.Label12.TabIndex = 510
        Me.Label12.Text = "Categoria:"
        '
        'tproyecto
        '
        Me.tproyecto.Location = New System.Drawing.Point(129, 203)
        Me.tproyecto.Name = "tproyecto"
        Me.tproyecto.Size = New System.Drawing.Size(192, 20)
        Me.tproyecto.TabIndex = 509
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(71, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 508
        Me.Label5.Text = "Proyecto:"
        '
        'codigovh
        '
        Me.codigovh.Enabled = False
        Me.codigovh.Location = New System.Drawing.Point(130, 125)
        Me.codigovh.Name = "codigovh"
        Me.codigovh.Size = New System.Drawing.Size(192, 20)
        Me.codigovh.TabIndex = 496
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 495
        Me.Label1.Text = "Codigo Vehiculo:"
        '
        'dgvvehiculos
        '
        Me.dgvvehiculos.AllowUserToAddRows = False
        Me.dgvvehiculos.AllowUserToDeleteRows = False
        Me.dgvvehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvvehiculos.Location = New System.Drawing.Point(914, 85)
        Me.dgvvehiculos.MultiSelect = False
        Me.dgvvehiculos.Name = "dgvvehiculos"
        Me.dgvvehiculos.ReadOnly = True
        Me.dgvvehiculos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvvehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvvehiculos.Size = New System.Drawing.Size(350, 127)
        Me.dgvvehiculos.TabIndex = 532
        Me.dgvvehiculos.Visible = False
        '
        'tcriterio2
        '
        Me.tcriterio2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tcriterio2.Enabled = False
        Me.tcriterio2.Location = New System.Drawing.Point(1108, 299)
        Me.tcriterio2.Name = "tcriterio2"
        Me.tcriterio2.Size = New System.Drawing.Size(108, 20)
        Me.tcriterio2.TabIndex = 547
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label13.Location = New System.Drawing.Point(1008, 253)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 24)
        Me.Label13.TabIndex = 549
        Me.Label13.Text = "Buscar"
        '
        'ccampos2
        '
        Me.ccampos2.Enabled = False
        Me.ccampos2.FormattingEnabled = True
        Me.ccampos2.Items.AddRange(New Object() {"codigo_vh  ", "placa_vh", "estado_vh"})
        Me.ccampos2.Location = New System.Drawing.Point(1108, 225)
        Me.ccampos2.Name = "ccampos2"
        Me.ccampos2.Size = New System.Drawing.Size(108, 21)
        Me.ccampos2.TabIndex = 550
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(910, 222)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(192, 24)
        Me.Label8.TabIndex = 551
        Me.Label8.Text = "Criterio de Busqueda:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label7.Location = New System.Drawing.Point(922, 253)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 24)
        Me.Label7.TabIndex = 553
        Me.Label7.Text = "Limpiar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(529, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 579
        Me.Label2.Text = "Cantidad:"
        '
        'dgvreg2
        '
        Me.dgvreg2.AllowUserToAddRows = False
        Me.dgvreg2.AllowUserToDeleteRows = False
        Me.dgvreg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvreg2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.dgvreg2.Location = New System.Drawing.Point(18, 407)
        Me.dgvreg2.MultiSelect = False
        Me.dgvreg2.Name = "dgvreg2"
        Me.dgvreg2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvreg2.Size = New System.Drawing.Size(855, 153)
        Me.dgvreg2.TabIndex = 580
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "item"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 60
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "cantidad"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "unidad"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "numero de parte"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 160
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "codigo serinter"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 115
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "descripcion"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 280
        '
        'bagregadogeneral
        '
        Me.bagregadogeneral.BackColor = System.Drawing.Color.White
        Me.bagregadogeneral.BackgroundImage = CType(resources.GetObject("bagregadogeneral.BackgroundImage"), System.Drawing.Image)
        Me.bagregadogeneral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bagregadogeneral.Location = New System.Drawing.Point(631, 12)
        Me.bagregadogeneral.Name = "bagregadogeneral"
        Me.bagregadogeneral.Size = New System.Drawing.Size(64, 63)
        Me.bagregadogeneral.TabIndex = 572
        Me.bagregadogeneral.UseVisualStyleBackColor = False
        '
        'bimprimir
        '
        Me.bimprimir.BackColor = System.Drawing.Color.White
        Me.bimprimir.BackgroundImage = CType(resources.GetObject("bimprimir.BackgroundImage"), System.Drawing.Image)
        Me.bimprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bimprimir.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bimprimir.Location = New System.Drawing.Point(284, 600)
        Me.bimprimir.Name = "bimprimir"
        Me.bimprimir.Size = New System.Drawing.Size(64, 63)
        Me.bimprimir.TabIndex = 562
        Me.bimprimir.UseVisualStyleBackColor = False
        '
        'bregresar
        '
        Me.bregresar.BackgroundImage = CType(resources.GetObject("bregresar.BackgroundImage"), System.Drawing.Image)
        Me.bregresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bregresar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bregresar.Location = New System.Drawing.Point(1184, 10)
        Me.bregresar.Name = "bregresar"
        Me.bregresar.Size = New System.Drawing.Size(86, 63)
        Me.bregresar.TabIndex = 561
        Me.bregresar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(18, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(141, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 559
        Me.PictureBox1.TabStop = False
        '
        'pfoto4
        '
        Me.pfoto4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pfoto4.Location = New System.Drawing.Point(996, 526)
        Me.pfoto4.Name = "pfoto4"
        Me.pfoto4.Size = New System.Drawing.Size(220, 140)
        Me.pfoto4.TabIndex = 558
        Me.pfoto4.TabStop = False
        '
        'pfoto3
        '
        Me.pfoto3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pfoto3.Location = New System.Drawing.Point(996, 374)
        Me.pfoto3.Name = "pfoto3"
        Me.pfoto3.Size = New System.Drawing.Size(220, 140)
        Me.pfoto3.TabIndex = 557
        Me.pfoto3.TabStop = False
        '
        'breiniciar
        '
        Me.breiniciar.BackColor = System.Drawing.Color.White
        Me.breiniciar.BackgroundImage = CType(resources.GetObject("breiniciar.BackgroundImage"), System.Drawing.Image)
        Me.breiniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.breiniciar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.breiniciar.Location = New System.Drawing.Point(214, 600)
        Me.breiniciar.Name = "breiniciar"
        Me.breiniciar.Size = New System.Drawing.Size(64, 63)
        Me.breiniciar.TabIndex = 556
        Me.breiniciar.UseVisualStyleBackColor = False
        '
        'beliminar
        '
        Me.beliminar.BackgroundImage = CType(resources.GetObject("beliminar.BackgroundImage"), System.Drawing.Image)
        Me.beliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.beliminar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.beliminar.Location = New System.Drawing.Point(144, 600)
        Me.beliminar.Name = "beliminar"
        Me.beliminar.Size = New System.Drawing.Size(64, 63)
        Me.beliminar.TabIndex = 555
        Me.beliminar.UseVisualStyleBackColor = True
        '
        'bagregar
        '
        Me.bagregar.BackgroundImage = CType(resources.GetObject("bagregar.BackgroundImage"), System.Drawing.Image)
        Me.bagregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bagregar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bagregar.Location = New System.Drawing.Point(74, 600)
        Me.bagregar.Name = "bagregar"
        Me.bagregar.Size = New System.Drawing.Size(64, 63)
        Me.bagregar.TabIndex = 554
        Me.bagregar.UseVisualStyleBackColor = True
        '
        'blimpieza2
        '
        Me.blimpieza2.BackColor = System.Drawing.Color.White
        Me.blimpieza2.BackgroundImage = CType(resources.GetObject("blimpieza2.BackgroundImage"), System.Drawing.Image)
        Me.blimpieza2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.blimpieza2.Location = New System.Drawing.Point(926, 280)
        Me.blimpieza2.Name = "blimpieza2"
        Me.blimpieza2.Size = New System.Drawing.Size(64, 56)
        Me.blimpieza2.TabIndex = 552
        Me.blimpieza2.UseVisualStyleBackColor = False
        '
        'btnbuscar2
        '
        Me.btnbuscar2.BackColor = System.Drawing.Color.White
        Me.btnbuscar2.BackgroundImage = CType(resources.GetObject("btnbuscar2.BackgroundImage"), System.Drawing.Image)
        Me.btnbuscar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscar2.Enabled = False
        Me.btnbuscar2.Location = New System.Drawing.Point(1012, 280)
        Me.btnbuscar2.Name = "btnbuscar2"
        Me.btnbuscar2.Size = New System.Drawing.Size(64, 56)
        Me.btnbuscar2.TabIndex = 548
        Me.btnbuscar2.UseVisualStyleBackColor = False
        '
        'bdatagridveh
        '
        Me.bdatagridveh.BackgroundImage = CType(resources.GetObject("bdatagridveh.BackgroundImage"), System.Drawing.Image)
        Me.bdatagridveh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bdatagridveh.Enabled = False
        Me.bdatagridveh.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bdatagridveh.Location = New System.Drawing.Point(984, 16)
        Me.bdatagridveh.Name = "bdatagridveh"
        Me.bdatagridveh.Size = New System.Drawing.Size(64, 63)
        Me.bdatagridveh.TabIndex = 539
        Me.bdatagridveh.UseVisualStyleBackColor = True
        '
        'bagrlista2
        '
        Me.bagrlista2.BackColor = System.Drawing.Color.White
        Me.bagrlista2.BackgroundImage = CType(resources.GetObject("bagrlista2.BackgroundImage"), System.Drawing.Image)
        Me.bagrlista2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bagrlista2.Enabled = False
        Me.bagrlista2.Location = New System.Drawing.Point(914, 16)
        Me.bagrlista2.Name = "bagrlista2"
        Me.bagrlista2.Size = New System.Drawing.Size(64, 63)
        Me.bagrlista2.TabIndex = 538
        Me.bagrlista2.UseVisualStyleBackColor = False
        '
        'beliminarreg
        '
        Me.beliminarreg.BackColor = System.Drawing.Color.White
        Me.beliminarreg.BackgroundImage = CType(resources.GetObject("beliminarreg.BackgroundImage"), System.Drawing.Image)
        Me.beliminarreg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.beliminarreg.Location = New System.Drawing.Point(4, 600)
        Me.beliminarreg.Name = "beliminarreg"
        Me.beliminarreg.Size = New System.Drawing.Size(64, 63)
        Me.beliminarreg.TabIndex = 537
        Me.beliminarreg.UseVisualStyleBackColor = False
        '
        'tsolicitante
        '
        Me.tsolicitante.Location = New System.Drawing.Point(130, 177)
        Me.tsolicitante.Name = "tsolicitante"
        Me.tsolicitante.Size = New System.Drawing.Size(192, 20)
        Me.tsolicitante.TabIndex = 582
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(64, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 581
        Me.Label3.Text = "Solicitante:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(510, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 586
        Me.Label4.Text = "Numero de Parte:"
        '
        'tnompart
        '
        Me.tnompart.Location = New System.Drawing.Point(604, 172)
        Me.tnompart.Name = "tnompart"
        Me.tnompart.Size = New System.Drawing.Size(150, 20)
        Me.tnompart.TabIndex = 585
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(533, 147)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 584
        Me.Label9.Text = "Unidad:"
        '
        'tunt
        '
        Me.tunt.Location = New System.Drawing.Point(604, 143)
        Me.tunt.Name = "tunt"
        Me.tunt.Size = New System.Drawing.Size(150, 20)
        Me.tunt.TabIndex = 583
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(514, 203)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 13)
        Me.Label10.TabIndex = 588
        Me.Label10.Text = "Codigo Serinter:"
        '
        'tcodsert
        '
        Me.tcodsert.Location = New System.Drawing.Point(604, 200)
        Me.tcodsert.Name = "tcodsert"
        Me.tcodsert.Size = New System.Drawing.Size(150, 20)
        Me.tcodsert.TabIndex = 587
        '
        'num1un
        '
        Me.num1un.Location = New System.Drawing.Point(604, 115)
        Me.num1un.Name = "num1un"
        Me.num1un.Size = New System.Drawing.Size(150, 20)
        Me.num1un.TabIndex = 589
        '
        'fechaSolc
        '
        Me.fechaSolc.Location = New System.Drawing.Point(129, 74)
        Me.fechaSolc.Name = "fechaSolc"
        Me.fechaSolc.Size = New System.Drawing.Size(100, 20)
        Me.fechaSolc.TabIndex = 590
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 13)
        Me.Label6.TabIndex = 591
        Me.Label6.Text = "Fecha Solicitada:"
        '
        'SolicitudTrabj
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1275, 672)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.fechaSolc)
        Me.Controls.Add(Me.num1un)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.tcodsert)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tnompart)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tunt)
        Me.Controls.Add(Me.tsolicitante)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvreg2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chknvregistro)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.descp1env)
        Me.Controls.Add(Me.bagregadogeneral)
        Me.Controls.Add(Me.mensaje)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.cestadpase)
        Me.Controls.Add(Me.tvacio)
        Me.Controls.Add(Me.bimprimir)
        Me.Controls.Add(Me.bregresar)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pfoto4)
        Me.Controls.Add(Me.pfoto3)
        Me.Controls.Add(Me.breiniciar)
        Me.Controls.Add(Me.beliminar)
        Me.Controls.Add(Me.bagregar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.blimpieza2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ccampos2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnbuscar2)
        Me.Controls.Add(Me.tcriterio2)
        Me.Controls.Add(Me.bdatagridveh)
        Me.Controls.Add(Me.bagrlista2)
        Me.Controls.Add(Me.beliminarreg)
        Me.Controls.Add(Me.dgvreg)
        Me.Controls.Add(Me.categoria)
        Me.Controls.Add(Me.dgvvehiculos)
        Me.Controls.Add(Me.nosolicitud)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.tproyecto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.codigovh)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SolicitudTrabj"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SolicitudTrabj"
        CType(Me.dgvreg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvvehiculos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvreg2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pfoto4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pfoto3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num1un, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chknvregistro As System.Windows.Forms.CheckBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents descp1env As System.Windows.Forms.TextBox
    Friend WithEvents bagregadogeneral As System.Windows.Forms.Button
    Friend WithEvents mensaje As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents cestadpase As System.Windows.Forms.ComboBox
    Friend WithEvents tvacio As System.Windows.Forms.TextBox
    Friend WithEvents bimprimir As System.Windows.Forms.Button
    Friend WithEvents bregresar As System.Windows.Forms.Button
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pfoto4 As System.Windows.Forms.PictureBox
    Friend WithEvents pfoto3 As System.Windows.Forms.PictureBox
    Friend WithEvents breiniciar As System.Windows.Forms.Button
    Friend WithEvents beliminar As System.Windows.Forms.Button
    Friend WithEvents bagregar As System.Windows.Forms.Button
    Friend WithEvents beliminarreg As System.Windows.Forms.Button
    Friend WithEvents dgvreg As System.Windows.Forms.DataGridView
    Friend WithEvents categoria As System.Windows.Forms.ComboBox
    Friend WithEvents nosolicitud As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tproyecto As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents codigovh As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvvehiculos As System.Windows.Forms.DataGridView
    Friend WithEvents bagrlista2 As System.Windows.Forms.Button
    Friend WithEvents bdatagridveh As System.Windows.Forms.Button
    Friend WithEvents tcriterio2 As System.Windows.Forms.TextBox
    Friend WithEvents btnbuscar2 As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ccampos2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents blimpieza2 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents id1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cant1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents npart As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodSert As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvreg2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tsolicitante As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tnompart As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tunt As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tcodsert As System.Windows.Forms.TextBox
    Friend WithEvents num1un As System.Windows.Forms.NumericUpDown
    Friend WithEvents fechaSolc As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
