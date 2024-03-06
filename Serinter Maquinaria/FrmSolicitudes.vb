Imports System.Data.SqlClient
Imports System.Data
Imports System.Runtime.InteropServices
Public Class FrmSolicitudes
    Private Sub bregresar_Click(sender As Object, e As EventArgs) Handles bregresar.Click
        FrmPrincipal.Show()
        Me.Hide()
        FrmPrincipal.bsolicitudes.Enabled = True
        FrmPrincipal.bordenes.Enabled = True
        FrmPrincipal.busuario.Enabled = True
        FrmPrincipal.bproveedor.Enabled = True
        FrmPrincipal.bgastosmaq.Enabled = True
        FrmPrincipal.binventariado.Enabled = True
    End Sub

    Private Sub rblempiras_CheckedChanged(sender As Object, e As EventArgs) Handles rblempiras.CheckedChanged
        rbdolares.Enabled = False
        rblempiras.Enabled = True
        If rblempiras.Checked = Nothing Then
            rbdolares.Enabled = True
            bagregar.Enabled = False
            limpiarcasillas()
            deshabilitarcasillas()
            Apagarcamposlaterales()
            apagarbotones()
        ElseIf rblempiras.Checked Then
            Encendercamposlaterales()
            encenderbotones()
            tformato.Text = Format(tformato.Text, "0.00  L")
            v1.Text = Format(v1.Text, "0.00  L")
            c1p2.Enabled = True
            c1p3.Enabled = True

            bagregar.Enabled = True
            v1.Enabled = True
            c1.Enabled = True
        End If
    End Sub

    Private Sub rbdolares_CheckedChanged(sender As Object, e As EventArgs) Handles rbdolares.CheckedChanged

        rblempiras.Enabled = False
        rbdolares.Enabled = True
        If rbdolares.Checked = Nothing Then
            rblempiras.Enabled = True
            bagregar.Enabled = False
            limpiarcasillas()
            deshabilitarcasillas()
            Apagarcamposlaterales()
            apagarbotones()
        ElseIf rbdolares.Checked Then
            Encendercamposlaterales()
            encenderbotones()
            tformato.Text = Format(tformato.Text, "0.00")
            v1.Text = Format(v1.Text, "0.00")
            c1p2.Enabled = True
            c1p3.Enabled = True

            bagregar.Enabled = True
            v1.Enabled = True
            c1.Enabled = True
        End If

    End Sub

    Private Sub FrmSolicitudes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tsolicitadopor.Text = FrmPrincipal.lnombres.Text
        Conexion = New SqlConnection
        Conexion.ConnectionString = cadena
        Dim da As New SqlDataAdapter("Select * from proveedores", Conexion)
        Dim dt As New DataTable
        da.Fill(dt)
        tproveedor.DataSource = dt
        tproveedor.DisplayMember = "nom_proveedor"
        tproveedor.ValueMember = "cod_proveedor"
    End Sub

    Private Sub v1_TextChanged(sender As Object, e As EventArgs) Handles v1.TextChanged
        v1d()
        If v1.Text <> "0.00  L" Or "0.00" Then
            v1.Enabled = True
        End If
    End Sub
    Private Sub v1d()
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double
        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text


    End Sub

    Private Sub v2_TextChanged(sender As Object, e As EventArgs) Handles v2.TextChanged
        v2d()
        If v2.Text <> "0.00  L" Or "0.00" Then
            v2.Enabled = True
        End If
    End Sub
    Private Sub v2d()
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double
        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text


    End Sub
    Private Sub v3_TextChanged(sender As Object, e As EventArgs) Handles v3.TextChanged
        v3d()
        If v3.Text <> "0.00  L" Or "0.00" Then
            v3.Enabled = True
        End If
    End Sub
    Private Sub v3d()
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double
        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub
    Private Sub breiniciar_Click(sender As Object, e As EventArgs) Handles breiniciar.Click
        limpiar()
        deshabilitarcasillas()
        tsolicitadopor.Text = FrmPrincipal.lnombres.Text
        mensaje.Text = Nothing
    End Sub
    Private Sub deshabilitarcasillas()
        c1p3.Enabled = False
        c1p2.Enabled = False
        c2p3.Enabled = False
        c2p2.Enabled = False
        c3p3.Enabled = False
        c3p2.Enabled = False
        c4p3.Enabled = False
        c4p2.Enabled = False
        c5p3.Enabled = False
        c5p2.Enabled = False
        c6p3.Enabled = False
        c6p2.Enabled = False
        c7p3.Enabled = False
        c7p2.Enabled = False
        c8p3.Enabled = False
        c8p2.Enabled = False
        c9p3.Enabled = False
        c9p2.Enabled = False
        c10p3.Enabled = False
        c10p2.Enabled = False
        c11p3.Enabled = False
        c11p2.Enabled = False
        c12p3.Enabled = False
        c12p2.Enabled = False
        c13p3.Enabled = False
        c13p2.Enabled = False
        c14p3.Enabled = False
        c14p2.Enabled = False
        c15p3.Enabled = False
        c15p2.Enabled = False
        c16p3.Enabled = False
        c16p2.Enabled = False
        c17p3.Enabled = False
        c17p2.Enabled = False
        c18p3.Enabled = False
        c18p2.Enabled = False
        c19p3.Enabled = False
        c19p2.Enabled = False
        c20p3.Enabled = False
        c20p2.Enabled = False
        c21p3.Enabled = False
        c21p2.Enabled = False
        c22p3.Enabled = False
        c22p2.Enabled = False
        c23p3.Enabled = False
        c23p2.Enabled = False
        c24p3.Enabled = False
        c24p2.Enabled = False
        c25p3.Enabled = False
        c25p2.Enabled = False
        c26p3.Enabled = False
        c26p2.Enabled = False
        c27p3.Enabled = False
        c27p2.Enabled = False
        c28p3.Enabled = False
        c28p2.Enabled = False
        c29p3.Enabled = False
        c29p2.Enabled = False
        c30p3.Enabled = False
        c30p2.Enabled = False
        c31p3.Enabled = False
        c31p2.Enabled = False
        c32p3.Enabled = False
        c32p2.Enabled = False
        c33p3.Enabled = False
        c33p2.Enabled = False
        c34p3.Enabled = False
        c34p2.Enabled = False
        c35p3.Enabled = False
        c35p2.Enabled = False
        c36p3.Enabled = False
        c36p2.Enabled = False
        c37p3.Enabled = False
        c37p2.Enabled = False
        c38p3.Enabled = False
        c38p2.Enabled = False
        c39p3.Enabled = False
        c39p2.Enabled = False
        c40p3.Enabled = False
        c40p2.Enabled = False
        c1.Enabled = False
        v1.Enabled = False
        c2.Enabled = False
        v2.Enabled = False
        c3.Enabled = False
        v3.Enabled = False
        c4.Enabled = False
        v4.Enabled = False
        c5.Enabled = False
        v5.Enabled = False
        c6.Enabled = False
        v6.Enabled = False
        c7.Enabled = False
        v7.Enabled = False
        c8.Enabled = False
        v8.Enabled = False
        c9.Enabled = False
        v9.Enabled = False
        c10.Enabled = False
        v10.Enabled = False
        c11.Enabled = False
        v11.Enabled = False
        c12.Enabled = False
        v12.Enabled = False
        c13.Enabled = False
        v13.Enabled = False
        c14.Enabled = False
        v14.Enabled = False
        c15.Enabled = False
        v15.Enabled = False
        c16.Enabled = False
        v16.Enabled = False
        c17.Enabled = False
        v17.Enabled = False
        c18.Enabled = False
        v18.Enabled = False
        c19.Enabled = False
        v19.Enabled = False
        c20.Enabled = False
        v20.Enabled = False
        c21.Enabled = False
        v21.Enabled = False
        c22.Enabled = False
        v22.Enabled = False
        c23.Enabled = False
        v23.Enabled = False
        c24.Enabled = False
        v24.Enabled = False
        c25.Enabled = False
        v25.Enabled = False
        c26.Enabled = False
        v26.Enabled = False
        c27.Enabled = False
        v27.Enabled = False
        c28.Enabled = False
        v28.Enabled = False
        c29.Enabled = False
        v29.Enabled = False
        c30.Enabled = False
        v30.Enabled = False
        c31.Enabled = False
        v31.Enabled = False
        c32.Enabled = False
        v32.Enabled = False
        c33.Enabled = False
        v33.Enabled = False
        c34.Enabled = False
        v34.Enabled = False
        c35.Enabled = False
        v35.Enabled = False
        c36.Enabled = False
        v36.Enabled = False
        c37.Enabled = False
        v37.Enabled = False
        c38.Enabled = False
        v38.Enabled = False
        c39.Enabled = False
        v39.Enabled = False
        c40.Enabled = False
        v40.Enabled = False
    End Sub
    Private Sub Apagarcamposlaterales()
        tdiae.Enabled = False
        tmese.Enabled = False
        tañoe.Enabled = False
        tdiav.Enabled = False
        tmesv.Enabled = False
        tañov.Enabled = False
        rbchekenormal.Enabled = False
        rbtransferencia.Enabled = False
        rbchequecertificado.Enabled = False
        rbgirobanc.Enabled = False
        tdepartamento.Enabled = False
        tproveedor.Enabled = False
        tcanletras.Enabled = False
        tcargara.Enabled = False
        tproyecto.Enabled = False
        tobservaciones.Enabled = False
    End Sub
    Private Sub Encendercamposlaterales()
        tdiae.Enabled = True
        tmese.Enabled = True
        tañoe.Enabled = True
        tdiav.Enabled = True
        tmesv.Enabled = True
        tañov.Enabled = True
        rbchekenormal.Enabled = True
        rbtransferencia.Enabled = True
        rbchequecertificado.Enabled = True
        rbgirobanc.Enabled = True
        tdepartamento.Enabled = True
        tproveedor.Enabled = True
        tcanletras.Enabled = True
        tcargara.Enabled = True
        tproyecto.Enabled = True
        tobservaciones.Enabled = True
    End Sub
    Private Sub encenderbotones()
        beliminar.Enabled = True
        bimprimir.Enabled = True
        breiniciar.Enabled = True
    End Sub
    Private Sub apagarbotones()
        beliminar.Enabled = False
        bimprimir.Enabled = False
        breiniciar.Enabled = False
    End Sub
    Private Sub limpiarcasillas()
        c1.Text = Nothing
        v1.Text = Nothing
        c2.Text = Nothing
        v2.Text = Nothing
        c3.Text = Nothing
        v3.Text = Nothing
        c4.Text = Nothing
        v4.Text = Nothing
        c5.Text = Nothing
        v5.Text = Nothing
        c6.Text = Nothing
        v6.Text = Nothing
        c7.Text = Nothing
        v7.Text = Nothing
        c8.Text = Nothing
        v8.Text = Nothing
        c9.Text = Nothing
        v9.Text = Nothing
        c10.Text = Nothing
        v10.Text = Nothing
        c11.Text = Nothing
        v11.Text = Nothing
        c12.Text = Nothing
        v12.Text = Nothing
        c13.Text = Nothing
        v13.Text = Nothing
        c14.Text = Nothing
        v14.Text = Nothing
        c15.Text = Nothing
        v15.Text = Nothing
        c16.Text = Nothing
        v16.Text = Nothing
        c17.Text = Nothing
        v17.Text = Nothing
        c18.Text = Nothing
        v18.Text = Nothing
        c19.Text = Nothing
        v19.Text = Nothing
        c20.Text = Nothing
        v20.Text = Nothing
        c21.Text = Nothing
        v21.Text = Nothing
        c22.Text = Nothing
        v22.Text = Nothing
        c23.Text = Nothing
        v23.Text = Nothing
        c24.Text = Nothing
        v24.Text = Nothing
        c25.Text = Nothing
        v25.Text = Nothing
        c26.Text = Nothing
        v26.Text = Nothing
        c27.Text = Nothing
        v27.Text = Nothing
        c28.Text = Nothing
        v28.Text = Nothing
        c29.Text = Nothing
        v29.Text = Nothing
        c30.Text = Nothing
        v30.Text = Nothing
        c31.Text = Nothing
        v31.Text = Nothing
        c32.Text = Nothing
        v32.Text = Nothing
        c33.Text = Nothing
        v33.Text = Nothing
        c34.Text = Nothing
        v34.Text = Nothing
        c35.Text = Nothing
        v35.Text = Nothing
        c36.Text = Nothing
        v36.Text = Nothing
        c37.Text = Nothing
        v37.Text = Nothing
        c38.Text = Nothing
        v38.Text = Nothing
        c39.Text = Nothing
        v39.Text = Nothing
        c40.Text = Nothing
        v40.Text = Nothing
        tformato.Text = Nothing
    End Sub
    Private Sub limpiar()
        tnorden.Text = Nothing
        limpiarparcial()
    End Sub
    Private Sub limpiarparcial()
        rblempiras.Checked = Nothing
        rbdolares.Checked = Nothing
        tdiae.Text = Nothing
        tmese.Text = Nothing
        tañoe.Text = Nothing
        tdiav.Text = Nothing
        tmesv.Text = Nothing
        tañov.Text = Nothing
        rbchekenormal.Checked = Nothing
        rbtransferencia.Checked = Nothing
        rbchequecertificado.Checked = Nothing
        rbgirobanc.Checked = Nothing
        tdepartamento.Text = Nothing
        tproveedor.Text = Nothing
        tcanletras.Text = Nothing
        tcargara.Text = Nothing
        tproyecto.Text = Nothing
        tobservaciones.Text = Nothing
        c1p3.Text = Nothing
        c1p2.Text = Nothing
        c2p3.Text = Nothing
        c2p2.Text = Nothing
        c3p3.Text = Nothing
        c3p2.Text = Nothing
        c4p3.Text = Nothing
        c4p2.Text = Nothing
        c5p3.Text = Nothing
        c5p2.Text = Nothing
        c6p3.Text = Nothing
        c6p2.Text = Nothing
        c7p3.Text = Nothing
        c7p2.Text = Nothing
        c8p3.Text = Nothing
        c8p2.Text = Nothing
        c9p3.Text = Nothing
        c9p2.Text = Nothing
        c10p3.Text = Nothing
        c10p2.Text = Nothing
        c11p3.Text = Nothing
        c11p2.Text = Nothing
        c12p3.Text = Nothing
        c12p2.Text = Nothing
        c13p3.Text = Nothing
        c13p2.Text = Nothing
        c14p3.Text = Nothing
        c14p2.Text = Nothing
        c15p3.Text = Nothing
        c15p2.Text = Nothing
        c16p3.Text = Nothing
        c16p2.Text = Nothing
        c17p3.Text = Nothing
        c17p2.Text = Nothing
        c18p3.Text = Nothing
        c18p2.Text = Nothing
        c19p3.Text = Nothing
        c19p2.Text = Nothing
        c20p3.Text = Nothing
        c20p2.Text = Nothing
        c21p3.Text = Nothing
        c21p2.Text = Nothing
        c22p3.Text = Nothing
        c22p2.Text = Nothing
        c23p3.Text = Nothing
        c23p2.Text = Nothing
        c24p3.Text = Nothing
        c24p2.Text = Nothing
        c25p3.Text = Nothing
        c25p2.Text = Nothing
        c26p3.Text = Nothing
        c26p2.Text = Nothing
        c27p3.Text = Nothing
        c27p2.Text = Nothing
        c28p3.Text = Nothing
        c28p2.Text = Nothing
        c29p3.Text = Nothing
        c29p2.Text = Nothing
        c30p3.Text = Nothing
        c30p2.Text = Nothing
        c31p3.Text = Nothing
        c31p2.Text = Nothing
        c32p3.Text = Nothing
        c32p2.Text = Nothing
        c33p3.Text = Nothing
        c33p2.Text = Nothing
        c34p3.Text = Nothing
        c34p2.Text = Nothing
        c35p3.Text = Nothing
        c35p2.Text = Nothing
        c36p3.Text = Nothing
        c36p2.Text = Nothing
        c37p3.Text = Nothing
        c37p2.Text = Nothing
        c38p3.Text = Nothing
        c38p2.Text = Nothing
        c39p3.Text = Nothing
        c39p2.Text = Nothing
        c40p3.Text = Nothing
        c40p2.Text = Nothing
        c1.Text = Nothing
        v1.Text = Nothing
        c2.Text = Nothing
        v2.Text = Nothing
        c3.Text = Nothing
        v3.Text = Nothing
        c4.Text = Nothing
        v4.Text = Nothing
        c5.Text = Nothing
        v5.Text = Nothing
        c6.Text = Nothing
        v6.Text = Nothing
        c7.Text = Nothing
        v7.Text = Nothing
        c8.Text = Nothing
        v8.Text = Nothing
        c9.Text = Nothing
        v9.Text = Nothing
        c10.Text = Nothing
        v10.Text = Nothing
        c11.Text = Nothing
        v11.Text = Nothing
        c12.Text = Nothing
        v12.Text = Nothing
        c13.Text = Nothing
        v13.Text = Nothing
        c14.Text = Nothing
        v14.Text = Nothing
        c15.Text = Nothing
        v15.Text = Nothing
        c16.Text = Nothing
        v16.Text = Nothing
        c17.Text = Nothing
        v17.Text = Nothing
        c18.Text = Nothing
        v18.Text = Nothing
        c19.Text = Nothing
        v19.Text = Nothing
        c20.Text = Nothing
        v20.Text = Nothing
        c21.Text = Nothing
        v21.Text = Nothing
        c22.Text = Nothing
        v22.Text = Nothing
        c23.Text = Nothing
        v23.Text = Nothing
        c24.Text = Nothing
        v24.Text = Nothing
        c25.Text = Nothing
        v25.Text = Nothing
        c26.Text = Nothing
        v26.Text = Nothing
        c27.Text = Nothing
        v27.Text = Nothing
        c28.Text = Nothing
        v28.Text = Nothing
        c29.Text = Nothing
        v29.Text = Nothing
        c30.Text = Nothing
        v30.Text = Nothing
        c31.Text = Nothing
        v31.Text = Nothing
        c32.Text = Nothing
        v32.Text = Nothing
        c33.Text = Nothing
        v33.Text = Nothing
        c34.Text = Nothing
        v34.Text = Nothing
        c35.Text = Nothing
        v35.Text = Nothing
        c36.Text = Nothing
        v36.Text = Nothing
        c37.Text = Nothing
        v37.Text = Nothing
        c38.Text = Nothing
        v38.Text = Nothing
        c39.Text = Nothing
        v39.Text = Nothing
        c40.Text = Nothing
        v40.Text = Nothing
        tformato.Text = Nothing
        tdesc.Text = 0
        treten.Text = 0
    End Sub

    Private Sub v4_TextChanged(sender As Object, e As EventArgs) Handles v4.TextChanged
        v4d()
        If v4.Text <> "0.00  L" Or "0.00" Then
            v4.Enabled = True
        End If
    End Sub
    Private Sub v4d()
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double
        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub v5_TextChanged(sender As Object, e As EventArgs) Handles v5.TextChanged
        v5d()
        If v5.Text <> "0.00  L" Or "0.00" Then
            v5.Enabled = True
        End If
    End Sub
    Private Sub v5d()
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double
        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub v6_TextChanged(sender As Object, e As EventArgs) Handles v6.TextChanged
        v6d()
        If v6.Text <> "0.00  L" Or "0.00" Then
            v6.Enabled = True
        End If
    End Sub
    Private Sub v6d()
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double
      
        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text
 
    End Sub

    Private Sub v7_TextChanged(sender As Object, e As EventArgs) Handles v7.TextChanged
        v7d()
        If v7.Text <> "0.00  L" Or "0.00" Then
            v7.Enabled = True
        End If
    End Sub
    Private Sub v7d()
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double
        
        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text
  
    End Sub

    Private Sub v8_TextChanged(sender As Object, e As EventArgs) Handles v8.TextChanged
        v8d()
        If v8.Text <> "0.00  L" Or "0.00" Then
            v8.Enabled = True
        End If
    End Sub
    Private Sub v8d()
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double
       
        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub v9_TextChanged(sender As Object, e As EventArgs) Handles v9.TextChanged
        v9d()
        If v9.Text <> "0.00  L" Or "0.00" Then
            v9.Enabled = True
        End If
    End Sub
    Private Sub v9d()
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double
        
        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text
 
    End Sub

    Private Sub v10_TextChanged(sender As Object, e As EventArgs) Handles v10.TextChanged
        v10d()
        If v10.Text <> "0.00  L" Or "0.00" Then
            v10.Enabled = True
        End If
    End Sub
    Private Sub v10d()
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double
       
        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text
 
    End Sub

    Private Sub v11_TextChanged(sender As Object, e As EventArgs) Handles v11.TextChanged
        v11d()
        If v11.Text <> "0.00  L" Or "0.00" Then
            v11.Enabled = True
        End If
    End Sub
    Private Sub v11d()
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double
       
        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text
       
    End Sub

    Private Sub v12_TextChanged(sender As Object, e As EventArgs) Handles v12.TextChanged
        v12d()
        If v12.Text <> "0.00  L" Or "0.00" Then
            v12.Enabled = True
        End If
    End Sub
    Private Sub v12d()
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double
       
        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub v13_TextChanged(sender As Object, e As EventArgs) Handles v13.TextChanged
        v13d()
        If v13.Text <> "0.00  L" Or "0.00" Then
            v13.Enabled = True
        End If
    End Sub
    Private Sub v13d()
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double
       
        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub v14_TextChanged(sender As Object, e As EventArgs) Handles v14.TextChanged
        v14d()
        If v14.Text <> "0.00  L" Or "0.00" Then
            v14.Enabled = True
        End If
    End Sub
    Private Sub v14d()
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double
       
        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub v15_TextChanged(sender As Object, e As EventArgs) Handles v15.TextChanged
        v15d()
        If v15.Text <> "0.00  L" Or "0.00" Then
            v15.Enabled = True
        End If
    End Sub

    Private Sub v15d()
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double
        
        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text
 
    End Sub
    Private Sub v16_TextChanged(sender As Object, e As EventArgs) Handles v16.TextChanged
        v16d()
        If v16.Text <> "0.00  L" Or "0.00" Then
            v16.Enabled = True
        End If
    End Sub
    Private Sub v16d()
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double
      
        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text
  
    End Sub
    Private Sub v17_TextChanged(sender As Object, e As EventArgs) Handles v17.TextChanged
        v17d()
        If v17.Text <> "0.00  L" Or "0.00" Then
            v17.Enabled = True
        End If
    End Sub
    Private Sub v17d()
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double
       
        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text
    
    End Sub

    Private Sub v18_TextChanged(sender As Object, e As EventArgs) Handles v18.TextChanged
        v18d()
        If v18.Text <> "0.00  L" Or "0.00" Then
            v18.Enabled = True
        End If
    End Sub
    Private Sub v18d()
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double
       
        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text
  
    End Sub

    Private Sub v19_TextChanged(sender As Object, e As EventArgs) Handles v19.TextChanged
        v19d()
        If v19.Text <> "0.00  L" Or "0.00" Then
            v19.Enabled = True
        End If
    End Sub

    Private Sub v19d()
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double
       
        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text
      
    End Sub
    Private Sub v20_TextChanged(sender As Object, e As EventArgs) Handles v20.TextChanged
        v20d()
        If v20.Text <> "0.00  L" Or "0.00" Then
            v20.Enabled = True
        End If
    End Sub
    Private Sub v20d()
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double
       
        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text
   
    End Sub
    Private Sub v21_TextChanged(sender As Object, e As EventArgs) Handles v21.TextChanged
        v21d()
        If v21.Text <> "0.00  L" Or "0.00" Then
            v21.Enabled = True
        End If
    End Sub
    Private Sub v21d()
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double
       
        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text
    
    End Sub

    Private Sub v22_TextChanged(sender As Object, e As EventArgs) Handles v22.TextChanged
        v22d()
        If v22.Text <> "0.00  L" Or "0.00" Then
            v22.Enabled = True
        End If
    End Sub
    Private Sub v22d()
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double
       
        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text
    
    End Sub

    Private Sub v23_TextChanged(sender As Object, e As EventArgs) Handles v23.TextChanged
        v23d()
        If v23.Text <> "0.00  L" Or "0.00" Then
            v23.Enabled = True
        End If
    End Sub
    Private Sub v23d()
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double
       
        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text
       
    End Sub

    Private Sub v24_TextChanged(sender As Object, e As EventArgs) Handles v24.TextChanged
        v24d()
        If v24.Text <> "0.00  L" Or "0.00" Then
            v24.Enabled = True
        End If
    End Sub
    Private Sub v24d()
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double
       
        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text
     
    End Sub

    Private Sub v25_TextChanged(sender As Object, e As EventArgs) Handles v25.TextChanged
        v25d()
        If v25.Text <> "0.00  L" Or "0.00" Then
            v25.Enabled = True
        End If
    End Sub
    Private Sub v25d()
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double
       
        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text
     
    End Sub

    Private Sub v26_TextChanged(sender As Object, e As EventArgs) Handles v26.TextChanged
        v26d()
        If v26.Text <> "0.00  L" Or "0.00" Then
            v26.Enabled = True
        End If
    End Sub
    Private Sub v26d()
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double
       
        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text
      
    End Sub

    Private Sub v27_TextChanged(sender As Object, e As EventArgs) Handles v27.TextChanged
        v27d()
        If v27.Text <> "0.00  L" Or "0.00" Then
            v27.Enabled = True
        End If
    End Sub
    Private Sub v27d()
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double
        
        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text
    
    End Sub

    Private Sub v28_TextChanged(sender As Object, e As EventArgs) Handles v28.TextChanged
        v28d()
        If v28.Text <> "0.00  L" Or "0.00" Then
            v28.Enabled = True
        End If
    End Sub
    Private Sub v28d()
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double
        
        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub v29_TextChanged(sender As Object, e As EventArgs) Handles v29.TextChanged
        v29d()
        If v29.Text <> "0.00  L" Or "0.00" Then
            v29.Enabled = True
        End If
    End Sub
    Private Sub v29d()
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double
       
        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text
     
    End Sub

    Private Sub v30_TextChanged(sender As Object, e As EventArgs) Handles v30.TextChanged
        v30d()
        If v30.Text <> "0.00  L" Or "0.00" Then
            v30.Enabled = True
        End If
    End Sub
    Private Sub v30d()
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double
        
        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text
 
    End Sub

    Private Sub v31_TextChanged(sender As Object, e As EventArgs) Handles v31.TextChanged
        v31d()
        If v31.Text <> "0.00  L" Or "0.00" Then
            v31.Enabled = True
        End If
    End Sub
    Private Sub v31d()
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double
       
        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text
  
    End Sub

    Private Sub v32_TextChanged(sender As Object, e As EventArgs) Handles v32.TextChanged
        v32d()
        If v32.Text <> "0.00  L" Or "0.00" Then
            v32.Enabled = True
        End If
    End Sub
    Private Sub v32d()
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double
        
        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub v33_TextChanged(sender As Object, e As EventArgs) Handles v33.TextChanged
        v33d()
        If v33.Text <> "0.00  L" Or "0.00" Then
            v33.Enabled = True
        End If
    End Sub
    Private Sub v33d()
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double
        
        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text
       
    End Sub

    Private Sub v34_TextChanged(sender As Object, e As EventArgs) Handles v34.TextChanged
        v34d()
        If v34.Text <> "0.00  L" Or "0.00" Then
            v34.Enabled = True
        End If
    End Sub
    Private Sub v34d()
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double
        
        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text
 
    End Sub

    Private Sub v35_TextChanged(sender As Object, e As EventArgs) Handles v35.TextChanged
        v35d()
        If v35.Text <> "0.00  L" Or "0.00" Then
            v35.Enabled = True
        End If
    End Sub

    Private Sub v35d()
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double
       
        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text
      
    End Sub
    Private Sub v36_TextChanged(sender As Object, e As EventArgs) Handles v36.TextChanged
        v36d()
        If v36.Text <> "0.00  L" Or "0.00" Then
            v36.Enabled = True
        End If
    End Sub
    Private Sub v36d()
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double
       
        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text
    End Sub

    Private Sub v37_TextChanged(sender As Object, e As EventArgs) Handles v37.TextChanged
        v37d()
        If v37.Text <> "0.00  L" Or "0.00" Then
            v37.Enabled = True
        End If
    End Sub
    Private Sub v37d()
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double
       
        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text
  
    End Sub

    Private Sub v38_TextChanged(sender As Object, e As EventArgs) Handles v38.TextChanged
        v38d()
        If v38.Text <> "0.00  L" Or "0.00" Then
            v38.Enabled = True
        End If
    End Sub
    Private Sub v38d()
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double
       
        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub v39_TextChanged(sender As Object, e As EventArgs) Handles v39.TextChanged
        v39d()
        If v39.Text <> "0.00  L" Or "0.00" Then
            v39.Enabled = True
        End If
    End Sub
    Private Sub v39d()
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double
      
        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text
     
    End Sub

    Private Sub v40_TextChanged(sender As Object, e As EventArgs) Handles v40.TextChanged
        v40d()
        If v40.Text <> "0.00  L" Or "0.00" Then
            v40.Enabled = True
        End If
    End Sub
    Private Sub v40d()
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double
        
        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text
    End Sub

    Private Sub tnorden_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tnorden.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tnorden_Validated(sender, e)
        End If
    End Sub

    Private Sub tdepartamento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tdepartamento.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tproveedor.Focus()
        End If
    End Sub
    Private Sub tproveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tproveedor.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tcanletras.Focus()
        End If
    End Sub
    Private Sub tcanletras_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tcanletras.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tcargara.Focus()
        End If
    End Sub

    Private Sub tcargara_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tcargara.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tproyecto.Focus()
        End If
    End Sub

    Private Sub tproyecto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tproyecto.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            tobservaciones.Focus()
        End If
    End Sub

    Private Sub tobservaciones_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tobservaciones.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c1p3.Focus()
        End If
    End Sub

    Private Sub c1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c1.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            v1.Focus()
        End If
    End Sub

    Private Sub v1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles v1.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c2p3.Focus()
        End If
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            mensaje.Text = "Solo Puede Digitar Numeros"
       
        End If
        If v1.Text = "0.00" Or "0.00  L" Then

        ElseIf v1.Text Then
            c2.Enabled = True
            v2.Enabled = True
            c2p2.Enabled = True
            c2p3.Enabled = True

            v2.Text = tformato.Text
        End If
    End Sub

    Private Sub c2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c2.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            v2.Focus()
        End If
    End Sub

    Private Sub v2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles v2.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c3p3.Focus()
        End If
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            mensaje.Text = "Solo Puede Digitar Numeros"

        End If
        If v2.Text = "0.00" Or "0.00  L" Then

        ElseIf v2.Text Then
            c3.Enabled = True
            v3.Enabled = True
            c3p2.Enabled = True
            c3p3.Enabled = True

            v3.Text = tformato.Text
        End If
    End Sub

    Private Sub c3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c3.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            v3.Focus()
        End If
    End Sub

    Private Sub v3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles v3.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c4p3.Focus()
        End If
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            mensaje.Text = "Solo Puede Digitar Numeros"
        End If
    End Sub

    Private Sub c4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c4.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            v4.Focus()
        End If
    End Sub

    Private Sub v4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles v4.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c5p3.Focus()
        End If
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            mensaje.Text = "Solo Puede Digitar Numeros"
        End If
    End Sub

    Private Sub c5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c5.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            v5.Focus()
        End If
    End Sub

    Private Sub v5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles v5.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c6p3.Focus()
        End If
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            mensaje.Text = "Solo Puede Digitar Numeros"
        End If
    End Sub

    Private Sub c6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c6.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            v6.Focus()
        End If
    End Sub

    Private Sub v6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles v6.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c7p3.Focus()
        End If
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            mensaje.Text = "Solo Puede Digitar Numeros"
        End If
    End Sub

    Private Sub c7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c7.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            v7.Focus()
        End If
    End Sub

    Private Sub v7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles v7.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c8p3.Focus()
        End If
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            mensaje.Text = "Solo Puede Digitar Numeros"
        End If
    End Sub

    Private Sub c8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c8.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            v8.Focus()
        End If
    End Sub

    Private Sub v8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles v8.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c9p3.Focus()
        End If
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            mensaje.Text = "Solo Puede Digitar Numeros"
        End If
    End Sub

    Private Sub c9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c9.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            v9.Focus()
        End If
    End Sub

    Private Sub v9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles v9.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c10p3.Focus()
        End If
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            mensaje.Text = "Solo Puede Digitar Numeros"
        End If
    End Sub

    Private Sub c10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c10.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            v10.Focus()
        End If
    End Sub

    Private Sub v10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles v10.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c11p3.Focus()
        End If
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            mensaje.Text = "Solo Puede Digitar Numeros"
        End If
    End Sub

    Private Sub c11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c11.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            v11.Focus()
        End If
    End Sub

    Private Sub v11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles v11.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c12p3.Focus()
        End If
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            mensaje.Text = "Solo Puede Digitar Numeros"
        End If
    End Sub

    Private Sub c12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c12.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            v12.Focus()
        End If
    End Sub

    Private Sub v12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles v12.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c13p3.Focus()
        End If
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            mensaje.Text = "Solo Puede Digitar Numeros"
        End If
    End Sub

    Private Sub c13_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c13.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            v13.Focus()
        End If
    End Sub

    Private Sub v13_KeyPress(sender As Object, e As KeyPressEventArgs) Handles v13.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c14p3.Focus()
        End If
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            mensaje.Text = "Solo Puede Digitar Numeros"
        End If
    End Sub

    Private Sub c14_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c14.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            v14.Focus()
        End If
    End Sub

    Private Sub v14_KeyPress(sender As Object, e As KeyPressEventArgs) Handles v14.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c15p3.Focus()
        End If
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            mensaje.Text = "Solo Puede Digitar Numeros"
        End If
    End Sub

    Private Sub c15_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c15.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            v15.Focus()
        End If
    End Sub

    Private Sub v15_KeyPress(sender As Object, e As KeyPressEventArgs) Handles v15.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c16p3.Focus()
        End If
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            mensaje.Text = "Solo Puede Digitar Numeros"
        End If
    End Sub

    Private Sub c16_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c16.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            v16.Focus()
        End If
    End Sub

    Private Sub v16_KeyPress(sender As Object, e As KeyPressEventArgs) Handles v16.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c17p3.Focus()
        End If
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            mensaje.Text = "Solo Puede Digitar Numeros"
        End If
    End Sub

    Private Sub c17_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c17.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            v17.Focus()
        End If
    End Sub

    Private Sub v17_KeyPress(sender As Object, e As KeyPressEventArgs) Handles v17.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c18p3.Focus()
        End If
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            mensaje.Text = "Solo Puede Digitar Numeros"
        End If
    End Sub

    Private Sub c18_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c18.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            v18.Focus()
        End If
    End Sub

    Private Sub v18_KeyPress(sender As Object, e As KeyPressEventArgs) Handles v18.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c19p3.Focus()
        End If
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            mensaje.Text = "Solo Puede Digitar Numeros"
        End If
    End Sub

    Private Sub c19_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c19.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            v19.Focus()
        End If
    End Sub

    Private Sub v19_KeyPress(sender As Object, e As KeyPressEventArgs) Handles v19.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c20p3.Focus()
        End If
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            mensaje.Text = "Solo Puede Digitar Numeros"
        End If
    End Sub

    Private Sub c20_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c20.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            v20.Focus()
        End If
    End Sub

    Private Sub v20_KeyPress(sender As Object, e As KeyPressEventArgs) Handles v20.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c21p3.Focus()
        End If
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            mensaje.Text = "Solo Puede Digitar Numeros"
        End If
    End Sub

    Private Sub c21_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c21.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            v21.Focus()
        End If
    End Sub

    Private Sub v21_KeyPress(sender As Object, e As KeyPressEventArgs) Handles v21.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c22p3.Focus()
        End If
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            mensaje.Text = "Solo Puede Digitar Numeros"
        End If
    End Sub

    Private Sub c22_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c22.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            v22.Focus()
        End If
    End Sub

    Private Sub v22_KeyPress(sender As Object, e As KeyPressEventArgs) Handles v22.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c23p3.Focus()
        End If
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            mensaje.Text = "Solo Puede Digitar Numeros"
        End If
    End Sub

    Private Sub c23_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c23.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            v23.Focus()
        End If
    End Sub

    Private Sub v23_KeyPress(sender As Object, e As KeyPressEventArgs) Handles v23.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c24p3.Focus()
        End If
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            mensaje.Text = "Solo Puede Digitar Numeros"
        End If
    End Sub

    Private Sub c24_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c24.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            v24.Focus()
        End If
    End Sub

    Private Sub v24_KeyPress(sender As Object, e As KeyPressEventArgs) Handles v24.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c25p3.Focus()
        End If
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            mensaje.Text = "Solo Puede Digitar Numeros"
        End If
    End Sub

    Private Sub c25_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c25.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            v25.Focus()
        End If
    End Sub

    Private Sub v25_KeyPress(sender As Object, e As KeyPressEventArgs) Handles v25.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c26p3.Focus()
        End If
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            mensaje.Text = "Solo Puede Digitar Numeros"
        End If
    End Sub

    Private Sub c26_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c26.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            v26.Focus()
        End If
    End Sub

    Private Sub v26_KeyPress(sender As Object, e As KeyPressEventArgs) Handles v26.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c27p3.Focus()
        End If
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            mensaje.Text = "Solo Puede Digitar Numeros"
        End If
    End Sub

    Private Sub c27_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c27.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            v27.Focus()
        End If
    End Sub

    Private Sub v27_KeyPress(sender As Object, e As KeyPressEventArgs) Handles v27.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c28p3.Focus()
        End If
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            mensaje.Text = "Solo Puede Digitar Numeros"
        End If
    End Sub

    Private Sub c28_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c28.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            v28.Focus()
        End If
    End Sub

    Private Sub v28_KeyPress(sender As Object, e As KeyPressEventArgs) Handles v28.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c29p3.Focus()
        End If
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            mensaje.Text = "Solo Puede Digitar Numeros"
        End If
    End Sub

    Private Sub c29_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c29.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            v29.Focus()
        End If
    End Sub

    Private Sub v29_KeyPress(sender As Object, e As KeyPressEventArgs) Handles v29.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c30p3.Focus()
        End If
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            mensaje.Text = "Solo Puede Digitar Numeros"
        End If
    End Sub

    Private Sub c30_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c30.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            v30.Focus()
        End If
    End Sub

    Private Sub v30_KeyPress(sender As Object, e As KeyPressEventArgs) Handles v30.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c31p3.Focus()
        End If
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            mensaje.Text = "Solo Puede Digitar Numeros"
        End If
    End Sub

    Private Sub c31_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c31.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            v31.Focus()
        End If
    End Sub

    Private Sub v31_KeyPress(sender As Object, e As KeyPressEventArgs) Handles v31.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c32p3.Focus()
        End If
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            mensaje.Text = "Solo Puede Digitar Numeros"
        End If
    End Sub

    Private Sub c32_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c32.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            v32.Focus()
        End If
    End Sub

    Private Sub v32_KeyPress(sender As Object, e As KeyPressEventArgs) Handles v32.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c33p3.Focus()
        End If
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            mensaje.Text = "Solo Puede Digitar Numeros"
        End If
    End Sub

    Private Sub c33_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c33.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            v33.Focus()
        End If
    End Sub

    Private Sub v33_KeyPress(sender As Object, e As KeyPressEventArgs) Handles v33.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c34p3.Focus()
        End If
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            mensaje.Text = "Solo Puede Digitar Numeros"
        End If
    End Sub

    Private Sub c34_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c34.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            v34.Focus()
        End If
    End Sub

    Private Sub v34_KeyPress(sender As Object, e As KeyPressEventArgs) Handles v34.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c35p3.Focus()
        End If
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            mensaje.Text = "Solo Puede Digitar Numeros"
        End If
    End Sub

    Private Sub c35_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c35.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            v35.Focus()
        End If
    End Sub

    Private Sub v35_KeyPress(sender As Object, e As KeyPressEventArgs) Handles v35.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c36p3.Focus()
        End If
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            mensaje.Text = "Solo Puede Digitar Numeros"
        End If
    End Sub

    Private Sub c36_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c36.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            v36.Focus()
        End If
    End Sub

    Private Sub v36_KeyPress(sender As Object, e As KeyPressEventArgs) Handles v36.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c37p3.Focus()
        End If
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            mensaje.Text = "Solo Puede Digitar Numeros"
        End If
    End Sub

    Private Sub c37_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c37.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            v37.Focus()
        End If
    End Sub

    Private Sub v37_KeyPress(sender As Object, e As KeyPressEventArgs) Handles v37.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c38p3.Focus()
        End If
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            mensaje.Text = "Solo Puede Digitar Numeros"
        End If
    End Sub

    Private Sub c38_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c38.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            v38.Focus()
        End If
    End Sub

    Private Sub v38_KeyPress(sender As Object, e As KeyPressEventArgs) Handles v38.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c39p3.Focus()
        End If
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            mensaje.Text = "Solo Puede Digitar Numeros"
        End If
    End Sub

    Private Sub c39_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c39.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            v39.Focus()
        End If
    End Sub

    Private Sub v39_KeyPress(sender As Object, e As KeyPressEventArgs) Handles v39.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c40p3.Focus()
        End If
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            mensaje.Text = "Solo Puede Digitar Numeros"
        End If
    End Sub

    Private Sub c40_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c40.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            v40.Focus()
        End If
    End Sub

    Private Sub v40_KeyPress(sender As Object, e As KeyPressEventArgs) Handles v40.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            bagregar.Focus()
        End If
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            mensaje.Text = "Solo Puede Digitar Numeros"
        End If
    End Sub

    Private Sub bagregar_Click(sender As Object, e As EventArgs) Handles bagregar.Click
        'este proyecto es en memoria de mi perrita cachi
        Dim tipomoneda As String
        Dim tipotransc As String
        If rblempiras.Checked = True Then
            tipomoneda = "Lempiras"
        ElseIf rbdolares.Checked = True Then
            tipomoneda = "Dolares"
        Else
            mensaje.Text = "Seleccione el Tipo de Moneda"
        End If
        If rbchekenormal.Checked = True Then
            tipotransc = "Cheque Normal"
        ElseIf rbtransferencia.Checked = True Then
            tipotransc = "Transferencia"
        ElseIf rbchequecertificado.Checked = True Then
            tipotransc = "Cheque Certificado"
        ElseIf rbgirobanc.Checked = True Then
            tipotransc = "Giro Bancario"
        End If

        If tnorden.Text = Nothing Then
            mensaje.Text = "Dejo vacia la orden"
            tnorden.Focus()
            Exit Sub
        ElseIf tdepartamento.Text = Nothing Then
            mensaje.Text = "Dejo vacio el departamento"
            tdepartamento.Focus()
            Exit Sub
        ElseIf tproveedor.Text = Nothing Then
            mensaje.Text = "Dejo vacio el proveedor del campo paguese"
            tproveedor.Focus()
            Exit Sub
        ElseIf tcanletras.Text = Nothing Then
            mensaje.Text = "Dejo vacio la cantidad en Letras"
            tcanletras.Focus()
            Exit Sub
        ElseIf tcargara.Text = Nothing Then
            mensaje.Text = "Dejo vacio el campo de cargara"
            tcargara.Focus()
            Exit Sub
        ElseIf tproyecto.Text = Nothing Then
            mensaje.Text = "Dejo vacio el campo de proyecto"
            tproyecto.Focus()
            Exit Sub
        ElseIf tobservaciones.Text = Nothing Then
            mensaje.Text = "Dejo vacio la Observacion"
            tproyecto.Focus()
            Exit Sub
        ElseIf tdiae.Text = Nothing Then
            mensaje.Text = "Dejo vacio el dia de emision"
            tdiae.Focus()
            Exit Sub
        ElseIf tmese.Text = Nothing Then
            mensaje.Text = "Dejo vacio el mes de emision"
            tmese.Focus()
            Exit Sub
        ElseIf tañoe.Text = Nothing Then
            mensaje.Text = "Dejo vacio el año de emision"
            tañoe.Focus()
            Exit Sub
        ElseIf tdiav.Text = Nothing Then
            mensaje.Text = "Dejo vacio el dia de vencimiento"
            tdiav.Focus()
            Exit Sub
        ElseIf tmesv.Text = Nothing Then
            mensaje.Text = "Dejo vacio el mes de vencimiento"
            tmesv.Focus()
            Exit Sub
        ElseIf tañov.Text = Nothing Then
            mensaje.Text = "Dejo vacio el año de vencimiento"
            tañov.Focus()
            Exit Sub
        ElseIf c1.Text = "-UND-" Then
            mensaje.Text = "Ingrese un dato inicial"
            c1.Focus()
            Exit Sub
        ElseIf v1.Text = "0.00" Or "0.00  L" Then
            mensaje.Text = "Ingrese un valor inicial"
            v1.Focus()
            Exit Sub
        End If
        sql = "select * from ordenes where num_orden='" & tnorden.Text & "'"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "ordenes")
            resultado = almacen.Tables("ordenes").Rows.Count
            If resultado > 0 Then
                sql = "Update ordenes set tipomoneda='" & tipomoneda & "',tipotransaccion='" & tipotransc & "',"
                sql += "solicitado_por='" & tsolicitadopor.Text & "',departamento='" & tdepartamento.Text & "',nom_proveedor='" & tproveedor.Text & "',can_letras='" & tcanletras.Text & "',cargar='" & tcargara.Text & "',proyecto='" & tproyecto.Text & "',"
                sql += "observaciones='" & tobservaciones.Text & "',dia='" & tdiae.Text & "',mes='" & tmese.Text & "',año='" & tañoe.Text & "',dia2='" & tdiav.Text & "',mes2='" & tmesv.Text & "',año2='" & tañov.Text & "',"
                sql += "c1='" & c1.Text & "',v1='" & v1.Text & "',c2='" & c2.Text & "',v2='" & v2.Text & "',c3='" & c3.Text & "',v3='" & v3.Text & "',c4='" & c4.Text & "',v4='" & v4.Text & "',c5='" & c5.Text & "',v5='" & v5.Text & "',c6='" & c6.Text & "',v6='" & v6.Text & "',c7='" & c7.Text & "',v7='" & v7.Text & "',c8='" & c8.Text & "',v8='" & v8.Text & "',c9='" & c9.Text & "',v9='" & v9.Text & "',c10='" & c10.Text & "',v10='" & v10.Text & "',"
                sql += "c11='" & c11.Text & "',v11='" & v11.Text & "',c12='" & c12.Text & "',v12='" & v12.Text & "',c13='" & c13.Text & "',v13='" & v13.Text & "',c14='" & c14.Text & "',v14='" & v14.Text & "',c15='" & c15.Text & "',v15='" & v15.Text & "',c16='" & c16.Text & "',v16='" & v16.Text & "',c17='" & c17.Text & "',v17='" & v17.Text & "',c18='" & c18.Text & "',v18='" & v18.Text & "',c19='" & c19.Text & "',v19='" & v19.Text & "',c20='" & c20.Text & "',v20='" & v20.Text & "',"
                sql += "c21='" & c21.Text & "',v21='" & v21.Text & "',c22='" & c22.Text & "',v22='" & v22.Text & "',c23='" & c23.Text & "',v23='" & v23.Text & "',c24='" & c24.Text & "',v24='" & v24.Text & "',c25='" & c25.Text & "',v25='" & v25.Text & "',c26='" & c26.Text & "',v26='" & v26.Text & "',c27='" & c27.Text & "',v27='" & v27.Text & "',c28='" & c28.Text & "',v28='" & v28.Text & "',c29='" & c29.Text & "',v29='" & v29.Text & "',c30='" & c30.Text & "',v30='" & v30.Text & "',"
                sql += "c31='" & c31.Text & "',v31='" & v31.Text & "',c32='" & c32.Text & "',v32='" & v32.Text & "',c33='" & c33.Text & "',v33='" & v33.Text & "',c34='" & c34.Text & "',v34='" & v34.Text & "',c35='" & c35.Text & "',v35='" & v35.Text & "',c36='" & c36.Text & "',v36='" & v36.Text & "',c37='" & c37.Text & "',v37='" & v37.Text & "',c38='" & c38.Text & "',v38='" & v38.Text & "',c39='" & c39.Text & "',v39='" & v39.Text & "',c40='" & c40.Text & "',v40='" & v40.Text & "',"
                sql += "cantidad1='" & c1p3.Text & "',unidad1='" & c1p2.Text & "',cantidad2='" & c2p3.Text & "',unidad2='" & c2p2.Text & "',cantidad3='" & c3p3.Text & "',unidad3='" & c3p2.Text & "',cantidad4='" & c4p3.Text & "',unidad4='" & c4p2.Text & "',cantidad5='" & c5p3.Text & "',unidad5='" & c5p2.Text & "',cantidad6='" & c6p3.Text & "',unidad6='" & c6p2.Text & "',cantidad7='" & c7p3.Text & "',unidad7='" & c7p2.Text & "',cantidad8='" & c8p3.Text & "',unidad8='" & c8p2.Text & "',cantidad9='" & c9p3.Text & "',unidad9='" & c9p2.Text & "',cantidad10='" & c10p3.Text & "',unidad10='" & c10p2.Text & "',"
                sql += "cantidad11='" & c11p3.Text & "',unidad11='" & c11p2.Text & "',cantidad12='" & c12p3.Text & "',unidad12='" & c12p2.Text & "',cantidad13='" & c13p3.Text & "',unidad13='" & c13p2.Text & "',cantidad14='" & c14p3.Text & "',unidad14='" & c14p2.Text & "',cantidad15='" & c15p3.Text & "',unidad15='" & c15p2.Text & "',cantidad16='" & c16p3.Text & "',unidad16='" & c16p2.Text & "',cantidad17='" & c17p3.Text & "',unidad17='" & c17p2.Text & "',cantidad18='" & c18p3.Text & "',unidad18='" & c18p2.Text & "',cantidad19='" & c19p3.Text & "',unidad19='" & c19p2.Text & "',cantidad20='" & c20p3.Text & "',unidad20='" & c20p2.Text & "',"
                sql += "cantidad21='" & c21p3.Text & "',unidad21='" & c21p2.Text & "',cantidad22='" & c22p3.Text & "',unidad22='" & c22p2.Text & "',cantidad23='" & c23p3.Text & "',unidad23='" & c23p2.Text & "',cantidad24='" & c24p3.Text & "',unidad24='" & c24p2.Text & "',cantidad25='" & c25p3.Text & "',unidad25='" & c25p2.Text & "',cantidad26='" & c26p3.Text & "',unidad26='" & c26p2.Text & "',cantidad27='" & c27p3.Text & "',unidad27='" & c27p2.Text & "',cantidad28='" & c28p3.Text & "',unidad28='" & c28p2.Text & "',cantidad29='" & c29p3.Text & "',unidad29='" & c29p2.Text & "',cantidad30='" & c30p3.Text & "',unidad30='" & c30p2.Text & "',"
                sql += "cantidad31='" & c31p3.Text & "',unidad31='" & c31p2.Text & "',cantidad32='" & c32p3.Text & "',unidad32='" & c32p2.Text & "',cantidad33='" & c33p3.Text & "',unidad33='" & c33p2.Text & "',cantidad34='" & c34p3.Text & "',unidad34='" & c34p2.Text & "',cantidad35='" & c35p3.Text & "',unidad35='" & c35p2.Text & "',cantidad36='" & c36p3.Text & "',unidad36='" & c36p2.Text & "',cantidad37='" & c37p3.Text & "',unidad37='" & c37p2.Text & "',cantidad38='" & c38p3.Text & "',unidad38='" & c38p2.Text & "',cantidad39='" & c39p3.Text & "',unidad39='" & c39p2.Text & "',cantidad40='" & c40p3.Text & "',unidad40='" & c40p2.Text & "',"
                sql += "subtotal='" & lblsub.Text & "',descuento='" & lbldesc.Text & "',impuesto='" & lblisv.Text & "',men_retencion='" & lblmenrete.Text & "',total='" & lbltotal.Text & "' where num_orden='" & tnorden.Text & "'"
            ElseIf resultado = 0 Then
                sql = "insert into ordenes (num_orden,tipomoneda,tipotransaccion,solicitado_por,departamento,nom_proveedor,can_letras,cargar,proyecto,observaciones,dia,mes,año,dia2,mes2,año2,c1,v1,c2,v2,c3,v3,c4,v4,c5,v5,c6,v6,c7,v7,c8,v8,c9,v9,c10,v10,c11,v11,c12,v12,c13,v13,c14,v14,c15,v15,c16,v16,c17,v17,c18,v18,c19,v19,c20,v20,c21,v21,c22,v22,c23,v23,c24,v24,c25,v25,c26,v26,c27,v27,c28,v28,c29,v29,c30,v30,c31,v31,c32,v32,c33,v33,c34,v34,c35,v35,c36,v36,c37,v37,c38,v38,c39,v39,c40,v40,cantidad1,unidad1,cantidad2,unidad2,cantidad3,unidad3,cantidad4,unidad4,cantidad5,unidad5,cantidad6,unidad6,cantidad7,unidad7,cantidad8,unidad8,cantidad9,unidad9,cantidad10,unidad10,cantidad11,unidad11,cantidad12,unidad12,cantidad13,unidad13,cantidad14,unidad14,cantidad15,unidad15,cantidad16,unidad16,cantidad17,unidad17,cantidad18,unidad18,cantidad19,unidad19,cantidad20,unidad20,cantidad21,unidad21,cantidad22,unidad22,cantidad23,unidad23,cantidad24,unidad24,cantidad25,unidad25,cantidad26,unidad26,cantidad27,unidad27,cantidad28,unidad28,cantidad29,unidad29,cantidad30,unidad30,cantidad31,unidad31,cantidad32,unidad32,cantidad33,unidad33,cantidad34,unidad34,cantidad35,unidad35,cantidad36,unidad36,cantidad37,unidad37,cantidad38,unidad38,cantidad39,unidad39,cantidad40,unidad40,subtotal,descuento,impuesto,men_retencion,total) values ("
                sql += "'" & tnorden.Text & "','" & tipomoneda & "','" & tipotransc & "','" & tsolicitadopor.Text & "','" & tdepartamento.Text & "',"
                sql += "'" & tproveedor.Text & "','" & tcanletras.Text & "','" & tcargara.Text & "','" & tproyecto.Text & "','" & tobservaciones.Text & "','" & tdiae.Text & "','" & tmese.Text & "','" & tañoe.Text & "','" & tdiav.Text & "','" & tmesv.Text & "','" & tañov.Text & "',"
                sql += "'" & c1.Text & "','" & v1.Text & "','" & c2.Text & "','" & v2.Text & "','" & c3.Text & "','" & v3.Text & "','" & c4.Text & "','" & v4.Text & "','" & c5.Text & "','" & v5.Text & "','" & c6.Text & "','" & v6.Text & "','" & c7.Text & "','" & v7.Text & "','" & c8.Text & "','" & v8.Text & "','" & c9.Text & "','" & v9.Text & "','" & c10.Text & "','" & v10.Text & "',"
                sql += "'" & c11.Text & "','" & v11.Text & "','" & c12.Text & "','" & v12.Text & "','" & c13.Text & "','" & v13.Text & "','" & c14.Text & "','" & v14.Text & "','" & c15.Text & "','" & v15.Text & "','" & c16.Text & "','" & v16.Text & "','" & c17.Text & "','" & v17.Text & "','" & c18.Text & "','" & v18.Text & "','" & c19.Text & "','" & v19.Text & "','" & c20.Text & "','" & v20.Text & "',"
                sql += "'" & c21.Text & "','" & v21.Text & "','" & c22.Text & "','" & v22.Text & "','" & c23.Text & "','" & v23.Text & "','" & c24.Text & "','" & v24.Text & "','" & c25.Text & "','" & v25.Text & "','" & c26.Text & "','" & v26.Text & "','" & c27.Text & "','" & v27.Text & "','" & c28.Text & "','" & v28.Text & "','" & c29.Text & "','" & v29.Text & "','" & c30.Text & "','" & v30.Text & "',"
                sql += "'" & c31.Text & "','" & v31.Text & "','" & c32.Text & "','" & v32.Text & "','" & c33.Text & "','" & v33.Text & "','" & c34.Text & "','" & v34.Text & "','" & c35.Text & "','" & v35.Text & "','" & c36.Text & "','" & v36.Text & "','" & c37.Text & "','" & v37.Text & "','" & c38.Text & "','" & v38.Text & "','" & c39.Text & "','" & v39.Text & "','" & c40.Text & "','" & v40.Text & "',"
                sql += "'" & c1p3.Text & "','" & c1p2.Text & "','" & c2p3.Text & "','" & c2p2.Text & "','" & c3p3.Text & "','" & c3p2.Text & "','" & c4p3.Text & "','" & c4p2.Text & "','" & c5p3.Text & "','" & c5p2.Text & "','" & c6p3.Text & "','" & c6p2.Text & "','" & c7p3.Text & "','" & c7p2.Text & "','" & c8p3.Text & "','" & c8p2.Text & "','" & c9p3.Text & "','" & c9p2.Text & "','" & c10p3.Text & "','" & c10p2.Text & "',"
                sql += "'" & c11p3.Text & "','" & c11p2.Text & "','" & c12p3.Text & "','" & c12p2.Text & "','" & c13p3.Text & "','" & c13p2.Text & "','" & c14p3.Text & "','" & c14p2.Text & "','" & c15p3.Text & "','" & c15p2.Text & "','" & c16p3.Text & "','" & c16p2.Text & "','" & c17p3.Text & "','" & c17p2.Text & "','" & c18p3.Text & "','" & c18p2.Text & "','" & c19p3.Text & "','" & c19p2.Text & "','" & c20p3.Text & "','" & c20p2.Text & "',"
                sql += "'" & c21p3.Text & "','" & c21p2.Text & "','" & c22p3.Text & "','" & c22p2.Text & "','" & c23p3.Text & "','" & c23p2.Text & "','" & c24p3.Text & "','" & c24p2.Text & "','" & c25p3.Text & "','" & c25p2.Text & "','" & c26p3.Text & "','" & c26p2.Text & "','" & c27p3.Text & "','" & c27p2.Text & "','" & c28p3.Text & "','" & c28p2.Text & "','" & c29p3.Text & "','" & c29p2.Text & "','" & c30p3.Text & "','" & c30p2.Text & "',"
                sql += "'" & c31p3.Text & "','" & c31p2.Text & "','" & c32p3.Text & "','" & c32p2.Text & "','" & c33p3.Text & "','" & c33p2.Text & "','" & c34p3.Text & "','" & c34p2.Text & "','" & c35p3.Text & "','" & c35p2.Text & "','" & c36p3.Text & "','" & c36p2.Text & "','" & c37p3.Text & "','" & c37p2.Text & "','" & c38p3.Text & "','" & c38p2.Text & "','" & c39p3.Text & "','" & c39p2.Text & "','" & c40p3.Text & "','" & c40p2.Text & "',"
                sql += "'" & lblsub.Text & "','" & lbldesc.Text & "','" & lblisv.Text & "','" & lblmenrete.Text & "','" & lbltotal.Text & "')"
            End If
            Comando = New SqlCommand(sql, Conexion)
            Comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        limpiar()
        Conexion.Close()
        tnorden.Focus()
    End Sub


    Private Sub tnorden_Validated(sender As Object, e As EventArgs) Handles tnorden.Validated
        limpiarparcial()
        If tnorden.Text = Nothing Then
            mensaje.Text = "Dejo vacio el numero de orden"
            tnorden.Focus()
            Exit Sub
        End If
        sql = "select * from ordenes where num_orden='" & tnorden.Text & "'"
        Try
            Conexion.Open()
            adaptar = New SqlDataAdapter(sql, Conexion)
            almacen = New DataSet
            adaptar.Fill(almacen, "ordenes")
            resultado = almacen.Tables("ordenes").Rows.Count
            If resultado > 0 Then
                registro = almacen.Tables("ordenes").Rows(0)
                If Not IsDBNull(registro("tipomoneda")) Then
                    If registro("tipomoneda") = "Lempiras" Then
                        rblempiras.Checked = True
                    ElseIf registro("tipomoneda") = "Dolares" Then
                        rbdolares.Checked = True
                    End If
                    If Not IsDBNull(registro("tipotransaccion")) Then
                        If registro("tipotransaccion") = "Cheque Normal" Then
                            rbchekenormal.Checked = True
                        ElseIf registro("tipotransaccion") = "Transferencia" Then
                            rbtransferencia.Checked = True
                        ElseIf registro("tipotransaccion") = "Cheque Certificado" Then
                            rbchequecertificado.Checked = True
                        ElseIf registro("tipotransaccion") = "Giro Bancario" Then
                            rbgirobanc.Checked = True
                        End If
                        If Not IsDBNull(registro("solicitado_por")) Then
                            tsolicitadopor.Text = registro("solicitado_por")
                        End If
                        If Not IsDBNull(registro("departamento")) Then
                            tdepartamento.Text = registro("departamento")
                        End If
                        If Not IsDBNull(registro("nom_proveedor")) Then
                            tproveedor.Text = registro("nom_proveedor")
                        End If
                        If Not IsDBNull(registro("can_letras")) Then
                            tcanletras.Text = registro("can_letras")
                        End If
                        If Not IsDBNull(registro("cargar")) Then
                            tcargara.Text = registro("cargar")
                        End If
                        If Not IsDBNull(registro("proyecto")) Then
                            tproyecto.Text = registro("proyecto")
                        End If
                        If Not IsDBNull(registro("observaciones")) Then
                            tobservaciones.Text = registro("observaciones")
                        End If
                        If Not IsDBNull(registro("dia")) Then
                            tdiae.Text = registro("dia")
                        End If
                        If Not IsDBNull(registro("mes")) Then
                            tmese.Text = registro("mes")
                        End If
                        If Not IsDBNull(registro("año")) Then
                            tañoe.Text = registro("año")
                        End If
                        If Not IsDBNull(registro("dia2")) Then
                            tdiav.Text = registro("dia2")
                        End If
                        If Not IsDBNull(registro("mes2")) Then
                            tmesv.Text = registro("mes2")
                        End If
                        If Not IsDBNull(registro("año2")) Then
                            tañov.Text = registro("año2")
                        End If
                        If Not IsDBNull(registro("cantidad1")) Then
                            c1p3.Text = registro("cantidad1")
                        End If
                        If Not IsDBNull(registro("unidad1")) Then
                            c1p2.Text = registro("unidad1")
                        End If
                        If Not IsDBNull(registro("c1")) Then
                            c1.Text = registro("c1")
                        End If
                        If Not IsDBNull(registro("v1")) Then
                            v1.Text = registro("v1")
                        End If
                        If Not IsDBNull(registro("cantidad2")) Then
                            c2p3.Text = registro("cantidad2")
                        End If
                        If Not IsDBNull(registro("unidad2")) Then
                            c2p2.Text = registro("unidad2")
                        End If
                        If Not IsDBNull(registro("c2")) Then
                            c2.Text = registro("c2")
                        End If
                        If Not IsDBNull(registro("v2")) Then
                            v2.Text = registro("v2")
                        End If
                        If Not IsDBNull(registro("cantidad3")) Then
                            c3p3.Text = registro("cantidad3")
                        End If
                        If Not IsDBNull(registro("unidad3")) Then
                            c3p2.Text = registro("unidad3")
                        End If
                        If Not IsDBNull(registro("c3")) Then
                            c3.Text = registro("c3")
                        End If
                        If Not IsDBNull(registro("v3")) Then
                            v3.Text = registro("v3")
                        End If
                        If Not IsDBNull(registro("cantidad4")) Then
                            c4p3.Text = registro("cantidad4")
                        End If
                        If Not IsDBNull(registro("unidad4")) Then
                            c4p2.Text = registro("unidad4")
                        End If
                        If Not IsDBNull(registro("c4")) Then
                            c4.Text = registro("c4")
                        End If
                        If Not IsDBNull(registro("v4")) Then
                            v4.Text = registro("v4")
                        End If
                        If Not IsDBNull(registro("cantidad5")) Then
                            c5p3.Text = registro("cantidad5")
                        End If
                        If Not IsDBNull(registro("unidad5")) Then
                            c5p2.Text = registro("unidad5")
                        End If
                        If Not IsDBNull(registro("c5")) Then
                            c5.Text = registro("c5")
                        End If
                        If Not IsDBNull(registro("v5")) Then
                            v5.Text = registro("v5")
                        End If
                        If Not IsDBNull(registro("cantidad6")) Then
                            c6p3.Text = registro("cantidad6")
                        End If
                        If Not IsDBNull(registro("unidad6")) Then
                            c6p2.Text = registro("unidad6")
                        End If
                        If Not IsDBNull(registro("c6")) Then
                            c6.Text = registro("c6")
                        End If
                        If Not IsDBNull(registro("v6")) Then
                            v6.Text = registro("v6")
                        End If
                        If Not IsDBNull(registro("cantidad7")) Then
                            c7p3.Text = registro("cantidad7")
                        End If
                        If Not IsDBNull(registro("unidad7")) Then
                            c7p2.Text = registro("unidad7")
                        End If
                        If Not IsDBNull(registro("c7")) Then
                            c7.Text = registro("c7")
                        End If
                        If Not IsDBNull(registro("v7")) Then
                            v7.Text = registro("v7")
                        End If
                        If Not IsDBNull(registro("cantidad8")) Then
                            c8p3.Text = registro("cantidad8")
                        End If
                        If Not IsDBNull(registro("unidad8")) Then
                            c8p2.Text = registro("unidad8")
                        End If
                        If Not IsDBNull(registro("c8")) Then
                            c8.Text = registro("c8")
                        End If
                        If Not IsDBNull(registro("v8")) Then
                            v8.Text = registro("v8")
                        End If
                        If Not IsDBNull(registro("cantidad9")) Then
                            c9p3.Text = registro("cantidad9")
                        End If
                        If Not IsDBNull(registro("unidad9")) Then
                            c9p2.Text = registro("unidad9")
                        End If
                        If Not IsDBNull(registro("c9")) Then
                            c9.Text = registro("c9")
                        End If
                        If Not IsDBNull(registro("v9")) Then
                            v9.Text = registro("v9")
                        End If
                        If Not IsDBNull(registro("cantidad10")) Then
                            c10p3.Text = registro("cantidad10")
                        End If
                        If Not IsDBNull(registro("unidad10")) Then
                            c10p2.Text = registro("unidad10")
                        End If
                        If Not IsDBNull(registro("c10")) Then
                            c10.Text = registro("c10")
                        End If
                        If Not IsDBNull(registro("v10")) Then
                            v10.Text = registro("v10")
                        End If
                        If Not IsDBNull(registro("cantidad11")) Then
                            c11p3.Text = registro("cantidad11")
                        End If
                        If Not IsDBNull(registro("unidad11")) Then
                            c11p2.Text = registro("unidad11")
                        End If
                        If Not IsDBNull(registro("c11")) Then
                            c11.Text = registro("c11")
                        End If
                        If Not IsDBNull(registro("v11")) Then
                            v11.Text = registro("v11")
                        End If
                        If Not IsDBNull(registro("cantidad12")) Then
                            c12p3.Text = registro("cantidad12")
                        End If
                        If Not IsDBNull(registro("unidad12")) Then
                            c12p2.Text = registro("unidad12")
                        End If
                        If Not IsDBNull(registro("c12")) Then
                            c12.Text = registro("c12")
                        End If
                        If Not IsDBNull(registro("v12")) Then
                            v12.Text = registro("v12")
                        End If
                        If Not IsDBNull(registro("cantidad13")) Then
                            c13p3.Text = registro("cantidad13")
                        End If
                        If Not IsDBNull(registro("unidad13")) Then
                            c13p2.Text = registro("unidad13")
                        End If
                        If Not IsDBNull(registro("c13")) Then
                            c13.Text = registro("c13")
                        End If
                        If Not IsDBNull(registro("v13")) Then
                            v13.Text = registro("v13")
                        End If
                        If Not IsDBNull(registro("cantidad14")) Then
                            c14p3.Text = registro("cantidad14")
                        End If
                        If Not IsDBNull(registro("unidad14")) Then
                            c14p2.Text = registro("unidad14")
                        End If
                        If Not IsDBNull(registro("c14")) Then
                            c14.Text = registro("c14")
                        End If
                        If Not IsDBNull(registro("v14")) Then
                            v14.Text = registro("v14")
                        End If
                        If Not IsDBNull(registro("cantidad15")) Then
                            c15p3.Text = registro("cantidad15")
                        End If
                        If Not IsDBNull(registro("unidad15")) Then
                            c15p2.Text = registro("unidad15")
                        End If
                        If Not IsDBNull(registro("c15")) Then
                            c15.Text = registro("c15")
                        End If
                        If Not IsDBNull(registro("v15")) Then
                            v15.Text = registro("v15")
                        End If
                        If Not IsDBNull(registro("cantidad16")) Then
                            c16p3.Text = registro("cantidad16")
                        End If
                        If Not IsDBNull(registro("unidad16")) Then
                            c16p2.Text = registro("unidad16")
                        End If
                        If Not IsDBNull(registro("c16")) Then
                            c16.Text = registro("c16")
                        End If
                        If Not IsDBNull(registro("v16")) Then
                            v16.Text = registro("v16")
                        End If
                        If Not IsDBNull(registro("cantidad17")) Then
                            c17p3.Text = registro("cantidad17")
                        End If
                        If Not IsDBNull(registro("unidad17")) Then
                            c17p2.Text = registro("unidad17")
                        End If
                        If Not IsDBNull(registro("c17")) Then
                            c17.Text = registro("c17")
                        End If
                        If Not IsDBNull(registro("v17")) Then
                            v17.Text = registro("v17")
                        End If
                        If Not IsDBNull(registro("cantidad18")) Then
                            c18p3.Text = registro("cantidad18")
                        End If
                        If Not IsDBNull(registro("unidad18")) Then
                            c18p2.Text = registro("unidad18")
                        End If
                        If Not IsDBNull(registro("c18")) Then
                            c18.Text = registro("c18")
                        End If
                        If Not IsDBNull(registro("v18")) Then
                            v18.Text = registro("v18")
                        End If
                        If Not IsDBNull(registro("cantidad19")) Then
                            c19p3.Text = registro("cantidad19")
                        End If
                        If Not IsDBNull(registro("unidad19")) Then
                            c19p2.Text = registro("unidad19")
                        End If
                        If Not IsDBNull(registro("c19")) Then
                            c19.Text = registro("c19")
                        End If
                        If Not IsDBNull(registro("v19")) Then
                            v19.Text = registro("v19")
                        End If
                        If Not IsDBNull(registro("cantidad20")) Then
                            c20p3.Text = registro("cantidad20")
                        End If
                        If Not IsDBNull(registro("unidad20")) Then
                            c20p2.Text = registro("unidad20")
                        End If
                        If Not IsDBNull(registro("c20")) Then
                            c20.Text = registro("c20")
                        End If
                        If Not IsDBNull(registro("v20")) Then
                            v20.Text = registro("v20")
                        End If
                        If Not IsDBNull(registro("cantidad21")) Then
                            c21p3.Text = registro("cantidad21")
                        End If
                        If Not IsDBNull(registro("unidad21")) Then
                            c21p2.Text = registro("unidad21")
                        End If
                        If Not IsDBNull(registro("c21")) Then
                            c21.Text = registro("c21")
                        End If
                        If Not IsDBNull(registro("v21")) Then
                            v21.Text = registro("v21")
                        End If
                        If Not IsDBNull(registro("cantidad22")) Then
                            c22p3.Text = registro("cantidad22")
                        End If
                        If Not IsDBNull(registro("unidad22")) Then
                            c22p2.Text = registro("unidad22")
                        End If
                        If Not IsDBNull(registro("c22")) Then
                            c22.Text = registro("c22")
                        End If
                        If Not IsDBNull(registro("v22")) Then
                            v22.Text = registro("v22")
                        End If
                        If Not IsDBNull(registro("cantidad23")) Then
                            c23p3.Text = registro("cantidad23")
                        End If
                        If Not IsDBNull(registro("unidad23")) Then
                            c23p2.Text = registro("unidad23")
                        End If
                        If Not IsDBNull(registro("c23")) Then
                            c23.Text = registro("c23")
                        End If
                        If Not IsDBNull(registro("v23")) Then
                            v23.Text = registro("v23")
                        End If
                        If Not IsDBNull(registro("cantidad24")) Then
                            c24p3.Text = registro("cantidad24")
                        End If
                        If Not IsDBNull(registro("unidad24")) Then
                            c24p2.Text = registro("unidad24")
                        End If
                        If Not IsDBNull(registro("c24")) Then
                            c24.Text = registro("c24")
                        End If
                        If Not IsDBNull(registro("v24")) Then
                            v24.Text = registro("v24")
                        End If
                        If Not IsDBNull(registro("cantidad25")) Then
                            c25p3.Text = registro("cantidad25")
                        End If
                        If Not IsDBNull(registro("unidad25")) Then
                            c25p2.Text = registro("unidad25")
                        End If
                        If Not IsDBNull(registro("c25")) Then
                            c25.Text = registro("c25")
                        End If
                        If Not IsDBNull(registro("v25")) Then
                            v25.Text = registro("v25")
                        End If
                        If Not IsDBNull(registro("cantidad26")) Then
                            c26p3.Text = registro("cantidad26")
                        End If
                        If Not IsDBNull(registro("unidad26")) Then
                            c26p2.Text = registro("unidad26")
                        End If
                        If Not IsDBNull(registro("c26")) Then
                            c26.Text = registro("c26")
                        End If
                        If Not IsDBNull(registro("v26")) Then
                            v26.Text = registro("v26")
                        End If
                        If Not IsDBNull(registro("cantidad27")) Then
                            c27p3.Text = registro("cantidad27")
                        End If
                        If Not IsDBNull(registro("unidad27")) Then
                            c27p2.Text = registro("unidad27")
                        End If
                        If Not IsDBNull(registro("c27")) Then
                            c27.Text = registro("c27")
                        End If
                        If Not IsDBNull(registro("v27")) Then
                            v27.Text = registro("v27")
                        End If
                        If Not IsDBNull(registro("cantidad28")) Then
                            c28p3.Text = registro("cantidad28")
                        End If
                        If Not IsDBNull(registro("unidad28")) Then
                            c28p2.Text = registro("unidad28")
                        End If
                        If Not IsDBNull(registro("c28")) Then
                            c28.Text = registro("c28")
                        End If
                        If Not IsDBNull(registro("v28")) Then
                            v28.Text = registro("v28")
                        End If
                        If Not IsDBNull(registro("cantidad29")) Then
                            c29p3.Text = registro("cantidad29")
                        End If
                        If Not IsDBNull(registro("unidad29")) Then
                            c29p2.Text = registro("unidad29")
                        End If
                        If Not IsDBNull(registro("c29")) Then
                            c29.Text = registro("c29")
                        End If
                        If Not IsDBNull(registro("v29")) Then
                            v29.Text = registro("v29")
                        End If
                        If Not IsDBNull(registro("cantidad30")) Then
                            c30p3.Text = registro("cantidad30")
                        End If
                        If Not IsDBNull(registro("unidad30")) Then
                            c30p2.Text = registro("unidad30")
                        End If
                        If Not IsDBNull(registro("c30")) Then
                            c30.Text = registro("c30")
                        End If
                        If Not IsDBNull(registro("v30")) Then
                            v30.Text = registro("v30")
                        End If
                        If Not IsDBNull(registro("cantidad31")) Then
                            c31p3.Text = registro("cantidad31")
                        End If
                        If Not IsDBNull(registro("unidad31")) Then
                            c31p2.Text = registro("unidad31")
                        End If
                        If Not IsDBNull(registro("c31")) Then
                            c31.Text = registro("c31")
                        End If
                        If Not IsDBNull(registro("v31")) Then
                            v31.Text = registro("v31")
                        End If
                        If Not IsDBNull(registro("cantidad32")) Then
                            c32p3.Text = registro("cantidad32")
                        End If
                        If Not IsDBNull(registro("unidad32")) Then
                            c32p2.Text = registro("unidad32")
                        End If
                        If Not IsDBNull(registro("c32")) Then
                            c32.Text = registro("c32")
                        End If
                        If Not IsDBNull(registro("v32")) Then
                            v32.Text = registro("v32")
                        End If
                        If Not IsDBNull(registro("cantidad33")) Then
                            c33p3.Text = registro("cantidad33")
                        End If
                        If Not IsDBNull(registro("unidad33")) Then
                            c33p2.Text = registro("unidad33")
                        End If
                        If Not IsDBNull(registro("c33")) Then
                            c33.Text = registro("c33")
                        End If
                        If Not IsDBNull(registro("v33")) Then
                            v33.Text = registro("v33")
                        End If
                        If Not IsDBNull(registro("cantidad34")) Then
                            c34p3.Text = registro("cantidad34")
                        End If
                        If Not IsDBNull(registro("unidad34")) Then
                            c34p2.Text = registro("unidad34")
                        End If
                        If Not IsDBNull(registro("c34")) Then
                            c34.Text = registro("c34")
                        End If
                        If Not IsDBNull(registro("v34")) Then
                            v34.Text = registro("v34")
                        End If
                        If Not IsDBNull(registro("cantidad35")) Then
                            c35p3.Text = registro("cantidad35")
                        End If
                        If Not IsDBNull(registro("unidad35")) Then
                            c35p2.Text = registro("unidad35")
                        End If
                        If Not IsDBNull(registro("c35")) Then
                            c35.Text = registro("c35")
                        End If
                        If Not IsDBNull(registro("v35")) Then
                            v35.Text = registro("v35")
                        End If
                        If Not IsDBNull(registro("cantidad36")) Then
                            c36p3.Text = registro("cantidad36")
                        End If
                        If Not IsDBNull(registro("unidad36")) Then
                            c36p2.Text = registro("unidad36")
                        End If
                        If Not IsDBNull(registro("c36")) Then
                            c36.Text = registro("c36")
                        End If
                        If Not IsDBNull(registro("v36")) Then
                            v36.Text = registro("v36")
                        End If
                        If Not IsDBNull(registro("cantidad37")) Then
                            c37p3.Text = registro("cantidad37")
                        End If
                        If Not IsDBNull(registro("unidad37")) Then
                            c37p2.Text = registro("unidad37")
                        End If
                        If Not IsDBNull(registro("c37")) Then
                            c37.Text = registro("c37")
                        End If
                        If Not IsDBNull(registro("v37")) Then
                            v37.Text = registro("v37")
                        End If
                        If Not IsDBNull(registro("cantidad38")) Then
                            c38p3.Text = registro("cantidad38")
                        End If
                        If Not IsDBNull(registro("unidad38")) Then
                            c38p2.Text = registro("unidad38")
                        End If
                        If Not IsDBNull(registro("c38")) Then
                            c38.Text = registro("c38")
                        End If
                        If Not IsDBNull(registro("v38")) Then
                            v38.Text = registro("v38")
                        End If
                        If Not IsDBNull(registro("cantidad39")) Then
                            c39p3.Text = registro("cantidad39")
                        End If
                        If Not IsDBNull(registro("unidad39")) Then
                            c39p2.Text = registro("unidad39")
                        End If
                        If Not IsDBNull(registro("c39")) Then
                            c39.Text = registro("c39")
                        End If
                        If Not IsDBNull(registro("v39")) Then
                            v39.Text = registro("v39")
                        End If
                        If Not IsDBNull(registro("cantidad40")) Then
                            c40p3.Text = registro("cantidad40")
                        End If
                        If Not IsDBNull(registro("unidad40")) Then
                            c40p2.Text = registro("unidad40")
                        End If
                        If Not IsDBNull(registro("c40")) Then
                            c40.Text = registro("c40")
                        End If
                        If Not IsDBNull(registro("v40")) Then
                            v40.Text = registro("v40")
                        End If
                        If Not IsDBNull(registro("descuento")) Then
                            tdesc.Text = registro("descuento")
                        End If
                        If Not IsDBNull(registro("men_retencion")) Then
                            treten.Text = registro("men_retencion")
                        End If
                    End If
                End If
            ElseIf resultado = 0 Then
                rblempiras.Enabled = True
                rbdolares.Enabled = True
            End If
            If c1.Enabled = True Or c1p3.Enabled = True Or c1p2.Enabled = True Or v1.Enabled = True Then
                c1p3.Enabled = True
                c1p2.Enabled = True
                c1.Enabled = True
                v1.Enabled = True
            End If
            If c2.Enabled = True Or c2p3.Enabled = True Or c2p2.Enabled = True Or v2.Enabled = True Then
                c2p3.Enabled = True
                c2p2.Enabled = True
                c2.Enabled = True
                v2.Enabled = True
            End If
            If c3.Enabled = True Or c3p3.Enabled = True Or c3p2.Enabled = True Or v3.Enabled = True Then
                c3p3.Enabled = True
                c3p2.Enabled = True
                c3.Enabled = True
                v3.Enabled = True
            End If
            If c4.Enabled = True Or c4p3.Enabled = True Or c4p2.Enabled = True Or v4.Enabled = True Then
                c4p3.Enabled = True
                c4p2.Enabled = True
                c4.Enabled = True
                v4.Enabled = True
            End If
            If c5.Enabled = True Or c5p3.Enabled = True Or c5p2.Enabled = True Or v5.Enabled = True Then
                c5p3.Enabled = True
                c5p2.Enabled = True
                c5.Enabled = True
                v5.Enabled = True
            End If
            If c6.Enabled = True Or c6p3.Enabled = True Or c6p2.Enabled = True Or v6.Enabled = True Then
                c6p3.Enabled = True
                c6p2.Enabled = True
                c6.Enabled = True
                v6.Enabled = True
            End If
            If c7.Enabled = True Or c7p3.Enabled = True Or c7p2.Enabled = True Or v7.Enabled = True Then
                c7p3.Enabled = True
                c7p2.Enabled = True
                c7.Enabled = True
                v7.Enabled = True
            End If
            If c8.Enabled = True Or c8p3.Enabled = True Or c8p2.Enabled = True Or v8.Enabled = True Then
                c8p3.Enabled = True
                c8p2.Enabled = True
                c8.Enabled = True
                v8.Enabled = True
            End If
            If c9.Enabled = True Or c9p3.Enabled = True Or c9p2.Enabled = True Or v9.Enabled = True Then
                c9p3.Enabled = True
                c9p2.Enabled = True
                c9.Enabled = True
                v9.Enabled = True
            End If
            If c10.Enabled = True Or c10p3.Enabled = True Or c10p2.Enabled = True Or v10.Enabled = True Then
                c10p3.Enabled = True
                c10p2.Enabled = True
                c10.Enabled = True
                v10.Enabled = True
            End If
            If c11.Enabled = True Or c11p3.Enabled = True Or c11p2.Enabled = True Or v11.Enabled = True Then
                c11p3.Enabled = True
                c11p2.Enabled = True
                c11.Enabled = True
                v11.Enabled = True
            End If
            If c12.Enabled = True Or c12p3.Enabled = True Or c12p2.Enabled = True Or v12.Enabled = True Then
                c12p3.Enabled = True
                c12p2.Enabled = True
                c12.Enabled = True
                v12.Enabled = True
            End If
            If c13.Enabled = True Or c13p3.Enabled = True Or c13p2.Enabled = True Or v13.Enabled = True Then
                c13p3.Enabled = True
                c13p2.Enabled = True
                c13.Enabled = True
                v13.Enabled = True
            End If
            If c14.Enabled = True Or c14p3.Enabled = True Or c14p2.Enabled = True Or v14.Enabled = True Then
                c14p3.Enabled = True
                c14p2.Enabled = True
                c14.Enabled = True
                v14.Enabled = True
            End If
            If c15.Enabled = True Or c15p3.Enabled = True Or c15p2.Enabled = True Or v15.Enabled = True Then
                c15p3.Enabled = True
                c15p2.Enabled = True
                c15.Enabled = True
                v15.Enabled = True
            End If
            If c16.Enabled = True Or c16p3.Enabled = True Or c16p2.Enabled = True Or v16.Enabled = True Then
                c16p3.Enabled = True
                c16p2.Enabled = True
                c16.Enabled = True
                v16.Enabled = True
            End If
            If c17.Enabled = True Or c17p3.Enabled = True Or c17p2.Enabled = True Or v17.Enabled = True Then
                c17p3.Enabled = True
                c17p2.Enabled = True
                c17.Enabled = True
                v17.Enabled = True
            End If
            If c18.Enabled = True Or c18p3.Enabled = True Or c18p2.Enabled = True Or v18.Enabled = True Then
                c18p3.Enabled = True
                c18p2.Enabled = True
                c18.Enabled = True
                v18.Enabled = True
            End If
            If c19.Enabled = True Or c19p3.Enabled = True Or c19p2.Enabled = True Or v19.Enabled = True Then
                c19p3.Enabled = True
                c19p2.Enabled = True
                c19.Enabled = True
                v19.Enabled = True
            End If
            If c20.Enabled = True Or c20p3.Enabled = True Or c20p2.Enabled = True Or v20.Enabled = True Then
                c20p3.Enabled = True
                c20p2.Enabled = True
                c20.Enabled = True
                v20.Enabled = True
            End If
            If c21.Enabled = True Or c21p3.Enabled = True Or c21p2.Enabled = True Or v21.Enabled = True Then
                c21p3.Enabled = True
                c21p2.Enabled = True
                c21.Enabled = True
                v21.Enabled = True
            End If
            If c22.Enabled = True Or c22p3.Enabled = True Or c22p2.Enabled = True Or v22.Enabled = True Then
                c22p3.Enabled = True
                c22p2.Enabled = True
                c22.Enabled = True
                v22.Enabled = True
            End If
            If c23.Enabled = True Or c23p3.Enabled = True Or c23p2.Enabled = True Or v23.Enabled = True Then
                c23p3.Enabled = True
                c23p2.Enabled = True
                c23.Enabled = True
                v23.Enabled = True
            End If
            If c24.Enabled = True Or c24p3.Enabled = True Or c24p2.Enabled = True Or v24.Enabled = True Then
                c24p3.Enabled = True
                c24p2.Enabled = True
                c24.Enabled = True
                v24.Enabled = True
            End If
            If c25.Enabled = True Or c25p3.Enabled = True Or c25p2.Enabled = True Or v25.Enabled = True Then
                c25p3.Enabled = True
                c25p2.Enabled = True
                c25.Enabled = True
                v25.Enabled = True
            End If
            If c26.Enabled = True Or c26p3.Enabled = True Or c26p2.Enabled = True Or v26.Enabled = True Then
                c26p3.Enabled = True
                c26p2.Enabled = True
                c26.Enabled = True
                v26.Enabled = True
            End If
            If c27.Enabled = True Or c27p3.Enabled = True Or c27p2.Enabled = True Or v27.Enabled = True Then
                c27p3.Enabled = True
                c27p2.Enabled = True
                c27.Enabled = True
                v27.Enabled = True
            End If
            If c28.Enabled = True Or c28p3.Enabled = True Or c28p2.Enabled = True Or v28.Enabled = True Then
                c28p3.Enabled = True
                c28p2.Enabled = True
                c28.Enabled = True
                v28.Enabled = True
            End If
            If c29.Enabled = True Or c29p3.Enabled = True Or c29p2.Enabled = True Or v29.Enabled = True Then
                c29p3.Enabled = True
                c29p2.Enabled = True
                c29.Enabled = True
                v29.Enabled = True
            End If
            If c30.Enabled = True Or c30p3.Enabled = True Or c30p2.Enabled = True Or v30.Enabled = True Then
                c30p3.Enabled = True
                c30p2.Enabled = True
                c30.Enabled = True
                v30.Enabled = True
            End If
            If c31.Enabled = True Or c31p3.Enabled = True Or c31p2.Enabled = True Or v31.Enabled = True Then
                c31p3.Enabled = True
                c31p2.Enabled = True
                c31.Enabled = True
                v31.Enabled = True
            End If
            If c32.Enabled = True Or c32p3.Enabled = True Or c32p2.Enabled = True Or v32.Enabled = True Then
                c32p3.Enabled = True
                c32p2.Enabled = True
                c32.Enabled = True
                v32.Enabled = True
            End If
            If c33.Enabled = True Or c33p3.Enabled = True Or c33p2.Enabled = True Or v33.Enabled = True Then
                c33p3.Enabled = True
                c33p2.Enabled = True
                c33.Enabled = True
                v33.Enabled = True
            End If
            If c34.Enabled = True Or c34p3.Enabled = True Or c34p2.Enabled = True Or v34.Enabled = True Then
                c34p3.Enabled = True
                c34p2.Enabled = True
                c34.Enabled = True
                v34.Enabled = True
            End If
            If c35.Enabled = True Or c35p3.Enabled = True Or c35p2.Enabled = True Or v35.Enabled = True Then
                c35p3.Enabled = True
                c35p2.Enabled = True
                c35.Enabled = True
                v35.Enabled = True
            End If
            If c36.Enabled = True Or c36p3.Enabled = True Or c36p2.Enabled = True Or v36.Enabled = True Then
                c36p3.Enabled = True
                c36p2.Enabled = True
                c36.Enabled = True
                v36.Enabled = True
            End If
            If c37.Enabled = True Or c37p3.Enabled = True Or c37p2.Enabled = True Or v37.Enabled = True Then
                c37p3.Enabled = True
                c37p2.Enabled = True
                c37.Enabled = True
                v37.Enabled = True
            End If
            If c38.Enabled = True Or c38p3.Enabled = True Or c38p2.Enabled = True Or v38.Enabled = True Then
                c38p3.Enabled = True
                c38p2.Enabled = True
                c38.Enabled = True
                v38.Enabled = True
            End If
            If c39.Enabled = True Or c39p3.Enabled = True Or c39p2.Enabled = True Or v39.Enabled = True Then
                c39p3.Enabled = True
                c39p2.Enabled = True
                c39.Enabled = True
                v39.Enabled = True
            End If
            If c40.Enabled = True Or c40p3.Enabled = True Or c40p2.Enabled = True Or v40.Enabled = True Then
                c40p3.Enabled = True
                c40p2.Enabled = True
                c40.Enabled = True
                v40.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Conexion.Close()
        tdepartamento.Focus()
    End Sub

    Private Sub beliminar_Click(sender As Object, e As EventArgs) Handles beliminar.Click
        If tnorden.Text = Nothing Then
            mensaje.Text = "Dejo vacio el numero de orden"
            tnorden.Focus()
            Exit Sub
        End If

        If MsgBox("Borrar la Solicitud de pago?", MsgBoxStyle.YesNo, "SERINTER") = MsgBoxResult.Yes Then
            Try
                sql = "Delete from ordenes where num_orden='" & tnorden.Text & "'"
                Conexion.Open()
                Comando = New SqlCommand(sql, Conexion)
                Comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        Conexion.Close()
        limpiar()
        tnorden.Focus()
    End Sub

    Private Sub rbchekenormal_CheckedChanged(sender As Object, e As EventArgs) Handles rbchekenormal.CheckedChanged
        rbchequecertificado.Enabled = False
        rbtransferencia.Enabled = False
        rbgirobanc.Enabled = False
        rbchekenormal.Enabled = True
        If rbchekenormal.Checked = Nothing Then
            rbgirobanc.Enabled = True
            rbtransferencia.Enabled = True
            rbchequecertificado.Enabled = True
        End If
    End Sub

    Private Sub rbtransferencia_CheckedChanged(sender As Object, e As EventArgs) Handles rbtransferencia.CheckedChanged
        rbchequecertificado.Enabled = False
        rbchekenormal.Enabled = False
        rbgirobanc.Enabled = False
        rbtransferencia.Enabled = True
        If rbtransferencia.Checked = Nothing Then
            rbgirobanc.Enabled = True
            rbchekenormal.Enabled = True
            rbchequecertificado.Enabled = True
        End If
    End Sub

    Private Sub rbchequecertificado_CheckedChanged(sender As Object, e As EventArgs) Handles rbchequecertificado.CheckedChanged
        rbchekenormal.Enabled = False
        rbtransferencia.Enabled = False
        rbgirobanc.Enabled = False
        rbchequecertificado.Enabled = True
        If rbchequecertificado.Checked = Nothing Then
            rbgirobanc.Enabled = True
            rbtransferencia.Enabled = True
            rbchekenormal.Enabled = True
        End If
    End Sub

    Private Sub rbgirobanc_CheckedChanged(sender As Object, e As EventArgs) Handles rbgirobanc.CheckedChanged
        rbchequecertificado.Enabled = False
        rbtransferencia.Enabled = False
        rbchekenormal.Enabled = False
        rbgirobanc.Enabled = True
        If rbgirobanc.Checked = Nothing Then
            rbchekenormal.Enabled = True
            rbtransferencia.Enabled = True
            rbchequecertificado.Enabled = True
        End If
    End Sub

    Private Sub bimprimir_Click(sender As Object, e As EventArgs) Handles bimprimir.Click
        ' FrmSolicitudImpr.tsolicitud.Text = Me.tnorden.Text
        FrmSolicitudImpr.ShowDialog()
    End Sub



    Private Sub tdesc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tdesc.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
            If Asc(e.KeyChar) = 46 Then
                e.Handled = False   ' <<< Para que admita el punto.
            Else
                mensaje.Text = "Solo Puede Digitar Numeros con punto"
            End If
        End If
    End Sub
    Private Sub tdesc_TextChanged(sender As Object, e As EventArgs) Handles tdesc.TextChanged
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double
        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text
    End Sub
    Private Sub treten_TextChanged(sender As Object, e As EventArgs) Handles treten.TextChanged
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double
        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text
    End Sub

    Private Sub treten_KeyPress(sender As Object, e As KeyPressEventArgs) Handles treten.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
            If Asc(e.KeyChar) = 46 Then
                e.Handled = False   ' <<< Para que admita el punto.
            Else
                mensaje.Text = "Solo Puede Digitar Numeros con punto"
            End If
        End If
    End Sub

    Private Sub tnorden_Enter(sender As Object, e As EventArgs) Handles tnorden.Enter
        bimprimir.Enabled = True
    End Sub

    Private Sub c1p3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c1p3.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c1p2.Focus()
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
            If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
                mensaje.Text = "Solo Puede Digitar Numeros"
            End If
        End If
    End Sub

    Private Sub c2p3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c2p3.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c2p2.Focus()
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
            If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
                mensaje.Text = "Solo Puede Digitar Numeros"
            End If
        End If
    End Sub

    Private Sub c3p3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c3p3.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c3p2.Focus()
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
            If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
                mensaje.Text = "Solo Puede Digitar Numeros"
            End If
        End If
    End Sub

    Private Sub c4p3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c4p3.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c4p2.Focus()
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
            If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
                mensaje.Text = "Solo Puede Digitar Numeros"
            End If
        End If
    End Sub

    Private Sub c5p3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c5p3.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c5p2.Focus()
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
            If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
                mensaje.Text = "Solo Puede Digitar Numeros"
            End If
        End If
    End Sub

    Private Sub c6p3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c6p3.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c6p2.Focus()
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
            If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
                mensaje.Text = "Solo Puede Digitar Numeros"
            End If
        End If
    End Sub

    Private Sub c7p3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c7p3.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c7p2.Focus()
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
            If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
                mensaje.Text = "Solo Puede Digitar Numeros"
            End If
        End If
    End Sub

    Private Sub c8p3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c8p3.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c8p2.Focus()
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
            If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
                mensaje.Text = "Solo Puede Digitar Numeros"
            End If
        End If
    End Sub

    Private Sub c9p3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c9p3.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c9p2.Focus()
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
            If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
                mensaje.Text = "Solo Puede Digitar Numeros"
            End If
        End If
    End Sub

    Private Sub c10p3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c10p3.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c10p2.Focus()
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
            If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
                mensaje.Text = "Solo Puede Digitar Numeros"
            End If
        End If
    End Sub

    Private Sub c11p3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c11p3.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c11p2.Focus()
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
            If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
                mensaje.Text = "Solo Puede Digitar Numeros"
            End If
        End If
    End Sub

    Private Sub c12p3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c12p3.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c12p2.Focus()
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
            If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
                mensaje.Text = "Solo Puede Digitar Numeros"
            End If
        End If
    End Sub

    Private Sub c13p3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c13p3.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c13p2.Focus()
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
            If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
                mensaje.Text = "Solo Puede Digitar Numeros"
            End If
        End If
    End Sub

    Private Sub c14p3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c14p3.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c14p2.Focus()
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
            If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
                mensaje.Text = "Solo Puede Digitar Numeros"
            End If
        End If
    End Sub

    Private Sub c15p3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c15p3.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c15p2.Focus()
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
            If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
                mensaje.Text = "Solo Puede Digitar Numeros"
            End If
        End If
    End Sub

    Private Sub c16p3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c16p3.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c16p2.Focus()
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
            If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
                mensaje.Text = "Solo Puede Digitar Numeros"
            End If
        End If
    End Sub

    Private Sub c17p3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c17p3.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c17p2.Focus()
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
            If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
                mensaje.Text = "Solo Puede Digitar Numeros"
            End If
        End If
    End Sub

    Private Sub c18p3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c18p3.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c18p2.Focus()
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
            If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
                mensaje.Text = "Solo Puede Digitar Numeros"
            End If
        End If
    End Sub

    Private Sub c19p3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c19p3.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c19p2.Focus()
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
            If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
                mensaje.Text = "Solo Puede Digitar Numeros"
            End If
        End If
    End Sub

    Private Sub c20p3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c20p3.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c20p2.Focus()
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
            If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
                mensaje.Text = "Solo Puede Digitar Numeros"
            End If
        End If
    End Sub

    Private Sub c21p3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c21p3.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c21p2.Focus()
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
            If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
                mensaje.Text = "Solo Puede Digitar Numeros"
            End If
        End If
    End Sub

    Private Sub c22p3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c22p3.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c22p2.Focus()
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
            If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
                mensaje.Text = "Solo Puede Digitar Numeros"
            End If
        End If
    End Sub

    Private Sub c23p3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c23p3.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c23p2.Focus()
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
            If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
                mensaje.Text = "Solo Puede Digitar Numeros"
            End If
        End If
    End Sub

    Private Sub c24p3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c24p3.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c24p2.Focus()
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
            If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
                mensaje.Text = "Solo Puede Digitar Numeros"
            End If
        End If
    End Sub

    Private Sub c25p3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c25p3.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c25p2.Focus()
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
            If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
                mensaje.Text = "Solo Puede Digitar Numeros"
            End If
        End If
    End Sub

    Private Sub c26p3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c26p3.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c26p2.Focus()
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
            If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
                mensaje.Text = "Solo Puede Digitar Numeros"
            End If
        End If
    End Sub

    Private Sub c27p3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c27p3.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c27p2.Focus()
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
            If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
                mensaje.Text = "Solo Puede Digitar Numeros"
            End If
        End If
    End Sub

    Private Sub c28p3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c28p3.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c28p2.Focus()
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
            If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
                mensaje.Text = "Solo Puede Digitar Numeros"
            End If
        End If
    End Sub

    Private Sub c29p3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c29p3.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c29p2.Focus()
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
            If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
                mensaje.Text = "Solo Puede Digitar Numeros"
            End If
        End If
    End Sub

    Private Sub c30p3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c30p3.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c30p2.Focus()
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
            If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
                mensaje.Text = "Solo Puede Digitar Numeros"
            End If
        End If
    End Sub

    Private Sub c31p3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c31p3.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c31p2.Focus()
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
            If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
                mensaje.Text = "Solo Puede Digitar Numeros"
            End If
        End If
    End Sub

    Private Sub c32p3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c32p3.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c32p2.Focus()
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
            If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
                mensaje.Text = "Solo Puede Digitar Numeros"
            End If
        End If
    End Sub

    Private Sub c33p3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c33p3.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c33p2.Focus()
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
            If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
                mensaje.Text = "Solo Puede Digitar Numeros"
            End If
        End If
    End Sub

    Private Sub c34p3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c34p3.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c34p2.Focus()
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
            If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
                mensaje.Text = "Solo Puede Digitar Numeros"
            End If
        End If
    End Sub

    Private Sub c35p3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c35p3.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c35p2.Focus()
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
            If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
                mensaje.Text = "Solo Puede Digitar Numeros"
            End If
        End If
    End Sub

    Private Sub c36p3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c36p3.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c36p2.Focus()
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
            If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
                mensaje.Text = "Solo Puede Digitar Numeros"
            End If
        End If
    End Sub

    Private Sub c37p3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c37p3.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c37p2.Focus()
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
            If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
                mensaje.Text = "Solo Puede Digitar Numeros"
            End If
        End If
    End Sub

    Private Sub c38p3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c38p3.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c38p2.Focus()
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
            If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
                mensaje.Text = "Solo Puede Digitar Numeros"
            End If
        End If
    End Sub

    Private Sub c39p3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c39p3.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c39p2.Focus()
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
            If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
                mensaje.Text = "Solo Puede Digitar Numeros"
            End If
        End If
    End Sub

    Private Sub c40p3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c40p3.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c40p2.Focus()
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
            If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
                mensaje.Text = "Solo Puede Digitar Numeros"
            End If
        End If
    End Sub

    Private Sub c1p2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c1p2.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c1.Focus()
        End If
    End Sub

    Private Sub c2p2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c2p2.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c2.Focus()
        End If
    End Sub

    Private Sub c3p2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c3p2.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c3.Focus()
        End If
    End Sub

    Private Sub c4p2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c4p2.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c4.Focus()
        End If
    End Sub

    Private Sub c5p2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c5p2.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c5.Focus()
        End If
    End Sub

    Private Sub c6p2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c6p2.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c6.Focus()
        End If
    End Sub

    Private Sub c7p2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c7p2.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c7.Focus()
        End If
    End Sub

    Private Sub c8p2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c8p2.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c8.Focus()
        End If
    End Sub

    Private Sub c9p2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c9p2.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c9.Focus()
        End If
    End Sub

    Private Sub c10p2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c10p2.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c10.Focus()
        End If
    End Sub

    Private Sub c11p2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c11p2.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c11.Focus()
        End If
    End Sub

    Private Sub c12p2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c12p2.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c12.Focus()
        End If
    End Sub

    Private Sub c13p2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c13p2.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c13.Focus()
        End If
    End Sub

    Private Sub c14p2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c14p2.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c14.Focus()
        End If
    End Sub

    Private Sub c15p2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c15p2.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c15.Focus()
        End If
    End Sub

    Private Sub c16p2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c16p2.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c16.Focus()
        End If
    End Sub

    Private Sub c17p2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c17p2.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c17.Focus()
        End If
    End Sub

    Private Sub c18p2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c18p2.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c18.Focus()
        End If
    End Sub

    Private Sub c19p2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c19p2.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c19.Focus()
        End If
    End Sub

    Private Sub c20p2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c20p2.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c20.Focus()
        End If
    End Sub

    Private Sub c21p2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c21p2.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c21.Focus()
        End If
    End Sub

    Private Sub c22p2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c22p2.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c22.Focus()
        End If
    End Sub

    Private Sub c23p2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c23p2.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c23.Focus()
        End If
    End Sub

    Private Sub c24p2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c24p2.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c24.Focus()
        End If
    End Sub

    Private Sub c25p2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c25p2.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c25.Focus()
        End If
    End Sub

    Private Sub c26p2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c26p2.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c26.Focus()
        End If
    End Sub

    Private Sub c27p2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c27p2.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c27.Focus()
        End If
    End Sub

    Private Sub c28p2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c28p2.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c28.Focus()
        End If
    End Sub

    Private Sub c29p2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c29p2.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c29.Focus()
        End If
    End Sub

    Private Sub c30p2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c30p2.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c30.Focus()
        End If
    End Sub

    Private Sub c31p2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c31p2.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c31.Focus()
        End If
    End Sub

    Private Sub c32p2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c32p2.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c32.Focus()
        End If
    End Sub

    Private Sub c33p2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c33p2.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c33.Focus()
        End If
    End Sub

    Private Sub c34p2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c34p2.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c34.Focus()
        End If
    End Sub

    Private Sub c35p2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c35p2.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c35.Focus()
        End If
    End Sub

    Private Sub c36p2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c36p2.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c36.Focus()
        End If
    End Sub

    Private Sub c37p2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c37p2.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c37.Focus()
        End If
    End Sub

    Private Sub c38p2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c38p2.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c38.Focus()
        End If
    End Sub

    Private Sub c39p2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c39p2.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c39.Focus()
        End If
    End Sub

    Private Sub c40p2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c40p2.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            c40.Focus()
        End If
    End Sub

    Private Sub c2p3_TextChanged(sender As Object, e As EventArgs) Handles c2p3.TextChanged
        If c2p3.Text <> Nothing Then
            c2p3.Enabled = True
        End If
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double

        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub c2p2_TextChanged(sender As Object, e As EventArgs) Handles c2p2.TextChanged
        If c2p2.Text <> Nothing Then
            c2p2.Enabled = True
        End If
    End Sub

    Private Sub c2_TextChanged(sender As Object, e As EventArgs) Handles c2.TextChanged
        If c2.Text <> Nothing Then
            c2.Enabled = True
        End If
    End Sub

    Private Sub c3p3_TextChanged(sender As Object, e As EventArgs) Handles c3p3.TextChanged
        If c3p3.Text <> Nothing Then
            c3p3.Enabled = True
        End If
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double

        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub c3p2_TextChanged(sender As Object, e As EventArgs) Handles c3p2.TextChanged
        If c3p2.Text <> Nothing Then
            c3p2.Enabled = True
        End If
    End Sub

    Private Sub c4p3_TextChanged(sender As Object, e As EventArgs) Handles c4p3.TextChanged
        If c4p3.Text <> Nothing Then
            c4p3.Enabled = True
        End If
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double

        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub c4p2_TextChanged(sender As Object, e As EventArgs) Handles c4p2.TextChanged
        If c4p2.Text <> Nothing Then
            c4p2.Enabled = True
        End If
    End Sub

    Private Sub c5p3_TextChanged(sender As Object, e As EventArgs) Handles c5p3.TextChanged
        If c5p3.Text <> Nothing Then
            c5p3.Enabled = True
        End If
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double

        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub c5p2_TextChanged(sender As Object, e As EventArgs) Handles c5p2.TextChanged
        If c5p2.Text <> Nothing Then
            c5p2.Enabled = True
        End If
    End Sub

    Private Sub c6p3_TextChanged(sender As Object, e As EventArgs) Handles c6p3.TextChanged
        If c6p3.Text <> Nothing Then
            c6p3.Enabled = True
        End If
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double

        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub c6p2_TextChanged(sender As Object, e As EventArgs) Handles c6p2.TextChanged
        If c6p2.Text <> Nothing Then
            c6p2.Enabled = True
        End If
    End Sub

    Private Sub c7p3_TextChanged(sender As Object, e As EventArgs) Handles c7p3.TextChanged
        If c7p3.Text <> Nothing Then
            c7p3.Enabled = True
        End If
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double

        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub c7p2_TextChanged(sender As Object, e As EventArgs) Handles c7p2.TextChanged
        If c7p2.Text <> Nothing Then
            c7p2.Enabled = True
        End If
    End Sub

    Private Sub c8p3_TextChanged(sender As Object, e As EventArgs) Handles c8p3.TextChanged
        If c8p3.Text <> Nothing Then
            c8p3.Enabled = True
        End If
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double

        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub c8p2_TextChanged(sender As Object, e As EventArgs) Handles c8p2.TextChanged
        If c8p2.Text <> Nothing Then
            c8p2.Enabled = True
        End If
    End Sub

    Private Sub c9p3_TextChanged(sender As Object, e As EventArgs) Handles c9p3.TextChanged
        If c9p3.Text <> Nothing Then
            c9p3.Enabled = True
        End If
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double

        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub c9p2_TextChanged(sender As Object, e As EventArgs) Handles c9p2.TextChanged
        If c9p2.Text <> Nothing Then
            c9p2.Enabled = True
        End If
    End Sub

    Private Sub c10p3_TextChanged(sender As Object, e As EventArgs) Handles c10p3.TextChanged
        If c10p3.Text <> Nothing Then
            c10p3.Enabled = True
        End If
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double

        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub c10p2_TextChanged(sender As Object, e As EventArgs) Handles c10p2.TextChanged
        If c10p2.Text <> Nothing Then
            c10p2.Enabled = True
        End If
    End Sub

    Private Sub c11p3_TextChanged(sender As Object, e As EventArgs) Handles c11p3.TextChanged
        If c11p3.Text <> Nothing Then
            c11p3.Enabled = True
        End If
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double

        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub c11p2_TextChanged(sender As Object, e As EventArgs) Handles c11p2.TextChanged
        If c11p2.Text <> Nothing Then
            c11p2.Enabled = True
        End If
    End Sub

    Private Sub c12p3_TextChanged(sender As Object, e As EventArgs) Handles c12p3.TextChanged
        If c12p3.Text <> Nothing Then
            c12p3.Enabled = True
        End If
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double

        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub c12p2_TextChanged(sender As Object, e As EventArgs) Handles c12p2.TextChanged
        If c12p2.Text <> Nothing Then
            c12p2.Enabled = True
        End If
    End Sub

    Private Sub c13p3_TextChanged(sender As Object, e As EventArgs) Handles c13p3.TextChanged
        If c13p3.Text <> Nothing Then
            c13p3.Enabled = True
        End If
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double

        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub c13p2_TextChanged(sender As Object, e As EventArgs) Handles c13p2.TextChanged
        If c13p2.Text <> Nothing Then
            c13p2.Enabled = True
        End If
    End Sub

    Private Sub c14p3_TextChanged(sender As Object, e As EventArgs) Handles c14p3.TextChanged
        If c14p3.Text <> Nothing Then
            c14p3.Enabled = True
        End If
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double

        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub c14p2_TextChanged(sender As Object, e As EventArgs) Handles c14p2.TextChanged
        If c14p2.Text <> Nothing Then
            c14p2.Enabled = True
        End If
    End Sub

    Private Sub c15p3_TextChanged(sender As Object, e As EventArgs) Handles c15p3.TextChanged
        If c15p3.Text <> Nothing Then
            c15p3.Enabled = True
        End If
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double

        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub c15p2_TextChanged(sender As Object, e As EventArgs) Handles c15p2.TextChanged
        If c15p2.Text <> Nothing Then
            c15p2.Enabled = True
        End If
    End Sub

    Private Sub c16p3_TextChanged(sender As Object, e As EventArgs) Handles c16p3.TextChanged
        If c16p3.Text <> Nothing Then
            c16p3.Enabled = True
        End If
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double

        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub c16p2_TextChanged(sender As Object, e As EventArgs) Handles c16p2.TextChanged
        If c16p2.Text <> Nothing Then
            c16p2.Enabled = True
        End If
    End Sub

    Private Sub c17p3_TextChanged(sender As Object, e As EventArgs) Handles c17p3.TextChanged
        If c17p3.Text <> Nothing Then
            c17p3.Enabled = True
        End If
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double

        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub c17p2_TextChanged(sender As Object, e As EventArgs) Handles c17p2.TextChanged
        If c17p2.Text <> Nothing Then
            c17p2.Enabled = True
        End If
    End Sub

    Private Sub c18p3_TextChanged(sender As Object, e As EventArgs) Handles c18p3.TextChanged
        If c18p3.Text <> Nothing Then
            c18p3.Enabled = True
        End If
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double

        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub c18p2_TextChanged(sender As Object, e As EventArgs) Handles c18p2.TextChanged
        If c18p2.Text <> Nothing Then
            c18p2.Enabled = True
        End If
    End Sub

    Private Sub c19p3_TextChanged(sender As Object, e As EventArgs) Handles c19p3.TextChanged
        If c19p3.Text <> Nothing Then
            c19p3.Enabled = True
        End If
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double

        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub c19p2_TextChanged(sender As Object, e As EventArgs) Handles c19p2.TextChanged
        If c19p2.Text <> Nothing Then
            c19p2.Enabled = True
        End If
    End Sub

    Private Sub c20p3_TextChanged(sender As Object, e As EventArgs) Handles c20p3.TextChanged
        If c20p3.Text <> Nothing Then
            c20p3.Enabled = True
        End If
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double

        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub c20p2_TextChanged(sender As Object, e As EventArgs) Handles c20p2.TextChanged
        If c20p2.Text <> Nothing Then
            c20p2.Enabled = True
        End If
    End Sub

    Private Sub c21p3_TextChanged(sender As Object, e As EventArgs) Handles c21p3.TextChanged
        If c21p3.Text <> Nothing Then
            c21p3.Enabled = True
        End If
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double

        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub c21p2_TextChanged(sender As Object, e As EventArgs) Handles c21p2.TextChanged
        If c21p2.Text <> Nothing Then
            c21p2.Enabled = True
        End If
    End Sub

    Private Sub c22p3_TextChanged(sender As Object, e As EventArgs) Handles c22p3.TextChanged
        If c22p3.Text <> Nothing Then
            c22p3.Enabled = True
        End If
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double

        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub c22p2_TextChanged(sender As Object, e As EventArgs) Handles c22p2.TextChanged
        If c22p2.Text <> Nothing Then
            c22p2.Enabled = True
        End If
    End Sub

    Private Sub c23p3_TextChanged(sender As Object, e As EventArgs) Handles c23p3.TextChanged
        If c23p3.Text <> Nothing Then
            c23p3.Enabled = True
        End If
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double

        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub c23p2_TextChanged(sender As Object, e As EventArgs) Handles c23p2.TextChanged
        If c23p2.Text <> Nothing Then
            c23p2.Enabled = True
        End If
    End Sub

    Private Sub c24p3_TextChanged(sender As Object, e As EventArgs) Handles c24p3.TextChanged
        If c24p3.Text <> Nothing Then
            c24p3.Enabled = True
        End If
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double

        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub c24p2_TextChanged(sender As Object, e As EventArgs) Handles c24p2.TextChanged
        If c24p2.Text <> Nothing Then
            c24p2.Enabled = True
        End If
    End Sub

    Private Sub c25p3_TextChanged(sender As Object, e As EventArgs) Handles c25p3.TextChanged
        If c25p3.Text <> Nothing Then
            c25p3.Enabled = True
        End If
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double

        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub c25p2_TextChanged(sender As Object, e As EventArgs) Handles c25p2.TextChanged
        If c25p2.Text <> Nothing Then
            c25p2.Enabled = True
        End If
    End Sub

    Private Sub c26p3_TextChanged(sender As Object, e As EventArgs) Handles c26p3.TextChanged
        If c26p3.Text <> Nothing Then
            c26p3.Enabled = True
        End If
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double

        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub c26p2_TextChanged(sender As Object, e As EventArgs) Handles c26p2.TextChanged
        If c26p2.Text <> Nothing Then
            c26p2.Enabled = True
        End If
    End Sub

    Private Sub c27p3_TextChanged(sender As Object, e As EventArgs) Handles c27p3.TextChanged
        If c27p3.Text <> Nothing Then
            c27p3.Enabled = True
        End If
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double

        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub c27p2_TextChanged(sender As Object, e As EventArgs) Handles c27p2.TextChanged
        If c27p2.Text <> Nothing Then
            c27p2.Enabled = True
        End If
    End Sub

    Private Sub c28p3_TextChanged(sender As Object, e As EventArgs) Handles c28p3.TextChanged
        If c28p3.Text <> Nothing Then
            c28p3.Enabled = True
        End If
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double

        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub c28p2_TextChanged(sender As Object, e As EventArgs) Handles c28p2.TextChanged
        If c28p2.Text <> Nothing Then
            c28p2.Enabled = True
        End If
    End Sub

    Private Sub c29p3_TextChanged(sender As Object, e As EventArgs) Handles c29p3.TextChanged
        If c29p3.Text <> Nothing Then
            c29p3.Enabled = True
        End If
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double

        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub c29p2_TextChanged(sender As Object, e As EventArgs) Handles c29p2.TextChanged
        If c29p2.Text <> Nothing Then
            c29p2.Enabled = True
        End If
    End Sub

    Private Sub c30p3_TextChanged(sender As Object, e As EventArgs) Handles c30p3.TextChanged
        If c30p3.Text <> Nothing Then
            c30p3.Enabled = True
        End If
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double

        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub c30p2_TextChanged(sender As Object, e As EventArgs) Handles c30p2.TextChanged
        If c30p2.Text <> Nothing Then
            c30p2.Enabled = True
        End If
    End Sub

    Private Sub c31p3_TextChanged(sender As Object, e As EventArgs) Handles c31p3.TextChanged
        If c31p3.Text <> Nothing Then
            c31p3.Enabled = True
        End If
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double

        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub c31p2_TextChanged(sender As Object, e As EventArgs) Handles c31p2.TextChanged
        If c31p2.Text <> Nothing Then
            c31p2.Enabled = True
        End If
    End Sub

    Private Sub c32p3_TextChanged(sender As Object, e As EventArgs) Handles c32p3.TextChanged
        If c32p3.Text <> Nothing Then
            c32p3.Enabled = True
        End If
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double

        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub c32p2_TextChanged(sender As Object, e As EventArgs) Handles c32p2.TextChanged
        If c32p2.Text <> Nothing Then
            c32p2.Enabled = True
        End If
    End Sub

    Private Sub c33p3_TextChanged(sender As Object, e As EventArgs) Handles c33p3.TextChanged
        If c33p3.Text <> Nothing Then
            c33p3.Enabled = True
        End If
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double

        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub c33p2_TextChanged(sender As Object, e As EventArgs) Handles c33p2.TextChanged
        If c33p2.Text <> Nothing Then
            c33p2.Enabled = True
        End If
    End Sub

    Private Sub c34p3_TextChanged(sender As Object, e As EventArgs) Handles c34p3.TextChanged
        If c34p3.Text <> Nothing Then
            c34p3.Enabled = True
        End If
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double

        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub c34p2_TextChanged(sender As Object, e As EventArgs) Handles c34p2.TextChanged
        If c34p2.Text <> Nothing Then
            c34p2.Enabled = True
        End If
    End Sub

    Private Sub c35p3_TextChanged(sender As Object, e As EventArgs) Handles c35p3.TextChanged
        If c35p3.Text <> Nothing Then
            c35p3.Enabled = True
        End If
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double

        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub c35p2_TextChanged(sender As Object, e As EventArgs) Handles c35p2.TextChanged
        If c35p2.Text <> Nothing Then
            c35p2.Enabled = True
        End If
    End Sub

    Private Sub c36p3_TextChanged(sender As Object, e As EventArgs) Handles c36p3.TextChanged
        If c36p3.Text <> Nothing Then
            c36p3.Enabled = True
        End If
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double

        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub c36p2_TextChanged(sender As Object, e As EventArgs) Handles c36p2.TextChanged
        If c36p2.Text <> Nothing Then
            c36p2.Enabled = True
        End If
    End Sub

    Private Sub c37p3_TextChanged(sender As Object, e As EventArgs) Handles c37p3.TextChanged
        If c37p3.Text <> Nothing Then
            c37p3.Enabled = True
        End If
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double

        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub c37p2_TextChanged(sender As Object, e As EventArgs) Handles c37p2.TextChanged
        If c37p2.Text <> Nothing Then
            c37p2.Enabled = True
        End If
    End Sub

    Private Sub c38p3_TextChanged(sender As Object, e As EventArgs) Handles c38p3.TextChanged
        If c38p3.Text <> Nothing Then
            c38p3.Enabled = True
        End If
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double

        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub c38p2_TextChanged(sender As Object, e As EventArgs) Handles c38p2.TextChanged
        If c38p2.Text <> Nothing Then
            c38p2.Enabled = True
        End If
    End Sub

    Private Sub c39p3_TextChanged(sender As Object, e As EventArgs) Handles c39p3.TextChanged
        If c39p3.Text <> Nothing Then
            c39p3.Enabled = True
        End If
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double

        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub c39p2_TextChanged(sender As Object, e As EventArgs) Handles c39p2.TextChanged
        If c39p2.Text <> Nothing Then
            c39p2.Enabled = True
        End If
    End Sub

    Private Sub c40p3_TextChanged(sender As Object, e As EventArgs) Handles c40p3.TextChanged
        If c40p3.Text <> Nothing Then
            c40p3.Enabled = True
        End If
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double

        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub c40p2_TextChanged(sender As Object, e As EventArgs) Handles c40p2.TextChanged
        If c40p2.Text <> Nothing Then
            c40p2.Enabled = True
        End If
    End Sub

    Private Sub c3_TextChanged(sender As Object, e As EventArgs) Handles c3.TextChanged
        If c3.Text <> Nothing Then
            c3.Enabled = True
        End If
    End Sub

    Private Sub c4_TextChanged(sender As Object, e As EventArgs) Handles c4.TextChanged
        If c4.Text <> Nothing Then
            c4.Enabled = True
        End If
    End Sub

    Private Sub c5_TextChanged(sender As Object, e As EventArgs) Handles c5.TextChanged
        If c5.Text <> Nothing Then
            c5.Enabled = True
        End If
    End Sub

    Private Sub c6_TextChanged(sender As Object, e As EventArgs) Handles c6.TextChanged
        If c6.Text <> Nothing Then
            c6.Enabled = True
        End If
    End Sub

    Private Sub c7_TextChanged(sender As Object, e As EventArgs) Handles c7.TextChanged
        If c7.Text <> Nothing Then
            c7.Enabled = True
        End If
    End Sub

    Private Sub c8_TextChanged(sender As Object, e As EventArgs) Handles c8.TextChanged
        If c8.Text <> Nothing Then
            c8.Enabled = True
        End If
    End Sub

    Private Sub c9_TextChanged(sender As Object, e As EventArgs) Handles c9.TextChanged
        If c9.Text <> Nothing Then
            c9.Enabled = True
        End If
    End Sub

    Private Sub c10_TextChanged(sender As Object, e As EventArgs) Handles c10.TextChanged
        If c10.Text <> Nothing Then
            c10.Enabled = True
        End If
    End Sub

    Private Sub c11_TextChanged(sender As Object, e As EventArgs) Handles c11.TextChanged
        If c11.Text <> Nothing Then
            c11.Enabled = True
        End If
    End Sub

    Private Sub c12_TextChanged(sender As Object, e As EventArgs) Handles c12.TextChanged
        If c12.Text <> Nothing Then
            c12.Enabled = True
        End If
    End Sub

    Private Sub c13_TextChanged(sender As Object, e As EventArgs) Handles c13.TextChanged
        If c13.Text <> Nothing Then
            c13.Enabled = True
        End If
    End Sub

    Private Sub c14_TextChanged(sender As Object, e As EventArgs) Handles c14.TextChanged
        If c14.Text <> Nothing Then
            c14.Enabled = True
        End If
    End Sub

    Private Sub c15_TextChanged(sender As Object, e As EventArgs) Handles c15.TextChanged
        If c15.Text <> Nothing Then
            c15.Enabled = True
        End If
    End Sub

    Private Sub c16_TextChanged(sender As Object, e As EventArgs) Handles c16.TextChanged
        If c16.Text <> Nothing Then
            c16.Enabled = True
        End If
    End Sub

    Private Sub c17_TextChanged(sender As Object, e As EventArgs) Handles c17.TextChanged
        If c17.Text <> Nothing Then
            c17.Enabled = True
        End If
    End Sub

    Private Sub c18_TextChanged(sender As Object, e As EventArgs) Handles c18.TextChanged
        If c18.Text <> Nothing Then
            c18.Enabled = True
        End If
    End Sub

    Private Sub c19_TextChanged(sender As Object, e As EventArgs) Handles c19.TextChanged
        If c19.Text <> Nothing Then
            c19.Enabled = True
        End If
    End Sub

    Private Sub c20_TextChanged(sender As Object, e As EventArgs) Handles c20.TextChanged
        If c20.Text <> Nothing Then
            c20.Enabled = True
        End If
    End Sub

    Private Sub c21_TextChanged(sender As Object, e As EventArgs) Handles c21.TextChanged
        If c21.Text <> Nothing Then
            c21.Enabled = True
        End If
    End Sub

    Private Sub c22_TextChanged(sender As Object, e As EventArgs) Handles c22.TextChanged
        If c22.Text <> Nothing Then
            c22.Enabled = True
        End If
    End Sub

    Private Sub c23_TextChanged(sender As Object, e As EventArgs) Handles c23.TextChanged
        If c23.Text <> Nothing Then
            c23.Enabled = True
        End If
    End Sub

    Private Sub c24_TextChanged(sender As Object, e As EventArgs) Handles c24.TextChanged
        If c24.Text <> Nothing Then
            c24.Enabled = True
        End If
    End Sub

    Private Sub c25_TextChanged(sender As Object, e As EventArgs) Handles c25.TextChanged
        If c25.Text <> Nothing Then
            c25.Enabled = True
        End If
    End Sub

    Private Sub c26_TextChanged(sender As Object, e As EventArgs) Handles c26.TextChanged
        If c26.Text <> Nothing Then
            c26.Enabled = True
        End If
    End Sub

    Private Sub c27_TextChanged(sender As Object, e As EventArgs) Handles c27.TextChanged
        If c27.Text <> Nothing Then
            c27.Enabled = True
        End If
    End Sub

    Private Sub c28_TextChanged(sender As Object, e As EventArgs) Handles c28.TextChanged
        If c28.Text <> Nothing Then
            c28.Enabled = True
        End If
    End Sub

    Private Sub c29_TextChanged(sender As Object, e As EventArgs) Handles c29.TextChanged
        If c29.Text <> Nothing Then
            c29.Enabled = True
        End If
    End Sub

    Private Sub c30_TextChanged(sender As Object, e As EventArgs) Handles c30.TextChanged
        If c30.Text <> Nothing Then
            c30.Enabled = True
        End If
    End Sub

    Private Sub c31_TextChanged(sender As Object, e As EventArgs) Handles c31.TextChanged
        If c31.Text <> Nothing Then
            c31.Enabled = True
        End If
    End Sub

    Private Sub c32_TextChanged(sender As Object, e As EventArgs) Handles c32.TextChanged
        If c32.Text <> Nothing Then
            c32.Enabled = True
        End If
    End Sub

    Private Sub c33_TextChanged(sender As Object, e As EventArgs) Handles c33.TextChanged
        If c33.Text <> Nothing Then
            c33.Enabled = True
        End If
    End Sub

    Private Sub c34_TextChanged(sender As Object, e As EventArgs) Handles c34.TextChanged
        If c34.Text <> Nothing Then
            c34.Enabled = True
        End If
    End Sub

    Private Sub c35_TextChanged(sender As Object, e As EventArgs) Handles c35.TextChanged
        If c35.Text <> Nothing Then
            c35.Enabled = True
        End If
    End Sub

    Private Sub c36_TextChanged(sender As Object, e As EventArgs) Handles c36.TextChanged
        If c36.Text <> Nothing Then
            c36.Enabled = True
        End If
    End Sub

    Private Sub c37_TextChanged(sender As Object, e As EventArgs) Handles c37.TextChanged
        If c37.Text <> Nothing Then
            c37.Enabled = True
        End If
    End Sub

    Private Sub c38_TextChanged(sender As Object, e As EventArgs) Handles c38.TextChanged
        If c38.Text <> Nothing Then
            c38.Enabled = True
        End If
    End Sub

    Private Sub c39_TextChanged(sender As Object, e As EventArgs) Handles c39.TextChanged
        If c39.Text <> Nothing Then
            c39.Enabled = True
        End If
    End Sub

    Private Sub c40_TextChanged(sender As Object, e As EventArgs) Handles c40.TextChanged
        If c40.Text <> Nothing Then
            c40.Enabled = True
        End If
    End Sub

    Private Sub c1p3_TextChanged(sender As Object, e As EventArgs) Handles c1p3.TextChanged
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double

        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub lblsub_TextChanged(sender As Object, e As EventArgs) Handles lblsub.TextChanged
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double

        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub lbldesc_TextChanged(sender As Object, e As EventArgs) Handles lbldesc.TextChanged
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double

        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub lblisv_TextChanged(sender As Object, e As EventArgs) Handles lblisv.TextChanged
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double

        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub lblmenrete_TextChanged(sender As Object, e As EventArgs) Handles lblmenrete.TextChanged
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double

        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

    Private Sub lbltotal_TextChanged(sender As Object, e As EventArgs) Handles lbltotal.TextChanged
        Dim t1 As Double, t2 As Double, t3 As Double, t4 As Double, t5 As Double, t6 As Double, t7 As Double, t8 As Double, t9 As Double, t10 As Double
        Dim t11 As Double, t12 As Double, t13 As Double, t14 As Double, t15 As Double, t16 As Double, t17 As Double, t18 As Double, t19 As Double, t20 As Double
        Dim t21 As Double, t22 As Double, t23 As Double, t24 As Double, t25 As Double, t26 As Double, t27 As Double, t28 As Double, t29 As Double, t30 As Double
        Dim t31 As Double, t32 As Double, t33 As Double, t34 As Double, t35 As Double, t36 As Double, t37 As Double, t38 As Double, t39 As Double, t40 As Double
        Dim des1 As Double
        Dim rete1 As Double

        On Error Resume Next
        If IsNumeric(v1.Text) Then t1 = CDec(v1.Text)
        If IsNumeric(v2.Text) Then t2 = CDec(v2.Text)
        If IsNumeric(v3.Text) Then t3 = CDec(v3.Text)
        If IsNumeric(v4.Text) Then t4 = CDec(v4.Text)
        If IsNumeric(v5.Text) Then t5 = CDec(v5.Text)
        If IsNumeric(v6.Text) Then t6 = CDec(v6.Text)
        If IsNumeric(v7.Text) Then t7 = CDec(v7.Text)
        If IsNumeric(v8.Text) Then t8 = CDec(v8.Text)
        If IsNumeric(v9.Text) Then t9 = CDec(v9.Text)
        If IsNumeric(v10.Text) Then t10 = CDec(v10.Text)
        If IsNumeric(v11.Text) Then t11 = CDec(v11.Text)
        If IsNumeric(v12.Text) Then t12 = CDec(v12.Text)
        If IsNumeric(v13.Text) Then t13 = CDec(v13.Text)
        If IsNumeric(v14.Text) Then t14 = CDec(v14.Text)
        If IsNumeric(v15.Text) Then t15 = CDec(v15.Text)
        If IsNumeric(v16.Text) Then t16 = CDec(v16.Text)
        If IsNumeric(v17.Text) Then t17 = CDec(v17.Text)
        If IsNumeric(v18.Text) Then t18 = CDec(v18.Text)
        If IsNumeric(v19.Text) Then t19 = CDec(v19.Text)
        If IsNumeric(v20.Text) Then t20 = CDec(v20.Text)
        If IsNumeric(v21.Text) Then t21 = CDec(v21.Text)
        If IsNumeric(v22.Text) Then t22 = CDec(v22.Text)
        If IsNumeric(v23.Text) Then t23 = CDec(v23.Text)
        If IsNumeric(v24.Text) Then t24 = CDec(v24.Text)
        If IsNumeric(v25.Text) Then t25 = CDec(v25.Text)
        If IsNumeric(v26.Text) Then t26 = CDec(v26.Text)
        If IsNumeric(v27.Text) Then t27 = CDec(v27.Text)
        If IsNumeric(v28.Text) Then t28 = CDec(v28.Text)
        If IsNumeric(v29.Text) Then t29 = CDec(v29.Text)
        If IsNumeric(v30.Text) Then t30 = CDec(v30.Text)
        If IsNumeric(v31.Text) Then t31 = CDec(v31.Text)
        If IsNumeric(v32.Text) Then t32 = CDec(v32.Text)
        If IsNumeric(v33.Text) Then t33 = CDec(v33.Text)
        If IsNumeric(v34.Text) Then t34 = CDec(v34.Text)
        If IsNumeric(v35.Text) Then t35 = CDec(v35.Text)
        If IsNumeric(v36.Text) Then t36 = CDec(v36.Text)
        If IsNumeric(v37.Text) Then t37 = CDec(v37.Text)
        If IsNumeric(v38.Text) Then t38 = CDec(v38.Text)
        If IsNumeric(v39.Text) Then t39 = CDec(v39.Text)
        If IsNumeric(v40.Text) Then t40 = CDec(v40.Text)
        If IsNumeric(lbldesc.Text) Then des1 = CDec(lbldesc.Text)
        If IsNumeric(lblmenrete.Text) Then rete1 = CDec(lblmenrete.Text)
        t1 = t1 * c1p3.Text
        t2 = t2 * c2p3.Text
        t3 = t3 * c3p3.Text
        t4 = t4 * c4p3.Text
        t5 = t5 * c5p3.Text
        t6 = t6 * c6p3.Text
        t7 = t7 * c7p3.Text
        t8 = t8 * c8p3.Text
        t9 = t9 * c9p3.Text
        t10 = t10 * c10p3.Text
        t11 = t11 * c11p3.Text
        t12 = t12 * c12p3.Text
        t13 = t13 * c13p3.Text
        t14 = t14 * c14p3.Text
        t15 = t15 * c15p3.Text
        t16 = t16 * c16p3.Text
        t17 = t17 * c17p3.Text
        t18 = t18 * c18p3.Text
        t19 = t19 * c19p3.Text
        t20 = t20 * c20p3.Text
        t21 = t21 * c21p3.Text
        t22 = t22 * c22p3.Text
        t23 = t23 * c23p3.Text
        t24 = t24 * c24p3.Text
        t25 = t25 * c25p3.Text
        t26 = t26 * c26p3.Text
        t27 = t27 * c27p3.Text
        t28 = t28 * c28p3.Text
        t29 = t29 * c29p3.Text
        t30 = t30 * c30p3.Text
        t31 = t31 * c31p3.Text
        t32 = t32 * c32p3.Text
        t33 = t33 * c33p3.Text
        t34 = t34 * c34p3.Text
        t35 = t35 * c35p3.Text
        t36 = t36 * c36p3.Text
        t37 = t37 * c37p3.Text
        t38 = t38 * c38p3.Text
        t39 = t39 * c39p3.Text
        t40 = t40 * c40p3.Text
        lblmenrete.Text = treten.Text
        lbldesc.Text = tdesc.Text
        lblsub.Text = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17 + t18 + t19 + t20 + t21 + t22 + t23 + t24 + t25 + t26 + t27 + t28 + t29 + t30 + t31 + t32 + t33 + t34 + t35 + t36 + t37 + t38 + t39 + t40
        lblisv.Text = lblsub.Text * 0.15
        lbltotal.Text = lblsub.Text - lbldesc.Text + lblisv.Text

    End Sub

End Class