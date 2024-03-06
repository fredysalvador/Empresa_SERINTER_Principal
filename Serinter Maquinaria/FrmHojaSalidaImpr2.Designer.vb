<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHojaSalidaImpr2
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SERINTERDataSet10 = New Serinter_Maquinaria.SERINTERDataSet10()
        Me.Generar_PaseSalidaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Generar_PaseSalidaTableAdapter = New Serinter_Maquinaria.SERINTERDataSet10TableAdapters.Generar_PaseSalidaTableAdapter()
        Me.tsalida = New System.Windows.Forms.TextBox()
        CType(Me.SERINTERDataSet10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Generar_PaseSalidaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.Generar_PaseSalidaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Serinter_Maquinaria.FrmHojaSalidaV7.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1284, 661)
        Me.ReportViewer1.TabIndex = 0
        '
        'SERINTERDataSet10
        '
        Me.SERINTERDataSet10.DataSetName = "SERINTERDataSet10"
        Me.SERINTERDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Generar_PaseSalidaBindingSource
        '
        Me.Generar_PaseSalidaBindingSource.DataMember = "Generar_PaseSalida"
        Me.Generar_PaseSalidaBindingSource.DataSource = Me.SERINTERDataSet10
        '
        'Generar_PaseSalidaTableAdapter
        '
        Me.Generar_PaseSalidaTableAdapter.ClearBeforeFill = True
        '
        'tsalida
        '
        Me.tsalida.Location = New System.Drawing.Point(706, 13)
        Me.tsalida.Name = "tsalida"
        Me.tsalida.Size = New System.Drawing.Size(100, 20)
        Me.tsalida.TabIndex = 1
        Me.tsalida.Visible = False
        '
        'FrmHojaSalidaImpr2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 661)
        Me.Controls.Add(Me.tsalida)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmHojaSalidaImpr2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmHojaSalidaImpr2"
        CType(Me.SERINTERDataSet10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Generar_PaseSalidaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Generar_PaseSalidaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SERINTERDataSet10 As Serinter_Maquinaria.SERINTERDataSet10
    Friend WithEvents Generar_PaseSalidaTableAdapter As Serinter_Maquinaria.SERINTERDataSet10TableAdapters.Generar_PaseSalidaTableAdapter
    Friend WithEvents tsalida As System.Windows.Forms.TextBox
End Class
