Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Data

Public Class forProveedorAgregar
    Dim mantenimiento As String

    Private Sub forProveedorAgregar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtAccion.Visible = False
        txtIdCodigo.Enabled = False
        txtFechaIngreso.Enabled = False
        txtIdCodigo.Visible = False
        labCodigo.Visible = False

    End Sub

    Private Sub btnIconGuardar_Click(sender As Object, e As EventArgs) Handles btnIconGuardar.Click
        Dim cn As New SqlConnection("server=(Local); database=SistemaVenta5; integrated security=SSPI")
        Dim cmd As New SqlCommand
        Select Case txtAccion.Text
            Case 1

            Case 2
                If txtIdCodigo.Text = "" Then
                    MsgBox("Digita el codigo a Buscar")
                Else


                    cmd.CommandType = CommandType.StoredProcedure 'TipoConexion
                    cmd.CommandText = "PERSONA_PROVEEDOR_Modificar"
                    cmd.Connection = cn

                    cmd.Parameters.Add("@id_persona", SqlDbType.Int).Value = Convert.ToInt32(txtIdCodigo.Text.Trim)
                    cmd.Parameters.Add("@tipo_persona", SqlDbType.VarChar).Value = cboTipo.Text.Trim
                    cmd.Parameters.Add("@empresa", SqlDbType.VarChar).Value = txtEmpresaNombre.Text.Trim

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
                    cmd.Parameters.Add("@fecha_ingreso", SqlDbType.DateTime).Value = Convert.ToDateTime(txtFechaIngreso.Text.Trim)


                    cn.Open()

                    cmd.ExecuteNonQuery()
                    MsgBox("Editado correctamente", vbInformation, "Editado")
                    txtIdCodigo.Visible = False
                    labCodigo.Visible = False

                    Dim frm As New forProveedorListado
                    frm.metodoUsuarioTotal()
                    frm.dgvTraListado.DataSource = frm.funcionListadoTrabajadores()

                End If
            Case Else

                txtFechaIngreso.Text = Date.Now()

                cmd.CommandType = CommandType.StoredProcedure 'TipoConexion
                cmd.CommandText = "PERSONA_CLIENTE_Insertar"
                cmd.Connection = cn

                cmd.Parameters.Add("@tipo_persona", SqlDbType.VarChar).Value = cboTipo.SelectedItem.Trim
                cmd.Parameters.Add("@empresa", SqlDbType.VarChar).Value = txtEmpresaNombre.Text
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

                Dim frm As New forProveedorListado
                frm.metodoUsuarioTotal()
                frm.dgvTraListado.DataSource = frm.funcionListadoTrabajadores()
                'metodoTerminado()
        End Select
    End Sub
End Class