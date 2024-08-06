<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_asiganr
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
        components = New ComponentModel.Container()
        dgv_apro = New DataGridView()
        ID_Materia = New DataGridViewTextBoxColumn()
        Nombre_materia = New DataGridViewTextBoxColumn()
        Estado = New DataGridViewTextBoxColumn()
        dgv_pend = New DataGridView()
        DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn3 = New DataGridViewTextBoxColumn()
        dgv_matri = New DataGridView()
        DataGridViewTextBoxColumn4 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn5 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn6 = New DataGridViewTextBoxColumn()
        txt_identificacion = New TextBox()
        txt_nombre_estudiante = New TextBox()
        txt_carrera = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Button1 = New Button()
        btn_pend_apro = New Button()
        Button3 = New Button()
        btn_matriculadas_aprobadas = New Button()
        btn_matri_pend = New Button()
        btn_pend_matri = New Button()
        lbl_porc_apro = New Label()
        btn_buscar = New Button()
        pb_aprobadas = New ProgressBar()
        Label7 = New Label()
        lbl_materia_matri = New Label()
        lbl_materia_pend = New Label()
        lbl_materia_apro = New Label()
        txt_nota_obtenida = New TextBox()
        Label8 = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        CType(dgv_apro, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgv_pend, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgv_matri, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgv_apro
        ' 
        dgv_apro.AllowUserToAddRows = False
        dgv_apro.BackgroundColor = SystemColors.MenuHighlight
        dgv_apro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_apro.Columns.AddRange(New DataGridViewColumn() {ID_Materia, Nombre_materia, Estado})
        dgv_apro.Location = New Point(-3, 247)
        dgv_apro.Name = "dgv_apro"
        dgv_apro.Size = New Size(337, 487)
        dgv_apro.TabIndex = 0
        ' 
        ' ID_Materia
        ' 
        ID_Materia.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ID_Materia.HeaderText = "ID Materia"
        ID_Materia.Name = "ID_Materia"
        ' 
        ' Nombre_materia
        ' 
        Nombre_materia.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Nombre_materia.HeaderText = "Nombre Materia"
        Nombre_materia.Name = "Nombre_materia"
        ' 
        ' Estado
        ' 
        Estado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Estado.HeaderText = "Estado"
        Estado.Name = "Estado"
        ' 
        ' dgv_pend
        ' 
        dgv_pend.AllowUserToAddRows = False
        dgv_pend.BackgroundColor = SystemColors.MenuHighlight
        dgv_pend.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_pend.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn1, DataGridViewTextBoxColumn2, DataGridViewTextBoxColumn3})
        dgv_pend.Location = New Point(421, 247)
        dgv_pend.Name = "dgv_pend"
        dgv_pend.Size = New Size(353, 487)
        dgv_pend.TabIndex = 1
        ' 
        ' DataGridViewTextBoxColumn1
        ' 
        DataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewTextBoxColumn1.FillWeight = 78.88146F
        DataGridViewTextBoxColumn1.HeaderText = "ID Materia"
        DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        ' 
        ' DataGridViewTextBoxColumn2
        ' 
        DataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewTextBoxColumn2.FillWeight = 114.519554F
        DataGridViewTextBoxColumn2.HeaderText = "Nombre Materia"
        DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        ' 
        ' DataGridViewTextBoxColumn3
        ' 
        DataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewTextBoxColumn3.FillWeight = 106.598984F
        DataGridViewTextBoxColumn3.HeaderText = "Estado"
        DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        ' 
        ' dgv_matri
        ' 
        dgv_matri.BackgroundColor = SystemColors.MenuHighlight
        dgv_matri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_matri.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn4, DataGridViewTextBoxColumn5, DataGridViewTextBoxColumn6})
        dgv_matri.Location = New Point(861, 247)
        dgv_matri.Name = "dgv_matri"
        dgv_matri.Size = New Size(349, 487)
        dgv_matri.TabIndex = 2
        ' 
        ' DataGridViewTextBoxColumn4
        ' 
        DataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewTextBoxColumn4.HeaderText = "ID Materia"
        DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        ' 
        ' DataGridViewTextBoxColumn5
        ' 
        DataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewTextBoxColumn5.HeaderText = "Nombre Materia"
        DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        ' 
        ' DataGridViewTextBoxColumn6
        ' 
        DataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewTextBoxColumn6.HeaderText = "Estado"
        DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        ' 
        ' txt_identificacion
        ' 
        txt_identificacion.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_identificacion.Location = New Point(156, 53)
        txt_identificacion.Name = "txt_identificacion"
        txt_identificacion.Size = New Size(100, 26)
        txt_identificacion.TabIndex = 3
        ' 
        ' txt_nombre_estudiante
        ' 
        txt_nombre_estudiante.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_nombre_estudiante.Location = New Point(1037, 29)
        txt_nombre_estudiante.Name = "txt_nombre_estudiante"
        txt_nombre_estudiante.Size = New Size(163, 26)
        txt_nombre_estudiante.TabIndex = 4
        ' 
        ' txt_carrera
        ' 
        txt_carrera.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_carrera.Location = New Point(1037, 90)
        txt_carrera.Name = "txt_carrera"
        txt_carrera.Size = New Size(163, 26)
        txt_carrera.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(16, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(134, 24)
        Label1.TabIndex = 6
        Label1.Text = "Identificacion"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(829, 28)
        Label2.Name = "Label2"
        Label2.Size = New Size(185, 24)
        Label2.TabIndex = 7
        Label2.Text = "Nombre estudiante"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(918, 89)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 24)
        Label3.TabIndex = 8
        Label3.Text = "Carrera"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(107, 203)
        Label4.Name = "Label4"
        Label4.Size = New Size(98, 25)
        Label4.TabIndex = 9
        Label4.Text = "Aprobadas"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(558, 213)
        Label5.Name = "Label5"
        Label5.Size = New Size(115, 24)
        Label5.TabIndex = 10
        Label5.Text = "Pendientes"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(1015, 211)
        Label6.Name = "Label6"
        Label6.Size = New Size(129, 24)
        Label6.TabIndex = 11
        Label6.Text = "Matriculadas"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(335, 410)
        Button1.Name = "Button1"
        Button1.Size = New Size(85, 23)
        Button1.TabIndex = 12
        Button1.Text = "Pendiente >"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btn_pend_apro
        ' 
        btn_pend_apro.Location = New Point(335, 510)
        btn_pend_apro.Name = "btn_pend_apro"
        btn_pend_apro.Size = New Size(85, 23)
        btn_pend_apro.TabIndex = 13
        btn_pend_apro.Text = "< Aprobadas"
        btn_pend_apro.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(335, 610)
        Button3.Name = "Button3"
        Button3.Size = New Size(85, 23)
        Button3.TabIndex = 14
        Button3.Text = "Matricular>>"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' btn_matriculadas_aprobadas
        ' 
        btn_matriculadas_aprobadas.Location = New Point(776, 610)
        btn_matriculadas_aprobadas.Name = "btn_matriculadas_aprobadas"
        btn_matriculadas_aprobadas.Size = New Size(85, 23)
        btn_matriculadas_aprobadas.TabIndex = 17
        btn_matriculadas_aprobadas.Text = "<<Aprobar"
        btn_matriculadas_aprobadas.UseVisualStyleBackColor = True
        ' 
        ' btn_matri_pend
        ' 
        btn_matri_pend.Location = New Point(776, 410)
        btn_matri_pend.Name = "btn_matri_pend"
        btn_matri_pend.Size = New Size(85, 23)
        btn_matri_pend.TabIndex = 16
        btn_matri_pend.Text = "< Pendiente"
        btn_matri_pend.UseVisualStyleBackColor = True
        ' 
        ' btn_pend_matri
        ' 
        btn_pend_matri.Location = New Point(776, 510)
        btn_pend_matri.Name = "btn_pend_matri"
        btn_pend_matri.Size = New Size(85, 23)
        btn_pend_matri.TabIndex = 15
        btn_pend_matri.Text = "Matricular > "
        btn_pend_matri.UseVisualStyleBackColor = True
        ' 
        ' lbl_porc_apro
        ' 
        lbl_porc_apro.AutoSize = True
        lbl_porc_apro.BackColor = Color.Transparent
        lbl_porc_apro.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_porc_apro.ForeColor = Color.White
        lbl_porc_apro.Location = New Point(664, 29)
        lbl_porc_apro.Name = "lbl_porc_apro"
        lbl_porc_apro.Size = New Size(22, 18)
        lbl_porc_apro.TabIndex = 18
        lbl_porc_apro.Text = "%"
        ' 
        ' btn_buscar
        ' 
        btn_buscar.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_buscar.ForeColor = Color.DodgerBlue
        btn_buscar.Location = New Point(96, 111)
        btn_buscar.Name = "btn_buscar"
        btn_buscar.Size = New Size(93, 39)
        btn_buscar.TabIndex = 19
        btn_buscar.Text = "Buscar"
        btn_buscar.UseVisualStyleBackColor = True
        ' 
        ' pb_aprobadas
        ' 
        pb_aprobadas.Location = New Point(558, 27)
        pb_aprobadas.Name = "pb_aprobadas"
        pb_aprobadas.Size = New Size(100, 23)
        pb_aprobadas.TabIndex = 20
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(421, 32)
        Label7.Name = "Label7"
        Label7.Size = New Size(114, 18)
        Label7.TabIndex = 24
        Label7.Text = "Avance carrera"
        ' 
        ' lbl_materia_matri
        ' 
        lbl_materia_matri.AutoSize = True
        lbl_materia_matri.Location = New Point(1037, 167)
        lbl_materia_matri.Name = "lbl_materia_matri"
        lbl_materia_matri.Size = New Size(41, 15)
        lbl_materia_matri.TabIndex = 25
        lbl_materia_matri.Text = "Label8"
        lbl_materia_matri.Visible = False
        ' 
        ' lbl_materia_pend
        ' 
        lbl_materia_pend.AutoSize = True
        lbl_materia_pend.Location = New Point(596, 182)
        lbl_materia_pend.Name = "lbl_materia_pend"
        lbl_materia_pend.Size = New Size(41, 15)
        lbl_materia_pend.TabIndex = 26
        lbl_materia_pend.Text = "Label8"
        lbl_materia_pend.Visible = False
        ' 
        ' lbl_materia_apro
        ' 
        lbl_materia_apro.AutoSize = True
        lbl_materia_apro.Location = New Point(166, 186)
        lbl_materia_apro.Name = "lbl_materia_apro"
        lbl_materia_apro.Size = New Size(41, 15)
        lbl_materia_apro.TabIndex = 27
        lbl_materia_apro.Text = "Label9"
        lbl_materia_apro.Visible = False
        ' 
        ' txt_nota_obtenida
        ' 
        txt_nota_obtenida.Location = New Point(558, 127)
        txt_nota_obtenida.Name = "txt_nota_obtenida"
        txt_nota_obtenida.Size = New Size(100, 23)
        txt_nota_obtenida.TabIndex = 28
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(421, 132)
        Label8.Name = "Label8"
        Label8.Size = New Size(106, 18)
        Label8.TabIndex = 29
        Label8.Text = "Nota obtenida"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' frm_asiganr
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.fondo_loggin
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1212, 738)
        Controls.Add(Label8)
        Controls.Add(txt_nota_obtenida)
        Controls.Add(lbl_materia_apro)
        Controls.Add(lbl_materia_pend)
        Controls.Add(lbl_materia_matri)
        Controls.Add(Label7)
        Controls.Add(pb_aprobadas)
        Controls.Add(btn_buscar)
        Controls.Add(lbl_porc_apro)
        Controls.Add(btn_matriculadas_aprobadas)
        Controls.Add(btn_matri_pend)
        Controls.Add(btn_pend_matri)
        Controls.Add(Button3)
        Controls.Add(btn_pend_apro)
        Controls.Add(Button1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txt_carrera)
        Controls.Add(txt_nombre_estudiante)
        Controls.Add(txt_identificacion)
        Controls.Add(dgv_matri)
        Controls.Add(dgv_pend)
        Controls.Add(dgv_apro)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "frm_asiganr"
        Text = "frm_asiganr"
        CType(dgv_apro, ComponentModel.ISupportInitialize).EndInit()
        CType(dgv_pend, ComponentModel.ISupportInitialize).EndInit()
        CType(dgv_matri, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgv_apro As DataGridView
    Friend WithEvents ID_Materia As DataGridViewTextBoxColumn
    Friend WithEvents Nombre_materia As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents dgv_pend As DataGridView
    Friend WithEvents dgv_matri As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents txt_identificacion As TextBox
    Friend WithEvents txt_nombre_estudiante As TextBox
    Friend WithEvents txt_carrera As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_pend_apro As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btn_matriculadas_aprobadas As Button
    Friend WithEvents btn_matri_pend As Button
    Friend WithEvents btn_pend_matri As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents lbl_porc_apro As Label
    Friend WithEvents btn_buscar As Button
    Friend WithEvents pb_aprobadas As ProgressBar
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_materia_matri As Label
    Friend WithEvents lbl_materia_pend As Label
    Friend WithEvents lbl_materia_apro As Label
    Friend WithEvents txt_nota_obtenida As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
