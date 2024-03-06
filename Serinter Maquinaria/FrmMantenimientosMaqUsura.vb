Imports System.Data.SqlClient
Imports System.Data
Imports System.Runtime.InteropServices
Public Class FrmMantenimientosMaqUsura
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
        dgvinventario.Columns(9).Visible = False
        dgvinventario.Columns(10).Visible = False
        dgvinventario.AutoResizeColumns()
        dgvinventario.Columns(0).Width = 60
        dgvinventario.Columns(1).Width = 44 'Ancho Especifico
        dgvinventario.Columns(2).Width = 203
        dgvinventario.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvinventario.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvinventario.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvinventario.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvinventario.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvinventario.Columns(7).DefaultCellStyle.NullValue = My.Resources.subir
        dgvinventario.Columns(8).DefaultCellStyle.NullValue = My.Resources.subir

        dgvinventario.ClearSelection()
        Conexion.Close()

        dgvinventario.Refresh()
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
        pfoto3.Image = Nothing
        pfoto4.Image = Nothing
        tcriterio.Enabled = False
        ccampos.Enabled = False
        btnbuscar.Enabled = False
    End Sub

    Private Sub FrmMantenimientosMaqUsura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub

    Private Sub bagrlista_Click(sender As Object, e As EventArgs) Handles bagrlista.Click
        Dim id1 As String
        Dim comp_usura As String
        Dim cantidad As String
        Dim codigov As String

        Dim Valor As String
        Valor = Me.tnombre.Text
        Dim existe As Boolean = Me.dgvreg.Rows.Cast(Of DataGridViewRow).Any(Function(x) CStr(x.Cells("Componente_Usura").Value) = Valor)

        sql = "select * from registro_usura where codigo_vh='" & tcodv.Text & "'"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "registro_usura")
            resultado = almacen.Tables("registro_usura").Rows.Count

            If resultado = 0 Then

                If tcantidadmont.Value = 0 Then
                    mensaje.Text = "Agregue una Cantidad Valida"
                    Conexion.Close()
                    Exit Sub

                ElseIf tcodv.Text = Nothing Then
                    mensaje.Text = "Agregue una Valor al Item"
                    Conexion.Close()
                    Exit Sub

                ElseIf tcompusu.Text = Nothing Then
                    mensaje.Text = "Agregue una Valor al Item"
                    Conexion.Close()
                    Exit Sub
                End If

                mensaje.Text = "Mensajes"

                ID1 = dgvreg.Rows.Count.ToString
                comp_usura = tcompusu.Text
                cantidad = tcantidadmont.Value
                codigov = codp2.Text
                dgvreg.Rows.Add(id1, comp_usura, codigov, cantidad)
                Conexion.Close()

                codp2.Text = Nothing
                codp1.Text = Nothing
                tnombre.Text = Nothing
                ccategoria.Text = Nothing
                tcompusu.Text = Nothing
                tcantidadmont.Value = Nothing
                pfoto.Image = Nothing
                pfoto2.Image = Nothing
                ActualizarINV()

            ElseIf resultado > 0 Then

                dgvreg.ClearSelection()

                If tcantidadmont.Value = 0 Then
                    mensaje.Text = "Agregue una Cantidad Valida"
                    Conexion.Close()
                    Exit Sub

                ElseIf tcodv.Text = Nothing Then
                    mensaje.Text = "Agregue una Valor al Item"
                    Conexion.Close()
                    Exit Sub

                ElseIf tcompusu.Text = Nothing Then
                    mensaje.Text = "Agregue una Valor al Item"
                    Conexion.Close()
                    Exit Sub
                End If

            mensaje.Text = "Mensajes"

                ID1 = dgvreg.Rows.Count.ToString
                comp_usura = tcompusu.Text
                cantidad = tcantidadmont.Value
                codigov = codp2.Text
                dgvreg2.Rows.Add(id1, comp_usura, codigov, cantidad)
                Conexion.Close()


                codp2.Text = Nothing
                codp1.Text = Nothing
                tnombre.Text = Nothing
                ccategoria.Text = Nothing
                pfoto.Image = Nothing
                pfoto2.Image = Nothing
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
            dgvinventario.Columns(9).Visible = False
            dgvinventario.Columns(10).Visible = False
            dgvinventario.AutoResizeColumns()
            dgvinventario.Columns(0).Width = 60
            dgvinventario.Columns(1).Width = 44 'Ancho Especifico
            dgvinventario.Columns(2).Width = 203
            dgvinventario.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvinventario.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvinventario.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvinventario.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvinventario.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvinventario.Columns(7).DefaultCellStyle.NullValue = My.Resources.subir
            dgvinventario.Columns(8).DefaultCellStyle.NullValue = My.Resources.subir
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
            dgvinventario.Columns(9).Visible = False
            dgvinventario.Columns(10).Visible = False
            dgvinventario.AutoResizeColumns()
            dgvinventario.Columns(0).Width = 60
            dgvinventario.Columns(1).Width = 44 'Ancho Especifico
            dgvinventario.Columns(2).Width = 203
            dgvinventario.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvinventario.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvinventario.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvinventario.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvinventario.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
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

    Private Sub bagregar_Click(sender As Object, e As EventArgs) Handles bagregar.Click
        sql = "select * from registro_usura where codigo_vh='" & tcodv.Text & "'"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "registro_usura")
            resultado = almacen.Tables("registro_usura").Rows.Count
            If resultado > 0 Then
                Conexion.Close()
                Dim result As DialogResult
                result = MessageBox.Show("Desea Agregar Nuevos Registros?", "Actualizado!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then

                    For Each Row As DataGridViewRow In dgvreg2.Rows

                        Dim comp_usu2 As String = Row.Cells("Componente_Usura2").Value
                        Dim cod_prod2 As String = Row.Cells("Codigo2").Value
                        Dim cant_mont2 As String = Row.Cells("Cantidad_mont2").Value

                        adaptar.InsertCommand = New SqlCommand("Insert into registro_usura (codigo_vh, compont_usura, codigo_prod, cantida_mont) values ('" & tcodv.Text & "', '" & comp_usu2 & "', '" & cod_prod2 & "', '" & cant_mont2 & "')", Conexion)
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

                        Dim comp_usu As String = Row.Cells("Componente_Usura").Value
                        Dim cod_prod As String = Row.Cells("Codigo").Value
                        Dim cant_mont As String = Row.Cells("Cantidad_mont").Value

                        adaptar.InsertCommand = New SqlCommand("Insert into registro_usura (codigo_vh, compont_usura, codigo_prod, cantida_mont) values ('" & tcodv.Text & "', '" & comp_usu & "', '" & cod_prod & "', '" & cant_mont & "')", Conexion)
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

    Private Sub beliminarreg_Click(sender As Object, e As EventArgs) Handles beliminarreg.Click

        For Each Row As DataGridViewRow In dgvreg.SelectedRows

            Dim id1 As String = Row.Cells("ID1").Value
            Dim compn_usur As String = Row.Cells("Componente_Usura").Value
            Dim cod_prod As String = Row.Cells("Codigo").Value
            Dim cant_mont As String = Row.Cells("Cantidad_mont").Value

            adaptar.DeleteCommand = New SqlCommand("delete from registro_usura where codigo_vh='" & tcodv.Text & "' and id='" & id1 & "' and compont_usura='" & compn_usur & "'", Conexion)
            Conexion.Open()
            adaptar.DeleteCommand.ExecuteNonQuery()
            Conexion.Close()
            dgvreg.Rows.Remove(Row)
            dgvinventario.Refresh()
        Next

        For Each Row As DataGridViewRow In dgvreg2.SelectedRows

            dgvreg2.Rows.Remove(Row)
            dgvinventario.Refresh()
        Next
    End Sub

    Private Sub beliminar_Click(sender As Object, e As EventArgs) Handles beliminar.Click
        Try

            Dim result As DialogResult
            result = MessageBox.Show("Desea Eliminar? Se Eliminaran la informacion de usura", "Eliminando!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                For j As Integer = 0 To dgvreg.Rows.Count - 1 Step +1
                    adaptar.DeleteCommand = New SqlCommand("delete from registro_usura where codigo_vh='" & tcodv.Text & "'", Conexion)
                    Conexion.Open()
                    adaptar.DeleteCommand.ExecuteNonQuery()
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
        pfoto3.Image = Nothing
        pfoto4.Image = Nothing
        tcriterio.Enabled = False
        ccampos.Enabled = False
        btnbuscar.Enabled = False
    End Sub

    Private Sub bimprimir_Click(sender As Object, e As EventArgs) Handles bimprimir.Click
        FrmMantenimientosMaqImprUsura2.tcodv.Text = Me.tcodv.Text
        FrmMantenimientosMaqImprUsura2.ShowDialog()
    End Sub

    Private Sub dgvinventario_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvinventario.CellContentClick

        codp2.Text = dgvinventario.CurrentRow.Cells.Item(0).Value.ToString
        codp1.Text = dgvinventario.CurrentRow.Cells.Item(1).Value.ToString
        tnombre.Text = dgvinventario.CurrentRow.Cells.Item(2).Value.ToString
        ccategoria.Text = dgvinventario.CurrentRow.Cells.Item(3).Value.ToString
        pfoto3.Image = dgvinventario.CurrentRow.Cells("foto1").FormattedValue
        pfoto3.SizeMode = PictureBoxSizeMode.StretchImage
        pfoto4.Image = dgvinventario.CurrentRow.Cells("foto2").FormattedValue
        pfoto4.SizeMode = PictureBoxSizeMode.StretchImage

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        sql = "select * from registro_usura where codigo_vh='" & tcodv.Text & "'"
        Try
            '   Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "registro_usura")
            resultado = almacen.Tables("registro_usura").Rows.Count
            If almacen.Tables(0).Rows.Count <> 0 Then
                For j As Integer = 0 To almacen.Tables(0).Rows.Count - 1 Step +1
                    dgvreg.Rows.Add(almacen.Tables(0).Rows(j)("id").ToString(), almacen.Tables(0).Rows(j)("compont_usura").ToString(), almacen.Tables(0).Rows(j)("codigo_prod").ToString(), almacen.Tables(0).Rows(j)("cantida_mont").ToString())
                Next
            End If

            If resultado = 0 Then

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

    Private Sub tcompusu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tcompusu.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tcantidadmont.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub tcantidadmont_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tcantidadmont.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            bagregar.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub tcompusu_TextChanged(sender As Object, e As EventArgs) Handles tcompusu.TextChanged
        tcompusu.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tcompusu.Text)
        tcompusu.SelectionStart = tcompusu.Text.Length
    End Sub

    Private Sub dgvreg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvreg.CellContentClick
        dgvreg2.ClearSelection()
    End Sub

    Private Sub dgvreg2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvreg2.CellContentClick
        dgvreg.ClearSelection()
    End Sub

End Class