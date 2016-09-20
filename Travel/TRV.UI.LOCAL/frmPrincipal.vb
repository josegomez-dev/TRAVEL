Imports System.Drawing
Imports System.Windows.Forms
Imports TRV.API.CORE
Imports TRV.Entidades

Public Class frmPrincipal
    Private rolesPermisos As New RolesPermisos()

    'Botones de CONFIGURACIÓN
    Private boton1 As Button
    Private boton2 As Button
    Private boton3 As Button
    Private boton4 As Button
    Private boton5 As Button
    Private boton6 As Button
    Private boton7 As Button

    'Botones de REPORTES
    Private boton8 As Button
    Private boton9 As Button
    Private boton10 As Button
    Private boton11 As Button
    Private boton12 As Button
    Private boton13 As Button
    Private boton14 As Button
    Private boton15 As Button

    'Botones de SEGURIDAD
    Private boton16 As Button
    Private boton17 As Button

    'Panel de MENÚ IZQUIERDO
    Private panel As Panel

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFecha.Text = DateTime.Now.ToShortDateString()
        lblHora.Text = DateTime.Now.ToLongTimeString()

        Dim gestorPuesto As New GestorPuesto(usuarioActual)
        Dim puesto As New Puesto()
        puesto = gestorPuesto.RetrievePuestoById(usuarioActual.Puesto)

        lblUsuario.Text = usuarioActual.Nombre + " (" + puesto.Nombre + ")"

        If rolesPermisos.PermisoUsuario(RolesPermisos.VentanasIDS.dashboard) Then
            CerrarTodos()
            VolverEstiloIconos(btnDashboard)

            Me.Controls.Remove(panel)

            Dim frmDashboard As New frmDashboard()
            frmDashboard.MdiParent = Me
            frmDashboard.Show()
        End If
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        lblHora.Text = DateTime.Now.ToShortTimeString
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub lnkCerrarSesion_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkCerrarSesion.LinkClicked
        usuarioActual = Nothing
        Dim frm As New frmInicio()
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub CerrarTodos()
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    'MOSTRANDO LOS ELEMENTOS CORRESPONDIENTES A CADA MÓDULO
    '---- DASHBOARD ----
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        If rolesPermisos.PermisoUsuario(RolesPermisos.VentanasIDS.dashboard) Then
            CerrarTodos()
            VolverEstiloIconos(btnDashboard)

            Me.Controls.Remove(panel)

            Dim frmDashboard As New frmDashboard()
            frmDashboard.MdiParent = Me
            frmDashboard.Show()
        End If
    End Sub

    '---- CONFIGURACIÓN ----
    Private Sub btnConfiguracion_Click(sender As Object, e As EventArgs) Handles btnConfiguracion.Click
        CerrarTodos()
        VolverEstiloIconos(btnConfiguracion)

        Me.Controls.Remove(panel)
        panel = CrearPanelMenuIzquierdo()

        If rolesPermisos.PermisoUsuario(RolesPermisos.VentanasIDS.empresa) Then
            boton1 = CrearBoton("Empresa", "btnEmpresa", 0, 0)
            AddHandler boton1.Click, AddressOf boton1_Click
            AddHandler boton1.MouseLeave, AddressOf boton1_MouseLeave
            AddHandler boton1.MouseMove, AddressOf boton1_MouseMove
            panel.Controls.Add(boton1)
        End If

        If rolesPermisos.PermisoUsuario(RolesPermisos.VentanasIDS.estacion) Then
            boton2 = CrearBoton("Estaciones", "btnEstacion", 0, 44)
            AddHandler boton2.Click, AddressOf boton2_Click
            AddHandler boton2.MouseLeave, AddressOf boton2_MouseLeave
            AddHandler boton2.MouseMove, AddressOf boton2_MouseMove
            panel.Controls.Add(boton2)
        End If

        If rolesPermisos.PermisoUsuario(RolesPermisos.VentanasIDS.linea) Then
            boton3 = CrearBoton("Líneas", "btnLinea", 0, 88)
            AddHandler boton3.Click, AddressOf boton3_Click
            AddHandler boton3.MouseLeave, AddressOf boton3_MouseLeave
            AddHandler boton3.MouseMove, AddressOf boton3_MouseMove
            panel.Controls.Add(boton3)
        End If

        If rolesPermisos.PermisoUsuario(RolesPermisos.VentanasIDS.tren) Then
            boton4 = CrearBoton("Trenes", "btnTren", 0, 132)
            AddHandler boton4.Click, AddressOf boton4_Click
            AddHandler boton4.MouseLeave, AddressOf boton4_MouseLeave
            AddHandler boton4.MouseMove, AddressOf boton4_MouseMove
            panel.Controls.Add(boton4)
        End If

        If rolesPermisos.PermisoUsuario(RolesPermisos.VentanasIDS.vagon) Then
            boton5 = CrearBoton("Vagones", "btnVagon", 0, 176)
            AddHandler boton5.Click, AddressOf boton5_Click
            AddHandler boton5.MouseLeave, AddressOf boton5_MouseLeave
            AddHandler boton5.MouseMove, AddressOf boton5_MouseMove
            panel.Controls.Add(boton5)
        End If

        If rolesPermisos.PermisoUsuario(RolesPermisos.VentanasIDS.puesto) Then
            boton6 = CrearBoton("Puestos", "btnPuesto", 0, 220)
            AddHandler boton6.Click, AddressOf boton6_Click
            AddHandler boton6.MouseLeave, AddressOf boton6_MouseLeave
            AddHandler boton6.MouseMove, AddressOf boton6_MouseMove
            panel.Controls.Add(boton6)
        End If

        If rolesPermisos.PermisoUsuario(RolesPermisos.VentanasIDS.tipoTiquete) Then
            boton7 = CrearBoton("Tipos de tiquete", "btnTTiquete", 0, 264)
            AddHandler boton7.Click, AddressOf boton7_Click
            AddHandler boton7.MouseLeave, AddressOf boton7_MouseLeave
            AddHandler boton7.MouseMove, AddressOf boton7_MouseMove
            panel.Controls.Add(boton7)
        End If
    End Sub

    '---- REPORTES ----
    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        CerrarTodos()
        VolverEstiloIconos(btnReportes)

        Me.Controls.Remove(panel)
        panel = CrearPanelMenuIzquierdo()

        If rolesPermisos.PermisoUsuario(RolesPermisos.VentanasIDS.bitacora) Then
            boton8 = CrearBoton("Bitácora de acciones", "btnRBitacora", 0, 0)
            AddHandler boton8.Click, AddressOf boton8_Click
            AddHandler boton8.MouseLeave, AddressOf boton8_MouseLeave
            AddHandler boton8.MouseMove, AddressOf boton8_MouseMove
            panel.Controls.Add(boton8)
        End If

        If rolesPermisos.PermisoUsuario(RolesPermisos.VentanasIDS.r_ingresos) Then
            boton9 = CrearBoton("Ingresos", "btnRIngresos", 0, 44)
            AddHandler boton9.Click, AddressOf boton9_Click
            AddHandler boton9.MouseLeave, AddressOf boton9_MouseLeave
            AddHandler boton9.MouseMove, AddressOf boton9_MouseMove
            panel.Controls.Add(boton9)
        End If

        If rolesPermisos.PermisoUsuario(RolesPermisos.VentanasIDS.r_historialVagones) Then
            boton10 = CrearBoton("Historial de vagones", "btnRVagones", 0, 88)
            AddHandler boton10.Click, AddressOf boton10_Click
            AddHandler boton10.MouseLeave, AddressOf boton10_MouseLeave
            AddHandler boton10.MouseMove, AddressOf boton10_MouseMove
            panel.Controls.Add(boton10)
        End If

        If rolesPermisos.PermisoUsuario(RolesPermisos.VentanasIDS.r_cantPasajerosEstacion) Then
            boton11 = CrearBoton("Cantidad de pasajeros por estación", "btnRPasajerosEstacion", 0, 132)
            AddHandler boton11.Click, AddressOf boton11_Click
            AddHandler boton11.MouseLeave, AddressOf boton11_MouseLeave
            AddHandler boton11.MouseMove, AddressOf boton11_MouseMove
            panel.Controls.Add(boton11)
        End If

        If rolesPermisos.PermisoUsuario(RolesPermisos.VentanasIDS.r_tiempoTrabajoLinea) Then
            boton12 = CrearBoton("Tiempo de trabajo de la línea", "btnRTrabajooLinea", 0, 176)
            AddHandler boton12.Click, AddressOf boton12_Click
            AddHandler boton12.MouseLeave, AddressOf boton12_MouseLeave
            AddHandler boton12.MouseMove, AddressOf boton12_MouseMove
            panel.Controls.Add(boton12)
        End If

        If rolesPermisos.PermisoUsuario(RolesPermisos.VentanasIDS.r_tiempoBajaLinea) Then
            boton13 = CrearBoton("Tiempo de baja de la línea", "btnRBajaLinea", 0, 220)
            AddHandler boton13.Click, AddressOf boton13_Click
            AddHandler boton13.MouseLeave, AddressOf boton13_MouseLeave
            AddHandler boton13.MouseMove, AddressOf boton13_MouseMove
            panel.Controls.Add(boton13)
        End If

        If rolesPermisos.PermisoUsuario(RolesPermisos.VentanasIDS.r_porcenCapacidadInstalada) Then
            boton14 = CrearBoton("Porcentaje de capacidad instalada", "btnBCapacidadInstalada", 0, 264)
            AddHandler boton14.Click, AddressOf boton14_Click
            AddHandler boton14.MouseLeave, AddressOf boton14_MouseLeave
            AddHandler boton14.MouseMove, AddressOf boton14_MouseMove
            panel.Controls.Add(boton14)
        End If

        If rolesPermisos.PermisoUsuario(RolesPermisos.VentanasIDS.r_capacidadTrenEstacion) Then
            boton15 = CrearBoton("Capacidad del tren por estación", "btnBCapacidadTren", 0, 309)
            AddHandler boton15.Click, AddressOf boton15_Click
            AddHandler boton15.MouseLeave, AddressOf boton15_MouseLeave
            AddHandler boton15.MouseMove, AddressOf boton15_MouseMove
            panel.Controls.Add(boton15)
        End If
    End Sub

    '---- SEGURIDAD ----
    Private Sub btnSeguridad_Click(sender As Object, e As EventArgs) Handles btnSeguridad.Click
        CerrarTodos()
        VolverEstiloIconos(btnSeguridad)

        Me.Controls.Remove(panel)
        panel = CrearPanelMenuIzquierdo()

        If rolesPermisos.PermisoUsuario(RolesPermisos.VentanasIDS.usuarios) Then
            boton16 = CrearBoton("Usuarios", "btnUsuarios", 0, 0)
            AddHandler boton16.Click, AddressOf boton16_Click
            AddHandler boton16.MouseLeave, AddressOf boton16_MouseLeave
            AddHandler boton16.MouseMove, AddressOf boton16_MouseMove
            panel.Controls.Add(boton16)
        End If

        If rolesPermisos.PermisoUsuario(RolesPermisos.VentanasIDS.permiso) Then
            boton17 = CrearBoton("Permisos", "btnPermisos", 0, 44)
            AddHandler boton17.Click, AddressOf boton17_Click
            AddHandler boton17.MouseLeave, AddressOf boton17_MouseLeave
            AddHandler boton17.MouseMove, AddressOf boton17_MouseMove
            panel.Controls.Add(boton17)
        End If
    End Sub

    Private Function CrearPanelMenuIzquierdo() As Panel
        Dim panel As New Panel
        panel.Name = "pnlMenuIzquierdo"
        panel.Location = New Point(10, 95)
        panel.Size = New Size(184, 478)
        panel.BorderStyle = BorderStyle.None
        panel.BackColor = Color.FromArgb(153, 206, 195)
        Me.Controls.Add(panel)
        Return panel
    End Function

    Private Function CrearBoton(texto As String, name As String, x As Integer, y As Integer) As Button
        Dim boton As New Button()
        boton.Text = texto
        boton.Name = name
        boton.Location = New Point(x, y)
        boton.Size = New Size(184, 45)
        boton.BackColor = Color.FromArgb(153, 206, 195)
        boton.Cursor = Cursors.Hand
        boton.FlatAppearance.BorderSize = 0
        boton.FlatAppearance.MouseOverBackColor = Color.FromArgb(211, 152, 22)
        boton.FlatAppearance.CheckedBackColor = Color.FromArgb(211, 152, 22)
        boton.FlatStyle = FlatStyle.Flat
        boton.Font = New Font("Berlin Sans FB", 10.75, FontStyle.Regular)
        boton.ForeColor = Color.FromArgb(51, 51, 51)
        Return boton
    End Function


    'APLICANDO ESTILO A LOS ICONOS DEL MENÚ PRINCIPAL
    '---- DASHBOARD ----
    Private Sub btnDashboard_MouseLeave(sender As Object, e As EventArgs) Handles btnDashboard.MouseLeave
        btnDashboard.BackgroundImage = My.Resources.dashboard
    End Sub

    Private Sub btnDashboard_MouseMove(sender As Object, e As EventArgs) Handles btnDashboard.MouseMove
        btnDashboard.BackgroundImage = My.Resources.dashboard_2
    End Sub

    '---- CONFIGURACIÓN ----
    Private Sub btnConfiguracion_MouseLeave(sender As Object, e As EventArgs) Handles btnConfiguracion.MouseLeave
        btnConfiguracion.BackgroundImage = My.Resources.configuracion
    End Sub

    Private Sub btnConfiguracion_MouseMove(sender As Object, e As EventArgs) Handles btnConfiguracion.MouseMove
        btnConfiguracion.BackgroundImage = My.Resources.configuracion_2
    End Sub

    '---- REPORTES ----
    Private Sub btnReportes_MouseLeave(sender As Object, e As EventArgs) Handles btnReportes.MouseLeave
        btnReportes.BackgroundImage = My.Resources.reportes
    End Sub

    Private Sub btnReportes_MouseMove(sender As Object, e As EventArgs) Handles btnReportes.MouseMove
        btnReportes.BackgroundImage = My.Resources.reportes_2
    End Sub

    '---- SEGURIDAD ----
    Private Sub btnSeguridad_MouseLeave(sender As Object, e As EventArgs) Handles btnSeguridad.MouseLeave
        btnSeguridad.BackgroundImage = My.Resources.seguridad
    End Sub

    Private Sub btnSeguridad_MouseMove(sender As Object, e As EventArgs) Handles btnSeguridad.MouseMove
        btnSeguridad.BackgroundImage = My.Resources.seguridad_2
    End Sub


    'ABRIENDO FORMULARIOS HIJOS
    '---- CONFIGURACIÓN ----
    Private Sub boton1_Click(ByVal sender As Object, ByVal e As EventArgs)
        'CerrarTodos()
        VolverEstiloBotonesConfiguracion()
        AplicarEstiloBotones(boton1)
        VolverEventosBotonesConfiguracion(boton1)

        Dim frm As New frmEmpresa()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub boton2_Click(ByVal sender As Object, ByVal e As EventArgs)
        'CerrarTodos()
        VolverEstiloBotonesConfiguracion()
        AplicarEstiloBotones(boton2)
        VolverEventosBotonesConfiguracion(boton2)

        Dim frm As New frmEstacion()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub boton3_Click(ByVal sender As Object, ByVal e As EventArgs)
        'CerrarTodos()
        VolverEstiloBotonesConfiguracion()
        AplicarEstiloBotones(boton3)
        VolverEventosBotonesConfiguracion(boton3)

        Dim frm As New frmLinea()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub boton4_Click(ByVal sender As Object, ByVal e As EventArgs)
        'CerrarTodos()
        VolverEstiloBotonesConfiguracion()
        AplicarEstiloBotones(boton4)
        VolverEventosBotonesConfiguracion(boton4)

        Dim frm As New frmTren()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub boton5_Click(ByVal sender As Object, ByVal e As EventArgs)
        'CerrarTodos()
        VolverEstiloBotonesConfiguracion()
        AplicarEstiloBotones(boton5)
        VolverEventosBotonesConfiguracion(boton5)

        Dim frm As New frmVagon()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub boton6_Click(ByVal sender As Object, ByVal e As EventArgs)
        'CerrarTodos()
        VolverEstiloBotonesConfiguracion()
        AplicarEstiloBotones(boton6)
        VolverEventosBotonesConfiguracion(boton6)

        Dim frm As New frmPuesto()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub boton7_Click(ByVal sender As Object, ByVal e As EventArgs)
        'CerrarTodos()
        VolverEstiloBotonesConfiguracion()
        AplicarEstiloBotones(boton7)
        VolverEventosBotonesConfiguracion(boton7)

        Dim frm As New frmTipoTiquete()
        frm.MdiParent = Me
        frm.Show()
    End Sub


    '---- REPORTES ----
    Private Sub boton8_Click(ByVal sender As Object, ByVal e As EventArgs)
        'CerrarTodos()
        VolverEstiloBotonesReportes()
        AplicarEstiloBotones(boton8)
        VolverEventosBotonesReportes(boton8)

        Dim frm As New frmBitacora()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub boton9_Click(ByVal sender As Object, ByVal e As EventArgs)
        'CerrarTodos()
        VolverEstiloBotonesReportes()
        AplicarEstiloBotones(boton9)
        VolverEventosBotonesReportes(boton9)

        Dim frm As New frmR_Ingresos()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub boton10_Click(ByVal sender As Object, ByVal e As EventArgs)
        'CerrarTodos()
        VolverEstiloBotonesReportes()
        AplicarEstiloBotones(boton10)
        VolverEventosBotonesReportes(boton10)

        Dim frm As New frmR_HistorialVagones()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub boton11_Click(ByVal sender As Object, ByVal e As EventArgs)
        'CerrarTodos()
        VolverEstiloBotonesReportes()
        AplicarEstiloBotones(boton11)
        VolverEventosBotonesReportes(boton11)

        Dim frm As New frmR_CantPasajerosEstacion()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub boton12_Click(ByVal sender As Object, ByVal e As EventArgs)
        'CerrarTodos()
        VolverEstiloBotonesReportes()
        AplicarEstiloBotones(boton12)
        VolverEventosBotonesReportes(boton12)

        Dim frm As New frmR_TiempoTrabajoLinea()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub boton13_Click(ByVal sender As Object, ByVal e As EventArgs)
        'CerrarTodos()
        VolverEstiloBotonesReportes()
        AplicarEstiloBotones(boton13)
        VolverEventosBotonesReportes(boton13)

        Dim frm As New frmR_TiempoBajaLinea()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub boton14_Click(ByVal sender As Object, ByVal e As EventArgs)
        'CerrarTodos()
        VolverEstiloBotonesReportes()
        AplicarEstiloBotones(boton14)
        VolverEventosBotonesReportes(boton14)

        Dim frm As New frmR_PorcenCapacidadInstalada()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub boton15_Click(ByVal sender As Object, ByVal e As EventArgs)
        'CerrarTodos()
        VolverEstiloBotonesReportes()
        AplicarEstiloBotones(boton15)
        VolverEventosBotonesReportes(boton15)

        Dim frm As New frmR_CapacidadTrenEstacion()
        frm.MdiParent = Me
        frm.Show()
    End Sub


    '---- SEGURIDAD ----
    Private Sub boton16_Click(ByVal sender As Object, ByVal e As EventArgs)
        'CerrarTodos()
        VolverEstiloBotonesSeguridad()
        AplicarEstiloBotones(boton16)
        VolverEventosBotonesSeguridad(boton16)

        Dim frm As New frmUsuario()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub boton17_Click(ByVal sender As Object, ByVal e As EventArgs)
        'CerrarTodos()
        VolverEstiloBotonesSeguridad()
        AplicarEstiloBotones(boton17)
        VolverEventosBotonesSeguridad(boton17)

        Dim frm As New frmPermiso()
        frm.MdiParent = Me
        frm.Show()
    End Sub



    'APLICANDO ESTILO A LOS BOTONES DEL MENÚ IZQUIERDO
    '---- CONFIGURACIÓN ----
    Private Sub boton1_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
        AplicarEstiloBotonLeave(boton1)
    End Sub

    Private Sub boton1_MouseMove(ByVal sender As Object, ByVal e As EventArgs)
        AplicarEstiloBotonMove(boton1)
    End Sub

    Private Sub boton2_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
        AplicarEstiloBotonLeave(boton2)
    End Sub

    Private Sub boton2_MouseMove(ByVal sender As Object, ByVal e As EventArgs)
        AplicarEstiloBotonMove(boton2)
    End Sub

    Private Sub boton3_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
        AplicarEstiloBotonLeave(boton3)
    End Sub

    Private Sub boton3_MouseMove(ByVal sender As Object, ByVal e As EventArgs)
        AplicarEstiloBotonMove(boton3)
    End Sub

    Private Sub boton4_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
        AplicarEstiloBotonLeave(boton4)
    End Sub

    Private Sub boton4_MouseMove(ByVal sender As Object, ByVal e As EventArgs)
        AplicarEstiloBotonMove(boton4)
    End Sub

    Private Sub boton5_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
        AplicarEstiloBotonLeave(boton5)
    End Sub

    Private Sub boton5_MouseMove(ByVal sender As Object, ByVal e As EventArgs)
        AplicarEstiloBotonMove(boton5)
    End Sub

    Private Sub boton6_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
        AplicarEstiloBotonLeave(boton6)
    End Sub

    Private Sub boton6_MouseMove(ByVal sender As Object, ByVal e As EventArgs)
        AplicarEstiloBotonMove(boton6)
    End Sub

    Private Sub boton7_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
        AplicarEstiloBotonLeave(boton7)
    End Sub

    Private Sub boton7_MouseMove(ByVal sender As Object, ByVal e As EventArgs)
        AplicarEstiloBotonMove(boton7)
    End Sub


    '---- REPORTES ----
    Private Sub boton8_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
        AplicarEstiloBotonLeave(boton8)
    End Sub

    Private Sub boton8_MouseMove(ByVal sender As Object, ByVal e As EventArgs)
        AplicarEstiloBotonMove(boton8)
    End Sub

    Private Sub boton9_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
        AplicarEstiloBotonLeave(boton9)
    End Sub

    Private Sub boton9_MouseMove(ByVal sender As Object, ByVal e As EventArgs)
        AplicarEstiloBotonMove(boton9)
    End Sub

    Private Sub boton10_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
        AplicarEstiloBotonLeave(boton10)
    End Sub

    Private Sub boton10_MouseMove(ByVal sender As Object, ByVal e As EventArgs)
        AplicarEstiloBotonMove(boton10)
    End Sub

    Private Sub boton11_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
        AplicarEstiloBotonLeave(boton11)
    End Sub

    Private Sub boton11_MouseMove(ByVal sender As Object, ByVal e As EventArgs)
        AplicarEstiloBotonMove(boton11)
    End Sub

    Private Sub boton12_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
        AplicarEstiloBotonLeave(boton12)
    End Sub

    Private Sub boton12_MouseMove(ByVal sender As Object, ByVal e As EventArgs)
        AplicarEstiloBotonMove(boton12)
    End Sub

    Private Sub boton13_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
        AplicarEstiloBotonLeave(boton13)
    End Sub

    Private Sub boton13_MouseMove(ByVal sender As Object, ByVal e As EventArgs)
        AplicarEstiloBotonMove(boton13)
    End Sub

    Private Sub boton14_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
        AplicarEstiloBotonLeave(boton14)
    End Sub

    Private Sub boton14_MouseMove(ByVal sender As Object, ByVal e As EventArgs)
        AplicarEstiloBotonMove(boton14)
    End Sub

    Private Sub boton15_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
        AplicarEstiloBotonLeave(boton15)
    End Sub

    Private Sub boton15_MouseMove(ByVal sender As Object, ByVal e As EventArgs)
        AplicarEstiloBotonMove(boton15)
    End Sub


    '---- SEGURIDAD ----
    Private Sub boton16_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
        AplicarEstiloBotonLeave(boton16)
    End Sub

    Private Sub boton16_MouseMove(ByVal sender As Object, ByVal e As EventArgs)
        AplicarEstiloBotonMove(boton16)
    End Sub

    Private Sub boton17_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
        AplicarEstiloBotonLeave(boton17)
    End Sub

    Private Sub boton17_MouseMove(ByVal sender As Object, ByVal e As EventArgs)
        AplicarEstiloBotonMove(boton17)
    End Sub



    'MÉTODOS QUE APLICAN ESTILO
    Private Sub VolverEstiloBotonesConfiguracion()
        Dim botonesConfiguracion = New Button() {boton1, boton2, boton3, boton4, boton5, boton6, boton7}
        VolverEstiloBotones(botonesConfiguracion)
    End Sub

    Private Sub VolverEstiloBotonesReportes()
        Dim botonesReportes = New Button() {boton8, boton9, boton10, boton11, boton12, boton13, boton14, boton15}
        VolverEstiloBotones(botonesReportes)
    End Sub

    Private Sub VolverEstiloBotonesSeguridad()
        Dim botonesSeguridad = New Button() {boton16, boton17}
        VolverEstiloBotones(botonesSeguridad)
    End Sub

    Private Sub VolverEstiloBotones(botones As Button())
        For i = 0 To botones.Count - 1
            botones(i).BackColor = Color.Transparent
            botones(i).ForeColor = Color.FromArgb(51, 51, 51)
        Next
    End Sub

    Private Sub AplicarEstiloBotonMove(boton As Button)
        boton.ForeColor = Color.FromArgb(222, 251, 249)
    End Sub

    Private Sub AplicarEstiloBotonLeave(boton As Button)
        boton.ForeColor = Color.FromArgb(51, 51, 51)
    End Sub

    Private Sub VolverEventosBotonesConfiguracion(botonSeleccionado As Button)
        Dim boton As String
        boton = botonSeleccionado.Name

        RemoveHandler boton1.MouseLeave, AddressOf boton1_MouseLeave
        If boton <> boton1.Name Then
            AddHandler boton1.MouseLeave, AddressOf boton1_MouseLeave
        End If

        RemoveHandler boton2.MouseLeave, AddressOf boton2_MouseLeave
        If boton <> boton2.Name Then
            AddHandler boton2.MouseLeave, AddressOf boton2_MouseLeave
        End If

        RemoveHandler boton3.MouseLeave, AddressOf boton3_MouseLeave
        If boton <> boton3.Name Then
            AddHandler boton3.MouseLeave, AddressOf boton3_MouseLeave
        End If

        RemoveHandler boton4.MouseLeave, AddressOf boton4_MouseLeave
        If boton <> boton4.Name Then
            AddHandler boton4.MouseLeave, AddressOf boton4_MouseLeave
        End If

        RemoveHandler boton5.MouseLeave, AddressOf boton5_MouseLeave
        If boton <> boton5.Name Then
            AddHandler boton5.MouseLeave, AddressOf boton5_MouseLeave
        End If

        RemoveHandler boton6.MouseLeave, AddressOf boton6_MouseLeave
        If boton <> boton6.Name Then
            AddHandler boton6.MouseLeave, AddressOf boton6_MouseLeave
        End If

        RemoveHandler boton7.MouseLeave, AddressOf boton7_MouseLeave
        If boton <> boton7.Name Then
            AddHandler boton7.MouseLeave, AddressOf boton7_MouseLeave
        End If
    End Sub

    Private Sub VolverEventosBotonesReportes(botonSeleccionado As Button)
        Dim boton As String
        boton = botonSeleccionado.Name

        RemoveHandler boton8.MouseLeave, AddressOf boton8_MouseLeave
        If boton <> boton8.Name Then
            AddHandler boton8.MouseLeave, AddressOf boton8_MouseLeave
        End If

        RemoveHandler boton9.MouseLeave, AddressOf boton9_MouseLeave
        If boton <> boton9.Name Then
            AddHandler boton9.MouseLeave, AddressOf boton9_MouseLeave
        End If

        RemoveHandler boton10.MouseLeave, AddressOf boton10_MouseLeave
        If boton <> boton10.Name Then
            AddHandler boton10.MouseLeave, AddressOf boton10_MouseLeave
        End If

        RemoveHandler boton11.MouseLeave, AddressOf boton11_MouseLeave
        If boton <> boton11.Name Then
            AddHandler boton11.MouseLeave, AddressOf boton11_MouseLeave
        End If

        RemoveHandler boton12.MouseLeave, AddressOf boton12_MouseLeave
        If boton <> boton12.Name Then
            AddHandler boton12.MouseLeave, AddressOf boton12_MouseLeave
        End If

        RemoveHandler boton13.MouseLeave, AddressOf boton13_MouseLeave
        If boton <> boton13.Name Then
            AddHandler boton13.MouseLeave, AddressOf boton13_MouseLeave
        End If

        RemoveHandler boton14.MouseLeave, AddressOf boton14_MouseLeave
        If boton <> boton14.Name Then
            AddHandler boton14.MouseLeave, AddressOf boton14_MouseLeave
        End If

        RemoveHandler boton15.MouseLeave, AddressOf boton15_MouseLeave
        If boton <> boton15.Name Then
            AddHandler boton15.MouseLeave, AddressOf boton15_MouseLeave
        End If
    End Sub

    Private Sub VolverEventosBotonesSeguridad(botonSeleccionado As Button)
        Dim boton As String
        boton = botonSeleccionado.Name

        RemoveHandler boton16.MouseLeave, AddressOf boton16_MouseLeave
        If boton <> boton16.Name Then
            AddHandler boton16.MouseLeave, AddressOf boton16_MouseLeave
        End If

        RemoveHandler boton17.MouseLeave, AddressOf boton17_MouseLeave
        If boton <> boton17.Name Then
            AddHandler boton17.MouseLeave, AddressOf boton17_MouseLeave
        End If
    End Sub

    Private Sub AplicarEstiloBotones(boton As Button)
        boton.BackColor = Color.FromArgb(211, 152, 22)
        boton.ForeColor = Color.FromArgb(222, 251, 249)
    End Sub

    Private Sub VolverEstiloIconos(iconoSeleccionado As PictureBox)
        Dim boton As String
        boton = iconoSeleccionado.Name

        RemoveHandler btnDashboard.MouseLeave, AddressOf btnDashboard_MouseLeave
        If boton <> btnDashboard.Name Then
            btnDashboard.BackgroundImage = My.Resources.dashboard
            AddHandler btnDashboard.MouseLeave, AddressOf btnDashboard_MouseLeave
        Else
            btnDashboard.BackgroundImage = My.Resources.dashboard_2
        End If

        RemoveHandler btnConfiguracion.MouseLeave, AddressOf btnConfiguracion_MouseLeave
        If boton <> btnConfiguracion.Name Then
            btnConfiguracion.BackgroundImage = My.Resources.configuracion
            AddHandler btnConfiguracion.MouseLeave, AddressOf btnConfiguracion_MouseLeave
        Else
            btnConfiguracion.BackgroundImage = My.Resources.configuracion_2
        End If

        RemoveHandler btnReportes.MouseLeave, AddressOf btnReportes_MouseLeave
        If boton <> btnReportes.Name Then
            btnReportes.BackgroundImage = My.Resources.reportes
            AddHandler btnReportes.MouseLeave, AddressOf btnReportes_MouseLeave
        Else
            btnReportes.BackgroundImage = My.Resources.reportes_2
        End If

        RemoveHandler btnSeguridad.MouseLeave, AddressOf btnSeguridad_MouseLeave
        If boton <> btnSeguridad.Name Then
            btnSeguridad.BackgroundImage = My.Resources.seguridad
            AddHandler btnSeguridad.MouseLeave, AddressOf btnSeguridad_MouseLeave
        Else
            btnSeguridad.BackgroundImage = My.Resources.seguridad_2
        End If
    End Sub
End Class
