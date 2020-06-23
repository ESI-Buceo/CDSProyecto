Imports System.Data.Odbc
Public Class ModeloSintoma
    Inherits ModeloConexion

    Public ID As Integer
    Public Nombre As String
    Public Estado As Boolean


    Public Sub GuardarSintoma()
        Comando.CommandText = "INSERT INTO sintoma (id,nombre, activo) VALUES ( " & Me.ID & " ,'" & Me.Nombre & "', " & Me.Estado & " ) ON DUPLICATE KEY UPDATE nombre ='" & Me.Nombre & "', activo= " & Me.Estado
        Comando.ExecuteNonQuery()
    End Sub

    Public Sub BorrarSintoma()
        ' eliminiacion logica de sintoma
        Comando.CommandText = "DELETE FROM sintoma  WHERE Id = " & Me.ID & " "
        Comando.ExecuteNonQuery()
    End Sub

    Public Function TraeDatosSintomasDeBD() As DataTable
        Dim tabla As New DataTable
        Comando.CommandText = "Select * FROM sintoma WHERE activo = 1 "
        Reader = Comando.ExecuteReader()
        tabla.Load(Reader)
        CerrarConexion()
        Return tabla
    End Function

    Public Function TraeDatosSintomasDeBD(sintoma As String) As DataTable
        Dim tabla As New DataTable
        Comando.CommandText = "Select * FROM sintoma WHERE activo = 1 And nombre Like '%" + sintoma + "%'"
        Reader = Comando.ExecuteReader()
        tabla.Load(Reader)
        CerrarConexion()
        Return tabla
    End Function

    Public Function ListarSintomasXPatologia(ByVal idPatologia As String) As DataTable
        ' lista los sintomas vinculados a una patologia
        Dim tabla As New DataTable
        Comando.CommandText = "SELECT a.idSintoma, s.nombre FROM asociados a JOIN sintoma s ON s.id = a.idSintoma WHERE a.idPatologia=" & idPatologia
        Reader = Comando.ExecuteReader()
        tabla.Load(Reader)
        CerrarConexion()
        Return tabla
    End Function

End Class
