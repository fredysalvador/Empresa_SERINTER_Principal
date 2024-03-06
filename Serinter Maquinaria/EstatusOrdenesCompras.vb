Imports System.Data.SqlClient
Imports System.Data
Imports System.Runtime.InteropServices
Public Class EstatusOrdenesCompras

    Private Sub EstatusOrdenesCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion = New SqlConnection
        Conexion.ConnectionString = cadena
        adaptar = New SqlDataAdapter(sql, Conexion)
        Me.Timer1.Enabled = True
        Me.Timer2.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.fechahora.Text = Now
    End Sub

    Private Sub dgvretorno1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvretorno1.CellFormatting
        If Me.dgvretorno1.Columns(e.ColumnIndex).Name = "estado_ord" Then

            If e.Value = "Nuevo" Then
                ' aplicarato a la totalidad de la fila
                Me.dgvretorno1.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(93, 193, 185)
            ElseIf e.Value = "Anulada" Then
                ' aplicar formato a la totalidad de la fila
                Me.dgvretorno1.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(255, 99, 71)
            ElseIf e.Value = "Retrasado" Then
                ' aplicar formato a la totalidad de la fila
                Me.dgvretorno1.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(255, 215, 0)
            ElseIf e.Value = "Recibida" Then
                ' aplicar formato a la totalidad de la fila
                Me.dgvretorno1.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(126, 239, 74)
            ElseIf e.Value = "Aprobada" Then
                ' aplicar formato a la totalidad de la fila
                Me.dgvretorno1.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(88, 214, 141)
            End If

        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Interval = 100
        Conexion.Open()
        Dim cmd As New SqlCommand("OrdenActiva", Conexion)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter
        da.SelectCommand = cmd
        Dim dt As New System.Data.DataTable
        dt.Clear()
        da.Fill(dt)
        dgvretorno1.DataSource = dt
        dgvretorno1.AutoResizeColumns()
        dgvretorno1.Columns(0).Width = 90
        dgvretorno1.Columns(1).Width = 100      'Ancho Especifico
        dgvretorno1.Columns(2).Width = 200
        dgvretorno1.Columns(3).Width = 250
        dgvretorno1.Columns(4).Width = 250
        dgvretorno1.Columns(5).Width = 130
        dgvretorno1.Columns(6).Width = 300

        Conexion.Close()
        For i As Integer = 1 To dgvretorno1.Rows.Count - 1
            For j As Integer = i - 1 To 0 Step -1
                If dgvretorno1.Rows(i).Cells("num_orden").Value.ToString = dgvretorno1.Rows(j).Cells("num_orden").Value.ToString Then
                    dgvretorno1.Rows(i).Visible = False
                End If
            Next
        Next
        Timer2.Enabled = False
    End Sub
End Class