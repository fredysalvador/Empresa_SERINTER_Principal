Imports System.Data.SqlClient
Imports System.Data
Imports System.Runtime.InteropServices
Public Class FrmRemisiones

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
    Private Sub FrmRemisiones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion = New SqlConnection
        Conexion.ConnectionString = cadena
        adaptar = New SqlDataAdapter(sql, Conexion)
    End Sub
    Private Sub bimprimir_Click(sender As Object, e As EventArgs)
        FrmHojaSalidaImpr.tsalida.Text = Me.nosalida.Text
        FrmHojaSalidaImpr.ShowDialog()
    End Sub
    Private Sub nosalida_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nosalida.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            nosalida_Validated(sender, e)
            mensaje.Text = "Mensajes"
        End If
    End Sub
    Private Sub nosalida_Validated(sender As Object, e As EventArgs) Handles nosalida.Validated
        '    If nosalida.Text = Nothing Then
        '    mensaje.Text = "Dejo vacio el numero de salida"
        '    nosalida.Focus()
        '    Exit Sub
        '    End If
        '    limpiar()
        limpiarparcial()
        limpiarparcial2()
        sql = "select * from salida_inventario where no_salida='" & nosalida.Text & "'"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet

            adaptar.Fill(almacen, "salida_inventario")
            resultado = almacen.Tables("salida_inventario").Rows.Count
            If almacen.Tables(0).Rows.Count <> 0 Then
                For j As Integer = 0 To almacen.Tables(0).Rows.Count - 1 Step +1
                    dgvreg.Rows.Add("", almacen.Tables(0).Rows(j)("unidad").ToString(), almacen.Tables(0).Rows(j)("descripcion").ToString(), almacen.Tables(0).Rows(j)("observacion").ToString())
                Next
            End If
            If resultado > 0 Then
                registro = almacen.Tables("salida_inventario").Rows(0)
                If Not IsDBNull(registro("destino")) Then
                    tdestiny.Text = registro("destino")
                End If
                If Not IsDBNull(registro("fecha_salida")) Then
                    dtpsalida.Value = registro("fecha_salida")
                End If
                If Not IsDBNull(registro("fecha_retorno")) Then
                    dtpretorno.Value = registro("fecha_retorno")
                End If
            End If

            If resultado = 0 Then
                dtpretorno2.Enabled = True
                dtpretorno.Enabled = True
                dtpsalida2.Enabled = True
                dtpsalida.Enabled = True
                limpiarparcial()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Conexion.Close()
        tdestiny.Focus()
        dtpretorno2.Enabled = True
        dtpretorno.Enabled = True
        dtpsalida2.Enabled = True
        dtpsalida.Enabled = True
    End Sub
    Private Sub nosalida2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles noremision2.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            nosalida2_Validated(sender, e)
            mensaje.Text = "Mensajes"
            ' nosalida_Validated(sender, e)
        End If
    End Sub
    Private Sub nosalida2_Validated(sender As Object, e As EventArgs) Handles noremision2.Validated
        'If nosalida2.Text = Nothing Then
        '    mensaje.Text = "Dejo vacio el numero de salida"
        '    nosalida2.Focus()
        '    Exit Sub
        'End If
        '  limpiar()
        dgvreg2.Rows.Clear()
        sql = "select * from remisiones where no_remision='" & noremision2.Text & "'"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "remisiones")
            resultado = almacen.Tables("remisiones").Rows.Count

            If almacen.Tables(0).Rows.Count <> 0 Then
                For j As Integer = 0 To almacen.Tables(0).Rows.Count - 1 Step +1
                    dgvreg2.Rows.Add(almacen.Tables(0).Rows(j)("id").ToString(), "", almacen.Tables(0).Rows(j)("unidad").ToString(), almacen.Tables(0).Rows(j)("descripcion").ToString(), almacen.Tables(0).Rows(j)("observacion").ToString())
                Next
            End If

            If resultado > 0 Then
                dtpretorno2.Enabled = True
                dtpretorno.Enabled = True
                registro = almacen.Tables("remisiones").Rows(0)
                If Not IsDBNull(registro("nota")) Then
                    tnota2.Text = registro("nota")
                End If
                If Not IsDBNull(registro("solicita")) Then
                    tsolicita2.Text = registro("solicita")
                End If
                If Not IsDBNull(registro("destino")) Then
                    tdestiny2.Text = registro("destino")
                End If
                If Not IsDBNull(registro("fecha_salida")) Then
                    dtpsalida2.Value = registro("fecha_salida")
                End If
                If Not IsDBNull(registro("fecha_retorno")) Then
                    dtpretorno2.Value = registro("fecha_retorno")
                End If
                If Not IsDBNull(registro("no_salida")) Then
                    tsalidano.Text = registro("no_salida")
                End If
            End If

            dtpretorno2.Enabled = True
            dtpretorno.Enabled = True
            dtpsalida2.Enabled = True
            dtpsalida.Enabled = True

            bagrginfo.Enabled = True
            num2un.Enabled = True
            descp2env.Enabled = True

            If resultado = 0 Then
                limpiarparcial2()
                dtpretorno2.Enabled = True
                dtpretorno.Enabled = True
                dtpsalida2.Enabled = True
                dtpsalida.Enabled = True


                bagrginfo.Enabled = False
                num2un.Enabled = False
                descp2env.Enabled = False




            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Conexion.Close()
    End Sub
    Private Sub val2()
        Dim valor As String
        valor = nosalida.Text
        noremision2.Text = valor
        sql = "select * from remisiones where no_remision='" & valor & "'"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "remisiones")
            resultado = almacen.Tables("remisiones").Rows.Count
            If almacen.Tables(0).Rows.Count <> 0 Then
                For j As Integer = 0 To almacen.Tables(0).Rows.Count - 1 Step +1
                    dgvreg2.Rows.Add("", almacen.Tables(0).Rows(j)("unidad").ToString(), almacen.Tables(0).Rows(j)("descripcion").ToString(), almacen.Tables(0).Rows(j)("observacion").ToString())
                Next
            End If

            If resultado > 0 Then
                registro = almacen.Tables("remisiones").Rows(0)
                If Not IsDBNull(registro("nota")) Then
                    tnota2.Text = registro("nota")
                End If
                If Not IsDBNull(registro("solicita")) Then
                    tsolicita2.Text = registro("solicita")
                End If
                If Not IsDBNull(registro("destino")) Then
                    tdestiny2.Text = registro("destino")
                End If
                If Not IsDBNull(registro("fecha_salida")) Then
                    dtpsalida2.Value = registro("fecha_salida")
                End If
                If Not IsDBNull(registro("fecha_retorno")) Then
                    dtpretorno2.Value = registro("fecha_retorno")
                End If
            End If

            If resultado = 0 Then
                limpiarparcial2()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Conexion.Close()
    End Sub
    Private Sub limpiar()
        noremision.Text = Nothing
        nosalida.Text = Nothing
        noremision.Enabled = True
        chknvregistro.Enabled = True
        chknvregistro.Checked = False
        limpiarparcial()
    End Sub
    Private Sub limpiar2()
        noremision2.Text = Nothing
        limpiarparcial2()
    End Sub
    Private Sub limpiarparcial()
        tdestiny.Text = Nothing
        tsolicita.Text = Nothing
        tnota.Text = Nothing
        dtpsalida.Value = Now
        dtpretorno.Value = Now
        dgvreg.Rows.Clear()
    End Sub
    Private Sub limpiarparcial2()
        tdestiny2.Text = Nothing
        tsolicita2.Text = Nothing
        tnota2.Text = Nothing
        dtpsalida2.Value = Now
        dtpretorno2.Value = Now
        dgvreg2.Rows.Clear()
        dgvreg3.Rows.Clear()
    End Sub
    Private Sub dgvreg_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvreg.RowPostPaint
        Me.dgvreg.Rows(e.RowIndex).Cells(0).Value = (e.RowIndex + 1).ToString
    End Sub
    Private Sub bagregar_Click(sender As Object, e As EventArgs) Handles bagregar.Click

        If noremision.Text = Nothing Then
            mensaje.Text = "Dejo vacio el Numero de remision"
            noremision.Focus()
            Exit Sub

        ElseIf tdestiny.Text = Nothing Then
            mensaje.Text = "Dejo vacio el destino"
            tdestiny.Focus()
            Exit Sub
        End If

        sql = "select * from remisiones where no_remision='" & noremision.Text & "'"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "remisiones")
            resultado = almacen.Tables("remisiones").Rows.Count

            If resultado = 0 Then
                Conexion.Close()
                Dim result As DialogResult
                result = MessageBox.Show("Desea Guardar el Registro?", "Guardar!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    For Each Row As DataGridViewRow In dgvreg.Rows

                        Dim item As String = Row.Cells("item").Value
                        Dim unidad As String = Row.Cells("unidad").Value
                        Dim descripcionds As String = Row.Cells("descripcion").Value
                        Dim observacion As String = Row.Cells("observacion").Value

                        adaptar.InsertCommand = New SqlCommand("Insert into remisiones (no_remision ,no_salida, item, unidad, descripcion,  observacion, nota, solicita, destino, fecha_retorno, fecha_salida) values ('" & noremision.Text & "', '" & nosalida.Text & "', '" & item & "', '" & unidad & "', '" & descripcionds & "', '" & observacion & "', '" & tnota.Text & "', '" & tsolicita.Text & "', '" & tdestiny.Text & "', '" & dtpretorno.Text & "', '" & dtpsalida.Text & "')", Conexion)
                        Conexion.Open()
                        adaptar.InsertCommand.ExecuteNonQuery()
                        Conexion.Close()

                    Next
                    MessageBox.Show("Guardado Exitosamente")
                    limpiar()

                ElseIf result = DialogResult.No Then

                End If


            ElseIf resultado > 0 Then
                Conexion.Close()
                MessageBox.Show("Esta remision ya se encuentra registrada / Modifique en la seccion derecha")

            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Conexion.Close()
        'val2()
    End Sub

    Private Sub dgvreg2_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvreg2.RowPostPaint
        Me.dgvreg2.Rows(e.RowIndex).Cells(1).Value = (e.RowIndex + 1).ToString
    End Sub

    Private Sub bimprimir_Click_1(sender As Object, e As EventArgs) Handles bimprimir.Click
        FrmRemisionesImp2.noremision.Text = Me.noremision2.Text
        FrmRemisionesImp2.ShowDialog()
    End Sub

    Private Sub breiniciar_Click(sender As Object, e As EventArgs) Handles breiniciar.Click
        limpiar()
        dtpretorno.Enabled = False
        dtpsalida.Enabled = False
        mensaje.Text = "Mensajes"

    End Sub
    Private Sub breiniciar2_Click(sender As Object, e As EventArgs) Handles breiniciar2.Click
        limpiar2()
        tsalidano.Text = Nothing
        dtpretorno2.Enabled = False
        dtpsalida2.Enabled = False
        mensaje.Text = "Mensajes"
    End Sub

    Private Sub beliminar_Click(sender As Object, e As EventArgs) Handles beliminar.Click
        If noremision2.Text = Nothing Then
            mensaje.Text = "Dejo vacio el Numero de Salida"
            noremision2.Focus()
            Exit Sub
        End If
        Try

            Dim result As DialogResult
            result = MessageBox.Show("Desea Eliminar la Remision?", "Eliminando!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                For j As Integer = 0 To dgvreg2.Rows.Count - 1 Step +1
                    adaptar.DeleteCommand = New SqlCommand("delete from remisiones where no_remision='" & noremision2.Text & "'", Conexion)
                    Conexion.Open()
                    adaptar.DeleteCommand.ExecuteNonQuery()
                    Conexion.Close()

                Next

                ' parametrolimpieza()
                MessageBox.Show("Eliminado Exitosamente")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        limpiar2()
        noremision2.Focus()
    End Sub
    Private Sub beditar_Click(sender As Object, e As EventArgs) Handles beditar.Click
        Dim nada As String
        nada = ""


        If noremision2.Text = Nothing Then
            mensaje.Text = "Dejo vacio el Numero de salida"
            noremision2.Focus()
            Exit Sub
        ElseIf tdestiny2.Text = Nothing Then
            mensaje.Text = "Dejo vacio el destino"
            tdestiny2.Focus()
            Exit Sub
        ElseIf tsolicita2.Text = Nothing Then
            mensaje.Text = "Dejo vacio el Solicitante"
            tsolicita2.Focus()
            Exit Sub
        End If
        Try
            If resultado > 0 Then
                Dim result As DialogResult
                result = MessageBox.Show("Desea Editar?", "Actualizado!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then

                    For Each Row As DataGridViewRow In dgvreg3.Rows

                        Dim item3 As String = Row.Cells("item3").Value
                        Dim unidad3 As String = Row.Cells("unidad3").Value
                        Dim descripcionds3 As String = Row.Cells("descripcion3").Value
                        Dim observacion3 As String = Row.Cells("observacion3").Value


                        adaptar.InsertCommand = New SqlCommand("Insert into remisiones (no_remision ,no_salida, item, unidad, descripcion,  observacion, nota, solicita, destino, fecha_retorno, fecha_salida) values ('" & noremision2.Text & "', '" & tsalidano.Text & "', '" & item3 & "', '" & unidad3 & "', '" & descripcionds3 & "', '" & observacion3 & "', '" & tnota2.Text & "', '" & tsolicita2.Text & "', '" & tdestiny2.Text & "', '" & dtpretorno.Text & "', '" & dtpsalida.Text & "')", Conexion)
                        Conexion.Open()
                        adaptar.InsertCommand.ExecuteNonQuery()
                        Conexion.Close()

                    Next

                    adaptar.UpdateCommand = New SqlCommand("update remisiones set nota='" & tnota2.Text & "',destino='" & tdestiny2.Text & "',solicita='" & tsolicita2.Text & "',fecha_salida='" & dtpsalida2.Text & "',fecha_retorno='" & dtpretorno2.Text & "' where no_remision='" & noremision2.Text & "'", Conexion)
                    Conexion.Open()
                    adaptar.UpdateCommand.ExecuteNonQuery()
                    Conexion.Close()

                    For Each Row As DataGridViewRow In dgvreg2.Rows
                        Dim id2 As String = Row.Cells("id").Value
                        Dim item2 As String = Row.Cells("item2").Value
                        Dim unidad2 As String = Row.Cells("unidad2").Value
                        Dim descripcionds2 As String = Row.Cells("descripcion2").Value
                        Dim observacion2 As String = Row.Cells("observacion2").Value
                        adaptar.UpdateCommand = New SqlCommand("update remisiones set item='" & item2 & "',unidad='" & unidad2 & "',descripcion='" & descripcionds2 & "',observacion='" & observacion2 & "' where no_remision='" & noremision2.Text & "'and id='" & id2 & "'", Conexion)
                        Conexion.Open()
                        adaptar.UpdateCommand.ExecuteNonQuery()
                        Conexion.Close()

                    Next
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        limpiar2()
        noremision2.Focus()
    End Sub
    Private Sub tdestiny_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tdestiny.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tsolicita.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub
    Private Sub tsolicita_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tsolicita.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tnota.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub
    Private Sub tsolicita_TextChanged(sender As Object, e As EventArgs) Handles tsolicita.TextChanged
        tsolicita.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tsolicita.Text)
        tsolicita.SelectionStart = tsolicita.Text.Length
    End Sub
    Private Sub tdestiny_TextChanged(sender As Object, e As EventArgs) Handles tdestiny.TextChanged
        tdestiny.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tdestiny.Text)
        tdestiny.SelectionStart = tdestiny.Text.Length
    End Sub
    Private Sub tdestiny2_TextChanged(sender As Object, e As EventArgs) Handles tdestiny2.TextChanged
        tdestiny2.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tdestiny2.Text)
        tdestiny2.SelectionStart = tdestiny2.Text.Length
    End Sub
    Private Sub tsolicita2_TextChanged(sender As Object, e As EventArgs) Handles tsolicita2.TextChanged
        tsolicita2.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tsolicita2.Text)
        tsolicita2.SelectionStart = tsolicita2.Text.Length
    End Sub
    Private Sub beliminarreg_Click(sender As Object, e As EventArgs) Handles beliminarreg.Click
        For Each Row As DataGridViewRow In dgvreg.SelectedRows
            dgvreg.Rows.Remove(Row)
        Next
    End Sub

    Private Sub bagregadogeneral_Click(sender As Object, e As EventArgs) Handles bagregadogeneral.Click

        Dim nombrea As String
        Dim itema As String
        Dim cantidad As String
        Dim idenv As String

        Dim Valor2 As String
        Valor2 = Me.descp1env.Text
        Dim existe2 As Boolean = Me.dgvreg.Rows.Cast(Of DataGridViewRow).Any(Function(x) CStr(x.Cells("descripcion").Value) = Valor2)

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
        dgvreg.Rows.Add(itema, cantidad, nombrea)
        Conexion.Close()
        num1un.Text = 0
        descp1env.Text = Nothing

    End Sub
    Private Sub bagrginfo_Click(sender As Object, e As EventArgs) Handles bagrginfo.Click

        Dim nombrea As String
        Dim itema As String
        Dim cantidad As String
        Dim idenv As String

        Dim Valor2 As String
        Valor2 = Me.descp2env.Text
        Dim existe2 As Boolean = Me.dgvreg3.Rows.Cast(Of DataGridViewRow).Any(Function(x) CStr(x.Cells("descripcion3").Value) = Valor2)

        If descp2env.Text = Nothing Then
            mensaje.Text = "Agregue una Descripción"
            Conexion.Close()
            Exit Sub
        ElseIf num2un.Text = Nothing Then
            mensaje.Text = "Agregue una valor numerico"
            Conexion.Close()
            Exit Sub
        End If

        mensaje.Text = "Mensajes"
        idenv = dgvreg3.Rows.Count.ToString
        itema = dgvreg3.Rows.Count.ToString
        cantidad = num2un.Text
        nombrea = descp2env.Text
        dgvreg3.Rows.Add(idenv, itema, cantidad, nombrea)
        Conexion.Close()
        num2un.Text = 0
        descp2env.Text = Nothing

    End Sub
    Private Sub beliminarreg2_Click(sender As Object, e As EventArgs) Handles beliminarreg2.Click

        For Each Row As DataGridViewRow In dgvreg2.SelectedRows

            Dim id1 As String = Row.Cells("id").Value
            Dim item As String = Row.Cells("item2").Value
            Dim unidad As String = Row.Cells("unidad2").Value
            Dim descripcionds As String = Row.Cells("descripcion2").Value
            ''Dim observacion As String = Row.Cells("observacion2").Value

            adaptar.DeleteCommand = New SqlCommand("delete from remisiones where no_remision='" & noremision2.Text & "' and descripcion='" & descripcionds & "' and unidad='" & unidad & "' and id='" & id1 & "'", Conexion)
            Conexion.Open()
            adaptar.DeleteCommand.ExecuteNonQuery()
            Conexion.Close()
            dgvreg2.Rows.Remove(Row)
        Next

        For Each Row As DataGridViewRow In dgvreg3.SelectedRows
            dgvreg3.Rows.Remove(Row)
        Next

    End Sub

    Private Sub chknvregistro_CheckedChanged(sender As Object, e As EventArgs) Handles chknvregistro.CheckedChanged

        Dim valormax As Integer
        If chknvregistro.Checked = True Then
            Conexion.Open()
            Dim cmd As New SqlCommand("ValormaximoRemision", Conexion)
            cmd.CommandType = CommandType.StoredProcedure

            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            Dim dt As New DataTable
            dt.Clear()
            da.Fill(dt)

            Dim row As DataRow = dt.Rows(0)
            'If row Is Nothing Then
            'valormax = 1
            'Else
            valormax = Convert.ToString(row("valmax"))
            noremision.Text = valormax.ToString("0000#")
            'End If

            ' valormax = Convert.ToString(row("valmax"))


            Conexion.Close()
            chknvregistro.Enabled = False
            noremision.Enabled = False
            noremision_Validated(sender, e)

            nosalida.Focus()

        ElseIf chknvregistro.Checked = False Then

        End If
    End Sub

    Private Sub noremision_KeyPress(sender As Object, e As KeyPressEventArgs) Handles noremision.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            noremision_Validated(sender, e)
            mensaje.Text = "Mensajes"
        End If
    End Sub
    Private Sub noremision_Validated(sender As Object, e As EventArgs) Handles noremision.Validated
        dgvreg2.Rows.Clear()
        sql = "select * from remisiones where no_remision='" & noremision.Text & "'"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "remisiones")
            resultado = almacen.Tables("remisiones").Rows.Count
            If almacen.Tables(0).Rows.Count <> 0 Then
                For j As Integer = 0 To almacen.Tables(0).Rows.Count - 1 Step +1
                    dgvreg2.Rows.Add(almacen.Tables(0).Rows(j)("id").ToString(), "", almacen.Tables(0).Rows(j)("unidad").ToString(), almacen.Tables(0).Rows(j)("descripcion").ToString(), almacen.Tables(0).Rows(j)("observacion").ToString())
                Next
            End If
            If resultado > 0 Then

                dtpretorno2.Enabled = True
                dtpretorno.Enabled = True
                registro = almacen.Tables("remisiones").Rows(0)
                If Not IsDBNull(registro("nota")) Then
                    tnota2.Text = registro("nota")
                End If
                If Not IsDBNull(registro("solicita")) Then
                    tsolicita2.Text = registro("solicita")
                End If
                If Not IsDBNull(registro("destino")) Then
                    tdestiny2.Text = registro("destino")
                End If
                If Not IsDBNull(registro("fecha_salida")) Then
                    dtpsalida2.Value = registro("fecha_salida")
                End If
                If Not IsDBNull(registro("fecha_retorno")) Then
                    dtpretorno2.Value = registro("fecha_retorno")
                End If
            End If

            dtpretorno2.Enabled = True
            dtpretorno.Enabled = True
            dtpsalida2.Enabled = True
            dtpsalida.Enabled = True

            If resultado = 0 Then
                limpiarparcial2()
                dtpretorno2.Enabled = True
                dtpretorno.Enabled = True
                dtpsalida2.Enabled = True
                dtpsalida.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Conexion.Close()
    End Sub

    Private Sub noremision_TextChanged(sender As Object, e As EventArgs) Handles noremision.TextChanged
        noremision2.Text = noremision.Text
    End Sub

    Private Sub btatras_Click(sender As Object, e As EventArgs) Handles btatras.Click

        Dim valormax As Integer
        Dim valostring As String

        If nosalida.Text = Nothing Then
            Conexion.Open()
            Dim cmd As New SqlCommand("Valormaximo", Conexion)
            cmd.CommandType = CommandType.StoredProcedure

            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            Dim dt As New DataTable
            dt.Clear()
            da.Fill(dt)

            Dim row As DataRow = dt.Rows(0)
            valormax = Convert.ToString(row("valmax"))

            valormax = valormax - 1

            If valormax < 10 Then
                valostring = "0000" + valormax.ToString
            ElseIf valormax < 100 Then
                valostring = "000" + valormax.ToString
            ElseIf valormax < 1000 Then
                valostring = "00" + valormax.ToString
            ElseIf valormax < 10000 Then
                valostring = "0" + valormax.ToString
            ElseIf valormax < 100000 Then
                valostring = valormax.ToString
            Else
                valostring = valormax.ToString
            End If

            nosalida.Text = valostring

            Conexion.Close()

            nosalida_Validated(sender, e)

            nosalida.Focus()

        Else

            valormax = nosalida.Text - 1

            If valormax < 10 Then
                valostring = "0000" + valormax.ToString
            ElseIf valormax < 100 Then
                valostring = "000" + valormax.ToString
            ElseIf valormax < 1000 Then
                valostring = "00" + valormax.ToString
            ElseIf valormax < 10000 Then
                valostring = "0" + valormax.ToString
            ElseIf valormax < 100000 Then
                valostring = valormax.ToString
            Else
                valostring = valormax.ToString
            End If

            nosalida.Text = valostring

            nosalida_Validated(sender, e)

        End If
    End Sub
    Private Sub btadelante_Click(sender As Object, e As EventArgs) Handles btadelante.Click
        Dim valormax As Integer
        Dim valostring As String

        If nosalida.Text = Nothing Then
            Conexion.Open()
            Dim cmd As New SqlCommand("Valormaximo", Conexion)
            cmd.CommandType = CommandType.StoredProcedure

            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            Dim dt As New DataTable
            dt.Clear()
            da.Fill(dt)

            Dim row As DataRow = dt.Rows(0)
            valormax = Convert.ToString(row("valmax"))

            valormax = valormax - 1

            If valormax < 10 Then
                valostring = "0000" + valormax.ToString
            ElseIf valormax < 100 Then
                valostring = "000" + valormax.ToString
            ElseIf valormax < 1000 Then
                valostring = "00" + valormax.ToString
            ElseIf valormax < 10000 Then
                valostring = "0" + valormax.ToString
            ElseIf valormax < 100000 Then
                valostring = valormax.ToString
            Else
                valostring = valormax.ToString
            End If

            nosalida.Text = valostring

            Conexion.Close()

            nosalida_Validated(sender, e)

            nosalida.Focus()

        Else
            valormax = nosalida.Text + 1

            If valormax < 10 Then
                valostring = "0000" + valormax.ToString
            ElseIf valormax < 100 Then
                valostring = "000" + valormax.ToString
            ElseIf valormax < 1000 Then
                valostring = "00" + valormax.ToString
            ElseIf valormax < 10000 Then
                valostring = "0" + valormax.ToString
            ElseIf valormax < 100000 Then
                valostring = valormax.ToString
            Else
                valostring = valormax.ToString
            End If

            nosalida.Text = valostring

            nosalida_Validated(sender, e)

        End If
    End Sub
    Private Sub btatras2_Click(sender As Object, e As EventArgs) Handles btatras2.Click

        Dim valormax As Integer
        Dim valostring As String

        If noremision2.Text = Nothing Then

            Conexion.Open()
            Dim cmd As New SqlCommand("ValormaximoRemision", Conexion)
            cmd.CommandType = CommandType.StoredProcedure

            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            Dim dt As New DataTable
            dt.Clear()
            da.Fill(dt)

            Dim row As DataRow = dt.Rows(0)
            valormax = Convert.ToString(row("valmax"))

            valormax = valormax - 1

            If valormax < 10 Then
                valostring = "0000" + valormax.ToString
            ElseIf valormax < 100 Then
                valostring = "000" + valormax.ToString
            ElseIf valormax < 1000 Then
                valostring = "00" + valormax.ToString
            ElseIf valormax < 10000 Then
                valostring = "0" + valormax.ToString
            Else
                valostring = valormax.ToString
            End If

            noremision2.Text = valostring

            Conexion.Close()

            nosalida2_Validated(sender, e)

            noremision2.Focus()

        Else

            valormax = noremision2.Text - 1

            If valormax < 10 Then
                valostring = "0000" + valormax.ToString
            ElseIf valormax < 100 Then
                valostring = "000" + valormax.ToString
            ElseIf valormax < 1000 Then
                valostring = "00" + valormax.ToString
            ElseIf valormax < 10000 Then
                valostring = "0" + valormax.ToString
            End If

            noremision2.Text = valostring

            nosalida2_Validated(sender, e)

        End If
    End Sub

    Private Sub btadelante2_Click(sender As Object, e As EventArgs) Handles btadelante2.Click
        Dim valormax As Integer
        Dim valostring As String

        If noremision2.Text = Nothing Then
            Conexion.Open()
            Dim cmd As New SqlCommand("ValormaximoRemision", Conexion)
            cmd.CommandType = CommandType.StoredProcedure

            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            Dim dt As New DataTable
            dt.Clear()
            da.Fill(dt)

            Dim row As DataRow = dt.Rows(0)
            valormax = Convert.ToString(row("valmax"))

            valormax = valormax - 1

            If valormax < 10 Then
                valostring = "0000" + valormax.ToString
            ElseIf valormax < 100 Then
                valostring = "000" + valormax.ToString
            ElseIf valormax < 1000 Then
                valostring = "00" + valormax.ToString
            ElseIf valormax < 10000 Then
                valostring = "0" + valormax.ToString
            ElseIf valormax < 100000 Then
                valostring = valormax.ToString
            Else
                valostring = valormax.ToString
            End If

            noremision2.Text = valostring


            Conexion.Close()

            nosalida2_Validated(sender, e)

            noremision2.Focus()

        Else
            valormax = noremision2.Text + 1

            If valormax < 10 Then
                valostring = "0000" + valormax.ToString
            ElseIf valormax < 100 Then
                valostring = "000" + valormax.ToString
            ElseIf valormax < 1000 Then
                valostring = "00" + valormax.ToString
            ElseIf valormax < 10000 Then
                valostring = "0" + valormax.ToString
            ElseIf valormax < 100000 Then
                valostring = valormax.ToString
            Else
                valostring = valormax.ToString
            End If

            noremision2.Text = valostring

            nosalida2_Validated(sender, e)

        End If

    End Sub

    Private Sub dgvreg3_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvreg3.RowPostPaint
        Me.dgvreg3.Rows(e.RowIndex).Cells(1).Value = (e.RowIndex + 1).ToString
    End Sub

    Private Sub num1un_KeyPress(sender As Object, e As KeyPressEventArgs) Handles num1un.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            descp1env.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub descp1env_KeyPress(sender As Object, e As KeyPressEventArgs) Handles descp1env.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            bagregadogeneral.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub
   
End Class