Public Class FrmRemisionesImp2

    Private Sub FrmRemisionesImp2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SERINTERDataSet22.Generar_Remision' Puede moverla o quitarla según sea necesario.
        Me.Generar_RemisionTableAdapter.Fill(Me.SERINTERDataSet22.Generar_Remision, no_remision:=noremision.Text)
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        Me.ReportViewer1.ZoomPercent = 100
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class