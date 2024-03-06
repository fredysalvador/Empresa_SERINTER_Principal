Public Class FrmRemisionesImpr

    Private Sub FrmRemisionesImpr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SERINTERDataSet12.Generar_Remisiones' Puede moverla o quitarla según sea necesario.
        Me.Generar_RemisionesTableAdapter.Fill(Me.SERINTERDataSet12.Generar_Remisiones, no_salida:=nosalida2.Text)
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        Me.ReportViewer1.ZoomPercent = 100
    End Sub

End Class