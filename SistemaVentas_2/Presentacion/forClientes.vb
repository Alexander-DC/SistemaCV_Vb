Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Data
Public Class forClientes
    Dim mantenimiento As Integer 'Accion Activar(Nuevo, Guardar)
    Dim empresa As String
    Private Sub forClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        metodoUsuarioTotal()

        dgvTraListado.DataSource = funcionListadoTrabajadores()
        cboTipo.Text = "Cliente"
        empresa = "-"
        txtFechaIngreso.Enabled = False
        cboTipo.Enabled = False
        'txtFechaIngreso.Text = Date.Now

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
        cn.Close()

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
        cn.Close()
        Return dtTrabajadores
    End Function

    Public Sub metodoUsuarioTotal()
        Dim cn As New SqlConnection("server=(Local); database=SistemaVenta5; integrated security=SSPI")
        Dim cmd As New SqlCommand

        cmd.CommandType = CommandType.StoredProcedure 'TipoConexion
        cmd.CommandText = "PERSONA_CLIENTE_Total_Clientes"
        cmd.Connection = cn

        cn.Open()
        Dim Dr As SqlDataReader
        Dr = cmd.ExecuteReader

        If Dr.Read() Then
            lblUsuarioTotal.Text = "Total de Usuarios: " & Dr(0)
        End If
        Dr.Close()
        cn.Close()

    End Sub
    Private Sub dgvTraListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTraListado.CellDoubleClick

        txtIdCodigo.Text = dgvTraListado.CurrentRow.Cells(0).Value.ToString()
        cboTipo.Text = dgvTraListado.CurrentRow.Cells(1).Value.ToString()
        txtFechaIngreso.Text = dgvTraListado.CurrentRow.Cells(2).Value.ToString()
        txtNombre.Text = dgvTraListado.CurrentRow.Cells(3).Value.ToString()
        txtApePaterno.Text = dgvTraListado.CurrentRow.Cells(4).Value.ToString()
        txtApeMaterno.Text = dgvTraListado.CurrentRow.Cells(5).Value.ToString()
        cboGenero.Text = dgvTraListado.CurrentRow.Cells(6).Value.ToString()
        cboTipoDoc.Text = dgvTraListado.CurrentRow.Cells(7).Value.ToString()
        txtNDoc.Text = dgvTraListado.CurrentRow.Cells(8).Value.ToString()
        txtDireccion.Text = dgvTraListado.CurrentRow.Cells(9).Value.ToString()
        txtTel1.Text = dgvTraListado.CurrentRow.Cells(10).Value.ToString()
        txtTel2.Text = dgvTraListado.CurrentRow.Cells(11).Value.ToString()
        txtEmail.Text = dgvTraListado.CurrentRow.Cells(12).Value.ToString()


        tabTrabajadores.SelectTab(1)

    End Sub

    Private Sub btnIconLimpiar_Click(sender As Object, e As EventArgs) Handles btnIconLimpiar.Click
        txtIdCodigo.Text = ""
        'cboTipo.Text = ""
        txtFechaIngreso.Text = ""
        txtNombre.Text = ""
        txtApePaterno.Text = ""
        txtApeMaterno.Text = ""
        cboGenero.Text = ""
        txtNDoc.Text = ""
        txtDireccion.Text = ""
        txtTel1.Text = ""
        txtTel2.Text = ""
        txtEmail.Text = ""

    End Sub
End Class