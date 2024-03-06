Imports System.Data.SqlClient
Imports System.Data
Imports System.Runtime.InteropServices
Public Class FrmOrdendeCompraXm
    Dim Subtotalx As String
    Dim Retenem As String
    Dim Isvx As String
    Dim Descx As String
    Dim TotalTotales As String
    Dim Psext As String
    Private Sub FrmOrdendeCompraXm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion = New SqlConnection
        Conexion.ConnectionString = cadena
        Dim da As New SqlDataAdapter("Select * from proveedores", Conexion)
        Dim dt As New DataTable
        da.Fill(dt)
        tproveedor.DataSource = dt
        tproveedor.DisplayMember = "nom_proveedor"
        tproveedor.ValueMember = "cod_proveedor"

        tnorden.Text = FrmPrincipal.valornumSolcompra

    End Sub
    Private Sub tnorden_Validated(sender As Object, e As EventArgs) Handles tnorden.Validated
        limpiarparcial()
        If tnorden.Text = Nothing Then
            mensaje.Text = "Dejo vacio el numero de orden"
            tnorden.Focus()
            Exit Sub
        End If
        sql = "select * from ordenes_compra where num_orden='" & tnorden.Text & "'"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "ordenes_compra")
            resultado = almacen.Tables("ordenes_compra").Rows.Count
            If almacen.Tables(0).Rows.Count <> 0 Then
                For j As Integer = 0 To almacen.Tables(0).Rows.Count - 1 Step +1
                    dgvreg.Rows.Add(almacen.Tables(0).Rows(j)("id").ToString(), "", almacen.Tables(0).Rows(j)("cantidad").ToString(), almacen.Tables(0).Rows(j)("unidad").ToString(), almacen.Tables(0).Rows(j)("descripcion").ToString(), almacen.Tables(0).Rows(j)("precio_unit").ToString())
                Next
            End If
            If resultado > 0 Then
                registro = almacen.Tables("ordenes_compra").Rows(0)
                If Not IsDBNull(registro("tipomoneda")) Then
                    If registro("tipomoneda") = "Lempiras" Then
                        rblempiras.Checked = True
                    ElseIf registro("tipomoneda") = "Dolares" Then
                        rbdolares.Checked = True
                    End If
                    'If Not IsDBNull(registro("solicitado_por")) Then
                    '    tsolicitadopor.Text = registro("solicitado_por")
                    'End If
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
                    If Not IsDBNull(registro("descuento")) Then
                        tdesc.Text = registro("descuento")
                    End If
                    If Not IsDBNull(registro("men_retencion")) Then
                        treten.Text = registro("men_retencion")
                    End If
                End If

                breiniciar.Enabled = True

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
    Private Sub tnorden_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tnorden.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tnorden_Validated(sender, e)
        End If
    End Sub
    Private Sub dgvreg_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvreg.RowPostPaint
        Me.dgvreg.Rows(e.RowIndex).Cells(1).Value = (e.RowIndex + 1).ToString
    End Sub
    Private Sub dgvreg2_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvreg2.RowPostPaint
        Me.dgvreg2.Rows(e.RowIndex).Cells(1).Value = (e.RowIndex + 1).ToString
    End Sub
    Private Sub bregresar_Click(sender As Object, e As EventArgs) Handles bregresar.Click
        Me.Hide()
        FrmPrincipal.EstatusSolicitudes()
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

    Private Sub breiniciar_Click(sender As Object, e As EventArgs) Handles breiniciar.Click
        limpiar()
        breiniciar.Enabled = False
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
            lbltotal.Text = Format(CType(TotalTotales, Decimal), "L #,##0.00")

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
            lbltotal.Text = Format(CType(TotalTotales, Decimal), "L #,##0.00")

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
            lbltotal.Text = Format(CType(TotalTotales, Decimal), "L #,##0.00")

        ElseIf rbdolares.Checked = True Then

            lblmenrete.Text = Format(CType(Retenem, Decimal), "$ #,###.00")
            lbldesc.Text = Format(CType(Descx, Decimal), "$ #,###.00")

            lblisvtotal = Subtotalx * 0.15
            lblisv.Text = Format(CType(lblisvtotal, Decimal), "$ #,###.00")

            TotalTotales = Subtotalx - Descx - Retenem + Isvx
            lbltotal.Text = Format(CType(TotalTotales, Decimal), "$ #,###.00")

        End If

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
            mensaje.Text = "Dejo vacio el año de remision"
            tañoe.Focus()
            Exit Sub
        End If
        sql = "select * from ordenes_compra where num_orden='" & tnorden.Text & "'"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "ordenes_compra")
            resultado = almacen.Tables("ordenes_compra").Rows.Count

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
                        Dim precunit2 As String = Row.Cells("prec_unt2").Value

                        adaptar.InsertCommand = New SqlCommand("Insert into ordenes_compra (num_orden, cantidad, unidad, descripcion, precio_unit, tipomoneda, departamento, nom_proveedor, can_letras, cargar, proyecto, observaciones, fecha1, fecha2, descuento, men_retencion, fecha_hora, estado_ord) values ('" & tnorden.Text & "', '" & cantidad2 & "', '" & unidad2 & "', '" & descripcion2 & "', '" & precunit2 & "', '" & tipomoneda & "', '" & tdepartamento.Text & "', '" & tproveedor.Text & "', '" & tcanletras.Text & "', '" & tcargara.Text & "', '" & tproyecto.Text & "', '" & tobservaciones.Text & "', '" & Fecha1.Text & "', '" & Fecha2.Text & "', '" & tdesc.Text & "', '" & treten.Text & "', '" & fechaactual & "', '" & Psext & "')", Conexion)
                        Conexion.Open()
                        adaptar.InsertCommand.ExecuteNonQuery()
                        Conexion.Close()

                    Next

                    adaptar.UpdateCommand = New SqlCommand("update ordenes_compra set tipomoneda='" & tipomoneda & "',departamento='" & tdepartamento.Text & "',nom_proveedor='" & tproveedor.Text & "',can_letras='" & tcanletras.Text & "',cargar='" & tcargara.Text & "',proyecto='" & tproyecto.Text & "',observaciones='" & tobservaciones.Text & "',fecha1='" & Fecha1.Text & "',fecha2='" & Fecha2.Text & "',año='" & tañoe.Text & "',descuento='" & tdesc.Text & "',men_retencion='" & treten.Text & "',fecha_hora='" & fechaactual & "' where num_orden='" & tnorden.Text & "'", Conexion)
                    Conexion.Open()
                    adaptar.UpdateCommand.ExecuteNonQuery()
                    Conexion.Close()

                    For Each Row As DataGridViewRow In dgvreg.Rows

                        Dim id3 As String = Row.Cells("id").Value
                        Dim cantidad3 As String = Row.Cells("cantidad").Value
                        Dim unidad3 As String = Row.Cells("unidad").Value
                        Dim descripcion3 As String = Row.Cells("descripcion").Value
                        Dim precunit3 As String = Row.Cells("precio_unit").Value

                        adaptar.UpdateCommand = New SqlCommand("update ordenes_compra set cantidad='" & cantidad3 & "',unidad='" & unidad3 & "',descripcion='" & descripcion3 & "',precio_unit='" & precunit3 & "',fecha_hora='" & fechaactual & "' where num_orden='" & tnorden.Text & "'and id='" & id3 & "'", Conexion)
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

                        adaptar.InsertCommand = New SqlCommand("Insert into ordenes_compra (num_orden, cantidad, unidad, descripcion, precio_unit, tipomoneda, departamento, nom_proveedor, can_letras, cargar, proyecto, observaciones, fecha1, fecha2, descuento, men_retencion, fecha_hora, estado_ord) values ('" & tnorden.Text & "', '" & cantidad & "', '" & unidad & "', '" & descripcion & "', '" & precunit & "', '" & tipomoneda & "', '" & tdepartamento.Text & "', '" & tproveedor.Text & "', '" & tcanletras.Text & "', '" & tcargara.Text & "', '" & tproyecto.Text & "', '" & tobservaciones.Text & "', '" & Fecha1.Text & "', '" & Fecha2.Text & "', '" & tdesc.Text & "', '" & treten.Text & "', '" & fechaactual & "', '" & Psext & "')", Conexion)
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

    Private Sub Apagarcamposlaterales()
        tdiae.Enabled = False
        tmese.Enabled = False
        tañoe.Enabled = False
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
        bformenv.Enabled = True
    End Sub

    Private Sub apagarbotones()
        beliminar.Enabled = False
        bimprimir.Enabled = False
        breiniciar.Enabled = False
        bformenv.Enabled = False
    End Sub

    Private Sub bimprimir_Click(sender As Object, e As EventArgs) Handles bimprimir.Click
        ' frmimprimirordencompraxm.show()
    End Sub

    Private Sub bformenv_Click(sender As Object, e As EventArgs) Handles bformenv.Click
        FrmEstatusSolcitudes.Show()
    End Sub

    Private Sub dgvreg2_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvreg2.CellValueChanged
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '   For i As Integer = 1 To dgvreg2.Rows.Count - 1

        'For j As Integer = i - 1 To 0 Step -1
        ' If dgvreg2.Rows(i).Cells(4).Value.ToString = dgvreg2.Rows(j).Cells(4).Value.ToString Then
        'dgvreg2.Rows(i).Visible = False

        '   End If
        'Next

        'Next
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''




        For Each row As DataGridViewRow In dgvreg2.Rows
            Dim total As Double = Convert.ToDecimal(row.Cells(2).Value) * Convert.ToDecimal(row.Cells(5).Value)

            row.Cells("importe2").Value = Format(CType(total, Decimal), "#,###.00")

        Next

        Dim sumTotal = 0

        For Each row As DataGridViewRow In dgvreg2.Rows
            sumTotal += Convert.ToDecimal(row.Cells("importe2").Value)
        Next

        Subtotalx = sumTotal

        If rblempiras.Checked = True Then

            lblsub.Text = Format(CType(sumTotal, Decimal), "L #,###.00")

        ElseIf rbdolares.Checked = True Then

            lblsub.Text = Format(CType(sumTotal, Decimal), "$ #,###.00")

        End If

    End Sub
    Private Sub beliminar_Click(sender As Object, e As EventArgs) Handles beliminar.Click
        If tnorden.Text = Nothing Then
            mensaje.Text = "Dejo vacio el Numero de Orden"
            tnorden.Focus()
            Exit Sub
        End If

        If MsgBox("Borrar la Orden de Compra?", MsgBoxStyle.YesNo, "Sistema de SERINTER") = MsgBoxResult.Yes Then
            Try
                sql = "delete from ordenes_compra where num_orden='" & tnorden.Text & "'"
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

    Private Sub tdepartamento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tdepartamento.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tproveedor.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub tproveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tproveedor.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tcanletras.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub tcanletras_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tcanletras.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tcargara.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub tcargara_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tcargara.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tproyecto.Focus()
            mensaje.Text = "Mensajes"

        End If
    End Sub

    Private Sub tproyecto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tproyecto.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tobservaciones.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub tobservaciones_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tobservaciones.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            bagregar.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub
End Class