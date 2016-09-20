Imports TRV.API.CORE.Gestores
Imports TRV.Entidades

Public Class frmHistorialViajes
    Private Sub frmHistorialViajes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgEstaciones.Rows.Clear()

        Dim gestor As New GestorHistorialViaje(usuarioActual)
        Dim lst As New List(Of HistorialViajes)
        Dim lstDat As New List(Of String)

        lst = gestor.RetrieveAll()

        If lst.Count > 0 Then

            For Each i In lst
                dgEstaciones.Rows.Add(i.Accion, i.Tren, i.Linea, i.EstacionAnterior, i.EstacionSiguiente, i.TiempoEstimado, i.Fecha)
            Next

        End If

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub dgEstaciones_CellContentClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgEstaciones.CellContentClick

    End Sub
End Class