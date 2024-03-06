Imports System.Data.SqlClient
Imports System.Data
Imports System.Runtime.InteropServices
Public Class FrmListadoOrdAgr
    Public Shared Property Instancia As FrmListadoOrdAgr 
    Public Sub New()
        InitializeComponent()
        Instancia = Me
    End Sub

    Private Sub FrmListadoOrdAgr_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Conexion = New SqlConnection
        Conexion.ConnectionString = cadena
        Dim da As New SqlDataAdapter("Select * from ubicaciones_vehiculos", Conexion)
        Dim dt As New DataTable
        da.Fill(dt)
        tproyectos.DataSource = dt
        tproyectos.DisplayMember = "ubicacion"
        tproyectos.ValueMember = "codigo_p"

        If FrmPrincipal.lrol.Text = "Administrador" Then

            chkbxaceptartodo.Visible = True
            'dgvreg.Columns("6").[ReadOnly] = False
        ElseIf FrmPrincipal.lrol.Text = "Administracion" Then

            chkbxaceptartodo.Visible = False
            'dgvreg.Columns("6").[ReadOnly] = True
        ElseIf FrmPrincipal.lrol.Text = "Dueño" Then

            chkbxaceptartodo.Visible = False
            '           dgvreg.Columns("6").[ReadOnly] = True
        ElseIf FrmPrincipal.lrol.Text = "Asistente SR" Then

            chkbxaceptartodo.Visible = False
            'dgvreg.Columns("6").[ReadOnly] = True
        ElseIf FrmPrincipal.lrol.Text = "Compras" Then

            chkbxaceptartodo.Visible = True
            'dgvreg.Columns("6").[ReadOnly] = False
        ElseIf FrmPrincipal.lrol.Text = "Gestor de Proyectos" Then

            chkbxaceptartodo.Visible = False
            'dgvreg.Columns("6").[ReadOnly] = True
        ElseIf FrmPrincipal.lrol.Text = "Bodeguero SR" Then

            chkbxaceptartodo.Visible = False
            'dgvreg.Columns("6").[ReadOnly] = True
        ElseIf FrmPrincipal.lrol.Text = "Taller Mecanico" Then

            chkbxaceptartodo.Visible = False
            'dgvreg.Columns("6").[ReadOnly] = True

        ElseIf FrmPrincipal.lrol.Text = "Contabilidad" Then

            chkbxaceptartodo.Visible = False
            'dgvreg.Columns("6").[ReadOnly] = True

        End If


        tnumsolici.Text = FrmPrincipal.valornumSolcompra
        ValidacionNumsol()

        mostrarINV()
    End Sub
    Private Sub mostrarINV()
        If tcriterio.Text = Nothing Then
            sql = "select * from inventario order by codigop desc"
        ElseIf tcriterio.Text <> Nothing Then
            sql = "select * from inventario where codigop like '%" & tcriterio.Text & "%' "
            sql += " or prefijo like '%" & tcriterio.Text & "%' "
            sql += " or nom_prod like '%" & tcriterio.Text & "%' "
            sql += " or categoria like '%" & tcriterio.Text & "%' "
            sql += " or ubicacion like '%" & tcriterio.Text & "%' "
            sql += "order by codigop"
        Else
            sql = "select * from inventario order by codigop"
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
            dgvinventario.Columns(3).HeaderText = "categoria"
            dgvinventario.Columns(4).HeaderText = "ubicacion"
            dgvinventario.Columns(5).Visible = False
            dgvinventario.Columns(6).Visible = False
            dgvinventario.Columns(7).HeaderText = "foto1"
            dgvinventario.Columns(8).Visible = False
            dgvinventario.Columns(9).Visible = False
            dgvinventario.Columns(10).Visible = False
            dgvinventario.AutoResizeColumns()
            dgvinventario.Columns(0).Width = 60
            dgvinventario.Columns(1).Width = 44 'Ancho Especifico
            dgvinventario.Columns(2).Width = 350
            dgvinventario.Columns(3).Width = 190
            dgvinventario.Columns(4).Width = 190
            dgvinventario.Columns(5).Width = 180
            dgvinventario.Columns(7).Width = 130
            dgvinventario.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvinventario.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvinventario.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvinventario.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvinventario.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvinventario.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvinventario.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvinventario.Columns(7).DefaultCellStyle.NullValue = My.Resources.subir2
            dgvinventario.Columns(8).DefaultCellStyle.NullValue = My.Resources.subir2
            Conexion.Close()
        ElseIf resultado = 0 Then
            mensaje.Text = "No se encuentra con mostrar"
            dgvinventario.DataSource = Nothing
            dgvinventario.DataMember = Nothing
            dgvinventario.Refresh()
        End If
        Conexion.Close()
        dgvinventario.Focus()
    End Sub
    Private Sub dgvinventario_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgvinventario.CellPainting
        For i = 0 To dgvinventario.Rows.Count - 1
            Dim r As DataGridViewRow = dgvinventario.Rows(i)
            r.Height = 94
        Next

        If (e.RowIndex < 0 Or e.ColumnIndex < 0) Then Return

        If dgvinventario.Rows(e.RowIndex).Cells(e.ColumnIndex).ValueType = GetType(Byte()) Then
            CType(dgvinventario.Rows(e.RowIndex).Cells(e.ColumnIndex), 
                  DataGridViewImageCell).ImageLayout = DataGridViewImageCellLayout.Zoom
        End If
    End Sub

    Private Sub tcriterio_TextChanged(sender As Object, e As EventArgs) Handles tcriterio.TextChanged
        If tcriterio.Text = Nothing Then
            sql = "select * from inventario order by codigop desc"
        ElseIf tcriterio.Text <> Nothing Then

            sql = "select * from inventario where codigop like '%" & tcriterio.Text & "%' "
            sql += " or prefijo like '%" & tcriterio.Text & "%' "
            sql += " or nom_prod like '%" & tcriterio.Text & "%' "
            sql += " or categoria like '%" & tcriterio.Text & "%' "
            sql += " or ubicacion like '%" & tcriterio.Text & "%' "
            sql += "order by codigop"
        Else
            sql = "select * from inventario order by codigop"
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
            dgvinventario.Columns(3).HeaderText = "categoria"
            dgvinventario.Columns(4).HeaderText = "ubicacion"
            dgvinventario.Columns(5).Visible = False
            dgvinventario.Columns(6).Visible = False
            dgvinventario.Columns(7).HeaderText = "foto1"
            dgvinventario.Columns(8).Visible = False
            dgvinventario.Columns(9).Visible = False
            dgvinventario.Columns(10).Visible = False
            dgvinventario.AutoResizeColumns()
            dgvinventario.Columns(0).Width = 60
            dgvinventario.Columns(1).Width = 44 'Ancho Especifico
            dgvinventario.Columns(2).Width = 350
            dgvinventario.Columns(3).Width = 190
            dgvinventario.Columns(4).Width = 190
            dgvinventario.Columns(5).Width = 180
            dgvinventario.Columns(7).Width = 130
            dgvinventario.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvinventario.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvinventario.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvinventario.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvinventario.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvinventario.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvinventario.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvinventario.Columns(7).DefaultCellStyle.NullValue = My.Resources.subir2
            dgvinventario.Columns(8).DefaultCellStyle.NullValue = My.Resources.subir2
            Conexion.Close()
        ElseIf resultado = 0 Then
            mensaje.Text = "No se encuentra con mostrar"
            dgvinventario.DataSource = Nothing
            dgvinventario.DataMember = Nothing
            dgvinventario.Refresh()
        End If
        Conexion.Close()
    End Sub

    Private Sub bagrsol_Click(sender As Object, e As EventArgs)
        Dim nombre As String
        Dim item As String
        Dim fechas As Date = Date.Today

        Dim Valor As String
        Valor = Me.dgvinventario(2, dgvinventario.CurrentRow.Index).Value
        Dim existe As Boolean = Me.dgvreg.Rows.Cast(Of DataGridViewRow).Any(Function(x) CStr(x.Cells("descripcion").Value) = Valor)

        dgvreg.ClearSelection()

        mensaje.Text = "Mensajes"
        item = dgvreg.Rows.Count.ToString
        nombre = dgvinventario(2, dgvinventario.CurrentRow.Index).Value
        dgvreg.Rows.Add(item, nombre)
        Conexion.Close()

        Conexion.Close()
        dgvinventario.Refresh()
    End Sub
    Private Sub dgvinventario_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvinventario.CellClick
        ListOrdenCantidad.Show()
    End Sub

    Private Sub beliminarreg_Click(sender As Object, e As EventArgs)
        For Each Row As DataGridViewRow In dgvreg.SelectedRows
            dgvreg.Rows.Remove(Row)
        Next
    End Sub

    Private Sub breiniciar_Click(sender As Object, e As EventArgs)
        dgvreg = Nothing
        tcriterio.Text = Nothing
    End Sub

    Private Sub bregresar_Click(sender As Object, e As EventArgs) Handles bregresar.Click

        Me.Hide()
        FrmPrincipal.EstatusSolicitudes()
        FrmPrincipal.valornumSolcompra = ""

    End Sub

    Private Sub tnumsolici_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tnumsolici.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tdepartament.Focus()
            mensaje.Text = "Mensajes"
            ValidacionNumsol()
        End If
    End Sub

    Private Sub fechasolc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles fechasolc.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            fechareq.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub fechareqmin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles fechareq.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            bagregar.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub bagregar_Click(sender As Object, e As EventArgs) Handles bagregar.Click

        If tnumsolici.Text = Nothing Then
            mensaje.Text = "Dejo vacio el numero de solicitud"
            tnumsolici.Focus()
            Exit Sub

        ElseIf tdepartament.Text = Nothing Then
            mensaje.Text = "Dejo vacio el departamento"
            tdepartament.Focus()
            Exit Sub

        ElseIf tmaquinaria.Text = Nothing Then
            mensaje.Text = "Dejo vacio en maquinaria"
            tmaquinaria.Focus()
            Exit Sub

        ElseIf tproyectos.Text = Nothing Then
            mensaje.Text = "Dejo vacio en proyecto"
            tproyectos.Focus()
            Exit Sub

        ElseIf tprioridad.Text = Nothing Then
            mensaje.Text = "Dejo vacio en prioridad"
            tprioridad.Focus()
            Exit Sub

        End If

        Dim estadoorden As String
        estadoorden = "Nuevo"

        Dim fecha As DateTime = Now
        Dim fechaactual As DateTime
        fechaactual = Now

        sql = "select * from ordenes_trabajo where num_solcitud='" & tnumsolici.Text & "'"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "ordenes_trabajo")
            resultado = almacen.Tables("ordenes_trabajo").Rows.Count
            If resultado = 0 Then
                Conexion.Close()
                Dim result As DialogResult
                result = MessageBox.Show("Desea Agregar Nuevos Registros?", "Actualizado!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then

                    For Each Row As DataGridViewRow In dgvreg.Rows

                        Dim id1 As String = Row.Cells("id").Value
                        Dim item As String = Row.Cells("item").Value
                        Dim articulo As String = Row.Cells("articulo").Value
                        Dim cantidad As String = Row.Cells("cantidad").Value
                        Dim cantidadaprov As String = Row.Cells("can_aprob").Value
                        Dim unidad As String = Row.Cells("unidad").Value
                        Dim descripcionds As String = Row.Cells("descripcion").Value

                        adaptar.InsertCommand = New SqlCommand("Insert into ordenes_trabajo (num_solcitud,solicitado_por,departamento,equipo1,proyecto,observaciones,tip_prioridad,aprova,dtpfecha_solicitud,dtpfecha_requerida,articulo,cantidad,cantidad_aprov,unidad,descripcion,estado_ord,fecha_hora) values ('" & tnumsolici.Text & "', '" & tnombre.Text & "', '" & tdepartament.Text & "', '" & tmaquinaria.Text & "', '" & tproyectos.Text & "', '" & tobservacion.Text & "', '" & tprioridad.Text & "', '" & taprobad.Text & "', '" & fechasolc.Text & "', '" & fechareq.Text & "', '" & articulo & "', '" & cantidad & "', '" & cantidadaprov & "', '" & unidad & "', '" & descripcionds & "', '" & estadoorden & "', '" & fechaactual & "')", Conexion)
                        Conexion.Open()
                        adaptar.InsertCommand.ExecuteNonQuery()
                        Conexion.Close()

                    Next


                    MessageBox.Show("Guardado Exitosamente")
                    limpiar()
                    tnumsolici.Enabled = True

                ElseIf result = DialogResult.No Then

                End If
            End If

            If resultado > 0 Then
                Conexion.Close()
                Dim result2 As DialogResult
                result2 = MessageBox.Show("Desea Guardar?", "Guardar!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result2 = DialogResult.Yes Then

                    For Each Row As DataGridViewRow In dgvreg2.Rows

                        Dim item As String = Row.Cells("item2").Value
                        Dim articulo As String = Row.Cells("articulo2").Value
                        Dim cantidad As String = Row.Cells("cantidad2").Value
                        Dim cantidadaprov As String = Row.Cells("can_aprob2").Value
                        Dim unidad As String = Row.Cells("unidad2").Value
                        Dim descripcionds As String = Row.Cells("descripcion2").Value

                        adaptar.InsertCommand = New SqlCommand("Insert into ordenes_trabajo (num_solcitud,solicitado_por,departamento,equipo1,proyecto,observaciones,tip_prioridad,aprova,dtpfecha_solicitud,dtpfecha_requerida,articulo,cantidad,cantidad_aprov,unidad,descripcion,estado_ord,fecha_hora) values ('" & tnumsolici.Text & "', '" & tnombre.Text & "', '" & tdepartament.Text & "', '" & tmaquinaria.Text & "', '" & tproyectos.Text & "', '" & tobservacion.Text & "', '" & tprioridad.Text & "', '" & taprobad.Text & "', '" & fechasolc.Text & "', '" & fechareq.Text & "', '" & articulo & "', '" & cantidad & "', '" & cantidadaprov & "', '" & unidad & "', '" & descripcionds & "', '" & estadoorden & "', '" & fechaactual & "')", Conexion)
                        Conexion.Open()
                        adaptar.InsertCommand.ExecuteNonQuery()
                        Conexion.Close()
                    Next


                    adaptar.UpdateCommand = New SqlCommand("update ordenes_trabajo set num_solcitud='" & tnumsolici.Text & "',equipo1='" & tmaquinaria.Text & "',proyecto='" & tproyectos.Text & "',observaciones='" & tobservacion.Text & "',dtpfecha_solicitud='" & fechasolc.Text & "',dtpfecha_requerida='" & fechareq.Text & "' where num_solcitud='" & tnumsolici.Text & "'", Conexion)
                    Conexion.Open()
                    adaptar.UpdateCommand.ExecuteNonQuery()
                    Conexion.Close()
                    For Each Row As DataGridViewRow In dgvreg.Rows

                        Dim id1 As String = Row.Cells("id").Value
                        Dim item As String = Row.Cells("item").Value
                        Dim articulo As String = Row.Cells("articulo").Value
                        Dim cantidad As String = Row.Cells("cantidad").Value
                        Dim unidad As String = Row.Cells("unidad").Value
                        Dim descripcionds As String = Row.Cells("descripcion").Value

                        adaptar.UpdateCommand = New SqlCommand("update ordenes_trabajo set cantidad='" & cantidad & "',unidad='" & unidad & "' where num_solcitud='" & tnumsolici.Text & "'and id='" & id1 & "'", Conexion)
                        Conexion.Open()
                        adaptar.UpdateCommand.ExecuteNonQuery()
                        Conexion.Close()
                    Next


                    MessageBox.Show("Actualizado Exitosamente")
                    limpiar()
                    tnumsolici.Enabled = True
                ElseIf result2 = DialogResult.No Then
                    dgvreg.Rows.Clear()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub limpiar()
        tnumsolici.Text = Nothing
        limpiarparcial()
    End Sub

    Private Sub limpiarparcial()
        tmaquinaria.Text = Nothing
        tproyectos.Text = Nothing
        tprioridad.Text = Nothing
        tdepartament.Text = Nothing
        taprobad.Text = Nothing
        tobservacion.Text = Nothing
        dgvreg.Rows.Clear()
        dgvreg2.Rows.Clear()

        fechasolc.Text = Now
        fechareq.Text = Now
    End Sub

    Private Sub maquinariadescrp()
        sql = "select * from maquinaria where='" & tnumsolici.Text & "'"
    End Sub

    Private Sub beliminar_Click(sender As Object, e As EventArgs) Handles beliminar.Click

        For Each Row As DataGridViewRow In dgvreg.SelectedRows
            dgvreg.Rows.Remove(Row)
            dgvinventario.Refresh()
        Next


        For Each Row As DataGridViewRow In dgvreg2.SelectedRows
            dgvreg2.Rows.Remove(Row)
            dgvinventario.Refresh()
        Next

    End Sub

    Private Sub bborrar_Click(sender As Object, e As EventArgs) Handles bborrar.Click
        If tnumsolici.Text = Nothing Then
            mensaje.Text = "Dejo vacio el Numero de Solicitud"
            tnumsolici.Focus()
            Exit Sub
        End If

        If MsgBox("Eliminar la Orden de Trabajo?", MsgBoxStyle.YesNo, "Sistema de SERINTER") = MsgBoxResult.Yes Then
            Try
                sql = "delete from ordenes_trabajo where num_solcitud='" & tnumsolici.Text & "'"
                Conexion.Open()
                Comando = New SqlCommand(sql, Conexion)
                Comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        Conexion.Close()
        limpiar()
        tnumsolici.Focus()
        mostrarINV()
    End Sub

    Private Sub btatras_Click(sender As Object, e As EventArgs) Handles btatras.Click

        Dim valormax As Integer
        Dim valostring As String

        If tnumsolici.Text = Nothing Then
            Conexion.Open()
            Dim cmd As New SqlCommand("Valormaximo_SolicitudTrb", Conexion)
            cmd.CommandType = CommandType.StoredProcedure

            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            Dim dt As New DataTable
            dt.Clear()
            da.Fill(dt)

            Dim row As DataRow = dt.Rows(0)

            'valormax = Convert.ToInt16(row("valmax"))
            'valorconvertible = Convert.ToDouble(row("valmax"))
            valormax = Convert.ToDecimal(If(TypeOf row("valmax") Is DBNull, 0, row("valmax")))

            If valormax = 0 Then
                valormax = 0
            ElseIf valormax > 0 Then
                valormax = valormax - 1
            End If


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

            tnumsolici.Text = valostring

            Conexion.Close()

            ValidacionNumsol()

            tnumsolici.Focus()

        Else

            If tnumsolici.Text = 0 Then
                valormax = 0
            ElseIf tnumsolici.Text > 0 Then
                valormax = tnumsolici.Text - 1
            End If

            ' valormax = tnumsolici.Text - 1

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

            tnumsolici.Text = valostring

            ValidacionNumsol()

        End If
    End Sub

    Private Sub ValidacionNumsol()
        limpiarparcial()
        sql = "select * from ordenes_trabajo where num_solcitud='" & tnumsolici.Text & "'"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet

            adaptar.Fill(almacen, "ordenes_trabajo")
            resultado = almacen.Tables("ordenes_trabajo").Rows.Count
            If almacen.Tables(0).Rows.Count <> 0 Then
                For j As Integer = 0 To almacen.Tables(0).Rows.Count - 1 Step +1
                    dgvreg.Rows.Add(almacen.Tables(0).Rows(j)("id").ToString(), 0, almacen.Tables(0).Rows(j)("articulo").ToString(), almacen.Tables(0).Rows(j)("descripcion").ToString(), almacen.Tables(0).Rows(j)("unidad").ToString(), almacen.Tables(0).Rows(j)("cantidad").ToString(), almacen.Tables(0).Rows(j)("cantidad_aprov").ToString())
                Next
            End If
            If resultado > 0 Then
                registro = almacen.Tables("ordenes_trabajo").Rows(0)
                If Not IsDBNull(registro("equipo1")) Then
                    tmaquinaria.Text = registro("equipo1")
                End If
                If Not IsDBNull(registro("proyecto")) Then
                    tproyectos.Text = registro("proyecto")
                End If
                If Not IsDBNull(registro("tip_prioridad")) Then
                    tprioridad.Text = registro("tip_prioridad")
                End If
                If Not IsDBNull(registro("departamento")) Then
                    tdepartament.Text = registro("departamento")
                End If
                If Not IsDBNull(registro("estado_ord")) Then
                    lblestado.Text = registro("estado_ord")
                End If
                If Not IsDBNull(registro("aprova")) Then
                    taprobad.Text = registro("aprova")
                End If
                If Not IsDBNull(registro("observaciones")) Then
                    tobservacion.Text = registro("observaciones")
                End If
                If Not IsDBNull(registro("dtpfecha_solicitud")) Then
                    fechasolc.Value = registro("dtpfecha_solicitud")
                End If
                If Not IsDBNull(registro("dtpfecha_requerida")) Then
                    fechareq.Value = registro("dtpfecha_requerida")
                End If
            End If

            If resultado = 0 Then
                limpiarparcial()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Conexion.Close()

    End Sub

    Private Sub dgvreg_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvreg.RowPostPaint
        Me.dgvreg.Rows(e.RowIndex).Cells(1).Value = (e.RowIndex + 1).ToString
    End Sub

    Private Sub dgvreg2_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvreg2.RowPostPaint
        Me.dgvreg2.Rows(e.RowIndex).Cells(1).Value = (e.RowIndex + 1).ToString
    End Sub

    Private Sub bdatagrid_Click(sender As Object, e As EventArgs) Handles bdatagrid.Click
        mostrarINV()
    End Sub

    Private Sub blimpiar_Click(sender As Object, e As EventArgs) Handles blimpiar.Click
        limpiar()
        chknvregistro.Enabled = True
        chknvregistro.Checked = False
    End Sub
    Private Sub btadelante_Click(sender As Object, e As EventArgs) Handles btadelante.Click
        Dim valormax As Integer
        Dim valostring As String

        If tnumsolici.Text = Nothing Then
            Conexion.Open()
            Dim cmd As New SqlCommand("Valormaximo_SolicitudTrb", Conexion)
            cmd.CommandType = CommandType.StoredProcedure

            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            Dim dt As New DataTable
            dt.Clear()
            da.Fill(dt)

            Dim row As DataRow = dt.Rows(0)
            valormax = Convert.ToDecimal(If(TypeOf row("valmax") Is DBNull, 0, row("valmax")))

            If valormax = 0 Then
                valormax = 0
            ElseIf valormax > 0 Then
                valormax = valormax - 1
            End If

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

            tnumsolici.Text = valostring

            Conexion.Close()

            ValidacionNumsol()

            tnumsolici.Focus()

        Else
            valormax = tnumsolici.Text + 1

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

            tnumsolici.Text = valostring

            ValidacionNumsol()

        End If
    End Sub

    Private Sub chknvregistro_CheckedChanged(sender As Object, e As EventArgs) Handles chknvregistro.CheckedChanged

        Dim valormax As Integer
        Dim valostring As String

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
            tnumsolici.Text = Convert.ToString(row("valmax"))
            Conexion.Close()
            chknvregistro.Enabled = False
            tnumsolici.Enabled = False
            valormax = Convert.ToDecimal(If(TypeOf row("valmax") Is DBNull, 0, row("valmax")))

            If valormax = 0 Then
                valormax = 0
            ElseIf valormax > 0 Then
                valormax = valormax
            End If

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

            tnumsolici.Text = valostring

            Conexion.Close()

            ValidacionNumsol()
            chknvregistro.Enabled = False

            tnumsolici.Focus()

        Else
        End If

    End Sub

    Private Sub chkbxaceptartodo_CheckedChanged(sender As Object, e As EventArgs) Handles chkbxaceptartodo.CheckedChanged

        If chkbxaceptartodo.Checked = True Then

            For i As Integer = 0 To dgvreg.Rows.Count - 1
                dgvreg.Rows(i).Cells(6).Value = dgvreg.Rows(i).Cells(5).Value
            Next

        ElseIf chkbxaceptartodo.Checked = False Then

            For i As Integer = 0 To dgvreg.Rows.Count - 1
                dgvreg.Rows(i).Cells(6).Value = 0
            Next

        End If
    End Sub
End Class