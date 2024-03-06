<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientosMaqObr
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMantenimientosMaqObr))
        Me.chkfiltro = New System.Windows.Forms.CheckBox()
        Me.dtp2 = New System.Windows.Forms.DateTimePicker()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.fechahora = New System.Windows.Forms.Label()
        Me.dgvreg2 = New System.Windows.Forms.DataGridView()
        Me.ID2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Item2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorS2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Servicio2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HorasTrab2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorT2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Razon2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.tcodv = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvreg = New System.Windows.Forms.DataGridView()
        Me.ID1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorS1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Servicio1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HorasTrab1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Razon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bagrlista = New System.Windows.Forms.Button()
        Me.bimprimir = New System.Windows.Forms.Button()
        Me.breiniciar = New System.Windows.Forms.Button()
        Me.beliminar = New System.Windows.Forms.Button()
        Me.bagregar = New System.Windows.Forms.Button()
        Me.beliminarreg = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pfoto2 = New System.Windows.Forms.PictureBox()
        Me.pfoto = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ttipotrab = New System.Windows.Forms.TextBox()
        Me.tvalorhora = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.thortrab = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tvalortotal = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.trazontrab = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.dgvreg2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvreg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pfoto2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pfoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkfiltro
        '
        Me.chkfiltro.AutoSize = True
        Me.chkfiltro.Location = New System.Drawing.Point(180, 648)
        Me.chkfiltro.Name = "chkfiltro"
        Me.chkfiltro.Size = New System.Drawing.Size(96, 17)
        Me.chkfiltro.TabIndex = 702
        Me.chkfiltro.Text = "Filtro de Fecha"
        Me.chkfiltro.UseVisualStyleBackColor = True
        '
        'dtp2
        '
        Me.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp2.Location = New System.Drawing.Point(487, 646)
        Me.dtp2.Name = "dtp2"
        Me.dtp2.Size = New System.Drawing.Size(200, 20)
        Me.dtp2.TabIndex = 701
        Me.dtp2.Visible = False
        '
        'dtp1
        '
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp1.Location = New System.Drawing.Point(280, 646)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(200, 20)
        Me.dtp1.TabIndex = 700
        Me.dtp1.Visible = False
        '
        'fechahora
        '
        Me.fechahora.AutoSize = True
        Me.fechahora.Location = New System.Drawing.Point(383, 31)
        Me.fechahora.Name = "fechahora"
        Me.fechahora.Size = New System.Drawing.Size(39, 13)
        Me.fechahora.TabIndex = 699
        Me.fechahora.Text = "Label1"
        '
        'dgvreg2
        '
        Me.dgvreg2.AllowUserToAddRows = False
        Me.dgvreg2.AllowUserToDeleteRows = False
        Me.dgvreg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvreg2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID2, Me.Item2, Me.ValorS2, Me.Servicio2, Me.HorasTrab2, Me.ValorT2, Me.Razon2, Me.Fecha2})
        Me.dgvreg2.Location = New System.Drawing.Point(39, 463)
        Me.dgvreg2.MultiSelect = False
        Me.dgvreg2.Name = "dgvreg2"
        Me.dgvreg2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.dgvreg2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvreg2.Size = New System.Drawing.Size(890, 176)
        Me.dgvreg2.TabIndex = 698
        '
        'ID2
        '
        Me.ID2.HeaderText = "id"
        Me.ID2.Name = "ID2"
        Me.ID2.Visible = False
        '
        'Item2
        '
        Me.Item2.HeaderText = "no*"
        Me.Item2.Name = "Item2"
        Me.Item2.ReadOnly = True
        Me.Item2.Width = 40
        '
        'ValorS2
        '
        Me.ValorS2.HeaderText = "valor_hora"
        Me.ValorS2.Name = "ValorS2"
        Me.ValorS2.ReadOnly = True
        Me.ValorS2.Width = 82
        '
        'Servicio2
        '
        Me.Servicio2.HeaderText = "servicio"
        Me.Servicio2.Name = "Servicio2"
        Me.Servicio2.ReadOnly = True
        Me.Servicio2.Width = 220
        '
        'HorasTrab2
        '
        DataGridViewCellStyle1.NullValue = Nothing
        Me.HorasTrab2.DefaultCellStyle = DataGridViewCellStyle1
        Me.HorasTrab2.HeaderText = "horas_trabajadas"
        Me.HorasTrab2.Name = "HorasTrab2"
        Me.HorasTrab2.ReadOnly = True
        Me.HorasTrab2.Width = 94
        '
        'ValorT2
        '
        Me.ValorT2.HeaderText = "valor_total"
        Me.ValorT2.Name = "ValorT2"
        Me.ValorT2.Width = 73
        '
        'Razon2
        '
        Me.Razon2.HeaderText = "descripcion"
        Me.Razon2.Name = "Razon2"
        Me.Razon2.Width = 200
        '
        'Fecha2
        '
        Me.Fecha2.HeaderText = "fecha"
        Me.Fecha2.Name = "Fecha2"
        Me.Fecha2.ReadOnly = True
        Me.Fecha2.Width = 138
        '
        'mensaje
        '
        Me.mensaje.AutoSize = True
        Me.mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mensaje.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.mensaje.Location = New System.Drawing.Point(511, 708)
        Me.mensaje.Name = "mensaje"
        Me.mensaje.Size = New System.Drawing.Size(75, 16)
        Me.mensaje.TabIndex = 670
        Me.mensaje.Text = "Mensajes"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(190, 23)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(144, 24)
        Me.Label32.TabIndex = 664
        Me.Label32.Text = "Mano de Obra"
        '
        'ttipomaq
        '
        Me.ttipomaq.Enabled = False
        Me.ttipomaq.Location = New System.Drawing.Point(1049, 88)
        Me.ttipomaq.Name = "ttipomaq"
        Me.ttipomaq.Size = New System.Drawing.Size(171, 20)
        Me.ttipomaq.TabIndex = 658
        '
        'ttipotrans
        '
        Me.ttipotrans.Enabled = False
        Me.ttipotrans.FormattingEnabled = True
        Me.ttipotrans.Items.AddRange(New Object() {"Manual", "Automatizadas o secuenciales", "Automático", "CVT", "Automatizada de doble embrague"})
        Me.ttipotrans.Location = New System.Drawing.Point(1049, 341)
        Me.ttipotrans.Name = "ttipotrans"
        Me.ttipotrans.Size = New System.Drawing.Size(171, 21)
        Me.ttipotrans.TabIndex = 661
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(950, 92)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(90, 13)
        Me.Label22.TabIndex = 657
        Me.Label22.Text = "Tipo de Maquina:"
        '
        'tyearfab
        '
        Me.tyearfab.Enabled = False
        Me.tyearfab.Location = New System.Drawing.Point(1048, 426)
        Me.tyearfab.Name = "tyearfab"
        Me.tyearfab.Size = New System.Drawing.Size(171, 20)
        Me.tyearfab.TabIndex = 660
        '
        'tubicacion
        '
        Me.tubicacion.Enabled = False
        Me.tubicacion.FormattingEnabled = True
        Me.tubicacion.Items.AddRange(New Object() {"COPRECA", "SERINTER"})
        Me.tubicacion.Location = New System.Drawing.Point(1050, 198)
        Me.tubicacion.Name = "tubicacion"
        Me.tubicacion.Size = New System.Drawing.Size(171, 21)
        Me.tubicacion.TabIndex = 645
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(938, 429)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(102, 13)
        Me.Label23.TabIndex = 659
        Me.Label23.Text = "Año de Fabricacion:"
        '
        'dtpcompra
        '
        Me.dtpcompra.Enabled = False
        Me.dtpcompra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpcompra.Location = New System.Drawing.Point(1051, 289)
        Me.dtpcompra.Name = "dtpcompra"
        Me.dtpcompra.Size = New System.Drawing.Size(101, 20)
        Me.dtpcompra.TabIndex = 644
        '
        'tpreciocompra
        '
        Me.tpreciocompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tpreciocompra.Enabled = False
        Me.tpreciocompra.Location = New System.Drawing.Point(1050, 314)
        Me.tpreciocompra.Name = "tpreciocompra"
        Me.tpreciocompra.Size = New System.Drawing.Size(121, 20)
        Me.tpreciocompra.TabIndex = 643
        '
        'tdimenpeso
        '
        Me.tdimenpeso.Enabled = False
        Me.tdimenpeso.Location = New System.Drawing.Point(1049, 538)
        Me.tdimenpeso.Name = "tdimenpeso"
        Me.tdimenpeso.Size = New System.Drawing.Size(171, 20)
        Me.tdimenpeso.TabIndex = 656
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(961, 318)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 13)
        Me.Label12.TabIndex = 642
        Me.Label12.Text = "Precio Compra:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(935, 344)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(105, 13)
        Me.Label17.TabIndex = 646
        Me.Label17.Text = "Tipo de Transmision:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(982, 201)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 13)
        Me.Label15.TabIndex = 641
        Me.Label15.Text = "Ubicacion:"
        '
        'tdimenalto
        '
        Me.tdimenalto.Enabled = False
        Me.tdimenalto.Location = New System.Drawing.Point(1049, 511)
        Me.tdimenalto.Name = "tdimenalto"
        Me.tdimenalto.Size = New System.Drawing.Size(171, 20)
        Me.tdimenalto.TabIndex = 655
        '
        'tpropetarios
        '
        Me.tpropetarios.Enabled = False
        Me.tpropetarios.FormattingEnabled = True
        Me.tpropetarios.Items.AddRange(New Object() {"COPRECA", "SERINTER"})
        Me.tpropetarios.Location = New System.Drawing.Point(1049, 170)
        Me.tpropetarios.Name = "tpropetarios"
        Me.tpropetarios.Size = New System.Drawing.Size(171, 21)
        Me.tpropetarios.TabIndex = 640
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1006, 401)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 622
        Me.Label3.Text = "Color:"
        '
        'tpropietario
        '
        Me.tpropietario.AutoSize = True
        Me.tpropietario.Location = New System.Drawing.Point(980, 174)
        Me.tpropietario.Name = "tpropietario"
        Me.tpropietario.Size = New System.Drawing.Size(60, 13)
        Me.tpropietario.TabIndex = 639
        Me.tpropietario.Text = "Propietario:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(1006, 541)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(34, 13)
        Me.Label20.TabIndex = 654
        Me.Label20.Text = "Peso:"
        '
        'tcondicion
        '
        Me.tcondicion.Enabled = False
        Me.tcondicion.Location = New System.Drawing.Point(953, 241)
        Me.tcondicion.Multiline = True
        Me.tcondicion.Name = "tcondicion"
        Me.tcondicion.Size = New System.Drawing.Size(276, 42)
        Me.tcondicion.TabIndex = 638
        '
        'tcolorvh
        '
        Me.tcolorvh.Enabled = False
        Me.tcolorvh.Location = New System.Drawing.Point(1048, 398)
        Me.tcolorvh.Name = "tcolorvh"
        Me.tcolorvh.Size = New System.Drawing.Size(171, 20)
        Me.tcolorvh.TabIndex = 629
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(961, 292)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 13)
        Me.Label13.TabIndex = 637
        Me.Label13.Text = "Fecha Compra:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(1012, 516)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(28, 13)
        Me.Label21.TabIndex = 653
        Me.Label21.Text = "Alto:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(950, 225)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 13)
        Me.Label14.TabIndex = 636
        Me.Label14.Text = "Condicion Maquinaria:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(948, 373)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(92, 13)
        Me.Label16.TabIndex = 647
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
        Me.testadovh.TabIndex = 635
        '
        'tdimenancho
        '
        Me.tdimenancho.Enabled = False
        Me.tdimenancho.Location = New System.Drawing.Point(1049, 483)
        Me.tdimenancho.Name = "tdimenancho"
        Me.tdimenancho.Size = New System.Drawing.Size(171, 20)
        Me.tdimenancho.TabIndex = 652
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(942, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 13)
        Me.Label8.TabIndex = 634
        Me.Label8.Text = "Estado Maquinaria:"
        '
        'tnomotor
        '
        Me.tnomotor.Enabled = False
        Me.tnomotor.Location = New System.Drawing.Point(1048, 370)
        Me.tnomotor.Name = "tnomotor"
        Me.tnomotor.Size = New System.Drawing.Size(171, 20)
        Me.tnomotor.TabIndex = 648
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1094, 564)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 633
        Me.Label4.Text = "foto#2"
        '
        'tdimenlargo
        '
        Me.tdimenlargo.Enabled = False
        Me.tdimenlargo.Location = New System.Drawing.Point(1049, 455)
        Me.tdimenlargo.Name = "tdimenlargo"
        Me.tdimenlargo.Size = New System.Drawing.Size(171, 20)
        Me.tdimenlargo.TabIndex = 651
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(947, 564)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 632
        Me.Label7.Text = "foto #1"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(1003, 460)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(37, 13)
        Me.Label19.TabIndex = 649
        Me.Label19.Text = "Largo:"
        '
        'tmodelovh
        '
        Me.tmodelovh.Enabled = False
        Me.tmodelovh.Location = New System.Drawing.Point(1049, 144)
        Me.tmodelovh.Name = "tmodelovh"
        Me.tmodelovh.Size = New System.Drawing.Size(171, 20)
        Me.tmodelovh.TabIndex = 631
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(999, 486)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(41, 13)
        Me.Label18.TabIndex = 650
        Me.Label18.Text = "Ancho:"
        '
        'tmarcavh
        '
        Me.tmarcavh.Enabled = False
        Me.tmarcavh.Location = New System.Drawing.Point(1049, 116)
        Me.tmarcavh.Name = "tmarcavh"
        Me.tmarcavh.Size = New System.Drawing.Size(171, 20)
        Me.tmarcavh.TabIndex = 630
        '
        'tplacveh
        '
        Me.tplacveh.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tplacveh.Enabled = False
        Me.tplacveh.Location = New System.Drawing.Point(1049, 33)
        Me.tplacveh.Name = "tplacveh"
        Me.tplacveh.Size = New System.Drawing.Size(171, 20)
        Me.tplacveh.TabIndex = 628
        '
        'tcodv
        '
        Me.tcodv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tcodv.Enabled = False
        Me.tcodv.Location = New System.Drawing.Point(1049, 5)
        Me.tcodv.Name = "tcodv"
        Me.tcodv.Size = New System.Drawing.Size(171, 20)
        Me.tcodv.TabIndex = 627
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(959, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 621
        Me.Label2.Text = "Placa Vehiculo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1000, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 623
        Me.Label6.Text = "Marca:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(995, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 624
        Me.Label5.Text = "Modelo:"
        '
        'dgvreg
        '
        Me.dgvreg.AllowUserToAddRows = False
        Me.dgvreg.AllowUserToDeleteRows = False
        Me.dgvreg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvreg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID1, Me.Item, Me.ValorS1, Me.Servicio1, Me.HorasTrab1, Me.ValorT, Me.Razon, Me.Fecha})
        Me.dgvreg.Location = New System.Drawing.Point(39, 281)
        Me.dgvreg.MultiSelect = False
        Me.dgvreg.Name = "dgvreg"
        Me.dgvreg.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.dgvreg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvreg.Size = New System.Drawing.Size(890, 176)
        Me.dgvreg.TabIndex = 662
        '
        'ID1
        '
        Me.ID1.HeaderText = "id"
        Me.ID1.Name = "ID1"
        Me.ID1.Visible = False
        '
        'Item
        '
        Me.Item.HeaderText = "no*"
        Me.Item.Name = "Item"
        Me.Item.ReadOnly = True
        Me.Item.Width = 40
        '
        'ValorS1
        '
        Me.ValorS1.HeaderText = "valor_hora"
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
        'bagrlista
        '
        Me.bagrlista.BackColor = System.Drawing.Color.White
        Me.bagrlista.BackgroundImage = CType(resources.GetObject("bagrlista.BackgroundImage"), System.Drawing.Image)
        Me.bagrlista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bagrlista.Location = New System.Drawing.Point(37, 73)
        Me.bagrlista.Name = "bagrlista"
        Me.bagrlista.Size = New System.Drawing.Size(64, 63)
        Me.bagrlista.TabIndex = 687
        Me.bagrlista.UseVisualStyleBackColor = False
        '
        'bimprimir
        '
        Me.bimprimir.BackColor = System.Drawing.Color.White
        Me.bimprimir.BackgroundImage = CType(resources.GetObject("bimprimir.BackgroundImage"), System.Drawing.Image)
        Me.bimprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bimprimir.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bimprimir.Location = New System.Drawing.Point(247, 668)
        Me.bimprimir.Name = "bimprimir"
        Me.bimprimir.Size = New System.Drawing.Size(64, 63)
        Me.bimprimir.TabIndex = 669
        Me.bimprimir.UseVisualStyleBackColor = False
        '
        'breiniciar
        '
        Me.breiniciar.BackColor = System.Drawing.Color.White
        Me.breiniciar.BackgroundImage = CType(resources.GetObject("breiniciar.BackgroundImage"), System.Drawing.Image)
        Me.breiniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.breiniciar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.breiniciar.Location = New System.Drawing.Point(177, 668)
        Me.breiniciar.Name = "breiniciar"
        Me.breiniciar.Size = New System.Drawing.Size(64, 63)
        Me.breiniciar.TabIndex = 668
        Me.breiniciar.UseVisualStyleBackColor = False
        '
        'beliminar
        '
        Me.beliminar.BackgroundImage = CType(resources.GetObject("beliminar.BackgroundImage"), System.Drawing.Image)
        Me.beliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.beliminar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.beliminar.Location = New System.Drawing.Point(865, 668)
        Me.beliminar.Name = "beliminar"
        Me.beliminar.Size = New System.Drawing.Size(64, 63)
        Me.beliminar.TabIndex = 667
        Me.beliminar.UseVisualStyleBackColor = True
        Me.beliminar.Visible = False
        '
        'bagregar
        '
        Me.bagregar.BackgroundImage = CType(resources.GetObject("bagregar.BackgroundImage"), System.Drawing.Image)
        Me.bagregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bagregar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bagregar.Location = New System.Drawing.Point(107, 668)
        Me.bagregar.Name = "bagregar"
        Me.bagregar.Size = New System.Drawing.Size(64, 63)
        Me.bagregar.TabIndex = 666
        Me.bagregar.UseVisualStyleBackColor = True
        '
        'beliminarreg
        '
        Me.beliminarreg.BackColor = System.Drawing.Color.White
        Me.beliminarreg.BackgroundImage = CType(resources.GetObject("beliminarreg.BackgroundImage"), System.Drawing.Image)
        Me.beliminarreg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.beliminarreg.Location = New System.Drawing.Point(37, 668)
        Me.beliminarreg.Name = "beliminarreg"
        Me.beliminarreg.Size = New System.Drawing.Size(64, 63)
        Me.beliminarreg.TabIndex = 665
        Me.beliminarreg.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(37, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(141, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 663
        Me.PictureBox1.TabStop = False
        '
        'pfoto2
        '
        Me.pfoto2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pfoto2.Enabled = False
        Me.pfoto2.Location = New System.Drawing.Point(1095, 582)
        Me.pfoto2.Name = "pfoto2"
        Me.pfoto2.Size = New System.Drawing.Size(134, 142)
        Me.pfoto2.TabIndex = 626
        Me.pfoto2.TabStop = False
        '
        'pfoto
        '
        Me.pfoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pfoto.Enabled = False
        Me.pfoto.Location = New System.Drawing.Point(947, 582)
        Me.pfoto.Name = "pfoto"
        Me.pfoto.Size = New System.Drawing.Size(134, 142)
        Me.pfoto.TabIndex = 625
        Me.pfoto.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(938, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 785
        Me.Label1.Text = "Codigo de Maquina:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(26, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 786
        Me.Label9.Text = "Servicio:"
        '
        'ttipotrab
        '
        Me.ttipotrab.Location = New System.Drawing.Point(123, 29)
        Me.ttipotrab.Name = "ttipotrab"
        Me.ttipotrab.Size = New System.Drawing.Size(296, 20)
        Me.ttipotrab.TabIndex = 787
        '
        'tvalorhora
        '
        Me.tvalorhora.Location = New System.Drawing.Point(123, 57)
        Me.tvalorhora.Name = "tvalorhora"
        Me.tvalorhora.Size = New System.Drawing.Size(79, 20)
        Me.tvalorhora.TabIndex = 789
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(26, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 13)
        Me.Label10.TabIndex = 788
        Me.Label10.Text = "Valor Hora:"
        '
        'thortrab
        '
        Me.thortrab.Location = New System.Drawing.Point(123, 84)
        Me.thortrab.Name = "thortrab"
        Me.thortrab.Size = New System.Drawing.Size(79, 20)
        Me.thortrab.TabIndex = 791
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(26, 86)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 13)
        Me.Label11.TabIndex = 790
        Me.Label11.Text = "Horas Trabajadas:"
        '
        'tvalortotal
        '
        Me.tvalortotal.Enabled = False
        Me.tvalortotal.Location = New System.Drawing.Point(123, 156)
        Me.tvalortotal.Name = "tvalortotal"
        Me.tvalortotal.Size = New System.Drawing.Size(168, 20)
        Me.tvalortotal.TabIndex = 793
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(26, 159)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(61, 13)
        Me.Label24.TabIndex = 792
        Me.Label24.Text = "Valor Total:"
        '
        'trazontrab
        '
        Me.trazontrab.Location = New System.Drawing.Point(123, 111)
        Me.trazontrab.Multiline = True
        Me.trazontrab.Name = "trazontrab"
        Me.trazontrab.Size = New System.Drawing.Size(296, 39)
        Me.trazontrab.TabIndex = 795
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(26, 113)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(80, 13)
        Me.Label25.TabIndex = 794
        Me.Label25.Text = "Razon Trabajo:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.trazontrab)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.tvalortotal)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.thortrab)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.tvalorhora)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.ttipotrab)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(322, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(451, 195)
        Me.GroupBox1.TabIndex = 796
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos a Enviar"
        '
        'Timer2
        '
        '
        'Timer3
        '
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(703, 649)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(34, 13)
        Me.Label31.TabIndex = 798
        Me.Label31.Text = "Total:"
        '
        'txtTotal
        '
        Me.txtTotal.AutoSize = True
        Me.txtTotal.Location = New System.Drawing.Point(742, 649)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(0, 13)
        Me.txtTotal.TabIndex = 797
        '
        'Timer1
        '
        '
        'Timer5
        '
        '
        'FrmMantenimientosMaqObr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1267, 735)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkfiltro)
        Me.Controls.Add(Me.dtp2)
        Me.Controls.Add(Me.dtp1)
        Me.Controls.Add(Me.fechahora)
        Me.Controls.Add(Me.dgvreg2)
        Me.Controls.Add(Me.bagrlista)
        Me.Controls.Add(Me.mensaje)
        Me.Controls.Add(Me.bimprimir)
        Me.Controls.Add(Me.breiniciar)
        Me.Controls.Add(Me.beliminar)
        Me.Controls.Add(Me.bagregar)
        Me.Controls.Add(Me.beliminarreg)
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
        Me.Controls.Add(Me.tcodv)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pfoto2)
        Me.Controls.Add(Me.pfoto)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgvreg)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMantenimientosMaqObr"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMantenimientoMaqObr"
        CType(Me.dgvreg2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvreg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pfoto2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pfoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkfiltro As System.Windows.Forms.CheckBox
    Friend WithEvents dtp2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents fechahora As System.Windows.Forms.Label
    Friend WithEvents dgvreg2 As System.Windows.Forms.DataGridView
    Friend WithEvents bagrlista As System.Windows.Forms.Button
    Friend WithEvents mensaje As System.Windows.Forms.Label
    Friend WithEvents bimprimir As System.Windows.Forms.Button
    Friend WithEvents breiniciar As System.Windows.Forms.Button
    Friend WithEvents beliminar As System.Windows.Forms.Button
    Friend WithEvents bagregar As System.Windows.Forms.Button
    Friend WithEvents beliminarreg As System.Windows.Forms.Button
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
    Friend WithEvents tcodv As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pfoto2 As System.Windows.Forms.PictureBox
    Friend WithEvents pfoto As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgvreg As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ttipotrab As System.Windows.Forms.TextBox
    Friend WithEvents tvalorhora As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents thortrab As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tvalortotal As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents trazontrab As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer5 As System.Windows.Forms.Timer
    Friend WithEvents ID2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Item2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorS2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Servicio2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HorasTrab2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorT2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Razon2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Item As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorS1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Servicio1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HorasTrab1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Razon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
