Imports System.Drawing
Imports System.Windows.Forms
Imports TRV.API.CORE.Gestores
Imports TRV.Entidades

Public Class frmEstacion

    Private estacionSeleccionada As Integer = 0
    Private estado As Integer = 1 '1 - Registrar / 2 - Modificar

    Private Sub frmEstacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Size = New Size(684, 467)
        txtNombre.Select()
        dgEstaciones_Load()
    End Sub

    Private Sub dgEstaciones_Load()
        dgEstaciones.Rows.Clear()

        Dim gestor As New GestorEstacion(usuarioActual)
        Dim lstEstaciones As New List(Of Estacion)

        lstEstaciones = gestor.RetrieveAllEstaciones()

        If lstEstaciones IsNot Nothing Then
            For i = 0 To lstEstaciones.Count - 1
                dgEstaciones.Rows.Add(lstEstaciones(i).Nombre, lstEstaciones(i).Estado)
            Next i
        End If
    End Sub

    Private Sub dgEstaciones_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgEstaciones.CellClick
        estado = 2

        Dim gestor As New GestorEstacion(usuarioActual)
        Dim codEstacion As String
        Dim estacion As New Estacion()
        Dim columna As String

        columna = dgEstaciones.Columns.Item(0).Name.ToString
        codEstacion = dgEstaciones.SelectedRows(0).Cells(columna).Value.ToString
        estacion = gestor.RetrieveEstacionPorNombre(codEstacion)

        txtLatitud.Enabled = False
        txtLongitud.Enabled = False

        estacionSeleccionada = estacion.Codigo
        txtNombre.Text = estacion.Nombre
        cmbEstado.Text = estacion.Estado
        txtLatitud.Text = estacion.Latitud
        txtLongitud.Text = estacion.Longitud

        If estacion.Central = 1 Then
            cbCentral.Checked = True
            cbCentral.CheckState = CheckState.Indeterminate
        Else
            cbCentral.Checked = False
        End If

        txtLatitud.ForeColor = Color.FromArgb(51, 51, 51)
        txtLongitud.ForeColor = Color.FromArgb(51, 51, 51)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim utilitario As New Utilitario()

        Dim nombre = utilitario.ValidarTexto(txtNombre.Text)
        Dim estadoEstacion = utilitario.ValidarComboBox(cmbEstado.Text)
        Dim latitud = utilitario.ValidarEnteroYDecimal(txtLatitud.Text)
        Dim longitud = utilitario.ValidarEnteroYDecimal(txtLongitud.Text)

        If nombre And estadoEstacion And latitud And longitud Then

            Dim gestor As New GestorEstacion(usuarioActual)
            Dim estacion As New Estacion()

            estacion.Nombre = txtNombre.Text
            estacion.Estado = cmbEstado.Text
            estacion.Latitud = txtLatitud.Text
            estacion.Longitud = txtLongitud.Text

            If cbCentral.Checked = True Then
                Dim lstEstaciones As List(Of Estacion)
                lstEstaciones = gestor.RetrieveAllEstaciones()
                Dim hayCentral As Boolean

                For i = 0 To lstEstaciones.Count - 1
                    If lstEstaciones(i).Central = 1 Then
                        MsgBox("Ya existe una estación central: " + lstEstaciones(i).Nombre, MsgBoxStyle.Information)
                        hayCentral = True
                        i = lstEstaciones.Count
                    End If
                Next i

                If hayCentral = False Then
                    estacion.Central = 1 'Si
                    If estado = 1 Then
                        gestor.CreateEstacion(estacion)

                        dgEstaciones_Load()
                        Clear_Fields()
                        MsgBox("¡Estación guardada con éxito!", MsgBoxStyle.Information)
                    End If
                End If
            Else
                estacion.Central = 2 'No
                If estado = 1 Then
                    gestor.CreateEstacion(estacion)

                    dgEstaciones_Load()
                    Clear_Fields()
                    MsgBox("¡Estación guardada con éxito!", MsgBoxStyle.Information)
                End If
            End If
        Else
            MsgBox("Hay campos con formatos no válidos y/o en blanco.")
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim utilitario As New Utilitario()

        Dim nombre = utilitario.ValidarTexto(txtNombre.Text)
        Dim estadoEstacion = utilitario.ValidarComboBox(cmbEstado.Text)
        Dim latitud = utilitario.ValidarEnteroYDecimal(txtLatitud.Text)
        Dim longitud = utilitario.ValidarEnteroYDecimal(txtLongitud.Text)

        If nombre And estadoEstacion And latitud And longitud Then

            Dim gestor As New GestorEstacion(usuarioActual)
            Dim estacion As New Estacion()

            estacion.Nombre = txtNombre.Text
            estacion.Estado = cmbEstado.Text
            estacion.Latitud = txtLatitud.Text
            estacion.Longitud = txtLongitud.Text

            If cbCentral.Checked = True Then
                Dim lstEstaciones As List(Of Estacion)
                lstEstaciones = gestor.RetrieveAllEstaciones()
                Dim hayCentral As Boolean

                For i = 0 To lstEstaciones.Count - 1
                    If lstEstaciones(i).Central = 1 Then
                        MsgBox("Ya existe una estación central: " + lstEstaciones(i).Nombre, MsgBoxStyle.Information)
                        hayCentral = True
                        i = lstEstaciones.Count
                    End If
                Next i

                If hayCentral = False Then
                    estacion.Central = 1 'Si
                    If estado = 2 Then
                        estacion.Codigo = estacionSeleccionada
                        gestor.UpdateEstacion(estacion)

                        dgEstaciones_Load()
                        Clear_Fields()
                        MsgBox("¡Estación modificada con éxito!", MsgBoxStyle.Information)
                    End If
                End If
            Else
                estacion.Central = 2 'No
                If estado = 2 Then
                    estacion.Codigo = estacionSeleccionada
                    gestor.UpdateEstacion(estacion)

                    dgEstaciones_Load()
                    Clear_Fields()
                    MsgBox("¡Estación modificada con éxito!", MsgBoxStyle.Information)
                End If
            End If
        Else
            MsgBox("Hay campos con formatos no válidos y/o en blanco.")
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("¿Seguro que desea eliminar la estación?", "AVISO | Travel", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Dim gestor As New GestorEstacion(usuarioActual)
            Dim estacion As New Estacion()

            estacion.Codigo = estacionSeleccionada

            gestor.DeleteEstacion(estacion)

            dgEstaciones_Load()
            Clear_Fields()
            MsgBox("¡Estación eliminada con éxito!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Dim nomEstacion As String
        Dim estacion As New Estacion()

        If txtFiltro.Text <> "Nombre" Then
            Dim gestor As New GestorEstacion(usuarioActual)

            Dim lstEstaciones As List(Of Estacion)
            lstEstaciones = gestor.RetrieveAllEstaciones()

            nomEstacion = txtFiltro.Text

            For i = 0 To lstEstaciones.Count - 1
                If lstEstaciones(i).Nombre = nomEstacion Then
                    estacion = gestor.RetrieveEstacionPorNombre(nomEstacion)

                    dgEstaciones.Rows.Clear()
                    dgEstaciones.Rows.Add(estacion.Nombre, estacion.Estado)
                End If
            Next
        Else
            dgEstaciones_Load()
        End If

        Clear_Fields()
    End Sub

    Private Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
        Clear_Fields()
    End Sub

    Private Sub Clear_Fields()
        estado = 1
        estacionSeleccionada = 0
        txtNombre.Select()
        txtNombre.Text = ""
        cmbEstado.SelectedIndex = -1
        txtLatitud.Text = "Latitud"
        txtLatitud.ForeColor = Color.FromArgb(149, 157, 146)
        txtLongitud.Text = "Longitud"
        txtLongitud.ForeColor = Color.FromArgb(149, 157, 146)
        cbCentral.Checked = False
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

    Private Sub txtLatitud_GotFocus(sender As Object, e As EventArgs) Handles txtLatitud.GotFocus
        If txtLatitud.Text = "Latitud" Then
            txtLatitud.ForeColor = Color.FromArgb(51, 51, 51)
            txtLatitud.Text = ""
        End If
    End Sub

    Private Sub txtLatitud_LostFocus(sender As Object, e As EventArgs) Handles txtLatitud.LostFocus
        If txtLatitud.Text = "" Then
            txtLatitud.ForeColor = Color.FromArgb(149, 157, 146)
            txtLatitud.Text = "Latitud"
        End If
    End Sub

    Private Sub txtLongitud_GotFocus(sender As Object, e As EventArgs) Handles txtLongitud.GotFocus
        If txtLongitud.Text = "Longitud" Then
            txtLongitud.ForeColor = Color.FromArgb(51, 51, 51)
            txtLongitud.Text = ""
        End If
    End Sub

    Private Sub txtLongitud_LostFocus(sender As Object, e As EventArgs) Handles txtLongitud.LostFocus
        If txtLongitud.Text = "" Then
            txtLongitud.ForeColor = Color.FromArgb(149, 157, 146)
            txtLongitud.Text = "Longitud"
        End If
    End Sub
End Class