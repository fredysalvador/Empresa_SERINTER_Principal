Public Class FrmHojaSalidaImpr2

    Private Sub FrmHojaSalidaImpr2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SERINTERDataSet10.Generar_PaseSalida' Puede moverla o quitarla según sea necesario.
        Me.Generar_PaseSalidaTableAdapter.Fill(Me.SERINTERDataSet10.Generar_PaseSalida, no_salida:=tsalida.Text)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        Me.ReportViewer1.ZoomPercent = 100
    End Sub
End Class