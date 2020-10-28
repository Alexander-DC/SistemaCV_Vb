Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Data
Public Class forProveedorListado
    Private Sub forProveedorListado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        metodoUsuarioTotal()
        dgvTraListado.DataSource = funcionListadoTrabajadores()
        cboProBuscador.Text = "Codigo"
    End Sub

    Public Sub metodoUsuarioTotal()
        Dim cn As New SqlConnection("server=(Local); database=SistemaVenta5; integrated security=SSPI")
        Dim cmd As New SqlCommand

        cmd.CommandType = CommandType.StoredProcedure 'TipoConexion
        cmd.CommandText = "PERSONA_PROVEEDOR_Total_Proveedores"
        cmd.Connection = cn

        cn.Open()
        Dim Dr As SqlDataReader
        Dr = cmd.ExecuteReader

        If Dr.Read() Then
            lblUsuarioTotal.Text = "Total de Proveedores: " & Dr(0)
        End If
        Dr.Close()
        cn.Close()

    End Sub
    Public Function funcionListadoTrabajadores() As DataTable
        Dim dtTrabajadores As New DataTable

        Dim cn As New SqlConnection("server=(Local); database=SistemaVenta5; integrated security=SSPI")
        Dim cmd As New SqlCommand

        cmd.CommandType = CommandType.StoredProcedure 'TipoConexion
        cmd.CommandText = "PERSONA_PROVEEDOR_Mostrar_Todo" '
        cmd.Connection = cn

        cn.Open()

        Dim dr As SqlDataReader 'ejecutar sql
        dr = cmd.ExecuteReader 'almacena la tabla en memoria

        dtTrabajadores.Load(dr)
        cn.Close()
        Return dtTrabajadores
    End Function
    Private Sub txtTraBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTraBuscar.KeyPress

        Dim cn As New SqlConnection("server=(Local); database=SistemaVenta5; integrated security=SSPI")
        Dim cmd As New SqlCommand
        Dim prodedimiento As String
        Dim variableBusqueda As String

        If cboProBuscador.Text = "" Then
            MsgBox("Seleccione un parametro por buscar")
        Else
            Select Case cboProBuscador.SelectedItem.ToString
                Case "Codigo"
                    prodedimiento = "PERSONA_PROVEEDOR_Buscar_Codigo"
                    variableBusqueda = "@id_persona"
                Case "Numero de Doc"
                    prodedimiento = "PERSONA_PROVEEDOR_Buscar_Documento"
                    variableBusqueda = "@num_documento"
                Case "Apellidos"
                    prodedimiento = "PERSONA_PROVEEDOR_Buscar_Datos"
                    variableBusqueda = "@ape_materno"
                Case Else
                    MsgBox("No selecciono nada")
            End Select

            cmd.CommandType = CommandType.StoredProcedure 'TipoConexion
            cmd.CommandText = prodedimiento '
            cmd.Connection = cn

            cmd.Parameters.Add(variableBusqueda, SqlDbType.VarChar).Value = txtTraBuscar.Text.Trim
            cn.Open()

            Try
                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader

                Dim dt = New DataTable

                dt.Load(dr)
                dgvTraListado.DataSource = dt
                cn.Close()
            Catch ex As Exception

            End Try
            If txtTraBuscar.Text = "" Then
                dgvTraListado.DataSource = funcionListadoTrabajadores()
                Exit Sub
            End If

        End If

    End Sub

    Private Sub btnIconEditar_Click(sender As Object, e As EventArgs) Handles btnIconEditar.Click

        Dim frm As New forProveedorAgregar
        frm.txtAccion.Text = 2
        frm.txtIdCodigo.Visible = True
        frm.labCodigo.Visible = True

        frm.txtIdCodigo.Text = dgvTraListado.CurrentRow.Cells(0).Value.ToString
        frm.cboTipo.Text = dgvTraListado.CurrentRow.Cells(1).Value.ToString
        frm.txtEmpresaNombre.Text = dgvTraListado.CurrentRow.Cells(2).Value.ToString
        frm.txtNombre.Text = dgvTraListado.CurrentRow.Cells(3).Value.ToString
        frm.txtApePaterno.Text = dgvTraListado.CurrentRow.Cells(4).Value.ToString
        frm.txtApeMaterno.Text = dgvTraListado.CurrentRow.Cells(5).Value.ToString
        frm.cboGenero.Text = dgvTraListado.CurrentRow.Cells(6).Value.ToString
        frm.cboTipoDoc.Text = dgvTraListado.CurrentRow.Cells(7).Value.ToString
        frm.txtNDoc.Text = dgvTraListado.CurrentRow.Cells(8).Value.ToString
        frm.txtDireccion.Text = dgvTraListado.CurrentRow.Cells(9).Value.ToString
        frm.txtTel1.Text = dgvTraListado.CurrentRow.Cells(10).Value.ToString
        frm.txtTel2.Text = dgvTraListado.CurrentRow.Cells(11).Value.ToString
        frm.txtEmail.Text = dgvTraListado.CurrentRow.Cells(12).Value.ToString
        frm.txtFechaIngreso.Text = dgvTraListado.CurrentRow.Cells(13).Value.ToString

        frm.labEncabezado.Text = "Modificar Proveedor"
        frm.ShowDialog()

    End Sub

    Private Sub btnIconNuevo_Click(sender As Object, e As EventArgs) Handles btnIconNuevo.Click
        Dim frm As New forProveedorAgregar
        frm.ShowDialog()
    End Sub

    Private Sub btnIconActualizar_Click(sender As Object, e As EventArgs) Handles btnIconActualizar.Click
        metodoUsuarioTotal()
        dgvTraListado.DataSource = funcionListadoTrabajadores()
    End Sub
End Class