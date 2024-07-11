Imports System.Runtime.InteropServices
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class frm_menu
    Private Sub frm_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btn_restaurar.Visible = False

    End Sub
    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click

        Me.Hide()
        frm_usuario.Close()

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
    Private Sub btn_salir_Click(sender As Object, e As EventArgs)

        Hide()

        frm_usuario.Show()

    End Sub

    Private formActual As Form = Nothing


    Private Sub abrirformhijo(formhijo As Form)
        If formActual IsNot Nothing Then formActual.Close()
        formActual = formhijo
        formhijo.TopLevel = False
        formhijo.FormBorderStyle = FormBorderStyle.None
        formhijo.Dock = DockStyle.Fill
        panel_contenedor.Controls.Add(formhijo)
        panel_contenedor.Tag = formhijo
        formhijo.BringToFront()
        formhijo.Show()

    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        abrirformhijo(New frm_agregar)
    End Sub

    Private Sub btn_asignar_Click(sender As Object, e As EventArgs) Handles btn_asignar.Click
        abrirformhijo(New frm_asiganr)
    End Sub
End Class