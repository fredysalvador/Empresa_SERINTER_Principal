Imports System.Data.SqlClient
Imports System.Data
Imports System.Runtime.InteropServices
Public Class FrmMantenimientosMaq
    Dim vall1 As Integer
    Private Sub bagregar_Click(sender As Object, e As EventArgs) Handles bagregar.Click
        sql = "select * from registro_mantenimientos where codigo_vh='" & tcodv.Text & "'"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "registro_mantenimientos")
            resultado = almacen.Tables("registro_mantenimientos").Rows.Count
            If resultado > 0 Then
                Conexion.Close()
                Dim result As DialogResult
                result = MessageBox.Show("Desea Agregar Nuevos Registros?", "Actualizado!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then

                    For Each Row As DataGridViewRow In dgvreg2.Rows

                        'Dim item2 As String = Row.Cells("Item2").Value
                        Dim unidad2 As String = Row.Cells("Unidad2").Value
                        Dim descripcionds2 As String = Row.Cells("Descripcion2").Value
                        Dim valords2 As String = Row.Cells("Valor2").Value
                        Dim valorT2 As String = Row.Cells("ValorT2").Value
                        Dim razon2 As String = Row.Cells("Razon2").Value
                        Dim fecha2 As Date = Row.Cells("Fecha2").Value

                        adaptar.InsertCommand = New SqlCommand("Insert into registro_mantenimientos (codigo_vh, unidad, descripcion, valor, razon, fecha, valor_total) values ('" & tcodv.Text & "', '" & unidad2 & "', '" & descripcionds2 & "', '" & valords2 & "', '" & razon2 & "', '" & fecha2 & "', '" & valorT2 & "')", Conexion)
                        Conexion.Open()
                        adaptar.InsertCommand.ExecuteNonQuery()
                        Conexion.Close()
                    Next

                    MessageBox.Show("Actualizado Exitosamente")
                    limpiar()
                    dgvreg2.Rows.Clear()
                    dgvreg.Rows.Clear()
                    Me.Hide()
                    ' nosalida.Enabled = True
                ElseIf result = DialogResult.No Then

                End If
            End If

            If resultado = 0 Then
                Conexion.Close()
                Dim result2 As DialogResult
                result2 = MessageBox.Show("Desea Guardar?", "Guardar!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result2 = DialogResult.Yes Then

                    For Each Row As DataGridViewRow In dgvreg.Rows

                        'Dim item As String = Row.Cells("Item").Value
                        Dim unidad As String = Row.Cells("Unidad").Value
                        Dim descripcionds As String = Row.Cells("Descripcion").Value
                        Dim valords As String = Row.Cells("Valor").Value
                        Dim valorT1 As String = Row.Cells("ValorT").Value
                        Dim razon As String = Row.Cells("Razon").Value
                        Dim fecha As Date = Row.Cells("Fecha").Value

                        adaptar.InsertCommand = New SqlCommand("Insert into registro_mantenimientos (codigo_vh, unidad, descripcion, valor, razon, fecha, valor_total) values ('" & tcodv.Text & "', '" & unidad & "', '" & descripcionds & "', '" & valords & "', '" & razon & "', '" & fecha & "', '" & valorT1 & "')", Conexion)
                        Conexion.Open()
                        adaptar.InsertCommand.ExecuteNonQuery()
                        Conexion.Close()
                    Next

                    MessageBox.Show("Guardado Exitosamente")
                    limpiar()
                    dgvreg2.Rows.Clear()
                    dgvreg.Rows.Clear()
                    Me.Hide()

                    'nosalida.Enabled = True
                ElseIf result2 = DialogResult.No Then
                
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub bdatagridinv_Click(sender As Object, e As EventArgs) Handles bdatagridinv.Click
        dgvinventario.Visible = True
        bagrlista.Enabled = True
        btnbuscar.Enabled = True
        ccampos.Enabled = True
        tcriterio.Enabled = True
        sql = "select * from inventario order by codigop desc"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "inventario")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        dgvinventario.DataSource = almacen
        dgvinventario.DataMember = "inventario"
        dgvinventario.Columns(0).HeaderText = "codigop"
        dgvinventario.Columns(1).HeaderText = "prefijo"
        dgvinventario.Columns(2).HeaderText = "nom_prod"
        dgvinventario.Columns(3).Visible = False
        dgvinventario.Columns(4).Visible = False
        dgvinventario.Columns(5).Visible = False
        dgvinventario.Columns(6).Visible = False
        dgvinventario.Columns(7).Visible = False
        dgvinventario.Columns(8).Visible = False
        dgvinventario.Columns(9).HeaderText = "stock"
        dgvinventario.Columns(10).Visible = False
        dgvinventario.AutoResizeColumns()
        dgvinventario.Columns(0).Width = 60
        dgvinventario.Columns(1).Width = 44 'Ancho Especifico
        dgvinventario.Columns(2).Width = 160
        dgvinventario.Columns(9).Width = 43
        dgvinventario.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvinventario.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvinventario.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvinventario.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvinventario.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvinventario.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvinventario.Columns(7).DefaultCellStyle.NullValue = My.Resources.subir
        dgvinventario.Columns(8).DefaultCellStyle.NullValue = My.Resources.subir

        dgvinventario.ClearSelection()
        Conexion.Close()

        dgvinventario.Refresh()
    End Sub

    Private Sub bagrlista_Click(sender As Object, e As EventArgs) Handles bagrlista.Click
        Dim nombre As String
        Dim id1 As String
        Dim item As String
        Dim cantidad As String
        Dim valors As String
        Dim razons As String
        Dim fechas As Date = Date.Today
        Dim total_unid As Decimal



        Dim Valor As String
        Valor = Me.tnombre.Text
        Dim existe As Boolean = Me.dgvreg.Rows.Cast(Of DataGridViewRow).Any(Function(x) CStr(x.Cells("descripcion").Value) = Valor)

        'If Not existe Then

        sql = "select * from registro_mantenimientos where codigo_vh='" & tcodv.Text & "'"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "registro_mantenimientos")
            resultado = almacen.Tables("registro_mantenimientos").Rows.Count


            If resultado = 0 Then

                If ncantidadinv.Value = 0 Then
                    mensaje.Text = "Agregue una Cantidad Valida"
                    Conexion.Close()
                    Exit Sub

                ElseIf tvalores.Text = Nothing Then
                    mensaje.Text = "Agregue una Valor al Item"
                    Conexion.Close()
                    Exit Sub
                End If

                mensaje.Text = "Mensajes"
                id1 = dgvreg.Rows.Count.ToString
                item = dgvreg.Rows.Count.ToString
                cantidad = ncantidadinv.Value
                nombre = dgvinventario(2, dgvinventario.CurrentRow.Index).Value
                valors = tvalores.Text
                'fechas = fechahora.Text
                total_unid = cantidad * valors
                dgvreg.Rows.Add(id1, item, cantidad, nombre, valors, total_unid, razons, fechas)
                Conexion.Close()

                adaptar.UpdateCommand = New SqlCommand("update inventario set stock= stock-'" & ncantidadinv.Value & "' where codigop='" & codp2.Text & "'", Conexion)
                Conexion.Open()
                adaptar.UpdateCommand.ExecuteNonQuery()
                Conexion.Close()

                codp2.Text = Nothing
                codp1.Text = Nothing
                tnombre.Text = Nothing
                ccategoria.Text = Nothing
                tproveedor.Text = Nothing
                cstock.Value = 0
                ncantidadinv.Value = 0
                pfoto.Image = Nothing
                pfoto2.Image = Nothing
                tvalores.Text = Nothing
                ActualizarINV()

            ElseIf resultado > 0 Then

                dgvreg.ClearSelection()
                If ncantidadinv.Value = 0 Then
                    mensaje.Text = "Agregue una Cantidad Valida"
                    Conexion.Close()
                    Exit Sub
                ElseIf tvalores.Text = Nothing Then
                    mensaje.Text = "Agregue una Valor al Item"
                    Conexion.Close()
                    Exit Sub
                End If

                mensaje.Text = "Mensajes"
                id1 = dgvreg2.Rows.Count.ToString
                item = dgvreg2.Rows.Count.ToString
                cantidad = ncantidadinv.Value
                nombre = dgvinventario(2, dgvinventario.CurrentRow.Index).Value
                valors = tvalores.Text
                'fechas = fechahora.Text
                total_unid = cantidad * valors
                dgvreg2.Rows.Add(id1, item, cantidad, nombre, valors, total_unid, razons, fechas)
                Conexion.Close()

                adaptar.UpdateCommand = New SqlCommand("update inventario set stock= stock-'" & ncantidadinv.Value & "' where codigop='" & codp2.Text & "'", Conexion)
                Conexion.Open()
                adaptar.UpdateCommand.ExecuteNonQuery()
                Conexion.Close()


                codp2.Text = Nothing
                codp1.Text = Nothing
                tnombre.Text = Nothing
                ccategoria.Text = Nothing
                tproveedor.Text = Nothing
                cstock.Value = 0
                ncantidadinv.Value = 0
                pfoto.Image = Nothing
                pfoto2.Image = Nothing
                tvalores.Text = Nothing
                ActualizarINV()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'End If

        Conexion.Close()
        dgvinventario.Refresh()

    End Sub
    Private Sub ActualizarINV()
        dgvinventario.Visible = True
        bagrlista.Enabled = True
        btnbuscar.Enabled = True
        ccampos.Enabled = True
        tcriterio.Enabled = True
        If ccampos.Text = Nothing And tcriterio.Text = Nothing Then
            sql = "select * from inventario order by codigop desc"
        ElseIf ccampos.Text <> Nothing And tcriterio.Text <> Nothing Then
            sql = "select * from inventario where " & ccampos.Text & " like '%" & tcriterio.Text & "%'"
            sql += "order by codigop desc"
        Else
            sql = "select * from inventario order by codigop desc"
        End If
        'MsgBox(sql)
        Try
            Conexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        adaptar = New SqlDataAdapter(sql, Conexion)
        almacen = New DataSet
        adaptar.Fill(almacen, "inventario")
        resultado = almacen.Tables("inventario").Rows.Count
        If resultado > 0 Then
            dgvinventario.DataSource = almacen
            dgvinventario.DataMember = "inventario"
            dgvinventario.Columns(0).HeaderText = "codigop"
            dgvinventario.Columns(1).HeaderText = "prefijo"
            dgvinventario.Columns(2).HeaderText = "nom_prod"
            dgvinventario.Columns(3).Visible = False
            dgvinventario.Columns(4).Visible = False
            dgvinventario.Columns(5).Visible = False
            dgvinventario.Columns(6).Visible = False
            dgvinventario.Columns(7).Visible = False
            dgvinventario.Columns(8).Visible = False
            dgvinventario.Columns(9).HeaderText = "stock"
            dgvinventario.AutoResizeColumns()
            dgvinventario.Columns(0).Width = 60
            dgvinventario.Columns(1).Width = 44 'Ancho Especifico
            dgvinventario.Columns(2).Width = 160
            dgvinventario.Columns(9).Width = 43
            dgvinventario.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvinventario.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvinventario.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvinventario.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvinventario.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvinventario.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        ElseIf resultado = 0 Then
            mensaje.Text = "No se encuentra con mostrar"
            dgvinventario.DataSource = Nothing
            dgvinventario.DataMember = Nothing
            dgvinventario.Refresh()
        End If
        Conexion.Close()
        dgvinventario.Focus()
        dgvinventario.ClearSelection()
    End Sub

    Private Sub FrmMantenimientosMaq_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        vall1 = 0 ' Su valor es 0
        ' Label1.Text = Vall1       <------- es para que muestre los segundos yo mejor lo quite
        Timer3.Enabled = True ' Activamos el control al iniciar el formulario
        Timer3.Interval = 1000 ' Un segundo de intervalo ' Recuerda que es en milisegundos
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        If ccampos.Text = Nothing And tcriterio.Text = Nothing Then
            sql = "select * from inventario order by codigop desc"
        ElseIf ccampos.Text <> Nothing And tcriterio.Text <> Nothing Then
            sql = "select * from inventario where " & ccampos.Text & " like '%" & tcriterio.Text & "%'"
            sql += "order by codigop desc"
        Else
            sql = "select * from inventario order by codigop desc"
        End If
        'MsgBox(sql)
        Try
            Conexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        adaptar = New SqlDataAdapter(sql, Conexion)
        almacen = New DataSet
        adaptar.Fill(almacen, "inventario")
        resultado = almacen.Tables("inventario").Rows.Count
        If resultado > 0 Then
            dgvinventario.DataSource = almacen
            dgvinventario.DataMember = "inventario"
            dgvinventario.Columns(0).HeaderText = "codigop"
            dgvinventario.Columns(1).HeaderText = "prefijo"
            dgvinventario.Columns(2).HeaderText = "nom_prod"
            dgvinventario.Columns(3).Visible = False
            dgvinventario.Columns(4).Visible = False
            dgvinventario.Columns(5).Visible = False
            dgvinventario.Columns(6).Visible = False
            dgvinventario.Columns(7).Visible = False
            dgvinventario.Columns(8).Visible = False
            dgvinventario.Columns(9).HeaderText = "stock"
            dgvinventario.AutoResizeColumns()
            dgvinventario.Columns(0).Width = 60
            dgvinventario.Columns(1).Width = 44 'Ancho Especifico
            dgvinventario.Columns(2).Width = 160
            dgvinventario.Columns(9).Width = 43
            dgvinventario.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvinventario.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvinventario.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvinventario.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvinventario.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvinventario.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvinventario.Columns(7).DefaultCellStyle.NullValue = My.Resources.subir
            dgvinventario.Columns(8).DefaultCellStyle.NullValue = My.Resources.subir
            mensaje.Text = "Mensajes"
        ElseIf resultado = 0 Then
            mensaje.Text = "No se encuentra con mostrar"
            dgvinventario.DataSource = Nothing
            dgvinventario.DataMember = Nothing
            dgvinventario.Refresh()
        End If
        Conexion.Close()
        dgvinventario.Focus()
        dgvinventario.ClearSelection()
    End Sub

    Private Sub blimpieza_Click(sender As Object, e As EventArgs) Handles blimpieza.Click
        mensaje.Text = "Mensajes"
        btnbuscar.Text = Nothing
        ccampos.Text = Nothing
        tcriterio.Text = Nothing
    End Sub

    Private Sub dgvinventario_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvinventario.CellContentClick
        If dgvreg.Rows.Count = cstock.Value Then
            For Each Row As DataGridViewRow In dgvreg.Rows
                Dim unidad As String = Row.Cells("unidad").Value
                Dim descripcionds As String = Row.Cells("descripcion").Value

                If tnombre.Text = descripcionds Then
                    cstock.Value = cstock.Value - unidad
                End If
            Next
        End If

        codp2.Text = dgvinventario.CurrentRow.Cells.Item(0).Value.ToString
        codp1.Text = dgvinventario.CurrentRow.Cells.Item(1).Value.ToString
        tnombre.Text = dgvinventario.CurrentRow.Cells.Item(2).Value.ToString
        ccategoria.Text = dgvinventario.CurrentRow.Cells.Item(3).Value.ToString
        tproveedor.Text = dgvinventario.CurrentRow.Cells.Item(5).Value.ToString
        cstock.Value = dgvinventario.CurrentRow.Cells.Item(9).Value.ToString
        pfoto3.Image = dgvinventario.CurrentRow.Cells("foto1").FormattedValue
        pfoto3.SizeMode = PictureBoxSizeMode.StretchImage
        pfoto4.Image = dgvinventario.CurrentRow.Cells("foto2").FormattedValue
        pfoto4.SizeMode = PictureBoxSizeMode.StretchImage

        If ncantidadinv.Value > cstock.Value Then
            ncantidadinv.Value = cstock.Value
        End If

    End Sub

    Private Sub beliminarreg_Click(sender As Object, e As EventArgs) Handles beliminarreg.Click
        For Each Row As DataGridViewRow In dgvreg.SelectedRows

            Dim id1 As String = Row.Cells("ID1").Value
            Dim unidad As String = Row.Cells("Unidad").Value
            Dim descripcionds As String = Row.Cells("Descripcion").Value
            Dim valords As String = Row.Cells("Valor").Value
            Dim razon As String = Row.Cells("Razon").Value
            Dim fecha As Date = Row.Cells("Fecha").Value

            adaptar.UpdateCommand = New SqlCommand("update inventario set stock= stock+'" & unidad & "' where nom_prod='" & descripcionds & "'", Conexion)
            Conexion.Open()
            adaptar.UpdateCommand.ExecuteNonQuery()
            Conexion.Close()
        Next

        For Each Row As DataGridViewRow In dgvreg.SelectedRows

            Dim id1 As String = Row.Cells("ID1").Value
            Dim unidad As String = Row.Cells("Unidad").Value
            Dim descripcionds As String = Row.Cells("Descripcion").Value
            Dim valords As String = Row.Cells("Valor").Value
            Dim razon As String = Row.Cells("Razon").Value
            Dim fecha As Date = Row.Cells("Fecha").Value

            adaptar.DeleteCommand = New SqlCommand("delete from registro_mantenimientos where codigo_vh='" & tcodv.Text & "' and id='" & id1 & "' and descripcion='" & descripcionds & "' and unidad='" & unidad & "'", Conexion)
            Conexion.Open()
            adaptar.DeleteCommand.ExecuteNonQuery()
            Conexion.Close()
            dgvreg.Rows.Remove(Row)
            dgvinventario.Refresh()
        Next

        For Each Row As DataGridViewRow In dgvreg2.SelectedRows
            Dim id1 As String = Row.Cells("ID1").Value
            Dim unidad2 As String = Row.Cells("Unidad2").Value
            Dim descripcionds2 As String = Row.Cells("Descripcion2").Value
            Dim valords2 As String = Row.Cells("Valor2").Value
            Dim razon2 As String = Row.Cells("Razon2").Value
            Dim fecha2 As Date = Row.Cells("Fecha2").Value

            adaptar.UpdateCommand = New SqlCommand("update inventario set stock= stock+'" & unidad2 & "' where nom_prod='" & descripcionds2 & "'", Conexion)
            Conexion.Open()
            adaptar.UpdateCommand.ExecuteNonQuery()
            Conexion.Close()
            dgvreg2.Rows.Remove(Row)
        Next

        sql = "select * from registro_mantenimientos where codigo_vh='" & tcodv.Text & "'"
        Try
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "registro_mantenimientos")
            resultado = almacen.Tables("registro_mantenimientos").Rows.Count

            If resultado = 0 Then
                chkfiltro.Visible = False
            ElseIf resultado > 0 Then
                chkfiltro.Visible = True
            End If
        Catch ex As Exception

        End Try
        ' Conexion.Open()
       
        ActualizarINV()
    End Sub

    Private Sub beliminar_Click(sender As Object, e As EventArgs) Handles beliminar.Click
        Try

            Dim result As DialogResult
            result = MessageBox.Show("Desea Eliminar? El Inventariado Regresara nuevamente", "Eliminando!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                For j As Integer = 0 To dgvreg.Rows.Count - 1 Step +1
                    adaptar.DeleteCommand = New SqlCommand("delete from registro_mantenimientos where codigo_vh='" & tcodv.Text & "'", Conexion)
                    Conexion.Open()
                    adaptar.DeleteCommand.ExecuteNonQuery()
                    Conexion.Close()

                    Dim unidadobt As String
                    unidadobt = dgvreg.Rows(j).Cells("unidad").Value.ToString
                    adaptar.UpdateCommand = New SqlCommand("update inventario set stock= stock+'" & unidadobt & "' where nom_prod='" & dgvreg.Rows(j).Cells("descripcion").Value.ToString & "'", Conexion)
                    Conexion.Open()
                    adaptar.UpdateCommand.ExecuteNonQuery()
                    Conexion.Close()
                Next
                ' parametrolimpieza()
                MessageBox.Show("Eliminado Exitosamente")
                limpiar()
                dgvreg2.Rows.Clear()
                dgvreg.Rows.Clear()
                Me.Hide()
                '  FrmMantenimientosMaq.Close()

            End If
            If result = DialogResult.No Then

            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub breiniciar_Click(sender As Object, e As EventArgs) Handles breiniciar.Click
        dgvinventario.Visible = False
        bagrlista.Enabled = False
        ccampos.Text = Nothing
        tcriterio.Text = Nothing
        codp2.Text = Nothing
        codp1.Text = Nothing
        tnombre.Text = Nothing
        ccategoria.Text = Nothing
        tproveedor.Text = Nothing
        cstock.Value = 0
        ncantidadinv.Value = 0
        tvalores.Text = Nothing
        pfoto3.Image = Nothing
        pfoto4.Image = Nothing
        tcriterio.Enabled = False
        ccampos.Enabled = False
        btnbuscar.Enabled = False
    End Sub
    Private Sub limpiar()
        dgvinventario.Visible = False
        bagrlista.Enabled = False
        ccampos.Text = Nothing
        tcriterio.Text = Nothing
        codp2.Text = Nothing
        codp1.Text = Nothing
        tnombre.Text = Nothing
        ccategoria.Text = Nothing
        tproveedor.Text = Nothing
        cstock.Value = 0
        ncantidadinv.Value = 0
        tvalores.Text = Nothing
        pfoto3.Image = Nothing
        pfoto4.Image = Nothing
        tcriterio.Enabled = False
        ccampos.Enabled = False
        btnbuscar.Enabled = False
    End Sub

    Private Sub tvalores_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tvalores.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
            If Asc(e.KeyChar) = 46 Then
                e.Handled = False
            End If
        End If
    End Sub

    Private Sub dgvreg_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvreg.RowPostPaint
        Me.dgvreg.Rows(e.RowIndex).Cells(1).Value = (e.RowIndex + 1).ToString
    End Sub

    Private Sub dgvreg2_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvreg2.RowPostPaint
        Me.dgvreg2.Rows(e.RowIndex).Cells(1).Value = (e.RowIndex + 1).ToString
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        sql = "select * from registro_mantenimientos where codigo_vh='" & tcodv.Text & "'"
        Try
            ' Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "registro_mantenimientos")
            resultado = almacen.Tables("registro_mantenimientos").Rows.Count
            If almacen.Tables(0).Rows.Count <> 0 Then
                For j As Integer = 0 To almacen.Tables(0).Rows.Count - 1 Step +1
                    dgvreg.Rows.Add(almacen.Tables(0).Rows(j)("id").ToString(), "", almacen.Tables(0).Rows(j)("unidad").ToString(), almacen.Tables(0).Rows(j)("descripcion").ToString(), almacen.Tables(0).Rows(j)("valor").ToString(), almacen.Tables(0).Rows(j)("valor_total").ToString(), almacen.Tables(0).Rows(j)("razon").ToString(), almacen.Tables(0).Rows(j)("fecha").ToString())
                Next
            End If

            If resultado = 0 Then
                chkfiltro.Visible = False
            ElseIf resultado > 0 Then
                chkfiltro.Visible = True
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Conexion.Close()
        Timer1.Enabled = False
    End Sub


    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.fechahora.Text = Now
    End Sub

    Private Sub FrmMantenimientosMaq_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        sql = "select * from registro_mantenimientos where codigo_vh='" & tcodv.Text & "'"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "registro_mantenimientos")
            resultado = almacen.Tables("registro_mantenimientos").Rows.Count
            If resultado > 0 Then
                Conexion.Close()
                Dim result As DialogResult
                result = MessageBox.Show("Desea Salir? Inventario retornando de segundo cuadro si hay datos!!!", "Saliendo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    For j As Integer = 0 To dgvreg2.Rows.Count - 1 Step +1
                        Dim unidadobt As String
                        unidadobt = dgvreg2.Rows(j).Cells("Unidad2").Value.ToString
                        adaptar.UpdateCommand = New SqlCommand("update inventario set stock= stock+'" & unidadobt & "' where nom_prod='" & dgvreg2.Rows(j).Cells("Descripcion2").Value.ToString & "'", Conexion)
                        Conexion.Open()
                        adaptar.UpdateCommand.ExecuteNonQuery()
                        Conexion.Close()
                    Next
                    e.Cancel = False
                ElseIf result = DialogResult.No Then
                    e.Cancel = True
                End If
            End If

            If resultado = 0 Then
                Conexion.Close()
                Dim result2 As DialogResult
                result2 = MessageBox.Show("Desea Salir? Inventario retornando de primer cuadro si hay datos!!!", "Saliendo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result2 = DialogResult.Yes Then

                    For j As Integer = 0 To dgvreg.Rows.Count - 1 Step +1
                        Dim unidadobt As String
                        unidadobt = dgvreg.Rows(j).Cells("Unidad").Value.ToString
                        adaptar.UpdateCommand = New SqlCommand("update inventario set stock= stock+'" & unidadobt & "' where nom_prod='" & dgvreg.Rows(j).Cells("Descripcion").Value.ToString & "'", Conexion)
                        Conexion.Open()
                        adaptar.UpdateCommand.ExecuteNonQuery()
                        Conexion.Close()
                    Next
                    e.Cancel = False
                ElseIf result2 = DialogResult.No Then
                    e.Cancel = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub bimprimir_Click(sender As Object, e As EventArgs) Handles bimprimir.Click
        If chkfiltro.Checked = False Then
            FrmMantenimientosMaqImpr3.tcodv.Text = Me.tcodv.Text
            FrmMantenimientosMaqImpr3.ShowDialog()
        ElseIf chkfiltro.Checked = True Then
            FrmMantenimientosMaqImpr4.tcodv.Text = Me.tcodv.Text
            FrmMantenimientosMaqImpr4.ShowDialog()
        End If

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        If chkfiltro.Checked = True Then
            vall1 = vall1 + 1

            Dim suma As Decimal = 0.0

            For Each row As DataGridViewRow In dgvreg.Rows
                suma += Val(row.Cells("ValorT").Value)
            Next

            txtTotal.Text = suma.ToString("L #,##0.00")

        ElseIf chkfiltro.Checked = False Then

            vall1 = vall1 + 1

            Dim suma As Decimal = 0.0

            For Each row As DataGridViewRow In dgvreg.Rows
                suma += Val(row.Cells("ValorT").Value)
            Next

            txtTotal.Text = suma.ToString("L #,##0.00")
        End If
 
    End Sub

    Private Sub tcodv_TextChanged(sender As Object, e As EventArgs) Handles tcodv.TextChanged
        Timer1.Enabled = True
    End Sub

    Private Sub chkfiltro_CheckedChanged(sender As Object, e As EventArgs) Handles chkfiltro.CheckedChanged

        If chkfiltro.Checked = False Then

            dtp1.Visible = False
            dtp2.Visible = False
            dgvreg.Rows.Clear()
            UsuarioconPriv()
            Timer1.Enabled = True


        ElseIf chkfiltro.Checked = True Then

            dtp1.Visible = True
            dtp2.Visible = True
            dtp1.Value = Convert.ToDateTime(dgvreg.Rows(0).Cells("Fecha").Value)
            dtp1.Format = DateTimePickerFormat.Short
            dgvreg.Rows.Clear()
            dtp2.Text = Now
            beliminarreg.Enabled = False
            bagregar.Enabled = False
            beliminar.Enabled = False
            Timer5.Enabled = True

        End If

    End Sub
    Private Sub UsuarioconPriv()
        If FrmPrincipal.lrol.Text = "Administrador" Then
            beliminar.Enabled = True
            beliminarreg.Enabled = True
            bagregar.Enabled = True
        ElseIf FrmPrincipal.lrol.Text = "Administracion" Then
            beliminar.Enabled = True
            beliminarreg.Enabled = True
            bagregar.Enabled = True
        ElseIf FrmPrincipal.lrol.Text = "Dueño" Then
            beliminar.Enabled = True
            beliminarreg.Enabled = True
            bagregar.Enabled = True
        Else
            beliminar.Enabled = False
            beliminarreg.Enabled = False
            bagregar.Enabled = True
        End If
    End Sub
    Private Sub dtp2_ValueChanged(sender As Object, e As EventArgs) Handles dtp2.ValueChanged
        dgvreg.Rows.Clear()
        Timer5.Enabled = True
        If dtp2.Value < dtp1.Value Then
            dtp2.Value = Now
        ElseIf dtp1.Value > dtp2.Value Then
            dtp1.Value = Now
        End If
    End Sub

    Private Sub dtp1_ValueChanged(sender As Object, e As EventArgs) Handles dtp1.ValueChanged
        dgvreg.Rows.Clear()
        Timer5.Enabled = True
        If dtp1.Value > dtp2.Value Then
            dtp1.Value = Now
        ElseIf dtp2.Value < dtp1.Value Then
            dtp2.Value = Now
        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick

        Dim fechaIni As String = dtp1.Value.ToString("yyyy-MM-dd")
        Dim fechaFin As String = dtp2.Value.ToString("yyyy-MM-dd")

        sql = "select * from registro_mantenimientos where codigo_vh='" & tcodv.Text & "' and fecha between'" & fechaIni & "' and '" & fechaFin & "'"

        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "registro_mantenimientos")
            resultado = almacen.Tables("registro_mantenimientos").Rows.Count
            If almacen.Tables(0).Rows.Count <> 0 Then

                For j As Integer = 0 To almacen.Tables(0).Rows.Count - 1 Step +1
                    dgvreg.Rows.Add(almacen.Tables(0).Rows(j)("id").ToString(), "", almacen.Tables(0).Rows(j)("unidad").ToString(), almacen.Tables(0).Rows(j)("descripcion").ToString(), almacen.Tables(0).Rows(j)("valor").ToString(), almacen.Tables(0).Rows(j)("valor_total").ToString(), almacen.Tables(0).Rows(j)("razon").ToString(), almacen.Tables(0).Rows(j)("fecha").ToString())
                Next

            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Conexion.Close()
        Timer5.Enabled = False

    End Sub

    Private Sub dgvreg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvreg.CellContentClick
        dgvreg2.ClearSelection()
    End Sub

    Private Sub dgvreg2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvreg2.CellContentClick
        dgvreg.ClearSelection()
    End Sub
End Class