Imports TRV.API.CORE.Gestores
Imports TRV.Entidades

Public Class frmConsultarHorarios

    Dim gestorLineas As New GestorLinea(usuarioActual)
    Dim gestorEstaciones As New GestorEstacion(usuarioActual)
    Dim util As New Utilitario()

    Dim lineaActual As New Linea()

    Dim horariosLle As New List(Of TimeSpan)
    Dim horariosArr As New List(Of TimeSpan)

    Dim lstTemp As New List(Of String)

    Private Sub cbxLinea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxLinea.SelectedIndexChanged

        If cbxLinea.Text.Equals(" -- Seleccione") Then

            panelLlegadaTren1.Controls.Clear()
            panelLlegadaTren2.Controls.Clear()
            panelArrivoTren1.Controls.Clear()
            panelArrivoTren2.Controls.Clear()

        Else

            lineaActual = gestorLineas.RetrieveLineaPorCodigo(cbxLinea.Text)

            simulateMove(lineaActual)
        End If

    End Sub


    Private Sub frmConsultarHorarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lstLineas As List(Of Linea)
        lstLineas = gestorLineas.RetrieveAllLineas()

        Dim lst As New List(Of String)
        lst.Add(" -- Seleccione")

        For Each item In lstLineas
            lst.Add(item.Codigo)
        Next

        cbxLinea.DataSource = lst

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

        MsgBox(horaMinuto)
    End Function

    Private Sub simulateMove(linea As Linea)


        Dim totalKms As Integer = linea.Distancia
        Dim tiempoRecorrido As Integer = linea.DuracionRecorrido

        Dim horaActual As DateTime = New DateTime(2016, 7, 11, obtenerHora(linea), 0, 0)
        Dim horaFinal As DateTime = horaActual.AddHours(12)

        Dim horaLlegada As DateTime
        Dim horaArrivo As DateTime

        Dim lstEstaciones As List(Of Estacion)

        Try
            lstEstaciones = gestorEstaciones.RetrieveAllEstacionesPorLinea(linea)

            Dim tiempoEstimado = tiempoRecorrido - lstEstaciones.Count

            Dim kmsEstaciones As New List(Of Integer)

            For Each item In lstEstaciones
                kmsEstaciones.Add(item.Kilometro)
            Next

            Dim locationStationPorcent As Double
            Dim minutsStation As Double

            Do While horaActual.TimeOfDay.ToString < horaFinal.TimeOfDay.ToString

                For i As Integer = 0 To (kmsEstaciones.Count - 1)

                    locationStationPorcent = util.PorcentajeKilometroActual(kmsEstaciones(i), totalKms)
                    minutsStation = util.PorcentajeDeTiempo(locationStationPorcent, tiempoEstimado)

                    horaLlegada = horaActual.AddMinutes(minutsStation + i)
                    horaArrivo = horaActual.AddMinutes(minutsStation + (i + 1))

                    horariosLle.Add(horaLlegada.TimeOfDay) '' HORARIOS DE LLEGADA
                    horariosArr.Add(horaArrivo.TimeOfDay) '' HORARIOS DE ARRIVO

                Next

                horaActual = horaArrivo
                kmsEstaciones.Reverse()

                For i As Integer = 0 To (kmsEstaciones.Count - 1)

                    locationStationPorcent = util.PorcentajeKilometroActual((kmsEstaciones(0) - kmsEstaciones(i)), totalKms)
                    minutsStation = util.PorcentajeDeTiempo(locationStationPorcent, tiempoEstimado)

                    horaLlegada = horaActual.AddMinutes(minutsStation + i)
                    horaArrivo = horaActual.AddMinutes(minutsStation + (i + 1))

                    horariosLle.Add(horaLlegada.TimeOfDay) '' HORARIOS DE LLEGADA
                    horariosArr.Add(horaArrivo.TimeOfDay) '' HORARIOS DE ARRIVO

                Next

                horaActual = horaArrivo
                kmsEstaciones.Reverse()

            Loop

            addHorariosLlegadaItems(horariosLle, panelLlegadaTren1, kmsEstaciones.Count) '' SET CONTROLS DYNAMIC
            addHorariosLlegadaItems(horariosArr, panelArrivoTren1, kmsEstaciones.Count) '' SET CONTROLS DYNAMIC


        Catch ex As Exception
            MsgBox("La linea no tiene estaciones asignadas")
        End Try

    End Sub

    Private Sub addHorariosLlegadaItems(ByVal lst As List(Of TimeSpan), ByVal panel As Panel, ByVal cantEstaciones As Integer)

        panel.Controls.Clear()

        Dim pt As Point
        pt.X = 0
        pt.Y = 25

        Dim size = 25

        Dim contStation As Integer = 1

        For i As Integer = 1 To lst.Count

            Dim color As Color = Color.FromArgb(51, 51, 51)

            Dim lbl = New Label()
            lbl.Location = pt
            lbl.Width = 150
            lbl.Height = size
            lbl.AutoSize = False
            lbl.TextAlign = ContentAlignment.MiddleCenter
            lbl.ForeColor = color

            If contStation >= (cantEstaciones + 1) Then

                Dim asd = New Button()
                asd.Location = pt
                asd.Width = 150
                asd.Height = size
                asd.Text = "Regreso"
                color = Color.FromArgb(51, 51, 51)
                asd.ForeColor = color

                panel.Controls.Add(asd)

                pt.X = pt.X + size

                If pt.X >= size Then
                    pt.Y = pt.Y + size
                    pt.X = 0
                End If

                contStation = 1
            Else

            End If

            lbl.Text = "Estacion: " & contStation & " - " & lst(i - 1).ToString("hh\:mm\:ss")

            panel.Controls.Add(lbl)

            pt.X = pt.X + size

            If pt.X >= size Then
                pt.Y = pt.Y + size
                pt.X = 0
            End If

            contStation = contStation + 1

        Next

    End Sub

    Private Sub refreshTrainsData(ByVal prvStation As Integer, ByVal nxtStation As Integer)

        lblPrStat_1.Text = prvStation
        lblNxtSt_1.Text = nxtStation

        lblFrom.Text = gestorEstaciones.RetrieveEstacionPorCodigo(lineaActual.EstacionInicial).Nombre
        lblTo.Text = gestorEstaciones.RetrieveEstacionPorCodigo(lineaActual.EstacionFinal).Nombre

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

        Dim lstEstaciones As List(Of Estacion)
        Dim data As New List(Of String)
        Dim time As TimeSpan = DateTime.Now.TimeOfDay

        Try

            lstEstaciones = gestorEstaciones.RetrieveAllEstacionesPorLinea(lineaActual)

            If lstEstaciones Is Nothing Then

            Else

                Dim cantSt = lstEstaciones.Count

                Dim cont As Integer = 1

                For i As Integer = 0 To horariosLle.Count - 1

                    If i = horariosLle.Count - 1 Then

                    Else

                        If time > horariosLle(i) And time < horariosLle(i + 1) Then

                            MsgBox(horariosLle(i).ToString & " - " & horariosLle(i + 1).ToString)

                            refreshTrainsData((cont), (cont + 1)) '' Refresh data
                        End If

                    End If

                    cont = cont + 1

                    If cont = gestorEstaciones.RetrieveAllEstacionesPorLinea(lineaActual).Count Then
                        cont = 1
                    End If

                Next

            End If

        Catch ex As Exception
            MsgBox("Seleccione una linea")
        End Try

    End Sub
End Class