Imports System.Data.SqlClient
Public Class forLogin

    Private Sub btnLogin_Paint_1(sender As Object, e As PaintEventArgs) Handles btnLogin.Paint
        Dim btnPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim rectangulo As Rectangle = btnLogin.ClientRectangle
        rectangulo.Inflate(0, 30)
        btnPath.AddEllipse(rectangulo)
        btnLogin.Region = New Region(btnPath)
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtUsuario.Text = ""
        txtClave.Text = ""
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim cn As New SqlConnection("server=(Local); database=SistemaVenta5; integrated security=SSPI")
        Dim cmd As New SqlCommand

        cmd.CommandType = CommandType.StoredProcedure 'TipoConexion
        cmd.CommandText = "USUARIO_Login" '
        cmd.Connection = cn
        'Agregando parametros
        cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = txtUsuario.Text.Trim
        cmd.Parameters.Add("@clave", SqlDbType.VarChar).Value = txtClave.Text.Trim

        cn.Open()

        'Recuperar filas,datos de la base de datos, necesaria la conexion, sqlADaptaer conexion cerrada
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader

        Dim id_rol As String
        Dim nom_rol As String

        'Declarando si hay datos en la tabla, y login por categoria
        If dr.Read = True Then
            If dr(4) = 0 Then
                MsgBox("Su cuenta se encuentra deshabilidada")
                Exit Sub
            Else
                'Enviando datos al MODULO
                pasarLogin.usuario = txtUsuario.Text.Trim
                id_rol = dr(2)
                nom_rol = dr(3)
                pasarLogin.id_rol = id_rol

                Select Case id_rol
                    Case 1
                        'Administrador
                        MessageBox.Show("Bienvenido " & nom_rol)
                        Me.Hide()
                        forDashboard.Show()
                    Case 2
                        'Cajero
                        MessageBox.Show("Bienvenido " & nom_rol)
                        Me.Hide()
                        forDashboard.Show()
                End Select
            End If
        Else
            MessageBox.Show("Ingrese correctamente")
        End If
        'Cerrar conexion
        cn.Close()

    End Sub

    Private Sub forLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class