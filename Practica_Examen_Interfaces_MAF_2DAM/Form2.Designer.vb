<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioElecAccion
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnAbrirPeliculas = New System.Windows.Forms.Button()
        Me.btnAbrirSocios = New System.Windows.Forms.Button()
        Me.btnAbrirAlquiler = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnVolverInicio = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(290, 26)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(227, 36)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Mario's Films"
        '
        'btnAbrirPeliculas
        '
        Me.btnAbrirPeliculas.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAbrirPeliculas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAbrirPeliculas.Location = New System.Drawing.Point(94, 332)
        Me.btnAbrirPeliculas.Name = "btnAbrirPeliculas"
        Me.btnAbrirPeliculas.Size = New System.Drawing.Size(111, 35)
        Me.btnAbrirPeliculas.TabIndex = 2
        Me.btnAbrirPeliculas.Text = "Peliculas"
        Me.btnAbrirPeliculas.UseVisualStyleBackColor = True
        '
        'btnAbrirSocios
        '
        Me.btnAbrirSocios.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAbrirSocios.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAbrirSocios.Location = New System.Drawing.Point(349, 332)
        Me.btnAbrirSocios.Name = "btnAbrirSocios"
        Me.btnAbrirSocios.Size = New System.Drawing.Size(111, 35)
        Me.btnAbrirSocios.TabIndex = 3
        Me.btnAbrirSocios.Text = "Socios"
        Me.btnAbrirSocios.UseVisualStyleBackColor = True
        '
        'btnAbrirAlquiler
        '
        Me.btnAbrirAlquiler.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAbrirAlquiler.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAbrirAlquiler.Location = New System.Drawing.Point(608, 332)
        Me.btnAbrirAlquiler.Name = "btnAbrirAlquiler"
        Me.btnAbrirAlquiler.Size = New System.Drawing.Size(111, 35)
        Me.btnAbrirAlquiler.TabIndex = 4
        Me.btnAbrirAlquiler.Text = "Alquiler"
        Me.btnAbrirAlquiler.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Image = Global.Practica_Examen_Interfaces_MAF_2DAM.My.Resources.Resources.Logo_Mario_S_Films
        Me.PictureBox2.Location = New System.Drawing.Point(277, 79)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(258, 235)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'btnVolverInicio
        '
        Me.btnVolverInicio.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnVolverInicio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnVolverInicio.Location = New System.Drawing.Point(349, 384)
        Me.btnVolverInicio.Name = "btnVolverInicio"
        Me.btnVolverInicio.Size = New System.Drawing.Size(111, 35)
        Me.btnVolverInicio.TabIndex = 8
        Me.btnVolverInicio.Text = "Salir"
        Me.btnVolverInicio.UseVisualStyleBackColor = True
        '
        'FormularioElecAccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnVolverInicio)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnAbrirAlquiler)
        Me.Controls.Add(Me.btnAbrirSocios)
        Me.Controls.Add(Me.btnAbrirPeliculas)
        Me.Controls.Add(Me.lblTitle)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormularioElecAccion"
        Me.Text = "Menu Acciones"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnAbrirPeliculas As Button
    Friend WithEvents btnAbrirSocios As Button
    Friend WithEvents btnAbrirAlquiler As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnVolverInicio As Button
End Class
