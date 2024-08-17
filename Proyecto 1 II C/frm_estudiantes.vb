Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Transactions
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class frm_estudiantes
    Dim conn As New MySqlConnection("server=localhost;userid=root;password='';database=db_proyecto")
    Private Sub CargarMateriasAprobadas(identificacionEstudiante As String)
        dgv_aprobadas.Rows.Clear()

        Try
            conn.Open()

            ' Modificar la consulta para excluir la materia con ID "Admitido"
            Dim cmd As New MySqlCommand("SELECT * FROM vista_estudiante_materia WHERE identificacion = @identificacion AND Estado = 1 AND `ID Materia` != 'Admitido'", conn)
            cmd.Parameters.AddWithValue("@identificacion", identificacionEstudiante)
            Dim dr = cmd.ExecuteReader()

            While dr.Read()
                dgv_aprobadas.Rows.Add(dr("ID Materia"), dr("Nombre materia"))
            End While

            dr.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar materias aprobadas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub CargarMateriasPendientes(identificacionEstudiante As String)
        dgv_pendientes.Rows.Clear()

        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM vista_estudiante_materia WHERE identificacion = @identificacion AND Estado = 3", conn)
            cmd.Parameters.AddWithValue("@identificacion", identificacionEstudiante)
            Dim dr = cmd.ExecuteReader()

            While dr.Read()
                dgv_pendientes.Rows.Add(dr("ID Materia"), dr("Nombre materia"))
            End While

            dr.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar materias pendientes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub CargarMateriasMatriculadas(identificacionEstudiante As String)
        dgv_matriculadas.Rows.Clear()

        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM vista_estudiante_materia WHERE identificacion = @identificacion AND Estado = 2", conn)
            cmd.Parameters.AddWithValue("@identificacion", identificacionEstudiante)
            Dim dr = cmd.ExecuteReader()

            While dr.Read()
                dgv_matriculadas.Rows.Add(dr("ID Materia"), dr("Nombre materia"))
            End While

            dr.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar materias matriculadas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub MostrarPorcentaje()
        Dim totalMaterias As Integer = 0
        Dim totalAprobadas As Integer = 0

        ' Contar las materias en dgv_apro excluyendo la materia con ID 'admitido'
        For Each row As DataGridViewRow In dgv_aprobadas.Rows
            If row.Cells("ID_Materia").Value.ToString() <> "Admitido" Then
                totalAprobadas += 1
            End If
        Next

        ' Contar las materias en dgv_pend y dgv_matri
        totalMaterias += dgv_matriculadas.Rows.Count + dgv_pendientes.Rows.Count + totalAprobadas

        If totalMaterias > 0 Then
            Dim porcentajeAprobadas As Double = (totalAprobadas / totalMaterias) * 100
            pb_aprobada.Value = Convert.ToInt32(porcentajeAprobadas)
        Else
            pb_aprobada.Value = 0
        End If
    End Sub
    Private Sub MostrarPorcentajeGanado()
        Dim totalPendientesYMatriculadas As Integer = dgv_matriculadas.Rows.Count + dgv_pendientes.Rows.Count
        Dim totalAprobadas As Integer = 0

        ' Contar las materias en dgv_apro excluyendo la materia con ID 'admitido'
        For Each row As DataGridViewRow In dgv_aprobadas.Rows
            If row.Cells("ID_Materia").Value.ToString() <> "Admitido" Then
                totalAprobadas += 1
            End If
        Next

        If totalPendientesYMatriculadas > 0 Then
            Dim porcentajeGanado As Double = (totalAprobadas / totalPendientesYMatriculadas) * 100
            lbl_porcent_apro.Text = porcentajeGanado.ToString("0.00") & "%"
        Else
            lbl_porcent_apro.Text = "0%"
        End If
    End Sub
    Private Sub Cargarnombreestudiante(identificacionEstudiante As String)

        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM vista_estudiante_materia WHERE identificacion = @identificacion", conn)
            cmd.Parameters.AddWithValue("@identificacion", identificacionEstudiante)
            Dim dr = cmd.ExecuteReader()

            While dr.Read()
                txt_estudiante.Text = dr("Nombre estudiante")
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
                txt_nombrecarrera.Text = carrera
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

    Private Sub dgv_aprobadas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_aprobadas.CellContentClick

    End Sub

    Private Sub dgv_pendientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_matriculadas.CellContentClick

    End Sub

    Private Sub btn_busc_Click(sender As Object, e As EventArgs) Handles btn_busc.Click

        Dim identificacionEstudiante As String = txt_ident.Text.Trim()

        ' Llamar a los métodos para cargar los DataGridView según el estado de las materias
        CargarMateriasAprobadas(identificacionEstudiante)
        CargarMateriasPendientes(identificacionEstudiante)
        CargarMateriasMatriculadas(identificacionEstudiante)
        MostrarPorcentaje()
        MostrarPorcentajeGanado()
        Cargarnombreestudiante(identificacionEstudiante)
        CargarCarreraEstudiante(identificacionEstudiante)




    End Sub
End Class