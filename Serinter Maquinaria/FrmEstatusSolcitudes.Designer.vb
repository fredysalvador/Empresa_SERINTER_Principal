<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEstatusSolcitudes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEstatusSolcitudes))
        Me.Label32 = New System.Windows.Forms.Label()
        Me.fechahora = New System.Windows.Forms.Label()
        Me.dgvretorno1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bexportar = New System.Windows.Forms.Button()
        Me.bcambio = New System.Windows.Forms.Button()
        Me.bhistorial = New System.Windows.Forms.Button()
        Me.bregresar = New System.Windows.Forms.Button()
        Me.bdatagridret = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.btsoliccompr = New System.Windows.Forms.Button()
        Me.bcompra = New System.Windows.Forms.Button()
        CType(Me.dgvretorno1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(161, 46)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(227, 24)
        Me.Label32.TabIndex = 509
        Me.Label32.Text = "Solicitudes de Compra:"
        '
        'fechahora
        '
        Me.fechahora.AutoSize = True
        Me.fechahora.Location = New System.Drawing.Point(1128, 26)
        Me.fechahora.Name = "fechahora"
        Me.fechahora.Size = New System.Drawing.Size(39, 13)
        Me.fechahora.TabIndex = 506
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
        Me.dgvretorno1.Location = New System.Drawing.Point(2, 128)
        Me.dgvretorno1.MultiSelect = False
        Me.dgvretorno1.Name = "dgvretorno1"
        Me.dgvretorno1.ReadOnly = True
        Me.dgvretorno1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgvretorno1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvretorno1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvretorno1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvretorno1.Size = New System.Drawing.Size(1255, 431)
        Me.dgvretorno1.TabIndex = 505
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(2, 87)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1255, 43)
        Me.Panel1.TabIndex = 507
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.LightGray
        Me.Label10.Location = New System.Drawing.Point(1058, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 13)
        Me.Label10.TabIndex = 502
        Me.Label10.Text = "Fecha_Requerida"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.LightGray
        Me.Label6.Location = New System.Drawing.Point(356, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 501
        Me.Label6.Text = "Maquinaria"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(785, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 500
        Me.Label5.Text = "Estatus"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(670, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 499
        Me.Label4.Text = "Prioridad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(546, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 498
        Me.Label3.Text = "Proyectos"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.LightGray
        Me.Label9.Location = New System.Drawing.Point(118, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 488
        Me.Label9.Text = "Solicitante"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.LightGray
        Me.Label8.Location = New System.Drawing.Point(889, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 13)
        Me.Label8.TabIndex = 487
        Me.Label8.Text = "Fecha_Creacion"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(222, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 497
        Me.Label2.Text = "Area"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(19, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 496
        Me.Label1.Text = "Num_Solicitud"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(3, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(141, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 508
        Me.PictureBox1.TabStop = False
        '
        'bexportar
        '
        Me.bexportar.BackColor = System.Drawing.Color.White
        Me.bexportar.BackgroundImage = CType(resources.GetObject("bexportar.BackgroundImage"), System.Drawing.Image)
        Me.bexportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bexportar.Location = New System.Drawing.Point(175, 566)
        Me.bexportar.Name = "bexportar"
        Me.bexportar.Size = New System.Drawing.Size(75, 63)
        Me.bexportar.TabIndex = 514
        Me.bexportar.UseVisualStyleBackColor = False
        '
        'bcambio
        '
        Me.bcambio.BackColor = System.Drawing.Color.White
        Me.bcambio.BackgroundImage = CType(resources.GetObject("bcambio.BackgroundImage"), System.Drawing.Image)
        Me.bcambio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bcambio.Location = New System.Drawing.Point(94, 565)
        Me.bcambio.Name = "bcambio"
        Me.bcambio.Size = New System.Drawing.Size(75, 63)
        Me.bcambio.TabIndex = 513
        Me.bcambio.UseVisualStyleBackColor = False
        '
        'bhistorial
        '
        Me.bhistorial.BackColor = System.Drawing.Color.White
        Me.bhistorial.BackgroundImage = CType(resources.GetObject("bhistorial.BackgroundImage"), System.Drawing.Image)
        Me.bhistorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bhistorial.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bhistorial.Location = New System.Drawing.Point(1175, 565)
        Me.bhistorial.Name = "bhistorial"
        Me.bhistorial.Size = New System.Drawing.Size(64, 63)
        Me.bhistorial.TabIndex = 512
        Me.bhistorial.UseVisualStyleBackColor = False
        '
        'bregresar
        '
        Me.bregresar.BackgroundImage = CType(resources.GetObject("bregresar.BackgroundImage"), System.Drawing.Image)
        Me.bregresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bregresar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bregresar.Location = New System.Drawing.Point(12, 565)
        Me.bregresar.Name = "bregresar"
        Me.bregresar.Size = New System.Drawing.Size(76, 63)
        Me.bregresar.TabIndex = 511
        Me.bregresar.UseVisualStyleBackColor = True
        '
        'bdatagridret
        '
        Me.bdatagridret.BackgroundImage = CType(resources.GetObject("bdatagridret.BackgroundImage"), System.Drawing.Image)
        Me.bdatagridret.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bdatagridret.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bdatagridret.Location = New System.Drawing.Point(1105, 565)
        Me.bdatagridret.Name = "bdatagridret"
        Me.bdatagridret.Size = New System.Drawing.Size(64, 63)
        Me.bdatagridret.TabIndex = 510
        Me.bdatagridret.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Timer3
        '
        '
        'btsoliccompr
        '
        Me.btsoliccompr.BackColor = System.Drawing.Color.White
        Me.btsoliccompr.BackgroundImage = CType(resources.GetObject("btsoliccompr.BackgroundImage"), System.Drawing.Image)
        Me.btsoliccompr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btsoliccompr.Location = New System.Drawing.Point(1035, 566)
        Me.btsoliccompr.Name = "btsoliccompr"
        Me.btsoliccompr.Size = New System.Drawing.Size(64, 63)
        Me.btsoliccompr.TabIndex = 515
        Me.btsoliccompr.UseVisualStyleBackColor = False
        '
        'bcompra
        '
        Me.bcompra.BackColor = System.Drawing.Color.White
        Me.bcompra.BackgroundImage = CType(resources.GetObject("bcompra.BackgroundImage"), System.Drawing.Image)
        Me.bcompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bcompra.Location = New System.Drawing.Point(965, 566)
        Me.bcompra.Name = "bcompra"
        Me.bcompra.Size = New System.Drawing.Size(64, 63)
        Me.bcompra.TabIndex = 516
        Me.bcompra.UseVisualStyleBackColor = False
        '
        'FrmEstatusSolcitudes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1259, 640)
        Me.Controls.Add(Me.bcompra)
        Me.Controls.Add(Me.btsoliccompr)
        Me.Controls.Add(Me.bexportar)
        Me.Controls.Add(Me.bcambio)
        Me.Controls.Add(Me.bhistorial)
        Me.Controls.Add(Me.bregresar)
        Me.Controls.Add(Me.bdatagridret)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.fechahora)
        Me.Controls.Add(Me.dgvretorno1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmEstatusSolcitudes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmEstatusSolcitudes"
        CType(Me.dgvretorno1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents fechahora As System.Windows.Forms.Label
    Friend WithEvents dgvretorno1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bexportar As System.Windows.Forms.Button
    Friend WithEvents bcambio As System.Windows.Forms.Button
    Friend WithEvents bhistorial As System.Windows.Forms.Button
    Friend WithEvents bregresar As System.Windows.Forms.Button
    Friend WithEvents bdatagridret As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents btsoliccompr As System.Windows.Forms.Button
    Friend WithEvents bcompra As System.Windows.Forms.Button
End Class
