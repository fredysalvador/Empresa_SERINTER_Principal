Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Data

Public Class FrmPrincipal


    'Informacion para la solicitud de compra
    Public valornumSolcompra As String


    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub bproveedor_Click(sender As Object, e As EventArgs) Handles bproveedor.Click
        Dim MDIform As New FrmProveedores
        MDIform.MdiParent = Me
        MDIform.Show()
        bordenes.Enabled = False
        busuario.Enabled = False
        bproveedor.Enabled = False
        bgastosmaq.Enabled = False
        bsolicitudes.Enabled = False
        binventariado.Enabled = False
        bhojasalida.Enabled = False
        bpaseentrada.Enabled = False
        bmaquinariareg.Enabled = False
        bfechasret1.Enabled = False
    End Sub
    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles busuario.Click
        Dim MDIform As New FrmUsuarios
        MDIform.MdiParent = Me
        MDIform.Show()
        bordenes.Enabled = False
        busuario.Enabled = False
        bproveedor.Enabled = False
        bgastosmaq.Enabled = False
        bsolicitudes.Enabled = False
        binventariado.Enabled = False
        bhojasalida.Enabled = False
        bpaseentrada.Enabled = False
        bmaquinariareg.Enabled = False
        bfechasret1.Enabled = False
    End Sub

    Public Sub EstatusOrdenCompraFrm()
        Dim MDIform As New EstatusOrdenesCompras
        MDIform.MdiParent = Me
        MDIform.Show()
        bordenes.Enabled = False
        busuario.Enabled = False
        bproveedor.Enabled = False
        bgastosmaq.Enabled = False
        bsolicitudes.Enabled = False
        binventariado.Enabled = False
        bhojasalida.Enabled = False
        bpaseentrada.Enabled = False
        bmaquinariareg.Enabled = False
        bfechasret1.Enabled = False
    End Sub


    Public Sub GenerarSolcCompra()
        Dim MDIform As New FrmListadoOrdAgr
        MDIform.MdiParent = Me
        MDIform.Show()
        bordenes.Enabled = False
        busuario.Enabled = False
        bproveedor.Enabled = False
        bgastosmaq.Enabled = False
        bsolicitudes.Enabled = False
        binventariado.Enabled = False
        bhojasalida.Enabled = False
        bpaseentrada.Enabled = False
        bmaquinariareg.Enabled = False
        bfechasret1.Enabled = False
    End Sub

    Public Sub EstatusSolicitudes()
        Dim MDIform As New FrmEstatusSolcitudes
        MDIform.MdiParent = Me
        MDIform.Show()
        bordenes.Enabled = False
        busuario.Enabled = False
        bproveedor.Enabled = False
        bgastosmaq.Enabled = False
        bsolicitudes.Enabled = False
        binventariado.Enabled = False
        bhojasalida.Enabled = False
        bpaseentrada.Enabled = False
        bmaquinariareg.Enabled = False
        bfechasret1.Enabled = False
    End Sub

    Public Sub OrdenCompraformulario()
        Dim MDIform As New FrmOrdendeCompraXm
        MDIform.MdiParent = Me
        MDIform.Show()
        bordenes.Enabled = False
        busuario.Enabled = False
        bproveedor.Enabled = False
        bgastosmaq.Enabled = False
        bsolicitudes.Enabled = False
        binventariado.Enabled = False
        bhojasalida.Enabled = False
        bpaseentrada.Enabled = False
        bmaquinariareg.Enabled = False
        bfechasret1.Enabled = False
    End Sub


    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles bordenes.Click
        EstatusSolicitudes()
    End Sub

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If lrol.Text = "Administracion" Then

        ElseIf lrol.Text = "Administrador" Then

        ElseIf lrol.Text = "Dueño" Then

        ElseIf lrol.Text = "Asistente SR" Then
            busuario.Enabled = False
            bproveedor.Enabled = False

        ElseIf lrol.Text = "Compras" Then
            busuario.Enabled = False

        ElseIf lrol.Text = "Gestor de Proyectos" Then


        ElseIf lrol.Text = "Bodeguero SR" Then
            busuario.Enabled = False
            bproveedor.Enabled = False

        ElseIf lrol.Text = "Taller Mecanico" Then
            busuario.Enabled = False
            bproveedor.Enabled = False

        ElseIf lrol.Text = "Contabilidad" Then
            busuario.Enabled = False
            bproveedor.Enabled = False
        End If




        Dim C As Control

        For Each C In Me.Controls
            If TypeOf C Is MdiClient Then
                C.BackColor = Color.FromArgb(255, 255, 255)
                Exit For
            End If
        Next

        C = Nothing
    End Sub

    Private Sub bgastosmaq_Click(sender As Object, e As EventArgs) Handles bgastosmaq.Click
        Dim MDIform As New FrmGastosMaquinas
        MDIform.MdiParent = Me
        MDIform.Show()
        bordenes.Enabled = False
        busuario.Enabled = False
        bproveedor.Enabled = False
        bgastosmaq.Enabled = False
        bsolicitudes.Enabled = False
        binventariado.Enabled = False
        bhojasalida.Enabled = False
        bpaseentrada.Enabled = False
        bmaquinariareg.Enabled = False
        bfechasret1.Enabled = False
    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub bsolicitudes_Click(sender As Object, e As EventArgs) Handles bsolicitudes.Click
        Dim MDIform As New FrmSolicitudesXm
        MDIform.MdiParent = Me
        MDIform.Show()
        bordenes.Enabled = False
        bsolicitudes.Enabled = False
        busuario.Enabled = False
        bproveedor.Enabled = False
        bgastosmaq.Enabled = False
        binventariado.Enabled = False
        bhojasalida.Enabled = False
        bpaseentrada.Enabled = False
        bmaquinariareg.Enabled = False
        bfechasret1.Enabled = False
    End Sub

    Private Sub lnombres_Click(sender As Object, e As EventArgs) Handles lnombres.Click

    End Sub

    Private Sub binventariado_Click(sender As Object, e As EventArgs) Handles binventariado.Click
        Dim MDIform As New FrmInventariado
        MDIform.MdiParent = Me
        MDIform.Show()
        bordenes.Enabled = False
        busuario.Enabled = False
        bproveedor.Enabled = False
        bgastosmaq.Enabled = False
        bsolicitudes.Enabled = False
        binventariado.Enabled = False
        bhojasalida.Enabled = False
        bpaseentrada.Enabled = False
        bmaquinariareg.Enabled = False
        bfechasret1.Enabled = False
    End Sub

    Private Sub bpasesalida_Click(sender As Object, e As EventArgs) Handles bhojasalida.Click
        Dim MDIform As New FrmHojaSalida
        MDIform.MdiParent = Me
        MDIform.Show()
        bordenes.Enabled = False
        busuario.Enabled = False
        bproveedor.Enabled = False
        bgastosmaq.Enabled = False
        bsolicitudes.Enabled = False
        binventariado.Enabled = False
        bhojasalida.Enabled = False
        bpaseentrada.Enabled = False
        bmaquinariareg.Enabled = False
        bfechasret1.Enabled = False
    End Sub

    Private Sub bpaseentrada_Click(sender As Object, e As EventArgs) Handles bpaseentrada.Click
        Dim MDIform As New FrmRemisiones
        MDIform.MdiParent = Me
        MDIform.Show()
        bordenes.Enabled = False
        busuario.Enabled = False
        bproveedor.Enabled = False
        bgastosmaq.Enabled = False
        bsolicitudes.Enabled = False
        binventariado.Enabled = False
        bhojasalida.Enabled = False
        bpaseentrada.Enabled = False
        bmaquinariareg.Enabled = False
        bfechasret1.Enabled = False
    End Sub

    Private Sub bmaquinariareg_Click(sender As Object, e As EventArgs) Handles bmaquinariareg.Click
        Dim MDIform As New FrmIngresoVehiculos
        MDIform.MdiParent = Me
        MDIform.Show()
        bordenes.Enabled = False
        busuario.Enabled = False
        bproveedor.Enabled = False
        bgastosmaq.Enabled = False
        bsolicitudes.Enabled = False
        binventariado.Enabled = False
        bhojasalida.Enabled = False
        bpaseentrada.Enabled = False
        bmaquinariareg.Enabled = False
        bfechasret1.Enabled = False
    End Sub

    Private Sub MzButtonWindows1_Paint(sender As Object, e As PaintEventArgs) Handles MzButtonWindows1.Paint
        MzButtonWindows1.BackColor = Color.DarkCyan
    End Sub

    Private Sub bfechasret1_Click(sender As Object, e As EventArgs) Handles bfechasret1.Click
        Dim MDIform As New FrmFechasRetornoMqInv
        MDIform.MdiParent = Me
        MDIform.Show()
        bordenes.Enabled = False
        busuario.Enabled = False
        bproveedor.Enabled = False
        bgastosmaq.Enabled = False
        bsolicitudes.Enabled = False
        binventariado.Enabled = False
        bhojasalida.Enabled = False
        bpaseentrada.Enabled = False
        bmaquinariareg.Enabled = False
        bfechasret1.Enabled = False
    End Sub



    Private Sub FrmPrincipal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress

        If AscW(e.KeyChar) = Keys.Enter Then

            If lrol.Text = "Administrador" Then

            ElseIf lrol.Text = "Dueño" Then

            ElseIf lrol.Text = "Administracion" Then

            ElseIf lrol.Text = "Gestor de Proyectos" Then

            ElseIf lrol.Text = "Bodeguero SR" Then

                'Dim Mdiform As New FrmHojaSalida
                'Mdiform.MdiParent = Me
                'Mdiform.Show()

            ElseIf lrol.Text = "Taller Mecanico" Then

                'Dim Mdiform As New FrmIngresoVehiculos
                'Mdiform.MdiParent = Me
                'Mdiform.Show()

            ElseIf lrol.Text = "Contabilidad" Then

                'Dim Mdiform As New FrmInventariado
                'Mdiform.MdiParent = Me
                'Mdiform.Show()

            End If
        End If


    End Sub

    Private Sub FrmPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        FrmLogin.Show()
    End Sub

    Private Sub bcotizaciones_Click(sender As Object, e As EventArgs) Handles bcotizaciones.Click
        Dim MDIform As New FrmCotizacionesvb
        MDIform.MdiParent = Me
        MDIform.Show()
        bordenes.Enabled = False
        busuario.Enabled = False
        bproveedor.Enabled = False
        bgastosmaq.Enabled = False
        bsolicitudes.Enabled = False
        binventariado.Enabled = False
        bhojasalida.Enabled = False
        bpaseentrada.Enabled = False
        bmaquinariareg.Enabled = False
        bfechasret1.Enabled = False
    End Sub

End Class
