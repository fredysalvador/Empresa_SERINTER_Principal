﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientosMaqImprManoObr1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMantenimientosMaqImprManoObr1))
        Me.Generar_DatosManoObr1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SERINTERDataSet7 = New Serinter_Maquinaria.SERINTERDataSet7()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Generar_DatosManoObr1TableAdapter = New Serinter_Maquinaria.SERINTERDataSet7TableAdapters.Generar_DatosManoObr1TableAdapter()
        Me.tcodv = New System.Windows.Forms.TextBox()
        CType(Me.Generar_DatosManoObr1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SERINTERDataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Generar_DatosManoObr1BindingSource
        '
        Me.Generar_DatosManoObr1BindingSource.DataMember = "Generar_DatosManoObr1"
        Me.Generar_DatosManoObr1BindingSource.DataSource = Me.SERINTERDataSet7
        '
        'SERINTERDataSet7
        '
        Me.SERINTERDataSet7.DataSetName = "SERINTERDataSet7"
        Me.SERINTERDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Generar_DatosManoObr1BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Serinter_Maquinaria.FrmMantenimientosMaqObr1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1076, 607)
        Me.ReportViewer1.TabIndex = 0
        '
        'Generar_DatosManoObr1TableAdapter
        '
        Me.Generar_DatosManoObr1TableAdapter.ClearBeforeFill = True
        '
        'tcodv
        '
        Me.tcodv.Location = New System.Drawing.Point(119, 50)
        Me.tcodv.Name = "tcodv"
        Me.tcodv.Size = New System.Drawing.Size(100, 20)
        Me.tcodv.TabIndex = 2
        Me.tcodv.Visible = False
        '
        'FrmMantenimientosMaqImprManoObr1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1076, 607)
        Me.Controls.Add(Me.tcodv)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMantenimientosMaqImprManoObr1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMantenimientosMaqImprManoObr1"
        CType(Me.Generar_DatosManoObr1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SERINTERDataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Generar_DatosManoObr1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SERINTERDataSet7 As Serinter_Maquinaria.SERINTERDataSet7
    Friend WithEvents Generar_DatosManoObr1TableAdapter As Serinter_Maquinaria.SERINTERDataSet7TableAdapters.Generar_DatosManoObr1TableAdapter
    Friend WithEvents tcodv As System.Windows.Forms.TextBox
End Class
