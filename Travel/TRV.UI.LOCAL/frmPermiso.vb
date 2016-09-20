Imports System.Windows.Forms
Imports TRV.API.CORE
Imports TRV.API.CORE.Gestores
Imports TRV.Entidades

Public Class frmPermiso

    Private lista As New List(Of Integer)
    Private listaPermisos As New List(Of Integer)
    Private cmb As New DataGridViewCheckBoxColumn
    Private lstPermiso As List(Of Permiso)
    Private esPresionado As Boolean = False
    Private esPresionadoPermisos As Boolean = False

    Private Sub frmPermiso_Load() Handles MyBase.Load
        cmb.HeaderText = "Seleccionar"
        cmb.Name = "cmb"
        cmb.FillWeight = 20
        dgPermisos.Columns.Add(cmb)

        Dim gestor As New GestorPermiso(usuarioActual)

        Dim lstPermiso As List(Of Permiso)

        lstPermiso = gestor.RetrieveAll()

        If lstPermiso Is Nothing Then
        Else
            dgPermisos.DataSource = lstPermiso

            dgPermisos.Columns(1).Visible = False
        End If
    End Sub

    Private Sub btnAsignar_Click(sender As Object, e As EventArgs) Handles btnAsignar.Click
        Try
            Dim gestor As New GestorPuesto(usuarioActual)
            Dim gestoPermisos As New GestorPermiso(usuarioActual)
            Dim puesto As New Puesto()
            Dim permiso As New Permiso()

            puesto = gestor.RetrievePuestoByNombre(cmbPuesto.Text)

            If cmbPuesto.Text = "" Then
                MsgBox("Seleccione el puesto que desea asignarle los permisos", MsgBoxStyle.Information)

            ElseIf esPresionado = False Then
                MsgBox("Seleccion los permiso que desea asignar", MsgBoxStyle.Information)
            Else
                For Each o As Object In lista
                    permiso.Codigo = o
                    gestor.CreatePuestosPorPermisos(permiso, puesto)
                Next

                MsgBox("Se le asignaron correctamente los permisos al rol", MsgBoxStyle.Information)
               
               
            End If
        Catch ex As TRV_Exception
            MsgBox(ex.Mensaje, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub data_ComboBox() Handles MyBase.Load

        Dim gestor As New GestorPuesto(usuarioActual)
        Dim puesto As New Puesto()
        Dim lstPuesto As List(Of Puesto)

        lstPuesto = gestor.RetrieveAll()
        For Each o As Object In lstPuesto
            puesto = o
            cmbPuesto.Items.Add(puesto.Nombre)
        Next

    End Sub

    Private Sub dgPermisos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPermisos.CellContentClick
        If (e.ColumnIndex = 0) Then

            If lista.Exists(Function(value As Integer) value = (dgPermisos.Item(1, dgPermisos.CurrentRow.Index).Value)) = False Then
                esPresionado = True
                lista.Add(dgPermisos.Item(1, dgPermisos.CurrentRow.Index).Value)
            Else
                lista.RemoveAt(lista.IndexOf((dgPermisos.Item(1, dgPermisos.CurrentRow.Index).Value)))
                esPresionado = false
            End If
        End If
    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Dim gestor As New GestorPermiso(usuarioActual)
        Dim gestorP As New GestorPuesto(usuarioActual)
        Dim id As Integer


        Dim puesto As New Puesto()

        If cmbPuesto.Text = "" Then
            MsgBox("Seleccione el puesto")
        Else

            Dim cmb As New DataGridViewCheckBoxColumn
            cmb.HeaderText = "Seleccionar"
            cmb.Name = "cmb"
            cmb.FillWeight = 20


            Dim existColumn As Boolean
            existColumn = False
            For Each column As DataGridViewColumn In dgPermisosPorPuesto.Columns
                If column.Name.Equals("cmb") Then
                    existColumn = True
                End If
            Next

            If Not existColumn Then
                dgPermisosPorPuesto.Columns.Add(cmb)

            End If

            puesto = gestorP.RetrievePuestoByNombre(cmbPuesto.Text)

            id = puesto.Id
            lstPermiso = gestor.RetrieveAllPermisoPorPuesto(id)

            If lstPermiso Is Nothing Then
                'dgPermisosPorPuesto.Columns.Remove(cmb)
                refresh_datagrid()
                MsgBox("No hay informacion que mostrar ")
            Else
                dgPermisosPorPuesto.DataSource = lstPermiso
                dgPermisosPorPuesto.Columns(1).Visible = False
            End If
        End If
    End Sub

    Private Sub dgPermisosPorPuesto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPermisosPorPuesto.CellContentClick
        Dim permiso As New Permiso()
        If (e.ColumnIndex = 0) Then

            If listaPermisos.Exists(Function(value As Integer) value = (dgPermisosPorPuesto.Item(1, dgPermisosPorPuesto.CurrentRow.Index).Value)) = False Then
                esPresionadoPermisos = True
                listaPermisos.Add(dgPermisosPorPuesto.Item(1, dgPermisosPorPuesto.CurrentRow.Index).Value)
                
            Else
                listaPermisos.RemoveAt(listaPermisos.IndexOf((dgPermisosPorPuesto.Item(1, dgPermisosPorPuesto.CurrentRow.Index).Value)))
                esPresionadoPermisos = false
                
            End If
          
        End If
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        Dim permisos As New Permiso()

        Dim gestor As New GestorPuesto(usuarioActual)
        If dgPermisosPorPuesto.Rows.Count = 0 Then
            MsgBox("Liste los permisos para continuar la operacion", MsgBoxStyle.Information)
        ElseIf esPresionadoPermisos = False Then
            MsgBox("Seleccione los permisos a eliminar", MsgBoxStyle.Information)
        Else
            For Each o As Integer In listaPermisos
                permisos.Codigo = o
                gestor.DeletePermisosPorPuestos(permisos)
                refresh_datagrid()
            Next
            MsgBox("Eliminado con exito", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub refresh_datagrid()

        Dim gestor As New GestorPermiso(usuarioActual)
        Dim gestorP As New GestorPuesto(usuarioActual)
        Dim puesto As New Puesto()
        Dim id As Integer
        Dim lstPermiso As List(Of Permiso)

        puesto = gestorP.RetrievePuestoByNombre(cmbPuesto.Text)
        id = puesto.Id
        lstPermiso = gestor.RetrieveAllPermisoPorPuesto(id)
        dgPermisosPorPuesto.DataSource = lstPermiso

    End Sub

    'Private Sub dgPermisos_ReLoad()
    '    Dim  e As DataGridViewCell = dgPermisos.CurrentCell
    '    If (e.ColumnIndex = 0) Then
    '    If dgPermisos.Item(1, dgPermisosPorPuesto.CurrentRow.Index).Value = 1 Then
    '         dgPermisos.Item(1, dgPermisos.CurrentRow.Index).Value = 0
    '         dgPermisos.Columns.Remove(cmb)
    '          frmPermiso_Load

    '    End If
    '    End if

    'End Sub
End Class