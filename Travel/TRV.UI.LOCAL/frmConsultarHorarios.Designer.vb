<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultarHorarios
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
        Me.panelLlegadaTren1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelArrivoTren1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbxLinea = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.panelArrivoTren2 = New System.Windows.Forms.Panel()
        Me.panelLlegadaTren2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblKm_1 = New System.Windows.Forms.Label()
        Me.lblPrStat_1 = New System.Windows.Forms.Label()
        Me.lblNxtSt_1 = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'panelLlegadaTren1
        '
        Me.panelLlegadaTren1.AutoScroll = True
        Me.panelLlegadaTren1.BackColor = System.Drawing.Color.White
        Me.panelLlegadaTren1.Location = New System.Drawing.Point(331, 316)
        Me.panelLlegadaTren1.Name = "panelLlegadaTren1"
        Me.panelLlegadaTren1.Size = New System.Drawing.Size(153, 278)
        Me.panelLlegadaTren1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Forte", 25.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Location = New System.Drawing.Point(324, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(326, 38)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Consultar Horarios"
        '
        'panelArrivoTren1
        '
        Me.panelArrivoTren1.AutoScroll = True
        Me.panelArrivoTren1.BackColor = System.Drawing.Color.White
        Me.panelArrivoTren1.Location = New System.Drawing.Point(501, 316)
        Me.panelArrivoTren1.Name = "panelArrivoTren1"
        Me.panelArrivoTren1.Size = New System.Drawing.Size(153, 278)
        Me.panelArrivoTren1.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 16.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(330, 286)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 27)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Llegada"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 16.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(496, 286)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 27)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Arribo"
        '
        'cbxLinea
        '
        Me.cbxLinea.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxLinea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxLinea.FormattingEnabled = True
        Me.cbxLinea.Location = New System.Drawing.Point(337, 205)
        Me.cbxLinea.Name = "cbxLinea"
        Me.cbxLinea.Size = New System.Drawing.Size(171, 21)
        Me.cbxLinea.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(332, 181)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(170, 21)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Seleccione una línea"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(38, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 21)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Tren 1:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(38, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 21)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Estación previa:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(38, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 21)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Estación siguiente:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(721, 127)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 21)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Desde:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(725, 160)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 21)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Hasta:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 16.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(838, 286)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 27)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Arribo"
        '
        'panelArrivoTren2
        '
        Me.panelArrivoTren2.AutoScroll = True
        Me.panelArrivoTren2.BackColor = System.Drawing.Color.White
        Me.panelArrivoTren2.Location = New System.Drawing.Point(843, 316)
        Me.panelArrivoTren2.Name = "panelArrivoTren2"
        Me.panelArrivoTren2.Size = New System.Drawing.Size(153, 278)
        Me.panelArrivoTren2.TabIndex = 1
        '
        'panelLlegadaTren2
        '
        Me.panelLlegadaTren2.AutoScroll = True
        Me.panelLlegadaTren2.BackColor = System.Drawing.Color.White
        Me.panelLlegadaTren2.Location = New System.Drawing.Point(673, 316)
        Me.panelLlegadaTren2.Name = "panelLlegadaTren2"
        Me.panelLlegadaTren2.Size = New System.Drawing.Size(153, 278)
        Me.panelLlegadaTren2.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 16.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(668, 286)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 27)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Llegada"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(38, 391)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(63, 21)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "Tren 2:"
        '
        'lblKm_1
        '
        Me.lblKm_1.AutoSize = True
        Me.lblKm_1.BackColor = System.Drawing.Color.Transparent
        Me.lblKm_1.Font = New System.Drawing.Font("Century Gothic", 16.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKm_1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.lblKm_1.Location = New System.Drawing.Point(225, 161)
        Me.lblKm_1.Name = "lblKm_1"
        Me.lblKm_1.Size = New System.Drawing.Size(28, 27)
        Me.lblKm_1.TabIndex = 40
        Me.lblKm_1.Text = "--"
        '
        'lblPrStat_1
        '
        Me.lblPrStat_1.AutoSize = True
        Me.lblPrStat_1.BackColor = System.Drawing.Color.Transparent
        Me.lblPrStat_1.Font = New System.Drawing.Font("Century Gothic", 16.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrStat_1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.lblPrStat_1.Location = New System.Drawing.Point(225, 195)
        Me.lblPrStat_1.Name = "lblPrStat_1"
        Me.lblPrStat_1.Size = New System.Drawing.Size(28, 27)
        Me.lblPrStat_1.TabIndex = 41
        Me.lblPrStat_1.Text = "--"
        '
        'lblNxtSt_1
        '
        Me.lblNxtSt_1.AutoSize = True
        Me.lblNxtSt_1.BackColor = System.Drawing.Color.Transparent
        Me.lblNxtSt_1.Font = New System.Drawing.Font("Century Gothic", 16.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNxtSt_1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.lblNxtSt_1.Location = New System.Drawing.Point(225, 230)
        Me.lblNxtSt_1.Name = "lblNxtSt_1"
        Me.lblNxtSt_1.Size = New System.Drawing.Size(28, 27)
        Me.lblNxtSt_1.TabIndex = 42
        Me.lblNxtSt_1.Text = "--"
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.BackColor = System.Drawing.Color.Transparent
        Me.lblFrom.Font = New System.Drawing.Font("Century Gothic", 16.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.lblFrom.Location = New System.Drawing.Point(796, 123)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(28, 27)
        Me.lblFrom.TabIndex = 44
        Me.lblFrom.Text = "--"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.BackColor = System.Drawing.Color.Transparent
        Me.lblTo.Font = New System.Drawing.Font("Century Gothic", 16.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.lblTo.Location = New System.Drawing.Point(796, 156)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(28, 27)
        Me.lblTo.TabIndex = 45
        Me.lblTo.Text = "--"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Century Gothic", 16.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.Label28.Location = New System.Drawing.Point(225, 459)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(28, 27)
        Me.Label28.TabIndex = 48
        Me.Label28.Text = "--"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Century Gothic", 16.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.Label29.Location = New System.Drawing.Point(225, 424)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(28, 27)
        Me.Label29.TabIndex = 47
        Me.Label29.Text = "--"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Century Gothic", 16.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.Label30.Location = New System.Drawing.Point(225, 388)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(28, 27)
        Me.Label30.TabIndex = 46
        Me.Label30.Text = "--"
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnRefresh.Location = New System.Drawing.Point(514, 200)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(93, 30)
        Me.btnRefresh.TabIndex = 52
        Me.btnRefresh.Text = "Actualizar"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(38, 463)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(163, 21)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "Estación siguiente:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(38, 428)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(144, 21)
        Me.Label13.TabIndex = 53
        Me.Label13.Text = "Estación previa:"
        '
        'frmConsultarHorarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TRV.UI.LOCAL.My.Resources.Resources.FondoGeneral1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1054, 631)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.lblFrom)
        Me.Controls.Add(Me.lblNxtSt_1)
        Me.Controls.Add(Me.lblPrStat_1)
        Me.Controls.Add(Me.lblKm_1)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbxLinea)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.panelArrivoTren2)
        Me.Controls.Add(Me.panelLlegadaTren2)
        Me.Controls.Add(Me.panelArrivoTren1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.panelLlegadaTren1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1070, 670)
        Me.MinimumSize = New System.Drawing.Size(1070, 670)
        Me.Name = "frmConsultarHorarios"
        Me.Text = "Consultar horarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panelLlegadaTren1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents panelArrivoTren1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cbxLinea As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents panelArrivoTren2 As Panel
    Friend WithEvents panelLlegadaTren2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lblKm_1 As Label
    Friend WithEvents lblPrStat_1 As Label
    Friend WithEvents lblNxtSt_1 As Label
    Friend WithEvents lblFrom As Label
    Friend WithEvents lblTo As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
End Class
