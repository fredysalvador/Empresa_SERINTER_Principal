<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EstatusOrdenesCompras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EstatusOrdenesCompras))
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fechahora = New System.Windows.Forms.Label()
        Me.dgvretorno1 = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.bexportar = New System.Windows.Forms.Button()
        Me.bcambio = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bhistorial = New System.Windows.Forms.Button()
        Me.bregresar = New System.Windows.Forms.Button()
        Me.bdatagridret = New System.Windows.Forms.Button()
        CType(Me.dgvretorno1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(168, 31)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(303, 24)
        Me.Label32.TabIndex = 504
        Me.Label32.Text = "Estatus de Ordenes de Compra"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(143, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 497
        Me.Label2.Text = "Fecha_Solicitada"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(32, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 496
        Me.Label1.Text = "No_Solicitud"
        '
        'fechahora
        '
        Me.fechahora.AutoSize = True
        Me.fechahora.Location = New System.Drawing.Point(1135, 11)
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
        Me.dgvretorno1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvretorno1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvretorno1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvretorno1.ColumnHeadersVisible = False
        Me.dgvretorno1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvretorno1.Location = New System.Drawing.Point(2, 113)
        Me.dgvretorno1.MultiSelect = False
        Me.dgvretorno1.Name = "dgvretorno1"
        Me.dgvretorno1.ReadOnly = True
        Me.dgvretorno1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgvretorno1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvretorno1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvretorno1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvretorno1.Size = New System.Drawing.Size(1255, 431)
        Me.dgvretorno1.TabIndex = 492
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.LightGray
        Me.Label9.Location = New System.Drawing.Point(615, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 488
        Me.Label9.Text = "Solicitador:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.LightGray
        Me.Label8.Location = New System.Drawing.Point(1096, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 487
        Me.Label8.Text = "Estado_Orden"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.LightGray
        Me.Label7.Location = New System.Drawing.Point(306, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 487
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(2, 72)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1255, 43)
        Me.Panel1.TabIndex = 501
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(443, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 501
        Me.Label5.Text = "Proveedor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(271, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 500
        Me.Label3.Text = "Fecha_Requerida"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(831, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 499
        Me.Label4.Text = "Tipo de Prioridad:"
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'bexportar
        '
        Me.bexportar.BackColor = System.Drawing.Color.White
        Me.bexportar.BackgroundImage = CType(resources.GetObject("bexportar.BackgroundImage"), System.Drawing.Image)
        Me.bexportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bexportar.Location = New System.Drawing.Point(165, 557)
        Me.bexportar.Name = "bexportar"
        Me.bexportar.Size = New System.Drawing.Size(75, 63)
        Me.bexportar.TabIndex = 506
        Me.bexportar.UseVisualStyleBackColor = False
        '
        'bcambio
        '
        Me.bcambio.BackColor = System.Drawing.Color.White
        Me.bcambio.BackgroundImage = CType(resources.GetObject("bcambio.BackgroundImage"), System.Drawing.Image)
        Me.bcambio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bcambio.Location = New System.Drawing.Point(84, 556)
        Me.bcambio.Name = "bcambio"
        Me.bcambio.Size = New System.Drawing.Size(75, 63)
        Me.bcambio.TabIndex = 505
        Me.bcambio.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(10, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(141, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 503
        Me.PictureBox1.TabStop = False
        '
        'bhistorial
        '
        Me.bhistorial.BackColor = System.Drawing.Color.White
        Me.bhistorial.BackgroundImage = CType(resources.GetObject("bhistorial.BackgroundImage"), System.Drawing.Image)
        Me.bhistorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bhistorial.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bhistorial.Location = New System.Drawing.Point(1192, 556)
        Me.bhistorial.Name = "bhistorial"
        Me.bhistorial.Size = New System.Drawing.Size(64, 63)
        Me.bhistorial.TabIndex = 502
        Me.bhistorial.UseVisualStyleBackColor = False
        '
        'bregresar
        '
        Me.bregresar.BackgroundImage = CType(resources.GetObject("bregresar.BackgroundImage"), System.Drawing.Image)
        Me.bregresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bregresar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bregresar.Location = New System.Drawing.Point(2, 556)
        Me.bregresar.Name = "bregresar"
        Me.bregresar.Size = New System.Drawing.Size(76, 63)
        Me.bregresar.TabIndex = 494
        Me.bregresar.UseVisualStyleBackColor = True
        '
        'bdatagridret
        '
        Me.bdatagridret.BackgroundImage = CType(resources.GetObject("bdatagridret.BackgroundImage"), System.Drawing.Image)
        Me.bdatagridret.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bdatagridret.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bdatagridret.Location = New System.Drawing.Point(1122, 556)
        Me.bdatagridret.Name = "bdatagridret"
        Me.bdatagridret.Size = New System.Drawing.Size(64, 63)
        Me.bdatagridret.TabIndex = 493
        Me.bdatagridret.UseVisualStyleBackColor = True
        '
        'EstatusOrdenesCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1259, 640)
        Me.Controls.Add(Me.bexportar)
        Me.Controls.Add(Me.bcambio)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.bhistorial)
        Me.Controls.Add(Me.fechahora)
        Me.Controls.Add(Me.bregresar)
        Me.Controls.Add(Me.bdatagridret)
        Me.Controls.Add(Me.dgvretorno1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EstatusOrdenesCompras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EstatusOrdenesCompras"
        CType(Me.dgvretorno1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bexportar As System.Windows.Forms.Button
    Friend WithEvents bcambio As System.Windows.Forms.Button
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents bhistorial As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents fechahora As System.Windows.Forms.Label
    Friend WithEvents bregresar As System.Windows.Forms.Button
    Friend WithEvents bdatagridret As System.Windows.Forms.Button
    Friend WithEvents dgvretorno1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
