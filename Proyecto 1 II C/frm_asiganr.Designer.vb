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
        Button2 = New Button()
        Button3 = New Button()
        btn_matriculadas_aprobadas = New Button()
        Button5 = New Button()
        Button6 = New Button()
        lbl_porcentaje = New Label()
        btn_buscar = New Button()
        pb_aprobadas = New ProgressBar()
        pb_pendientes = New ProgressBar()
        pb_matriculadas = New ProgressBar()
        lbl_materia_matri = New Label()
        CType(dgv_apro, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgv_pend, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgv_matri, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgv_apro
        ' 
        dgv_apro.AllowUserToAddRows = False
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
        dgv_matri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_matri.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn4, DataGridViewTextBoxColumn5, DataGridViewTextBoxColumn6})
        dgv_matri.Location = New Point(858, 247)
        dgv_matri.Name = "dgv_matri"
        dgv_matri.Size = New Size(352, 487)
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
        txt_identificacion.Location = New Point(101, 45)
        txt_identificacion.Name = "txt_identificacion"
        txt_identificacion.Size = New Size(100, 23)
        txt_identificacion.TabIndex = 3
        ' 
        ' txt_nombre_estudiante
        ' 
        txt_nombre_estudiante.Location = New Point(1037, 29)
        txt_nombre_estudiante.Name = "txt_nombre_estudiante"
        txt_nombre_estudiante.Size = New Size(163, 23)
        txt_nombre_estudiante.TabIndex = 4
        ' 
        ' txt_carrera
        ' 
        txt_carrera.Location = New Point(1037, 90)
        txt_carrera.Name = "txt_carrera"
        txt_carrera.Size = New Size(163, 23)
        txt_carrera.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(16, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 15)
        Label1.TabIndex = 6
        Label1.Text = "Identificacion"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(911, 32)
        Label2.Name = "Label2"
        Label2.Size = New Size(109, 15)
        Label2.TabIndex = 7
        Label2.Text = "Nombre estudiante"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(911, 98)
        Label3.Name = "Label3"
        Label3.Size = New Size(45, 15)
        Label3.TabIndex = 8
        Label3.Text = "Carrera"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(107, 203)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 15)
        Label4.TabIndex = 9
        Label4.Text = "Aprobadas"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(558, 213)
        Label5.Name = "Label5"
        Label5.Size = New Size(65, 15)
        Label5.TabIndex = 10
        Label5.Text = "Pendientes"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(1015, 211)
        Label6.Name = "Label6"
        Label6.Size = New Size(75, 15)
        Label6.TabIndex = 11
        Label6.Text = "Matriculadas"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(340, 410)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 12
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(340, 490)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 13
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(340, 583)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 14
        Button3.Text = "Button3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' btn_matriculadas_aprobadas
        ' 
        btn_matriculadas_aprobadas.Location = New Point(780, 583)
        btn_matriculadas_aprobadas.Name = "btn_matriculadas_aprobadas"
        btn_matriculadas_aprobadas.Size = New Size(75, 23)
        btn_matriculadas_aprobadas.TabIndex = 17
        btn_matriculadas_aprobadas.Text = "Button4"
        btn_matriculadas_aprobadas.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(780, 490)
        Button5.Name = "Button5"
        Button5.Size = New Size(75, 23)
        Button5.TabIndex = 16
        Button5.Text = "Button5"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(780, 410)
        Button6.Name = "Button6"
        Button6.Size = New Size(75, 23)
        Button6.TabIndex = 15
        Button6.Text = "Button6"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' lbl_porcentaje
        ' 
        lbl_porcentaje.AutoSize = True
        lbl_porcentaje.Location = New Point(1109, 187)
        lbl_porcentaje.Name = "lbl_porcentaje"
        lbl_porcentaje.Size = New Size(41, 15)
        lbl_porcentaje.TabIndex = 18
        lbl_porcentaje.Text = "Label7"
        ' 
        ' btn_buscar
        ' 
        btn_buscar.Location = New Point(67, 98)
        btn_buscar.Name = "btn_buscar"
        btn_buscar.Size = New Size(75, 23)
        btn_buscar.TabIndex = 19
        btn_buscar.Text = "Buscar"
        btn_buscar.UseVisualStyleBackColor = True
        ' 
        ' pb_aprobadas
        ' 
        pb_aprobadas.Location = New Point(271, 55)
        pb_aprobadas.Name = "pb_aprobadas"
        pb_aprobadas.Size = New Size(100, 23)
        pb_aprobadas.TabIndex = 20
        ' 
        ' pb_pendientes
        ' 
        pb_pendientes.Location = New Point(273, 113)
        pb_pendientes.Name = "pb_pendientes"
        pb_pendientes.Size = New Size(100, 23)
        pb_pendientes.TabIndex = 21
        ' 
        ' pb_matriculadas
        ' 
        pb_matriculadas.Location = New Point(267, 164)
        pb_matriculadas.Name = "pb_matriculadas"
        pb_matriculadas.Size = New Size(100, 23)
        pb_matriculadas.TabIndex = 22
        ' 
        ' lbl_materia_matri
        ' 
        lbl_materia_matri.AutoSize = True
        lbl_materia_matri.Location = New Point(559, 65)
        lbl_materia_matri.Name = "lbl_materia_matri"
        lbl_materia_matri.Size = New Size(41, 15)
        lbl_materia_matri.TabIndex = 23
        lbl_materia_matri.Text = "Label7"
        ' 
        ' frm_asiganr
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1212, 738)
        Controls.Add(lbl_materia_matri)
        Controls.Add(pb_matriculadas)
        Controls.Add(pb_pendientes)
        Controls.Add(pb_aprobadas)
        Controls.Add(btn_buscar)
        Controls.Add(lbl_porcentaje)
        Controls.Add(btn_matriculadas_aprobadas)
        Controls.Add(Button5)
        Controls.Add(Button6)
        Controls.Add(Button3)
        Controls.Add(Button2)
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
        Name = "frm_asiganr"
        Text = "frm_asiganr"
        CType(dgv_apro, ComponentModel.ISupportInitialize).EndInit()
        CType(dgv_pend, ComponentModel.ISupportInitialize).EndInit()
        CType(dgv_matri, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btn_matriculadas_aprobadas As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents lbl_porcentaje As Label
    Friend WithEvents btn_buscar As Button
    Friend WithEvents pb_aprobadas As ProgressBar
    Friend WithEvents pb_pendientes As ProgressBar
    Friend WithEvents pb_matriculadas As ProgressBar
    Friend WithEvents lbl_materia_matri As Label
End Class
