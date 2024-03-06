Imports System.Data.SqlClient
Imports System.Data
Imports System.Runtime.InteropServices
Public Class ListOrdenCantidad

    Private Sub ncantidadsol_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ncantidadsol.KeyPress

        Dim frmListado As FrmListadoOrdAgr = FrmListadoOrdAgr.Instancia

        If AscW(e.KeyChar) = Keys.Enter Then

            sql = "select * from ordenes_trabajo where num_solcitud='" & frmListado.tnumsolici.Text & "'"

            Try
                Conexion.Open()
                adaptar = New SqlDataAdapter(sql, Conexion)
                almacen = New DataSet
                adaptar.Fill(almacen, "ordenes_trabajo")
                resultado = almacen.Tables("ordenes_trabajo").Rows.Count

                If resultado = 0 Then

                    Dim Valor As String
                    'Dim Found = False
                    Valor = frmListado.dgvinventario(2, frmListado.dgvinventario.CurrentRow.Index).Value
                    Dim existe As Boolean = frmListado.dgvreg.Rows.Cast(Of DataGridViewRow).Any(Function(x) CStr(x.Cells("descripcion").Value) = Valor)
                    If existe = True Then

                        Me.Close()
                        frmListado.mensaje.Text = "Este articulo ya esta agregado solo modifique valores"
                    Else

                        Dim Valor2 As String
                        Valor2 = frmListado.dgvinventario(2, frmListado.dgvinventario.CurrentRow.Index).Value

                        Dim nombre As String
                        Dim item As String
                        Dim cantidad As String
                        Dim articulo As String
                        Dim cantidaaprob As String

                        item = frmListado.dgvreg.Rows.Count.ToString
                        articulo = frmListado.dgvinventario(0, frmListado.dgvinventario.CurrentRow.Index).Value
                        nombre = frmListado.dgvinventario(2, frmListado.dgvinventario.CurrentRow.Index).Value
                        cantidad = ncantidadsol.Value
                        cantidaaprob = 0


                        frmListado.dgvreg.Rows.Add(0, item, articulo, nombre, "UND", cantidad, cantidaaprob)
                        frmListado.dgvreg.ClearSelection()

                        frmListado.mensaje.Text = "Mensajes"
                        Me.Close()
                        frmListado.tcriterio.Focus()

                    End If

                ElseIf resultado > 0 Then

                    Dim Valor As String

                    Valor = frmListado.dgvinventario(2, frmListado.dgvinventario.CurrentRow.Index).Value

                    Dim existe As Boolean = frmListado.dgvreg.Rows.Cast(Of DataGridViewRow).Any(Function(x) CStr(x.Cells("descripcion").Value) = Valor)
                    Dim existe2 As Boolean = frmListado.dgvreg2.Rows.Cast(Of DataGridViewRow).Any(Function(x) CStr(x.Cells("descripcion2").Value) = Valor)

                    If existe = True Or existe2 = True Then

                        frmListado.dgvreg.Refresh()
                        frmListado.dgvreg2.Refresh()

                        frmListado.mensaje.Text = "Este articulo ya esta agregado solo modifique valores"

                        Me.Close()
                    Else

                        frmListado.dgvreg.Refresh()
                        frmListado.dgvreg2.Refresh()

                        Dim Valor2 As String
                        Valor2 = frmListado.dgvinventario(2, frmListado.dgvinventario.CurrentRow.Index).Value

                        Dim nombre As String
                        Dim item As String
                        Dim cantidad As String
                        Dim articulo As String
                        Dim cantidaaprob As String

                        item = frmListado.dgvreg2.Rows.Count.ToString
                        articulo = frmListado.dgvinventario(0, frmListado.dgvinventario.CurrentRow.Index).Value
                        nombre = frmListado.dgvinventario(2, frmListado.dgvinventario.CurrentRow.Index).Value
                        cantidad = ncantidadsol.Value
                        cantidaaprob = 0

                        frmListado.dgvreg2.Rows.Add(0, item, articulo, nombre, "UND", cantidad, cantidaaprob)
                        frmListado.dgvreg2.ClearSelection()

                        frmListado.mensaje.Text = "Mensajes"
                        Me.Close()
                        frmListado.tcriterio.Focus()

                    End If
                End If

            Catch ex As Exception
            End Try
            Conexion.Close()
        End If
    End Sub
End Class