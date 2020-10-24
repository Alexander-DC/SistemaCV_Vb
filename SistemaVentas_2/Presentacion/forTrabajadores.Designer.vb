<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class forTrabajadores
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.tabTraMantenimiento = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnAgregarImagen = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtIdCodigo = New System.Windows.Forms.TextBox()
        Me.labEncabezado = New System.Windows.Forms.Label()
        Me.gboAcceso = New System.Windows.Forms.GroupBox()
        Me.gboTraAcceso = New System.Windows.Forms.GroupBox()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.cboRol = New System.Windows.Forms.ComboBox()
        Me.labUsuario = New System.Windows.Forms.Label()
        Me.labRol = New System.Windows.Forms.Label()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.labClave = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.labEstado = New System.Windows.Forms.Label()
        Me.gboDatos = New System.Windows.Forms.GroupBox()
        Me.txtFechaIngreso = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.labelDireccion = New System.Windows.Forms.Label()
        Me.txtTel2 = New System.Windows.Forms.TextBox()
        Me.txtTel1 = New System.Windows.Forms.TextBox()
        Me.txtNDoc = New System.Windows.Forms.TextBox()
        Me.cboTipoDoc = New System.Windows.Forms.ComboBox()
        Me.cboGenero = New System.Windows.Forms.ComboBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApeMaterno = New System.Windows.Forms.TextBox()
        Me.txtApePaterno = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tabTraListado = New System.Windows.Forms.TabPage()
        Me.lblUsuarioTotal = New System.Windows.Forms.Label()
        Me.dgvTraListado = New System.Windows.Forms.DataGridView()
        Me.btnTraBuscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTraBuscar = New System.Windows.Forms.TextBox()
        Me.tabTrabajadores = New System.Windows.Forms.TabControl()
        Me.btnIconLimpiar = New FontAwesome.Sharp.IconButton()
        Me.btnIconBuscar = New FontAwesome.Sharp.IconButton()
        Me.btnIconEliminar = New FontAwesome.Sharp.IconButton()
        Me.btnIconGuardar = New FontAwesome.Sharp.IconButton()
        Me.btnIconCancelar = New FontAwesome.Sharp.IconButton()
        Me.btnIconEditar = New FontAwesome.Sharp.IconButton()
        Me.btnIconNuevo = New FontAwesome.Sharp.IconButton()
        Me.picImagen = New System.Windows.Forms.PictureBox()
        Me.tabTraMantenimiento.SuspendLayout()
        Me.gboAcceso.SuspendLayout()
        Me.gboTraAcceso.SuspendLayout()
        Me.gboDatos.SuspendLayout()
        Me.tabTraListado.SuspendLayout()
        CType(Me.dgvTraListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabTrabajadores.SuspendLayout()
        CType(Me.picImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'tabTraMantenimiento
        '
        Me.tabTraMantenimiento.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tabTraMantenimiento.Controls.Add(Me.Label12)
        Me.tabTraMantenimiento.Controls.Add(Me.btnAgregarImagen)
        Me.tabTraMantenimiento.Controls.Add(Me.Label10)
        Me.tabTraMantenimiento.Controls.Add(Me.txtIdCodigo)
        Me.tabTraMantenimiento.Controls.Add(Me.labEncabezado)
        Me.tabTraMantenimiento.Controls.Add(Me.gboAcceso)
        Me.tabTraMantenimiento.Controls.Add(Me.gboTraAcceso)
        Me.tabTraMantenimiento.Controls.Add(Me.gboDatos)
        Me.tabTraMantenimiento.Controls.Add(Me.picImagen)
        Me.tabTraMantenimiento.Location = New System.Drawing.Point(4, 29)
        Me.tabTraMantenimiento.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabTraMantenimiento.Name = "tabTraMantenimiento"
        Me.tabTraMantenimiento.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabTraMantenimiento.Size = New System.Drawing.Size(1363, 752)
        Me.tabTraMantenimiento.TabIndex = 1
        Me.tabTraMantenimiento.Text = "Mantenimiento"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(49, 129)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(217, 24)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Ingreso Codigo a Buscar"
        '
        'btnAgregarImagen
        '
        Me.btnAgregarImagen.Location = New System.Drawing.Point(48, 439)
        Me.btnAgregarImagen.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnAgregarImagen.Name = "btnAgregarImagen"
        Me.btnAgregarImagen.Size = New System.Drawing.Size(241, 34)
        Me.btnAgregarImagen.TabIndex = 11
        Me.btnAgregarImagen.Text = "Seleccionar Imagen"
        Me.btnAgregarImagen.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(44, 100)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 24)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Buscador"
        '
        'txtIdCodigo
        '
        Me.txtIdCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtIdCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIdCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCodigo.ForeColor = System.Drawing.SystemColors.Window
        Me.txtIdCodigo.Location = New System.Drawing.Point(48, 164)
        Me.txtIdCodigo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtIdCodigo.Name = "txtIdCodigo"
        Me.txtIdCodigo.Size = New System.Drawing.Size(219, 23)
        Me.txtIdCodigo.TabIndex = 9
        '
        'labEncabezado
        '
        Me.labEncabezado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labEncabezado.AutoSize = True
        Me.labEncabezado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.labEncabezado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labEncabezado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.labEncabezado.Location = New System.Drawing.Point(43, 36)
        Me.labEncabezado.Name = "labEncabezado"
        Me.labEncabezado.Size = New System.Drawing.Size(0, 31)
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
        Me.gboAcceso.Location = New System.Drawing.Point(889, 79)
        Me.gboAcceso.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gboAcceso.Name = "gboAcceso"
        Me.gboAcceso.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gboAcceso.Size = New System.Drawing.Size(435, 258)
        Me.gboAcceso.TabIndex = 2
        Me.gboAcceso.TabStop = False
        Me.gboAcceso.Text = "Herramientas"
        '
        'gboTraAcceso
        '
        Me.gboTraAcceso.Controls.Add(Me.cboEstado)
        Me.gboTraAcceso.Controls.Add(Me.cboRol)
        Me.gboTraAcceso.Controls.Add(Me.labUsuario)
        Me.gboTraAcceso.Controls.Add(Me.labRol)
        Me.gboTraAcceso.Controls.Add(Me.txtClave)
        Me.gboTraAcceso.Controls.Add(Me.labClave)
        Me.gboTraAcceso.Controls.Add(Me.txtUsuario)
        Me.gboTraAcceso.Controls.Add(Me.labEstado)
        Me.gboTraAcceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboTraAcceso.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.gboTraAcceso.Location = New System.Drawing.Point(352, 505)
        Me.gboTraAcceso.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gboTraAcceso.Name = "gboTraAcceso"
        Me.gboTraAcceso.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gboTraAcceso.Size = New System.Drawing.Size(419, 217)
        Me.gboTraAcceso.TabIndex = 1
        Me.gboTraAcceso.TabStop = False
        Me.gboTraAcceso.Text = "Acceso"
        '
        'cboEstado
        '
        Me.cboEstado.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.cboEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstado.ForeColor = System.Drawing.Color.White
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Items.AddRange(New Object() {"Activado", "Desactivado"})
        Me.cboEstado.Location = New System.Drawing.Point(139, 80)
        Me.cboEstado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(189, 28)
        Me.cboEstado.TabIndex = 9
        '
        'cboRol
        '
        Me.cboRol.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.cboRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRol.ForeColor = System.Drawing.Color.White
        Me.cboRol.FormattingEnabled = True
        Me.cboRol.Items.AddRange(New Object() {"Administrador", "Cajero"})
        Me.cboRol.Location = New System.Drawing.Point(139, 46)
        Me.cboRol.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboRol.Name = "cboRol"
        Me.cboRol.Size = New System.Drawing.Size(189, 28)
        Me.cboRol.TabIndex = 8
        '
        'labUsuario
        '
        Me.labUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labUsuario.AutoSize = True
        Me.labUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.labUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labUsuario.ForeColor = System.Drawing.Color.White
        Me.labUsuario.Location = New System.Drawing.Point(21, 119)
        Me.labUsuario.Name = "labUsuario"
        Me.labUsuario.Size = New System.Drawing.Size(67, 20)
        Me.labUsuario.TabIndex = 4
        Me.labUsuario.Text = "Usuario"
        '
        'labRol
        '
        Me.labRol.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labRol.AutoSize = True
        Me.labRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.labRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labRol.ForeColor = System.Drawing.Color.White
        Me.labRol.Location = New System.Drawing.Point(21, 50)
        Me.labRol.Name = "labRol"
        Me.labRol.Size = New System.Drawing.Size(34, 20)
        Me.labRol.TabIndex = 2
        Me.labRol.Text = "Rol"
        '
        'txtClave
        '
        Me.txtClave.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClave.ForeColor = System.Drawing.SystemColors.Window
        Me.txtClave.Location = New System.Drawing.Point(139, 158)
        Me.txtClave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Size = New System.Drawing.Size(189, 23)
        Me.txtClave.TabIndex = 7
        Me.txtClave.UseSystemPasswordChar = True
        '
        'labClave
        '
        Me.labClave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labClave.AutoSize = True
        Me.labClave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.labClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labClave.ForeColor = System.Drawing.Color.White
        Me.labClave.Location = New System.Drawing.Point(21, 155)
        Me.labClave.Name = "labClave"
        Me.labClave.Size = New System.Drawing.Size(51, 20)
        Me.labClave.TabIndex = 5
        Me.labClave.Text = "Clave"
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.ForeColor = System.Drawing.SystemColors.Window
        Me.txtUsuario.Location = New System.Drawing.Point(139, 119)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(189, 23)
        Me.txtUsuario.TabIndex = 6
        '
        'labEstado
        '
        Me.labEstado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labEstado.AutoSize = True
        Me.labEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.labEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labEstado.ForeColor = System.Drawing.Color.White
        Me.labEstado.Location = New System.Drawing.Point(21, 85)
        Me.labEstado.Name = "labEstado"
        Me.labEstado.Size = New System.Drawing.Size(61, 20)
        Me.labEstado.TabIndex = 3
        Me.labEstado.Text = "Estado"
        '
        'gboDatos
        '
        Me.gboDatos.Controls.Add(Me.txtFechaIngreso)
        Me.gboDatos.Controls.Add(Me.Label11)
        Me.gboDatos.Controls.Add(Me.txtDireccion)
        Me.gboDatos.Controls.Add(Me.labelDireccion)
        Me.gboDatos.Controls.Add(Me.txtTel2)
        Me.gboDatos.Controls.Add(Me.txtTel1)
        Me.gboDatos.Controls.Add(Me.txtNDoc)
        Me.gboDatos.Controls.Add(Me.cboTipoDoc)
        Me.gboDatos.Controls.Add(Me.cboGenero)
        Me.gboDatos.Controls.Add(Me.txtNombre)
        Me.gboDatos.Controls.Add(Me.txtApeMaterno)
        Me.gboDatos.Controls.Add(Me.txtApePaterno)
        Me.gboDatos.Controls.Add(Me.Label6)
        Me.gboDatos.Controls.Add(Me.Label2)
        Me.gboDatos.Controls.Add(Me.Label7)
        Me.gboDatos.Controls.Add(Me.Label3)
        Me.gboDatos.Controls.Add(Me.Label8)
        Me.gboDatos.Controls.Add(Me.Label4)
        Me.gboDatos.Controls.Add(Me.Label9)
        Me.gboDatos.Controls.Add(Me.Label5)
        Me.gboDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.gboDatos.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.gboDatos.Location = New System.Drawing.Point(352, 79)
        Me.gboDatos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gboDatos.Name = "gboDatos"
        Me.gboDatos.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gboDatos.Size = New System.Drawing.Size(512, 410)
        Me.gboDatos.TabIndex = 0
        Me.gboDatos.TabStop = False
        Me.gboDatos.Text = "Datos"
        '
        'txtFechaIngreso
        '
        Me.txtFechaIngreso.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.txtFechaIngreso.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFechaIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaIngreso.ForeColor = System.Drawing.SystemColors.Window
        Me.txtFechaIngreso.Location = New System.Drawing.Point(235, 372)
        Me.txtFechaIngreso.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFechaIngreso.Name = "txtFechaIngreso"
        Me.txtFechaIngreso.Size = New System.Drawing.Size(245, 23)
        Me.txtFechaIngreso.TabIndex = 20
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(39, 374)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(115, 20)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Fecha ingreso"
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.ForeColor = System.Drawing.SystemColors.Window
        Me.txtDireccion.Location = New System.Drawing.Point(235, 270)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(189, 23)
        Me.txtDireccion.TabIndex = 18
        '
        'labelDireccion
        '
        Me.labelDireccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelDireccion.AutoSize = True
        Me.labelDireccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.labelDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelDireccion.ForeColor = System.Drawing.Color.White
        Me.labelDireccion.Location = New System.Drawing.Point(39, 273)
        Me.labelDireccion.Name = "labelDireccion"
        Me.labelDireccion.Size = New System.Drawing.Size(81, 20)
        Me.labelDireccion.TabIndex = 17
        Me.labelDireccion.Text = "Direccion"
        '
        'txtTel2
        '
        Me.txtTel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.txtTel2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel2.ForeColor = System.Drawing.SystemColors.Window
        Me.txtTel2.Location = New System.Drawing.Point(235, 338)
        Me.txtTel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTel2.Name = "txtTel2"
        Me.txtTel2.Size = New System.Drawing.Size(189, 23)
        Me.txtTel2.TabIndex = 16
        '
        'txtTel1
        '
        Me.txtTel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.txtTel1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel1.ForeColor = System.Drawing.SystemColors.Window
        Me.txtTel1.Location = New System.Drawing.Point(235, 302)
        Me.txtTel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTel1.Name = "txtTel1"
        Me.txtTel1.Size = New System.Drawing.Size(189, 23)
        Me.txtTel1.TabIndex = 15
        '
        'txtNDoc
        '
        Me.txtNDoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.txtNDoc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNDoc.ForeColor = System.Drawing.SystemColors.Window
        Me.txtNDoc.Location = New System.Drawing.Point(235, 235)
        Me.txtNDoc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNDoc.Name = "txtNDoc"
        Me.txtNDoc.Size = New System.Drawing.Size(189, 23)
        Me.txtNDoc.TabIndex = 14
        '
        'cboTipoDoc
        '
        Me.cboTipoDoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.cboTipoDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoDoc.ForeColor = System.Drawing.Color.White
        Me.cboTipoDoc.FormattingEnabled = True
        Me.cboTipoDoc.Items.AddRange(New Object() {"DNI"})
        Me.cboTipoDoc.Location = New System.Drawing.Point(235, 197)
        Me.cboTipoDoc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboTipoDoc.Name = "cboTipoDoc"
        Me.cboTipoDoc.Size = New System.Drawing.Size(189, 28)
        Me.cboTipoDoc.TabIndex = 13
        '
        'cboGenero
        '
        Me.cboGenero.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.cboGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGenero.ForeColor = System.Drawing.Color.White
        Me.cboGenero.FormattingEnabled = True
        Me.cboGenero.Items.AddRange(New Object() {"Hombre", "Mujer"})
        Me.cboGenero.Location = New System.Drawing.Point(235, 154)
        Me.cboGenero.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboGenero.Name = "cboGenero"
        Me.cboGenero.Size = New System.Drawing.Size(189, 28)
        Me.cboGenero.TabIndex = 12
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.SystemColors.Window
        Me.txtNombre.Location = New System.Drawing.Point(235, 122)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(189, 23)
        Me.txtNombre.TabIndex = 11
        '
        'txtApeMaterno
        '
        Me.txtApeMaterno.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.txtApeMaterno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtApeMaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApeMaterno.ForeColor = System.Drawing.SystemColors.Window
        Me.txtApeMaterno.Location = New System.Drawing.Point(235, 85)
        Me.txtApeMaterno.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtApeMaterno.Name = "txtApeMaterno"
        Me.txtApeMaterno.Size = New System.Drawing.Size(189, 23)
        Me.txtApeMaterno.TabIndex = 10
        '
        'txtApePaterno
        '
        Me.txtApePaterno.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.txtApePaterno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtApePaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApePaterno.ForeColor = System.Drawing.SystemColors.Window
        Me.txtApePaterno.Location = New System.Drawing.Point(235, 50)
        Me.txtApePaterno.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtApePaterno.Name = "txtApePaterno"
        Me.txtApePaterno.Size = New System.Drawing.Size(189, 23)
        Me.txtApePaterno.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(39, 305)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Telefono 1"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(39, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nombres"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(39, 206)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 20)
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
        Me.Label3.Location = New System.Drawing.Point(39, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Apellido Paterno"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(39, 341)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 20)
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
        Me.Label4.Location = New System.Drawing.Point(39, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Género"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(39, 239)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(135, 20)
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
        Me.Label5.Location = New System.Drawing.Point(39, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Apellido Materno"
        '
        'tabTraListado
        '
        Me.tabTraListado.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tabTraListado.Controls.Add(Me.lblUsuarioTotal)
        Me.tabTraListado.Controls.Add(Me.dgvTraListado)
        Me.tabTraListado.Controls.Add(Me.btnTraBuscar)
        Me.tabTraListado.Controls.Add(Me.Label1)
        Me.tabTraListado.Controls.Add(Me.txtTraBuscar)
        Me.tabTraListado.Location = New System.Drawing.Point(4, 29)
        Me.tabTraListado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabTraListado.Name = "tabTraListado"
        Me.tabTraListado.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabTraListado.Size = New System.Drawing.Size(1363, 752)
        Me.tabTraListado.TabIndex = 0
        Me.tabTraListado.Text = "Listado"
        '
        'lblUsuarioTotal
        '
        Me.lblUsuarioTotal.AutoSize = True
        Me.lblUsuarioTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblUsuarioTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarioTotal.ForeColor = System.Drawing.Color.White
        Me.lblUsuarioTotal.Location = New System.Drawing.Point(871, 42)
        Me.lblUsuarioTotal.Name = "lblUsuarioTotal"
        Me.lblUsuarioTotal.Size = New System.Drawing.Size(0, 24)
        Me.lblUsuarioTotal.TabIndex = 8
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
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(215, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTraListado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvTraListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTraListado.EnableHeadersVisualStyles = False
        Me.dgvTraListado.GridColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.dgvTraListado.Location = New System.Drawing.Point(36, 112)
        Me.dgvTraListado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvTraListado.Name = "dgvTraListado"
        Me.dgvTraListado.ReadOnly = True
        Me.dgvTraListado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(183, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTraListado.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvTraListado.RowHeadersWidth = 51
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(183, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.dgvTraListado.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvTraListado.RowTemplate.Height = 24
        Me.dgvTraListado.Size = New System.Drawing.Size(1291, 566)
        Me.dgvTraListado.TabIndex = 7
        '
        'btnTraBuscar
        '
        Me.btnTraBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnTraBuscar.FlatAppearance.BorderSize = 0
        Me.btnTraBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btnTraBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnTraBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTraBuscar.ForeColor = System.Drawing.Color.White
        Me.btnTraBuscar.Location = New System.Drawing.Point(637, 42)
        Me.btnTraBuscar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTraBuscar.Name = "btnTraBuscar"
        Me.btnTraBuscar.Size = New System.Drawing.Size(157, 38)
        Me.btnTraBuscar.TabIndex = 6
        Me.btnTraBuscar.Text = "Buscar"
        Me.btnTraBuscar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(32, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Buscador"
        '
        'txtTraBuscar
        '
        Me.txtTraBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtTraBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTraBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTraBuscar.ForeColor = System.Drawing.SystemColors.Window
        Me.txtTraBuscar.Location = New System.Drawing.Point(36, 57)
        Me.txtTraBuscar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTraBuscar.Name = "txtTraBuscar"
        Me.txtTraBuscar.Size = New System.Drawing.Size(563, 23)
        Me.txtTraBuscar.TabIndex = 5
        '
        'tabTrabajadores
        '
        Me.tabTrabajadores.Controls.Add(Me.tabTraListado)
        Me.tabTrabajadores.Controls.Add(Me.tabTraMantenimiento)
        Me.tabTrabajadores.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabTrabajadores.Location = New System.Drawing.Point(21, 30)
        Me.tabTrabajadores.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabTrabajadores.Name = "tabTrabajadores"
        Me.tabTrabajadores.SelectedIndex = 0
        Me.tabTrabajadores.Size = New System.Drawing.Size(1371, 785)
        Me.tabTrabajadores.TabIndex = 0
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
        Me.btnIconLimpiar.Location = New System.Drawing.Point(31, 206)
        Me.btnIconLimpiar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnIconLimpiar.Name = "btnIconLimpiar"
        Me.btnIconLimpiar.Rotation = 0R
        Me.btnIconLimpiar.Size = New System.Drawing.Size(364, 41)
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
        Me.btnIconBuscar.Location = New System.Drawing.Point(231, 154)
        Me.btnIconBuscar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnIconBuscar.Name = "btnIconBuscar"
        Me.btnIconBuscar.Rotation = 0R
        Me.btnIconBuscar.Size = New System.Drawing.Size(164, 41)
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
        Me.btnIconEliminar.Location = New System.Drawing.Point(31, 153)
        Me.btnIconEliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnIconEliminar.Name = "btnIconEliminar"
        Me.btnIconEliminar.Rotation = 0R
        Me.btnIconEliminar.Size = New System.Drawing.Size(164, 41)
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
        Me.btnIconGuardar.Location = New System.Drawing.Point(231, 46)
        Me.btnIconGuardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnIconGuardar.Name = "btnIconGuardar"
        Me.btnIconGuardar.Rotation = 0R
        Me.btnIconGuardar.Size = New System.Drawing.Size(164, 41)
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
        Me.btnIconCancelar.Location = New System.Drawing.Point(231, 102)
        Me.btnIconCancelar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnIconCancelar.Name = "btnIconCancelar"
        Me.btnIconCancelar.Rotation = 0R
        Me.btnIconCancelar.Size = New System.Drawing.Size(164, 41)
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
        Me.btnIconEditar.Location = New System.Drawing.Point(31, 103)
        Me.btnIconEditar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnIconEditar.Name = "btnIconEditar"
        Me.btnIconEditar.Rotation = 0R
        Me.btnIconEditar.Size = New System.Drawing.Size(164, 41)
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
        Me.btnIconNuevo.Location = New System.Drawing.Point(31, 46)
        Me.btnIconNuevo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnIconNuevo.Name = "btnIconNuevo"
        Me.btnIconNuevo.Rotation = 0R
        Me.btnIconNuevo.Size = New System.Drawing.Size(164, 41)
        Me.btnIconNuevo.TabIndex = 4
        Me.btnIconNuevo.Text = "Nuevo"
        Me.btnIconNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIconNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnIconNuevo.UseVisualStyleBackColor = False
        '
        'picImagen
        '
        Me.picImagen.Location = New System.Drawing.Point(48, 202)
        Me.picImagen.Margin = New System.Windows.Forms.Padding(5)
        Me.picImagen.Name = "picImagen"
        Me.picImagen.Size = New System.Drawing.Size(284, 223)
        Me.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picImagen.TabIndex = 10
        Me.picImagen.TabStop = False
        '
        'forTrabajadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1434, 853)
        Me.Controls.Add(Me.tabTrabajadores)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "forTrabajadores"
        Me.Text = "formTrabajadores"
        Me.tabTraMantenimiento.ResumeLayout(False)
        Me.tabTraMantenimiento.PerformLayout()
        Me.gboAcceso.ResumeLayout(False)
        Me.gboTraAcceso.ResumeLayout(False)
        Me.gboTraAcceso.PerformLayout()
        Me.gboDatos.ResumeLayout(False)
        Me.gboDatos.PerformLayout()
        Me.tabTraListado.ResumeLayout(False)
        Me.tabTraListado.PerformLayout()
        CType(Me.dgvTraListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabTrabajadores.ResumeLayout(False)
        CType(Me.picImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents tabTraMantenimiento As TabPage
    Friend WithEvents Label12 As Label
    Friend WithEvents btnAgregarImagen As Button
    Friend WithEvents picImagen As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtIdCodigo As TextBox
    Friend WithEvents labEncabezado As Label
    Friend WithEvents gboAcceso As GroupBox
    Friend WithEvents btnIconLimpiar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnIconBuscar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnIconEliminar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnIconGuardar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnIconCancelar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnIconEditar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnIconNuevo As FontAwesome.Sharp.IconButton
    Friend WithEvents gboTraAcceso As GroupBox
    Friend WithEvents cboEstado As ComboBox
    Friend WithEvents cboRol As ComboBox
    Friend WithEvents labUsuario As Label
    Friend WithEvents labRol As Label
    Friend WithEvents txtClave As TextBox
    Friend WithEvents labClave As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents labEstado As Label
    Friend WithEvents gboDatos As GroupBox
    Friend WithEvents txtFechaIngreso As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents labelDireccion As Label
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
    Friend WithEvents tabTraListado As TabPage
    Friend WithEvents lblUsuarioTotal As Label
    Friend WithEvents dgvTraListado As DataGridView
    Friend WithEvents btnTraBuscar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTraBuscar As TextBox
    Friend WithEvents tabTrabajadores As TabControl
End Class
