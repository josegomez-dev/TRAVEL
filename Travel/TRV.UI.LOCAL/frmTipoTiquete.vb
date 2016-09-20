Imports System.Drawing
Imports System.Windows.Forms
Imports TRV.API.CORE.Gestores
Imports TRV.Entidades

Public Class frmTipoTiquete
    Private rolesPermisos As New RolesPermisos()

    Private estado As Integer = 1 '1 - Registrar / 2 - Modificar
    Dim gestorTipo As New GestorTipoTiquete(usuarioActual)
    Dim idTipotiquete As Integer
    Private utilitario As New Utilitario()
    Private lista As New List(Of String)

    Private Sub TipoTiquete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Size = New Size(675, 443)
        txtNombre.Select()
        dgTiposTiquete_Load()
    End Sub

    Private Sub dgTiposTiquete_Load()
        dgTiposTiquete.Rows.Clear()

        Dim lstTiquetes As New List(Of TipoTiquete)
        lstTiquetes = gestorTipo.RetrieveAll()

        If lstTiquetes IsNot Nothing Then
            For i = 0 To lstTiquetes.Count - 1
                dgTiposTiquete.Rows.Add(lstTiquetes(i).Tipo, lstTiquetes(i).Precio)
            Next i
        End If
    End Sub

    Private Sub dgTiposTiquete_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgTiposTiquete.CellClick
        estado = 1
        Dim gestor As New GestorTipoTiquete(usuarioActual)
        Dim nomTipo As String
        Dim tipo As New TipoTiquete()
        Dim columna As String

        columna = dgTiposTiquete.Columns.Item(0).Name.ToString
        nomTipo = dgTiposTiquete.SelectedRows(0).Cells(columna).Value.ToString
        tipo = gestor.RetrieveByName(nomTipo)

        idTipotiquete = tipo.Id
        txtNombre.Text = tipo.Tipo
        txtPrecio.Text = tipo.Precio



    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If estado = 1 Then
            Dim tipo As TipoTiquete = New TipoTiquete()
            Try

                lista.Add(txtNombre.Text)
                lista.Add(txtPrecio.Text)
                If utilitario.ValidarEnBlanco(lista) = True Then
                    If utilitario.ValidarEnteroYDecimal(txtPrecio.Text) = True Then
                        tipo.Tipo = txtNombre.Text
                        tipo.Precio = txtPrecio.Text
                        gestorTipo.Create(tipo)
                        Clear_Fields()
                        dgTiposTiquete_Load()
                        lista.Clear()
                        MsgBox("¡Tipo de tiquete guardado con éxito!", MsgBoxStyle.Information)
                    Else
                        MessageBox.Show("El precio solo acepta datos numéricos", "AVISO | Travel", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Faltan campos que completar", "AVISO | Travel", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As TRV_Exception
                MsgBox(ex.Mensaje, MsgBoxStyle.Critical)
            End Try

        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If estado = 1 Then
            Dim tipo As TipoTiquete = New TipoTiquete()
            Try

                lista.Add(txtNombre.Text)
                lista.Add(txtPrecio.Text)
                If utilitario.ValidarEnBlanco(lista) = True Then

                    If utilitario.ValidarEnteroYDecimal(txtPrecio.Text) = True Then
                        tipo.Id = idTipotiquete
                        tipo.Tipo = txtNombre.Text
                        tipo.Precio = txtPrecio.Text
                        gestorTipo.update(tipo)
                        Clear_Fields()
                        dgTiposTiquete_Load()
                        lista.Clear()
                        MsgBox("¡Tipo de tiquete modificado con éxito!", MsgBoxStyle.Information)
                    Else
                        MessageBox.Show("El precio solo acepta datos numéricos", "AVISO | Travel", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Faltan campos que completar", "AVISO | Travel", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As TRV_Exception
                MsgBox(ex.Mensaje, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("¿Seguro que desea eliminar el tipo de tiquete?", "AVISO | Travel", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Dim gestor As New GestorTipoTiquete(usuarioActual)
            Dim tipo As New TipoTiquete()

            Try
                lista.Add(txtNombre.Text)
                lista.Add(txtPrecio.Text)
                If utilitario.ValidarEnBlanco(lista) = True Then

                    tipo.Id = idTipotiquete
                    gestor.delete(tipo)

                    dgTiposTiquete_Load()
                    Clear_Fields()
                    lista.Clear()
                    MsgBox("¡Tipo de tiquete eliminado con éxito!", MsgBoxStyle.Information)

                Else
                    MessageBox.Show("Faltan campos que completar", "AVISO | Travel", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As TRV_Exception
                MsgBox(ex.Mensaje, MsgBoxStyle.Critical)
            End Try

        End If
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Dim nomTiquete As String
        Dim tipoTiquete As New TipoTiquete()
        Try
            If txtFiltro.Text <> "Nombre" Then
                Dim gestor As New GestorTipoTiquete(usuarioActual)

                Dim lstTipos As List(Of TipoTiquete)
                lstTipos = gestor.RetrieveAll()

                nomTiquete = txtFiltro.Text

                For i = 0 To lstTipos.Count - 1
                    If lstTipos(i).Tipo = nomTiquete Then
                        tipoTiquete = gestor.RetrieveByName(nomTiquete)

                        dgTiposTiquete.Rows.Clear()
                        dgTiposTiquete.Rows.Add(tipoTiquete.Tipo, tipoTiquete.Precio)
                    End If
                Next
            Else
                dgTiposTiquete_Load()
            End If

        Catch ex As TRV_Exception
            MsgBox(ex.Mensaje, MsgBoxStyle.Critical)
        End Try
        Clear_Fields()
    End Sub

    Private Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
        Clear_Fields()
    End Sub

    Private Sub Clear_Fields()
        estado = 1
        txtNombre.Select()
        txtNombre.Text = ""
        txtPrecio.Text = ""
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

    Private Sub btnConvenio_Click(sender As Object, e As EventArgs) Handles btnConvenio.Click
        If rolesPermisos.PermisoUsuario(RolesPermisos.VentanasIDS.convenio) Then
            Dim frm As New frmConvenio()
            frm.Show()
        End If
    End Sub
End Class