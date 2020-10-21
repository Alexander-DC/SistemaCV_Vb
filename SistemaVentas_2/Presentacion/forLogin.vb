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

        Dim cod_categoria As String
        Dim nom_categoria As String

        'Declarando si hay datos en la tabla, y login por categoria
        If dr.Read = True Then
            'Enviando datos al MODULO
            pasarLogin.usuario = txtUsuario.Text.Trim

            cod_categoria = dr(2)
            nom_categoria = dr(3)
            Select Case cod_categoria
                Case 1
                    MessageBox.Show("Bienvenido " & nom_categoria)
                    Me.Hide()
                    forDashboard.Show()
                Case 2
                    MessageBox.Show("Bienvenido " & nom_categoria)
                    Me.Hide()
                    forDashboard.Show()
            End Select

        Else
            MessageBox.Show("Ingrese correctamente")
        End If
        'Cerrar conexion
        cn.Close()



    End Sub

    Private Sub forLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class