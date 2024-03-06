<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRemisionesImpr
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRemisionesImpr))
        Me.Generar_RemisionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SERINTERDataSet12 = New Serinter_Maquinaria.SERINTERDataSet12()
        Me.nosalida2 = New System.Windows.Forms.TextBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Generar_RemisionesTableAdapter = New Serinter_Maquinaria.SERINTERDataSet12TableAdapters.Generar_RemisionesTableAdapter()
        CType(Me.Generar_RemisionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SERINTERDataSet12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Generar_RemisionesBindingSource
        '
        Me.Generar_RemisionesBindingSource.DataMember = "Generar_Remisiones"
        Me.Generar_RemisionesBindingSource.DataSource = Me.SERINTERDataSet12
        '
        'SERINTERDataSet12
        '
        Me.SERINTERDataSet12.DataSetName = "SERINTERDataSet12"
        Me.SERINTERDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'nosalida2
        '
        Me.nosalida2.Location = New System.Drawing.Point(323, 142)
        Me.nosalida2.Name = "nosalida2"
        Me.nosalida2.Size = New System.Drawing.Size(100, 20)
        Me.nosalida2.TabIndex = 3
        Me.nosalida2.Visible = False
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetRM"
        ReportDataSource1.Value = Me.Generar_RemisionesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Serinter_Maquinaria.FrmRemisionesV7.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1284, 661)
        Me.ReportViewer1.TabIndex = 2
        '
        'Generar_RemisionesTableAdapter
        '
        Me.Generar_RemisionesTableAdapter.ClearBeforeFill = True
        '
        'FrmRemisionesImpr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 661)
        Me.Controls.Add(Me.nosalida2)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmRemisionesImpr"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmRemisionesImpr"
        CType(Me.Generar_RemisionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SERINTERDataSet12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nosalida2 As System.Windows.Forms.TextBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Generar_RemisionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SERINTERDataSet12 As Serinter_Maquinaria.SERINTERDataSet12
    Friend WithEvents Generar_RemisionesTableAdapter As Serinter_Maquinaria.SERINTERDataSet12TableAdapters.Generar_RemisionesTableAdapter
End Class
