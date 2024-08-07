﻿Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Transactions
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class frm_agregar

    Dim conn As New MySqlConnection("server=localhost;userid=root;password='';database=db_proyecto")
    Dim i As Integer
    Dim dr As MySqlDataAdapter

    Dim errorProvider As New ErrorProvider()

    Private Sub frm_agregar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cargarestudiantes()
    End Sub

    Sub cargarestudiantes()

        DataGridView1.Rows.Clear()

        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM db_proyecto.vista_estudiante", conn)
            Dim dr = cmd.ExecuteReader
            While dr.Read
                Dim carreraTexto As String = Convertircarrera(CInt(dr("Carrera")))
                DataGridView1.Rows.Add(dr.Item("ID"), dr.Item("Nombre"), dr.Item("Identificacion"), dr.Item("Correo"), dr.Item("Fecha de ingreso"), carreraTexto)
            End While
            dr.DisposeAsync()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Sub cargarmaterias()
        DataGridView2.Rows.Clear()

        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM db_proyecto.vista_carrera_materia WHERE carrera = @carrera", conn)
            cmd.Parameters.AddWithValue("@carrera", cbx_carrera.SelectedIndex + 1) ' Se suma 1 porque los índices de las carreras en la base de datos comienzan desde 1
            Dim dr = cmd.ExecuteReader

            While dr.Read
                Dim carreraTexto As String = Convertircarrera(CInt(dr("Carrera")))
                DataGridView2.Rows.Add(carreraTexto, dr.Item("Materia"), dr.Item("Codigo"), dr.Item("Creditos"), dr.Item("Requisito"), dr.Item("Nombre requisito"))
            End While

            dr.DisposeAsync()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

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

    Sub agregarEstudiante()

        Dim fechahoraactual As DateTime = DateTime.Now
        Dim fechaFormateada As String = fechahoraactual.ToString("yyyy/MM/dd HH:mm:ss")
        txt_fecha_ingreso.Text = fechaFormateada

        DataGridView1.Rows.Clear()
        Dim opcionSeleccionada As Integer
        Select Case cbx_carrera.SelectedIndex
            Case 0 ' Ingeniería Industrial
                opcionSeleccionada = 1
            Case 1 ' Ingeniería de Sistemas
                opcionSeleccionada = 2
            Case 2 ' Administración de Negocios
                opcionSeleccionada = 3
            Case 3 ' Contaduría 
                opcionSeleccionada = 4
        End Select

        Dim transaction As MySqlTransaction = Nothing

        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            transaction = conn.BeginTransaction()

            Dim cmd As New MySqlCommand("INSERT INTO estudiante (nombre_apellidos, identificacion, correo, fecha_ingreso, carrera) 
                                    VALUES (@nombre_apellidos, @identificacion, @correo, @fecha_ingreso, @carrera); SELECT LAST_INSERT_ID();", conn)
            cmd.Transaction = transaction
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@nombre_apellidos", txt_nombre.Text)
            cmd.Parameters.AddWithValue("@identificacion", txt_identificacion.Text)
            cmd.Parameters.AddWithValue("@correo", txt_correo.Text)
            cmd.Parameters.AddWithValue("@fecha_ingreso", txt_fecha_ingreso.Text)
            cmd.Parameters.AddWithValue("@carrera", opcionSeleccionada)

            Dim idEstudiante As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            For Each row As DataGridViewRow In DataGridView2.Rows
                If Not row.IsNewRow Then
                    Dim cmdMaterias As New MySqlCommand("INSERT INTO estudiante_materia (ident_estudiante, id_materia, estado, nota) 
                                                    VALUES (@ident_estudiante, @id_materia, @estado, @nota)", conn)
                    cmdMaterias.Transaction = transaction
                    cmdMaterias.Parameters.Clear()
                    cmdMaterias.Parameters.AddWithValue("@ident_estudiante", txt_identificacion.Text)
                    cmdMaterias.Parameters.AddWithValue("@id_materia", row.Cells("Codigo").Value)
                    cmdMaterias.Parameters.AddWithValue("@estado", 3)
                    cmdMaterias.Parameters.AddWithValue("@nota", 0)
                    cmdMaterias.ExecuteNonQuery()
                End If
            Next

            transaction.Commit()

            MessageBox.Show("Estudiante agregado", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DataGridView1.Rows.Clear()
            conn.Close()
            cargarestudiantes()
            cargarmaterias()
            LimpiarCampos()
        Catch ex As Exception
            MsgBox(ex.Message)
            If transaction IsNot Nothing Then
                Try
                    transaction.Rollback()
                Catch ex2 As Exception
                    MsgBox("Error" & ex2.Message)
                End Try
            End If
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub



    Sub editarestudiante()

        DataGridView1.Rows.Clear()
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

        Dim transaction As MySqlTransaction = Nothing

        Try
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
                conn.Open()
                Transaction = conn.BeginTransaction()

                Dim cmd As New MySqlCommand("UPDATE estudiante SET nombre_apellidos=@nombre_apellidos, identificacion=@identificacion, correo=@correo, fecha_ingreso=@fecha_ingreso, carrera=@carrera WHERE id= @id", conn)

                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@nombre_apellidos", txt_nombre.Text)
                cmd.Parameters.AddWithValue("@identificacion", txt_identificacion.Text)
                cmd.Parameters.AddWithValue("@correo", txt_correo.Text)
                cmd.Parameters.AddWithValue("@fecha_ingreso", txt_fecha_ingreso.Text)
                cmd.Parameters.AddWithValue("@carrera", opcionSeleccionada)
                cmd.Parameters.AddWithValue("@id", lbl_id.Text)

            Dim i = cmd.ExecuteNonQuery

            conn.Close()

            Try
                conn.Open()
                Dim cmd1 As New MySqlCommand("DELETE FROM estudiante_materia WHERE ident_estudiante=@ident_estudiante;", conn)
                cmd1.Parameters.AddWithValue("@ident_estudiante", txt_identificacion.Text)

                Dim o = cmd1.ExecuteNonQuery()

                If o > 0 Then
                    DataGridView1.Rows.Clear()
                End If
            Catch ex As Exception
            Finally
                conn.Close()
            End Try

            conn.Open()
            Dim idEstudiante As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                For Each row As DataGridViewRow In DataGridView2.Rows
                    If Not row.IsNewRow Then
                        Dim cmdMaterias As New MySqlCommand("INSERT INTO estudiante_materia (ident_estudiante, id_materia, estado, nota) 
                                                    VALUES (@ident_estudiante, @id_materia, @estado, @nota)", conn)
                        cmdMaterias.Transaction = Transaction
                        cmdMaterias.Parameters.Clear()
                        cmdMaterias.Parameters.AddWithValue("@ident_estudiante", txt_identificacion.Text)
                        cmdMaterias.Parameters.AddWithValue("@id_materia", row.Cells("Codigo").Value)
                        cmdMaterias.Parameters.AddWithValue("@estado", 3)
                        cmdMaterias.Parameters.AddWithValue("@nota", 0)
                        cmdMaterias.ExecuteNonQuery()
                    End If
                Next

            transaction.Commit()
            MessageBox.Show("Estudiante modificado", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DataGridView1.Rows.Clear()
                conn.Close()
                cargarestudiantes()
                cargarmaterias()
                LimpiarCampos()
            Catch ex As Exception
                MsgBox(ex.Message)
                If Transaction IsNot Nothing Then
                    Try
                        Transaction.Rollback()
                    Catch ex2 As Exception
                        MsgBox("Error" & ex2.Message)
                    End Try
                End If
            Finally
                If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try

    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click

        editarestudiante()
        LimpiarCampos()
        cargarestudiantes()

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
                    DataGridView1.Rows.Clear()
                End If
            Catch ex As Exception
                MsgBox("Error al eliminar el estudiante: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End If

    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        lbl_id.Text = DataGridView1.CurrentRow.Cells(0).Value
        txt_nombre.Text = DataGridView1.CurrentRow.Cells(1).Value
        txt_identificacion.Text = DataGridView1.CurrentRow.Cells(2).Value
        txt_correo.Text = DataGridView1.CurrentRow.Cells(3).Value
        txt_fecha_ingreso.Text = DataGridView1.CurrentRow.Cells(4).Value
        cbx_carrera.Text = DataGridView1.CurrentRow.Cells(5).Value
    End Sub
    Sub LimpiarCampos()

        txt_nombre.Clear()
        txt_identificacion.Clear()
        txt_correo.Clear()
        txt_fecha_ingreso.Clear()
        lbl_id.Text = "0"

    End Sub

    Private Sub btn_añadir_Click(sender As Object, e As EventArgs) Handles btn_añadir.Click

        agregarEstudiante()

    End Sub
    Private Sub cbx_carrera_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_carrera.SelectedIndexChanged
        cargarmaterias()
    End Sub
End Class
