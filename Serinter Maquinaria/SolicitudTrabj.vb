Imports System.Data.SqlClient
Imports System.Data
Imports System.Runtime.InteropServices
Public Class SolicitudTrabj
    Dim Vehiculoext As String
    Dim Psext As String
    Private Sub SolicitudTrabj_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion = New SqlConnection
        Conexion.ConnectionString = cadena
        adaptar = New SqlDataAdapter(sql, Conexion)
    End Sub
    Private Sub bagregadogeneral_Click(sender As Object, e As EventArgs) Handles bagregadogeneral.Click
        Dim nombrea As String
        Dim itema As String
        Dim cantidad As String
        Dim idenv As String
        Dim und1 As String
        Dim nompart1 As String
        Dim codset1 As String

        Dim Valor2 As String
        Valor2 = Me.codigovh.Text
        Dim existe2 As Boolean = Me.dgvreg.Rows.Cast(Of DataGridViewRow).Any(Function(x) CStr(x.Cells("descripcion").Value) = Valor2)

        sql = "select * from solicitud_trab where no_solicitud='" & nosolicitud.Text & "'"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "solicitud_trab")
            resultado = almacen.Tables("solicitud_trab").Rows.Count

            If resultado = 0 Then
                If descp1env.Text = Nothing Then
                    mensaje.Text = "Agregue una Descripción"
                    Conexion.Close()
                    Exit Sub
                ElseIf num1un.Text = Nothing Then
                    mensaje.Text = "Agregue una valor numerico"
                    Conexion.Close()
                    Exit Sub
                End If
                mensaje.Text = "Mensajes"
                idenv = dgvreg.Rows.Count.ToString
                itema = dgvreg.Rows.Count.ToString
                cantidad = num1un.Text
                nombrea = descp1env.Text
                dgvreg.Rows.Add(idenv, itema, cantidad, und1, nompart1, codset1, nombrea)
                Conexion.Close()
                num1un.Text = 0
                descp1env.Text = Nothing

            ElseIf resultado > 0 Then
                dgvreg.ClearSelection()
                If descp1env.Text = Nothing Then
                    mensaje.Text = "Agregue el Valor de la Hora"
                    Conexion.Close()
                    Exit Sub
                ElseIf num1un.Text = Nothing Then
                    mensaje.Text = "Agregue una valor numerico"
                    Conexion.Close()
                    Exit Sub
                End If
                mensaje.Text = "Mensajes"
                idenv = dgvreg2.Rows.Count.ToString
                itema = dgvreg2.Rows.Count.ToString
                cantidad = num1un.Text
                nombrea = descp1env.Text
                nompart1 = tnompart.Text
                codset1 = tcodsert.Text
                dgvreg2.Rows.Add(idenv, itema, cantidad, und1, nompart1, codset1, nombrea)
                Conexion.Close()
                num1un.Text = 0
                descp1env.Text = Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Conexion.Close()
    End Sub
    Private Sub dgvreg_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvreg.RowPostPaint
        Me.dgvreg.Rows(e.RowIndex).Cells(1).Value = (e.RowIndex + 1).ToString
    End Sub

    Private Sub chknvregistro_CheckedChanged(sender As Object, e As EventArgs) Handles chknvregistro.CheckedChanged

        If chknvregistro.Checked = True Then
            Conexion.Open()
            Dim cmd As New SqlCommand("Valormaximo_SolicitudTrb", Conexion)

            cmd.CommandType = CommandType.StoredProcedure

            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            Dim dt As New DataTable
            dt.Clear()
            da.Fill(dt)

            Dim row As DataRow = dt.Rows(0)
            nosolicitud.Text = Convert.ToString(row("valmax"))
            Conexion.Close()
            chknvregistro.Enabled = False
            nosolicitud.Enabled = False
            nosolicitud_Validated(sender, e)

        ElseIf chknvregistro.Checked = False Then

        End If

    End Sub

    Private Sub nosolicitud_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nosolicitud.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            nosolicitud_Validated(sender, e)
            mensaje.Text = "Mensajes"
            nosolicitud.Enabled = False
        End If
    End Sub

    Private Sub nosolicitud_Validated(sender As Object, e As EventArgs) Handles nosolicitud.Validated
        'almacen.Tables(0).Rows(j)("item").ToString(),
        If nosolicitud.Text = Nothing Then
            mensaje.Text = "Dejo vacio el numero de salida"
            nosolicitud.Focus()
            Exit Sub
        End If
        '  limpiar()
        dgvreg.Rows.Clear()
        dgvvehiculos.Visible = False
        sql = "select * from solicitud_trab where no_solicitud='" & nosolicitud.Text & "'"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "solicitud_trab")
            resultado = almacen.Tables("solicitud_trab").Rows.Count
            If almacen.Tables(0).Rows.Count <> 0 Then
                For j As Integer = 0 To almacen.Tables(0).Rows.Count - 1 Step +1
                    dgvreg.Rows.Add(almacen.Tables(0).Rows(j)("id").ToString(), "", almacen.Tables(0).Rows(j)("cantidad").ToString(), almacen.Tables(0).Rows(j)("unidad").ToString(), almacen.Tables(0).Rows(j)("no_parte").ToString(), almacen.Tables(0).Rows(j)("cod_sert").ToString(), almacen.Tables(0).Rows(j)("descripcion").ToString(), almacen.Tables(0).Rows(j)("observacion").ToString())
                Next
            End If
            If resultado > 0 Then

                registro = almacen.Tables("solicitud_trab").Rows(0)
                If Not IsDBNull(registro("codigo_vh")) Then
                    codigovh.Text = registro("codigo_vh")
                End If

                If Not IsDBNull(registro("cod_veh")) Then
                    tcodsert.Text = registro("cod_veh")
                End If

                If Not IsDBNull(registro("categoria")) Then
                    categoria.Text = registro("categoria")
                End If

                If Not IsDBNull(registro("proyecto")) Then
                    tproyecto.Text = registro("proyecto")
                End If

                If Not IsDBNull(registro("estado_ficha")) Then
                    cestadpase.Text = registro("estado_ficha")
                End If
            End If

            If cestadpase.Text = "Inactivo" Then
                beliminarreg.Enabled = False
                bdatagridveh.Enabled = False
                beliminar.Enabled = False
                bimprimir.Enabled = True
            ElseIf cestadpase.Text = "Activo" Then
                beliminarreg.Enabled = True
                bdatagridveh.Enabled = True
                beliminar.Enabled = True
            End If

            chknvregistro.Enabled = False

            If resultado = 0 Then

                beliminar.Enabled = False
                beliminarreg.Enabled = True
                bdatagridveh.Enabled = True
                chknvregistro.Enabled = False
                limpiarparcial()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Conexion.Close()
        categoria.Focus()
    End Sub

    Private Sub limpiar()
        nosolicitud.Text = Nothing
        limpiarparcial()
    End Sub

    Private Sub limpiarparcial()
        codigovh.Text = Nothing
        categoria.Text = Nothing

    End Sub

    Private Sub breiniciar_Click(sender As Object, e As EventArgs) Handles breiniciar.Click
        limpiar()
    End Sub

    '    Private Sub bagregar_Click(sender As Object, e As EventArgs) Handles bagregar.Click

    '        If cestadpase.Text = "" Then
    '            Psext = "Activo"
    '        ElseIf cestadpase.Text = "Inactivo" Then
    '            Psext = "Inactivo"
    '        ElseIf cestadpase.Text = "Activo" Then
    '            Psext = "Activo"
    '        End If

    '        If nosolicitud.Text = Nothing Then
    '            mensaje.Text = "Dejo vacio el numero de solicitud"
    '            nosolicitud.Focus()
    '            Exit Sub
    '        ElseIf categoria.Text = Nothing Then
    '            mensaje.Text = "Dejo vacio la categoria del pase de salida"
    '            categoria.Focus()
    '            Exit Sub
    '        ElseIf codigovh.Text = Nothing Then
    '            mensaje.Text = "Dejo vacio el codigo del vehiculo"
    '            codigovh.Focus()
    '            Exit Sub
    '        ElseIf tproyecto.Text = Nothing Then
    '            mensaje.Text = "Dejo vacio el proyecto"
    '            tproyecto.Focus()
    '            Exit Sub
    '        End If
    '        sql = "select * from solicitud_trab where no_solicitud='" & nosolicitud.Text & "'"
    '        Try
    '            Conexion.Open()
    '            adaptar = New SqlDataAdapter(sql, Conexion)
    '            almacen = New DataSet
    '            adaptar.Fill(almacen, "solicitud_trab")
    '            resultado = almacen.Tables("solicitud_trab").Rows.Count
    '            If resultado > 0 Then
    '                Conexion.Close()
    '                Dim result As DialogResult
    '                result = MessageBox.Show("Desea Agregar Nuevos Registros?", "Actualizado!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

    '                If result = DialogResult.Yes Then

    '                    For Each Row As DataGridViewRow In dgvreg2.Rows

    '                        Dim item2 As String = Row.Cells("item2").Value
    '                        Dim unidad2 As String = Row.Cells("unidad2").Value
    '                        Dim descripcionds2 As String = Row.Cells("descripcion2").Value
    '                        Dim observacion2 As String = Row.Cells("observacion2").Value

    '                        adaptar.InsertCommand = New SqlCommand("Insert into salida_inventario (no_salida, item, unidad, descripcion, observacion, codigo_vh, estado_vh, vhexist, placa_vh, categoriaps, hrm1, hrm2, klm1, klm2, motorista, acompañante, destino, fecha_retorno, fecha_salida, estado_ficha) values ('" & nosalida.Text & "', '" & item2 & "', '" & unidad2 & "', '" & descripcionds2 & "', '" & observacion2 & "', '" & codigovh.Text & "', '" & estadovh.Text & "', '" & Vehiculoext & "', '" & placavh.Text & "', '" & categoria.Text & "', '" & hrm1.Text & "', '" & hrm2.Text & "', '" & km1.Text & "', '" & km2.Text & "', '" & tmorotris.Text & "', '" & tpartner.Text & "', '" & tdestiny.Text & "', '" & dtpretorno.Text & "', '" & dtpsalida.Text & "', '" & Psext & "')", Conexion)
    '                        Conexion.Open()
    '                        adaptar.InsertCommand.ExecuteNonQuery()
    '                        Conexion.Close()
    '                    Next


    '                    adaptar.UpdateCommand = New SqlCommand("update salida_inventario set codigo_vh='" & codigovh.Text & "',placa_vh='" & placavh.Text & "',estado_vh='" & estadovh.Text & "',categoriaps='" & categoria.Text & "',hrm1='" & hrm1.Text & "',hrm2='" & hrm2.Text & "',klm1='" & km1.Text & "',klm2='" & km2.Text & "',motorista='" & tmorotris.Text & "',acompañante='" & tpartner.Text & "',destino='" & tdestiny.Text & "',fecha_retorno='" & dtpretorno.Text & "',fecha_salida='" & dtpsalida.Text & "',vhexist='" & Vehiculoext & "',estado_ficha='" & Psext & "' where no_salida='" & nosalida.Text & "'", Conexion)
    '                    Conexion.Open()
    '                    adaptar.UpdateCommand.ExecuteNonQuery()
    '                    Conexion.Close()

    '                    For Each Row As DataGridViewRow In dgvreg.Rows
    '                        Dim id1 As String = Row.Cells("id1").Value
    '                        Dim item As String = Row.Cells("item").Value
    '                        Dim unidad As String = Row.Cells("unidad").Value
    '                        Dim descripcionds As String = Row.Cells("descripcion").Value
    '                        Dim observacion As String = Row.Cells("observacion").Value
    '                        adaptar.UpdateCommand = New SqlCommand("update salida_inventario set item='" & item & "',unidad='" & unidad & "',descripcion='" & descripcionds & "',observacion='" & observacion & "' where no_salida='" & nosalida.Text & "'and id='" & id1 & "'", Conexion)
    '                        Conexion.Open()
    '                        adaptar.UpdateCommand.ExecuteNonQuery()
    '                        Conexion.Close()
    '                    Next



    '                    MessageBox.Show("Actualizado Exitosamente")
    '                    limpiar()
    '                    chknvregistro.Enabled = True

    '                    chknvregistro.Checked = False

    '                ElseIf result = DialogResult.No Then

    '                    For j As Integer = 0 To dgvreg2.Rows.Count - 1 Step +1
    '                        Dim unidadobt As String
    '                        unidadobt = dgvreg2.Rows(j).Cells("unidad2").Value.ToString
    '                        adaptar.UpdateCommand = New SqlCommand("update inventario set stock= stock+'" & unidadobt & "' where nom_prod='" & dgvreg2.Rows(j).Cells("descripcion2").Value.ToString & "'", Conexion)
    '                        Conexion.Open()
    '                        adaptar.UpdateCommand.ExecuteNonQuery()
    '                        Conexion.Close()
    '                    Next
    '                    dgvreg2.Rows.Clear()
    '                End If


    '                If resultado = 0 Then
    '                    Conexion.Close()
    '                    Dim result2 As DialogResult
    '                    result2 = MessageBox.Show("Desea Guardar?", "Guardar!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    '                    If result2 = DialogResult.Yes Then

    '                        For Each Row As DataGridViewRow In dgvreg.Rows

    '                            Dim item As String = Row.Cells("item").Value
    '                            Dim unidad As String = Row.Cells("unidad").Value
    '                            Dim descripcionds As String = Row.Cells("descripcion").Value
    '                            Dim observacion As String = Row.Cells("observacion").Value

    '                            adaptar.InsertCommand = New SqlCommand("Insert into salida_inventario (no_salida, item, unidad, descripcion, observacion, codigo_vh, estado_vh, vhexist, placa_vh, categoriaps, hrm1, hrm2, klm1, klm2, motorista, acompañante, destino, fecha_retorno, fecha_salida, estado_ficha) values ('" & nosalida.Text & "', '" & item & "', '" & unidad & "', '" & descripcionds & "', '" & observacion & "', '" & codigovh.Text & "', '" & estadovh.Text & "', '" & Vehiculoext & "', '" & placavh.Text & "', '" & categoria.Text & "', '" & hrm1.Text & "', '" & hrm2.Text & "', '" & km1.Text & "', '" & km2.Text & "', '" & tmorotris.Text & "', '" & tpartner.Text & "', '" & tdestiny.Text & "', '" & dtpretorno.Text & "', '" & dtpsalida.Text & "', '" & Psext & "')", Conexion)
    '                            Conexion.Open()
    '                            adaptar.InsertCommand.ExecuteNonQuery()
    '                            Conexion.Close()
    '                        Next

    '                        MessageBox.Show("Guardado Exitosamente")
    '                        limpiar()
    '                        nosalida.Enabled = True
    '                        chknvregistro.Enabled = True
    '                        chknvregistro.Checked = False
    '                    ElseIf result2 = DialogResult.No Then
    '                        For j As Integer = 0 To dgvreg.Rows.Count - 1 Step +1
    '                            Dim unidadobt As String
    '                            unidadobt = dgvreg.Rows(j).Cells("unidad").Value.ToString
    '                            adaptar.UpdateCommand = New SqlCommand("update inventario set stock= stock+'" & unidadobt & "' where nom_prod='" & dgvreg.Rows(j).Cells("descripcion").Value.ToString & "'", Conexion)
    '                            Conexion.Open()
    '                            adaptar.UpdateCommand.ExecuteNonQuery()
    '                            Conexion.Close()
    '                        Next
    '                        dgvreg.Rows.Clear()
    '                    End If
    '                End If
    '        Catch ex As Exception
    '            MessageBox.Show(ex.ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End Try
    '    End Sub
End Class