<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_menu))
        Panel1 = New Panel()
        btn_salir = New Button()
        btn_asignar = New Button()
        btn_estudidantes = New Button()
        Panel3 = New Panel()
        Panel2 = New Panel()
        btn_agregar = New Button()
        btn_cerrar = New Button()
        btn_restaurar = New Button()
        btn_maximizar = New Button()
        btn_minimizar = New Button()
        panel_contenedor = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.MidnightBlue
        Panel1.Controls.Add(btn_salir)
        Panel1.Controls.Add(btn_asignar)
        Panel1.Controls.Add(btn_estudidantes)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(btn_agregar)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(164, 620)
        Panel1.TabIndex = 0
        ' 
        ' btn_salir
        ' 
        btn_salir.BackColor = Color.MidnightBlue
        btn_salir.FlatAppearance.BorderSize = 0
        btn_salir.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue
        btn_salir.FlatAppearance.MouseOverBackColor = Color.PowderBlue
        btn_salir.FlatStyle = FlatStyle.Flat
        btn_salir.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_salir.ForeColor = Color.DeepSkyBlue
        btn_salir.Location = New Point(0, 533)
        btn_salir.Name = "btn_salir"
        btn_salir.Size = New Size(144, 50)
        btn_salir.TabIndex = 7
        btn_salir.Text = "Salir"
        btn_salir.UseVisualStyleBackColor = False
        ' 
        ' btn_asignar
        ' 
        btn_asignar.BackColor = Color.MidnightBlue
        btn_asignar.FlatAppearance.BorderSize = 0
        btn_asignar.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue
        btn_asignar.FlatAppearance.MouseOverBackColor = Color.PowderBlue
        btn_asignar.FlatStyle = FlatStyle.Flat
        btn_asignar.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_asignar.ForeColor = Color.DeepSkyBlue
        btn_asignar.Location = New Point(0, 426)
        btn_asignar.Name = "btn_asignar"
        btn_asignar.Size = New Size(164, 50)
        btn_asignar.TabIndex = 6
        btn_asignar.Text = "Asignar materias"
        btn_asignar.UseVisualStyleBackColor = False
        ' 
        ' btn_estudidantes
        ' 
        btn_estudidantes.BackColor = Color.MidnightBlue
        btn_estudidantes.FlatAppearance.BorderSize = 0
        btn_estudidantes.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue
        btn_estudidantes.FlatAppearance.MouseOverBackColor = Color.PowderBlue
        btn_estudidantes.FlatStyle = FlatStyle.Flat
        btn_estudidantes.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_estudidantes.ForeColor = Color.DeepSkyBlue
        btn_estudidantes.Location = New Point(3, 321)
        btn_estudidantes.Name = "btn_estudidantes"
        btn_estudidantes.Size = New Size(144, 50)
        btn_estudidantes.TabIndex = 5
        btn_estudidantes.Text = "Ver estudiantes"
        btn_estudidantes.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.Location = New Point(143, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(658, 31)
        Panel3.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImage = My.Resources.Resources.frase
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.Location = New Point(0, 37)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(164, 110)
        Panel2.TabIndex = 4
        ' 
        ' btn_agregar
        ' 
        btn_agregar.BackColor = Color.MidnightBlue
        btn_agregar.FlatAppearance.BorderSize = 0
        btn_agregar.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue
        btn_agregar.FlatAppearance.MouseOverBackColor = Color.PowderBlue
        btn_agregar.FlatStyle = FlatStyle.Flat
        btn_agregar.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_agregar.ForeColor = Color.DeepSkyBlue
        btn_agregar.Location = New Point(0, 210)
        btn_agregar.Name = "btn_agregar"
        btn_agregar.Size = New Size(144, 50)
        btn_agregar.TabIndex = 0
        btn_agregar.Text = "Matricular"
        btn_agregar.UseVisualStyleBackColor = False
        ' 
        ' btn_cerrar
        ' 
        btn_cerrar.AutoSize = True
        btn_cerrar.BackColor = Color.Transparent
        btn_cerrar.BackgroundImage = My.Resources.Resources._9110796_x_icon
        btn_cerrar.BackgroundImageLayout = ImageLayout.Center
        btn_cerrar.FlatAppearance.BorderSize = 0
        btn_cerrar.FlatAppearance.MouseDownBackColor = Color.LightSkyBlue
        btn_cerrar.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue
        btn_cerrar.FlatStyle = FlatStyle.Flat
        btn_cerrar.ForeColor = SystemColors.ControlText
        btn_cerrar.Location = New Point(890, 0)
        btn_cerrar.Name = "btn_cerrar"
        btn_cerrar.Size = New Size(44, 31)
        btn_cerrar.TabIndex = 1
        btn_cerrar.UseVisualStyleBackColor = False
        ' 
        ' btn_restaurar
        ' 
        btn_restaurar.AutoSize = True
        btn_restaurar.BackColor = Color.Transparent
        btn_restaurar.BackgroundImage = CType(resources.GetObject("btn_restaurar.BackgroundImage"), Image)
        btn_restaurar.BackgroundImageLayout = ImageLayout.Center
        btn_restaurar.FlatAppearance.BorderSize = 0
        btn_restaurar.FlatAppearance.MouseDownBackColor = Color.LightSkyBlue
        btn_restaurar.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue
        btn_restaurar.FlatStyle = FlatStyle.Flat
        btn_restaurar.ForeColor = SystemColors.ControlText
        btn_restaurar.Location = New Point(841, 0)
        btn_restaurar.Name = "btn_restaurar"
        btn_restaurar.Size = New Size(44, 31)
        btn_restaurar.TabIndex = 2
        btn_restaurar.UseVisualStyleBackColor = False
        ' 
        ' btn_maximizar
        ' 
        btn_maximizar.AutoSize = True
        btn_maximizar.BackColor = Color.Transparent
        btn_maximizar.BackgroundImage = CType(resources.GetObject("btn_maximizar.BackgroundImage"), Image)
        btn_maximizar.BackgroundImageLayout = ImageLayout.Center
        btn_maximizar.FlatAppearance.BorderSize = 0
        btn_maximizar.FlatAppearance.MouseDownBackColor = Color.LightSkyBlue
        btn_maximizar.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue
        btn_maximizar.FlatStyle = FlatStyle.Flat
        btn_maximizar.ForeColor = SystemColors.ControlText
        btn_maximizar.Location = New Point(841, 0)
        btn_maximizar.Name = "btn_maximizar"
        btn_maximizar.Size = New Size(44, 31)
        btn_maximizar.TabIndex = 3
        btn_maximizar.UseVisualStyleBackColor = False
        ' 
        ' btn_minimizar
        ' 
        btn_minimizar.AutoSize = True
        btn_minimizar.BackColor = Color.Transparent
        btn_minimizar.BackgroundImage = CType(resources.GetObject("btn_minimizar.BackgroundImage"), Image)
        btn_minimizar.BackgroundImageLayout = ImageLayout.Center
        btn_minimizar.FlatAppearance.BorderSize = 0
        btn_minimizar.FlatAppearance.MouseDownBackColor = Color.LightSkyBlue
        btn_minimizar.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue
        btn_minimizar.FlatStyle = FlatStyle.Flat
        btn_minimizar.ForeColor = SystemColors.ControlText
        btn_minimizar.Location = New Point(791, 0)
        btn_minimizar.Name = "btn_minimizar"
        btn_minimizar.Size = New Size(44, 31)
        btn_minimizar.TabIndex = 4
        btn_minimizar.UseVisualStyleBackColor = False
        ' 
        ' panel_contenedor
        ' 
        panel_contenedor.BackColor = Color.Transparent
        panel_contenedor.Location = New Point(170, 37)
        panel_contenedor.Name = "panel_contenedor"
        panel_contenedor.Size = New Size(764, 583)
        panel_contenedor.TabIndex = 5
        ' 
        ' frm_menu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.fondo_loggin
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(936, 620)
        Controls.Add(panel_contenedor)
        Controls.Add(btn_minimizar)
        Controls.Add(btn_maximizar)
        Controls.Add(btn_restaurar)
        Controls.Add(btn_cerrar)
        Controls.Add(Panel1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "frm_menu"
        Text = "frm_menu"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_agregar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_cerrar As Button
    Friend WithEvents btn_restaurar As Button
    Friend WithEvents btn_maximizar As Button
    Friend WithEvents btn_minimizar As Button
    Friend WithEvents btn_salir As Button
    Friend WithEvents btn_asignar As Button
    Friend WithEvents btn_estudidantes As Button
    Friend WithEvents panel_contenedor As Panel
End Class
