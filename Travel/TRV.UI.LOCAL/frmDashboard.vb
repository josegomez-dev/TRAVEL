Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports TRV.API.CORE.Gestores
Imports TRV.Entidades

Public Class frmDashboard
    Private rolesPermisos As New RolesPermisos()

    Private lineaSeleccionada As String
    Private estacionSeleccionada As String
    Private trenSeleccionado As String
    Private tipoTiqueteSeleccionado As String

    Dim horariosLle As New List(Of TimeSpan)
    Dim horariosArr As New List(Of TimeSpan)

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgLineas_Load()
        wbApiMaps.Navigate(recreateOurPage())
    End Sub

    Private Sub dgLineas_Load()
        dgLineas.Rows.Clear()

        Dim gestor As New GestorLinea(usuarioActual)
        Dim lstLineas As New List(Of Linea)
        lstLineas = gestor.RetrieveAllLineas()

        If lstLineas IsNot Nothing Then
            For i = 0 To lstLineas.Count - 1
                dgLineas.Rows.Add(lstLineas(i).Nombre, lstLineas(i).Estado)
            Next i
        End If
    End Sub

    Private Sub dgLineas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgLineas.CellClick
        Dim gestor As New GestorLinea(usuarioActual)
        Dim linea As New Linea()
        Dim columna As String
        Dim nomLinea As String

        columna = dgLineas.Columns.Item(0).Name.ToString
        nomLinea = dgLineas.SelectedRows(0).Cells(columna).Value.ToString
        linea = gestor.RetrieveLineaPorNombre(nomLinea)
        lineaSeleccionada = linea.Codigo

        btnEditarHorario.Enabled = True
        btnEditarPrecio.Enabled = True
        dgEstaciones_Load()
        dgHorarios_Load()
        dgTrenes_Load()
        dgPrecios_Load()

        Dim lineaData = getLineaMapData(linea)
        Dim estacionesData = getEstacionesMapData(linea)
        Dim centralSt = getCentralStation()


        dgInfo.Rows.Clear()
        dgHorariosDyn.Rows.Clear()
        dgTiempo.Rows.Clear()
        wbApiMaps.Navigate(apiMaps_Lines_Stations(estacionesData, lineaData, centralSt, False))

    End Sub

    Private Sub dgPrecios_Load()
        dgPrecios.Rows.Clear()

        Dim tarifaLinea As Double
        Dim IV As Double
        Dim precioTotal As Double

        Dim gestorLinea As New GestorLinea(usuarioActual)
        Dim linea As New Linea()
        linea = gestorLinea.RetrieveLineaPorCodigo(lineaSeleccionada)
        tarifaLinea = linea.CostoCirculacion

        Dim gestorEmpresa As New GestorEmpresa(usuarioActual)
        Dim empresa As New List(Of Empresa)
        empresa = gestorEmpresa.RetrieveAll()
        IV = empresa(0).Impuesto / 100

        Dim gestorTTiquete As New GestorTipoTiquete(usuarioActual)
        Dim lstTipos As New List(Of TipoTiquete)
        lstTipos = gestorTTiquete.RetrieveAll()

        If lstTipos IsNot Nothing Then
            For i = 0 To lstTipos.Count - 1
                precioTotal = tarifaLinea + lstTipos(i).Precio
                dgPrecios.Rows.Add(lstTipos(i).Tipo, Convert.ToString((IV * precioTotal) + precioTotal))
            Next i
        End If
    End Sub

    Private Sub dgPrecios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPrecios.CellClick
        Dim gestor As New GestorTipoTiquete(usuarioActual)
        Dim tipoTiquete As New TipoTiquete()
        Dim columna As String

        columna = dgPrecios.Columns.Item(0).Name.ToString
        tipoTiqueteSeleccionado = dgPrecios.SelectedRows(0).Cells(columna).Value.ToString

        btnEditarPrecio.Enabled = True
    End Sub

    '' API MAPS
    Function getCentralStation() As Estacion

        Dim gestor As New GestorEstacion(usuarioActual)
        Return gestor.retrieveEstacionCentral()

    End Function

    Function getEstacionesMapData(line As Linea) As String

        Dim gestor As New GestorEstacion(usuarioActual)
        Dim lstEstaciones As New List(Of Estacion)
        lstEstaciones = gestor.RetrieveAllEstacionesPorLinea(line)

        Dim sb As New StringBuilder()

        sb.Append("[")
        sb.AppendLine()

        Dim i As Integer = 1

        For Each item In lstEstaciones

            Dim lat As String = item.Latitud
            Dim lng As String = item.Longitud
            lat = Replace(lat, ",", ".")
            lng = Replace(lng, ",", ".")

            sb.Append("[ {lat : " & lat & ", lng : " & lng & "} ," & Chr(34) & item.Nombre & Chr(34) & " ]")

            If i < lstEstaciones.Count Then
                sb.AppendLine(",")
                sb.AppendLine()

                i = i + 1
            End If

        Next

        sb.AppendLine()
        sb.Append("]")

        Return sb.ToString()

    End Function

    Function getLineaMapData(line As Linea) As List(Of String)

        Dim gestor As New GestorLinea(usuarioActual)
        Dim gestorEstaciones As New GestorEstacion(usuarioActual)
        Dim lineasData As New List(Of String)
        Dim lstEst As New List(Of Estacion)

        lstEst = gestorEstaciones.RetrieveAllEstacionesPorLinea(line)

        Dim sb As New StringBuilder()

        Dim i As Integer = 1

        sb.Append("[")

        For Each item In lstEst

            Dim lat As String = item.Latitud
            Dim lng As String = item.Longitud
            lat = Replace(lat, ",", ".")
            lng = Replace(lng, ",", ".")

            sb.Append(" {lat : " & lat & ", lng : " & lng & "} ")

            If i < lstEst.Count Then
                sb.AppendLine(",")
                sb.AppendLine()

                i = i + 1
            End If

        Next

        sb.Append("]")

        Dim linea = gestor.RetrieveLineaPorCodigo(lineaSeleccionada)

        lineasData.Add(linea.Color)
        lineasData.Add(sb.ToString())
        lineasData.Add(linea.DuracionRecorrido * 10)

        Return lineasData

    End Function

    Function getCentralStation(ByVal line As Linea) As List(Of String)

        Dim gestorEstacion As New GestorEstacion(usuarioActual)
        Dim estacionInicial As New Estacion
        Dim estacionFinal As New Estacion

        estacionInicial = gestorEstacion.RetrieveEstacionPorCodigo(line.EstacionInicial)
        estacionFinal = gestorEstacion.RetrieveEstacionPorCodigo(line.EstacionFinal)

    End Function

    '' API MAPS

    '' HORARIOS
    Private Sub generarHorarios(linea As Linea, tren As Tren)

        Dim gestorEstaciones As New GestorEstacion(usuarioActual)
        Dim util As New Utilitario()

        Dim totalKms As Integer = linea.Distancia
        Dim tiempoRecorrido As Integer = linea.DuracionRecorrido

        Dim horaActual As DateTime = New DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, obtenerHora(linea), 0, 0) '' Set Start Time
        Dim horaFinal As DateTime = horaActual.AddHours(linea.HoraTrabajo) '' Set End Time

        Dim horaLlegada As DateTime
        Dim horaArrivo As DateTime

        horariosLle = New List(Of TimeSpan)
        horariosArr = New List(Of TimeSpan)

        Dim lstEstaciones As List(Of Estacion)

        If horaActual.TimeOfDay.ToString < horaFinal.TimeOfDay.ToString Then

            Try

                lstEstaciones = gestorEstaciones.RetrieveAllEstacionesPorLinea(linea)

                Dim tiempoEstimado = tiempoRecorrido - lstEstaciones.Count

                Dim kmsEstaciones1erCarril As New List(Of Integer)
                Dim kmsEstaciones2doCarril As New List(Of Integer)
                Dim kms As New List(Of Integer)

                '' 1er Carril
                For Each item In lstEstaciones
                    kmsEstaciones1erCarril.Add(item.Kilometro)
                Next
                kmsEstaciones1erCarril.Reverse()

                '' 2do Carril
                For i As Integer = 0 To (lstEstaciones.Count - 1)
                    kmsEstaciones2doCarril.Add(kmsEstaciones1erCarril(0) - kmsEstaciones1erCarril(i))
                Next
                kmsEstaciones1erCarril.Reverse()

                '' Identify Carril
                If tren.Kilometro = 0 Then '' tren.Kilometro = 0
                    kms = kmsEstaciones1erCarril
                Else
                    kms = kmsEstaciones2doCarril
                End If

                Dim locationStationPorcent As Double
                Dim minutsStation As Double

                Do While horaActual.TimeOfDay.ToString < horaFinal.TimeOfDay.ToString

                    For i As Integer = 0 To (kms.Count - 1)

                        locationStationPorcent = util.PorcentajeKilometroActual(kms(i), totalKms)
                        minutsStation = util.PorcentajeDeTiempo(locationStationPorcent, tiempoEstimado)

                        horaLlegada = horaActual.AddMinutes(minutsStation + i)
                        horaArrivo = horaActual.AddMinutes(minutsStation + (i + 1))

                        horariosLle.Add(horaLlegada.TimeOfDay) '' HORARIOS DE LLEGADA
                        horariosArr.Add(horaArrivo.TimeOfDay) '' HORARIOS DE ARRIVO

                    Next

                    horaActual = horaArrivo
                    kms.Reverse()

                    For i As Integer = 0 To (kms.Count - 1)

                        locationStationPorcent = util.PorcentajeKilometroActual((kms(0) - kms(i)), totalKms)
                        minutsStation = util.PorcentajeDeTiempo(locationStationPorcent, tiempoEstimado)

                        horaLlegada = horaActual.AddMinutes(minutsStation + i)
                        horaArrivo = horaActual.AddMinutes(minutsStation + (i + 1))

                        horariosLle.Add(horaLlegada.TimeOfDay) '' HORARIOS DE LLEGADA
                        horariosArr.Add(horaArrivo.TimeOfDay) '' HORARIOS DE ARRIVO

                    Next

                    horaActual = horaArrivo
                    kms.Reverse()

                Loop

                mostrarHorarios(horariosLle, horariosArr, kms.Count)

                mostrarTiempoEstimado(lstEstaciones, horariosLle)

                mostrarMapaTren(tren) '' Refresh Train MAP

                getInfoTren(tren)

            Catch ex As Exception
                dgHorariosDyn.Rows.Clear()
                MsgBox(ex.Message)
            End Try
        Else
            dgHorariosDyn.Rows.Clear()
            MsgBox("Fuera de Servicio")
        End If

    End Sub

    Private Sub getInfoTren(tren As Tren)

        Dim gestorLinea As New GestorLinea(usuarioActual)
        Dim gestorEstaciones As New GestorEstacion(usuarioActual)

        Dim linea As Linea = gestorLinea.RetrieveLineaPorCodigo(lineaSeleccionada)
        Dim lstEst As New List(Of Estacion)
        lstEst = gestorEstaciones.RetrieveAllEstacionesPorLinea(linea)

        Dim dat As New TimeSpan
        Dim info As New List(Of String)

        Dim buffer As String = ""

        If tren.Kilometro = 0 Then
            info.Add("     *** Carril 1 ***     ")
        Else
            info.Add("     *** Carril 2 ***     ")
        End If

        dat = DateTime.Now.TimeOfDay

        If tren.Kilometro <> 0 Then
            lstEst.Reverse()
        End If

        Dim cont As Integer = 1

        For i As Integer = 0 To (horariosArr.Count - 1)

            If i = (horariosLle.Count - 1) Then

            Else

                If dat > horariosLle(i) And dat < horariosLle(i + 1) Then
                    info.Add("Prox: " + lstEst(cont - 1).Nombre)

                    If cont = lstEst.Count Then
                        buffer = "Sig: " + lstEst(0).Nombre + " - " + horariosLle(i).ToString()
                        info.Add(buffer)
                    Else
                        buffer = "Sig: " + lstEst(cont).Nombre + " - " + horariosLle(i + 1).ToString()
                        info.Add(buffer)
                    End If
                End If

            End If

            cont = cont + 1
            If cont = (lstEst.Count + 1) Then
                cont = 1
            End If

        Next

        dgInfo.Rows.Clear()

        For Each e In info
            dgInfo.Rows.Add(e)
        Next

    End Sub

    Private Sub mostrarMapaTren(tren As Tren)

        Dim gestorLinea As New GestorLinea(usuarioActual)
        Dim linea As New Linea

        Dim lineaData As List(Of String)
        Dim estacionesData As String
        Dim centralSt As New Estacion


        If lineaSeleccionada IsNot Nothing And trenSeleccionado IsNot Nothing Then

            linea = gestorLinea.RetrieveLineaPorCodigo(lineaSeleccionada)
            lineaData = getLineaMapData(linea)
            estacionesData = getEstacionesMapData(linea)
            centralSt = getCentralStation()

            If tren.Estado.Equals("Activo") Then
                wbApiMaps.Navigate(apiMaps_Lines_Stations(estacionesData, lineaData, centralSt, True))
            Else
                wbApiMaps.Navigate(apiMaps_Lines_Stations(estacionesData, lineaData, centralSt, False))
            End If

        End If

    End Sub

    Private Sub mostrarHorarios(ByVal lstLlegadas As List(Of TimeSpan), ByVal lstArrivos As List(Of TimeSpan), ByVal cantEstaciones As Integer)

        dgHorariosDyn.Rows.Clear()

        Dim contStation As Integer = 1

        For i As Integer = 1 To lstLlegadas.Count

            If contStation >= (cantEstaciones + 1) Then
                contStation = 1
            Else

            End If

            Dim arribo = "St: " & contStation & " - " & lstLlegadas(i - 1).ToString("hh\:mm\:ss")
            Dim salida = "St: " & contStation & " - " & lstArrivos(i - 1).ToString("hh\:mm\:ss")

            dgHorariosDyn.Rows.Add(arribo, salida)

            contStation = contStation + 1

        Next

    End Sub

    Function obtenerHora(linea As Linea) As String

        Dim fecha As Date

        fecha = linea.HoraInicio

        Dim horaMinuto As String
        Dim hora As String

        If Len(Trim(Str(fecha.Hour))) = 1 Then
            hora = fecha.Hour
        Else
            hora = fecha.Hour
        End If

        horaMinuto = hora

        Return horaMinuto

    End Function

    Private Sub mostrarTiempoEstimado(ByVal lstEstaciones As List(Of Estacion), ByVal horariosLle As List(Of TimeSpan))

        Dim time As TimeSpan = DateTime.Now.TimeOfDay

        Dim cantSt = lstEstaciones.Count

        For i As Integer = 0 To horariosLle.Count - 1

            If i = horariosLle.Count - 1 Then

            Else

                If time > horariosLle(i) And time < horariosLle(i + 1) Then

                    ' MsgBox(horariosLle(i).ToString & " - " & horariosLle(i + 1).ToString)

                    fillTimeAprox(horariosLle(i + 1), time) '' Fill Time Aprox

                End If

            End If

        Next

    End Sub

    Private Sub fillTimeAprox(ByVal proximaLlegada As TimeSpan, ByVal horaActual As TimeSpan)

        dgTiempo.Rows.Clear()

        Dim arrivoAprox As TimeSpan
        arrivoAprox = proximaLlegada - horaActual

        dgTiempo.Rows.Add(arrivoAprox.Hours, arrivoAprox.Minutes, arrivoAprox.Seconds)

    End Sub

    '' HORARIOS

    Private Sub dgEstaciones_Load()
        dgEstaciones.Rows.Clear()

        Dim gestorLinea As New GestorLinea(usuarioActual)
        Dim lstEstaciones As List(Of Estacion)
        lstEstaciones = gestorLinea.RetrieveEstacionesPorLinea(lineaSeleccionada)

        If lstEstaciones IsNot Nothing Then
            For i = 0 To lstEstaciones.Count - 1
                dgEstaciones.Rows.Add(lstEstaciones(i).Nombre, lstEstaciones(i).Kilometro, lstEstaciones(i).Estado)
            Next
        End If
    End Sub

    Private Sub dgEstaciones_CellClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub dgTrenes_Load()
        dgTrenes.Rows.Clear()

        Dim gestorTren As New GestorTren(usuarioActual)
        Dim lstTrenes As List(Of Tren)
        Dim linea As New Linea

        linea.Codigo = lineaSeleccionada
        lstTrenes = gestorTren.RetrieveAllTrenByLinea(linea)

        If lstTrenes IsNot Nothing Then
            For i = 0 To lstTrenes.Count - 1
                dgTrenes.Rows.Add(lstTrenes(i).Matricula, lstTrenes(i).Nombre, lstTrenes(i).Estado)
            Next
        End If
    End Sub

    Private Sub dgTrenes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgTrenes.CellClick

        Dim gestorTren As New GestorTren(usuarioActual)
        Dim gestorLinea As New GestorLinea(usuarioActual)
        Dim tren As New Tren
        Dim linea As New Linea
        Dim columna As String
        Dim matricula As String

        columna = dgTrenes.Columns.Item(0).Name.ToString
        matricula = dgTrenes.SelectedRows(0).Cells(columna).Value.ToString

        trenSeleccionado = dgTrenes.SelectedRows(0).Cells(columna).Value.ToString

        tren = gestorTren.RetrievTrenPorMatricula(matricula)
        linea = gestorLinea.RetrieveLineaPorCodigo(tren.CodLinea)

        generarHorarios(linea, tren)

    End Sub

    Private Sub dgAsientos_Load()

    End Sub

    Private Sub dgAsientos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgAsientos.CellClick

    End Sub

    Private Sub dgTiempo_Load()

    End Sub

    Private Sub dgTiempo_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgTiempo.CellClick

    End Sub

    Private Sub dgHorarios_Load()

        dgHorarios.Rows.Clear()
        Dim gestorLineas As New GestorLinea(usuarioActual)
        Dim gestorEstaciones As New GestorEstacion(usuarioActual)
        Dim linea As New Linea
        Dim estacionInicial As New Estacion
        Dim estacionFinal As New Estacion

        linea = gestorLineas.RetrieveLineaPorCodigo(lineaSeleccionada)
        estacionInicial = gestorEstaciones.RetrieveEstacionPorCodigo(linea.EstacionInicial)
        estacionFinal = gestorEstaciones.RetrieveEstacionPorCodigo(linea.EstacionFinal)

        dgHorarios.Rows.Add("Desde: " & estacionInicial.Nombre)
        dgHorarios.Rows.Add("Hasta: " & estacionFinal.Nombre)
        dgHorarios.Rows.Add("Hora de arribo: " & linea.HoraInicio)
        dgHorarios.Rows.Add("Horas de trabajo: " & Convert.ToString(linea.HoraTrabajo))

    End Sub

    Private Sub btnEditarPrecio_Click(sender As Object, e As EventArgs) Handles btnEditarPrecio.Click
        If rolesPermisos.PermisoUsuario(RolesPermisos.VentanasIDS.precioTiquete) Then
            Dim frm As New frmPrecioTiquete(lineaSeleccionada, tipoTiqueteSeleccionado)
            frm.Show()
            dgPrecios_Load()
        End If
    End Sub

    Private Sub btnEditarHorario_Click(sender As Object, e As EventArgs) Handles btnEditarHorario.Click
        If rolesPermisos.PermisoUsuario(RolesPermisos.VentanasIDS.horarioLinea) Then
            Dim frm As New frmHorarioLinea(lineaSeleccionada)
            frm.Show()
            dgHorarios_Load()
        End If
    End Sub

    Private Sub btnNotificarClientes_Click(sender As Object, e As EventArgs) Handles btnNotificarClientes.Click
        If rolesPermisos.PermisoUsuario(RolesPermisos.VentanasIDS.notificacion) Then
            Dim frm As New frmNotificacion()
            frm.Show()
        End If
    End Sub

    Private Sub btnHistorialViajes_Click(sender As Object, e As EventArgs) Handles btnHistorialViajes.Click
        Dim frm As New frmHistorialViajes()
        frm.Show()
    End Sub

    Private Sub btn_iniciar_Click(sender As Object, e As EventArgs) Handles btn_iniciar.Click
        If rolesPermisos.PermisoUsuario(RolesPermisos.VentanasIDS.iniciar_tren) Then
            Dim gestorTren As New GestorTren(usuarioActual)
            Dim tren As New Tren

            If trenSeleccionado IsNot Nothing And lineaSeleccionada IsNot Nothing Then

                tren = gestorTren.RetrievTrenPorMatricula(trenSeleccionado)
                tren.iniciarTren()

                gestorTren.UpdateTren(tren)

                mostrarMapaTren(tren) '' Refresh Train MAP
                dgTrenes_Load()

                registrarHistorialViajes("Inicio Tren")

            Else

                MsgBox("Seleccione un tren", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub btn_detener_Click(sender As Object, e As EventArgs) Handles btn_detener.Click
        If rolesPermisos.PermisoUsuario(RolesPermisos.VentanasIDS.detener_tren) Then
            Dim gestorTren As New GestorTren(usuarioActual)
            Dim tren As New Tren

            If trenSeleccionado IsNot Nothing And lineaSeleccionada IsNot Nothing Then

                tren = gestorTren.RetrievTrenPorMatricula(trenSeleccionado)
                tren.detenerTren()

                gestorTren.UpdateTren(tren)

                mostrarMapaTren(tren) '' Refresh Train MAP
                dgTrenes_Load()

                registrarHistorialViajes("Se detuvo Tren")
            Else

                MsgBox("Seleccione un tren", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub registrarHistorialViajes(action As String)

        Dim gestorTren As New GestorTren(usuarioActual)
        Dim gestorLinea As New GestorLinea(usuarioActual)
        Dim gestorHistorial As New GestorHistorialViaje(usuarioActual)
        Dim historial As New HistorialViajes()

        Dim infoHistorialViaje As New List(Of String)

        Try

            If dgInfo.Rows.Count > 1 Then

                Dim carril = dgInfo.Rows(0).Cells(0).Value
                Dim estacionInicial = dgInfo.Rows(1).Cells(0).Value
                Dim estacionFinal = dgInfo.Rows(2).Cells(0).Value

                Dim h = dgTiempo.Rows(0).Cells(0).Value
                Dim m = dgTiempo.Rows(0).Cells(1).Value
                Dim s = dgTiempo.Rows(0).Cells(2).Value

                Dim tiempoEstimado = h & ":" & m & "." & s

                Dim tren = gestorTren.RetrievTrenPorMatricula(trenSeleccionado)
                Dim linea = gestorLinea.RetrieveLineaPorCodigo(lineaSeleccionada)

                historial.Linea = linea.Nombre
                historial.Tren = tren.Matricula & " - " & tren.Nombre
                historial.EstacionAnterior = estacionInicial
                historial.EstacionSiguiente = estacionFinal
                historial.TiempoEstimado = tiempoEstimado
                historial.Accion = action
                historial.Fecha = DateTime.Now.ToString()

                gestorHistorial.Create(historial)

            Else
                MsgBox("El Tren esta fuera de servicio")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnRegistrarHorarios_Click(sender As Object, e As EventArgs) Handles btnRegistrarHorarios.Click

        Dim gestor As New GestorHorario(usuarioActual)
        Dim lstArrivos As New List(Of String)
        Dim lstSalidas As New List(Of String)

        Dim lstHorarios As New List(Of Horario)

        If lineaSeleccionada IsNot Nothing And trenSeleccionado IsNot Nothing Then

            Try
                lstHorarios = gestor.RetrieveAllByTrenLinea(trenSeleccionado, lineaSeleccionada)

                If lstHorarios IsNot Nothing Then

                    MsgBox("Los horarios para este tren, ya han sido registrados!")
                Else

                    Dim cont = dgHorariosDyn.Rows.Count

                    For i As Integer = 0 To cont - 1
                        lstArrivos.Add(dgHorariosDyn.Rows(i).Cells(0).Value)
                        lstSalidas.Add(dgHorariosDyn.Rows(i).Cells(1).Value)
                    Next

                    For i As Integer = 0 To cont - 1

                        Dim horario As New Horario
                        horario.HoraArrivo = lstArrivos(i)
                        horario.HoraSalida = lstSalidas(i)
                        horario.Tren = trenSeleccionado
                        horario.Linea = lineaSeleccionada

                        gestor.CreateHorario(horario)
                    Next

                    MsgBox("Se registraron " & cont & " Registros de Horarios!", MsgBoxStyle.Information)

                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else
            MsgBox("Seleccione un tren", MsgBoxStyle.Exclamation)
        End If


    End Sub

    Private Sub btnEliminarRegHorarios_Click(sender As Object, e As EventArgs) Handles btnEliminarRegHorarios.Click

        If lineaSeleccionada IsNot Nothing And trenSeleccionado IsNot Nothing Then
            Try

                Dim gestor As New GestorHorario(usuarioActual)
                Dim lst As New List(Of Horario)
                lst = gestor.RetrieveAllByTrenLinea(trenSeleccionado, lineaSeleccionada)

                For Each i In lst
                    gestor.Delete(i.Tren, i.Linea)
                Next

                MsgBox("Se eliminaron " & lst.Count & " registros de horairos!", MsgBoxStyle.Information)

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try

        Else
            MsgBox("Seleccione un tren", MsgBoxStyle.Exclamation)
        End If


    End Sub
End Class