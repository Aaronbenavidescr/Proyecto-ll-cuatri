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

            ' Modificar la consulta para excluir la materia con ID "Admitido"
            Dim cmd As New MySqlCommand("SELECT * FROM vista_estudiante_materia WHERE identificacion = @identificacion AND Estado = 1 AND `ID Materia` != 'Admitido'", conn)
            cmd.Parameters.AddWithValue("@identificacion", identificacionEstudiante)
            Dim dr = cmd.ExecuteReader()

            While dr.Read()
                dgv_apro.Rows.Add(dr("ID Materia"), dr("Nombre materia"), dr("Requisitos"))
            End While

            dr.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar materias aprobadas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub


    ' Cargar materias pendientes (Estado = 2)
    Private Sub CargarMateriasMatriculadas(identificacionEstudiante As String)
        dgv_matric.Rows.Clear()

        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM vista_estudiante_materia WHERE identificacion = @identificacion AND Estado = 2", conn)
            cmd.Parameters.AddWithValue("@identificacion", identificacionEstudiante)
            Dim dr = cmd.ExecuteReader()

            While dr.Read()
                dgv_matric.Rows.Add(dr("ID Materia"), dr("Nombre materia"), dr("Requisitos"))
            End While

            dr.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar materias matriculadas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Cargar materias matriculadas (Estado = 3)
    Private Sub CargarMateriasPendientes(identificacionEstudiante As String)
        dgv_pendie.Rows.Clear()

        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM vista_estudiante_materia WHERE identificacion = @identificacion AND Estado = 3", conn)
            cmd.Parameters.AddWithValue("@identificacion", identificacionEstudiante)
            Dim dr = cmd.ExecuteReader()

            While dr.Read()
                dgv_pendie.Rows.Add(dr("ID Materia"), dr("Nombre materia"), dr("Requisitos"))
            End While

            dr.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar materias pendientes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub CambiarEstadoPendienteAprobadas(identificacionEstudiante As String)
        Try
            conn.Open()

            ' Obtener el ID del requisito desde la tabla materia
            Dim requisitoIdCmd As New MySqlCommand("
            SELECT requisito 
            FROM materia 
            WHERE codigo = @id_materia", conn)
            requisitoIdCmd.Parameters.AddWithValue("@id_materia", lbl_materia_pendie.Text)

            Dim requisitoId As Object = requisitoIdCmd.ExecuteScalar()

            If requisitoId IsNot Nothing Then
                ' Verificar el estado de la materia de requisito en estudiante_materia
                Dim checkReqCmd As New MySqlCommand("
                SELECT estado 
                FROM estudiante_materia 
                WHERE id_materia = @id_requisito 
                AND ident_estudiante = @ident_estudiante", conn)
                checkReqCmd.Parameters.AddWithValue("@id_requisito", requisitoId)
                checkReqCmd.Parameters.AddWithValue("@ident_estudiante", identificacionEstudiante)

                Dim reqEstado As Object = checkReqCmd.ExecuteScalar()

                If reqEstado IsNot Nothing AndAlso Convert.ToInt32(reqEstado) = 1 Then
                    ' Verificar si la nota ingresada es 70 o superior
                    Dim nota As Integer
                    If Integer.TryParse(txt_nota_obtenida.Text.Trim(), nota) AndAlso nota >= 70 Then


                        ' Actualizar el estado de la materia y la nota en la base de datos
                        Dim cmd As New MySqlCommand("UPDATE estudiante_materia SET estado = 1, nota = @nota WHERE id_materia = @id_materia AND Estado = 3 AND ident_estudiante = @identificacion", conn)
                        cmd.Parameters.AddWithValue("@id_materia", lbl_materia_pendie.Text)
                        cmd.Parameters.AddWithValue("@nota", nota)
                        cmd.Parameters.AddWithValue("@identificacion", identificacionEstudiante)
                        cmd.ExecuteNonQuery()

                        MessageBox.Show("Estado de materia cambiado a aprobada correctamente.", "Estado Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("La nota debe ser 70 o superior para aprobar la materia.", "Nota Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Else
                    ' Mostrar mensaje si el estado del requisito no es 1
                    MessageBox.Show("No se puede aprobar la materia porque el estado del requisito no está aprobado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("No se encontró el requisito para la materia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As MySqlException
            MessageBox.Show("Error de base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error al cambiar estado de materia a aprobada: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub CambiarEstadoPendienteAMatriculada(identificacionEstudiante As String)
        Try
            conn.Open()

            ' Obtener el ID del requisito desde la tabla materia
            Dim requisitoIdCmd As New MySqlCommand("
            SELECT requisito 
            FROM materia 
            WHERE codigo = @id_materia", conn)
            requisitoIdCmd.Parameters.AddWithValue("@id_materia", lbl_materia_pendie.Text)

            Dim requisitoId As Object = requisitoIdCmd.ExecuteScalar()

            If requisitoId IsNot Nothing Then
                ' Verificar el estado de la materia de requisito en estudiante_materia
                Dim checkReqCmd As New MySqlCommand("
                SELECT estado 
                FROM estudiante_materia 
                WHERE id_materia = @id_requisito 
                AND ident_estudiante = @ident_estudiante", conn)
                checkReqCmd.Parameters.AddWithValue("@id_requisito", requisitoId)
                checkReqCmd.Parameters.AddWithValue("@ident_estudiante", identificacionEstudiante)

                Dim reqEstado As Object = checkReqCmd.ExecuteScalar()

                If reqEstado IsNot Nothing AndAlso Convert.ToInt32(reqEstado) = 1 Then
                    ' Si el estado del requisito es 1, realizar la actualización
                    Dim updateCmd As New MySqlCommand("
                    UPDATE estudiante_materia 
                    SET estado = 2 
                    WHERE id_materia = @id_materia 
                    AND estado = 3 
                    AND ident_estudiante = @ident_estudiante", conn)
                    updateCmd.Parameters.AddWithValue("@id_materia", lbl_materia_pendie.Text)
                    updateCmd.Parameters.AddWithValue("@ident_estudiante", identificacionEstudiante)
                    updateCmd.ExecuteNonQuery()

                    MessageBox.Show("Estado de materia cambiado a matriculada correctamente.", "Estado Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    ' Mostrar mensaje si el estado del requisito no es 1
                    MessageBox.Show("No se puede matricular la materia porque el estado del requisito no está aprobado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("No se encontró el requisito para la materia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As MySqlException
            MessageBox.Show("Error de base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error al cambiar estado de materias pendientes a matriculadas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub


    Private Sub CambiarEstadoMatriculadaApendiente(identificacionEstudiante As String)
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("UPDATE estudiante_materia SET estado = 3 WHERE id_materia = @id_materia AND Estado = 2 AND ident_estudiante = @ident_estudiante", conn)
            cmd.Parameters.AddWithValue("@id_materia", lbl_materia_matric.Text)
            cmd.Parameters.AddWithValue("@ident_estudiante", identificacionEstudiante)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Estado de materia cambiado a pendiente correctamente.", "Estado Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al cambiar estado de materia a pendiente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub CambiarEstadoaprobadaAmatriculada(identificacionEstudiante As String)
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("UPDATE estudiante_materia SET estado = 2, nota=0 WHERE id_materia = @id_materia AND Estado = 1 AND ident_estudiante = @ident_estudiante", conn)
            cmd.Parameters.AddWithValue("@id_materia", lbl_materia_apro.Text)
            cmd.Parameters.AddWithValue("@ident_estudiante", identificacionEstudiante)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Estado de materia cambiado a matriculada correctamente.", "Estado Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al cambiar estado de materia a matriculada: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub CambiarEstadomatriculadaaprobada(identificacionEstudiante As String)
        Try
            Dim nota As Integer
            If Integer.TryParse(txt_nota_obtenida.Text.Trim(), nota) AndAlso nota >= 70 Then
                conn.Open()
                Dim cmd As New MySqlCommand("UPDATE estudiante_materia SET estado = 1, nota = @nota WHERE id_materia = @id_materia AND Estado = 2 AND ident_estudiante = @identificacion", conn)
                cmd.Parameters.AddWithValue("@id_materia", lbl_materia_matric.Text)
                cmd.Parameters.AddWithValue("@nota", nota)
                cmd.Parameters.AddWithValue("@identificacion", identificacionEstudiante)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Estado de materia cambiado a aprobada correctamente.", "Estado Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("La nota debe ser 70 o superior para aprobar la materia.", "Nota Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cambiar estado de materia a aprobada: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub CambiarEstadoaprobadapendiente(identificacionEstudiante As String)
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("UPDATE estudiante_materia SET estado = 3, nota=0 WHERE id_materia = @id_materia AND Estado = 1 AND ident_estudiante = @ident_estudiante", conn)
            cmd.Parameters.AddWithValue("@id_materia", lbl_materia_apro.Text)
            cmd.Parameters.AddWithValue("@ident_estudiante", identificacionEstudiante)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Estado de materia cambiado a pendiente correctamente.", "Estado Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al cambiar estado de materia a pendiente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        Cargarnombreestudiante(identificacionEstudiante)
        CargarCarreraEstudiante(identificacionEstudiante)



    End Sub

    ' Evento para cambiar el estado de materias matriculadas a aprobadas al hacer clic en el botón
    Private Sub btn_matriculadas_aprobadas_Click(sender As Object, e As EventArgs) Handles btn_matriculadas_aprobadas.Click
        Dim identificacionEstudiante As String = txt_identificacion.Text.Trim()
        CambiarEstadoPendienteAprobadas(identificacionEstudiante)
        CargarMateriasAprobadas(identificacionEstudiante)
        CargarMateriasPendientes(identificacionEstudiante)
        CargarMateriasMatriculadas(identificacionEstudiante)
        CargarCarreraEstudiante(identificacionEstudiante)
        txt_nota_obtenida.Clear()

    End Sub

    Private Sub dgv_matri_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_pendie.CellClick

        lbl_materia_pendie.Text = dgv_pendie.CurrentRow.Cells(0).Value

    End Sub

    Private Sub btn_matri_pend_Click(sender As Object, e As EventArgs) Handles btn_matri_pend.Click

        Dim identificacionEstudiante As String = txt_identificacion.Text.Trim()
        CambiarEstadoPendienteAMatriculada(identificacionEstudiante)
        CargarMateriasAprobadas(identificacionEstudiante)
        CargarMateriasPendientes(identificacionEstudiante)
        CargarMateriasMatriculadas(identificacionEstudiante)
        CargarCarreraEstudiante(identificacionEstudiante)
        txt_nota_obtenida.Clear()

    End Sub

    Private Sub btn_pend_matri_Click(sender As Object, e As EventArgs) Handles btn_pend_matri.Click
        Dim identificacionEstudiante As String = txt_identificacion.Text.Trim()
        CambiarEstadoMatriculadaApendiente(identificacionEstudiante)
        CargarMateriasAprobadas(identificacionEstudiante)
        CargarMateriasPendientes(identificacionEstudiante)
        CargarMateriasMatriculadas(identificacionEstudiante)
        CargarCarreraEstudiante(identificacionEstudiante)
        txt_nota_obtenida.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim identificacionEstudiante As String = txt_identificacion.Text.Trim()
        CambiarEstadoaprobadaAmatriculada(identificacionEstudiante)
        CargarMateriasAprobadas(identificacionEstudiante)
        CargarMateriasPendientes(identificacionEstudiante)
        CargarMateriasMatriculadas(identificacionEstudiante)
        CargarCarreraEstudiante(identificacionEstudiante)
        txt_nota_obtenida.Clear()
    End Sub

    Private Sub btn_pend_apro_Click(sender As Object, e As EventArgs) Handles btn_pend_apro.Click
        Dim identificacionEstudiante As String = txt_identificacion.Text.Trim()
        CambiarEstadomatriculadaaprobada(identificacionEstudiante)
        CargarMateriasAprobadas(identificacionEstudiante)
        CargarMateriasPendientes(identificacionEstudiante)
        CargarMateriasMatriculadas(identificacionEstudiante)
        CargarCarreraEstudiante(identificacionEstudiante)
        txt_nota_obtenida.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim identificacionEstudiante As String = txt_identificacion.Text.Trim()
        CambiarEstadoaprobadapendiente(identificacionEstudiante)
        CargarMateriasAprobadas(identificacionEstudiante)
        CargarMateriasPendientes(identificacionEstudiante)
        CargarMateriasMatriculadas(identificacionEstudiante)
        CargarCarreraEstudiante(identificacionEstudiante)
        txt_nota_obtenida.Clear()
    End Sub

    Private Sub dgv_apro_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_apro.SelectionChanged
        ' Verificar que se haya seleccionado una fila
        If dgv_apro.SelectedRows.Count > 0 Then
            Dim idMateria As String = dgv_apro.SelectedRows(0).Cells("ID_Materia").Value.ToString()
            Dim identificacionEstudiante As String = txt_identificacion.Text ' O la variable que contiene la identificación del estudiante

            ' Obtener la nota de la base de datos
            Dim nota As String = ObtenerNotaMateria(identificacionEstudiante, idMateria)
            txt_nota_obtenida.Text = nota
        End If
    End Sub

    Private Function ObtenerNotaMateria(identificacionEstudiante As String, idMateria As String) As String
        Dim nota As String = "No disponible"
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT nota FROM estudiante_materia WHERE ident_estudiante = @ident_estudiante AND id_materia = @id_materia", conn)
            cmd.Parameters.AddWithValue("@ident_estudiante", identificacionEstudiante)
            cmd.Parameters.AddWithValue("@id_materia", idMateria)

            Dim result = cmd.ExecuteScalar()
            If result IsNot Nothing Then
                nota = result.ToString()
            End If
        Catch ex As Exception
            MessageBox.Show("Error al obtener la nota de la materia: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try

        Return nota
    End Function

    Private Sub dgv_apro_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_apro.CellClick
        lbl_materia_apro.Text = dgv_apro.CurrentRow.Cells(0).Value

    End Sub

    Private Sub dgv_pendie_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_pendie.CellClick
        lbl_materia_pendie.Text = dgv_pendie.CurrentRow.Cells(0).Value
    End Sub

    Private Sub dgv_matric_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_matric.CellClick
        lbl_materia_matric.Text = dgv_matric.CurrentRow.Cells(0).Value
    End Sub

    Private Sub lbl_materia_matric_Click(sender As Object, e As EventArgs) Handles lbl_materia_matric.Click

    End Sub

    Private Sub dgv_apro_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_apro.CellContentClick

    End Sub
End Class




