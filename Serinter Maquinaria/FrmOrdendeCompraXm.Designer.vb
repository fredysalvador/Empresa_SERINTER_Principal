<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOrdendeCompraXm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOrdendeCompraXm))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.cestadpase = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.treten = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.tdesc = New System.Windows.Forms.TextBox()
        Me.tproveedor = New System.Windows.Forms.ComboBox()
        Me.mensaje = New System.Windows.Forms.Label()
        Me.tformato = New System.Windows.Forms.TextBox()
        Me.tobservaciones = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.lblmenrete = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tnorden = New System.Windows.Forms.TextBox()
        Me.tproyecto = New System.Windows.Forms.TextBox()
        Me.tcargara = New System.Windows.Forms.TextBox()
        Me.tcanletras = New System.Windows.Forms.TextBox()
        Me.tdepartamento = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.rbdolares = New System.Windows.Forms.CheckBox()
        Me.rblempiras = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgvreg = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio_unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvreg2 = New System.Windows.Forms.DataGridView()
        Me.id2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unidad2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prec_unt2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.importe2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tdiae = New System.Windows.Forms.ComboBox()
        Me.tmese = New System.Windows.Forms.ComboBox()
        Me.tañoe = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblisv = New System.Windows.Forms.Label()
        Me.lbldesc = New System.Windows.Forms.Label()
        Me.lblsub = New System.Windows.Forms.Label()
        Me.bformenv = New System.Windows.Forms.Button()
        Me.bagregar = New System.Windows.Forms.Button()
        Me.bimprimir = New System.Windows.Forms.Button()
        Me.breiniciar = New System.Windows.Forms.Button()
        Me.beliminar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bregresar = New System.Windows.Forms.Button()
        Me.Fecha1 = New System.Windows.Forms.DateTimePicker()
        Me.Fecha2 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dgvreg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvreg2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(168, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 24)
        Me.Label2.TabIndex = 370
        Me.Label2.Text = "Ordenes de Compra"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(500, 609)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(98, 13)
        Me.Label32.TabIndex = 369
        Me.Label32.Text = "Estado de la Orden"
        '
        'cestadpase
        '
        Me.cestadpase.BackColor = System.Drawing.SystemColors.Window
        Me.cestadpase.Enabled = False
        Me.cestadpase.FormattingEnabled = True
        Me.cestadpase.Items.AddRange(New Object() {"En Transcurso", "En Uso"})
        Me.cestadpase.Location = New System.Drawing.Point(617, 603)
        Me.cestadpase.Name = "cestadpase"
        Me.cestadpase.Size = New System.Drawing.Size(209, 21)
        Me.cestadpase.TabIndex = 368
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(1057, 585)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(94, 13)
        Me.Label24.TabIndex = 364
        Me.Label24.Text = "Ingrese Retencion"
        '
        'treten
        '
        Me.treten.Location = New System.Drawing.Point(1060, 602)
        Me.treten.Name = "treten"
        Me.treten.Size = New System.Drawing.Size(167, 20)
        Me.treten.TabIndex = 363
        Me.treten.Text = "0"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(873, 586)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(97, 13)
        Me.Label22.TabIndex = 362
        Me.Label22.Text = "Ingrese Descuento"
        '
        'tdesc
        '
        Me.tdesc.Location = New System.Drawing.Point(876, 603)
        Me.tdesc.Name = "tdesc"
        Me.tdesc.Size = New System.Drawing.Size(167, 20)
        Me.tdesc.TabIndex = 361
        Me.tdesc.Text = "0"
        '
        'tproveedor
        '
        Me.tproveedor.BackColor = System.Drawing.SystemColors.Window
        Me.tproveedor.Enabled = False
        Me.tproveedor.FormattingEnabled = True
        Me.tproveedor.Location = New System.Drawing.Point(118, 191)
        Me.tproveedor.Name = "tproveedor"
        Me.tproveedor.Size = New System.Drawing.Size(257, 21)
        Me.tproveedor.TabIndex = 360
        '
        'mensaje
        '
        Me.mensaje.AutoSize = True
        Me.mensaje.Location = New System.Drawing.Point(219, 611)
        Me.mensaje.Name = "mensaje"
        Me.mensaje.Size = New System.Drawing.Size(47, 13)
        Me.mensaje.TabIndex = 359
        Me.mensaje.Text = "Mensaje"
        '
        'tformato
        '
        Me.tformato.Location = New System.Drawing.Point(844, 12)
        Me.tformato.Name = "tformato"
        Me.tformato.Size = New System.Drawing.Size(100, 20)
        Me.tformato.TabIndex = 358
        Me.tformato.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tformato.Visible = False
        '
        'tobservaciones
        '
        Me.tobservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tobservaciones.Enabled = False
        Me.tobservaciones.Location = New System.Drawing.Point(22, 318)
        Me.tobservaciones.Multiline = True
        Me.tobservaciones.Name = "tobservaciones"
        Me.tobservaciones.Size = New System.Drawing.Size(353, 58)
        Me.tobservaciones.TabIndex = 353
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label28.Location = New System.Drawing.Point(19, 302)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(81, 13)
        Me.Label28.TabIndex = 352
        Me.Label28.Text = "Observaciones:"
        '
        'lblmenrete
        '
        Me.lblmenrete.AutoSize = True
        Me.lblmenrete.Location = New System.Drawing.Point(37, 549)
        Me.lblmenrete.Name = "lblmenrete"
        Me.lblmenrete.Size = New System.Drawing.Size(13, 13)
        Me.lblmenrete.TabIndex = 351
        Me.lblmenrete.Text = "0"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(36, 595)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(13, 13)
        Me.lbltotal.TabIndex = 350
        Me.lbltotal.Text = "0"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(34, 529)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(108, 13)
        Me.Label23.TabIndex = 349
        Me.Label23.Text = "Menos Retencion 1%"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(34, 575)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(31, 13)
        Me.Label20.TabIndex = 348
        Me.Label20.Text = "Total"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(34, 483)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(47, 13)
        Me.Label21.TabIndex = 347
        Me.Label21.Text = "15% ISV"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(34, 436)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(59, 13)
        Me.Label19.TabIndex = 346
        Me.Label19.Text = "Descuento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 391)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 345
        Me.Label1.Text = "Subtotal"
        '
        'tnorden
        '
        Me.tnorden.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tnorden.Location = New System.Drawing.Point(227, 95)
        Me.tnorden.Name = "tnorden"
        Me.tnorden.Size = New System.Drawing.Size(92, 20)
        Me.tnorden.TabIndex = 343
        '
        'tproyecto
        '
        Me.tproyecto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tproyecto.Enabled = False
        Me.tproyecto.Location = New System.Drawing.Point(118, 272)
        Me.tproyecto.Name = "tproyecto"
        Me.tproyecto.Size = New System.Drawing.Size(257, 20)
        Me.tproyecto.TabIndex = 341
        '
        'tcargara
        '
        Me.tcargara.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tcargara.Enabled = False
        Me.tcargara.Location = New System.Drawing.Point(118, 246)
        Me.tcargara.Name = "tcargara"
        Me.tcargara.Size = New System.Drawing.Size(257, 20)
        Me.tcargara.TabIndex = 340
        '
        'tcanletras
        '
        Me.tcanletras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tcanletras.Enabled = False
        Me.tcanletras.Location = New System.Drawing.Point(118, 220)
        Me.tcanletras.Name = "tcanletras"
        Me.tcanletras.Size = New System.Drawing.Size(257, 20)
        Me.tcanletras.TabIndex = 339
        '
        'tdepartamento
        '
        Me.tdepartamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tdepartamento.Enabled = False
        Me.tdepartamento.Location = New System.Drawing.Point(118, 166)
        Me.tdepartamento.Name = "tdepartamento"
        Me.tdepartamento.Size = New System.Drawing.Size(257, 20)
        Me.tdepartamento.TabIndex = 338
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(19, 171)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 13)
        Me.Label15.TabIndex = 337
        Me.Label15.Text = "Departamento:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(19, 225)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(99, 13)
        Me.Label13.TabIndex = 336
        Me.Label13.Text = "Cantidad en Letras:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(19, 197)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 13)
        Me.Label14.TabIndex = 335
        Me.Label14.Text = "Paguese a:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(19, 251)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 13)
        Me.Label11.TabIndex = 334
        Me.Label11.Text = "Para Cargar a:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(19, 277)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 13)
        Me.Label12.TabIndex = 333
        Me.Label12.Text = "Proyecto:"
        '
        'rbdolares
        '
        Me.rbdolares.AutoSize = True
        Me.rbdolares.Enabled = False
        Me.rbdolares.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rbdolares.Location = New System.Drawing.Point(22, 141)
        Me.rbdolares.Name = "rbdolares"
        Me.rbdolares.Size = New System.Drawing.Size(62, 17)
        Me.rbdolares.TabIndex = 332
        Me.rbdolares.Text = "Dolares"
        Me.rbdolares.UseVisualStyleBackColor = True
        '
        'rblempiras
        '
        Me.rblempiras.AutoSize = True
        Me.rblempiras.Enabled = False
        Me.rblempiras.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rblempiras.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rblempiras.Location = New System.Drawing.Point(22, 118)
        Me.rblempiras.Name = "rblempiras"
        Me.rblempiras.Size = New System.Drawing.Size(68, 17)
        Me.rblempiras.TabIndex = 331
        Me.rblempiras.Text = "Lempiras"
        Me.rblempiras.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(168, 98)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 13)
        Me.Label10.TabIndex = 330
        Me.Label10.Text = "Nro.Orden"
        '
        'dgvreg
        '
        Me.dgvreg.AllowUserToAddRows = False
        Me.dgvreg.AllowUserToDeleteRows = False
        Me.dgvreg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvreg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.item, Me.cantidad, Me.unidad, Me.descripcion, Me.precio_unit, Me.importe})
        Me.dgvreg.Location = New System.Drawing.Point(381, 75)
        Me.dgvreg.Name = "dgvreg"
        Me.dgvreg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvreg.Size = New System.Drawing.Size(870, 249)
        Me.dgvreg.TabIndex = 371
        '
        'id
        '
        Me.id.HeaderText = "Id"
        Me.id.Name = "id"
        Me.id.Visible = False
        Me.id.Width = 30
        '
        'item
        '
        Me.item.HeaderText = "Item"
        Me.item.Name = "item"
        Me.item.Width = 40
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.Width = 70
        '
        'unidad
        '
        Me.unidad.HeaderText = "Unidad"
        Me.unidad.Name = "unidad"
        Me.unidad.Width = 70
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "Descripcion del Producto"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Width = 347
        '
        'precio_unit
        '
        Me.precio_unit.HeaderText = "Precio Unitario"
        Me.precio_unit.Name = "precio_unit"
        Me.precio_unit.Width = 150
        '
        'importe
        '
        Me.importe.HeaderText = "Importe"
        Me.importe.Name = "importe"
        Me.importe.Width = 150
        '
        'dgvreg2
        '
        Me.dgvreg2.AllowUserToAddRows = False
        Me.dgvreg2.AllowUserToDeleteRows = False
        Me.dgvreg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvreg2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id2, Me.item2, Me.cantidad2, Me.unidad2, Me.descripcion2, Me.prec_unt2, Me.importe2})
        Me.dgvreg2.Location = New System.Drawing.Point(381, 330)
        Me.dgvreg2.Name = "dgvreg2"
        Me.dgvreg2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvreg2.Size = New System.Drawing.Size(870, 249)
        Me.dgvreg2.TabIndex = 372
        '
        'id2
        '
        Me.id2.HeaderText = "Id"
        Me.id2.Name = "id2"
        Me.id2.Visible = False
        Me.id2.Width = 30
        '
        'item2
        '
        Me.item2.HeaderText = "Item"
        Me.item2.Name = "item2"
        Me.item2.ReadOnly = True
        Me.item2.Width = 40
        '
        'cantidad2
        '
        Me.cantidad2.HeaderText = "Cantidad"
        Me.cantidad2.Name = "cantidad2"
        Me.cantidad2.Width = 70
        '
        'unidad2
        '
        Me.unidad2.HeaderText = "Unidad"
        Me.unidad2.Name = "unidad2"
        Me.unidad2.Width = 70
        '
        'descripcion2
        '
        Me.descripcion2.HeaderText = "Descripcion del Producto"
        Me.descripcion2.Name = "descripcion2"
        Me.descripcion2.Width = 347
        '
        'prec_unt2
        '
        Me.prec_unt2.HeaderText = "Precio Unitario"
        Me.prec_unt2.Name = "prec_unt2"
        Me.prec_unt2.Width = 150
        '
        'importe2
        '
        Me.importe2.HeaderText = "Importe"
        Me.importe2.Name = "importe2"
        Me.importe2.ReadOnly = True
        Me.importe2.Width = 150
        '
        'tdiae
        '
        Me.tdiae.BackColor = System.Drawing.SystemColors.Window
        Me.tdiae.Enabled = False
        Me.tdiae.FormattingEnabled = True
        Me.tdiae.Items.AddRange(New Object() {"01", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.tdiae.Location = New System.Drawing.Point(395, 21)
        Me.tdiae.Name = "tdiae"
        Me.tdiae.Size = New System.Drawing.Size(51, 21)
        Me.tdiae.TabIndex = 376
        '
        'tmese
        '
        Me.tmese.BackColor = System.Drawing.SystemColors.Window
        Me.tmese.Enabled = False
        Me.tmese.FormattingEnabled = True
        Me.tmese.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.tmese.Location = New System.Drawing.Point(454, 22)
        Me.tmese.Name = "tmese"
        Me.tmese.Size = New System.Drawing.Size(86, 21)
        Me.tmese.TabIndex = 377
        '
        'tañoe
        '
        Me.tañoe.BackColor = System.Drawing.SystemColors.Window
        Me.tañoe.Enabled = False
        Me.tañoe.FormattingEnabled = True
        Me.tañoe.Items.AddRange(New Object() {"2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.tañoe.Location = New System.Drawing.Point(547, 21)
        Me.tañoe.Name = "tañoe"
        Me.tañoe.Size = New System.Drawing.Size(51, 21)
        Me.tañoe.TabIndex = 378
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(483, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 375
        Me.Label5.Text = "Mes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(560, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 374
        Me.Label4.Text = "Año"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(411, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 373
        Me.Label3.Text = "Dia"
        '
        'lblisv
        '
        Me.lblisv.AutoSize = True
        Me.lblisv.Location = New System.Drawing.Point(37, 502)
        Me.lblisv.Name = "lblisv"
        Me.lblisv.Size = New System.Drawing.Size(13, 13)
        Me.lblisv.TabIndex = 379
        Me.lblisv.Text = "0"
        '
        'lbldesc
        '
        Me.lbldesc.AutoSize = True
        Me.lbldesc.Location = New System.Drawing.Point(37, 457)
        Me.lbldesc.Name = "lbldesc"
        Me.lbldesc.Size = New System.Drawing.Size(13, 13)
        Me.lbldesc.TabIndex = 380
        Me.lbldesc.Text = "0"
        '
        'lblsub
        '
        Me.lblsub.AutoSize = True
        Me.lblsub.Location = New System.Drawing.Point(37, 410)
        Me.lblsub.Name = "lblsub"
        Me.lblsub.Size = New System.Drawing.Size(13, 13)
        Me.lblsub.TabIndex = 381
        Me.lblsub.Text = "0"
        '
        'bformenv
        '
        Me.bformenv.BackColor = System.Drawing.Color.White
        Me.bformenv.BackgroundImage = CType(resources.GetObject("bformenv.BackgroundImage"), System.Drawing.Image)
        Me.bformenv.Enabled = False
        Me.bformenv.Location = New System.Drawing.Point(289, 539)
        Me.bformenv.Name = "bformenv"
        Me.bformenv.Size = New System.Drawing.Size(64, 63)
        Me.bformenv.TabIndex = 384
        Me.bformenv.UseVisualStyleBackColor = False
        '
        'bagregar
        '
        Me.bagregar.BackgroundImage = CType(resources.GetObject("bagregar.BackgroundImage"), System.Drawing.Image)
        Me.bagregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bagregar.Enabled = False
        Me.bagregar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bagregar.Location = New System.Drawing.Point(216, 402)
        Me.bagregar.Name = "bagregar"
        Me.bagregar.Size = New System.Drawing.Size(64, 63)
        Me.bagregar.TabIndex = 383
        Me.bagregar.UseVisualStyleBackColor = True
        '
        'bimprimir
        '
        Me.bimprimir.BackColor = System.Drawing.Color.White
        Me.bimprimir.BackgroundImage = CType(resources.GetObject("bimprimir.BackgroundImage"), System.Drawing.Image)
        Me.bimprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bimprimir.Enabled = False
        Me.bimprimir.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bimprimir.Location = New System.Drawing.Point(289, 401)
        Me.bimprimir.Name = "bimprimir"
        Me.bimprimir.Size = New System.Drawing.Size(64, 63)
        Me.bimprimir.TabIndex = 357
        Me.bimprimir.UseVisualStyleBackColor = False
        '
        'breiniciar
        '
        Me.breiniciar.BackColor = System.Drawing.Color.White
        Me.breiniciar.BackgroundImage = CType(resources.GetObject("breiniciar.BackgroundImage"), System.Drawing.Image)
        Me.breiniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.breiniciar.Enabled = False
        Me.breiniciar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.breiniciar.Location = New System.Drawing.Point(289, 470)
        Me.breiniciar.Name = "breiniciar"
        Me.breiniciar.Size = New System.Drawing.Size(64, 63)
        Me.breiniciar.TabIndex = 356
        Me.breiniciar.UseVisualStyleBackColor = False
        '
        'beliminar
        '
        Me.beliminar.BackgroundImage = CType(resources.GetObject("beliminar.BackgroundImage"), System.Drawing.Image)
        Me.beliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.beliminar.Enabled = False
        Me.beliminar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.beliminar.Location = New System.Drawing.Point(216, 471)
        Me.beliminar.Name = "beliminar"
        Me.beliminar.Size = New System.Drawing.Size(64, 63)
        Me.beliminar.TabIndex = 355
        Me.beliminar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(21, 51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(141, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 344
        Me.PictureBox1.TabStop = False
        '
        'bregresar
        '
        Me.bregresar.BackgroundImage = CType(resources.GetObject("bregresar.BackgroundImage"), System.Drawing.Image)
        Me.bregresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bregresar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bregresar.Location = New System.Drawing.Point(217, 539)
        Me.bregresar.Name = "bregresar"
        Me.bregresar.Size = New System.Drawing.Size(63, 63)
        Me.bregresar.TabIndex = 342
        Me.bregresar.UseVisualStyleBackColor = True
        '
        'Fecha1
        '
        Me.Fecha1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha1.Location = New System.Drawing.Point(142, 139)
        Me.Fecha1.Name = "Fecha1"
        Me.Fecha1.Size = New System.Drawing.Size(81, 20)
        Me.Fecha1.TabIndex = 385
        '
        'Fecha2
        '
        Me.Fecha2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha2.Location = New System.Drawing.Point(265, 140)
        Me.Fecha2.Name = "Fecha2"
        Me.Fecha2.Size = New System.Drawing.Size(81, 20)
        Me.Fecha2.TabIndex = 386
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(134, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 13)
        Me.Label6.TabIndex = 387
        Me.Label6.Text = "Fecha de Solicitud"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(240, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 13)
        Me.Label7.TabIndex = 388
        Me.Label7.Text = "Fecha Requerida Minima"
        '
        'FrmOrdendeCompraXm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1259, 633)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Fecha2)
        Me.Controls.Add(Me.Fecha1)
        Me.Controls.Add(Me.bformenv)
        Me.Controls.Add(Me.bagregar)
        Me.Controls.Add(Me.lblsub)
        Me.Controls.Add(Me.lbldesc)
        Me.Controls.Add(Me.lblisv)
        Me.Controls.Add(Me.tdiae)
        Me.Controls.Add(Me.tmese)
        Me.Controls.Add(Me.tañoe)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvreg2)
        Me.Controls.Add(Me.dgvreg)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.cestadpase)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.treten)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.tdesc)
        Me.Controls.Add(Me.tproveedor)
        Me.Controls.Add(Me.mensaje)
        Me.Controls.Add(Me.tformato)
        Me.Controls.Add(Me.bimprimir)
        Me.Controls.Add(Me.breiniciar)
        Me.Controls.Add(Me.beliminar)
        Me.Controls.Add(Me.tobservaciones)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.lblmenrete)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.tnorden)
        Me.Controls.Add(Me.bregresar)
        Me.Controls.Add(Me.tproyecto)
        Me.Controls.Add(Me.tcargara)
        Me.Controls.Add(Me.tcanletras)
        Me.Controls.Add(Me.tdepartamento)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.rbdolares)
        Me.Controls.Add(Me.rblempiras)
        Me.Controls.Add(Me.Label10)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmOrdendeCompraXm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "2"
        CType(Me.dgvreg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvreg2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents cestadpase As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents treten As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents tdesc As System.Windows.Forms.TextBox
    Friend WithEvents tproveedor As System.Windows.Forms.ComboBox
    Friend WithEvents mensaje As System.Windows.Forms.Label
    Friend WithEvents tformato As System.Windows.Forms.TextBox
    Friend WithEvents bimprimir As System.Windows.Forms.Button
    Friend WithEvents breiniciar As System.Windows.Forms.Button
    Friend WithEvents beliminar As System.Windows.Forms.Button
    Friend WithEvents tobservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents lblmenrete As System.Windows.Forms.Label
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents tnorden As System.Windows.Forms.TextBox
    Friend WithEvents bregresar As System.Windows.Forms.Button
    Friend WithEvents tproyecto As System.Windows.Forms.TextBox
    Friend WithEvents tcargara As System.Windows.Forms.TextBox
    Friend WithEvents tcanletras As System.Windows.Forms.TextBox
    Friend WithEvents tdepartamento As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents rbdolares As System.Windows.Forms.CheckBox
    Friend WithEvents rblempiras As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dgvreg As System.Windows.Forms.DataGridView
    Friend WithEvents dgvreg2 As System.Windows.Forms.DataGridView
    Friend WithEvents tdiae As System.Windows.Forms.ComboBox
    Friend WithEvents tmese As System.Windows.Forms.ComboBox
    Friend WithEvents tañoe As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblisv As System.Windows.Forms.Label
    Friend WithEvents lbldesc As System.Windows.Forms.Label
    Friend WithEvents lblsub As System.Windows.Forms.Label
    Friend WithEvents bagregar As System.Windows.Forms.Button
    Friend WithEvents bformenv As System.Windows.Forms.Button
    Friend WithEvents id2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unidad2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prec_unt2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents importe2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precio_unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Fecha2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
