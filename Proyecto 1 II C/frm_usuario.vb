Imports System.Runtime.InteropServices
Imports System.Reflection.PortableExecutable
Imports System.Diagnostics.CodeAnalysis
Imports Mysqlx.Cursor
Imports MySql.Data.MySqlClient
Imports System.Text


Public Class frm_usuario

    <DllImport("user32.Dll", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()

    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub sendMessage(ByVal hwnd As System.IntPtr, ByVal wmsg As Integer, ByVal wparam As Integer, ByVal lparm As Integer)
    End Sub

    Dim conn As New MySqlConnection("server=localhost;userid=root;password='';database=db_proyecto")
    Dim i As Integer
    Dim dr As MySqlDataAdapter


    Private Sub frm_usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txt_contraseña.Text = "Contraseña"
        txt_usuario.Text = "Usuario"
        btn_restaurar.Visible = False



        'Aqui nos conectamos a la base de datos
        Try
            conn.Open()

            MessageBox.Show("Conectado con el servidor")

            conn.Close()



        Catch ex As Exception

        End Try

    End Sub


    Private Sub btn_ingresar_Click(sender As Object, e As EventArgs) Handles btn_ingresar.Click
        'Aqui validamos los campos escritos y encriptamos la contrasena escrita a ver si coincide

        Dim contraseña = encrypt(txt_contraseña.Text)

        Dim nombre = txt_usuario.Text

        ingresar(nombre, contraseña)

        If txt_usuario.Text = "" Then

            txt_usuario.Text = "Usuario"

        End If

        If txt_contraseña.Text = "" Then
            txt_contraseña.PasswordChar = ""
            txt_contraseña.Text = "Contraseña"

        End If

    End Sub
    Public Function encrypt(encryptation As String) As String
        'Aqui encriptamos la contrasena

        Dim msg As String = String.Empty

        Dim encode As Byte() = New Byte(encryptation.Length - 1) {}

        encode = Encoding.UTF8.GetBytes(encryptation)

        msg = Convert.ToBase64String(encode)

        Return msg

    End Function
    Sub ingresar(nombre As String, contraseña As String)
        'Aqui nos conectamos a la base de datos para validar la informacion de nombre y contrasena
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM usuario WHERE nombre=@nombre and contraseña=@contraseña", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.Parameters.AddWithValue("@contraseña", contraseña)
            Dim i As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If (i > 0) Then
                MessageBox.Show("Datos correctos")
                conn.Close()

                Me.Hide()

                txt_contraseña.Clear()
                txt_usuario.Clear()

                frm_menu.Show()
            Else
                MessageBox.Show("Usuario o contraseña incorrecta")
                conn.Close()
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        'Salir del programa
        Me.Close()

    End Sub

    Private Sub txt_usuario_click(sender As Object, e As EventArgs) Handles txt_usuario.Click
        'Aqui reestablecemos los valores fijos de los datos de login
        If txt_usuario.Text = "Usuario" Then
            txt_usuario.Text = ""
        End If

        If txt_contraseña.Text = "" Then
            txt_contraseña.PasswordChar = ""
            txt_contraseña.Text = "Contraseña"

        End If
    End Sub

    Private Sub txt_contraseña_click(sender As Object, e As EventArgs) Handles txt_contraseña.Click
        'Aqui reestablecemos los valores fijos de los datos de login con la contrasena en *
        If txt_contraseña.Text = "Contraseña" Then
            txt_contraseña.Text = ""
            txt_contraseña.PasswordChar = "*"
        End If



        If txt_usuario.Text = "" Then

            txt_usuario.Text = "Usuario"

        End If
    End Sub
    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click

        Me.Close()


    End Sub
    Private Sub btn_restaurar_Click(sender As Object, e As EventArgs) Handles btn_restaurar.Click

        btn_restaurar.Visible = False
        btn_maximizar.Visible = True
        Me.WindowState = FormWindowState.Normal

    End Sub
    Private Sub btn_maximizar_Click(sender As Object, e As EventArgs) Handles btn_maximizar.Click

        btn_maximizar.Visible = False
        btn_restaurar.Visible = True
        Me.WindowState = FormWindowState.Maximized

    End Sub
    Private Sub btn_minimizar_Click(sender As Object, e As EventArgs) Handles btn_minimizar.Click

        Me.WindowState = FormWindowState.Minimized

    End Sub


End Class
