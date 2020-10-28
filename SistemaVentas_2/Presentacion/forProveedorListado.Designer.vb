<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class forProveedorListado
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tabTrabajadores = New System.Windows.Forms.TabControl()
        Me.tabTraListado = New System.Windows.Forms.TabPage()
        Me.btnIconNuevo = New FontAwesome.Sharp.IconButton()
        Me.btnIconEliminar = New FontAwesome.Sharp.IconButton()
        Me.btnIconEditar = New FontAwesome.Sharp.IconButton()
        Me.cboProBuscador = New System.Windows.Forms.ComboBox()
        Me.lblUsuarioTotal = New System.Windows.Forms.Label()
        Me.dgvTraListado = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTraBuscar = New System.Windows.Forms.TextBox()
        Me.btnIconActualizar = New FontAwesome.Sharp.IconButton()
        Me.tabTrabajadores.SuspendLayout()
        Me.tabTraListado.SuspendLayout()
        CType(Me.dgvTraListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabTrabajadores
        '
        Me.tabTrabajadores.Controls.Add(Me.tabTraListado)
        Me.tabTrabajadores.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabTrabajadores.Location = New System.Drawing.Point(16, 21)
        Me.tabTrabajadores.Margin = New System.Windows.Forms.Padding(2)
        Me.tabTrabajadores.Name = "tabTrabajadores"
        Me.tabTrabajadores.SelectedIndex = 0
        Me.tabTrabajadores.Size = New System.Drawing.Size(1049, 638)
        Me.tabTrabajadores.TabIndex = 2
        '
        'tabTraListado
        '
        Me.tabTraListado.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tabTraListado.Controls.Add(Me.btnIconActualizar)
        Me.tabTraListado.Controls.Add(Me.btnIconNuevo)
        Me.tabTraListado.Controls.Add(Me.btnIconEliminar)
        Me.tabTraListado.Controls.Add(Me.btnIconEditar)
        Me.tabTraListado.Controls.Add(Me.cboProBuscador)
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
        Me.btnIconNuevo.Location = New System.Drawing.Point(893, 106)
        Me.btnIconNuevo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnIconNuevo.Name = "btnIconNuevo"
        Me.btnIconNuevo.Rotation = 0R
        Me.btnIconNuevo.Size = New System.Drawing.Size(123, 33)
        Me.btnIconNuevo.TabIndex = 29
        Me.btnIconNuevo.Text = "Nuevo"
        Me.btnIconNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIconNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnIconNuevo.UseVisualStyleBackColor = False
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
        Me.btnIconEliminar.Location = New System.Drawing.Point(893, 213)
        Me.btnIconEliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnIconEliminar.Name = "btnIconEliminar"
        Me.btnIconEliminar.Rotation = 0R
        Me.btnIconEliminar.Size = New System.Drawing.Size(123, 33)
        Me.btnIconEliminar.TabIndex = 28
        Me.btnIconEliminar.Text = "Eliminar"
        Me.btnIconEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIconEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnIconEliminar.UseVisualStyleBackColor = False
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
        Me.btnIconEditar.Location = New System.Drawing.Point(893, 159)
        Me.btnIconEditar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnIconEditar.Name = "btnIconEditar"
        Me.btnIconEditar.Rotation = 0R
        Me.btnIconEditar.Size = New System.Drawing.Size(123, 33)
        Me.btnIconEditar.TabIndex = 27
        Me.btnIconEditar.Text = "Editar"
        Me.btnIconEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIconEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnIconEditar.UseVisualStyleBackColor = False
        '
        'cboProBuscador
        '
        Me.cboProBuscador.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.cboProBuscador.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProBuscador.ForeColor = System.Drawing.Color.White
        Me.cboProBuscador.FormattingEnabled = True
        Me.cboProBuscador.Items.AddRange(New Object() {"Codigo", "Numero de Doc", "Apellidos"})
        Me.cboProBuscador.Location = New System.Drawing.Point(193, 10)
        Me.cboProBuscador.Margin = New System.Windows.Forms.Padding(2)
        Me.cboProBuscador.Name = "cboProBuscador"
        Me.cboProBuscador.Size = New System.Drawing.Size(152, 25)
        Me.cboProBuscador.TabIndex = 26
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
        Me.dgvTraListado.Location = New System.Drawing.Point(17, 91)
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
        Me.dgvTraListado.Size = New System.Drawing.Size(857, 485)
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
        Me.Label1.Size = New System.Drawing.Size(106, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Buscador por: "
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
        'btnIconActualizar
        '
        Me.btnIconActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnIconActualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIconActualizar.FlatAppearance.BorderSize = 0
        Me.btnIconActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btnIconActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnIconActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIconActualizar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnIconActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIconActualizar.ForeColor = System.Drawing.Color.White
        Me.btnIconActualizar.IconChar = FontAwesome.Sharp.IconChar.CalendarPlus
        Me.btnIconActualizar.IconColor = System.Drawing.Color.White
        Me.btnIconActualizar.IconSize = 32
        Me.btnIconActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIconActualizar.Location = New System.Drawing.Point(510, 40)
        Me.btnIconActualizar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnIconActualizar.Name = "btnIconActualizar"
        Me.btnIconActualizar.Rotation = 0R
        Me.btnIconActualizar.Size = New System.Drawing.Size(123, 33)
        Me.btnIconActualizar.TabIndex = 30
        Me.btnIconActualizar.Text = "Actualizar"
        Me.btnIconActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIconActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnIconActualizar.UseVisualStyleBackColor = False
        '
        'forProveedorListado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1076, 687)
        Me.Controls.Add(Me.tabTrabajadores)
        Me.Name = "forProveedorListado"
        Me.Text = "forProveedorListado"
        Me.tabTrabajadores.ResumeLayout(False)
        Me.tabTraListado.ResumeLayout(False)
        Me.tabTraListado.PerformLayout()
        CType(Me.dgvTraListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabTrabajadores As TabControl
    Friend WithEvents tabTraListado As TabPage
    Friend WithEvents lblUsuarioTotal As Label
    Friend WithEvents dgvTraListado As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTraBuscar As TextBox
    Friend WithEvents cboProBuscador As ComboBox
    Friend WithEvents btnIconEditar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnIconEliminar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnIconNuevo As FontAwesome.Sharp.IconButton
    Friend WithEvents btnIconActualizar As FontAwesome.Sharp.IconButton
End Class
