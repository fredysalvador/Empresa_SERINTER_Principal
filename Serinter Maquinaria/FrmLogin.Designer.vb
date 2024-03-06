<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.mensaje = New System.Windows.Forms.Label()
        Me.tclave = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tusuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.breiniciar = New System.Windows.Forms.Button()
        Me.bingresar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'mensaje
        '
        Me.mensaje.AutoSize = True
        Me.mensaje.BackColor = System.Drawing.Color.Transparent
        Me.mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mensaje.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.mensaje.Location = New System.Drawing.Point(12, 306)
        Me.mensaje.Name = "mensaje"
        Me.mensaje.Size = New System.Drawing.Size(75, 16)
        Me.mensaje.TabIndex = 20
        Me.mensaje.Text = "Mensajes"
        '
        'tclave
        '
        Me.tclave.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!)
        Me.tclave.Location = New System.Drawing.Point(52, 228)
        Me.tclave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tclave.Name = "tclave"
        Me.tclave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.tclave.Size = New System.Drawing.Size(288, 24)
        Me.tclave.TabIndex = 19
        Me.tclave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(135, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Clave de Acceso"
        '
        'tusuario
        '
        Me.tusuario.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tusuario.Location = New System.Drawing.Point(52, 146)
        Me.tusuario.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tusuario.Name = "tusuario"
        Me.tusuario.Size = New System.Drawing.Size(288, 24)
        Me.tusuario.TabIndex = 17
        Me.tusuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(123, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 16)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Usuario del Sistema"
        '
        'breiniciar
        '
        Me.breiniciar.BackColor = System.Drawing.Color.White
        Me.breiniciar.BackgroundImage = CType(resources.GetObject("breiniciar.BackgroundImage"), System.Drawing.Image)
        Me.breiniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.breiniciar.Location = New System.Drawing.Point(398, 200)
        Me.breiniciar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.breiniciar.Name = "breiniciar"
        Me.breiniciar.Size = New System.Drawing.Size(80, 81)
        Me.breiniciar.TabIndex = 22
        Me.breiniciar.UseVisualStyleBackColor = False
        '
        'bingresar
        '
        Me.bingresar.BackgroundImage = Global.Serinter_Maquinaria.My.Resources.Resources.Cerrado
        Me.bingresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bingresar.Location = New System.Drawing.Point(398, 102)
        Me.bingresar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bingresar.Name = "bingresar"
        Me.bingresar.Size = New System.Drawing.Size(80, 81)
        Me.bingresar.TabIndex = 21
        Me.bingresar.UseVisualStyleBackColor = True
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(519, 331)
        Me.Controls.Add(Me.breiniciar)
        Me.Controls.Add(Me.bingresar)
        Me.Controls.Add(Me.mensaje)
        Me.Controls.Add(Me.tclave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tusuario)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de Sesion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents breiniciar As System.Windows.Forms.Button
    Friend WithEvents bingresar As System.Windows.Forms.Button
    Friend WithEvents mensaje As System.Windows.Forms.Label
    Friend WithEvents tclave As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tusuario As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
