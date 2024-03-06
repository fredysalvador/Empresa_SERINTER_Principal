<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCotizacionesImpr3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCotizacionesImpr3))
        Me.Generar_CotizacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SERINTERDataSet18 = New Serinter_Maquinaria.SERINTERDataSet18()
        Me.tcotno = New System.Windows.Forms.TextBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Generar_CotizacionTableAdapter = New Serinter_Maquinaria.SERINTERDataSet18TableAdapters.Generar_CotizacionTableAdapter()
        CType(Me.Generar_CotizacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SERINTERDataSet18, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Generar_CotizacionBindingSource
        '
        Me.Generar_CotizacionBindingSource.DataMember = "Generar_Cotizacion"
        Me.Generar_CotizacionBindingSource.DataSource = Me.SERINTERDataSet18
        '
        'SERINTERDataSet18
        '
        Me.SERINTERDataSet18.DataSetName = "SERINTERDataSet18"
        Me.SERINTERDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tcotno
        '
        Me.tcotno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tcotno.Location = New System.Drawing.Point(47, 74)
        Me.tcotno.Name = "tcotno"
        Me.tcotno.Size = New System.Drawing.Size(132, 20)
        Me.tcotno.TabIndex = 481
        Me.tcotno.Visible = False
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Generar_CotizacionBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Serinter_Maquinaria.CotizacionSv2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1284, 661)
        Me.ReportViewer1.TabIndex = 480
        '
        'Generar_CotizacionTableAdapter
        '
        Me.Generar_CotizacionTableAdapter.ClearBeforeFill = True
        '
        'FrmCotizacionesImpr3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 661)
        Me.Controls.Add(Me.tcotno)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCotizacionesImpr3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCotizacionesImpr3"
        CType(Me.Generar_CotizacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SERINTERDataSet18, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tcotno As System.Windows.Forms.TextBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Generar_CotizacionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SERINTERDataSet18 As Serinter_Maquinaria.SERINTERDataSet18
    Friend WithEvents Generar_CotizacionTableAdapter As Serinter_Maquinaria.SERINTERDataSet18TableAdapters.Generar_CotizacionTableAdapter
End Class
