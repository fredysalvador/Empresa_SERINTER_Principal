<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientosMaqImpr4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMantenimientosMaqImpr4))
        Me.Generar_DatosMaquinariaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SERINTERDataSet14 = New Serinter_Maquinaria.SERINTERDataSet14()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tcodv = New System.Windows.Forms.TextBox()
        Me.Generar_DatosMaquinariaTableAdapter = New Serinter_Maquinaria.SERINTERDataSet14TableAdapters.Generar_DatosMaquinariaTableAdapter()
        CType(Me.Generar_DatosMaquinariaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SERINTERDataSet14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Generar_DatosMaquinariaBindingSource
        '
        Me.Generar_DatosMaquinariaBindingSource.DataMember = "Generar_DatosMaquinaria"
        Me.Generar_DatosMaquinariaBindingSource.DataSource = Me.SERINTERDataSet14
        '
        'SERINTERDataSet14
        '
        Me.SERINTERDataSet14.DataSetName = "SERINTERDataSet14"
        Me.SERINTERDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Generar_DatosMaquinariaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Serinter_Maquinaria.FrmMantenimientosMaqV10.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1076, 607)
        Me.ReportViewer1.TabIndex = 0
        '
        'tcodv
        '
        Me.tcodv.Location = New System.Drawing.Point(47, 52)
        Me.tcodv.Name = "tcodv"
        Me.tcodv.Size = New System.Drawing.Size(100, 20)
        Me.tcodv.TabIndex = 2
        Me.tcodv.Visible = False
        '
        'Generar_DatosMaquinariaTableAdapter
        '
        Me.Generar_DatosMaquinariaTableAdapter.ClearBeforeFill = True
        '
        'FrmMantenimientosMaqImpr4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1076, 607)
        Me.Controls.Add(Me.tcodv)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMantenimientosMaqImpr4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMantenimientosMaqImpr4"
        CType(Me.Generar_DatosMaquinariaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SERINTERDataSet14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tcodv As System.Windows.Forms.TextBox
    Friend WithEvents Generar_DatosMaquinariaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SERINTERDataSet14 As Serinter_Maquinaria.SERINTERDataSet14
    Friend WithEvents Generar_DatosMaquinariaTableAdapter As Serinter_Maquinaria.SERINTERDataSet14TableAdapters.Generar_DatosMaquinariaTableAdapter
End Class
