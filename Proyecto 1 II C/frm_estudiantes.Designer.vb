<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_estudiantes
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
        dgv_aprobadas = New DataGridView()
        ID_Materia = New DataGridViewTextBoxColumn()
        Nombre_materia = New DataGridViewTextBoxColumn()
        Label4 = New Label()
        dgv_matriculadas = New DataGridView()
        DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn()
        Label5 = New Label()
        dgv_pendientes = New DataGridView()
        DataGridViewTextBoxColumn4 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn5 = New DataGridViewTextBoxColumn()
        Label6 = New Label()
        btn_busc = New Button()
        Label1 = New Label()
        txt_ident = New TextBox()
        Label7 = New Label()
        pb_aprobada = New ProgressBar()
        lbl_porcent_apro = New Label()
        Label3 = New Label()
        Label2 = New Label()
        txt_nombrecarrera = New TextBox()
        txt_estudiante = New TextBox()
        CType(dgv_aprobadas, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgv_matriculadas, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgv_pendientes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgv_aprobadas
        ' 
        dgv_aprobadas.AllowUserToAddRows = False
        dgv_aprobadas.BackgroundColor = SystemColors.MenuHighlight
        dgv_aprobadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_aprobadas.Columns.AddRange(New DataGridViewColumn() {ID_Materia, Nombre_materia})
        dgv_aprobadas.Location = New Point(1, 220)
        dgv_aprobadas.Name = "dgv_aprobadas"
        dgv_aprobadas.Size = New Size(390, 555)
        dgv_aprobadas.TabIndex = 1
        ' 
        ' ID_Materia
        ' 
        ID_Materia.FillWeight = 60.9137039F
        ID_Materia.HeaderText = "ID Materia"
        ID_Materia.Name = "ID_Materia"
        ID_Materia.Width = 68
        ' 
        ' Nombre_materia
        ' 
        Nombre_materia.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Nombre_materia.FillWeight = 139.0863F
        Nombre_materia.HeaderText = "Nombre Materia"
        Nombre_materia.Name = "Nombre_materia"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(120, 179)
        Label4.Name = "Label4"
        Label4.Size = New Size(98, 25)
        Label4.TabIndex = 10
        Label4.Text = "Aprobadas"
        ' 
        ' dgv_matriculadas
        ' 
        dgv_matriculadas.AllowUserToAddRows = False
        dgv_matriculadas.BackgroundColor = SystemColors.MenuHighlight
        dgv_matriculadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_matriculadas.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn1, DataGridViewTextBoxColumn2})
        dgv_matriculadas.Location = New Point(414, 220)
        dgv_matriculadas.Name = "dgv_matriculadas"
        dgv_matriculadas.Size = New Size(390, 555)
        dgv_matriculadas.TabIndex = 11
        ' 
        ' DataGridViewTextBoxColumn1
        ' 
        DataGridViewTextBoxColumn1.FillWeight = 78.88146F
        DataGridViewTextBoxColumn1.HeaderText = "ID Materia"
        DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        DataGridViewTextBoxColumn1.Width = 68
        ' 
        ' DataGridViewTextBoxColumn2
        ' 
        DataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewTextBoxColumn2.FillWeight = 114.519554F
        DataGridViewTextBoxColumn2.HeaderText = "Nombre Materia"
        DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(558, 180)
        Label5.Name = "Label5"
        Label5.Size = New Size(129, 24)
        Label5.TabIndex = 12
        Label5.Text = "Matriculadas"
        ' 
        ' dgv_pendientes
        ' 
        dgv_pendientes.BackgroundColor = SystemColors.MenuHighlight
        dgv_pendientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_pendientes.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn4, DataGridViewTextBoxColumn5})
        dgv_pendientes.Location = New Point(836, 220)
        dgv_pendientes.Name = "dgv_pendientes"
        dgv_pendientes.Size = New Size(390, 555)
        dgv_pendientes.TabIndex = 13
        ' 
        ' DataGridViewTextBoxColumn4
        ' 
        DataGridViewTextBoxColumn4.HeaderText = "ID Materia"
        DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        DataGridViewTextBoxColumn4.Width = 68
        ' 
        ' DataGridViewTextBoxColumn5
        ' 
        DataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewTextBoxColumn5.HeaderText = "Nombre Materia"
        DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(984, 180)
        Label6.Name = "Label6"
        Label6.Size = New Size(115, 24)
        Label6.TabIndex = 14
        Label6.Text = "Pendientes"
        ' 
        ' btn_busc
        ' 
        btn_busc.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_busc.ForeColor = Color.DodgerBlue
        btn_busc.Location = New Point(98, 93)
        btn_busc.Name = "btn_busc"
        btn_busc.Size = New Size(93, 39)
        btn_busc.TabIndex = 20
        btn_busc.Text = "Buscar"
        btn_busc.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(12, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(134, 24)
        Label1.TabIndex = 22
        Label1.Text = "Identificacion"
        ' 
        ' txt_ident
        ' 
        txt_ident.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_ident.Location = New Point(152, 27)
        txt_ident.Name = "txt_ident"
        txt_ident.Size = New Size(100, 26)
        txt_ident.TabIndex = 21
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(690, 99)
        Label7.Name = "Label7"
        Label7.Size = New Size(114, 18)
        Label7.TabIndex = 27
        Label7.Text = "Avance carrera"
        ' 
        ' pb_aprobada
        ' 
        pb_aprobada.Location = New Point(834, 99)
        pb_aprobada.Name = "pb_aprobada"
        pb_aprobada.Size = New Size(100, 23)
        pb_aprobada.TabIndex = 26
        ' 
        ' lbl_porcent_apro
        ' 
        lbl_porcent_apro.AutoSize = True
        lbl_porcent_apro.BackColor = Color.Transparent
        lbl_porcent_apro.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_porcent_apro.ForeColor = Color.White
        lbl_porcent_apro.Location = New Point(955, 104)
        lbl_porcent_apro.Name = "lbl_porcent_apro"
        lbl_porcent_apro.Size = New Size(22, 18)
        lbl_porcent_apro.TabIndex = 25
        lbl_porcent_apro.Text = "%"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(769, 26)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 24)
        Label3.TabIndex = 31
        Label3.Text = "Carrera"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(326, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(185, 24)
        Label2.TabIndex = 30
        Label2.Text = "Nombre estudiante"
        ' 
        ' txt_nombrecarrera
        ' 
        txt_nombrecarrera.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_nombrecarrera.Location = New Point(889, 26)
        txt_nombrecarrera.Name = "txt_nombrecarrera"
        txt_nombrecarrera.Size = New Size(163, 26)
        txt_nombrecarrera.TabIndex = 29
        ' 
        ' txt_estudiante
        ' 
        txt_estudiante.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_estudiante.Location = New Point(538, 27)
        txt_estudiante.Name = "txt_estudiante"
        txt_estudiante.Size = New Size(163, 26)
        txt_estudiante.TabIndex = 28
        ' 
        ' frm_estudiantes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.fondo_loggin
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1228, 777)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txt_nombrecarrera)
        Controls.Add(txt_estudiante)
        Controls.Add(Label7)
        Controls.Add(pb_aprobada)
        Controls.Add(lbl_porcent_apro)
        Controls.Add(Label1)
        Controls.Add(txt_ident)
        Controls.Add(btn_busc)
        Controls.Add(Label6)
        Controls.Add(dgv_pendientes)
        Controls.Add(Label5)
        Controls.Add(dgv_matriculadas)
        Controls.Add(Label4)
        Controls.Add(dgv_aprobadas)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "frm_estudiantes"
        Text = "frm_estudiantes"
        CType(dgv_aprobadas, ComponentModel.ISupportInitialize).EndInit()
        CType(dgv_matriculadas, ComponentModel.ISupportInitialize).EndInit()
        CType(dgv_pendientes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents dgv_aprobadas As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents dgv_matriculadas As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents dgv_pendientes As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_busc As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_ident As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents pb_aprobada As ProgressBar
    Friend WithEvents lbl_porcent_apro As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nombrecarrera As TextBox
    Friend WithEvents txt_estudiante As TextBox
    Friend WithEvents ID_Materia As DataGridViewTextBoxColumn
    Friend WithEvents Nombre_materia As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class
