Imports System.Data.Odbc

Public Class ModeloPatologia
    Public Id As Integer
    Public Nombre As String
    Public Ponderacion As Integer
    Public Descripcion As String
    Public activo As Integer
    Public LectorPatologia As OdbcDataReader


    Public Function GuaradrPatologia() As Boolean
        ' guarda nueva patologia

        Return True
    End Function

    Public Function eliminarPatologia(id As Integer)
        'elimina la patologa con el id
        Return True
    End Function

    Private Function validarNombre() As Boolean
        'valida que el nombre no tenga caracteres raros
        Return True
    End Function

    Private Function validarDescripcion() As Boolean
        'valida que la descripcion no tenga codigos raros
        Return True
    End Function

    Private Function validarPonderacion() As Boolean
        'valida que la ponderacion sea numerica
        Return True
    End Function

    Private Function validarEstado() As Boolean
        'valida que el esado true o false
        Return True
    End Function

    Public Function TraeDatosPatologiasDeBD() As DataTable
        'trae de la base de datos las patolgias registadas
        Try
            Dim conexion As New ModeloConexion
            Dim comando As New OdbcCommand
            Dim tabla As New DataTable

            conexion.Abrir()
            comando.CommandText = "SELECT * FROM patologia WHERE activo = 1 "
            comando.Connection = conexion.Abrir()
            LectorPatologia = comando.ExecuteReader()
            tabla.Load(LectorPatologia)
            conexion.Cerrar()
            Return tabla

        Catch ex As Exception
            mostrarExepcion(ex)
        End Try
    End Function

    Public Function TraeDatosPatologiasDeBD(ByVal nombre As String) As DataTable
        'trae de la base de datos las patolgias registadas
        Try
            Dim conexion As New ModeloConexion
            Dim comando As New OdbcCommand
            Dim tabla As New DataTable

            comando.CommandText = "SELECT * FROM patologia WHERE activo = 1 AND nombre like '%" + nombre + "%'"
            comando.Connection = conexion.Abrir()
            LectorPatologia = comando.ExecuteReader()
            tabla.Load(LectorPatologia)
            conexion.Cerrar()
            Return tabla

        Catch ex As Exception
            mostrarExepcion(ex)
        End Try
    End Function

    Public Function BuscarPatologiaPorID(ByVal id As Integer)
        Try
            Dim conexion As New ModeloConexion
            Dim comando As New OdbcCommand

            comando.CommandText = "SELECT * FROM patologia WHERE id = " & id
            comando.Connection = conexion.Abrir()
            LectorPatologia = comando.ExecuteReader()
            Return crearObjetoPatologia(LectorPatologia)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return vbNull
    End Function

    Private Function crearObjetoPatologia(ByRef patologia As OdbcDataReader) As ModeloPatologia
        Dim datosPatologia As New ModeloPatologia
        patologia.Read()
        datosPatologia.Id = patologia(0)
        datosPatologia.Nombre = patologia(1)
        datosPatologia.Ponderacion = patologia(2)
        datosPatologia.Descripcion = patologia(3)
        Return datosPatologia
    End Function

    Private Sub mostrarExepcion(ByVal exeption As Exception)
        MsgBox(exeption.Message)
    End Sub
End Class
