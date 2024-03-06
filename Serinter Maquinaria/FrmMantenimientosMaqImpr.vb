Public Class FrmMantenimientosMaqImpr

    Private Sub FrmMantenimientosMaqImpr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SERINTERDataSet5.Generar_DatosMaquinaria' Puede moverla o quitarla según sea necesario.
        Me.Generar_DatosMaquinariaTableAdapter.Fill(Me.SERINTERDataSet5.Generar_DatosMaquinaria, codigo_vh:=tcodv.Text, valor1:=FrmMantenimientosMaq.dtp1.Value, valor2:=FrmMantenimientosMaq.dtp2.Value)
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        Me.ReportViewer1.ZoomPercent = 100
    End Sub
End Class