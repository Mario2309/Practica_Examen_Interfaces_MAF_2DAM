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
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlquilarToolStripMenuItem, Me.DevolverToolStripMenuItem, Me.ConcultarAlquileresDeUnSocioToolStripMenuItem, Me.HistorialDeAlquileresToolStripMenuItem, Me.VolverToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
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
        'FormAlquiler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
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
End Class
