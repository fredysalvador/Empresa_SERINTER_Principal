<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRemisionesImp2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRemisionesImp2))
        Me.Generar_RemisionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SERINTERDataSet22 = New Serinter_Maquinaria.SERINTERDataSet22()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Generar_RemisionTableAdapter = New Serinter_Maquinaria.SERINTERDataSet22TableAdapters.Generar_RemisionTableAdapter()
        Me.noremision = New System.Windows.Forms.TextBox()
        CType(Me.Generar_RemisionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SERINTERDataSet22, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Generar_RemisionBindingSource
        '
        Me.Generar_RemisionBindingSource.DataMember = "Generar_Remision"
        Me.Generar_RemisionBindingSource.DataSource = Me.SERINTERDataSet22
        '
        'SERINTERDataSet22
        '
        Me.SERINTERDataSet22.DataSetName = "SERINTERDataSet22"
        Me.SERINTERDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Generar_RemisionBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Serinter_Maquinaria.FrmRemisionesV8.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1284, 661)
        Me.ReportViewer1.TabIndex = 0
        '
        'Generar_RemisionTableAdapter
        '
        Me.Generar_RemisionTableAdapter.ClearBeforeFill = True
        '
        'noremision
        '
        Me.noremision.Location = New System.Drawing.Point(630, 178)
        Me.noremision.Name = "noremision"
        Me.noremision.Size = New System.Drawing.Size(100, 20)
        Me.noremision.TabIndex = 1
        Me.noremision.Visible = False
        '
        'FrmRemisionesImp2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 661)
        Me.Controls.Add(Me.noremision)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmRemisionesImp2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmRemisionesImp2"
        CType(Me.Generar_RemisionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SERINTERDataSet22, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Generar_RemisionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SERINTERDataSet22 As Serinter_Maquinaria.SERINTERDataSet22
    Friend WithEvents Generar_RemisionTableAdapter As Serinter_Maquinaria.SERINTERDataSet22TableAdapters.Generar_RemisionTableAdapter
    Friend WithEvents noremision As System.Windows.Forms.TextBox
End Class
