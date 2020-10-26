<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class forClientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tabTrabajadores = New System.Windows.Forms.TabControl()
        Me.tabTraListado = New System.Windows.Forms.TabPage()
        Me.lblUsuarioTotal = New System.Windows.Forms.Label()
        Me.dgvTraListado = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTraBuscar = New System.Windows.Forms.TextBox()
        Me.tabTraMantenimiento = New System.Windows.Forms.TabPage()
        Me.txtIdCodigo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.labEncabezado = New System.Windows.Forms.Label()
        Me.gboAcceso = New System.Windows.Forms.GroupBox()
        Me.btnIconLimpiar = New FontAwesome.Sharp.IconButton()
        Me.btnIconBuscar = New FontAwesome.Sharp.IconButton()
        Me.btnIconEliminar = New FontAwesome.Sharp.IconButton()
        Me.btnIconGuardar = New FontAwesome.Sharp.IconButton()
        Me.btnIconCancelar = New FontAwesome.Sharp.IconButton()
        Me.btnIconEditar = New FontAwesome.Sharp.IconButton()
        Me.btnIconNuevo = New FontAwesome.Sharp.IconButton()
        Me.gboDatos = New System.Windows.Forms.GroupBox()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.labEmail = New System.Windows.Forms.Label()
        Me.txtFechaIngreso = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTel2 = New System.Windows.Forms.TextBox()
        Me.txtTel1 = New System.Windows.Forms.TextBox()
        Me.txtNDoc = New System.Windows.Forms.TextBox()
        Me.labTipo = New System.Windows.Forms.Label()
        Me.cboTipoDoc = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboGenero = New System.Windows.Forms.ComboBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtApeMaterno = New System.Windows.Forms.TextBox()
        Me.txtApePaterno = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tabTrabajadores.SuspendLayout()
        Me.tabTraListado.SuspendLayout()
        CType(Me.dgvTraListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabTraMantenimiento.SuspendLayout()
        Me.gboAcceso.SuspendLayout()
        Me.gboDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabTrabajadores
        '
        Me.tabTrabajadores.Controls.Add(Me.tabTraListado)
        Me.tabTrabajadores.Controls.Add(Me.tabTraMantenimiento)
        Me.tabTrabajadores.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabTrabajadores.Location = New System.Drawing.Point(16, 24)
        Me.tabTrabajadores.Margin = New System.Windows.Forms.Padding(2)
        Me.tabTrabajadores.Name = "tabTrabajadores"
        Me.tabTrabajadores.SelectedIndex = 0
        Me.tabTrabajadores.Size = New System.Drawing.Size(1049, 638)
        Me.tabTrabajadores.TabIndex = 1
        '
        'tabTraListado
        '
        Me.tabTraListado.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tabTraListado.Controls.Add(Me.lblUsuarioTotal)
        Me.tabTraListado.Controls.Add(Me.dgvTraListado)
        Me.tabTraListado.Controls.Add(Me.Label1)
        Me.tabTraListado.Controls.Add(Me.txtTraBuscar)
        Me.tabTraListado.Location = New System.Drawing.Point(4, 26)
        Me.tabTraListado.Margin = New System.Windows.Forms.Padding(2)
        Me.tabTraListado.Name = "tabTraListado"
        Me.tabTraListado.Padding = New System.Windows.Forms.Padding(2)
        Me.tabTraListado.Size = New System.Drawing.Size(1041, 608)
        Me.tabTraListado.TabIndex = 0
        Me.tabTraListado.Text = "Listado"
        '
        'lblUsuarioTotal
        '
        Me.lblUsuarioTotal.AutoSize = True
        Me.lblUsuarioTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblUsuarioTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarioTotal.ForeColor = System.Drawing.Color.White
        Me.lblUsuarioTotal.Location = New System.Drawing.Point(653, 34)
        Me.lblUsuarioTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUsuarioTotal.Name = "lblUsuarioTotal"
        Me.lblUsuarioTotal.Size = New System.Drawing.Size(97, 18)
        Me.lblUsuarioTotal.TabIndex = 8
        Me.lblUsuarioTotal.Text = "Usuario Total"
        '
        'dgvTraListado
        '
        Me.dgvTraListado.AllowUserToAddRows = False
        Me.dgvTraListado.AllowUserToDeleteRows = False
        Me.dgvTraListado.AllowUserToOrderColumns = True
        Me.dgvTraListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvTraListado.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.dgvTraListado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTraListado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(215, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTraListado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTraListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTraListado.EnableHeadersVisualStyles = False
        Me.dgvTraListado.GridColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.dgvTraListado.Location = New System.Drawing.Point(27, 91)
        Me.dgvTraListado.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvTraListado.Name = "dgvTraListado"
        Me.dgvTraListado.ReadOnly = True
        Me.dgvTraListado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(183, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTraListado.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTraListado.RowHeadersWidth = 51
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(183, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.dgvTraListado.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvTraListado.RowTemplate.Height = 24
        Me.dgvTraListado.Size = New System.Drawing.Size(968, 460)
        Me.dgvTraListado.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(24, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Buscador"
        '
        'txtTraBuscar
        '
        Me.txtTraBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtTraBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTraBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTraBuscar.ForeColor = System.Drawing.SystemColors.Window
        Me.txtTraBuscar.Location = New System.Drawing.Point(27, 46)
        Me.txtTraBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTraBuscar.Name = "txtTraBuscar"
        Me.txtTraBuscar.Size = New System.Drawing.Size(422, 19)
        Me.txtTraBuscar.TabIndex = 5
        '
        'tabTraMantenimiento
        '
        Me.tabTraMantenimiento.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tabTraMantenimiento.Controls.Add(Me.txtIdCodigo)
        Me.tabTraMantenimiento.Controls.Add(Me.Label12)
        Me.tabTraMantenimiento.Controls.Add(Me.Label10)
        Me.tabTraMantenimiento.Controls.Add(Me.labEncabezado)
        Me.tabTraMantenimiento.Controls.Add(Me.gboAcceso)
        Me.tabTraMantenimiento.Controls.Add(Me.gboDatos)
        Me.tabTraMantenimiento.Location = New System.Drawing.Point(4, 26)
        Me.tabTraMantenimiento.Margin = New System.Windows.Forms.Padding(2)
        Me.tabTraMantenimiento.Name = "tabTraMantenimiento"
        Me.tabTraMantenimiento.Padding = New System.Windows.Forms.Padding(2)
        Me.tabTraMantenimiento.Size = New System.Drawing.Size(1041, 608)
        Me.tabTraMantenimiento.TabIndex = 1
        Me.tabTraMantenimiento.Text = "Mantenimiento"
        '
        'txtIdCodigo
        '
        Me.txtIdCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtIdCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIdCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCodigo.ForeColor = System.Drawing.SystemColors.Window
        Me.txtIdCodigo.Location = New System.Drawing.Point(256, 106)
        Me.txtIdCodigo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIdCodigo.Name = "txtIdCodigo"
        Me.txtIdCodigo.Size = New System.Drawing.Size(264, 19)
        Me.txtIdCodigo.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(28, 105)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(172, 18)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Ingreso Codigo a Buscar"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(25, 81)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 18)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Buscador"
        '
        'labEncabezado
        '
        Me.labEncabezado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labEncabezado.AutoSize = True
        Me.labEncabezado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.labEncabezado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labEncabezado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.labEncabezado.Location = New System.Drawing.Point(53, 29)
        Me.labEncabezado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labEncabezado.Name = "labEncabezado"
        Me.labEncabezado.Size = New System.Drawing.Size(0, 25)
        Me.labEncabezado.TabIndex = 7
        '
        'gboAcceso
        '
        Me.gboAcceso.Controls.Add(Me.btnIconLimpiar)
        Me.gboAcceso.Controls.Add(Me.btnIconBuscar)
        Me.gboAcceso.Controls.Add(Me.btnIconEliminar)
        Me.gboAcceso.Controls.Add(Me.btnIconGuardar)
        Me.gboAcceso.Controls.Add(Me.btnIconCancelar)
        Me.gboAcceso.Controls.Add(Me.btnIconEditar)
        Me.gboAcceso.Controls.Add(Me.btnIconNuevo)
        Me.gboAcceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboAcceso.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.gboAcceso.Location = New System.Drawing.Point(696, 67)
        Me.gboAcceso.Margin = New System.Windows.Forms.Padding(2)
        Me.gboAcceso.Name = "gboAcceso"
        Me.gboAcceso.Padding = New System.Windows.Forms.Padding(2)
        Me.gboAcceso.Size = New System.Drawing.Size(326, 210)
        Me.gboAcceso.TabIndex = 2
        Me.gboAcceso.TabStop = False
        Me.gboAcceso.Text = "Herramientas"
        '
        'btnIconLimpiar
        '
        Me.btnIconLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnIconLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIconLimpiar.FlatAppearance.BorderSize = 0
        Me.btnIconLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btnIconLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnIconLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIconLimpiar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnIconLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIconLimpiar.ForeColor = System.Drawing.Color.White
        Me.btnIconLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom
        Me.btnIconLimpiar.IconColor = System.Drawing.Color.White
        Me.btnIconLimpiar.IconSize = 32
        Me.btnIconLimpiar.Location = New System.Drawing.Point(23, 167)
        Me.btnIconLimpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnIconLimpiar.Name = "btnIconLimpiar"
        Me.btnIconLimpiar.Rotation = 0R
        Me.btnIconLimpiar.Size = New System.Drawing.Size(273, 33)
        Me.btnIconLimpiar.TabIndex = 10
        Me.btnIconLimpiar.Text = "Limpiar casillas"
        Me.btnIconLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnIconLimpiar.UseVisualStyleBackColor = False
        '
        'btnIconBuscar
        '
        Me.btnIconBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnIconBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIconBuscar.FlatAppearance.BorderSize = 0
        Me.btnIconBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btnIconBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnIconBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIconBuscar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnIconBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIconBuscar.ForeColor = System.Drawing.Color.White
        Me.btnIconBuscar.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.btnIconBuscar.IconColor = System.Drawing.Color.White
        Me.btnIconBuscar.IconSize = 32
        Me.btnIconBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIconBuscar.Location = New System.Drawing.Point(173, 125)
        Me.btnIconBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnIconBuscar.Name = "btnIconBuscar"
        Me.btnIconBuscar.Rotation = 0R
        Me.btnIconBuscar.Size = New System.Drawing.Size(123, 33)
        Me.btnIconBuscar.TabIndex = 9
        Me.btnIconBuscar.Text = "Buscar"
        Me.btnIconBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIconBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnIconBuscar.UseVisualStyleBackColor = False
        '
        'btnIconEliminar
        '
        Me.btnIconEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnIconEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIconEliminar.FlatAppearance.BorderSize = 0
        Me.btnIconEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btnIconEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnIconEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIconEliminar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnIconEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIconEliminar.ForeColor = System.Drawing.Color.White
        Me.btnIconEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash
        Me.btnIconEliminar.IconColor = System.Drawing.Color.White
        Me.btnIconEliminar.IconSize = 32
        Me.btnIconEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIconEliminar.Location = New System.Drawing.Point(23, 124)
        Me.btnIconEliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnIconEliminar.Name = "btnIconEliminar"
        Me.btnIconEliminar.Rotation = 0R
        Me.btnIconEliminar.Size = New System.Drawing.Size(123, 33)
        Me.btnIconEliminar.TabIndex = 8
        Me.btnIconEliminar.Text = "Eliminar"
        Me.btnIconEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIconEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnIconEliminar.UseVisualStyleBackColor = False
        '
        'btnIconGuardar
        '
        Me.btnIconGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnIconGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIconGuardar.FlatAppearance.BorderSize = 0
        Me.btnIconGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btnIconGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnIconGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIconGuardar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnIconGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIconGuardar.ForeColor = System.Drawing.Color.White
        Me.btnIconGuardar.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.btnIconGuardar.IconColor = System.Drawing.Color.White
        Me.btnIconGuardar.IconSize = 32
        Me.btnIconGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIconGuardar.Location = New System.Drawing.Point(173, 37)
        Me.btnIconGuardar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnIconGuardar.Name = "btnIconGuardar"
        Me.btnIconGuardar.Rotation = 0R
        Me.btnIconGuardar.Size = New System.Drawing.Size(123, 33)
        Me.btnIconGuardar.TabIndex = 7
        Me.btnIconGuardar.Text = "Guardar"
        Me.btnIconGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIconGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnIconGuardar.UseVisualStyleBackColor = False
        '
        'btnIconCancelar
        '
        Me.btnIconCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnIconCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIconCancelar.FlatAppearance.BorderSize = 0
        Me.btnIconCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btnIconCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnIconCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIconCancelar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnIconCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIconCancelar.ForeColor = System.Drawing.Color.White
        Me.btnIconCancelar.IconChar = FontAwesome.Sharp.IconChar.Ban
        Me.btnIconCancelar.IconColor = System.Drawing.Color.White
        Me.btnIconCancelar.IconSize = 32
        Me.btnIconCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIconCancelar.Location = New System.Drawing.Point(173, 83)
        Me.btnIconCancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnIconCancelar.Name = "btnIconCancelar"
        Me.btnIconCancelar.Rotation = 0R
        Me.btnIconCancelar.Size = New System.Drawing.Size(123, 33)
        Me.btnIconCancelar.TabIndex = 6
        Me.btnIconCancelar.Text = "Cancelar"
        Me.btnIconCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIconCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnIconCancelar.UseVisualStyleBackColor = False
        '
        'btnIconEditar
        '
        Me.btnIconEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnIconEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIconEditar.FlatAppearance.BorderSize = 0
        Me.btnIconEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btnIconEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnIconEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIconEditar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnIconEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIconEditar.ForeColor = System.Drawing.Color.White
        Me.btnIconEditar.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.btnIconEditar.IconColor = System.Drawing.Color.White
        Me.btnIconEditar.IconSize = 32
        Me.btnIconEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIconEditar.Location = New System.Drawing.Point(23, 84)
        Me.btnIconEditar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnIconEditar.Name = "btnIconEditar"
        Me.btnIconEditar.Rotation = 0R
        Me.btnIconEditar.Size = New System.Drawing.Size(123, 33)
        Me.btnIconEditar.TabIndex = 5
        Me.btnIconEditar.Text = "Editar"
        Me.btnIconEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIconEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnIconEditar.UseVisualStyleBackColor = False
        '
        'btnIconNuevo
        '
        Me.btnIconNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnIconNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIconNuevo.FlatAppearance.BorderSize = 0
        Me.btnIconNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btnIconNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnIconNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIconNuevo.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnIconNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIconNuevo.ForeColor = System.Drawing.Color.White
        Me.btnIconNuevo.IconChar = FontAwesome.Sharp.IconChar.CalendarPlus
        Me.btnIconNuevo.IconColor = System.Drawing.Color.White
        Me.btnIconNuevo.IconSize = 32
        Me.btnIconNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIconNuevo.Location = New System.Drawing.Point(23, 37)
        Me.btnIconNuevo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnIconNuevo.Name = "btnIconNuevo"
        Me.btnIconNuevo.Rotation = 0R
        Me.btnIconNuevo.Size = New System.Drawing.Size(123, 33)
        Me.btnIconNuevo.TabIndex = 4
        Me.btnIconNuevo.Text = "Nuevo"
        Me.btnIconNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIconNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnIconNuevo.UseVisualStyleBackColor = False
        '
        'gboDatos
        '
        Me.gboDatos.Controls.Add(Me.cboTipo)
        Me.gboDatos.Controls.Add(Me.txtDireccion)
        Me.gboDatos.Controls.Add(Me.Label13)
        Me.gboDatos.Controls.Add(Me.txtEmail)
        Me.gboDatos.Controls.Add(Me.labEmail)
        Me.gboDatos.Controls.Add(Me.txtFechaIngreso)
        Me.gboDatos.Controls.Add(Me.Label11)
        Me.gboDatos.Controls.Add(Me.txtTel2)
        Me.gboDatos.Controls.Add(Me.txtTel1)
        Me.gboDatos.Controls.Add(Me.txtNDoc)
        Me.gboDatos.Controls.Add(Me.labTipo)
        Me.gboDatos.Controls.Add(Me.cboTipoDoc)
        Me.gboDatos.Controls.Add(Me.Label8)
        Me.gboDatos.Controls.Add(Me.Label4)
        Me.gboDatos.Controls.Add(Me.Label6)
        Me.gboDatos.Controls.Add(Me.cboGenero)
        Me.gboDatos.Controls.Add(Me.txtNombre)
        Me.gboDatos.Controls.Add(Me.Label9)
        Me.gboDatos.Controls.Add(Me.Label5)
        Me.gboDatos.Controls.Add(Me.txtApeMaterno)
        Me.gboDatos.Controls.Add(Me.txtApePaterno)
        Me.gboDatos.Controls.Add(Me.Label7)
        Me.gboDatos.Controls.Add(Me.Label3)
        Me.gboDatos.Controls.Add(Me.Label2)
        Me.gboDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.gboDatos.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.gboDatos.Location = New System.Drawing.Point(17, 148)
        Me.gboDatos.Margin = New System.Windows.Forms.Padding(2)
        Me.gboDatos.Name = "gboDatos"
        Me.gboDatos.Padding = New System.Windows.Forms.Padding(2)
        Me.gboDatos.Size = New System.Drawing.Size(664, 321)
        Me.gboDatos.TabIndex = 0
        Me.gboDatos.TabStop = False
        Me.gboDatos.Text = "Datos Del Cliente"
        '
        'cboTipo
        '
        Me.cboTipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.cboTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipo.ForeColor = System.Drawing.Color.White
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Items.AddRange(New Object() {"Cliente"})
        Me.cboTipo.Location = New System.Drawing.Point(498, 72)
        Me.cboTipo.Margin = New System.Windows.Forms.Padding(2)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(152, 25)
        Me.cboTipo.TabIndex = 25
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.ForeColor = System.Drawing.SystemColors.Window
        Me.txtDireccion.Location = New System.Drawing.Point(498, 153)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(151, 19)
        Me.txtDireccion.TabIndex = 24
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(355, 153)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 17)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Direccion"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.SystemColors.Window
        Me.txtEmail.Location = New System.Drawing.Point(164, 273)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(277, 19)
        Me.txtEmail.TabIndex = 22
        '
        'labEmail
        '
        Me.labEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labEmail.AutoSize = True
        Me.labEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.labEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labEmail.ForeColor = System.Drawing.Color.White
        Me.labEmail.Location = New System.Drawing.Point(11, 273)
        Me.labEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labEmail.Name = "labEmail"
        Me.labEmail.Size = New System.Drawing.Size(46, 17)
        Me.labEmail.TabIndex = 21
        Me.labEmail.Text = "Email:"
        '
        'txtFechaIngreso
        '
        Me.txtFechaIngreso.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.txtFechaIngreso.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFechaIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaIngreso.ForeColor = System.Drawing.SystemColors.Window
        Me.txtFechaIngreso.Location = New System.Drawing.Point(164, 234)
        Me.txtFechaIngreso.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFechaIngreso.Name = "txtFechaIngreso"
        Me.txtFechaIngreso.Size = New System.Drawing.Size(278, 19)
        Me.txtFechaIngreso.TabIndex = 20
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(11, 234)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 17)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Fecha ingreso"
        '
        'txtTel2
        '
        Me.txtTel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.txtTel2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel2.ForeColor = System.Drawing.SystemColors.Window
        Me.txtTel2.Location = New System.Drawing.Point(498, 192)
        Me.txtTel2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTel2.Name = "txtTel2"
        Me.txtTel2.Size = New System.Drawing.Size(151, 19)
        Me.txtTel2.TabIndex = 16
        '
        'txtTel1
        '
        Me.txtTel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.txtTel1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel1.ForeColor = System.Drawing.SystemColors.Window
        Me.txtTel1.Location = New System.Drawing.Point(164, 194)
        Me.txtTel1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTel1.Name = "txtTel1"
        Me.txtTel1.Size = New System.Drawing.Size(142, 19)
        Me.txtTel1.TabIndex = 15
        '
        'txtNDoc
        '
        Me.txtNDoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.txtNDoc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNDoc.ForeColor = System.Drawing.SystemColors.Window
        Me.txtNDoc.Location = New System.Drawing.Point(498, 115)
        Me.txtNDoc.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNDoc.Name = "txtNDoc"
        Me.txtNDoc.Size = New System.Drawing.Size(151, 19)
        Me.txtNDoc.TabIndex = 14
        '
        'labTipo
        '
        Me.labTipo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labTipo.AutoSize = True
        Me.labTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.labTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labTipo.ForeColor = System.Drawing.Color.White
        Me.labTipo.Location = New System.Drawing.Point(355, 76)
        Me.labTipo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labTipo.Name = "labTipo"
        Me.labTipo.Size = New System.Drawing.Size(36, 17)
        Me.labTipo.TabIndex = 17
        Me.labTipo.Text = "Tipo"
        '
        'cboTipoDoc
        '
        Me.cboTipoDoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.cboTipoDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoDoc.ForeColor = System.Drawing.Color.White
        Me.cboTipoDoc.FormattingEnabled = True
        Me.cboTipoDoc.Items.AddRange(New Object() {"DNI"})
        Me.cboTipoDoc.Location = New System.Drawing.Point(164, 106)
        Me.cboTipoDoc.Margin = New System.Windows.Forms.Padding(2)
        Me.cboTipoDoc.Name = "cboTipoDoc"
        Me.cboTipoDoc.Size = New System.Drawing.Size(143, 25)
        Me.cboTipoDoc.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(355, 197)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 17)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Telefono 2"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(11, 159)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Género"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(11, 194)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Telefono 1"
        '
        'cboGenero
        '
        Me.cboGenero.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.cboGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGenero.ForeColor = System.Drawing.Color.White
        Me.cboGenero.FormattingEnabled = True
        Me.cboGenero.Items.AddRange(New Object() {"Hombre", "Mujer"})
        Me.cboGenero.Location = New System.Drawing.Point(164, 153)
        Me.cboGenero.Margin = New System.Windows.Forms.Padding(2)
        Me.cboGenero.Name = "cboGenero"
        Me.cboGenero.Size = New System.Drawing.Size(143, 25)
        Me.cboGenero.TabIndex = 12
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.SystemColors.Window
        Me.txtNombre.Location = New System.Drawing.Point(164, 76)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(142, 19)
        Me.txtNombre.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(355, 116)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 17)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "N de Documento"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(355, 37)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Apellido Materno"
        '
        'txtApeMaterno
        '
        Me.txtApeMaterno.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.txtApeMaterno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtApeMaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApeMaterno.ForeColor = System.Drawing.SystemColors.Window
        Me.txtApeMaterno.Location = New System.Drawing.Point(498, 35)
        Me.txtApeMaterno.Margin = New System.Windows.Forms.Padding(2)
        Me.txtApeMaterno.Name = "txtApeMaterno"
        Me.txtApeMaterno.Size = New System.Drawing.Size(151, 19)
        Me.txtApeMaterno.TabIndex = 10
        '
        'txtApePaterno
        '
        Me.txtApePaterno.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.txtApePaterno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtApePaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApePaterno.ForeColor = System.Drawing.SystemColors.Window
        Me.txtApePaterno.Location = New System.Drawing.Point(164, 37)
        Me.txtApePaterno.Margin = New System.Windows.Forms.Padding(2)
        Me.txtApePaterno.Name = "txtApePaterno"
        Me.txtApePaterno.Size = New System.Drawing.Size(142, 19)
        Me.txtApePaterno.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(11, 112)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Tipo de documento"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(11, 40)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Apellido Paterno"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(11, 78)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nombres"
        '
        'forClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1076, 687)
        Me.Controls.Add(Me.tabTrabajadores)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "forClientes"
        Me.Text = "forClientes"
        Me.tabTrabajadores.ResumeLayout(False)
        Me.tabTraListado.ResumeLayout(False)
        Me.tabTraListado.PerformLayout()
        CType(Me.dgvTraListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabTraMantenimiento.ResumeLayout(False)
        Me.tabTraMantenimiento.PerformLayout()
        Me.gboAcceso.ResumeLayout(False)
        Me.gboDatos.ResumeLayout(False)
        Me.gboDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabTrabajadores As TabControl
    Friend WithEvents tabTraListado As TabPage
    Friend WithEvents lblUsuarioTotal As Label
    Friend WithEvents dgvTraListado As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTraBuscar As TextBox
    Friend WithEvents tabTraMantenimiento As TabPage
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents labEncabezado As Label
    Friend WithEvents gboAcceso As GroupBox
    Friend WithEvents btnIconLimpiar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnIconBuscar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnIconEliminar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnIconGuardar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnIconCancelar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnIconEditar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnIconNuevo As FontAwesome.Sharp.IconButton
    Friend WithEvents gboDatos As GroupBox
    Friend WithEvents txtFechaIngreso As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents labTipo As Label
    Friend WithEvents txtTel2 As TextBox
    Friend WithEvents txtTel1 As TextBox
    Friend WithEvents txtNDoc As TextBox
    Friend WithEvents cboTipoDoc As ComboBox
    Friend WithEvents cboGenero As ComboBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApeMaterno As TextBox
    Friend WithEvents txtApePaterno As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents labEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cboTipo As ComboBox
    Friend WithEvents txtIdCodigo As TextBox
End Class
