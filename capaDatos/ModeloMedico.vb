﻿Public Class ModeloMedico
    Inherits ModeloPersona

    Public NumeroMedico As String
    Public RangoIpConexion As String = "192.168.1.%"

    Public Sub New(ByVal uid As String, pwd As String)
        MyBase.New(uid, pwd)
    End Sub

    Public Function VerificarDocumentoDeIdentidad(ByVal docidentidad As String)
        'Verifica si la cedula ya esta registrada en persona
        Comando.CommandText = "SELECT docidentidad FROM persona WHERE docidentidad =" & docidentidad
        Return Comando.ExecuteScalar
    End Function

    Public Sub GuardarDatosMedico()
        'Guarda la informacion del medico nueva o actualiza
        Try
            Comando.CommandText = "SET AUTOCOMMIT = OFF;"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "START TRANSACTION;"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "LOCK TABLE persona WRITE, medico WRITE, telefono WRITE"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "INSERT INTO persona (docidentidad, mail, nombres, apellidos, calle, numero, barrio, esquina, apartamento, fechaNacimiento, activo) 
                                        VALUES(" & Me.Documento & ", '" & Me.Email & "', '" & Me.Nombres & "', '" & Me.Apellidos & "','" & Me.Calle & "', '" & Me.Numero & "', 
                                                '" & Me.Barrio & "', '" & Me.Esquina & "', '" & Me.Apartamento & "', '" & Me.FechaNacimiento & "', activo =1) 
                                        ON DUPLICATE KEY UPDATE 
                                                mail='" & Me.Email & "', nombres='" & Me.Nombres & "', apellidos='" & Me.Apellidos & "', calle ='" & Me.Calle & "', numero='" & Me.Numero & "',
                                                barrio='" & Me.Barrio & "', esquina='" & Me.Esquina & "', apartamento='" & Me.Apartamento & "', fechaNacimiento='" & Me.FechaNacimiento & "', activo =" & Me.Activo
            Comando.ExecuteNonQuery()

            Comando.CommandText = "INSERT INTO medico VALUES(" & Me.Documento & ", " & Me.NumeroMedico & ") 
                                ON DUPLICATE KEY UPDATE ndemedico=" & Me.NumeroMedico
            Comando.ExecuteNonQuery()

            Comando.CommandText = "DELETE FROM telefono WHERE docidentidad=" & Me.Documento
            Comando.ExecuteNonQuery()

            For Each Telefono In Me.Telefonos.Rows
                If Telefono("Telefono").ToString.Length > 1 Then
                    Comando.CommandText = "INSERT INTO telefono VALUES(" & Me.Documento & ", '" & Telefono("Telefono").ToString & "')"
                    Comando.ExecuteNonQuery()
                End If
            Next

            Comando.CommandText = "UNLOCK TABLES"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "COMMIT;"
            Comando.ExecuteNonQuery()

        Catch ex As Exception
            Comando.CommandText = "ROLLBACK;"
            Comando.ExecuteNonQuery()
        End Try
    End Sub

    Public Sub CrearUsuarioBD()
        'Crea el usuario para la base de datos
        Dim medicoPass As String = "Me." & Me.Documento
        Try
            Comando.CommandText = "CREATE USER '" & Me.Documento & "'@'" & Me.RangoIpConexion & "' IDENTIFIED BY '" & medicoPass & "'"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "GRANT SELECT ON dbTriage.persona TO '" & Me.Documento & "'@'" & RangoIpConexion & "'"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "GRANT SELECT ON dbTriage.paciente TO '" & Me.Documento & "'@'" & RangoIpConexion & "'"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "GRANT SELECT ON dbTriage.preexistentes TO '" & Me.Documento & "'@'" & RangoIpConexion & "'"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "GRANT SELECT, UPDATE ON dbTriage.sesion TO '" & Me.Documento & "'@'" & RangoIpConexion & "'"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "GRANT SELECT ON dbTriage.sintoma TO '" & Me.Documento & "'@'" & RangoIpConexion & "'"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "GRANT SELECT, INSERT, UPDATE ON dbTriage.chat TO '" & Me.Documento & "'@'" & RangoIpConexion & "'"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "GRANT SELECT ON dbTriage.recibe TO '" & Me.Documento & "'@'" & RangoIpConexion & "'"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "GRANT SELECT ON dbTriage.tiene TO '" & Me.Documento & "'@'" & RangoIpConexion & "'"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "GRANT SELECT ON dbTriage.medico TO '" & Me.Documento & "'@'" & RangoIpConexion & "'"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "GRANT SELECT ON dbTriage.telefono TO '" & Me.Documento & "'@'" & RangoIpConexion & "'"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "FLUSH PRIVILEGES"
            Comando.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("No se pudo crear el usuario", vbCritical, "Error de Usuario")
        End Try
    End Sub

    Public Function BuscarMedico(ByVal stringSql As String)
        'Busca un medico por los datos ingresados por el gestor
        Dim tablaMedicos As New DataTable
        Comando.CommandText = "SELECT m.docidentidad DOCUMENTO, p.mail EMAIL, p.nombres NOMBRES, p.apellidos APELLIDOS, 
                                p.fechaRegistro FECHREG, m.ndemedico NMEDICO, p.activo ACTIVO 
                                FROM medico m 
                                JOIN persona p ON p.docidentidad = m.docidentidad WHERE " & stringSql
        Reader = Comando.ExecuteReader
        tablaMedicos.Load(Reader)
        CerrarConexion()
        Return tablaMedicos
    End Function

    Public Function EliminarMedico(ByVal docidentidad As String)
        'Elimina logicamente el registro de el medico
        Comando.CommandText = "UPDATE persona SET activo = 0 WHERE docidentidad =" & docidentidad
        Comando.ExecuteNonQuery()
        CerrarConexion()
        Return True
    End Function

    Public Function buscarMedicoPorDocumento(ByVal docIdentidad As String)
        'Busca la informacion del medico por docuemento de identidad
        Dim tablaDatos As New DataTable
        Comando.CommandText = "SELECT m.docidentidad as documento, p.mail as mail, p.nombres as nombres, p.apellidos as apellidos, p.calle as calle, p.numero as numero, p.barrio as barrio, 
                                p.esquina as esquina, p.apartamento as apto, p.fechaNacimiento as fechaNac, p.activo as activo, p.fechaRegistro as fechReg, m.ndemedico as nmedico, t.telefono as telefono 
                                FROM medico m 
                                INNER JOIN persona p ON p.docidentidad = m.docidentidad 
                                LEFT JOIN telefono t ON t.docidentidad = m.docidentidad
                                WHERE m.docidentidad =" & docIdentidad
        Reader = Comando.ExecuteReader
        tablaDatos.Load(Reader)
        CerrarConexion()
        Return tablaDatos
    End Function

    Public Sub EliminarUsuarioBD(ByVal docidentidad As String)
        'Elimina el usuario de la base de datos
        Comando.CommandText = "DROP '" & Me.Documento & "' FROM mysql.user"
        Comando.ExecuteNonQuery()
        CerrarConexion()
    End Sub

    Public Function ListarMedicos()
        'Lista todos los medicos en la base de datos
        Dim tablaMedicos As New DataTable
        Comando.CommandText = "SELECT m.docidentidad, m.ndemedico, p.nombres, p.apellidos, p.mail, p.activo, p.fechaRegistro 
                                FROM medico m 
                                JOIN persona p 
                                ON p.docidentidad = m.docidentidad"
        Reader = Comando.ExecuteReader
        tablaMedicos.Load(Reader)
        CerrarConexion()
        Return tablaMedicos
    End Function

    Public Function ListarMedicos(ByVal activo As String)
        'Lista solos los medicos por estado
        Dim tablaMedicos As New DataTable
        Comando.CommandText = "SELECT m.docidentidad, m.ndemedico, p.nombres, p.apellidos, p.mail, p.activo, p.fechaRegistro 
                                FROM medico m 
                                JOIN persona p 
                                ON p.docidentidad = m.docidentidad 
                                WHERE p.activo =" & activo
        Reader = Comando.ExecuteReader
        tablaMedicos.Load(Reader)
        CerrarConexion()
        Return tablaMedicos
    End Function

    Public Function ListarTelefonos(ByVal docidentidad As String)
        'Lista los telefonos del medico
        Dim tablaTelefonos As New DataTable
        Comando.CommandText = "SELECT telefono FROM telefono WHERE docidentidad =" & docidentidad
        Reader = Comando.ExecuteReader
        tablaTelefonos.Load(Reader)
        CerrarConexion()
        Return tablaTelefonos
    End Function

End Class
