Imports System.Data.Odbc
Public Class ModeloRecibe
    Inherits ModeloConexion

    Public DocIdentidad As String
    Public IdDiagnostico As String

    Public Function GuardarRelacionPacienteDiagnostico()
        Comando.CommandText = "INSERT INTO recibe (idDiagnostico, idPaciente) VALUES(" & Me.IdDiagnostico & ", " & Me.DocIdentidad & ")"
        Comando.ExecuteNonQuery()
        CerrarConexion()
        Return True
    End Function
End Class
