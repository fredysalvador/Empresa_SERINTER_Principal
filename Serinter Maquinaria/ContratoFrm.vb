Public Class ContratoFrm
    Private Sub ContratoFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Generar_solicitudTableAdapter.Fill(Me.SERINTERDataSet.Generar_solicitud, num_orden:=tsolicitud.Text)
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        Me.ReportViewer1.ZoomPercent = 100
    End Sub
End Class