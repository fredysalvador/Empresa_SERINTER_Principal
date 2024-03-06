Imports System.Data.SqlClient
Imports System.Data
Imports System.Runtime.InteropServices
Public Class FrmContPrivServicios

    Private Sub btatras_Click(sender As Object, e As EventArgs) Handles btatras.Click
        Dim valormax As Integer
        Dim valostring As String

        If tnumcorrelativo.Text = Nothing Then
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

            tnumcorrelativo.Text = valostring

            Conexion.Close()

            tnumcorrelativo_Validated(sender, e)

            tnumcorrelativo.Focus()

        Else

            valormax = tnumcorrelativo.Text - 1

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

            tnumcorrelativo.Text = valostring

            tnumcorrelativo_Validated(sender, e)

        End If
    End Sub

    Private Sub btadelante_Click(sender As Object, e As EventArgs) Handles btadelante.Click
        Dim valormax As Integer
        Dim valostring As String

        If tnumcorrelativo.Text = Nothing Then
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

            tnumcorrelativo.Text = valostring

            Conexion.Close()

            tnumcorrelativo_Validated(sender, e)

            tnumcorrelativo.Focus()

        Else
            valormax = tnumcorrelativo.Text + 1

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

            tnumcorrelativo.Text = valostring

            tnumcorrelativo_Validated(sender, e)

        End If
    End Sub

    Private Sub FrmContPrivServicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion = New SqlConnection
        Conexion.ConnectionString = cadena
        adaptar = New SqlDataAdapter(sql, Conexion)
    End Sub

    Private Sub tnumcorrelativo_Validated(sender As Object, e As EventArgs) Handles tnumcorrelativo.Validated
        sql = "Select * from contrpresta_servicios where num_correlativo='" & tnumcorrelativo.Text & "'"
        Try
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "contrpresta_servicios")
            resultado = almacen.Tables("contrpresta_servicios").Rows.Count
            If resultado > 0 Then
                registro = almacen.Tables("contrpresta_servicios").Rows(0)
                If Not IsDBNull(registro("num_correlativo")) Then
                    tnumcorrelativo.Text = registro("num_correlativo")
                End If
                If Not IsDBNull(registro("identidad")) Then
                    tidentidad.Text = registro("identidad")
                End If
                If Not IsDBNull(registro("nombre_completo")) Then
                    tnombre.Text = registro("nombre_completo")
                End If
                If Not IsDBNull(registro("tipo_consultor")) Then
                    tconsultor.Text = registro("tipo_consultor")
                End If
                If Not IsDBNull(registro("fecha_emision")) Then
                    dtpfechaemision.Value = registro("fecha_emision")
                End If
                If Not IsDBNull(registro("fecha_vencimiento")) Then
                    dtpfechafinalizacion.Value = registro("fecha_vencimiento")
                End If
            ElseIf resultado = 0 Then
                limpiarparcial()
            End If
        Catch ex As Exception
        End Try
        Conexion.Close()
        tidentidad.Focus()
    End Sub

    Private Sub limpiar()
        tnumcorrelativo.Text = Nothing
        limpiarparcial()
    End Sub

    Private Sub limpiarparcial()
        dtpfechaemision.Value = Now
        tidentidad.Text = Nothing
        tnombre.Text = Nothing
        nsalario.Value = Nothing
        tconsultor.Text = Nothing
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        limpiar()
    End Sub

    Private Sub bagregar_Click(sender As Object, e As EventArgs) Handles bagregar.Click
        If tnumcorrelativo.Text = Nothing Then
            mensaje.Text = "Dejo vacio el numero de correlativo"
            tnumcorrelativo.Focus()
            Exit Sub
        ElseIf tidentidad.Text = Nothing Then
            mensaje.Text = "Dejo vacio la identidad"
            tidentidad.Focus()
            Exit Sub
        ElseIf tnombre.Text = Nothing Then
            mensaje.Text = "Dejo vacio el nombre del contratante"
            tnombre.Focus()
            Exit Sub
        ElseIf nsalario.Text = Nothing Then
            mensaje.Text = "Dejo vacio la identidad"
            nsalario.Focus()
            Exit Sub
        End If
        sql = "select * from contrpresta_servicios where num_correlativo='" & tnumcorrelativo.Text & "'"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "contrpresta_servicios")
            resultado = almacen.Tables("contrpresta_servicios").Rows.Count
            If resultado > 0 Then
                sql = "Update contrpresta_servicios set identidad='" & tidentidad.Text & "',nombre_completo='" & tnombre.Text & "',tipo_consultor='" & tconsultor.Text & "',"
                sql += "fecha_emision='" & dtpfechaemision.Value & "',fecha_vencimiento='" & dtpfechafinalizacion.Value & "',salario_asignar='" & nsalario.Value & "' where num_correlativo='" & tnumcorrelativo.Text & "'"
            ElseIf resultado = 0 Then
                sql = "insert into contrpresta_servicios (num_correlativo,identidad,nombre_completo,fecha_emision,fecha_vencimiento,tipo_consultor,salario_asignar) values ("
                sql += "'" & tnumcorrelativo.Text & "','" & tidentidad.Text & "','" & tnombre.Text & "',"
                sql += "'" & dtpfechaemision.Text & "','" & dtpfechafinalizacion.Text & "','" & tconsultor.Text & "','" & nsalario.Text & "')"
            End If
            Comando = New SqlCommand(sql, Conexion)
            Comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        limpiar()
        Conexion.Close()
        tnumcorrelativo.Focus()
    End Sub

    Private Sub tnumcorrelativo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tnumcorrelativo.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tnumcorrelativo_Validated(sender, e)
            mensaje.Text = "Mensajes"
            tnumcorrelativo.Enabled = False
        End If
    End Sub

    Private Sub beliminar_Click(sender As Object, e As EventArgs) Handles beliminar.Click

        If tnumcorrelativo.Text = Nothing Then
            mensaje.Text = "Dejo vacio el Correlativo"
            tnumcorrelativo.Focus()
            Exit Sub
        End If

        If MsgBox("Borrar el Contrato.?", MsgBoxStyle.YesNo, "Sistema de SERINTER") = MsgBoxResult.Yes Then
            Try
                sql = "delete from contrpresta_servicios where num_correlativo='" & tnumcorrelativo.Text & "'"
                Conexion.Open()
                Comando = New SqlCommand(sql, Conexion)
                Comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        Conexion.Close()
        limpiar()

    End Sub
End Class