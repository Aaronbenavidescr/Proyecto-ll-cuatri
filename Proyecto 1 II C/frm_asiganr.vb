Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Transactions
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class frm_asiganr
    Dim conn As New MySqlConnection("server=localhost;userid=root;password='';database=db_proyecto")

    ' Cargar materias aprobadas (Estado = 1)
    Private Sub CargarMateriasAprobadas(identificacionEstudiante As String)
        dgv_apro.Rows.Clear()

        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM vista_estudiante_materia WHERE identificacion = @identificacion AND Estado = 1", conn)
            cmd.Parameters.AddWithValue("@identificacion", identificacionEstudiante)
            Dim dr = cmd.ExecuteReader()

            While dr.Read()
                dgv_apro.Rows.Add(dr("ID Materia"), dr("Nombre materia"), "Aprobado")
            End While

            dr.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar materias aprobadas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Cargar materias pendientes (Estado = 2)
    Private Sub CargarMateriasPendientes(identificacionEstudiante As String)
        dgv_pend.Rows.Clear()

        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM vista_estudiante_materia WHERE identificacion = @identificacion AND Estado = 2", conn)
            cmd.Parameters.AddWithValue("@identificacion", identificacionEstudiante)
            Dim dr = cmd.ExecuteReader()

            While dr.Read()
                dgv_pend.Rows.Add(dr("ID Materia"), dr("Nombre materia"), "Pendiente")
            End While

            dr.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar materias pendientes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Cargar materias matriculadas (Estado = 3)
    Private Sub CargarMateriasMatriculadas(identificacionEstudiante As String)
        dgv_matri.Rows.Clear()

        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM vista_estudiante_materia WHERE identificacion = @identificacion AND Estado = 3", conn)
            cmd.Parameters.AddWithValue("@identificacion", identificacionEstudiante)
            Dim dr = cmd.ExecuteReader()

            While dr.Read()
                dgv_matri.Rows.Add(dr("ID Materia"), dr("Nombre materia"), "Matriculado")
            End While

            dr.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar materias matriculadas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Cargarnombreestudiante(identificacionEstudiante As String)

        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM vista_estudiante_materia WHERE identificacion = @identificacion", conn)
            cmd.Parameters.AddWithValue("@identificacion", identificacionEstudiante)
            Dim dr = cmd.ExecuteReader()

            While dr.Read()
                txt_nombre_estudiante.Text = dr("Nombre estudiante")
            End While

            dr.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar el nombre: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub CargarCarreraEstudiante(identificacionEstudiante As String)
        Try
            ' Abre la conexión a la base de datos
            conn.Open()

            ' Crea el comando SQL para seleccionar la carrera del estudiante basado en su identificación
            Dim cmd As New MySqlCommand("SELECT Carrera FROM vista_estudiante WHERE Identificacion = @Identificacion", conn)
            ' Añade el parámetro de identificación al comando
            cmd.Parameters.AddWithValue("@Identificacion", identificacionEstudiante)

            ' Ejecuta el comando y obtiene el lector de datos
            Dim dr = cmd.ExecuteReader()

            ' Lee los datos obtenidos
            While dr.Read()
                ' Convierte el valor numérico de la carrera a su correspondiente descripción
                Dim carrera As String = ""
                Select Case dr("Carrera")
                    Case 1
                        carrera = "Ingeniería en Sistemas"
                    Case 2
                        carrera = "Ingeniería Industrial"
                    Case 3
                        carrera = "Contaduría"
                    Case 4
                        carrera = "Administración de Negocios"
                    Case Else
                        carrera = "Carrera desconocida"
                End Select

                ' Asigna la descripción de la carrera al label correspondiente
                txt_carrera.Text = carrera
            End While

            ' Cierra el lector de datos
            dr.Close()
        Catch ex As Exception
            ' Muestra un mensaje de error en caso de que ocurra una excepción
            MessageBox.Show("Error al cargar la carrera: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Asegura que la conexión a la base de datos se cierre siempre
            conn.Close()
        End Try
    End Sub


    ' Función para calcular y mostrar el porcentaje total de materias
    Private Sub MostrarPorcentaje()
        Dim totalMaterias As Integer = dgv_apro.Rows.Count + dgv_pend.Rows.Count + dgv_matri.Rows.Count

        If totalMaterias > 0 Then
            Dim porcentajeAprobadas As Double = (dgv_apro.Rows.Count / totalMaterias) * 100
            Dim porcentajePendientes As Double = (dgv_pend.Rows.Count / totalMaterias) * 100
            Dim porcentajeMatriculadas As Double = (dgv_matri.Rows.Count / totalMaterias) * 100

            ' Actualizar las barras de progreso
            pb_aprobadas.Value = Convert.ToInt32(porcentajeAprobadas)

        Else
            ' Manejo si no hay materias cargadas
            pb_aprobadas.Value = 0

        End If
    End Sub

    ' Función para calcular y mostrar el porcentaje de avance en la carrera
    Private Sub MostrarPorcentajeGanado()
        Dim totalPendientesYMatriculadas As Double = dgv_pend.Rows.Count + dgv_matri.Rows.Count

        If totalPendientesYMatriculadas > 0 Then
            Dim porcentajeGanado As Double = (dgv_apro.Rows.Count / totalPendientesYMatriculadas) * 100
            lbl_porc_apro.Text = porcentajeGanado.ToString("0.00") & "%"
        Else
            lbl_porc_apro.Text = "0%"
        End If
    End Sub

    ' Cambiar el estado de materias matriculadas a aprobadas (Estado = 3 a Estado = 1)
    Private Sub CambiarEstadoMatriculadasAprobadas(identificacionEstudiante As String)
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("UPDATE estudiante_materia SET estado = 1 WHERE id_materia = @id_materia AND Estado = 3", conn)
            cmd.Parameters.AddWithValue("@id_materia", lbl_materia_matri.Text)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Estado de materia matriculada cambiado a aprobada correctamente.", "Estado Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al cambiar estado de materias matriculadas a aprobadas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub
    ' Cambiar el estado de materias matriculadas a aprobadas (Estado = 3 a Estado = 1)
    Private Sub CambiarEstadoMatriculadaspendientes(identificacionEstudiante As String)
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("UPDATE estudiante_materia SET estado = 2 WHERE id_materia = @id_materia AND Estado = 3", conn)
            cmd.Parameters.AddWithValue("@id_materia", lbl_materia_matri.Text)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Estado de materia matriculada cambiado a pendiente correctamente.", "Estado Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al cambiar estado de materias matriculadas a aprobadas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub CambiarEstadopendientematriculada(identificacionEstudiante As String)
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("UPDATE estudiante_materia SET estado = 3 WHERE id_materia = @id_materia AND Estado = 2", conn)
            cmd.Parameters.AddWithValue("@id_materia", lbl_materia_pend.Text)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Estado de materia pendiente cambiado a matriculada correctamente.", "Estado Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al cambiar estado de materias matriculadas a aprobadas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub CambiarEstadoaprobadapendiente(identificacionEstudiante As String)
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("UPDATE estudiante_materia SET estado = 2 WHERE id_materia = @id_materia AND Estado = 1", conn)
            cmd.Parameters.AddWithValue("@id_materia", lbl_materia_apro.Text)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Estado de materia aprobada cambiado a pendiente correctamente.", "Estado Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al cambiar estado de materias matriculadas a aprobadas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub CambiarEstadopendienteaprobada(identificacionEstudiante As String)
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("UPDATE estudiante_materia SET estado = 1 WHERE id_materia = @id_materia AND Estado = 2", conn)
            cmd.Parameters.AddWithValue("@id_materia", lbl_materia_pend.Text)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Estado de materia pendiente cambiado a aprobada correctamente.", "Estado Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al cambiar estado de materias matriculadas a aprobadas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub CambiarEstadoaprobadamatriculada(identificacionEstudiante As String)
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("UPDATE estudiante_materia SET estado = 3 WHERE id_materia = @id_materia AND Estado = 1", conn)
            cmd.Parameters.AddWithValue("@id_materia", lbl_materia_apro.Text)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Estado de materia aprobada cambiado a matriculada correctamente.", "Estado Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al cambiar estado de materias matriculadas a aprobadas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Evento de búsqueda por identificación de estudiante
    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim identificacionEstudiante As String = txt_identificacion.Text.Trim()

        ' Llamar a los métodos para cargar los DataGridView según el estado de las materias
        CargarMateriasAprobadas(identificacionEstudiante)
        CargarMateriasPendientes(identificacionEstudiante)
        CargarMateriasMatriculadas(identificacionEstudiante)
        MostrarPorcentaje()
        MostrarPorcentajeGanado()
        Cargarnombreestudiante(identificacionEstudiante)
        Cargarcarreraestudiante(identificacionEstudiante)



    End Sub

    ' Evento para cambiar el estado de materias matriculadas a aprobadas al hacer clic en el botón
    Private Sub btn_matriculadas_aprobadas_Click(sender As Object, e As EventArgs) Handles btn_matriculadas_aprobadas.Click
        Dim identificacionEstudiante As String = txt_identificacion.Text.Trim()
        CambiarEstadoMatriculadasAprobadas(identificacionEstudiante)
        CargarMateriasAprobadas(identificacionEstudiante)
        CargarMateriasPendientes(identificacionEstudiante)
        CargarMateriasMatriculadas(identificacionEstudiante)
        MostrarPorcentaje()
        MostrarPorcentajeGanado()
        CargarCarreraEstudiante(identificacionEstudiante)

    End Sub

    Private Sub dgv_matri_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_matri.CellClick

        lbl_materia_matri.Text = dgv_matri.CurrentRow.Cells(0).Value

    End Sub

    Private Sub btn_matri_pend_Click(sender As Object, e As EventArgs) Handles btn_matri_pend.Click

        Dim identificacionEstudiante As String = txt_identificacion.Text.Trim()
        CambiarEstadoMatriculadaspendientes(identificacionEstudiante)
        CargarMateriasAprobadas(identificacionEstudiante)
        CargarMateriasPendientes(identificacionEstudiante)
        CargarMateriasMatriculadas(identificacionEstudiante)
        MostrarPorcentaje()
        MostrarPorcentajeGanado()
        CargarCarreraEstudiante(identificacionEstudiante)

    End Sub

    Private Sub btn_pend_matri_Click(sender As Object, e As EventArgs) Handles btn_pend_matri.Click
        Dim identificacionEstudiante As String = txt_identificacion.Text.Trim()
        CambiarEstadopendientematriculada(identificacionEstudiante)
        CargarMateriasAprobadas(identificacionEstudiante)
        CargarMateriasPendientes(identificacionEstudiante)
        CargarMateriasMatriculadas(identificacionEstudiante)
        MostrarPorcentaje()
        MostrarPorcentajeGanado()
        CargarCarreraEstudiante(identificacionEstudiante)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim identificacionEstudiante As String = txt_identificacion.Text.Trim()
        CambiarEstadoaprobadapendiente(identificacionEstudiante)
        CargarMateriasAprobadas(identificacionEstudiante)
        CargarMateriasPendientes(identificacionEstudiante)
        CargarMateriasMatriculadas(identificacionEstudiante)
        MostrarPorcentaje()
        MostrarPorcentajeGanado()
        CargarCarreraEstudiante(identificacionEstudiante)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim identificacionEstudiante As String = txt_identificacion.Text.Trim()
        CambiarEstadopendienteaprobada(identificacionEstudiante)
        CargarMateriasAprobadas(identificacionEstudiante)
        CargarMateriasPendientes(identificacionEstudiante)
        CargarMateriasMatriculadas(identificacionEstudiante)
        MostrarPorcentaje()
        MostrarPorcentajeGanado()
        CargarCarreraEstudiante(identificacionEstudiante)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim identificacionEstudiante As String = txt_identificacion.Text.Trim()
        CambiarEstadoaprobadamatriculada(identificacionEstudiante)
        CargarMateriasAprobadas(identificacionEstudiante)
        CargarMateriasPendientes(identificacionEstudiante)
        CargarMateriasMatriculadas(identificacionEstudiante)
        MostrarPorcentaje()
        MostrarPorcentajeGanado()
        CargarCarreraEstudiante(identificacionEstudiante)
    End Sub


    Private Sub dgv_apro_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_apro.CellClick
        lbl_materia_apro.Text = dgv_apro.CurrentRow.Cells(0).Value
    End Sub

    Private Sub dgv_pend_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_pend.CellClick
        lbl_materia_pend.Text = dgv_pend.CurrentRow.Cells(0).Value
    End Sub
End Class



