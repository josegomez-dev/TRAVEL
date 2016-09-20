Imports TRV.API.CORE.Gestores
Imports TRV.API.UTIL.Gestores
Imports TRV.Entidades

Public Class frmNotificacion

    Dim gestorUsuario As New GestorUsuario(usuarioActual)
    Dim gestorIncidencias As New GestorIncidencia(usuarioActual)

    Private Sub frmNotificacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lst As List(Of Incidencia)
        lst = gestorIncidencias.RetrieveAllPorTipo("Incidencia") '' RETRIEVE POR CODIGO 

        If lst Is Nothing Then

        Else

            Dim lstIncidencias As New List(Of String)

            lstIncidencias.Add("")
            For Each item In lst
                lstIncidencias.Add(item.Descripcion)
            Next

            cmbIncidencia.DataSource = lstIncidencias

        End If
    End Sub

    Private Sub gbHorario_Enter(sender As Object, e As EventArgs) Handles gbHorario.Enter

    End Sub

    Private Sub btnNotificar_Click(sender As Object, e As EventArgs) Handles btnNotificar.Click

        Dim lstUsuarios As New List(Of Usuario)
        lstUsuarios = gestorUsuario.RetrieveAll()

        If cmbIncidencia.Text.Equals("") And cbxOtro.Checked = False Then
            MsgBox("Seleccione un mensaje")

        Else
            If cbCorreo.Checked Then '' Send Mail?
                For Each user In lstUsuarios
                    enviarCorreoElectronico(user)
                Next
            End If

            If cbMensaje.Checked Then '' Send SMS?
                For Each user In lstUsuarios
                    enviarMensajeSMS(user)
                Next
            End If

            Me.Close()
        End If

    End Sub

    Private Sub enviarCorreoElectronico(user As Usuario)

        Dim mensajeria = New GestorMail(usuarioActual)
        Dim mensaje = New Mensaje()

        If user.Correo = "jgomezc@ucenfotec.ac.cr" Then 'Filter

            If cbxOtro.Checked Then
                MsgBox(mensajeria.SendMail(user, "Notificacion TRAVEL", txtContenidoPersonalizado.Text))
            Else
                MsgBox(mensajeria.SendMail(user, "Notificacion TRAVEL", cmbIncidencia.Text))
            End If

        End If

    End Sub

    Private Sub enviarMensajeSMS(user As Usuario)

        Dim mensajeria = New GestorSMS(usuarioActual)

        If user.Telefono = "62402974" Then 'Filter

            If cbxOtro.Checked Then
                MsgBox(mensajeria.SendNotify(user, txtContenidoPersonalizado.Text))
            Else
                MsgBox(mensajeria.SendNotify(user, cmbIncidencia.Text))
            End If

        End If

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub cbMensaje_CheckedChanged(sender As Object, e As EventArgs) Handles cbMensaje.CheckedChanged
        If cbMensaje.Checked Or cbCorreo.Checked Then
            btnNotificar.Enabled = True
        Else
            btnNotificar.Enabled = False
        End If
    End Sub

    Private Sub cbCorreo_CheckedChanged(sender As Object, e As EventArgs) Handles cbCorreo.CheckedChanged
        If cbMensaje.Checked Or cbCorreo.Checked Then
            btnNotificar.Enabled = True
        Else
            btnNotificar.Enabled = False
        End If
    End Sub

    Private Sub cbxOtro_CheckedChanged(sender As Object, e As EventArgs) Handles cbxOtro.CheckedChanged

        If cbxOtro.Checked Then
            txtContenidoPersonalizado.Enabled = True
            cmbIncidencia.Text = ""
        Else
            txtContenidoPersonalizado.Enabled = False
            txtContenidoPersonalizado.Text = ""
        End If

    End Sub
End Class