<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCotizacionesImprHNL1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCotizacionesImprHNL1))
        Me.Generar_CotizacionCMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SERINTERDataSet19 = New Serinter_Maquinaria.SERINTERDataSet19()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Generar_CotizacionCMTableAdapter = New Serinter_Maquinaria.SERINTERDataSet19TableAdapters.Generar_CotizacionCMTableAdapter()
        Me.tcotno = New System.Windows.Forms.TextBox()
        CType(Me.Generar_CotizacionCMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SERINTERDataSet19, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Generar_CotizacionCMBindingSource
        '
        Me.Generar_CotizacionCMBindingSource.DataMember = "Generar_CotizacionCM"
        Me.Generar_CotizacionCMBindingSource.DataSource = Me.SERINTERDataSet19
        '
        'SERINTERDataSet19
        '
        Me.SERINTERDataSet19.DataSetName = "SERINTERDataSet19"
        Me.SERINTERDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Generar_CotizacionCMBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Serinter_Maquinaria.CotizacionesSVLempiras.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1268, 622)
        Me.ReportViewer1.TabIndex = 0
        '
        'Generar_CotizacionCMTableAdapter
        '
        Me.Generar_CotizacionCMTableAdapter.ClearBeforeFill = True
        '
        'tcotno
        '
        Me.tcotno.Location = New System.Drawing.Point(27, 77)
        Me.tcotno.Name = "tcotno"
        Me.tcotno.Size = New System.Drawing.Size(100, 20)
        Me.tcotno.TabIndex = 1
        '
        'FrmCotizacionesImprHNL1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1268, 622)
        Me.Controls.Add(Me.tcotno)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCotizacionesImprHNL1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCotizacionesImprHNL1"
        CType(Me.Generar_CotizacionCMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SERINTERDataSet19, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Generar_CotizacionCMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SERINTERDataSet19 As Serinter_Maquinaria.SERINTERDataSet19
    Friend WithEvents Generar_CotizacionCMTableAdapter As Serinter_Maquinaria.SERINTERDataSet19TableAdapters.Generar_CotizacionCMTableAdapter
    Friend WithEvents tcotno As System.Windows.Forms.TextBox
End Class
