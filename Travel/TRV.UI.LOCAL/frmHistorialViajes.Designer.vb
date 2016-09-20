<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistorialViajes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHistorialViajes))
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.gbHorario = New System.Windows.Forms.GroupBox()
        Me.dgEstaciones = New System.Windows.Forms.DataGridView()
        Me.Accion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTren = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLinea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEstInicial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEstFinal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTiempoEstimado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbHorario.SuspendLayout()
        CType(Me.dgEstaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnCerrar.Location = New System.Drawing.Point(709, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(25, 24)
        Me.btnCerrar.TabIndex = 88
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'gbHorario
        '
        Me.gbHorario.Controls.Add(Me.dgEstaciones)
        Me.gbHorario.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbHorario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.gbHorario.Location = New System.Drawing.Point(12, 22)
        Me.gbHorario.Name = "gbHorario"
        Me.gbHorario.Size = New System.Drawing.Size(710, 249)
        Me.gbHorario.TabIndex = 87
        Me.gbHorario.TabStop = False
        Me.gbHorario.Text = "Historial de viajes"
        '
        'dgEstaciones
        '
        Me.dgEstaciones.AllowUserToAddRows = False
        Me.dgEstaciones.AllowUserToDeleteRows = False
        Me.dgEstaciones.AllowUserToResizeColumns = False
        Me.dgEstaciones.AllowUserToResizeRows = False
        Me.dgEstaciones.BackgroundColor = System.Drawing.Color.White
        Me.dgEstaciones.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgEstaciones.CausesValidation = False
        Me.dgEstaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(100, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgEstaciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgEstaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgEstaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Accion, Me.colTren, Me.colLinea, Me.colEstInicial, Me.colEstFinal, Me.colTiempoEstimado, Me.Fecha})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgEstaciones.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgEstaciones.GridColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.dgEstaciones.Location = New System.Drawing.Point(23, 36)
        Me.dgEstaciones.MultiSelect = False
        Me.dgEstaciones.Name = "dgEstaciones"
        Me.dgEstaciones.ReadOnly = True
        Me.dgEstaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgEstaciones.RowHeadersVisible = False
        Me.dgEstaciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgEstaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgEstaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgEstaciones.Size = New System.Drawing.Size(665, 192)
        Me.dgEstaciones.TabIndex = 26
        '
        'Accion
        '
        Me.Accion.HeaderText = "Acción"
        Me.Accion.Name = "Accion"
        Me.Accion.ReadOnly = True
        '
        'colTren
        '
        Me.colTren.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colTren.FillWeight = 80.0!
        Me.colTren.HeaderText = "Tren"
        Me.colTren.Name = "colTren"
        Me.colTren.ReadOnly = True
        '
        'colLinea
        '
        Me.colLinea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colLinea.FillWeight = 60.0!
        Me.colLinea.HeaderText = "Línea"
        Me.colLinea.Name = "colLinea"
        Me.colLinea.ReadOnly = True
        '
        'colEstInicial
        '
        Me.colEstInicial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colEstInicial.HeaderText = "Estación inicial"
        Me.colEstInicial.Name = "colEstInicial"
        Me.colEstInicial.ReadOnly = True
        '
        'colEstFinal
        '
        Me.colEstFinal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colEstFinal.HeaderText = "Estación final"
        Me.colEstFinal.Name = "colEstFinal"
        Me.colEstFinal.ReadOnly = True
        '
        'colTiempoEstimado
        '
        Me.colTiempoEstimado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colTiempoEstimado.FillWeight = 60.0!
        Me.colTiempoEstimado.HeaderText = "Tiempo estimado"
        Me.colTiempoEstimado.Name = "colTiempoEstimado"
        Me.colTiempoEstimado.ReadOnly = True
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'frmHistorialViajes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(734, 283)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.gbHorario)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(335, 250)
        Me.Name = "frmHistorialViajes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Historial de viajes"
        Me.gbHorario.ResumeLayout(false)
        CType(Me.dgEstaciones,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents gbHorario As System.Windows.Forms.GroupBox
    Friend WithEvents dgEstaciones As System.Windows.Forms.DataGridView
    Friend WithEvents Accion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTren As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colLinea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEstInicial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEstFinal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTiempoEstimado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
