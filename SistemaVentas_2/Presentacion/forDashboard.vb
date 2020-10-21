Imports System.Data.SqlClient
Imports FontAwesome.Sharp

Public Class forDashboard

    Private ActualBoton As IconButton
    Private Sub forDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '---------------------------usuario
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

        '--------------------------Imagen circular
        Dim pic As New Drawing2D.GraphicsPath
        pic.AddEllipse(2, 2, 50, 50)
        picUsuarioEncabezado.Region = New Region(pic)

        metodoEsconderSubMenu()

        '--------------------------Imagen panel



    End Sub
    Public Sub metodoActivarBoton()
        'IconPictureBox1.IconChar = ActualBoton.IconChar
    End Sub
    Private Sub metodoEsconderSubMenu()
        panMenuUsuarios.Visible = False
    End Sub
    Private forActual As Form = Nothing
    Public Sub metodoAbrirFormularioHijo(forHijo As Form)
        'Si existe formulario abierto se cierra
        If forActual IsNot Nothing Then forActual.Close()
        forActual = forHijo 'Almacenamos el form activo
        forHijo.TopLevel = False 'Se conporta como control, no como superior
        forHijo.FormBorderStyle = FormBorderStyle.None
        forHijo.Dock = DockStyle.Fill
        panForHijo.Controls.Add(forHijo)
        panForHijo.Tag = forHijo 'Asociamos el form con el panel controlador
        forHijo.Show()
    End Sub

    Private Sub metodoMostrarSubMenu(subMenu As Panel)
        If subMenu.Visible = False Then
            metodoEsconderSubMenu()
            subMenu.Visible = True
        Else
            subMenu.Visible = False
        End If
    End Sub

    Private Sub btnIconMenuUsuarios_Click(sender As Object, e As EventArgs) Handles btnIconMenuUsuarios.Click
        metodoMostrarSubMenu(panMenuUsuarios)
    End Sub

    Private Sub btnIconSubClientes_Click(sender As Object, e As EventArgs) Handles btnIconSubClientes.Click
        'Code
        metodoAbrirFormularioHijo(New forClientes)

    End Sub

    Private Sub btnIconSubTrabajadores_Click(sender As Object, e As EventArgs) Handles btnIconSubTrabajadores.Click
        'metodoActivarBoton()
        metodoAbrirFormularioHijo(New forTrabajadores)
    End Sub

    Private Sub panEncabezado_Paint(sender As Object, e As PaintEventArgs) Handles panEncabezado.Paint

    End Sub
End Class