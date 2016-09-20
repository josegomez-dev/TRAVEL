Imports TRV.API.CORE
Imports TRV.API.CORE.Gestores
Imports TRV.Entidades

Public Class RolesPermisos

    Dim lstPermisos As New List(Of Permiso)
    Dim gestorPermiso As New GestorPermiso(usuarioActual)

    Enum VentanasIDS
        usuarios = 1
        bitacora = 2
        r_tiempoBajaLinea = 3
        r_porcenCapacidadInstalada = 4
        r_ingresos = 6
        r_cantPasajerosEstacion = 7
        r_tiempoTrabajoLinea = 8
        r_capacidadTrenEstacion = 9
        dashboard = 11
        empresa = 12
        estacion = 13
        linea = 14
        permiso = 16
        puesto = 17
        tren = 18
        tipoTiquete = 19
        vagon = 20
        asiento = 26
        convenio = 27
        horarioLinea = 28
        notificacion = 29
        precioTiquete = 30
        r_historialVagones = 31
        iniciar_tren = 32
        detener_tren = 33
    End Enum

    Public Function PermisoUsuario(permiso As Integer) As Boolean
        Dim encontrado As Boolean = False

        lstPermisos = gestorPermiso.RetrieveAllPermisoPorPuesto(usuarioActual.Puesto)

        If lstPermisos IsNot Nothing Then
            For i = 0 To lstPermisos.Count - 1
                If lstPermisos(i).Codigo.Equals(permiso) Then
                    encontrado = True
                End If
            Next
        End If

        Return encontrado
    End Function

    Public Function VerificarPuestoUsuario() As Boolean
        Dim sinPermiso As Boolean = False
        Dim puestoSinPermiso As Integer

        Dim gestorPuesto As New GestorPuesto(usuarioActual)
        Dim lstPuestos As New List(Of Puesto)

        lstPuestos = gestorPuesto.RetrieveAll()

        If lstPuestos IsNot Nothing Then
            For i = 0 To lstPuestos.Count - 1
                If lstPuestos(i).Nombre.Equals("Cajero") Then
                    puestoSinPermiso = lstPuestos(i).Id
                End If
            Next
        End If

        If usuarioActual.Puesto.Equals(puestoSinPermiso) = False Then
            sinPermiso = True
        End If

        Return sinPermiso
    End Function

End Class
