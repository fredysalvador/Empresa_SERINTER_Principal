Imports System.Data.SqlClient
Imports System.Data
Imports System.Runtime.InteropServices
Public Class FrmHojaSalida
    Dim Vehiculoext As String
    Dim Psext As String
    Dim hora_elab As Date
    Private Sub FrmPaseSalida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion = New SqlConnection
        Conexion.ConnectionString = cadena
        adaptar = New SqlDataAdapter(sql, Conexion)
    End Sub

    Private Sub bagrlista_Click(sender As Object, e As EventArgs) Handles bagrlista.Click
        Dim nombre As String
        Dim item As String
        Dim cantidad As String
        Dim id1 As String


        Dim Valor As String
        Valor = Me.tnombre.Text
        Dim existe As Boolean = Me.dgvreg.Rows.Cast(Of DataGridViewRow).Any(Function(x) CStr(x.Cells("descripcion").Value) = Valor)

        If Not existe Then

            sql = "select * from salida_inventario where no_salida='" & nosalida.Text & "'"
            Try
                Conexion.Open()
                adaptar = New SqlDataAdapter(sql, Conexion)
                almacen = New DataSet
                adaptar.Fill(almacen, "salida_inventario")
                resultado = almacen.Tables("salida_inventario").Rows.Count


                If resultado = 0 Then

                    If ncantidadinv.Value = 0 Then
                        mensaje.Text = "Agregue una Cantidad Valida"
                        Conexion.Close()
                        Exit Sub
                    End If

                    mensaje.Text = "Mensajes"
                    id1 = dgvreg.Rows.Count.ToString
                    item = dgvreg.Rows.Count.ToString
                    cantidad = ncantidadinv.Value
                    nombre = dgvinventario(2, dgvinventario.CurrentRow.Index).Value
                    dgvreg.Rows.Add(id1, item, cantidad, nombre)
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
                    cstock.Value = 0.0
                    ncantidadinv.Value = 0.0
                    pfoto.Image = Nothing
                    pfoto2.Image = Nothing
                    ActualizarINV()

                ElseIf resultado > 0 Then

                    dgvreg.ClearSelection()
                    If ncantidadinv.Value = 0.0 Then
                        mensaje.Text = "Agregue una Cantidad Valida"
                        Conexion.Close()
                        Exit Sub
                    End If

                    mensaje.Text = "Mensajes"
                    id1 = dgvreg.Rows.Count.ToString
                    item = dgvreg2.Rows.Count.ToString
                    cantidad = ncantidadinv.Value
                    nombre = dgvinventario(2, dgvinventario.CurrentRow.Index).Value
                    dgvreg2.Rows.Add(id1, item, cantidad, nombre)
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
                    cstock.Value = 0.0
                    ncantidadinv.Value = 0.0
                    pfoto.Image = Nothing
                    pfoto2.Image = Nothing
                    ActualizarINV()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        Conexion.Close()
        dgvinventario.Refresh()

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
        pfoto.Image = dgvinventario.CurrentRow.Cells("foto1").FormattedValue
        pfoto.SizeMode = PictureBoxSizeMode.StretchImage
        pfoto2.Image = dgvinventario.CurrentRow.Cells("foto2").FormattedValue
        pfoto2.SizeMode = PictureBoxSizeMode.StretchImage


        If ncantidadinv.Value > cstock.Value Then
            ncantidadinv.Value = cstock.Value
        End If

        dgvvehiculos.ClearSelection()

    End Sub

    Private Sub bdatagridveh_Click(sender As Object, e As EventArgs) Handles bdatagridveh.Click
        dgvvehiculos.Visible = True
        bagrlista2.Enabled = True
        btnbuscar2.Enabled = True
        ccampos2.Enabled = True
        tcriterio2.Enabled = True
        sql = "select * from maquinaria order by codigo_vh"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "maquinaria")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        dgvvehiculos.DataSource = almacen
        dgvvehiculos.DataMember = "maquinaria"
        dgvvehiculos.Columns(0).HeaderText = "codigo_vh"
        dgvvehiculos.Columns(1).Visible = False
        dgvvehiculos.Columns(2).HeaderText = "placa_vh"
        dgvvehiculos.Columns(3).Visible = False
        dgvvehiculos.Columns(4).Visible = False
        dgvvehiculos.Columns(5).HeaderText = "estado_vh"
        dgvvehiculos.Columns(6).Visible = False
        dgvvehiculos.Columns(7).Visible = False
        dgvvehiculos.Columns(8).Visible = False
        dgvvehiculos.Columns(9).Visible = False
        dgvvehiculos.Columns(10).Visible = False
        dgvvehiculos.Columns(11).Visible = False
        dgvvehiculos.Columns(12).Visible = False
        dgvvehiculos.Columns(13).Visible = False
        dgvvehiculos.Columns(14).Visible = False
        dgvvehiculos.Columns(15).Visible = False
        dgvvehiculos.Columns(16).Visible = False
        dgvvehiculos.Columns(17).Visible = False
        dgvvehiculos.Columns(18).Visible = False
        dgvvehiculos.Columns(19).Visible = False
        dgvvehiculos.Columns(20).Visible = False
        ' dgvvehiculos.AutoResizeColumns()
        dgvvehiculos.Columns(0).Width = 60
        dgvvehiculos.Columns(2).Width = 110 'Ancho Especifico
        dgvvehiculos.Columns(5).Width = 120
        dgvvehiculos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvvehiculos.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvvehiculos.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvvehiculos.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        'dgvvehiculos.Columns(9).DefaultCellStyle.NullValue = My.Resources.subir
        'dgvvehiculos.Columns(10).DefaultCellStyle.NullValue = My.Resources.subir

        dgvvehiculos.Columns(9).DefaultCellStyle.NullValue = Nothing
        dgvvehiculos.Columns(10).DefaultCellStyle.NullValue = Nothing

        dgvvehiculos.ClearSelection()
        Conexion.Close()

        dgvvehiculos.Refresh()
    End Sub

    Private Sub dgvvehiculos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvvehiculos.CellContentClick
        codigovh.Text = dgvvehiculos.CurrentRow.Cells.Item(0).Value.ToString
        placavh.Text = dgvvehiculos.CurrentRow.Cells.Item(2).Value.ToString
        pfoto3.Image = dgvvehiculos.CurrentRow.Cells("foto1").FormattedValue
        pfoto3.SizeMode = PictureBoxSizeMode.StretchImage
        pfoto4.Image = dgvvehiculos.CurrentRow.Cells("foto2").FormattedValue
        pfoto4.SizeMode = PictureBoxSizeMode.StretchImage


        For Each Row As DataGridViewRow In dgvvehiculos.SelectedRows
            Dim estadods As String = Row.Cells("estado_vh").Value
            If estadods = "Disponible" Then
                estadovh.Text = "Disponible"

            ElseIf estadods = "Utilizado" Then
                estadovh.Text = "No esta disponible"

            ElseIf estadods = "Dañado" Then
                estadovh.Text = "Dañado"

            ElseIf estadods = "Mantenimiento" Then
                estadovh.Text = "En Reparacion"
            End If
        Next


        codp2.Text = Nothing
        codp1.Text = Nothing
        tnombre.Text = Nothing
        ccategoria.Text = Nothing
        tproveedor.Text = Nothing
        ncantidadinv.Value = 0

        dgvinventario.ClearSelection()
    End Sub

    Private Sub bagrlista2_Click(sender As Object, e As EventArgs) Handles bagrlista2.Click
        Dim nombrea As String
        Dim itema As String
        Dim destino As String
        Dim cantidad As String
        Dim id1 As String
        Dim Valor2 As String
        Valor2 = Me.codigovh.Text
        Dim existe2 As Boolean = Me.dgvreg.Rows.Cast(Of DataGridViewRow).Any(Function(x) CStr(x.Cells("descripcion").Value) = Valor2)

        'If Not existe2 Then

        For Each Row As DataGridViewRow In dgvvehiculos.SelectedRows
            Dim estadods As String = Row.Cells("estado_vh").Value
            Dim codvhds As String = Row.Cells("codigo_vh").Value


            sql = "select * from salida_inventario where no_salida='" & nosalida.Text & "'"
            Try
                Conexion.Open()
                adaptar = New SqlDataAdapter(sql, Conexion)
                almacen = New DataSet
                adaptar.Fill(almacen, "salida_inventario")
                resultado = almacen.Tables("salida_inventario").Rows.Count


                If resultado = 0 Then
                    id1 = dgvreg.Rows.Count.ToString
                    itema = dgvreg.Rows.Count.ToString
                    destino = Cdestiny.Text
                    cantidad = 1
                    nombrea = dgvvehiculos(0, dgvvehiculos.CurrentRow.Index).Value
                    dgvreg.Rows.Add(id1, itema, destino, nombrea, cantidad)

                    'ElseIf estadods <> "Utilizado" And codvhds <> codigovh.Text Then
                    '    mensaje.Text = "No Se Puede Agregar"

                    'ElseIf estadods = "Utilizado" And codvhds = codigovh.Text Then
                    '    itema = dgvreg.Rows.Count.ToString
                    '    cantidad = 1
                    '    nombrea = dgvvehiculos(0, dgvvehiculos.CurrentRow.Index).Value
                    '    dgvreg.Rows.Add(itema, cantidad, nombrea)

                ElseIf resultado > 0 Then
                    id1 = dgvreg2.Rows.Count.ToString
                    itema = dgvreg2.Rows.Count.ToString
                    destino = Cdestiny.Text
                    cantidad = 1
                    nombrea = dgvvehiculos(0, dgvvehiculos.CurrentRow.Index).Value
                    dgvreg2.Rows.Add(id1, itema, destino, cantidad, nombrea)

                    'ElseIf estadods <> "Utilizado" And codvhds <> codigovh.Text Then
                    '    mensaje.Text = "No Se Puede Agregar"

                    'ElseIf estadods = "Utilizado" And codvhds = codigovh.Text Then
                    '    itema = dgvreg2.Rows.Count.ToString
                    '    cantidad = 1
                    '    nombrea = dgvvehiculos(0, dgvvehiculos.CurrentRow.Index).Value
                    '    dgvreg2.Rows.Add(itema, cantidad, nombrea)
                End If
            Catch ex As Exception

            End Try
        Next
        '        End If


        'If resultado > 0 Then
        '    registro = almacen.Tables("salida_inventario").Rows(0)
        '    If Not IsDBNull(registro("codigo_vh")) Then
        '        codigovh.Text = registro("codigo_vh")
        '    End If
        '    If Not IsDBNull(registro("placa_vh")) Then
        '        placavh.Text = registro("placa_vh")
        '    End If
        '    If Not IsDBNull(registro("estado_vh")) Then
        '        estadovh.Text = registro("estado_vh")
        '    End If
        'End If

        Conexion.Close()
    End Sub

    Private Sub bagregar_Click(sender As Object, e As EventArgs) Handles bagregar.Click

        Dim hora_elab As DateTime = Now
        Dim hora_elabString As String = hora_elab.ToString("dd.MM.yyyy HH:mm:ss")

        If rbexistvh.Checked = True Then
            Vehiculoext = "Vehiculo en Sistema"
        ElseIf rbexistvh.Checked = False Then
            Vehiculoext = "Vehiculo Particular"
        End If

        If cestadpase.Text = "" Then
            Psext = "Activo"
        ElseIf cestadpase.Text = "Inactivo" Then
            Psext = "Inactivo"
        ElseIf cestadpase.Text = "Activo" Then
            Psext = "Activo"
        End If

        If nosalida.Text = Nothing Then
            mensaje.Text = "Dejo vacio el Numero de salida"
            nosalida.Focus()
            Exit Sub
        ElseIf categoria.Text = Nothing Then
            mensaje.Text = "Dejo vacio la categoria del pase de salida"
            categoria.Focus()
            Exit Sub
        ElseIf tmorotris.Text = Nothing Then
            mensaje.Text = "Dejo vacio el campo motorista"
            tmorotris.Focus()
            Exit Sub
        ElseIf tdestiny.Text = Nothing Then
            mensaje.Text = "Dejo vacio el destino"
            tdestiny.Focus()
            Exit Sub
        End If
        sql = "select * from salida_inventario where no_salida='" & nosalida.Text & "'"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "salida_inventario")
            resultado = almacen.Tables("salida_inventario").Rows.Count
            If resultado > 0 Then
                Conexion.Close()
                Dim result As DialogResult
                result = MessageBox.Show("Desea Agregar Nuevos Registros?", "Actualizado!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then

                    For Each Row As DataGridViewRow In dgvreg2.Rows

                        Dim item2 As String = Row.Cells("item2").Value
                        Dim unidad2 As String = Row.Cells("unidad2").Value
                        Dim cdestino2 As String = Row.Cells("cdestino2").Value
                        Dim descripcionds2 As String = Row.Cells("descripcion2").Value
                        Dim observacion2 As String = Row.Cells("observacion2").Value

                        adaptar.InsertCommand = New SqlCommand("Insert into salida_inventario (no_salida, item, unidad, item_destino , descripcion, observacion, codigo_vh, estado_vh, vhexist, placa_vh, categoriaps, hrm1, hrm2, klm1, klm2, motorista, acompañante, destino, fecha_retorno, fecha_salida, estado_ficha, fecha_hora) values ('" & nosalida.Text & "', '" & item2 & "', '" & unidad2 & "', '" & cdestino2 & "', '" & descripcionds2 & "', '" & observacion2 & "', '" & codigovh.Text & "', '" & estadovh.Text & "', '" & Vehiculoext & "', '" & placavh.Text & "', '" & categoria.Text & "', '" & hrm1.Text & "', '" & hrm2.Text & "', '" & km1.Text & "', '" & km2.Text & "', '" & tmorotris.Text & "', '" & tpartner.Text & "', '" & tdestiny.Text & "', '" & dtpretorno.Text & "', '" & dtpsalida.Text & "', '" & Psext & "', '" & hora_elabString & "')", Conexion)
                        Conexion.Open()
                        adaptar.InsertCommand.ExecuteNonQuery()
                        Conexion.Close()
                    Next


                        adaptar.UpdateCommand = New SqlCommand("update salida_inventario set codigo_vh='" & codigovh.Text & "',placa_vh='" & placavh.Text & "',estado_vh='" & estadovh.Text & "',categoriaps='" & categoria.Text & "',hrm1='" & hrm1.Text & "',hrm2='" & hrm2.Text & "',klm1='" & km1.Text & "',klm2='" & km2.Text & "',motorista='" & tmorotris.Text & "',acompañante='" & tpartner.Text & "',destino='" & tdestiny.Text & "',fecha_retorno='" & dtpretorno.Text & "',fecha_salida='" & dtpsalida.Text & "',vhexist='" & Vehiculoext & "',estado_ficha='" & Psext & "' where no_salida='" & nosalida.Text & "'", Conexion)
                        Conexion.Open()
                        adaptar.UpdateCommand.ExecuteNonQuery()
                        Conexion.Close()

                        For Each Row As DataGridViewRow In dgvreg.Rows
                        Dim id1 As String = Row.Cells("id1").Value
                        Dim item As String = Row.Cells("item").Value
                        Dim unidad As String = Row.Cells("unidad").Value
                        Dim cdestino1 As String = Row.Cells("cdestino1").Value
                            Dim descripcionds As String = Row.Cells("descripcion").Value
                            Dim observacion As String = Row.Cells("observacion").Value
                        adaptar.UpdateCommand = New SqlCommand("update salida_inventario set item='" & item & "',unidad='" & unidad & "',item_destino='" & cdestino1 & "',descripcion='" & descripcionds & "',observacion='" & observacion & "' where no_salida='" & nosalida.Text & "'and id='" & id1 & "'", Conexion)
                            Conexion.Open()
                            adaptar.UpdateCommand.ExecuteNonQuery()
                            Conexion.Close()
                        Next



                    MessageBox.Show("Actualizado Exitosamente")
                    limpiar()
                    nosalida.Enabled = True
                    chknvregistro.Enabled = True
                    chknvregistro.Checked = False
                    rbexistvh.Checked = True

                ElseIf result = DialogResult.No Then

                    For j As Integer = 0 To dgvreg2.Rows.Count - 1 Step +1
                        Dim unidadobt As String
                        unidadobt = dgvreg2.Rows(j).Cells("unidad2").Value.ToString
                        adaptar.UpdateCommand = New SqlCommand("update inventario set stock= stock+'" & unidadobt & "' where nom_prod='" & dgvreg2.Rows(j).Cells("descripcion2").Value.ToString & "'", Conexion)
                        Conexion.Open()
                        adaptar.UpdateCommand.ExecuteNonQuery()
                        Conexion.Close()
                    Next
                    dgvreg2.Rows.Clear()
                    ActualizarINV()
                End If



                If rbexistvh.Checked = False Then
                    codigovh.Enabled = True
                    estadovh.Enabled = True
                    placavh.Enabled = True
                ElseIf rbexistvh.Checked = True Then
                    codigovh.Enabled = False
                    estadovh.Enabled = False
                    placavh.Enabled = False
                End If
                bdatagridveh.Enabled = False
                bdatagridinv.Enabled = False
                nosalida.Enabled = True
            End If


            If resultado = 0 Then
                Conexion.Close()
                Dim result2 As DialogResult
                result2 = MessageBox.Show("Desea Guardar?", "Guardar!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result2 = DialogResult.Yes Then

                    For Each Row As DataGridViewRow In dgvreg.Rows

                        Dim item As String = Row.Cells("item").Value
                        Dim unidad As String = Row.Cells("unidad").Value
                        Dim cdestino1 As String = Row.Cells("cdestino1").Value
                        Dim descripcionds As String = Row.Cells("descripcion").Value
                        Dim observacion As String = Row.Cells("observacion").Value

                        adaptar.InsertCommand = New SqlCommand("Insert into salida_inventario (no_salida, item, unidad, item_destino,  descripcion, observacion, codigo_vh, estado_vh, vhexist, placa_vh, categoriaps, hrm1, hrm2, klm1, klm2, motorista, acompañante, destino, fecha_retorno, fecha_salida, estado_ficha, fecha_hora) values ('" & nosalida.Text & "', '" & item & "', '" & unidad & "', '" & cdestino1 & "', '" & descripcionds & "', '" & observacion & "', '" & codigovh.Text & "', '" & estadovh.Text & "', '" & Vehiculoext & "', '" & placavh.Text & "', '" & categoria.Text & "', '" & hrm1.Text & "', '" & hrm2.Text & "', '" & km1.Text & "', '" & km2.Text & "', '" & tmorotris.Text & "', '" & tpartner.Text & "', '" & tdestiny.Text & "', '" & dtpretorno.Text & "', '" & dtpsalida.Text & "', '" & Psext & "', '" & hora_elabString & "')", Conexion)
                        Conexion.Open()
                        adaptar.InsertCommand.ExecuteNonQuery()
                        Conexion.Close()
                    Next




                    MessageBox.Show("Guardado Exitosamente")
                    limpiar()
                    nosalida.Enabled = True
                    chknvregistro.Enabled = True
                    chknvregistro.Checked = False
                ElseIf result2 = DialogResult.No Then
                    For j As Integer = 0 To dgvreg.Rows.Count - 1 Step +1
                        Dim unidadobt As String
                        unidadobt = dgvreg.Rows(j).Cells("unidad").Value.ToString
                        adaptar.UpdateCommand = New SqlCommand("update inventario set stock= stock+'" & unidadobt & "' where nom_prod='" & dgvreg.Rows(j).Cells("descripcion").Value.ToString & "'", Conexion)
                        Conexion.Open()
                        adaptar.UpdateCommand.ExecuteNonQuery()
                        Conexion.Close()
                    Next
                    dgvreg.Rows.Clear()
                    ActualizarINV()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub limpiar()
        nosalida.Text = Nothing
        limpiarparcial()
    End Sub

    Private Sub limpiarparcial()
        codigovh.Text = Nothing
        estadovh.Text = Nothing
        placavh.Text = Nothing
        categoria.Text = Nothing
        hrm1.Text = Nothing
        hrm2.Text = Nothing
        km1.Text = Nothing
        km2.Text = Nothing
        tmorotris.Text = Nothing
        tpartner.Text = Nothing
        tdestiny.Text = Nothing
        codp2.Text = Nothing
        codp1.Text = Nothing
        tnombre.Text = Nothing
        ccategoria.Text = Nothing
        tproveedor.Text = Nothing
        ncantidadinv.Value = 0.0
        dgvreg.Rows.Clear()
        dgvreg2.Rows.Clear()
        pfoto.Image = Nothing
        pfoto2.Image = Nothing
        pfoto3.Image = Nothing
        pfoto4.Image = Nothing
        tcriterio.Text = Nothing
        tcriterio2.Text = Nothing
        ccampos.Text = Nothing
        ccampos2.Text = Nothing
        dtpsalida.Value = Now
        dtpretorno.Value = Now
        cestadpase.Text = Nothing
    End Sub

    Private Sub dgvreg_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvreg.RowPostPaint
        Me.dgvreg.Rows(e.RowIndex).Cells(1).Value = (e.RowIndex + 1).ToString
    End Sub

    Private Sub nosalida_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nosalida.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            nosalida_Validated(sender, e)
            mensaje.Text = "Mensajes"
            nosalida.Enabled = False
        End If
    End Sub

    Private Sub nosalida_Validated(sender As Object, e As EventArgs) Handles nosalida.Validated
        'almacen.Tables(0).Rows(j)("item").ToString(),
        If nosalida.Text = Nothing Then
            mensaje.Text = "Dejo vacio el numero de salida"
            nosalida.Focus()
            Exit Sub
        End If
        '  limpiar()
        dgvreg.Rows.Clear()
        dgvinventario.Visible = False
        dgvvehiculos.Visible = False
        sql = "select * from salida_inventario where no_salida='" & nosalida.Text & "'"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "salida_inventario")
            resultado = almacen.Tables("salida_inventario").Rows.Count
            If almacen.Tables(0).Rows.Count <> 0 Then
                For j As Integer = 0 To almacen.Tables(0).Rows.Count - 1 Step +1
                    dgvreg.Rows.Add(almacen.Tables(0).Rows(j)("id").ToString(), "", almacen.Tables(0).Rows(j)("item_destino").ToString(), almacen.Tables(0).Rows(j)("descripcion").ToString(), almacen.Tables(0).Rows(j)("unidad").ToString(), almacen.Tables(0).Rows(j)("observacion").ToString())
                Next
            End If
            If resultado > 0 Then

                registro = almacen.Tables("salida_inventario").Rows(0)
                If Not IsDBNull(registro("codigo_vh")) Then
                    codigovh.Text = registro("codigo_vh")
                End If
                If Not IsDBNull(registro("placa_vh")) Then
                    placavh.Text = registro("placa_vh")
                End If
                If Not IsDBNull(registro("categoriaps")) Then
                    categoria.Text = registro("categoriaps")
                End If
                If Not IsDBNull(registro("estado_vh")) Then
                    estadovh.Text = registro("estado_vh")
                End If
                If Not IsDBNull(registro("hrm1")) Then
                    hrm1.Text = registro("hrm1")
                End If
                If Not IsDBNull(registro("hrm2")) Then
                    hrm2.Text = registro("hrm2")
                End If
                If Not IsDBNull(registro("klm1")) Then
                    km1.Text = registro("klm1")
                End If
                If Not IsDBNull(registro("klm2")) Then
                    km2.Text = registro("klm2")
                End If
                If Not IsDBNull(registro("motorista")) Then
                    tmorotris.Text = registro("motorista")
                End If
                If Not IsDBNull(registro("acompañante")) Then
                    tpartner.Text = registro("acompañante")
                End If
                If Not IsDBNull(registro("destino")) Then
                    tdestiny.Text = registro("destino")
                End If
                If Not IsDBNull(registro("fecha_salida")) Then
                    dtpsalida.Value = registro("fecha_salida")
                End If
                If Not IsDBNull(registro("fecha_retorno")) Then
                    dtpretorno.Value = registro("fecha_retorno")
                End If
                If Not IsDBNull(registro("vhexist")) Then
                    If registro("vhexist") = "Vehiculo en Sistema" Then
                        rbexistvh.Checked = True
                    ElseIf registro("vhexist") = "Vehiculo Particular" Then
                        rbexistvh.Checked = False
                    End If

                    If Not IsDBNull(registro("estado_ficha")) Then
                        cestadpase.Text = registro("estado_ficha")
                    End If
                End If
            End If
            If cestadpase.Text = "Inactivo" Then
                beliminarreg.Enabled = False
                bdatagridinv.Enabled = False
                bdatagridveh.Enabled = False
                beliminar.Enabled = False
                bimprimir.Enabled = True
            ElseIf cestadpase.Text = "Activo" Then
                beliminarreg.Enabled = True
                bdatagridinv.Enabled = True
                bdatagridveh.Enabled = True
                beliminar.Enabled = True
            End If

            If rbexistvh.Checked = False Then
                codigovh.Enabled = True
                estadovh.Enabled = True
                placavh.Enabled = True
                bdatagridveh.Enabled = False
                dgvvehiculos.Visible = False
            ElseIf rbexistvh.Checked = True Then
                codigovh.Enabled = False
                estadovh.Enabled = False
                placavh.Enabled = False
                bdatagridveh.Enabled = True
            End If
            chknvregistro.Enabled = False

            If resultado = 0 Then

                beliminar.Enabled = False
                beliminarreg.Enabled = True
                bdatagridinv.Enabled = True
                bdatagridveh.Enabled = True
                rbexistvh.Checked = True
                chknvregistro.Enabled = False

                limpiarparcial()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Conexion.Close()
        categoria.Focus()
    End Sub
    Private Sub validprev()
        sql = "select * from salida_inventario where no_salida='" & nosalida.Text & "'"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "salida_inventario")
            resultado = almacen.Tables("salida_inventario").Rows.Count
            If resultado > 0 Then
                If almacen.Tables(0).Rows.Count <> 0 Then
                    For j As Integer = 0 To almacen.Tables(0).Rows.Count - 1 Step +1
                        dgvreg.Rows.Add(almacen.Tables(0).Rows(j)("id").ToString(), "", almacen.Tables(0).Rows(j)("item_destino").ToString(), almacen.Tables(0).Rows(j)("descripcion").ToString(), almacen.Tables(0).Rows(j)("unidad").ToString(), almacen.Tables(0).Rows(j)("observacion").ToString())
                    Next
                End If
                registro = almacen.Tables("salida_inventario").Rows(0)
                If Not IsDBNull(registro("codigo_vh")) Then
                    codigovh.Text = registro("codigo_vh")
                End If
                If Not IsDBNull(registro("placa_vh")) Then
                    placavh.Text = registro("placa_vh")
                End If
                If Not IsDBNull(registro("categoriaps")) Then
                    categoria.Text = registro("categoriaps")
                End If
                If Not IsDBNull(registro("estado_vh")) Then
                    estadovh.Text = registro("estado_vh")
                End If
                If Not IsDBNull(registro("hrm1")) Then
                    hrm1.Text = registro("hrm1")
                End If
                If Not IsDBNull(registro("hrm2")) Then
                    hrm2.Text = registro("hrm2")
                End If
                If Not IsDBNull(registro("klm1")) Then
                    km1.Text = registro("klm1")
                End If
                If Not IsDBNull(registro("klm2")) Then
                    km2.Text = registro("klm2")
                End If
                If Not IsDBNull(registro("motorista")) Then
                    tmorotris.Text = registro("motorista")
                End If
                If Not IsDBNull(registro("acompañante")) Then
                    tpartner.Text = registro("acompañante")
                End If
                If Not IsDBNull(registro("destino")) Then
                    tdestiny.Text = registro("destino")
                End If
                If Not IsDBNull(registro("fecha_salida")) Then
                    dtpsalida.Value = registro("fecha_salida")
                End If
                If Not IsDBNull(registro("fecha_retorno")) Then
                    dtpretorno.Value = registro("fecha_retorno")
                End If
                If Not IsDBNull(registro("vhexist")) Then
                    If registro("vhexist") = "Vehiculo en Sistema" Then
                        rbexistvh.Checked = True
                    ElseIf registro("vhexist") = "Vehiculo Particular" Then
                        rbexistvh.Checked = False
                    End If
                    If Not IsDBNull(registro("estado_ficha")) Then
                        cestadpase.Text = registro("estado_ficha")
                    End If
                End If
            End If
            If cestadpase.Text = "Inactivo" Then
                beliminarreg.Enabled = False
                bdatagridinv.Enabled = False
            ElseIf cestadpase.Text = "Activo" Then
                beliminarreg.Enabled = True
                bdatagridinv.Enabled = True
            End If


            If resultado = 0 Then
                beliminarreg.Enabled = True
                bdatagridinv.Enabled = True
                nosalida.Enabled = False
                limpiarparcial()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Conexion.Close()
    End Sub

    Private Sub bregresar_Click(sender As Object, e As EventArgs) Handles bregresar.Click
        'validprev()
        mensaje.Text = "Mensajes"
        sql = "select * from salida_inventario where no_salida='" & nosalida.Text & "'"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "salida_inventario")
            resultado = almacen.Tables("salida_inventario").Rows.Count
            If resultado > 0 Then
                Conexion.Close()
                Dim result As DialogResult
                result = MessageBox.Show("Desea Salir? Inventario retornando de segundo cuadro si hay datos!!!", "Saliendo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    For j As Integer = 0 To dgvreg2.Rows.Count - 1 Step +1
                        Dim unidadobt As String
                        unidadobt = dgvreg2.Rows(j).Cells("unidad2").Value.ToString
                        adaptar.UpdateCommand = New SqlCommand("update inventario set stock= stock+'" & unidadobt & "' where nom_prod='" & dgvreg2.Rows(j).Cells("descripcion2").Value.ToString & "'", Conexion)
                        Conexion.Open()
                        adaptar.UpdateCommand.ExecuteNonQuery()
                        Conexion.Close()
                    Next
                    FrmPrincipal.Show()
                    Me.Hide()
                    retornopr()
                ElseIf result = DialogResult.No Then
                    Me.Show()
                End If
            End If
            If resultado = 0 Then
                Conexion.Close()
                Dim result2 As DialogResult
                result2 = MessageBox.Show("Desea Salir? Inventario retornando de primer cuadro si hay datos!!!", "Saliendo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result2 = DialogResult.Yes Then
                    For j As Integer = 0 To dgvreg.Rows.Count - 1 Step +1
                        Dim unidadobt As String
                        unidadobt = dgvreg.Rows(j).Cells("unidad").Value.ToString
                        adaptar.UpdateCommand = New SqlCommand("update inventario set stock= stock+'" & unidadobt & "' where nom_prod='" & dgvreg.Rows(j).Cells("descripcion").Value.ToString & "'", Conexion)
                        Conexion.Open()
                        adaptar.UpdateCommand.ExecuteNonQuery()
                        Conexion.Close()
                    Next
                    FrmPrincipal.Show()
                    Me.Hide()
                    retornopr()
                ElseIf result2 = DialogResult.No Then
                    Me.Show()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub retornopr()

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

    Private Sub beliminar_Click(sender As Object, e As EventArgs) Handles beliminar.Click
        If nosalida.Text = Nothing Then
            mensaje.Text = "Dejo vacio el Numero de Salida"
            nosalida.Focus()
            Exit Sub
        End If
        Try

            Dim result As DialogResult
            result = MessageBox.Show("Desea Eliminar? El Inventariado Regresara nuevamente", "Eliminando!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                For j As Integer = 0 To dgvreg.Rows.Count - 1 Step +1
                    adaptar.DeleteCommand = New SqlCommand("delete from salida_inventario where no_salida='" & nosalida.Text & "'", Conexion)
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
                nosalida.Enabled = True

                If rbexistvh.Checked = False Then
                    codigovh.Enabled = True
                    estadovh.Enabled = True
                    placavh.Enabled = True
                ElseIf rbexistvh.Checked = True Then
                    codigovh.Enabled = False
                    estadovh.Enabled = False
                    placavh.Enabled = False

                End If
                ActualizarINV()
            End If
            If result = DialogResult.No Then

            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ncantidadinv_ValueChanged(sender As Object, e As EventArgs) Handles ncantidadinv.ValueChanged
        If ncantidadinv.Value > cstock.Value Then
            ncantidadinv.Value = cstock.Value
        End If
    End Sub

    Private Sub beliminarreg_Click(sender As Object, e As EventArgs) Handles beliminarreg.Click

        For Each Row As DataGridViewRow In dgvreg.SelectedRows
            Dim item As String = Row.Cells("item").Value
            Dim unidad As String = Row.Cells("unidad").Value
            Dim descripcionds As String = Row.Cells("descripcion").Value
            Dim observacion As String = Row.Cells("observacion").Value

            adaptar.UpdateCommand = New SqlCommand("update inventario set stock= stock+'" & unidad & "' where nom_prod='" & descripcionds & "'", Conexion)
            Conexion.Open()
            adaptar.UpdateCommand.ExecuteNonQuery()
            Conexion.Close()
        Next

        For Each Row As DataGridViewRow In dgvreg.SelectedRows

            Dim id1 As String = Row.Cells("ID1").Value
            Dim item As String = Row.Cells("item").Value
            Dim unidad As String = Row.Cells("unidad").Value
            Dim descripcionds As String = Row.Cells("descripcion").Value
            Dim observacion As String = Row.Cells("observacion").Value

            adaptar.DeleteCommand = New SqlCommand("delete from salida_inventario where no_salida='" & nosalida.Text & "' and descripcion='" & descripcionds & "' and unidad='" & unidad & "' and id='" & id1 & "'", Conexion)
            Conexion.Open()
            adaptar.DeleteCommand.ExecuteNonQuery()
            Conexion.Close()
            dgvreg.Rows.Remove(Row)
            dgvinventario.Refresh()
            dgvvehiculos.Refresh()
        Next

        For Each Row As DataGridViewRow In dgvreg2.SelectedRows
            Dim item2 As String = Row.Cells("item2").Value
            Dim unidad2 As String = Row.Cells("unidad2").Value
            Dim descripcionds2 As String = Row.Cells("descripcion2").Value
            Dim observacion2 As String = Row.Cells("observacion2").Value

            adaptar.UpdateCommand = New SqlCommand("update inventario set stock= stock+'" & unidad2 & "' where nom_prod='" & descripcionds2 & "'", Conexion)
            Conexion.Open()
            adaptar.UpdateCommand.ExecuteNonQuery()
            Conexion.Close()
            dgvreg2.Rows.Remove(Row)
        Next

        ActualizarINV()

    End Sub

    Private Sub hrm1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles hrm1.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            hrm2.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub hrm2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles hrm2.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            km1.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub km1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles km1.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            km2.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub km2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles km2.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tmorotris.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub tmorotris_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tmorotris.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tpartner.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub


    Private Sub breiniciar_Click(sender As Object, e As EventArgs) Handles breiniciar.Click
        sql = "select * from salida_inventario where no_salida='" & nosalida.Text & "'"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "salida_inventario")
            resultado = almacen.Tables("salida_inventario").Rows.Count
            If resultado > 0 Then
                Conexion.Close()
                Dim result As DialogResult
                result = MessageBox.Show("Limpiando, Inventario retornando de segundo cuadro si hay datos!!!", "Saliendo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    For j As Integer = 0 To dgvreg2.Rows.Count - 1 Step +1
                        Dim unidadobt As String
                        unidadobt = dgvreg2.Rows(j).Cells("unidad2").Value.ToString
                        adaptar.UpdateCommand = New SqlCommand("update inventario set stock= stock+'" & unidadobt & "' where nom_prod='" & dgvreg2.Rows(j).Cells("descripcion2").Value.ToString & "'", Conexion)
                        Conexion.Open()
                        adaptar.UpdateCommand.ExecuteNonQuery()
                        Conexion.Close()
                    Next
                    limpiar()
                    rbexistvh.Checked = True
                    dgvinventario.Visible = False
                    dgvvehiculos.Visible = False
                    mensaje.Text = "Mensajes"
                    bdatagridveh.Enabled = False
                    bdatagridinv.Enabled = False

                    chknvregistro.Enabled = True
                    chknvregistro.Checked = False
                    beliminar.Enabled = True
                    nosalida.Enabled = True
                    If rbexistvh.Checked = False Then
                        codigovh.Enabled = True
                        estadovh.Enabled = True
                        placavh.Enabled = True
                    ElseIf rbexistvh.Checked = True Then
                        codigovh.Enabled = False
                        estadovh.Enabled = False
                        placavh.Enabled = False
                    End If
                    bdatagridveh.Enabled = False
                    bdatagridinv.Enabled = False

                ElseIf result = DialogResult.No Then

                End If
            End If
            If resultado = 0 Then
                Conexion.Close()
                Dim result2 As DialogResult
                result2 = MessageBox.Show("Limpiando, Inventario retornando de primer cuadro si hay datos!!!", "Saliendo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result2 = DialogResult.Yes Then
                    For j As Integer = 0 To dgvreg.Rows.Count - 1 Step +1
                        Dim unidadobt As String
                        unidadobt = dgvreg.Rows(j).Cells("unidad").Value.ToString
                        adaptar.UpdateCommand = New SqlCommand("update inventario set stock= stock+'" & unidadobt & "' where nom_prod='" & dgvreg.Rows(j).Cells("descripcion").Value.ToString & "'", Conexion)
                        Conexion.Open()
                        adaptar.UpdateCommand.ExecuteNonQuery()
                        Conexion.Close()
                    Next
                    limpiar()
                    rbexistvh.Checked = True
                    dgvinventario.Visible = False
                    dgvvehiculos.Visible = False
                    mensaje.Text = "Mensajes"
                    bdatagridveh.Enabled = False
                    bdatagridinv.Enabled = False

                    beliminar.Enabled = True
                    nosalida.Enabled = True
                    chknvregistro.Enabled = True
                    chknvregistro.Checked = False
                    If rbexistvh.Checked = False Then
                        codigovh.Enabled = True
                        estadovh.Enabled = True
                        placavh.Enabled = True
                    ElseIf rbexistvh.Checked = True Then
                        codigovh.Enabled = False
                        estadovh.Enabled = False
                        placavh.Enabled = False
                    End If
                    bdatagridveh.Enabled = False
                    bdatagridinv.Enabled = False
                ElseIf result2 = DialogResult.No Then

                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub blimpieza2_Click(sender As Object, e As EventArgs) Handles blimpieza2.Click
        mensaje.Text = "Mensajes"
        btnbuscar2.Text = Nothing
        ccampos2.Text = Nothing
        tcriterio2.Text = Nothing
    End Sub

    Private Sub blimpieza_Click(sender As Object, e As EventArgs) Handles blimpieza.Click
        mensaje.Text = "Mensajes"
        btnbuscar.Text = Nothing
        ccampos.Text = Nothing
        tcriterio.Text = Nothing
    End Sub

    Private Sub btnbuscar2_Click(sender As Object, e As EventArgs) Handles btnbuscar2.Click
        If ccampos2.Text = Nothing And tcriterio2.Text = Nothing Then
            sql = "select * from maquinaria order by codigo_vh"
        ElseIf ccampos2.Text <> Nothing And tcriterio2.Text <> Nothing Then
            sql = "select * from maquinaria where " & ccampos2.Text & " like '%" & tcriterio2.Text & "%'"
            sql += "order by codigo_vh"
        Else
            sql = "select * from maquinaria order by codigo_vh"
        End If
        'MsgBox(sql)
        Try
            Conexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        adaptar = New SqlDataAdapter(sql, Conexion)
        almacen = New DataSet
        adaptar.Fill(almacen, "maquinaria")
        resultado = almacen.Tables("maquinaria").Rows.Count
        If resultado > 0 Then
            dgvvehiculos.DataSource = almacen
            dgvvehiculos.DataMember = "maquinaria"
            dgvvehiculos.Columns(0).HeaderText = "codigo_vh"
            dgvvehiculos.Columns(1).Visible = False
            dgvvehiculos.Columns(2).HeaderText = "placa_vh"
            dgvvehiculos.Columns(3).Visible = False
            dgvvehiculos.Columns(4).Visible = False
            dgvvehiculos.Columns(5).HeaderText = "estado_vh"
            dgvvehiculos.Columns(6).Visible = False
            dgvvehiculos.Columns(7).Visible = False
            dgvvehiculos.Columns(8).Visible = False
            dgvvehiculos.Columns(9).Visible = False
            dgvvehiculos.Columns(10).Visible = False
            dgvvehiculos.Columns(11).Visible = False
            dgvvehiculos.Columns(12).Visible = False
            dgvvehiculos.Columns(13).Visible = False
            dgvvehiculos.Columns(14).Visible = False
            dgvvehiculos.Columns(15).Visible = False
            dgvvehiculos.Columns(16).Visible = False
            dgvvehiculos.Columns(17).Visible = False
            dgvvehiculos.Columns(18).Visible = False
            dgvvehiculos.Columns(19).Visible = False
            dgvvehiculos.Columns(20).Visible = False
            dgvvehiculos.AutoResizeColumns()
            dgvvehiculos.Columns(0).Width = 60
            dgvvehiculos.Columns(2).Width = 110 'Ancho Especifico
            dgvvehiculos.Columns(5).Width = 120
            dgvvehiculos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvvehiculos.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvvehiculos.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvvehiculos.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvvehiculos.Columns(9).DefaultCellStyle.NullValue = My.Resources.subir
            dgvvehiculos.Columns(10).DefaultCellStyle.NullValue = My.Resources.subir
            mensaje.Text = "Mensajes"
        ElseIf resultado = 0 Then
            mensaje.Text = "No se encuentra con mostrar"
            dgvvehiculos.DataSource = Nothing
            dgvvehiculos.DataMember = Nothing
            dgvvehiculos.Refresh()
        End If
        Conexion.Close()
        dgvvehiculos.Focus()
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

    Private Sub bimprimir_Click(sender As Object, e As EventArgs) Handles bimprimir.Click
        FrmHojaSalidaImpr2.tsalida.Text = Me.nosalida.Text
        FrmHojaSalidaImpr2.ShowDialog()
    End Sub
    Private Sub rbexistvh_CheckedChanged(sender As Object, e As EventArgs) Handles rbexistvh.CheckedChanged
        If rbexistvh.Checked = False Then
            codigovh.Enabled = True
            estadovh.Enabled = True
            placavh.Enabled = True
            bdatagridveh.Enabled = False
            dgvvehiculos.Visible = False
            codigovh.Text = Nothing
            estadovh.Text = Nothing
            placavh.Text = Nothing
        ElseIf rbexistvh.Checked = True Then
            codigovh.Enabled = False
            estadovh.Enabled = False
            placavh.Enabled = False
            bdatagridveh.Enabled = True
            codigovh.Text = Nothing
            estadovh.Text = Nothing
            placavh.Text = Nothing
        End If
    End Sub

    Private Sub FrmPaseSalida_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        dgvvehiculos.ClearSelection()
        dgvinventario.ClearSelection()
        sql = "select * from salida_inventario where no_salida='" & nosalida.Text & "'"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "salida_inventario")
            resultado = almacen.Tables("salida_inventario").Rows.Count
            If resultado > 0 Then
                registro = almacen.Tables("salida_inventario").Rows(0)
                If Not IsDBNull(registro("codigo_vh")) Then
                    codigovh.Text = registro("codigo_vh")
                End If
                If Not IsDBNull(registro("placa_vh")) Then
                    placavh.Text = registro("placa_vh")
                End If
                If Not IsDBNull(registro("estado_vh")) Then
                    estadovh.Text = registro("estado_vh")
                End If

            End If
            If resultado = 0 Then

            End If
        Catch ex As Exception
        End Try
        Conexion.Close()
    End Sub

    Private Sub beditar_Click(sender As Object, e As EventArgs)
        Dim nada As String
        nada = ""

        If rbexistvh.Checked = True Then
            Vehiculoext = "Vehiculo en Sistema"
        ElseIf rbexistvh.Checked = False Then
            Vehiculoext = "Vehiculo Particular"
        End If

        If cestadpase.Text = "" Then
            Psext = "Activo"
        ElseIf cestadpase.Text = "Inactivo" Then
            Psext = "Inactivo"
        ElseIf cestadpase.Text = "Activo" Then
            Psext = "Activo"
        End If

        If nosalida.Text = Nothing Then
            mensaje.Text = "Dejo vacio el Numero de salida"
            nosalida.Focus()
            Exit Sub
        ElseIf categoria.Text = Nothing Then
            mensaje.Text = "Dejo vacio la categoria del pase de salida"
            categoria.Focus()
            Exit Sub
        ElseIf tmorotris.Text = Nothing Then
            mensaje.Text = "Dejo vacio el campo motorista"
            tmorotris.Focus()
            Exit Sub
        ElseIf tdestiny.Text = Nothing Then
            mensaje.Text = "Dejo vacio el destino"
            tdestiny.Focus()
            Exit Sub
        End If
        Try
            If resultado > 0 Then
                Dim result As DialogResult
                result = MessageBox.Show("Desea Editar Registros?", "Actualizando!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then

                    adaptar.UpdateCommand = New SqlCommand("update salida_inventario set codigo_vh='" & codigovh.Text & "',placa_vh='" & placavh.Text & "',estado_vh='" & estadovh.Text & "',categoriaps='" & categoria.Text & "',hrm1='" & hrm1.Text & "',hrm2='" & hrm2.Text & "',klm1='" & km1.Text & "',klm2='" & km2.Text & "',motorista='" & tmorotris.Text & "',acompañante='" & tpartner.Text & "',destino='" & tdestiny.Text & "',fecha_retorno='" & dtpretorno.Text & "',fecha_salida='" & dtpsalida.Text & "',vhexist='" & Vehiculoext & "',estado_ficha='" & Psext & "' where no_salida='" & nosalida.Text & "'", Conexion)
                    Conexion.Open()
                    adaptar.UpdateCommand.ExecuteNonQuery()
                    Conexion.Close()

                    For Each Row As DataGridViewRow In dgvreg.Rows
                        Dim id1 As String = Row.Cells("id1").Value
                        Dim item As String = Row.Cells("item").Value
                        Dim unidad As String = Row.Cells("unidad").Value
                        Dim descripcionds As String = Row.Cells("descripcion").Value
                        Dim observacion As String = Row.Cells("observacion").Value
                        adaptar.UpdateCommand = New SqlCommand("update salida_inventario set item='" & item & "',unidad='" & unidad & "',descripcion='" & descripcionds & "',observacion='" & observacion & "' where no_salida='" & nosalida.Text & "'and id='" & id1 & "'", Conexion)
                        Conexion.Open()
                        adaptar.UpdateCommand.ExecuteNonQuery()
                        Conexion.Close()
                    Next

                    limpiar()
                    rbexistvh.Checked = True
                    If rbexistvh.Checked = False Then
                        codigovh.Enabled = True
                        estadovh.Enabled = True
                        placavh.Enabled = True
                    ElseIf rbexistvh.Checked = True Then
                        codigovh.Enabled = False
                        estadovh.Enabled = False
                        placavh.Enabled = False
                    End If
                    bdatagridveh.Enabled = False
                    bdatagridinv.Enabled = False
                    nosalida.Enabled = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tpartner_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tpartner.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tdestiny.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub


    Private Sub dgvreg2_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvreg2.RowPostPaint
        Me.dgvreg2.Rows(e.RowIndex).Cells(1).Value = (e.RowIndex + 1).ToString
    End Sub

    Private Sub FrmPaseSalida_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        '  validprev()
        sql = "select * from salida_inventario where no_salida='" & nosalida.Text & "'"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "salida_inventario")
            resultado = almacen.Tables("salida_inventario").Rows.Count
            If resultado > 0 Then
                Conexion.Close()
                Dim result As DialogResult
                result = MessageBox.Show("Desea Salir? Inventario retornando de segundo cuadro si hay datos!!!", "Saliendo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    For j As Integer = 0 To dgvreg2.Rows.Count - 1 Step +1
                        Dim unidadobt As String
                        unidadobt = dgvreg2.Rows(j).Cells("unidad2").Value.ToString
                        adaptar.UpdateCommand = New SqlCommand("update inventario set stock= stock+'" & unidadobt & "' where nom_prod='" & dgvreg2.Rows(j).Cells("descripcion2").Value.ToString & "'", Conexion)
                        Conexion.Open()
                        adaptar.UpdateCommand.ExecuteNonQuery()
                        Conexion.Close()
                    Next
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
                ElseIf result = DialogResult.No Then
                    e.Cancel = True
                    Timer1.Enabled = True
                End If
            End If

            If resultado = 0 Then
                Conexion.Close()
                Dim result2 As DialogResult
                result2 = MessageBox.Show("Desea Salir? Inventario retornando de primer cuadro si hay datos!!!", "Saliendo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result2 = DialogResult.Yes Then

                    For j As Integer = 0 To dgvreg.Rows.Count - 1 Step +1
                        Dim unidadobt As String
                        unidadobt = dgvreg.Rows(j).Cells("unidad").Value.ToString
                        adaptar.UpdateCommand = New SqlCommand("update inventario set stock= stock+'" & unidadobt & "' where nom_prod='" & dgvreg.Rows(j).Cells("descripcion").Value.ToString & "'", Conexion)
                        Conexion.Open()
                        adaptar.UpdateCommand.ExecuteNonQuery()
                        Conexion.Close()
                    Next
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
                ElseIf result2 = DialogResult.No Then
                    e.Cancel = True
                    Timer1.Enabled = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cestadpase_TextChanged(sender As Object, e As EventArgs) Handles cestadpase.TextChanged
        If cestadpase.Text = "Inactivo" Then
            dtpsalida.Enabled = False
            dtpretorno.Enabled = False
            rbexistvh.Enabled = False
            codigovh.Enabled = False
            estadovh.Enabled = False
            placavh.Enabled = False
            categoria.Enabled = False
            hrm1.Enabled = False
            hrm2.Enabled = False
            km1.Enabled = False
            km2.Enabled = False
            tmorotris.Enabled = False
            tpartner.Enabled = False
            tdestiny.Enabled = False
            beliminarreg.Enabled = False
            bagregar.Enabled = False
            beliminar.Enabled = False
            bimprimir.Enabled = False
            bdatagridveh.Enabled = False
            bdatagridinv.Enabled = False
            beliminarreg.Enabled = False
            blimpieza.Enabled = False
            blimpieza2.Enabled = False
            ncantidadinv.Enabled = False
            dgvreg.Enabled = False
            dgvreg2.Enabled = False
            dgvreg.ClearSelection()
            dgvreg2.ClearSelection()

        ElseIf cestadpase.Text = "Activo" Then
            dtpsalida.Enabled = True
            dtpretorno.Enabled = True
            rbexistvh.Enabled = True
            codigovh.Enabled = True
            estadovh.Enabled = True
            placavh.Enabled = True
            categoria.Enabled = True
            hrm1.Enabled = True
            hrm2.Enabled = True
            km1.Enabled = True
            km2.Enabled = True
            tmorotris.Enabled = True
            tpartner.Enabled = True
            tdestiny.Enabled = True
            beliminarreg.Enabled = True
            bagregar.Enabled = True
            beliminar.Enabled = True
            bimprimir.Enabled = True
            bdatagridveh.Enabled = True
            bdatagridinv.Enabled = True
            beliminarreg.Enabled = True
            blimpieza.Enabled = True
            blimpieza2.Enabled = True
            ncantidadinv.Enabled = True
            dgvreg.Enabled = True
            dgvreg2.Enabled = True
            dgvreg.ClearSelection()
            dgvreg2.ClearSelection()

        ElseIf cestadpase.Text = "" Then
            dtpsalida.Enabled = True
            dtpretorno.Enabled = True
            rbexistvh.Enabled = True
            codigovh.Enabled = True
            estadovh.Enabled = True
            placavh.Enabled = True
            categoria.Enabled = True
            hrm1.Enabled = True
            hrm2.Enabled = True
            km1.Enabled = True
            km2.Enabled = True
            tmorotris.Enabled = True
            tpartner.Enabled = True
            tdestiny.Enabled = True
            beliminarreg.Enabled = True
            bagregar.Enabled = True
            beliminar.Enabled = True
            bimprimir.Enabled = True
            bdatagridveh.Enabled = True
            bdatagridinv.Enabled = True
            beliminarreg.Enabled = True
            blimpieza.Enabled = True
            blimpieza2.Enabled = True
            ncantidadinv.Enabled = True
            dgvreg.Enabled = True
            dgvreg2.Enabled = True
            dgvreg.ClearSelection()
            dgvreg2.ClearSelection()

        End If

    End Sub

    Private Sub categoria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles categoria.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            hrm1.Focus()
            mensaje.Text = "Mensajes"
        End If
        e.Handled = True
    End Sub

    Private Sub estadovh_KeyPress(sender As Object, e As KeyPressEventArgs) Handles estadovh.KeyPress
        e.Handled = True
    End Sub

    Private Sub tdestiny_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tdestiny.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            bagregar.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub ccampos2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ccampos2.KeyPress
        e.Handled = True
    End Sub

    Private Sub ccampos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ccampos.KeyPress
        e.Handled = True
    End Sub

    Private Sub tmorotris_TextChanged(sender As Object, e As EventArgs) Handles tmorotris.TextChanged
        tmorotris.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tmorotris.Text)
        tmorotris.SelectionStart = tmorotris.Text.Length
    End Sub

    Private Sub tpartner_TextChanged(sender As Object, e As EventArgs) Handles tpartner.TextChanged
        tpartner.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tpartner.Text)
        tpartner.SelectionStart = tpartner.Text.Length
    End Sub

    Private Sub tdestiny_TextChanged(sender As Object, e As EventArgs) Handles tdestiny.TextChanged
        tdestiny.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tdestiny.Text)
        tdestiny.SelectionStart = tdestiny.Text.Length


        ' Obtén el texto de la casilla de texto
        Dim destinosTexto As String = tdestiny.Text

        ' Divide el texto en una lista de destinos utilizando el símbolo "/" como separador y elimina los espacios en blanco
        Dim separator As Char() = {"/"c}
        Dim destinos As String() = destinosTexto.Split(separator, StringSplitOptions.RemoveEmptyEntries).Select(Function(s) s.Trim()).ToArray()

        ' Borra los elementos actuales del ComboBox y agrega los nuevos destinos
        Cdestiny.Items.Clear()
        Cdestiny.Items.AddRange(destinos)

        ' Asegúrate de que el ComboBox muestre el último destino
        Cdestiny.SelectedIndex = Cdestiny.Items.Count - 1
    End Sub

    Private Sub nosalida_TextChanged(sender As Object, e As EventArgs) Handles nosalida.TextChanged
    End Sub
    'Private Sub dgvreg2_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvreg2.CellValueChanged
    '    If dgvreg2.Rows.Count = 0 Then
    '        beditar.Enabled = True
    '    Else
    '        beditar.Enabled = False
    '    End If
    'End Sub


    Private Sub codigovh_TextChanged(sender As Object, e As EventArgs) Handles codigovh.TextChanged
        codigovh.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(codigovh.Text)
        codigovh.SelectionStart = codigovh.Text.Length
    End Sub

    Private Sub dgvreg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvreg.CellContentClick
        dgvreg2.ClearSelection()
    End Sub

    Private Sub dgvreg2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvreg2.CellContentClick
        dgvreg.ClearSelection()
    End Sub

    Private Sub dtpsalida_ValueChanged(sender As Object, e As EventArgs) Handles dtpsalida.ValueChanged
        If dtpsalida.Value > dtpretorno.Value Then
            dtpsalida.Value = Now
        ElseIf dtpretorno.Value < dtpsalida.Value Then
            dtpretorno.Value = Now
        End If
    End Sub

    Private Sub dtpretorno_ValueChanged(sender As Object, e As EventArgs) Handles dtpretorno.ValueChanged
        If dtpretorno.Value < dtpsalida.Value Then
            dtpretorno.Value = Now
        ElseIf dtpsalida.Value > dtpretorno.Value Then
            dtpsalida.Value = Now
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Interval = 1

        FrmLogin.Hide()

        Timer1.Enabled = False
    End Sub

    Private Sub bagregadogeneral_Click(sender As Object, e As EventArgs) Handles bagregadogeneral.Click

        Dim listdestin1 As String
        Dim nombrea As String
        Dim itema As String
        Dim ubc1 As String
        Dim cantidad As String
        Dim idenv As String

        Dim Valor2 As String
        Valor2 = Me.codigovh.Text
        Dim existe2 As Boolean = Me.dgvreg.Rows.Cast(Of DataGridViewRow).Any(Function(x) CStr(x.Cells("descripcion").Value) = Valor2)

        sql = "select * from salida_inventario where no_salida='" & nosalida.Text & "'"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "salida_inventario")
            resultado = almacen.Tables("salida_inventario").Rows.Count

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
                listdestin1 = dgvreg.Rows.Count.ToString
                ubc1 = Cdestiny.Text
                cantidad = num1un.Text
                nombrea = descp1env.Text
                dgvreg.Rows.Add(idenv, itema, ubc1, nombrea, cantidad)
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
                ubc1 = Cdestiny.Text
                cantidad = num1un.Text
                nombrea = descp1env.Text
                dgvreg2.Rows.Add(idenv, itema, ubc1, nombrea, cantidad)
                Conexion.Close()
                num1un.Text = 0
                descp1env.Text = Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Conexion.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim nombrea As String
        Dim itema As String
        Dim cantidad As String
        Dim id1 As String

        Dim Valor2 As String
        Valor2 = Me.codigovh.Text
        Dim existe2 As Boolean = Me.dgvreg.Rows.Cast(Of DataGridViewRow).Any(Function(x) CStr(x.Cells("descripcion").Value) = Valor2)

        sql = "select * from salida_inventario where no_salida='" & nosalida.Text & "'"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "salida_inventario")
            resultado = almacen.Tables("salida_inventario").Rows.Count

            If resultado = 0 Then
                If descp1env.Text = Nothing Then
                    mensaje.Text = "Agregue el Valor de la Hora"
                    Conexion.Close()
                    Exit Sub

                ElseIf num1un.Text = Nothing Then
                    mensaje.Text = "Agregue las horas trabajadas"
                    Conexion.Close()
                    Exit Sub
                End If
                mensaje.Text = "Mensajes"
                id1 = dgvreg.Rows.Count.ToString
                itema = dgvreg.Rows.Count.ToString
                cantidad = num1un.Text
                nombrea = descp1env.Text
                nombrea = dgvvehiculos(0, dgvvehiculos.CurrentRow.Index).Value
                dgvreg.Rows.Add(id1, itema, cantidad, nombrea)
                Conexion.Close()

            ElseIf resultado > 0 Then
                If descp1env.Text = Nothing Then
                    mensaje.Text = "Agregue el Valor de la Hora"
                    Conexion.Close()
                    Exit Sub

                ElseIf num1un.Text = Nothing Then
                    mensaje.Text = "Agregue las horas trabajadas"
                    Conexion.Close()
                    Exit Sub
                End If
                mensaje.Text = "Mensajes"
                id1 = dgvreg2.Rows.Count.ToString
                itema = dgvreg2.Rows.Count.ToString
                cantidad = num1un.Text
                nombrea = descp1env.Text
                dgvreg2.Rows.Add(id1, itema, cantidad, nombrea)
                Conexion.Close()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub num1un_Validated(sender As Object, e As EventArgs) Handles num1un.Validated
        If num1un.Value = Nothing Then
            num1un.Value = 0.0
        End If
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

    Private Sub chknvregistro_CheckedChanged(sender As Object, e As EventArgs) Handles chknvregistro.CheckedChanged

        If chknvregistro.Checked = True Then
            Conexion.Open()
            Dim cmd As New SqlCommand("Valormaximo", Conexion)
            cmd.CommandType = CommandType.StoredProcedure

            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            Dim dt As New DataTable
            dt.Clear()
            da.Fill(dt)

            Dim row As DataRow = dt.Rows(0)
            nosalida.Text = Convert.ToString(row("valmax"))
            Conexion.Close()
            chknvregistro.Enabled = False
            nosalida.Enabled = False
            nosalida_Validated(sender, e)

        ElseIf chknvregistro.Checked = False Then

        End If
    End Sub


    Private Sub num1un_ValueChanged(sender As Object, e As EventArgs) Handles num1un.ValueChanged
        'If num1un.Value = 0 Then
        'num1un.Value = 0.0

        'End If
        'num1un.DecimalPlaces = 2
        'num1un.Increment = 0.1
    End Sub
End Class