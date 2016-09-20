<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotificacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNotificacion))
        Me.btnNotificar = New System.Windows.Forms.Button()
        Me.txtContenidoPersonalizado = New System.Windows.Forms.TextBox()
        Me.gbHorario = New System.Windows.Forms.GroupBox()
        Me.cmbIncidencia = New System.Windows.Forms.ComboBox()
        Me.cbCorreo = New System.Windows.Forms.CheckBox()
        Me.cbMensaje = New System.Windows.Forms.CheckBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.cbxOtro = New System.Windows.Forms.CheckBox()
        Me.gbHorario.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNotificar
        '
        Me.btnNotificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnNotificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNotificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnNotificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotificar.Font = New System.Drawing.Font("Berlin Sans FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotificar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnNotificar.Location = New System.Drawing.Point(238, 240)
        Me.btnNotificar.Name = "btnNotificar"
        Me.btnNotificar.Size = New System.Drawing.Size(125, 26)
        Me.btnNotificar.TabIndex = 80
        Me.btnNotificar.Text = "Enviar notificación"
        Me.btnNotificar.UseVisualStyleBackColor = False
        '
        'txtContenidoPersonalizado
        '
        Me.txtContenidoPersonalizado.BackColor = System.Drawing.Color.White
        Me.txtContenidoPersonalizado.Enabled = False
        Me.txtContenidoPersonalizado.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContenidoPersonalizado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtContenidoPersonalizado.Location = New System.Drawing.Point(27, 161)
        Me.txtContenidoPersonalizado.Multiline = True
        Me.txtContenidoPersonalizado.Name = "txtContenidoPersonalizado"
        Me.txtContenidoPersonalizado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtContenidoPersonalizado.Size = New System.Drawing.Size(336, 70)
        Me.txtContenidoPersonalizado.TabIndex = 77
        '
        'gbHorario
        '
        Me.gbHorario.Controls.Add(Me.cbxOtro)
        Me.gbHorario.Controls.Add(Me.cmbIncidencia)
        Me.gbHorario.Controls.Add(Me.cbCorreo)
        Me.gbHorario.Controls.Add(Me.cbMensaje)
        Me.gbHorario.Controls.Add(Me.btnNotificar)
        Me.gbHorario.Controls.Add(Me.txtContenidoPersonalizado)
        Me.gbHorario.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbHorario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.gbHorario.Location = New System.Drawing.Point(12, 22)
        Me.gbHorario.Name = "gbHorario"
        Me.gbHorario.Size = New System.Drawing.Size(388, 286)
        Me.gbHorario.TabIndex = 82
        Me.gbHorario.TabStop = False
        Me.gbHorario.Text = "Notificación a los clientes"
        '
        'cmbIncidencia
        '
        Me.cmbIncidencia.BackColor = System.Drawing.Color.White
        Me.cmbIncidencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIncidencia.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbIncidencia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.cmbIncidencia.FormattingEnabled = True
        Me.cmbIncidencia.Location = New System.Drawing.Point(27, 99)
        Me.cmbIncidencia.Name = "cmbIncidencia"
        Me.cmbIncidencia.Size = New System.Drawing.Size(336, 24)
        Me.cmbIncidencia.TabIndex = 84
        '
        'cbCorreo
        '
        Me.cbCorreo.AutoSize = True
        Me.cbCorreo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCorreo.Location = New System.Drawing.Point(27, 59)
        Me.cbCorreo.Name = "cbCorreo"
        Me.cbCorreo.Size = New System.Drawing.Size(141, 21)
        Me.cbCorreo.TabIndex = 83
        Me.cbCorreo.Text = "Correo electrónico"
        Me.cbCorreo.UseVisualStyleBackColor = True
        '
        'cbMensaje
        '
        Me.cbMensaje.AutoSize = True
        Me.cbMensaje.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMensaje.Location = New System.Drawing.Point(27, 32)
        Me.cbMensaje.Name = "cbMensaje"
        Me.cbMensaje.Size = New System.Drawing.Size(131, 21)
        Me.cbMensaje.TabIndex = 82
        Me.cbMensaje.Text = "Mensaje de texto"
        Me.cbMensaje.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnCerrar.Location = New System.Drawing.Point(387, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(25, 24)
        Me.btnCerrar.TabIndex = 86
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'cbxOtro
        '
        Me.cbxOtro.AutoSize = True
        Me.cbxOtro.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxOtro.Location = New System.Drawing.Point(27, 129)
        Me.cbxOtro.Name = "cbxOtro"
        Me.cbxOtro.Size = New System.Drawing.Size(54, 21)
        Me.cbxOtro.TabIndex = 85
        Me.cbxOtro.Text = "Otro"
        Me.cbxOtro.UseVisualStyleBackColor = True
        '
        'frmNotificacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(412, 320)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.gbHorario)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(475, 250)
        Me.Name = "frmNotificacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Notificacion"
        Me.gbHorario.ResumeLayout(False)
        Me.gbHorario.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnNotificar As System.Windows.Forms.Button
    Friend WithEvents txtContenidoPersonalizado As System.Windows.Forms.TextBox
    Friend WithEvents gbHorario As System.Windows.Forms.GroupBox
    Friend WithEvents cbCorreo As System.Windows.Forms.CheckBox
    Friend WithEvents cbMensaje As System.Windows.Forms.CheckBox
    Friend WithEvents cmbIncidencia As System.Windows.Forms.ComboBox
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents cbxOtro As System.Windows.Forms.CheckBox
End Class
