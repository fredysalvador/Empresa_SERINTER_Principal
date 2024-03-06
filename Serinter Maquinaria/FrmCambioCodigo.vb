Imports System.Data.SqlClient
Imports System.Data
Public Class FrmCambioCodigo

    Private Sub beditar_Click(sender As Object, e As EventArgs) Handles beditar.Click

        If tcod1.Text = Nothing Then
            mensaje.Text = "Dejo Vacio el Codigo a Cambiar"
            tcod1.Focus()
            Exit Sub
        ElseIf tcod2.Text = Nothing Then
            mensaje.Text = "Dejo Vacio el Nuevo Codigo"
            tcod2.Focus()
            Exit Sub
        End If
        sql = "select * from salida_inventario where no_salida='" & tcod1.Text & "'"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "salida_inventario")
            resultado = almacen.Tables("salida_inventario").Rows.Count
            If resultado > 0 Then
                sql = "update salida_inventario set no_salida='" & tcod2.Text & "' where no_salida='" & tcod1.Text & "'"
            End If
            Comando = New SqlCommand(sql, Conexion)
            Comando.ExecuteNonQuery()

        Catch ex As Exception
        End Try
        Conexion.Close()
        mensaje.Text = "Mensajes"
        Me.Close()
    End Sub

    Private Sub tcod1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tcod1.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tcod1_Validated(sender, e)
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub tcod1_Validated(sender As Object, e As EventArgs) Handles tcod1.Validated

        sql = "select * from salida_inventario where no_salida='" & tcod1.Text & "'"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "salida_inventario")
            resultado = almacen.Tables("salida_inventario").Rows.Count
            If resultado = 0 Then
                mensaje.Text = "Este codigo no existe"
                beditar.Enabled = False
            ElseIf resultado > 0 Then
                mensaje.Text = "Mensajes"
                tcod2.Enabled = True
                tcod2.Focus()
            End If
        Catch ex As Exception

        End Try
        Conexion.Close()
    End Sub

    Private Sub tcod2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tcod2.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tcod2_Validated(sender, e)
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub tcod2_Validated(sender As Object, e As EventArgs) Handles tcod2.Validated

        sql = "select * from salida_inventario where no_salida='" & tcod2.Text & "'"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "salida_inventario")
            resultado = almacen.Tables("salida_inventario").Rows.Count
            If resultado = 0 Then
                beditar.Enabled = True
                mensaje.Text = "Mensajes"
            ElseIf resultado > 0 Then
                mensaje.Text = "Este codigo ya existe"
                beditar.Enabled = False
            End If
        Catch ex As Exception

        End Try
        Conexion.Close()
    End Sub

    Private Sub tcod2_TextChanged(sender As Object, e As EventArgs) Handles tcod2.TextChanged

        sql = "select * from salida_inventario where no_salida='" & tcod2.Text & "'"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "salida_inventario")
            resultado = almacen.Tables("salida_inventario").Rows.Count
            If resultado = 0 Then
                beditar.Enabled = True
                mensaje.Text = "Mensajes"
            ElseIf resultado > 0 Then
                mensaje.Text = "Este codigo ya existe"
                beditar.Enabled = False
            End If
        Catch ex As Exception

        End Try
        Conexion.Close()
    End Sub

    Private Sub tcod1_TextChanged(sender As Object, e As EventArgs) Handles tcod1.TextChanged
        sql = "select * from salida_inventario where no_salida='" & tcod1.Text & "'"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "salida_inventario")
            resultado = almacen.Tables("salida_inventario").Rows.Count
            If resultado = 0 Then
                mensaje.Text = "Este codigo no existe"
                beditar.Enabled = False
            ElseIf resultado > 0 Then
                mensaje.Text = "Mensajes"
                tcod2.Enabled = True
                tcod2.Focus()
            End If
        Catch ex As Exception

        End Try
        Conexion.Close()
    End Sub
End Class