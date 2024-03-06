Imports System.Data.SqlClient
Imports System.Data
Public Class FrmUsuarios

    Private Sub FrmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion = New SqlConnection
        Conexion.ConnectionString = cadena
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

    Private Sub bingresar_Click(sender As Object, e As EventArgs) Handles bingresar.Click
        vclave = tclave.Text
        vconfirmar = tconfirmar.Text
        If tusuario.Text = Nothing Then
            mensaje.Text = "Dejo Vacio el Usuario"
            tusuario.Focus()
            Exit Sub
        ElseIf tclave.Text = Nothing Then
            mensaje.Text = "Dejo Vacio la Clave"
            tclave.Focus()
            Exit Sub
        ElseIf vclave <> vconfirmar Then
            mensaje.Text = "No Coinciden los Valores"
            tclave.Focus()
            Exit Sub
        ElseIf tnombre.Text = Nothing Then
            mensaje.Text = "Dejo vacio el Nombre"
            tnombre.Focus()
            Exit Sub
        ElseIf crol.Text = Nothing Then
            mensaje.Text = "Dejo vacio el Rol"
            crol.Focus()
            Exit Sub
        End If
        sql = "select * from acceso where usuario='" & tusuario.Text & "'"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "acceso")
            resultado = almacen.Tables("acceso").Rows.Count
            If resultado > 0 Then
                sql = "update acceso set clave='" & tclave.Text & "',nombre='" & tnombre.Text & "',"
                sql += "rol='" & crol.Text & "' where usuario='" & tusuario.Text & "'"
                vobs = "Edito el Usuario" + tusuario.Text
                grabarlogs()
            ElseIf resultado = 0 Then
                sql = "insert into acceso (usuario,clave,nombre,rol) "
                sql += "values ('" & tusuario.Text & "','" & tclave.Text & "',"
                sql += "'" & tnombre.Text & "','" & crol.Text & "')"
                vobs = "Agrego el Usuario" + tusuario.Text
                grabarlogs()
            End If
            Comando = New SqlCommand(sql, Conexion)
            Comando.ExecuteNonQuery()
            'Aqui se llama al procedimiento de gabarlogs

        Catch ex As Exception
            'MsgBox("No se conecta con el Servidor")'
        End Try
        limpiar()
        Conexion.Close()
        tusuario.Focus()
        mensaje.Text = "Mensajes"
    End Sub
    Private Sub limpiarparcial()
        tnombre.Text = Nothing
        tclave.Text = Nothing
        tconfirmar.Text = Nothing
        crol.Text = Nothing
        mensaje.Text = Nothing
    End Sub

    Private Sub limpiar()
        tusuario.Text = Nothing
        limpiarparcial()
    End Sub

    Private Sub breiniciar_Click(sender As Object, e As EventArgs) Handles breiniciar.Click
        limpiar()
        tusuario.Focus()
        mensaje.Text = "Mensajes"
    End Sub

    Private Sub beliminar_Click(sender As Object, e As EventArgs) Handles beliminar.Click
        If MsgBox("Descartar Usuario?", MsgBoxStyle.YesNo, "Sistema de SERINTER") = MsgBoxResult.Yes Then

            Try
                Conexion.Open()
                sql = "delete from acceso where usuario='" & tusuario.Text & "'"
                Comando = New SqlCommand(sql, Conexion)
                Comando.ExecuteNonQuery()
                vobs = "Descarto el usuario" + tusuario.Text
                grabarlogs()
            Catch ex As Exception
                MsgBox("No se Descarto el usuario")
            End Try
        End If
        Conexion.Close()
        limpiar()
        tusuario.Focus()
        mensaje.Text = "Mensajes"
    End Sub

    Private Sub tusuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tusuario.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tclave.Focus() 'Llamado a un evento del mismo objeto
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub grabarlogs()
        Dim fecha As DateTime = DateTime.Now
        Dim fechaFormateada As String
        fechaFormateada = fecha.ToString("dd-MM-yyyyhh:mm:ss")
        sql2 = "insert into logs value ('" & vusuario & "','" & vobs & "','" & fecha & "')"
        Comando2 = New SqlCommand(sql, Conexion)
        Comando2.ExecuteNonQuery()
    End Sub

    Private Sub tclave_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tclave.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tconfirmar.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub tconfirmar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tconfirmar.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tnombre.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub tnombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tnombre.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            crol.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub cnivel_KeyPress(sender As Object, e As KeyPressEventArgs)
        If AscW(e.KeyChar) = Keys.Enter Then
            bingresar.Focus()
        End If
    End Sub

    Private Sub bdatagrid_Click(sender As Object, e As EventArgs) Handles bdatagrid.Click
        sql = "select * from acceso where rol <> 'Administrador' and rol <> 'Dueño' order by usuario"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "acceso")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        dgvusuarios.DataSource = almacen
        dgvusuarios.DataMember = "acceso"
        dgvusuarios.Columns(0).HeaderText = "usuario"
        dgvusuarios.Columns(1).HeaderText = "nombre"
        dgvusuarios.Columns(2).HeaderText = "clave"
        dgvusuarios.Columns(3).HeaderText = "rol"
        dgvusuarios.AutoResizeColumns()
        dgvusuarios.Columns(0).Width = 85
        dgvusuarios.Columns(1).Width = 250
        dgvusuarios.Columns(2).Width = 150 'Ancho Especifico
        dgvusuarios.Columns(3).Width = 175
        dgvusuarios.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvusuarios.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvusuarios.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Conexion.Close()
        dgvusuarios.Refresh()
    End Sub

    Private Sub dgvusuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvusuarios.CellContentClick
        tusuario.Text = dgvusuarios.CurrentRow.Cells.Item(0).Value.ToString
        tnombre.Text = dgvusuarios.CurrentRow.Cells.Item(1).Value.ToString
        tclave.Text = dgvusuarios.CurrentRow.Cells.Item(2).Value.ToString
        tconfirmar.Text = dgvusuarios.CurrentRow.Cells.Item(2).Value.ToString
        crol.Text = dgvusuarios.CurrentRow.Cells.Item(3).Value.ToString
    End Sub

    Private Sub crol_KeyPress(sender As Object, e As KeyPressEventArgs) Handles crol.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            bingresar.Focus()
            mensaje.Text = "Mensajes"
        End If
        e.Handled = True
    End Sub

    Private Sub tnombre_TextChanged(sender As Object, e As EventArgs) Handles tnombre.TextChanged
        tnombre.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tnombre.Text)
        tnombre.SelectionStart = tnombre.Text.Length
    End Sub

    Private Sub tusuario_TextChanged(sender As Object, e As EventArgs) Handles tusuario.TextChanged
        tusuario.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tusuario.Text)
        tusuario.SelectionStart = tusuario.Text.Length
    End Sub
End Class