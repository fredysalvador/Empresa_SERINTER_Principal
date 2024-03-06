Public Class FrmMantenimientosMaqImprUsura2

    Private Sub FrmMantenimientosMaqImprUsura2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SERINTERDataSet17.Generar_usura' Puede moverla o quitarla según sea necesario.
        Me.Generar_usuraTableAdapter.Fill(Me.SERINTERDataSet17.Generar_usura, codigo_vh:=tcodv.Text)
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        Me.ReportViewer1.ZoomPercent = 100
    End Sub
End Class