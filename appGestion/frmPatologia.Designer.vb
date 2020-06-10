<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatologia
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPatologia))
        Me.picEncabezado = New System.Windows.Forms.PictureBox()
        Me.toolsMenuPatologia = New System.Windows.Forms.ToolStrip()
        Me.mnuBtnAgregar = New System.Windows.Forms.ToolStripButton()
        Me.tabSeparador = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuBtnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tabSeparador1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuBtnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.tabSeperador2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuBtnNueva = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuBtnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.tabSeparador3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuBtnBorrar = New System.Windows.Forms.ToolStripButton()
        Me.tabSeparador4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuBtnModificar = New System.Windows.Forms.ToolStripButton()
        Me.tabDatosPatologia = New System.Windows.Forms.TabControl()
        Me.tabDatos = New System.Windows.Forms.TabPage()
        Me.chkActiva = New System.Windows.Forms.CheckBox()
        Me.lblActiva = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAgregarSigno = New System.Windows.Forms.Button()
        Me.lblSignos = New System.Windows.Forms.Label()
        Me.dgvSignosPatologia = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblSintomas = New System.Windows.Forms.Label()
        Me.btnAgregarSintoma = New System.Windows.Forms.Button()
        Me.dgvSintomasPatologia = New System.Windows.Forms.DataGridView()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSintomaNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtPatologiaDescipcion = New System.Windows.Forms.TextBox()
        Me.lblPatologiaDescripcion = New System.Windows.Forms.Label()
        Me.cbPatologiaPonderacion = New System.Windows.Forms.ComboBox()
        Me.lblPatologiaPonderacion = New System.Windows.Forms.Label()
        Me.txtPatologiaNombre = New System.Windows.Forms.TextBox()
        Me.lblPatologiaNombre = New System.Windows.Forms.Label()
        Me.txtPatologiaID = New System.Windows.Forms.TextBox()
        Me.lblPatologiaID = New System.Windows.Forms.Label()
        Me.tabPatologiaBusqueda = New System.Windows.Forms.TabPage()
        Me.dgvListaDePatologias = New System.Windows.Forms.DataGridView()
        Me.lblUrgenciaMenor = New System.Windows.Forms.Label()
        Me.lblUrgencia = New System.Windows.Forms.Label()
        Me.lblEmergencia = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.picEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolsMenuPatologia.SuspendLayout()
        Me.tabDatosPatologia.SuspendLayout()
        Me.tabDatos.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvSignosPatologia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSintomasPatologia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPatologiaBusqueda.SuspendLayout()
        CType(Me.dgvListaDePatologias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picEncabezado
        '
        Me.picEncabezado.Image = CType(resources.GetObject("picEncabezado.Image"), System.Drawing.Image)
        Me.picEncabezado.Location = New System.Drawing.Point(-2, 1)
        Me.picEncabezado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.picEncabezado.Name = "picEncabezado"
        Me.picEncabezado.Size = New System.Drawing.Size(707, 64)
        Me.picEncabezado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picEncabezado.TabIndex = 2
        Me.picEncabezado.TabStop = False
        Me.picEncabezado.UseWaitCursor = True
        '
        'toolsMenuPatologia
        '
        Me.toolsMenuPatologia.AutoSize = False
        Me.toolsMenuPatologia.Dock = System.Windows.Forms.DockStyle.None
        Me.toolsMenuPatologia.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toolsMenuPatologia.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolsMenuPatologia.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.toolsMenuPatologia.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBtnAgregar, Me.tabSeparador, Me.mnuBtnGuardar, Me.tabSeparador1, Me.mnuBtnCancelar, Me.tabSeperador2, Me.mnuBtnNueva, Me.ToolStripSeparator1, Me.mnuBtnBuscar, Me.tabSeparador3, Me.mnuBtnBorrar, Me.tabSeparador4, Me.mnuBtnModificar})
        Me.toolsMenuPatologia.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.toolsMenuPatologia.Location = New System.Drawing.Point(7, 67)
        Me.toolsMenuPatologia.Name = "toolsMenuPatologia"
        Me.toolsMenuPatologia.Size = New System.Drawing.Size(698, 36)
        Me.toolsMenuPatologia.TabIndex = 3
        Me.toolsMenuPatologia.UseWaitCursor = True
        '
        'mnuBtnAgregar
        '
        Me.mnuBtnAgregar.Image = CType(resources.GetObject("mnuBtnAgregar.Image"), System.Drawing.Image)
        Me.mnuBtnAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuBtnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuBtnAgregar.Name = "mnuBtnAgregar"
        Me.mnuBtnAgregar.Size = New System.Drawing.Size(88, 29)
        Me.mnuBtnAgregar.Text = "Agregar"
        Me.mnuBtnAgregar.ToolTipText = "Agrega un nuevo registro"
        '
        'tabSeparador
        '
        Me.tabSeparador.Name = "tabSeparador"
        Me.tabSeparador.Size = New System.Drawing.Size(6, 23)
        '
        'mnuBtnGuardar
        '
        Me.mnuBtnGuardar.Enabled = False
        Me.mnuBtnGuardar.Image = CType(resources.GetObject("mnuBtnGuardar.Image"), System.Drawing.Image)
        Me.mnuBtnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuBtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuBtnGuardar.Name = "mnuBtnGuardar"
        Me.mnuBtnGuardar.Size = New System.Drawing.Size(90, 29)
        Me.mnuBtnGuardar.Text = "Guardar"
        Me.mnuBtnGuardar.ToolTipText = "Guarda los cambios"
        '
        'tabSeparador1
        '
        Me.tabSeparador1.Name = "tabSeparador1"
        Me.tabSeparador1.Size = New System.Drawing.Size(6, 23)
        '
        'mnuBtnCancelar
        '
        Me.mnuBtnCancelar.Enabled = False
        Me.mnuBtnCancelar.Image = CType(resources.GetObject("mnuBtnCancelar.Image"), System.Drawing.Image)
        Me.mnuBtnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuBtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuBtnCancelar.Name = "mnuBtnCancelar"
        Me.mnuBtnCancelar.Size = New System.Drawing.Size(94, 29)
        Me.mnuBtnCancelar.Text = "Cancelar"
        Me.mnuBtnCancelar.ToolTipText = "Cancela los cambios"
        '
        'tabSeperador2
        '
        Me.tabSeperador2.Name = "tabSeperador2"
        Me.tabSeperador2.Size = New System.Drawing.Size(6, 23)
        '
        'mnuBtnNueva
        '
        Me.mnuBtnNueva.Image = CType(resources.GetObject("mnuBtnNueva.Image"), System.Drawing.Image)
        Me.mnuBtnNueva.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuBtnNueva.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuBtnNueva.Name = "mnuBtnNueva"
        Me.mnuBtnNueva.Size = New System.Drawing.Size(77, 29)
        Me.mnuBtnNueva.Text = "Nueva"
        Me.mnuBtnNueva.ToolTipText = "Inicia una nueva busqueda"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 23)
        '
        'mnuBtnBuscar
        '
        Me.mnuBtnBuscar.Enabled = False
        Me.mnuBtnBuscar.Image = CType(resources.GetObject("mnuBtnBuscar.Image"), System.Drawing.Image)
        Me.mnuBtnBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuBtnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuBtnBuscar.Name = "mnuBtnBuscar"
        Me.mnuBtnBuscar.Size = New System.Drawing.Size(81, 29)
        Me.mnuBtnBuscar.Text = "Buscar"
        Me.mnuBtnBuscar.ToolTipText = "Buscar registros"
        '
        'tabSeparador3
        '
        Me.tabSeparador3.Name = "tabSeparador3"
        Me.tabSeparador3.Size = New System.Drawing.Size(6, 23)
        '
        'mnuBtnBorrar
        '
        Me.mnuBtnBorrar.Enabled = False
        Me.mnuBtnBorrar.Image = CType(resources.GetObject("mnuBtnBorrar.Image"), System.Drawing.Image)
        Me.mnuBtnBorrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuBtnBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuBtnBorrar.Name = "mnuBtnBorrar"
        Me.mnuBtnBorrar.Size = New System.Drawing.Size(77, 29)
        Me.mnuBtnBorrar.Text = "Borrar"
        Me.mnuBtnBorrar.ToolTipText = "Borrar el registro en pantalla"
        '
        'tabSeparador4
        '
        Me.tabSeparador4.Name = "tabSeparador4"
        Me.tabSeparador4.Size = New System.Drawing.Size(6, 23)
        '
        'mnuBtnModificar
        '
        Me.mnuBtnModificar.Enabled = False
        Me.mnuBtnModificar.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuBtnModificar.Image = CType(resources.GetObject("mnuBtnModificar.Image"), System.Drawing.Image)
        Me.mnuBtnModificar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuBtnModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuBtnModificar.Name = "mnuBtnModificar"
        Me.mnuBtnModificar.Size = New System.Drawing.Size(94, 29)
        Me.mnuBtnModificar.Text = "Modificar"
        Me.mnuBtnModificar.ToolTipText = "Modificar el registro en pantalla"
        '
        'tabDatosPatologia
        '
        Me.tabDatosPatologia.Controls.Add(Me.tabDatos)
        Me.tabDatosPatologia.Controls.Add(Me.tabPatologiaBusqueda)
        Me.tabDatosPatologia.Font = New System.Drawing.Font("Arial", 10.2!)
        Me.tabDatosPatologia.Location = New System.Drawing.Point(9, 114)
        Me.tabDatosPatologia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tabDatosPatologia.Name = "tabDatosPatologia"
        Me.tabDatosPatologia.SelectedIndex = 0
        Me.tabDatosPatologia.Size = New System.Drawing.Size(656, 414)
        Me.tabDatosPatologia.TabIndex = 4
        '
        'tabDatos
        '
        Me.tabDatos.BackColor = System.Drawing.Color.Gainsboro
        Me.tabDatos.Controls.Add(Me.chkActiva)
        Me.tabDatos.Controls.Add(Me.lblActiva)
        Me.tabDatos.Controls.Add(Me.Panel1)
        Me.tabDatos.Controls.Add(Me.txtPatologiaDescipcion)
        Me.tabDatos.Controls.Add(Me.lblPatologiaDescripcion)
        Me.tabDatos.Controls.Add(Me.cbPatologiaPonderacion)
        Me.tabDatos.Controls.Add(Me.lblPatologiaPonderacion)
        Me.tabDatos.Controls.Add(Me.txtPatologiaNombre)
        Me.tabDatos.Controls.Add(Me.lblPatologiaNombre)
        Me.tabDatos.Controls.Add(Me.txtPatologiaID)
        Me.tabDatos.Controls.Add(Me.lblPatologiaID)
        Me.tabDatos.Location = New System.Drawing.Point(4, 25)
        Me.tabDatos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tabDatos.Name = "tabDatos"
        Me.tabDatos.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tabDatos.Size = New System.Drawing.Size(648, 385)
        Me.tabDatos.TabIndex = 0
        Me.tabDatos.Text = "Datos"
        '
        'chkActiva
        '
        Me.chkActiva.AutoSize = True
        Me.chkActiva.Location = New System.Drawing.Point(120, 341)
        Me.chkActiva.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkActiva.Name = "chkActiva"
        Me.chkActiva.Size = New System.Drawing.Size(15, 14)
        Me.chkActiva.TabIndex = 14
        Me.chkActiva.UseVisualStyleBackColor = True
        '
        'lblActiva
        '
        Me.lblActiva.AutoSize = True
        Me.lblActiva.Location = New System.Drawing.Point(55, 341)
        Me.lblActiva.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblActiva.Name = "lblActiva"
        Me.lblActiva.Size = New System.Drawing.Size(60, 16)
        Me.lblActiva.TabIndex = 13
        Me.lblActiva.Text = "ACTIVA:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnAgregarSigno)
        Me.Panel1.Controls.Add(Me.lblSignos)
        Me.Panel1.Controls.Add(Me.dgvSignosPatologia)
        Me.Panel1.Controls.Add(Me.lblSintomas)
        Me.Panel1.Controls.Add(Me.btnAgregarSintoma)
        Me.Panel1.Controls.Add(Me.dgvSintomasPatologia)
        Me.Panel1.Location = New System.Drawing.Point(4, 154)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(625, 178)
        Me.Panel1.TabIndex = 12
        '
        'btnAgregarSigno
        '
        Me.btnAgregarSigno.Enabled = False
        Me.btnAgregarSigno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarSigno.ForeColor = System.Drawing.Color.Green
        Me.btnAgregarSigno.Location = New System.Drawing.Point(421, 138)
        Me.btnAgregarSigno.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAgregarSigno.Name = "btnAgregarSigno"
        Me.btnAgregarSigno.Size = New System.Drawing.Size(79, 32)
        Me.btnAgregarSigno.TabIndex = 29
        Me.btnAgregarSigno.Text = "Agregar"
        Me.btnAgregarSigno.UseVisualStyleBackColor = True
        '
        'lblSignos
        '
        Me.lblSignos.AutoSize = True
        Me.lblSignos.Location = New System.Drawing.Point(356, 12)
        Me.lblSignos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSignos.Name = "lblSignos"
        Me.lblSignos.Size = New System.Drawing.Size(64, 16)
        Me.lblSignos.TabIndex = 28
        Me.lblSignos.Text = "SIGNOS:"
        '
        'dgvSignosPatologia
        '
        Me.dgvSignosPatologia.AllowUserToAddRows = False
        Me.dgvSignosPatologia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSignosPatologia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.dgvSignosPatologia.Enabled = False
        Me.dgvSignosPatologia.Location = New System.Drawing.Point(421, 2)
        Me.dgvSignosPatologia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvSignosPatologia.Name = "dgvSignosPatologia"
        Me.dgvSignosPatologia.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        Me.dgvSignosPatologia.RowTemplate.Height = 24
        Me.dgvSignosPatologia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvSignosPatologia.Size = New System.Drawing.Size(202, 131)
        Me.dgvSignosPatologia.TabIndex = 27
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 180
        '
        'lblSintomas
        '
        Me.lblSintomas.AutoSize = True
        Me.lblSintomas.Location = New System.Drawing.Point(32, 12)
        Me.lblSintomas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSintomas.Name = "lblSintomas"
        Me.lblSintomas.Size = New System.Drawing.Size(82, 16)
        Me.lblSintomas.TabIndex = 26
        Me.lblSintomas.Text = "SINTOMAS:"
        '
        'btnAgregarSintoma
        '
        Me.btnAgregarSintoma.Enabled = False
        Me.btnAgregarSintoma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarSintoma.ForeColor = System.Drawing.Color.Green
        Me.btnAgregarSintoma.Location = New System.Drawing.Point(117, 138)
        Me.btnAgregarSintoma.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAgregarSintoma.Name = "btnAgregarSintoma"
        Me.btnAgregarSintoma.Size = New System.Drawing.Size(79, 32)
        Me.btnAgregarSintoma.TabIndex = 25
        Me.btnAgregarSintoma.Text = "Agregar"
        Me.btnAgregarSintoma.UseVisualStyleBackColor = True
        '
        'dgvSintomasPatologia
        '
        Me.dgvSintomasPatologia.AllowUserToAddRows = False
        Me.dgvSintomasPatologia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSintomasPatologia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colSintomaNombre})
        Me.dgvSintomasPatologia.Enabled = False
        Me.dgvSintomasPatologia.Location = New System.Drawing.Point(116, 2)
        Me.dgvSintomasPatologia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvSintomasPatologia.Name = "dgvSintomasPatologia"
        Me.dgvSintomasPatologia.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        Me.dgvSintomasPatologia.RowTemplate.Height = 24
        Me.dgvSintomasPatologia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvSintomasPatologia.Size = New System.Drawing.Size(205, 131)
        Me.dgvSintomasPatologia.TabIndex = 24
        '
        'colID
        '
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.Width = 50
        '
        'colSintomaNombre
        '
        Me.colSintomaNombre.HeaderText = "Nombre"
        Me.colSintomaNombre.Name = "colSintomaNombre"
        Me.colSintomaNombre.ReadOnly = True
        Me.colSintomaNombre.Width = 180
        '
        'txtPatologiaDescipcion
        '
        Me.txtPatologiaDescipcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPatologiaDescipcion.Location = New System.Drawing.Point(122, 56)
        Me.txtPatologiaDescipcion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPatologiaDescipcion.Multiline = True
        Me.txtPatologiaDescipcion.Name = "txtPatologiaDescipcion"
        Me.txtPatologiaDescipcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPatologiaDescipcion.Size = New System.Drawing.Size(506, 93)
        Me.txtPatologiaDescipcion.TabIndex = 7
        '
        'lblPatologiaDescripcion
        '
        Me.lblPatologiaDescripcion.AutoSize = True
        Me.lblPatologiaDescripcion.Location = New System.Drawing.Point(14, 56)
        Me.lblPatologiaDescripcion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPatologiaDescripcion.Name = "lblPatologiaDescripcion"
        Me.lblPatologiaDescripcion.Size = New System.Drawing.Size(105, 16)
        Me.lblPatologiaDescripcion.TabIndex = 6
        Me.lblPatologiaDescripcion.Text = "DESCRIPCION:"
        '
        'cbPatologiaPonderacion
        '
        Me.cbPatologiaPonderacion.FormattingEnabled = True
        Me.cbPatologiaPonderacion.Items.AddRange(New Object() {"10", "20", "30"})
        Me.cbPatologiaPonderacion.Location = New System.Drawing.Point(560, 18)
        Me.cbPatologiaPonderacion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbPatologiaPonderacion.Name = "cbPatologiaPonderacion"
        Me.cbPatologiaPonderacion.Size = New System.Drawing.Size(71, 24)
        Me.cbPatologiaPonderacion.TabIndex = 5
        '
        'lblPatologiaPonderacion
        '
        Me.lblPatologiaPonderacion.AutoSize = True
        Me.lblPatologiaPonderacion.Location = New System.Drawing.Point(449, 21)
        Me.lblPatologiaPonderacion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPatologiaPonderacion.Name = "lblPatologiaPonderacion"
        Me.lblPatologiaPonderacion.Size = New System.Drawing.Size(112, 16)
        Me.lblPatologiaPonderacion.TabIndex = 4
        Me.lblPatologiaPonderacion.Text = "PONDERACION:"
        '
        'txtPatologiaNombre
        '
        Me.txtPatologiaNombre.Location = New System.Drawing.Point(284, 18)
        Me.txtPatologiaNombre.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPatologiaNombre.Name = "txtPatologiaNombre"
        Me.txtPatologiaNombre.Size = New System.Drawing.Size(150, 23)
        Me.txtPatologiaNombre.TabIndex = 3
        '
        'lblPatologiaNombre
        '
        Me.lblPatologiaNombre.AutoSize = True
        Me.lblPatologiaNombre.Location = New System.Drawing.Point(208, 21)
        Me.lblPatologiaNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPatologiaNombre.Name = "lblPatologiaNombre"
        Me.lblPatologiaNombre.Size = New System.Drawing.Size(71, 16)
        Me.lblPatologiaNombre.TabIndex = 2
        Me.lblPatologiaNombre.Text = "NOMBRE:"
        '
        'txtPatologiaID
        '
        Me.txtPatologiaID.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtPatologiaID.Location = New System.Drawing.Point(120, 18)
        Me.txtPatologiaID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPatologiaID.Name = "txtPatologiaID"
        Me.txtPatologiaID.ReadOnly = True
        Me.txtPatologiaID.Size = New System.Drawing.Size(79, 23)
        Me.txtPatologiaID.TabIndex = 1
        Me.txtPatologiaID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPatologiaID
        '
        Me.lblPatologiaID.AutoSize = True
        Me.lblPatologiaID.Location = New System.Drawing.Point(86, 21)
        Me.lblPatologiaID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPatologiaID.Name = "lblPatologiaID"
        Me.lblPatologiaID.Size = New System.Drawing.Size(25, 16)
        Me.lblPatologiaID.TabIndex = 0
        Me.lblPatologiaID.Text = "ID:"
        '
        'tabPatologiaBusqueda
        '
        Me.tabPatologiaBusqueda.Controls.Add(Me.dgvListaDePatologias)
        Me.tabPatologiaBusqueda.Location = New System.Drawing.Point(4, 25)
        Me.tabPatologiaBusqueda.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tabPatologiaBusqueda.Name = "tabPatologiaBusqueda"
        Me.tabPatologiaBusqueda.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tabPatologiaBusqueda.Size = New System.Drawing.Size(648, 385)
        Me.tabPatologiaBusqueda.TabIndex = 1
        Me.tabPatologiaBusqueda.Text = "Busqueda"
        Me.tabPatologiaBusqueda.UseVisualStyleBackColor = True
        '
        'dgvListaDePatologias
        '
        Me.dgvListaDePatologias.AllowUserToAddRows = False
        Me.dgvListaDePatologias.AllowUserToDeleteRows = False
        Me.dgvListaDePatologias.AllowUserToOrderColumns = True
        Me.dgvListaDePatologias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaDePatologias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListaDePatologias.Location = New System.Drawing.Point(2, 2)
        Me.dgvListaDePatologias.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvListaDePatologias.Name = "dgvListaDePatologias"
        Me.dgvListaDePatologias.ReadOnly = True
        Me.dgvListaDePatologias.RowTemplate.Height = 24
        Me.dgvListaDePatologias.Size = New System.Drawing.Size(644, 381)
        Me.dgvListaDePatologias.TabIndex = 0
        '
        'lblUrgenciaMenor
        '
        Me.lblUrgenciaMenor.BackColor = System.Drawing.Color.Green
        Me.lblUrgenciaMenor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUrgenciaMenor.ForeColor = System.Drawing.Color.White
        Me.lblUrgenciaMenor.Location = New System.Drawing.Point(667, 184)
        Me.lblUrgenciaMenor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUrgenciaMenor.Name = "lblUrgenciaMenor"
        Me.lblUrgenciaMenor.Size = New System.Drawing.Size(28, 24)
        Me.lblUrgenciaMenor.TabIndex = 11
        Me.lblUrgenciaMenor.Text = "20"
        Me.lblUrgenciaMenor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUrgencia
        '
        Me.lblUrgencia.BackColor = System.Drawing.Color.Yellow
        Me.lblUrgencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUrgencia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblUrgencia.Location = New System.Drawing.Point(667, 160)
        Me.lblUrgencia.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUrgencia.Name = "lblUrgencia"
        Me.lblUrgencia.Size = New System.Drawing.Size(28, 24)
        Me.lblUrgencia.TabIndex = 10
        Me.lblUrgencia.Text = "30"
        Me.lblUrgencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmergencia
        '
        Me.lblEmergencia.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblEmergencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmergencia.ForeColor = System.Drawing.Color.White
        Me.lblEmergencia.Location = New System.Drawing.Point(667, 136)
        Me.lblEmergencia.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmergencia.Name = "lblEmergencia"
        Me.lblEmergencia.Size = New System.Drawing.Size(28, 24)
        Me.lblEmergencia.TabIndex = 9
        Me.lblEmergencia.Text = "40"
        Me.lblEmergencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Teal
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(667, 207)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 24)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "10"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmPatologia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 537)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblUrgenciaMenor)
        Me.Controls.Add(Me.lblUrgencia)
        Me.Controls.Add(Me.lblEmergencia)
        Me.Controls.Add(Me.tabDatosPatologia)
        Me.Controls.Add(Me.toolsMenuPatologia)
        Me.Controls.Add(Me.picEncabezado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmPatologia"
        Me.Text = "PATOLOGIA"
        CType(Me.picEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolsMenuPatologia.ResumeLayout(False)
        Me.toolsMenuPatologia.PerformLayout()
        Me.tabDatosPatologia.ResumeLayout(False)
        Me.tabDatos.ResumeLayout(False)
        Me.tabDatos.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvSignosPatologia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSintomasPatologia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPatologiaBusqueda.ResumeLayout(False)
        CType(Me.dgvListaDePatologias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picEncabezado As PictureBox
    Friend WithEvents toolsMenuPatologia As ToolStrip
    Friend WithEvents mnuBtnAgregar As ToolStripButton
    Friend WithEvents tabSeparador As ToolStripSeparator
    Friend WithEvents mnuBtnGuardar As ToolStripButton
    Friend WithEvents tabSeparador1 As ToolStripSeparator
    Friend WithEvents mnuBtnCancelar As ToolStripButton
    Friend WithEvents tabSeperador2 As ToolStripSeparator
    Friend WithEvents mnuBtnNueva As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuBtnBuscar As ToolStripButton
    Friend WithEvents tabSeparador3 As ToolStripSeparator
    Friend WithEvents mnuBtnBorrar As ToolStripButton
    Friend WithEvents tabSeparador4 As ToolStripSeparator
    Friend WithEvents mnuBtnModificar As ToolStripButton
    Friend WithEvents tabDatosPatologia As TabControl
    Friend WithEvents tabDatos As TabPage
    Friend WithEvents tabPatologiaBusqueda As TabPage
    Friend WithEvents txtPatologiaID As TextBox
    Friend WithEvents lblPatologiaID As Label
    Friend WithEvents txtPatologiaNombre As TextBox
    Friend WithEvents lblPatologiaNombre As Label
    Friend WithEvents cbPatologiaPonderacion As ComboBox
    Friend WithEvents lblPatologiaPonderacion As Label
    Friend WithEvents txtPatologiaDescipcion As TextBox
    Friend WithEvents lblPatologiaDescripcion As Label
    Friend WithEvents dgvListaDePatologias As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAgregarSigno As Button
    Friend WithEvents lblSignos As Label
    Public WithEvents dgvSignosPatologia As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents lblSintomas As Label
    Friend WithEvents btnAgregarSintoma As Button
    Public WithEvents dgvSintomasPatologia As DataGridView
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents colSintomaNombre As DataGridViewTextBoxColumn
    Friend WithEvents chkActiva As CheckBox
    Friend WithEvents lblActiva As Label

    Friend WithEvents lblUrgenciaMenor As Label
    Friend WithEvents lblUrgencia As Label
    Friend WithEvents lblEmergencia As Label
    Friend WithEvents Label1 As Label
End Class
