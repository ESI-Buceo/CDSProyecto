﻿Imports System.Data
Imports System.Windows.Forms
Imports capaDatos
Public Module ControladorMedico

    Public Function identificarMedico(ByVal uid As String, pwd As String)
        Dim m As New ModeloMedico(uid, pwd)
        Return m.buscarMedicoPorDocumento(uid)
    End Function

    Public Function VarificarDocumentoDeIdentidad(ByVal docidentidad As String, uid As String, pwd As String)
        'Valida si el documento ya existe en la bd
        Dim a As New ModeloMedico(uid, pwd)
        Return a.VerificarDocumentoDeIdentidad(docidentidad)
    End Function

    Public Sub GuardarDatosMedico(ByVal docId As String, email As String, nombres As String, apellidos As String, calle As String,
                                  numero As String, barrio As String, esquina As String, apto As String, fechaNac As String,
                                  activo As String, telefonos As DataGridView, numeroMedico As String, uid As String, pwd As String)
        'Guarda los datos del medico
        Dim m As New ModeloMedico(uid, pwd)
        m.Documento = docId
        m.Email = email
        m.Nombres = nombres
        m.Apellidos = apellidos
        m.Calle = calle
        m.Numero = numero
        m.Barrio = barrio
        m.Esquina = esquina
        m.Apartamento = apto
        m.FechaNacimiento = fechaNac
        m.NumeroMedico = numeroMedico
        m.Activo = activo
        m.Telefonos = cargarGridTelefonosADataTable(telefonos)
        m.GuardarDatosMedico()
    End Sub

    Public Sub crearUsuarioBD(ByVal docidentidad As String, uid As String, pwd As String)
        'Crea el usuario en la base de datos
        Dim m As New ModeloMedico(uid, pwd)
        m.Documento = docidentidad
        m.CrearUsuarioBD()
    End Sub

    Private Function cargarGridTelefonosADataTable(ByVal telefonos As DataGridView) As DataTable
        'Carga la lista de telefonos
        Dim listaTelefonos As New DataTable
        listaTelefonos = TryCast(telefonos.DataSource, DataTable)
        Return listaTelefonos
    End Function

    Public Function EliminiarMedico(ByVal docIdentidad As String, uid As String, pwd As String)
        'Elimina logicamente a un medico
        Dim m As New ModeloMedico(uid, pwd)
        Return m.EliminarMedico(docIdentidad)
    End Function

    Public Sub eliminiarUsuarioBD(ByVal docidentidad As String, uid As String, pwd As String)
        Dim m As New ModeloMedico(uid, pwd)
        m.EliminarUsuarioBD(docidentidad)
    End Sub

    Public Function buscarMedicoPorDocumento(ByVal docIdentidad As String, uid As String, pwd As String)
        'Busca medico por documento
        Dim m As New ModeloMedico(uid, pwd)
        Return m.buscarMedicoPorDocumento(docIdentidad)
    End Function

    Public Function crearTablaTelefonos()
        'Crea la tabla que alimenta el datagrid de telefonos
        Dim tablaTel As New DataTable
        tablaTel.Columns.Add("Telefono")
        Return tablaTel
    End Function

    Public Function crearCadenaDeBusquedaMedico(ByVal campoABuscar As String, datoABuscar As String)
        'Crea la cadena de consulta de acuerdo a los datos ingresados para ello
        Select Case campoABuscar
            Case "txtDocIdentidad" : Return "p.docidentidad=" & datoABuscar
            Case "txtNumMedico" : Return "m.ndemedico=" & datoABuscar
            Case "txtNombres" : Return "p.nombres LIKE '%" & datoABuscar & "%'"
            Case "txtApellidos" : Return "p.apellidos LIKE '%" & datoABuscar & "%'"
        End Select
        Return ""
    End Function

    Public Function buscarMedico(ByVal cadenaSql As String, uid As String, pwd As String)
        'Busca los medicos que coinciden con los criterios de busqueda
        Dim m As New ModeloMedico(uid, pwd)
        Return m.BuscarMedico(formatearSqlBuscquedaMedico(cadenaSql))
    End Function

    Private Function formatearSqlBuscquedaMedico(ByVal datoString As String)
        'Elimina el ultimo and de la consulta
        If datoString IsNot Nothing Then
            Return datoString.Remove(datoString.Length - 4, 4)
        End If
        Return "p.nombres like '%%'"
    End Function

    Public Function ListarMedicos(ByVal uid As String, pwd As String)
        'Lista todos los medicos registrados
        Dim m As New ModeloMedico(uid, pwd)
        Return m.ListarMedicos()
    End Function

    Public Function ListarMedicos(ByVal activo As String, uid As String, pwd As String)
        'Listado de medicos por estado
        Dim m As New ModeloMedico(uid, pwd)
        Return m.ListarMedicos(activo)
    End Function

    Public Function ListarTelefonos(ByVal docidentidad As String, uid As String, pwd As String)
        'Lista los telefonos de un medico
        Dim m As New ModeloMedico(uid, pwd)
        Return m.ListarTelefonos(docidentidad)
    End Function


End Module
