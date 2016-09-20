<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLinea
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pnlTitulo = New System.Windows.Forms.Panel()
        Me.btnRefrescar = New System.Windows.Forms.PictureBox()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.dgLineas = New System.Windows.Forms.DataGridView()
        Me.colNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEstaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.txtDistancia = New System.Windows.Forms.TextBox()
        Me.txtTarifa = New System.Windows.Forms.TextBox()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.lblDistancia = New System.Windows.Forms.Label()
        Me.lblTarifa = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lblEstacionInicial = New System.Windows.Forms.Label()
        Me.cmbEstacionInicial = New System.Windows.Forms.ComboBox()
        Me.lblEstacionFinal = New System.Windows.Forms.Label()
        Me.lblParadas = New System.Windows.Forms.Label()
        Me.lblTiempoDe = New System.Windows.Forms.Label()
        Me.lblRecorrido = New System.Windows.Forms.Label()
        Me.txtDuracion = New System.Windows.Forms.TextBox()
        Me.cmbEstacionFinal = New System.Windows.Forms.ComboBox()
        Me.lbEstaciones = New System.Windows.Forms.ListBox()
        Me.gbHorario = New System.Windows.Forms.GroupBox()
        Me.txtHoraInicio = New System.Windows.Forms.TextBox()
        Me.lblFormato = New System.Windows.Forms.Label()
        Me.lblAM = New System.Windows.Forms.Label()
        Me.lblHoraInicio = New System.Windows.Forms.Label()
        Me.lblHoras = New System.Windows.Forms.Label()
        Me.cmbHoras = New System.Windows.Forms.ComboBox()
        Me.lblHorasTrabajo = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.pnlTitulo.SuspendLayout()
        CType(Me.btnRefrescar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgLineas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbHorario.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lblTitulo.Location = New System.Drawing.Point(270, 7)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(142, 21)
        Me.lblTitulo.TabIndex = 4
        Me.lblTitulo.Text = "Gestión de líneas"
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
        Me.pnlTitulo.TabIndex = 1
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
        Me.btnRefrescar.TabIndex = 59
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
        Me.btnConsultar.TabIndex = 53
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
        Me.txtFiltro.TabIndex = 52
        Me.txtFiltro.Text = "Nombre"
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
        Me.btnEliminar.TabIndex = 51
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'dgLineas
        '
        Me.dgLineas.AllowUserToAddRows = False
        Me.dgLineas.AllowUserToDeleteRows = False
        Me.dgLineas.AllowUserToResizeColumns = False
        Me.dgLineas.AllowUserToResizeRows = False
        Me.dgLineas.BackgroundColor = System.Drawing.Color.White
        Me.dgLineas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgLineas.CausesValidation = False
        Me.dgLineas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(22, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgLineas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgLineas.ColumnHeadersHeight = 30
        Me.dgLineas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgLineas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNombre, Me.colEstaciones, Me.colEstado})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgLineas.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgLineas.GridColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.dgLineas.Location = New System.Drawing.Point(24, 299)
        Me.dgLineas.MultiSelect = False
        Me.dgLineas.Name = "dgLineas"
        Me.dgLineas.ReadOnly = True
        Me.dgLineas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSalmon
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgLineas.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgLineas.RowHeadersVisible = False
        Me.dgLineas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgLineas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgLineas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgLineas.Size = New System.Drawing.Size(637, 143)
        Me.dgLineas.TabIndex = 50
        '
        'colNombre
        '
        Me.colNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colNombre.FillWeight = 25.0!
        Me.colNombre.HeaderText = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.ReadOnly = True
        '
        'colEstaciones
        '
        Me.colEstaciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colEstaciones.FillWeight = 50.0!
        Me.colEstaciones.HeaderText = "Estaciones (inicial - final)"
        Me.colEstaciones.Name = "colEstaciones"
        Me.colEstaciones.ReadOnly = True
        '
        'colEstado
        '
        Me.colEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colEstado.FillWeight = 25.0!
        Me.colEstado.HeaderText = "Estado"
        Me.colEstado.Name = "colEstado"
        Me.colEstado.ReadOnly = True
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
        Me.btnModificar.TabIndex = 49
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.White
        Me.txtNombre.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtNombre.Location = New System.Drawing.Point(87, 52)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(118, 21)
        Me.txtNombre.TabIndex = 55
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblNombre.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblNombre.Location = New System.Drawing.Point(22, 56)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(59, 17)
        Me.lblNombre.TabIndex = 54
        Me.lblNombre.Text = "Nombre:"
        '
        'txtColor
        '
        Me.txtColor.BackColor = System.Drawing.Color.White
        Me.txtColor.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtColor.Location = New System.Drawing.Point(87, 79)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(118, 21)
        Me.txtColor.TabIndex = 56
        '
        'txtDistancia
        '
        Me.txtDistancia.BackColor = System.Drawing.Color.White
        Me.txtDistancia.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDistancia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtDistancia.Location = New System.Drawing.Point(87, 106)
        Me.txtDistancia.Name = "txtDistancia"
        Me.txtDistancia.Size = New System.Drawing.Size(118, 21)
        Me.txtDistancia.TabIndex = 57
        '
        'txtTarifa
        '
        Me.txtTarifa.BackColor = System.Drawing.Color.White
        Me.txtTarifa.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTarifa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtTarifa.Location = New System.Drawing.Point(87, 133)
        Me.txtTarifa.Name = "txtTarifa"
        Me.txtTarifa.Size = New System.Drawing.Size(118, 21)
        Me.txtTarifa.TabIndex = 58
        '
        'cmbEstado
        '
        Me.cmbEstado.BackColor = System.Drawing.Color.White
        Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstado.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"Abierta", "Cerrada", "En mantenimiento"})
        Me.cmbEstado.Location = New System.Drawing.Point(87, 160)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(118, 24)
        Me.cmbEstado.TabIndex = 59
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.BackColor = System.Drawing.Color.Transparent
        Me.lblColor.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblColor.Location = New System.Drawing.Point(38, 82)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(43, 17)
        Me.lblColor.TabIndex = 61
        Me.lblColor.Text = "Color:"
        '
        'lblDistancia
        '
        Me.lblDistancia.AutoSize = True
        Me.lblDistancia.BackColor = System.Drawing.Color.Transparent
        Me.lblDistancia.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDistancia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblDistancia.Location = New System.Drawing.Point(14, 109)
        Me.lblDistancia.Name = "lblDistancia"
        Me.lblDistancia.Size = New System.Drawing.Size(67, 17)
        Me.lblDistancia.TabIndex = 62
        Me.lblDistancia.Text = "Distancia:"
        '
        'lblTarifa
        '
        Me.lblTarifa.AutoSize = True
        Me.lblTarifa.BackColor = System.Drawing.Color.Transparent
        Me.lblTarifa.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTarifa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblTarifa.Location = New System.Drawing.Point(38, 136)
        Me.lblTarifa.Name = "lblTarifa"
        Me.lblTarifa.Size = New System.Drawing.Size(43, 17)
        Me.lblTarifa.TabIndex = 63
        Me.lblTarifa.Text = "Tarifa:"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.BackColor = System.Drawing.Color.Transparent
        Me.lblEstado.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblEstado.Location = New System.Drawing.Point(30, 163)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(51, 17)
        Me.lblEstado.TabIndex = 64
        Me.lblEstado.Text = "Estado:"
        '
        'lblEstacionInicial
        '
        Me.lblEstacionInicial.AutoSize = True
        Me.lblEstacionInicial.BackColor = System.Drawing.Color.Transparent
        Me.lblEstacionInicial.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstacionInicial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblEstacionInicial.Location = New System.Drawing.Point(219, 54)
        Me.lblEstacionInicial.Name = "lblEstacionInicial"
        Me.lblEstacionInicial.Size = New System.Drawing.Size(99, 17)
        Me.lblEstacionInicial.TabIndex = 66
        Me.lblEstacionInicial.Text = "Estación inicial:"
        '
        'cmbEstacionInicial
        '
        Me.cmbEstacionInicial.BackColor = System.Drawing.Color.White
        Me.cmbEstacionInicial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstacionInicial.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEstacionInicial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.cmbEstacionInicial.FormattingEnabled = True
        Me.cmbEstacionInicial.Location = New System.Drawing.Point(324, 49)
        Me.cmbEstacionInicial.Name = "cmbEstacionInicial"
        Me.cmbEstacionInicial.Size = New System.Drawing.Size(121, 24)
        Me.cmbEstacionInicial.TabIndex = 65
        '
        'lblEstacionFinal
        '
        Me.lblEstacionFinal.AutoSize = True
        Me.lblEstacionFinal.BackColor = System.Drawing.Color.Transparent
        Me.lblEstacionFinal.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstacionFinal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblEstacionFinal.Location = New System.Drawing.Point(229, 82)
        Me.lblEstacionFinal.Name = "lblEstacionFinal"
        Me.lblEstacionFinal.Size = New System.Drawing.Size(89, 17)
        Me.lblEstacionFinal.TabIndex = 67
        Me.lblEstacionFinal.Text = "Estación final:"
        '
        'lblParadas
        '
        Me.lblParadas.AutoSize = True
        Me.lblParadas.BackColor = System.Drawing.Color.Transparent
        Me.lblParadas.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParadas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblParadas.Location = New System.Drawing.Point(259, 109)
        Me.lblParadas.Name = "lblParadas"
        Me.lblParadas.Size = New System.Drawing.Size(59, 17)
        Me.lblParadas.TabIndex = 68
        Me.lblParadas.Text = "Paradas:"
        '
        'lblTiempoDe
        '
        Me.lblTiempoDe.AutoSize = True
        Me.lblTiempoDe.BackColor = System.Drawing.Color.Transparent
        Me.lblTiempoDe.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTiempoDe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblTiempoDe.Location = New System.Drawing.Point(11, 187)
        Me.lblTiempoDe.Name = "lblTiempoDe"
        Me.lblTiempoDe.Size = New System.Drawing.Size(70, 17)
        Me.lblTiempoDe.TabIndex = 69
        Me.lblTiempoDe.Text = "Tiempo de"
        '
        'lblRecorrido
        '
        Me.lblRecorrido.AutoSize = True
        Me.lblRecorrido.BackColor = System.Drawing.Color.Transparent
        Me.lblRecorrido.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecorrido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblRecorrido.Location = New System.Drawing.Point(15, 204)
        Me.lblRecorrido.Name = "lblRecorrido"
        Me.lblRecorrido.Size = New System.Drawing.Size(66, 17)
        Me.lblRecorrido.TabIndex = 70
        Me.lblRecorrido.Text = "recorrido:"
        '
        'txtDuracion
        '
        Me.txtDuracion.BackColor = System.Drawing.Color.White
        Me.txtDuracion.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuracion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtDuracion.Location = New System.Drawing.Point(87, 195)
        Me.txtDuracion.Name = "txtDuracion"
        Me.txtDuracion.Size = New System.Drawing.Size(118, 21)
        Me.txtDuracion.TabIndex = 71
        '
        'cmbEstacionFinal
        '
        Me.cmbEstacionFinal.BackColor = System.Drawing.Color.White
        Me.cmbEstacionFinal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstacionFinal.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEstacionFinal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.cmbEstacionFinal.FormattingEnabled = True
        Me.cmbEstacionFinal.Location = New System.Drawing.Point(324, 77)
        Me.cmbEstacionFinal.Name = "cmbEstacionFinal"
        Me.cmbEstacionFinal.Size = New System.Drawing.Size(121, 24)
        Me.cmbEstacionFinal.TabIndex = 72
        '
        'lbEstaciones
        '
        Me.lbEstaciones.BackColor = System.Drawing.Color.White
        Me.lbEstaciones.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEstaciones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lbEstaciones.FormattingEnabled = True
        Me.lbEstaciones.ItemHeight = 16
        Me.lbEstaciones.Location = New System.Drawing.Point(324, 107)
        Me.lbEstaciones.Name = "lbEstaciones"
        Me.lbEstaciones.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lbEstaciones.Size = New System.Drawing.Size(121, 100)
        Me.lbEstaciones.TabIndex = 73
        '
        'gbHorario
        '
        Me.gbHorario.Controls.Add(Me.txtHoraInicio)
        Me.gbHorario.Controls.Add(Me.lblFormato)
        Me.gbHorario.Controls.Add(Me.lblAM)
        Me.gbHorario.Controls.Add(Me.lblHoraInicio)
        Me.gbHorario.Controls.Add(Me.lblHoras)
        Me.gbHorario.Controls.Add(Me.cmbHoras)
        Me.gbHorario.Controls.Add(Me.lblHorasTrabajo)
        Me.gbHorario.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbHorario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.gbHorario.Location = New System.Drawing.Point(458, 45)
        Me.gbHorario.Name = "gbHorario"
        Me.gbHorario.Size = New System.Drawing.Size(120, 163)
        Me.gbHorario.TabIndex = 74
        Me.gbHorario.TabStop = False
        Me.gbHorario.Text = "Horario"
        '
        'txtHoraInicio
        '
        Me.txtHoraInicio.BackColor = System.Drawing.Color.White
        Me.txtHoraInicio.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraInicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtHoraInicio.Location = New System.Drawing.Point(9, 112)
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
        Me.lblFormato.Location = New System.Drawing.Point(6, 133)
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
        Me.lblAM.Location = New System.Drawing.Point(67, 116)
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
        Me.lblHoraInicio.Location = New System.Drawing.Point(6, 92)
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
        Me.lblHoras.Location = New System.Drawing.Point(67, 54)
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
        Me.cmbHoras.Location = New System.Drawing.Point(9, 47)
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
        Me.btnGuardar.TabIndex = 75
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'frmLinea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(684, 467)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.gbHorario)
        Me.Controls.Add(Me.lbEstaciones)
        Me.Controls.Add(Me.cmbEstacionFinal)
        Me.Controls.Add(Me.txtDuracion)
        Me.Controls.Add(Me.lblRecorrido)
        Me.Controls.Add(Me.lblTiempoDe)
        Me.Controls.Add(Me.lblParadas)
        Me.Controls.Add(Me.lblEstacionFinal)
        Me.Controls.Add(Me.lblEstacionInicial)
        Me.Controls.Add(Me.cmbEstacionInicial)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.lblTarifa)
        Me.Controls.Add(Me.lblDistancia)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.cmbEstado)
        Me.Controls.Add(Me.txtTarifa)
        Me.Controls.Add(Me.txtDistancia)
        Me.Controls.Add(Me.txtColor)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.txtFiltro)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.dgLineas)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.pnlTitulo)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(202, 7)
        Me.Name = "frmLinea"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Línea"
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlTitulo.PerformLayout()
        CType(Me.btnRefrescar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgLineas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbHorario.ResumeLayout(False)
        Me.gbHorario.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents pnlTitulo As System.Windows.Forms.Panel
    Friend WithEvents btnRefrescar As System.Windows.Forms.PictureBox
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents dgLineas As System.Windows.Forms.DataGridView
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtColor As System.Windows.Forms.TextBox
    Friend WithEvents txtDistancia As System.Windows.Forms.TextBox
    Friend WithEvents txtTarifa As System.Windows.Forms.TextBox
    Friend WithEvents cmbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents lblColor As System.Windows.Forms.Label
    Friend WithEvents lblDistancia As System.Windows.Forms.Label
    Friend WithEvents lblTarifa As System.Windows.Forms.Label
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents lblEstacionInicial As System.Windows.Forms.Label
    Friend WithEvents cmbEstacionInicial As System.Windows.Forms.ComboBox
    Friend WithEvents lblEstacionFinal As System.Windows.Forms.Label
    Friend WithEvents lblParadas As System.Windows.Forms.Label
    Friend WithEvents lblTiempoDe As System.Windows.Forms.Label
    Friend WithEvents lblRecorrido As System.Windows.Forms.Label
    Friend WithEvents txtDuracion As System.Windows.Forms.TextBox
    Friend WithEvents cmbEstacionFinal As System.Windows.Forms.ComboBox
    Friend WithEvents lbEstaciones As System.Windows.Forms.ListBox
    Friend WithEvents gbHorario As System.Windows.Forms.GroupBox
    Friend WithEvents lblFormato As System.Windows.Forms.Label
    Friend WithEvents lblAM As System.Windows.Forms.Label
    Friend WithEvents lblHoraInicio As System.Windows.Forms.Label
    Friend WithEvents lblHoras As System.Windows.Forms.Label
    Friend WithEvents cmbHoras As System.Windows.Forms.ComboBox
    Friend WithEvents lblHorasTrabajo As System.Windows.Forms.Label
    Friend WithEvents txtHoraInicio As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents colNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEstaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEstado As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
