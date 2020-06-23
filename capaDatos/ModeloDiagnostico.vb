Imports System.Data.Odbc

Public Class ModeloDiagnostico
    Inherits ModeloConexion

    Public IdDiagnostico As String
    Public Prioridad As Integer

    Public Function GuardarDiagnostico() As Boolean
        'codigo para guardar el diagnostico en la base de datos
        Comando.CommandText = "INSERT INTO diagnostico VALUES (" & Me.IdDiagnostico & ", " & Me.Prioridad & ")"
        Comando.ExecuteNonQuery()
        CerrarConexion()
        Return True
    End Function
End Class
