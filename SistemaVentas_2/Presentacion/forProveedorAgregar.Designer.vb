<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class forProveedorAgregar
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
        Me.labCodigo = New System.Windows.Forms.Label()
        Me.labEncabezado = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtEmpresaNombre = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtIdCodigo = New System.Windows.Forms.TextBox()
        Me.btnIconGuardar = New FontAwesome.Sharp.IconButton()
        Me.txtAccion = New System.Windows.Forms.TextBox()
        Me.gboDatos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.gboDatos.Location = New System.Drawing.Point(45, 143)
        Me.gboDatos.Margin = New System.Windows.Forms.Padding(2)
        Me.gboDatos.Name = "gboDatos"
        Me.gboDatos.Padding = New System.Windows.Forms.Padding(2)
        Me.gboDatos.Size = New System.Drawing.Size(664, 321)
        Me.gboDatos.TabIndex = 1
        Me.gboDatos.TabStop = False
        Me.gboDatos.Text = "Datos Del Proveedor"
        '
        'cboTipo
        '
        Me.cboTipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.cboTipo.Enabled = False
        Me.cboTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipo.ForeColor = System.Drawing.Color.White
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Items.AddRange(New Object() {"Proveedor"})
        Me.cboTipo.Location = New System.Drawing.Point(498, 72)
        Me.cboTipo.Margin = New System.Windows.Forms.Padding(2)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(152, 25)
        Me.cboTipo.TabIndex = 25
        Me.cboTipo.Text = "Proveedor"
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.ForeColor = System.Drawing.SystemColors.Window
        Me.txtDireccion.Location = New System.Drawing.Point(498, 151)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(151, 41)
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
        Me.txtTel2.Location = New System.Drawing.Point(499, 204)
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
        Me.Label8.Location = New System.Drawing.Point(355, 204)
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
        'labCodigo
        '
        Me.labCodigo.AutoSize = True
        Me.labCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labCodigo.ForeColor = System.Drawing.Color.White
        Me.labCodigo.Location = New System.Drawing.Point(56, 104)
        Me.labCodigo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labCodigo.Name = "labCodigo"
        Me.labCodigo.Size = New System.Drawing.Size(56, 18)
        Me.labCodigo.TabIndex = 14
        Me.labCodigo.Text = "Codigo"
        '
        'labEncabezado
        '
        Me.labEncabezado.AutoSize = True
        Me.labEncabezado.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labEncabezado.ForeColor = System.Drawing.SystemColors.Control
        Me.labEncabezado.Location = New System.Drawing.Point(54, 41)
        Me.labEncabezado.Name = "labEncabezado"
        Me.labEncabezado.Size = New System.Drawing.Size(265, 29)
        Me.labEncabezado.TabIndex = 16
        Me.labEncabezado.Text = "Inserte Datos a Agregar"
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(28, 51)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(58, 17)
        Me.Label23.TabIndex = 6
        Me.Label23.Text = "Nombre"
        '
        'txtEmpresaNombre
        '
        Me.txtEmpresaNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.txtEmpresaNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmpresaNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpresaNombre.ForeColor = System.Drawing.SystemColors.Window
        Me.txtEmpresaNombre.Location = New System.Drawing.Point(149, 38)
        Me.txtEmpresaNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmpresaNombre.Multiline = True
        Me.txtEmpresaNombre.Name = "txtEmpresaNombre"
        Me.txtEmpresaNombre.Size = New System.Drawing.Size(142, 49)
        Me.txtEmpresaNombre.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtEmpresaNombre)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Location = New System.Drawing.Point(732, 153)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(308, 213)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos De La Empresa"
        '
        'txtIdCodigo
        '
        Me.txtIdCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.txtIdCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIdCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCodigo.ForeColor = System.Drawing.SystemColors.Window
        Me.txtIdCodigo.Location = New System.Drawing.Point(210, 102)
        Me.txtIdCodigo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIdCodigo.Name = "txtIdCodigo"
        Me.txtIdCodigo.Size = New System.Drawing.Size(142, 19)
        Me.txtIdCodigo.TabIndex = 18
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
        Me.btnIconGuardar.Location = New System.Drawing.Point(45, 511)
        Me.btnIconGuardar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnIconGuardar.Name = "btnIconGuardar"
        Me.btnIconGuardar.Rotation = 0R
        Me.btnIconGuardar.Size = New System.Drawing.Size(123, 33)
        Me.btnIconGuardar.TabIndex = 20
        Me.btnIconGuardar.Text = "Guardar"
        Me.btnIconGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIconGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnIconGuardar.UseVisualStyleBackColor = False
        '
        'txtAccion
        '
        Me.txtAccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.txtAccion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccion.ForeColor = System.Drawing.SystemColors.Window
        Me.txtAccion.Location = New System.Drawing.Point(445, 102)
        Me.txtAccion.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAccion.Name = "txtAccion"
        Me.txtAccion.Size = New System.Drawing.Size(142, 19)
        Me.txtAccion.TabIndex = 21
        '
        'forProveedorAgregar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1076, 687)
        Me.Controls.Add(Me.txtAccion)
        Me.Controls.Add(Me.btnIconGuardar)
        Me.Controls.Add(Me.txtIdCodigo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.labEncabezado)
        Me.Controls.Add(Me.labCodigo)
        Me.Controls.Add(Me.gboDatos)
        Me.Name = "forProveedorAgregar"
        Me.Text = "forProveedorAgregar"
        Me.gboDatos.ResumeLayout(False)
        Me.gboDatos.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gboDatos As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents labEmail As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents labTipo As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents labCodigo As Label
    Friend WithEvents labEncabezado As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Public WithEvents cboTipo As ComboBox
    Public WithEvents txtDireccion As TextBox
    Public WithEvents txtEmail As TextBox
    Public WithEvents txtFechaIngreso As TextBox
    Public WithEvents txtTel2 As TextBox
    Public WithEvents txtTel1 As TextBox
    Public WithEvents txtNDoc As TextBox
    Public WithEvents cboTipoDoc As ComboBox
    Public WithEvents cboGenero As ComboBox
    Public WithEvents txtNombre As TextBox
    Public WithEvents txtApeMaterno As TextBox
    Public WithEvents txtApePaterno As TextBox
    Public WithEvents txtEmpresaNombre As TextBox
    Public WithEvents txtIdCodigo As TextBox
    Friend WithEvents btnIconGuardar As FontAwesome.Sharp.IconButton
    Public WithEvents txtAccion As TextBox
End Class
