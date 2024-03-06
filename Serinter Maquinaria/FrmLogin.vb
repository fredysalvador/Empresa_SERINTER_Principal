Imports System.Data.SqlClient
Imports System.Data
Imports MaterialSkin
Public Class FrmLogin
    Private Sub limpiar()
        tusuario.Text = Nothing
        tclave.Text = Nothing
        resultado = 0
    End Sub
    Private Sub breiniciar_Click(sender As Object, e As EventArgs) Handles breiniciar.Click
        limpiar()
        tusuario.Focus()
        bingresar.BackgroundImage = My.Resources.Cerrado
        bingresar.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub bingresar_Click(sender As Object, e As EventArgs) Handles bingresar.Click
        If resultado > 0 Then
            FrmPrincipal.Show()
            limpiar()
            vusuario = tusuario.Text
            Me.Hide()
        Else
            mensaje.Text = "No ha iniciado sesion"
            tusuario.Focus()
        End If
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion = New SqlConnection
        Conexion.ConnectionString = cadena
    End Sub

    Private Sub tusuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tusuario.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tclave.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub tclave_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tclave.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tclave_Validated(sender, e)
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub FrmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MsgBox("Cerrar la Formulario de Acceso", MsgBoxStyle.YesNo, "Sistema de Maquinaria") = MsgBoxResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub tclave_Validated(sender As Object, e As EventArgs) Handles tclave.Validated
        If tusuario.Text = Nothing Then
            mensaje.Text = "No ingreso un usuario"
            tusuario.Focus()
            Exit Sub
        ElseIf tclave.Text = Nothing Then
            mensaje.Text = "No ingreso la clave"
            tclave.Focus()
            Exit Sub
        End If
        vusuario = tusuario.Text
        Try
            Conexion.Open()
            sql = "select * from acceso where usuario='" & tusuario.Text & "' and "
            sql += "clave='" & tclave.Text & "'"
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "acceso")
            resultado = almacen.Tables("acceso").Rows.Count
            If resultado > 0 Then
                registro = almacen.Tables("acceso").Rows(0)
                If Not IsDBNull(registro("nombre")) Then
                    vnombre = registro("nombre")
                End If
                If Not IsDBNull(registro("rol")) Then
                    vrol = registro("rol")
                End If
                FrmPrincipal.lrol.Text = vrol
                FrmPrincipal.lnombres.Text = RTrim(vnombre) + ", " + UCase(vusuario) 'Hay que crear el objeto nombre en el formulario
                bingresar.BackgroundImage = My.Resources.Abierto1
                bingresar.BackgroundImageLayout = ImageLayout.Stretch
            ElseIf resultado = 0 Then
                FrmPrincipal.lnombres.Text = "No inicio sesion"
                bingresar.BackgroundImage = My.Resources.Cerrado1
                bingresar.BackgroundImageLayout = ImageLayout.Stretch
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Conexion.Close()
        bingresar.Focus()
    End Sub
End Class
