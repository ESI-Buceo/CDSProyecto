Imports System.Data.Odbc
Public MustInherit Class ModeloConexion

    Public Driver As String = "MySQL ODBC 5.3 ANSI Driver"
    Public Uid As String = "u876920732_proyectocds"
    Public Pwd As String = "npvtcADR"
    Public Port As String = "3306"
    Public Database As String = "u876920732_dbTriage"
    Public Server As String = "213.190.6.127"

    Public Conexion As New OdbcConnection("DRIVER=" + Me.Driver +
                                       ";UID=" + Me.Uid +
                                       ";PWD=" + Me.Pwd +
                                       ";PORT=" + Me.Port +
                                       ";DATABASE=" + Me.Database +
                                       ";SERVER=" + Me.Server)
    Public Comando As New OdbcCommand
    Public Reader As OdbcDataReader

    Public Sub New()
        Me.Conexion.Open()
        Me.Comando.Connection = Me.Conexion
    End Sub

    Public Sub CerrarConexion()
        Me.Conexion.Close()
    End Sub
End Class
