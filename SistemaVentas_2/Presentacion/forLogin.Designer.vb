<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class forLogin
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.iconImagen = New FontAwesome.Sharp.IconPictureBox()
        Me.btnLimpiar = New FontAwesome.Sharp.IconButton()
        Me.btnLogin = New FontAwesome.Sharp.IconButton()
        CType(Me.iconImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 602)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(438, 16)
        Me.Panel1.TabIndex = 1
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.ForeColor = System.Drawing.SystemColors.Window
        Me.txtUsuario.Location = New System.Drawing.Point(81, 315)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(285, 19)
        Me.txtUsuario.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(78, 359)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(78, 284)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Usuario"
        '
        'txtClave
        '
        Me.txtClave.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClave.ForeColor = System.Drawing.SystemColors.Window
        Me.txtClave.Location = New System.Drawing.Point(81, 388)
        Me.txtClave.Margin = New System.Windows.Forms.Padding(2)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Size = New System.Drawing.Size(285, 19)
        Me.txtClave.TabIndex = 5
        Me.txtClave.UseSystemPasswordChar = True
        '
        'iconImagen
        '
        Me.iconImagen.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.iconImagen.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.iconImagen.IconChar = FontAwesome.Sharp.IconChar.User
        Me.iconImagen.IconColor = System.Drawing.SystemColors.ControlLightLight
        Me.iconImagen.IconSize = 188
        Me.iconImagen.Location = New System.Drawing.Point(104, 72)
        Me.iconImagen.Margin = New System.Windows.Forms.Padding(2)
        Me.iconImagen.Name = "iconImagen"
        Me.iconImagen.Size = New System.Drawing.Size(225, 188)
        Me.iconImagen.TabIndex = 6
        Me.iconImagen.TabStop = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpiar.FlatAppearance.BorderSize = 0
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.HandsWash
        Me.btnLimpiar.IconColor = System.Drawing.Color.White
        Me.btnLimpiar.IconSize = 26
        Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLimpiar.Location = New System.Drawing.Point(260, 426)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Rotation = 0R
        Me.btnLimpiar.Size = New System.Drawing.Size(106, 28)
        Me.btnLimpiar.TabIndex = 8
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.btnLogin.ForeColor = System.Drawing.SystemColors.Control
        Me.btnLogin.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight
        Me.btnLogin.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnLogin.IconSize = 55
        Me.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogin.Location = New System.Drawing.Point(120, 471)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Rotation = 0R
        Me.btnLogin.Size = New System.Drawing.Size(209, 52)
        Me.btnLogin.TabIndex = 9
        Me.btnLogin.Text = "    Ingresar"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'forLogin
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(438, 618)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.iconImagen)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtUsuario)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(454, 657)
        Me.MinimumSize = New System.Drawing.Size(454, 657)
        Me.Name = "forLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.iconImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtClave As TextBox
    Friend WithEvents iconImagen As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnLimpiar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnLogin As FontAwesome.Sharp.IconButton
End Class
