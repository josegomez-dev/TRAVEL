Imports TRV.API.CORE.Gestores
Imports TRV.Entidades

Public Class frmPrecioTiquete

    Private lineaActual As String
    Private tipoTiqueteActual As String

    Sub New(ByVal linea As Integer, ByVal tipoTiquete As String)
        InitializeComponent()
        lineaActual = linea
        tipoTiqueteActual = tipoTiquete
    End Sub

    Private Sub PrecioTiquete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPrecio.Select()
        Dim gestor As New GestorTipoTiquete(usuarioActual)
        Dim tipoTiquete As New TipoTiquete()

        tipoTiquete = gestor.RetrieveByName(tipoTiqueteActual)
        txtPrecio.Text = tipoTiquete.Precio
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim utilitario As New Utilitario()

        Dim precio = utilitario.ValidarEnteroYDecimal(txtPrecio.Text)

        If precio Then
            Dim gestor As New GestorTipoTiquete(usuarioActual)
            Dim tipoTiqueteAModificar As New TipoTiquete()
            Dim tipoTiqueteConsultado As New TipoTiquete()
            tipoTiqueteConsultado = gestor.RetrieveByName(tipoTiqueteActual)

            tipoTiqueteAModificar.Id = tipoTiqueteConsultado.Id
            tipoTiqueteAModificar.Precio = Convert.ToDouble(txtPrecio.Text)
            tipoTiqueteAModificar.Tipo = tipoTiqueteActual

            gestor.update(tipoTiqueteAModificar)
            MsgBox("¡Precio modificado con éxito!", MsgBoxStyle.Information)
            Me.Close()
        Else
            MsgBox("Hay un campo con formato no válido.")
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class