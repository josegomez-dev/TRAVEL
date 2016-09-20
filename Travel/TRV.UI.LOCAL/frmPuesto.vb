Imports System.Drawing
Imports System.Windows.Forms
Imports TRV.API.CORE
Imports TRV.API.CORE.Gestores
Imports TRV.Entidades

Public Class frmPuesto

    Private puestoSeleccionado As Integer = 0
    Private estado As Integer = 1 '1 - Registrar / 2 - Modificar

    Private Sub Puesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Size = New Size(675, 443)
        txtNombre.Select()
        dgPuestos_Load()
    End Sub

    Private Sub dgPuestos_Load()
        dgPuestos.Rows.Clear()
        Dim gestor As New GestorPuesto(usuarioActual)
        Dim lstPuesto As New List(Of Puesto)
        Dim cantPermisos As Integer = 0

        lstPuesto = gestor.RetrieveAll()

        If lstPuesto IsNot Nothing Then
            Dim gestorPermiso As New GestorPermiso(usuarioActual)
            Dim lstPermisos As New List(Of Permiso)

            For i = 0 To lstPuesto.Count - 1
                lstPermisos = gestorPermiso.RetrieveAllPermisoPorPuesto(lstPuesto(i).Id)
                If lstPermisos IsNot Nothing Then
                    dgPuestos.Rows.Add(lstPuesto(i).Nombre, (lstPermisos.Count - 1))
                Else
                    dgPuestos.Rows.Add(lstPuesto(i).Nombre, 0)
                End If
            Next i
        End If
    End Sub

    Private Sub dgPuestos_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgPuestos.CellClick
        estado = 2
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dgPuestos.Rows(e.RowIndex)

            Dim columna As String

            columna = dgPuestos.Columns.Item(0).Name.ToString
            txtNombre.Text = row.Cells(columna).Value.ToString

            Dim gestor As New GestorPuesto(usuarioActual)
            Dim puesto As New Puesto()
            puesto = gestor.RetrievePuestoByNombre(txtNombre.Text)
            puestoSeleccionado = puesto.Id
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If estado = 1 Then
            Dim gestor As New GestorPuesto(usuarioActual)
            Dim puesto As New Puesto

            Try
                If txtNombre.Text <> "" Then
                    puesto.Nombre = txtNombre.Text
                    gestor.Create(puesto)
                    txtNombre.Text = ""
                    puestoSeleccionado = 0
                    dgPuestos_Load()
                    MsgBox("¡Puesto registrado con éxito!")
                End If

            Catch ex As Exception
                MsgBox(ex, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If estado = 2 Then
            Dim gestor As New GestorPuesto(usuarioActual)
            Dim puesto As New Puesto()

            Try
                If puestoSeleccionado <> 0 Then
                    puesto.Id = puestoSeleccionado
                    puesto.Nombre = txtNombre.Text
                    gestor.Update(puesto)

                    dgPuestos_Load()
                    MsgBox("¡Puesto modificado con éxito!")
                    Clear_Fields()
                End If
            Catch ex As TRV_Exception
                MsgBox(ex.Mensaje, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("¿Seguro que desea eliminar el puesto?", "AVISO | Travel", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Dim puesto As New Puesto()
            Dim gestor As New GestorPuesto(usuarioActual)

            Try
                If puestoSeleccionado = 0 Then
                    MsgBox("Seleccione el puesto a eliminar", "AVISO | Travel")
                    txtNombre.Text = ""
                Else
                    puesto.Id = puestoSeleccionado
                    puesto.Nombre = txtNombre.Text
                    gestor.delete(puesto)

                    dgPuestos_Load()
                    MsgBox("Eliminado con exito",MsgBoxStyle.OkOnly)
                    Clear_Fields()
                End If

            Catch ex As TRV_Exception
                MsgBox(ex.Mensaje, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
        Clear_Fields()
    End Sub

    Private Sub Clear_Fields()
        estado = 1
        txtNombre.Select()
        txtNombre.Text = ""
        dgPuestos_Load()
    End Sub
End Class