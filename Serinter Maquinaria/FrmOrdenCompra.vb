Public Class FrmOrdenCompra

    Private Sub FrmOrdenCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        FrmPrincipal.bhojasalida.Enabled = True
        FrmPrincipal.bpaseentrada.Enabled = True
        FrmPrincipal.bmaquinariareg.Enabled = True
    End Sub

    Private Sub breiniciar_Click(sender As Object, e As EventArgs) Handles breiniciar.Click

    End Sub
End Class