<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class forSeguridadBackup
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
        Me.tabBackup = New System.Windows.Forms.TabControl()
        Me.tabBacAgregar = New System.Windows.Forms.TabPage()
        Me.tabBacRestaurar = New System.Windows.Forms.TabPage()
        Me.tabBackup.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabBackup
        '
        Me.tabBackup.Controls.Add(Me.tabBacAgregar)
        Me.tabBackup.Controls.Add(Me.tabBacRestaurar)
        Me.tabBackup.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.tabBackup.Location = New System.Drawing.Point(16, 21)
        Me.tabBackup.Name = "tabBackup"
        Me.tabBackup.SelectedIndex = 0
        Me.tabBackup.Size = New System.Drawing.Size(1049, 638)
        Me.tabBackup.TabIndex = 0
        '
        'tabBacAgregar
        '
        Me.tabBacAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tabBacAgregar.Location = New System.Drawing.Point(4, 26)
        Me.tabBacAgregar.Name = "tabBacAgregar"
        Me.tabBacAgregar.Padding = New System.Windows.Forms.Padding(3)
        Me.tabBacAgregar.Size = New System.Drawing.Size(1041, 608)
        Me.tabBacAgregar.TabIndex = 0
        Me.tabBacAgregar.Text = "Agregar"
        '
        'tabBacRestaurar
        '
        Me.tabBacRestaurar.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tabBacRestaurar.Location = New System.Drawing.Point(4, 26)
        Me.tabBacRestaurar.Name = "tabBacRestaurar"
        Me.tabBacRestaurar.Padding = New System.Windows.Forms.Padding(3)
        Me.tabBacRestaurar.Size = New System.Drawing.Size(1041, 608)
        Me.tabBacRestaurar.TabIndex = 1
        Me.tabBacRestaurar.Text = "Restaurar"
        '
        'forSeguridadBackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1076, 687)
        Me.Controls.Add(Me.tabBackup)
        Me.Name = "forSeguridadBackup"
        Me.Text = "forSeguridadBackup"
        Me.tabBackup.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabBackup As TabControl
    Friend WithEvents tabBacAgregar As TabPage
    Friend WithEvents tabBacRestaurar As TabPage
End Class
