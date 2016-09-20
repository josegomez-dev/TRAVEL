Imports System.Drawing
Imports TRV.API.CORE.Gestores
Imports TRV.Entidades

Public Class frmAsiento

    Private Vagon As Vagon
    Dim usr = New Usuario()
    Dim gestor As New GestorAsiento(usr)

    Private Sub frmAsiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Size = New Size(654, 293)
        txtAsientoInicial.Select()
    End Sub

    Private Sub dgAsientos_Load()

        Dim lista = gestor.obtenerCantidadPorTipo(Vagon.IdVagon)

        Dim cantAsientoAdulto = lista(0)
        Dim cantAsientoAdultoMayor = lista(1)
        Dim cantAsientosVIP = lista(2)

        dgTipoAsientos.Rows.Add("Adulto", cantAsientoAdulto)
        dgTipoAsientos.Rows.Add("Adulto Mayor", cantAsientoAdultoMayor)
        dgTipoAsientos.Rows.Add("VIP", cantAsientosVIP)

    End Sub

    Private Sub dgTAsientos_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgTipoAsientos.CellClick

    End Sub

    Private Sub btnModificarCantAsientos_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnModificarTipoAsiento_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Public Sub asignarVagon(pvagon As Vagon)

        Vagon = pvagon
        dgAsientos_Load()
    End Sub
End Class