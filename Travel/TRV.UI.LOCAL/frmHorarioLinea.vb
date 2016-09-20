Imports TRV.API.CORE.Gestores
Imports TRV.Entidades

Public Class frmHorarioLinea

    Private lineaActual As String

    Sub New(ByVal linea As Integer)
        InitializeComponent()
        lineaActual = linea
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim utilitario As New Utilitario()

        Dim horasTrabajo = utilitario.ValidarComboBox(cmbHoras.Text)
        Dim horaInicio = utilitario.ValidarHora(txtHoraInicio.Text)

        If horasTrabajo And horaInicio Then
            Dim gestor As New GestorLinea(usuarioActual)
            Dim lineaAModificar As New Linea()
            Dim lineaConsultada As New Linea()
            lineaConsultada = gestor.RetrieveLineaPorCodigo(lineaActual)

            lineaAModificar.Codigo = lineaActual
            lineaAModificar.Nombre = lineaConsultada.Nombre
            lineaAModificar.Color = lineaConsultada.Color
            lineaAModificar.Distancia = lineaConsultada.Distancia
            lineaAModificar.Estado = lineaConsultada.Estado
            lineaAModificar.EstacionInicial = lineaConsultada.EstacionInicial
            lineaAModificar.EstacionFinal = lineaConsultada.EstacionFinal
            lineaAModificar.HoraTrabajo = cmbHoras.Text
            lineaAModificar.HoraInicio = txtHoraInicio.Text
            lineaAModificar.CostoCirculacion = lineaConsultada.CostoCirculacion

            gestor.UpdateLinea(lineaAModificar)
            MsgBox("¡Horario modificado con éxito!", MsgBoxStyle.Information)
            Me.Close()
        Else
            MsgBox("Hay campos con formatos no válidos y/o en blanco.")
        End If
    End Sub
End Class