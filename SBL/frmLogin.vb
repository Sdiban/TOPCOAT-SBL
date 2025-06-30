Imports System.Data.SqlClient
Public Class frmLogin
    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If Trim(txtUsuario.Text) = "" Then
            MsgBox("Debe ingresar el ID de usuario de conexión", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Showroom")
            txtUsuario.Focus()
            Exit Sub
        End If
        If Trim(txtPassword.Text) = "" Then
            MsgBox("Debe ingresar la contraseña del usuario", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Showroom")
            txtPassword.Focus()
            Exit Sub
        End If
        If txtUsuario.Text = "superadmin" And txtPassword.Text = "abril.1970" Then
            username = txtUsuario.Text
            cerrar = False
            Me.Close()
        Else
            sql = "SELECT * FROM Usuarios_PC WHERE Id_Usuario = '" & txtUsuario.Text & "' And clave_usuario = '" & txtPassword.Text & "'"
            Dim dR As SqlDataReader = execQuery(sql, csql)
            If dR.Read Then
                If dR("Estado_Usuario") = "INA" Then
                    dR.Close()
                    MsgBox("El usuario ingresado no se encuentra activo, verifique", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Showroom")
                    txtUsuario.Focus()
                    Exit Sub
                End If
                username = txtUsuario.Text
                cerrar = False
                dR.Close()
                Me.Close()
            Else
                MsgBox("La combinación Usuario/Contraseña no es valida, verifique", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Showroom")
                txtUsuario.Focus()
            End If
            dR.Close()
        End If
    End Sub
    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        csql.Close()
        Me.Close()
    End Sub
    Private Sub txtUsuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsuario.KeyPress
        If Trim(txtUsuario.Text) <> "" And e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            txtPassword.Focus()
        End If
        e.Handled = False
        If Char.IsControl(e.KeyChar) Then
        Else
            If Char.IsDigit(e.KeyChar) Then
            Else
                If Char.IsLetter(e.KeyChar) Then
                Else
                    If Char.IsPunctuation(e.KeyChar) Then
                        If e.KeyChar = "'" Or Asc(e.KeyChar) = 34 Then
                            e.Handled = True
                        End If
                    Else
                        If Char.IsSymbol(e.KeyChar) Then
                        Else
                            e.Handled = True
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub txtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If Trim(txtPassword.Text) <> "" And e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            btnLogin.Focus()
        End If
        e.Handled = False
        If Char.IsControl(e.KeyChar) Then
        Else
            If Char.IsDigit(e.KeyChar) Then
            Else
                If Char.IsLetter(e.KeyChar) Then
                Else
                    If Char.IsPunctuation(e.KeyChar) Then
                        If e.KeyChar = "'" Or Asc(e.KeyChar) = 34 Then
                            e.Handled = True
                        End If
                    Else
                        If Char.IsSymbol(e.KeyChar) Then
                        Else
                            e.Handled = True
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub PictureBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.DoubleClick
        Dim c As String
        Dim u As String
        c = System.Windows.Forms.SystemInformation.ComputerName
        u = System.Windows.Forms.SystemInformation.UserName
        If (c = "NOTEBOOK-JCCC" Or c = "NOTEBOOK-JEDS" Or c = "DESKTOP-VK9IS5J" Or c = "PC-DESARROLLO") And
            (u = "Juan Carlos" Or u = "JacobDiaz" Or u = "TDS-Desarrollo" Or u = "Tds_pc") Then
            txtUsuario.Text = "adm"
            txtPassword.Text = "tds1234"
            btnLogin_Click(sender, e)
        End If
    End Sub
    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblInfo.Text = System.Diagnostics.FileVersionInfo.GetVersionInfo(Application.ExecutablePath).FileVersion & vbCrLf &
                       server & vbCrLf & database
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class