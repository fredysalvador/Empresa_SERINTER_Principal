<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProveedores))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tcodprov = New System.Windows.Forms.TextBox()
        Me.tidenfiscal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tnombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tdireccion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tcorreo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvproveedor = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tmoneda = New System.Windows.Forms.ComboBox()
        Me.tpais = New System.Windows.Forms.ComboBox()
        Me.tespecialidad = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.talias = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ct3 = New System.Windows.Forms.TextBox()
        Me.ct2 = New System.Windows.Forms.TextBox()
        Me.ct1 = New System.Windows.Forms.TextBox()
        Me.nt3 = New System.Windows.Forms.TextBox()
        Me.nt2 = New System.Windows.Forms.TextBox()
        Me.nt1 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ccampos = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tcriterio = New System.Windows.Forms.TextBox()
        Me.mensaje = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.blimpieza = New System.Windows.Forms.Button()
        Me.bregresar = New System.Windows.Forms.Button()
        Me.bdescartar = New System.Windows.Forms.Button()
        Me.bdatagrid = New System.Windows.Forms.Button()
        Me.breinicio = New System.Windows.Forms.Button()
        Me.bagregar = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        CType(Me.dgvproveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(10, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo Proveedor:"
        '
        'tcodprov
        '
        Me.tcodprov.Location = New System.Drawing.Point(167, 55)
        Me.tcodprov.Name = "tcodprov"
        Me.tcodprov.Size = New System.Drawing.Size(205, 20)
        Me.tcodprov.TabIndex = 1
        '
        'tidenfiscal
        '
        Me.tidenfiscal.Location = New System.Drawing.Point(167, 90)
        Me.tidenfiscal.Name = "tidenfiscal"
        Me.tidenfiscal.Size = New System.Drawing.Size(205, 20)
        Me.tidenfiscal.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(10, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Codigo Iden Fiscal:"
        '
        'tnombre
        '
        Me.tnombre.Location = New System.Drawing.Point(167, 127)
        Me.tnombre.Name = "tnombre"
        Me.tnombre.Size = New System.Drawing.Size(205, 20)
        Me.tnombre.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(10, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nombre Empresa:"
        '
        'tdireccion
        '
        Me.tdireccion.Location = New System.Drawing.Point(14, 257)
        Me.tdireccion.Multiline = True
        Me.tdireccion.Name = "tdireccion"
        Me.tdireccion.Size = New System.Drawing.Size(356, 51)
        Me.tdireccion.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(11, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Dirección:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(12, 323)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Pais:"
        '
        'tcorreo
        '
        Me.tcorreo.Location = New System.Drawing.Point(167, 402)
        Me.tcorreo.Name = "tcorreo"
        Me.tcorreo.Size = New System.Drawing.Size(205, 20)
        Me.tcorreo.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(10, 402)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Correo Electronico:"
        '
        'dgvproveedor
        '
        Me.dgvproveedor.AllowUserToAddRows = False
        Me.dgvproveedor.AllowUserToDeleteRows = False
        Me.dgvproveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvproveedor.Location = New System.Drawing.Point(8, 185)
        Me.dgvproveedor.MultiSelect = False
        Me.dgvproveedor.Name = "dgvproveedor"
        Me.dgvproveedor.ReadOnly = True
        Me.dgvproveedor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvproveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvproveedor.Size = New System.Drawing.Size(856, 417)
        Me.dgvproveedor.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tmoneda)
        Me.GroupBox1.Controls.Add(Me.tpais)
        Me.GroupBox1.Controls.Add(Me.tespecialidad)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.talias)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.ct3)
        Me.GroupBox1.Controls.Add(Me.ct2)
        Me.GroupBox1.Controls.Add(Me.ct1)
        Me.GroupBox1.Controls.Add(Me.nt3)
        Me.GroupBox1.Controls.Add(Me.nt2)
        Me.GroupBox1.Controls.Add(Me.nt1)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.tcorreo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tdireccion)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tnombre)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tidenfiscal)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tcodprov)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(870, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(386, 580)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Generales Proveedores"
        '
        'tmoneda
        '
        Me.tmoneda.FormattingEnabled = True
        Me.tmoneda.Location = New System.Drawing.Point(167, 362)
        Me.tmoneda.Name = "tmoneda"
        Me.tmoneda.Size = New System.Drawing.Size(203, 21)
        Me.tmoneda.TabIndex = 167
        '
        'tpais
        '
        Me.tpais.FormattingEnabled = True
        Me.tpais.Location = New System.Drawing.Point(167, 324)
        Me.tpais.Name = "tpais"
        Me.tpais.Size = New System.Drawing.Size(203, 21)
        Me.tpais.TabIndex = 166
        '
        'tespecialidad
        '
        Me.tespecialidad.Location = New System.Drawing.Point(167, 163)
        Me.tespecialidad.Name = "tespecialidad"
        Me.tespecialidad.Size = New System.Drawing.Size(205, 20)
        Me.tespecialidad.TabIndex = 165
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label17.Location = New System.Drawing.Point(12, 163)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(103, 20)
        Me.Label17.TabIndex = 164
        Me.Label17.Text = "Especialidad:"
        '
        'talias
        '
        Me.talias.Location = New System.Drawing.Point(167, 202)
        Me.talias.Name = "talias"
        Me.talias.Size = New System.Drawing.Size(205, 20)
        Me.talias.TabIndex = 163
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label16.Location = New System.Drawing.Point(12, 202)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(47, 20)
        Me.Label16.TabIndex = 162
        Me.Label16.Text = "Alias:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label15.Location = New System.Drawing.Point(163, 448)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(157, 20)
        Me.Label15.TabIndex = 161
        Me.Label15.Text = "Numero de Telefono:"
        '
        'ct3
        '
        Me.ct3.Location = New System.Drawing.Point(14, 547)
        Me.ct3.Name = "ct3"
        Me.ct3.Size = New System.Drawing.Size(138, 20)
        Me.ct3.TabIndex = 160
        '
        'ct2
        '
        Me.ct2.Location = New System.Drawing.Point(14, 508)
        Me.ct2.Name = "ct2"
        Me.ct2.Size = New System.Drawing.Size(138, 20)
        Me.ct2.TabIndex = 159
        '
        'ct1
        '
        Me.ct1.Location = New System.Drawing.Point(14, 471)
        Me.ct1.Name = "ct1"
        Me.ct1.Size = New System.Drawing.Size(138, 20)
        Me.ct1.TabIndex = 158
        '
        'nt3
        '
        Me.nt3.Location = New System.Drawing.Point(167, 547)
        Me.nt3.Name = "nt3"
        Me.nt3.Size = New System.Drawing.Size(205, 20)
        Me.nt3.TabIndex = 157
        '
        'nt2
        '
        Me.nt2.Location = New System.Drawing.Point(167, 508)
        Me.nt2.Name = "nt2"
        Me.nt2.Size = New System.Drawing.Size(205, 20)
        Me.nt2.TabIndex = 156
        '
        'nt1
        '
        Me.nt1.Location = New System.Drawing.Point(167, 471)
        Me.nt1.Name = "nt1"
        Me.nt1.Size = New System.Drawing.Size(205, 20)
        Me.nt1.TabIndex = 155
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label14.Location = New System.Drawing.Point(10, 448)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(86, 20)
        Me.Label14.TabIndex = 154
        Me.Label14.Text = "Contactos:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label13.Location = New System.Drawing.Point(-669, 65)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 20)
        Me.Label13.TabIndex = 153
        Me.Label13.Text = "Limpiar"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(10, 362)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 20)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Moneda:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label12.Location = New System.Drawing.Point(-681, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(162, 20)
        Me.Label12.TabIndex = 144
        Me.Label12.Text = "Criterio de Busqueda:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label11.Location = New System.Drawing.Point(-583, 65)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 20)
        Me.Label11.TabIndex = 142
        Me.Label11.Text = "Buscar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(192, 24)
        Me.Label7.TabIndex = 144
        Me.Label7.Text = "Criterio de Busqueda:"
        '
        'ccampos
        '
        Me.ccampos.FormattingEnabled = True
        Me.ccampos.Items.AddRange(New Object() {"cod_proveedor", "especialidad", "nom_proveedor", "alias", "pais_prov", "email_prov"})
        Me.ccampos.Location = New System.Drawing.Point(209, 35)
        Me.ccampos.Name = "ccampos"
        Me.ccampos.Size = New System.Drawing.Size(155, 21)
        Me.ccampos.TabIndex = 143
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label8.Location = New System.Drawing.Point(109, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 24)
        Me.Label8.TabIndex = 142
        Me.Label8.Text = "Buscar"
        '
        'tcriterio
        '
        Me.tcriterio.Location = New System.Drawing.Point(209, 124)
        Me.tcriterio.Name = "tcriterio"
        Me.tcriterio.Size = New System.Drawing.Size(155, 20)
        Me.tcriterio.TabIndex = 140
        '
        'mensaje
        '
        Me.mensaje.AutoSize = True
        Me.mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mensaje.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.mensaje.Location = New System.Drawing.Point(6, 607)
        Me.mensaje.Name = "mensaje"
        Me.mensaje.Size = New System.Drawing.Size(75, 16)
        Me.mensaje.TabIndex = 145
        Me.mensaje.Text = "Mensajes"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label10.Location = New System.Drawing.Point(23, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 24)
        Me.Label10.TabIndex = 153
        Me.Label10.Text = "Limpiar"
        '
        'blimpieza
        '
        Me.blimpieza.BackColor = System.Drawing.Color.White
        Me.blimpieza.BackgroundImage = CType(resources.GetObject("blimpieza.BackgroundImage"), System.Drawing.Image)
        Me.blimpieza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.blimpieza.Location = New System.Drawing.Point(27, 105)
        Me.blimpieza.Name = "blimpieza"
        Me.blimpieza.Size = New System.Drawing.Size(64, 56)
        Me.blimpieza.TabIndex = 152
        Me.blimpieza.UseVisualStyleBackColor = False
        '
        'bregresar
        '
        Me.bregresar.BackgroundImage = CType(resources.GetObject("bregresar.BackgroundImage"), System.Drawing.Image)
        Me.bregresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bregresar.Location = New System.Drawing.Point(391, 57)
        Me.bregresar.Name = "bregresar"
        Me.bregresar.Size = New System.Drawing.Size(89, 66)
        Me.bregresar.TabIndex = 151
        Me.bregresar.UseVisualStyleBackColor = True
        '
        'bdescartar
        '
        Me.bdescartar.BackgroundImage = CType(resources.GetObject("bdescartar.BackgroundImage"), System.Drawing.Image)
        Me.bdescartar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bdescartar.Enabled = False
        Me.bdescartar.Location = New System.Drawing.Point(739, 114)
        Me.bdescartar.Name = "bdescartar"
        Me.bdescartar.Size = New System.Drawing.Size(59, 64)
        Me.bdescartar.TabIndex = 149
        Me.bdescartar.UseVisualStyleBackColor = True
        '
        'bdatagrid
        '
        Me.bdatagrid.BackgroundImage = CType(resources.GetObject("bdatagrid.BackgroundImage"), System.Drawing.Image)
        Me.bdatagrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bdatagrid.Location = New System.Drawing.Point(804, 114)
        Me.bdatagrid.Name = "bdatagrid"
        Me.bdatagrid.Size = New System.Drawing.Size(59, 64)
        Me.bdatagrid.TabIndex = 148
        Me.bdatagrid.UseVisualStyleBackColor = True
        '
        'breinicio
        '
        Me.breinicio.BackColor = System.Drawing.Color.White
        Me.breinicio.BackgroundImage = CType(resources.GetObject("breinicio.BackgroundImage"), System.Drawing.Image)
        Me.breinicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.breinicio.Location = New System.Drawing.Point(673, 114)
        Me.breinicio.Name = "breinicio"
        Me.breinicio.Size = New System.Drawing.Size(59, 63)
        Me.breinicio.TabIndex = 147
        Me.breinicio.UseVisualStyleBackColor = False
        '
        'bagregar
        '
        Me.bagregar.BackColor = System.Drawing.Color.LightGray
        Me.bagregar.BackgroundImage = CType(resources.GetObject("bagregar.BackgroundImage"), System.Drawing.Image)
        Me.bagregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bagregar.Location = New System.Drawing.Point(608, 114)
        Me.bagregar.Name = "bagregar"
        Me.bagregar.Size = New System.Drawing.Size(59, 63)
        Me.bagregar.TabIndex = 146
        Me.bagregar.UseVisualStyleBackColor = False
        '
        'btnbuscar
        '
        Me.btnbuscar.BackColor = System.Drawing.Color.White
        Me.btnbuscar.BackgroundImage = CType(resources.GetObject("btnbuscar.BackgroundImage"), System.Drawing.Image)
        Me.btnbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscar.Location = New System.Drawing.Point(113, 105)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(64, 56)
        Me.btnbuscar.TabIndex = 141
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'FrmProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1263, 628)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.blimpieza)
        Me.Controls.Add(Me.bregresar)
        Me.Controls.Add(Me.bdescartar)
        Me.Controls.Add(Me.bdatagrid)
        Me.Controls.Add(Me.breinicio)
        Me.Controls.Add(Me.bagregar)
        Me.Controls.Add(Me.mensaje)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ccampos)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.tcriterio)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvproveedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmProveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario Proveedores"
        CType(Me.dgvproveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tcodprov As System.Windows.Forms.TextBox
    Friend WithEvents tidenfiscal As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tdireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tcorreo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dgvproveedor As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ccampos As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents tcriterio As System.Windows.Forms.TextBox
    Friend WithEvents bdescartar As System.Windows.Forms.Button
    Friend WithEvents bdatagrid As System.Windows.Forms.Button
    Friend WithEvents breinicio As System.Windows.Forms.Button
    Friend WithEvents bagregar As System.Windows.Forms.Button
    Friend WithEvents mensaje As System.Windows.Forms.Label
    Friend WithEvents bregresar As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents blimpieza As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ct3 As System.Windows.Forms.TextBox
    Friend WithEvents ct2 As System.Windows.Forms.TextBox
    Friend WithEvents ct1 As System.Windows.Forms.TextBox
    Friend WithEvents nt3 As System.Windows.Forms.TextBox
    Friend WithEvents nt2 As System.Windows.Forms.TextBox
    Friend WithEvents nt1 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents talias As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents tespecialidad As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents tpais As System.Windows.Forms.ComboBox
    Friend WithEvents tmoneda As System.Windows.Forms.ComboBox
End Class
