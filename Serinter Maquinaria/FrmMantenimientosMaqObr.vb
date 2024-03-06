Imports System.Data.SqlClient
Imports System.Data
Imports System.Runtime.InteropServices
Public Class FrmMantenimientosMaqObr
    Dim vall1 As Integer
    Private Sub tvalorhora_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tvalorhora.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
            If Asc(e.KeyChar) = 46 Then
                e.Handled = False
            End If
        End If
        If AscW(e.KeyChar) = Keys.Enter Then
            thortrab.Focus()
            mensaje.Text = "Mensajes"
        End If
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
        Valor = Me.ttipotrab.Text
        Dim existe As Boolean = Me.dgvreg.Rows.Cast(Of DataGridViewRow).Any(Function(x) CStr(x.Cells("Servicio1").Value) = Valor)

        'If Not existe Then

        sql = "select * from registro_manobra where codigo_vh='" & tcodv.Text & "'"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "registro_manobra")
            resultado = almacen.Tables("registro_manobra").Rows.Count


            If resultado = 0 Then

                If tvalorhora.Text = Nothing Then
                    mensaje.Text = "Agregue el Valor de la Hora"
                    Conexion.Close()
                    Exit Sub

                ElseIf thortrab.Text = Nothing Then
                    mensaje.Text = "Agregue las horas trabajadas"
                    Conexion.Close()
                    Exit Sub
                End If

                mensaje.Text = "Mensajes"
                id1 = dgvreg.Rows.Count.ToString
                item = dgvreg.Rows.Count.ToString
                cantidad = tvalorhora.Text
                nombre = ttipotrab.Text
                valors = thortrab.Text
                '  fechas = fechahora.Text
                razons = trazontrab.Text
                total_unid = tvalortotal.Text
                dgvreg.Rows.Add(id1, item, cantidad, nombre, valors, total_unid, razons, fechas)
                Conexion.Close()

                ttipotrab.Text = Nothing
                tvalorhora.Text = Nothing
                thortrab.Text = Nothing
                trazontrab.Text = Nothing
                tvalortotal.Text = Nothing

            ElseIf resultado > 0 Then

                dgvreg.ClearSelection()
                If tvalorhora.Text = Nothing Then
                    mensaje.Text = "Agregue el Valor de la Hora"
                    Conexion.Close()
                    Exit Sub

                ElseIf thortrab.Text = Nothing Then
                    mensaje.Text = "Agregue las horas trabajadas"
                    Conexion.Close()
                    Exit Sub
                End If

                mensaje.Text = "Mensajes"
                id1 = dgvreg2.Rows.Count.ToString
                item = dgvreg2.Rows.Count.ToString
                cantidad = tvalorhora.Text
                nombre = ttipotrab.Text
                valors = thortrab.Text
                razons = trazontrab.Text
                ' fechas = fechahora.Text
                total_unid = tvalortotal.Text
                dgvreg2.Rows.Add(id1, item, cantidad, nombre, valors, total_unid, razons, fechas)
                Conexion.Close()


                 ttipotrab.Text = Nothing
                tvalorhora.Text = Nothing
                thortrab.Text = Nothing
                trazontrab.Text = Nothing
                tvalortotal.Text = Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'End If

        Conexion.Close()

    End Sub

    Private Sub FrmMantenimientosMaqObr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion = New SqlConnection
        Conexion.ConnectionString = cadena
        adaptar = New SqlDataAdapter(sql, Conexion)
        Timer2.Enabled = True

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

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.fechahora.Text = Now
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

    Private Sub tvalorhora_TextChanged(sender As Object, e As EventArgs) Handles tvalorhora.TextChanged

        Dim t1 As Double, t2 As Double
        On Error Resume Next

        If IsNumeric(tvalorhora.Text) Then t1 = CDec(tvalorhora.Text)
        If IsNumeric(thortrab.Text) Then t2 = CDec(thortrab.Text)

        tvalortotal.Text = t1 * t2
       
    End Sub

    Private Sub thortrab_TextChanged(sender As Object, e As EventArgs) Handles thortrab.TextChanged

        Dim t1 As Double, t2 As Double
        On Error Resume Next

        If IsNumeric(tvalorhora.Text) Then t1 = CDec(tvalorhora.Text)
        If IsNumeric(thortrab.Text) Then t2 = CDec(thortrab.Text)

        tvalortotal.Text = t1 * t2

    End Sub

    Private Sub ttipotrab_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ttipotrab.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tvalorhora.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub thortrab_KeyPress(sender As Object, e As KeyPressEventArgs) Handles thortrab.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
            If Asc(e.KeyChar) = 46 Then
                e.Handled = False
            End If
        End If
        If AscW(e.KeyChar) = Keys.Enter Then
            trazontrab.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub trazontrab_KeyPress(sender As Object, e As KeyPressEventArgs) Handles trazontrab.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tvalortotal.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub tvalortotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tvalortotal.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            bagregar.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        sql = "select * from registro_manobra where codigo_vh='" & tcodv.Text & "'"
        Try
            '   Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "registro_manobra")
            resultado = almacen.Tables("registro_manobra").Rows.Count
            If almacen.Tables(0).Rows.Count <> 0 Then
                For j As Integer = 0 To almacen.Tables(0).Rows.Count - 1 Step +1
                    dgvreg.Rows.Add(almacen.Tables(0).Rows(j)("id").ToString(), "", almacen.Tables(0).Rows(j)("valor_servicio").ToString(), almacen.Tables(0).Rows(j)("servicio").ToString(), almacen.Tables(0).Rows(j)("horas_servicio").ToString(), almacen.Tables(0).Rows(j)("valor_total").ToString(), almacen.Tables(0).Rows(j)("razon").ToString(), almacen.Tables(0).Rows(j)("fecha").ToString())
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

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick

        Dim fechaIni As String = dtp1.Value.ToString("yyyy-MM-dd")
        Dim fechaFin As String = dtp2.Value.ToString("yyyy-MM-dd")

        sql = "select * from registro_manobra where codigo_vh='" & tcodv.Text & "' and fecha between'" & fechaIni & "' and '" & fechaFin & "'"

        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "registro_manobra")
            resultado = almacen.Tables("registro_manobra").Rows.Count
            If almacen.Tables(0).Rows.Count <> 0 Then

                For j As Integer = 0 To almacen.Tables(0).Rows.Count - 1 Step +1
                    dgvreg.Rows.Add(almacen.Tables(0).Rows(j)("id").ToString(), "", almacen.Tables(0).Rows(j)("valor_servicio").ToString(), almacen.Tables(0).Rows(j)("servicio").ToString(), almacen.Tables(0).Rows(j)("horas_servicio").ToString(), almacen.Tables(0).Rows(j)("valor_total").ToString(), almacen.Tables(0).Rows(j)("razon").ToString(), almacen.Tables(0).Rows(j)("fecha").ToString())
                Next

            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Conexion.Close()
        Timer5.Enabled = False
    End Sub

    Private Sub bagregar_Click(sender As Object, e As EventArgs) Handles bagregar.Click
        sql = "select * from registro_manobra where codigo_vh='" & tcodv.Text & "'"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "registro_manobra")
            resultado = almacen.Tables("registro_manobra").Rows.Count
            If resultado > 0 Then
                Conexion.Close()
                Dim result As DialogResult
                result = MessageBox.Show("Desea Agregar Nuevos Registros?", "Actualizado!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then

                    For Each Row As DataGridViewRow In dgvreg2.Rows


                        Dim valorser2 As String = Row.Cells("ValorS2").Value
                        Dim Servicios2 As String = Row.Cells("Servicio2").Value
                        Dim HorasTrabs2 As String = Row.Cells("HorasTrab2").Value
                        Dim valorT2 As String = Row.Cells("ValorT2").Value
                        Dim razon2 As String = Row.Cells("Razon2").Value
                        Dim fecha2 As Date = Row.Cells("Fecha2").Value

                        adaptar.InsertCommand = New SqlCommand("Insert into registro_manobra (codigo_vh, valor_servicio, servicio, horas_servicio, razon, fecha, valor_total) values ('" & tcodv.Text & "', '" & valorser2 & "', '" & Servicios2 & "', '" & HorasTrabs2 & "', '" & razon2 & "', '" & fecha2 & "', '" & valorT2 & "')", Conexion)
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
                        Dim valorser1 As String = Row.Cells("ValorS1").Value
                        Dim Servicios1 As String = Row.Cells("Servicio1").Value
                        Dim HorasTrabs1 As String = Row.Cells("HorasTrab1").Value
                        Dim valorT1 As String = Row.Cells("ValorT").Value
                        Dim razon1 As String = Row.Cells("Razon").Value
                        Dim fecha1 As Date = Row.Cells("Fecha").Value

                        adaptar.InsertCommand = New SqlCommand("Insert into registro_manobra (codigo_vh, valor_servicio, servicio, horas_servicio, razon, fecha, valor_total) values ('" & tcodv.Text & "', '" & valorser1 & "', '" & Servicios1 & "', '" & HorasTrabs1 & "', '" & razon1 & "', '" & fecha1 & "', '" & valorT1 & "')", Conexion)
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
            Dim valorser1 As String = Row.Cells("ValorS1").Value
            Dim Servicios1 As String = Row.Cells("Servicio1").Value
            Dim HorasTrabs1 As String = Row.Cells("HorasTrab1").Value
            Dim valorT1 As String = Row.Cells("ValorT").Value
            Dim razon1 As String = Row.Cells("Razon").Value
            Dim fecha1 As Date = Row.Cells("Fecha").Value

            adaptar.DeleteCommand = New SqlCommand("delete from registro_manobra where codigo_vh='" & tcodv.Text & "' and id='" & id1 & "' and servicio='" & Servicios1 & "'", Conexion)
            Conexion.Open()
            adaptar.DeleteCommand.ExecuteNonQuery()
            Conexion.Close()
            dgvreg.Rows.Remove(Row)
        Next

        For Each Row As DataGridViewRow In dgvreg2.SelectedRows
            dgvreg2.Rows.Remove(Row)
        Next

        sql = "select * from registro_manobra where codigo_vh='" & tcodv.Text & "'"
        Try
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "registro_manobra")
            resultado = almacen.Tables("registro_manobra").Rows.Count

            If resultado = 0 Then
                chkfiltro.Visible = False
            ElseIf resultado > 0 Then
                chkfiltro.Visible = True
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub beliminar_Click(sender As Object, e As EventArgs) Handles beliminar.Click
        Try
            Dim result As DialogResult
            result = MessageBox.Show("Desea Eliminar? Todos los Registros Seran Eliminados!", "Eliminando!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                For j As Integer = 0 To dgvreg.Rows.Count - 1 Step +1
                    adaptar.DeleteCommand = New SqlCommand("delete from registro_manobra where codigo_vh='" & tcodv.Text & "'", Conexion)
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
        bagrlista.Enabled = False
    End Sub
    Private Sub limpiar()
        ttipotrab.Text = Nothing
        tvalorhora.Text = Nothing
        thortrab.Text = Nothing
        trazontrab.Text = Nothing
        tvalortotal.Text = Nothing
    End Sub

    Private Sub bimprimir_Click(sender As Object, e As EventArgs) Handles bimprimir.Click
        If chkfiltro.Checked = False Then
            FrmMantenimientosMaqImprManoObr4.tcodv.Text = Me.tcodv.Text
            FrmMantenimientosMaqImprManoObr4.ShowDialog()
        ElseIf chkfiltro.Checked = True Then
            FrmMantenimientosMaqImprManoObr3.tcodv.Text = Me.tcodv.Text
            FrmMantenimientosMaqImprManoObr3.ShowDialog()
        End If
    End Sub
    Private Sub dgvreg_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvreg.RowPostPaint
        Me.dgvreg.Rows(e.RowIndex).Cells(1).Value = (e.RowIndex + 1).ToString
    End Sub
    Private Sub dgvreg2_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvreg2.RowPostPaint
        Me.dgvreg2.Rows(e.RowIndex).Cells(1).Value = (e.RowIndex + 1).ToString
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

    Private Sub dtp1_ValueChanged(sender As Object, e As EventArgs) Handles dtp1.ValueChanged
        dgvreg.Rows.Clear()
        Timer5.Enabled = True
        If dtp1.Value > dtp2.Value Then
            dtp1.Value = Now
        ElseIf dtp2.Value < dtp1.Value Then
            dtp2.Value = Now
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

    Private Sub ttipotrab_TextChanged(sender As Object, e As EventArgs) Handles ttipotrab.TextChanged
        ttipotrab.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(ttipotrab.Text)
        ttipotrab.SelectionStart = ttipotrab.Text.Length
    End Sub

    Private Sub dgvreg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvreg.CellContentClick
        dgvreg2.ClearSelection()
    End Sub

    Private Sub dgvreg2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvreg2.CellContentClick
        dgvreg.ClearSelection()
    End Sub

End Class