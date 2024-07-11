<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_usuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_usuario))
        btn_ingresar = New Button()
        txt_contraseña = New TextBox()
        txt_usuario = New TextBox()
        btn_salir = New Button()
        Panel1 = New Panel()
        btn_minimizar = New Button()
        btn_maximizar = New Button()
        btn_restaurar = New Button()
        btn_cerrar = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btn_ingresar
        ' 
        btn_ingresar.Anchor = AnchorStyles.Bottom
        btn_ingresar.Location = New Point(327, 312)
        btn_ingresar.Name = "btn_ingresar"
        btn_ingresar.Size = New Size(75, 23)
        btn_ingresar.TabIndex = 0
        btn_ingresar.Text = "Ingresar"
        btn_ingresar.UseVisualStyleBackColor = True
        ' 
        ' txt_contraseña
        ' 
        txt_contraseña.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txt_contraseña.Location = New Point(260, 222)
        txt_contraseña.Name = "txt_contraseña"
        txt_contraseña.Size = New Size(210, 23)
        txt_contraseña.TabIndex = 1
        ' 
        ' txt_usuario
        ' 
        txt_usuario.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txt_usuario.Location = New Point(260, 153)
        txt_usuario.Name = "txt_usuario"
        txt_usuario.Size = New Size(210, 23)
        txt_usuario.TabIndex = 2
        ' 
        ' btn_salir
        ' 
        btn_salir.Anchor = AnchorStyles.Bottom
        btn_salir.Location = New Point(327, 368)
        btn_salir.Name = "btn_salir"
        btn_salir.Size = New Size(75, 23)
        btn_salir.TabIndex = 3
        btn_salir.Text = "Salir"
        btn_salir.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(btn_minimizar)
        Panel1.Controls.Add(btn_maximizar)
        Panel1.Controls.Add(btn_restaurar)
        Panel1.Controls.Add(btn_cerrar)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(801, 33)
        Panel1.TabIndex = 4
        ' 
        ' btn_minimizar
        ' 
        btn_minimizar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btn_minimizar.AutoSize = True
        btn_minimizar.BackColor = Color.Transparent
        btn_minimizar.BackgroundImage = CType(resources.GetObject("btn_minimizar.BackgroundImage"), Image)
        btn_minimizar.BackgroundImageLayout = ImageLayout.Center
        btn_minimizar.FlatAppearance.BorderSize = 0
        btn_minimizar.FlatAppearance.MouseDownBackColor = Color.LightSkyBlue
        btn_minimizar.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue
        btn_minimizar.FlatStyle = FlatStyle.Flat
        btn_minimizar.ForeColor = SystemColors.ControlText
        btn_minimizar.Location = New Point(657, 0)
        btn_minimizar.Name = "btn_minimizar"
        btn_minimizar.Size = New Size(44, 33)
        btn_minimizar.TabIndex = 8
        btn_minimizar.UseVisualStyleBackColor = False
        ' 
        ' btn_maximizar
        ' 
        btn_maximizar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btn_maximizar.AutoSize = True
        btn_maximizar.BackColor = Color.Transparent
        btn_maximizar.BackgroundImage = CType(resources.GetObject("btn_maximizar.BackgroundImage"), Image)
        btn_maximizar.BackgroundImageLayout = ImageLayout.Center
        btn_maximizar.FlatAppearance.BorderSize = 0
        btn_maximizar.FlatAppearance.MouseDownBackColor = Color.LightSkyBlue
        btn_maximizar.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue
        btn_maximizar.FlatStyle = FlatStyle.Flat
        btn_maximizar.ForeColor = SystemColors.ControlText
        btn_maximizar.Location = New Point(707, 0)
        btn_maximizar.Name = "btn_maximizar"
        btn_maximizar.Size = New Size(44, 33)
        btn_maximizar.TabIndex = 7
        btn_maximizar.UseVisualStyleBackColor = False
        ' 
        ' btn_restaurar
        ' 
        btn_restaurar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btn_restaurar.AutoSize = True
        btn_restaurar.BackColor = Color.Transparent
        btn_restaurar.BackgroundImage = CType(resources.GetObject("btn_restaurar.BackgroundImage"), Image)
        btn_restaurar.BackgroundImageLayout = ImageLayout.Center
        btn_restaurar.FlatAppearance.BorderSize = 0
        btn_restaurar.FlatAppearance.MouseDownBackColor = Color.LightSkyBlue
        btn_restaurar.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue
        btn_restaurar.ForeColor = SystemColors.ControlText
        btn_restaurar.Location = New Point(707, 0)
        btn_restaurar.Name = "btn_restaurar"
        btn_restaurar.Size = New Size(44, 33)
        btn_restaurar.TabIndex = 6
        btn_restaurar.UseVisualStyleBackColor = False
        ' 
        ' btn_cerrar
        ' 
        btn_cerrar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btn_cerrar.AutoSize = True
        btn_cerrar.BackColor = Color.Transparent
        btn_cerrar.BackgroundImage = My.Resources.Resources._9110796_x_icon
        btn_cerrar.BackgroundImageLayout = ImageLayout.Center
        btn_cerrar.FlatAppearance.BorderSize = 0
        btn_cerrar.FlatAppearance.MouseDownBackColor = Color.LightSkyBlue
        btn_cerrar.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue
        btn_cerrar.FlatStyle = FlatStyle.Flat
        btn_cerrar.ForeColor = SystemColors.ControlText
        btn_cerrar.Location = New Point(757, 0)
        btn_cerrar.Name = "btn_cerrar"
        btn_cerrar.Size = New Size(44, 33)
        btn_cerrar.TabIndex = 5
        btn_cerrar.UseVisualStyleBackColor = False
        ' 
        ' frm_usuario
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.fondo_loggin
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(btn_salir)
        Controls.Add(txt_usuario)
        Controls.Add(txt_contraseña)
        Controls.Add(btn_ingresar)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "frm_usuario"
        Text = "frm_usuario"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_ingresar As Button
    Friend WithEvents txt_contraseña As TextBox
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents btn_salir As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_minimizar As Button
    Friend WithEvents btn_maximizar As Button
    Friend WithEvents btn_restaurar As Button
    Friend WithEvents btn_cerrar As Button
End Class
