<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCambioCodigo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCambioCodigo))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tcod1 = New System.Windows.Forms.TextBox()
        Me.tcod2 = New System.Windows.Forms.TextBox()
        Me.beditar = New System.Windows.Forms.Button()
        Me.mensaje = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo a Cambiar:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(63, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nuevo Codigo:"
        '
        'tcod1
        '
        Me.tcod1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tcod1.Location = New System.Drawing.Point(222, 79)
        Me.tcod1.Name = "tcod1"
        Me.tcod1.Size = New System.Drawing.Size(198, 20)
        Me.tcod1.TabIndex = 2
        '
        'tcod2
        '
        Me.tcod2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tcod2.Enabled = False
        Me.tcod2.Location = New System.Drawing.Point(222, 150)
        Me.tcod2.Name = "tcod2"
        Me.tcod2.Size = New System.Drawing.Size(198, 20)
        Me.tcod2.TabIndex = 3
        '
        'beditar
        '
        Me.beditar.BackColor = System.Drawing.Color.White
        Me.beditar.BackgroundImage = CType(resources.GetObject("beditar.BackgroundImage"), System.Drawing.Image)
        Me.beditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.beditar.Enabled = False
        Me.beditar.Location = New System.Drawing.Point(459, 82)
        Me.beditar.Name = "beditar"
        Me.beditar.Size = New System.Drawing.Size(78, 76)
        Me.beditar.TabIndex = 4
        Me.beditar.UseVisualStyleBackColor = False
        '
        'mensaje
        '
        Me.mensaje.AutoSize = True
        Me.mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mensaje.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.mensaje.Location = New System.Drawing.Point(61, 244)
        Me.mensaje.Name = "mensaje"
        Me.mensaje.Size = New System.Drawing.Size(75, 16)
        Me.mensaje.TabIndex = 557
        Me.mensaje.Text = "Mensajes"
        '
        'FrmCambioCodigo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(607, 282)
        Me.Controls.Add(Me.mensaje)
        Me.Controls.Add(Me.beditar)
        Me.Controls.Add(Me.tcod2)
        Me.Controls.Add(Me.tcod1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCambioCodigo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCambioCodigo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tcod1 As System.Windows.Forms.TextBox
    Friend WithEvents tcod2 As System.Windows.Forms.TextBox
    Friend WithEvents beditar As System.Windows.Forms.Button
    Friend WithEvents mensaje As System.Windows.Forms.Label
End Class
