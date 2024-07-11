Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class frm_univer
    Dim conn As New MySqlConnection("server=localhost;userid=root;password='';database=db_proyecto")
    Dim i As Integer
    Dim dr As MySqlDataAdapter

    Dim errorProvider As New ErrorProvider()


    Private Sub frm_univer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cargarestudiantes()
    End Sub

    Sub cargarestudiantes()
        dgv_estudiante.Rows.Clear()

        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM db_proyecto.vista_estudiante", conn)
            Dim dr = cmd.ExecuteReader
            While dr.Read
                dgv_estudiante.Rows.Add(dr.Item("ID"), dr.Item("Nombre"), dr.Item("Identificacion"), dr.Item("Correo"), dr.Item("Fecha de ingreso"))
            End While
            dr.DisposeAsync()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btn_añadir_Click(sender As Object, e As EventArgs) Handles btn_añadir.Click
        Dim fechahoraactual As DateTime = DateTime.Now
        Dim fechaFormateada As String = fechahoraactual.ToString("yyyy/MM/dd HH:mm:ss")
        txt_fecha_ingreso.Text = fechaFormateada

        errorProvider.Clear()

        If String.IsNullOrEmpty(txt_nombre.Text) OrElse String.IsNullOrEmpty(txt_identificacion.Text) OrElse String.IsNullOrEmpty(txt_correo.Text) OrElse String.IsNullOrEmpty(txt_fecha_ingreso.Text) Then
            errorProvider.SetError(btn_añadir, "Rellena todos los espacios")
        Else
            añadirestudiante()
            LimpiarCampos()
            cargarestudiantes()
        End If
    End Sub

    Sub añadirestudiante()
        Dim opcionSeleccionada As Integer
        Select Case cbx_carrera.SelectedIndex
            Case 0 ' Ingenieria en sistemas
                opcionSeleccionada = 1
            Case 1 ' Ingenieria industrial
                opcionSeleccionada = 2
            Case 2 ' Contaduria
                opcionSeleccionada = 3
            Case 3 ' Administracion de negocios
                opcionSeleccionada = 4
        End Select

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO estudiante (nombre_apellidos,identificacion,correo,fecha_ingreso,carrera) 
           VALUES(@nombre_apellidos,@identificacion,@correo,@fecha_ingreso,@carrera)", conn)

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@nombre_apellidos", txt_nombre.Text)
            cmd.Parameters.AddWithValue("@identificacion", txt_identificacion.Text)
            cmd.Parameters.AddWithValue("@correo", txt_correo.Text)
            cmd.Parameters.AddWithValue("@fecha_ingreso", txt_fecha_ingreso.Text)
            cmd.Parameters.AddWithValue("@carrera", opcionSeleccionada)

            Dim i = cmd.ExecuteNonQuery

            If i > 0 Then
                MessageBox.Show("El estudiante ha sido añadido exitosamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dgv_estudiante.Rows.Clear()
                conn.Close()
                cargarestudiantes()
            Else
                MessageBox.Show("El estudiante no ha sido añadido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub editarestudiante()
        dgv_estudiante.Rows.Clear()
        Dim opcionSeleccionada As Integer
        Select Case cbx_carrera.SelectedIndex
            Case 0 ' Ingenieria en sistemas
                opcionSeleccionada = 1
            Case 1 ' Ingenieria industrial
                opcionSeleccionada = 2
            Case 2 ' Contaduria
                opcionSeleccionada = 3
            Case 3 ' Administracion de negocios
                opcionSeleccionada = 4
        End Select
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE estudiante SET nombre_apellidos=@nombre_apellidos, identificacion=@identificacion, correo=@correo, fecha_ingreso=@fecha_ingreso WHERE id= @id", conn)

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@nombre_apellidos", txt_nombre.Text)
            cmd.Parameters.AddWithValue("@identificacion", txt_identificacion.Text)
            cmd.Parameters.AddWithValue("@correo", txt_correo.Text)
            cmd.Parameters.AddWithValue("@fecha_ingreso", txt_fecha_ingreso.Text)
            cmd.Parameters.AddWithValue("@id", lbl_id.Text)

            Dim i = cmd.ExecuteNonQuery

            If i > 0 Then
                MessageBox.Show("El estudiante ha sido editado exitosamente", "Editado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dgv_estudiante.Rows.Clear()
                conn.Close()
                cargarestudiantes()
            Else
                MessageBox.Show("El usuario no ha sido editado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        editarestudiante()
        LimpiarCampos()
        cargarestudiantes()
    End Sub

    Private Sub dgv_estudiante_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_estudiante.CellClick
        lbl_id.Text = dgv_estudiante.CurrentRow.Cells(0).Value
        txt_nombre.Text = dgv_estudiante.CurrentRow.Cells(1).Value
        txt_identificacion.Text = dgv_estudiante.CurrentRow.Cells(2).Value
        txt_correo.Text = dgv_estudiante.CurrentRow.Cells(3).Value
        txt_fecha_ingreso.Text = dgv_estudiante.CurrentRow.Cells(4).Value
        lbl_cedula.Text = dgv_estudiante.CurrentRow.Cells(2).Value
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        eliminarestudiante()
        LimpiarCampos()
        cargarestudiantes()
    End Sub

    Sub eliminarestudiante()
        Dim ask As MsgBoxResult = MsgBox("¿Desea eliminar el estudiante?", MsgBoxStyle.YesNo)

        If ask = MsgBoxResult.Yes Then
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("DELETE FROM estudiante WHERE id=@id;", conn)
                cmd.Parameters.AddWithValue("@id", lbl_id.Text)

                Dim i = cmd.ExecuteNonQuery()

                If i > 0 Then
                    MessageBox.Show("El estudiante ha sido eliminado exitosamente", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dgv_estudiante.Rows.Clear()
                End If
            Catch ex As Exception
                MsgBox("Error al eliminar el estudiante: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Sub LimpiarCampos()
        txt_nombre.Clear()
        txt_identificacion.Clear()
        txt_correo.Clear()
        txt_fecha_ingreso.Clear()
        lbl_id.Text = "0"
        lbl_carrera.Text = ""
        lbl_cedula.Text = ""
        lbl_materia.Text = ""
    End Sub

    Sub cargarmaterias()
        dgv_materia.Rows.Clear()

        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM db_proyecto.vista_carrera_materia WHERE carrera = @carrera", conn)
            cmd.Parameters.AddWithValue("@carrera", cbx_carrera.SelectedIndex + 1) ' Se suma 1 porque los índices de las carreras en la base de datos comienzan desde 1
            Dim dr = cmd.ExecuteReader

            While dr.Read
                Dim carreraTexto As String = Convertircarrera(CInt(dr("Carrera")))
                dgv_materia.Rows.Add(carreraTexto, dr.Item("Materia"), dr.Item("Codigo"), dr.Item("Creditos"), dr.Item("Requisito"), dr.Item("Nombre requisito"))
            End While

            dr.DisposeAsync()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub cbx_carrera_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_carrera.SelectedIndexChanged
        cargarmaterias()
    End Sub

    Private Function ConvertirEstado(ByVal estado As Integer) As String
        Select Case estado
            Case 1
                Return "Aprobado"
            Case 2
                Return "Pendiente"
            Case 3
                Return "Matriculado"
            Case Else
                Return "Desconocido"
        End Select
    End Function

    Private Function Convertircarrera(ByVal carrera As Integer) As String
        Select Case carrera
            Case 1
                Return "Ingeniería en sistemas"
            Case 2
                Return "Ingeniería industrial"
            Case 3
                Return "Contaduría"
            Case 4
                Return "Administracion de negocios"
            Case Else
                Return "Desconocida"
        End Select
    End Function

    Private Sub dgv_materia_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_materia.CellClick
        lbl_materia.Text = dgv_materia.CurrentRow.Cells(1).Value
        lbl_carrera.Text = dgv_materia.CurrentRow.Cells(0).Value
        lbl_codigo.Text = dgv_materia.CurrentRow.Cells(2).Value

    End Sub



    Sub asignarmateria()
        dgv_materia.Rows.Clear()
        dgv_estudiante.Rows.Clear()

        Dim opcionSeleccionada As Integer = cbx_estado.SelectedIndex + 1

        Try
            conn.Open()

            ' Validar si la materia ya está asignada al estudiante
            Dim cmdValidarAsignacion As New MySqlCommand("SELECT COUNT(*) FROM estudiante_materia WHERE ident_estudiante=@ident_estudiante AND id_materia=@id_materia", conn)
            cmdValidarAsignacion.Parameters.AddWithValue("@ident_estudiante", lbl_cedula.Text)
            cmdValidarAsignacion.Parameters.AddWithValue("@id_materia", lbl_codigo.Text)
            Dim asignacionCount As Integer = CInt(cmdValidarAsignacion.ExecuteScalar())
            If asignacionCount > 0 Then
                MessageBox.Show("La materia ya está asignada al estudiante.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.Close()
                Return
            End If


            ' Si todas las validaciones pasan, entonces asigna la materia al estudiante
            Dim cmd As New MySqlCommand("INSERT INTO estudiante_materia(ident_estudiante,id_materia,estado) VALUES(@ident_estudiante,@id_materia,@estado)", conn)
            cmd.Parameters.AddWithValue("@ident_estudiante", lbl_cedula.Text)
            cmd.Parameters.AddWithValue("@id_materia", lbl_codigo.Text)
            cmd.Parameters.AddWithValue("@estado", opcionSeleccionada)

            Dim i As Integer = cmd.ExecuteNonQuery()

            If i > 0 Then
                MessageBox.Show("La materia ha sido añadida exitosamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)

                dgv_materia.Rows.Clear()
                conn.Close()

                cargarmaterias()
                cargarestudiantes()
                LimpiarCampos()
            Else
                MessageBox.Show("La materia no ha sido añadida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub





    Private Sub btn_asignar_Click(sender As Object, e As EventArgs) Handles btn_asignar.Click
        asignarmateria()
        cargarestudiante2()
        cargarestudiantes()
        cargarmaterias()

        Try

            If String.IsNullOrEmpty(lbl_carrera.Text) OrElse String.IsNullOrEmpty(lbl_materia.Text) Then
                MessageBox.Show("Por favor, seleccione una materia y una carrera.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Validar que se haya seleccionado un estado
            If cbx_estado.SelectedIndex = -1 Then
                MessageBox.Show("Por favor, seleccione un estado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try


        asignarmateria()
        cargarestudiante2()
        cargarestudiantes()
        cargarmaterias()
    End Sub

    Sub cargarestudiante2()
        dgv_estudiante_materia.Rows.Clear()

        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM db_proyecto.vista_estudiante_materia WHERE identificacion = @identificacion", conn)
            cmd.Parameters.AddWithValue("@identificacion", txt_identificacion.Text)
            Dim dr = cmd.ExecuteReader

            While dr.Read
                Dim estadoTexto As String = ConvertirEstado(CInt(dr("Estado")))
                dgv_estudiante_materia.Rows.Add(dr.Item("Nombre estudiante"), dr.Item("identificacion"), dr.Item("ID Materia"), dr.Item("Nombre materia"), estadoTexto)
            End While

            dr.DisposeAsync()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub txt_identificacion_TextChanged(sender As Object, e As EventArgs) Handles txt_identificacion.TextChanged
        cargarestudiante2()
    End Sub
    Private Sub txt_identificacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_identificacion.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
            MsgBox("Sólo se puede ingresar valores de tipo numérico", MsgBoxStyle.Exclamation)
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub
    Private Sub txt_nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nombre.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = True
            MsgBox("Sólo se puede ingresar valores de tipo texto", MsgBoxStyle.Exclamation)
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub
    Private Sub txt_correo_LostFocus(sender As Object, e As EventArgs) Handles txt_correo.LostFocus
        Dim Regex As Regex = New Regex("^[^@\s]+@[^@\s]+\.[^@\s]+$")
        Dim isvalid As Boolean = Regex.IsMatch(txt_correo.Text.Trim)
        If Not isvalid Then
            MessageBox.Show("Ingrese un correo electrónico válido")
        End If
    End Sub
End Class