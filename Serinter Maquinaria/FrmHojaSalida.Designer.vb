<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHojaSalida
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHojaSalida))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.codigovh = New System.Windows.Forms.TextBox()
        Me.placavh = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.km1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.hrm1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.km2 = New System.Windows.Forms.TextBox()
        Me.hrm2 = New System.Windows.Forms.TextBox()
        Me.tdestiny = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tmorotris = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.nosalida = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtpretorno = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtpsalida = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ncantidadinv = New System.Windows.Forms.NumericUpDown()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cstock = New System.Windows.Forms.NumericUpDown()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tproveedor = New System.Windows.Forms.ComboBox()
        Me.codp1 = New System.Windows.Forms.ComboBox()
        Me.ccategoria = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tnombre = New System.Windows.Forms.TextBox()
        Me.codp2 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.dgvinventario = New System.Windows.Forms.DataGridView()
        Me.dgvvehiculos = New System.Windows.Forms.DataGridView()
        Me.categoria = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.dgvreg = New System.Windows.Forms.DataGridView()
        Me.id1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cdestino1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.observacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ccampos = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tcriterio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ccampos2 = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tcriterio2 = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.tvacio = New System.Windows.Forms.TextBox()
        Me.tpartner = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.rbexistvh = New System.Windows.Forms.CheckBox()
        Me.estadovh = New System.Windows.Forms.ComboBox()
        Me.dgvreg2 = New System.Windows.Forms.DataGridView()
        Me.id2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cdestino2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unidad2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.observacion2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cestadpase = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.mensaje = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.descp1env = New System.Windows.Forms.TextBox()
        Me.num1un = New System.Windows.Forms.NumericUpDown()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.chknvregistro = New System.Windows.Forms.CheckBox()
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
        Me.blimpieza = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.bdatagridveh = New System.Windows.Forms.Button()
        Me.bagrlista2 = New System.Windows.Forms.Button()
        Me.beliminarreg = New System.Windows.Forms.Button()
        Me.bdatagridinv = New System.Windows.Forms.Button()
        Me.bagrlista = New System.Windows.Forms.Button()
        Me.pfoto2 = New System.Windows.Forms.PictureBox()
        Me.pfoto = New System.Windows.Forms.PictureBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Cdestiny = New System.Windows.Forms.ComboBox()
        CType(Me.ncantidadinv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cstock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvinventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvvehiculos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvreg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvreg2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num1un, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pfoto4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pfoto3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pfoto2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pfoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo Vehiculo:"
        '
        'codigovh
        '
        Me.codigovh.Enabled = False
        Me.codigovh.Location = New System.Drawing.Point(111, 122)
        Me.codigovh.Name = "codigovh"
        Me.codigovh.Size = New System.Drawing.Size(132, 20)
        Me.codigovh.TabIndex = 1
        '
        'placavh
        '
        Me.placavh.Enabled = False
        Me.placavh.Location = New System.Drawing.Point(111, 174)
        Me.placavh.Name = "placavh"
        Me.placavh.Size = New System.Drawing.Size(132, 20)
        Me.placavh.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Placa:"
        '
        'km1
        '
        Me.km1.Location = New System.Drawing.Point(112, 254)
        Me.km1.Name = "km1"
        Me.km1.Size = New System.Drawing.Size(92, 20)
        Me.km1.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 257)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Kilometraje:"
        '
        'hrm1
        '
        Me.hrm1.Location = New System.Drawing.Point(112, 228)
        Me.hrm1.Name = "hrm1"
        Me.hrm1.Size = New System.Drawing.Size(92, 20)
        Me.hrm1.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Horometro:"
        '
        'km2
        '
        Me.km2.Location = New System.Drawing.Point(210, 254)
        Me.km2.Name = "km2"
        Me.km2.Size = New System.Drawing.Size(92, 20)
        Me.km2.TabIndex = 9
        '
        'hrm2
        '
        Me.hrm2.Location = New System.Drawing.Point(210, 228)
        Me.hrm2.Name = "hrm2"
        Me.hrm2.Size = New System.Drawing.Size(93, 20)
        Me.hrm2.TabIndex = 8
        '
        'tdestiny
        '
        Me.tdestiny.Location = New System.Drawing.Point(111, 333)
        Me.tdestiny.Name = "tdestiny"
        Me.tdestiny.Size = New System.Drawing.Size(192, 20)
        Me.tdestiny.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(60, 335)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Destino:"
        '
        'tmorotris
        '
        Me.tmorotris.Location = New System.Drawing.Point(111, 280)
        Me.tmorotris.Name = "tmorotris"
        Me.tmorotris.Size = New System.Drawing.Size(192, 20)
        Me.tmorotris.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(53, 283)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Motorista:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(51, 205)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Categoria:"
        '
        'nosalida
        '
        Me.nosalida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.nosalida.Location = New System.Drawing.Point(111, 96)
        Me.nosalida.Name = "nosalida"
        Me.nosalida.Size = New System.Drawing.Size(132, 20)
        Me.nosalida.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 98)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 13)
        Me.Label14.TabIndex = 425
        Me.Label14.Text = "Numero de Salida:"
        '
        'dtpretorno
        '
        Me.dtpretorno.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpretorno.Location = New System.Drawing.Point(358, 124)
        Me.dtpretorno.Name = "dtpretorno"
        Me.dtpretorno.Size = New System.Drawing.Size(101, 20)
        Me.dtpretorno.TabIndex = 424
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(256, 127)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 13)
        Me.Label15.TabIndex = 423
        Me.Label15.Text = "Fecha de Retorno:"
        '
        'dtpsalida
        '
        Me.dtpsalida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpsalida.Location = New System.Drawing.Point(358, 95)
        Me.dtpsalida.Name = "dtpsalida"
        Me.dtpsalida.Size = New System.Drawing.Size(101, 20)
        Me.dtpsalida.TabIndex = 422
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(265, 98)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(87, 13)
        Me.Label16.TabIndex = 421
        Me.Label16.Text = "Fecha de Salida:"
        '
        'ncantidadinv
        '
        Me.ncantidadinv.Location = New System.Drawing.Point(1187, 444)
        Me.ncantidadinv.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.ncantidadinv.Name = "ncantidadinv"
        Me.ncantidadinv.Size = New System.Drawing.Size(62, 20)
        Me.ncantidadinv.TabIndex = 420
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(1103, 446)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(52, 13)
        Me.Label17.TabIndex = 419
        Me.Label17.Text = "Cantidad:"
        '
        'cstock
        '
        Me.cstock.Enabled = False
        Me.cstock.Location = New System.Drawing.Point(1029, 444)
        Me.cstock.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.cstock.Name = "cstock"
        Me.cstock.Size = New System.Drawing.Size(65, 20)
        Me.cstock.TabIndex = 417
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(935, 446)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(38, 13)
        Me.Label18.TabIndex = 416
        Me.Label18.Text = "Stock:"
        '
        'tproveedor
        '
        Me.tproveedor.Enabled = False
        Me.tproveedor.FormattingEnabled = True
        Me.tproveedor.Location = New System.Drawing.Point(1029, 416)
        Me.tproveedor.Name = "tproveedor"
        Me.tproveedor.Size = New System.Drawing.Size(220, 21)
        Me.tproveedor.TabIndex = 415
        '
        'codp1
        '
        Me.codp1.Enabled = False
        Me.codp1.FormattingEnabled = True
        Me.codp1.Items.AddRange(New Object() {"A", "B", "C"})
        Me.codp1.Location = New System.Drawing.Point(1114, 338)
        Me.codp1.Name = "codp1"
        Me.codp1.Size = New System.Drawing.Size(41, 21)
        Me.codp1.TabIndex = 412
        '
        'ccategoria
        '
        Me.ccategoria.Enabled = False
        Me.ccategoria.FormattingEnabled = True
        Me.ccategoria.Items.AddRange(New Object() {"Repuesto de Maquinaria", "Material de Construcción", "Objeto de Limpieza", "Herramienta de Mantenimiento", "Objeto de Oficina", "Otros"})
        Me.ccategoria.Location = New System.Drawing.Point(1029, 389)
        Me.ccategoria.Name = "ccategoria"
        Me.ccategoria.Size = New System.Drawing.Size(220, 21)
        Me.ccategoria.TabIndex = 411
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(918, 421)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(59, 13)
        Me.Label19.TabIndex = 410
        Me.Label19.Text = "Proveedor:"
        '
        'tnombre
        '
        Me.tnombre.Enabled = False
        Me.tnombre.Location = New System.Drawing.Point(1029, 364)
        Me.tnombre.Name = "tnombre"
        Me.tnombre.Size = New System.Drawing.Size(220, 20)
        Me.tnombre.TabIndex = 409
        '
        'codp2
        '
        Me.codp2.Enabled = False
        Me.codp2.Location = New System.Drawing.Point(1029, 338)
        Me.codp2.Name = "codp2"
        Me.codp2.Size = New System.Drawing.Size(79, 20)
        Me.codp2.TabIndex = 408
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(918, 395)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(55, 13)
        Me.Label20.TabIndex = 407
        Me.Label20.Text = "Categoria:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(918, 340)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(89, 13)
        Me.Label21.TabIndex = 406
        Me.Label21.Text = "Codigo Producto:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(918, 367)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(108, 13)
        Me.Label22.TabIndex = 405
        Me.Label22.Text = "Nombre de Producto:"
        '
        'dgvinventario
        '
        Me.dgvinventario.AllowUserToAddRows = False
        Me.dgvinventario.AllowUserToDeleteRows = False
        Me.dgvinventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvinventario.Location = New System.Drawing.Point(907, 74)
        Me.dgvinventario.MultiSelect = False
        Me.dgvinventario.Name = "dgvinventario"
        Me.dgvinventario.ReadOnly = True
        Me.dgvinventario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvinventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvinventario.Size = New System.Drawing.Size(367, 127)
        Me.dgvinventario.TabIndex = 430
        Me.dgvinventario.Visible = False
        '
        'dgvvehiculos
        '
        Me.dgvvehiculos.AllowUserToAddRows = False
        Me.dgvvehiculos.AllowUserToDeleteRows = False
        Me.dgvvehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvvehiculos.Location = New System.Drawing.Point(541, 74)
        Me.dgvvehiculos.MultiSelect = False
        Me.dgvvehiculos.Name = "dgvvehiculos"
        Me.dgvvehiculos.ReadOnly = True
        Me.dgvvehiculos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvvehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvvehiculos.Size = New System.Drawing.Size(350, 127)
        Me.dgvvehiculos.TabIndex = 431
        Me.dgvvehiculos.Visible = False
        '
        'categoria
        '
        Me.categoria.FormattingEnabled = True
        Me.categoria.Items.AddRange(New Object() {"Salida Inventario", "Salida Personal", "Salida Maquinaria", "Salida Tecnica", "Salida Renta", "Salida Compras", "Salida Acarreo", "Salida Vehiculos Proyectos", "Salida Flete Pequeño", "Salida Flete Grande", "Salida Vehiculo"})
        Me.categoria.Location = New System.Drawing.Point(111, 201)
        Me.categoria.Name = "categoria"
        Me.categoria.Size = New System.Drawing.Size(132, 21)
        Me.categoria.TabIndex = 434
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(19, 151)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(87, 13)
        Me.Label23.TabIndex = 438
        Me.Label23.Text = "Estado Vehiculo:"
        '
        'dgvreg
        '
        Me.dgvreg.AllowUserToAddRows = False
        Me.dgvreg.AllowUserToDeleteRows = False
        Me.dgvreg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvreg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id1, Me.item, Me.cdestino1, Me.descripcion, Me.unidad, Me.observacion})
        Me.dgvreg.Location = New System.Drawing.Point(8, 364)
        Me.dgvreg.MultiSelect = False
        Me.dgvreg.Name = "dgvreg"
        Me.dgvreg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvreg.Size = New System.Drawing.Size(597, 113)
        Me.dgvreg.TabIndex = 0
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
        Me.item.Width = 32
        '
        'cdestino1
        '
        Me.cdestino1.HeaderText = "destino"
        Me.cdestino1.Name = "cdestino1"
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "respuestos / materiales / equipo"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Width = 190
        '
        'unidad
        '
        Me.unidad.HeaderText = "unidad"
        Me.unidad.Name = "unidad"
        Me.unidad.ReadOnly = True
        Me.unidad.Width = 50
        '
        'observacion
        '
        Me.observacion.HeaderText = "observacion"
        Me.observacion.Name = "observacion"
        Me.observacion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.observacion.Width = 184
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label10.Location = New System.Drawing.Point(917, 242)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 24)
        Me.Label10.TabIndex = 456
        Me.Label10.Text = "Limpiar"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(905, 211)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(192, 24)
        Me.Label9.TabIndex = 454
        Me.Label9.Text = "Criterio de Busqueda:"
        '
        'ccampos
        '
        Me.ccampos.Enabled = False
        Me.ccampos.FormattingEnabled = True
        Me.ccampos.Items.AddRange(New Object() {"codigop", "prefijo", "nom_prod"})
        Me.ccampos.Location = New System.Drawing.Point(1103, 216)
        Me.ccampos.Name = "ccampos"
        Me.ccampos.Size = New System.Drawing.Size(108, 21)
        Me.ccampos.TabIndex = 453
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label11.Location = New System.Drawing.Point(1003, 242)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 24)
        Me.Label11.TabIndex = 452
        Me.Label11.Text = "Buscar"
        '
        'tcriterio
        '
        Me.tcriterio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tcriterio.Enabled = False
        Me.tcriterio.Location = New System.Drawing.Point(1103, 288)
        Me.tcriterio.Name = "tcriterio"
        Me.tcriterio.Size = New System.Drawing.Size(108, 20)
        Me.tcriterio.TabIndex = 450
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label7.Location = New System.Drawing.Point(549, 242)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 24)
        Me.Label7.TabIndex = 463
        Me.Label7.Text = "Limpiar"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(537, 211)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(192, 24)
        Me.Label8.TabIndex = 461
        Me.Label8.Text = "Criterio de Busqueda:"
        '
        'ccampos2
        '
        Me.ccampos2.Enabled = False
        Me.ccampos2.FormattingEnabled = True
        Me.ccampos2.Items.AddRange(New Object() {"codigo_vh  ", "placa_vh", "estado_vh"})
        Me.ccampos2.Location = New System.Drawing.Point(735, 214)
        Me.ccampos2.Name = "ccampos2"
        Me.ccampos2.Size = New System.Drawing.Size(108, 21)
        Me.ccampos2.TabIndex = 460
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label13.Location = New System.Drawing.Point(635, 242)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 24)
        Me.Label13.TabIndex = 459
        Me.Label13.Text = "Buscar"
        '
        'tcriterio2
        '
        Me.tcriterio2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tcriterio2.Enabled = False
        Me.tcriterio2.Location = New System.Drawing.Point(735, 288)
        Me.tcriterio2.Name = "tcriterio2"
        Me.tcriterio2.Size = New System.Drawing.Size(108, 20)
        Me.tcriterio2.TabIndex = 457
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(180, 38)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(146, 24)
        Me.Label32.TabIndex = 472
        Me.Label32.Text = "Hoja de Salida"
        '
        'tvacio
        '
        Me.tvacio.Location = New System.Drawing.Point(432, 42)
        Me.tvacio.Name = "tvacio"
        Me.tvacio.Size = New System.Drawing.Size(100, 20)
        Me.tvacio.TabIndex = 0
        Me.tvacio.Visible = False
        '
        'tpartner
        '
        Me.tpartner.Location = New System.Drawing.Point(111, 307)
        Me.tpartner.Name = "tpartner"
        Me.tpartner.Size = New System.Drawing.Size(192, 20)
        Me.tpartner.TabIndex = 477
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(24, 310)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(81, 13)
        Me.Label24.TabIndex = 476
        Me.Label24.Text = "Acompañantes:"
        '
        'rbexistvh
        '
        Me.rbexistvh.AutoSize = True
        Me.rbexistvh.Checked = True
        Me.rbexistvh.CheckState = System.Windows.Forms.CheckState.Checked
        Me.rbexistvh.Location = New System.Drawing.Point(287, 173)
        Me.rbexistvh.Name = "rbexistvh"
        Me.rbexistvh.Size = New System.Drawing.Size(169, 17)
        Me.rbexistvh.TabIndex = 479
        Me.rbexistvh.Text = "El Vehiculo Esta en el Sistema"
        Me.rbexistvh.UseVisualStyleBackColor = True
        '
        'estadovh
        '
        Me.estadovh.Enabled = False
        Me.estadovh.FormattingEnabled = True
        Me.estadovh.Items.AddRange(New Object() {"Disponible", "Utilizado", "Mantenimiento", "Dañado"})
        Me.estadovh.Location = New System.Drawing.Point(111, 147)
        Me.estadovh.Name = "estadovh"
        Me.estadovh.Size = New System.Drawing.Size(132, 21)
        Me.estadovh.TabIndex = 480
        '
        'dgvreg2
        '
        Me.dgvreg2.AllowUserToAddRows = False
        Me.dgvreg2.AllowUserToDeleteRows = False
        Me.dgvreg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvreg2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id2, Me.item2, Me.cdestino2, Me.descripcion2, Me.unidad2, Me.observacion2})
        Me.dgvreg2.Location = New System.Drawing.Point(8, 480)
        Me.dgvreg2.MultiSelect = False
        Me.dgvreg2.Name = "dgvreg2"
        Me.dgvreg2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvreg2.Size = New System.Drawing.Size(597, 113)
        Me.dgvreg2.TabIndex = 482
        '
        'id2
        '
        Me.id2.HeaderText = "id"
        Me.id2.Name = "id2"
        Me.id2.Visible = False
        '
        'item2
        '
        Me.item2.HeaderText = "item"
        Me.item2.Name = "item2"
        Me.item2.ReadOnly = True
        Me.item2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.item2.Width = 32
        '
        'cdestino2
        '
        Me.cdestino2.HeaderText = "destino"
        Me.cdestino2.Name = "cdestino2"
        '
        'descripcion2
        '
        Me.descripcion2.HeaderText = "repuestos / materiales / equipo"
        Me.descripcion2.Name = "descripcion2"
        Me.descripcion2.ReadOnly = True
        Me.descripcion2.Width = 190
        '
        'unidad2
        '
        Me.unidad2.HeaderText = "unidad"
        Me.unidad2.Name = "unidad2"
        Me.unidad2.ReadOnly = True
        Me.unidad2.Width = 50
        '
        'observacion2
        '
        Me.observacion2.HeaderText = "observacion"
        Me.observacion2.Name = "observacion2"
        Me.observacion2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.observacion2.Width = 184
        '
        'cestadpase
        '
        Me.cestadpase.Enabled = False
        Me.cestadpase.FormattingEnabled = True
        Me.cestadpase.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.cestadpase.Location = New System.Drawing.Point(321, 227)
        Me.cestadpase.Name = "cestadpase"
        Me.cestadpase.Size = New System.Drawing.Size(79, 21)
        Me.cestadpase.TabIndex = 483
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(317, 211)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(85, 13)
        Me.Label25.TabIndex = 484
        Me.Label25.Text = "Estado de salida"
        '
        'mensaje
        '
        Me.mensaje.AutoSize = True
        Me.mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mensaje.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.mensaje.Location = New System.Drawing.Point(429, 642)
        Me.mensaje.Name = "mensaje"
        Me.mensaje.Size = New System.Drawing.Size(75, 16)
        Me.mensaje.TabIndex = 485
        Me.mensaje.Text = "Mensajes"
        '
        'Timer1
        '
        '
        'descp1env
        '
        Me.descp1env.Location = New System.Drawing.Point(420, 334)
        Me.descp1env.Name = "descp1env"
        Me.descp1env.Size = New System.Drawing.Size(120, 20)
        Me.descp1env.TabIndex = 488
        '
        'num1un
        '
        Me.num1un.DecimalPlaces = 2
        Me.num1un.Location = New System.Drawing.Point(420, 309)
        Me.num1un.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.num1un.Name = "num1un"
        Me.num1un.Size = New System.Drawing.Size(120, 20)
        Me.num1un.TabIndex = 489
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(337, 312)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(44, 13)
        Me.Label26.TabIndex = 490
        Me.Label26.Text = "Unidad:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(307, 336)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(115, 13)
        Me.Label27.TabIndex = 491
        Me.Label27.Text = "Repuesto y Materiales:"
        '
        'chknvregistro
        '
        Me.chknvregistro.AutoSize = True
        Me.chknvregistro.Location = New System.Drawing.Point(111, 77)
        Me.chknvregistro.Name = "chknvregistro"
        Me.chknvregistro.Size = New System.Drawing.Size(100, 17)
        Me.chknvregistro.TabIndex = 492
        Me.chknvregistro.Text = "Nuevo Registro"
        Me.chknvregistro.UseVisualStyleBackColor = True
        '
        'bagregadogeneral
        '
        Me.bagregadogeneral.BackColor = System.Drawing.Color.White
        Me.bagregadogeneral.BackgroundImage = CType(resources.GetObject("bagregadogeneral.BackgroundImage"), System.Drawing.Image)
        Me.bagregadogeneral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bagregadogeneral.Location = New System.Drawing.Point(432, 207)
        Me.bagregadogeneral.Name = "bagregadogeneral"
        Me.bagregadogeneral.Size = New System.Drawing.Size(64, 63)
        Me.bagregadogeneral.TabIndex = 486
        Me.bagregadogeneral.UseVisualStyleBackColor = False
        '
        'bimprimir
        '
        Me.bimprimir.BackColor = System.Drawing.Color.White
        Me.bimprimir.BackgroundImage = CType(resources.GetObject("bimprimir.BackgroundImage"), System.Drawing.Image)
        Me.bimprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bimprimir.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bimprimir.Location = New System.Drawing.Point(287, 595)
        Me.bimprimir.Name = "bimprimir"
        Me.bimprimir.Size = New System.Drawing.Size(64, 63)
        Me.bimprimir.TabIndex = 474
        Me.bimprimir.UseVisualStyleBackColor = False
        '
        'bregresar
        '
        Me.bregresar.BackgroundImage = CType(resources.GetObject("bregresar.BackgroundImage"), System.Drawing.Image)
        Me.bregresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bregresar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bregresar.Location = New System.Drawing.Point(1188, 5)
        Me.bregresar.Name = "bregresar"
        Me.bregresar.Size = New System.Drawing.Size(86, 63)
        Me.bregresar.TabIndex = 473
        Me.bregresar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(22, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(141, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 471
        Me.PictureBox1.TabStop = False
        '
        'pfoto4
        '
        Me.pfoto4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pfoto4.Location = New System.Drawing.Point(623, 515)
        Me.pfoto4.Name = "pfoto4"
        Me.pfoto4.Size = New System.Drawing.Size(220, 140)
        Me.pfoto4.TabIndex = 470
        Me.pfoto4.TabStop = False
        '
        'pfoto3
        '
        Me.pfoto3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pfoto3.Location = New System.Drawing.Point(623, 363)
        Me.pfoto3.Name = "pfoto3"
        Me.pfoto3.Size = New System.Drawing.Size(220, 140)
        Me.pfoto3.TabIndex = 469
        Me.pfoto3.TabStop = False
        '
        'breiniciar
        '
        Me.breiniciar.BackColor = System.Drawing.Color.White
        Me.breiniciar.BackgroundImage = CType(resources.GetObject("breiniciar.BackgroundImage"), System.Drawing.Image)
        Me.breiniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.breiniciar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.breiniciar.Location = New System.Drawing.Point(217, 595)
        Me.breiniciar.Name = "breiniciar"
        Me.breiniciar.Size = New System.Drawing.Size(64, 63)
        Me.breiniciar.TabIndex = 466
        Me.breiniciar.UseVisualStyleBackColor = False
        '
        'beliminar
        '
        Me.beliminar.BackgroundImage = CType(resources.GetObject("beliminar.BackgroundImage"), System.Drawing.Image)
        Me.beliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.beliminar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.beliminar.Location = New System.Drawing.Point(147, 595)
        Me.beliminar.Name = "beliminar"
        Me.beliminar.Size = New System.Drawing.Size(64, 63)
        Me.beliminar.TabIndex = 465
        Me.beliminar.UseVisualStyleBackColor = True
        '
        'bagregar
        '
        Me.bagregar.BackgroundImage = CType(resources.GetObject("bagregar.BackgroundImage"), System.Drawing.Image)
        Me.bagregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bagregar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bagregar.Location = New System.Drawing.Point(78, 595)
        Me.bagregar.Name = "bagregar"
        Me.bagregar.Size = New System.Drawing.Size(64, 63)
        Me.bagregar.TabIndex = 464
        Me.bagregar.UseVisualStyleBackColor = True
        '
        'blimpieza2
        '
        Me.blimpieza2.BackColor = System.Drawing.Color.White
        Me.blimpieza2.BackgroundImage = CType(resources.GetObject("blimpieza2.BackgroundImage"), System.Drawing.Image)
        Me.blimpieza2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.blimpieza2.Location = New System.Drawing.Point(553, 269)
        Me.blimpieza2.Name = "blimpieza2"
        Me.blimpieza2.Size = New System.Drawing.Size(64, 56)
        Me.blimpieza2.TabIndex = 462
        Me.blimpieza2.UseVisualStyleBackColor = False
        '
        'btnbuscar2
        '
        Me.btnbuscar2.BackColor = System.Drawing.Color.White
        Me.btnbuscar2.BackgroundImage = CType(resources.GetObject("btnbuscar2.BackgroundImage"), System.Drawing.Image)
        Me.btnbuscar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscar2.Enabled = False
        Me.btnbuscar2.Location = New System.Drawing.Point(639, 269)
        Me.btnbuscar2.Name = "btnbuscar2"
        Me.btnbuscar2.Size = New System.Drawing.Size(64, 56)
        Me.btnbuscar2.TabIndex = 458
        Me.btnbuscar2.UseVisualStyleBackColor = False
        '
        'blimpieza
        '
        Me.blimpieza.BackColor = System.Drawing.Color.White
        Me.blimpieza.BackgroundImage = CType(resources.GetObject("blimpieza.BackgroundImage"), System.Drawing.Image)
        Me.blimpieza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.blimpieza.Location = New System.Drawing.Point(921, 269)
        Me.blimpieza.Name = "blimpieza"
        Me.blimpieza.Size = New System.Drawing.Size(64, 56)
        Me.blimpieza.TabIndex = 455
        Me.blimpieza.UseVisualStyleBackColor = False
        '
        'btnbuscar
        '
        Me.btnbuscar.BackColor = System.Drawing.Color.White
        Me.btnbuscar.BackgroundImage = CType(resources.GetObject("btnbuscar.BackgroundImage"), System.Drawing.Image)
        Me.btnbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscar.Enabled = False
        Me.btnbuscar.Location = New System.Drawing.Point(1007, 269)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(64, 56)
        Me.btnbuscar.TabIndex = 451
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'bdatagridveh
        '
        Me.bdatagridveh.BackgroundImage = CType(resources.GetObject("bdatagridveh.BackgroundImage"), System.Drawing.Image)
        Me.bdatagridveh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bdatagridveh.Enabled = False
        Me.bdatagridveh.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bdatagridveh.Location = New System.Drawing.Point(611, 5)
        Me.bdatagridveh.Name = "bdatagridveh"
        Me.bdatagridveh.Size = New System.Drawing.Size(64, 63)
        Me.bdatagridveh.TabIndex = 446
        Me.bdatagridveh.UseVisualStyleBackColor = True
        '
        'bagrlista2
        '
        Me.bagrlista2.BackColor = System.Drawing.Color.White
        Me.bagrlista2.BackgroundImage = CType(resources.GetObject("bagrlista2.BackgroundImage"), System.Drawing.Image)
        Me.bagrlista2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bagrlista2.Enabled = False
        Me.bagrlista2.Location = New System.Drawing.Point(541, 5)
        Me.bagrlista2.Name = "bagrlista2"
        Me.bagrlista2.Size = New System.Drawing.Size(64, 63)
        Me.bagrlista2.TabIndex = 443
        Me.bagrlista2.UseVisualStyleBackColor = False
        '
        'beliminarreg
        '
        Me.beliminarreg.BackColor = System.Drawing.Color.White
        Me.beliminarreg.BackgroundImage = CType(resources.GetObject("beliminarreg.BackgroundImage"), System.Drawing.Image)
        Me.beliminarreg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.beliminarreg.Location = New System.Drawing.Point(8, 595)
        Me.beliminarreg.Name = "beliminarreg"
        Me.beliminarreg.Size = New System.Drawing.Size(64, 63)
        Me.beliminarreg.TabIndex = 442
        Me.beliminarreg.UseVisualStyleBackColor = False
        '
        'bdatagridinv
        '
        Me.bdatagridinv.BackgroundImage = CType(resources.GetObject("bdatagridinv.BackgroundImage"), System.Drawing.Image)
        Me.bdatagridinv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bdatagridinv.Enabled = False
        Me.bdatagridinv.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bdatagridinv.Location = New System.Drawing.Point(977, 6)
        Me.bdatagridinv.Name = "bdatagridinv"
        Me.bdatagridinv.Size = New System.Drawing.Size(64, 62)
        Me.bdatagridinv.TabIndex = 440
        Me.bdatagridinv.UseVisualStyleBackColor = True
        '
        'bagrlista
        '
        Me.bagrlista.BackColor = System.Drawing.Color.White
        Me.bagrlista.BackgroundImage = CType(resources.GetObject("bagrlista.BackgroundImage"), System.Drawing.Image)
        Me.bagrlista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bagrlista.Enabled = False
        Me.bagrlista.Location = New System.Drawing.Point(907, 5)
        Me.bagrlista.Name = "bagrlista"
        Me.bagrlista.Size = New System.Drawing.Size(64, 63)
        Me.bagrlista.TabIndex = 435
        Me.bagrlista.UseVisualStyleBackColor = False
        '
        'pfoto2
        '
        Me.pfoto2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pfoto2.Location = New System.Drawing.Point(1079, 475)
        Me.pfoto2.Name = "pfoto2"
        Me.pfoto2.Size = New System.Drawing.Size(154, 177)
        Me.pfoto2.TabIndex = 414
        Me.pfoto2.TabStop = False
        '
        'pfoto
        '
        Me.pfoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pfoto.Location = New System.Drawing.Point(919, 475)
        Me.pfoto.Name = "pfoto"
        Me.pfoto.Size = New System.Drawing.Size(154, 177)
        Me.pfoto.TabIndex = 413
        Me.pfoto.TabStop = False
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(313, 287)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(103, 13)
        Me.Label28.TabIndex = 494
        Me.Label28.Text = "Listado de Destinos:"
        '
        'Cdestiny
        '
        Me.Cdestiny.FormattingEnabled = True
        Me.Cdestiny.Location = New System.Drawing.Point(420, 283)
        Me.Cdestiny.Name = "Cdestiny"
        Me.Cdestiny.Size = New System.Drawing.Size(121, 21)
        Me.Cdestiny.TabIndex = 495
        '
        'FrmHojaSalida
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1275, 672)
        Me.Controls.Add(Me.Cdestiny)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.chknvregistro)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.num1un)
        Me.Controls.Add(Me.descp1env)
        Me.Controls.Add(Me.bagregadogeneral)
        Me.Controls.Add(Me.mensaje)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.cestadpase)
        Me.Controls.Add(Me.dgvreg2)
        Me.Controls.Add(Me.estadovh)
        Me.Controls.Add(Me.rbexistvh)
        Me.Controls.Add(Me.tpartner)
        Me.Controls.Add(Me.Label24)
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
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.blimpieza)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ccampos)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.tcriterio)
        Me.Controls.Add(Me.bdatagridveh)
        Me.Controls.Add(Me.bagrlista2)
        Me.Controls.Add(Me.beliminarreg)
        Me.Controls.Add(Me.dgvreg)
        Me.Controls.Add(Me.bdatagridinv)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.bagrlista)
        Me.Controls.Add(Me.categoria)
        Me.Controls.Add(Me.dgvvehiculos)
        Me.Controls.Add(Me.dgvinventario)
        Me.Controls.Add(Me.nosalida)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.dtpretorno)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.dtpsalida)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.ncantidadinv)
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
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.tdestiny)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tmorotris)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.km2)
        Me.Controls.Add(Me.hrm2)
        Me.Controls.Add(Me.km1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.hrm1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.placavh)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.codigovh)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmHojaSalida"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPaseSalida"
        CType(Me.ncantidadinv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cstock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvinventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvvehiculos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvreg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvreg2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num1un, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pfoto4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pfoto3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pfoto2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pfoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents codigovh As System.Windows.Forms.TextBox
    Friend WithEvents placavh As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents km1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents hrm1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents km2 As System.Windows.Forms.TextBox
    Friend WithEvents hrm2 As System.Windows.Forms.TextBox
    Friend WithEvents tdestiny As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tmorotris As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents nosalida As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dtpretorno As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dtpsalida As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ncantidadinv As System.Windows.Forms.NumericUpDown
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
    Friend WithEvents dgvinventario As System.Windows.Forms.DataGridView
    Friend WithEvents dgvvehiculos As System.Windows.Forms.DataGridView
    Friend WithEvents categoria As System.Windows.Forms.ComboBox
    Friend WithEvents bagrlista As System.Windows.Forms.Button
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents bdatagridinv As System.Windows.Forms.Button
    Friend WithEvents dgvreg As System.Windows.Forms.DataGridView
    Friend WithEvents beliminarreg As System.Windows.Forms.Button
    Friend WithEvents bdatagridveh As System.Windows.Forms.Button
    Friend WithEvents bagrlista2 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents blimpieza As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ccampos As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents tcriterio As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents blimpieza2 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ccampos2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnbuscar2 As System.Windows.Forms.Button
    Friend WithEvents tcriterio2 As System.Windows.Forms.TextBox
    Friend WithEvents breiniciar As System.Windows.Forms.Button
    Friend WithEvents beliminar As System.Windows.Forms.Button
    Friend WithEvents bagregar As System.Windows.Forms.Button
    Friend WithEvents pfoto4 As System.Windows.Forms.PictureBox
    Friend WithEvents pfoto3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents bimprimir As System.Windows.Forms.Button
    Friend WithEvents bregresar As System.Windows.Forms.Button
    Friend WithEvents tvacio As System.Windows.Forms.TextBox
    Friend WithEvents tpartner As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents rbexistvh As System.Windows.Forms.CheckBox
    Friend WithEvents estadovh As System.Windows.Forms.ComboBox
    Friend WithEvents dgvreg2 As System.Windows.Forms.DataGridView
    Friend WithEvents cestadpase As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents mensaje As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bagregadogeneral As System.Windows.Forms.Button
    Friend WithEvents descp1env As System.Windows.Forms.TextBox
    Friend WithEvents num1un As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents chknvregistro As System.Windows.Forms.CheckBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Cdestiny As System.Windows.Forms.ComboBox
    Friend WithEvents id2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cdestino2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unidad2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents observacion2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cdestino1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents observacion As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
