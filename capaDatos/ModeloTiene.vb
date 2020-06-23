Imports System.Data.Odbc

Public Class ModeloTiene
    Inherits ModeloConexion

    Public IdDiagnostico As String
    Public IdPatologia As String

    Public Function GuardarRelacionDiagnosticoPatologia()
        Comando.CommandText = "INSERT INTO tiene VALUES(" & Me.IdDiagnostico & ", " & Me.IdPatologia & ")"
        Comando.ExecuteNonQuery()
        CerrarConexion()
        Return True
    End Function
End Class