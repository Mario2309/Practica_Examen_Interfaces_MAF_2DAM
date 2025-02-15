<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPeliculas
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarPeliculaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarPeliculasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btnAccionPelicula = New System.Windows.Forms.Button()
        Me.btnLimpiezaPeliculas = New System.Windows.Forms.Button()
        Me.lblTituloPelicula = New System.Windows.Forms.Label()
        Me.lblDirector = New System.Windows.Forms.Label()
        Me.lblGenero = New System.Windows.Forms.Label()
        Me.lblAnio = New System.Windows.Forms.Label()
        Me.lblCalificacion = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.tbTitulo = New System.Windows.Forms.TextBox()
        Me.tbDirector = New System.Windows.Forms.TextBox()
        Me.cbGenero = New System.Windows.Forms.ComboBox()
        Me.nudAnio = New System.Windows.Forms.NumericUpDown()
        Me.nudCalificacion = New System.Windows.Forms.NumericUpDown()
        Me.tbDescripcion = New System.Windows.Forms.TextBox()
        Me.cbTitulo = New System.Windows.Forms.ComboBox()
        Me.lblTituloPeliculas = New System.Windows.Forms.Label()
        Me.lwPeliculas = New System.Windows.Forms.ListView()
        Me.btnBuscarPelicula = New System.Windows.Forms.Button()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.nudAnio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCalificacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.ModificarToolStripMenuItem, Me.ConsultarPeliculaToolStripMenuItem, Me.ConsultarPeliculasToolStripMenuItem, Me.VolverToolStripMenuItem})
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
        'ConsultarPeliculaToolStripMenuItem
        '
        Me.ConsultarPeliculaToolStripMenuItem.Name = "ConsultarPeliculaToolStripMenuItem"
        Me.ConsultarPeliculaToolStripMenuItem.Size = New System.Drawing.Size(163, 20)
        Me.ConsultarPeliculaToolStripMenuItem.Text = "Consultar pelicula concreta"
        '
        'ConsultarPeliculasToolStripMenuItem
        '
        Me.ConsultarPeliculasToolStripMenuItem.Name = "ConsultarPeliculasToolStripMenuItem"
        Me.ConsultarPeliculasToolStripMenuItem.Size = New System.Drawing.Size(119, 20)
        Me.ConsultarPeliculasToolStripMenuItem.Text = "Consultar peliculas"
        '
        'VolverToolStripMenuItem
        '
        Me.VolverToolStripMenuItem.Name = "VolverToolStripMenuItem"
        Me.VolverToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.VolverToolStripMenuItem.Text = "Volver "
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'btnAccionPelicula
        '
        Me.btnAccionPelicula.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAccionPelicula.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAccionPelicula.Location = New System.Drawing.Point(263, 377)
        Me.btnAccionPelicula.Name = "btnAccionPelicula"
        Me.btnAccionPelicula.Size = New System.Drawing.Size(111, 35)
        Me.btnAccionPelicula.TabIndex = 9
        Me.btnAccionPelicula.UseVisualStyleBackColor = True
        '
        'btnLimpiezaPeliculas
        '
        Me.btnLimpiezaPeliculas.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnLimpiezaPeliculas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnLimpiezaPeliculas.Location = New System.Drawing.Point(453, 377)
        Me.btnLimpiezaPeliculas.Name = "btnLimpiezaPeliculas"
        Me.btnLimpiezaPeliculas.Size = New System.Drawing.Size(111, 35)
        Me.btnLimpiezaPeliculas.TabIndex = 10
        Me.btnLimpiezaPeliculas.Text = "Limpiar"
        Me.btnLimpiezaPeliculas.UseVisualStyleBackColor = True
        '
        'lblTituloPelicula
        '
        Me.lblTituloPelicula.AutoSize = True
        Me.lblTituloPelicula.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloPelicula.Location = New System.Drawing.Point(78, 82)
        Me.lblTituloPelicula.Name = "lblTituloPelicula"
        Me.lblTituloPelicula.Size = New System.Drawing.Size(68, 21)
        Me.lblTituloPelicula.TabIndex = 11
        Me.lblTituloPelicula.Text = "Titulo: "
        '
        'lblDirector
        '
        Me.lblDirector.AutoSize = True
        Me.lblDirector.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDirector.Location = New System.Drawing.Point(412, 82)
        Me.lblDirector.Name = "lblDirector"
        Me.lblDirector.Size = New System.Drawing.Size(84, 21)
        Me.lblDirector.TabIndex = 12
        Me.lblDirector.Text = "Director: "
        '
        'lblGenero
        '
        Me.lblGenero.AutoSize = True
        Me.lblGenero.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenero.Location = New System.Drawing.Point(72, 156)
        Me.lblGenero.Name = "lblGenero"
        Me.lblGenero.Size = New System.Drawing.Size(74, 21)
        Me.lblGenero.TabIndex = 13
        Me.lblGenero.Text = "Genero: "
        '
        'lblAnio
        '
        Me.lblAnio.AutoSize = True
        Me.lblAnio.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnio.Location = New System.Drawing.Point(445, 156)
        Me.lblAnio.Name = "lblAnio"
        Me.lblAnio.Size = New System.Drawing.Size(51, 21)
        Me.lblAnio.TabIndex = 14
        Me.lblAnio.Text = "Año: "
        '
        'lblCalificacion
        '
        Me.lblCalificacion.AutoSize = True
        Me.lblCalificacion.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalificacion.Location = New System.Drawing.Point(33, 226)
        Me.lblCalificacion.Name = "lblCalificacion"
        Me.lblCalificacion.Size = New System.Drawing.Size(113, 21)
        Me.lblCalificacion.TabIndex = 15
        Me.lblCalificacion.Text = "Calificacion: "
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.Location = New System.Drawing.Point(385, 226)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(111, 21)
        Me.lblDescripcion.TabIndex = 16
        Me.lblDescripcion.Text = "Descripción: "
        '
        'tbTitulo
        '
        Me.tbTitulo.Location = New System.Drawing.Point(152, 82)
        Me.tbTitulo.Name = "tbTitulo"
        Me.tbTitulo.Size = New System.Drawing.Size(138, 20)
        Me.tbTitulo.TabIndex = 17
        '
        'tbDirector
        '
        Me.tbDirector.Location = New System.Drawing.Point(502, 82)
        Me.tbDirector.Name = "tbDirector"
        Me.tbDirector.Size = New System.Drawing.Size(138, 20)
        Me.tbDirector.TabIndex = 18
        '
        'cbGenero
        '
        Me.cbGenero.FormattingEnabled = True
        Me.cbGenero.Location = New System.Drawing.Point(152, 156)
        Me.cbGenero.Name = "cbGenero"
        Me.cbGenero.Size = New System.Drawing.Size(138, 21)
        Me.cbGenero.TabIndex = 19
        '
        'nudAnio
        '
        Me.nudAnio.Location = New System.Drawing.Point(503, 156)
        Me.nudAnio.Maximum = New Decimal(New Integer() {2025, 0, 0, 0})
        Me.nudAnio.Name = "nudAnio"
        Me.nudAnio.Size = New System.Drawing.Size(137, 20)
        Me.nudAnio.TabIndex = 20
        '
        'nudCalificacion
        '
        Me.nudCalificacion.Location = New System.Drawing.Point(152, 227)
        Me.nudCalificacion.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudCalificacion.Name = "nudCalificacion"
        Me.nudCalificacion.Size = New System.Drawing.Size(138, 20)
        Me.nudCalificacion.TabIndex = 21
        '
        'tbDescripcion
        '
        Me.tbDescripcion.Location = New System.Drawing.Point(503, 226)
        Me.tbDescripcion.Multiline = True
        Me.tbDescripcion.Name = "tbDescripcion"
        Me.tbDescripcion.Size = New System.Drawing.Size(231, 87)
        Me.tbDescripcion.TabIndex = 22
        '
        'cbTitulo
        '
        Me.cbTitulo.FormattingEnabled = True
        Me.cbTitulo.Location = New System.Drawing.Point(152, 82)
        Me.cbTitulo.Name = "cbTitulo"
        Me.cbTitulo.Size = New System.Drawing.Size(138, 21)
        Me.cbTitulo.TabIndex = 23
        Me.cbTitulo.Visible = False
        '
        'lblTituloPeliculas
        '
        Me.lblTituloPeliculas.AutoSize = True
        Me.lblTituloPeliculas.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloPeliculas.Location = New System.Drawing.Point(349, 76)
        Me.lblTituloPeliculas.Name = "lblTituloPeliculas"
        Me.lblTituloPeliculas.Size = New System.Drawing.Size(104, 25)
        Me.lblTituloPeliculas.TabIndex = 24
        Me.lblTituloPeliculas.Text = "Peliculas"
        '
        'lwPeliculas
        '
        Me.lwPeliculas.GridLines = True
        Me.lwPeliculas.HideSelection = False
        Me.lwPeliculas.Location = New System.Drawing.Point(37, 122)
        Me.lwPeliculas.Name = "lwPeliculas"
        Me.lwPeliculas.Size = New System.Drawing.Size(721, 276)
        Me.lwPeliculas.TabIndex = 25
        Me.lwPeliculas.UseCompatibleStateImageBehavior = False
        Me.lwPeliculas.View = System.Windows.Forms.View.Details
        '
        'btnBuscarPelicula
        '
        Me.btnBuscarPelicula.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarPelicula.Location = New System.Drawing.Point(296, 78)
        Me.btnBuscarPelicula.Name = "btnBuscarPelicula"
        Me.btnBuscarPelicula.Size = New System.Drawing.Size(69, 27)
        Me.btnBuscarPelicula.TabIndex = 46
        Me.btnBuscarPelicula.Text = "Buscar"
        Me.btnBuscarPelicula.UseVisualStyleBackColor = True
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'FormPeliculas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnBuscarPelicula)
        Me.Controls.Add(Me.lwPeliculas)
        Me.Controls.Add(Me.lblTituloPeliculas)
        Me.Controls.Add(Me.cbTitulo)
        Me.Controls.Add(Me.tbDescripcion)
        Me.Controls.Add(Me.nudCalificacion)
        Me.Controls.Add(Me.nudAnio)
        Me.Controls.Add(Me.cbGenero)
        Me.Controls.Add(Me.tbDirector)
        Me.Controls.Add(Me.tbTitulo)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblCalificacion)
        Me.Controls.Add(Me.lblAnio)
        Me.Controls.Add(Me.lblGenero)
        Me.Controls.Add(Me.lblDirector)
        Me.Controls.Add(Me.lblTituloPelicula)
        Me.Controls.Add(Me.btnLimpiezaPeliculas)
        Me.Controls.Add(Me.btnAccionPelicula)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormPeliculas"
        Me.Text = "Peliculas"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.nudAnio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCalificacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AgregarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarPeliculaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarPeliculasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VolverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents btnAccionPelicula As Button
    Friend WithEvents btnLimpiezaPeliculas As Button
    Friend WithEvents lblTituloPelicula As Label
    Friend WithEvents lblDirector As Label
    Friend WithEvents lblGenero As Label
    Friend WithEvents lblAnio As Label
    Friend WithEvents lblCalificacion As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents tbTitulo As TextBox
    Friend WithEvents tbDirector As TextBox
    Friend WithEvents cbGenero As ComboBox
    Friend WithEvents nudAnio As NumericUpDown
    Friend WithEvents nudCalificacion As NumericUpDown
    Friend WithEvents tbDescripcion As TextBox
    Friend WithEvents cbTitulo As ComboBox
    Friend WithEvents lblTituloPeliculas As Label
    Friend WithEvents lwPeliculas As ListView
    Friend WithEvents btnBuscarPelicula As Button
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
End Class
