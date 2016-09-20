Imports System.Drawing
Imports System.Windows.Forms
Imports System.Security.Cryptography
Imports TRV.API.CORE.Gestores
Imports TRV.Entidades
Imports TRV.API.UTIL.Gestores

Public Class frmInicio
    Private rolesPermisos As New RolesPermisos()

    Dim gestor As New GestorUsuario(usuarioActual)
    Dim util As New Utilitario()
    Dim lstPermisos As New List(Of Permiso)

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Try
            Dim aprobado As Boolean = False
            Dim usuario As New Usuario
            If txtCorreo.Text = "Correo electrónico" Then
                MsgBox("Introduzca un correo.")
            Else
                If util.ValidarEmail(txtCorreo.Text) = True Then
                    usuario.Correo = txtCorreo.Text
                    aprobado = True
                Else
                    aprobado = False
                    MsgBox("El formato del correo es inválido.")
                End If
            End If

            If txtContrasena.Text = "Contraseña" Then
                MsgBox("Introduzca una contraseña.")
            End If

            If txtCorreo.Text = "" Or txtContrasena.Text = "" Or aprobado = False Then

            Else
                usuario = gestor.RetrievePorAutentificacion(usuario, txtContrasena.Text) '' RetriveUserById
                If usuario Is Nothing Then

                    MsgBox("El usuario no existe.", MsgBoxStyle.Exclamation)
                Else
                    usuarioActual = usuario

                    If rolesPermisos.VerificarPuestoUsuario() = True Then
                        Dim frm As New frmPrincipal()
                        frm.Show()
                        Me.Hide()
                    Else
                        MsgBox("El usuario no tiene permisos en la aplicación.", MsgBoxStyle.Exclamation)
                    End If

                End If
            End If

        Catch ex As TRV_Exception
            MsgBox(ex.Mensaje, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub lnkRecuperarContrasena_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkRecuperarContrasena.LinkClicked
        Dim sUser As New Usuario()
        Dim mensajeria = New GestorMail(usuarioActual)
        Dim mensajeriaSMS = New GestorSMS(usuarioActual)
        Dim gestorIncidencia = New GestorIncidencia(usuarioActual)
        Dim _mensaje = New Incidencia()

        Dim confirm = Convert.ToInt16(MsgBox("¿Desea recuperar contraseña?", MsgBoxStyle.OkCancel, "TRAVEL | Confirmar contraseña"))

        If confirm = 1 Then
            '' User Recognition
            Dim identificacion = InputBox("Ingrese una identificación válida.", "AVISO | Recuperar contraseña")
            ''util.emailaddresscheck(mail) ''Check Email Addressee

            sUser = gestor.RetrieveUsuario(identificacion)
            ''       sUser = gestor.RetrieveUsuarioPorCorreo(email)

            If sUser Is Nothing Then
                MsgBox("Identificación inválida.", MsgBoxStyle.Information)

            Else
                _mensaje = gestorIncidencia.RetrievePorId("RecoveryPassword")

                Dim newPassword = util.passwordGenerator()

                MsgBox(mensajeriaSMS.SendNotify(sUser, _mensaje.Descripcion & _mensaje.Detalle & newPassword), MsgBoxStyle.Information)
                MsgBox(mensajeria.SendMail(sUser, _mensaje.Descripcion, _mensaje.Detalle & newPassword), MsgBoxStyle.Information)

                '' Enter Code User
                Dim codeInput = InputBox("Ingrese el código de confirmación", "AVISO | Confirmar código")

                If (codeInput.Equals(newPassword)) Then
                    _mensaje = gestorIncidencia.RetrievePorId("WelcomeHome")

                    sUser.Contrasena = newPassword
                    gestor.Update(sUser)

                    MsgBox(mensajeriaSMS.SendNotify(sUser, _mensaje.Detalle & newPassword), MsgBoxStyle.Information)
                    MsgBox(mensajeria.SendMail(sUser, _mensaje.Descripcion & " " & sUser.Nombre, _mensaje.Detalle & newPassword), MsgBoxStyle.Information)
                Else

                    _mensaje = gestorIncidencia.RetrievePorId("InvalidCode")
                    MsgBox(mensajeria.SendMail(sUser, _mensaje.Descripcion, _mensaje.Detalle), MsgBoxStyle.Exclamation)
                End If

            End If

        End If
    End Sub

    Private Function TruncateHash(ByVal key As String, ByVal length As Integer) As Byte()
        Dim sha1 As New SHA1CryptoServiceProvider

        ' Hash the key.
        Dim keyBytes() As Byte =
            System.Text.Encoding.Unicode.GetBytes(key)
        Dim hash() As Byte = sha1.ComputeHash(keyBytes)

        ' Truncate or pad the hash.
        ReDim Preserve hash(length - 1)
        Return hash
    End Function

    Private Sub txtCorreo_LostFocus(sender As Object, e As EventArgs) Handles txtCorreo.LostFocus
        If txtCorreo.Text = "" Then
            txtCorreo.ForeColor = Color.FromArgb(126, 134, 126)
            txtCorreo.Text = "Correo electrónico"
        End If
    End Sub

    Private Sub txtCorreo_GotFocus(sender As Object, e As EventArgs) Handles txtCorreo.GotFocus
        If txtCorreo.Text = "Correo electrónico" Then
            txtCorreo.ForeColor = Color.FromArgb(51, 51, 51)
            txtCorreo.Text = ""
        End If
    End Sub

    Private Sub txtContrasena_LostFocus(sender As Object, e As EventArgs) Handles txtContrasena.LostFocus
        If txtContrasena.Text = "" Then
            txtContrasena.ForeColor = Color.FromArgb(126, 134, 126)
            txtContrasena.UseSystemPasswordChar = False
            txtContrasena.Text = "Contraseña"
        End If
    End Sub

    Private Sub txtContrasena_GotFocus(sender As Object, e As EventArgs) Handles txtContrasena.GotFocus
        If txtContrasena.Text = "Contraseña" Then
            txtContrasena.ForeColor = Color.FromArgb(51, 51, 51)
            txtContrasena.UseSystemPasswordChar = True
            txtContrasena.Text = ""
        End If
    End Sub

    Private Sub cbMostrar_CheckedChanged(sender As Object, e As EventArgs) Handles cbMostrar.CheckedChanged
        If cbMostrar.Checked = True Then
            txtContrasena.UseSystemPasswordChar = False
        Else
            txtContrasena.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MessageBox.Show("¿Seguro que desea salir?", "AVISO | Travel", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub frmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Administrador
        txtCorreo.Text = "jgomezc@ucenfotec.ac.cr"
        txtContrasena.Text = "jgomez"

        'Operador
        'txtCorreo.Text = "eguerrerom@ucenfotec.ac.cr"
        'txtContrasena.Text = "eguerrero"

        'Cajero
        'txtCorreo.Text = "jorgem@gmail.com"
        'txtContrasena.Text = "jorgem"
        txtContrasena.UseSystemPasswordChar = True
    End Sub
End Class