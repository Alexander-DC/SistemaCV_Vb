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
    Private Function funcionListadoTrabajadores() As DataTable
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
End Class