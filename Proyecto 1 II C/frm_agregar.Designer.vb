﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_agregar
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
        btn_eliminar = New Button()
        btn_modificar = New Button()
        btn_añadir = New Button()
        cbx_carrera = New ComboBox()
        Label1 = New Label()
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
        DataGridView1 = New DataGridView()
        ID = New DataGridViewTextBoxColumn()
        Nombre = New DataGridViewTextBoxColumn()
        Identificacion = New DataGridViewTextBoxColumn()
        Correo = New DataGridViewTextBoxColumn()
        FechaIngreso = New DataGridViewTextBoxColumn()
        Carrera = New DataGridViewTextBoxColumn()
        DataGridView2 = New DataGridView()
        id_carrera = New DataGridViewTextBoxColumn()
        Materia = New DataGridViewTextBoxColumn()
        Codigo = New DataGridViewTextBoxColumn()
        Creditos = New DataGridViewTextBoxColumn()
        Requisito = New DataGridViewTextBoxColumn()
        Nombre_requisito = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lbl_codigo_materia
        ' 
        lbl_codigo_materia.AutoSize = True
        lbl_codigo_materia.Location = New Point(27, 335)
        lbl_codigo_materia.Name = "lbl_codigo_materia"
        lbl_codigo_materia.Size = New Size(0, 15)
        lbl_codigo_materia.TabIndex = 71
        lbl_codigo_materia.Visible = False
        ' 
        ' btn_eliminar
        ' 
        btn_eliminar.Location = New Point(661, 200)
        btn_eliminar.Name = "btn_eliminar"
        btn_eliminar.Size = New Size(75, 23)
        btn_eliminar.TabIndex = 70
        btn_eliminar.Text = "Eliminar"
        btn_eliminar.UseVisualStyleBackColor = True
        ' 
        ' btn_modificar
        ' 
        btn_modificar.Location = New Point(661, 122)
        btn_modificar.Name = "btn_modificar"
        btn_modificar.Size = New Size(75, 23)
        btn_modificar.TabIndex = 69
        btn_modificar.Text = "Modificar"
        btn_modificar.UseVisualStyleBackColor = True
        ' 
        ' btn_añadir
        ' 
        btn_añadir.Location = New Point(661, 42)
        btn_añadir.Name = "btn_añadir"
        btn_añadir.Size = New Size(75, 23)
        btn_añadir.TabIndex = 68
        btn_añadir.Text = "Añadir"
        btn_añadir.UseVisualStyleBackColor = True
        ' 
        ' cbx_carrera
        ' 
        cbx_carrera.FormattingEnabled = True
        cbx_carrera.Items.AddRange(New Object() {"Ingenieria en sistemas", "Ingenieria industrial", "Contaduria", "Administracion de negocios"})
        cbx_carrera.Location = New Point(100, 227)
        cbx_carrera.Name = "cbx_carrera"
        cbx_carrera.Size = New Size(150, 23)
        cbx_carrera.TabIndex = 67
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(3, 235)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 15)
        Label1.TabIndex = 66
        Label1.Text = "Carrera"
        ' 
        ' txt_fecha_ingreso
        ' 
        txt_fecha_ingreso.Location = New Point(100, 175)
        txt_fecha_ingreso.Name = "txt_fecha_ingreso"
        txt_fecha_ingreso.Size = New Size(150, 23)
        txt_fecha_ingreso.TabIndex = 64
        ' 
        ' txt_correo
        ' 
        txt_correo.Location = New Point(100, 122)
        txt_correo.Name = "txt_correo"
        txt_correo.Size = New Size(150, 23)
        txt_correo.TabIndex = 63
        ' 
        ' txt_identificacion
        ' 
        txt_identificacion.Location = New Point(100, 67)
        txt_identificacion.Name = "txt_identificacion"
        txt_identificacion.Size = New Size(150, 23)
        txt_identificacion.TabIndex = 62
        ' 
        ' txt_nombre
        ' 
        txt_nombre.Location = New Point(100, 22)
        txt_nombre.Name = "txt_nombre"
        txt_nombre.Size = New Size(150, 23)
        txt_nombre.TabIndex = 61
        ' 
        ' lbl_id
        ' 
        lbl_id.AutoSize = True
        lbl_id.Location = New Point(27, 5)
        lbl_id.Name = "lbl_id"
        lbl_id.Size = New Size(13, 15)
        lbl_id.TabIndex = 60
        lbl_id.Text = "0"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(3, 5)
        Label4.Name = "Label4"
        Label4.Size = New Size(18, 15)
        Label4.TabIndex = 59
        Label4.Text = "ID"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(3, 183)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 15)
        Label3.TabIndex = 58
        Label3.Text = "Fecha ingreso"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(3, 130)
        Label2.Name = "Label2"
        Label2.Size = New Size(43, 15)
        Label2.TabIndex = 57
        Label2.Text = "Correo"
        ' 
        ' lbl_identificacion
        ' 
        lbl_identificacion.AutoSize = True
        lbl_identificacion.Location = New Point(3, 75)
        lbl_identificacion.Name = "lbl_identificacion"
        lbl_identificacion.Size = New Size(79, 15)
        lbl_identificacion.TabIndex = 56
        lbl_identificacion.Text = "Identificacion"
        ' 
        ' lbl_nombre
        ' 
        lbl_nombre.AutoSize = True
        lbl_nombre.Location = New Point(3, 30)
        lbl_nombre.Name = "lbl_nombre"
        lbl_nombre.Size = New Size(51, 15)
        lbl_nombre.TabIndex = 55
        lbl_nombre.Text = "Nombre"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ID, Nombre, Identificacion, Correo, FechaIngreso, Carrera})
        DataGridView1.Location = New Point(3, 265)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(760, 155)
        DataGridView1.TabIndex = 74
        ' 
        ' ID
        ' 
        ID.HeaderText = "ID"
        ID.Name = "ID"
        ID.Width = 67
        ' 
        ' Nombre
        ' 
        Nombre.HeaderText = "Nombre"
        Nombre.Name = "Nombre"
        Nombre.Width = 130
        ' 
        ' Identificacion
        ' 
        Identificacion.HeaderText = "Identificacion"
        Identificacion.Name = "Identificacion"
        Identificacion.Width = 130
        ' 
        ' Correo
        ' 
        Correo.HeaderText = "Correo"
        Correo.Name = "Correo"
        Correo.Width = 130
        ' 
        ' FechaIngreso
        ' 
        FechaIngreso.HeaderText = "Fecha de ingreso"
        FechaIngreso.Name = "FechaIngreso"
        FechaIngreso.Width = 130
        ' 
        ' Carrera
        ' 
        Carrera.HeaderText = "Carrera"
        Carrera.Name = "Carrera"
        Carrera.Width = 130
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Columns.AddRange(New DataGridViewColumn() {id_carrera, Materia, Codigo, Creditos, Requisito, Nombre_requisito})
        DataGridView2.Location = New Point(3, 435)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.Size = New Size(760, 145)
        DataGridView2.TabIndex = 75
        ' 
        ' id_carrera
        ' 
        id_carrera.HeaderText = "Carrera"
        id_carrera.Name = "id_carrera"
        id_carrera.Width = 110
        ' 
        ' Materia
        ' 
        Materia.HeaderText = "Materia"
        Materia.Name = "Materia"
        Materia.Width = 170
        ' 
        ' Codigo
        ' 
        Codigo.HeaderText = "Codigo"
        Codigo.Name = "Codigo"
        Codigo.Width = 80
        ' 
        ' Creditos
        ' 
        Creditos.HeaderText = "Creditos"
        Creditos.Name = "Creditos"
        Creditos.Width = 67
        ' 
        ' Requisito
        ' 
        Requisito.HeaderText = "Requisito"
        Requisito.Name = "Requisito"
        Requisito.Width = 110
        ' 
        ' Nombre_requisito
        ' 
        Nombre_requisito.HeaderText = "Nombre requisito"
        Nombre_requisito.Name = "Nombre_requisito"
        Nombre_requisito.Width = 180
        ' 
        ' frm_agregar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(764, 583)
        Controls.Add(DataGridView2)
        Controls.Add(DataGridView1)
        Controls.Add(lbl_codigo_materia)
        Controls.Add(btn_eliminar)
        Controls.Add(btn_modificar)
        Controls.Add(btn_añadir)
        Controls.Add(cbx_carrera)
        Controls.Add(Label1)
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
        FormBorderStyle = FormBorderStyle.None
        Name = "frm_agregar"
        Text = "frm_agregar"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl_codigo_materia As Label
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_modificar As Button
    Friend WithEvents btn_añadir As Button
    Friend WithEvents cbx_carrera As ComboBox
    Friend WithEvents Label1 As Label
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
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Identificacion As DataGridViewTextBoxColumn
    Friend WithEvents Correo As DataGridViewTextBoxColumn
    Friend WithEvents FechaIngreso As DataGridViewTextBoxColumn
    Friend WithEvents Carrera As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents id_carrera As DataGridViewTextBoxColumn
    Friend WithEvents Materia As DataGridViewTextBoxColumn
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Creditos As DataGridViewTextBoxColumn
    Friend WithEvents Requisito As DataGridViewTextBoxColumn
    Friend WithEvents Nombre_requisito As DataGridViewTextBoxColumn
End Class
