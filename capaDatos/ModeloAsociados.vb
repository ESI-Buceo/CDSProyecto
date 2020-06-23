Imports System.Data.Odbc

Public Class ModeloAsociados
    Inherits ModeloConexion

    Public IdPatologia As Integer
    Public IdSintoma As Integer
    Public IdSigno As Integer
    Public Incluida As Boolean

    Public Function CargarListaAsociadosBD()
        'carga la lista de la tabla asociados donde se vinculan patologias, sintomas y signos
        Dim tabla As New DataTable
        Comando.CommandText = "SELECT DISTINCT(a.idPatologia), a.idPatologia, a.idSintoma, a.idSigno FROM asociados a JOIN patologia p ON p.activo = 1"
        Reader = Comando.ExecuteReader()
        tabla.Load(Reader)
        CerrarConexion()
        Return tabla
    End Function


End Class
