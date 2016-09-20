<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVagon
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pnlTitulo = New System.Windows.Forms.Panel()
        Me.btnRefrescar = New System.Windows.Forms.PictureBox()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.dgVagones = New System.Windows.Forms.DataGridView()
        Me.colMatricula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTren = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNumVagon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lblCantVagones = New System.Windows.Forms.Label()
        Me.txtCantVagones = New System.Windows.Forms.TextBox()
        Me.btnAgregarAsientos = New System.Windows.Forms.Button()
        Me.lbTrenes = New System.Windows.Forms.ListBox()
        Me.lblTrenes = New System.Windows.Forms.Label()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lblCantAsientos = New System.Windows.Forms.Label()
        Me.txtCantAsientos = New System.Windows.Forms.TextBox()
        Me.pnlTitulo.SuspendLayout()
        CType(Me.btnRefrescar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgVagones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lblTitulo.Location = New System.Drawing.Point(256, 7)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(167, 21)
        Me.lblTitulo.TabIndex = 4
        Me.lblTitulo.Text = "Gestión de vagones"
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
        Me.pnlTitulo.TabIndex = 49
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
        'btnConsultar
        '
        Me.btnConsultar.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultar.Font = New System.Drawing.Font("Berlin Sans FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnConsultar.Location = New System.Drawing.Point(182, 269)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(71, 23)
        Me.btnConsultar.TabIndex = 60
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = False
        '
        'txtFiltro
        '
        Me.txtFiltro.BackColor = System.Drawing.Color.White
        Me.txtFiltro.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.txtFiltro.Location = New System.Drawing.Point(23, 270)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(151, 21)
        Me.txtFiltro.TabIndex = 59
        Me.txtFiltro.Text = "Nombre del tren"
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Berlin Sans FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnEliminar.Location = New System.Drawing.Point(590, 270)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(71, 23)
        Me.btnEliminar.TabIndex = 58
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'dgVagones
        '
        Me.dgVagones.AllowUserToAddRows = False
        Me.dgVagones.AllowUserToDeleteRows = False
        Me.dgVagones.AllowUserToResizeColumns = False
        Me.dgVagones.AllowUserToResizeRows = False
        Me.dgVagones.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgVagones.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgVagones.CausesValidation = False
        Me.dgVagones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(22, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgVagones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgVagones.ColumnHeadersHeight = 30
        Me.dgVagones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgVagones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colMatricula, Me.colTren, Me.colNumVagon})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LemonChiffon
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgVagones.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgVagones.GridColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.dgVagones.Location = New System.Drawing.Point(24, 299)
        Me.dgVagones.MultiSelect = False
        Me.dgVagones.Name = "dgVagones"
        Me.dgVagones.ReadOnly = True
        Me.dgVagones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSalmon
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgVagones.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgVagones.RowHeadersVisible = False
        Me.dgVagones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgVagones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgVagones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgVagones.Size = New System.Drawing.Size(637, 138)
        Me.dgVagones.TabIndex = 57
        '
        'colMatricula
        '
        Me.colMatricula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.colMatricula.DefaultCellStyle = DataGridViewCellStyle2
        Me.colMatricula.FillWeight = 40.0!
        Me.colMatricula.HeaderText = "Matrícula del tren"
        Me.colMatricula.Name = "colMatricula"
        Me.colMatricula.ReadOnly = True
        '
        'colTren
        '
        Me.colTren.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.colTren.DefaultCellStyle = DataGridViewCellStyle3
        Me.colTren.FillWeight = 40.0!
        Me.colTren.HeaderText = "Nombre del tren"
        Me.colTren.Name = "colTren"
        Me.colTren.ReadOnly = True
        '
        'colNumVagon
        '
        Me.colNumVagon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colNumVagon.FillWeight = 30.0!
        Me.colNumVagon.HeaderText = "Número de vagón"
        Me.colNumVagon.Name = "colNumVagon"
        Me.colNumVagon.ReadOnly = True
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Berlin Sans FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnModificar.Location = New System.Drawing.Point(590, 82)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(71, 23)
        Me.btnModificar.TabIndex = 56
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Berlin Sans FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnGuardar.Location = New System.Drawing.Point(590, 53)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(71, 23)
        Me.btnGuardar.TabIndex = 55
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'lblCantVagones
        '
        Me.lblCantVagones.AutoSize = True
        Me.lblCantVagones.BackColor = System.Drawing.Color.Transparent
        Me.lblCantVagones.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantVagones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblCantVagones.Location = New System.Drawing.Point(268, 55)
        Me.lblCantVagones.Name = "lblCantVagones"
        Me.lblCantVagones.Size = New System.Drawing.Size(141, 17)
        Me.lblCantVagones.TabIndex = 76
        Me.lblCantVagones.Text = "Cantidad de vagones:"
        '
        'txtCantVagones
        '
        Me.txtCantVagones.BackColor = System.Drawing.Color.White
        Me.txtCantVagones.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantVagones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtCantVagones.Location = New System.Drawing.Point(415, 53)
        Me.txtCantVagones.Name = "txtCantVagones"
        Me.txtCantVagones.Size = New System.Drawing.Size(86, 21)
        Me.txtCantVagones.TabIndex = 74
        '
        'btnAgregarAsientos
        '
        Me.btnAgregarAsientos.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnAgregarAsientos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarAsientos.Enabled = False
        Me.btnAgregarAsientos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnAgregarAsientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarAsientos.Font = New System.Drawing.Font("Berlin Sans FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarAsientos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnAgregarAsientos.Location = New System.Drawing.Point(440, 269)
        Me.btnAgregarAsientos.Name = "btnAgregarAsientos"
        Me.btnAgregarAsientos.Size = New System.Drawing.Size(144, 24)
        Me.btnAgregarAsientos.TabIndex = 77
        Me.btnAgregarAsientos.Text = "Asientos preferenciales"
        Me.btnAgregarAsientos.UseVisualStyleBackColor = False
        '
        'lbTrenes
        '
        Me.lbTrenes.BackColor = System.Drawing.Color.White
        Me.lbTrenes.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTrenes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lbTrenes.FormattingEnabled = True
        Me.lbTrenes.ItemHeight = 16
        Me.lbTrenes.Location = New System.Drawing.Point(75, 53)
        Me.lbTrenes.Name = "lbTrenes"
        Me.lbTrenes.Size = New System.Drawing.Size(140, 84)
        Me.lbTrenes.TabIndex = 79
        '
        'lblTrenes
        '
        Me.lblTrenes.AutoSize = True
        Me.lblTrenes.BackColor = System.Drawing.Color.Transparent
        Me.lblTrenes.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrenes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblTrenes.Location = New System.Drawing.Point(21, 53)
        Me.lblTrenes.Name = "lblTrenes"
        Me.lblTrenes.Size = New System.Drawing.Size(48, 17)
        Me.lblTrenes.TabIndex = 78
        Me.lblTrenes.Text = "Trenes:"
        '
        'cmbEstado
        '
        Me.cmbEstado.BackColor = System.Drawing.Color.White
        Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstado.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.cmbEstado.Location = New System.Drawing.Point(75, 143)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(140, 24)
        Me.cmbEstado.TabIndex = 83
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.BackColor = System.Drawing.Color.Transparent
        Me.lblEstado.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblEstado.Location = New System.Drawing.Point(18, 145)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(51, 17)
        Me.lblEstado.TabIndex = 82
        Me.lblEstado.Text = "Estado:"
        '
        'lblCantAsientos
        '
        Me.lblCantAsientos.AutoSize = True
        Me.lblCantAsientos.BackColor = System.Drawing.Color.Transparent
        Me.lblCantAsientos.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantAsientos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblCantAsientos.Location = New System.Drawing.Point(239, 82)
        Me.lblCantAsientos.Name = "lblCantAsientos"
        Me.lblCantAsientos.Size = New System.Drawing.Size(170, 17)
        Me.lblCantAsientos.TabIndex = 85
        Me.lblCantAsientos.Text = "Cantidad total de asientos:"
        '
        'txtCantAsientos
        '
        Me.txtCantAsientos.BackColor = System.Drawing.Color.White
        Me.txtCantAsientos.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantAsientos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtCantAsientos.Location = New System.Drawing.Point(415, 80)
        Me.txtCantAsientos.Name = "txtCantAsientos"
        Me.txtCantAsientos.Size = New System.Drawing.Size(86, 21)
        Me.txtCantAsientos.TabIndex = 84
        '
        'frmVagon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(684, 467)
        Me.Controls.Add(Me.lblCantAsientos)
        Me.Controls.Add(Me.txtCantAsientos)
        Me.Controls.Add(Me.cmbEstado)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.lbTrenes)
        Me.Controls.Add(Me.lblTrenes)
        Me.Controls.Add(Me.btnAgregarAsientos)
        Me.Controls.Add(Me.lblCantVagones)
        Me.Controls.Add(Me.txtCantVagones)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.txtFiltro)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.dgVagones)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.pnlTitulo)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(202, 7)
        Me.Name = "frmVagon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Vagón"
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlTitulo.PerformLayout()
        CType(Me.btnRefrescar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgVagones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents pnlTitulo As System.Windows.Forms.Panel
    Friend WithEvents btnRefrescar As System.Windows.Forms.PictureBox
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents dgVagones As System.Windows.Forms.DataGridView
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents lblCantVagones As System.Windows.Forms.Label
    Friend WithEvents txtCantVagones As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregarAsientos As System.Windows.Forms.Button
    Friend WithEvents lbTrenes As System.Windows.Forms.ListBox
    Friend WithEvents lblTrenes As System.Windows.Forms.Label
    Friend WithEvents cmbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents colMatricula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTren As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNumVagon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblCantAsientos As System.Windows.Forms.Label
    Friend WithEvents txtCantAsientos As System.Windows.Forms.TextBox
End Class
