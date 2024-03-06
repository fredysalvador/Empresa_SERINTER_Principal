Public Class FrmEntradaInventario

    Private Sub FrmEntradaInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub bregresar_Click(sender As Object, e As EventArgs) Handles bregresar.Click
        FrmPrincipal.Show()
        Me.Hide()
        FrmPrincipal.bsolicitudes.Enabled = True
        FrmPrincipal.bordenes.Enabled = True
        FrmPrincipal.busuario.Enabled = True
        FrmPrincipal.bproveedor.Enabled = True
        FrmPrincipal.bgastosmaq.Enabled = True
        FrmPrincipal.binventariado.Enabled = True
        FrmPrincipal.bfechasret1.Enabled = True
        FrmPrincipal.bpasesalida.Enabled = True
        FrmPrincipal.bpaseentrada.Enabled = True
        FrmPrincipal.bmaquinariareg.Enabled = True
    End Sub
End Class