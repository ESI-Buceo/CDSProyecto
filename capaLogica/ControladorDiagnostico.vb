Imports capaDatos
Imports System.Data

Public Module ControladorDiagnostico

    Public CodigoDiagnostico As String
    Public PonderacionDiagnostico As Integer
    Public CantidadDeSintomasFiltrados As Integer
    Public ListaSintomasSeleccionados As New List(Of Integer)
    Public ListaRelacionPatologiaSintoma As New DataTable
    Public ListaFiltradaPatologiasXSintomas As New List(Of ModeloAsociados)
    Public ListaDePatologiasParaDiagnostico As New List(Of ModeloPatologia)

    Public Sub CrearInformeDiagnostico()
        'Trae la informacion de relacion asociados (patologia, signo, sintoma de la base de datos)
        Dim a As New ModeloAsociados
        CodigoDiagnostico = generarCodigoDeDiagnostico()
        ListaRelacionPatologiaSintoma = a.CargarListaAsociadosBD()
        FiltrarPatologiasXSintomas()
    End Sub

    Public Function ValidarSintomaSeleccionado(ByVal idSintoma As Integer, sintomaNombre As String)
        'Completa la lista de sintomas seleccionados por el paciente si esta vacia y sino, llama al metodo verifiar para ver si ya no esta ingresado
        If ListaSintomasSeleccionados.Count = 0 Then
            ListaSintomasSeleccionados.Add(idSintoma)
            Return True
        Else
            Return VerificarSiYaFueIngresado(idSintoma, sintomaNombre)
        End If
    End Function

    Public Function VerificarSiYaFueIngresado(ByVal idSintoma As Integer, sintomaNombre As String)
        'Valida si el sintoma que selecciono el paciente ya fue seleccionado anteriormente 
        For s = 0 To ListaSintomasSeleccionados.Count - 1
            If ListaSintomasSeleccionados.Item(s) <> idSintoma Then
                ListaSintomasSeleccionados.Add(idSintoma)
                Return True
            End If
        Next
        Return False
    End Function

    Public Sub FiltrarPatologiasXSintomas()
        ' realiza el primer filtro de la relacion patologia sintomas para obtener las primeras patologias que coinciden con el primer sintoma
        ListaFiltradaPatologiasXSintomas.Clear()
        For index = 0 To ListaRelacionPatologiaSintoma.Rows.Count - 1
            If ListaRelacionPatologiaSintoma.Rows.Item(index)("IdSintoma").ToString = ListaSintomasSeleccionados.Item(0) Then
                Dim a As New ModeloAsociados
                a.IdPatologia = ListaRelacionPatologiaSintoma.Rows.Item(index)("idPatologia").ToString
                a.IdSintoma = ListaRelacionPatologiaSintoma.Rows.Item(index)("idSintoma").ToString
                a.IdSigno = ListaRelacionPatologiaSintoma.Rows.Item(index)("idSigno").ToString
                ListaFiltradaPatologiasXSintomas.Add(a)
            End If
        Next
        filtroFinalPatologiaXsintomas()
    End Sub

    Private Sub filtroFinalPatologiaXsintomas()
        'filtra ListaFiltradaPatologiasXSintomas por los otros sintomas ingrsados por el paciente
        For s = 1 To ListaSintomasSeleccionados.Count - 1
            For Each patologiasSeleccionadas In ListaFiltradaPatologiasXSintomas
                For Each listaPrimariaPatologias As DataRow In ListaRelacionPatologiaSintoma.Rows
                    If listaPrimariaPatologias("IdPatologia").ToString = patologiasSeleccionadas.IdPatologia Then
                        If listaPrimariaPatologias("idSintoma").ToString = ListaSintomasSeleccionados.Item(s) Then
                            patologiasSeleccionadas.Incluida = True
                            Exit For
                        Else
                            patologiasSeleccionadas.Incluida = False
                        End If
                    End If
                Next
            Next
        Next
        devolverPatologiasParaDiagnostico()
    End Sub

    Private Sub devolverPatologiasParaDiagnostico()
        'prepara el listado de patologias para mostrar al paciente
        ListaDePatologiasParaDiagnostico.Clear()
        For Each patologiasSelecionadas In ListaFiltradaPatologiasXSintomas
            If patologiasSelecionadas.Incluida Then
                Dim p As New ModeloPatologia
                ListaDePatologiasParaDiagnostico.Add(p.BuscarPatologiaPorID(patologiasSelecionadas.IdPatologia))
            End If
        Next
        ponderarDiagnostico()
    End Sub

    Public Function DevuelveListaSintomasSeleccionados()
        'Devuelve el listado de sintomas seleccionados
        Return ListaSintomasSeleccionados
    End Function

    Public Function DevolverListaPatologiasDiagnostico()
        'devuelve la lista de patologias del diagnostico
        Return ListaDePatologiasParaDiagnostico
    End Function

    Public Function DevolverlistaListaFiltradaPatologiasXSintomas()
        Return ListaFiltradaPatologiasXSintomas
    End Function

    Private Sub ponderarDiagnostico()
        'calcula la ponderacino del diagnostico que despues se utlizara en el chat
        PonderacionDiagnostico = 0
        For Each patologias In ListaDePatologiasParaDiagnostico
            If patologias.Ponderacion = 40 Then
                PonderacionDiagnostico = 40
                Exit For
            Else
                calcularPonderacionDiagnostico()
            End If
        Next
        guardarDiagnosticoEnBD()
    End Sub

    Private Sub calcularPonderacionDiagnostico()
        'Si no hay ninguna patologia de EMERGENCIA calcula el promedio para ordenar en el chat
        Dim cantidad As Integer = ListaDePatologiasParaDiagnostico.Count
        Dim totalPonderaciones As Integer

        For Each patologias In ListaDePatologiasParaDiagnostico
            totalPonderaciones = totalPonderaciones + patologias.Ponderacion
        Next
        PonderacionDiagnostico = totalPonderaciones / cantidad
    End Sub

    Private Sub guardarDiagnosticoEnBD()
        'Guarda el diagnostico en la bs
        If ListaDePatologiasParaDiagnostico.Count > 0 Then
            Dim d As New ModeloDiagnostico
            d.IdDiagnostico = CodigoDiagnostico
            d.Prioridad = PonderacionDiagnostico
            d.GuardarDiagnostico()
            guardarRelacionPacienteDiagnostico()
        End If
    End Sub

    Private Sub guardarRelacionPacienteDiagnostico()
        'Guarda la relacion paciente recibe diagnostico en la bd
        Dim pd As New ModeloRecibe
        pd.DocIdentidad = "11111111"
        pd.IdDiagnostico = CodigoDiagnostico
        pd.GuardarRelacionPacienteDiagnostico()
        guardarRelacionDiagnosticoPatologia()
    End Sub

    Private Sub guardarRelacionDiagnosticoPatologia()
        'Guarda las patologias que forman parte del diagnosticos
        For Each patologiasDeDiagnostico In ListaDePatologiasParaDiagnostico
            Dim guardarTiene As New ModeloTiene
            guardarTiene.IdDiagnostico = CodigoDiagnostico
            guardarTiene.IdPatologia = patologiasDeDiagnostico.Id
            guardarTiene.GuardarRelacionDiagnosticoPatologia()
        Next
    End Sub

    Private Function generarCodigoDeDiagnostico() As String
        'Genera codigo aleatorio de diagnostico
        Dim fechaHora As Date = DateTime.Now
        Dim codigo As String
        codigo = fechaHora.ToString("dd mm ss FFF")
        Return codigo.Replace(" ", "")
    End Function

    Public Sub NuevaConsulta()
        'Resetea todos los listados y la ponderacion cuando se inicia una nueva consulta
        ListaRelacionPatologiaSintoma.Clear()
        ListaSintomasSeleccionados.Clear()
        ListaDePatologiasParaDiagnostico.Clear()
        ListaFiltradaPatologiasXSintomas.Clear()
        PonderacionDiagnostico = 0
        CantidadDeSintomasFiltrados = 0
        CodigoDiagnostico = ""
    End Sub

    Public Function NuevoMensaje() As String
        'Genera un numero aleatorio del 1 al 4 para luego mostrar mensajes diferentes.
        Dim Random As New Random()
        Dim numero As Integer = Random.Next(1, 4)
        Return mensaje(numero)
    End Function

    Private Function mensaje(id As Integer) As String
        Dim txtMensaje As String
        Select Case id
            Case 1
                txtMensaje = "Que mas sientes? "
            Case 2
                txtMensaje = "Sientes otro malestar? "
            Case 3
                txtMensaje = "Que otro sintoma tienes? "
            Case 4
                txtMensaje = "Sientes algo mas?"
            Case Else
                txtMensaje = "Mensaje por defecto"
        End Select
        Return txtMensaje
    End Function

End Module
