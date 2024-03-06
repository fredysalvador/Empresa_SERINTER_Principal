Imports System.Data.SqlClient
Imports System.Data
Imports System.Runtime.InteropServices


Public Class FrmSeleccionVhMan
    Public codv, tipomaq, placaveh, propietariosE, ubicaciond, estadovh, condicion, marca, modelo, compradt, tipotrans, tprecio, tnomotor, tcolorvh, tyearfab As String
    Public dimenlarg, dimenancho, dimenalto, dimenpeso As String
    Public foto As Image
    Public foto2 As Image

    Private Sub FrmSeleccionVhMan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Conexion = New SqlConnection
        Conexion.ConnectionString = cadena
    End Sub

    Private Sub bmanteobj_Click(sender As Object, e As EventArgs) Handles bmanteobj.Click
        FrmMantenimientosMaq.Show()
        FrmMantenimientosMaq.tcodv.Text = codv
        FrmMantenimientosMaq.ttipomaq.Text = tipomaq
        FrmMantenimientosMaq.tplacveh.Text = placaveh
        FrmMantenimientosMaq.tpropetarios.Text = propietariosE
        FrmMantenimientosMaq.tubicacion.Text = ubicaciond
        FrmMantenimientosMaq.testadovh.Text = estadovh
        FrmMantenimientosMaq.tcondicion.Text = condicion
        FrmMantenimientosMaq.tmarcavh.Text = marca
        FrmMantenimientosMaq.tmodelovh.Text = modelo
        FrmMantenimientosMaq.dtpcompra.Text = compradt
        FrmMantenimientosMaq.tpreciocompra.Text = tprecio
        FrmMantenimientosMaq.ttipotrans.Text = tipotrans
        FrmMantenimientosMaq.tnomotor.Text = tnomotor
        FrmMantenimientosMaq.tcolorvh.Text = tcolorvh
        FrmMantenimientosMaq.tyearfab.Text = tyearfab
        FrmMantenimientosMaq.tdimenlargo.Text = dimenlarg
        FrmMantenimientosMaq.tdimenancho.Text = dimenancho
        FrmMantenimientosMaq.tdimenalto.Text = dimenalto
        FrmMantenimientosMaq.tdimenpeso.Text = dimenpeso

        FrmMantenimientosMaq.pfoto.Image = foto
        FrmMantenimientosMaq.pfoto.SizeMode = PictureBoxSizeMode.StretchImage
        FrmMantenimientosMaq.pfoto2.Image = foto2
        FrmMantenimientosMaq.pfoto2.SizeMode = PictureBoxSizeMode.StretchImage
        FrmMantenimientosMaq.Timer1.Enabled = True

        Close()
    End Sub

    Private Sub bmanobr_Click(sender As Object, e As EventArgs) Handles bmanobr.Click

        FrmMantenimientosMaqObr.Show()
        FrmMantenimientosMaqObr.tcodv.Text = codv
        FrmMantenimientosMaqObr.ttipomaq.Text = tipomaq
        FrmMantenimientosMaqObr.tplacveh.Text = placaveh
        FrmMantenimientosMaqObr.tpropetarios.Text = propietariosE
        FrmMantenimientosMaqObr.tubicacion.Text = ubicaciond
        FrmMantenimientosMaqObr.testadovh.Text = estadovh
        FrmMantenimientosMaqObr.tcondicion.Text = condicion
        FrmMantenimientosMaqObr.tmarcavh.Text = marca
        FrmMantenimientosMaqObr.tmodelovh.Text = modelo
        FrmMantenimientosMaqObr.dtpcompra.Text = compradt
        FrmMantenimientosMaqObr.tpreciocompra.Text = tprecio
        FrmMantenimientosMaqObr.ttipotrans.Text = tipotrans
        FrmMantenimientosMaqObr.tnomotor.Text = tnomotor
        FrmMantenimientosMaqObr.tcolorvh.Text = tcolorvh
        FrmMantenimientosMaqObr.tyearfab.Text = tyearfab
        FrmMantenimientosMaqObr.tdimenlargo.Text = dimenlarg
        FrmMantenimientosMaqObr.tdimenancho.Text = dimenancho
        FrmMantenimientosMaqObr.tdimenalto.Text = dimenalto
        FrmMantenimientosMaqObr.tdimenpeso.Text = dimenpeso

        FrmMantenimientosMaqObr.pfoto.Image = foto
        FrmMantenimientosMaqObr.pfoto.SizeMode = PictureBoxSizeMode.StretchImage
        FrmMantenimientosMaqObr.pfoto2.Image = foto2
        FrmMantenimientosMaqObr.pfoto2.SizeMode = PictureBoxSizeMode.StretchImage
        FrmMantenimientosMaqObr.Timer1.Enabled = True


        Close()
    End Sub

    'Private Sub btodo_Click(sender As Object, e As EventArgs)
    '    FrmMantenimientosMaqTotal.Show()
    '    FrmMantenimientosMaqTotal.tcodv.Text = codv
    '    FrmMantenimientosMaqTotal.ttipomaq.Text = tipomaq
    '    FrmMantenimientosMaqTotal.tplacveh.Text = placaveh
    '    FrmMantenimientosMaqTotal.tpropetarios.Text = propietariosE
    '    FrmMantenimientosMaqTotal.tubicacion.Text = ubicaciond
    '    FrmMantenimientosMaqTotal.testadovh.Text = estadovh
    '    FrmMantenimientosMaqTotal.tcondicion.Text = condicion
    '    FrmMantenimientosMaqTotal.tmarcavh.Text = marca
    '    FrmMantenimientosMaqTotal.tmodelovh.Text = modelo
    '    FrmMantenimientosMaqTotal.dtpcompra.Text = compradt
    '    FrmMantenimientosMaqTotal.tpreciocompra.Text = tprecio
    '    FrmMantenimientosMaqTotal.ttipotrans.Text = tipotrans
    '    FrmMantenimientosMaqTotal.tnomotor.Text = tnomotor
    '    FrmMantenimientosMaqTotal.tcolorvh.Text = tcolorvh
    '    FrmMantenimientosMaqTotal.tyearfab.Text = tyearfab
    '    FrmMantenimientosMaqTotal.tdimenlargo.Text = dimenlarg
    '    FrmMantenimientosMaqTotal.tdimenancho.Text = dimenancho
    '    FrmMantenimientosMaqTotal.tdimenalto.Text = dimenalto
    '    FrmMantenimientosMaqTotal.tdimenpeso.Text = dimenpeso

    '    FrmMantenimientosMaqTotal.pfoto.Image = foto
    '    FrmMantenimientosMaqTotal.pfoto.SizeMode = PictureBoxSizeMode.StretchImage
    '    FrmMantenimientosMaqTotal.pfoto2.Image = foto2
    '    FrmMantenimientosMaqTotal.pfoto2.SizeMode = PictureBoxSizeMode.StretchImage
    '    FrmMantenimientosMaqTotal.Timer1.Enabled = True
    '    FrmMantenimientosMaqTotal.Timer6.Enabled = True

    '    Close()
    'End Sub

    Private Sub busura_Click(sender As Object, e As EventArgs) Handles busura.Click
        FrmMantenimientosMaqUsura.Show()
        FrmMantenimientosMaqUsura.tcodv.Text = codv
        FrmMantenimientosMaqUsura.ttipomaq.Text = tipomaq
        FrmMantenimientosMaqUsura.tplacveh.Text = placaveh
        FrmMantenimientosMaqUsura.tpropetarios.Text = propietariosE
        FrmMantenimientosMaqUsura.tubicacion.Text = ubicaciond
        FrmMantenimientosMaqUsura.testadovh.Text = estadovh
        FrmMantenimientosMaqUsura.tcondicion.Text = condicion
        FrmMantenimientosMaqUsura.tmarcavh.Text = marca
        FrmMantenimientosMaqUsura.tmodelovh.Text = modelo
        FrmMantenimientosMaqUsura.dtpcompra.Text = compradt
        FrmMantenimientosMaqUsura.tpreciocompra.Text = tprecio
        FrmMantenimientosMaqUsura.ttipotrans.Text = tipotrans
        FrmMantenimientosMaqUsura.tnomotor.Text = tnomotor
        FrmMantenimientosMaqUsura.tcolorvh.Text = tcolorvh
        FrmMantenimientosMaqUsura.tyearfab.Text = tyearfab
        FrmMantenimientosMaqUsura.tdimenlargo.Text = dimenlarg
        FrmMantenimientosMaqUsura.tdimenancho.Text = dimenancho
        FrmMantenimientosMaqUsura.tdimenalto.Text = dimenalto
        FrmMantenimientosMaqUsura.tdimenpeso.Text = dimenpeso

        FrmMantenimientosMaqUsura.pfoto.Image = foto
        FrmMantenimientosMaqUsura.pfoto.SizeMode = PictureBoxSizeMode.StretchImage
        FrmMantenimientosMaqUsura.pfoto2.Image = foto2
        FrmMantenimientosMaqUsura.pfoto2.SizeMode = PictureBoxSizeMode.StretchImage
        FrmMantenimientosMaqUsura.Timer1.Enabled = True

        Close()
    End Sub
End Class