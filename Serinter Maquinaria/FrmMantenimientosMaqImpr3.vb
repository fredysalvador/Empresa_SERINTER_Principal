Public Class FrmMantenimientosMaqImpr3

    Private Sub FrmMantenimientosMaqImpr3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SERINTERDataSet13.Generar_DatosMaquinaria2' Puede moverla o quitarla según sea necesario.
        Me.Generar_DatosMaquinaria2TableAdapter.Fill(Me.SERINTERDataSet13.Generar_DatosMaquinaria2, codigo_vh:=tcodv.Text)
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        Me.ReportViewer1.ZoomPercent = 100
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class