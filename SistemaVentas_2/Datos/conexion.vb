Imports System.Data.SqlClient
Public Class conexion
    Public cnn As New SqlConnection

    Public Function metodo_conectar()
        Try
            cnn = New SqlConnection("data source=(local); initial catalog=SistemaVenta5;integrated security=true")
            cnn.Open()
            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function metodo_desconectar()
        Try
            If cnn.State = ConnectionState.Open Then 'Si cadena de conexion
                cnn.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

End Class
