<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class forDashboard
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
        Me.panMenu = New System.Windows.Forms.Panel()
        Me.panMenuProveedores = New System.Windows.Forms.Panel()
        Me.btnIconSubAgregar = New FontAwesome.Sharp.IconButton()
        Me.btnIconSubListado = New FontAwesome.Sharp.IconButton()
        Me.btnIconMenuProveedores = New FontAwesome.Sharp.IconButton()
        Me.panMenuUsuarios = New System.Windows.Forms.Panel()
        Me.btnIconSubTrabajadores = New FontAwesome.Sharp.IconButton()
        Me.btnIconSubClientes = New FontAwesome.Sharp.IconButton()
        Me.btnIconMenuUsuarios = New FontAwesome.Sharp.IconButton()
        Me.btnIconMenuDashboard = New FontAwesome.Sharp.IconButton()
        Me.panLogo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panEncabezado = New System.Windows.Forms.Panel()
        Me.IconActualForm = New FontAwesome.Sharp.IconPictureBox()
        Me.picUsuarioEncabezado = New System.Windows.Forms.PictureBox()
        Me.labRol = New System.Windows.Forms.Label()
        Me.labUsuario = New System.Windows.Forms.Label()
        Me.labMenu = New System.Windows.Forms.Label()
        Me.panForHijo = New System.Windows.Forms.Panel()
        Me.panMenu.SuspendLayout()
        Me.panMenuProveedores.SuspendLayout()
        Me.panMenuUsuarios.SuspendLayout()
        Me.panLogo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panEncabezado.SuspendLayout()
        CType(Me.IconActualForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUsuarioEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panMenu
        '
        Me.panMenu.AutoScroll = True
        Me.panMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.panMenu.Controls.Add(Me.panMenuProveedores)
        Me.panMenu.Controls.Add(Me.btnIconMenuProveedores)
        Me.panMenu.Controls.Add(Me.panMenuUsuarios)
        Me.panMenu.Controls.Add(Me.btnIconMenuUsuarios)
        Me.panMenu.Controls.Add(Me.btnIconMenuDashboard)
        Me.panMenu.Controls.Add(Me.panLogo)
        Me.panMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panMenu.Location = New System.Drawing.Point(0, 0)
        Me.panMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panMenu.Name = "panMenu"
        Me.panMenu.Size = New System.Drawing.Size(260, 937)
        Me.panMenu.TabIndex = 0
        '
        'panMenuProveedores
        '
        Me.panMenuProveedores.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.panMenuProveedores.Controls.Add(Me.btnIconSubAgregar)
        Me.panMenuProveedores.Controls.Add(Me.btnIconSubListado)
        Me.panMenuProveedores.Dock = System.Windows.Forms.DockStyle.Top
        Me.panMenuProveedores.Location = New System.Drawing.Point(0, 467)
        Me.panMenuProveedores.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panMenuProveedores.Name = "panMenuProveedores"
        Me.panMenuProveedores.Size = New System.Drawing.Size(260, 127)
        Me.panMenuProveedores.TabIndex = 7
        '
        'btnIconSubAgregar
        '
        Me.btnIconSubAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIconSubAgregar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnIconSubAgregar.FlatAppearance.BorderSize = 0
        Me.btnIconSubAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btnIconSubAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnIconSubAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIconSubAgregar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnIconSubAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIconSubAgregar.ForeColor = System.Drawing.Color.White
        Me.btnIconSubAgregar.IconChar = FontAwesome.Sharp.IconChar.UserTie
        Me.btnIconSubAgregar.IconColor = System.Drawing.Color.White
        Me.btnIconSubAgregar.IconSize = 32
        Me.btnIconSubAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIconSubAgregar.Location = New System.Drawing.Point(0, 60)
        Me.btnIconSubAgregar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnIconSubAgregar.Name = "btnIconSubAgregar"
        Me.btnIconSubAgregar.Padding = New System.Windows.Forms.Padding(35, 0, 21, 0)
        Me.btnIconSubAgregar.Rotation = 0R
        Me.btnIconSubAgregar.Size = New System.Drawing.Size(260, 60)
        Me.btnIconSubAgregar.TabIndex = 6
        Me.btnIconSubAgregar.Text = "Agregar"
        Me.btnIconSubAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIconSubAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnIconSubAgregar.UseVisualStyleBackColor = True
        '
        'btnIconSubListado
        '
        Me.btnIconSubListado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIconSubListado.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnIconSubListado.FlatAppearance.BorderSize = 0
        Me.btnIconSubListado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btnIconSubListado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnIconSubListado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIconSubListado.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnIconSubListado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIconSubListado.ForeColor = System.Drawing.Color.White
        Me.btnIconSubListado.IconChar = FontAwesome.Sharp.IconChar.Unity
        Me.btnIconSubListado.IconColor = System.Drawing.Color.White
        Me.btnIconSubListado.IconSize = 32
        Me.btnIconSubListado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIconSubListado.Location = New System.Drawing.Point(0, 0)
        Me.btnIconSubListado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnIconSubListado.Name = "btnIconSubListado"
        Me.btnIconSubListado.Padding = New System.Windows.Forms.Padding(35, 0, 21, 0)
        Me.btnIconSubListado.Rotation = 0R
        Me.btnIconSubListado.Size = New System.Drawing.Size(260, 60)
        Me.btnIconSubListado.TabIndex = 5
        Me.btnIconSubListado.Text = "Listado"
        Me.btnIconSubListado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIconSubListado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnIconSubListado.UseVisualStyleBackColor = True
        '
        'btnIconMenuProveedores
        '
        Me.btnIconMenuProveedores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIconMenuProveedores.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnIconMenuProveedores.FlatAppearance.BorderSize = 0
        Me.btnIconMenuProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btnIconMenuProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnIconMenuProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIconMenuProveedores.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnIconMenuProveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIconMenuProveedores.ForeColor = System.Drawing.Color.White
        Me.btnIconMenuProveedores.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.btnIconMenuProveedores.IconColor = System.Drawing.Color.White
        Me.btnIconMenuProveedores.IconSize = 32
        Me.btnIconMenuProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIconMenuProveedores.Location = New System.Drawing.Point(0, 407)
        Me.btnIconMenuProveedores.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnIconMenuProveedores.Name = "btnIconMenuProveedores"
        Me.btnIconMenuProveedores.Padding = New System.Windows.Forms.Padding(11, 0, 21, 0)
        Me.btnIconMenuProveedores.Rotation = 0R
        Me.btnIconMenuProveedores.Size = New System.Drawing.Size(260, 60)
        Me.btnIconMenuProveedores.TabIndex = 6
        Me.btnIconMenuProveedores.Text = "Proveedores"
        Me.btnIconMenuProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIconMenuProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnIconMenuProveedores.UseVisualStyleBackColor = True
        '
        'panMenuUsuarios
        '
        Me.panMenuUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.panMenuUsuarios.Controls.Add(Me.btnIconSubTrabajadores)
        Me.panMenuUsuarios.Controls.Add(Me.btnIconSubClientes)
        Me.panMenuUsuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.panMenuUsuarios.Location = New System.Drawing.Point(0, 280)
        Me.panMenuUsuarios.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panMenuUsuarios.Name = "panMenuUsuarios"
        Me.panMenuUsuarios.Size = New System.Drawing.Size(260, 127)
        Me.panMenuUsuarios.TabIndex = 5
        '
        'btnIconSubTrabajadores
        '
        Me.btnIconSubTrabajadores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIconSubTrabajadores.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnIconSubTrabajadores.FlatAppearance.BorderSize = 0
        Me.btnIconSubTrabajadores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btnIconSubTrabajadores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnIconSubTrabajadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIconSubTrabajadores.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnIconSubTrabajadores.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIconSubTrabajadores.ForeColor = System.Drawing.Color.White
        Me.btnIconSubTrabajadores.IconChar = FontAwesome.Sharp.IconChar.UserTie
        Me.btnIconSubTrabajadores.IconColor = System.Drawing.Color.White
        Me.btnIconSubTrabajadores.IconSize = 32
        Me.btnIconSubTrabajadores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIconSubTrabajadores.Location = New System.Drawing.Point(0, 60)
        Me.btnIconSubTrabajadores.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnIconSubTrabajadores.Name = "btnIconSubTrabajadores"
        Me.btnIconSubTrabajadores.Padding = New System.Windows.Forms.Padding(35, 0, 21, 0)
        Me.btnIconSubTrabajadores.Rotation = 0R
        Me.btnIconSubTrabajadores.Size = New System.Drawing.Size(260, 60)
        Me.btnIconSubTrabajadores.TabIndex = 6
        Me.btnIconSubTrabajadores.Text = "Trabajadores"
        Me.btnIconSubTrabajadores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIconSubTrabajadores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnIconSubTrabajadores.UseVisualStyleBackColor = True
        '
        'btnIconSubClientes
        '
        Me.btnIconSubClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIconSubClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnIconSubClientes.FlatAppearance.BorderSize = 0
        Me.btnIconSubClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btnIconSubClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnIconSubClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIconSubClientes.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnIconSubClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIconSubClientes.ForeColor = System.Drawing.Color.White
        Me.btnIconSubClientes.IconChar = FontAwesome.Sharp.IconChar.Unity
        Me.btnIconSubClientes.IconColor = System.Drawing.Color.White
        Me.btnIconSubClientes.IconSize = 32
        Me.btnIconSubClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIconSubClientes.Location = New System.Drawing.Point(0, 0)
        Me.btnIconSubClientes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnIconSubClientes.Name = "btnIconSubClientes"
        Me.btnIconSubClientes.Padding = New System.Windows.Forms.Padding(35, 0, 21, 0)
        Me.btnIconSubClientes.Rotation = 0R
        Me.btnIconSubClientes.Size = New System.Drawing.Size(260, 60)
        Me.btnIconSubClientes.TabIndex = 5
        Me.btnIconSubClientes.Text = "Clientes"
        Me.btnIconSubClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIconSubClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnIconSubClientes.UseVisualStyleBackColor = True
        '
        'btnIconMenuUsuarios
        '
        Me.btnIconMenuUsuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIconMenuUsuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnIconMenuUsuarios.FlatAppearance.BorderSize = 0
        Me.btnIconMenuUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btnIconMenuUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnIconMenuUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIconMenuUsuarios.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnIconMenuUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIconMenuUsuarios.ForeColor = System.Drawing.Color.White
        Me.btnIconMenuUsuarios.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.btnIconMenuUsuarios.IconColor = System.Drawing.Color.White
        Me.btnIconMenuUsuarios.IconSize = 32
        Me.btnIconMenuUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIconMenuUsuarios.Location = New System.Drawing.Point(0, 220)
        Me.btnIconMenuUsuarios.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnIconMenuUsuarios.Name = "btnIconMenuUsuarios"
        Me.btnIconMenuUsuarios.Padding = New System.Windows.Forms.Padding(11, 0, 21, 0)
        Me.btnIconMenuUsuarios.Rotation = 0R
        Me.btnIconMenuUsuarios.Size = New System.Drawing.Size(260, 60)
        Me.btnIconMenuUsuarios.TabIndex = 4
        Me.btnIconMenuUsuarios.Text = "Usuarios"
        Me.btnIconMenuUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIconMenuUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnIconMenuUsuarios.UseVisualStyleBackColor = True
        '
        'btnIconMenuDashboard
        '
        Me.btnIconMenuDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIconMenuDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnIconMenuDashboard.FlatAppearance.BorderSize = 0
        Me.btnIconMenuDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btnIconMenuDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnIconMenuDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIconMenuDashboard.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnIconMenuDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIconMenuDashboard.ForeColor = System.Drawing.Color.White
        Me.btnIconMenuDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartLine
        Me.btnIconMenuDashboard.IconColor = System.Drawing.Color.White
        Me.btnIconMenuDashboard.IconSize = 32
        Me.btnIconMenuDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIconMenuDashboard.Location = New System.Drawing.Point(0, 160)
        Me.btnIconMenuDashboard.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnIconMenuDashboard.Name = "btnIconMenuDashboard"
        Me.btnIconMenuDashboard.Padding = New System.Windows.Forms.Padding(11, 0, 21, 0)
        Me.btnIconMenuDashboard.Rotation = 0R
        Me.btnIconMenuDashboard.Size = New System.Drawing.Size(260, 60)
        Me.btnIconMenuDashboard.TabIndex = 3
        Me.btnIconMenuDashboard.Text = "Dashboard"
        Me.btnIconMenuDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIconMenuDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnIconMenuDashboard.UseVisualStyleBackColor = True
        '
        'panLogo
        '
        Me.panLogo.Controls.Add(Me.PictureBox1)
        Me.panLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panLogo.Location = New System.Drawing.Point(0, 0)
        Me.panLogo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panLogo.Name = "panLogo"
        Me.panLogo.Size = New System.Drawing.Size(260, 160)
        Me.panLogo.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SistemaVentas_2.My.Resources.Resources.mauvi
        Me.PictureBox1.Location = New System.Drawing.Point(11, 26)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(211, 119)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'panEncabezado
        '
        Me.panEncabezado.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.panEncabezado.Controls.Add(Me.IconActualForm)
        Me.panEncabezado.Controls.Add(Me.picUsuarioEncabezado)
        Me.panEncabezado.Controls.Add(Me.labRol)
        Me.panEncabezado.Controls.Add(Me.labUsuario)
        Me.panEncabezado.Controls.Add(Me.labMenu)
        Me.panEncabezado.Dock = System.Windows.Forms.DockStyle.Top
        Me.panEncabezado.Location = New System.Drawing.Point(260, 0)
        Me.panEncabezado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panEncabezado.Name = "panEncabezado"
        Me.panEncabezado.Size = New System.Drawing.Size(1452, 80)
        Me.panEncabezado.TabIndex = 1
        '
        'IconActualForm
        '
        Me.IconActualForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.IconActualForm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IconActualForm.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconActualForm.IconColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IconActualForm.IconSize = 54
        Me.IconActualForm.Location = New System.Drawing.Point(29, 14)
        Me.IconActualForm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IconActualForm.Name = "IconActualForm"
        Me.IconActualForm.Size = New System.Drawing.Size(55, 49)
        Me.IconActualForm.TabIndex = 4
        Me.IconActualForm.TabStop = False
        '
        'picUsuarioEncabezado
        '
        Me.picUsuarioEncabezado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picUsuarioEncabezado.Image = Global.SistemaVentas_2.My.Resources.Resources.Anotación_2020_05_17_164239
        Me.picUsuarioEncabezado.Location = New System.Drawing.Point(1095, 9)
        Me.picUsuarioEncabezado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picUsuarioEncabezado.Name = "picUsuarioEncabezado"
        Me.picUsuarioEncabezado.Size = New System.Drawing.Size(96, 65)
        Me.picUsuarioEncabezado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picUsuarioEncabezado.TabIndex = 3
        Me.picUsuarioEncabezado.TabStop = False
        '
        'labRol
        '
        Me.labRol.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labRol.AutoSize = True
        Me.labRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labRol.ForeColor = System.Drawing.Color.White
        Me.labRol.Location = New System.Drawing.Point(1212, 46)
        Me.labRol.Name = "labRol"
        Me.labRol.Size = New System.Drawing.Size(29, 17)
        Me.labRol.TabIndex = 2
        Me.labRol.Text = "Rol"
        '
        'labUsuario
        '
        Me.labUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labUsuario.AutoSize = True
        Me.labUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.labUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labUsuario.ForeColor = System.Drawing.Color.White
        Me.labUsuario.Location = New System.Drawing.Point(1196, 14)
        Me.labUsuario.Name = "labUsuario"
        Me.labUsuario.Size = New System.Drawing.Size(139, 20)
        Me.labUsuario.TabIndex = 1
        Me.labUsuario.Text = "Datos Completos"
        '
        'labMenu
        '
        Me.labMenu.AutoSize = True
        Me.labMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labMenu.ForeColor = System.Drawing.Color.White
        Me.labMenu.Location = New System.Drawing.Point(105, 26)
        Me.labMenu.Name = "labMenu"
        Me.labMenu.Size = New System.Drawing.Size(78, 29)
        Me.labMenu.TabIndex = 0
        Me.labMenu.Text = "Home"
        '
        'panForHijo
        '
        Me.panForHijo.AutoSize = True
        Me.panForHijo.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.panForHijo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panForHijo.Location = New System.Drawing.Point(260, 80)
        Me.panForHijo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panForHijo.Name = "panForHijo"
        Me.panForHijo.Size = New System.Drawing.Size(1452, 857)
        Me.panForHijo.TabIndex = 2
        '
        'forDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1712, 937)
        Me.Controls.Add(Me.panForHijo)
        Me.Controls.Add(Me.panEncabezado)
        Me.Controls.Add(Me.panMenu)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "forDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.panMenu.ResumeLayout(False)
        Me.panMenuProveedores.ResumeLayout(False)
        Me.panMenuUsuarios.ResumeLayout(False)
        Me.panLogo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panEncabezado.ResumeLayout(False)
        Me.panEncabezado.PerformLayout()
        CType(Me.IconActualForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUsuarioEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panMenu As Panel
    Friend WithEvents panLogo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents panEncabezado As Panel
    Friend WithEvents labUsuario As Label
    Friend WithEvents labMenu As Label
    Friend WithEvents labRol As Label
    Friend WithEvents picUsuarioEncabezado As PictureBox
    Friend WithEvents panForHijo As Panel
    Friend WithEvents btnIconMenuDashboard As FontAwesome.Sharp.IconButton
    Friend WithEvents panMenuUsuarios As Panel
    Friend WithEvents btnIconSubTrabajadores As FontAwesome.Sharp.IconButton
    Friend WithEvents btnIconSubClientes As FontAwesome.Sharp.IconButton
    Friend WithEvents btnIconMenuUsuarios As FontAwesome.Sharp.IconButton
    Friend WithEvents IconActualForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents panMenuProveedores As Panel
    Friend WithEvents btnIconSubAgregar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnIconSubListado As FontAwesome.Sharp.IconButton
    Friend WithEvents btnIconMenuProveedores As FontAwesome.Sharp.IconButton
End Class
