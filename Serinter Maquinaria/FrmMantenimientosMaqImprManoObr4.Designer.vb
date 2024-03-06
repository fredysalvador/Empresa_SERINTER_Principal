<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientosMaqImprManoObr4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMantenimientosMaqImprManoObr4))
        Me.Generar_DatosManoObr2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SERINTERDataSet16 = New Serinter_Maquinaria.SERINTERDataSet16()
        Me.tcodv = New System.Windows.Forms.TextBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Generar_DatosManoObr2TableAdapter = New Serinter_Maquinaria.SERINTERDataSet16TableAdapters.Generar_DatosManoObr2TableAdapter()
        CType(Me.Generar_DatosManoObr2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SERINTERDataSet16, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Generar_DatosManoObr2BindingSource
        '
        Me.Generar_DatosManoObr2BindingSource.DataMember = "Generar_DatosManoObr2"
        Me.Generar_DatosManoObr2BindingSource.DataSource = Me.SERINTERDataSet16
        '
        'SERINTERDataSet16
        '
        Me.SERINTERDataSet16.DataSetName = "SERINTERDataSet16"
        Me.SERINTERDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tcodv
        '
        Me.tcodv.Location = New System.Drawing.Point(488, 217)
        Me.tcodv.Name = "tcodv"
        Me.tcodv.Size = New System.Drawing.Size(100, 20)
        Me.tcodv.TabIndex = 4
        Me.tcodv.Visible = False
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Generar_DatosManoObr2BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Serinter_Maquinaria.FrmMantenimientosMaqObr4.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1076, 607)
        Me.ReportViewer1.TabIndex = 3
        '
        'Generar_DatosManoObr2TableAdapter
        '
        Me.Generar_DatosManoObr2TableAdapter.ClearBeforeFill = True
        '
        'FrmMantenimientosMaqImprManoObr4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1076, 607)
        Me.Controls.Add(Me.tcodv)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMantenimientosMaqImprManoObr4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMantenimientosMaqImprManoObr4"
        CType(Me.Generar_DatosManoObr2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SERINTERDataSet16, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tcodv As System.Windows.Forms.TextBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Generar_DatosManoObr2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SERINTERDataSet16 As Serinter_Maquinaria.SERINTERDataSet16
    Friend WithEvents Generar_DatosManoObr2TableAdapter As Serinter_Maquinaria.SERINTERDataSet16TableAdapters.Generar_DatosManoObr2TableAdapter
End Class
