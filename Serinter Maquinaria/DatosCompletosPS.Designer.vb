<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatosCompletosPS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DatosCompletosPS))
        Me.Label32 = New System.Windows.Forms.Label()
        Me.fechahora = New System.Windows.Forms.Label()
        Me.dgvretorno1 = New System.Windows.Forms.DataGridView()
        Me.bexportar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.dtpinicial = New System.Windows.Forms.DateTimePicker()
        Me.dtpfinal = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkexportacion = New System.Windows.Forms.CheckBox()
        CType(Me.dgvretorno1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(171, 33)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(271, 24)
        Me.Label32.TabIndex = 504
        Me.Label32.Text = "Pases de Salidas Generales"
        '
        'fechahora
        '
        Me.fechahora.AutoSize = True
        Me.fechahora.Location = New System.Drawing.Point(1138, -18)
        Me.fechahora.Name = "fechahora"
        Me.fechahora.Size = New System.Drawing.Size(39, 13)
        Me.fechahora.TabIndex = 495
        Me.fechahora.Text = "Label1"
        '
        'dgvretorno1
        '
        Me.dgvretorno1.AllowUserToAddRows = False
        Me.dgvretorno1.AllowUserToDeleteRows = False
        Me.dgvretorno1.AllowUserToOrderColumns = True
        Me.dgvretorno1.AllowUserToResizeColumns = False
        Me.dgvretorno1.AllowUserToResizeRows = False
        Me.dgvretorno1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvretorno1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvretorno1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvretorno1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvretorno1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvretorno1.Location = New System.Drawing.Point(4, 73)
        Me.dgvretorno1.MultiSelect = False
        Me.dgvretorno1.Name = "dgvretorno1"
        Me.dgvretorno1.ReadOnly = True
        Me.dgvretorno1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgvretorno1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvretorno1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvretorno1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvretorno1.Size = New System.Drawing.Size(1267, 515)
        Me.dgvretorno1.TabIndex = 492
        '
        'bexportar
        '
        Me.bexportar.BackColor = System.Drawing.Color.White
        Me.bexportar.BackgroundImage = CType(resources.GetObject("bexportar.BackgroundImage"), System.Drawing.Image)
        Me.bexportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bexportar.Location = New System.Drawing.Point(12, 606)
        Me.bexportar.Name = "bexportar"
        Me.bexportar.Size = New System.Drawing.Size(75, 63)
        Me.bexportar.TabIndex = 506
        Me.bexportar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(141, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 503
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'dtpinicial
        '
        Me.dtpinicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpinicial.Location = New System.Drawing.Point(103, 647)
        Me.dtpinicial.Name = "dtpinicial"
        Me.dtpinicial.Size = New System.Drawing.Size(98, 20)
        Me.dtpinicial.TabIndex = 507
        Me.dtpinicial.Visible = False
        '
        'dtpfinal
        '
        Me.dtpfinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfinal.Location = New System.Drawing.Point(216, 647)
        Me.dtpfinal.Name = "dtpfinal"
        Me.dtpfinal.Size = New System.Drawing.Size(105, 20)
        Me.dtpfinal.TabIndex = 508
        Me.dtpfinal.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(117, 631)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 509
        Me.Label1.Text = "Fecha Inicial:"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(236, 631)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 510
        Me.Label2.Text = "Fecha Final:"
        Me.Label2.Visible = False
        '
        'chkexportacion
        '
        Me.chkexportacion.AutoSize = True
        Me.chkexportacion.Location = New System.Drawing.Point(103, 606)
        Me.chkexportacion.Name = "chkexportacion"
        Me.chkexportacion.Size = New System.Drawing.Size(134, 17)
        Me.chkexportacion.TabIndex = 511
        Me.chkexportacion.Text = "Filtrado de Exportación"
        Me.chkexportacion.UseVisualStyleBackColor = True
        '
        'DatosCompletosPS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1275, 679)
        Me.Controls.Add(Me.chkexportacion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpfinal)
        Me.Controls.Add(Me.dtpinicial)
        Me.Controls.Add(Me.bexportar)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.fechahora)
        Me.Controls.Add(Me.dgvretorno1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DatosCompletosPS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "DatosCompletosPS"
        CType(Me.dgvretorno1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bexportar As System.Windows.Forms.Button
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents fechahora As System.Windows.Forms.Label
    Friend WithEvents dgvretorno1 As System.Windows.Forms.DataGridView
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents dtpinicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkexportacion As System.Windows.Forms.CheckBox
End Class
