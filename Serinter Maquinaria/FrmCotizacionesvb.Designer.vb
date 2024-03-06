<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCotizacionesvb
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCotizacionesvb))
        Me.Label32 = New System.Windows.Forms.Label()
        Me.trtn = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tcotno = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tcliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tcontacto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tdireccion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tciudad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tterminopag = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvreg = New System.Windows.Forms.DataGridView()
        Me.ID1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tobservacion = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tdesc = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.tdescripcion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tpreciounit = New System.Windows.Forms.TextBox()
        Me.tcantidad = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.mensaje = New System.Windows.Forms.Label()
        Me.dgvreg2 = New System.Windows.Forms.DataGridView()
        Me.ID2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Item2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unidad2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Valor2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorT2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.fechahora = New System.Windows.Forms.Label()
        Me.tflete = New System.Windows.Forms.TextBox()
        Me.rbdolares = New System.Windows.Forms.CheckBox()
        Me.rblempiras = New System.Windows.Forms.CheckBox()
        Me.lblflete = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.lblsub = New System.Windows.Forms.Label()
        Me.lbldesc = New System.Windows.Forms.Label()
        Me.lblisv = New System.Windows.Forms.Label()
        Me.lblmenrete = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.chknvregistro = New System.Windows.Forms.CheckBox()
        Me.bimprimir = New System.Windows.Forms.Button()
        Me.breiniciar = New System.Windows.Forms.Button()
        Me.beliminar = New System.Windows.Forms.Button()
        Me.bagregar = New System.Windows.Forms.Button()
        Me.beliminarreg = New System.Windows.Forms.Button()
        Me.bagrlista2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvreg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tcantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvreg2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(184, 40)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(129, 24)
        Me.Label32.TabIndex = 476
        Me.Label32.Text = "Cotizaciones"
        '
        'trtn
        '
        Me.trtn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.trtn.Enabled = False
        Me.trtn.Location = New System.Drawing.Point(325, 104)
        Me.trtn.Name = "trtn"
        Me.trtn.Size = New System.Drawing.Size(132, 20)
        Me.trtn.TabIndex = 473
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(363, 88)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 13)
        Me.Label14.TabIndex = 474
        Me.Label14.Text = "RTN:"
        '
        'tcotno
        '
        Me.tcotno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tcotno.Location = New System.Drawing.Point(147, 128)
        Me.tcotno.Name = "tcotno"
        Me.tcotno.Size = New System.Drawing.Size(132, 20)
        Me.tcotno.TabIndex = 477
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(174, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 478
        Me.Label1.Text = "Cotizacion No:"
        '
        'tcliente
        '
        Me.tcliente.Enabled = False
        Me.tcliente.Location = New System.Drawing.Point(146, 154)
        Me.tcliente.Name = "tcliente"
        Me.tcliente.Size = New System.Drawing.Size(132, 20)
        Me.tcliente.TabIndex = 479
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 480
        Me.Label2.Text = "Cliente:"
        '
        'tcontacto
        '
        Me.tcontacto.Enabled = False
        Me.tcontacto.Location = New System.Drawing.Point(146, 178)
        Me.tcontacto.Name = "tcontacto"
        Me.tcontacto.Size = New System.Drawing.Size(132, 20)
        Me.tcontacto.TabIndex = 481
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 482
        Me.Label3.Text = "Contacto:"
        '
        'tdireccion
        '
        Me.tdireccion.Enabled = False
        Me.tdireccion.Location = New System.Drawing.Point(146, 203)
        Me.tdireccion.Name = "tdireccion"
        Me.tdireccion.Size = New System.Drawing.Size(132, 20)
        Me.tdireccion.TabIndex = 483
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 484
        Me.Label4.Text = "Direccion:"
        '
        'tciudad
        '
        Me.tciudad.Enabled = False
        Me.tciudad.Location = New System.Drawing.Point(146, 229)
        Me.tciudad.Name = "tciudad"
        Me.tciudad.Size = New System.Drawing.Size(132, 20)
        Me.tciudad.TabIndex = 485
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 232)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 486
        Me.Label5.Text = "Ciudad:"
        '
        'tterminopag
        '
        Me.tterminopag.Enabled = False
        Me.tterminopag.Location = New System.Drawing.Point(146, 255)
        Me.tterminopag.Name = "tterminopag"
        Me.tterminopag.Size = New System.Drawing.Size(132, 20)
        Me.tterminopag.TabIndex = 487
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 258)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 13)
        Me.Label6.TabIndex = 488
        Me.Label6.Text = "Terminos de Pago:"
        '
        'dgvreg
        '
        Me.dgvreg.AllowUserToAddRows = False
        Me.dgvreg.AllowUserToDeleteRows = False
        Me.dgvreg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvreg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID1, Me.Item, Me.Unidad, Me.Descripcion, Me.Valor, Me.ValorT})
        Me.dgvreg.Location = New System.Drawing.Point(318, 266)
        Me.dgvreg.MultiSelect = False
        Me.dgvreg.Name = "dgvreg"
        Me.dgvreg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvreg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvreg.Size = New System.Drawing.Size(890, 131)
        Me.dgvreg.TabIndex = 0
        '
        'ID1
        '
        Me.ID1.HeaderText = "id"
        Me.ID1.Name = "ID1"
        Me.ID1.ReadOnly = True
        Me.ID1.Visible = False
        '
        'Item
        '
        Me.Item.HeaderText = "item"
        Me.Item.Name = "Item"
        Me.Item.ReadOnly = True
        Me.Item.Width = 40
        '
        'Unidad
        '
        Me.Unidad.HeaderText = "unidad"
        Me.Unidad.Name = "Unidad"
        Me.Unidad.Width = 59
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Width = 300
        '
        'Valor
        '
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Valor.DefaultCellStyle = DataGridViewCellStyle1
        Me.Valor.HeaderText = "valor_unidad"
        Me.Valor.Name = "Valor"
        Me.Valor.Width = 224
        '
        'ValorT
        '
        Me.ValorT.HeaderText = "valor_total"
        Me.ValorT.Name = "ValorT"
        Me.ValorT.ReadOnly = True
        Me.ValorT.Width = 224
        '
        'dtpfecha
        '
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha.Location = New System.Drawing.Point(478, 104)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(101, 20)
        Me.dtpfecha.TabIndex = 578
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(504, 88)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 13)
        Me.Label16.TabIndex = 577
        Me.Label16.Text = "Fecha:"
        '
        'tobservacion
        '
        Me.tobservacion.Enabled = False
        Me.tobservacion.Location = New System.Drawing.Point(324, 153)
        Me.tobservacion.Multiline = True
        Me.tobservacion.Name = "tobservacion"
        Me.tobservacion.Size = New System.Drawing.Size(342, 98)
        Me.tobservacion.TabIndex = 630
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(324, 137)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(70, 13)
        Me.Label19.TabIndex = 631
        Me.Label19.Text = "Observación:"
        '
        'tdesc
        '
        Me.tdesc.Location = New System.Drawing.Point(955, 229)
        Me.tdesc.Name = "tdesc"
        Me.tdesc.Size = New System.Drawing.Size(100, 20)
        Me.tdesc.TabIndex = 632
        Me.tdesc.Text = "0"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(1106, 214)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(33, 13)
        Me.Label20.TabIndex = 635
        Me.Label20.Text = "Flete:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(969, 213)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(62, 13)
        Me.Label22.TabIndex = 636
        Me.Label22.Text = "Descuento:"
        '
        'tdescripcion
        '
        Me.tdescripcion.Location = New System.Drawing.Point(986, 99)
        Me.tdescripcion.Name = "tdescripcion"
        Me.tdescripcion.Size = New System.Drawing.Size(189, 20)
        Me.tdescripcion.TabIndex = 641
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(874, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 642
        Me.Label7.Text = "Descripción:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(874, 153)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 644
        Me.Label8.Text = "Precio Unitario:"
        '
        'tpreciounit
        '
        Me.tpreciounit.Location = New System.Drawing.Point(986, 151)
        Me.tpreciounit.Name = "tpreciounit"
        Me.tpreciounit.Size = New System.Drawing.Size(189, 20)
        Me.tpreciounit.TabIndex = 643
        '
        'tcantidad
        '
        Me.tcantidad.Location = New System.Drawing.Point(986, 125)
        Me.tcantidad.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.tcantidad.Name = "tcantidad"
        Me.tcantidad.Size = New System.Drawing.Size(89, 20)
        Me.tcantidad.TabIndex = 645
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(874, 127)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 646
        Me.Label9.Text = "Cantidad:"
        '
        'mensaje
        '
        Me.mensaje.AutoSize = True
        Me.mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mensaje.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.mensaje.Location = New System.Drawing.Point(445, 606)
        Me.mensaje.Name = "mensaje"
        Me.mensaje.Size = New System.Drawing.Size(75, 16)
        Me.mensaje.TabIndex = 647
        Me.mensaje.Text = "Mensajes"
        '
        'dgvreg2
        '
        Me.dgvreg2.AllowUserToAddRows = False
        Me.dgvreg2.AllowUserToDeleteRows = False
        Me.dgvreg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvreg2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID2, Me.Item2, Me.Unidad2, Me.Descripcion2, Me.Valor2, Me.ValorT2})
        Me.dgvreg2.Location = New System.Drawing.Point(317, 411)
        Me.dgvreg2.MultiSelect = False
        Me.dgvreg2.Name = "dgvreg2"
        Me.dgvreg2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvreg2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvreg2.Size = New System.Drawing.Size(890, 131)
        Me.dgvreg2.TabIndex = 650
        '
        'ID2
        '
        Me.ID2.HeaderText = "id"
        Me.ID2.Name = "ID2"
        Me.ID2.Visible = False
        '
        'Item2
        '
        Me.Item2.HeaderText = "item"
        Me.Item2.Name = "Item2"
        Me.Item2.ReadOnly = True
        Me.Item2.Width = 40
        '
        'Unidad2
        '
        Me.Unidad2.HeaderText = "unidad"
        Me.Unidad2.Name = "Unidad2"
        Me.Unidad2.Width = 59
        '
        'Descripcion2
        '
        Me.Descripcion2.HeaderText = "descripcion"
        Me.Descripcion2.Name = "Descripcion2"
        Me.Descripcion2.Width = 300
        '
        'Valor2
        '
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Valor2.DefaultCellStyle = DataGridViewCellStyle2
        Me.Valor2.HeaderText = "valor_unidad"
        Me.Valor2.Name = "Valor2"
        Me.Valor2.Width = 224
        '
        'ValorT2
        '
        Me.ValorT2.HeaderText = "valor_total"
        Me.ValorT2.Name = "ValorT2"
        Me.ValorT2.ReadOnly = True
        Me.ValorT2.Width = 224
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'fechahora
        '
        Me.fechahora.AutoSize = True
        Me.fechahora.Location = New System.Drawing.Point(372, 48)
        Me.fechahora.Name = "fechahora"
        Me.fechahora.Size = New System.Drawing.Size(39, 13)
        Me.fechahora.TabIndex = 657
        Me.fechahora.Text = "Label1"
        '
        'tflete
        '
        Me.tflete.Location = New System.Drawing.Point(1072, 229)
        Me.tflete.Name = "tflete"
        Me.tflete.Size = New System.Drawing.Size(100, 20)
        Me.tflete.TabIndex = 658
        Me.tflete.Text = "0"
        '
        'rbdolares
        '
        Me.rbdolares.AutoSize = True
        Me.rbdolares.Enabled = False
        Me.rbdolares.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rbdolares.Location = New System.Drawing.Point(26, 129)
        Me.rbdolares.Name = "rbdolares"
        Me.rbdolares.Size = New System.Drawing.Size(62, 17)
        Me.rbdolares.TabIndex = 660
        Me.rbdolares.Text = "Dolares"
        Me.rbdolares.UseVisualStyleBackColor = True
        '
        'rblempiras
        '
        Me.rblempiras.AutoSize = True
        Me.rblempiras.Enabled = False
        Me.rblempiras.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rblempiras.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rblempiras.Location = New System.Drawing.Point(26, 106)
        Me.rblempiras.Name = "rblempiras"
        Me.rblempiras.Size = New System.Drawing.Size(68, 17)
        Me.rblempiras.TabIndex = 659
        Me.rblempiras.Text = "Lempiras"
        Me.rblempiras.UseVisualStyleBackColor = True
        '
        'lblflete
        '
        Me.lblflete.AutoSize = True
        Me.lblflete.Location = New System.Drawing.Point(41, 454)
        Me.lblflete.Name = "lblflete"
        Me.lblflete.Size = New System.Drawing.Size(0, 13)
        Me.lblflete.TabIndex = 628
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.Location = New System.Drawing.Point(43, 430)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(33, 13)
        Me.lbl5.TabIndex = 629
        Me.lbl5.Text = "Flete:"
        '
        'lblsub
        '
        Me.lblsub.AutoSize = True
        Me.lblsub.Location = New System.Drawing.Point(43, 310)
        Me.lblsub.Name = "lblsub"
        Me.lblsub.Size = New System.Drawing.Size(13, 13)
        Me.lblsub.TabIndex = 680
        Me.lblsub.Text = "0"
        '
        'lbldesc
        '
        Me.lbldesc.AutoSize = True
        Me.lbldesc.Location = New System.Drawing.Point(43, 357)
        Me.lbldesc.Name = "lbldesc"
        Me.lbldesc.Size = New System.Drawing.Size(13, 13)
        Me.lbldesc.TabIndex = 679
        Me.lbldesc.Text = "0"
        '
        'lblisv
        '
        Me.lblisv.AutoSize = True
        Me.lblisv.Location = New System.Drawing.Point(43, 403)
        Me.lblisv.Name = "lblisv"
        Me.lblisv.Size = New System.Drawing.Size(13, 13)
        Me.lblisv.TabIndex = 678
        Me.lblisv.Text = "0"
        '
        'lblmenrete
        '
        Me.lblmenrete.AutoSize = True
        Me.lblmenrete.Location = New System.Drawing.Point(43, 450)
        Me.lblmenrete.Name = "lblmenrete"
        Me.lblmenrete.Size = New System.Drawing.Size(13, 13)
        Me.lblmenrete.TabIndex = 677
        Me.lblmenrete.Text = "0"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(42, 496)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(13, 13)
        Me.lbltotal.TabIndex = 676
        Me.lbltotal.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(40, 476)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(31, 13)
        Me.Label15.TabIndex = 674
        Me.Label15.Text = "Total"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(40, 384)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(47, 13)
        Me.Label17.TabIndex = 673
        Me.Label17.Text = "15% ISV"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(40, 336)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(59, 13)
        Me.Label18.TabIndex = 672
        Me.Label18.Text = "Descuento"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(40, 291)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(46, 13)
        Me.Label24.TabIndex = 671
        Me.Label24.Text = "Subtotal"
        '
        'chknvregistro
        '
        Me.chknvregistro.AutoSize = True
        Me.chknvregistro.Location = New System.Drawing.Point(150, 84)
        Me.chknvregistro.Name = "chknvregistro"
        Me.chknvregistro.Size = New System.Drawing.Size(100, 17)
        Me.chknvregistro.TabIndex = 681
        Me.chknvregistro.Text = "Nuevo Registro"
        Me.chknvregistro.UseVisualStyleBackColor = True
        '
        'bimprimir
        '
        Me.bimprimir.BackColor = System.Drawing.Color.White
        Me.bimprimir.BackgroundImage = CType(resources.GetObject("bimprimir.BackgroundImage"), System.Drawing.Image)
        Me.bimprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bimprimir.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bimprimir.Location = New System.Drawing.Point(304, 559)
        Me.bimprimir.Name = "bimprimir"
        Me.bimprimir.Size = New System.Drawing.Size(64, 63)
        Me.bimprimir.TabIndex = 655
        Me.bimprimir.Text = "s"
        Me.bimprimir.UseVisualStyleBackColor = False
        '
        'breiniciar
        '
        Me.breiniciar.BackColor = System.Drawing.Color.White
        Me.breiniciar.BackgroundImage = CType(resources.GetObject("breiniciar.BackgroundImage"), System.Drawing.Image)
        Me.breiniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.breiniciar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.breiniciar.Location = New System.Drawing.Point(234, 559)
        Me.breiniciar.Name = "breiniciar"
        Me.breiniciar.Size = New System.Drawing.Size(64, 63)
        Me.breiniciar.TabIndex = 654
        Me.breiniciar.UseVisualStyleBackColor = False
        '
        'beliminar
        '
        Me.beliminar.BackgroundImage = CType(resources.GetObject("beliminar.BackgroundImage"), System.Drawing.Image)
        Me.beliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.beliminar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.beliminar.Location = New System.Drawing.Point(164, 559)
        Me.beliminar.Name = "beliminar"
        Me.beliminar.Size = New System.Drawing.Size(64, 63)
        Me.beliminar.TabIndex = 653
        Me.beliminar.UseVisualStyleBackColor = True
        '
        'bagregar
        '
        Me.bagregar.BackgroundImage = CType(resources.GetObject("bagregar.BackgroundImage"), System.Drawing.Image)
        Me.bagregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bagregar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bagregar.Location = New System.Drawing.Point(94, 559)
        Me.bagregar.Name = "bagregar"
        Me.bagregar.Size = New System.Drawing.Size(64, 63)
        Me.bagregar.TabIndex = 652
        Me.bagregar.UseVisualStyleBackColor = True
        '
        'beliminarreg
        '
        Me.beliminarreg.BackColor = System.Drawing.Color.White
        Me.beliminarreg.BackgroundImage = CType(resources.GetObject("beliminarreg.BackgroundImage"), System.Drawing.Image)
        Me.beliminarreg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.beliminarreg.Location = New System.Drawing.Point(24, 559)
        Me.beliminarreg.Name = "beliminarreg"
        Me.beliminarreg.Size = New System.Drawing.Size(64, 63)
        Me.beliminarreg.TabIndex = 651
        Me.beliminarreg.UseVisualStyleBackColor = False
        '
        'bagrlista2
        '
        Me.bagrlista2.BackColor = System.Drawing.Color.White
        Me.bagrlista2.BackgroundImage = CType(resources.GetObject("bagrlista2.BackgroundImage"), System.Drawing.Image)
        Me.bagrlista2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bagrlista2.Location = New System.Drawing.Point(879, 20)
        Me.bagrlista2.Name = "bagrlista2"
        Me.bagrlista2.Size = New System.Drawing.Size(64, 63)
        Me.bagrlista2.TabIndex = 639
        Me.bagrlista2.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(26, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(141, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 475
        Me.PictureBox1.TabStop = False
        '
        'FrmCotizacionesvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1259, 633)
        Me.Controls.Add(Me.chknvregistro)
        Me.Controls.Add(Me.lblsub)
        Me.Controls.Add(Me.lbldesc)
        Me.Controls.Add(Me.lblisv)
        Me.Controls.Add(Me.lblmenrete)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.rbdolares)
        Me.Controls.Add(Me.rblempiras)
        Me.Controls.Add(Me.tflete)
        Me.Controls.Add(Me.fechahora)
        Me.Controls.Add(Me.bimprimir)
        Me.Controls.Add(Me.breiniciar)
        Me.Controls.Add(Me.beliminar)
        Me.Controls.Add(Me.bagregar)
        Me.Controls.Add(Me.beliminarreg)
        Me.Controls.Add(Me.dgvreg2)
        Me.Controls.Add(Me.mensaje)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tcantidad)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tpreciounit)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tdescripcion)
        Me.Controls.Add(Me.bagrlista2)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.tdesc)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.tobservacion)
        Me.Controls.Add(Me.lbl5)
        Me.Controls.Add(Me.lblflete)
        Me.Controls.Add(Me.dtpfecha)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.dgvreg)
        Me.Controls.Add(Me.tterminopag)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tciudad)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tdireccion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tcontacto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tcliente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tcotno)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.trtn)
        Me.Controls.Add(Me.Label14)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCotizacionesvb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCotizacionesvb"
        CType(Me.dgvreg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tcantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvreg2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents trtn As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tcotno As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tcliente As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tcontacto As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tdireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tciudad As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tterminopag As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dgvreg As System.Windows.Forms.DataGridView
    Friend WithEvents dtpfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents tobservacion As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents tdesc As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents bagrlista2 As System.Windows.Forms.Button
    Friend WithEvents tdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tpreciounit As System.Windows.Forms.TextBox
    Friend WithEvents tcantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents mensaje As System.Windows.Forms.Label
    Friend WithEvents dgvreg2 As System.Windows.Forms.DataGridView
    Friend WithEvents bimprimir As System.Windows.Forms.Button
    Friend WithEvents breiniciar As System.Windows.Forms.Button
    Friend WithEvents beliminar As System.Windows.Forms.Button
    Friend WithEvents bagregar As System.Windows.Forms.Button
    Friend WithEvents beliminarreg As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents fechahora As System.Windows.Forms.Label
    Friend WithEvents tflete As System.Windows.Forms.TextBox
    Friend WithEvents rbdolares As System.Windows.Forms.CheckBox
    Friend WithEvents rblempiras As System.Windows.Forms.CheckBox
    Friend WithEvents lblflete As System.Windows.Forms.Label
    Friend WithEvents lbl5 As System.Windows.Forms.Label
    Friend WithEvents lblsub As System.Windows.Forms.Label
    Friend WithEvents lbldesc As System.Windows.Forms.Label
    Friend WithEvents lblisv As System.Windows.Forms.Label
    Friend WithEvents lblmenrete As System.Windows.Forms.Label
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ID2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Item2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Unidad2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Valor2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorT2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chknvregistro As System.Windows.Forms.CheckBox
    Friend WithEvents ID1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Item As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Unidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Valor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorT As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
