<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientosMaqUsura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMantenimientosMaqUsura))
        Me.fechahora = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ccampos = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tcriterio = New System.Windows.Forms.TextBox()
        Me.dgvinventario = New System.Windows.Forms.DataGridView()
        Me.codp1 = New System.Windows.Forms.ComboBox()
        Me.ccategoria = New System.Windows.Forms.ComboBox()
        Me.tnombre = New System.Windows.Forms.TextBox()
        Me.codp2 = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvreg = New System.Windows.Forms.DataGridView()
        Me.ID1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Componente_Usura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad_mont = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.blimpieza = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.bdatagridinv = New System.Windows.Forms.Button()
        Me.bagrlista = New System.Windows.Forms.Button()
        Me.pfoto4 = New System.Windows.Forms.PictureBox()
        Me.pfoto3 = New System.Windows.Forms.PictureBox()
        Me.bimprimir = New System.Windows.Forms.Button()
        Me.breiniciar = New System.Windows.Forms.Button()
        Me.beliminar = New System.Windows.Forms.Button()
        Me.bagregar = New System.Windows.Forms.Button()
        Me.beliminarreg = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pfoto2 = New System.Windows.Forms.PictureBox()
        Me.pfoto = New System.Windows.Forms.PictureBox()
        Me.dgvreg2 = New System.Windows.Forms.DataGridView()
        Me.ID2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Componente_Usura2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad_mont2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tcompusu = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.tcantidadmont = New System.Windows.Forms.NumericUpDown()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.dgvinventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvreg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pfoto4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pfoto3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pfoto2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pfoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvreg2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tcantidadmont, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fechahora
        '
        Me.fechahora.AutoSize = True
        Me.fechahora.Location = New System.Drawing.Point(528, 31)
        Me.fechahora.Name = "fechahora"
        Me.fechahora.Size = New System.Drawing.Size(39, 13)
        Me.fechahora.TabIndex = 700
        Me.fechahora.Text = "Label1"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label10.Location = New System.Drawing.Point(608, 108)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 24)
        Me.Label10.TabIndex = 696
        Me.Label10.Text = "Limpiar"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(190, 67)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(192, 24)
        Me.Label9.TabIndex = 694
        Me.Label9.Text = "Criterio de Busqueda:"
        '
        'ccampos
        '
        Me.ccampos.Enabled = False
        Me.ccampos.FormattingEnabled = True
        Me.ccampos.Items.AddRange(New Object() {"codigop", "prefijo", "nom_prod"})
        Me.ccampos.Location = New System.Drawing.Point(388, 67)
        Me.ccampos.Name = "ccampos"
        Me.ccampos.Size = New System.Drawing.Size(108, 21)
        Me.ccampos.TabIndex = 693
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label11.Location = New System.Drawing.Point(519, 109)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 24)
        Me.Label11.TabIndex = 692
        Me.Label11.Text = "Buscar"
        '
        'tcriterio
        '
        Me.tcriterio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tcriterio.Enabled = False
        Me.tcriterio.Location = New System.Drawing.Point(388, 101)
        Me.tcriterio.Name = "tcriterio"
        Me.tcriterio.Size = New System.Drawing.Size(108, 20)
        Me.tcriterio.TabIndex = 690
        '
        'dgvinventario
        '
        Me.dgvinventario.AllowUserToAddRows = False
        Me.dgvinventario.AllowUserToDeleteRows = False
        Me.dgvinventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvinventario.Location = New System.Drawing.Point(37, 132)
        Me.dgvinventario.MultiSelect = False
        Me.dgvinventario.Name = "dgvinventario"
        Me.dgvinventario.ReadOnly = True
        Me.dgvinventario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvinventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvinventario.Size = New System.Drawing.Size(367, 127)
        Me.dgvinventario.TabIndex = 687
        Me.dgvinventario.Visible = False
        '
        'codp1
        '
        Me.codp1.Enabled = False
        Me.codp1.FormattingEnabled = True
        Me.codp1.Items.AddRange(New Object() {"A", "B", "C"})
        Me.codp1.Location = New System.Drawing.Point(628, 138)
        Me.codp1.Name = "codp1"
        Me.codp1.Size = New System.Drawing.Size(41, 21)
        Me.codp1.TabIndex = 679
        '
        'ccategoria
        '
        Me.ccategoria.Enabled = False
        Me.ccategoria.FormattingEnabled = True
        Me.ccategoria.Items.AddRange(New Object() {"Repuesto de Maquinaria", "Material de Construcción", "Objeto de Limpieza", "Herramienta de Mantenimiento", "Objeto de Oficina", "Otros"})
        Me.ccategoria.Location = New System.Drawing.Point(537, 189)
        Me.ccategoria.Name = "ccategoria"
        Me.ccategoria.Size = New System.Drawing.Size(389, 21)
        Me.ccategoria.TabIndex = 678
        '
        'tnombre
        '
        Me.tnombre.Enabled = False
        Me.tnombre.Location = New System.Drawing.Point(537, 164)
        Me.tnombre.Name = "tnombre"
        Me.tnombre.Size = New System.Drawing.Size(389, 20)
        Me.tnombre.TabIndex = 676
        '
        'codp2
        '
        Me.codp2.Enabled = False
        Me.codp2.Location = New System.Drawing.Point(537, 138)
        Me.codp2.Name = "codp2"
        Me.codp2.Size = New System.Drawing.Size(85, 20)
        Me.codp2.TabIndex = 675
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(447, 192)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(55, 13)
        Me.Label27.TabIndex = 674
        Me.Label27.Text = "Categoria:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(439, 141)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(89, 13)
        Me.Label28.TabIndex = 673
        Me.Label28.Text = "Codigo Producto:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(430, 167)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(108, 13)
        Me.Label29.TabIndex = 672
        Me.Label29.Text = "Nombre de Producto:"
        '
        'mensaje
        '
        Me.mensaje.AutoSize = True
        Me.mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mensaje.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.mensaje.Location = New System.Drawing.Point(511, 708)
        Me.mensaje.Name = "mensaje"
        Me.mensaje.Size = New System.Drawing.Size(75, 16)
        Me.mensaje.TabIndex = 671
        Me.mensaje.Text = "Mensajes"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(185, 23)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(268, 24)
        Me.Label32.TabIndex = 665
        Me.Label32.Text = "Componentes desgastables"
        '
        'ttipomaq
        '
        Me.ttipomaq.Enabled = False
        Me.ttipomaq.Location = New System.Drawing.Point(1049, 88)
        Me.ttipomaq.Name = "ttipomaq"
        Me.ttipomaq.Size = New System.Drawing.Size(171, 20)
        Me.ttipomaq.TabIndex = 659
        '
        'ttipotrans
        '
        Me.ttipotrans.Enabled = False
        Me.ttipotrans.FormattingEnabled = True
        Me.ttipotrans.Items.AddRange(New Object() {"Manual", "Automatizadas o secuenciales", "Automático", "CVT", "Automatizada de doble embrague"})
        Me.ttipotrans.Location = New System.Drawing.Point(1049, 341)
        Me.ttipotrans.Name = "ttipotrans"
        Me.ttipotrans.Size = New System.Drawing.Size(171, 21)
        Me.ttipotrans.TabIndex = 662
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(950, 92)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(90, 13)
        Me.Label22.TabIndex = 658
        Me.Label22.Text = "Tipo de Maquina:"
        '
        'tyearfab
        '
        Me.tyearfab.Enabled = False
        Me.tyearfab.Location = New System.Drawing.Point(1048, 426)
        Me.tyearfab.Name = "tyearfab"
        Me.tyearfab.Size = New System.Drawing.Size(171, 20)
        Me.tyearfab.TabIndex = 661
        '
        'tubicacion
        '
        Me.tubicacion.Enabled = False
        Me.tubicacion.FormattingEnabled = True
        Me.tubicacion.Items.AddRange(New Object() {"COPRECA", "SERINTER"})
        Me.tubicacion.Location = New System.Drawing.Point(1050, 198)
        Me.tubicacion.Name = "tubicacion"
        Me.tubicacion.Size = New System.Drawing.Size(171, 21)
        Me.tubicacion.TabIndex = 646
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(938, 429)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(102, 13)
        Me.Label23.TabIndex = 660
        Me.Label23.Text = "Año de Fabricacion:"
        '
        'dtpcompra
        '
        Me.dtpcompra.Enabled = False
        Me.dtpcompra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpcompra.Location = New System.Drawing.Point(1051, 289)
        Me.dtpcompra.Name = "dtpcompra"
        Me.dtpcompra.Size = New System.Drawing.Size(101, 20)
        Me.dtpcompra.TabIndex = 645
        '
        'tpreciocompra
        '
        Me.tpreciocompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tpreciocompra.Enabled = False
        Me.tpreciocompra.Location = New System.Drawing.Point(1050, 314)
        Me.tpreciocompra.Name = "tpreciocompra"
        Me.tpreciocompra.Size = New System.Drawing.Size(121, 20)
        Me.tpreciocompra.TabIndex = 644
        '
        'tdimenpeso
        '
        Me.tdimenpeso.Enabled = False
        Me.tdimenpeso.Location = New System.Drawing.Point(1049, 538)
        Me.tdimenpeso.Name = "tdimenpeso"
        Me.tdimenpeso.Size = New System.Drawing.Size(171, 20)
        Me.tdimenpeso.TabIndex = 657
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(961, 318)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 13)
        Me.Label12.TabIndex = 643
        Me.Label12.Text = "Precio Compra:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(935, 344)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(105, 13)
        Me.Label17.TabIndex = 647
        Me.Label17.Text = "Tipo de Transmision:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(982, 201)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 13)
        Me.Label15.TabIndex = 642
        Me.Label15.Text = "Ubicacion:"
        '
        'tdimenalto
        '
        Me.tdimenalto.Enabled = False
        Me.tdimenalto.Location = New System.Drawing.Point(1049, 511)
        Me.tdimenalto.Name = "tdimenalto"
        Me.tdimenalto.Size = New System.Drawing.Size(171, 20)
        Me.tdimenalto.TabIndex = 656
        '
        'tpropetarios
        '
        Me.tpropetarios.Enabled = False
        Me.tpropetarios.FormattingEnabled = True
        Me.tpropetarios.Items.AddRange(New Object() {"COPRECA", "SERINTER"})
        Me.tpropetarios.Location = New System.Drawing.Point(1049, 170)
        Me.tpropetarios.Name = "tpropetarios"
        Me.tpropetarios.Size = New System.Drawing.Size(171, 21)
        Me.tpropetarios.TabIndex = 641
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1006, 401)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 623
        Me.Label3.Text = "Color:"
        '
        'tpropietario
        '
        Me.tpropietario.AutoSize = True
        Me.tpropietario.Location = New System.Drawing.Point(980, 174)
        Me.tpropietario.Name = "tpropietario"
        Me.tpropietario.Size = New System.Drawing.Size(60, 13)
        Me.tpropietario.TabIndex = 640
        Me.tpropietario.Text = "Propietario:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(1006, 541)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(34, 13)
        Me.Label20.TabIndex = 655
        Me.Label20.Text = "Peso:"
        '
        'tcondicion
        '
        Me.tcondicion.Enabled = False
        Me.tcondicion.Location = New System.Drawing.Point(953, 241)
        Me.tcondicion.Multiline = True
        Me.tcondicion.Name = "tcondicion"
        Me.tcondicion.Size = New System.Drawing.Size(276, 42)
        Me.tcondicion.TabIndex = 639
        '
        'tcolorvh
        '
        Me.tcolorvh.Enabled = False
        Me.tcolorvh.Location = New System.Drawing.Point(1048, 398)
        Me.tcolorvh.Name = "tcolorvh"
        Me.tcolorvh.Size = New System.Drawing.Size(171, 20)
        Me.tcolorvh.TabIndex = 630
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(961, 292)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 13)
        Me.Label13.TabIndex = 638
        Me.Label13.Text = "Fecha Compra:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(1012, 516)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(28, 13)
        Me.Label21.TabIndex = 654
        Me.Label21.Text = "Alto:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(950, 225)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 13)
        Me.Label14.TabIndex = 637
        Me.Label14.Text = "Condicion Maquinaria:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(948, 373)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(92, 13)
        Me.Label16.TabIndex = 648
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
        Me.testadovh.TabIndex = 636
        '
        'tdimenancho
        '
        Me.tdimenancho.Enabled = False
        Me.tdimenancho.Location = New System.Drawing.Point(1049, 483)
        Me.tdimenancho.Name = "tdimenancho"
        Me.tdimenancho.Size = New System.Drawing.Size(171, 20)
        Me.tdimenancho.TabIndex = 653
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(942, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 13)
        Me.Label8.TabIndex = 635
        Me.Label8.Text = "Estado Maquinaria:"
        '
        'tnomotor
        '
        Me.tnomotor.Enabled = False
        Me.tnomotor.Location = New System.Drawing.Point(1048, 370)
        Me.tnomotor.Name = "tnomotor"
        Me.tnomotor.Size = New System.Drawing.Size(171, 20)
        Me.tnomotor.TabIndex = 649
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1094, 564)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 634
        Me.Label4.Text = "foto#2"
        '
        'tdimenlargo
        '
        Me.tdimenlargo.Enabled = False
        Me.tdimenlargo.Location = New System.Drawing.Point(1049, 455)
        Me.tdimenlargo.Name = "tdimenlargo"
        Me.tdimenlargo.Size = New System.Drawing.Size(171, 20)
        Me.tdimenlargo.TabIndex = 652
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(947, 564)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 633
        Me.Label7.Text = "foto #1"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(1003, 460)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(37, 13)
        Me.Label19.TabIndex = 650
        Me.Label19.Text = "Largo:"
        '
        'tmodelovh
        '
        Me.tmodelovh.Enabled = False
        Me.tmodelovh.Location = New System.Drawing.Point(1049, 144)
        Me.tmodelovh.Name = "tmodelovh"
        Me.tmodelovh.Size = New System.Drawing.Size(171, 20)
        Me.tmodelovh.TabIndex = 632
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(999, 486)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(41, 13)
        Me.Label18.TabIndex = 651
        Me.Label18.Text = "Ancho:"
        '
        'tmarcavh
        '
        Me.tmarcavh.Enabled = False
        Me.tmarcavh.Location = New System.Drawing.Point(1049, 116)
        Me.tmarcavh.Name = "tmarcavh"
        Me.tmarcavh.Size = New System.Drawing.Size(171, 20)
        Me.tmarcavh.TabIndex = 631
        '
        'tplacveh
        '
        Me.tplacveh.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tplacveh.Enabled = False
        Me.tplacveh.Location = New System.Drawing.Point(1049, 33)
        Me.tplacveh.Name = "tplacveh"
        Me.tplacveh.Size = New System.Drawing.Size(171, 20)
        Me.tplacveh.TabIndex = 629
        '
        'tcodv
        '
        Me.tcodv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tcodv.Enabled = False
        Me.tcodv.Location = New System.Drawing.Point(1049, 4)
        Me.tcodv.Name = "tcodv"
        Me.tcodv.Size = New System.Drawing.Size(171, 20)
        Me.tcodv.TabIndex = 628
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(959, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 622
        Me.Label2.Text = "Placa Vehiculo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(938, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 621
        Me.Label1.Text = "Codigo de Maquina:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1000, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 624
        Me.Label6.Text = "Marca:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(995, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 625
        Me.Label5.Text = "Modelo:"
        '
        'dgvreg
        '
        Me.dgvreg.AllowUserToAddRows = False
        Me.dgvreg.AllowUserToDeleteRows = False
        Me.dgvreg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvreg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID1, Me.Componente_Usura, Me.Codigo, Me.Cantidad_mont})
        Me.dgvreg.Location = New System.Drawing.Point(39, 286)
        Me.dgvreg.MultiSelect = False
        Me.dgvreg.Name = "dgvreg"
        Me.dgvreg.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.dgvreg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvreg.Size = New System.Drawing.Size(890, 176)
        Me.dgvreg.TabIndex = 663
        '
        'ID1
        '
        Me.ID1.HeaderText = "id"
        Me.ID1.Name = "ID1"
        Me.ID1.Visible = False
        '
        'Componente_Usura
        '
        Me.Componente_Usura.HeaderText = "Componente_Usura"
        Me.Componente_Usura.Name = "Componente_Usura"
        Me.Componente_Usura.Width = 450
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Width = 200
        '
        'Cantidad_mont
        '
        Me.Cantidad_mont.HeaderText = "Cantidad Montada"
        Me.Cantidad_mont.Name = "Cantidad_mont"
        Me.Cantidad_mont.Width = 197
        '
        'blimpieza
        '
        Me.blimpieza.BackColor = System.Drawing.Color.White
        Me.blimpieza.BackgroundImage = CType(resources.GetObject("blimpieza.BackgroundImage"), System.Drawing.Image)
        Me.blimpieza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.blimpieza.Location = New System.Drawing.Point(611, 49)
        Me.blimpieza.Name = "blimpieza"
        Me.blimpieza.Size = New System.Drawing.Size(64, 56)
        Me.blimpieza.TabIndex = 695
        Me.blimpieza.UseVisualStyleBackColor = False
        '
        'btnbuscar
        '
        Me.btnbuscar.BackColor = System.Drawing.Color.White
        Me.btnbuscar.BackgroundImage = CType(resources.GetObject("btnbuscar.BackgroundImage"), System.Drawing.Image)
        Me.btnbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscar.Enabled = False
        Me.btnbuscar.Location = New System.Drawing.Point(521, 49)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(64, 56)
        Me.btnbuscar.TabIndex = 691
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'bdatagridinv
        '
        Me.bdatagridinv.BackgroundImage = CType(resources.GetObject("bdatagridinv.BackgroundImage"), System.Drawing.Image)
        Me.bdatagridinv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bdatagridinv.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bdatagridinv.Location = New System.Drawing.Point(107, 64)
        Me.bdatagridinv.Name = "bdatagridinv"
        Me.bdatagridinv.Size = New System.Drawing.Size(64, 62)
        Me.bdatagridinv.TabIndex = 689
        Me.bdatagridinv.UseVisualStyleBackColor = True
        '
        'bagrlista
        '
        Me.bagrlista.BackColor = System.Drawing.Color.White
        Me.bagrlista.BackgroundImage = CType(resources.GetObject("bagrlista.BackgroundImage"), System.Drawing.Image)
        Me.bagrlista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bagrlista.Enabled = False
        Me.bagrlista.Location = New System.Drawing.Point(37, 63)
        Me.bagrlista.Name = "bagrlista"
        Me.bagrlista.Size = New System.Drawing.Size(64, 63)
        Me.bagrlista.TabIndex = 688
        Me.bagrlista.UseVisualStyleBackColor = False
        '
        'pfoto4
        '
        Me.pfoto4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pfoto4.Location = New System.Drawing.Point(813, 20)
        Me.pfoto4.Name = "pfoto4"
        Me.pfoto4.Size = New System.Drawing.Size(113, 130)
        Me.pfoto4.TabIndex = 681
        Me.pfoto4.TabStop = False
        '
        'pfoto3
        '
        Me.pfoto3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pfoto3.Location = New System.Drawing.Point(695, 20)
        Me.pfoto3.Name = "pfoto3"
        Me.pfoto3.Size = New System.Drawing.Size(112, 130)
        Me.pfoto3.TabIndex = 680
        Me.pfoto3.TabStop = False
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
        Me.bimprimir.TabIndex = 670
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
        Me.breiniciar.TabIndex = 669
        Me.breiniciar.UseVisualStyleBackColor = False
        '
        'beliminar
        '
        Me.beliminar.BackgroundImage = CType(resources.GetObject("beliminar.BackgroundImage"), System.Drawing.Image)
        Me.beliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.beliminar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.beliminar.Location = New System.Drawing.Point(862, 668)
        Me.beliminar.Name = "beliminar"
        Me.beliminar.Size = New System.Drawing.Size(64, 63)
        Me.beliminar.TabIndex = 668
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
        Me.bagregar.TabIndex = 667
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
        Me.beliminarreg.TabIndex = 669
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
        Me.PictureBox1.TabIndex = 664
        Me.PictureBox1.TabStop = False
        '
        'pfoto2
        '
        Me.pfoto2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pfoto2.Enabled = False
        Me.pfoto2.Location = New System.Drawing.Point(1095, 582)
        Me.pfoto2.Name = "pfoto2"
        Me.pfoto2.Size = New System.Drawing.Size(134, 142)
        Me.pfoto2.TabIndex = 627
        Me.pfoto2.TabStop = False
        '
        'pfoto
        '
        Me.pfoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pfoto.Enabled = False
        Me.pfoto.Location = New System.Drawing.Point(947, 582)
        Me.pfoto.Name = "pfoto"
        Me.pfoto.Size = New System.Drawing.Size(134, 142)
        Me.pfoto.TabIndex = 626
        Me.pfoto.TabStop = False
        '
        'dgvreg2
        '
        Me.dgvreg2.AllowUserToAddRows = False
        Me.dgvreg2.AllowUserToDeleteRows = False
        Me.dgvreg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvreg2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID2, Me.Componente_Usura2, Me.Codigo2, Me.Cantidad_mont2})
        Me.dgvreg2.Location = New System.Drawing.Point(39, 468)
        Me.dgvreg2.MultiSelect = False
        Me.dgvreg2.Name = "dgvreg2"
        Me.dgvreg2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.dgvreg2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvreg2.Size = New System.Drawing.Size(890, 176)
        Me.dgvreg2.TabIndex = 706
        '
        'ID2
        '
        Me.ID2.HeaderText = "id"
        Me.ID2.Name = "ID2"
        Me.ID2.Visible = False
        '
        'Componente_Usura2
        '
        Me.Componente_Usura2.HeaderText = "Componente_Usura"
        Me.Componente_Usura2.Name = "Componente_Usura2"
        Me.Componente_Usura2.ReadOnly = True
        Me.Componente_Usura2.Width = 450
        '
        'Codigo2
        '
        Me.Codigo2.HeaderText = "Codigo"
        Me.Codigo2.Name = "Codigo2"
        Me.Codigo2.ReadOnly = True
        Me.Codigo2.Width = 200
        '
        'Cantidad_mont2
        '
        Me.Cantidad_mont2.HeaderText = "Cantidad Montada"
        Me.Cantidad_mont2.Name = "Cantidad_mont2"
        Me.Cantidad_mont2.ReadOnly = True
        Me.Cantidad_mont2.Width = 197
        '
        'tcompusu
        '
        Me.tcompusu.Location = New System.Drawing.Point(537, 216)
        Me.tcompusu.Name = "tcompusu"
        Me.tcompusu.Size = New System.Drawing.Size(389, 20)
        Me.tcompusu.TabIndex = 708
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(430, 219)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(101, 13)
        Me.Label24.TabIndex = 707
        Me.Label24.Text = "Componente Usura:"
        '
        'tcantidadmont
        '
        Me.tcantidadmont.Location = New System.Drawing.Point(537, 242)
        Me.tcantidadmont.Name = "tcantidadmont"
        Me.tcantidadmont.Size = New System.Drawing.Size(120, 20)
        Me.tcantidadmont.TabIndex = 709
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(430, 244)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(97, 13)
        Me.Label25.TabIndex = 710
        Me.Label25.Text = "Cantidad Montada:"
        '
        'Timer2
        '
        '
        'Timer1
        '
        '
        'FrmMantenimientosMaqUsura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1267, 735)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.tcantidadmont)
        Me.Controls.Add(Me.tcompusu)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.dgvreg2)
        Me.Controls.Add(Me.fechahora)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.blimpieza)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ccampos)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.tcriterio)
        Me.Controls.Add(Me.bdatagridinv)
        Me.Controls.Add(Me.bagrlista)
        Me.Controls.Add(Me.dgvinventario)
        Me.Controls.Add(Me.pfoto4)
        Me.Controls.Add(Me.pfoto3)
        Me.Controls.Add(Me.codp1)
        Me.Controls.Add(Me.ccategoria)
        Me.Controls.Add(Me.tnombre)
        Me.Controls.Add(Me.codp2)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label29)
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
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pfoto)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgvreg)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMantenimientosMaqUsura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMantenimientosMaqUsura"
        CType(Me.dgvinventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvreg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pfoto4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pfoto3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pfoto2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pfoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvreg2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tcantidadmont, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents fechahora As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents blimpieza As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ccampos As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents tcriterio As System.Windows.Forms.TextBox
    Friend WithEvents bdatagridinv As System.Windows.Forms.Button
    Friend WithEvents bagrlista As System.Windows.Forms.Button
    Friend WithEvents dgvinventario As System.Windows.Forms.DataGridView
    Friend WithEvents pfoto4 As System.Windows.Forms.PictureBox
    Friend WithEvents pfoto3 As System.Windows.Forms.PictureBox
    Friend WithEvents codp1 As System.Windows.Forms.ComboBox
    Friend WithEvents ccategoria As System.Windows.Forms.ComboBox
    Friend WithEvents tnombre As System.Windows.Forms.TextBox
    Friend WithEvents codp2 As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pfoto As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgvreg As System.Windows.Forms.DataGridView
    Friend WithEvents dgvreg2 As System.Windows.Forms.DataGridView
    Friend WithEvents tcompusu As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents tcantidadmont As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ID1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Componente_Usura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad_mont As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Componente_Usura2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Codigo2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad_mont2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
