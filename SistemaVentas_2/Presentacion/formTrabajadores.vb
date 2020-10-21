Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Data

Public Class forTrabajadores
    Dim mantenimiento As Integer
    Dim IMAGEN As String

    Private Sub forTrabajadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvTraListado.DataSource = funcionListadoTrabajadores()
        txtFechaIngreso.Text = Date.Now
        txtFechaIngreso.Enabled = False

    End Sub

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

    Private Sub tabTraListado_Click(sender As Object, e As EventArgs) Handles tabTraListado.Click

    End Sub

    Private Sub tabTraMantenimiento_Click(sender As Object, e As EventArgs) Handles tabTraMantenimiento.Click

    End Sub

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

                dgvTraListado.DataSource = funcionListadoTrabajadores()
                mantenimiento = 0
                metodoBotonDesbloquear()

                Exit Sub
            Case 2
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

                dgvTraListado.DataSource = funcionListadoTrabajadores()
                mantenimiento = 0
                metodoBotonDesbloquear()
                Exit Sub
        End Select

    End Sub

    Private Sub btnIconCancelar_Click(sender As Object, e As EventArgs) Handles btnIconCancelar.Click
        metodoBotonDesbloquear()
        txtFechaIngreso.Text = ""
    End Sub

    Private Sub btnIconBuscar_Click(sender As Object, e As EventArgs) Handles btnIconBuscar.Click
        Dim existencia As Boolean = False
        Dim cn As New SqlConnection("server=(Local); database=SistemaVenta5; integrated security=SSPI")
        Dim cmd As New SqlCommand

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
    End Sub

    Private Sub btnIconLimpiar_Click(sender As Object, e As EventArgs) Handles btnIconLimpiar.Click
        txtApePaterno.Text=""
        txtApeMaterno.Text = ""
        txtNombre.Text = ""
        cboGenero.Text = ""
        cboTipoDoc.Text = ""
        txtNDoc.Text=""
        txtDireccion.Text = ""
        txtTel1.Text = ""
        txtTel2.Text = ""
        txtFechaIngreso.Text = ""
        picImagen.Image = Nothing

        cboRol.Text = ""
        cboEstado.Text = ""
        txtUsuario.Text = ""
        txtClave.Text = ""
    End Sub


    'Metodo que selecciona una imagen y la carga en un PictureBox'
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

                    System.IO.File.Copy(Me.OpenFileDialog1.FileName, "C:\Imagenes\usuario\" & nombrefinal)
                    IMAGEN = "C:\Imagenes\usuario\" & nombrefinal
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
    Private Sub btnAgregarImagen_Click(sender As Object, e As EventArgs) Handles btnAgregarImagen.Click
        cargarImagen()
    End Sub



End Class