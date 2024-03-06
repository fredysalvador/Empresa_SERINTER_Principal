<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DGVORDENESCOMPRAS
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DGVORDENESCOMPRAS))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_atras = New System.Windows.Forms.Button()
        Me.btn_siguiente = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 17)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(698, 339)
        Me.DataGridView1.TabIndex = 0
        '
        'btn_atras
        '
        Me.btn_atras.BackgroundImage = CType(resources.GetObject("btn_atras.BackgroundImage"), System.Drawing.Image)
        Me.btn_atras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_atras.Location = New System.Drawing.Point(34, 362)
        Me.btn_atras.Name = "btn_atras"
        Me.btn_atras.Size = New System.Drawing.Size(63, 57)
        Me.btn_atras.TabIndex = 1
        Me.btn_atras.UseVisualStyleBackColor = True
        '
        'btn_siguiente
        '
        Me.btn_siguiente.BackgroundImage = CType(resources.GetObject("btn_siguiente.BackgroundImage"), System.Drawing.Image)
        Me.btn_siguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_siguiente.Location = New System.Drawing.Point(624, 362)
        Me.btn_siguiente.Name = "btn_siguiente"
        Me.btn_siguiente.Size = New System.Drawing.Size(63, 57)
        Me.btn_siguiente.TabIndex = 2
        Me.btn_siguiente.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(328, 385)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(368, 385)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "/"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(402, 385)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "0"
        '
        'DGVORDENESCOMPRAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_siguiente)
        Me.Controls.Add(Me.btn_atras)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "DGVORDENESCOMPRAS"
        Me.Size = New System.Drawing.Size(728, 426)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btn_atras As System.Windows.Forms.Button
    Friend WithEvents btn_siguiente As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
