﻿Imports capaLogica

Public Class frmAdministrativo
    Dim agregar As Boolean

    Private Sub mnuBtnAgregar_Click(sender As Object, e As EventArgs) Handles mnuBtnAgregar.Click
        ClickEnBotonAgregar(toolsMenuAdmin)
        agregar = True
        habilitarDocumento()
        colorearDocumento()
        chkActivo.Visible = False
        vaciarControles()
        habilitarControlesDeEdicion()
        cargarFechaDeHoy()
    End Sub

    Private Sub controlAgregarActivo()
        agregar = True
        chkActivo.Visible = False
    End Sub

    Private Sub colorearDocumento()
        'Colorea el textbox de documento para un nuevo ingreso
        txtDocIdentidad.BackColor = Color.FromArgb(234, 222, 164)
    End Sub

    Private Sub habilitarDocumento()
        'habilita el textbox de documento para un nuevo ingreso
        txtDocIdentidad.Enabled = True
        txtDocIdentidad.Select()
    End Sub

    Private Sub deshablitaDocumento()
        'Deshabilita el textbox de documento
        txtDocIdentidad.Enabled = False
    End Sub

    Private Sub crearTablaTelefonoParaDataGrid()
        'Crea un datatable para el datagrid de telefonos
        dgvListaTelefonos.DataSource = controladorAdministrativo.crearTablaTelefonos()
    End Sub

    Private Sub habilitarControlesDeEdicion()
        'Habilita la lista de telefonos
        dgvListaTelefonos.Enabled = True
        btnAgregarTelefono.Enabled = True
        btnEliminarTelefono.Enabled = True
        colorearCamposRequeridos()
    End Sub

    Private Sub deshabilitarControlesDeEdicion()
        'Habilita la lista de telefonos
        dgvListaTelefonos.Enabled = False
        btnAgregarTelefono.Enabled = False
        btnEliminarTelefono.Enabled = False
        agregar = False
        restaurarColorCampos()
    End Sub

    Private Sub mnuBtnGuardar_Click(sender As Object, e As EventArgs) Handles mnuBtnGuardar.Click
        'valida antesde ingresar la informacion del administrativo
        If ControladorValidaciones.validarFormatoDocumento(txtDocIdentidad.Text) And ControladorValidaciones.validarNombres(txtNombres.Text) _
            And ControladorValidaciones.validarApellidos(txtApellidos.Text) And ControladorValidaciones.ValidarEmail(txtEmail.Text) _
            And ControladorValidaciones.ValidarFechaNacimiento(dtpFechaNac.Value) And ControladorValidaciones.validarNumeroEmpleado(txtNumAdmin.Text) Then
            guardarDatosAdministrativo()
        Else
            MsgBox("Faltan datos requeridos o hay datos incorrectos, verifica.", vbInformation, "Aviso")
        End If
    End Sub

    Private Sub guardarDatosAdministrativo()
        'guarda la informacion del administrativo
        Try
            controladorAdministrativo.GuardarDatosAdmin(txtDocIdentidad.Text, txtEmail.Text, txtNombres.Text, txtApellidos.Text,
                               txtCalle.Text, txtNumeroCalle.Text, txtBarrio.Text, txtEsquina.Text, txtApto.Text,
                               Format(dtpFechaNac.Value, "yyyy-MM-dd"), chkActivo.CheckState, dgvListaTelefonos,
                               txtNumAdmin.Text, USUARIO, PASSWORD)
            opcionesMenu.ClickEnBotonGuardar(toolsMenuAdmin)
            guardadoConExito()
            deshabilitarControlesDeEdicion()
        Catch ex As Exception
            MsgBox("Error al guardar los datos del administrativo", vbCritical, "Error")
        End Try
    End Sub

    Private Sub guardadoConExito()
        'Mensaje de guardo con exito
        MsgBox("Datos guardado con exito", vbInformation, "Aviso")
        deshablitaDocumento()
        restaurarColorCampos()
        agregarAdministrativoABD()
    End Sub

    Private Sub agregarAdministrativoABD()
        'Agrega el usuario a la base de datos
        If agregar Then
            Try
                controladorAdministrativo.CrearUsuarioBD(txtDocIdentidad.Text, USUARIO, PASSWORD)
            Catch ex As Exception
                MsgBox("Error al crear el usuario en la base de datos", vbCritical, "ERROR")
            End Try
        End If
    End Sub

    Private Sub deshabilitarListaTelefonos()
        'Deshabilita la lista de telefonos
        dgvListaTelefonos.Enabled = False
    End Sub

    Private Sub mnuBtnCancelar_Click(sender As Object, e As EventArgs) Handles mnuBtnCancelar.Click
        'Cancela los procesos activos
        opcionesMenu.ClickEnBotonCancelar(toolsMenuAdmin)
        deshablitaDocumento()
        deshabilitarControlesDeEdicion()
        tabOpcionAdmin.SelectTab(tabDatos)
        desactivarCheckActivo()
    End Sub

    Private Sub mnuBtnNueva_Click(sender As Object, e As EventArgs) Handles mnuBtnNueva.Click
        'Habilita para una nueva busqueda
        opcionesMenu.ClickEnBotonNueva(toolsMenuAdmin)
        agregar = False
        crearTablaTelefonoParaDataGrid()
        vaciarControles()
        habilitarDocumento()
        txtDocIdentidad.Select()
        marcarCamposParaBusqueda()
    End Sub

    Private Sub marcarCamposParaBusqueda()
        'Marca los campos por los que se puede buscar
        txtDocIdentidad.BackColor = Color.FromArgb(247, 241, 210)
        txtNumAdmin.BackColor = Color.FromArgb(247, 241, 210)
        txtNombres.BackColor = Color.FromArgb(247, 241, 210)
        txtApellidos.BackColor = Color.FromArgb(247, 241, 210)
    End Sub

    Private Sub mnuBtnBuscar_Click(sender As Object, e As EventArgs) Handles mnuBtnBuscar.Click
        'Buscar un administrativo de acuerdo a los datos ingresados 
        opcionesMenu.ClickEnBotonBuscar(toolsMenuAdmin)
        tabOpcionAdmin.SelectTab(tabBusqueda)
        formarCadenaDeBusqueda()
    End Sub

    Private Sub mnuBtnBorrar_Click(sender As Object, e As EventArgs) Handles mnuBtnBorrar.Click
        'Dispara el proceso de eliminacion logica
        Dim respuesta As Integer
        respuesta = MsgBox("Seguro de eliminar al Administrativo?", vbQuestion & vbYesNo, "Confirmar eliminacion")
        If respuesta = 6 Then
            borrarAdministrativo()
        End If
    End Sub
    Private Sub borrarAdministrativo()
        'Procesa baja de administrativo
        Try
            If controladorAdministrativo.EliminiarAdmin(txtDocIdentidad.Text, USUARIO, PASSWORD) Then
                opcionesMenu.ClickEnBotonBorrar(toolsMenuAdmin)
                MsgBox("Administrativo eliminado con exito !", vbInformation, "Aviso")
                eliminarAdmnistrativoBD()
            End If
        Catch ex As Exception
            MsgBox("Error al eliminar el administrativo", vbCritical, "Aviso")
        End Try
    End Sub

    Private Sub eliminarAdmnistrativoBD()
        'Elimina el usuario de la base de datos
        Try
            controladorAdministrativo.eliminiarUsuarioBD(txtDocIdentidad.Text, USUARIO, PASSWORD)
        Catch ex As Exception
            MsgBox("No se puedo eliminiar el usuario de la base de datos", vbCritical, "ERROR")
        End Try
    End Sub

    Private Sub mnuBtnModificar_Click(sender As Object, e As EventArgs) Handles mnuBtnModificar.Click
        'Habilita la modificacion del administrativo en pantalla
        opcionesMenu.ClickEnBotonModificar(toolsMenuAdmin)
        habilitarControlesDeEdicion()
        deshablitaDocumento()
        agregar = False
        activarCheckActivo()
    End Sub

    Private Sub activarCheckActivo()
        chkActivo.Enabled = True
    End Sub

    Private Sub desactivarCheckActivo()
        chkActivo.Enabled = False
    End Sub

    Private Sub colorearCamposRequeridos()
        'Colorea los campos requeridos con amarillo
        txtNombres.BackColor = Color.FromArgb(247, 241, 210)
        txtApellidos.BackColor = Color.FromArgb(247, 241, 210)
        txtEmail.BackColor = Color.FromArgb(247, 241, 210)
        dtpFechaNac.CalendarTitleBackColor = Color.FromArgb(247, 241, 210)
        txtNumAdmin.BackColor = Color.FromArgb(247, 241, 210)
    End Sub

    Private Sub restaurarColorCampos()
        'Recorre y colorea todos los textbox del tabDatos
        For Each controles As Control In Me.tabDatos.Controls
            If TypeOf controles Is TextBox Then
                controles.BackColor = Color.White
            End If
        Next
    End Sub

    Private Sub vaciarControles()
        'Recorre y vacia todos los textbos del tabDatos
        For Each controles As Control In Me.tabDatos.Controls
            If TypeOf controles Is TextBox Then
                controles.Text = Nothing
            End If
        Next
        crearTablaTelefonoParaDataGrid()
    End Sub

    Private Sub cargarFechaDeHoy()
        'Carga la fecha del dia de hoy
        txtFechaRegistro.Text = Format(CDate(Now), "dd/MM/yyyy")
    End Sub

    Private Sub dgvListaAdministrador_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvListaAdministrador.RowHeaderMouseClick
        'Evento al hacer clic en la lista de administrativos que muestra los datos del mismo
        ClickEnListado(toolsMenuAdmin)
        Try
            mostrarDatosDelAdmin(controladorAdministrativo.BuscarAdministrativoPorDocumento(dgvListaAdministrador.Item(0, e.RowIndex).Value, USUARIO, PASSWORD))
            restaurarColorCampos()
            tabOpcionAdmin.SelectTab(tabDatos)
            deshablitaDocumento()
            validarBotonBorrar(dgvListaAdministrador.Item(6, e.RowIndex).Value)
            txtNombres.Select()
        Catch ex As Exception
            MsgBox("Error al cargar los datos del usuario", vbExclamation, "Aviso")
        End Try
    End Sub

    Private Sub validarBotonBorrar(ByVal activo As String)
        'Si ya esta eliminado el boton queda deshabilitado
        If activo = 0 Then
            mnuBtnBorrar.Enabled = False
            chkActivo.Visible = True
        Else
            chkActivo.Visible = False
        End If
    End Sub

    Private Sub mostrarDatosDelAdmin(ByVal datosAdministrativo As DataTable)
        'Carga todos los datos del administrativo elegido
        txtDocIdentidad.Text = datosAdministrativo.Rows(0).Item("documento").ToString
        txtFechaRegistro.Text = Format(datosAdministrativo.Rows(0).Item("fechReg"), "dd/MM/yyyy").ToString
        txtNumAdmin.Text = datosAdministrativo.Rows(0).Item("ndeempleado").ToString
        dtpFechaNac.Value = Format(datosAdministrativo.Rows(0).Item("fechaNac"), "dd/MM/yyyy").ToString
        txtNombres.Text = datosAdministrativo.Rows(0).Item("nombres").ToString
        txtApellidos.Text = datosAdministrativo.Rows(0).Item("apellidos").ToString
        txtEmail.Text = datosAdministrativo.Rows(0).Item("mail").ToString
        txtCalle.Text = datosAdministrativo.Rows(0).Item("calle").ToString
        txtNumeroCalle.Text = datosAdministrativo(0).Item("numero").ToString
        txtApto.Text = datosAdministrativo.Rows(0).Item("apto").ToString
        txtEsquina.Text = datosAdministrativo.Rows(0).Item("esquina").ToString
        txtBarrio.Text = datosAdministrativo.Rows(0).Item("barrio").ToString
        chkActivo.CheckState = datosAdministrativo.Rows(0).Item("activo").ToString
        cargarTelefonos(datosAdministrativo)
    End Sub

    Private Sub cargarTelefonos(ByVal telefonos As DataTable)
        'Carga los telefonos del administrativo elegido
        cargarGridTelefonos(controladorAdministrativo.crearTablaTelefonos(), telefonos)
    End Sub

    Private Sub cargarGridTelefonos(ByVal tablaTelefono As DataTable, telefonos As DataTable)
        'Carga la tabla con los telefonos registrados
        For t = 0 To telefonos.Rows.Count - 1
            Dim rowTel As DataRow = tablaTelefono.NewRow()
            rowTel("Telefono") = telefonos(t).Item("telefono").ToString
            tablaTelefono.Rows.Add(rowTel)
        Next
        mostrarTelefonosEnDataGrid(tablaTelefono)
    End Sub

    Private Sub mostrarTelefonosEnDataGrid(ByVal tablaTelefono As DataTable)
        'Carga el datagrid con los telefonos
        dgvListaTelefonos.DataSource = tablaTelefono
    End Sub

    Private Sub btnAgregarTelefono_Click(sender As Object, e As EventArgs) Handles btnAgregarTelefono.Click
        'Habilita el ingreso de un nuevo telefono en el grid
        dgvListaTelefonos.AllowUserToAddRows = True
    End Sub

    Private Sub dgvListaTelefonos_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListaTelefonos.CellValueChanged
        'Actualza el grid una vez ingresado un nuevo telefono
        dgvListaTelefonos.AllowUserToAddRows = False
    End Sub

    Private Sub btnEliminarTelefono_Click(sender As Object, e As EventArgs) Handles btnEliminarTelefono.Click
        'Eliminia el telefono seleccionado de la lista
        dgvListaTelefonos.Rows.Remove(dgvListaTelefonos.CurrentRow)
    End Sub

    Private Sub formarCadenaDeBusqueda()
        'Recorre y verifica los datos ingresados para la busqueda
        Dim stringDeBusqueda As String
        For Each controles As Control In Me.tabDatos.Controls
            If TypeOf controles Is TextBox And controles.Text <> Nothing Then
                stringDeBusqueda += crearCadenaDeBusquedaAdministrativo(controles.Name, controles.Text) & " AND "
            End If
        Next
        lanzarBusquedaAdministrativo(stringDeBusqueda)
    End Sub

    Private Sub lanzarBusquedaAdministrativo(ByVal stringDeBusqueda As String)
        'Muestra el resultado del proceso de busqueda
        Try
            dgvListaAdministrador.DataSource = controladorAdministrativo.buscarAdministrativo(stringDeBusqueda, USUARIO, PASSWORD)
            colorearEliminados(dgvListaAdministrador)
            crearTablaTelefonoParaDataGrid()
        Catch ex As Exception
            MsgBox("Error al buscar el administrativo", vbCritical, "Error")
        End Try

    End Sub

    Public Sub colorearEliminados(ByRef lista As DataGridView)
        For i = 0 To lista.Rows.Count - 1
            If lista.Rows.Item(i).Cells("colActivo").Value.ToString = 0 Then
                lista.Rows(i).DefaultCellStyle.BackColor = Color.Red
                lista.Rows(i).DefaultCellStyle.ForeColor = Color.White
            End If
        Next
    End Sub

    Private Sub validarDocumentoDeIdentidad()
        Try
            If controladorAdministrativo.VarificarDocumentoDeIdentidad(txtDocIdentidad.Text, USUARIO, PASSWORD) IsNot Nothing Then
                MsgBox("El documento ingresado ya existe", vbInformation, "AVISO")
                cancelarProcesoDeIngreso()
            End If
        Catch ex As Exception
            MsgBox("Error al verificar el documento", vbCritical, "Error")
            cancelarProcesoDeIngreso()
        End Try
    End Sub

    Private Sub cancelarProcesoDeIngreso()
        ClickEnBotonCancelar(toolsMenuAdmin)
        deshablitaDocumento()
        deshabilitarControlesDeEdicion()
        vaciarControles()
    End Sub

    Private Sub txtDocIdentidad_LostFocus(sender As Object, e As EventArgs) Handles txtDocIdentidad.LostFocus
        If agregar Then validarDocumentoDeIdentidad()
    End Sub
End Class