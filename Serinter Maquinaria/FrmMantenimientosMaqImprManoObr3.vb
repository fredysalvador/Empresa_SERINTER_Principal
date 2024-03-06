Public Class FrmMantenimientosMaqImprManoObr3

    Private Sub FrmMantenimientosMaqImprManoObr3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SERINTERDataSet15.Generar_DatosManoObr1' Puede moverla o quitarla según sea necesario.
        Me.Generar_DatosManoObr1TableAdapter.Fill(Me.SERINTERDataSet15.Generar_DatosManoObr1, codigo_vh:=tcodv.Text, valor1:=FrmMantenimientosMaqObr.dtp1.Value, valor2:=FrmMantenimientosMaqObr.dtp2.Value)
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        Me.ReportViewer1.ZoomPercent = 100
    End Sub
End Class