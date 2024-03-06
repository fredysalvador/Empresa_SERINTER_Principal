<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSeleccionVhMan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSeleccionVhMan))
        Me.bmanteobj = New System.Windows.Forms.Button()
        Me.bmanobr = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.busura = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bmanteobj
        '
        Me.bmanteobj.BackColor = System.Drawing.Color.White
        Me.bmanteobj.BackgroundImage = CType(resources.GetObject("bmanteobj.BackgroundImage"), System.Drawing.Image)
        Me.bmanteobj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bmanteobj.Location = New System.Drawing.Point(50, 70)
        Me.bmanteobj.Name = "bmanteobj"
        Me.bmanteobj.Size = New System.Drawing.Size(153, 123)
        Me.bmanteobj.TabIndex = 3
        Me.bmanteobj.TabStop = False
        Me.bmanteobj.UseVisualStyleBackColor = False
        '
        'bmanobr
        '
        Me.bmanobr.BackColor = System.Drawing.Color.White
        Me.bmanobr.BackgroundImage = CType(resources.GetObject("bmanobr.BackgroundImage"), System.Drawing.Image)
        Me.bmanobr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bmanobr.Location = New System.Drawing.Point(295, 69)
        Me.bmanobr.Name = "bmanobr"
        Me.bmanobr.Size = New System.Drawing.Size(153, 124)
        Me.bmanobr.TabIndex = 4
        Me.bmanobr.TabStop = False
        Me.bmanobr.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Elephant", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Costos en Repuestos y Piezas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Elephant", 11.25!)
        Me.Label2.Location = New System.Drawing.Point(273, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(194, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Costos en Mano de Obra"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Elephant", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(494, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(261, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Piezas de Desgaste de la Maquina"
        '
        'busura
        '
        Me.busura.BackColor = System.Drawing.Color.White
        Me.busura.BackgroundImage = CType(resources.GetObject("busura.BackgroundImage"), System.Drawing.Image)
        Me.busura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.busura.Location = New System.Drawing.Point(548, 67)
        Me.busura.Name = "busura"
        Me.busura.Size = New System.Drawing.Size(153, 123)
        Me.busura.TabIndex = 7
        Me.busura.TabStop = False
        Me.busura.UseVisualStyleBackColor = False
        '
        'FrmSeleccionVhMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(776, 264)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.busura)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bmanobr)
        Me.Controls.Add(Me.bmanteobj)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSeleccionVhMan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmSeleccionVhMan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bmanteobj As System.Windows.Forms.Button
    Friend WithEvents bmanobr As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents busura As System.Windows.Forms.Button
End Class
