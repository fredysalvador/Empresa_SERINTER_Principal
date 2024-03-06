Imports System.Data.SqlClient
Imports System.Data
Imports System.Runtime.InteropServices
Public Class FrmMantenimientosMaqTotal
    Dim vall1 As Integer
    Private Sub FrmMantenimientoMaqTotal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion = New SqlConnection
        Conexion.ConnectionString = cadena
        adaptar = New SqlDataAdapter(sql, Conexion)
        Timer2.Enabled = True
        vall1 = 0
        Timer3.Enabled = True
        Timer3.Interval = 1000
        Timer7.Enabled = True
        Timer7.Interval = 1000
    End Sub

    Private Sub chkfiltro_CheckedChanged(sender As Object, e As EventArgs) Handles chkfiltro.CheckedChanged

        If chkfiltro.Checked = False Then

            dtp1.Visible = False
            dtp2.Visible = False
            dgvreg.Rows.Clear()
            Timer1.Enabled = True

        ElseIf chkfiltro.Checked = True Then

            dtp1.Visible = True
            dtp2.Visible = True
            dtp1.Value = Convert.ToDateTime(dgvreg.Rows(0).Cells("Fecha").Value)
            dtp1.Format = DateTimePickerFormat.Short
            dgvreg.Rows.Clear()
            dtp2.Text = Now
            Timer5.Enabled = True

        End If

    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Dim fechaIni As String = dtp1.Value.ToString("yyyy-MM-dd")
        Dim fechaFin As String = dtp2.Value.ToString("yyyy-MM-dd")

        sql = "select * from registro_mantenimientos where codigo_vh='" & tcodv.Text & "' and fecha between'" & fechaIni & "' and '" & fechaFin & "'"

        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "registro_mantenimientos")
            resultado = almacen.Tables("registro_mantenimientos").Rows.Count
            If almacen.Tables(0).Rows.Count <> 0 Then

                For j As Integer = 0 To almacen.Tables(0).Rows.Count - 1 Step +1
                    dgvreg.Rows.Add(almacen.Tables(0).Rows(j)("id").ToString(), "", almacen.Tables(0).Rows(j)("unidad").ToString(), almacen.Tables(0).Rows(j)("descripcion").ToString(), almacen.Tables(0).Rows(j)("valor").ToString(), almacen.Tables(0).Rows(j)("valor_total").ToString(), almacen.Tables(0).Rows(j)("razon").ToString(), almacen.Tables(0).Rows(j)("fecha").ToString())
                Next

            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Conexion.Close()
        Timer5.Enabled = False
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

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.fechahora.Text = Now
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        sql = "select * from registro_mantenimientos where codigo_vh='" & tcodv.Text & "'"
        Try
            ' Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "registro_mantenimientos")
            resultado = almacen.Tables("registro_mantenimientos").Rows.Count
            If almacen.Tables(0).Rows.Count <> 0 Then
                For j As Integer = 0 To almacen.Tables(0).Rows.Count - 1 Step +1
                    dgvreg.Rows.Add(almacen.Tables(0).Rows(j)("id").ToString(), "", almacen.Tables(0).Rows(j)("unidad").ToString(), almacen.Tables(0).Rows(j)("descripcion").ToString(), almacen.Tables(0).Rows(j)("valor").ToString(), almacen.Tables(0).Rows(j)("valor_total").ToString(), almacen.Tables(0).Rows(j)("razon").ToString(), almacen.Tables(0).Rows(j)("fecha").ToString())
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

    Private Sub dtp1_ValueChanged(sender As Object, e As EventArgs) Handles dtp1.ValueChanged
        dgvreg.Rows.Clear()
        dgvreg2.Rows.Clear()
        Timer5.Enabled = True
        Timer8.Enabled = True
    End Sub

    Private Sub dtp2_ValueChanged(sender As Object, e As EventArgs) Handles dtp2.ValueChanged
        dgvreg.Rows.Clear()
        dgvreg2.Rows.Clear()
        Timer5.Enabled = True
        Timer8.Enabled = True
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        sql = "select * from registro_manobra where codigo_vh='" & tcodv.Text & "'"
        Try
            '   Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "registro_manobra")
            resultado = almacen.Tables("registro_manobra").Rows.Count
            If almacen.Tables(0).Rows.Count <> 0 Then
                For j As Integer = 0 To almacen.Tables(0).Rows.Count - 1 Step +1
                    dgvreg2.Rows.Add(almacen.Tables(0).Rows(j)("id").ToString(), "", almacen.Tables(0).Rows(j)("valor_servicio").ToString(), almacen.Tables(0).Rows(j)("servicio").ToString(), almacen.Tables(0).Rows(j)("horas_servicio").ToString(), almacen.Tables(0).Rows(j)("valor_total").ToString(), almacen.Tables(0).Rows(j)("razon").ToString(), almacen.Tables(0).Rows(j)("fecha").ToString())
                Next
            End If

            If resultado = 0 Then

            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Conexion.Close()
        Timer6.Enabled = False
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick

        If chkfiltro.Checked = True Then
            vall1 = vall1 + 1

            Dim suma As Decimal = 0.0

            For Each row As DataGridViewRow In dgvreg2.Rows
                suma += Val(row.Cells("ValorT2").Value)
            Next

            txtTotal2.Text = suma.ToString("L #,##0.00")

        ElseIf chkfiltro.Checked = False Then

            vall1 = vall1 + 1

            Dim suma As Decimal = 0.0

            For Each row As DataGridViewRow In dgvreg2.Rows
                suma += Val(row.Cells("ValorT2").Value)
            Next

            txtTotal2.Text = suma.ToString("L #,##0.00")
        End If

    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
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
                    dgvreg2.Rows.Add(almacen.Tables(0).Rows(j)("id").ToString(), "", almacen.Tables(0).Rows(j)("valor_servicio").ToString(), almacen.Tables(0).Rows(j)("servicio").ToString(), almacen.Tables(0).Rows(j)("horas_servicio").ToString(), almacen.Tables(0).Rows(j)("valor_total").ToString(), almacen.Tables(0).Rows(j)("razon").ToString(), almacen.Tables(0).Rows(j)("fecha").ToString())
                Next

            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Conexion.Close()
        Timer8.Enabled = False
    End Sub

    Private Sub dgvreg_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvreg.RowPostPaint
        Me.dgvreg.Rows(e.RowIndex).Cells(1).Value = (e.RowIndex + 1).ToString
    End Sub

    Private Sub dgvreg2_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvreg2.RowPostPaint
        Me.dgvreg2.Rows(e.RowIndex).Cells(1).Value = (e.RowIndex + 1).ToString
    End Sub

    Private Sub bimprimir_Click(sender As Object, e As EventArgs) Handles bimprimir.Click
        If chkfiltro.Checked = False Then
            ' FrmMantenimientosMaqImpr2.tcodv.Text = Me.tcodv.Text
            ' FrmMantenimientosMaqImpr2.ShowDialog()
        ElseIf chkfiltro.Checked = True Then
            'FrmMantenimientosMaqImprManoTotl1.tcodv.Text = Me.tcodv.Text
            FrmMantenimientosMaqImprManoTotl1.ShowDialog()
        End If
    End Sub
End Class