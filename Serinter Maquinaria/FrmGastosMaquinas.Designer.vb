<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGastosMaquinas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGastosMaquinas))
        Me.bregresar = New System.Windows.Forms.Button()
        Me.dgvreg2 = New System.Windows.Forms.DataGridView()
        Me.item2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unidad2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.observacion2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvreg = New System.Windows.Forms.DataGridView()
        Me.item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.observacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pfoto4 = New System.Windows.Forms.PictureBox()
        Me.pfoto3 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.blimpieza2 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ccampos2 = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnbuscar2 = New System.Windows.Forms.Button()
        Me.tcriterio2 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.blimpieza = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ccampos = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.tcriterio = New System.Windows.Forms.TextBox()
        Me.bdatagridveh = New System.Windows.Forms.Button()
        Me.bagrlista2 = New System.Windows.Forms.Button()
        Me.bdatagridinv = New System.Windows.Forms.Button()
        Me.bagrlista = New System.Windows.Forms.Button()
        Me.dgvvehiculos = New System.Windows.Forms.DataGridView()
        Me.dgvinventario = New System.Windows.Forms.DataGridView()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cstock = New System.Windows.Forms.NumericUpDown()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tproveedor = New System.Windows.Forms.ComboBox()
        Me.pfoto2 = New System.Windows.Forms.PictureBox()
        Me.pfoto = New System.Windows.Forms.PictureBox()
        Me.codp1 = New System.Windows.Forms.ComboBox()
        Me.ccategoria = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tnombre = New System.Windows.Forms.TextBox()
        Me.codp2 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgvreg2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvreg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pfoto4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pfoto3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvvehiculos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvinventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cstock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pfoto2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pfoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bregresar
        '
        Me.bregresar.BackgroundImage = CType(resources.GetObject("bregresar.BackgroundImage"), System.Drawing.Image)
        Me.bregresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bregresar.Location = New System.Drawing.Point(601, 432)
        Me.bregresar.Name = "bregresar"
        Me.bregresar.Size = New System.Drawing.Size(89, 66)
        Me.bregresar.TabIndex = 149
        Me.bregresar.UseVisualStyleBackColor = True
        '
        'dgvreg2
        '
        Me.dgvreg2.AllowUserToAddRows = False
        Me.dgvreg2.AllowUserToDeleteRows = False
        Me.dgvreg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvreg2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.item2, Me.unidad2, Me.descripcion2, Me.observacion2})
        Me.dgvreg2.Location = New System.Drawing.Point(23, 548)
        Me.dgvreg2.Name = "dgvreg2"
        Me.dgvreg2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvreg2.Size = New System.Drawing.Size(566, 113)
        Me.dgvreg2.TabIndex = 484
        '
        'item2
        '
        Me.item2.HeaderText = "item"
        Me.item2.Name = "item2"
        Me.item2.ReadOnly = True
        Me.item2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.item2.Width = 49
        '
        'unidad2
        '
        Me.unidad2.HeaderText = "unidad"
        Me.unidad2.Name = "unidad2"
        Me.unidad2.ReadOnly = True
        Me.unidad2.Width = 70
        '
        'descripcion2
        '
        Me.descripcion2.HeaderText = "descripcion"
        Me.descripcion2.Name = "descripcion2"
        Me.descripcion2.ReadOnly = True
        Me.descripcion2.Width = 220
        '
        'observacion2
        '
        Me.observacion2.HeaderText = "observacion"
        Me.observacion2.Name = "observacion2"
        Me.observacion2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.observacion2.Width = 184
        '
        'dgvreg
        '
        Me.dgvreg.AllowUserToAddRows = False
        Me.dgvreg.AllowUserToDeleteRows = False
        Me.dgvreg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvreg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.item, Me.unidad, Me.descripcion, Me.observacion})
        Me.dgvreg.Location = New System.Drawing.Point(23, 432)
        Me.dgvreg.Name = "dgvreg"
        Me.dgvreg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvreg.Size = New System.Drawing.Size(566, 113)
        Me.dgvreg.TabIndex = 483
        '
        'item
        '
        Me.item.HeaderText = "item"
        Me.item.Name = "item"
        Me.item.ReadOnly = True
        Me.item.Width = 49
        '
        'unidad
        '
        Me.unidad.HeaderText = "unidad"
        Me.unidad.Name = "unidad"
        Me.unidad.ReadOnly = True
        Me.unidad.Width = 70
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "descripcion"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Width = 220
        '
        'observacion
        '
        Me.observacion.HeaderText = "observacion"
        Me.observacion.Name = "observacion"
        Me.observacion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.observacion.Width = 184
        '
        'pfoto4
        '
        Me.pfoto4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pfoto4.Location = New System.Drawing.Point(719, 523)
        Me.pfoto4.Name = "pfoto4"
        Me.pfoto4.Size = New System.Drawing.Size(220, 140)
        Me.pfoto4.TabIndex = 520
        Me.pfoto4.TabStop = False
        '
        'pfoto3
        '
        Me.pfoto3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pfoto3.Location = New System.Drawing.Point(719, 371)
        Me.pfoto3.Name = "pfoto3"
        Me.pfoto3.Size = New System.Drawing.Size(220, 140)
        Me.pfoto3.TabIndex = 519
        Me.pfoto3.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label7.Location = New System.Drawing.Point(619, 253)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 24)
        Me.Label7.TabIndex = 518
        Me.Label7.Text = "Limpiar"
        '
        'blimpieza2
        '
        Me.blimpieza2.BackColor = System.Drawing.Color.White
        Me.blimpieza2.BackgroundImage = CType(resources.GetObject("blimpieza2.BackgroundImage"), System.Drawing.Image)
        Me.blimpieza2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.blimpieza2.Location = New System.Drawing.Point(623, 280)
        Me.blimpieza2.Name = "blimpieza2"
        Me.blimpieza2.Size = New System.Drawing.Size(64, 56)
        Me.blimpieza2.TabIndex = 517
        Me.blimpieza2.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(607, 222)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(192, 24)
        Me.Label8.TabIndex = 516
        Me.Label8.Text = "Criterio de Busqueda:"
        '
        'ccampos2
        '
        Me.ccampos2.Enabled = False
        Me.ccampos2.FormattingEnabled = True
        Me.ccampos2.Items.AddRange(New Object() {"codigo_vh  ", "placa_vh", "estado_vh"})
        Me.ccampos2.Location = New System.Drawing.Point(805, 225)
        Me.ccampos2.Name = "ccampos2"
        Me.ccampos2.Size = New System.Drawing.Size(108, 21)
        Me.ccampos2.TabIndex = 515
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label13.Location = New System.Drawing.Point(705, 253)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 24)
        Me.Label13.TabIndex = 514
        Me.Label13.Text = "Buscar"
        '
        'btnbuscar2
        '
        Me.btnbuscar2.BackColor = System.Drawing.Color.White
        Me.btnbuscar2.BackgroundImage = CType(resources.GetObject("btnbuscar2.BackgroundImage"), System.Drawing.Image)
        Me.btnbuscar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscar2.Enabled = False
        Me.btnbuscar2.Location = New System.Drawing.Point(709, 280)
        Me.btnbuscar2.Name = "btnbuscar2"
        Me.btnbuscar2.Size = New System.Drawing.Size(64, 56)
        Me.btnbuscar2.TabIndex = 513
        Me.btnbuscar2.UseVisualStyleBackColor = False
        '
        'tcriterio2
        '
        Me.tcriterio2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tcriterio2.Enabled = False
        Me.tcriterio2.Location = New System.Drawing.Point(805, 299)
        Me.tcriterio2.Name = "tcriterio2"
        Me.tcriterio2.Size = New System.Drawing.Size(108, 20)
        Me.tcriterio2.TabIndex = 512
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label10.Location = New System.Drawing.Point(991, 253)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 24)
        Me.Label10.TabIndex = 511
        Me.Label10.Text = "Limpiar"
        '
        'blimpieza
        '
        Me.blimpieza.BackColor = System.Drawing.Color.White
        Me.blimpieza.BackgroundImage = CType(resources.GetObject("blimpieza.BackgroundImage"), System.Drawing.Image)
        Me.blimpieza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.blimpieza.Location = New System.Drawing.Point(995, 280)
        Me.blimpieza.Name = "blimpieza"
        Me.blimpieza.Size = New System.Drawing.Size(64, 56)
        Me.blimpieza.TabIndex = 510
        Me.blimpieza.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(979, 222)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(192, 24)
        Me.Label9.TabIndex = 509
        Me.Label9.Text = "Criterio de Busqueda:"
        '
        'ccampos
        '
        Me.ccampos.Enabled = False
        Me.ccampos.FormattingEnabled = True
        Me.ccampos.Items.AddRange(New Object() {"codigop", "prefijo", "nom_prod"})
        Me.ccampos.Location = New System.Drawing.Point(1177, 227)
        Me.ccampos.Name = "ccampos"
        Me.ccampos.Size = New System.Drawing.Size(108, 21)
        Me.ccampos.TabIndex = 508
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label11.Location = New System.Drawing.Point(1077, 253)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 24)
        Me.Label11.TabIndex = 507
        Me.Label11.Text = "Buscar"
        '
        'btnbuscar
        '
        Me.btnbuscar.BackColor = System.Drawing.Color.White
        Me.btnbuscar.BackgroundImage = CType(resources.GetObject("btnbuscar.BackgroundImage"), System.Drawing.Image)
        Me.btnbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscar.Enabled = False
        Me.btnbuscar.Location = New System.Drawing.Point(1081, 280)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(64, 56)
        Me.btnbuscar.TabIndex = 506
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'tcriterio
        '
        Me.tcriterio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tcriterio.Enabled = False
        Me.tcriterio.Location = New System.Drawing.Point(1177, 299)
        Me.tcriterio.Name = "tcriterio"
        Me.tcriterio.Size = New System.Drawing.Size(108, 20)
        Me.tcriterio.TabIndex = 505
        '
        'bdatagridveh
        '
        Me.bdatagridveh.BackgroundImage = CType(resources.GetObject("bdatagridveh.BackgroundImage"), System.Drawing.Image)
        Me.bdatagridveh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bdatagridveh.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bdatagridveh.Location = New System.Drawing.Point(659, 16)
        Me.bdatagridveh.Name = "bdatagridveh"
        Me.bdatagridveh.Size = New System.Drawing.Size(64, 63)
        Me.bdatagridveh.TabIndex = 504
        Me.bdatagridveh.UseVisualStyleBackColor = True
        '
        'bagrlista2
        '
        Me.bagrlista2.BackColor = System.Drawing.Color.White
        Me.bagrlista2.BackgroundImage = CType(resources.GetObject("bagrlista2.BackgroundImage"), System.Drawing.Image)
        Me.bagrlista2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bagrlista2.Enabled = False
        Me.bagrlista2.Location = New System.Drawing.Point(589, 16)
        Me.bagrlista2.Name = "bagrlista2"
        Me.bagrlista2.Size = New System.Drawing.Size(64, 63)
        Me.bagrlista2.TabIndex = 503
        Me.bagrlista2.UseVisualStyleBackColor = False
        '
        'bdatagridinv
        '
        Me.bdatagridinv.BackgroundImage = CType(resources.GetObject("bdatagridinv.BackgroundImage"), System.Drawing.Image)
        Me.bdatagridinv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bdatagridinv.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bdatagridinv.Location = New System.Drawing.Point(1025, 17)
        Me.bdatagridinv.Name = "bdatagridinv"
        Me.bdatagridinv.Size = New System.Drawing.Size(64, 62)
        Me.bdatagridinv.TabIndex = 502
        Me.bdatagridinv.UseVisualStyleBackColor = True
        '
        'bagrlista
        '
        Me.bagrlista.BackColor = System.Drawing.Color.White
        Me.bagrlista.BackgroundImage = CType(resources.GetObject("bagrlista.BackgroundImage"), System.Drawing.Image)
        Me.bagrlista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bagrlista.Enabled = False
        Me.bagrlista.Location = New System.Drawing.Point(955, 16)
        Me.bagrlista.Name = "bagrlista"
        Me.bagrlista.Size = New System.Drawing.Size(64, 63)
        Me.bagrlista.TabIndex = 501
        Me.bagrlista.UseVisualStyleBackColor = False
        '
        'dgvvehiculos
        '
        Me.dgvvehiculos.AllowUserToAddRows = False
        Me.dgvvehiculos.AllowUserToDeleteRows = False
        Me.dgvvehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvvehiculos.Location = New System.Drawing.Point(589, 85)
        Me.dgvvehiculos.MultiSelect = False
        Me.dgvvehiculos.Name = "dgvvehiculos"
        Me.dgvvehiculos.ReadOnly = True
        Me.dgvvehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvvehiculos.Size = New System.Drawing.Size(350, 127)
        Me.dgvvehiculos.TabIndex = 500
        Me.dgvvehiculos.Visible = False
        '
        'dgvinventario
        '
        Me.dgvinventario.AllowUserToAddRows = False
        Me.dgvinventario.AllowUserToDeleteRows = False
        Me.dgvinventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvinventario.Location = New System.Drawing.Point(955, 85)
        Me.dgvinventario.MultiSelect = False
        Me.dgvinventario.Name = "dgvinventario"
        Me.dgvinventario.ReadOnly = True
        Me.dgvinventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvinventario.Size = New System.Drawing.Size(367, 127)
        Me.dgvinventario.TabIndex = 499
        Me.dgvinventario.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(1177, 457)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(52, 13)
        Me.Label17.TabIndex = 498
        Me.Label17.Text = "Cantidad:"
        '
        'cstock
        '
        Me.cstock.Enabled = False
        Me.cstock.Location = New System.Drawing.Point(1103, 455)
        Me.cstock.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.cstock.Name = "cstock"
        Me.cstock.Size = New System.Drawing.Size(65, 20)
        Me.cstock.TabIndex = 497
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(1009, 457)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(38, 13)
        Me.Label18.TabIndex = 496
        Me.Label18.Text = "Stock:"
        '
        'tproveedor
        '
        Me.tproveedor.Enabled = False
        Me.tproveedor.FormattingEnabled = True
        Me.tproveedor.Location = New System.Drawing.Point(1103, 427)
        Me.tproveedor.Name = "tproveedor"
        Me.tproveedor.Size = New System.Drawing.Size(194, 21)
        Me.tproveedor.TabIndex = 495
        '
        'pfoto2
        '
        Me.pfoto2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pfoto2.Location = New System.Drawing.Point(1153, 486)
        Me.pfoto2.Name = "pfoto2"
        Me.pfoto2.Size = New System.Drawing.Size(154, 177)
        Me.pfoto2.TabIndex = 494
        Me.pfoto2.TabStop = False
        '
        'pfoto
        '
        Me.pfoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pfoto.Location = New System.Drawing.Point(993, 486)
        Me.pfoto.Name = "pfoto"
        Me.pfoto.Size = New System.Drawing.Size(154, 177)
        Me.pfoto.TabIndex = 493
        Me.pfoto.TabStop = False
        '
        'codp1
        '
        Me.codp1.Enabled = False
        Me.codp1.FormattingEnabled = True
        Me.codp1.Items.AddRange(New Object() {"A", "B", "C"})
        Me.codp1.Location = New System.Drawing.Point(1188, 349)
        Me.codp1.Name = "codp1"
        Me.codp1.Size = New System.Drawing.Size(41, 21)
        Me.codp1.TabIndex = 492
        '
        'ccategoria
        '
        Me.ccategoria.Enabled = False
        Me.ccategoria.FormattingEnabled = True
        Me.ccategoria.Items.AddRange(New Object() {"Repuesto de Maquinaria", "Material de Construcción", "Objeto de Limpieza", "Herramienta de Mantenimiento", "Objeto de Oficina", "Otros"})
        Me.ccategoria.Location = New System.Drawing.Point(1103, 400)
        Me.ccategoria.Name = "ccategoria"
        Me.ccategoria.Size = New System.Drawing.Size(194, 21)
        Me.ccategoria.TabIndex = 491
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(992, 432)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(59, 13)
        Me.Label19.TabIndex = 490
        Me.Label19.Text = "Proveedor:"
        '
        'tnombre
        '
        Me.tnombre.Enabled = False
        Me.tnombre.Location = New System.Drawing.Point(1103, 375)
        Me.tnombre.Name = "tnombre"
        Me.tnombre.Size = New System.Drawing.Size(194, 20)
        Me.tnombre.TabIndex = 489
        '
        'codp2
        '
        Me.codp2.Enabled = False
        Me.codp2.Location = New System.Drawing.Point(1103, 349)
        Me.codp2.Name = "codp2"
        Me.codp2.Size = New System.Drawing.Size(79, 20)
        Me.codp2.TabIndex = 488
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(992, 406)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(55, 13)
        Me.Label20.TabIndex = 487
        Me.Label20.Text = "Categoria:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(992, 351)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(89, 13)
        Me.Label21.TabIndex = 486
        Me.Label21.Text = "Codigo Producto:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(992, 378)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(108, 13)
        Me.Label22.TabIndex = 485
        Me.Label22.Text = "Nombre de Producto:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 521
        Me.Label1.Text = "N*Orden"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(137, 75)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 522
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(137, 111)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 524
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 523
        Me.Label2.Text = "Vehiculo"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(137, 147)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 526
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(137, 253)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 531
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(137, 217)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 530
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(64, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 529
        Me.Label3.Text = "Vehiculo"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(137, 181)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 528
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(64, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 527
        Me.Label4.Text = "N*Orden"
        '
        'FrmGastosMaquinas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1328, 666)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pfoto4)
        Me.Controls.Add(Me.pfoto3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.blimpieza2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ccampos2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnbuscar2)
        Me.Controls.Add(Me.tcriterio2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.blimpieza)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ccampos)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.tcriterio)
        Me.Controls.Add(Me.bdatagridveh)
        Me.Controls.Add(Me.bagrlista2)
        Me.Controls.Add(Me.bdatagridinv)
        Me.Controls.Add(Me.bagrlista)
        Me.Controls.Add(Me.dgvvehiculos)
        Me.Controls.Add(Me.dgvinventario)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.cstock)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.tproveedor)
        Me.Controls.Add(Me.pfoto2)
        Me.Controls.Add(Me.pfoto)
        Me.Controls.Add(Me.codp1)
        Me.Controls.Add(Me.ccategoria)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.tnombre)
        Me.Controls.Add(Me.codp2)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.dgvreg2)
        Me.Controls.Add(Me.dgvreg)
        Me.Controls.Add(Me.bregresar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmGastosMaquinas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmGastosMaquinas"
        CType(Me.dgvreg2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvreg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pfoto4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pfoto3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvvehiculos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvinventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cstock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pfoto2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pfoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bregresar As System.Windows.Forms.Button
    Friend WithEvents dgvreg2 As System.Windows.Forms.DataGridView
    Friend WithEvents item2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unidad2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents observacion2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvreg As System.Windows.Forms.DataGridView
    Friend WithEvents item As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents observacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pfoto4 As System.Windows.Forms.PictureBox
    Friend WithEvents pfoto3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents blimpieza2 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ccampos2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnbuscar2 As System.Windows.Forms.Button
    Friend WithEvents tcriterio2 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents blimpieza As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ccampos As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents tcriterio As System.Windows.Forms.TextBox
    Friend WithEvents bdatagridveh As System.Windows.Forms.Button
    Friend WithEvents bagrlista2 As System.Windows.Forms.Button
    Friend WithEvents bdatagridinv As System.Windows.Forms.Button
    Friend WithEvents bagrlista As System.Windows.Forms.Button
    Friend WithEvents dgvvehiculos As System.Windows.Forms.DataGridView
    Friend WithEvents dgvinventario As System.Windows.Forms.DataGridView
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cstock As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents tproveedor As System.Windows.Forms.ComboBox
    Friend WithEvents pfoto2 As System.Windows.Forms.PictureBox
    Friend WithEvents pfoto As System.Windows.Forms.PictureBox
    Friend WithEvents codp1 As System.Windows.Forms.ComboBox
    Friend WithEvents ccategoria As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents tnombre As System.Windows.Forms.TextBox
    Friend WithEvents codp2 As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
