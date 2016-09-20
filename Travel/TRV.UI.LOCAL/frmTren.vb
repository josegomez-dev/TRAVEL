Imports System.Drawing
Imports System.Windows.Forms
Imports TRV.API.CORE.Gestores
Imports TRV.Entidades

Public Class frmTren

    Private estado As Integer = 1 '1 - Registrar / 2 - Modificar
    Dim usr = New Usuario()
    Dim gestor As New GestorTren(usr)

    Private Sub Tren_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Size = New Size(684, 467)
        txtNombre.Select()
        dgTrenes_Load()
        cmbLinea_Load()
    End Sub

    Private Sub cmbLinea_Load()

        Dim gestorLinea As New GestorLinea(usuarioActual)
        Dim lstLinea As List(Of Linea)
        lstLinea = gestorLinea.RetrieveAllLineas()
        Dim linea As New Linea()

        For Each o As Object In lstLinea
            linea = o
            cmbLinea.Items.Add(linea.Codigo)
        Next
    End Sub

    Private Sub dgTrenes_Load()
        dgTrenes.Rows.Clear()

        Dim gestorTren As New GestorTren(usuarioActual)
        Dim lstTrenes As New List(Of Tren)
        lstTrenes = gestorTren.RetrieveAllTren()

        If lstTrenes IsNot Nothing Then
            For i = 0 To lstTrenes.Count - 1
                dgTrenes.Rows.Add(lstTrenes(i).Nombre, lstTrenes(i).Matricula, lstTrenes(i).Estado)
            Next i
        End If
    End Sub

    Private Sub dgTrenes_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgTrenes.CellMouseClick

        Dim t = gestor.RetrievTrenPorMatricula(dgTrenes.Rows(e.RowIndex).Cells(1).Value)

        txtMatricula.Text = t.Matricula
        txtModelo.Text = t.Modelo
        txtNombre.Text = t.Nombre
        txtFechaCompra.Text = t.FechaCompra
        txtCosto.Text = t.Costo
        txtDescripcion.Text = t.Descripcion
        cmbEstado.Text = t.Estado


    End Sub

    Private Sub dgTrenes_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgTrenes.CellClick
        estado = 2
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If estado = 1 Then
            If txtNombre.Text <> "" And txtModelo.Text <> "" And txtMatricula.Text <> "" And cmbEstado.Text <> "" And txtFechaCompra.Text <> "" And txtCosto.Text <> "" And txtDescripcion.Text <> "" Then

                Dim tren As New Tren()

                tren.Nombre = txtNombre.Text
                tren.Modelo = txtNombre.Text
                tren.Matricula = txtMatricula.Text
                tren.Estado = cmbEstado.Text
                tren.FechaCompra = txtFechaCompra.Text
                tren.Costo = txtCosto.Text
                tren.Descripcion = txtDescripcion.Text

                Try
                    gestor.CreateTren(tren)
                    MsgBox("Tren agregado al sistema con éxito", MsgBoxStyle.Information)

                Catch ex As TRV_Exception
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                End Try

            Else
                MsgBox("Existen campos vacios, verifique que los espacios esten con datos válidos.", MsgBoxStyle.Information)
            End If

            If cmbLinea.Text <> "" Then
                If MessageBox.Show("¿Desea asignar el tren a la linea " + cmbLinea.Text + " en la estación inicial? En el caso que seleccione no, se asginaria a la estación final de la linea", "AVISO | Travel", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then

                    Dim t As New Tren()

                    Try
                        t.Kilometro = 0
                        t.CodLinea = cmbLinea.Text
                        t.Matricula = txtMatricula.Text

                        gestor.asignarTrenALinea(t)
                        dgTrenes_Load()

                    Catch ex As TRV_Exception
                        MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                    End Try

                    Clear_Fields()

                Else
                    MsgBox("", MsgBoxStyle.Information)
                End If
            End If

            Clear_Fields()
            dgTrenes_Load()
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If estado = 2 Then
            If txtNombre.Text <> "" And txtModelo.Text <> "" And txtMatricula.Text <> "" And cmbEstado.Text <> "" And txtFechaCompra.Text <> "" And txtCosto.Text <> "" And txtDescripcion.Text <> "" Then

                Dim tren As New Tren()

                tren.Nombre = txtNombre.Text
                tren.Modelo = txtNombre.Text
                tren.Matricula = txtMatricula.Text
                tren.Estado = cmbEstado.Text
                tren.FechaCompra = txtFechaCompra.Text
                tren.Costo = txtCosto.Text
                tren.Descripcion = txtDescripcion.Text

                Try
                    gestor.UpdateTren(tren)
                    MsgBox("Tren modificado en el sistema con éxito", MsgBoxStyle.Information)
                Catch ex As TRV_Exception
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                End Try

                Clear_Fields()
            Else
                MsgBox("Existen campos vacios, verifique que los espacios esten con datos válidos.", MsgBoxStyle.Information)
            End If

            dgTrenes_Load()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("¿Seguro que desea eliminar el tren?", "AVISO | Travel", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            If txtMatricula.Text <> "" Then
                Dim tren As New Tren()

                tren.Matricula = txtMatricula.Text

                Try

                    gestor.DeleteTren(tren)
                    MsgBox("Tren eliminado en el sistema con éxito", MsgBoxStyle.Information)
                    dgTrenes_Load()

                Catch ex As TRV_Exception
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                End Try

                Clear_Fields()

            Else
                MsgBox("El campo de la matricula esta vacio, verifique que el espacio este con datos válidos.", MsgBoxStyle.Information)
            End If
            dgTrenes_Load()
        End If
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        If txtFiltro.Text <> "" Then

            Try

                Dim tren = gestor.RetrievTrenPorMatricula(txtFiltro.Text)
                Dim list As New List(Of Tren)
                list.Add(tren)

                dgTrenes.DataSource = list

            Catch ex As TRV_Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try

        Else
            MsgBox("El campo de consulta esta vacio, verifique que los espaciones esten con datos válidos.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
        Clear_Fields()
    End Sub

    Private Sub Clear_Fields()
        estado = 1
        txtNombre.Select()
        txtNombre.Text = ""
        txtMatricula.Text = ""
        txtModelo.Text = ""
        cmbEstado.SelectedIndex = -1
        txtFechaCompra.Text = "dd/mm/yyyy"
        txtCosto.Text = ""
        txtDescripcion.Text = ""
        txtFiltro.Text = "Nombre"
        dgTrenes_Load()
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

    Private Sub txtFechaCompra_GotFocus(sender As Object, e As EventArgs) Handles txtFechaCompra.GotFocus
        If txtFechaCompra.Text = "dd/mm/yyyy" Then
            txtFechaCompra.ForeColor = Color.FromArgb(51, 51, 51)
            txtFechaCompra.Text = ""
        End If
    End Sub

    Private Sub txtFechaCompra_LostFocus(sender As Object, e As EventArgs) Handles txtFechaCompra.LostFocus
        If txtFechaCompra.Text = "" Then
            txtFechaCompra.ForeColor = Color.FromArgb(149, 157, 146)
            txtFechaCompra.Text = "dd/mm/yyyy"
        End If
    End Sub
End Class