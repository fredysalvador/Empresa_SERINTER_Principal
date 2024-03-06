<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientosMaqImprUsura2
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMantenimientosMaqImprUsura2))
        Me.Generar_usuraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SERINTERDataSet17 = New Serinter_Maquinaria.SERINTERDataSet17()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Generar_usuraTableAdapter = New Serinter_Maquinaria.SERINTERDataSet17TableAdapters.Generar_usuraTableAdapter()
        Me.tcodv = New System.Windows.Forms.TextBox()
        CType(Me.Generar_usuraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SERINTERDataSet17, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Generar_usuraBindingSource
        '
        Me.Generar_usuraBindingSource.DataMember = "Generar_usura"
        Me.Generar_usuraBindingSource.DataSource = Me.SERINTERDataSet17
        '
        'SERINTERDataSet17
        '
        Me.SERINTERDataSet17.DataSetName = "SERINTERDataSet17"
        Me.SERINTERDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Generar_usuraBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Serinter_Maquinaria.FrmMantenimientosMaqUsura2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1076, 607)
        Me.ReportViewer1.TabIndex = 1
        '
        'Generar_usuraTableAdapter
        '
        Me.Generar_usuraTableAdapter.ClearBeforeFill = True
        '
        'tcodv
        '
        Me.tcodv.Location = New System.Drawing.Point(23, 43)
        Me.tcodv.Name = "tcodv"
        Me.tcodv.Size = New System.Drawing.Size(100, 20)
        Me.tcodv.TabIndex = 2
        Me.tcodv.Visible = False
        '
        'FrmMantenimientosMaqImprUsura2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1076, 607)
        Me.Controls.Add(Me.tcodv)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMantenimientosMaqImprUsura2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMantenimientosMaqImprUsura2"
        CType(Me.Generar_usuraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SERINTERDataSet17, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Generar_usuraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SERINTERDataSet17 As Serinter_Maquinaria.SERINTERDataSet17
    Friend WithEvents Generar_usuraTableAdapter As Serinter_Maquinaria.SERINTERDataSet17TableAdapters.Generar_usuraTableAdapter
    Friend WithEvents tcodv As System.Windows.Forms.TextBox
End Class
