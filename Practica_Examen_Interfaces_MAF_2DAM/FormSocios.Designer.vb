<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSocios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarSocioConcretoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarSociosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblTituloSocios = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.lblFechaNacimiento = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.tbDNI = New System.Windows.Forms.TextBox()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.tbApellido = New System.Windows.Forms.TextBox()
        Me.tbDireccion = New System.Windows.Forms.TextBox()
        Me.tbTelefono = New System.Windows.Forms.TextBox()
        Me.tbCorreo = New System.Windows.Forms.TextBox()
        Me.dtpNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.btnLimpiezaSocio = New System.Windows.Forms.Button()
        Me.btnAccionSocio = New System.Windows.Forms.Button()
        Me.cbDNI = New System.Windows.Forms.ComboBox()
        Me.lwSocios = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnBuscarSocio = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.ModificarToolStripMenuItem, Me.ConsultarSocioConcretoToolStripMenuItem, Me.ConsultarSociosToolStripMenuItem, Me.VolverToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.AgregarToolStripMenuItem.Text = "Agregar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'ConsultarSocioConcretoToolStripMenuItem
        '
        Me.ConsultarSocioConcretoToolStripMenuItem.Name = "ConsultarSocioConcretoToolStripMenuItem"
        Me.ConsultarSocioConcretoToolStripMenuItem.Size = New System.Drawing.Size(151, 20)
        Me.ConsultarSocioConcretoToolStripMenuItem.Text = "Consultar socio concreto"
        '
        'ConsultarSociosToolStripMenuItem
        '
        Me.ConsultarSociosToolStripMenuItem.Name = "ConsultarSociosToolStripMenuItem"
        Me.ConsultarSociosToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.ConsultarSociosToolStripMenuItem.Text = "Consultar socios"
        '
        'VolverToolStripMenuItem
        '
        Me.VolverToolStripMenuItem.Name = "VolverToolStripMenuItem"
        Me.VolverToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.VolverToolStripMenuItem.Text = "Volver"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(429, 82)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(79, 21)
        Me.lblNombre.TabIndex = 12
        Me.lblNombre.Text = "Nombre: "
        '
        'lblTituloSocios
        '
        Me.lblTituloSocios.AutoSize = True
        Me.lblTituloSocios.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloSocios.Location = New System.Drawing.Point(360, 53)
        Me.lblTituloSocios.Name = "lblTituloSocios"
        Me.lblTituloSocios.Size = New System.Drawing.Size(73, 25)
        Me.lblTituloSocios.TabIndex = 25
        Me.lblTituloSocios.Text = "Socios"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.Location = New System.Drawing.Point(90, 158)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(85, 21)
        Me.lblApellido.TabIndex = 26
        Me.lblApellido.Text = "Apellido: "
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDNI.Location = New System.Drawing.Point(121, 82)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(54, 21)
        Me.lblDNI.TabIndex = 27
        Me.lblDNI.Text = "DNI: "
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(413, 158)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(95, 21)
        Me.lblDireccion.TabIndex = 28
        Me.lblDireccion.Text = "Direccion: "
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(87, 239)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(88, 21)
        Me.lblTelefono.TabIndex = 29
        Me.lblTelefono.Text = "Telefono: "
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.Location = New System.Drawing.Point(439, 239)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(69, 21)
        Me.lblCorreo.TabIndex = 30
        Me.lblCorreo.Text = "Correo: "
        '
        'lblFechaNacimiento
        '
        Me.lblFechaNacimiento.AutoSize = True
        Me.lblFechaNacimiento.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(14, 307)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.Size = New System.Drawing.Size(161, 21)
        Me.lblFechaNacimiento.TabIndex = 31
        Me.lblFechaNacimiento.Text = "Fecha Nacimiento: "
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.Location = New System.Drawing.Point(436, 307)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(72, 21)
        Me.lblEstado.TabIndex = 32
        Me.lblEstado.Text = "Estado: "
        '
        'tbDNI
        '
        Me.tbDNI.Location = New System.Drawing.Point(181, 85)
        Me.tbDNI.MaxLength = 9
        Me.tbDNI.Name = "tbDNI"
        Me.tbDNI.Size = New System.Drawing.Size(122, 20)
        Me.tbDNI.TabIndex = 33
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(514, 85)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(122, 20)
        Me.tbNombre.TabIndex = 34
        '
        'tbApellido
        '
        Me.tbApellido.Location = New System.Drawing.Point(181, 158)
        Me.tbApellido.Name = "tbApellido"
        Me.tbApellido.Size = New System.Drawing.Size(122, 20)
        Me.tbApellido.TabIndex = 35
        '
        'tbDireccion
        '
        Me.tbDireccion.Location = New System.Drawing.Point(514, 161)
        Me.tbDireccion.Name = "tbDireccion"
        Me.tbDireccion.Size = New System.Drawing.Size(183, 20)
        Me.tbDireccion.TabIndex = 36
        '
        'tbTelefono
        '
        Me.tbTelefono.Location = New System.Drawing.Point(181, 242)
        Me.tbTelefono.MaxLength = 9
        Me.tbTelefono.Name = "tbTelefono"
        Me.tbTelefono.Size = New System.Drawing.Size(122, 20)
        Me.tbTelefono.TabIndex = 37
        '
        'tbCorreo
        '
        Me.tbCorreo.Location = New System.Drawing.Point(514, 242)
        Me.tbCorreo.Name = "tbCorreo"
        Me.tbCorreo.Size = New System.Drawing.Size(183, 20)
        Me.tbCorreo.TabIndex = 38
        '
        'dtpNacimiento
        '
        Me.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNacimiento.Location = New System.Drawing.Point(181, 308)
        Me.dtpNacimiento.Name = "dtpNacimiento"
        Me.dtpNacimiento.Size = New System.Drawing.Size(122, 20)
        Me.dtpNacimiento.TabIndex = 39
        '
        'cbEstado
        '
        Me.cbEstado.FormattingEnabled = True
        Me.cbEstado.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.cbEstado.Location = New System.Drawing.Point(514, 306)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(122, 21)
        Me.cbEstado.TabIndex = 40
        '
        'btnLimpiezaSocio
        '
        Me.btnLimpiezaSocio.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnLimpiezaSocio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnLimpiezaSocio.Location = New System.Drawing.Point(443, 359)
        Me.btnLimpiezaSocio.Name = "btnLimpiezaSocio"
        Me.btnLimpiezaSocio.Size = New System.Drawing.Size(111, 35)
        Me.btnLimpiezaSocio.TabIndex = 42
        Me.btnLimpiezaSocio.Text = "Limpiar"
        Me.btnLimpiezaSocio.UseVisualStyleBackColor = True
        '
        'btnAccionSocio
        '
        Me.btnAccionSocio.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAccionSocio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAccionSocio.Location = New System.Drawing.Point(253, 359)
        Me.btnAccionSocio.Name = "btnAccionSocio"
        Me.btnAccionSocio.Size = New System.Drawing.Size(111, 35)
        Me.btnAccionSocio.TabIndex = 41
        Me.btnAccionSocio.UseVisualStyleBackColor = True
        '
        'cbDNI
        '
        Me.cbDNI.FormattingEnabled = True
        Me.cbDNI.Location = New System.Drawing.Point(182, 85)
        Me.cbDNI.Name = "cbDNI"
        Me.cbDNI.Size = New System.Drawing.Size(121, 21)
        Me.cbDNI.TabIndex = 43
        '
        'lwSocios
        '
        Me.lwSocios.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.lwSocios.GridLines = True
        Me.lwSocios.HideSelection = False
        Me.lwSocios.Location = New System.Drawing.Point(34, 97)
        Me.lwSocios.Name = "lwSocios"
        Me.lwSocios.Size = New System.Drawing.Size(721, 276)
        Me.lwSocios.TabIndex = 44
        Me.lwSocios.UseCompatibleStateImageBehavior = False
        Me.lwSocios.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "NOMBRE"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "APELLIDO"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "DNI"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "DIRECCION"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "TELEFONO"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "EMAIL"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "NACIMIENTO"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "REGISTRO"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "ESTADO"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnBuscarSocio
        '
        Me.btnBuscarSocio.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarSocio.Location = New System.Drawing.Point(309, 81)
        Me.btnBuscarSocio.Name = "btnBuscarSocio"
        Me.btnBuscarSocio.Size = New System.Drawing.Size(69, 27)
        Me.btnBuscarSocio.TabIndex = 45
        Me.btnBuscarSocio.Text = "Buscar"
        Me.btnBuscarSocio.UseVisualStyleBackColor = True
        '
        'FormSocios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnBuscarSocio)
        Me.Controls.Add(Me.lwSocios)
        Me.Controls.Add(Me.cbDNI)
        Me.Controls.Add(Me.btnLimpiezaSocio)
        Me.Controls.Add(Me.btnAccionSocio)
        Me.Controls.Add(Me.cbEstado)
        Me.Controls.Add(Me.dtpNacimiento)
        Me.Controls.Add(Me.tbCorreo)
        Me.Controls.Add(Me.tbTelefono)
        Me.Controls.Add(Me.tbDireccion)
        Me.Controls.Add(Me.tbApellido)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.tbDNI)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.lblFechaNacimiento)
        Me.Controls.Add(Me.lblCorreo)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.lblDNI)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.lblTituloSocios)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormSocios"
        Me.Text = "FormSocios"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AgregarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarSocioConcretoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarSociosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VolverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblTituloSocios As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblDNI As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblCorreo As Label
    Friend WithEvents lblFechaNacimiento As Label
    Friend WithEvents lblEstado As Label
    Friend WithEvents tbDNI As TextBox
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents tbApellido As TextBox
    Friend WithEvents tbDireccion As TextBox
    Friend WithEvents tbTelefono As TextBox
    Friend WithEvents tbCorreo As TextBox
    Friend WithEvents dtpNacimiento As DateTimePicker
    Friend WithEvents cbEstado As ComboBox
    Friend WithEvents btnLimpiezaSocio As Button
    Friend WithEvents btnAccionSocio As Button
    Friend WithEvents cbDNI As ComboBox
    Friend WithEvents lwSocios As ListView
    Friend WithEvents btnBuscarSocio As Button
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
End Class
