<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientosMaqTotal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMantenimientosMaqTotal))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.chkfiltro = New System.Windows.Forms.CheckBox()
        Me.dtp2 = New System.Windows.Forms.DateTimePicker()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.fechahora = New System.Windows.Forms.Label()
        Me.mensaje = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.ttipomaq = New System.Windows.Forms.TextBox()
        Me.ttipotrans = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.tyearfab = New System.Windows.Forms.TextBox()
        Me.tubicacion = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.dtpcompra = New System.Windows.Forms.DateTimePicker()
        Me.tpreciocompra = New System.Windows.Forms.TextBox()
        Me.tdimenpeso = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tdimenalto = New System.Windows.Forms.TextBox()
        Me.tpropetarios = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tpropietario = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tcondicion = New System.Windows.Forms.TextBox()
        Me.tcolorvh = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.testadovh = New System.Windows.Forms.ComboBox()
        Me.tdimenancho = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tnomotor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tdimenlargo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tmodelovh = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tmarcavh = New System.Windows.Forms.TextBox()
        Me.tplacveh = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvreg = New System.Windows.Forms.DataGridView()
        Me.ID1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Razon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bimprimir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pfoto2 = New System.Windows.Forms.PictureBox()
        Me.pfoto = New System.Windows.Forms.PictureBox()
        Me.tcodv = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTotal2 = New System.Windows.Forms.Label()
        Me.dgvreg2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorS1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Servicio1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HorasTrab1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorT2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timer6 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer8 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer7 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.dgvreg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pfoto2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pfoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvreg2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkfiltro
        '
        Me.chkfiltro.AutoSize = True
        Me.chkfiltro.Location = New System.Drawing.Point(109, 664)
        Me.chkfiltro.Name = "chkfiltro"
        Me.chkfiltro.Size = New System.Drawing.Size(96, 17)
        Me.chkfiltro.TabIndex = 783
        Me.chkfiltro.Text = "Filtro de Fecha"
        Me.chkfiltro.UseVisualStyleBackColor = True
        '
        'dtp2
        '
        Me.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp2.Location = New System.Drawing.Point(416, 662)
        Me.dtp2.Name = "dtp2"
        Me.dtp2.Size = New System.Drawing.Size(200, 20)
        Me.dtp2.TabIndex = 782
        Me.dtp2.Visible = False
        '
        'dtp1
        '
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp1.Location = New System.Drawing.Point(209, 662)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(200, 20)
        Me.dtp1.TabIndex = 781
        Me.dtp1.Visible = False
        '
        'fechahora
        '
        Me.fechahora.AutoSize = True
        Me.fechahora.Location = New System.Drawing.Point(385, 40)
        Me.fechahora.Name = "fechahora"
        Me.fechahora.Size = New System.Drawing.Size(39, 13)
        Me.fechahora.TabIndex = 780
        Me.fechahora.Text = "Label1"
        '
        'mensaje
        '
        Me.mensaje.AutoSize = True
        Me.mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mensaje.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.mensaje.Location = New System.Drawing.Point(511, 708)
        Me.mensaje.Name = "mensaje"
        Me.mensaje.Size = New System.Drawing.Size(75, 16)
        Me.mensaje.TabIndex = 751
        Me.mensaje.Text = "Mensajes"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(190, 32)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(147, 24)
        Me.Label32.TabIndex = 745
        Me.Label32.Text = "Gastos Totales"
        '
        'ttipomaq
        '
        Me.ttipomaq.Enabled = False
        Me.ttipomaq.Location = New System.Drawing.Point(1049, 88)
        Me.ttipomaq.Name = "ttipomaq"
        Me.ttipomaq.Size = New System.Drawing.Size(171, 20)
        Me.ttipomaq.TabIndex = 739
        '
        'ttipotrans
        '
        Me.ttipotrans.Enabled = False
        Me.ttipotrans.FormattingEnabled = True
        Me.ttipotrans.Items.AddRange(New Object() {"Manual", "Automatizadas o secuenciales", "Automático", "CVT", "Automatizada de doble embrague"})
        Me.ttipotrans.Location = New System.Drawing.Point(1049, 341)
        Me.ttipotrans.Name = "ttipotrans"
        Me.ttipotrans.Size = New System.Drawing.Size(171, 21)
        Me.ttipotrans.TabIndex = 742
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(950, 92)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(90, 13)
        Me.Label22.TabIndex = 738
        Me.Label22.Text = "Tipo de Maquina:"
        '
        'tyearfab
        '
        Me.tyearfab.Enabled = False
        Me.tyearfab.Location = New System.Drawing.Point(1048, 426)
        Me.tyearfab.Name = "tyearfab"
        Me.tyearfab.Size = New System.Drawing.Size(171, 20)
        Me.tyearfab.TabIndex = 741
        '
        'tubicacion
        '
        Me.tubicacion.Enabled = False
        Me.tubicacion.FormattingEnabled = True
        Me.tubicacion.Items.AddRange(New Object() {"COPRECA", "SERINTER"})
        Me.tubicacion.Location = New System.Drawing.Point(1050, 198)
        Me.tubicacion.Name = "tubicacion"
        Me.tubicacion.Size = New System.Drawing.Size(171, 21)
        Me.tubicacion.TabIndex = 726
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(938, 429)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(102, 13)
        Me.Label23.TabIndex = 740
        Me.Label23.Text = "Año de Fabricacion:"
        '
        'dtpcompra
        '
        Me.dtpcompra.Enabled = False
        Me.dtpcompra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpcompra.Location = New System.Drawing.Point(1051, 289)
        Me.dtpcompra.Name = "dtpcompra"
        Me.dtpcompra.Size = New System.Drawing.Size(101, 20)
        Me.dtpcompra.TabIndex = 725
        '
        'tpreciocompra
        '
        Me.tpreciocompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tpreciocompra.Enabled = False
        Me.tpreciocompra.Location = New System.Drawing.Point(1050, 314)
        Me.tpreciocompra.Name = "tpreciocompra"
        Me.tpreciocompra.Size = New System.Drawing.Size(121, 20)
        Me.tpreciocompra.TabIndex = 724
        '
        'tdimenpeso
        '
        Me.tdimenpeso.Enabled = False
        Me.tdimenpeso.Location = New System.Drawing.Point(1049, 538)
        Me.tdimenpeso.Name = "tdimenpeso"
        Me.tdimenpeso.Size = New System.Drawing.Size(171, 20)
        Me.tdimenpeso.TabIndex = 737
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(961, 318)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 13)
        Me.Label12.TabIndex = 723
        Me.Label12.Text = "Precio Compra:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(935, 344)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(105, 13)
        Me.Label17.TabIndex = 727
        Me.Label17.Text = "Tipo de Transmision:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(982, 201)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 13)
        Me.Label15.TabIndex = 722
        Me.Label15.Text = "Ubicacion:"
        '
        'tdimenalto
        '
        Me.tdimenalto.Enabled = False
        Me.tdimenalto.Location = New System.Drawing.Point(1049, 511)
        Me.tdimenalto.Name = "tdimenalto"
        Me.tdimenalto.Size = New System.Drawing.Size(171, 20)
        Me.tdimenalto.TabIndex = 736
        '
        'tpropetarios
        '
        Me.tpropetarios.Enabled = False
        Me.tpropetarios.FormattingEnabled = True
        Me.tpropetarios.Items.AddRange(New Object() {"COPRECA", "SERINTER"})
        Me.tpropetarios.Location = New System.Drawing.Point(1049, 170)
        Me.tpropetarios.Name = "tpropetarios"
        Me.tpropetarios.Size = New System.Drawing.Size(171, 21)
        Me.tpropetarios.TabIndex = 721
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1006, 401)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 704
        Me.Label3.Text = "Color:"
        '
        'tpropietario
        '
        Me.tpropietario.AutoSize = True
        Me.tpropietario.Location = New System.Drawing.Point(980, 174)
        Me.tpropietario.Name = "tpropietario"
        Me.tpropietario.Size = New System.Drawing.Size(60, 13)
        Me.tpropietario.TabIndex = 720
        Me.tpropietario.Text = "Propietario:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(1006, 541)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(34, 13)
        Me.Label20.TabIndex = 735
        Me.Label20.Text = "Peso:"
        '
        'tcondicion
        '
        Me.tcondicion.Enabled = False
        Me.tcondicion.Location = New System.Drawing.Point(953, 241)
        Me.tcondicion.Multiline = True
        Me.tcondicion.Name = "tcondicion"
        Me.tcondicion.Size = New System.Drawing.Size(276, 42)
        Me.tcondicion.TabIndex = 719
        '
        'tcolorvh
        '
        Me.tcolorvh.Enabled = False
        Me.tcolorvh.Location = New System.Drawing.Point(1048, 398)
        Me.tcolorvh.Name = "tcolorvh"
        Me.tcolorvh.Size = New System.Drawing.Size(171, 20)
        Me.tcolorvh.TabIndex = 710
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(961, 292)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 13)
        Me.Label13.TabIndex = 718
        Me.Label13.Text = "Fecha Compra:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(1012, 516)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(28, 13)
        Me.Label21.TabIndex = 734
        Me.Label21.Text = "Alto:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(950, 225)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 13)
        Me.Label14.TabIndex = 717
        Me.Label14.Text = "Condicion Maquinaria:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(948, 373)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(92, 13)
        Me.Label16.TabIndex = 728
        Me.Label16.Text = "Numero de Motor:"
        '
        'testadovh
        '
        Me.testadovh.Enabled = False
        Me.testadovh.FormattingEnabled = True
        Me.testadovh.Items.AddRange(New Object() {"Disponible", "Utilizado", "Mantenimiento", "Dañado"})
        Me.testadovh.Location = New System.Drawing.Point(1049, 60)
        Me.testadovh.Name = "testadovh"
        Me.testadovh.Size = New System.Drawing.Size(171, 21)
        Me.testadovh.TabIndex = 716
        '
        'tdimenancho
        '
        Me.tdimenancho.Enabled = False
        Me.tdimenancho.Location = New System.Drawing.Point(1049, 483)
        Me.tdimenancho.Name = "tdimenancho"
        Me.tdimenancho.Size = New System.Drawing.Size(171, 20)
        Me.tdimenancho.TabIndex = 733
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(942, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 13)
        Me.Label8.TabIndex = 715
        Me.Label8.Text = "Estado Maquinaria:"
        '
        'tnomotor
        '
        Me.tnomotor.Enabled = False
        Me.tnomotor.Location = New System.Drawing.Point(1048, 370)
        Me.tnomotor.Name = "tnomotor"
        Me.tnomotor.Size = New System.Drawing.Size(171, 20)
        Me.tnomotor.TabIndex = 729
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1094, 564)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 714
        Me.Label4.Text = "foto#2"
        '
        'tdimenlargo
        '
        Me.tdimenlargo.Enabled = False
        Me.tdimenlargo.Location = New System.Drawing.Point(1049, 455)
        Me.tdimenlargo.Name = "tdimenlargo"
        Me.tdimenlargo.Size = New System.Drawing.Size(171, 20)
        Me.tdimenlargo.TabIndex = 732
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(947, 564)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 713
        Me.Label7.Text = "foto #1"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(1003, 460)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(37, 13)
        Me.Label19.TabIndex = 730
        Me.Label19.Text = "Largo:"
        '
        'tmodelovh
        '
        Me.tmodelovh.Enabled = False
        Me.tmodelovh.Location = New System.Drawing.Point(1049, 144)
        Me.tmodelovh.Name = "tmodelovh"
        Me.tmodelovh.Size = New System.Drawing.Size(171, 20)
        Me.tmodelovh.TabIndex = 712
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(999, 486)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(41, 13)
        Me.Label18.TabIndex = 731
        Me.Label18.Text = "Ancho:"
        '
        'tmarcavh
        '
        Me.tmarcavh.Enabled = False
        Me.tmarcavh.Location = New System.Drawing.Point(1049, 116)
        Me.tmarcavh.Name = "tmarcavh"
        Me.tmarcavh.Size = New System.Drawing.Size(171, 20)
        Me.tmarcavh.TabIndex = 711
        '
        'tplacveh
        '
        Me.tplacveh.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tplacveh.Enabled = False
        Me.tplacveh.Location = New System.Drawing.Point(1049, 33)
        Me.tplacveh.Name = "tplacveh"
        Me.tplacveh.Size = New System.Drawing.Size(171, 20)
        Me.tplacveh.TabIndex = 709
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(959, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 703
        Me.Label2.Text = "Placa Vehiculo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1000, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 705
        Me.Label6.Text = "Marca:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(995, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 706
        Me.Label5.Text = "Modelo:"
        '
        'dgvreg
        '
        Me.dgvreg.AllowUserToAddRows = False
        Me.dgvreg.AllowUserToDeleteRows = False
        Me.dgvreg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvreg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID1, Me.Item, Me.Unidad, Me.Descripcion, Me.Valor, Me.ValorT, Me.Razon, Me.Fecha})
        Me.dgvreg.Location = New System.Drawing.Point(39, 85)
        Me.dgvreg.Name = "dgvreg"
        Me.dgvreg.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.dgvreg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvreg.Size = New System.Drawing.Size(890, 270)
        Me.dgvreg.TabIndex = 743
        '
        'ID1
        '
        Me.ID1.HeaderText = "id"
        Me.ID1.Name = "ID1"
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
        Me.Unidad.ReadOnly = True
        Me.Unidad.Width = 52
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "objeto"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 270
        '
        'Valor
        '
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Valor.DefaultCellStyle = DataGridViewCellStyle1
        Me.Valor.HeaderText = "valor_unidad"
        Me.Valor.Name = "Valor"
        Me.Valor.ReadOnly = True
        Me.Valor.Width = 74
        '
        'ValorT
        '
        Me.ValorT.HeaderText = "valor_total"
        Me.ValorT.Name = "ValorT"
        Me.ValorT.Width = 73
        '
        'Razon
        '
        Me.Razon.HeaderText = "descripcion"
        Me.Razon.Name = "Razon"
        Me.Razon.Width = 200
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 138
        '
        'bimprimir
        '
        Me.bimprimir.BackColor = System.Drawing.Color.White
        Me.bimprimir.BackgroundImage = CType(resources.GetObject("bimprimir.BackgroundImage"), System.Drawing.Image)
        Me.bimprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bimprimir.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bimprimir.Location = New System.Drawing.Point(39, 664)
        Me.bimprimir.Name = "bimprimir"
        Me.bimprimir.Size = New System.Drawing.Size(64, 63)
        Me.bimprimir.TabIndex = 750
        Me.bimprimir.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(37, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(141, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 744
        Me.PictureBox1.TabStop = False
        '
        'pfoto2
        '
        Me.pfoto2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pfoto2.Enabled = False
        Me.pfoto2.Location = New System.Drawing.Point(1095, 582)
        Me.pfoto2.Name = "pfoto2"
        Me.pfoto2.Size = New System.Drawing.Size(134, 142)
        Me.pfoto2.TabIndex = 708
        Me.pfoto2.TabStop = False
        '
        'pfoto
        '
        Me.pfoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pfoto.Enabled = False
        Me.pfoto.Location = New System.Drawing.Point(947, 582)
        Me.pfoto.Name = "pfoto"
        Me.pfoto.Size = New System.Drawing.Size(134, 142)
        Me.pfoto.TabIndex = 707
        Me.pfoto.TabStop = False
        '
        'tcodv
        '
        Me.tcodv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tcodv.Enabled = False
        Me.tcodv.Location = New System.Drawing.Point(1048, 5)
        Me.tcodv.Name = "tcodv"
        Me.tcodv.Size = New System.Drawing.Size(171, 20)
        Me.tcodv.TabIndex = 785
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(937, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 784
        Me.Label1.Text = "Codigo de Maquina:"
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Timer3
        '
        '
        'Timer5
        '
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(785, 358)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(34, 13)
        Me.Label31.TabIndex = 800
        Me.Label31.Text = "Total:"
        '
        'txtTotal
        '
        Me.txtTotal.AutoSize = True
        Me.txtTotal.Location = New System.Drawing.Point(824, 358)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(0, 13)
        Me.txtTotal.TabIndex = 799
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(785, 661)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 802
        Me.Label9.Text = "Total:"
        '
        'txtTotal2
        '
        Me.txtTotal2.AutoSize = True
        Me.txtTotal2.Location = New System.Drawing.Point(824, 661)
        Me.txtTotal2.Name = "txtTotal2"
        Me.txtTotal2.Size = New System.Drawing.Size(0, 13)
        Me.txtTotal2.TabIndex = 801
        '
        'dgvreg2
        '
        Me.dgvreg2.AllowUserToAddRows = False
        Me.dgvreg2.AllowUserToDeleteRows = False
        Me.dgvreg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvreg2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.ValorS1, Me.Servicio1, Me.HorasTrab1, Me.ValorT2, Me.Descripcion2, Me.Fecha2})
        Me.dgvreg2.Location = New System.Drawing.Point(39, 382)
        Me.dgvreg2.Name = "dgvreg2"
        Me.dgvreg2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.dgvreg2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvreg2.Size = New System.Drawing.Size(890, 274)
        Me.dgvreg2.TabIndex = 803
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "no*"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 40
        '
        'ValorS1
        '
        Me.ValorS1.HeaderText = "valor_servicio"
        Me.ValorS1.Name = "ValorS1"
        Me.ValorS1.ReadOnly = True
        Me.ValorS1.Width = 82
        '
        'Servicio1
        '
        Me.Servicio1.HeaderText = "servicio"
        Me.Servicio1.Name = "Servicio1"
        Me.Servicio1.ReadOnly = True
        Me.Servicio1.Width = 220
        '
        'HorasTrab1
        '
        DataGridViewCellStyle2.NullValue = Nothing
        Me.HorasTrab1.DefaultCellStyle = DataGridViewCellStyle2
        Me.HorasTrab1.HeaderText = "horas_trabajadas"
        Me.HorasTrab1.Name = "HorasTrab1"
        Me.HorasTrab1.ReadOnly = True
        Me.HorasTrab1.Width = 94
        '
        'ValorT2
        '
        Me.ValorT2.HeaderText = "valor_total"
        Me.ValorT2.Name = "ValorT2"
        Me.ValorT2.Width = 73
        '
        'Descripcion2
        '
        Me.Descripcion2.HeaderText = "descripcion"
        Me.Descripcion2.Name = "Descripcion2"
        Me.Descripcion2.Width = 200
        '
        'Fecha2
        '
        Me.Fecha2.HeaderText = "fecha"
        Me.Fecha2.Name = "Fecha2"
        Me.Fecha2.ReadOnly = True
        Me.Fecha2.Width = 138
        '
        'Timer6
        '
        '
        'Timer8
        '
        '
        'Timer7
        '
        '
        'FrmMantenimientosMaqTotal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1267, 735)
        Me.Controls.Add(Me.dgvreg2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtTotal2)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.tcodv)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkfiltro)
        Me.Controls.Add(Me.dtp2)
        Me.Controls.Add(Me.dtp1)
        Me.Controls.Add(Me.fechahora)
        Me.Controls.Add(Me.mensaje)
        Me.Controls.Add(Me.bimprimir)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ttipomaq)
        Me.Controls.Add(Me.ttipotrans)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.tyearfab)
        Me.Controls.Add(Me.tubicacion)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.dtpcompra)
        Me.Controls.Add(Me.tpreciocompra)
        Me.Controls.Add(Me.tdimenpeso)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.tdimenalto)
        Me.Controls.Add(Me.tpropetarios)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tpropietario)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.tcondicion)
        Me.Controls.Add(Me.tcolorvh)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.testadovh)
        Me.Controls.Add(Me.tdimenancho)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tnomotor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tdimenlargo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.tmodelovh)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.tmarcavh)
        Me.Controls.Add(Me.tplacveh)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pfoto2)
        Me.Controls.Add(Me.pfoto)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgvreg)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMantenimientosMaqTotal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMantenimientoMaqTotal"
        CType(Me.dgvreg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pfoto2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pfoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvreg2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkfiltro As System.Windows.Forms.CheckBox
    Friend WithEvents dtp2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents fechahora As System.Windows.Forms.Label
    Friend WithEvents mensaje As System.Windows.Forms.Label
    Friend WithEvents bimprimir As System.Windows.Forms.Button
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ttipomaq As System.Windows.Forms.TextBox
    Friend WithEvents ttipotrans As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents tyearfab As System.Windows.Forms.TextBox
    Friend WithEvents tubicacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents dtpcompra As System.Windows.Forms.DateTimePicker
    Friend WithEvents tpreciocompra As System.Windows.Forms.TextBox
    Friend WithEvents tdimenpeso As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents tdimenalto As System.Windows.Forms.TextBox
    Friend WithEvents tpropetarios As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tpropietario As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents tcondicion As System.Windows.Forms.TextBox
    Friend WithEvents tcolorvh As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents testadovh As System.Windows.Forms.ComboBox
    Friend WithEvents tdimenancho As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tnomotor As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tdimenlargo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents tmodelovh As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents tmarcavh As System.Windows.Forms.TextBox
    Friend WithEvents tplacveh As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pfoto2 As System.Windows.Forms.PictureBox
    Friend WithEvents pfoto As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgvreg As System.Windows.Forms.DataGridView
    Friend WithEvents ID1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Item As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Unidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Valor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Razon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tcodv As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Timer5 As System.Windows.Forms.Timer
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTotal2 As System.Windows.Forms.Label
    Friend WithEvents dgvreg2 As System.Windows.Forms.DataGridView
    Friend WithEvents Timer6 As System.Windows.Forms.Timer
    Friend WithEvents Timer8 As System.Windows.Forms.Timer
    Friend WithEvents Timer7 As System.Windows.Forms.Timer
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorS1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Servicio1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HorasTrab1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorT2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
