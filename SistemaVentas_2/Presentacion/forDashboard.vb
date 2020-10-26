Imports System.Data.SqlClient
Imports FontAwesome.Sharp

Public Class forDashboard

    Private ActualBoton As IconButton
    Private Sub forDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '---------------------------usuario
        metodoMostrarUsuario()
        '--------------------------Imagen circular
        Dim pic As New Drawing2D.GraphicsPath
        pic.AddEllipse(2, 2, 50, 50)
        picUsuarioEncabezado.Region = New Region(pic)

        metodoEsconderSubMenu()

        '--------------------------Imagen panel

    End Sub
    'Pasar datos de nombre y rol al Dashboard en el encabezado, y restrige roles
    Public Sub metodoMostrarUsuario()
        Dim cn As New SqlConnection("server=(Local); database=SistemaVenta5; integrated security=SSPI")
        Dim cmd As New SqlCommand

        cmd.CommandType = CommandType.StoredProcedure 'TipoConexion
        cmd.CommandText = "USUARIO_Mostrar" '
        cmd.Connection = cn

        Dim dr As SqlDataReader
        Dim datoCompleto As String

        cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = pasarLogin.usuario
        cn.Open()
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            datoCompleto = dr(3) & " " & dr(4) & " " & dr(2)
            labUsuario.Text = datoCompleto
            labRol.Text = dr(17)
        End If
        cn.Close()
        '__________________________Bloqueo

        Select Case pasarLogin.id_rol
            Case 1
                Exit Sub
            Case 2
                btnIconSubTrabajadores.Visible = False
                Exit Sub
        End Select
    End Sub

    'Permite esconder los paneles, a la hora de dar clip
    Private Sub metodoEsconderSubMenu()


        panMenuUsuarios.Visible = False
        btnIconMenuUsuarios.BackColor = Color.FromArgb(11, 8, 20)
        panMenuProveedores.Visible = False
        btnIconMenuProveedores.BackColor = Color.FromArgb(11, 8, 20)
    End Sub

    'Abre formulario hijo del SubBoton
    Private forActual As Form = Nothing
    Public Sub metodoAbrirFormularioHijo(forHijo As Form, Boton As IconButton)
        'Si existe formulario abierto se cierra
        If forActual IsNot Nothing Then forActual.Close()
        forActual = forHijo 'Almacenamos el form activo
        forHijo.TopLevel = False 'Se conporta como control, no como superior
        forHijo.FormBorderStyle = FormBorderStyle.None
        forHijo.Dock = DockStyle.Fill
        panForHijo.Controls.Add(forHijo)
        panForHijo.Tag = forHijo 'Asociamos el form con el panel controlador
        forHijo.Show()
        IconActualForm.IconChar = Boton.IconChar
        labMenu.Text = Boton.Text
    End Sub

    Private Sub metodoMostrarSubMenu(subMenu As Panel, Boton As IconButton)
        'Abre el panel de los SubBotones
        If subMenu.Visible = False Then
            Boton.FlatAppearance.MouseOverBackColor = Color.FromArgb(36, 33, 40)
            Boton.BackColor = Color.FromArgb(11, 8, 20)
            metodoEsconderSubMenu()
            subMenu.Visible = True
            Boton.BackColor = Color.FromArgb(0, 128, 128)
            Boton.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 128, 128)
            IconActualForm.IconChar = Boton.IconChar
            labMenu.Text = Boton.Text

        Else
            subMenu.Visible = False
            Boton.BackColor = Color.FromArgb(11, 8, 20)
            'IMAGEN ENCABEZADO
        End If
    End Sub
    Private Sub btnIconMenuDashboard_Click(sender As Object, e As EventArgs) Handles btnIconMenuDashboard.Click
        metodoAbrirFormularioHijo(New forSubDashboard, btnIconMenuDashboard)
    End Sub
    Private Sub btnIconMenuUsuarios_Click(sender As Object, e As EventArgs) Handles btnIconMenuUsuarios.Click
        metodoMostrarSubMenu(panMenuUsuarios, btnIconMenuUsuarios)
    End Sub

    Private Sub btnIconSubClientes_Click(sender As Object, e As EventArgs) Handles btnIconSubClientes.Click
        'Code
        metodoAbrirFormularioHijo(New forClientes, btnIconSubClientes)

    End Sub

    Private Sub btnIconSubTrabajadores_Click(sender As Object, e As EventArgs) Handles btnIconSubTrabajadores.Click
        'metodoActivarBoton()
        metodoAbrirFormularioHijo(New forTrabajadores, btnIconSubTrabajadores)
    End Sub
    Private Sub btnIconMenuProveedores_Click(sender As Object, e As EventArgs) Handles btnIconMenuProveedores.Click
        metodoMostrarSubMenu(panMenuProveedores, btnIconMenuProveedores)
    End Sub

    Private Sub btnIconSubListado_Click(sender As Object, e As EventArgs) Handles btnIconSubListado.Click
        metodoAbrirFormularioHijo(New forProveedorListado, btnIconSubListado)

    End Sub
    Private Sub btnIconSubAgregar_Click(sender As Object, e As EventArgs) Handles btnIconSubAgregar.Click
        metodoAbrirFormularioHijo(New forProveedorAgregar, btnIconSubAgregar)
    End Sub

End Class