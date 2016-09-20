<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.btnSeguridad = New System.Windows.Forms.PictureBox()
        Me.btnReportes = New System.Windows.Forms.PictureBox()
        Me.btnDashboard = New System.Windows.Forms.PictureBox()
        Me.btnConfiguracion = New System.Windows.Forms.PictureBox()
        Me.lnkCerrarSesion = New System.Windows.Forms.LinkLabel()
        Me.lblSubtitulo = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.pnlMenuPrincipal = New System.Windows.Forms.Panel()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.btnSeguridad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnReportes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDashboard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnConfiguracion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        Me.pnlMenuPrincipal.SuspendLayout()
        Me.pnlFooter.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnMinimizar
        '
        Me.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimizar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnMinimizar.Location = New System.Drawing.Point(872, 3)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(25, 24)
        Me.btnMinimizar.TabIndex = 3
        Me.btnMinimizar.Text = "ꟷ"
        Me.ToolTip.SetToolTip(Me.btnMinimizar, "Minimizar")
        Me.btnMinimizar.UseVisualStyleBackColor = False
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lblFecha.Location = New System.Drawing.Point(529, 4)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(48, 18)
        Me.lblFecha.TabIndex = 2
        Me.lblFecha.Text = "Fecha"
        Me.ToolTip.SetToolTip(Me.lblFecha, "Fecha")
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lblUsuario.Location = New System.Drawing.Point(264, 5)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(57, 18)
        Me.lblUsuario.TabIndex = 1
        Me.lblUsuario.Text = "Usuario"
        Me.ToolTip.SetToolTip(Me.lblUsuario, "Usuario")
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lblHora.Location = New System.Drawing.Point(3, 5)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(41, 18)
        Me.lblHora.TabIndex = 0
        Me.lblHora.Text = "Hora"
        Me.ToolTip.SetToolTip(Me.lblHora, "Hora")
        '
        'btnSeguridad
        '
        Me.btnSeguridad.BackgroundImage = Global.TRV.UI.LOCAL.My.Resources.Resources.seguridad
        Me.btnSeguridad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSeguridad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSeguridad.Location = New System.Drawing.Point(423, 23)
        Me.btnSeguridad.Name = "btnSeguridad"
        Me.btnSeguridad.Size = New System.Drawing.Size(44, 44)
        Me.btnSeguridad.TabIndex = 7
        Me.btnSeguridad.TabStop = False
        Me.ToolTip.SetToolTip(Me.btnSeguridad, "Seguridad")
        '
        'btnReportes
        '
        Me.btnReportes.BackgroundImage = Global.TRV.UI.LOCAL.My.Resources.Resources.reportes
        Me.btnReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReportes.Location = New System.Drawing.Point(301, 23)
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.Size = New System.Drawing.Size(44, 44)
        Me.btnReportes.TabIndex = 6
        Me.btnReportes.TabStop = False
        Me.ToolTip.SetToolTip(Me.btnReportes, "Reportes")
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.Transparent
        Me.btnDashboard.BackgroundImage = Global.TRV.UI.LOCAL.My.Resources.Resources.dashboard
        Me.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashboard.Location = New System.Drawing.Point(55, 23)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(44, 44)
        Me.btnDashboard.TabIndex = 4
        Me.btnDashboard.TabStop = False
        Me.btnDashboard.Tag = ""
        Me.ToolTip.SetToolTip(Me.btnDashboard, "Dashboard")
        '
        'btnConfiguracion
        '
        Me.btnConfiguracion.BackgroundImage = Global.TRV.UI.LOCAL.My.Resources.Resources.configuracion
        Me.btnConfiguracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfiguracion.Location = New System.Drawing.Point(178, 23)
        Me.btnConfiguracion.Name = "btnConfiguracion"
        Me.btnConfiguracion.Size = New System.Drawing.Size(44, 44)
        Me.btnConfiguracion.TabIndex = 5
        Me.btnConfiguracion.TabStop = False
        Me.ToolTip.SetToolTip(Me.btnConfiguracion, "Configuración")
        '
        'lnkCerrarSesion
        '
        Me.lnkCerrarSesion.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lnkCerrarSesion.AutoSize = True
        Me.lnkCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkCerrarSesion.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lnkCerrarSesion.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lnkCerrarSesion.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline
        Me.lnkCerrarSesion.LinkColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lnkCerrarSesion.Location = New System.Drawing.Point(794, 7)
        Me.lnkCerrarSesion.Name = "lnkCerrarSesion"
        Me.lnkCerrarSesion.Size = New System.Drawing.Size(75, 16)
        Me.lnkCerrarSesion.TabIndex = 4
        Me.lnkCerrarSesion.TabStop = True
        Me.lnkCerrarSesion.Text = "Cerrar sesión"
        Me.lnkCerrarSesion.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        '
        'lblSubtitulo
        '
        Me.lblSubtitulo.AutoSize = True
        Me.lblSubtitulo.Font = New System.Drawing.Font("Berlin Sans FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.lblSubtitulo.Location = New System.Drawing.Point(27, 54)
        Me.lblSubtitulo.Name = "lblSubtitulo"
        Me.lblSubtitulo.Size = New System.Drawing.Size(152, 17)
        Me.lblSubtitulo.TabIndex = 12
        Me.lblSubtitulo.Text = "trenes de alta velocidad"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Mistral", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.lblTitulo.Location = New System.Drawing.Point(15, 11)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(136, 57)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "TRAVEL"
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblSubtitulo)
        Me.pnlHeader.Controls.Add(Me.lblTitulo)
        Me.pnlHeader.Controls.Add(Me.pnlMenuPrincipal)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(900, 86)
        Me.pnlHeader.TabIndex = 12
        '
        'pnlMenuPrincipal
        '
        Me.pnlMenuPrincipal.BackColor = System.Drawing.Color.Transparent
        Me.pnlMenuPrincipal.Controls.Add(Me.btnSeguridad)
        Me.pnlMenuPrincipal.Controls.Add(Me.btnReportes)
        Me.pnlMenuPrincipal.Controls.Add(Me.btnConfiguracion)
        Me.pnlMenuPrincipal.Controls.Add(Me.btnDashboard)
        Me.pnlMenuPrincipal.Location = New System.Drawing.Point(294, 0)
        Me.pnlMenuPrincipal.Name = "pnlMenuPrincipal"
        Me.pnlMenuPrincipal.Size = New System.Drawing.Size(520, 86)
        Me.pnlMenuPrincipal.TabIndex = 0
        '
        'pnlFooter
        '
        Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.pnlFooter.Controls.Add(Me.lnkCerrarSesion)
        Me.pnlFooter.Controls.Add(Me.btnMinimizar)
        Me.pnlFooter.Controls.Add(Me.lblFecha)
        Me.pnlFooter.Controls.Add(Me.lblUsuario)
        Me.pnlFooter.Controls.Add(Me.lblHora)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 571)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(900, 29)
        Me.pnlFooter.TabIndex = 13
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 1000
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = Global.TRV.UI.LOCAL.My.Resources.Resources.fondo_liso
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(900, 600)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlFooter)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Principal"
        CType(Me.btnSeguridad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnReportes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDashboard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnConfiguracion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlMenuPrincipal.ResumeLayout(False)
        Me.pnlFooter.ResumeLayout(False)
        Me.pnlFooter.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents lnkCerrarSesion As System.Windows.Forms.LinkLabel
    Friend WithEvents lblSubtitulo As System.Windows.Forms.Label
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents pnlMenuPrincipal As System.Windows.Forms.Panel
    Private WithEvents btnSeguridad As System.Windows.Forms.PictureBox
    Private WithEvents btnReportes As System.Windows.Forms.PictureBox
    Private WithEvents btnDashboard As System.Windows.Forms.PictureBox
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents btnMinimizar As System.Windows.Forms.Button
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents lblHora As System.Windows.Forms.Label
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Private WithEvents btnConfiguracion As System.Windows.Forms.PictureBox
End Class
