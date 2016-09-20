Imports System.Drawing
Imports System.Windows.Forms
Imports TRV.API.CORE.Gestores
Imports TRV.Entidades

Public Class frmConvenio

    Private estado As Integer = 1 '1 - Registrar / 2 - Modificar
    Dim gestorConvenio As New GestorConvenio(usuarioActual)
    Dim idConvenio As Integer
    Private utilitario As New Utilitario()
    Private lista As New List(Of String)

    Private Sub Convenios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Size = New Size(675, 443)
        txtNombre.Select()
        dgConvenios_Load()
    End Sub

    Private Sub dgConvenios_Load()
        dgConvenios.Rows.Clear()

        Dim lstConvenios As New List(Of Convenio)
        lstConvenios = gestorConvenio.RetrieveAll()

        If lstConvenios IsNot Nothing Then
            For i = 0 To lstConvenios.Count - 1
                dgConvenios.Rows.Add(lstConvenios(i).Nombre, lstConvenios(i).Descuento)
            Next i
        End If
    End Sub

    Private Sub dgConvenios_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgConvenios.CellClick
        estado = 1
        Dim gestor As New GestorConvenio(usuarioActual)
        Dim nomConvenio As String
        Dim convenio As New Convenio()
        Dim columna As String

        columna = dgConvenios.Columns.Item(0).Name.ToString
        nomConvenio = dgConvenios.SelectedRows(0).Cells(columna).Value.ToString
        convenio = gestor.RetrieveByName(nomConvenio)

        idConvenio = convenio.Id
        txtNombre.Text = convenio.Nombre
        txtDescuento.Text = convenio.Descuento



    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If estado = 1 Then
            Dim convenio As Convenio = New Convenio()
            Try

                lista.Add(txtNombre.Text)
                lista.Add(txtDescuento.Text)
                If utilitario.ValidarEnBlanco(lista) = True Then
                    If utilitario.ValidarEnteroYDecimal(txtDescuento.Text) = True Then
                        convenio.Nombre = txtNombre.Text
                        convenio.Descuento = txtDescuento.Text
                        gestorConvenio.Create(convenio)
                        Clear_Fields()
                        dgConvenios_Load()
                        lista.Clear()
                        MsgBox("¡Convenio guardado con éxito!", MsgBoxStyle.Information)
                    Else
                        MessageBox.Show("El Descuento solo acepta datos numéricos", "AVISO | Travel", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Faltan campos que completar", "AVISO | Travel", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As TRV_Exception
                MsgBox(ex.Mensaje, MsgBoxStyle.Critical)
            End Try

        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If estado = 1 Then
            Dim convenio As Convenio = New Convenio()
            Try

                lista.Add(txtNombre.Text)
                lista.Add(txtDescuento.Text)
                If utilitario.ValidarEnBlanco(lista) = True Then

                    If utilitario.ValidarEnteroYDecimal(txtDescuento.Text) = True Then
                        convenio.Id = idConvenio
                        convenio.Nombre = txtNombre.Text
                        convenio.Descuento = txtDescuento.Text
                        gestorConvenio.update(convenio)
                        Clear_Fields()
                        dgConvenios_Load()
                        lista.Clear()
                        MsgBox("¡Convenio modificado con éxito!", MsgBoxStyle.Information)
                    Else
                        MessageBox.Show("El Descuento solo acepta datos numéricos", "AVISO | Travel", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Faltan campos que completar", "AVISO | Travel", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As TRV_Exception
                MsgBox(ex.Mensaje, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("¿Seguro que desea eliminar el Convenio?", "AVISO | Travel", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Dim gestor As New GestorConvenio(usuarioActual)
            Dim convenio As New Convenio()

            Try
                lista.Add(txtNombre.Text)
                lista.Add(txtDescuento.Text)
                If utilitario.ValidarEnBlanco(lista) = True Then

                    convenio.Id = idConvenio
                    gestor.delete(convenio)

                    dgConvenios_Load()
                    Clear_Fields()
                    lista.Clear()
                    MsgBox("¡Convenio eliminado con éxito!", MsgBoxStyle.Information)

                Else
                    MessageBox.Show("Faltan campos que completar", "AVISO | Travel", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As TRV_Exception
                MsgBox(ex.Mensaje, MsgBoxStyle.Critical)
            End Try

        End If
    End Sub

  
    Private Sub Clear_Fields()
        estado = 1
        txtNombre.Select()
        txtNombre.Text = ""
        txtDescuento.Text = ""
        
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class