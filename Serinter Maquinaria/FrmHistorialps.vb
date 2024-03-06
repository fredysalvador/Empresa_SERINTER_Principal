Imports System.Data.SqlClient
Imports System.Data
Imports System.Runtime.InteropServices
Public Class FrmHistorialps
    Private Sub FrmHistorialps_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion = New SqlConnection
        Conexion.ConnectionString = cadena
        Me.Timer1.Enabled = True
        Me.Timer2.Enabled = True
        Me.Timer3.Enabled = True
    End Sub
    Private Sub ActualizarDGV()
        Conexion.Open()
        Dim cmd As New SqlCommand("Salidasinactivas", Conexion)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter
        da.SelectCommand = cmd
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)
        dgvretorno1.DataSource = dt
        dgvretorno1.AutoResizeColumns()
        dgvretorno1.Columns(0).Width = 70
        dgvretorno1.Columns(1).Width = 100 'Ancho Especifico
        dgvretorno1.Columns(2).Width = 100
        dgvretorno1.Columns(3).Width = 100
        dgvretorno1.Columns(4).Width = 150
        dgvretorno1.Columns(5).Width = 180
        dgvretorno1.Columns(6).Width = 180
        dgvretorno1.Columns(7).Width = 100
        dgvretorno1.Columns(8).Width = 232
        Conexion.Close()

        For i As Integer = 1 To dgvretorno1.Rows.Count - 1
            For j As Integer = i - 1 To 0 Step -1
                If dgvretorno1.Rows(i).Cells("no_salida").Value.ToString = dgvretorno1.Rows(j).Cells("no_salida").Value.ToString Then
                    dgvretorno1.Rows(i).Visible = False
                End If
            Next
        Next
        'dgvretorno1.Visible = True
        'sql = "select * from salida_inventario where estado_ficha <> 'Activo' order by no_salida desc"
        'Try
        '    Conexion.Open()
        '    adaptar = New SqlDataAdapter(sql, Conexion)
        '    almacen = New DataSet
        '    adaptar.Fill(almacen, "salida_inventario")

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        'dgvretorno1.DataSource = almacen
        'dgvretorno1.DataMember = "salida_inventario"
        'dgvretorno1.Columns(0).Visible = False
        'dgvretorno1.Columns(1).HeaderText = "no_salida"
        'dgvretorno1.Columns(2).HeaderText = "fecha_salida"
        'dgvretorno1.Columns(3).HeaderText = "fecha_retorno"
        'dgvretorno1.Columns(4).HeaderText = "codigo_vh"
        'dgvretorno1.Columns(5).Visible = False
        'dgvretorno1.Columns(6).Visible = False
        'dgvretorno1.Columns(7).Visible = False
        'dgvretorno1.Columns(8).HeaderText = "categoriaps"
        'dgvretorno1.Columns(9).Visible = False
        'dgvretorno1.Columns(10).Visible = False
        'dgvretorno1.Columns(11).Visible = False
        'dgvretorno1.Columns(12).Visible = False
        'dgvretorno1.Columns(13).HeaderText = "motorista"
        'dgvretorno1.Columns(14).Visible = False
        'dgvretorno1.Columns(15).HeaderText = "Destino"
        'dgvretorno1.Columns(16).Visible = False
        'dgvretorno1.Columns(17).Visible = False
        'dgvretorno1.Columns(18).Visible = False
        'dgvretorno1.Columns(19).Visible = False
        'dgvretorno1.Columns(20).HeaderText = "Estado"
        'dgvretorno1.AutoResizeColumns()
        'dgvretorno1.Columns(1).Width = 100
        'dgvretorno1.Columns(2).Width = 100 'Ancho Especifico
        'dgvretorno1.Columns(3).Width = 100
        'dgvretorno1.Columns(4).Width = 100
        'dgvretorno1.Columns(8).Width = 200
        'dgvretorno1.Columns(13).Width = 256
        'dgvretorno1.Columns(15).Width = 220
        'dgvretorno1.Columns(20).Width = 136


        'dgvretorno1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        'dgvretorno1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        'dgvretorno1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        'dgvretorno1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        'dgvretorno1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        'dgvretorno1.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        'dgvretorno1.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        'dgvretorno1.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        'dgvretorno1.Columns(20).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        'Conexion.Close()

        'For i As Integer = 1 To dgvretorno1.Rows.Count - 1
        '    For j As Integer = i - 1 To 0 Step -1
        '        If dgvretorno1.Rows(i).Cells("no_salida").Value.ToString = dgvretorno1.Rows(j).Cells("no_salida").Value.ToString Then
        '            dgvretorno1.Rows(i).Visible = False
        '        End If
        '    Next
        'Next

        'dgvretorno1.ClearSelection()
        'dgvretorno1.Refresh()
    End Sub


    Private Sub bdatagridret_Click(sender As Object, e As EventArgs) Handles bdatagridret.Click
        Conexion.Open()
        Dim cmd As New SqlCommand("Salidasinactivas", Conexion)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter
        da.SelectCommand = cmd
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)
        dgvretorno1.DataSource = dt
        dgvretorno1.AutoResizeColumns()
        dgvretorno1.Columns(0).Width = 70
        dgvretorno1.Columns(1).Width = 100 'Ancho Especifico
        dgvretorno1.Columns(2).Width = 100
        dgvretorno1.Columns(3).Width = 100
        dgvretorno1.Columns(4).Width = 150
        dgvretorno1.Columns(5).Width = 180
        dgvretorno1.Columns(6).Width = 180
        dgvretorno1.Columns(7).Width = 100
        dgvretorno1.Columns(8).Width = 232
        Conexion.Close()

        For i As Integer = 1 To dgvretorno1.Rows.Count - 1
            For j As Integer = i - 1 To 0 Step -1
                If dgvretorno1.Rows(i).Cells("no_salida").Value.ToString = dgvretorno1.Rows(j).Cells("no_salida").Value.ToString Then
                    dgvretorno1.Rows(i).Visible = False
                End If
            Next
        Next
    End Sub

    Private Sub dgvretorno1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvretorno1.CellFormatting
        If Me.dgvretorno1.Columns(e.ColumnIndex).Name = "fecha_retorno" Then
            If CDate(e.Value) < Date.Today Then
                ' aplicarato a la totalidad de la fila
                Me.dgvretorno1.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(255, 99, 71)
            ElseIf CDate(e.Value) = Date.Today Then
                ' aplicar formato a la totalidad de la fila
                Me.dgvretorno1.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(255, 215, 0)
            ElseIf CDate(e.Value) > Date.Today Then
                ' aplicar formato a la totalidad de la fila
                Me.dgvretorno1.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(126, 239, 74)

            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.fechahora.Text = Now
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Interval = 100
        Conexion.Open()
        Dim cmd As New SqlCommand("Salidasinactivas", Conexion)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter
        da.SelectCommand = cmd
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)
        dgvretorno1.DataSource = dt
        dgvretorno1.AutoResizeColumns()
        dgvretorno1.Columns(0).Width = 70
        dgvretorno1.Columns(1).Width = 100 'Ancho Especifico
        dgvretorno1.Columns(2).Width = 100
        dgvretorno1.Columns(3).Width = 100
        dgvretorno1.Columns(4).Width = 150
        dgvretorno1.Columns(5).Width = 180
        dgvretorno1.Columns(6).Width = 180
        dgvretorno1.Columns(7).Width = 100
        dgvretorno1.Columns(8).Width = 232
        Conexion.Close()

        For i As Integer = 1 To dgvretorno1.Rows.Count - 1
            For j As Integer = i - 1 To 0 Step -1
                If dgvretorno1.Rows(i).Cells("no_salida").Value.ToString = dgvretorno1.Rows(j).Cells("no_salida").Value.ToString Then
                    dgvretorno1.Rows(i).Visible = False
                End If
            Next
        Next
        Timer2.Enabled = False
    End Sub

    'Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
    '    Timer3.Interval = 60000
    '    Conexion.Open()
    '    Dim cmd As New SqlCommand("Salidasinactivas", Conexion)
    '    cmd.CommandType = CommandType.StoredProcedure
    '    Dim da As New SqlDataAdapter
    '    da.SelectCommand = cmd
    '    Dim dt As New DataTable
    '    dt.Clear()
    '    da.Fill(dt)
    '    dgvretorno1.DataSource = dt
    '    dgvretorno1.AutoResizeColumns()
    '    dgvretorno1.Columns(0).Width = 70
    '    dgvretorno1.Columns(1).Width = 100 'Ancho Especifico
    '    dgvretorno1.Columns(2).Width = 100
    '    dgvretorno1.Columns(3).Width = 100
    '    dgvretorno1.Columns(4).Width = 150
    '    dgvretorno1.Columns(5).Width = 180
    '    dgvretorno1.Columns(6).Width = 180
    '    dgvretorno1.Columns(7).Width = 100
    '    dgvretorno1.Columns(8).Width = 232
    '    Conexion.Close()

    '    For i As Integer = 1 To dgvretorno1.Rows.Count - 1
    '        For j As Integer = i - 1 To 0 Step -1
    '            If dgvretorno1.Rows(i).Cells("no_salida").Value.ToString = dgvretorno1.Rows(j).Cells("no_salida").Value.ToString Then
    '                dgvretorno1.Rows(i).Visible = False
    '            End If
    '        Next
    '    Next
    'End Sub

    Private Sub dgvretorno1_DoubleClick(sender As Object, e As EventArgs) Handles dgvretorno1.DoubleClick
        Dim ficha As String
        ficha = "Activo"
        Try
            Dim result As DialogResult
            result = MessageBox.Show("Activar Hoja de Salida?", "Activando!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                For Each Row As DataGridViewRow In dgvretorno1.SelectedRows

                    Dim salida As String = Row.Cells("no_salida").Value

                    adaptar.UpdateCommand = New SqlCommand("update salida_inventario set estado_ficha='" & ficha & "' where no_salida='" & salida & "'", Conexion)
                    Conexion.Open()
                    adaptar.UpdateCommand.ExecuteNonQuery()
                    Conexion.Close()

                Next
                ActualizarDGV()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class