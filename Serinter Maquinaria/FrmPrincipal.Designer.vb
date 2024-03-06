<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
    Inherits MaterialSkin.Controls.MaterialForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.busuario = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.bproveedor = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.bfechasret1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.bsolicitudes = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.bcotizaciones = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.bordenes = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.binventariado = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.bgastosmaq = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.bhojasalida = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.bpaseentrada = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.bmaquinariareg = New System.Windows.Forms.ToolStripButton()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.lnombres = New System.Windows.Forms.Label()
        Me.MaterialContextMenuStrip1 = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.lrol = New System.Windows.Forms.Label()
        Me.MzButtonWindows3 = New BWCMM.MZButtonWindows()
        Me.MzButtonWindows2 = New BWCMM.MZButtonWindows()
        Me.MzButtonWindows1 = New BWCMM.MZButtonWindows()
        Me.ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.AutoSize = False
        Me.ToolStrip.BackColor = System.Drawing.Color.DarkCyan
        Me.ToolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ToolStrip.GripMargin = New System.Windows.Forms.Padding(20)
        Me.ToolStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.busuario, Me.ToolStripSeparator3, Me.bproveedor, Me.ToolStripSeparator1, Me.bfechasret1, Me.ToolStripSeparator9, Me.bsolicitudes, Me.ToolStripSeparator2, Me.bcotizaciones, Me.ToolStripSeparator10, Me.bordenes, Me.ToolStripSeparator4, Me.binventariado, Me.ToolStripSeparator5, Me.bgastosmaq, Me.ToolStripSeparator6, Me.bhojasalida, Me.ToolStripSeparator7, Me.bpaseentrada, Me.ToolStripSeparator8, Me.bmaquinariareg})
        Me.ToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Margin = New System.Windows.Forms.Padding(20)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(1365, 63)
        Me.ToolStrip.TabIndex = 6
        Me.ToolStrip.Text = "ToolStrip"
        '
        'busuario
        '
        Me.busuario.BackColor = System.Drawing.Color.Transparent
        Me.busuario.BackgroundImage = CType(resources.GetObject("busuario.BackgroundImage"), System.Drawing.Image)
        Me.busuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.busuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.busuario.ImageTransparentColor = System.Drawing.Color.Black
        Me.busuario.Margin = New System.Windows.Forms.Padding(30, 10, 0, 2)
        Me.busuario.Name = "busuario"
        Me.busuario.Padding = New System.Windows.Forms.Padding(20)
        Me.busuario.Size = New System.Drawing.Size(44, 44)
        Me.busuario.Text = "Gestion de Usuarios "
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Margin = New System.Windows.Forms.Padding(10)
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 23)
        '
        'bproveedor
        '
        Me.bproveedor.BackgroundImage = CType(resources.GetObject("bproveedor.BackgroundImage"), System.Drawing.Image)
        Me.bproveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bproveedor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bproveedor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bproveedor.Margin = New System.Windows.Forms.Padding(0, 10, 0, 2)
        Me.bproveedor.Name = "bproveedor"
        Me.bproveedor.Padding = New System.Windows.Forms.Padding(20)
        Me.bproveedor.Size = New System.Drawing.Size(44, 44)
        Me.bproveedor.Text = "Gestion de Proveedores"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Margin = New System.Windows.Forms.Padding(10)
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 23)
        '
        'bfechasret1
        '
        Me.bfechasret1.BackgroundImage = CType(resources.GetObject("bfechasret1.BackgroundImage"), System.Drawing.Image)
        Me.bfechasret1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bfechasret1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bfechasret1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bfechasret1.Margin = New System.Windows.Forms.Padding(0, 10, 0, 2)
        Me.bfechasret1.Name = "bfechasret1"
        Me.bfechasret1.Padding = New System.Windows.Forms.Padding(20)
        Me.bfechasret1.Size = New System.Drawing.Size(44, 44)
        Me.bfechasret1.Text = "Gestionamiento de Fechas de Retorno de Maquinaria e Inventario"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Margin = New System.Windows.Forms.Padding(10)
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 23)
        Me.ToolStripSeparator9.Visible = False
        '
        'bsolicitudes
        '
        Me.bsolicitudes.BackColor = System.Drawing.Color.Transparent
        Me.bsolicitudes.BackgroundImage = CType(resources.GetObject("bsolicitudes.BackgroundImage"), System.Drawing.Image)
        Me.bsolicitudes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bsolicitudes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bsolicitudes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bsolicitudes.Margin = New System.Windows.Forms.Padding(0, 10, 0, 2)
        Me.bsolicitudes.Name = "bsolicitudes"
        Me.bsolicitudes.Padding = New System.Windows.Forms.Padding(20)
        Me.bsolicitudes.Size = New System.Drawing.Size(44, 44)
        Me.bsolicitudes.Text = "Gestion de Solicitud de Compra"
        Me.bsolicitudes.Visible = False
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Margin = New System.Windows.Forms.Padding(10)
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 23)
        Me.ToolStripSeparator2.Visible = False
        '
        'bcotizaciones
        '
        Me.bcotizaciones.BackgroundImage = CType(resources.GetObject("bcotizaciones.BackgroundImage"), System.Drawing.Image)
        Me.bcotizaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bcotizaciones.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bcotizaciones.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bcotizaciones.Margin = New System.Windows.Forms.Padding(0, 10, 0, 2)
        Me.bcotizaciones.Name = "bcotizaciones"
        Me.bcotizaciones.Padding = New System.Windows.Forms.Padding(20)
        Me.bcotizaciones.Size = New System.Drawing.Size(44, 44)
        Me.bcotizaciones.Text = "Gestion de Cotizaciones"
        Me.bcotizaciones.Visible = False
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Margin = New System.Windows.Forms.Padding(10)
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 23)
        '
        'bordenes
        '
        Me.bordenes.BackgroundImage = CType(resources.GetObject("bordenes.BackgroundImage"), System.Drawing.Image)
        Me.bordenes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bordenes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bordenes.ImageTransparentColor = System.Drawing.Color.Black
        Me.bordenes.Margin = New System.Windows.Forms.Padding(0, 10, 0, 2)
        Me.bordenes.Name = "bordenes"
        Me.bordenes.Padding = New System.Windows.Forms.Padding(20)
        Me.bordenes.Size = New System.Drawing.Size(44, 44)
        Me.bordenes.Text = "Gestion de Ordenes de Compra"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Margin = New System.Windows.Forms.Padding(10)
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 23)
        '
        'binventariado
        '
        Me.binventariado.BackColor = System.Drawing.Color.Transparent
        Me.binventariado.BackgroundImage = CType(resources.GetObject("binventariado.BackgroundImage"), System.Drawing.Image)
        Me.binventariado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.binventariado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.binventariado.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.binventariado.Margin = New System.Windows.Forms.Padding(0, 10, 0, 2)
        Me.binventariado.Name = "binventariado"
        Me.binventariado.Padding = New System.Windows.Forms.Padding(20)
        Me.binventariado.Size = New System.Drawing.Size(44, 44)
        Me.binventariado.Text = "Gestion de Inventario"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Margin = New System.Windows.Forms.Padding(10)
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 23)
        '
        'bgastosmaq
        '
        Me.bgastosmaq.BackColor = System.Drawing.Color.Transparent
        Me.bgastosmaq.BackgroundImage = CType(resources.GetObject("bgastosmaq.BackgroundImage"), System.Drawing.Image)
        Me.bgastosmaq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bgastosmaq.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bgastosmaq.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bgastosmaq.Margin = New System.Windows.Forms.Padding(0, 10, 0, 2)
        Me.bgastosmaq.Name = "bgastosmaq"
        Me.bgastosmaq.Padding = New System.Windows.Forms.Padding(20)
        Me.bgastosmaq.Size = New System.Drawing.Size(44, 44)
        Me.bgastosmaq.Text = "Gestion de Gastos por Maquinas"
        Me.bgastosmaq.Visible = False
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Margin = New System.Windows.Forms.Padding(10)
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 23)
        Me.ToolStripSeparator6.Visible = False
        '
        'bhojasalida
        '
        Me.bhojasalida.BackgroundImage = CType(resources.GetObject("bhojasalida.BackgroundImage"), System.Drawing.Image)
        Me.bhojasalida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bhojasalida.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bhojasalida.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bhojasalida.Margin = New System.Windows.Forms.Padding(0, 10, 0, 2)
        Me.bhojasalida.Name = "bhojasalida"
        Me.bhojasalida.Padding = New System.Windows.Forms.Padding(20)
        Me.bhojasalida.Size = New System.Drawing.Size(44, 44)
        Me.bhojasalida.Text = "Pases de Salida"
        Me.bhojasalida.ToolTipText = "Hoja de Salida"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Margin = New System.Windows.Forms.Padding(10)
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 23)
        '
        'bpaseentrada
        '
        Me.bpaseentrada.BackgroundImage = CType(resources.GetObject("bpaseentrada.BackgroundImage"), System.Drawing.Image)
        Me.bpaseentrada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bpaseentrada.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bpaseentrada.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bpaseentrada.Margin = New System.Windows.Forms.Padding(0, 10, 0, 2)
        Me.bpaseentrada.Name = "bpaseentrada"
        Me.bpaseentrada.Padding = New System.Windows.Forms.Padding(20)
        Me.bpaseentrada.Size = New System.Drawing.Size(44, 44)
        Me.bpaseentrada.Text = "Gestion de remisiones"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Margin = New System.Windows.Forms.Padding(10)
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 23)
        '
        'bmaquinariareg
        '
        Me.bmaquinariareg.BackgroundImage = CType(resources.GetObject("bmaquinariareg.BackgroundImage"), System.Drawing.Image)
        Me.bmaquinariareg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bmaquinariareg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bmaquinariareg.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bmaquinariareg.Margin = New System.Windows.Forms.Padding(0, 10, 0, 2)
        Me.bmaquinariareg.Name = "bmaquinariareg"
        Me.bmaquinariareg.Padding = New System.Windows.Forms.Padding(20)
        Me.bmaquinariareg.Size = New System.Drawing.Size(44, 44)
        Me.bmaquinariareg.Text = "Registro de Maquinaria"
        '
        'lnombres
        '
        Me.lnombres.AutoSize = True
        Me.lnombres.BackColor = System.Drawing.Color.DarkCyan
        Me.lnombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnombres.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lnombres.Location = New System.Drawing.Point(949, 34)
        Me.lnombres.Name = "lnombres"
        Me.lnombres.Size = New System.Drawing.Size(51, 18)
        Me.lnombres.TabIndex = 9
        Me.lnombres.Text = "Label1"
        '
        'MaterialContextMenuStrip1
        '
        Me.MaterialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialContextMenuStrip1.Depth = 0
        Me.MaterialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialContextMenuStrip1.Name = "MaterialContextMenuStrip1"
        Me.MaterialContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'lrol
        '
        Me.lrol.AutoSize = True
        Me.lrol.BackColor = System.Drawing.Color.DarkCyan
        Me.lrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lrol.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lrol.Location = New System.Drawing.Point(1052, 9)
        Me.lrol.Name = "lrol"
        Me.lrol.Size = New System.Drawing.Size(51, 18)
        Me.lrol.TabIndex = 19
        Me.lrol.Text = "Label1"
        '
        'MzButtonWindows3
        '
        Me.MzButtonWindows3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MzButtonWindows3.BackColor = System.Drawing.Color.DarkCyan
        Me.MzButtonWindows3.BackgroundImage = CType(resources.GetObject("MzButtonWindows3.BackgroundImage"), System.Drawing.Image)
        Me.MzButtonWindows3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MzButtonWindows3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MzButtonWindows3.EstiloButton = BWCMM.MZButtonWindows.EstiloDeButton.Windows
        Me.MzButtonWindows3.Location = New System.Drawing.Point(1285, 0)
        Me.MzButtonWindows3.Name = "MzButtonWindows3"
        Me.MzButtonWindows3.ParentControl = Me
        Me.MzButtonWindows3.Size = New System.Drawing.Size(40, 24)
        Me.MzButtonWindows3.TabIndex = 17
        Me.MzButtonWindows3.TipoButton = BWCMM.MZButtonWindows.ModeButton.Maximize
        '
        'MzButtonWindows2
        '
        Me.MzButtonWindows2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MzButtonWindows2.BackColor = System.Drawing.Color.DarkCyan
        Me.MzButtonWindows2.BackgroundImage = CType(resources.GetObject("MzButtonWindows2.BackgroundImage"), System.Drawing.Image)
        Me.MzButtonWindows2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MzButtonWindows2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MzButtonWindows2.EstiloButton = BWCMM.MZButtonWindows.EstiloDeButton.Windows
        Me.MzButtonWindows2.Location = New System.Drawing.Point(1245, 0)
        Me.MzButtonWindows2.Name = "MzButtonWindows2"
        Me.MzButtonWindows2.ParentControl = Me
        Me.MzButtonWindows2.Size = New System.Drawing.Size(40, 24)
        Me.MzButtonWindows2.TabIndex = 16
        Me.MzButtonWindows2.TipoButton = BWCMM.MZButtonWindows.ModeButton.Minimize
        '
        'MzButtonWindows1
        '
        Me.MzButtonWindows1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MzButtonWindows1.BackColor = System.Drawing.Color.DarkCyan
        Me.MzButtonWindows1.BackgroundImage = CType(resources.GetObject("MzButtonWindows1.BackgroundImage"), System.Drawing.Image)
        Me.MzButtonWindows1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MzButtonWindows1.Cursor = System.Windows.Forms.Cursors.Default
        Me.MzButtonWindows1.EstiloButton = BWCMM.MZButtonWindows.EstiloDeButton.Windows
        Me.MzButtonWindows1.Location = New System.Drawing.Point(1325, 0)
        Me.MzButtonWindows1.Name = "MzButtonWindows1"
        Me.MzButtonWindows1.ParentControl = Me
        Me.MzButtonWindows1.Size = New System.Drawing.Size(40, 24)
        Me.MzButtonWindows1.TabIndex = 15
        Me.MzButtonWindows1.TipoButton = BWCMM.MZButtonWindows.ModeButton.Close
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(1365, 704)
        Me.Controls.Add(Me.lrol)
        Me.Controls.Add(Me.MzButtonWindows3)
        Me.Controls.Add(Me.MzButtonWindows2)
        Me.Controls.Add(Me.MzButtonWindows1)
        Me.Controls.Add(Me.lnombres)
        Me.Controls.Add(Me.ToolStrip)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventana General del Sistema"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents busuario As System.Windows.Forms.ToolStripButton
    Friend WithEvents bordenes As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lnombres As System.Windows.Forms.Label
    Friend WithEvents bproveedor As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bgastosmaq As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MaterialContextMenuStrip1 As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents MzButtonWindows1 As BWCMM.MZButtonWindows
    Friend WithEvents MzButtonWindows2 As BWCMM.MZButtonWindows
    Friend WithEvents MzButtonWindows3 As BWCMM.MZButtonWindows
    Friend WithEvents bsolicitudes As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents binventariado As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bhojasalida As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bpaseentrada As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bmaquinariareg As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bfechasret1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents lrol As System.Windows.Forms.Label
    Friend WithEvents bcotizaciones As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator

End Class
