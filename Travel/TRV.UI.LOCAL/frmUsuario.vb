Imports System.Drawing
Imports System.Windows.Forms
Imports TRV.API.CORE
Imports TRV.API.CORE.Gestores
Imports TRV.Entidades

Public Class frmUsuario

    Private estado As Integer = 1 '1 - Registrar / 2 - Modificar
    Private list As New List(Of Integer)
    Private utilitario As New Utilitario()
    Private lista As New List(Of String)
    Dim xCurrentTextValue As String

    Private Sub Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Size = New Size(684, 467)
        txtCedula.Select()
        dgUsuarios_Load()
    End Sub

    Private Sub data_ComboBox() Handles MyBase.Load
        Dim gestor As New GestorPuesto(usuarioActual)
        Dim puesto As New Puesto()
        Dim lstPuesto As List(Of Puesto)

        lstPuesto = gestor.RetrieveAll()
        For Each o As Object In lstPuesto
            puesto = o
            cmbPuesto.Items.Add(puesto.Nombre)
        Next
    End Sub

    Private Sub dgUsuarios_Load()
        dgUsuarios.Rows.Clear()

        Dim gestorUsuario As New GestorUsuario(usuarioActual)
        Dim lstUsuarios As New List(Of Usuario)

        lstUsuarios = gestorUsuario.RetrieveAll()

        If lstUsuarios IsNot Nothing Then
            For i = 0 To lstUsuarios.Count - 1
                dgUsuarios.Rows.Add(lstUsuarios(i).Cedula, lstUsuarios(i).Nombre, lstUsuarios(i).Telefono, lstUsuarios(i).Correo, lstUsuarios(i).PuestoNombre)
            Next i
        End If
    End Sub

    Private Sub dgUsuarios_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgUsuarios.CellClick
        estado = 2
        Dim gestorU As New GestorUsuario(usuarioActual)
        Dim gestorP As New GestorPuesto(usuarioActual)
        Dim codUsuario As String
        Dim usuario As New Usuario()
        Dim columna As String

        columna = dgUsuarios.Columns.Item(0).Name.ToString
        codUsuario = dgUsuarios.SelectedRows(0).Cells(columna).Value.ToString
        usuario = gestorU.RetrieveUsuario(codUsuario)

        Dim puesto As String
        puesto = gestorP.RetrievePuestoById(usuario.Puesto).Nombre

        txtNombre.Text = usuario.Nombre
        txtCedula.Text = usuario.Cedula
        cmbPuesto.Text = puesto
        txtCorreo.Text = usuario.Correo
        txtTelefono.Text = usuario.Telefono
        txtCedula.Enabled = False

        txtContrasena1.Text = ""
        txtContrasena2.Text = ""
        cbMostrar.Checked = False
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If estado = 1 Then
            Dim usuario As New Usuario()
            Dim gestor As New GestorUsuario(usuarioActual)
            Dim gestorP As New GestorPuesto(usuarioActual)
            Dim puesto As New Puesto()
            Dim aproved As Boolean = False

            Try

                If txtCedula.Enabled = False Then
                    MsgBox("Actualize los campos para poder guardar", MsgBoxStyle.Information)
                Else
                    usuario.Nombre = txtNombre.Text
                    usuario.Cedula = txtCedula.Text
                    usuario.Telefono = txtTelefono.Text

                    If txtCorreo.Text = "" Then
                        usuario.Correo = ""
                    Else
                        If utilitario.ValidarEmail(txtCorreo.Text) = True Then
                            usuario.Correo = txtCorreo.Text
                        Else
                            MsgBox("El formato del correo es invalido", MsgBoxStyle.Information)
                        End If
                    End If



                    If cmbPuesto.Text.Equals("") Then
                        usuario.Puesto = 0
                        aproved = False
                    Else
                        puesto = gestorP.RetrievePuestoByNombre(cmbPuesto.Text)
                        usuario.Puesto = puesto.Id
                        aproved = True
                    End If


                    If txtContrasena1.Text = "" Then
                        usuario.Contrasena = ""
                    Else
                        If txtContrasena2.Text = "" Then
                            MsgBox("Confirme la contraseña ingresada", MsgBoxStyle.Exclamation)
                        Else
                            If utilitario.ValidatePassword(txtContrasena1.Text, txtContrasena2.Text) = True Then
                                usuario.Contrasena = txtContrasena1.Text

                            Else
                                MsgBox("Las contraseñas son diferentes", MsgBoxStyle.Exclamation)
                            End If
                        End If

                    End If

                    lista.Add(usuario.Nombre)
                    lista.Add(usuario.Cedula)
                    lista.Add(usuario.Correo)
                    lista.Add(usuario.Telefono)
                    lista.Add(usuario.Contrasena)

                    If utilitario.ValidarEnBlanco(lista) = True And aproved = True Then
                        gestor.Create(usuario)
                        dgUsuarios_Load()
                        Clear_Fields()
                        MsgBox("Usuario agregado", MsgBoxStyle.Information)
                    Else
                        lista.Clear()
                        MsgBox("Faltan campos que completar", MsgBoxStyle.Information)
                    End If

                End If
            Catch ex As TRV_Exception
                MsgBox(ex.Mensaje, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If estado = 2 Then
            Dim usuario As New Usuario()
            Dim gestor As New GestorUsuario(usuarioActual)
            Dim gestorP As New GestorPuesto(usuarioActual)
            Dim puesto As New Puesto()

            Try
                usuario.Nombre = txtNombre.Text
                usuario.Cedula = txtCedula.Text
                usuario.Correo = txtCorreo.Text
                usuario.Telefono = txtTelefono.Text
                usuario.Contrasena = txtContrasena1.Text
                puesto = gestorP.RetrievePuestoByNombre(cmbPuesto.Text)
                usuario.Puesto = puesto.Id
                gestor.Update(usuario)
                dgUsuarios_Load()
                MsgBox("Modificado con exito", MsgBoxStyle.Information)
            Catch ex As Exception
                Throw ex
            End Try
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("¿Seguro que desea eliminar el usuario?", "AVISO | Travel", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Try
                Dim usuario As New Usuario()
                Dim gestor As New GestorUsuario(usuarioActual)
                usuario.Cedula = txtCedula.Text
                If txtCedula.Text = "" And cmbPuesto.Text.Equals("") Then
                    MsgBox("Debe seleccionar al usuario que desea eliminar", MsgBoxStyle.Information)
                Else
                    gestor.delete(usuario)
                    Clear_Fields()
                    dgUsuarios_Load()
                    MsgBox("Eliminado con exito")
                End If

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click

    End Sub

    Private Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
        Clear_Fields()
        txtCedula.Enabled = True
    End Sub

    Private Sub cmbPuesto_TextChanged(sender As Object, e As EventArgs) Handles cmbPuesto.TextChanged
        If Len(xCurrentTextValue) > 0 Then
            Me.cmbPuesto.Text = xCurrentTextValue
        End If
    End Sub

    Private Sub cbMostrar_CheckedChanged(sender As Object, e As EventArgs) Handles cbMostrar.CheckedChanged
        If cbMostrar.Checked = True Then
            txtContrasena1.UseSystemPasswordChar = False
            txtContrasena2.UseSystemPasswordChar = False
        Else
            txtContrasena1.UseSystemPasswordChar = True
            txtContrasena2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Clear_Fields()
        estado = 1
        txtCedula.Select()
        txtCedula.Text = ""
        txtNombre.Text = ""
        cmbPuesto.SelectedIndex = -1
        txtTelefono.Text = ""
        txtCorreo.Text = ""
        txtContrasena1.Text = ""
        txtContrasena2.Text = ""
        cbMostrar.Checked = False
        txtFiltro.Text = "Nombre"
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