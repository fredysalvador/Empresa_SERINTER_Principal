<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIngresoVehiculos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIngresoVehiculos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tcodv = New System.Windows.Forms.TextBox()
        Me.tplacveh = New System.Windows.Forms.TextBox()
        Me.tcolorvh = New System.Windows.Forms.TextBox()
        Me.tmodelovh = New System.Windows.Forms.TextBox()
        Me.tmarcavh = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvvehiculos = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.testadovh = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ccampos = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tcriterio = New System.Windows.Forms.TextBox()
        Me.tpropetarios = New System.Windows.Forms.ComboBox()
        Me.tpropietario = New System.Windows.Forms.Label()
        Me.tcondicion = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tpreciocompra = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtpcompra = New System.Windows.Forms.DateTimePicker()
        Me.tubicacion = New System.Windows.Forms.ComboBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.mensaje = New System.Windows.Forms.Label()
        Me.tnomotor = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tdimenancho = New System.Windows.Forms.TextBox()
        Me.tdimenlargo = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tdimenpeso = New System.Windows.Forms.TextBox()
        Me.tdimenalto = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.ttipomaq = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.tyearfab = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.ttipotrans = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pfoto2 = New System.Windows.Forms.PictureBox()
        Me.pfoto = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.bregresar = New System.Windows.Forms.Button()
        Me.blimpieza = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.bdatagrid = New System.Windows.Forms.Button()
        Me.breiniciar = New System.Windows.Forms.Button()
        Me.beliminar = New System.Windows.Forms.Button()
        Me.bagregar = New System.Windows.Forms.Button()
        Me.btimpresion = New System.Windows.Forms.Button()
        CType(Me.dgvvehiculos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pfoto2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pfoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo de Maquina:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Placa Vehiculo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(77, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Color:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Modelo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Marca:"
        '
        'tcodv
        '
        Me.tcodv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tcodv.Location = New System.Drawing.Point(118, 34)
        Me.tcodv.Name = "tcodv"
        Me.tcodv.Size = New System.Drawing.Size(171, 20)
        Me.tcodv.TabIndex = 351
        '
        'tplacveh
        '
        Me.tplacveh.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tplacveh.Location = New System.Drawing.Point(118, 63)
        Me.tplacveh.Name = "tplacveh"
        Me.tplacveh.Size = New System.Drawing.Size(171, 20)
        Me.tplacveh.TabIndex = 352
        '
        'tcolorvh
        '
        Me.tcolorvh.Location = New System.Drawing.Point(117, 73)
        Me.tcolorvh.Name = "tcolorvh"
        Me.tcolorvh.Size = New System.Drawing.Size(171, 20)
        Me.tcolorvh.TabIndex = 353
        '
        'tmodelovh
        '
        Me.tmodelovh.Location = New System.Drawing.Point(118, 182)
        Me.tmodelovh.Name = "tmodelovh"
        Me.tmodelovh.Size = New System.Drawing.Size(171, 20)
        Me.tmodelovh.TabIndex = 355
        '
        'tmarcavh
        '
        Me.tmarcavh.Location = New System.Drawing.Point(118, 151)
        Me.tmarcavh.Name = "tmarcavh"
        Me.tmarcavh.Size = New System.Drawing.Size(171, 20)
        Me.tmarcavh.TabIndex = 354
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(155, 407)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 357
        Me.Label4.Text = "foto#2"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 407)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 356
        Me.Label7.Text = "foto #1"
        '
        'dgvvehiculos
        '
        Me.dgvvehiculos.AllowUserToAddRows = False
        Me.dgvvehiculos.AllowUserToDeleteRows = False
        Me.dgvvehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvvehiculos.Location = New System.Drawing.Point(314, 78)
        Me.dgvvehiculos.MultiSelect = False
        Me.dgvvehiculos.Name = "dgvvehiculos"
        Me.dgvvehiculos.ReadOnly = True
        Me.dgvvehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvvehiculos.Size = New System.Drawing.Size(954, 434)
        Me.dgvvehiculos.TabIndex = 358
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 13)
        Me.Label8.TabIndex = 365
        Me.Label8.Text = "Estado Maquinaria:"
        '
        'testadovh
        '
        Me.testadovh.FormattingEnabled = True
        Me.testadovh.Items.AddRange(New Object() {"Disponible", "Utilizado", "Mantenimiento", "Dañado", "N/A"})
        Me.testadovh.Location = New System.Drawing.Point(118, 90)
        Me.testadovh.Name = "testadovh"
        Me.testadovh.Size = New System.Drawing.Size(171, 21)
        Me.testadovh.TabIndex = 366
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label10.Location = New System.Drawing.Point(881, 563)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 24)
        Me.Label10.TabIndex = 375
        Me.Label10.Text = "Limpiar"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(869, 518)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(192, 24)
        Me.Label9.TabIndex = 373
        Me.Label9.Text = "Criterio de Busqueda:"
        '
        'ccampos
        '
        Me.ccampos.FormattingEnabled = True
        Me.ccampos.Items.AddRange(New Object() {"codigo_vh", "tipo_maquina  ", "placa_vh", "ubicacion", "estado_vh", "marca"})
        Me.ccampos.Location = New System.Drawing.Point(1067, 523)
        Me.ccampos.Name = "ccampos"
        Me.ccampos.Size = New System.Drawing.Size(174, 21)
        Me.ccampos.TabIndex = 372
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label11.Location = New System.Drawing.Point(967, 563)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 24)
        Me.Label11.TabIndex = 371
        Me.Label11.Text = "Buscar"
        '
        'tcriterio
        '
        Me.tcriterio.Location = New System.Drawing.Point(1067, 609)
        Me.tcriterio.Name = "tcriterio"
        Me.tcriterio.Size = New System.Drawing.Size(155, 20)
        Me.tcriterio.TabIndex = 369
        '
        'tpropetarios
        '
        Me.tpropetarios.FormattingEnabled = True
        Me.tpropetarios.Items.AddRange(New Object() {"COPRECA", "SERINTER"})
        Me.tpropetarios.Location = New System.Drawing.Point(118, 213)
        Me.tpropetarios.Name = "tpropetarios"
        Me.tpropetarios.Size = New System.Drawing.Size(171, 21)
        Me.tpropetarios.TabIndex = 486
        '
        'tpropietario
        '
        Me.tpropietario.AutoSize = True
        Me.tpropietario.Location = New System.Drawing.Point(10, 217)
        Me.tpropietario.Name = "tpropietario"
        Me.tpropietario.Size = New System.Drawing.Size(60, 13)
        Me.tpropietario.TabIndex = 485
        Me.tpropietario.Text = "Propietario:"
        '
        'tcondicion
        '
        Me.tcondicion.Location = New System.Drawing.Point(12, 293)
        Me.tcondicion.Multiline = True
        Me.tcondicion.Name = "tcondicion"
        Me.tcondicion.Size = New System.Drawing.Size(276, 42)
        Me.tcondicion.TabIndex = 483
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 347)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 13)
        Me.Label13.TabIndex = 481
        Me.Label13.Text = "Fecha Compra:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(9, 277)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 13)
        Me.Label14.TabIndex = 480
        Me.Label14.Text = "Condicion Maquinaria:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(9, 251)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 13)
        Me.Label15.TabIndex = 487
        Me.Label15.Text = "Ubicacion:"
        '
        'tpreciocompra
        '
        Me.tpreciocompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tpreciocompra.Location = New System.Drawing.Point(115, 376)
        Me.tpreciocompra.Name = "tpreciocompra"
        Me.tpreciocompra.Size = New System.Drawing.Size(121, 20)
        Me.tpreciocompra.TabIndex = 489
        Me.tpreciocompra.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 380)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 13)
        Me.Label12.TabIndex = 488
        Me.Label12.Text = "Precio Compra:"
        '
        'dtpcompra
        '
        Me.dtpcompra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpcompra.Location = New System.Drawing.Point(115, 344)
        Me.dtpcompra.Name = "dtpcompra"
        Me.dtpcompra.Size = New System.Drawing.Size(101, 20)
        Me.dtpcompra.TabIndex = 490
        '
        'tubicacion
        '
        Me.tubicacion.FormattingEnabled = True
        Me.tubicacion.Items.AddRange(New Object() {"COPRECA", "SERINTER"})
        Me.tubicacion.Location = New System.Drawing.Point(118, 247)
        Me.tubicacion.Name = "tubicacion"
        Me.tubicacion.Size = New System.Drawing.Size(171, 21)
        Me.tubicacion.TabIndex = 491
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(159, 30)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(123, 24)
        Me.Label32.TabIndex = 492
        Me.Label32.Text = "Maquinarias"
        '
        'mensaje
        '
        Me.mensaje.AutoSize = True
        Me.mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mensaje.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.mensaje.Location = New System.Drawing.Point(14, 649)
        Me.mensaje.Name = "mensaje"
        Me.mensaje.Size = New System.Drawing.Size(75, 16)
        Me.mensaje.TabIndex = 555
        Me.mensaje.Text = "Mensajes"
        '
        'tnomotor
        '
        Me.tnomotor.Location = New System.Drawing.Point(117, 45)
        Me.tnomotor.Name = "tnomotor"
        Me.tnomotor.Size = New System.Drawing.Size(171, 20)
        Me.tnomotor.TabIndex = 559
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(19, 48)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(92, 13)
        Me.Label16.TabIndex = 557
        Me.Label16.Text = "Numero de Motor:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(7, 19)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(105, 13)
        Me.Label17.TabIndex = 556
        Me.Label17.Text = "Tipo de Transmision:"
        '
        'tdimenancho
        '
        Me.tdimenancho.Location = New System.Drawing.Point(356, 45)
        Me.tdimenancho.Name = "tdimenancho"
        Me.tdimenancho.Size = New System.Drawing.Size(171, 20)
        Me.tdimenancho.TabIndex = 563
        '
        'tdimenlargo
        '
        Me.tdimenlargo.Location = New System.Drawing.Point(356, 14)
        Me.tdimenlargo.Name = "tdimenlargo"
        Me.tdimenlargo.Size = New System.Drawing.Size(171, 20)
        Me.tdimenlargo.TabIndex = 562
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(307, 48)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(41, 13)
        Me.Label18.TabIndex = 561
        Me.Label18.Text = "Ancho:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(311, 19)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(37, 13)
        Me.Label19.TabIndex = 560
        Me.Label19.Text = "Largo:"
        '
        'tdimenpeso
        '
        Me.tdimenpeso.Location = New System.Drawing.Point(356, 104)
        Me.tdimenpeso.Name = "tdimenpeso"
        Me.tdimenpeso.Size = New System.Drawing.Size(171, 20)
        Me.tdimenpeso.TabIndex = 567
        '
        'tdimenalto
        '
        Me.tdimenalto.Location = New System.Drawing.Point(356, 73)
        Me.tdimenalto.Name = "tdimenalto"
        Me.tdimenalto.Size = New System.Drawing.Size(171, 20)
        Me.tdimenalto.TabIndex = 566
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(314, 107)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(34, 13)
        Me.Label20.TabIndex = 565
        Me.Label20.Text = "Peso:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(320, 78)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(28, 13)
        Me.Label21.TabIndex = 564
        Me.Label21.Text = "Alto:"
        '
        'ttipomaq
        '
        Me.ttipomaq.Location = New System.Drawing.Point(118, 120)
        Me.ttipomaq.Name = "ttipomaq"
        Me.ttipomaq.Size = New System.Drawing.Size(171, 20)
        Me.ttipomaq.TabIndex = 569
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(9, 124)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(90, 13)
        Me.Label22.TabIndex = 568
        Me.Label22.Text = "Tipo de Maquina:"
        '
        'tyearfab
        '
        Me.tyearfab.Location = New System.Drawing.Point(117, 104)
        Me.tyearfab.Name = "tyearfab"
        Me.tyearfab.Size = New System.Drawing.Size(171, 20)
        Me.tyearfab.TabIndex = 571
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(11, 107)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(102, 13)
        Me.Label23.TabIndex = 570
        Me.Label23.Text = "Año de Fabricacion:"
        '
        'ttipotrans
        '
        Me.ttipotrans.FormattingEnabled = True
        Me.ttipotrans.Items.AddRange(New Object() {"Manual", "Automatizadas o secuenciales", "Automático", "CVT", "Automatizada de doble embrague"})
        Me.ttipotrans.Location = New System.Drawing.Point(118, 16)
        Me.ttipotrans.Name = "ttipotrans"
        Me.ttipotrans.Size = New System.Drawing.Size(171, 21)
        Me.ttipotrans.TabIndex = 572
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ttipomaq)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.tubicacion)
        Me.GroupBox1.Controls.Add(Me.dtpcompra)
        Me.GroupBox1.Controls.Add(Me.tpreciocompra)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.tpropetarios)
        Me.GroupBox1.Controls.Add(Me.tpropietario)
        Me.GroupBox1.Controls.Add(Me.tcondicion)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.testadovh)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.tmodelovh)
        Me.GroupBox1.Controls.Add(Me.tmarcavh)
        Me.GroupBox1.Controls.Add(Me.tplacveh)
        Me.GroupBox1.Controls.Add(Me.tcodv)
        Me.GroupBox1.Controls.Add(Me.pfoto2)
        Me.GroupBox1.Controls.Add(Me.pfoto)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(298, 580)
        Me.GroupBox1.TabIndex = 573
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Generales Maquinaria"
        Me.GroupBox1.UseCompatibleTextRendering = True
        '
        'pfoto2
        '
        Me.pfoto2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pfoto2.Location = New System.Drawing.Point(156, 429)
        Me.pfoto2.Name = "pfoto2"
        Me.pfoto2.Size = New System.Drawing.Size(134, 142)
        Me.pfoto2.TabIndex = 350
        Me.pfoto2.TabStop = False
        '
        'pfoto
        '
        Me.pfoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pfoto.Location = New System.Drawing.Point(8, 429)
        Me.pfoto.Name = "pfoto"
        Me.pfoto.Size = New System.Drawing.Size(134, 142)
        Me.pfoto.TabIndex = 349
        Me.pfoto.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ttipotrans)
        Me.GroupBox2.Controls.Add(Me.tyearfab)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.tdimenpeso)
        Me.GroupBox2.Controls.Add(Me.tdimenalto)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.tdimenancho)
        Me.GroupBox2.Controls.Add(Me.tdimenlargo)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.tnomotor)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.tcolorvh)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(304, 514)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(552, 134)
        Me.GroupBox2.TabIndex = 574
        Me.GroupBox2.TabStop = False
        '
        'bregresar
        '
        Me.bregresar.BackgroundImage = CType(resources.GetObject("bregresar.BackgroundImage"), System.Drawing.Image)
        Me.bregresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bregresar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bregresar.Location = New System.Drawing.Point(732, 9)
        Me.bregresar.Name = "bregresar"
        Me.bregresar.Size = New System.Drawing.Size(76, 63)
        Me.bregresar.TabIndex = 479
        Me.bregresar.UseVisualStyleBackColor = True
        '
        'blimpieza
        '
        Me.blimpieza.BackColor = System.Drawing.Color.White
        Me.blimpieza.BackgroundImage = CType(resources.GetObject("blimpieza.BackgroundImage"), System.Drawing.Image)
        Me.blimpieza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.blimpieza.Location = New System.Drawing.Point(885, 590)
        Me.blimpieza.Name = "blimpieza"
        Me.blimpieza.Size = New System.Drawing.Size(64, 56)
        Me.blimpieza.TabIndex = 374
        Me.blimpieza.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(12, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(141, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 367
        Me.PictureBox1.TabStop = False
        '
        'btnbuscar
        '
        Me.btnbuscar.BackColor = System.Drawing.Color.White
        Me.btnbuscar.BackgroundImage = CType(resources.GetObject("btnbuscar.BackgroundImage"), System.Drawing.Image)
        Me.btnbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscar.Location = New System.Drawing.Point(971, 590)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(64, 56)
        Me.btnbuscar.TabIndex = 370
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'bdatagrid
        '
        Me.bdatagrid.BackgroundImage = CType(resources.GetObject("bdatagrid.BackgroundImage"), System.Drawing.Image)
        Me.bdatagrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bdatagrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bdatagrid.Location = New System.Drawing.Point(524, 9)
        Me.bdatagrid.Name = "bdatagrid"
        Me.bdatagrid.Size = New System.Drawing.Size(64, 63)
        Me.bdatagrid.TabIndex = 363
        Me.bdatagrid.UseVisualStyleBackColor = True
        '
        'breiniciar
        '
        Me.breiniciar.BackColor = System.Drawing.Color.White
        Me.breiniciar.BackgroundImage = CType(resources.GetObject("breiniciar.BackgroundImage"), System.Drawing.Image)
        Me.breiniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.breiniciar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.breiniciar.Location = New System.Drawing.Point(454, 9)
        Me.breiniciar.Name = "breiniciar"
        Me.breiniciar.Size = New System.Drawing.Size(64, 63)
        Me.breiniciar.TabIndex = 361
        Me.breiniciar.UseVisualStyleBackColor = False
        '
        'beliminar
        '
        Me.beliminar.BackgroundImage = CType(resources.GetObject("beliminar.BackgroundImage"), System.Drawing.Image)
        Me.beliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.beliminar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.beliminar.Location = New System.Drawing.Point(384, 9)
        Me.beliminar.Name = "beliminar"
        Me.beliminar.Size = New System.Drawing.Size(64, 63)
        Me.beliminar.TabIndex = 360
        Me.beliminar.UseVisualStyleBackColor = True
        '
        'bagregar
        '
        Me.bagregar.BackgroundImage = CType(resources.GetObject("bagregar.BackgroundImage"), System.Drawing.Image)
        Me.bagregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bagregar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bagregar.Location = New System.Drawing.Point(314, 9)
        Me.bagregar.Name = "bagregar"
        Me.bagregar.Size = New System.Drawing.Size(64, 63)
        Me.bagregar.TabIndex = 359
        Me.bagregar.UseVisualStyleBackColor = True
        '
        'btimpresion
        '
        Me.btimpresion.BackgroundImage = CType(resources.GetObject("btimpresion.BackgroundImage"), System.Drawing.Image)
        Me.btimpresion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btimpresion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btimpresion.Location = New System.Drawing.Point(594, 9)
        Me.btimpresion.Name = "btimpresion"
        Me.btimpresion.Size = New System.Drawing.Size(64, 63)
        Me.btimpresion.TabIndex = 575
        Me.btimpresion.UseVisualStyleBackColor = True
        '
        'FrmIngresoVehiculos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1270, 670)
        Me.Controls.Add(Me.btimpresion)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.mensaje)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.bregresar)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.blimpieza)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ccampos)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.tcriterio)
        Me.Controls.Add(Me.bdatagrid)
        Me.Controls.Add(Me.breiniciar)
        Me.Controls.Add(Me.beliminar)
        Me.Controls.Add(Me.bagregar)
        Me.Controls.Add(Me.dgvvehiculos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmIngresoVehiculos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmIngresoVehiculos"
        CType(Me.dgvvehiculos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pfoto2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pfoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents pfoto2 As System.Windows.Forms.PictureBox
    Friend WithEvents pfoto As System.Windows.Forms.PictureBox
    Friend WithEvents tcodv As System.Windows.Forms.TextBox
    Friend WithEvents tplacveh As System.Windows.Forms.TextBox
    Friend WithEvents tcolorvh As System.Windows.Forms.TextBox
    Friend WithEvents tmodelovh As System.Windows.Forms.TextBox
    Friend WithEvents tmarcavh As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dgvvehiculos As System.Windows.Forms.DataGridView
    Friend WithEvents bdatagrid As System.Windows.Forms.Button
    Friend WithEvents breiniciar As System.Windows.Forms.Button
    Friend WithEvents beliminar As System.Windows.Forms.Button
    Friend WithEvents bagregar As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents testadovh As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents blimpieza As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ccampos As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents tcriterio As System.Windows.Forms.TextBox
    Friend WithEvents bregresar As System.Windows.Forms.Button
    Friend WithEvents tpropetarios As System.Windows.Forms.ComboBox
    Friend WithEvents tpropietario As System.Windows.Forms.Label
    Friend WithEvents tcondicion As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents tpreciocompra As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dtpcompra As System.Windows.Forms.DateTimePicker
    Friend WithEvents tubicacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents mensaje As System.Windows.Forms.Label
    Friend WithEvents tnomotor As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents tdimenancho As System.Windows.Forms.TextBox
    Friend WithEvents tdimenlargo As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents tdimenpeso As System.Windows.Forms.TextBox
    Friend WithEvents tdimenalto As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents ttipomaq As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents tyearfab As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents ttipotrans As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btimpresion As System.Windows.Forms.Button
End Class
