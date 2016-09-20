Imports System.Drawing
Imports System.Windows.Forms
Imports TRV.API.CORE.Gestores
Imports TRV.Entidades

Public Class frmLinea

    Private lineaSeleccionada As Integer = 0
    Private estado As Integer = 1 '1 - Registrar / 2 - Modificar

    Private Sub Linea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Size = New Size(675, 443)
        txtNombre.Select()
        dgLineas_Load()
        lbEstaciones_Load()
    End Sub

    Private Sub lbEstaciones_Load()
        Dim gestorEstaciones As New GestorEstacion(usuarioActual)
        Dim lstEstaciones As List(Of Estacion)

        lstEstaciones = gestorEstaciones.RetrieveAllEstaciones()

        Dim i
        For i = 0 To lstEstaciones.Count - 1
            lbEstaciones.Items.Add(lstEstaciones(i).Nombre)
            cmbEstacionInicial.Items.Add(lstEstaciones(i).Nombre)
            cmbEstacionFinal.Items.Add(lstEstaciones(i).Nombre)
        Next
    End Sub

    Private Sub dgLineas_Load()
        dgLineas.Rows.Clear()

        Dim gestor As New GestorLinea(usuarioActual)
        Dim lstLineas As New List(Of Linea)

        lstLineas = gestor.RetrieveAllLineas()

        Dim gestorEst As New GestorEstacion(usuarioActual)
        Dim inicial As New Estacion
        Dim final As New Estacion
        Dim lstEstaciones As List(Of Estacion)

        lstEstaciones = gestorEst.RetrieveAllEstaciones()

        If lstLineas IsNot Nothing Then
            For i = 0 To lstLineas.Count - 1
                inicial = gestorEst.RetrieveEstacionPorCodigo(lstLineas(i).EstacionInicial)
                final = gestorEst.RetrieveEstacionPorCodigo(lstLineas(i).EstacionFinal)

                dgLineas.Rows.Add(lstLineas(i).Nombre, inicial.Nombre + " - " + final.Nombre, lstLineas(i).Estado)
            Next i
        End If
    End Sub

    Private Sub dgLineas_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgLineas.CellClick
        estado = 2

        Dim gestor As New GestorLinea(usuarioActual)
        Dim codLinea As String
        Dim linea As New Linea()
        Dim columna As String

        columna = dgLineas.Columns.Item(0).Name.ToString
        codLinea = dgLineas.SelectedRows(0).Cells(columna).Value.ToString
        linea = gestor.RetrieveLineaPorNombre(codLinea)

        Dim gestorEst As New GestorEstacion(usuarioActual)
        Dim inicial As New Estacion
        Dim final As New Estacion

        inicial = gestorEst.RetrieveEstacionPorCodigo(linea.EstacionInicial)
        final = gestorEst.RetrieveEstacionPorCodigo(linea.EstacionFinal)

        lineaSeleccionada = linea.Codigo
        txtNombre.Text = linea.Nombre
        txtColor.Text = linea.Color
        txtDistancia.Text = linea.Distancia
        cmbEstado.Text = linea.Estado
        cmbEstacionInicial.Text = inicial.Nombre
        cmbEstacionFinal.Text = final.Nombre
        cmbHoras.Text = linea.HoraTrabajo
        txtHoraInicio.Text = linea.HoraInicio
        txtTarifa.Text = linea.CostoCirculacion
        txtDuracion.Text = linea.DuracionRecorrido
        txtHoraInicio.Text = linea.HoraInicio

        txtHoraInicio.ForeColor = Color.FromArgb(51, 51, 51)

        lbEstaciones_Load(cmbEstacionInicial.Text, cmbEstacionFinal.Text)

        Dim lstEstaciones As List(Of Estacion)
        lstEstaciones = gestor.RetrieveEstacionesPorLinea(linea.Codigo)

        For i = 0 To lstEstaciones.Count - 1
            lbEstaciones.SelectedItem = lstEstaciones(i).Nombre
        Next
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim utilitario As New Utilitario()

        Dim nombre = utilitario.ValidarTexto(txtNombre.Text)
        Dim color = utilitario.ValidarTexto(txtColor.Text)
        Dim distancia = utilitario.ValidarEnteroYDecimal(txtDistancia.Text)
        Dim estadoLinea = utilitario.ValidarComboBox(cmbEstado.Text)
        Dim estacionInicial = utilitario.ValidarComboBox(cmbEstacionInicial.Text)
        Dim estacionFinal = utilitario.ValidarComboBox(cmbEstacionFinal.Text)
        Dim horasTrabajo = utilitario.ValidarComboBox(cmbHoras.Text)
        Dim horaInicio = utilitario.ValidarHora(txtHoraInicio.Text)
        Dim tarifa = utilitario.ValidarEnteroYDecimal(txtTarifa.Text)

        If nombre And color And distancia And estadoLinea And estacionInicial And estacionFinal And horasTrabajo And horaInicio And tarifa Then
            If cmbEstacionInicial.Text <> cmbEstacionFinal.Text Then

                Dim gestor As New GestorLinea(usuarioActual)
                Dim linea As New Linea()

                Dim gestorEst As New GestorEstacion(usuarioActual)
                Dim lstEstaciones As List(Of Estacion)
                lstEstaciones = gestorEst.RetrieveAllEstaciones()

                Dim estInicio As New Estacion
                Dim estFin As New Estacion

                estInicio = gestorEst.RetrieveEstacionPorNombre(cmbEstacionInicial.Text)
                estFin = gestorEst.RetrieveEstacionPorNombre(cmbEstacionFinal.Text)

                linea.Nombre = txtNombre.Text
                linea.Color = txtColor.Text
                linea.Distancia = txtDistancia.Text
                linea.Estado = cmbEstado.Text
                linea.EstacionInicial = estInicio.Codigo
                linea.EstacionFinal = estFin.Codigo
                linea.HoraTrabajo = cmbHoras.Text
                linea.HoraInicio = txtHoraInicio.Text
                linea.CostoCirculacion = txtTarifa.Text

                For i = 0 To lstEstaciones.Count - 1
                    If lstEstaciones(i).Central = 1 Then
                        linea.CodCentral = lstEstaciones(i).Codigo
                        i = lstEstaciones.Count
                    End If
                Next i

                If estado = 1 Then
                    'gestor.CreateLinea(linea)

                    dgLineas_Load()
                    MsgBox("¡Línea guardada con éxito!", MsgBoxStyle.Information)
                End If

                Dim estacionesAAsignar As New List(Of Estacion)

                estacionesAAsignar.Add(estInicio)
                estacionesAAsignar.Add(estFin)

                For i = 0 To lbEstaciones.SelectedItems.Count - 1
                    Dim est As New Estacion
                    est = gestorEst.RetrieveEstacionPorNombre(lbEstaciones.SelectedItems(i).ToString)
                    estacionesAAsignar.Add(est)
                Next i

                For j = 0 To estacionesAAsignar.Count - 1
                    gestor.CreateEstacionesPorLinea(estacionesAAsignar(j).Nombre, txtNombre.Text)
                Next j

                Clear_Fields()
            Else
                MsgBox("La estación final y la estación inicial no pueden ser las mismas.", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("Hay campos con formatos no válidos y/o en blanco.")
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim utilitario As New Utilitario()

        Dim nombre = utilitario.ValidarTexto(txtNombre.Text)
        Dim color = utilitario.ValidarTexto(txtColor.Text)
        Dim distancia = utilitario.ValidarEnteroYDecimal(txtDistancia.Text)
        Dim estadoLinea = utilitario.ValidarComboBox(cmbEstado.Text)
        Dim estacionInicial = utilitario.ValidarComboBox(cmbEstacionInicial.Text)
        Dim estacionFinal = utilitario.ValidarComboBox(cmbEstacionFinal.Text)
        Dim horasTrabajo = utilitario.ValidarComboBox(cmbHoras.Text)
        Dim horaInicio = utilitario.ValidarHora(txtHoraInicio.Text)
        Dim tarifa = utilitario.ValidarEnteroYDecimal(txtTarifa.Text)

        If nombre And color And distancia And estadoLinea And estacionInicial And estacionFinal And horasTrabajo And horaInicio And tarifa Then
            If cmbEstacionInicial.Text <> cmbEstacionFinal.Text Then

                Dim gestor As New GestorLinea(usuarioActual)
                Dim linea As New Linea()

                Dim gestorEst As New GestorEstacion(usuarioActual)
                Dim lstEstaciones As List(Of Estacion)
                lstEstaciones = gestorEst.RetrieveAllEstaciones()

                Dim estInicio As New Estacion
                Dim estFin As New Estacion

                estInicio = gestorEst.RetrieveEstacionPorNombre(cmbEstacionInicial.Text)
                estFin = gestorEst.RetrieveEstacionPorNombre(cmbEstacionFinal.Text)

                linea.Nombre = txtNombre.Text
                linea.Color = txtColor.Text
                linea.Distancia = txtDistancia.Text
                linea.Estado = cmbEstado.Text
                linea.EstacionInicial = estInicio.Codigo
                linea.EstacionFinal = estFin.Codigo
                linea.HoraTrabajo = cmbHoras.Text
                linea.HoraInicio = txtHoraInicio.Text
                linea.CostoCirculacion = txtTarifa.Text

                For i = 0 To lstEstaciones.Count - 1
                    If lstEstaciones(i).Central = 1 Then
                        linea.CodCentral = lstEstaciones(i).Codigo
                        i = lstEstaciones.Count
                    End If
                Next i

                If estado = 2 Then
                    linea.Codigo = lineaSeleccionada
                    gestor.UpdateLinea(linea)

                    dgLineas_Load()
                    MsgBox("¡Línea modificada con éxito!", MsgBoxStyle.Information)

                    gestor.DeleteEstacionesPorLinea(lineaSeleccionada)
                End If

                For i = 0 To lbEstaciones.SelectedItems.Count - 1
                    gestor.CreateEstacionesPorLinea(lbEstaciones.SelectedItems(i).ToString, txtNombre.Text)
                Next

                Clear_Fields()
            Else
                MsgBox("La estación final y la estación inicial no pueden ser las mismas.", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("Hay campos con formatos no válidos y/o en blanco.")
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("¿Seguro que desea eliminar la línea?", "AVISO | Travel", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Dim gestor As New GestorLinea(usuarioActual)
            Dim linea As New Linea()

            linea.Codigo = lineaSeleccionada

            gestor.DeleteLinea(linea)

            dgLineas_Load()
            Clear_Fields()
            MsgBox("¡Línea eliminada con éxito!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Dim gestor As New GestorLinea(usuarioActual)
        Dim nomLinea As String
        Dim linea As New Linea()

        If txtFiltro.Text <> "Nombre" Then
            Dim lstLineas As List(Of Linea)
            lstLineas = gestor.RetrieveAllLineas()

            nomLinea = txtFiltro.Text

            For i = 0 To lstLineas.Count - 1
                If lstLineas(i).Nombre = nomLinea Then
                    linea = gestor.RetrieveLineaPorNombre(nomLinea)

                    Dim gestorEst As New GestorEstacion(usuarioActual)
                    Dim inicial As New Estacion
                    Dim final As New Estacion
                    Dim lstEstaciones As List(Of Estacion)

                    lstEstaciones = gestorEst.RetrieveAllEstaciones()

                    inicial = gestorEst.RetrieveEstacionPorCodigo(lstLineas(i).EstacionInicial)
                    final = gestorEst.RetrieveEstacionPorCodigo(lstLineas(i).EstacionFinal)

                    dgLineas.Rows.Clear()
                    dgLineas.Rows.Add(lstLineas(i).Nombre, inicial.Nombre + " - " + final.Nombre, lstLineas(i).Estado)

                    lstEstaciones = gestorEst.RetrieveAllEstaciones()
                End If
            Next
        Else
            dgLineas_Load()
        End If

        Clear_Fields()
    End Sub

    Private Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
        Clear_Fields()
    End Sub

    Private Sub cbEstacionInicial_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEstacionInicial.SelectedIndexChanged
        lbEstaciones_Load(cmbEstacionInicial.Text, cmbEstacionFinal.Text)
    End Sub

    Private Sub cbEstacionFinal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEstacionFinal.SelectedIndexChanged
        lbEstaciones_Load(cmbEstacionInicial.Text, cmbEstacionFinal.Text)
    End Sub

    Private Sub lbEstaciones_Load(estacionInicial As String, estacionFinal As String)
        lbEstaciones.Items.Clear()

        Dim gestorEstaciones As New GestorEstacion(usuarioActual)
        Dim lstEstaciones As List(Of Estacion)

        lstEstaciones = gestorEstaciones.RetrieveAllEstaciones()

        If estacionInicial <> "" Or estacionFinal <> "" Then
            If estacionFinal <> "" Then
                For i = 0 To lstEstaciones.Count - 1
                    If estacionInicial <> lstEstaciones(i).Nombre And estacionFinal <> lstEstaciones(i).Nombre And lstEstaciones(i).Central <> 1 Then
                        lbEstaciones.Items.Add(lstEstaciones(i).Nombre)
                    End If
                Next
            Else
                For j = 0 To lstEstaciones.Count - 1
                    If estacionInicial <> lstEstaciones(j).Nombre And lstEstaciones(j).Central <> 1 Then
                        lbEstaciones.Items.Add(lstEstaciones(j).Nombre)
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub Clear_Fields()
        estado = 1
        lineaSeleccionada = 0
        txtNombre.Select()
        txtNombre.Text = ""
        txtColor.Text = ""
        txtDistancia.Text = ""
        txtTarifa.Text = ""
        cmbEstado.SelectedIndex = -1
        txtDuracion.Text = ""
        cmbEstacionInicial.SelectedIndex = -1
        cmbEstacionFinal.SelectedIndex = -1
        lbEstaciones.ClearSelected()
        cmbHoras.SelectedIndex = -1
        txtHoraInicio.Text = ""
        txtFiltro.Text = "Nombre"
        txtFiltro.ForeColor = Color.FromArgb(149, 157, 146)
    End Sub

    Private Sub txtFiltro_GotFocus(sender As Object, e As EventArgs) Handles txtFiltro.GotFocus
        If txtFiltro.Text = "Nombre" Then
            txtFiltro.ForeColor = Color.FromArgb(51, 51, 51)
            txtFiltro.Text = ""
        End If
    End Sub

    Private Sub txtFiltro_LostFocus(sender As Object, e As EventArgs) Handles txtFiltro.LostFocus
        If txtFiltro.Text = "" Then
            txtFiltro.ForeColor = Color.FromArgb(149, 157, 146)
            txtFiltro.Text = "Nombre"
        End If
    End Sub
End Class