Imports System.Data.SqlClient
Imports System.Data
Imports System.Runtime.InteropServices
Public Class FrmInventariado
    Dim temp As Long
    Dim lista As New ListBox
    Dim a, b As Integer
    Const WM_CAP As Short = &H400S

    Const WM_CAP_DRIVER_CONNECT As Integer = WM_CAP + 10
    Const WM_CAP_DRIVER_DISCONNECT As Integer = WM_CAP + 11
    Const WM_CAP_EDIT_COPY As Integer = WM_CAP + 30

    Const WM_CAP_SET_PREVIEW As Integer = WM_CAP + 50
    Const WM_CAP_SET_PREVIEWRATE As Integer = WM_CAP + 52
    Const WM_CAP_SET_SCALE As Integer = WM_CAP + 53
    Const WS_CHILD As Integer = &H40000000
    Const WS_VISIBLE As Integer = &H10000000
    Const SWP_NOMOVE As Short = &H2S
    Const SWP_NOSIZE As Short = 1
    Const SWP_NOZORDER As Short = &H4S
    Const HWND_BOTTOM As Short = 1

    Dim iDevice As Integer = 0
    Dim hHwnd As Integer

    Public Const WM_USER As Long = &H400
    Public Const WM_CAP_START As Long = WM_USER
    Public si As Integer
    Public Const WM_CAP_DLG_VIDEOFORMAT As Long = WM_CAP_START + 41
    Public Const WM_CAP_DLG_VIDEOSOURCE As Long = WM_CAP_START + 42
    Public Const WM_CAP_DLG_VIDEODISPLAY As Long = WM_CAP_START + 43
    Public Const WM_CAP_GET_VIDEOFORMAT As Long = WM_CAP_START + 44
    Public Const WM_CAP_SET_VIDEOFORMAT As Long = WM_CAP_START + 45
    Public Const WM_CAP_DLG_VIDEOCOMPRESSION As Long = WM_CAP_START + 46

    'Formato
    Declare Function SendMessage Lib "user32" Alias "SendMessageA" _
     (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, _
     <MarshalAs(UnmanagedType.AsAny)> ByVal lParam As Object) As Integer

    Declare Function SetWindowPos Lib "user32" Alias "SetWindowPos" (ByVal hwnd As Integer, _
     ByVal hWndInsertAfter As Integer, ByVal x As Integer, ByVal y As Integer, _
     ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer) As Integer

    Declare Function DestroyWindow Lib "user32" (ByVal hndw As Integer) As Boolean

    Declare Function capCreateCaptureWindowA Lib "avicap32.dll" _
     (ByVal lpszWindowName As String, ByVal dwStyle As Integer, _
     ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer, _
     ByVal nHeight As Short, ByVal hWndParent As Integer, _
     ByVal nID As Integer) As Integer

    Declare Function capGetDriverDescriptionA Lib "avicap32.dll" (ByVal wDriver As Short, _
     ByVal lpszName As String, ByVal cbName As Integer, ByVal lpszVer As String, _
     ByVal cbVer As Integer) As Boolean
    Private Sub FrmInventariado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion = New SqlConnection
        Conexion.ConnectionString = cadena
        Dim da As New SqlDataAdapter("Select * from proveedores", Conexion)
        Dim dt As New DataTable
        da.Fill(dt)
        tproveedor.DataSource = dt
        tproveedor.DisplayMember = "nom_proveedor"
        tproveedor.ValueMember = "cod_proveedor"

        Dim da2 As New SqlDataAdapter("Select * from ubicaciones_stock", Conexion)
        Dim dt2 As New DataTable
        da2.Fill(dt2)
        cubicacion.DataSource = dt2
        cubicacion.DisplayMember = "ubicacion"
        cubicacion.ValueMember = "codigo_p"

        Try
            cargar_webcam()
            If lista.Items.Count > 0 Then
                biniciar.Enabled = True
                lista.SelectedIndex = 0
                biniciar.Enabled = True
            Else
                lista.Items.Add("No Capture Device")
                biniciar.Enabled = False
            End If

            bguardar.Enabled = False
            bformato.Enabled = False
            pfototomar.SizeMode = PictureBoxSizeMode.StretchImage
            a = 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        mostrarINV()

        If FrmPrincipal.lrol.Text = "Administrador" Then
            beliminar.Enabled = True
        ElseIf FrmPrincipal.lrol.Text = "Administracion" Then
            beliminar.Enabled = True
        ElseIf FrmPrincipal.lrol.Text = "Dueño" Then
            beliminar.Enabled = True
        Else
            beliminar.Enabled = False
        End If
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
    Private Sub cargar_webcam()
        Try
            Dim strName As String = Space(100)
            Dim strVer As String = Space(100)
            Dim bReturn As Boolean
            Dim x As Integer = 0
            Do
                'obtenemos la webcam conectada
                bReturn = capGetDriverDescriptionA(x, strName, 100, strVer, 100)
                If bReturn Then lista.Items.Add(strName.Trim)
                x += 1
            Loop Until bReturn = False
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub
    'Private Sub codp2_Validated(sender As Object, e As EventArgs) Handles codp2.Validated
    '    If codp2.Text = "" Then
    '        mensaje.Text = "Dejo vacio el codigo del producto"
    '        codp2.Focus()
    '        Exit Sub
    '    End If
    '    sql = "select * from inventario where codigop='" & codp2.Text & "'"
    '    Try
    '        Conexion.Open()
    '        adaptar = New SqlDataAdapter(sql, Conexion)
    '        almacen = New DataSet
    '        adaptar.Fill(almacen, "inventario")
    '        resultado = almacen.Tables("inventario").Rows.Count
    '        If resultado > 0 Then
    '            registro = almacen.Tables("inventario").Rows(0)
    '            If Not IsDBNull(registro("prefijo")) Then
    '                codp1.Text = registro("prefijo")
    '            End If
    '            If Not IsDBNull(registro("nom_prod")) Then
    '                tnombre.Text = registro("nom_prod")
    '            End If
    '            If Not IsDBNull(registro("categoria")) Then
    '                ccategoria.Text = registro("categoria")
    '            End If
    '            If Not IsDBNull(registro("proveedor")) Then
    '                tproveedor.Text = registro("proveedor")
    '            End If
    '            If Not IsDBNull(registro("precio")) Then
    '                tprecio.Text = registro("precio")
    '            End If
    '            If Not IsDBNull(registro("observaciones")) Then
    '                tobservaciones.Text = registro("observaciones")
    '            End If
    '            If Not IsDBNull(registro("stock")) Then
    '                cstock.Text = registro("stock")
    '            End If
    '            If Not IsDBNull(registro("foto1")) Then
    '                Dim vfoto As Byte() = CType(registro("foto1"), Byte())
    '                Dim ms As IO.MemoryStream
    '                ms = New IO.MemoryStream(vfoto)
    '                Dim img As Image = Image.FromStream(ms)
    '                pfoto.Image = img
    '                pfoto.SizeMode = PictureBoxSizeMode.StretchImage
    '            Else
    '                pfoto.Image = Nothing
    '            End If
    '            If Not IsDBNull(registro("foto2")) Then
    '                Dim vfoto As Byte() = CType(registro("foto2"), Byte())
    '                Dim ms As IO.MemoryStream
    '                ms = New IO.MemoryStream(vfoto)
    '                Dim img As Image = Image.FromStream(ms)
    '                pfoto2.Image = img
    '                pfoto2.SizeMode = PictureBoxSizeMode.StretchImage
    '            Else
    '                pfoto.Image = Nothing
    '            End If
    '        ElseIf resultado = 0 Then
    '            limpiarparcial()
    '        End If
    '    Catch ex As Exception
    '    End Try
    '    Conexion.Close()
    '    codp1.Focus()
    'End Sub
    Private Sub limpiar()
        codp2.Text = Nothing
        limpiarparcial()
    End Sub

    Private Sub limpiarparcial()
        codp1.Text = Nothing
        tnombre.Text = Nothing
        ccategoria.Text = Nothing
        tproveedor.Text = Nothing
        tprecio.Text = Nothing
        tobservaciones.Text = Nothing
        cubicacion.Text = Nothing
        cstock.Value = 0
        biniciar.Enabled = True
        pfoto.Image = Nothing
        pfoto2.Image = Nothing
        mensaje.Text = Nothing
    End Sub

    Private Sub codp2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles codp2.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            codp2_Validated(sender, e)
            mensaje.Text = "Mensajes"
        End If
    End Sub


    Private Sub bagregar_Click(sender As Object, e As EventArgs) Handles bagregar.Click
        If codp2.Text = Nothing Then
            mensaje.Text = "Dejo vacio el codigo del producto"
            codp2.Focus()
            Exit Sub
        ElseIf codp1.Text = Nothing Then
            mensaje.Text = "Dejo vacio la importancia del producto"
            codp1.Focus()
            Exit Sub
        ElseIf tnombre.Text = Nothing Then
            mensaje.Text = "Dejo vacio el nombre de producto"
            tnombre.Focus()
            Exit Sub
        End If
        sql = "select * from inventario where codigop='" & codp2.Text & "'"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "inventario")
            resultado = almacen.Tables("inventario").Rows.Count
            If resultado > 0 Then
                sql = "Update inventario set prefijo='" & codp1.Text & "',nom_prod='" & tnombre.Text & "',"
                sql += "categoria='" & ccategoria.Text & "',ubicacion='" & cubicacion.Text & "',proveedor='" & tproveedor.Text & "',"
                sql += "observaciones='" & tobservaciones.Text & "',stock='" & cstock.Text & "',precio='" & tprecio.Text & "' where codigop='" & codp2.Text & "'"
            ElseIf resultado = 0 Then
                sql = "insert into inventario (codigop,prefijo,nom_prod,categoria,ubicacion,proveedor,observaciones,stock,precio) values ("
                sql += "'" & codp2.Text & "','" & codp1.Text & "','" & tnombre.Text & "',"
                sql += "'" & ccategoria.Text & "','" & cubicacion.Text & "','" & tproveedor.Text & "',"
                sql += "'" & tobservaciones.Text & "','" & cstock.Text & "','" & tprecio.Text & "')"
            End If
            Comando = New SqlCommand(sql, Conexion)
            Comando.ExecuteNonQuery()

            If pfoto.Image Is Nothing Then
            Else
                sql = "update inventario set foto1=@foto where codigop='" & codp2.Text & "'"
                Comando = New SqlCommand(sql, Conexion)
                Dim imgbdd As New System.IO.MemoryStream
                pfoto.Image.Save(imgbdd, System.Drawing.Imaging.ImageFormat.Jpeg)
                Comando.Parameters.Add("@foto", SqlDbType.VarBinary).Value = imgbdd.GetBuffer
                Comando.ExecuteNonQuery()
            End If

            If pfoto2.Image Is Nothing Then
            Else
                sql = "update inventario set foto2=@foto where codigop='" & codp2.Text & "'"
                Comando = New SqlCommand(sql, Conexion)
                Dim imgbdd As New System.IO.MemoryStream
                pfoto2.Image.Save(imgbdd, System.Drawing.Imaging.ImageFormat.Jpeg)
                Comando.Parameters.Add("@foto", SqlDbType.VarBinary).Value = imgbdd.GetBuffer
                Comando.ExecuteNonQuery()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        limpiar()
        Conexion.Close()
        codp2.Focus()
        mostrarINV()
    End Sub

    Private Sub breiniciar_Click(sender As Object, e As EventArgs)
        limpiar()
    End Sub

    Private Sub bdatagrid_Click(sender As Object, e As EventArgs) Handles bdatagrid.Click
        dgvinventario.Visible = True
        ccampos.Enabled = True
        tcriterio.Enabled = True
        btnbuscar.Enabled = True
        sql = "select * from inventario order by codigop desc"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "inventario")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        dgvinventario.DataSource = almacen
        dgvinventario.DataMember = "inventario"
        dgvinventario.Columns(0).HeaderText = "codigop"
        dgvinventario.Columns(1).HeaderText = "prefijo"
        dgvinventario.Columns(2).HeaderText = "nom_prod"
        dgvinventario.Columns(3).HeaderText = "categoria"
        dgvinventario.Columns(4).HeaderText = "ubicacion"
        dgvinventario.Columns(5).Visible = False
        dgvinventario.Columns(6).Visible = False
        dgvinventario.Columns(7).HeaderText = "foto1"
        dgvinventario.Columns(8).Visible = False
        dgvinventario.Columns(9).Visible = False
        dgvinventario.Columns(10).Visible = False
        dgvinventario.AutoResizeColumns()
        dgvinventario.Columns(0).Width = 60
        dgvinventario.Columns(1).Width = 44 'Ancho Especifico
        dgvinventario.Columns(2).Width = 193
        dgvinventario.Columns(3).Width = 160
        dgvinventario.Columns(4).Width = 170
        dgvinventario.Columns(5).Width = 180
        dgvinventario.Columns(7).Width = 130
        dgvinventario.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvinventario.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvinventario.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvinventario.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvinventario.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvinventario.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvinventario.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvinventario.Columns(7).DefaultCellStyle.NullValue = My.Resources.subir2
        dgvinventario.Columns(8).DefaultCellStyle.NullValue = My.Resources.subir2
        Conexion.Close()
        dgvinventario.Refresh()
        mostrarINV()
    End Sub

    Private Sub bguardar_Click(sender As Object, e As EventArgs) Handles bguardar.Click
        Try
            Dim data As IDataObject
            SendMessage(hHwnd, WM_CAP_EDIT_COPY, 352, 288)
            data = Clipboard.GetDataObject()
            If data.GetDataPresent(GetType(System.Drawing.Bitmap)) Then
                pfoto.Image = CType(data.GetData(GetType(System.Drawing.Bitmap)), Image)
                pfoto.SizeMode = PictureBoxSizeMode.StretchImage
            End If
            '  pfoto.Image.Save("c:\imagen\" + codp2.Text + ".jpg")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub bguardar2_Click(sender As Object, e As EventArgs) Handles bguardar2.Click
        Try
            Dim data As IDataObject
            SendMessage(hHwnd, WM_CAP_EDIT_COPY, 352, 288)
            data = Clipboard.GetDataObject()
            If data.GetDataPresent(GetType(System.Drawing.Bitmap)) Then
                pfoto2.Image = CType(data.GetData(GetType(System.Drawing.Bitmap)), Image)
                pfoto2.SizeMode = PictureBoxSizeMode.StretchImage
            End If
            '  pfoto2.Image.Save("c:\imagen\" + codp2.Text + ".jpg")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub biniciar_Click(sender As Object, e As EventArgs) Handles biniciar.Click
        Try
            If a = 1 Then
                iDevice = lista.SelectedIndex
                'Representa los distintos dispositivos que capturan imagen
                iniciar_webcam() 'No se ha creado
                biniciar.Text = "Apagar" 'Aunque tenemos una imagen para esto, se podria cambiar la imagen
                bformato.Enabled = True
                bguardar.Enabled = True
                si = True 'Esto indica al sistema que si hay Webcam y que ya esta configurada
            ElseIf a = 0 Then
                'Aqui seria todo lo contrario
                cerrar_webcam() 'No se ha creado
                bformato.Enabled = False
                bguardar.Enabled = False
                biniciar.Text = "Iniciar"
                pfototomar.Image = Nothing
                si = False
            End If
            'Variables de Control
            a = a + 1
            If a = 2 Then
                a = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub iniciar_webcam()
        Try
            Dim iheigth As Integer = pfototomar.Height
            Dim iwidth As Integer = pfototomar.Width
            'Creando variables de control de la forma de la imagen
            'Iniciando la apertura de la camara web
            hHwnd = capCreateCaptureWindowA(iDevice, WS_VISIBLE Or WS_CHILD, 0, 0, 190, _
            209, pfototomar.Handle.ToInt32, 0) 'Esto crea la ventana de captura
            pfototomar.SizeMode = PictureBoxSizeMode.StretchImage
            If SendMessage(hHwnd, WM_CAP_DRIVER_CONNECT, iDevice, 0) Then
                SendMessage(hHwnd, WM_CAP_SET_SCALE, True, 0)
                SendMessage(hHwnd, WM_CAP_SET_PREVIEWRATE, 66, 0)
                SendMessage(hHwnd, WM_CAP_SET_PREVIEW, True, 0)
                SetWindowPos(hHwnd, HWND_BOTTOM, 0, 0, 190, 209, _
                SWP_NOMOVE Or SWP_NOZORDER)
                'Esto configura una ventana de captura de la camara
            Else
                'Error de conexion con el dispositivo, en el caso de que la Webcam no exista o este
                'dañada
                DestroyWindow(hHwnd) 'Esto destruye la ventana creada anteriomente
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub cerrar_webcam()
        SendMessage(hHwnd, WM_CAP_DRIVER_DISCONNECT, iDevice, 0)
        DestroyWindow(hHwnd)
    End Sub

    Private Sub bformato_Click(sender As Object, e As EventArgs) Handles bformato.Click
        If si = True Then 'Variable de control
            temp = SendMessage(hHwnd, WM_CAP_DLG_VIDEOFORMAT, iDevice, 0)
            'idevice representa el hardware que encontro el codigo para captur de imagenes
        End If
    End Sub

    Private Sub breiniciar_Click_1(sender As Object, e As EventArgs) Handles breiniciar.Click
        limpiar()
        mostrarINV()
        tnombre.Enabled = True
    End Sub

    Private Sub pfoto2_Click(sender As Object, e As EventArgs) Handles pfoto2.Click
        Dim file As New OpenFileDialog()
        file.Filter = "Archivo JPG|*.jpg"
        If file.ShowDialog() = DialogResult.OK Then
            pfoto2.Image = Image.FromFile(file.FileName)
            pfoto2.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub pfoto_Click(sender As Object, e As EventArgs) Handles pfoto.Click
        Dim file As New OpenFileDialog()
        file.Filter = "Archivo JPG|*.jpg"
        If file.ShowDialog() = DialogResult.OK Then
            pfoto.Image = Image.FromFile(file.FileName)
            pfoto.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub dgvinventario_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvinventario.CellContentClick
        codp2.Text = dgvinventario.CurrentRow.Cells.Item(0).Value.ToString
        codp1.Text = dgvinventario.CurrentRow.Cells.Item(1).Value.ToString
        tnombre.Text = dgvinventario.CurrentRow.Cells.Item(2).Value.ToString
        tnombre.Enabled = False
        ccategoria.Text = dgvinventario.CurrentRow.Cells.Item(3).Value.ToString
        cubicacion.Text = dgvinventario.CurrentRow.Cells.Item(4).Value.ToString
        tproveedor.Text = dgvinventario.CurrentRow.Cells.Item(5).Value.ToString
        tobservaciones.Text = dgvinventario.CurrentRow.Cells.Item(6).Value.ToString
        cstock.Value = dgvinventario.CurrentRow.Cells.Item(9).Value.ToString
        tprecio.Text = dgvinventario.CurrentRow.Cells.Item(10).Value.ToString
        pfoto.Image = dgvinventario.CurrentRow.Cells("foto1").FormattedValue
        pfoto.SizeMode = PictureBoxSizeMode.StretchImage
        pfoto2.Image = dgvinventario.CurrentRow.Cells("foto2").FormattedValue
        pfoto2.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub dgvinventario_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgvinventario.CellPainting
        For i = 0 To dgvinventario.Rows.Count - 1
            Dim r As DataGridViewRow = dgvinventario.Rows(i)
            r.Height = 94
        Next

        If (e.RowIndex < 0 Or e.ColumnIndex < 0) Then Return

        If dgvinventario.Rows(e.RowIndex).Cells(e.ColumnIndex).ValueType = GetType(Byte()) Then
            CType(dgvinventario.Rows(e.RowIndex).Cells(e.ColumnIndex), 
                  DataGridViewImageCell).ImageLayout = DataGridViewImageCellLayout.Zoom
        End If
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        If ccampos.Text = Nothing And tcriterio.Text = Nothing Then
            sql = "select * from inventario order by codigop desc"
        ElseIf ccampos.Text <> Nothing And tcriterio.Text <> Nothing Then
            sql = "select * from inventario where " & ccampos.Text & " like '%" & tcriterio.Text & "%'"
            sql += "order by codigop"
        Else
            sql = "select * from inventario order by codigop"
        End If
        'MsgBox(sql)
        Try
            Conexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        adaptar = New SqlDataAdapter(sql, Conexion)
        almacen = New DataSet
        adaptar.Fill(almacen, "inventario")
        resultado = almacen.Tables("inventario").Rows.Count
        If resultado > 0 Then
            dgvinventario.DataSource = almacen
            dgvinventario.DataMember = "inventario"
            dgvinventario.Columns(0).HeaderText = "codigop"
            dgvinventario.Columns(1).HeaderText = "prefijo"
            dgvinventario.Columns(2).HeaderText = "nom_prod"
            dgvinventario.Columns(3).HeaderText = "categoria"
            dgvinventario.Columns(4).HeaderText = "ubicacion"
            dgvinventario.Columns(5).Visible = False
            dgvinventario.Columns(6).Visible = False
            dgvinventario.Columns(7).HeaderText = "foto1"
            dgvinventario.Columns(8).Visible = False
            dgvinventario.Columns(9).Visible = False
            dgvinventario.Columns(10).Visible = False
            dgvinventario.AutoResizeColumns()
            dgvinventario.Columns(0).Width = 60
            dgvinventario.Columns(1).Width = 44 'Ancho Especifico
            dgvinventario.Columns(2).Width = 193
            dgvinventario.Columns(3).Width = 160
            dgvinventario.Columns(4).Width = 170
            dgvinventario.Columns(5).Width = 180
            dgvinventario.Columns(7).Width = 130
            dgvinventario.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvinventario.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvinventario.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvinventario.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvinventario.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvinventario.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvinventario.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvinventario.Columns(7).DefaultCellStyle.NullValue = My.Resources.subir2
            dgvinventario.Columns(8).DefaultCellStyle.NullValue = My.Resources.subir2
            Conexion.Close()
        ElseIf resultado = 0 Then
            mensaje.Text = "No se encuentra con mostrar"
            dgvinventario.DataSource = Nothing
            dgvinventario.DataMember = Nothing
            dgvinventario.Refresh()
        End If
        Conexion.Close()
        dgvinventario.Focus()
    End Sub
    Private Sub mostrarINV()
        If ccampos.Text = Nothing And tcriterio.Text = Nothing Then
            sql = "select * from inventario order by codigop desc"
        ElseIf ccampos.Text <> Nothing And tcriterio.Text <> Nothing Then
            sql = "select * from inventario where " & ccampos.Text & " like '%" & tcriterio.Text & "%'"
            sql += "order by codigop desc"
        Else
            sql = "select * from inventario order by codigop desc"
        End If
        'MsgBox(sql)
        Try
            Conexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        adaptar = New SqlDataAdapter(sql, Conexion)
        almacen = New DataSet
        adaptar.Fill(almacen, "inventario")
        resultado = almacen.Tables("inventario").Rows.Count
        If resultado > 0 Then
            dgvinventario.DataSource = almacen
            dgvinventario.DataMember = "inventario"
            dgvinventario.Columns(0).HeaderText = "codigop"
            dgvinventario.Columns(1).HeaderText = "prefijo"
            dgvinventario.Columns(2).HeaderText = "nom_prod"
            dgvinventario.Columns(3).HeaderText = "categoria"
            dgvinventario.Columns(4).HeaderText = "ubicacion"
            dgvinventario.Columns(5).Visible = False
            dgvinventario.Columns(6).Visible = False
            dgvinventario.Columns(7).HeaderText = "foto1"
            dgvinventario.Columns(8).Visible = False
            dgvinventario.Columns(9).Visible = False
            dgvinventario.Columns(10).Visible = False
            dgvinventario.AutoResizeColumns()
            dgvinventario.Columns(0).Width = 60
            dgvinventario.Columns(1).Width = 44 'Ancho Especifico
            dgvinventario.Columns(2).Width = 193
            dgvinventario.Columns(3).Width = 160
            dgvinventario.Columns(4).Width = 170
            dgvinventario.Columns(5).Width = 180
            dgvinventario.Columns(7).Width = 130
            dgvinventario.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvinventario.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvinventario.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvinventario.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvinventario.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvinventario.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvinventario.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvinventario.Columns(7).DefaultCellStyle.NullValue = My.Resources.subir2
            dgvinventario.Columns(8).DefaultCellStyle.NullValue = My.Resources.subir2
            Conexion.Close()
        ElseIf resultado = 0 Then
            mensaje.Text = "No se encuentra con mostrar"
            dgvinventario.DataSource = Nothing
            dgvinventario.DataMember = Nothing
            dgvinventario.Refresh()
        End If
        Conexion.Close()
        dgvinventario.Focus()
    End Sub

    Private Sub blimpieza_Click(sender As Object, e As EventArgs) Handles blimpieza.Click
        btnbuscar.Text = Nothing
        ccampos.Text = Nothing
        tcriterio.Text = Nothing
    End Sub

    Private Sub beliminar_Click(sender As Object, e As EventArgs) Handles beliminar.Click
        If codp2.Text = Nothing Then
            mensaje.Text = "Dejo vacio el Codigo del Producto"
            codp2.Focus()
            Exit Sub
        End If

        If MsgBox("Borrar el Producto?", MsgBoxStyle.YesNo, "Sistema de SERINTER") = MsgBoxResult.Yes Then
            Try
                sql = "delete from inventario where codigop='" & codp2.Text & "'"
                Conexion.Open()
                Comando = New SqlCommand(sql, Conexion)
                Comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        Conexion.Close()
        limpiar()
        codp2.Focus()
        mostrarINV()
    End Sub

    Private Sub cubicacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cubicacion.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tproveedor.Focus()
            mensaje.Text = "Mensajes"
        End If
        e.Handled = True
    End Sub

    Private Sub ccategoria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ccategoria.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            cubicacion.Focus()
            mensaje.Text = "Mensajes"
        End If
        e.Handled = True
    End Sub

    Private Sub codp1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles codp1.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tnombre.Focus()
            mensaje.Text = "Mensajes"
        End If
        e.Handled = True
    End Sub

    Private Sub tnombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tnombre.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            ccategoria.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub tproveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tproveedor.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tobservaciones.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub tprecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tprecio.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
            If Asc(e.KeyChar) = 46 Then
                e.Handled = False
            End If
        End If
        If AscW(e.KeyChar) = Keys.Enter Then
            cstock.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub cstock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cstock.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            bagregar.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub tobservaciones_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tobservaciones.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tprecio.Focus()
            mensaje.Text = "Mensajes"
        End If
    End Sub

    Private Sub codp2_Validated(sender As Object, e As EventArgs) Handles codp2.Validated

        sql = "Select * from inventario where codigop='" & codp2.Text & "'"
        Try
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "inventario")
            resultado = almacen.Tables("inventario").Rows.Count
            If resultado > 0 Then
                limpiarparcial()
                registro = almacen.Tables("inventario").Rows(0)
                If Not IsDBNull(registro("prefijo")) Then
                    codp1.Text = registro("prefijo")
                End If
                If Not IsDBNull(registro("nom_prod")) Then
                    tnombre.Text = registro("nom_prod")
                End If
                If Not IsDBNull(registro("categoria")) Then
                    ccategoria.Text = registro("categoria")
                End If
                If Not IsDBNull(registro("ubicacion")) Then
                    cubicacion.Text = registro("ubicacion")
                End If
                If Not IsDBNull(registro("proveedor")) Then
                    tproveedor.Text = registro("proveedor")
                End If
                If Not IsDBNull(registro("precio")) Then
                    tprecio.Text = registro("precio")
                End If
                If Not IsDBNull(registro("stock")) Then
                    cstock.Value = registro("stock")
                End If
                If Not IsDBNull(registro("foto1")) Then
                    Dim vfoto As Byte() = CType(registro("foto1"), Byte())
                    Dim ms As IO.MemoryStream
                    ms = New IO.MemoryStream(vfoto)
                    Dim img As Image = Image.FromStream(ms)
                    pfoto.Image = img
                    pfoto.SizeMode = PictureBoxSizeMode.StretchImage
                Else
                    pfoto.Image = Nothing
                End If
                If Not IsDBNull(registro("foto2")) Then
                    Dim vfoto As Byte() = CType(registro("foto2"), Byte())
                    Dim ms As IO.MemoryStream
                    ms = New IO.MemoryStream(vfoto)
                    Dim img As Image = Image.FromStream(ms)
                    pfoto2.Image = img
                    pfoto2.SizeMode = PictureBoxSizeMode.StretchImage
                Else
                    pfoto.Image = Nothing
                End If
                tnombre.Enabled = False
            ElseIf resultado = 0 Then
                tnombre.Enabled = True
                limpiarparcial()
            End If
        Catch ex As Exception
        End Try
        Conexion.Close()
        codp1.Focus()
    End Sub

    Private Sub ccampos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ccampos.KeyPress
        e.Handled = True
    End Sub
End Class