Imports System.Drawing
Imports System.Windows.Forms
Imports TRV.API.CORE.Gestores
Imports TRV.Entidades

Public Class frmVagon
    Private rolesPermisos As New RolesPermisos()

    Private estado As Integer = 1 '1 - Registrar / 2 - Modificar
    Dim gestorTren As New GestorTren(usuarioActual)
    Dim gestorVagon As New GestorVagon(usuarioActual)
    Dim numVagon = -1
    Dim idTren = -1

    Private Sub Vagon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Size = New Size(684, 467)

        lbTrenes_Load()
    End Sub

    Private Sub lbTrenes_Load()
        Dim gestorTren As New GestorTren(usuarioActual)
        Dim lstTrenes As List(Of Tren)
        lstTrenes = gestorTren.RetrieveAllTren()

        If lstTrenes IsNot Nothing Then
            For i = 0 To lstTrenes.Count - 1
                lbTrenes.Items.Add(lstTrenes(i).Matricula)
            Next
        End If
    End Sub

    Private Sub dgVagones_Load()
        dgVagones.Rows.Clear()

        'Dim gestorVagon As New GestorVagon(usuarioActual)
        'Dim lstVagones As New List(Of Vagon)

        'lstVagones = gestorVagon.RetrieveAllVagones()

        'If lstVagones IsNot Nothing Then
        '    For i = 0 To lstVagones.Count - 1
        '        dgVagones.Rows.Add(lstVagones(i).IdTren, lstEstaciones(i).Nombre, lstEstaciones(i).Estado)
        '    Next i
        'End If
    End Sub

    Private Sub dgVagones_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgVagones.CellClick
        estado = 1
        btnAgregarAsientos.Enabled = True
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If estado = 1 Then
            If txtCantVagones.Text <> "" And txtCantAsientos.Text <> "" And lbTrenes.Text <> "" Then

                Dim cantVagones = CInt(txtCantVagones.Text)
                Dim cantAsientos = CInt(txtCantAsientos.Text)

                For i = 1 To cantVagones

                    Dim vagon As New Vagon()
                    vagon.CantAsientos = cantAsientos
                    vagon.IdTren = CInt(lbTrenes.Text)

                    Try
                        gestorVagon.CreateVagon(vagon)

                    Catch ex As TRV_Exception
                        MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                    End Try
                Next i

                MsgBox("Vagones añadidos al sistema con éxito", MsgBoxStyle.Information)
            Else
                MsgBox("Existen campos vacios, verifique que los espacios esten con datos válidos.", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If estado = 2 Then

        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("¿Seguro que desea eliminar el vagón?", "AVISO | Travel", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            'Eliminar
        End If
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        If txtFiltro.Text <> "" Then
            Try
                Dim list = gestorVagon.RetrievVagonPorIdTren(txtFiltro.Text)

                For i = 0 To list.Count - 1

                    Dim Nombre = gestorTren.RetrievTrenPorMatricula(list(i).IdTren).Nombre
                    dgVagones.Rows.Add(list(i).IdTren, Nombre, i + 1)

                Next

            Catch ex As TRV_Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try
        Else
            MsgBox("El campo de consulta esta vacio, verifique que los espaciones esten con datos válidos.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnAgregarAsientos_Click(sender As Object, e As EventArgs) Handles btnAgregarAsientos.Click
        If rolesPermisos.PermisoUsuario(RolesPermisos.VentanasIDS.asiento) Then
            If numVagon <> -1 Then

                Dim list = gestorVagon.RetrievVagonPorIdTren(idTren)
                Dim frm As New frmAsiento()
                frm.asignarVagon(list(numVagon - 1))
                frm.Show()
            Else
                MsgBox("No ha seleccionado un vagón, por favor seleccione un vagón en la tabla de vagones", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
        Clear_Fields()
    End Sub

    Private Sub Clear_Fields()
        estado = 1
        lbTrenes.ClearSelected()
        cmbEstado.SelectedIndex = -1
        txtCantVagones.Text = ""
        txtCantAsientos.Text = ""
        txtFiltro.Text = "Nombre del tren"
        'Listar todos los vagones
    End Sub

    Private Sub txtFiltro_GotFocus(sender As Object, e As EventArgs) Handles txtFiltro.GotFocus
        If txtFiltro.Text = "Nombre del tren" Then
            txtFiltro.ForeColor = Color.FromArgb(51, 51, 51)
            txtFiltro.Text = ""
        End If
    End Sub

    Private Sub txtFiltro_LostFocus(sender As Object, e As EventArgs) Handles txtFiltro.LostFocus
        If txtFiltro.Text = "" Then
            txtFiltro.ForeColor = Color.FromArgb(149, 157, 146)
            txtFiltro.Text = "Nombre del tren"
        End If
    End Sub

    Private Sub dgVagones_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgVagones.CellMouseClick

        If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
            numVagon = dgVagones.Rows(e.RowIndex).Cells(2).Value
            idTren = dgVagones.Rows(e.RowIndex).Cells(0).Value
        End If

    End Sub
End Class