Imports System.Data.SqlClient
Imports System.Data
Imports System.Runtime.InteropServices
Public Class FrmSolicitudImpr

    Private Sub FrmSolicitudImpr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Generar_solicitudTableAdapter.Fill(Me.SERINTERDataSet.Generar_solicitud, num_orden:=tsolicitud.Text)
        'Me.RepoViewer.RefreshReport()
        'Me.RepoViewer.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        'Me.RepoViewer.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        'Me.RepoViewer.ZoomPercent = 100
    End Sub

    Private Sub FrmSolicitudImpr_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MsgBox("Salir de la Solicitud de Compra", MsgBoxStyle.YesNo, "SERINTER") = MsgBoxResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
            FrmSolicitudes.bimprimir.Enabled = False
            FrmSolicitudes.tnorden.Focus()
        End If
    End Sub

    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSolicitudImpr))
        Me.SuspendLayout()
        '
        'FrmSolicitudImpr
        '
        Me.ClientSize = New System.Drawing.Size(1226, 563)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmSolicitudImpr"
        Me.ResumeLayout(False)

    End Sub
End Class