Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Data

Public Class forTrabajadores
    Dim mantenimiento As Integer
    Dim IMAGEN As String
    Dim imagenDefecto As String

    'FORMULARIO GENERAL
    Private Sub forTrabajadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        metodoUsuarioTotal()
        dgvTraListado.DataSource = funcionListadoTrabajadores()
        txtFechaIngreso.Text = Date.Now
        txtFechaIngreso.Enabled = False
        imagenDefecto = ".\Imagenes\usuario\foto_defecto.jpg"
        IMAGEN = imagenDefecto
        picImagen.Load(imagenDefecto)

    End Sub

    'TAB
    Private Sub tabTraListado_Click(sender As Object, e As EventArgs) Handles tabTraListado.Click

    End Sub
    Private Sub tabTraMantenimiento_Click(sender As Object, e As EventArgs) Handles tabTraMantenimiento.Click

    End Sub

    'FUNCIONES
    Private Function funcionListadoTrabajadores() As DataTable
        Dim dtTrabajadores As New DataTable

        Dim cn As New SqlConnection("server=(Local); database=SistemaVenta5; integrated security=SSPI")
        Dim cmd As New SqlCommand

        cmd.CommandType = CommandType.StoredProcedure 'TipoConexion
        cmd.CommandText = "USUARIO_Mostrar_Todo" '
        cmd.Connection = cn

        cn.Open()

        Dim dr As SqlDataReader 'ejecutar sql
        dr = cmd.ExecuteReader 'almacena la tabla en memoria

        dtTrabajadores.Load(dr)

        Return dtTrabajadores
    End Function

    'METODOS
    Public Sub metodoUsuarioTotal()
        Dim cn As New SqlConnection("server=(Local); database=SistemaVenta5; integrated security=SSPI")
        Dim cmd As New SqlCommand

        cmd.CommandType = CommandType.StoredProcedure 'TipoConexion
        cmd.CommandText = "USUARIO_Total_Usuarios"
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
    Public Sub metodoTerminado()
        mantenimiento = 0
        metodoBotonDesbloquear()
        labEncabezado.Text = ""
        dgvTraListado.DataSource = funcionListadoTrabajadores()
        metodoUsuarioTotal()
    End Sub
    Sub cargarImagen()
        Try

            Me.OpenFileDialog1.Title = "Seleccione Imagen"
            Me.OpenFileDialog1.Filter = "JPG|*.jpg;*.jpeg|PNG|*.png|GIF|*.gif|PDF|*.pdf"

            If Me.OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim extension As String = System.IO.Path.GetExtension(Me.OpenFileDialog1.FileName)
                If extension = ".jpg" Or extension = ".png" Or extension = ".gif" Then

                    Dim nombreOriginal As String = System.IO.Path.GetFileName(Me.OpenFileDialog1.FileName)
                    Dim fecha As String = Date.Today()
                    fecha = fecha.Replace("/", "_")
                    Dim aleatorio As Integer = CInt(Int((99999 * Rnd()) + 1))
                    Dim nombrefinal As String = aleatorio & "_" & fecha & "_" & nombreOriginal

                    IMAGEN = ".\Imagenes\usuario\" & nombrefinal
                    System.IO.File.Copy(Me.OpenFileDialog1.FileName, IMAGEN)

                    MsgBox(IMAGEN)
                    picImagen.Load(IMAGEN)
                Else
                    MsgBox("El formato es incorrecto")
                End If
            Else
                MsgBox("No soleccione nada")
            End If

        Catch ex As Exception
        End Try

    End Sub

    'BOTONES
    Private Sub btnIconNuevo_Click(sender As Object, e As EventArgs) Handles btnIconNuevo.Click
        mantenimiento = 1
        labEncabezado.Text = "Modo Insertar"
        metodoBotonBloquear()
        txtFechaIngreso.Text = Date.Now

    End Sub

    Private Sub btnIconEditar_Click(sender As Object, e As EventArgs) Handles btnIconEditar.Click
        mantenimiento = 2
        labEncabezado.Text = "Modo Editar"
        metodoBotonBloquear()
    End Sub

    Private Sub btnIconGuardar_Click(sender As Object, e As EventArgs) Handles btnIconGuardar.Click
        Select Case mantenimiento
            Case 1

                Dim cn As New SqlConnection("server=(Local); database=SistemaVenta5; integrated security=SSPI")
                Dim cmd As New SqlCommand

                cmd.CommandType = CommandType.StoredProcedure 'TipoConexion
                cmd.CommandText = "USUARIO_Insertar"
                cmd.Connection = cn

                cmd.Parameters.Add("@ape_paterno", SqlDbType.VarChar).Value = txtApePaterno.Text.Trim
                cmd.Parameters.Add("@ape_materno", SqlDbType.VarChar).Value = txtApeMaterno.Text.Trim
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtNombre.Text.Trim
                cmd.Parameters.Add("@genero", SqlDbType.VarChar).Value = cboGenero.SelectedItem.Trim
                cmd.Parameters.Add("@tipo_documento", SqlDbType.VarChar).Value = cboTipoDoc.SelectedItem.Trim
                cmd.Parameters.Add("@num_documento", SqlDbType.VarChar).Value = txtNDoc.Text.Trim
                cmd.Parameters.Add("@direccion", SqlDbType.VarChar).Value = txtDireccion.Text.Trim
                cmd.Parameters.Add("@telefono1", SqlDbType.VarChar).Value = txtTel1.Text.Trim
                cmd.Parameters.Add("@telefono2", SqlDbType.VarChar).Value = txtTel2.Text.Trim
                cmd.Parameters.Add("@fecha_ingreso", SqlDbType.DateTime).Value = Convert.ToDateTime(txtFechaIngreso.Text.Trim)


                cmd.Parameters.Add("@imagen", SqlDbType.VarChar).Value = IMAGEN


                Select Case cboEstado.SelectedItem.Trim
                    Case "Activado"
                        cmd.Parameters.Add("@estado", SqlDbType.Bit).Value = 1
                    Case "Desactivado"
                        cmd.Parameters.Add("@estado", SqlDbType.Bit).Value = 0
                End Select

                Select Case cboRol.SelectedItem
                    Case "Administrador"
                        cmd.Parameters.Add("@id_rol", SqlDbType.Int).Value = 1
                    Case "Cajero"
                        cmd.Parameters.Add("@id_rol", SqlDbType.Int).Value = 2
                End Select
                cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = txtUsuario.Text.Trim
                cmd.Parameters.Add("@clave", SqlDbType.VarChar).Value = txtClave.Text.Trim

                cn.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Registrado correctamente", vbInformation, "Registrado")

                metodoTerminado()
                Exit Sub
            Case 2

                If txtIdCodigo.Text = "" Then
                    MsgBox("Falta ingresar Codigo a Modificar")
                Else
                    Dim cn As New SqlConnection("server=(Local); database=SistemaVenta5; integrated security=SSPI")
                    Dim cmd As New SqlCommand

                    cmd.CommandType = CommandType.StoredProcedure 'TipoConexion
                    cmd.CommandText = "USUARIO_Modificar"
                    cmd.Connection = cn

                    cmd.Parameters.Add("@id_usuario", SqlDbType.Int).Value = Convert.ToInt32(txtIdCodigo.Text.Trim)

                    cmd.Parameters.Add("@ape_paterno", SqlDbType.VarChar).Value = txtApePaterno.Text.Trim
                    cmd.Parameters.Add("@ape_materno", SqlDbType.VarChar).Value = txtApeMaterno.Text.Trim
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtNombre.Text.Trim
                    cmd.Parameters.Add("@genero", SqlDbType.VarChar).Value = cboGenero.SelectedItem.Trim
                    cmd.Parameters.Add("@tipo_documento", SqlDbType.VarChar).Value = cboTipoDoc.SelectedItem.Trim
                    cmd.Parameters.Add("@num_documento", SqlDbType.VarChar).Value = txtNDoc.Text.Trim
                    cmd.Parameters.Add("@direccion", SqlDbType.VarChar).Value = txtDireccion.Text.Trim
                    cmd.Parameters.Add("@telefono1", SqlDbType.VarChar).Value = txtTel1.Text.Trim
                    cmd.Parameters.Add("@telefono2", SqlDbType.VarChar).Value = txtTel2.Text.Trim
                    cmd.Parameters.Add("@fecha_ingreso", SqlDbType.DateTime).Value = Convert.ToDateTime(txtFechaIngreso.Text.Trim)

                    cmd.Parameters.Add("@imagen", SqlDbType.VarChar).Value = IMAGEN


                    Select Case cboEstado.SelectedItem.Trim
                        Case "Activado"
                            cmd.Parameters.Add("@estado", SqlDbType.Bit).Value = 1
                        Case "Desactivado"
                            cmd.Parameters.Add("@estado", SqlDbType.Bit).Value = 0
                    End Select

                    Select Case cboRol.SelectedItem
                        Case "Administrador"
                            cmd.Parameters.Add("@id_rol", SqlDbType.Int).Value = 1
                        Case "Cajero"
                            cmd.Parameters.Add("@id_rol", SqlDbType.Int).Value = 2
                    End Select
                    cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = txtUsuario.Text.Trim
                    cmd.Parameters.Add("@clave", SqlDbType.VarChar).Value = txtClave.Text.Trim

                    cn.Open()

                    cmd.ExecuteNonQuery()
                    MsgBox("Editado correctamente", vbInformation, "Editado")

                    metodoTerminado()
                    Exit Sub
                End If

        End Select

    End Sub

    Private Sub btnIconCancelar_Click(sender As Object, e As EventArgs) Handles btnIconCancelar.Click
        txtFechaIngreso.Text = ""
        metodoTerminado()

    End Sub

    Private Sub btnIconBuscar_Click(sender As Object, e As EventArgs) Handles btnIconBuscar.Click
        Dim existencia As Boolean = False
        Dim cn As New SqlConnection("server=(Local); database=SistemaVenta5; integrated security=SSPI")
        Dim cmd As New SqlCommand


        If txtIdCodigo.Text = "" Then
            MsgBox("Digita el codigo a Buscar")
        Else
            cmd.CommandType = CommandType.StoredProcedure 'TipoConexion
            cmd.CommandText = "USUARIO_Buscar"
            cmd.Connection = cn
            cmd.Parameters.Add("@id_usuario", SqlDbType.Int).Value = Convert.ToInt32(txtIdCodigo.Text.Trim)
            cn.Open()

            Dim Dr As SqlDataReader
            Dr = cmd.ExecuteReader

            If Dr.Read() Then
                existencia = True
                txtApePaterno.Text = Dr(3)
                txtApeMaterno.Text = Dr(4)
                txtNombre.Text = Dr(2)
                cboGenero.Text = Dr(5)
                cboTipoDoc.Text = Dr(6)
                txtNDoc.Text = Dr(7)
                txtDireccion.Text = Dr(9)
                txtTel1.Text = Dr(10)
                txtTel2.Text = Dr(11)
                txtFechaIngreso.Text = Dr(8)
                If Dr(14) = "" Then
                Else
                    picImagen.Load(Dr(14))
                End If

                cboRol.Text = Dr(17)
                If Dr(15) = "TRUE" Then
                    cboEstado.Text = "Activado"
                Else
                    cboEstado.Text = "Desactivado"
                End If

                txtUsuario.Text = Dr(12)
                txtClave.Text = Dr(13)


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

    Private Sub btnIconLimpiar_Click(sender As Object, e As EventArgs) Handles btnIconLimpiar.Click
        metodoTerminado()

        txtIdCodigo.Text = ""
        txtApePaterno.Text = ""
        txtApeMaterno.Text = ""
        txtNombre.Text = ""
        cboGenero.Text = ""
        cboTipoDoc.Text = ""
        txtNDoc.Text = ""
        txtDireccion.Text = ""
        txtTel1.Text = ""
        txtTel2.Text = ""
        txtFechaIngreso.Text = ""
        'picImagen.Image = Nothing
        picImagen.Load(imagenDefecto)
        IMAGEN = imagenDefecto

        cboRol.Text = ""
        cboEstado.Text = ""
        txtUsuario.Text = ""
        txtClave.Text = ""
    End Sub
    'Metodo que selecciona una imagen y la carga en un PictureBox'
    Private Sub btnAgregarImagen_Click(sender As Object, e As EventArgs) Handles btnAgregarImagen.Click
        cargarImagen()
    End Sub


    Private Sub dgvTraListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTraListado.CellContentClick

    End Sub

    Public Function funcionBuscarTabla()
        Dim dtTrabajadores As New DataTable

        Dim cn As New SqlConnection("server=(Local); database=SistemaVenta5; integrated security=SSPI")
        Dim cmd As New SqlCommand

        cmd.CommandType = CommandType.StoredProcedure 'TipoConexion
        cmd.CommandText = "USUARIO_Buscar_Tabla" '
        cmd.Connection = cn

        cmd.Parameters.Add("@ape_materno", SqlDbType.VarChar).Value = txtTraBuscar.Text.Trim

        cn.Open()

        Dim dr As SqlDataReader 'ejecutar sql
        dr = cmd.ExecuteReader 'almacena la tabla en memoria

        dtTrabajadores.Load(dr)
        Return dtTrabajadores
    End Function

    Private Sub txtTraBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTraBuscar.KeyPress

        Dim cn As New SqlConnection("server=(Local); database=SistemaVenta5; integrated security=SSPI")
        Dim cmd As New SqlCommand

        'MsgBox("Comienza")
        cmd.CommandType = CommandType.StoredProcedure 'TipoConexion
        cmd.CommandText = "USUARIO_Buscar_Tabla" '
        cmd.Connection = cn

        cmd.Parameters.Add("@ape_materno", SqlDbType.VarChar).Value = txtTraBuscar.Text.Trim
        'MsgBox("Letra: " & txtTraBuscar.Text)
        cn.Open()

        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader 'almacena la tabla en memoria
        'MsgBox("Ejecutado el procedimiento")

        Dim dt = New DataTable


        dt.Load(dr)
        'MsgBox("Datos cargados " & dt.ToString)
        dgvTraListado.DataSource = dt
        'MsgBox("Eniando al DGW")

        'dgvTraListado.DataSource = funcionBuscarTabla()

    End Sub

    Private Sub dgvTraListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTraListado.CellDoubleClick
        txtApePaterno.Text = dgvTraListado.CurrentRow.Cells(5).Value.ToString()
        txtApeMaterno.Text = dgvTraListado.CurrentRow.Cells(6).Value.ToString()
        txtNombre.Text = dgvTraListado.CurrentRow.Cells(4).Value.ToString()
        cboGenero.Text = dgvTraListado.CurrentRow.Cells(7).Value.ToString()
        cboTipoDoc.Text = dgvTraListado.CurrentRow.Cells(8).Value.ToString()
        txtNDoc.Text = dgvTraListado.CurrentRow.Cells(9).Value.ToString()
        txtDireccion.Text = dgvTraListado.CurrentRow.Cells(11).Value.ToString()
        txtTel1.Text = dgvTraListado.CurrentRow.Cells(12).Value.ToString()
        txtTel2.Text = dgvTraListado.CurrentRow.Cells(13).Value.ToString()
        txtFechaIngreso.Text = dgvTraListado.CurrentRow.Cells(10).Value.ToString()
        picImagen.Load(dgvTraListado.CurrentRow.Cells(16).Value.ToString())

        cboRol.Text = dgvTraListado.CurrentRow.Cells(2).Value.ToString()
        'cboEstado.Text = dgvTraListado.CurrentRow.Cells(1).Value.ToString()
        txtUsuario.Text = dgvTraListado.CurrentRow.Cells(14).Value.ToString()
        txtClave.Text = dgvTraListado.CurrentRow.Cells(15).Value.ToString()


        Select Case dgvTraListado.CurrentRow.Cells(1).Value.ToString()
            Case "True"
                cboEstado.Text = "Activado"
            Case "False"
                cboEstado.Text = "Desactivado"
        End Select


        tabTrabajadores.SelectTab(1)

    End Sub
End Class