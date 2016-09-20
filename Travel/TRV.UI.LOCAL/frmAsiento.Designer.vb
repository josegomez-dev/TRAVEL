<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsiento
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAsiento))
        Me.dgTipoAsientos = New System.Windows.Forms.DataGridView()
        Me.colTipoAsiento_2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRango = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtAsientoInicial = New System.Windows.Forms.TextBox()
        Me.lblRango = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.gbAsientos = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAsientoFinal = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        CType(Me.dgTipoAsientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbAsientos.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgTipoAsientos
        '
        Me.dgTipoAsientos.AllowUserToAddRows = False
        Me.dgTipoAsientos.AllowUserToDeleteRows = False
        Me.dgTipoAsientos.AllowUserToResizeColumns = False
        Me.dgTipoAsientos.AllowUserToResizeRows = False
        Me.dgTipoAsientos.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgTipoAsientos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgTipoAsientos.CausesValidation = False
        Me.dgTipoAsientos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(100, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgTipoAsientos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgTipoAsientos.ColumnHeadersHeight = 30
        Me.dgTipoAsientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgTipoAsientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTipoAsiento_2, Me.colRango})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSalmon
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgTipoAsientos.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgTipoAsientos.GridColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.dgTipoAsientos.Location = New System.Drawing.Point(23, 59)
        Me.dgTipoAsientos.MultiSelect = False
        Me.dgTipoAsientos.Name = "dgTipoAsientos"
        Me.dgTipoAsientos.ReadOnly = True
        Me.dgTipoAsientos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSalmon
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgTipoAsientos.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgTipoAsientos.RowHeadersVisible = False
        Me.dgTipoAsientos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgTipoAsientos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgTipoAsientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgTipoAsientos.Size = New System.Drawing.Size(330, 126)
        Me.dgTipoAsientos.TabIndex = 52
        '
        'colTipoAsiento_2
        '
        Me.colTipoAsiento_2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colTipoAsiento_2.FillWeight = 20.0!
        Me.colTipoAsiento_2.HeaderText = "Tipo"
        Me.colTipoAsiento_2.Name = "colTipoAsiento_2"
        Me.colTipoAsiento_2.ReadOnly = True
        '
        'colRango
        '
        Me.colRango.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colRango.FillWeight = 15.0!
        Me.colRango.HeaderText = "Rango de asientos"
        Me.colRango.Name = "colRango"
        Me.colRango.ReadOnly = True
        '
        'txtAsientoInicial
        '
        Me.txtAsientoInicial.BackColor = System.Drawing.Color.White
        Me.txtAsientoInicial.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAsientoInicial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtAsientoInicial.Location = New System.Drawing.Point(143, 32)
        Me.txtAsientoInicial.Name = "txtAsientoInicial"
        Me.txtAsientoInicial.Size = New System.Drawing.Size(40, 21)
        Me.txtAsientoInicial.TabIndex = 68
        '
        'lblRango
        '
        Me.lblRango.AutoSize = True
        Me.lblRango.BackColor = System.Drawing.Color.Transparent
        Me.lblRango.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRango.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblRango.Location = New System.Drawing.Point(20, 34)
        Me.lblRango.Name = "lblRango"
        Me.lblRango.Size = New System.Drawing.Size(120, 17)
        Me.lblRango.TabIndex = 67
        Me.lblRango.Text = "Rango de asientos:"
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnCerrar.Location = New System.Drawing.Point(377, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(25, 24)
        Me.btnCerrar.TabIndex = 71
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'gbAsientos
        '
        Me.gbAsientos.Controls.Add(Me.Label2)
        Me.gbAsientos.Controls.Add(Me.txtAsientoFinal)
        Me.gbAsientos.Controls.Add(Me.btnGuardar)
        Me.gbAsientos.Controls.Add(Me.dgTipoAsientos)
        Me.gbAsientos.Controls.Add(Me.lblRango)
        Me.gbAsientos.Controls.Add(Me.txtAsientoInicial)
        Me.gbAsientos.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbAsientos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.gbAsientos.Location = New System.Drawing.Point(12, 22)
        Me.gbAsientos.Name = "gbAsientos"
        Me.gbAsientos.Size = New System.Drawing.Size(377, 210)
        Me.gbAsientos.TabIndex = 83
        Me.gbAsientos.TabStop = False
        Me.gbAsientos.Text = "Asientos preferenciales"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(189, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 17)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "-"
        '
        'txtAsientoFinal
        '
        Me.txtAsientoFinal.BackColor = System.Drawing.Color.White
        Me.txtAsientoFinal.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAsientoFinal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtAsientoFinal.Location = New System.Drawing.Point(205, 32)
        Me.txtAsientoFinal.Name = "txtAsientoFinal"
        Me.txtAsientoFinal.Size = New System.Drawing.Size(40, 21)
        Me.txtAsientoFinal.TabIndex = 86
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Berlin Sans FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnGuardar.Location = New System.Drawing.Point(282, 31)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(71, 23)
        Me.btnGuardar.TabIndex = 85
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'frmAsiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(401, 243)
        Me.Controls.Add(Me.gbAsientos)
        Me.Controls.Add(Me.btnCerrar)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(455, 250)
        Me.Name = "frmAsiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Asientos"
        CType(Me.dgTipoAsientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbAsientos.ResumeLayout(False)
        Me.gbAsientos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgTipoAsientos As System.Windows.Forms.DataGridView
    Friend WithEvents txtAsientoInicial As System.Windows.Forms.TextBox
    Friend WithEvents lblRango As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents gbAsientos As System.Windows.Forms.GroupBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents txtAsientoFinal As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents colTipoAsiento_2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRango As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
