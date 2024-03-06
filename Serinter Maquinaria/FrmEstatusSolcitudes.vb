Imports System.Data.SqlClient
Imports System.Data
Imports System.Runtime.InteropServices
Public Class FrmEstatusSolcitudes
    Private Sub FrmEstatusSolcitudes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Conexion = New SqlConnection
        Conexion.ConnectionString = cadena
        adaptar = New SqlDataAdapter(sql, Conexion)

        Me.Timer1.Enabled = True
        Me.Timer2.Enabled = True
        Me.Timer3.Enabled = True

    End Sub
    Private Sub bdatagridret_Click(sender As Object, e As EventArgs) Handles bdatagridret.Click
        Conexion.Open()
        Dim cmd As New SqlCommand("SolcTrabjActivas", Conexion)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter

        da.SelectCommand = cmd
        Dim dt As New System.Data.DataTable
        dt.Clear()
        da.Fill(dt)
        dgvretorno1.DataSource = dt
        dgvretorno1.AutoResizeColumns()
        dgvretorno1.Columns(0).Visible = False
        dgvretorno1.Columns(1).Width = 70
        dgvretorno1.Columns(2).Width = 100
        dgvretorno1.Columns(3).Width = 120
        dgvretorno1.Columns(4).Width = 200
        dgvretorno1.Columns(5).Width = 150
        dgvretorno1.Columns(6).Visible = False
        dgvretorno1.Columns(7).Width = 100
        dgvretorno1.Columns(8).Visible = False
        dgvretorno1.Columns(9).Visible = False
        dgvretorno1.Columns(10).Visible = False
        dgvretorno1.Columns(11).Visible = False
        dgvretorno1.Columns(12).Visible = False
        dgvretorno1.Columns(13).Visible = False
        dgvretorno1.Columns(14).Visible = False
        dgvretorno1.Columns(15).Visible = False
        dgvretorno1.Columns(16).Width = 110
        dgvretorno1.Columns(17).Width = 190
        dgvretorno1.Columns(18).Width = 170
        Conexion.Close()

        For i As Integer = 1 To dgvretorno1.Rows.Count - 1
            For j As Integer = i - 1 To 0 Step -1
                If dgvretorno1.Rows(i).Cells("num_solcitud").Value.ToString = dgvretorno1.Rows(j).Cells("num_solcitud").Value.ToString Then
                    dgvretorno1.Rows(i).Visible = False
                End If
            Next
        Next
    End Sub
    Private Sub ActualizarDGV()

        Conexion.Open()
        Dim cmd As New SqlCommand("SolcTrabjActivas", Conexion)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter
        da.SelectCommand = cmd
        Dim dt As New System.Data.DataTable
        dt.Clear()
        da.Fill(dt)
        dgvretorno1.DataSource = dt
        dgvretorno1.AutoResizeColumns()
        dgvretorno1.Columns(0).Visible = False
        dgvretorno1.Columns(1).Width = 70
        dgvretorno1.Columns(2).Width = 100
        dgvretorno1.Columns(3).Width = 120
        dgvretorno1.Columns(4).Width = 200
        dgvretorno1.Columns(5).Width = 150
        dgvretorno1.Columns(6).Visible = False
        dgvretorno1.Columns(7).Width = 100
        dgvretorno1.Columns(8).Visible = False
        dgvretorno1.Columns(9).Visible = False
        dgvretorno1.Columns(10).Visible = False
        dgvretorno1.Columns(11).Visible = False
        dgvretorno1.Columns(12).Visible = False
        dgvretorno1.Columns(13).Visible = False
        dgvretorno1.Columns(14).Visible = False
        dgvretorno1.Columns(15).Visible = False
        dgvretorno1.Columns(16).Width = 110
        dgvretorno1.Columns(17).Width = 190
        dgvretorno1.Columns(18).Width = 170
        Conexion.Close()


        For i As Integer = 1 To dgvretorno1.Rows.Count - 1
            For j As Integer = i - 1 To 0 Step -1
                If dgvretorno1.Rows(i).Cells("num_solcitud").Value.ToString = dgvretorno1.Rows(j).Cells("num_solcitud").Value.ToString Then
                    dgvretorno1.Rows(i).Visible = False
                End If
            Next
        Next
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
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.fechahora.Text = Now
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Interval = 100
        Conexion.Open()
        Dim cmd As New SqlCommand("SolcTrabjActivas", Conexion)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter
        da.SelectCommand = cmd
        Dim dt As New System.Data.DataTable
        dt.Clear()
        da.Fill(dt)
        dgvretorno1.DataSource = dt
        dgvretorno1.AutoResizeColumns()
        dgvretorno1.Columns(0).Visible = False
        dgvretorno1.Columns(1).Width = 70
        dgvretorno1.Columns(2).Width = 100
        dgvretorno1.Columns(3).Width = 120
        dgvretorno1.Columns(4).Width = 200
        dgvretorno1.Columns(5).Width = 150
        dgvretorno1.Columns(6).Visible = False
        dgvretorno1.Columns(7).Width = 100
        dgvretorno1.Columns(8).Visible = False
        dgvretorno1.Columns(9).Visible = False
        dgvretorno1.Columns(10).Visible = False
        dgvretorno1.Columns(11).Visible = False
        dgvretorno1.Columns(12).Visible = False
        dgvretorno1.Columns(13).Visible = False
        dgvretorno1.Columns(14).Visible = False
        dgvretorno1.Columns(15).Visible = False
        dgvretorno1.Columns(16).Width = 110
        dgvretorno1.Columns(17).Width = 190
        dgvretorno1.Columns(18).Width = 170
        Conexion.Close()

        For i As Integer = 1 To dgvretorno1.Rows.Count - 1
            For j As Integer = i - 1 To 0 Step -1
                If dgvretorno1.Rows(i).Cells("num_solcitud").Value.ToString = dgvretorno1.Rows(j).Cells("num_solcitud").Value.ToString Then
                    dgvretorno1.Rows(i).Visible = False
                End If
            Next
        Next


        Timer2.Enabled = False
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Timer3.Interval = 60000
        Conexion.Open()
        Dim cmd As New SqlCommand("SolcTrabjActivas", Conexion)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter
        da.SelectCommand = cmd
        Dim dt As New System.Data.DataTable
        dt.Clear()
        da.Fill(dt)
        dgvretorno1.DataSource = dt
        dgvretorno1.AutoResizeColumns()
        dgvretorno1.Columns(0).Visible = False
        dgvretorno1.Columns(1).Width = 70
        dgvretorno1.Columns(2).Width = 100
        dgvretorno1.Columns(3).Width = 120
        dgvretorno1.Columns(4).Width = 200
        dgvretorno1.Columns(5).Width = 150
        dgvretorno1.Columns(6).Visible = False
        dgvretorno1.Columns(7).Width = 100
        dgvretorno1.Columns(8).Visible = False
        dgvretorno1.Columns(9).Visible = False
        dgvretorno1.Columns(10).Visible = False
        dgvretorno1.Columns(11).Visible = False
        dgvretorno1.Columns(12).Visible = False
        dgvretorno1.Columns(13).Visible = False
        dgvretorno1.Columns(14).Visible = False
        dgvretorno1.Columns(15).Visible = False
        dgvretorno1.Columns(16).Width = 110
        dgvretorno1.Columns(17).Width = 190
        dgvretorno1.Columns(18).Width = 170
        Conexion.Close()

        For i As Integer = 1 To dgvretorno1.Rows.Count - 1
            For j As Integer = i - 1 To 0 Step -1
                If dgvretorno1.Rows(i).Cells("num_solcitud").Value.ToString = dgvretorno1.Rows(j).Cells("num_solcitud").Value.ToString Then
                    dgvretorno1.Rows(i).Visible = False
                End If
            Next
        Next

    End Sub
    Private Sub btsoliccompr_Click(sender As Object, e As EventArgs) Handles btsoliccompr.Click
        Me.Hide()
        FrmPrincipal.GenerarSolcCompra()
    End Sub

    Private Sub bregresar_Click(sender As Object, e As EventArgs) Handles bregresar.Click
        FrmPrincipal.Show()
        Me.Hide()
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
    End Sub

    Private Sub bcompra_Click(sender As Object, e As EventArgs) Handles bcompra.Click
        Me.Hide()
        FrmPrincipal.EstatusOrdenCompraFrm()
    End Sub

    Private Sub dgvretorno1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvretorno1.CellDoubleClick
        Dim ficha As String
        ficha = "Recibida"
        Try
            Dim result As DialogResult = CustomMessageBox.Show("Abrir Solicitud de Compra o Orden de Compra?", "Abriendo!!!", "Formulario de Solicitud", "Formulario Orden de Compra", "Cancelar")
            If result = DialogResult.Yes Then
                For Each Row As DataGridViewRow In dgvretorno1.SelectedRows
                    Dim visto As String = Row.Cells("num_solcitud").Value
                    Dim estado As String = Row.Cells("estado_ord").Value
                    If estado = "Nuevo" Then
                        adaptar.UpdateCommand = New SqlCommand("update ordenes_trabajo set estado_ord='" & ficha & "' where num_solcitud='" & visto & "'", Conexion)
                        Conexion.Open()
                        adaptar.UpdateCommand.ExecuteNonQuery()
                        Conexion.Close()
                    End If
                    Me.Hide()
                    'FrmPrincipal.valornumSolcompra = "ydatocompleto"
                    FrmPrincipal.valornumSolcompra = visto
                    FrmPrincipal.GenerarSolcCompra()
                Next
                ActualizarDGV()



            ElseIf result = DialogResult.No Then

                For Each Row As DataGridViewRow In dgvretorno1.SelectedRows
                    Dim visto As String = Row.Cells("num_solcitud").Value
                    Dim estado As String = Row.Cells("estado_ord").Value
                    If estado = "Nuevo" Then
                        adaptar.UpdateCommand = New SqlCommand("update ordenes_trabajo set estado_ord='" & ficha & "' where num_solcitud='" & visto & "'", Conexion)
                        Conexion.Open()
                        adaptar.UpdateCommand.ExecuteNonQuery()
                        Conexion.Close()
                    End If
                    Me.Hide()
                    'FrmPrincipal.valornumSolcompra = "ydatocompleto"
                    FrmPrincipal.valornumSolcompra = visto
                    FrmPrincipal.OrdenCompraformulario()
                Next
                ActualizarDGV()

            ElseIf result = DialogResult.Cancel Then


            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class

Public Class CustomMessageBox
    Public Shared Function Show(message As String, caption As String, button1Text As String, button2Text As String, button3Text As String) As DialogResult
        Using customMessageBox As New CustomMessageBoxForm(message, caption, button1Text, button2Text, button3Text)
            Return customMessageBox.ShowDialog()
        End Using
    End Function
End Class

Public Class CustomMessageBoxForm
    Inherits Form

    Public Sub New(message As String, caption As String, button1Text As String, button2Text As String, button3Text As String)
        InitializeComponent(message, caption, button1Text, button2Text, button3Text)
    End Sub

    Private Sub InitializeComponent(message As String, caption As String, button1Text As String, button2Text As String, button3Text As String)
        ' Configuración del formulario
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = caption
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.ControlBox = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False

        ' Configuración de la etiqueta de mensaje
        Dim label As New Label()
        label.Text = message
        label.AutoSize = True
        label.Location = New Point(10, 10)

        ' Configuración de los botones
        Dim button1 As New Button()
        button1.Text = button1Text
        button1.DialogResult = DialogResult.Yes
        button1.Location = New Point(10, label.Bottom + 5)
        button1.AutoSize = True

        Dim button2 As New Button()
        button2.Text = button2Text
        button2.DialogResult = DialogResult.No
        button2.Location = New Point(button1.Right + 60, button1.Top)
        button2.AutoSize = True

        Dim button3 As New Button()
        button3.Text = button3Text
        button3.DialogResult = DialogResult.Cancel
        button3.Location = New Point(button2.Right + 90, button1.Top)
        button3.AutoSize = True

        ' Adición de controles al formulario
        Me.Controls.Add(label)
        Me.Controls.Add(button1)
        Me.Controls.Add(button2)
        Me.Controls.Add(button3)
        Me.ClientSize = New Size(button3.Right + 10, button3.Bottom + 10)  ' Ajuste del tamaño del formulario
    End Sub
End Class
