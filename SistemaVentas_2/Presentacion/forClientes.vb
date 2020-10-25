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
        metodoTerminado()
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
    Public Sub metodoBotonDesbloquear()
        btnIconNuevo.BackColor = Color.FromArgb(11, 8, 20)
        btnIconNuevo.Enabled = True
        btnIconEditar.BackColor = Color.FromArgb(11, 8, 20)
        btnIconEditar.Enabled = True
        btnIconEliminar.BackColor = Color.FromArgb(11, 8, 20)
        btnIconEliminar.Enabled = True
        btnIconBuscar.BackColor = Color.FromArgb(11, 8, 20)
        btnIconBuscar.Enabled = True
        labEncabezado.Text = ""
    End Sub
    Public Sub metodoBotonBloquear()
        btnIconNuevo.BackColor = Color.FromArgb(92, 92, 92)
        btnIconNuevo.Enabled = False
        btnIconEditar.BackColor = Color.FromArgb(92, 92, 92)
        btnIconEditar.Enabled = False
        btnIconEliminar.BackColor = Color.FromArgb(92, 92, 92)
        btnIconEliminar.Enabled = False
        btnIconBuscar.BackColor = Color.FromArgb(92, 92, 92)
        btnIconBuscar.Enabled = False
    End Sub
    Private Sub btnIconBuscar_Click(sender As Object, e As EventArgs) Handles btnIconBuscar.Click
        Dim existencia As Boolean = False
        Dim cn As New SqlConnection("server=(Local); database=SistemaVenta5; integrated security=SSPI")
        Dim cmd As New SqlCommand


        If txtIdCodigo.Text = "" Then
            MsgBox("Digita el codigo a Buscar")
        Else
            cmd.CommandType = CommandType.StoredProcedure 'TipoConexion
            cmd.CommandText = "PERSONA_CLIENTE_Buscar"
            cmd.Connection = cn
            cmd.Parameters.Add("@id_persona", SqlDbType.Int).Value = Convert.ToInt32(txtIdCodigo.Text.Trim)
            cn.Open()

            Dim Dr As SqlDataReader
            Dr = cmd.ExecuteReader

            If Dr.Read() Then
                existencia = True

                txtIdCodigo.Text = Dr(0)
                cboTipo.Text = Dr(1)
                txtFechaIngreso.Text = Dr(2)
                txtNombre.Text = Dr(3)
                txtApePaterno.Text = Dr(4)
                txtApeMaterno.Text = Dr(5)
                cboGenero.Text = Dr(6)
                cboTipoDoc.Text = Dr(7)
                txtNDoc.Text = Dr(8)
                txtDireccion.Text = Dr(9)
                txtTel1.Text = Dr(10)
                txtTel2.Text = Dr(11)
                txtEmail.Text = Dr(12)



            Else
                MsgBox("No se encontro al cliente", vbExclamation, "No encontrado")
                txtIdCodigo.Focus()

            End If

            Dr.Close()
            cn.Close()

            dgvTraListado.DataSource = funcionListadoTrabajadores()
            mantenimiento = 0
            metodoBotonDesbloquear()
            Exit Sub
        End If

    End Sub
    Public Sub metodoTerminado()
        mantenimiento = 0
        metodoBotonDesbloquear()
        labEncabezado.Text = ""
        dgvTraListado.DataSource = funcionListadoTrabajadores()
        metodoUsuarioTotal()
    End Sub

    Private Sub btnIconGuardar_Click(sender As Object, e As EventArgs) Handles btnIconGuardar.Click
        Select Case mantenimiento
            Case 1
                Dim cn As New SqlConnection("server=(Local); database=SistemaVenta5; integrated security=SSPI")
                Dim cmd As New SqlCommand

                cmd.CommandType = CommandType.StoredProcedure 'TipoConexion
                cmd.CommandText = "PERSONA_CLIENTE_Insertar"
                cmd.Connection = cn

                cmd.Parameters.Add("@tipo_persona", SqlDbType.VarChar).Value = cboTipo.SelectedItem.Trim
                cmd.Parameters.Add("@empresa", SqlDbType.VarChar).Value = empresa
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtNombre.Text.Trim
                cmd.Parameters.Add("@ape_paterno", SqlDbType.VarChar).Value = txtApePaterno.Text.Trim
                cmd.Parameters.Add("@ape_materno", SqlDbType.VarChar).Value = txtApeMaterno.Text.Trim
                cmd.Parameters.Add("@genero", SqlDbType.VarChar).Value = cboGenero.SelectedItem.Trim
                cmd.Parameters.Add("@tipo_documento", SqlDbType.VarChar).Value = cboTipoDoc.SelectedItem.Trim
                cmd.Parameters.Add("@num_documento", SqlDbType.VarChar).Value = txtNDoc.Text.Trim
                cmd.Parameters.Add("@direccion", SqlDbType.VarChar).Value = txtDireccion.Text.Trim
                cmd.Parameters.Add("@telefono1", SqlDbType.VarChar).Value = txtTel1.Text.Trim
                cmd.Parameters.Add("@telefono2", SqlDbType.VarChar).Value = txtTel2.Text.Trim
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = txtEmail.Text.Trim

                cmd.Parameters.Add("@fecha_ingreso", SqlDbType.DateTime).Value = Convert.ToDateTime(txtFechaIngreso.Text.Trim)

                cn.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Registrado correctamente", vbInformation, "Registrado")

                metodoTerminado()

            Case 2
                If txtIdCodigo.Text = "" Then
                    MsgBox("Digita el codigo a Buscar")
                Else
                    Dim cn As New SqlConnection("server=(Local); database=SistemaVenta5; integrated security=SSPI")
                    Dim cmd As New SqlCommand

                    cmd.CommandType = CommandType.StoredProcedure 'TipoConexion
                    cmd.CommandText = "PERSONA_CLIENTE_Modificar"
                    cmd.Connection = cn

                    cmd.Parameters.Add("@id_persona", SqlDbType.Int).Value = Convert.ToInt32(txtIdCodigo.Text.Trim)
                    cmd.Parameters.Add("@tipo_persona", SqlDbType.VarChar).Value = cboTipo.Text.Trim
                    cmd.Parameters.Add("@fecha_ingreso", SqlDbType.DateTime).Value = Convert.ToDateTime(txtFechaIngreso.Text.Trim)
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtNombre.Text.Trim
                    cmd.Parameters.Add("@ape_paterno", SqlDbType.VarChar).Value = txtApePaterno.Text.Trim
                    cmd.Parameters.Add("@ape_materno", SqlDbType.VarChar).Value = txtApeMaterno.Text.Trim
                    cmd.Parameters.Add("@genero", SqlDbType.VarChar).Value = cboGenero.Text.Trim
                    cmd.Parameters.Add("@tipo_documento", SqlDbType.VarChar).Value = cboTipoDoc.Text.Trim
                    cmd.Parameters.Add("@num_documento", SqlDbType.VarChar).Value = txtNDoc.Text.Trim
                    cmd.Parameters.Add("@direccion", SqlDbType.VarChar).Value = txtDireccion.Text.Trim
                    cmd.Parameters.Add("@telefono1", SqlDbType.VarChar).Value = txtTel1.Text.Trim
                    cmd.Parameters.Add("@telefono2", SqlDbType.VarChar).Value = txtTel2.Text.Trim
                    cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = txtEmail.Text.Trim

                    cn.Open()

                    cmd.ExecuteNonQuery()
                    MsgBox("Editado correctamente", vbInformation, "Editado")

                    metodoTerminado()

                End If


            Case Else
                MsgBox("No se selecciono nada " & mantenimiento)
        End Select
    End Sub

    Private Sub btnIconEditar_Click(sender As Object, e As EventArgs) Handles btnIconEditar.Click
        mantenimiento = 2
        labEncabezado.Text = "Modo Editar ID: " & txtIdCodigo.Text
        metodoBotonBloquear()
    End Sub

    Private Sub btnIconCancelar_Click(sender As Object, e As EventArgs) Handles btnIconCancelar.Click
        txtFechaIngreso.Text = ""
        metodoTerminado()
    End Sub

    Private Sub btnIconNuevo_Click(sender As Object, e As EventArgs) Handles btnIconNuevo.Click
        mantenimiento = 1
        labEncabezado.Text = "Modo Insertar"
        metodoBotonBloquear()
        txtFechaIngreso.Text = Date.Now

    End Sub
End Class