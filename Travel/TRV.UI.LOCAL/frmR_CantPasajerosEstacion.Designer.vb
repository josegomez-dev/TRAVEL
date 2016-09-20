<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmR_CantPasajerosEstacion
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
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.lblFormato = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.pnlTitulo = New System.Windows.Forms.Panel()
        Me.btnRefrescar = New System.Windows.Forms.PictureBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lbLineas = New System.Windows.Forms.ListBox()
        Me.lblLineas = New System.Windows.Forms.Label()
        Me.lbEstaciones = New System.Windows.Forms.ListBox()
        Me.lblEstaciones = New System.Windows.Forms.Label()
        Me.pnlTitulo.SuspendLayout()
        CType(Me.btnRefrescar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnConsultar
        '
        Me.btnConsultar.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultar.Font = New System.Drawing.Font("Berlin Sans FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnConsultar.Location = New System.Drawing.Point(590, 53)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(71, 23)
        Me.btnConsultar.TabIndex = 87
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = False
        '
        'lblFormato
        '
        Me.lblFormato.AutoSize = True
        Me.lblFormato.BackColor = System.Drawing.Color.Transparent
        Me.lblFormato.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormato.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblFormato.Location = New System.Drawing.Point(279, 77)
        Me.lblFormato.Name = "lblFormato"
        Me.lblFormato.Size = New System.Drawing.Size(133, 16)
        Me.lblFormato.TabIndex = 85
        Me.lblFormato.Text = "(Formato dd/mm/yyyy)"
        '
        'txtFecha
        '
        Me.txtFecha.BackColor = System.Drawing.Color.White
        Me.txtFecha.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.txtFecha.Location = New System.Drawing.Point(271, 53)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(151, 21)
        Me.txtFecha.TabIndex = 83
        Me.txtFecha.Text = "Fecha"
        '
        'pnlTitulo
        '
        Me.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.pnlTitulo.Controls.Add(Me.btnRefrescar)
        Me.pnlTitulo.Controls.Add(Me.lblTitulo)
        Me.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.pnlTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitulo.Name = "pnlTitulo"
        Me.pnlTitulo.Size = New System.Drawing.Size(684, 35)
        Me.pnlTitulo.TabIndex = 82
        '
        'btnRefrescar
        '
        Me.btnRefrescar.BackColor = System.Drawing.Color.Transparent
        Me.btnRefrescar.BackgroundImage = Global.TRV.UI.LOCAL.My.Resources.Resources.refrescar
        Me.btnRefrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRefrescar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefrescar.Location = New System.Drawing.Point(8, 7)
        Me.btnRefrescar.Name = "btnRefrescar"
        Me.btnRefrescar.Size = New System.Drawing.Size(20, 20)
        Me.btnRefrescar.TabIndex = 58
        Me.btnRefrescar.TabStop = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lblTitulo.Location = New System.Drawing.Point(199, 6)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(290, 21)
        Me.lblTitulo.TabIndex = 4
        Me.lblTitulo.Text = "Cantidad de pasajeros por estación"
        '
        'lbLineas
        '
        Me.lbLineas.BackColor = System.Drawing.Color.White
        Me.lbLineas.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLineas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lbLineas.FormattingEnabled = True
        Me.lbLineas.ItemHeight = 16
        Me.lbLineas.Location = New System.Drawing.Point(101, 53)
        Me.lbLineas.Name = "lbLineas"
        Me.lbLineas.Size = New System.Drawing.Size(140, 68)
        Me.lbLineas.TabIndex = 89
        '
        'lblLineas
        '
        Me.lblLineas.AutoSize = True
        Me.lblLineas.BackColor = System.Drawing.Color.Transparent
        Me.lblLineas.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLineas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblLineas.Location = New System.Drawing.Point(21, 53)
        Me.lblLineas.Name = "lblLineas"
        Me.lblLineas.Size = New System.Drawing.Size(48, 17)
        Me.lblLineas.TabIndex = 88
        Me.lblLineas.Text = "Líneas:"
        '
        'lbEstaciones
        '
        Me.lbEstaciones.BackColor = System.Drawing.Color.White
        Me.lbEstaciones.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEstaciones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lbEstaciones.FormattingEnabled = True
        Me.lbEstaciones.ItemHeight = 16
        Me.lbEstaciones.Location = New System.Drawing.Point(101, 140)
        Me.lbEstaciones.Name = "lbEstaciones"
        Me.lbEstaciones.Size = New System.Drawing.Size(140, 68)
        Me.lbEstaciones.TabIndex = 91
        '
        'lblEstaciones
        '
        Me.lblEstaciones.AutoSize = True
        Me.lblEstaciones.BackColor = System.Drawing.Color.Transparent
        Me.lblEstaciones.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstaciones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblEstaciones.Location = New System.Drawing.Point(21, 140)
        Me.lblEstaciones.Name = "lblEstaciones"
        Me.lblEstaciones.Size = New System.Drawing.Size(74, 17)
        Me.lblEstaciones.TabIndex = 90
        Me.lblEstaciones.Text = "Estaciones:"
        '
        'frmR_CantPasajerosEstacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.BackgroundImage = Global.TRV.UI.LOCAL.My.Resources.Resources.refrescar
        Me.ClientSize = New System.Drawing.Size(684, 467)
        Me.Controls.Add(Me.lbEstaciones)
        Me.Controls.Add(Me.lblEstaciones)
        Me.Controls.Add(Me.lbLineas)
        Me.Controls.Add(Me.lblLineas)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.lblFormato)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.pnlTitulo)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(202, 7)
        Me.Name = "frmR_CantPasajerosEstacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "R_CantPasajerosEstacion"
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlTitulo.PerformLayout()
        CType(Me.btnRefrescar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents lblFormato As System.Windows.Forms.Label
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents pnlTitulo As System.Windows.Forms.Panel
    Friend WithEvents btnRefrescar As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lbLineas As System.Windows.Forms.ListBox
    Friend WithEvents lblLineas As System.Windows.Forms.Label
    Friend WithEvents lbEstaciones As System.Windows.Forms.ListBox
    Friend WithEvents lblEstaciones As System.Windows.Forms.Label
End Class
