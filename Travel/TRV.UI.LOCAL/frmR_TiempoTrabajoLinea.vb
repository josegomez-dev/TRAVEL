Imports System.Drawing

Public Class frmR_TiempoTrabajoLinea
    Private Sub R_TiempoTrabajoLinea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Size = New Size(675, 443)
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click

    End Sub

    Private Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
        txtFechaInicial.Text = "Fecha inicial"
        txtFechaFinal.Text = "Fecha final"
    End Sub

    Private Sub txtFechaInicial_GotFocus(sender As Object, e As EventArgs) Handles txtFechaInicial.GotFocus
        If txtFechaInicial.Text = "Fecha inicial" Then
            txtFechaInicial.ForeColor = Color.FromArgb(51, 51, 51)
            txtFechaInicial.Text = ""
        End If
    End Sub

    Private Sub txtFechaInicial_LostFocus(sender As Object, e As EventArgs) Handles txtFechaInicial.LostFocus
        If txtFechaInicial.Text = "" Then
            txtFechaInicial.ForeColor = Color.FromArgb(149, 157, 146)
            txtFechaInicial.Text = "Fecha inicial"
        End If
    End Sub

    Private Sub txtFechaFinal_GotFocus(sender As Object, e As EventArgs) Handles txtFechaFinal.GotFocus
        If txtFechaFinal.Text = "Fecha final" Then
            txtFechaFinal.ForeColor = Color.FromArgb(51, 51, 51)
            txtFechaFinal.Text = ""
        End If
    End Sub

    Private Sub txtFechaFinal_LostFocus(sender As Object, e As EventArgs) Handles txtFechaFinal.LostFocus
        If txtFechaFinal.Text = "" Then
            txtFechaFinal.ForeColor = Color.FromArgb(149, 157, 146)
            txtFechaFinal.Text = "Fecha final"
        End If
    End Sub
End Class