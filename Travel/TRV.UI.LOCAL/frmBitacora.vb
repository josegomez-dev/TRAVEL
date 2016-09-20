Imports System.Drawing
Imports TRV.API.CORE.Gestores
Imports TRV.Entidades

Public Class frmBitacora

    Private Sub Bitacora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Size = New Size(675, 443)

        Dim gestorAccion = New GestorAccion(usuarioActual)
        dgAcciones_Load()
    End Sub

    Private Sub dgAcciones_Load()
        dgAcciones.Rows.Clear()

        Dim gestorAccion = New GestorAccion(usuarioActual)
        Dim lstAcciones As New List(Of Accion)
        lstAcciones = gestorAccion.RetrieveAll()

        If lstAcciones IsNot Nothing Then
            For i = 0 To lstAcciones.Count - 1
                dgAcciones.Rows.Add(lstAcciones(i).IdUsuario, lstAcciones(i).Fecha, lstAcciones(i).TipoAccion)
            Next i
        End If
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Dim nomUsuario As String
        Dim gestorAccion = New GestorAccion(usuarioActual)
        Dim accion As New Accion()

        If txtFiltro.Text <> "Nombre del usuario" Then
            Dim lstAcciones As New List(Of Accion)
            lstAcciones = gestorAccion.RetrieveAll()

            nomUsuario = txtFiltro.Text

            For i = 0 To lstAcciones.Count - 1
                If lstAcciones(i).IdUsuario = nomUsuario Then
                    accion = gestorAccion.RetrieveById(nomUsuario)

                    dgAcciones.Rows.Clear()
                    dgAcciones.Rows.Add(lstAcciones(i).IdUsuario, lstAcciones(i).Fecha, lstAcciones(i).TipoAccion)
                End If
            Next
        Else
            dgAcciones_Load()
        End If
    End Sub

    Private Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
        txtFiltro.Text = "Nombre del usuario"
        dgAcciones_Load()
    End Sub

    Private Sub txtFiltro_GotFocus(sender As Object, e As EventArgs) Handles txtFiltro.GotFocus
        If txtFiltro.Text = "Nombre del usuario" Then
            txtFiltro.ForeColor = Color.FromArgb(51, 51, 51)
            txtFiltro.Text = ""
        End If
    End Sub

    Private Sub txtFiltro_LostFocus(sender As Object, e As EventArgs) Handles txtFiltro.LostFocus
        If txtFiltro.Text = "" Then
            txtFiltro.ForeColor = Color.FromArgb(149, 157, 146)
            txtFiltro.Text = "Nombre del usuario"
        End If
    End Sub
End Class