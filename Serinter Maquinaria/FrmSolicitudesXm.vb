Imports System.Data.SqlClient
Imports System.Data
Imports System.Runtime.InteropServices
Public Class FrmSolicitudesXm
    Dim Subtotalx As String
    Dim Retenem As String
    Dim Isvx As String
    Dim Descx As String
    Dim TotalTotales As String
    Dim Psext As String

    Private Sub FrmSolicitudesXm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tsolicitadopor.Text = FrmPrincipal.lnombres.Text
        Conexion = New SqlConnection
        Conexion.ConnectionString = cadena
        Dim da As New SqlDataAdapter("Select * from proveedores", Conexion)
        Dim dt As New DataTable
        da.Fill(dt)
        tproveedor.DataSource = dt
        tproveedor.DisplayMember = "nom_proveedor"
        tproveedor.ValueMember = "cod_proveedor"
    End Sub
    Private Sub tnorden_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tnorden.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tnorden_Validated(sender, e)
        End If
    End Sub

    Private Sub tnorden_Validated(sender As Object, e As EventArgs) Handles tnorden.Validated
        limpiarparcial()
        If tnorden.Text = Nothing Then
            mensaje.Text = "Dejo vacio el numero de orden"
            tnorden.Focus()
            Exit Sub
        End If
        sql = "select * from ordenes where num_orden='" & tnorden.Text & "'"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "ordenes")
            resultado = almacen.Tables("ordenes").Rows.Count
            If almacen.Tables(0).Rows.Count <> 0 Then
                For j As Integer = 0 To almacen.Tables(0).Rows.Count - 1 Step +1
                    dgvreg.Rows.Add(almacen.Tables(0).Rows(j)("id").ToString(), "", almacen.Tables(0).Rows(j)("cantidad").ToString(), almacen.Tables(0).Rows(j)("unidad").ToString(), almacen.Tables(0).Rows(j)("descripcion").ToString(), almacen.Tables(0).Rows(j)("precio_unit").ToString())
                Next
            End If
            If resultado > 0 Then
                registro = almacen.Tables("ordenes").Rows(0)
                If Not IsDBNull(registro("tipomoneda")) Then
                    If registro("tipomoneda") = "Lempiras" Then
                        rblempiras.Checked = True
                    ElseIf registro("tipomoneda") = "Dolares" Then
                        rbdolares.Checked = True
                    End If
                    If Not IsDBNull(registro("tipotransaccion")) Then
                        If registro("tipotransaccion") = "Cheque Normal" Then
                            rbchekenormal.Checked = True
                        ElseIf registro("tipotransaccion") = "Transferencia" Then
                            rbtransferencia.Checked = True
                        ElseIf registro("tipotransaccion") = "Cheque Certificado" Then
                            rbchequecertificado.Checked = True
                        ElseIf registro("tipotransaccion") = "Giro Bancario" Then
                            rbgirobanc.Checked = True
                        End If
                        If Not IsDBNull(registro("solicitado_por")) Then
                            tsolicitadopor.Text = registro("solicitado_por")
                        End If
                        If Not IsDBNull(registro("departamento")) Then
                            tdepartamento.Text = registro("departamento")
                        End If
                        If Not IsDBNull(registro("nom_proveedor")) Then
                            tproveedor.Text = registro("nom_proveedor")
                        End If
                        If Not IsDBNull(registro("can_letras")) Then
                            tcanletras.Text = registro("can_letras")
                        End If
                        If Not IsDBNull(registro("cargar")) Then
                            tcargara.Text = registro("cargar")
                        End If
                        If Not IsDBNull(registro("proyecto")) Then
                            tproyecto.Text = registro("proyecto")
                        End If
                        If Not IsDBNull(registro("observaciones")) Then
                            tobservaciones.Text = registro("observaciones")
                        End If
                        If Not IsDBNull(registro("dia")) Then
                            tdiae.Text = registro("dia")
                        End If
                        If Not IsDBNull(registro("mes")) Then
                            tmese.Text = registro("mes")
                        End If
                        If Not IsDBNull(registro("año")) Then
                            tañoe.Text = registro("año")
                        End If
                        If Not IsDBNull(registro("dia2")) Then
                            tdiav.Text = registro("dia2")
                        End If
                        If Not IsDBNull(registro("mes2")) Then
                            tmesv.Text = registro("mes2")
                        End If
                        If Not IsDBNull(registro("año2")) Then
                            tañov.Text = registro("año2")
                        End If
                        If Not IsDBNull(registro("descuento")) Then
                            tdesc.Text = registro("descuento")
                        End If
                        If Not IsDBNull(registro("men_retencion")) Then
                            treten.Text = registro("men_retencion")
                        End If
                    End If
                End If
            ElseIf resultado = 0 Then
                rblempiras.Enabled = True
                rbdolares.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Conexion.Close()
        tdepartamento.Focus()
    End Sub
    Private Sub limpiar()
        tnorden.Text = Nothing
        limpiarparcial()
    End Sub
    Private Sub limpiarparcial()
        rblempiras.Checked = Nothing
        rbdolares.Checked = Nothing
        tdiae.Text = Nothing
        tmese.Text = Nothing
        tañoe.Text = Nothing
        tdiav.Text = Nothing
        tmesv.Text = Nothing
        tañov.Text = Nothing
        rbchekenormal.Checked = Nothing
        rbtransferencia.Checked = Nothing
        rbchequecertificado.Checked = Nothing
        rbgirobanc.Checked = Nothing
        tdepartamento.Text = Nothing
        tproveedor.Text = Nothing
        tcanletras.Text = Nothing
        tcargara.Text = Nothing
        tproyecto.Text = Nothing
        tobservaciones.Text = Nothing
        tformato.Text = Nothing
        dgvreg.Rows.Clear()
        dgvreg2.Rows.Clear()
        tdesc.Text = 0
        treten.Text = 0
    End Sub

    Private Sub dgvreg_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvreg.RowPostPaint
        Me.dgvreg.Rows(e.RowIndex).Cells(1).Value = (e.RowIndex + 1).ToString
    End Sub

    Private Sub dgvreg2_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvreg2.RowPostPaint
        Me.dgvreg2.Rows(e.RowIndex).Cells(1).Value = (e.RowIndex + 1).ToString
    End Sub

    Private Sub rblempiras_CheckedChanged(sender As Object, e As EventArgs) Handles rblempiras.CheckedChanged
        rbdolares.Enabled = False
        rblempiras.Enabled = True
        If rblempiras.Checked = Nothing Then
            rbdolares.Enabled = True
            bagregar.Enabled = False
            dgvreg.ClearSelection()
            Apagarcamposlaterales()
            apagarbotones()
        ElseIf rblempiras.Checked Then
            Encendercamposlaterales()
            encenderbotones()

            bagregar.Enabled = True
        End If
    End Sub

    Private Sub rbdolares_CheckedChanged(sender As Object, e As EventArgs) Handles rbdolares.CheckedChanged
        rbdolares.Enabled = True
        rblempiras.Enabled = False
        If rbdolares.Checked = Nothing Then
            rblempiras.Enabled = True
            bagregar.Enabled = False
            dgvreg.ClearSelection()
            Apagarcamposlaterales()
            apagarbotones()
        ElseIf rbdolares.Checked Then
            Encendercamposlaterales()
            encenderbotones()

            bagregar.Enabled = True
        End If
    End Sub

    Private Sub rbchekenormal_CheckedChanged(sender As Object, e As EventArgs) Handles rbchekenormal.CheckedChanged
        rbchequecertificado.Enabled = False
        rbtransferencia.Enabled = False
        rbgirobanc.Enabled = False
        rbchekenormal.Enabled = True
        If rbchekenormal.Checked = Nothing Then
            rbgirobanc.Enabled = True
            rbtransferencia.Enabled = True
            rbchequecertificado.Enabled = True
        End If
    End Sub

    Private Sub rbtransferencia_CheckedChanged(sender As Object, e As EventArgs) Handles rbtransferencia.CheckedChanged
        rbchequecertificado.Enabled = False
        rbchekenormal.Enabled = False
        rbgirobanc.Enabled = False
        rbtransferencia.Enabled = True
        If rbtransferencia.Checked = Nothing Then
            rbgirobanc.Enabled = True
            rbchekenormal.Enabled = True
            rbchequecertificado.Enabled = True
        End If
    End Sub

    Private Sub rbchequecertificado_CheckedChanged(sender As Object, e As EventArgs) Handles rbchequecertificado.CheckedChanged
        rbchekenormal.Enabled = False
        rbtransferencia.Enabled = False
        rbgirobanc.Enabled = False
        rbchequecertificado.Enabled = True
        If rbchequecertificado.Checked = Nothing Then
            rbgirobanc.Enabled = True
            rbtransferencia.Enabled = True
            rbchekenormal.Enabled = True
        End If
    End Sub
    Private Sub rbgirobanc_CheckedChanged(sender As Object, e As EventArgs) Handles rbgirobanc.CheckedChanged
        rbchequecertificado.Enabled = False
        rbtransferencia.Enabled = False
        rbchekenormal.Enabled = False
        rbgirobanc.Enabled = True
        If rbgirobanc.Checked = Nothing Then
            rbchekenormal.Enabled = True
            rbtransferencia.Enabled = True
            rbchequecertificado.Enabled = True
        End If
    End Sub
    Private Sub Apagarcamposlaterales()
        tdiae.Enabled = False
        tmese.Enabled = False
        tañoe.Enabled = False
        tdiav.Enabled = False
        tmesv.Enabled = False
        tañov.Enabled = False
        rbchekenormal.Enabled = False
        rbtransferencia.Enabled = False
        rbchequecertificado.Enabled = False
        rbgirobanc.Enabled = False
        tdepartamento.Enabled = False
        tproveedor.Enabled = False
        tcanletras.Enabled = False
        tcargara.Enabled = False
        tproyecto.Enabled = False
        tobservaciones.Enabled = False
    End Sub
    Private Sub Encendercamposlaterales()
        tdiae.Enabled = True
        tmese.Enabled = True
        tañoe.Enabled = True
        tdiav.Enabled = True
        tmesv.Enabled = True
        tañov.Enabled = True
        rbchekenormal.Enabled = True
        rbtransferencia.Enabled = True
        rbchequecertificado.Enabled = True
        rbgirobanc.Enabled = True
        tdepartamento.Enabled = True
        tproveedor.Enabled = True
        tcanletras.Enabled = True
        tcargara.Enabled = True
        tproyecto.Enabled = True
        tobservaciones.Enabled = True
    End Sub
    Private Sub encenderbotones()
        beliminar.Enabled = True
        bimprimir.Enabled = True
        breiniciar.Enabled = True
    End Sub
    Private Sub apagarbotones()
        beliminar.Enabled = False
        bimprimir.Enabled = False
        breiniciar.Enabled = False
    End Sub
    Private Sub breiniciar_Click(sender As Object, e As EventArgs) Handles breiniciar.Click
        limpiar()
        tsolicitadopor.Text = FrmPrincipal.lnombres.Text
        mensaje.Text = Nothing
    End Sub
    Private Sub beliminar_Click(sender As Object, e As EventArgs) Handles beliminar.Click
        If tnorden.Text = Nothing Then
            mensaje.Text = "Dejo vacio el numero de orden"
            tnorden.Focus()
            Exit Sub
        End If

        If MsgBox("Borrar la Solicitud de pago?", MsgBoxStyle.YesNo, "SERINTER") = MsgBoxResult.Yes Then
            Try
                sql = "Delete from ordenes where num_orden='" & tnorden.Text & "'"
                Conexion.Open()
                Comando = New SqlCommand(sql, Conexion)
                Comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        Conexion.Close()
        limpiar()
        tnorden.Focus()
    End Sub
    Private Sub bregresar_Click(sender As Object, e As EventArgs) Handles bregresar.Click
        FrmPrincipal.Show()
        Me.Hide()
        If FrmPrincipal.lrol.Text = "Administracion" Then
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

        ElseIf FrmPrincipal.lrol.Text = "Administrador" Then
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

        ElseIf FrmPrincipal.lrol.Text = "Dueño" Then
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

        ElseIf FrmPrincipal.lrol.Text = "Asistente SR" Then
            FrmPrincipal.busuario.Enabled = False
            FrmPrincipal.bproveedor.Enabled = False
            FrmPrincipal.bgastosmaq.Enabled = True
            FrmPrincipal.binventariado.Enabled = True
            FrmPrincipal.bfechasret1.Enabled = True
            FrmPrincipal.bhojasalida.Enabled = True
            FrmPrincipal.bpaseentrada.Enabled = True
            FrmPrincipal.bmaquinariareg.Enabled = True
            FrmPrincipal.bsolicitudes.Enabled = True
            FrmPrincipal.bordenes.Enabled = True

        ElseIf FrmPrincipal.lrol.Text = "Compras" Then
            FrmPrincipal.busuario.Enabled = False
            FrmPrincipal.bproveedor.Enabled = True
            FrmPrincipal.bgastosmaq.Enabled = True
            FrmPrincipal.binventariado.Enabled = True
            FrmPrincipal.bfechasret1.Enabled = True
            FrmPrincipal.bhojasalida.Enabled = True
            FrmPrincipal.bpaseentrada.Enabled = True
            FrmPrincipal.bmaquinariareg.Enabled = True
            FrmPrincipal.bsolicitudes.Enabled = True
            FrmPrincipal.bordenes.Enabled = True

        ElseIf FrmPrincipal.lrol.Text = "Gestor de Proyectos" Then
            FrmPrincipal.busuario.Enabled = True
            FrmPrincipal.bproveedor.Enabled = True
            FrmPrincipal.bgastosmaq.Enabled = True
            FrmPrincipal.binventariado.Enabled = True
            FrmPrincipal.bfechasret1.Enabled = True
            FrmPrincipal.bhojasalida.Enabled = True
            FrmPrincipal.bpaseentrada.Enabled = True
            FrmPrincipal.bmaquinariareg.Enabled = True
            FrmPrincipal.bsolicitudes.Enabled = True
            FrmPrincipal.bordenes.Enabled = True

        ElseIf FrmPrincipal.lrol.Text = "Bodeguero SR" Then
            FrmPrincipal.busuario.Enabled = False
            FrmPrincipal.bproveedor.Enabled = False
            FrmPrincipal.bgastosmaq.Enabled = True
            FrmPrincipal.binventariado.Enabled = True
            FrmPrincipal.bfechasret1.Enabled = True
            FrmPrincipal.bhojasalida.Enabled = True
            FrmPrincipal.bpaseentrada.Enabled = True
            FrmPrincipal.bmaquinariareg.Enabled = True
            FrmPrincipal.bsolicitudes.Enabled = True
            FrmPrincipal.bordenes.Enabled = True

        ElseIf FrmPrincipal.lrol.Text = "Taller Mecanico" Then
            FrmPrincipal.busuario.Enabled = False
            FrmPrincipal.bproveedor.Enabled = False
            FrmPrincipal.bgastosmaq.Enabled = True
            FrmPrincipal.binventariado.Enabled = True
            FrmPrincipal.bfechasret1.Enabled = True
            FrmPrincipal.bhojasalida.Enabled = True
            FrmPrincipal.bpaseentrada.Enabled = True
            FrmPrincipal.bmaquinariareg.Enabled = True
            FrmPrincipal.bsolicitudes.Enabled = True
            FrmPrincipal.bordenes.Enabled = True

        ElseIf FrmPrincipal.lrol.Text = "Contabilidad" Then
            FrmPrincipal.busuario.Enabled = False
            FrmPrincipal.bproveedor.Enabled = False
            FrmPrincipal.bgastosmaq.Enabled = True
            FrmPrincipal.binventariado.Enabled = True
            FrmPrincipal.bfechasret1.Enabled = True
            FrmPrincipal.bhojasalida.Enabled = True
            FrmPrincipal.bpaseentrada.Enabled = True
            FrmPrincipal.bmaquinariareg.Enabled = True
            FrmPrincipal.bsolicitudes.Enabled = True
            FrmPrincipal.bordenes.Enabled = True
        End If
    End Sub
    Private Sub bagrsol_Click(sender As Object, e As EventArgs) Handles bagrsol.Click

        Dim nombrea As String
        Dim itema As String
        Dim cantidad As String
        Dim idenv As String
        Dim unidad1 As String
        Dim preunit As Decimal
        Dim pretotal As Decimal

        Dim Valor2 As String
        Valor2 = Me.ddescripcion.Text
        Dim existe2 As Boolean = Me.dgvreg.Rows.Cast(Of DataGridViewRow).Any(Function(x) CStr(x.Cells("descripcion").Value) = Valor2)

        sql = "select * from Ordenes where num_orden='" & tnorden.Text & "'"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "Ordenes")
            resultado = almacen.Tables("Ordenes").Rows.Count

            If resultado = 0 Then

                If ddescripcion.Text = Nothing Then
                    mensaje.Text = "Agregue una Descripción"
                    Conexion.Close()
                    Exit Sub
                ElseIf dcantidad.Text = Nothing Then
                    mensaje.Text = "Agregue una valor numerico"
                    Conexion.Close()
                    Exit Sub
                End If

                mensaje.Text = "Mensajes"
                idenv = dgvreg.Rows.Count.ToString
                itema = dgvreg.Rows.Count.ToString
                cantidad = dcantidad.Value
                unidad1 = dunidad.Text
                nombrea = ddescripcion.Text
                preunit = dprec_unit.Text
                pretotal = dcantidad.Value * dprec_unit.Text
                dgvreg.Rows.Add(idenv, itema, cantidad, unidad1, nombrea, preunit, pretotal)
                Conexion.Close()

                dcantidad.Value = 0
                dunidad.Text = Nothing
                ddescripcion.Text = Nothing
                dprec_unit.Text = Nothing

            ElseIf resultado > 0 Then
                dgvreg.ClearSelection()
                If dcantidad.Text = Nothing Then
                    mensaje.Text = "Agregue una valor numerico"
                    Conexion.Close()
                    Exit Sub
                End If
                mensaje.Text = "Mensajes"
                idenv = dgvreg2.Rows.Count.ToString
                itema = dgvreg2.Rows.Count.ToString
                cantidad = dcantidad.Value
                unidad1 = dunidad.Text
                nombrea = ddescripcion.Text
                preunit = dprec_unit.Text
                pretotal = dcantidad.Value * dprec_unit.Text
                dgvreg2.Rows.Add(idenv, itema, cantidad, unidad1, nombrea, preunit, pretotal)
                Conexion.Close()
                dcantidad.Value = 0
                dunidad.Text = Nothing
                ddescripcion.Text = Nothing
                dprec_unit.Text = Nothing


            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Conexion.Close()
    End Sub
    Private Sub bagregar_Click(sender As Object, e As EventArgs) Handles bagregar.Click

        Dim tipomoneda As String
        Dim tipotransc As String
        If rblempiras.Checked = True Then
            tipomoneda = "Lempiras"
        ElseIf rbdolares.Checked = True Then
            tipomoneda = "Dolares"
        Else
            mensaje.Text = "Seleccione el Tipo de Moneda"
        End If
        If rbchekenormal.Checked = True Then
            tipotransc = "Cheque Normal"
        ElseIf rbtransferencia.Checked = True Then
            tipotransc = "Transferencia"
        ElseIf rbchequecertificado.Checked = True Then
            tipotransc = "Cheque Certificado"
        ElseIf rbgirobanc.Checked = True Then
            tipotransc = "Giro Bancario"
        End If

        If cestadpase.Text = "" Then
            Psext = "Activo"
        ElseIf cestadpase.Text = "Inactivo" Then
            Psext = "Inactivo"
        ElseIf cestadpase.Text = "Activo" Then
            Psext = "Activo"
        End If


        If tnorden.Text = Nothing Then
            mensaje.Text = "Dejo vacia la orden"
            tnorden.Focus()
            Exit Sub
        ElseIf tdepartamento.Text = Nothing Then
            mensaje.Text = "Dejo vacio el departamento"
            tdepartamento.Focus()
            Exit Sub
        ElseIf tproveedor.Text = Nothing Then
            mensaje.Text = "Dejo vacio el proveedor del campo paguese"
            tproveedor.Focus()
            Exit Sub
        ElseIf tcanletras.Text = Nothing Then
            mensaje.Text = "Dejo vacio la cantidad en Letras"
            tcanletras.Focus()
            Exit Sub
        ElseIf tcargara.Text = Nothing Then
            mensaje.Text = "Dejo vacio el campo de cargara"
            tcargara.Focus()
            Exit Sub
        ElseIf tproyecto.Text = Nothing Then
            mensaje.Text = "Dejo vacio el campo de proyecto"
            tproyecto.Focus()
            Exit Sub
        ElseIf tobservaciones.Text = Nothing Then
            mensaje.Text = "Dejo vacio la Observacion"
            tproyecto.Focus()
            Exit Sub
        ElseIf tdiae.Text = Nothing Then
            mensaje.Text = "Dejo vacio el dia de emision"
            tdiae.Focus()
            Exit Sub
        ElseIf tmese.Text = Nothing Then
            mensaje.Text = "Dejo vacio el mes de emision"
            tmese.Focus()
            Exit Sub
        ElseIf tañoe.Text = Nothing Then
            mensaje.Text = "Dejo vacio el año de emision"
            tañoe.Focus()
            Exit Sub
        ElseIf tdiav.Text = Nothing Then
            mensaje.Text = "Dejo vacio el dia de vencimiento"
            tdiav.Focus()
            Exit Sub
        ElseIf tmesv.Text = Nothing Then
            mensaje.Text = "Dejo vacio el mes de vencimiento"
            tmesv.Focus()
            Exit Sub
        ElseIf tañov.Text = Nothing Then
            mensaje.Text = "Dejo vacio el año de vencimiento"
            tañov.Focus()
            Exit Sub
        End If
        sql = "select * from ordenes where num_orden='" & tnorden.Text & "'"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "ordenes")
            resultado = almacen.Tables("ordenes").Rows.Count
            If resultado > 0 Then
                Conexion.Close()
                Dim result As DialogResult
                result = MessageBox.Show("Desea Agregar Nuevos Registros?", "Actualizado!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then

                    Dim fechaactual As DateTime

                    For Each Row As DataGridViewRow In dgvreg2.Rows


                        Dim id2 As String = Row.Cells("id2").Value
                        Dim cantidad2 As String = Row.Cells("cantidad2").Value
                        Dim unidad2 As String = Row.Cells("unidad2").Value
                        Dim descripcion2 As String = Row.Cells("descripcion2").Value
                        Dim precunit2 As String = Row.Cells("precio_unit2").Value

                        adaptar.InsertCommand = New SqlCommand("Insert into ordenes (num_orden, cantidad, unidad, descripcion, precio_unit, tipomoneda, tipotransaccion, solicitado_por, departamento, nom_proveedor, can_letras, cargar, proyecto, observaciones, dia, mes, año, dia2, mes2, año2, descuento, men_retencion, foto, fecha_hora, estado_ord) values ('" & tnorden.Text & "', '" & cantidad2 & "', '" & unidad2 & "', '" & descripcion2 & "', '" & precunit2 & "', '" & tipomoneda & "', '" & tipotransc & "', '" & tsolicitadopor.Text & "', '" & tdepartamento.Text & "', '" & tproveedor.Text & "', '" & tcanletras.Text & "', '" & tcargara.Text & "', '" & tproyecto.Text & "', '" & tobservaciones.Text & "', '" & tdiae.Text & "', '" & tmese.Text & "', '" & tañoe.Text & "', '" & tdiav.Text & "', '" & tmesv.Text & "', '" & tañov.Text & "', '" & tdesc.Text & "', '" & treten.Text & "', '" & fechaactual & "', '" & Psext & "')", Conexion)
                        Conexion.Open()
                        adaptar.InsertCommand.ExecuteNonQuery()
                        Conexion.Close()
                    Next

                    adaptar.UpdateCommand = New SqlCommand("update ordenes set tipomoneda='" & tipomoneda & "',tipotransaccion='" & tipotransc & "',solicitado_por='" & tsolicitadopor.Text & "',departamento='" & tdepartamento.Text & "',nom_proveedor='" & tproveedor.Text & "',can_letras='" & tcanletras.Text & "',cargar='" & tcargara.Text & "',proyecto='" & tproyecto.Text & "',observaciones='" & tobservaciones.Text & "',dia='" & tdiae.Text & "',mes='" & tmese.Text & "',año='" & tañoe.Text & "',dia2='" & tdiav.Text & "',mes2='" & tmesv.Text & "',año2='" & tañov.Text & "',descuento='" & tdesc.Text & "',men_retencion='" & treten.Text & "',fecha_hora='" & fechaactual & "' where num_orden='" & tnorden.Text & "'", Conexion)
                    Conexion.Open()
                    adaptar.UpdateCommand.ExecuteNonQuery()
                    Conexion.Close()

                    For Each Row As DataGridViewRow In dgvreg.Rows

                        Dim id3 As String = Row.Cells("id").Value
                        Dim cantidad3 As String = Row.Cells("cantidad").Value
                        Dim unidad3 As String = Row.Cells("unidad").Value
                        Dim descripcion3 As String = Row.Cells("descripcion").Value
                        Dim precunit3 As String = Row.Cells("precio_unit").Value

                        adaptar.UpdateCommand = New SqlCommand("update ordenes set cantidad='" & cantidad3 & "',unidad='" & unidad3 & "',descripcion='" & descripcion3 & "',precio_unit='" & precunit3 & "',fecha_hora='" & fechaactual & "' where num_orden='" & tnorden.Text & "'and id='" & id3 & "'", Conexion)
                        Conexion.Open()
                        adaptar.UpdateCommand.ExecuteNonQuery()
                        Conexion.Close()
                    Next

                    MessageBox.Show("Actualizado Exitosamente")

                    limpiar()

                ElseIf result = DialogResult.No Then

                    dgvreg2.Rows.Clear()

                End If
            End If

            If resultado = 0 Then
                Conexion.Close()
                Dim result2 As DialogResult
                result2 = MessageBox.Show("Desea Guardar?", "Guardar!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result2 = DialogResult.Yes Then

                    Dim fechaactual As DateTime

                    For Each Row As DataGridViewRow In dgvreg.Rows

                        Dim id As String = Row.Cells("id").Value
                        Dim cantidad As String = Row.Cells("cantidad").Value
                        Dim unidad As String = Row.Cells("unidad").Value
                        Dim descripcion As String = Row.Cells("descripcion").Value
                        Dim precunit As String = Row.Cells("precio_unit").Value

                        adaptar.InsertCommand = New SqlCommand("Insert into ordenes (num_orden, cantidad, unidad, descripcion, precio_unit, tipomoneda, tipotransaccion, solicitado_por, departamento, nom_proveedor, can_letras, cargar, proyecto, observaciones, dia, mes, año, dia2, mes2, año2, descuento, men_retencion, fecha_hora) values ('" & tnorden.Text & "', '" & cantidad & "', '" & unidad & "', '" & descripcion & "', '" & precunit & "', '" & tipomoneda & "', '" & tipotransc & "', '" & tsolicitadopor.Text & "', '" & tdepartamento.Text & "', '" & tproveedor.Text & "', '" & tcanletras.Text & "', '" & tcargara.Text & "', '" & tproyecto.Text & "', '" & tobservaciones.Text & "', '" & tdiae.Text & "', '" & tmese.Text & "', '" & tañoe.Text & "', '" & tdiav.Text & "', '" & tmesv.Text & "', '" & tañov.Text & "', '" & tdesc.Text & "', '" & treten.Text & "', '" & fechaactual & "')", Conexion)
                        Conexion.Open()
                        adaptar.InsertCommand.ExecuteNonQuery()
                        Conexion.Close()
                    Next

                    MessageBox.Show("Guardado Exitosamente")
                    limpiar()
                ElseIf result2 = DialogResult.No Then
                    dgvreg.Rows.Clear()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        limpiar()
        Conexion.Close()
        tnorden.Focus()
    End Sub
    Private Sub tdepartamento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tdepartamento.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tproveedor.Focus()
        End If
    End Sub
    Private Sub tproveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tproveedor.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tcanletras.Focus()
        End If
    End Sub
    Private Sub tcanletras_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tcanletras.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tcargara.Focus()
        End If
    End Sub
    Private Sub tcargara_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tcargara.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tproyecto.Focus()
        End If
    End Sub
    Private Sub tproyecto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tproyecto.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tobservaciones.Focus()
        End If
    End Sub
    Private Sub tobservaciones_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tobservaciones.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            dcantidad.Focus()
        End If
    End Sub
    Private Sub dcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dcantidad.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            dunidad.Focus()
        End If
    End Sub

    Private Sub dunidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dunidad.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            ddescripcion.Focus()
        End If
    End Sub

    Private Sub ddescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ddescripcion.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            dprec_unit.Focus()
        End If
    End Sub

    Private Sub dprec_unit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dprec_unit.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            bagrsol.Focus()
        End If
    End Sub

    Private Sub beliminarreg_Click(sender As Object, e As EventArgs) Handles beliminarreg.Click

        For Each Row As DataGridViewRow In dgvreg.SelectedRows

            Dim id As String = Row.Cells("id").Value
            Dim item As String = Row.Cells("cantidad").Value
            Dim unidad As String = Row.Cells("unidad").Value
            Dim descripcion As String = Row.Cells("descripcion").Value
            Dim precunit As String = Row.Cells("precio_unit").Value

            adaptar.DeleteCommand = New SqlCommand("delete from ordenes where num_orden='" & tnorden.Text & "' and descripcion='" & descripcion & "' and unidad='" & unidad & "' and id='" & id & "'", Conexion)
            Conexion.Open()
            adaptar.DeleteCommand.ExecuteNonQuery()
            Conexion.Close()
            dgvreg.Rows.Remove(Row)

        Next

    End Sub

    Private Sub dgvreg_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvreg.CellValueChanged

        For Each row As DataGridViewRow In dgvreg.Rows

            Dim total As Double = Convert.ToDecimal(row.Cells(2).Value) * Convert.ToDecimal(row.Cells(5).Value)

            row.Cells("importe").Value = Format(CType(total, Decimal), "#,###.00")

        Next

        Dim sumTotal = 0

        For Each row As DataGridViewRow In dgvreg.Rows
            sumTotal += Convert.ToDecimal(row.Cells("importe").Value)
        Next

        Subtotalx = sumTotal

        If rblempiras.Checked = True Then

            lblsub.Text = Format(CType(sumTotal, Decimal), "L #,###.00")

        ElseIf rbdolares.Checked = True Then

            lblsub.Text = Format(CType(sumTotal, Decimal), "$ #,###.00")

        End If

    End Sub
    Private Sub dgvreg2_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvreg2.CellValueChanged

        For Each row As DataGridViewRow In dgvreg2.Rows

            Dim total As Double = Convert.ToDouble(row.Cells(2).Value) * Convert.ToDouble(row.Cells(5).Value)

            row.Cells("importe2").Value = total
        Next

    End Sub
    Private Sub tdesc_TextChanged(sender As Object, e As EventArgs) Handles tdesc.TextChanged

        Dim lblisvtotal As Decimal
        Dim TotalTotales As Decimal
        Isvx = Subtotalx * 0.15
        Descx = tdesc.Text
        Retenem = treten.Text

        On Error Resume Next

        If rblempiras.Checked = True Then
            lblmenrete.Text = Format(CType(Isvx, Decimal), "L #,###.00")
            lbldesc.Text = Format(CType(Descx, Decimal), "L #,###.00")

            lblisvtotal = Subtotalx * 0.15
            lblisv.Text = Format(CType(lblisvtotal, Decimal), "L #,###.00")

            TotalTotales = Subtotalx - Descx - Retenem + Isvx
            lbltotal.Text = Format(CType(TotalTotales, Decimal), "L #,###.00")

        ElseIf rbdolares.Checked = True Then
            lblmenrete.Text = Format(CType(Retenem, Decimal), "$ #,###.00")
            lbldesc.Text = Format(CType(Descx, Decimal), "$ #,###.00")

            lblisvtotal = Subtotalx * 0.15
            lblisv.Text = Format(CType(lblisvtotal, Decimal), "$ #,###.00")

            TotalTotales = Subtotalx - Descx - Retenem + Isvx
            lbltotal.Text = Format(CType(TotalTotales, Decimal), "$ #,###.00")
        End If
    End Sub
    Private Sub treten_TextChanged(sender As Object, e As EventArgs) Handles treten.TextChanged

        Dim lblisvtotal As Decimal
        Dim TotalTotales As Decimal

        Isvx = Subtotalx * 0.15
        Descx = tdesc.Text
        Retenem = treten.Text

        On Error Resume Next

        If rblempiras.Checked = True Then

            lblmenrete.Text = Format(CType(Isvx, Decimal), "L #,###.00")
            lbldesc.Text = Format(CType(Descx, Decimal), "L #,###.00")

            lblisvtotal = Subtotalx * 0.15
            lblisv.Text = Format(CType(lblisvtotal, Decimal), "L #,###.00")

            TotalTotales = Subtotalx - Descx - Retenem + Isvx
            lbltotal.Text = Format(CType(TotalTotales, Decimal), "L #,###.00")

        ElseIf rbdolares.Checked = True Then
            lblmenrete.Text = Format(CType(Retenem, Decimal), "$ #,###.00")
            lbldesc.Text = Format(CType(Descx, Decimal), "$ #,###.00")

            lblisvtotal = Subtotalx * 0.15
            lblisv.Text = Format(CType(lblisvtotal, Decimal), "$ #,###.00")

            TotalTotales = Subtotalx - Descx - Retenem + Isvx
            lbltotal.Text = Format(CType(TotalTotales, Decimal), "$ #,###.00")
        End If
    End Sub
    Private Sub lblsub_TextChanged(sender As Object, e As EventArgs) Handles lblsub.TextChanged

        Dim lblisvtotal As Decimal
        Dim TotalTotales As Decimal

        Isvx = Subtotalx * 0.15
        Descx = tdesc.Text
        Retenem = treten.Text

        On Error Resume Next

        If rblempiras.Checked = True Then
            lblmenrete.Text = Format(CType(Isvx, Decimal), "L #,###.00")
            lbldesc.Text = Format(CType(Descx, Decimal), "L #,###.00")

            lblisvtotal = Subtotalx * 0.15
            lblisv.Text = Format(CType(lblisvtotal, Decimal), "L #,###.00")

            TotalTotales = Subtotalx - Descx - Retenem + Isvx
            lbltotal.Text = Format(CType(TotalTotales, Decimal), "L #,###.00")

        ElseIf rbdolares.Checked = True Then

            lblmenrete.Text = Format(CType(Retenem, Decimal), "$ #,###.00")
            lbldesc.Text = Format(CType(Descx, Decimal), "$ #,###.00")

            lblisvtotal = Subtotalx * 0.15
            lblisv.Text = Format(CType(lblisvtotal, Decimal), "$ #,###.00")

            TotalTotales = Subtotalx - Descx - Retenem + Isvx
            lbltotal.Text = Format(CType(TotalTotales, Decimal), "$ #,###.00")
        End If
    End Sub
    Private Sub tdesc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tdesc.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
            If Asc(e.KeyChar) = 46 Then
                e.Handled = False
            End If
        End If
    End Sub
    Private Sub treten_KeyPress(sender As Object, e As KeyPressEventArgs) Handles treten.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
            If Asc(e.KeyChar) = 46 Then
                e.Handled = False
            End If
        End If
    End Sub
End Class