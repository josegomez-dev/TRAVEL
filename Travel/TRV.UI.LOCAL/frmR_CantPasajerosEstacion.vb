Imports System.Drawing

Public Class frmR_CantPasajerosEstacion
    Private Sub R_CantPasajerosEstacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Size = New Size(675, 443)
    End Sub

    Private Sub lbLineas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbLineas.SelectedIndexChanged

    End Sub

    Private Sub lbEstaciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbEstaciones.SelectedIndexChanged

    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click

    End Sub

    Private Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
        lbLineas.ClearSelected()
        lbEstaciones.ClearSelected()
        txtFecha.Text = "Fecha"
    End Sub

    Private Sub txtFecha_GotFocus(sender As Object, e As EventArgs) Handles txtFecha.GotFocus
        If txtFecha.Text = "Fecha" Then
            txtFecha.ForeColor = Color.FromArgb(51, 51, 51)
            txtFecha.Text = ""
        End If
    End Sub

    Private Sub txtFecha_LostFocus(sender As Object, e As EventArgs) Handles txtFecha.LostFocus
        If txtFecha.Text = "" Then
            txtFecha.ForeColor = Color.FromArgb(149, 157, 146)
            txtFecha.Text = "Fecha"
        End If
    End Sub
End Class