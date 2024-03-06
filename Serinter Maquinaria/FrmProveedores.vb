Imports System.Data.SqlClient
Imports System.Data
Imports System.Runtime.InteropServices
Public Class FrmProveedores
    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        If ccampos.Text = Nothing And tcriterio.Text = Nothing Then
            sql = "select * from proveedores order by cod_proveedor"
        ElseIf ccampos.Text <> Nothing And tcriterio.Text <> Nothing Then
            sql = "select * from proveedores where " & ccampos.Text & " like '%" & tcriterio.Text & "%'"
            sql += "order by cod_proveedor"
        Else
            sql = "select * from proveedores order by cod_proveedor"
        End If
        'MsgBox(sql)
        Try
            Conexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        adaptar = New SqlDataAdapter(sql, Conexion)
        almacen = New DataSet
        adaptar.Fill(almacen, "proveedores")
        resultado = almacen.Tables("proveedores").Rows.Count
        If resultado > 0 Then
            dgvproveedor.DataSource = almacen
            dgvproveedor.DataMember = "proveedores"
            dgvproveedor.Columns(0).HeaderText = "cod_proveedor"
            dgvproveedor.Columns(1).Visible = False
            dgvproveedor.Columns(2).HeaderText = "especialidad"
            dgvproveedor.Columns(3).HeaderText = "nom_proveedor"
            dgvproveedor.Columns(4).HeaderText = "alias"
            dgvproveedor.Columns(5).Visible = False
            dgvproveedor.Columns(6).HeaderText = "pais_prov"
            dgvproveedor.Columns(7).Visible = False
            dgvproveedor.Columns(8).HeaderText = "email_prov"
            dgvproveedor.Columns(9).Visible = False
            dgvproveedor.Columns(10).Visible = False
            dgvproveedor.Columns(11).Visible = False
            dgvproveedor.Columns(12).Visible = False
            dgvproveedor.Columns(13).Visible = False
            dgvproveedor.Columns(14).Visible = False
            dgvproveedor.AutoResizeColumns()
            dgvproveedor.Columns(0).Width = 85
            dgvproveedor.Columns(1).Width = 90
            dgvproveedor.Columns(2).Width = 120
            dgvproveedor.Columns(3).Width = 225
            dgvproveedor.Columns(4).Width = 110 'Ancho Especifico
            dgvproveedor.Columns(6).Width = 100
            dgvproveedor.Columns(8).Width = 160

            dgvproveedor.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvproveedor.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvproveedor.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvproveedor.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvproveedor.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        ElseIf resultado = 0 Then
            mensaje.Text = "No se encuentra con mostrar"
            dgvproveedor.DataSource = Nothing
            dgvproveedor.DataMember = Nothing
            dgvproveedor.Refresh()
        End If
        Conexion.Close()
        dgvproveedor.Focus()
    End Sub
    Private Sub MostrarProv()
        If ccampos.Text = Nothing And tcriterio.Text = Nothing Then
            sql = "select * from proveedores order by cod_proveedor"
        ElseIf ccampos.Text <> Nothing And tcriterio.Text <> Nothing Then
            sql = "select * from proveedores where " & ccampos.Text & " like '%" & tcriterio.Text & "%'"
            sql += "order by cod_proveedor"
        Else
            sql = "select * from proveedores order by cod_proveedor"
        End If
        'MsgBox(sql)
        Try
            Conexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        adaptar = New SqlDataAdapter(sql, Conexion)
        almacen = New DataSet
        adaptar.Fill(almacen, "proveedores")
        resultado = almacen.Tables("proveedores").Rows.Count
        If resultado > 0 Then
            dgvproveedor.DataSource = almacen
            dgvproveedor.DataMember = "proveedores"
            dgvproveedor.Columns(0).HeaderText = "cod_proveedor"
            dgvproveedor.Columns(1).Visible = False
            dgvproveedor.Columns(2).HeaderText = "especialidad"
            dgvproveedor.Columns(3).HeaderText = "nom_proveedor"
            dgvproveedor.Columns(4).HeaderText = "alias"
            dgvproveedor.Columns(5).Visible = False
            dgvproveedor.Columns(6).HeaderText = "pais_prov"
            dgvproveedor.Columns(7).Visible = False
            dgvproveedor.Columns(8).HeaderText = "email_prov"
            dgvproveedor.Columns(9).Visible = False
            dgvproveedor.Columns(10).Visible = False
            dgvproveedor.Columns(11).Visible = False
            dgvproveedor.Columns(12).Visible = False
            dgvproveedor.Columns(13).Visible = False
            dgvproveedor.Columns(14).Visible = False
            dgvproveedor.AutoResizeColumns()
            dgvproveedor.Columns(0).Width = 85
            dgvproveedor.Columns(1).Width = 90
            dgvproveedor.Columns(2).Width = 120
            dgvproveedor.Columns(3).Width = 225
            dgvproveedor.Columns(4).Width = 110 'Ancho Especifico
            dgvproveedor.Columns(6).Width = 100
            dgvproveedor.Columns(8).Width = 160

            dgvproveedor.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvproveedor.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvproveedor.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvproveedor.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvproveedor.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        ElseIf resultado = 0 Then
            mensaje.Text = "No se encuentra con mostrar"
            dgvproveedor.DataSource = Nothing
            dgvproveedor.DataMember = Nothing
            dgvproveedor.Refresh()
        End If
        Conexion.Close()
    End Sub

    Private Sub FrmProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion = New SqlConnection
        Conexion.ConnectionString = cadena
        MostrarProv()
        If FrmPrincipal.lrol.Text = "Administrador" Then
            bdescartar.Enabled = True
        ElseIf FrmPrincipal.lrol.Text = "Administracion" Then
            bdescartar.Enabled = True
        ElseIf FrmPrincipal.lrol.Text = "Dueño" Then
            bdescartar.Enabled = True
        Else
            bdescartar.Enabled = False
        End If
        'Dim da As New SqlDataAdapter("Select * from paises_bdd", Conexion)
        'Dim dt As New DataTable
        'da.Fill(dt)
        'tpais.DataSource = dt
        'tpais.DisplayMember = "nombre"
        'tpais.ValueMember = "pais"
        Dim sql As String = "Select * from paises_bdd"
        Dim DA As New SqlDataAdapter(sql, Conexion)
        Dim DS As New DataSet
        DA.fill(DS, "paises_bdd")
        Dim fila As DataRow
        For Each fila In DS.Tables("paises_bdd").Rows
            tpais.Items.Add(fila("pais") & "-" & fila("nombre"))
        Next

        Dim sql2 As String = "Select * from moneda_bdd"
        Dim DA2 As New SqlDataAdapter(sql2, Conexion)
        Dim DS2 As New DataSet
        DA2.Fill(DS2, "moneda_bdd")
        Dim fila2 As DataRow
        For Each fila2 In DS2.Tables("moneda_bdd").Rows
            tmoneda.Items.Add(fila2("codigo") & "-" & fila2("pais"))
        Next
    End Sub

    Private Sub bdatagrid_Click(sender As Object, e As EventArgs) Handles bdatagrid.Click
        btnbuscar.Enabled = True
        ccampos.Enabled = True
        tcriterio.Enabled = True
        sql = "select * from proveedores order by cod_proveedor"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "proveedores")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        dgvproveedor.DataSource = almacen
        dgvproveedor.DataMember = "proveedores"
        dgvproveedor.Columns(0).HeaderText = "cod_proveedor"
        dgvproveedor.Columns(1).Visible = False
        dgvproveedor.Columns(2).HeaderText = "especialidad"
        dgvproveedor.Columns(3).HeaderText = "nom_proveedor"
        dgvproveedor.Columns(4).HeaderText = "alias"
        dgvproveedor.Columns(5).Visible = False
        dgvproveedor.Columns(6).HeaderText = "pais_prov"
        dgvproveedor.Columns(7).Visible = False
        dgvproveedor.Columns(8).HeaderText = "email_prov"
        dgvproveedor.Columns(9).Visible = False
        dgvproveedor.Columns(10).Visible = False
        dgvproveedor.Columns(11).Visible = False
        dgvproveedor.Columns(12).Visible = False
        dgvproveedor.Columns(13).Visible = False
        dgvproveedor.Columns(14).Visible = False
        dgvproveedor.AutoResizeColumns()
        dgvproveedor.Columns(0).Width = 85
        dgvproveedor.Columns(1).Width = 90
        dgvproveedor.Columns(2).Width = 120
        dgvproveedor.Columns(3).Width = 225
        dgvproveedor.Columns(4).Width = 110 'Ancho Especifico
        dgvproveedor.Columns(6).Width = 100
        dgvproveedor.Columns(8).Width = 160

        dgvproveedor.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvproveedor.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvproveedor.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvproveedor.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvproveedor.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Conexion.Close()
        dgvproveedor.Refresh()
    End Sub

    Private Sub dgvproveedor_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvproveedor.CellContentClick
        tcodprov.Text = dgvproveedor.CurrentRow.Cells.Item(0).Value.ToString
        tidenfiscal.Text = dgvproveedor.CurrentRow.Cells.Item(1).Value.ToString
        tespecialidad.Text = dgvproveedor.CurrentRow.Cells.Item(2).Value.ToString
        tnombre.Text = dgvproveedor.CurrentRow.Cells.Item(3).Value.ToString
        talias.Text = dgvproveedor.CurrentRow.Cells.Item(4).Value.ToString
        tdireccion.Text = dgvproveedor.CurrentRow.Cells.Item(5).Value.ToString
        tpais.Text = dgvproveedor.CurrentRow.Cells.Item(6).Value.ToString
        tmoneda.Text = dgvproveedor.CurrentRow.Cells.Item(7).Value.ToString
        tcorreo.Text = dgvproveedor.CurrentRow.Cells.Item(8).Value.ToString
        ct1.Text = dgvproveedor.CurrentRow.Cells.Item(9).Value.ToString
        nt1.Text = dgvproveedor.CurrentRow.Cells.Item(10).Value.ToString
        ct2.Text = dgvproveedor.CurrentRow.Cells.Item(11).Value.ToString
        nt2.Text = dgvproveedor.CurrentRow.Cells.Item(12).Value.ToString
        ct3.Text = dgvproveedor.CurrentRow.Cells.Item(13).Value.ToString
        nt3.Text = dgvproveedor.CurrentRow.Cells.Item(14).Value.ToString
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

    Private Sub bagregar_Click(sender As Object, e As EventArgs) Handles bagregar.Click
        If tcodprov.Text = Nothing Then
            mensaje.Text = "Dejo vacio el RNE"
            tcodprov.Focus()
            Exit Sub
        ElseIf tnombre.Text = Nothing Then
            mensaje.Text = "Dejo vacio el Nombre del Alumno"
            tnombre.Focus()
            Exit Sub
        End If
        sql = "select * from proveedores where cod_proveedor='" & tcodprov.Text & "'"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "proveedores")
            resultado = almacen.Tables("proveedores").Rows.Count
            If resultado > 0 Then
                sql = "Update proveedores set cod_iden_fiscal='" & tidenfiscal.Text & "',especialidad='" & tespecialidad.Text & "',nom_proveedor='" & tnombre.Text & "',"
                sql += "alias='" & talias.Text & "',direccion_prov='" & tdireccion.Text & "',pais_prov='" & tpais.Text & "',moneda='" & tmoneda.Text & "',"
                sql += "email_prov='" & tcorreo.Text & "',contacto1='" & ct1.Text & "',numero_cont1='" & nt1.Text & "',contacto2='" & ct2.Text & "',numero_cont2='" & nt2.Text & "',contacto3='" & ct3.Text & "',numero_cont3='" & nt3.Text & "' where cod_proveedor='" & tcodprov.Text & "'"
            ElseIf resultado = 0 Then
                sql = "insert into proveedores (cod_proveedor,cod_iden_fiscal,especialidad,nom_proveedor,alias,direccion_prov,pais_prov,moneda,email_prov,contacto1,numero_cont1,contacto2,numero_cont2,contacto3,numero_cont3) values ("
                sql += "'" & tcodprov.Text & "','" & tidenfiscal.Text & "','" & tespecialidad.Text & "','" & tnombre.Text & "',"
                sql += "'" & talias.Text & "','" & tdireccion.Text & "','" & tpais.Text & "','" & tmoneda.Text & "',"
                sql += "'" & tcorreo.Text & "','" & ct1.Text & "','" & nt1.Text & "','" & ct2.Text & "','" & nt2.Text & "','" & ct3.Text & "','" & nt3.Text & "')"
            End If
            Comando = New SqlCommand(sql, Conexion)
            Comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        limpiar()
        Conexion.Close()
        tcodprov.Focus()
        MostrarProv()
    End Sub
    Private Sub limpiarparcial()
        tidenfiscal.Text = Nothing
        talias.Text = Nothing
        tnombre.Text = Nothing
        tespecialidad.Text = Nothing
        tdireccion.Text = Nothing
        tpais.Text = Nothing
        tmoneda.Text = Nothing
        tcorreo.Text = Nothing
        ct1.Text = Nothing
        nt1.Text = Nothing
        ct2.Text = Nothing
        nt2.Text = Nothing
        ct3.Text = Nothing
        nt3.Text = Nothing
    End Sub
    Private Sub limpiar()
        tcodprov.Text = Nothing
        limpiarparcial()
    End Sub

    Private Sub breinicio_Click(sender As Object, e As EventArgs) Handles breinicio.Click
        limpiar()
        MostrarProv()
    End Sub

    Private Sub bdescartar_Click(sender As Object, e As EventArgs) Handles bdescartar.Click
        If tcodprov.Text = Nothing Then
            mensaje.Text = "Dejo vacio el Codigo alumno"
            tcodprov.Focus()
            Exit Sub
        End If

        If MsgBox("Borrar el Proveedor?", MsgBoxStyle.YesNo, "Sistema de SERINTER") = MsgBoxResult.Yes Then
            Try
                sql = "delete from proveedores where cod_proveedor='" & tcodprov.Text & "'"
                Conexion.Open()
                Comando = New SqlCommand(sql, Conexion)
                Comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        Conexion.Close()
        limpiar()
        tcodprov.Focus()
        MostrarProv()
    End Sub

    Private Sub tcodprov_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tcodprov.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tcodprov_Validated(sender, e)
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub tidenfiscal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tidenfiscal.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tnombre.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub tnombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tnombre.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tespecialidad.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub tdireccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tdireccion.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tpais.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub tlocalidad_KeyPress(sender As Object, e As KeyPressEventArgs)
        If AscW(e.KeyChar) = Keys.Enter Then
            tmoneda.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub ttelefono_KeyPress(sender As Object, e As KeyPressEventArgs)
        If AscW(e.KeyChar) = Keys.Enter Then
            tcorreo.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub tcorreo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tcorreo.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            ct1.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub blimpieza_Click(sender As Object, e As EventArgs) Handles blimpieza.Click
        mensaje.Text = "Mensajes"
        ccampos.Text = Nothing
        tcriterio.Text = Nothing
    End Sub

    Private Sub tespecialidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles talias.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tdireccion.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub ct1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ct1.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            nt1.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub nt1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nt1.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            ct2.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub ct2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ct2.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            nt2.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub nt2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nt2.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            ct3.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub ct3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ct3.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            nt3.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub nt3_KeyPress(sender As Object, e As KeyPressEventArgs)
        If AscW(e.KeyChar) = Keys.Enter Then
            bagregar.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub tcodprov_Validated(sender As Object, e As EventArgs) Handles tcodprov.Validated

        sql = "Select * from proveedores where cod_proveedor='" & tcodprov.Text & "'"
        Try
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "proveedores")
            resultado = almacen.Tables("proveedores").Rows.Count
            If resultado > 0 Then
                registro = almacen.Tables("proveedores").Rows(0)
                If Not IsDBNull(registro("cod_iden_fiscal")) Then
                    tidenfiscal.Text = registro("cod_iden_fiscal")
                End If
                If Not IsDBNull(registro("nom_proveedor")) Then
                    tnombre.Text = registro("nom_proveedor")
                End If
                If Not IsDBNull(registro("especialidad")) Then
                    tespecialidad.Text = registro("especialidad")
                End If
                If Not IsDBNull(registro("direccion_prov")) Then
                    tdireccion.Text = registro("direccion_prov")
                End If
                If Not IsDBNull(registro("pais_prov")) Then
                    tpais.Text = registro("pais_prov")
                End If
                If Not IsDBNull(registro("moneda")) Then
                    tmoneda.Text = registro("moneda")
                End If
                If Not IsDBNull(registro("email_prov")) Then
                    tcorreo.Text = registro("email_prov")
                End If
                If Not IsDBNull(registro("contacto1")) Then
                    ct1.Text = registro("contacto1")
                End If
                If Not IsDBNull(registro("numero_cont1")) Then
                    nt1.Text = registro("numero_cont1")
                End If
                If Not IsDBNull(registro("contacto2")) Then
                    ct2.Text = registro("contacto2")
                End If
                If Not IsDBNull(registro("numero_cont2")) Then
                    nt2.Text = registro("numero_cont2")
                End If
                If Not IsDBNull(registro("contacto3")) Then
                    ct3.Text = registro("contacto3")
                End If
                If Not IsDBNull(registro("numero_cont3")) Then
                    nt3.Text = registro("numero_cont3")
                End If
            ElseIf resultado = 0 Then
                limpiarparcial()
            End If
        Catch ex As Exception
        End Try
        Conexion.Close()
        tidenfiscal.Focus()
    End Sub

    Private Sub ccampos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ccampos.KeyPress
        e.Handled = True
    End Sub

    Private Sub tespecialidad_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles tespecialidad.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            talias.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub tpais_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tpais.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tmoneda.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub tmoneda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tmoneda.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tcorreo.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub
End Class