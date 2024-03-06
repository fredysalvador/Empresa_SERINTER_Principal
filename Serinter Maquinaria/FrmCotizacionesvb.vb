Imports System.Data.SqlClient
Imports System.Data
Imports System.Runtime.InteropServices
Public Class FrmCotizacionesvb

    Dim vall1 As Integer
    Dim Subtotalx As String
    Dim Retenem As String
    Dim Isvx As String
    Dim Descx As String
    Dim TotalTotales As String
    Dim Psext As String

    Private Sub FrmCotizacionesvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion = New SqlConnection
        Conexion.ConnectionString = cadena
        adaptar = New SqlDataAdapter(sql, Conexion)
        Me.Timer2.Enabled = True
        If FrmPrincipal.lrol.Text = "Administrador" Then
            beliminar.Enabled = True
            beliminarreg.Enabled = True
        ElseIf FrmPrincipal.lrol.Text = "Administracion" Then
            beliminar.Enabled = True
            beliminarreg.Enabled = True
        ElseIf FrmPrincipal.lrol.Text = "Dueño" Then
            beliminar.Enabled = True
            beliminarreg.Enabled = True
        Else
            beliminar.Enabled = False
            beliminarreg.Enabled = False
        End If
        vall1 = 0
        Timer3.Enabled = True
        Timer3.Interval = 1000
    End Sub
    Private Sub limpiar()
        tcotno.Text = Nothing
        limpiarparcial()
    End Sub
    Private Sub limpiarparcial()

        dgvreg.Rows.Clear()
        dgvreg2.Rows.Clear()
        trtn.Text = Nothing
        tcliente.Text = Nothing
        tcontacto.Text = Nothing
        tdireccion.Text = Nothing
        tciudad.Text = Nothing
        tterminopag.Text = Nothing
        dtpfecha.Text = Nothing
        tdescripcion.Text = Nothing
        tcantidad.Value = 0
        tpreciounit.Text = Nothing
        tdesc.Text = 0
        tflete.Text = 0
        tobservacion.Text = Nothing
        lblsub.Text = 0
        lbldesc.Text = 0
        lblisv.Text = 0
        lblmenrete.Text = 0
        lbltotal.Text = 0

    End Sub
    Private Sub bagrlista2_Click(sender As Object, e As EventArgs) Handles bagrlista2.Click

        Dim nombre As String
        Dim id1 As String
        Dim item As String
        Dim cantidad As String
        Dim valors As String

        Dim Valor As String
        Valor = Me.tdescripcion.Text
        Dim existe As Boolean = Me.dgvreg.Rows.Cast(Of DataGridViewRow).Any(Function(x) CStr(x.Cells("Descripcion").Value) = Valor)

        sql = "select * from cotizacion where no_cotizacion='" & tcotno.Text & "'"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "no_cotizacion")
            resultado = almacen.Tables("no_cotizacion").Rows.Count


            If resultado = 0 Then

                If tdescripcion.Text = Nothing Then
                    mensaje.Text = "Agregue la descricion"
                    Conexion.Close()
                    Exit Sub

                ElseIf tcantidad.Text = Nothing Then
                    mensaje.Text = "Agregue la cantidad"
                    Conexion.Close()
                    Exit Sub

                ElseIf tpreciounit.Text = Nothing Then
                    mensaje.Text = "Agregue el precio de la unidad"
                    Conexion.Close()
                    Exit Sub
                End If

                mensaje.Text = "Mensajes"
                id1 = dgvreg.Rows.Count.ToString
                item = dgvreg.Rows.Count.ToString
                cantidad = tcantidad.Text
                nombre = tdescripcion.Text
                valors = tpreciounit.Text
                dgvreg.Rows.Add(id1, item, cantidad, nombre, valors)
                Conexion.Close()

                tdescripcion.Text = Nothing
                tcantidad.Text = Nothing
                tpreciounit.Text = Nothing

            ElseIf resultado > 0 Then

                dgvreg.ClearSelection()
                If tdescripcion.Text = Nothing Then
                    mensaje.Text = "Agregue la descricion"
                    Conexion.Close()
                    Exit Sub

                ElseIf tcantidad.Text = Nothing Then
                    mensaje.Text = "Agregue la cantidad"
                    Conexion.Close()
                    Exit Sub

                ElseIf tpreciounit.Text = Nothing Then
                    mensaje.Text = "Agregue el precio de la unidad"
                    Conexion.Close()
                    Exit Sub
                End If

                mensaje.Text = "Mensajes"
                id1 = dgvreg.Rows.Count.ToString
                item = dgvreg.Rows.Count.ToString
                cantidad = tcantidad.Text
                nombre = tdescripcion.Text
                valors = tpreciounit.Text

                dgvreg2.Rows.Add(id1, item, cantidad, nombre, valors)
                Conexion.Close()

                tdescripcion.Text = Nothing
                tcantidad.Text = Nothing
                tpreciounit.Text = Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Conexion.Close()

    End Sub
    Private Sub dgvreg_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvreg.RowPostPaint
        Me.dgvreg.Rows(e.RowIndex).Cells(1).Value = (e.RowIndex + 1).ToString
    End Sub
    Private Sub dgvreg2_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvreg2.RowPostPaint
        Me.dgvreg2.Rows(e.RowIndex).Cells(1).Value = (e.RowIndex + 1).ToString
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.fechahora.Text = Now
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        sql = "select * from cotizacion where no_cotizacion='" & tcotno.Text & "'"
        Try
            '   Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "cotizacion")
            resultado = almacen.Tables("cotizacion").Rows.Count
            If almacen.Tables(0).Rows.Count <> 0 Then
                For j As Integer = 0 To almacen.Tables(0).Rows.Count - 1 Step +1
                    dgvreg.Rows.Add(almacen.Tables(0).Rows(j)("id").ToString(), "", almacen.Tables(0).Rows(j)("cantidad").ToString(), almacen.Tables(0).Rows(j)("descripcion").ToString(), almacen.Tables(0).Rows(j)("precio_unitario").ToString(), almacen.Tables(0).Rows(j)("total_preciounit").ToString())
                Next
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Conexion.Close()
        Timer1.Enabled = False
    End Sub


    Private Sub bagregar_Click(sender As Object, e As EventArgs) Handles bagregar.Click

        Dim tipomoneda As String

        If rblempiras.Checked = True Then
            tipomoneda = "Lempiras"
        ElseIf rbdolares.Checked = True Then
            tipomoneda = "Dolares"
        Else
            mensaje.Text = "Seleccione el Tipo de Moneda"
        End If

        If tcotno.Text = Nothing Then
            mensaje.Text = "Dejo vacio el numero de cotización"
            tcotno.Focus()
            Exit Sub
        End If

        sql = "select * from cotizacion where no_cotizacion='" & tcotno.Text & "'"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "cotizacion")
            resultado = almacen.Tables("cotizacion").Rows.Count
            If resultado > 0 Then
                Conexion.Close()
                Dim result As DialogResult
                result = MessageBox.Show("Desea Agregar Nuevos Registros?", "Actualizado!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then

                    For Each Row As DataGridViewRow In dgvreg2.Rows

                        Dim unidad2 As String = Row.Cells("Unidad2").Value
                        Dim descripcionds2 As String = Row.Cells("Descripcion2").Value
                        Dim valords2 As Decimal = Row.Cells("Valor2").Value
                        Dim valorT2 As Decimal = Row.Cells("ValorT2").Value

                        adaptar.InsertCommand = New SqlCommand("Insert into cotizacion (no_cotizacion, tipomoneda, rtn, cliente, contacto, direccion, ciudad, termino_pago, cantidad, descripcion, precio_unitario, total_preciounit, descuento, flete, observacion, fecha) values ('" & tcotno.Text & "', '" & tipomoneda & "', '" & trtn.Text & "', '" & tcliente.Text & "', '" & tcontacto.Text & "', '" & tdireccion.Text & "', '" & tciudad.Text & "', '" & tterminopag.Text & "', '" & unidad2 & "', '" & descripcionds2 & "', '" & valords2 & "', '" & valorT2 & "', '" & tdesc.Text & "', '" & tflete.Text & "', '" & tobservacion.Text & "', '" & dtpfecha.Text & "')", Conexion)
                        Conexion.Open()
                        adaptar.InsertCommand.ExecuteNonQuery()
                        Conexion.Close()
                    Next

                    adaptar.UpdateCommand = New SqlCommand("update cotizacion set rtn='" & trtn.Text & "',tipomoneda='" & tipomoneda & "',cliente='" & tcliente.Text & "',contacto='" & tcontacto.Text & "',direccion='" & tdireccion.Text & "',termino_pago='" & tterminopag.Text & "',descuento='" & tdesc.Text & "',flete='" & tflete.Text & "',observacion='" & tobservacion.Text & "',fecha='" & dtpfecha.Value & "' where no_cotizacion='" & tcotno.Text & "'", Conexion)
                    Conexion.Open()
                    adaptar.UpdateCommand.ExecuteNonQuery()
                    Conexion.Close()

                    For Each Row As DataGridViewRow In dgvreg.Rows

                        Dim id3 As String = Row.Cells("ID1").Value
                        Dim unidad3 As String = Row.Cells("Unidad").Value
                        Dim descripcionds3 As String = Row.Cells("Descripcion").Value
                        Dim valords3 As Decimal = Row.Cells("Valor").Value
                        Dim valorT3 As Decimal = Row.Cells("ValorT").Value

                        adaptar.UpdateCommand = New SqlCommand("update cotizacion set cantidad='" & unidad3 & "',descripcion='" & descripcionds3 & "',precio_unitario='" & valords3 & "',total_preciounit='" & valorT3 & "' where no_cotizacion='" & tcotno.Text & "'and id='" & id3 & "'", Conexion)
                        Conexion.Open()
                        adaptar.UpdateCommand.ExecuteNonQuery()
                        Conexion.Close()

                    Next

                    MessageBox.Show("Actualizado Exitosamente")
                    limpiar()
                    dgvreg2.Rows.Clear()
                    dgvreg.Rows.Clear()
                    tcotno.Enabled = True

                ElseIf result = DialogResult.No Then

                End If
            End If

            If resultado = 0 Then
                Conexion.Close()
                Dim result2 As DialogResult
                result2 = MessageBox.Show("Desea Guardar?", "Guardar!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result2 = DialogResult.Yes Then

                    For Each Row As DataGridViewRow In dgvreg.Rows

                        Dim unidad As String = Row.Cells("Unidad").Value
                        Dim descripcionds As String = Row.Cells("Descripcion").Value
                        Dim valords As Decimal = Row.Cells("Valor").Value
                        Dim valorT1 As Decimal = Row.Cells("ValorT").Value


                        adaptar.InsertCommand = New SqlCommand("Insert into cotizacion (no_cotizacion, tipomoneda, rtn, cliente, contacto, direccion, ciudad, termino_pago, cantidad, descripcion, precio_unitario, total_preciounit, descuento, flete, observacion, fecha) values ('" & tcotno.Text & "', '" & tipomoneda & "', '" & trtn.Text & "', '" & tcliente.Text & "', '" & tcontacto.Text & "', '" & tdireccion.Text & "', '" & tciudad.Text & "', '" & tterminopag.Text & "', '" & unidad & "', '" & descripcionds & "', '" & valords & "', '" & valorT1 & "', '" & tdesc.Text & "', '" & tflete.Text & "', '" & tobservacion.Text & "', '" & dtpfecha.Text & "')", Conexion)
                        Conexion.Open()
                        adaptar.InsertCommand.ExecuteNonQuery()
                        Conexion.Close()
                    Next

                    MessageBox.Show("Guardado Exitosamente")
                    limpiar()
                    dgvreg2.Rows.Clear()
                    dgvreg.Rows.Clear()
                    tcotno.Enabled = True

                ElseIf result2 = DialogResult.No Then

                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        limpiar()
        Conexion.Close()
        tcotno.Focus()
    End Sub

    Private Sub beliminarreg_Click(sender As Object, e As EventArgs) Handles beliminarreg.Click

        For Each Row As DataGridViewRow In dgvreg.SelectedRows

            Dim id1 As String = Row.Cells("ID1").Value
            Dim unidad As String = Row.Cells("Unidad").Value
            Dim descripcionds As String = Row.Cells("Descripcion").Value
            Dim valords As String = Row.Cells("Valor").Value

            adaptar.DeleteCommand = New SqlCommand("delete from cotizacion where no_cotizacion='" & tcotno.Text & "' and id='" & id1 & "' and descripcion='" & descripcionds & "' and cantidad='" & unidad & "'", Conexion)
            Conexion.Open()
            adaptar.DeleteCommand.ExecuteNonQuery()
            Conexion.Close()
            dgvreg.Rows.Remove(Row)
        Next

        For Each Row As DataGridViewRow In dgvreg2.SelectedRows
            dgvreg2.Rows.Remove(Row)
        Next



        '''''''''''''''''''''''''''''''''''''''''''
        Dim sumTotal = 0

        For Each row As DataGridViewRow In dgvreg.Rows
            sumTotal += Convert.ToDecimal(row.Cells("ValorT").Value)
        Next


        Dim sumTotal2 = 0

        For Each row As DataGridViewRow In dgvreg2.Rows

            sumTotal2 += Convert.ToDecimal(row.Cells("valorT2").Value)

        Next
        '''''''''''''''''''''''''''''''''''''''''''''''''''

        Subtotalx = sumTotal + sumTotal2


        Dim lblisvtotal As Decimal
        Dim TotalTotales As Decimal

        Isvx = Subtotalx * 0.15
        Descx = tdesc.Text
        Retenem = tflete.Text

        On Error Resume Next

        If rblempiras.Checked = True Then

            lblmenrete.Text = Format(CType(Retenem, Decimal), "L #,###.00")
            lbldesc.Text = Format(CType(Descx, Decimal), "L #,###.00")

            lblisvtotal = Subtotalx * 0.15
            lblisv.Text = Format(CType(lblisvtotal, Decimal), "L #,###.00")

            TotalTotales = Subtotalx - Descx - Retenem + Isvx
            lbltotal.Text = Format(CType(TotalTotales, Decimal), "L #,##0.00")

            lblsub.Text = Format(CType(Subtotalx, Decimal), "L #,###.00")

        ElseIf rbdolares.Checked = True Then

            lblmenrete.Text = Format(CType(Retenem, Decimal), "$ #,###.00")
            lbldesc.Text = Format(CType(Descx, Decimal), "$ #,###.00")

            lblisvtotal = 0
            lblisv.Text = Format(CType(lblisvtotal, Decimal), "$ #,###.00")

            TotalTotales = Subtotalx - Descx - Retenem + 0
            lbltotal.Text = Format(CType(TotalTotales, Decimal), "$ #,###.00")

            lblsub.Text = Format(CType(Subtotalx, Decimal), "$ #,###.00")

        End If


    End Sub

    Private Sub beliminar_Click(sender As Object, e As EventArgs) Handles beliminar.Click
        If tcotno.Text = Nothing Then
            mensaje.Text = "Dejo vacio el Codigo de Cotizacion"
            tcotno.Focus()
            Exit Sub
        End If

        If MsgBox("Borrar la Cotización?", MsgBoxStyle.YesNo, "Sistema de SERINTER") = MsgBoxResult.Yes Then
            Try
                sql = "delete from  cotizacion where no_cotizacion='" & tcotno.Text & "'"
                Conexion.Open()
                Comando = New SqlCommand(sql, Conexion)
                Comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        Conexion.Close()
        limpiar()
        tcotno.Focus()
    End Sub

    Private Sub breiniciar_Click(sender As Object, e As EventArgs) Handles breiniciar.Click
        limpiar()
        rblempiras.Checked = False
        rbdolares.Checked = False
        rblempiras.Enabled = False
        rbdolares.Enabled = False
        tcotno.Enabled = True
        chknvregistro.Checked = False
        chknvregistro.Enabled = True
        mensaje.Text = ""
    End Sub

    Private Sub tcotno_Validated(sender As Object, e As EventArgs) Handles tcotno.Validated
        If tcotno.Text = Nothing Then
            mensaje.Text = "Dejo vacio el numero de cotización"
            tcotno.Focus()
            Exit Sub
        End If
        dgvreg.Rows.Clear()
        sql = "select * from cotizacion where no_cotizacion='" & tcotno.Text & "'"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "cotizacion")
            resultado = almacen.Tables("cotizacion").Rows.Count
            If almacen.Tables(0).Rows.Count <> 0 Then
                For j As Integer = 0 To almacen.Tables(0).Rows.Count - 1 Step +1
                    dgvreg.Rows.Add(almacen.Tables(0).Rows(j)("id").ToString(), "", almacen.Tables(0).Rows(j)("cantidad").ToString(), almacen.Tables(0).Rows(j)("descripcion").ToString(), almacen.Tables(0).Rows(j)("precio_unitario").ToString(), almacen.Tables(0).Rows(j)("total_preciounit").ToString())
                Next
            End If
            If resultado > 0 Then
                registro = almacen.Tables("cotizacion").Rows(0)

                If Not IsDBNull(registro("tipomoneda")) Then
                    If registro("tipomoneda") = "Lempiras" Then
                        rblempiras.Checked = True
                    ElseIf registro("tipomoneda") = "Dolares" Then
                        rbdolares.Checked = True
                    End If

                    If Not IsDBNull(registro("rtn")) Then
                        trtn.Text = registro("rtn")
                    End If

                    If Not IsDBNull(registro("cliente")) Then
                        tcliente.Text = registro("cliente")
                    End If

                    If Not IsDBNull(registro("contacto")) Then
                        tcontacto.Text = registro("contacto")
                    End If

                    If Not IsDBNull(registro("direccion")) Then
                        tdireccion.Text = registro("direccion")
                    End If

                    If Not IsDBNull(registro("ciudad")) Then
                        tciudad.Text = registro("ciudad")
                    End If

                    If Not IsDBNull(registro("termino_pago")) Then
                        tterminopag.Text = registro("termino_pago")
                    End If

                    If Not IsDBNull(registro("descuento")) Then
                        tdesc.Text = registro("descuento")
                    End If

                    If Not IsDBNull(registro("observacion")) Then
                        tobservacion.Text = registro("observacion")
                    End If

                    If Not IsDBNull(registro("fecha")) Then
                        dtpfecha.Value = registro("fecha")
                    End If

                    If Not IsDBNull(registro("flete")) Then
                        tflete.Text = registro("flete")
                    End If
                End If


            ElseIf resultado = 0 Then
                rblempiras.Enabled = True
                rbdolares.Enabled = True
                beliminar.Enabled = False
                beliminarreg.Enabled = True

                limpiarparcial()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Conexion.Close()

    End Sub

    Private Sub tcotno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tcotno.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tcotno_Validated(sender, e)
            mensaje.Text = "Mensajes"
            tcotno.Enabled = False
        End If
    End Sub

    Private Sub bimprimir_Click(sender As Object, e As EventArgs) Handles bimprimir.Click
        If rbdolares.Checked = True Then
            FrmCotizacionesImprDL1.tcotno.Text = Me.tcotno.Text
            FrmCotizacionesImprDL1.ShowDialog()
        ElseIf rblempiras.Checked = True Then
            FrmCotizacionesImprHNL2.tcotno.Text = Me.tcotno.Text
            FrmCotizacionesImprHNL2.ShowDialog()
        End If
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



        '''''''''''''''''''''''''''''''''''''''''''
        Dim sumTotal = 0

        For Each row As DataGridViewRow In dgvreg.Rows

            sumTotal += Convert.ToDecimal(row.Cells("ValorT").Value)

        Next


        Dim sumTotal2 = 0

        For Each row As DataGridViewRow In dgvreg2.Rows

            sumTotal2 += Convert.ToDecimal(row.Cells("valorT2").Value)

        Next
        '''''''''''''''''''''''''''''''''''''''''''''''''''

        Subtotalx = sumTotal + sumTotal2


        Dim lblisvtotal As Decimal
        Dim TotalTotales As Decimal

        Isvx = Subtotalx * 0.15
        Descx = tdesc.Text
        Retenem = tflete.Text

        On Error Resume Next

        If rblempiras.Checked = True Then

            lblmenrete.Text = Format(CType(Retenem, Decimal), "L #,###.00")
            lbldesc.Text = Format(CType(Descx, Decimal), "L #,###.00")

            lblisvtotal = Subtotalx * 0.15
            lblisv.Text = Format(CType(lblisvtotal, Decimal), "L #,###.00")

            TotalTotales = Subtotalx - Descx - Retenem + Isvx
            lbltotal.Text = Format(CType(TotalTotales, Decimal), "L #,##0.00")

            lblsub.Text = Format(CType(Subtotalx, Decimal), "L #,###.00")

        ElseIf rbdolares.Checked = True Then

            lblmenrete.Text = Format(CType(Retenem, Decimal), "$ #,###.00")
            lbldesc.Text = Format(CType(Descx, Decimal), "$ #,###.00")

            lblisvtotal = 0
            lblisv.Text = Format(CType(lblisvtotal, Decimal), "$ #,###.00")

            TotalTotales = Subtotalx - Descx - Retenem + 0
            lbltotal.Text = Format(CType(TotalTotales, Decimal), "$ #,###.00")

            lblsub.Text = Format(CType(Subtotalx, Decimal), "$ #,###.00")

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



        '''''''''''''''''''''''''''''''''''''''''''
        Dim sumTotal = 0

        For Each row As DataGridViewRow In dgvreg.Rows

            sumTotal += Convert.ToDecimal(row.Cells("ValorT").Value)

        Next


        Dim sumTotal2 = 0

        For Each row As DataGridViewRow In dgvreg2.Rows

            sumTotal2 += Convert.ToDecimal(row.Cells("valorT2").Value)

        Next
        '''''''''''''''''''''''''''''''''''''''''''''''''''

        Subtotalx = sumTotal + sumTotal2


        Dim lblisvtotal As Decimal
        Dim TotalTotales As Decimal

        Isvx = Subtotalx * 0.15
        Descx = tdesc.Text
        Retenem = tflete.Text

        On Error Resume Next

        If rblempiras.Checked = True Then

            lblmenrete.Text = Format(CType(Retenem, Decimal), "L #,###.00")
            lbldesc.Text = Format(CType(Descx, Decimal), "L #,###.00")

            lblisvtotal = Subtotalx * 0.15
            lblisv.Text = Format(CType(lblisvtotal, Decimal), "L #,###.00")

            TotalTotales = Subtotalx - Descx - Retenem + Isvx
            lbltotal.Text = Format(CType(TotalTotales, Decimal), "L #,##0.00")

            lblsub.Text = Format(CType(Subtotalx, Decimal), "L #,###.00")

        ElseIf rbdolares.Checked = True Then

            lblmenrete.Text = Format(CType(Retenem, Decimal), "$ #,###.00")
            lbldesc.Text = Format(CType(Descx, Decimal), "$ #,###.00")

            lblisvtotal = 0
            lblisv.Text = Format(CType(lblisvtotal, Decimal), "$ #,###.00")

            TotalTotales = Subtotalx - Descx - Retenem + 0
            lbltotal.Text = Format(CType(TotalTotales, Decimal), "$ #,###.00")

            lblsub.Text = Format(CType(Subtotalx, Decimal), "$ #,###.00")


        End If
    End Sub

    Private Sub Apagarcamposlaterales()
        dtpfecha.Enabled = False
        tcliente.Enabled = False
        tcontacto.Enabled = False
        tdireccion.Enabled = False
        tciudad.Enabled = False
        tterminopag.Enabled = False
        tobservacion.Enabled = False
        trtn.Enabled = False
    End Sub

    Private Sub Encendercamposlaterales()
        dtpfecha.Enabled = True
        tcliente.Enabled = True
        tcontacto.Enabled = True
        tdireccion.Enabled = True
        tciudad.Enabled = True
        tterminopag.Enabled = True
        tobservacion.Enabled = True
        trtn.Enabled = True
    End Sub

    Private Sub encenderbotones()
        beliminarreg.Enabled = True
        beliminar.Enabled = True
        bimprimir.Enabled = True
        breiniciar.Enabled = True
    End Sub

    Private Sub apagarbotones()
        beliminarreg.Enabled = False
        beliminar.Enabled = False
        bimprimir.Enabled = False
        breiniciar.Enabled = False
    End Sub

    Private Sub dgvreg_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvreg.CellValueChanged

        For Each row As DataGridViewRow In dgvreg.Rows

            Dim total As Double = Convert.ToDecimal(row.Cells(2).Value) * Convert.ToDecimal(row.Cells(4).Value)

            row.Cells("ValorT").Value = Format(CType(total, Decimal), "#,###.00")

        Next

        '''''''''''''''''''''''''''''''''''''''''''
        Dim sumTotal = 0

        For Each row As DataGridViewRow In dgvreg.Rows
            sumTotal += Convert.ToDecimal(row.Cells("ValorT").Value)
        Next


        Dim sumTotal2 = 0

        For Each row As DataGridViewRow In dgvreg2.Rows

            sumTotal2 += Convert.ToDecimal(row.Cells("valorT2").Value)

        Next
        '''''''''''''''''''''''''''''''''''''''''''''''''''

        Subtotalx = sumTotal + sumTotal2

        If rblempiras.Checked = True Then

            lblsub.Text = Format(CType(Subtotalx, Decimal), "L #,###.00")

        ElseIf rbdolares.Checked = True Then

            lblsub.Text = Format(CType(Subtotalx, Decimal), "$ #,###.00")

        End If
    End Sub

    Private Sub dgvreg2_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvreg2.CellValueChanged

        For Each row As DataGridViewRow In dgvreg2.Rows

            Dim total As Double = Convert.ToDecimal(row.Cells(2).Value) * Convert.ToDecimal(row.Cells(4).Value)

            row.Cells("valorT2").Value = Format(CType(total, Decimal), "#,###.00")

        Next


        '''''''''''''''''''''''''''''''''''''''''''
        Dim sumTotal = 0

        For Each row As DataGridViewRow In dgvreg.Rows
            sumTotal += Convert.ToDecimal(row.Cells("ValorT").Value)
        Next


        Dim sumTotal2 = 0

        For Each row As DataGridViewRow In dgvreg2.Rows

            sumTotal2 += Convert.ToDecimal(row.Cells("valorT2").Value)

        Next
        '''''''''''''''''''''''''''''''''''''''''''''''''''

        Subtotalx = sumTotal + sumTotal2

        If rblempiras.Checked = True Then

            lblsub.Text = Format(CType(Subtotalx, Decimal), "L #,###.00")

        ElseIf rbdolares.Checked = True Then

            lblsub.Text = Format(CType(Subtotalx, Decimal), "$ #,###.00")

        End If

    End Sub

    Private Sub lblsub_TextChanged(sender As Object, e As EventArgs) Handles lblsub.TextChanged

        Dim lblisvtotal As Decimal
        Dim TotalTotales As Decimal

        Isvx = Subtotalx * 0.15
        Descx = tdesc.Text
        Retenem = tflete.Text

        On Error Resume Next

        If rblempiras.Checked = True Then

            lblmenrete.Text = Format(CType(Retenem, Decimal), "L #,###.00")
            lbldesc.Text = Format(CType(Descx, Decimal), "L #,###.00")

            lblisvtotal = Subtotalx * 0.15
            lblisv.Text = Format(CType(lblisvtotal, Decimal), "L #,###.00")

            TotalTotales = Subtotalx - Descx - Retenem + Isvx
            lbltotal.Text = Format(CType(TotalTotales, Decimal), "L #,##0.00")

        ElseIf rbdolares.Checked = True Then

            lblmenrete.Text = Format(CType(Retenem, Decimal), "$ #,###.00")
            lbldesc.Text = Format(CType(Descx, Decimal), "$ #,###.00")

            lblisvtotal = 0
            lblisv.Text = Format(CType(lblisvtotal, Decimal), "$ #,###.00")

            TotalTotales = Subtotalx - Descx - Retenem + 0
            lbltotal.Text = Format(CType(TotalTotales, Decimal), "$ #,###.00")

        End If
    End Sub

    Private Sub tdesc_TextChanged(sender As Object, e As EventArgs) Handles tdesc.TextChanged
        Dim lblisvtotal As Decimal
        Dim TotalTotales As Decimal

        Isvx = Subtotalx * 0.15
        Descx = tdesc.Text
        Retenem = tflete.Text

        On Error Resume Next

        If rblempiras.Checked = True Then

            lblmenrete.Text = Format(CType(Retenem, Decimal), "L #,###.00")
            lbldesc.Text = Format(CType(Descx, Decimal), "L #,###.00")

            lblisvtotal = Subtotalx * 0.15
            lblisv.Text = Format(CType(lblisvtotal, Decimal), "L #,###.00")

            TotalTotales = Subtotalx - Descx - Retenem + Isvx
            lbltotal.Text = Format(CType(TotalTotales, Decimal), "L #,##0.00")

        ElseIf rbdolares.Checked = True Then
            lblmenrete.Text = Format(CType(Retenem, Decimal), "$ #,###.00")
            lbldesc.Text = Format(CType(Descx, Decimal), "$ #,###.00")

            lblisvtotal = 0
            lblisv.Text = Format(CType(lblisvtotal, Decimal), "$ #,###.00")

            TotalTotales = Subtotalx - Descx - Retenem + 0
            lbltotal.Text = Format(CType(TotalTotales, Decimal), "$ #,###.00")
        End If


        If tdesc.Text = Nothing Then
            tdesc.Text = 0
        Else
        End If

    End Sub

    Private Sub tflete_TextChanged(sender As Object, e As EventArgs) Handles tflete.TextChanged

        Dim lblisvtotal As Decimal
        Dim TotalTotales As Decimal

        Isvx = Subtotalx * 0.15
        Descx = tdesc.Text
        Retenem = tflete.Text

        On Error Resume Next

        If rblempiras.Checked = True Then

            lblmenrete.Text = Format(CType(Retenem, Decimal), "L #,###.00")
            lbldesc.Text = Format(CType(Descx, Decimal), "L #,###.00")

            lblisvtotal = Subtotalx * 0.15
            lblisv.Text = Format(CType(lblisvtotal, Decimal), "L #,###.00")

            TotalTotales = Subtotalx - Descx - Retenem + Isvx
            lbltotal.Text = Format(CType(TotalTotales, Decimal), "L #,##0.00")

        ElseIf rbdolares.Checked = True Then

            lblmenrete.Text = Format(CType(Retenem, Decimal), "$ #,###.00")
            lbldesc.Text = Format(CType(Descx, Decimal), "$ #,###.00")

            lblisvtotal = 0
            lblisv.Text = Format(CType(lblisvtotal, Decimal), "$ #,###.00")

            TotalTotales = Subtotalx - Descx - Retenem + 0
            lbltotal.Text = Format(CType(TotalTotales, Decimal), "$ #,###.00")

        End If

        If tflete.Text = Nothing Then
            tflete.Text = 0
        Else
        End If

    End Sub

    Private Sub tdescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tdescripcion.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tcantidad.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub tcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tcantidad.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tpreciounit.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub tpreciounit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tpreciounit.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            bagrlista2.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub tcliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tcliente.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tcontacto.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub tcontacto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tcontacto.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tdireccion.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub tdireccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tdireccion.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tciudad.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub tciudad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tciudad.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tterminopag.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub
    Private Sub trtn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles trtn.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            dtpfecha.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub dtpfecha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtpfecha.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tobservacion.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub tterminopag_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tterminopag.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            trtn.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub chknvregistro_CheckedChanged(sender As Object, e As EventArgs) Handles chknvregistro.CheckedChanged

        If chknvregistro.Checked = True Then

            Conexion.Open()
            Dim cmd As New SqlCommand("Valormaximo_Cotizacion", Conexion)
            cmd.CommandType = CommandType.StoredProcedure

            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            Dim dt As New DataTable
            dt.Clear()
            da.Fill(dt)

            Dim row As DataRow = dt.Rows(0)
            tcotno.Text = "CT" & Convert.ToString(row("max_num"))
            Conexion.Close()
            chknvregistro.Enabled = False
            tcotno.Enabled = False
            tcotno_Validated(sender, e)

        ElseIf chknvregistro.Checked = False Then

        End If

    End Sub

    Private Sub tcliente_TextChanged(sender As Object, e As EventArgs) Handles tcliente.TextChanged
        tcliente.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tcliente.Text)
        tcliente.SelectionStart = tcliente.Text.Length
    End Sub

    Private Sub tcontacto_TextChanged(sender As Object, e As EventArgs) Handles tcontacto.TextChanged
    End Sub

    Private Sub tdireccion_TextChanged(sender As Object, e As EventArgs) Handles tdireccion.TextChanged
        tdireccion.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tdireccion.Text)
        tdireccion.SelectionStart = tdireccion.Text.Length
    End Sub

    Private Sub tciudad_TextChanged(sender As Object, e As EventArgs) Handles tciudad.TextChanged
        tciudad.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tciudad.Text)
        tciudad.SelectionStart = tciudad.Text.Length
    End Sub

    Private Sub tterminopag_TextChanged(sender As Object, e As EventArgs) Handles tterminopag.TextChanged
        tterminopag.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tterminopag.Text)
        tterminopag.SelectionStart = tterminopag.Text.Length
    End Sub
End Class