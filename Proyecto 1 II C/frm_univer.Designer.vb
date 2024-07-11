<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_univer
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
        lbl_codigo_materia = New Label()
        lbl_codigo = New Label()
        Label5 = New Label()
        dgv_estudiante_materia = New DataGridView()
        Nombre_estudiante = New DataGridViewTextBoxColumn()
        Cedula = New DataGridViewTextBoxColumn()
        ID_Materia = New DataGridViewTextBoxColumn()
        Nombre_materia = New DataGridViewTextBoxColumn()
        Estado = New DataGridViewTextBoxColumn()
        cbx_estado = New ComboBox()
        lbl_carrera = New Label()
        lbl_materia = New Label()
        lbl_cedula = New Label()
        dgv_materia = New DataGridView()
        Carrera = New DataGridViewTextBoxColumn()
        Materia = New DataGridViewTextBoxColumn()
        Codigo = New DataGridViewTextBoxColumn()
        Creditos = New DataGridViewTextBoxColumn()
        Requisito = New DataGridViewTextBoxColumn()
        Nombre_requisito = New DataGridViewTextBoxColumn()
        btn_asignar = New Button()
        btn_eliminar = New Button()
        btn_modificar = New Button()
        btn_añadir = New Button()
        cbx_carrera = New ComboBox()
        Label1 = New Label()
        dgv_estudiante = New DataGridView()
        id = New DataGridViewTextBoxColumn()
        Nombre = New DataGridViewTextBoxColumn()
        Identificacion = New DataGridViewTextBoxColumn()
        Correo = New DataGridViewTextBoxColumn()
        Fecha_ingreso = New DataGridViewTextBoxColumn()
        txt_fecha_ingreso = New TextBox()
        txt_correo = New TextBox()
        txt_identificacion = New TextBox()
        txt_nombre = New TextBox()
        lbl_id = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        lbl_identificacion = New Label()
        lbl_nombre = New Label()
        CType(dgv_estudiante_materia, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgv_materia, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgv_estudiante, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lbl_codigo_materia
        ' 
        lbl_codigo_materia.AutoSize = True
        lbl_codigo_materia.Location = New Point(29, 335)
        lbl_codigo_materia.Name = "lbl_codigo_materia"
        lbl_codigo_materia.Size = New Size(0, 15)
        lbl_codigo_materia.TabIndex = 54
        lbl_codigo_materia.Visible = False
        ' 
        ' lbl_codigo
        ' 
        lbl_codigo.AutoSize = True
        lbl_codigo.Location = New Point(747, 380)
        lbl_codigo.Name = "lbl_codigo"
        lbl_codigo.Size = New Size(0, 15)
        lbl_codigo.TabIndex = 52
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(376, 596)
        Label5.Name = "Label5"
        Label5.Size = New Size(149, 15)
        Label5.TabIndex = 51
        Label5.Text = "Información del estudiante"
        ' 
        ' dgv_estudiante_materia
        ' 
        dgv_estudiante_materia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_estudiante_materia.Columns.AddRange(New DataGridViewColumn() {Nombre_estudiante, Cedula, ID_Materia, Nombre_materia, Estado})
        dgv_estudiante_materia.Location = New Point(29, 632)
        dgv_estudiante_materia.Name = "dgv_estudiante_materia"
        dgv_estudiante_materia.Size = New Size(1140, 150)
        dgv_estudiante_materia.TabIndex = 50
        ' 
        ' Nombre_estudiante
        ' 
        Nombre_estudiante.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Nombre_estudiante.HeaderText = "Estudiante"
        Nombre_estudiante.Name = "Nombre_estudiante"
        ' 
        ' Cedula
        ' 
        Cedula.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Cedula.HeaderText = "Identificacion"
        Cedula.Name = "Cedula"
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
        Nombre_materia.HeaderText = "Nombre materia"
        Nombre_materia.Name = "Nombre_materia"
        ' 
        ' Estado
        ' 
        Estado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Estado.HeaderText = "Estado"
        Estado.Name = "Estado"
        ' 
        ' cbx_estado
        ' 
        cbx_estado.FormattingEnabled = True
        cbx_estado.Items.AddRange(New Object() {"Aprobado", "Pendiente", "Matriculado"})
        cbx_estado.Location = New Point(817, 380)
        cbx_estado.Name = "cbx_estado"
        cbx_estado.Size = New Size(121, 23)
        cbx_estado.TabIndex = 49
        ' 
        ' lbl_carrera
        ' 
        lbl_carrera.AutoSize = True
        lbl_carrera.Location = New Point(499, 383)
        lbl_carrera.Name = "lbl_carrera"
        lbl_carrera.Size = New Size(0, 15)
        lbl_carrera.TabIndex = 48
        ' 
        ' lbl_materia
        ' 
        lbl_materia.AutoSize = True
        lbl_materia.Location = New Point(247, 383)
        lbl_materia.Name = "lbl_materia"
        lbl_materia.Size = New Size(0, 15)
        lbl_materia.TabIndex = 47
        ' 
        ' lbl_cedula
        ' 
        lbl_cedula.AutoSize = True
        lbl_cedula.Location = New Point(36, 383)
        lbl_cedula.Name = "lbl_cedula"
        lbl_cedula.Size = New Size(0, 15)
        lbl_cedula.TabIndex = 46
        ' 
        ' dgv_materia
        ' 
        dgv_materia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_materia.Columns.AddRange(New DataGridViewColumn() {Carrera, Materia, Codigo, Creditos, Requisito, Nombre_requisito})
        dgv_materia.Location = New Point(29, 420)
        dgv_materia.Name = "dgv_materia"
        dgv_materia.Size = New Size(1140, 156)
        dgv_materia.TabIndex = 45
        ' 
        ' Carrera
        ' 
        Carrera.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Carrera.HeaderText = "Carrera"
        Carrera.Name = "Carrera"
        ' 
        ' Materia
        ' 
        Materia.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Materia.HeaderText = "Materia"
        Materia.Name = "Materia"
        ' 
        ' Codigo
        ' 
        Codigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Codigo.HeaderText = "Codigo"
        Codigo.Name = "Codigo"
        ' 
        ' Creditos
        ' 
        Creditos.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Creditos.HeaderText = "Creditos"
        Creditos.Name = "Creditos"
        ' 
        ' Requisito
        ' 
        Requisito.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Requisito.HeaderText = "Requisito"
        Requisito.Name = "Requisito"
        ' 
        ' Nombre_requisito
        ' 
        Nombre_requisito.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Nombre_requisito.HeaderText = "Nombre requisito"
        Nombre_requisito.Name = "Nombre_requisito"
        ' 
        ' btn_asignar
        ' 
        btn_asignar.Location = New Point(1020, 379)
        btn_asignar.Name = "btn_asignar"
        btn_asignar.Size = New Size(107, 23)
        btn_asignar.TabIndex = 44
        btn_asignar.Text = "Asignar materia"
        btn_asignar.UseVisualStyleBackColor = True
        ' 
        ' btn_eliminar
        ' 
        btn_eliminar.Location = New Point(898, 71)
        btn_eliminar.Name = "btn_eliminar"
        btn_eliminar.Size = New Size(75, 23)
        btn_eliminar.TabIndex = 43
        btn_eliminar.Text = "Eliminar"
        btn_eliminar.UseVisualStyleBackColor = True
        ' 
        ' btn_modificar
        ' 
        btn_modificar.Location = New Point(541, 71)
        btn_modificar.Name = "btn_modificar"
        btn_modificar.Size = New Size(75, 23)
        btn_modificar.TabIndex = 42
        btn_modificar.Text = "Modificar"
        btn_modificar.UseVisualStyleBackColor = True
        ' 
        ' btn_añadir
        ' 
        btn_añadir.Location = New Point(175, 71)
        btn_añadir.Name = "btn_añadir"
        btn_añadir.Size = New Size(75, 23)
        btn_añadir.TabIndex = 41
        btn_añadir.Text = "Añadir"
        btn_añadir.UseVisualStyleBackColor = True
        ' 
        ' cbx_carrera
        ' 
        cbx_carrera.FormattingEnabled = True
        cbx_carrera.Items.AddRange(New Object() {"Ingenieria en sistemas", "Ingenieria industrial", "Contaduria", "Administracion de negocios"})
        cbx_carrera.Location = New Point(1035, 27)
        cbx_carrera.Name = "cbx_carrera"
        cbx_carrera.Size = New Size(100, 23)
        cbx_carrera.TabIndex = 40
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(974, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 15)
        Label1.TabIndex = 39
        Label1.Text = "Carrera"
        ' 
        ' dgv_estudiante
        ' 
        dgv_estudiante.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_estudiante.Columns.AddRange(New DataGridViewColumn() {id, Nombre, Identificacion, Correo, Fecha_ingreso})
        dgv_estudiante.Location = New Point(29, 130)
        dgv_estudiante.Name = "dgv_estudiante"
        dgv_estudiante.Size = New Size(1140, 184)
        dgv_estudiante.TabIndex = 38
        ' 
        ' id
        ' 
        id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        id.HeaderText = "ID"
        id.Name = "id"
        ' 
        ' Nombre
        ' 
        Nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Nombre.HeaderText = "Nombre"
        Nombre.Name = "Nombre"
        ' 
        ' Identificacion
        ' 
        Identificacion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Identificacion.HeaderText = "Identificacion"
        Identificacion.Name = "Identificacion"
        ' 
        ' Correo
        ' 
        Correo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Correo.HeaderText = "Correo"
        Correo.Name = "Correo"
        ' 
        ' Fecha_ingreso
        ' 
        Fecha_ingreso.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Fecha_ingreso.HeaderText = "Fecha de ingreso"
        Fecha_ingreso.Name = "Fecha_ingreso"
        ' 
        ' txt_fecha_ingreso
        ' 
        txt_fecha_ingreso.Location = New Point(832, 27)
        txt_fecha_ingreso.Name = "txt_fecha_ingreso"
        txt_fecha_ingreso.Size = New Size(100, 23)
        txt_fecha_ingreso.TabIndex = 37
        ' 
        ' txt_correo
        ' 
        txt_correo.Location = New Point(541, 27)
        txt_correo.Name = "txt_correo"
        txt_correo.Size = New Size(100, 23)
        txt_correo.TabIndex = 36
        ' 
        ' txt_identificacion
        ' 
        txt_identificacion.Location = New Point(318, 27)
        txt_identificacion.Name = "txt_identificacion"
        txt_identificacion.Size = New Size(100, 23)
        txt_identificacion.TabIndex = 35
        ' 
        ' txt_nombre
        ' 
        txt_nombre.Location = New Point(62, 27)
        txt_nombre.Name = "txt_nombre"
        txt_nombre.Size = New Size(111, 23)
        txt_nombre.TabIndex = 34
        ' 
        ' lbl_id
        ' 
        lbl_id.AutoSize = True
        lbl_id.Location = New Point(29, 5)
        lbl_id.Name = "lbl_id"
        lbl_id.Size = New Size(13, 15)
        lbl_id.TabIndex = 33
        lbl_id.Text = "0"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(5, 5)
        Label4.Name = "Label4"
        Label4.Size = New Size(18, 15)
        Label4.TabIndex = 32
        Label4.Text = "ID"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(712, 30)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 15)
        Label3.TabIndex = 31
        Label3.Text = "Fecha ingreso"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(482, 30)
        Label2.Name = "Label2"
        Label2.Size = New Size(43, 15)
        Label2.TabIndex = 30
        Label2.Text = "Correo"
        ' 
        ' lbl_identificacion
        ' 
        lbl_identificacion.AutoSize = True
        lbl_identificacion.Location = New Point(222, 30)
        lbl_identificacion.Name = "lbl_identificacion"
        lbl_identificacion.Size = New Size(79, 15)
        lbl_identificacion.TabIndex = 29
        lbl_identificacion.Text = "Identificacion"
        ' 
        ' lbl_nombre
        ' 
        lbl_nombre.AutoSize = True
        lbl_nombre.Location = New Point(5, 30)
        lbl_nombre.Name = "lbl_nombre"
        lbl_nombre.Size = New Size(51, 15)
        lbl_nombre.TabIndex = 28
        lbl_nombre.Text = "Nombre"
        ' 
        ' frm_univer
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1292, 705)
        Controls.Add(lbl_codigo_materia)
        Controls.Add(lbl_codigo)
        Controls.Add(Label5)
        Controls.Add(dgv_estudiante_materia)
        Controls.Add(cbx_estado)
        Controls.Add(lbl_carrera)
        Controls.Add(lbl_materia)
        Controls.Add(lbl_cedula)
        Controls.Add(dgv_materia)
        Controls.Add(btn_asignar)
        Controls.Add(btn_eliminar)
        Controls.Add(btn_modificar)
        Controls.Add(btn_añadir)
        Controls.Add(cbx_carrera)
        Controls.Add(Label1)
        Controls.Add(dgv_estudiante)
        Controls.Add(txt_fecha_ingreso)
        Controls.Add(txt_correo)
        Controls.Add(txt_identificacion)
        Controls.Add(txt_nombre)
        Controls.Add(lbl_id)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(lbl_identificacion)
        Controls.Add(lbl_nombre)
        Name = "frm_univer"
        Text = "frm_univer"
        CType(dgv_estudiante_materia, ComponentModel.ISupportInitialize).EndInit()
        CType(dgv_materia, ComponentModel.ISupportInitialize).EndInit()
        CType(dgv_estudiante, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl_codigo_materia As Label
    Friend WithEvents lbl_codigo As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dgv_estudiante_materia As DataGridView
    Friend WithEvents Nombre_estudiante As DataGridViewTextBoxColumn
    Friend WithEvents Cedula As DataGridViewTextBoxColumn
    Friend WithEvents ID_Materia As DataGridViewTextBoxColumn
    Friend WithEvents Nombre_materia As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents cbx_estado As ComboBox
    Friend WithEvents lbl_carrera As Label
    Friend WithEvents lbl_materia As Label
    Friend WithEvents lbl_cedula As Label
    Friend WithEvents dgv_materia As DataGridView
    Friend WithEvents Carrera As DataGridViewTextBoxColumn
    Friend WithEvents Materia As DataGridViewTextBoxColumn
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Creditos As DataGridViewTextBoxColumn
    Friend WithEvents Requisito As DataGridViewTextBoxColumn
    Friend WithEvents Nombre_requisito As DataGridViewTextBoxColumn
    Friend WithEvents btn_asignar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_modificar As Button
    Friend WithEvents btn_añadir As Button
    Friend WithEvents cbx_carrera As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv_estudiante As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Identificacion As DataGridViewTextBoxColumn
    Friend WithEvents Correo As DataGridViewTextBoxColumn
    Friend WithEvents Fecha_ingreso As DataGridViewTextBoxColumn
    Friend WithEvents txt_fecha_ingreso As TextBox
    Friend WithEvents txt_correo As TextBox
    Friend WithEvents txt_identificacion As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents lbl_id As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_identificacion As Label
    Friend WithEvents lbl_nombre As Label
End Class
