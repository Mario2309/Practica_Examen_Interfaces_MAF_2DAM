<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAlquiler
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AlquilarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DevolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConcultarAlquileresDeUnSocioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistorialDeAlquileresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.lbPelicula = New System.Windows.Forms.Label()
        Me.cbPeliculas = New System.Windows.Forms.ComboBox()
        Me.btnAccionAlquileres = New System.Windows.Forms.Button()
        Me.btnBuscarDNI = New System.Windows.Forms.Button()
        Me.lblTituloAlquileres = New System.Windows.Forms.Label()
        Me.lwAlquileres = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.tbDNI = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlquilarToolStripMenuItem, Me.DevolverToolStripMenuItem, Me.ConcultarAlquileresDeUnSocioToolStripMenuItem, Me.HistorialDeAlquileresToolStripMenuItem, Me.VolverToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(541, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AlquilarToolStripMenuItem
        '
        Me.AlquilarToolStripMenuItem.Name = "AlquilarToolStripMenuItem"
        Me.AlquilarToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.AlquilarToolStripMenuItem.Text = "Alquilar"
        '
        'DevolverToolStripMenuItem
        '
        Me.DevolverToolStripMenuItem.Name = "DevolverToolStripMenuItem"
        Me.DevolverToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.DevolverToolStripMenuItem.Text = "Devolver"
        '
        'ConcultarAlquileresDeUnSocioToolStripMenuItem
        '
        Me.ConcultarAlquileresDeUnSocioToolStripMenuItem.Name = "ConcultarAlquileresDeUnSocioToolStripMenuItem"
        Me.ConcultarAlquileresDeUnSocioToolStripMenuItem.Size = New System.Drawing.Size(191, 20)
        Me.ConcultarAlquileresDeUnSocioToolStripMenuItem.Text = "Concultar alquileres de un socio "
        '
        'HistorialDeAlquileresToolStripMenuItem
        '
        Me.HistorialDeAlquileresToolStripMenuItem.Name = "HistorialDeAlquileresToolStripMenuItem"
        Me.HistorialDeAlquileresToolStripMenuItem.Size = New System.Drawing.Size(132, 20)
        Me.HistorialDeAlquileresToolStripMenuItem.Text = "Historial de alquileres"
        '
        'VolverToolStripMenuItem
        '
        Me.VolverToolStripMenuItem.Name = "VolverToolStripMenuItem"
        Me.VolverToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.VolverToolStripMenuItem.Text = "Volver"
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.lblDNI.Location = New System.Drawing.Point(34, 48)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(51, 24)
        Me.lblDNI.TabIndex = 1
        Me.lblDNI.Text = "DNI: "
        '
        'lbPelicula
        '
        Me.lbPelicula.AutoSize = True
        Me.lbPelicula.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.lbPelicula.Location = New System.Drawing.Point(282, 48)
        Me.lbPelicula.Name = "lbPelicula"
        Me.lbPelicula.Size = New System.Drawing.Size(86, 24)
        Me.lbPelicula.TabIndex = 2
        Me.lbPelicula.Text = "Pelicula: "
        '
        'cbPeliculas
        '
        Me.cbPeliculas.FormattingEnabled = True
        Me.cbPeliculas.Location = New System.Drawing.Point(387, 51)
        Me.cbPeliculas.Name = "cbPeliculas"
        Me.cbPeliculas.Size = New System.Drawing.Size(121, 21)
        Me.cbPeliculas.TabIndex = 5
        '
        'btnAccionAlquileres
        '
        Me.btnAccionAlquileres.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAccionAlquileres.Location = New System.Drawing.Point(208, 108)
        Me.btnAccionAlquileres.Name = "btnAccionAlquileres"
        Me.btnAccionAlquileres.Size = New System.Drawing.Size(146, 29)
        Me.btnAccionAlquileres.TabIndex = 6
        Me.btnAccionAlquileres.UseVisualStyleBackColor = True
        '
        'btnBuscarDNI
        '
        Me.btnBuscarDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarDNI.Location = New System.Drawing.Point(197, 48)
        Me.btnBuscarDNI.Name = "btnBuscarDNI"
        Me.btnBuscarDNI.Size = New System.Drawing.Size(69, 27)
        Me.btnBuscarDNI.TabIndex = 47
        Me.btnBuscarDNI.Text = "Buscar"
        Me.btnBuscarDNI.UseVisualStyleBackColor = True
        '
        'lblTituloAlquileres
        '
        Me.lblTituloAlquileres.AutoSize = True
        Me.lblTituloAlquileres.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloAlquileres.Location = New System.Drawing.Point(299, 44)
        Me.lblTituloAlquileres.Name = "lblTituloAlquileres"
        Me.lblTituloAlquileres.Size = New System.Drawing.Size(121, 29)
        Me.lblTituloAlquileres.TabIndex = 48
        Me.lblTituloAlquileres.Text = "Alquileres"
        '
        'lwAlquileres
        '
        Me.lwAlquileres.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lwAlquileres.GridLines = True
        Me.lwAlquileres.HideSelection = False
        Me.lwAlquileres.Location = New System.Drawing.Point(38, 100)
        Me.lwAlquileres.Name = "lwAlquileres"
        Me.lwAlquileres.Size = New System.Drawing.Size(470, 102)
        Me.lwAlquileres.TabIndex = 49
        Me.lwAlquileres.UseCompatibleStateImageBehavior = False
        Me.lwAlquileres.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 39
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "SOCIO"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "PELICULA"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 71
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "FECHA_ALQUILER"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 110
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "FECHA_DEVOLUCION"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 126
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "ESTADO"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnLimpiar.Location = New System.Drawing.Point(208, 225)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(111, 35)
        Me.btnLimpiar.TabIndex = 50
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'tbDNI
        '
        Me.tbDNI.Location = New System.Drawing.Point(91, 52)
        Me.tbDNI.Name = "tbDNI"
        Me.tbDNI.Size = New System.Drawing.Size(100, 20)
        Me.tbDNI.TabIndex = 3
        '
        'FormAlquiler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 334)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.lwAlquileres)
        Me.Controls.Add(Me.lblTituloAlquileres)
        Me.Controls.Add(Me.btnBuscarDNI)
        Me.Controls.Add(Me.btnAccionAlquileres)
        Me.Controls.Add(Me.cbPeliculas)
        Me.Controls.Add(Me.tbDNI)
        Me.Controls.Add(Me.lbPelicula)
        Me.Controls.Add(Me.lblDNI)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormAlquiler"
        Me.Text = "Alquileres"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AlquilarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DevolverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConcultarAlquileresDeUnSocioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistorialDeAlquileresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VolverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblDNI As Label
    Friend WithEvents lbPelicula As Label
    Friend WithEvents cbPeliculas As ComboBox
    Friend WithEvents btnAccionAlquileres As Button
    Friend WithEvents btnBuscarDNI As Button
    Friend WithEvents lblTituloAlquileres As Label
    Friend WithEvents lwAlquileres As ListView
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents tbDNI As TextBox
End Class
