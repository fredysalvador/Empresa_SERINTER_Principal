Imports System.Data.SqlClient
Imports System.Data
Imports System.Runtime.InteropServices
Imports Excel = Microsoft.Office.Interop.Excel
Public Class DatosCompletosPS

    Private Sub DatosCompletosPS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion = New SqlConnection
        Conexion.ConnectionString = cadena
        Me.Timer1.Enabled = True
        Me.Timer2.Enabled = True
        'Me.Timer3.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.fechahora.Text = Now
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Interval = 100
        sql = "select * from salida_inventario order by fecha_salida, no_salida asc"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "salida_inventario")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        dgvretorno1.DataSource = almacen
        dgvretorno1.DataMember = "salida_inventario"
        dgvretorno1.Columns(0).Visible = False
        dgvretorno1.Columns(1).HeaderText = "no_salida"
        dgvretorno1.Columns(2).HeaderText = "fecha_salida"
        dgvretorno1.Columns(3).HeaderText = "fecha_retorno"
        dgvretorno1.Columns(4).HeaderText = "codigo_vh"
        dgvretorno1.Columns(5).HeaderText = "placa_vh"
        dgvretorno1.Columns(6).HeaderText = "estado_vh"
        dgvretorno1.Columns(7).HeaderText = "vhexist"
        dgvretorno1.Columns(8).HeaderText = "categoriaps"
        dgvretorno1.Columns(9).HeaderText = "hrm1"
        dgvretorno1.Columns(10).HeaderText = "hrm2"
        dgvretorno1.Columns(11).HeaderText = "klm1"
        dgvretorno1.Columns(12).HeaderText = "klm2"
        dgvretorno1.Columns(13).HeaderText = "motorista"
        dgvretorno1.Columns(14).HeaderText = "acompañante"
        dgvretorno1.Columns(15).HeaderText = "destino"
        dgvretorno1.Columns(16).HeaderText = "item"
        dgvretorno1.Columns(17).HeaderText = "unidad"
        dgvretorno1.Columns(18).HeaderText = "item_destino"
        dgvretorno1.Columns(19).HeaderText = "descripcion"
        dgvretorno1.Columns(20).HeaderText = "observacion"
        dgvretorno1.Columns(21).HeaderText = "estado"
        dgvretorno1.Columns(22).HeaderText = "fechahora"
        dgvretorno1.AutoResizeColumns()
        dgvretorno1.Columns(1).Width = 60
        dgvretorno1.Columns(2).Width = 80 'Ancho Especifico
        dgvretorno1.Columns(3).Width = 80
        dgvretorno1.Columns(4).Width = 60
        dgvretorno1.Columns(5).Width = 55
        dgvretorno1.Columns(6).Width = 60
        dgvretorno1.Columns(7).Width = 50
        dgvretorno1.Columns(8).Width = 65
        dgvretorno1.Columns(9).Width = 50
        dgvretorno1.Columns(10).Width = 50
        dgvretorno1.Columns(11).Width = 50
        dgvretorno1.Columns(12).Width = 50
        dgvretorno1.Columns(13).Width = 80
        dgvretorno1.Columns(14).Width = 75
        dgvretorno1.Columns(15).Width = 80
        dgvretorno1.Columns(16).Width = 35
        dgvretorno1.Columns(17).Width = 43
        dgvretorno1.Columns(18).Width = 70
        dgvretorno1.Columns(19).Width = 70
        dgvretorno1.Columns(20).Width = 70
        dgvretorno1.Columns(21).Width = 50
        dgvretorno1.Columns(22).Width = 50


        dgvretorno1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvretorno1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvretorno1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvretorno1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvretorno1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvretorno1.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvretorno1.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvretorno1.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvretorno1.Columns(20).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvretorno1.Columns(21).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvretorno1.Columns(22).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Conexion.Close()

        Timer2.Enabled = False
    End Sub

    Private Sub chkexportacion_CheckedChanged(sender As Object, e As EventArgs) Handles chkexportacion.CheckedChanged
        If chkexportacion.Checked = True Then
            Dim dtFecha As Date = DateSerial(Year(Date.Today), 1, 1)
            dtpinicial.Visible = True
            dtpfinal.Visible = True
            dtpinicial.Value = dtFecha
            Dim fechaIni As String = dtpinicial.Value.ToString("yyyy-MM-dd")
            Dim fechaFin As String = dtpfinal.Value.ToString("yyyy-MM-dd")
            Label1.Visible = True
            Label2.Visible = True
            'dtpinicial.Value = Convert.ToDateTime(dgvretorno1.Rows(0).Cells("fecha_salida").Value)
            'dtpinicial.Format = DateTimePickerFormat.Short

            sql = "select * from salida_inventario where fecha_salida >= '" & fechaIni & "' and fecha_salida <= '" & fechaFin & "' order by fecha_salida, no_salida asc"
            Try
                Conexion.Open()
                adaptar = New SqlDataAdapter(sql, Conexion)
                almacen = New DataSet
                adaptar.Fill(almacen, "salida_inventario")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            dgvretorno1.DataSource = almacen
            dgvretorno1.DataMember = "salida_inventario"
            dgvretorno1.Columns(0).Visible = False
            dgvretorno1.Columns(1).HeaderText = "no_salida"
            dgvretorno1.Columns(2).HeaderText = "fecha_salida"
            dgvretorno1.Columns(3).HeaderText = "fecha_retorno"
            dgvretorno1.Columns(4).HeaderText = "codigo_vh"
            dgvretorno1.Columns(5).HeaderText = "placa_vh"
            dgvretorno1.Columns(6).HeaderText = "estado_vh"
            dgvretorno1.Columns(7).HeaderText = "vhexist"
            dgvretorno1.Columns(8).HeaderText = "categoriaps"
            dgvretorno1.Columns(9).HeaderText = "hrm1"
            dgvretorno1.Columns(10).HeaderText = "hrm2"
            dgvretorno1.Columns(11).HeaderText = "klm1"
            dgvretorno1.Columns(12).HeaderText = "klm2"
            dgvretorno1.Columns(13).HeaderText = "motorista"
            dgvretorno1.Columns(14).HeaderText = "acompañante"
            dgvretorno1.Columns(15).HeaderText = "destino"
            dgvretorno1.Columns(16).HeaderText = "item"
            dgvretorno1.Columns(17).HeaderText = "unidad"
            dgvretorno1.Columns(18).HeaderText = "item_destino"
            dgvretorno1.Columns(19).HeaderText = "descripcion"
            dgvretorno1.Columns(20).HeaderText = "observacion"
            dgvretorno1.Columns(21).HeaderText = "estado"
            dgvretorno1.Columns(22).HeaderText = "fechahora"
            dgvretorno1.AutoResizeColumns()
            dgvretorno1.Columns(1).Width = 60
            dgvretorno1.Columns(2).Width = 80 'Ancho Especifico
            dgvretorno1.Columns(3).Width = 80
            dgvretorno1.Columns(4).Width = 60
            dgvretorno1.Columns(5).Width = 55
            dgvretorno1.Columns(6).Width = 60
            dgvretorno1.Columns(7).Width = 50
            dgvretorno1.Columns(8).Width = 65
            dgvretorno1.Columns(9).Width = 50
            dgvretorno1.Columns(10).Width = 50
            dgvretorno1.Columns(11).Width = 50
            dgvretorno1.Columns(12).Width = 50
            dgvretorno1.Columns(13).Width = 80
            dgvretorno1.Columns(14).Width = 75
            dgvretorno1.Columns(15).Width = 80
            dgvretorno1.Columns(16).Width = 35
            dgvretorno1.Columns(17).Width = 43
            dgvretorno1.Columns(18).Width = 70
            dgvretorno1.Columns(19).Width = 70
            dgvretorno1.Columns(20).Width = 70
            dgvretorno1.Columns(21).Width = 50
            dgvretorno1.Columns(22).Width = 50


            dgvretorno1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvretorno1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvretorno1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvretorno1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvretorno1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvretorno1.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvretorno1.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvretorno1.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvretorno1.Columns(20).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvretorno1.Columns(21).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvretorno1.Columns(22).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Conexion.Close()
        ElseIf chkexportacion.Checked = False Then
            dtpinicial.Visible = False
            dtpfinal.Visible = False
            Label1.Visible = False
            Label2.Visible = False
            sql = "select * from salida_inventario order by fecha_salida, no_salida asc"
            Try
                Conexion.Open()
                adaptar = New SqlDataAdapter(sql, Conexion)
                almacen = New DataSet
                adaptar.Fill(almacen, "salida_inventario")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            dgvretorno1.DataSource = almacen
            dgvretorno1.DataMember = "salida_inventario"
            dgvretorno1.Columns(0).Visible = False
            dgvretorno1.Columns(1).HeaderText = "no_salida"
            dgvretorno1.Columns(2).HeaderText = "fecha_salida"
            dgvretorno1.Columns(3).HeaderText = "fecha_retorno"
            dgvretorno1.Columns(4).HeaderText = "codigo_vh"
            dgvretorno1.Columns(5).HeaderText = "placa_vh"
            dgvretorno1.Columns(6).HeaderText = "estado_vh"
            dgvretorno1.Columns(7).HeaderText = "vhexist"
            dgvretorno1.Columns(8).HeaderText = "categoriaps"
            dgvretorno1.Columns(9).HeaderText = "hrm1"
            dgvretorno1.Columns(10).HeaderText = "hrm2"
            dgvretorno1.Columns(11).HeaderText = "klm1"
            dgvretorno1.Columns(12).HeaderText = "klm2"
            dgvretorno1.Columns(13).HeaderText = "motorista"
            dgvretorno1.Columns(14).HeaderText = "acompañante"
            dgvretorno1.Columns(15).HeaderText = "destino"
            dgvretorno1.Columns(16).HeaderText = "item"
            dgvretorno1.Columns(17).HeaderText = "unidad"
            dgvretorno1.Columns(18).HeaderText = "descripcion"
            dgvretorno1.Columns(19).HeaderText = "observacion"
            dgvretorno1.Columns(20).HeaderText = "estado"
            dgvretorno1.Columns(21).HeaderText = "fechahora"
            dgvretorno1.AutoResizeColumns()
            dgvretorno1.Columns(1).Width = 60
            dgvretorno1.Columns(2).Width = 80 'Ancho Especifico
            dgvretorno1.Columns(3).Width = 80
            dgvretorno1.Columns(4).Width = 60
            dgvretorno1.Columns(5).Width = 55
            dgvretorno1.Columns(6).Width = 60
            dgvretorno1.Columns(7).Width = 50
            dgvretorno1.Columns(8).Width = 65
            dgvretorno1.Columns(9).Width = 50
            dgvretorno1.Columns(10).Width = 50
            dgvretorno1.Columns(11).Width = 50
            dgvretorno1.Columns(12).Width = 50
            dgvretorno1.Columns(13).Width = 80
            dgvretorno1.Columns(14).Width = 75
            dgvretorno1.Columns(15).Width = 80
            dgvretorno1.Columns(16).Width = 35
            dgvretorno1.Columns(17).Width = 43
            dgvretorno1.Columns(18).Width = 70
            dgvretorno1.Columns(19).Width = 70
            dgvretorno1.Columns(20).Width = 50
            dgvretorno1.Columns(21).Width = 50


            dgvretorno1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvretorno1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvretorno1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvretorno1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvretorno1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvretorno1.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvretorno1.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvretorno1.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvretorno1.Columns(20).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvretorno1.Columns(21).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Conexion.Close()
        End If
    End Sub

    Private Sub dtpinicial_ValueChanged(sender As Object, e As EventArgs) Handles dtpinicial.ValueChanged
        Dim fechaIni As String = dtpinicial.Value.ToString("yyyy-MM-dd")
        Dim fechaFin As String = dtpfinal.Value.ToString("yyyy-MM-dd")
        sql = "select * from salida_inventario where fecha_salida >= '" & fechaIni & "' and fecha_salida <= '" & fechaFin & "' order by fecha_salida, no_salida asc"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "salida_inventario")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        dgvretorno1.DataSource = almacen
        dgvretorno1.DataMember = "salida_inventario"
        dgvretorno1.Columns(0).Visible = False
        dgvretorno1.Columns(1).HeaderText = "no_salida"
        dgvretorno1.Columns(2).HeaderText = "fecha_salida"
        dgvretorno1.Columns(3).HeaderText = "fecha_retorno"
        dgvretorno1.Columns(4).HeaderText = "codigo_vh"
        dgvretorno1.Columns(5).HeaderText = "placa_vh"
        dgvretorno1.Columns(6).HeaderText = "estado_vh"
        dgvretorno1.Columns(7).HeaderText = "vhexist"
        dgvretorno1.Columns(8).HeaderText = "categoriaps"
        dgvretorno1.Columns(9).HeaderText = "hrm1"
        dgvretorno1.Columns(10).HeaderText = "hrm2"
        dgvretorno1.Columns(11).HeaderText = "klm1"
        dgvretorno1.Columns(12).HeaderText = "klm2"
        dgvretorno1.Columns(13).HeaderText = "motorista"
        dgvretorno1.Columns(14).HeaderText = "acompañante"
        dgvretorno1.Columns(15).HeaderText = "destino"
        dgvretorno1.Columns(16).HeaderText = "item"
        dgvretorno1.Columns(17).HeaderText = "unidad"
        dgvretorno1.Columns(18).HeaderText = "item_destino"
        dgvretorno1.Columns(19).HeaderText = "descripcion"
        dgvretorno1.Columns(20).HeaderText = "observacion"
        dgvretorno1.Columns(21).HeaderText = "estado"
        dgvretorno1.Columns(22).HeaderText = "fechahora"
        dgvretorno1.AutoResizeColumns()
        dgvretorno1.Columns(1).Width = 60
        dgvretorno1.Columns(2).Width = 80 'Ancho Especifico
        dgvretorno1.Columns(3).Width = 80
        dgvretorno1.Columns(4).Width = 60
        dgvretorno1.Columns(5).Width = 55
        dgvretorno1.Columns(6).Width = 60
        dgvretorno1.Columns(7).Width = 50
        dgvretorno1.Columns(8).Width = 65
        dgvretorno1.Columns(9).Width = 50
        dgvretorno1.Columns(10).Width = 50
        dgvretorno1.Columns(11).Width = 50
        dgvretorno1.Columns(12).Width = 50
        dgvretorno1.Columns(13).Width = 80
        dgvretorno1.Columns(14).Width = 75
        dgvretorno1.Columns(15).Width = 80
        dgvretorno1.Columns(16).Width = 35
        dgvretorno1.Columns(17).Width = 43
        dgvretorno1.Columns(18).Width = 70
        dgvretorno1.Columns(19).Width = 70
        dgvretorno1.Columns(20).Width = 70
        dgvretorno1.Columns(21).Width = 50
        dgvretorno1.Columns(22).Width = 50


        dgvretorno1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvretorno1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvretorno1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvretorno1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvretorno1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvretorno1.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvretorno1.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvretorno1.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvretorno1.Columns(20).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvretorno1.Columns(21).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvretorno1.Columns(22).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Conexion.Close()

    End Sub

    Private Sub dtpfinal_ValueChanged(sender As Object, e As EventArgs) Handles dtpfinal.ValueChanged
        Dim fechaIni As String = dtpinicial.Value.ToString("yyyy-MM-dd")
        Dim fechaFin As String = dtpfinal.Value.ToString("yyyy-MM-dd")
        sql = "select * from salida_inventario where fecha_salida >= '" & fechaIni & "' and fecha_salida <= '" & fechaFin & "' order by fecha_salida, no_salida asc"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "salida_inventario")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        dgvretorno1.DataSource = almacen
        dgvretorno1.DataMember = "salida_inventario"
        dgvretorno1.Columns(0).Visible = False
        dgvretorno1.Columns(1).HeaderText = "no_salida"
        dgvretorno1.Columns(2).HeaderText = "fecha_salida"
        dgvretorno1.Columns(3).HeaderText = "fecha_retorno"
        dgvretorno1.Columns(4).HeaderText = "codigo_vh"
        dgvretorno1.Columns(5).HeaderText = "placa_vh"
        dgvretorno1.Columns(6).HeaderText = "estado_vh"
        dgvretorno1.Columns(7).HeaderText = "vhexist"
        dgvretorno1.Columns(8).HeaderText = "categoriaps"
        dgvretorno1.Columns(9).HeaderText = "hrm1"
        dgvretorno1.Columns(10).HeaderText = "hrm2"
        dgvretorno1.Columns(11).HeaderText = "klm1"
        dgvretorno1.Columns(12).HeaderText = "klm2"
        dgvretorno1.Columns(13).HeaderText = "motorista"
        dgvretorno1.Columns(14).HeaderText = "acompañante"
        dgvretorno1.Columns(15).HeaderText = "destino"
        dgvretorno1.Columns(16).HeaderText = "item"
        dgvretorno1.Columns(17).HeaderText = "unidad"
        dgvretorno1.Columns(18).HeaderText = "item_destino"
        dgvretorno1.Columns(19).HeaderText = "descripcion"
        dgvretorno1.Columns(20).HeaderText = "observacion"
        dgvretorno1.Columns(21).HeaderText = "estado"
        dgvretorno1.Columns(22).HeaderText = "fechahora"
        dgvretorno1.AutoResizeColumns()
        dgvretorno1.Columns(1).Width = 60
        dgvretorno1.Columns(2).Width = 80 'Ancho Especifico
        dgvretorno1.Columns(3).Width = 80
        dgvretorno1.Columns(4).Width = 60
        dgvretorno1.Columns(5).Width = 55
        dgvretorno1.Columns(6).Width = 60
        dgvretorno1.Columns(7).Width = 50
        dgvretorno1.Columns(8).Width = 65
        dgvretorno1.Columns(9).Width = 50
        dgvretorno1.Columns(10).Width = 50
        dgvretorno1.Columns(11).Width = 50
        dgvretorno1.Columns(12).Width = 50
        dgvretorno1.Columns(13).Width = 80
        dgvretorno1.Columns(14).Width = 75
        dgvretorno1.Columns(15).Width = 80
        dgvretorno1.Columns(16).Width = 35
        dgvretorno1.Columns(17).Width = 43
        dgvretorno1.Columns(18).Width = 70
        dgvretorno1.Columns(19).Width = 70
        dgvretorno1.Columns(20).Width = 70
        dgvretorno1.Columns(21).Width = 50
        dgvretorno1.Columns(22).Width = 50


        dgvretorno1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvretorno1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvretorno1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvretorno1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvretorno1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvretorno1.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvretorno1.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvretorno1.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvretorno1.Columns(20).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvretorno1.Columns(21).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvretorno1.Columns(22).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Conexion.Close()
    End Sub

    Private Sub bexportar_Click(sender As Object, e As EventArgs) Handles bexportar.Click
        llenarExcel(dgvretorno1)
    End Sub
        Function llenarExcel(ByVal ElGrid As DataGridView) As Boolean
        ' Creamos las variables
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        Try
            ' Añadimos el Libro al programa, y la hoja al libro
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()

            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = ElGrid.ColumnCount
            Dim NRow As Integer = ElGrid.RowCount

            ' Aquí recorremos todas las filas, y por cada fila todas las columnas
            ' y vamos escribiendo.
            Dim excelRow As Integer = 2 ' Iniciar desde la segunda fila en Excel, dejando la primera para los encabezados de tabla

            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = ElGrid.Columns(i - 1).Name.ToString
            Next

            For Fila As Integer = 0 To NRow - 1
                ' Verificar si es una fila vacía
                Dim filaVacia As Boolean = True
                For Col As Integer = 0 To NCol - 1
                    If Not String.IsNullOrEmpty(ElGrid.Item(Col, Fila).Value.ToString) Then
                        filaVacia = False
                        Exit For
                    End If
                Next

                ' Si no es una fila vacía, copiar los datos
                If Not filaVacia Then
                    For Col As Integer = 0 To NCol - 1
                        exHoja.Cells.Item(excelRow, Col + 1) = ElGrid.Item(Col, Fila).Value
                    Next
                    excelRow += 1
                End If
            Next

            ' Ajustar el ancho de las columnas
            exHoja.Columns.AutoFit()

            ' Crear una tabla en Excel con el rango de datos
            Dim lastCell = exHoja.Cells.SpecialCells(Microsoft.Office.Interop.Excel.XlCellType.xlCellTypeLastCell)
            Dim tableRange = exHoja.Range(exHoja.Cells(1, 1), lastCell)
            tableRange.Select()
            exHoja.ListObjects.Add(1, tableRange, , 1, exHoja.Cells(1, 1)).Name = "TablaDatos"

            ' Aplicación visible
            exApp.Application.Visible = True

            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
            Return False
        End Try
        Return True
        End Function

End Class