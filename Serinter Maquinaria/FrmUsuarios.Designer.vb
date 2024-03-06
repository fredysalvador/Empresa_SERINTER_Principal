<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUsuarios))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tusuario = New System.Windows.Forms.TextBox()
        Me.tnombre = New System.Windows.Forms.TextBox()
        Me.tclave = New System.Windows.Forms.TextBox()
        Me.tconfirmar = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.crol = New System.Windows.Forms.ComboBox()
        Me.dgvusuarios = New System.Windows.Forms.DataGridView()
        Me.mensaje = New System.Windows.Forms.Label()
        Me.bdatagrid = New System.Windows.Forms.Button()
        Me.bregresar = New System.Windows.Forms.Button()
        Me.breiniciar = New System.Windows.Forms.Button()
        Me.beliminar = New System.Windows.Forms.Button()
        Me.bingresar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvusuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(26, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 20)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Nombre de Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(35, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Nombre Completo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(58, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 20)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Clave Personal:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(51, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 20)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Confirmar Clave:"
        '
        'tusuario
        '
        Me.tusuario.Location = New System.Drawing.Point(183, 87)
        Me.tusuario.Name = "tusuario"
        Me.tusuario.Size = New System.Drawing.Size(260, 20)
        Me.tusuario.TabIndex = 1
        '
        'tnombre
        '
        Me.tnombre.Location = New System.Drawing.Point(183, 125)
        Me.tnombre.Name = "tnombre"
        Me.tnombre.Size = New System.Drawing.Size(260, 20)
        Me.tnombre.TabIndex = 20
        '
        'tclave
        '
        Me.tclave.Location = New System.Drawing.Point(183, 165)
        Me.tclave.Name = "tclave"
        Me.tclave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tclave.Size = New System.Drawing.Size(260, 20)
        Me.tclave.TabIndex = 21
        '
        'tconfirmar
        '
        Me.tconfirmar.Location = New System.Drawing.Point(183, 205)
        Me.tconfirmar.Name = "tconfirmar"
        Me.tconfirmar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tconfirmar.Size = New System.Drawing.Size(260, 20)
        Me.tconfirmar.TabIndex = 22
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.crol)
        Me.GroupBox1.Controls.Add(Me.tconfirmar)
        Me.GroupBox1.Controls.Add(Me.tclave)
        Me.GroupBox1.Controls.Add(Me.tnombre)
        Me.GroupBox1.Controls.Add(Me.tusuario)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(494, 340)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Generales Usuarios"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(80, 243)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 20)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Rol Usuario:"
        '
        'crol
        '
        Me.crol.FormattingEnabled = True
        Me.crol.Items.AddRange(New Object() {"Administracion", "Asistente SR", "Gestor de Proyectos", "Bodeguero SR", "Taller Mecanico", "Contabilidad", "Compras"})
        Me.crol.Location = New System.Drawing.Point(183, 245)
        Me.crol.Name = "crol"
        Me.crol.Size = New System.Drawing.Size(260, 21)
        Me.crol.TabIndex = 25
        '
        'dgvusuarios
        '
        Me.dgvusuarios.AllowUserToAddRows = False
        Me.dgvusuarios.AllowUserToDeleteRows = False
        Me.dgvusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvusuarios.Location = New System.Drawing.Point(536, 38)
        Me.dgvusuarios.MultiSelect = False
        Me.dgvusuarios.Name = "dgvusuarios"
        Me.dgvusuarios.ReadOnly = True
        Me.dgvusuarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvusuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvusuarios.Size = New System.Drawing.Size(703, 489)
        Me.dgvusuarios.TabIndex = 0
        '
        'mensaje
        '
        Me.mensaje.AutoSize = True
        Me.mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mensaje.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.mensaje.Location = New System.Drawing.Point(9, 524)
        Me.mensaje.Name = "mensaje"
        Me.mensaje.Size = New System.Drawing.Size(75, 16)
        Me.mensaje.TabIndex = 556
        Me.mensaje.Text = "Mensajes"
        '
        'bdatagrid
        '
        Me.bdatagrid.BackgroundImage = CType(resources.GetObject("bdatagrid.BackgroundImage"), System.Drawing.Image)
        Me.bdatagrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bdatagrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bdatagrid.Location = New System.Drawing.Point(223, 406)
        Me.bdatagrid.Name = "bdatagrid"
        Me.bdatagrid.Size = New System.Drawing.Size(64, 68)
        Me.bdatagrid.TabIndex = 364
        Me.bdatagrid.UseVisualStyleBackColor = True
        '
        'bregresar
        '
        Me.bregresar.BackgroundImage = CType(resources.GetObject("bregresar.BackgroundImage"), System.Drawing.Image)
        Me.bregresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bregresar.Location = New System.Drawing.Point(410, 406)
        Me.bregresar.Name = "bregresar"
        Me.bregresar.Size = New System.Drawing.Size(96, 68)
        Me.bregresar.TabIndex = 29
        Me.bregresar.UseVisualStyleBackColor = True
        '
        'breiniciar
        '
        Me.breiniciar.BackColor = System.Drawing.Color.White
        Me.breiniciar.BackgroundImage = CType(resources.GetObject("breiniciar.BackgroundImage"), System.Drawing.Image)
        Me.breiniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.breiniciar.Location = New System.Drawing.Point(154, 406)
        Me.breiniciar.Name = "breiniciar"
        Me.breiniciar.Size = New System.Drawing.Size(64, 68)
        Me.breiniciar.TabIndex = 28
        Me.breiniciar.UseVisualStyleBackColor = False
        '
        'beliminar
        '
        Me.beliminar.BackgroundImage = CType(resources.GetObject("beliminar.BackgroundImage"), System.Drawing.Image)
        Me.beliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.beliminar.Location = New System.Drawing.Point(84, 406)
        Me.beliminar.Name = "beliminar"
        Me.beliminar.Size = New System.Drawing.Size(64, 68)
        Me.beliminar.TabIndex = 27
        Me.beliminar.UseVisualStyleBackColor = True
        '
        'bingresar
        '
        Me.bingresar.BackColor = System.Drawing.Color.White
        Me.bingresar.BackgroundImage = CType(resources.GetObject("bingresar.BackgroundImage"), System.Drawing.Image)
        Me.bingresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bingresar.Location = New System.Drawing.Point(10, 406)
        Me.bingresar.Name = "bingresar"
        Me.bingresar.Size = New System.Drawing.Size(64, 68)
        Me.bingresar.TabIndex = 26
        Me.bingresar.UseVisualStyleBackColor = False
        '
        'FrmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1251, 549)
        Me.ControlBox = False
        Me.Controls.Add(Me.mensaje)
        Me.Controls.Add(Me.bdatagrid)
        Me.Controls.Add(Me.dgvusuarios)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.bregresar)
        Me.Controls.Add(Me.breiniciar)
        Me.Controls.Add(Me.beliminar)
        Me.Controls.Add(Me.bingresar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmUsuarios"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario Para Agregar Usuarios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvusuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bingresar As System.Windows.Forms.Button
    Friend WithEvents beliminar As System.Windows.Forms.Button
    Friend WithEvents breiniciar As System.Windows.Forms.Button
    Friend WithEvents bregresar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tusuario As System.Windows.Forms.TextBox
    Friend WithEvents tnombre As System.Windows.Forms.TextBox
    Friend WithEvents tclave As System.Windows.Forms.TextBox
    Friend WithEvents tconfirmar As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvusuarios As System.Windows.Forms.DataGridView
    Friend WithEvents bdatagrid As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents crol As System.Windows.Forms.ComboBox
    Friend WithEvents mensaje As System.Windows.Forms.Label
End Class
