<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHorarioLinea
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHorarioLinea))
        Me.gbHorario = New System.Windows.Forms.GroupBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.txtHoraInicio = New System.Windows.Forms.TextBox()
        Me.lblFormato = New System.Windows.Forms.Label()
        Me.lblAM = New System.Windows.Forms.Label()
        Me.lblHoraInicio = New System.Windows.Forms.Label()
        Me.lblHoras = New System.Windows.Forms.Label()
        Me.cmbHoras = New System.Windows.Forms.ComboBox()
        Me.lblHorasTrabajo = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.gbHorario.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbHorario
        '
        Me.gbHorario.Controls.Add(Me.btnModificar)
        Me.gbHorario.Controls.Add(Me.txtHoraInicio)
        Me.gbHorario.Controls.Add(Me.lblFormato)
        Me.gbHorario.Controls.Add(Me.lblAM)
        Me.gbHorario.Controls.Add(Me.lblHoraInicio)
        Me.gbHorario.Controls.Add(Me.lblHoras)
        Me.gbHorario.Controls.Add(Me.cmbHoras)
        Me.gbHorario.Controls.Add(Me.lblHorasTrabajo)
        Me.gbHorario.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbHorario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.gbHorario.Location = New System.Drawing.Point(12, 23)
        Me.gbHorario.Name = "gbHorario"
        Me.gbHorario.Size = New System.Drawing.Size(350, 109)
        Me.gbHorario.TabIndex = 75
        Me.gbHorario.TabStop = False
        Me.gbHorario.Text = "Horario de la línea"
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Berlin Sans FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnModificar.Location = New System.Drawing.Point(264, 26)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(71, 23)
        Me.btnModificar.TabIndex = 80
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'txtHoraInicio
        '
        Me.txtHoraInicio.BackColor = System.Drawing.Color.White
        Me.txtHoraInicio.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraInicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtHoraInicio.Location = New System.Drawing.Point(122, 55)
        Me.txtHoraInicio.Name = "txtHoraInicio"
        Me.txtHoraInicio.Size = New System.Drawing.Size(58, 21)
        Me.txtHoraInicio.TabIndex = 79
        '
        'lblFormato
        '
        Me.lblFormato.AutoSize = True
        Me.lblFormato.BackColor = System.Drawing.Color.Transparent
        Me.lblFormato.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormato.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblFormato.Location = New System.Drawing.Point(119, 78)
        Me.lblFormato.Name = "lblFormato"
        Me.lblFormato.Size = New System.Drawing.Size(107, 16)
        Me.lblFormato.TabIndex = 78
        Me.lblFormato.Text = "(Formato 24 horas)"
        '
        'lblAM
        '
        Me.lblAM.AutoSize = True
        Me.lblAM.BackColor = System.Drawing.Color.Transparent
        Me.lblAM.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblAM.Location = New System.Drawing.Point(186, 59)
        Me.lblAM.Name = "lblAM"
        Me.lblAM.Size = New System.Drawing.Size(28, 17)
        Me.lblAM.TabIndex = 77
        Me.lblAM.Text = "AM"
        '
        'lblHoraInicio
        '
        Me.lblHoraInicio.AutoSize = True
        Me.lblHoraInicio.BackColor = System.Drawing.Color.Transparent
        Me.lblHoraInicio.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoraInicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblHoraInicio.Location = New System.Drawing.Point(23, 57)
        Me.lblHoraInicio.Name = "lblHoraInicio"
        Me.lblHoraInicio.Size = New System.Drawing.Size(93, 17)
        Me.lblHoraInicio.TabIndex = 75
        Me.lblHoraInicio.Text = "Hora de inicio:"
        '
        'lblHoras
        '
        Me.lblHoras.AutoSize = True
        Me.lblHoras.BackColor = System.Drawing.Color.Transparent
        Me.lblHoras.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoras.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblHoras.Location = New System.Drawing.Point(186, 32)
        Me.lblHoras.Name = "lblHoras"
        Me.lblHoras.Size = New System.Drawing.Size(40, 17)
        Me.lblHoras.TabIndex = 74
        Me.lblHoras.Text = "horas"
        '
        'cmbHoras
        '
        Me.cmbHoras.BackColor = System.Drawing.Color.White
        Me.cmbHoras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoras.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbHoras.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.cmbHoras.FormattingEnabled = True
        Me.cmbHoras.Items.AddRange(New Object() {"12", "24"})
        Me.cmbHoras.Location = New System.Drawing.Point(122, 25)
        Me.cmbHoras.Name = "cmbHoras"
        Me.cmbHoras.Size = New System.Drawing.Size(58, 24)
        Me.cmbHoras.TabIndex = 73
        '
        'lblHorasTrabajo
        '
        Me.lblHorasTrabajo.AutoSize = True
        Me.lblHorasTrabajo.BackColor = System.Drawing.Color.Transparent
        Me.lblHorasTrabajo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHorasTrabajo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblHorasTrabajo.Location = New System.Drawing.Point(6, 27)
        Me.lblHorasTrabajo.Name = "lblHorasTrabajo"
        Me.lblHorasTrabajo.Size = New System.Drawing.Size(110, 17)
        Me.lblHorasTrabajo.TabIndex = 69
        Me.lblHorasTrabajo.Text = "Horas de trabajo:"
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnCerrar.Location = New System.Drawing.Point(351, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(25, 24)
        Me.btnCerrar.TabIndex = 85
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'frmHorarioLinea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(376, 143)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.gbHorario)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(515, 300)
        Me.Name = "frmHorarioLinea"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Horario de la línea"
        Me.gbHorario.ResumeLayout(False)
        Me.gbHorario.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbHorario As System.Windows.Forms.GroupBox
    Friend WithEvents txtHoraInicio As System.Windows.Forms.TextBox
    Friend WithEvents lblFormato As System.Windows.Forms.Label
    Friend WithEvents lblAM As System.Windows.Forms.Label
    Friend WithEvents lblHoraInicio As System.Windows.Forms.Label
    Friend WithEvents lblHoras As System.Windows.Forms.Label
    Friend WithEvents cmbHoras As System.Windows.Forms.ComboBox
    Friend WithEvents lblHorasTrabajo As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
End Class
