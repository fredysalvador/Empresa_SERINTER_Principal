﻿Public Class FrmCotizacionesImprHNL1

    Private Sub FrmCotizacionesImprHNL1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SERINTERDataSet19.Generar_CotizacionCM' Puede moverla o quitarla según sea necesario.
        Me.Generar_CotizacionCMTableAdapter.Fill(Me.SERINTERDataSet19.Generar_CotizacionCM, no_cotizacion:=tcotno.Text)
        'TODO: esta línea de código carga datos en la tabla 'SERINTERDataSet19.Generar_CotizacionCM' Puede moverla o quitarla según sea necesario.
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        Me.ReportViewer1.ZoomPercent = 100
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class