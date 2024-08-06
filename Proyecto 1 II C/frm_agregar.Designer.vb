<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
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
        btn_eliminar.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_eliminar.ForeColor = Color.DodgerBlue
        btn_eliminar.Location = New Point(988, 310)
        btn_eliminar.Name = "btn_eliminar"
        btn_eliminar.Size = New Size(109, 40)
        btn_eliminar.TabIndex = 70
        btn_eliminar.Text = "Eliminar"
        btn_eliminar.UseVisualStyleBackColor = True
        ' 
        ' btn_modificar
        ' 
        btn_modificar.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_modificar.ForeColor = Color.DodgerBlue
        btn_modificar.Location = New Point(988, 221)
        btn_modificar.Name = "btn_modificar"
        btn_modificar.Size = New Size(109, 40)
        btn_modificar.TabIndex = 69
        btn_modificar.Text = "Modificar"
        btn_modificar.UseVisualStyleBackColor = True
        ' 
        ' btn_añadir
        ' 
        btn_añadir.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_añadir.ForeColor = Color.DodgerBlue
        btn_añadir.Location = New Point(988, 122)
        btn_añadir.Name = "btn_añadir"
        btn_añadir.Size = New Size(109, 41)
        btn_añadir.TabIndex = 68
        btn_añadir.Text = "Añadir"
        btn_añadir.UseVisualStyleBackColor = True
        ' 
        ' cbx_carrera
        ' 
        cbx_carrera.FormattingEnabled = True
        cbx_carrera.Items.AddRange(New Object() {"Ingenieria en sistemas", "Ingenieria industrial", "Contaduria", "Administracion de negocios"})
        cbx_carrera.Location = New Point(323, 352)
        cbx_carrera.Name = "cbx_carrera"
        cbx_carrera.Size = New Size(150, 23)
        cbx_carrera.TabIndex = 67
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(155, 348)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 24)
        Label1.TabIndex = 66
        Label1.Text = "Carrera"
        ' 
        ' txt_fecha_ingreso
        ' 
        txt_fecha_ingreso.Location = New Point(323, 291)
        txt_fecha_ingreso.Name = "txt_fecha_ingreso"
        txt_fecha_ingreso.Size = New Size(150, 23)
        txt_fecha_ingreso.TabIndex = 64
        ' 
        ' txt_correo
        ' 
        txt_correo.Location = New Point(323, 225)
        txt_correo.Name = "txt_correo"
        txt_correo.Size = New Size(150, 23)
        txt_correo.TabIndex = 63
        ' 
        ' txt_identificacion
        ' 
        txt_identificacion.Location = New Point(323, 157)
        txt_identificacion.Name = "txt_identificacion"
        txt_identificacion.Size = New Size(150, 23)
        txt_identificacion.TabIndex = 62
        ' 
        ' txt_nombre
        ' 
        txt_nombre.Location = New Point(323, 87)
        txt_nombre.Name = "txt_nombre"
        txt_nombre.Size = New Size(150, 23)
        txt_nombre.TabIndex = 61
        ' 
        ' lbl_id
        ' 
        lbl_id.AutoSize = True
        lbl_id.BackColor = Color.Transparent
        lbl_id.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_id.ForeColor = Color.White
        lbl_id.Location = New Point(40, 5)
        lbl_id.Name = "lbl_id"
        lbl_id.Size = New Size(22, 24)
        lbl_id.TabIndex = 60
        lbl_id.Text = "0"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(3, 5)
        Label4.Name = "Label4"
        Label4.Size = New Size(31, 24)
        Label4.TabIndex = 59
        Label4.Text = "ID"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(155, 287)
        Label3.Name = "Label3"
        Label3.Size = New Size(144, 24)
        Label3.TabIndex = 58
        Label3.Text = "Fecha ingreso"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(155, 221)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 24)
        Label2.TabIndex = 57
        Label2.Text = "Correo"
        ' 
        ' lbl_identificacion
        ' 
        lbl_identificacion.AutoSize = True
        lbl_identificacion.BackColor = Color.Transparent
        lbl_identificacion.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_identificacion.ForeColor = Color.White
        lbl_identificacion.Location = New Point(155, 153)
        lbl_identificacion.Name = "lbl_identificacion"
        lbl_identificacion.Size = New Size(134, 24)
        lbl_identificacion.TabIndex = 56
        lbl_identificacion.Text = "Identificacion"
        ' 
        ' lbl_nombre
        ' 
        lbl_nombre.AutoSize = True
        lbl_nombre.BackColor = Color.Transparent
        lbl_nombre.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_nombre.ForeColor = Color.White
        lbl_nombre.Location = New Point(155, 83)
        lbl_nombre.Name = "lbl_nombre"
        lbl_nombre.Size = New Size(82, 24)
        lbl_nombre.TabIndex = 55
        lbl_nombre.Text = "Nombre"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.MenuHighlight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ID, Nombre, Identificacion, Correo, FechaIngreso, Carrera})
        DataGridView1.Location = New Point(3, 460)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(1224, 318)
        DataGridView1.TabIndex = 74
        ' 
        ' ID
        ' 
        ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ID.HeaderText = "ID"
        ID.Name = "ID"
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
        ' FechaIngreso
        ' 
        FechaIngreso.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        FechaIngreso.HeaderText = "Fecha de ingreso"
        FechaIngreso.Name = "FechaIngreso"
        ' 
        ' Carrera
        ' 
        Carrera.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Carrera.HeaderText = "Carrera"
        Carrera.Name = "Carrera"
        ' 
        ' frm_agregar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.fondo_loggin
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1228, 777)
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
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "frm_agregar"
        Text = "frm_agregar"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
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
End Class
