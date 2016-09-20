Imports System.Drawing
Imports TRV.API.CORE.Gestores
Imports TRV.Entidades

Public Class frmEmpresa

    
    Dim gestorEmpresa As GestorEmpresa
    Private utilitario As New Utilitario()
    Private lista As List(Of String)

    Private Sub frmEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Size = New Size(675, 443)
        txtCedula.Select()
        form_Load()
    End Sub

    Private Sub form_Load()
        Dim gestor As New GestorEmpresa(usuarioActual)
        Dim empresa As List(Of Empresa)

        empresa = gestor.RetrieveAll()


        txtCedula.Text = empresa(0).Cedula
        txtNombre.Text = empresa(0).Nombre
        txtDireccion.Text = empresa(0).Direccion
        txtTelefono.Text = empresa(0).Telefono
        txtCorreo.Text = empresa(0).Correo
        txtIV.Text = empresa(0).Impuesto
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim empresa As Empresa = New Empresa()
        Dim mal As Integer
        lista = New List(Of String)

        Try
            empresa.Cedula = txtCedula.Text
            empresa.Nombre = txtNombre.Text
            empresa.Direccion = txtDireccion.Text
            empresa.Telefono = txtTelefono.Text
            empresa.Correo = txtCorreo.Text
            empresa.Impuesto = txtIV.Text

            lista.Add(empresa.Cedula)
            lista.Add(empresa.Nombre)
            lista.Add(empresa.Direccion)
            lista.Add(empresa.Telefono)
            lista.Add(empresa.Correo)
            lista.Add(empresa.Impuesto)

            If utilitario.ValidarEnBlanco(lista) = True Then
                If utilitario.ValidarEnteroYDecimal(empresa.Cedula) = True And utilitario.ValidarEnteroYDecimal(empresa.Telefono) And utilitario.ValidarEnteroYDecimal(empresa.Impuesto) Then

                    If utilitario.ValidarEmail(empresa.Correo) = True Then

                    Else
                        mal = 1
                        MsgBox("El correo electrónico no es valido", MsgBoxStyle.Information)

                    End If

                Else
                    mal = 1
                    MsgBox("No se puede ingresar letras en campos de solo digitos", MsgBoxStyle.Information)

                End If

            Else
                mal = 1
                MsgBox("Faltan campos que completar", MsgBoxStyle.Information)


            End If

            If mal < 1 Then
                gestorEmpresa.update(empresa)
                Clear_Fields()
                lista = New List(Of String)
            End If

        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
        Clear_Fields()
    End Sub

    Public Sub Clear_Fields()
        txtCedula.Select()
        txtCedula.Text = ""
        txtNombre.Text = ""
        txtDireccion.Text = ""
        txtTelefono.Text = ""
        txtCorreo.Text = ""
        txtIV.Text = ""
    End Sub
End Class