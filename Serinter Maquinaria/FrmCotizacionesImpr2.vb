Public Class FrmCotizacionesImpr2

    Private Sub FrmCotizacionesImpr2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SERINTERDataSet11.Generar_Cotizacion' Puede moverla o quitarla según sea necesario.
        Me.Generar_CotizacionTableAdapter.Fill(Me.SERINTERDataSet11.Generar_Cotizacion, no_cotizacion:=tcotno.Text)
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        Me.ReportViewer1.ZoomPercent = 100
    End Sub
End Class