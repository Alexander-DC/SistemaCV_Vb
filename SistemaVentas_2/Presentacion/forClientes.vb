Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Data
Public Class forClientes
    Dim mantenimiento As Integer 'Accion Activar(Nuevo, Guardar)
    Private Sub forClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvTraListado.DataSource = funcionListadoTrabajadores()
    End Sub
    Private Sub txtTraBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTraBuscar.KeyPress

        Dim cn As New SqlConnection("server=(Local); database=SistemaVenta5; integrated security=SSPI")
        Dim cmd As New SqlCommand

        cmd.CommandType = CommandType.StoredProcedure 'TipoConexion
        cmd.CommandText = "PERSONA_CLIENTE_Buscar_Tabla" '
        cmd.Connection = cn

        cmd.Parameters.Add("@ape_materno", SqlDbType.VarChar).Value = txtTraBuscar.Text.Trim
        cn.Open()

        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader

        Dim dt = New DataTable


        dt.Load(dr)
        dgvTraListado.DataSource = dt

    End Sub
    Private Function funcionListadoTrabajadores() As DataTable
        Dim dtTrabajadores As New DataTable

        Dim cn As New SqlConnection("server=(Local); database=SistemaVenta5; integrated security=SSPI")
        Dim cmd As New SqlCommand

        cmd.CommandType = CommandType.StoredProcedure 'TipoConexion
        cmd.CommandText = "PERSONA_CLIENTE_Mostrar_Todo" '
        cmd.Connection = cn

        cn.Open()

        Dim dr As SqlDataReader 'ejecutar sql
        dr = cmd.ExecuteReader 'almacena la tabla en memoria

        dtTrabajadores.Load(dr)

        Return dtTrabajadores
    End Function
End Class