﻿Imports System.Data.Odbc

Public Class ModeloChat
    Inherits ModeloConexion

    Public idSesion As String
    Public docidentidadPaciente As String
    Public docidentidadMedico As String
    Public emisor As String
    Public mensaje As String

    Public Sub New(ByVal uid As String, pwd As String)
        MyBase.New(uid, pwd)
    End Sub

    Public Function enviarMensaje()
        Comando.CommandText = "INSERT INTO chat (docidentidadPaciente, docidentidadMedico, idSesion, emisor, mensaje) VALUES (" & Me.docidentidadPaciente & "," & Me.docidentidadMedico & ", " & Me.idSesion & ",'" & Me.emisor & "', '" & Me.mensaje & "')"
        Comando.ExecuteNonQuery()
        CerrarConexion()
        Return True
    End Function

    Public Function RecibirMensajes(ByVal emisor As String)
        Dim tablaMensajes As New DataTable
        Comando.CommandText = "SELECT * FROM chat WHERE idSesion = " & ModeloDiagnostico.CodigoDiagnostico & " AND leido = 0 AND emisor <> '" & emisor & "'"
        Reader = Comando.ExecuteReader
        tablaMensajes.Load(Reader)
        CerrarConexion()
        Return tablaMensajes
    End Function


    Public Function RecibirMensajes(ByVal idSesion As String, emisor As String)
        'Lo utiliza la app del paciente
        Dim tablaMensajes As New DataTable
        Comando.CommandText = "SELECT * FROM chat WHERE idSesion = " & idSesion & " AND leido = 0 AND emisor <> '" & emisor & "'"
        Reader = Comando.ExecuteReader
        tablaMensajes.Load(Reader)
        CerrarConexion()
        Return tablaMensajes
    End Function


    Public Function RecibirTodosMensajes(ByVal idSesion As String)
        Dim tablaMensajes As New DataTable
        Comando.CommandText = "SELECT * FROM chat WHERE idSesion = " & idSesion
        Reader = Comando.ExecuteReader
        tablaMensajes.Load(Reader)
        CerrarConexion()
        Return tablaMensajes
    End Function

    Public Sub MarcarMensajeLeido(ByVal id As String)
        Comando.CommandText = "UPDATE chat SET leido = 1 WHERE id =" & id
        Comando.ExecuteNonQuery()
        CerrarConexion()
    End Sub

End Class
