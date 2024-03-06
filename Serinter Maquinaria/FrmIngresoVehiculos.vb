Imports System.Data.SqlClient
Imports System.Data
Imports System.Runtime.InteropServices
'Imports OfficeOpenXml
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO
Imports Microsoft.Office.Core
Public Class FrmIngresoVehiculos
    Private Sub bdatagrid_Click(sender As Object, e As EventArgs) Handles bdatagrid.Click
        Dim sql As String = ""

        If String.IsNullOrEmpty(ccampos.Text) And String.IsNullOrEmpty(tcriterio.Text) Then
            sql = "SELECT * FROM maquinaria ORDER BY codigo_vh"
        ElseIf Not String.IsNullOrEmpty(ccampos.Text) And Not String.IsNullOrEmpty(tcriterio.Text) Then
            sql = "SELECT * FROM maquinaria WHERE " & ccampos.Text & " LIKE '%" & tcriterio.Text & "%' ORDER BY codigo_vh"
        Else
            sql = "SELECT * FROM maquinaria ORDER BY codigo_vh"
        End If

        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "maquinaria")
            resultado = almacen.Tables("maquinaria").Rows.Count

            If resultado > 0 Then
                dgvvehiculos.DataSource = almacen.Tables("maquinaria")

                ' Establecer los nombres de las columnas
                dgvvehiculos.Columns(0).HeaderText = "codigo vh"
                dgvvehiculos.Columns(1).HeaderText = "tipo de máquina"
                dgvvehiculos.Columns(2).HeaderText = "placa vh"
                ' ... Define los nombres de las demás columnas

                ' Establecer anchos de las columnas
                dgvvehiculos.Columns(0).Width = 45
                dgvvehiculos.Columns(1).Width = 105
                dgvvehiculos.Columns(2).Width = 89
                dgvvehiculos.Columns(3).Width = 60
                dgvvehiculos.Columns(6).Visible = False

                ' ... Define los anchos de las demás columnas

                ' Alinear las celdas
                dgvvehiculos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                For Each col As DataGridViewColumn In dgvvehiculos.Columns
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                Next

                ' Configurar imágenes predeterminadas
                dgvvehiculos.Columns(9).DefaultCellStyle.NullValue = My.Resources.subir2
                dgvvehiculos.Columns(10).DefaultCellStyle.NullValue = My.Resources.subir2
            Else
                mensaje.Text = "No se encontraron resultados"
                dgvvehiculos.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conexion.Close()
            mensaje.Text = "Mensajes"
        End Try

        dgvvehiculos.Focus()
    End Sub

    Private Sub bagregar_Click(sender As Object, e As EventArgs) Handles bagregar.Click
        If tcodv.Text = Nothing Then
            mensaje.Text = "Dejo vacio el codigo del vehiculo"
            tcodv.Focus()
            Exit Sub
        ElseIf testadovh.Text = Nothing Then
            mensaje.Text = "Dejo vacio el estado de la Maquina"
            testadovh.Focus()
            Exit Sub
        End If
        sql = "select * from maquinaria where codigo_vh='" & tcodv.Text & "'"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "maquinaria")
            resultado = almacen.Tables("maquinaria").Rows.Count
            If resultado > 0 Then
                sql = "Update maquinaria set placa_vh='" & tplacveh.Text & "',tipo_maquina='" & ttipomaq.Text & "',propietario='" & tpropetarios.Text & "',ubicacion='" & tubicacion.Text & "',"
                sql += "estado_vh='" & testadovh.Text & "',condicion_vh='" & tcondicion.Text & "',marca='" & tmarcavh.Text & "',"
                sql += "modelo='" & tmodelovh.Text & "',fecha_compra='" & dtpcompra.Text & "',valor_compra='" & tpreciocompra.Text & "',tipo_transmision='" & ttipotrans.Text & "',numero_motor='" & tnomotor.Text & "',"
                sql += "color='" & tcolorvh.Text & "',año_fabricacion='" & tyearfab.Text & "',largo='" & tdimenlargo.Text & "',ancho='" & tdimenancho.Text & "',alto='" & tdimenalto.Text & "',peso='" & tdimenpeso.Text & "' where codigo_vh='" & tcodv.Text & "'"
            ElseIf resultado = 0 Then
                sql = "insert into maquinaria (codigo_vh,placa_vh,tipo_maquina,propietario,ubicacion,estado_vh,condicion_vh,marca,modelo,fecha_compra,valor_compra,tipo_transmision,numero_motor,color,año_fabricacion,largo,ancho,alto,peso) values ("
                sql += "'" & tcodv.Text & "','" & tplacveh.Text & "','" & ttipomaq.Text & "','" & tpropetarios.Text & "','" & tubicacion.Text & "',"
                sql += "'" & testadovh.Text & "','" & tcondicion.Text & "','" & tmarcavh.Text & "','" & tmodelovh.Text & "','" & dtpcompra.Text & "','" & tpreciocompra.Text & "',"
                sql += "'" & ttipotrans.Text & "','" & tnomotor.Text & "','" & tcolorvh.Text & "','" & tyearfab.Text & "','" & tdimenlargo.Text & "','" & tdimenancho.Text & "',"
                sql += "'" & tdimenalto.Text & "','" & tdimenpeso.Text & "')"

            End If
            Comando = New SqlCommand(sql, Conexion)
            Comando.ExecuteNonQuery()
            If pfoto.Image Is Nothing Then
            Else
                sql = "update maquinaria set foto1=@foto where codigo_vh='" & tcodv.Text & "'"
                Comando = New SqlCommand(sql, Conexion)
                Dim imgbdd As New System.IO.MemoryStream
                pfoto.Image.Save(imgbdd, System.Drawing.Imaging.ImageFormat.Jpeg)
                Comando.Parameters.Add("@foto", SqlDbType.VarBinary).Value = imgbdd.GetBuffer
                Comando.ExecuteNonQuery()
            End If

            If pfoto2.Image Is Nothing Then
            Else
                sql = "update maquinaria set foto2=@foto where codigo_vh='" & tcodv.Text & "'"
                Comando = New SqlCommand(sql, Conexion)
                Dim imgbdd As New System.IO.MemoryStream
                pfoto2.Image.Save(imgbdd, System.Drawing.Imaging.ImageFormat.Jpeg)
                Comando.Parameters.Add("@foto", SqlDbType.VarBinary).Value = imgbdd.GetBuffer
                Comando.ExecuteNonQuery()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        limpiar()
        Conexion.Close()
        MostraVehiculos()
        tcodv.Focus()
    End Sub
    Private Sub limpiarparcial()
        tplacveh.Text = Nothing
        ttipomaq.Text = Nothing
        testadovh.Text = Nothing
        tmarcavh.Text = Nothing
        tmodelovh.Text = Nothing
        tpropetarios.Text = Nothing
        tubicacion.Text = Nothing
        tcondicion.Text = Nothing
        dtpcompra.Value = Now
        tpreciocompra.Text = 0
        pfoto.Image = Nothing
        pfoto2.Image = Nothing
        ttipotrans.Text = Nothing
        tnomotor.Text = Nothing
        tcolorvh.Text = Nothing
        tyearfab.Text = Nothing
        tdimenlargo.Text = Nothing
        tdimenancho.Text = Nothing
        tdimenalto.Text = Nothing
        tdimenpeso.Text = Nothing

    End Sub
    Private Sub limpiar()
        tcodv.Text = Nothing
        limpiarparcial()
    End Sub


    Private Sub pfoto_Click(sender As Object, e As EventArgs) Handles pfoto.Click
        Dim file As New OpenFileDialog()
        file.Filter = "Archivo JPG|*.jpg"
        If file.ShowDialog() = DialogResult.OK Then
            pfoto.Image = Image.FromFile(file.FileName)
            pfoto.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub
    Private Sub pfoto2_Click(sender As Object, e As EventArgs) Handles pfoto2.Click
        Dim file As New OpenFileDialog()
        file.Filter = "Archivo JPG|*.jpg"
        If file.ShowDialog() = DialogResult.OK Then
            pfoto2.Image = Image.FromFile(file.FileName)
            pfoto2.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub
    Private Sub breiniciar_Click(sender As Object, e As EventArgs) Handles breiniciar.Click
        limpiar()
        MostraVehiculos()
    End Sub

    Private Sub FrmIngresoVehiculos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion = New SqlConnection
        Conexion.ConnectionString = cadena
        Dim da As New SqlDataAdapter("Select * from ubicaciones_vehiculos", Conexion)
        Dim dt As New DataTable
        da.Fill(dt)
        tubicacion.DataSource = dt
        tubicacion.DisplayMember = "ubicacion"
        tubicacion.ValueMember = "codigo_p"
        MostraVehiculos()
        If FrmPrincipal.lrol.Text = "Administrador" Then
            beliminar.Enabled = True
        ElseIf FrmPrincipal.lrol.Text = "Administracion" Then
            beliminar.Enabled = True
        ElseIf FrmPrincipal.lrol.Text = "Dueño" Then
            beliminar.Enabled = True
        Else
            beliminar.Enabled = False
        End If
    End Sub


    Private Sub dgvvehiculos_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgvvehiculos.CellPainting

        For i = 0 To dgvvehiculos.Rows.Count - 1
            Dim r As DataGridViewRow = dgvvehiculos.Rows(i)
            r.Height = 94
        Next

        If (e.RowIndex < 0 Or e.ColumnIndex < 0) Then Return

        If dgvvehiculos.Rows(e.RowIndex).Cells(e.ColumnIndex).ValueType = GetType(Byte()) Then
            CType(dgvvehiculos.Rows(e.RowIndex).Cells(e.ColumnIndex), 
                  DataGridViewImageCell).ImageLayout = DataGridViewImageCellLayout.Zoom
        End If
    End Sub

    Private Sub dgvvehiculos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvvehiculos.CellContentClick
        tcodv.Text = dgvvehiculos.CurrentRow.Cells.Item(0).Value.ToString
        ttipomaq.Text = dgvvehiculos.CurrentRow.Cells.Item(1).Value.ToString
        tplacveh.Text = dgvvehiculos.CurrentRow.Cells.Item(2).Value.ToString
        tpropetarios.Text = dgvvehiculos.CurrentRow.Cells.Item(3).Value.ToString
        tubicacion.Text = dgvvehiculos.CurrentRow.Cells.Item(4).Value.ToString
        testadovh.Text = dgvvehiculos.CurrentRow.Cells.Item(5).Value.ToString
        tcondicion.Text = dgvvehiculos.CurrentRow.Cells.Item(6).Value.ToString
        tmarcavh.Text = dgvvehiculos.CurrentRow.Cells.Item(7).Value.ToString
        tmodelovh.Text = dgvvehiculos.CurrentRow.Cells.Item(8).Value.ToString
        dtpcompra.Text = dgvvehiculos.CurrentRow.Cells.Item(11).Value.ToString
        tpreciocompra.Text = dgvvehiculos.CurrentRow.Cells.Item(12).Value.ToString
        ttipotrans.Text = dgvvehiculos.CurrentRow.Cells.Item(13).Value.ToString
        tnomotor.Text = dgvvehiculos.CurrentRow.Cells.Item(14).Value.ToString
        tcolorvh.Text = dgvvehiculos.CurrentRow.Cells.Item(15).Value.ToString
        tyearfab.Text = dgvvehiculos.CurrentRow.Cells.Item(16).Value.ToString
        tdimenlargo.Text = dgvvehiculos.CurrentRow.Cells.Item(17).Value.ToString
        tdimenancho.Text = dgvvehiculos.CurrentRow.Cells.Item(18).Value.ToString
        tdimenalto.Text = dgvvehiculos.CurrentRow.Cells.Item(19).Value.ToString
        tdimenpeso.Text = dgvvehiculos.CurrentRow.Cells.Item(20).Value.ToString


            pfoto.Image = dgvvehiculos.CurrentRow.Cells("foto1").FormattedValue
            pfoto.SizeMode = PictureBoxSizeMode.StretchImage
            pfoto2.Image = dgvvehiculos.CurrentRow.Cells("foto2").FormattedValue
            pfoto2.SizeMode = PictureBoxSizeMode.StretchImage

    End Sub

    Private Sub beliminar_Click(sender As Object, e As EventArgs) Handles beliminar.Click
        If tcodv.Text = Nothing Then
            mensaje.Text = "Dejo vacio el Codigo del Vehiculos"
            tcodv.Focus()
            Exit Sub
        End If

        If MsgBox("Borrar el Vehiculo?", MsgBoxStyle.YesNo, "Sistema de SERINTER") = MsgBoxResult.Yes Then
            Try
                sql = "delete from maquinaria where codigo_vh='" & tcodv.Text & "'"
                Conexion.Open()
                Comando = New SqlCommand(sql, Conexion)
                Comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        Conexion.Close()
        limpiar()
        MostraVehiculos()
        tcodv.Focus()
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Dim sql As String = ""

        Dim campoSeleccionado As String = ccampos.SelectedItem.ToString()

        If String.IsNullOrEmpty(campoSeleccionado) And String.IsNullOrEmpty(tcriterio.Text) Then
            sql = "SELECT * FROM maquinaria ORDER BY codigo_vh"
        ElseIf Not String.IsNullOrEmpty(campoSeleccionado) And Not String.IsNullOrEmpty(tcriterio.Text) Then
            sql = "SELECT * FROM maquinaria WHERE " & campoSeleccionado & " LIKE '%" & tcriterio.Text & "%' ORDER BY codigo_vh"
        Else
            sql = "SELECT * FROM maquinaria ORDER BY codigo_vh"
        End If

        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "maquinaria")
            resultado = almacen.Tables("maquinaria").Rows.Count

            If resultado > 0 Then
                dgvvehiculos.DataSource = almacen.Tables("maquinaria")

                ' Establecer los nombres de las columnas
                dgvvehiculos.Columns(0).HeaderText = "codigo vh"
                dgvvehiculos.Columns(1).HeaderText = "tipo de máquina"
                dgvvehiculos.Columns(2).HeaderText = "placa vh"
                ' ... Define los nombres de las demás columnas

                ' Establecer anchos de las columnas
                dgvvehiculos.Columns(0).Width = 45
                dgvvehiculos.Columns(1).Width = 105
                dgvvehiculos.Columns(2).Width = 89
                dgvvehiculos.Columns(3).Width = 60
                dgvvehiculos.Columns(6).Visible = False
                ' ... Define los anchos de las demás columnas

                ' Alinear las celdas
                dgvvehiculos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                For Each col As DataGridViewColumn In dgvvehiculos.Columns
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                Next

                ' Configurar imágenes predeterminadas
                dgvvehiculos.Columns(9).DefaultCellStyle.NullValue = My.Resources.subir2
                dgvvehiculos.Columns(10).DefaultCellStyle.NullValue = My.Resources.subir2
            Else
                mensaje.Text = "No se encontraron resultados"
                dgvvehiculos.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conexion.Close()
            mensaje.Text = "Mensajes"
        End Try

        dgvvehiculos.Focus()
    End Sub
    Private Sub MostraVehiculos()
        Dim sql As String = ""

        If String.IsNullOrEmpty(ccampos.Text) And String.IsNullOrEmpty(tcriterio.Text) Then
            sql = "SELECT * FROM maquinaria ORDER BY codigo_vh"
        ElseIf Not String.IsNullOrEmpty(ccampos.Text) And Not String.IsNullOrEmpty(tcriterio.Text) Then
            sql = "SELECT * FROM maquinaria WHERE " & ccampos.Text & " LIKE '%" & tcriterio.Text & "%' ORDER BY codigo_vh"
        Else
            sql = "SELECT * FROM maquinaria ORDER BY codigo_vh"
        End If

        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "maquinaria")
            resultado = almacen.Tables("maquinaria").Rows.Count

            If resultado > 0 Then
                dgvvehiculos.DataSource = almacen.Tables("maquinaria")

                ' Establecer los nombres de las columnas
                dgvvehiculos.Columns(0).HeaderText = "codigo vh"
                dgvvehiculos.Columns(1).HeaderText = "tipo de máquina"
                dgvvehiculos.Columns(2).HeaderText = "placa vh"
                ' ... Define los nombres de las demás columnas

                ' Establecer anchos de las columnas
                dgvvehiculos.Columns(0).Width = 45
                dgvvehiculos.Columns(1).Width = 105
                dgvvehiculos.Columns(2).Width = 89
                dgvvehiculos.Columns(3).Width = 60
                dgvvehiculos.Columns(6).Visible = False

                ' ... Define los anchos de las demás columnas

                ' Alinear las celdas
                dgvvehiculos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                For Each col As DataGridViewColumn In dgvvehiculos.Columns
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                Next

                ' Configurar imágenes predeterminadas
                dgvvehiculos.Columns(9).DefaultCellStyle.NullValue = My.Resources.subir2
                dgvvehiculos.Columns(10).DefaultCellStyle.NullValue = My.Resources.subir2
            Else
                mensaje.Text = "No se encontraron resultados"
                dgvvehiculos.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conexion.Close()
            mensaje.Text = "Mensajes"
        End Try

        dgvvehiculos.Focus()
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

    Private Sub blimpieza_Click(sender As Object, e As EventArgs) Handles blimpieza.Click
        mensaje.Text = "Mensajes"
        btnbuscar.Text = Nothing
        ccampos.Text = Nothing
        tcriterio.Text = Nothing
    End Sub

    Private Sub tcodv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tcodv.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tcodv_Validated(sender, e)
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub tplacveh_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tplacveh.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            testadovh.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub testadovh_KeyPress(sender As Object, e As KeyPressEventArgs) Handles testadovh.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            ttipomaq.Focus()
            mensaje.Text = "Mensajes"
        End If
        e.Handled = True
    End Sub

    Private Sub tcolorvh_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tcolorvh.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tyearfab.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub tmarcavh_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tmarcavh.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tmodelovh.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub tmodelovh_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tmodelovh.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tpropetarios.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub tpropetarios_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tpropetarios.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tubicacion.Focus()
            mensaje.Text = "Mensajes"
        End If
        e.Handled = True
    End Sub

    Private Sub tubicacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tubicacion.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tcondicion.Focus()
            mensaje.Text = "Mensajes"
        End If
        '   e.Handled = True
    End Sub

    Private Sub tcondicion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tcondicion.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            dtpcompra.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub dtpcompra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtpcompra.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tpreciocompra.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub tpreciocompra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tpreciocompra.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
            If Asc(e.KeyChar) = 46 Then
                e.Handled = False
            End If
        End If
        If AscW(e.KeyChar) = Keys.Enter Then
            ttipotrans.Focus()
            mensaje.Text = "Mensajes"
        End If

    End Sub

    Private Sub tcodv_Validated(sender As Object, e As EventArgs) Handles tcodv.Validated
        sql = "Select * from maquinaria where codigo_vh='" & tcodv.Text & "'"
        Try
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "maquinaria")
            resultado = almacen.Tables("maquinaria").Rows.Count
            If resultado > 0 Then
                registro = almacen.Tables("maquinaria").Rows(0)
                If Not IsDBNull(registro("placa_vh")) Then
                    tplacveh.Text = registro("placa_vh")
                End If
                If Not IsDBNull(registro("estado_vh")) Then
                    testadovh.Text = registro("estado_vh")
                End If
                If Not IsDBNull(registro("tipo_maquina")) Then
                    ttipomaq.Text = registro("tipo_maquina")
                End If
                If Not IsDBNull(registro("marca")) Then
                    tmarcavh.Text = registro("marca")
                End If
                If Not IsDBNull(registro("modelo")) Then
                    tmodelovh.Text = registro("modelo")
                End If
                If Not IsDBNull(registro("propietario")) Then
                    tpropetarios.Text = registro("propietario")
                End If
                If Not IsDBNull(registro("ubicacion")) Then
                    tubicacion.Text = registro("ubicacion")
                End If
                If Not IsDBNull(registro("condicion_vh")) Then
                    tcondicion.Text = registro("condicion_vh")
                End If
                If Not IsDBNull(registro("fecha_compra")) Then
                    dtpcompra.Value = registro("fecha_compra")
                End If
                If Not IsDBNull(registro("valor_compra")) Then
                    tpreciocompra.Text = registro("valor_compra")
                End If
                If Not IsDBNull(registro("tipo_transmision")) Then
                    ttipotrans.Text = registro("tipo_transmision")
                End If
                If Not IsDBNull(registro("numero_motor")) Then
                    tnomotor.Text = registro("numero_motor")
                End If
                If Not IsDBNull(registro("color")) Then
                    tcolorvh.Text = registro("color")
                End If
                If Not IsDBNull(registro("año_fabricacion")) Then
                    tyearfab.Text = registro("año_fabricacion")
                End If
                If Not IsDBNull(registro("largo")) Then
                    tdimenlargo.Text = registro("largo")
                End If
                If Not IsDBNull(registro("ancho")) Then
                    tdimenancho.Text = registro("ancho")
                End If
                If Not IsDBNull(registro("alto")) Then
                    tdimenalto.Text = registro("alto")
                End If
                If Not IsDBNull(registro("peso")) Then
                    tdimenpeso.Text = registro("peso")
                End If
                If Not IsDBNull(registro("foto1")) Then
                    Dim vfoto As Byte() = CType(registro("foto1"), Byte())
                    Dim ms As IO.MemoryStream
                    ms = New IO.MemoryStream(vfoto)
                    Dim img As Image = Image.FromStream(ms)
                    pfoto.Image = img
                    pfoto.SizeMode = PictureBoxSizeMode.StretchImage
                Else
                    pfoto.Image = Nothing
                End If
                If Not IsDBNull(registro("foto2")) Then
                    Dim vfoto As Byte() = CType(registro("foto2"), Byte())
                    Dim ms As IO.MemoryStream
                    ms = New IO.MemoryStream(vfoto)
                    Dim img As Image = Image.FromStream(ms)
                    pfoto2.Image = img
                    pfoto2.SizeMode = PictureBoxSizeMode.StretchImage
                Else
                    pfoto.Image = Nothing
                End If

            ElseIf resultado = 0 Then
                limpiarparcial()
            End If
        Catch ex As Exception
        End Try
        Conexion.Close()
        tplacveh.Focus()
    End Sub

    Private Sub ttipotrans_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ttipotrans.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tnomotor.Focus()
            mensaje.Text = "Mensajes"
        End If
        e.Handled = True
    End Sub

    Private Sub ccampos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ccampos.KeyPress
        e.Handled = True
    End Sub

    Private Sub tnomotor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tnomotor.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tcolorvh.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub tyearfab_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tyearfab.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tdimenlargo.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub tdimenlargo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tdimenlargo.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tdimenancho.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub tdimenancho_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tdimenancho.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tdimenalto.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub tdimenalto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tdimenalto.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tdimenpeso.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub tdimenpeso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tdimenpeso.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            bagregar.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub ttipomaq_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ttipomaq.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tmarcavh.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub dgvvehiculos_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgvvehiculos.MouseDoubleClick

        FrmSeleccionVhMan.Show()
        FrmSeleccionVhMan.codv = dgvvehiculos.CurrentRow.Cells.Item(0).Value.ToString
        FrmSeleccionVhMan.placaveh = dgvvehiculos.CurrentRow.Cells.Item(1).Value.ToString
        FrmSeleccionVhMan.estadovh = dgvvehiculos.CurrentRow.Cells.Item(2).Value.ToString
        FrmSeleccionVhMan.tipomaq = dgvvehiculos.CurrentRow.Cells.Item(3).Value.ToString
        FrmSeleccionVhMan.marca = dgvvehiculos.CurrentRow.Cells.Item(4).Value.ToString
        FrmSeleccionVhMan.modelo = dgvvehiculos.CurrentRow.Cells.Item(5).Value.ToString
        FrmSeleccionVhMan.propietariosE = dgvvehiculos.CurrentRow.Cells.Item(6).Value.ToString
        FrmSeleccionVhMan.ubicaciond = dgvvehiculos.CurrentRow.Cells.Item(7).Value.ToString
        FrmSeleccionVhMan.condicion = dgvvehiculos.CurrentRow.Cells.Item(8).Value.ToString
        FrmSeleccionVhMan.compradt = dgvvehiculos.CurrentRow.Cells.Item(11).Value.ToString
        FrmSeleccionVhMan.tprecio = dgvvehiculos.CurrentRow.Cells.Item(12).Value.ToString
        FrmSeleccionVhMan.tipotrans = dgvvehiculos.CurrentRow.Cells.Item(13).Value.ToString
        FrmSeleccionVhMan.tnomotor = dgvvehiculos.CurrentRow.Cells.Item(14).Value.ToString
        FrmSeleccionVhMan.tcolorvh = dgvvehiculos.CurrentRow.Cells.Item(15).Value.ToString
        FrmSeleccionVhMan.tyearfab = dgvvehiculos.CurrentRow.Cells.Item(16).Value.ToString
        FrmSeleccionVhMan.dimenlarg = dgvvehiculos.CurrentRow.Cells.Item(17).Value.ToString
        FrmSeleccionVhMan.dimenancho = dgvvehiculos.CurrentRow.Cells.Item(18).Value.ToString
        FrmSeleccionVhMan.dimenalto = dgvvehiculos.CurrentRow.Cells.Item(19).Value.ToString
        FrmSeleccionVhMan.dimenpeso = dgvvehiculos.CurrentRow.Cells.Item(20).Value.ToString

        FrmSeleccionVhMan.foto = dgvvehiculos.CurrentRow.Cells("foto1").FormattedValue
        FrmSeleccionVhMan.foto2 = dgvvehiculos.CurrentRow.Cells("foto2").FormattedValue

        'FrmMantenimientosMaq.tcodv.Text = dgvvehiculos.CurrentRow.Cells.Item(0).Value.ToString
        'FrmMantenimientosMaq.ttipomaq.Text = dgvvehiculos.CurrentRow.Cells.Item(1).Value.ToString
        'FrmMantenimientosMaq.tplacveh.Text = dgvvehiculos.CurrentRow.Cells.Item(2).Value.ToString
        'FrmMantenimientosMaq.tpropetarios.Text = dgvvehiculos.CurrentRow.Cells.Item(3).Value.ToString
        'FrmMantenimientosMaq.tubicacion.Text = dgvvehiculos.CurrentRow.Cells.Item(4).Value.ToString
        'FrmMantenimientosMaq.testadovh.Text = dgvvehiculos.CurrentRow.Cells.Item(5).Value.ToString
        'FrmMantenimientosMaq.tcondicion.Text = dgvvehiculos.CurrentRow.Cells.Item(6).Value.ToString
        'FrmMantenimientosMaq.tmarcavh.Text = dgvvehiculos.CurrentRow.Cells.Item(7).Value.ToString
        'FrmMantenimientosMaq.tmodelovh.Text = dgvvehiculos.CurrentRow.Cells.Item(8).Value.ToString
        'FrmMantenimientosMaq.dtpcompra.Text = dgvvehiculos.CurrentRow.Cells.Item(11).Value.ToString
        'FrmMantenimientosMaq.tpreciocompra.Text = dgvvehiculos.CurrentRow.Cells.Item(12).Value.ToString
        'FrmMantenimientosMaq.ttipotrans.Text = dgvvehiculos.CurrentRow.Cells.Item(13).Value.ToString
        'FrmMantenimientosMaq.tnomotor.Text = dgvvehiculos.CurrentRow.Cells.Item(14).Value.ToString
        'FrmMantenimientosMaq.tcolorvh.Text = dgvvehiculos.CurrentRow.Cells.Item(15).Value.ToString
        'FrmMantenimientosMaq.tyearfab.Text = dgvvehiculos.CurrentRow.Cells.Item(16).Value.ToString
        'FrmMantenimientosMaq.tdimenlargo.Text = dgvvehiculos.CurrentRow.Cells.Item(17).Value.ToString
        'FrmMantenimientosMaq.tdimenancho.Text = dgvvehiculos.CurrentRow.Cells.Item(18).Value.ToString
        'FrmMantenimientosMaq.tdimenalto.Text = dgvvehiculos.CurrentRow.Cells.Item(19).Value.ToString
        'FrmMantenimientosMaq.tdimenpeso.Text = dgvvehiculos.CurrentRow.Cells.Item(20).Value.ToString

        'FrmMantenimientosMaq.pfoto.Image = dgvvehiculos.CurrentRow.Cells("foto1").FormattedValue
        'FrmMantenimientosMaq.pfoto.SizeMode = PictureBoxSizeMode.StretchImage
        'FrmMantenimientosMaq.pfoto2.Image = dgvvehiculos.CurrentRow.Cells("foto2").FormattedValue
        'FrmMantenimientosMaq.pfoto2.SizeMode = PictureBoxSizeMode.StretchImage
        'FrmMantenimientosMaq.Timer1.Enabled = True
    End Sub

    Private Sub tpreciocompra_TextChanged(sender As Object, e As EventArgs) Handles tpreciocompra.TextChanged
        If tpreciocompra.Text = Nothing Then
            tpreciocompra.Text = 0
        Else
        End If
    End Sub

    Private Sub btimpresion_Click(sender As Object, e As EventArgs) Handles btimpresion.Click
        ExportarDatosAExcelConImagenes()
    End Sub

    Private Sub ExportarDatosAExcelConImagenes()
        Try
            Dim exApp As New Excel.Application
            Dim exLibro As Excel.Workbook
            Dim exHoja As Excel.Worksheet

            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add

            ' Llenar la hoja de Excel con los datos de la tabla maquinaria
            Dim da As New SqlDataAdapter("Select * from maquinaria", Conexion)
            Dim dt As New DataTable
            da.Fill(dt)

            ' Encabezados
            For colIndex As Integer = 1 To dt.Columns.Count
                exHoja.Cells(1, colIndex) = dt.Columns(colIndex - 1).ColumnName
            Next

            ' Datos
            For rowIndex As Integer = 0 To dt.Rows.Count - 1
                For colIndex As Integer = 0 To dt.Columns.Count - 1
                    Dim columnName As String = dt.Columns(colIndex).ColumnName
                    Dim cellValue As Object = dt.Rows(rowIndex)(colIndex)

                    ' Comprobar si la columna contiene una imagen y si es así, convertirla y agregarla a Excel
                    If columnName = "foto1" Or columnName = "foto2" Then
                        Dim imageBytes As Byte() = TryCast(cellValue, Byte())
                        If imageBytes IsNot Nothing AndAlso imageBytes.Length > 0 Then
                            ' Crear una ruta temporal para guardar la imagen
                            Dim tempImagePath As String = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString() + ".jpg")

                            ' Guardar la imagen en el archivo temporal
                            File.WriteAllBytes(tempImagePath, imageBytes)

                            ' Agregar la imagen a Excel y vincularla a la celda específica
                            Dim shape As Excel.Shape = exHoja.Shapes.AddPicture(tempImagePath, MsoTriState.msoFalse, MsoTriState.msoTrue, exHoja.Cells(rowIndex + 2, colIndex + 1).Left, exHoja.Cells(rowIndex + 2, colIndex + 1).Top, 100, 100) ' Ajusta el ancho y alto según tus necesidades

                            ' Ajustar la altura de la fila
                            exHoja.Cells(rowIndex + 2, colIndex + 1).RowHeight = shape.Height

                            ' Eliminar el archivo temporal
                            File.Delete(tempImagePath)
                        End If
                    Else
                        ' Si no es una imagen, simplemente agregar el valor a Excel
                        exHoja.Cells(rowIndex + 2, colIndex + 1) = cellValue.ToString()
                    End If
                Next
            Next

            ' Ajustar el ancho de las columnas específicas (ajusta los valores según tus necesidades)
            exHoja.Columns("J:J").ColumnWidth = 19 ' Ajusta el ancho de la primera columna
            exHoja.Columns("K:K").ColumnWidth = 19 ' Ajusta el ancho de la segunda columna
            ' Puedes seguir ajustando las columnas según sea necesario

            ' Aplicar formato de fuente (Calibri 20) y alineación
            exHoja.Cells.Font.Name = "Calibri"
            exHoja.Cells.Font.Size = 20
            exHoja.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            exHoja.Cells.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter ' Alineación vertical al centro
            exHoja.Cells.WrapText = True ' Ajustar texto

            ' Crear una tabla en Excel con el rango de datos
            Dim lastCell = exHoja.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell)
            Dim tableRange = exHoja.Range(exHoja.Cells(1, 1), lastCell)
            tableRange.Select()
            exHoja.ListObjects.Add(Excel.XlListObjectSourceType.xlSrcRange, tableRange, , Excel.XlYesNoGuess.xlYes).Name = "TablaMaquinaria"

            ' Configurar la aplicación Excel para ser visible
            exApp.Visible = True

            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
        End Try
    End Sub

End Class